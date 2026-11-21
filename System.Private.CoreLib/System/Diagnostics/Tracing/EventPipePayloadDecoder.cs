using System;
using System.Buffers.Binary;
using System.Reflection;
using System.Runtime.InteropServices;

namespace System.Diagnostics.Tracing
{
	// Token: 0x020008DF RID: 2271
	internal static class EventPipePayloadDecoder
	{
		// Token: 0x06008BAA RID: 35754 RVA: 0x001520F4 File Offset: 0x001502F4
		internal unsafe static object[] DecodePayload(ref EventSource.EventMetadata metadata, ReadOnlySpan<byte> payload)
		{
			ParameterInfo[] parameters = metadata.Parameters;
			object[] array = new object[parameters.Length];
			int num = 0;
			while (num < parameters.Length && payload.Length > 0)
			{
				Type parameterType = parameters[num].ParameterType;
				Type left = parameterType.IsEnum ? Enum.GetUnderlyingType(parameterType) : null;
				if (parameterType == typeof(IntPtr))
				{
					array[num] = BinaryPrimitives.ReadIntPtrLittleEndian(payload);
					payload = payload.Slice(8);
				}
				else if (parameterType == typeof(int) || left == typeof(int))
				{
					array[num] = BinaryPrimitives.ReadInt32LittleEndian(payload);
					payload = payload.Slice(4);
				}
				else if (parameterType == typeof(uint) || left == typeof(uint))
				{
					array[num] = BinaryPrimitives.ReadUInt32LittleEndian(payload);
					payload = payload.Slice(4);
				}
				else if (parameterType == typeof(long) || left == typeof(long))
				{
					array[num] = BinaryPrimitives.ReadInt64LittleEndian(payload);
					payload = payload.Slice(8);
				}
				else if (parameterType == typeof(ulong) || left == typeof(ulong))
				{
					array[num] = BinaryPrimitives.ReadUInt64LittleEndian(payload);
					payload = payload.Slice(8);
				}
				else if (parameterType == typeof(byte) || left == typeof(byte))
				{
					array[num] = MemoryMarshal.Read<byte>(payload);
					payload = payload.Slice(1);
				}
				else if (parameterType == typeof(sbyte) || left == typeof(sbyte))
				{
					array[num] = MemoryMarshal.Read<sbyte>(payload);
					payload = payload.Slice(1);
				}
				else if (parameterType == typeof(short) || left == typeof(short))
				{
					array[num] = BinaryPrimitives.ReadInt16LittleEndian(payload);
					payload = payload.Slice(2);
				}
				else if (parameterType == typeof(ushort) || left == typeof(ushort))
				{
					array[num] = BinaryPrimitives.ReadUInt16LittleEndian(payload);
					payload = payload.Slice(2);
				}
				else if (parameterType == typeof(float))
				{
					array[num] = BinaryPrimitives.ReadSingleLittleEndian(payload);
					payload = payload.Slice(4);
				}
				else if (parameterType == typeof(double))
				{
					array[num] = BinaryPrimitives.ReadDoubleLittleEndian(payload);
					payload = payload.Slice(8);
				}
				else if (parameterType == typeof(bool))
				{
					array[num] = (BinaryPrimitives.ReadInt32LittleEndian(payload) == 1);
					payload = payload.Slice(4);
				}
				else if (parameterType == typeof(Guid))
				{
					array[num] = new Guid(payload.Slice(0, 16));
					payload = payload.Slice(16);
				}
				else if (parameterType == typeof(char))
				{
					array[num] = (char)BinaryPrimitives.ReadUInt16LittleEndian(payload);
					payload = payload.Slice(2);
				}
				else if (parameterType == typeof(string))
				{
					int num2 = -1;
					for (int i = 1; i < payload.Length; i += 2)
					{
						if (*payload[i - 1] == 0 && *payload[i] == 0)
						{
							num2 = i + 1;
							break;
						}
					}
					ReadOnlySpan<char> value;
					if (num2 < 0)
					{
						value = MemoryMarshal.Cast<byte, char>(payload);
						payload = default(ReadOnlySpan<byte>);
					}
					else
					{
						value = MemoryMarshal.Cast<byte, char>(payload.Slice(0, num2 - 2));
						payload = payload.Slice(num2);
					}
					object[] array2 = array;
					int num3 = num;
					if (!BitConverter.IsLittleEndian)
					{
					}
					array2[num3] = new string(value);
				}
				num++;
			}
			return array;
		}
	}
}
