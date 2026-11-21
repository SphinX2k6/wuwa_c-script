using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace System.Diagnostics.Tracing
{
	// Token: 0x020008DD RID: 2269
	internal sealed class EventPipeMetadataGenerator
	{
		// Token: 0x06008B96 RID: 35734 RVA: 0x00005ACC File Offset: 0x00003CCC
		private EventPipeMetadataGenerator()
		{
		}

		// Token: 0x06008B97 RID: 35735 RVA: 0x0015151C File Offset: 0x0014F71C
		public byte[] GenerateEventMetadata(EventSource.EventMetadata eventMetadata)
		{
			ParameterInfo[] parameters = eventMetadata.Parameters;
			EventParameterInfo[] array = new EventParameterInfo[parameters.Length];
			for (int i = 0; i < parameters.Length; i++)
			{
				TraceLoggingTypeInfo typeInfo;
				EventParameterInfo.GetTypeInfoFromType(parameters[i].ParameterType, out typeInfo);
				array[i].SetInfo(parameters[i].Name, parameters[i].ParameterType, typeInfo);
			}
			return this.GenerateMetadata(eventMetadata.Descriptor.EventId, eventMetadata.Name, eventMetadata.Descriptor.Keywords, (uint)eventMetadata.Descriptor.Level, (uint)eventMetadata.Descriptor.Version, (EventOpcode)eventMetadata.Descriptor.Opcode, array);
		}

		// Token: 0x06008B98 RID: 35736 RVA: 0x001515C0 File Offset: 0x0014F7C0
		public byte[] GenerateEventMetadata(int eventId, string eventName, EventKeywords keywords, EventLevel level, uint version, EventOpcode opcode, TraceLoggingEventTypes eventTypes)
		{
			TraceLoggingTypeInfo[] typeInfos = eventTypes.typeInfos;
			string[] paramNames = eventTypes.paramNames;
			EventParameterInfo[] array = new EventParameterInfo[typeInfos.Length];
			for (int i = 0; i < typeInfos.Length; i++)
			{
				string name = string.Empty;
				if (paramNames != null)
				{
					name = paramNames[i];
				}
				array[i].SetInfo(name, typeInfos[i].DataType, typeInfos[i]);
			}
			return this.GenerateMetadata(eventId, eventName, (long)keywords, (uint)level, version, opcode, array);
		}

		// Token: 0x06008B99 RID: 35737 RVA: 0x0015162C File Offset: 0x0014F82C
		internal unsafe byte[] GenerateMetadata(int eventId, string eventName, long keywords, uint level, uint version, EventOpcode opcode, EventParameterInfo[] parameters)
		{
			byte[] array = null;
			bool flag = false;
			try
			{
				uint num = (uint)(24 + (eventName.Length + 1) * 2);
				uint num2 = 0U;
				uint num3 = num;
				if (parameters.Length == 1 && parameters[0].ParameterType == typeof(EmptyStruct))
				{
					parameters = Array.Empty<EventParameterInfo>();
				}
				foreach (EventParameterInfo eventParameterInfo in parameters)
				{
					uint num4;
					if (!eventParameterInfo.GetMetadataLength(out num4))
					{
						flag = true;
						break;
					}
					num += num4;
				}
				if (flag)
				{
					num = num3;
					num2 = 4U;
					foreach (EventParameterInfo eventParameterInfo2 in parameters)
					{
						uint num5;
						if (!eventParameterInfo2.GetMetadataLengthV2(out num5))
						{
							parameters = Array.Empty<EventParameterInfo>();
							num = num3;
							num2 = 0U;
							flag = false;
							break;
						}
						num2 += num5;
					}
				}
				uint num6 = (opcode == EventOpcode.Info) ? 0U : 6U;
				uint num7 = ((num2 == 0U) ? 0U : (num2 + 5U)) + num6;
				uint num8 = num + num7;
				array = new byte[num8];
				try
				{
					byte[] array3;
					byte* ptr;
					if ((array3 = array) == null || array3.Length == 0)
					{
						ptr = null;
					}
					else
					{
						ptr = &array3[0];
					}
					uint num9 = 0U;
					EventPipeMetadataGenerator.WriteToBuffer<uint>(ptr, num8, ref num9, (uint)eventId);
					try
					{
						char* ptr2;
						if (eventName == null)
						{
							ptr2 = null;
						}
						else
						{
							fixed (char* ptr3 = eventName.GetPinnableReference())
							{
								ptr2 = ptr3;
							}
						}
						char* src = ptr2;
						EventPipeMetadataGenerator.WriteToBuffer(ptr, num8, ref num9, (byte*)src, (uint)((eventName.Length + 1) * 2));
					}
					finally
					{
						char* ptr3 = null;
					}
					EventPipeMetadataGenerator.WriteToBuffer<long>(ptr, num8, ref num9, keywords);
					EventPipeMetadataGenerator.WriteToBuffer<uint>(ptr, num8, ref num9, version);
					EventPipeMetadataGenerator.WriteToBuffer<uint>(ptr, num8, ref num9, level);
					if (flag)
					{
						EventPipeMetadataGenerator.WriteToBuffer<int>(ptr, num8, ref num9, 0);
					}
					else
					{
						EventPipeMetadataGenerator.WriteToBuffer<uint>(ptr, num8, ref num9, (uint)parameters.Length);
						foreach (EventParameterInfo eventParameterInfo3 in parameters)
						{
							if (!eventParameterInfo3.GenerateMetadata(ptr, ref num9, num8))
							{
								return this.GenerateMetadata(eventId, eventName, keywords, level, version, opcode, Array.Empty<EventParameterInfo>());
							}
						}
					}
					if (opcode != EventOpcode.Info)
					{
						EventPipeMetadataGenerator.WriteToBuffer<int>(ptr, num8, ref num9, 1);
						EventPipeMetadataGenerator.WriteToBuffer<byte>(ptr, num8, ref num9, 1);
						EventPipeMetadataGenerator.WriteToBuffer<byte>(ptr, num8, ref num9, (byte)opcode);
					}
					if (flag)
					{
						EventPipeMetadataGenerator.WriteToBuffer<uint>(ptr, num8, ref num9, num2);
						EventPipeMetadataGenerator.WriteToBuffer<byte>(ptr, num8, ref num9, 2);
						EventPipeMetadataGenerator.WriteToBuffer<uint>(ptr, num8, ref num9, (uint)parameters.Length);
						foreach (EventParameterInfo eventParameterInfo4 in parameters)
						{
							if (!eventParameterInfo4.GenerateMetadataV2(ptr, ref num9, num8))
							{
								return this.GenerateMetadata(eventId, eventName, keywords, level, version, opcode, Array.Empty<EventParameterInfo>());
							}
						}
					}
				}
				finally
				{
					byte[] array3 = null;
				}
			}
			catch
			{
				array = null;
			}
			return array;
		}

		// Token: 0x06008B9A RID: 35738 RVA: 0x0015190C File Offset: 0x0014FB0C
		internal unsafe static void WriteToBuffer(byte* buffer, uint bufferLength, ref uint offset, byte* src, uint srcLength)
		{
			int num = 0;
			while ((long)num < (long)((ulong)srcLength))
			{
				(buffer + offset)[num] = src[num];
				num++;
			}
			offset += srcLength;
		}

		// Token: 0x06008B9B RID: 35739 RVA: 0x0015193B File Offset: 0x0014FB3B
		internal unsafe static void WriteToBuffer<[IsUnmanaged] T>(byte* buffer, uint bufferLength, ref uint offset, T value) where T : struct, ValueType
		{
			*(T*)(buffer + offset) = value;
			offset += (uint)sizeof(T);
		}

		// Token: 0x04001F81 RID: 8065
		public static readonly EventPipeMetadataGenerator Instance = new EventPipeMetadataGenerator();
	}
}
