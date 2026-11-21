using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Numerics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Text;

namespace System.Diagnostics.Tracing
{
	// Token: 0x02000901 RID: 2305
	internal sealed class ManifestBuilder
	{
		// Token: 0x06008CF1 RID: 36081 RVA: 0x00159878 File Offset: 0x00157A78
		public ManifestBuilder(string providerName, Guid providerGuid, string dllName, ResourceManager resources, EventManifestOptions flags) : this(resources, flags)
		{
			this.providerName = providerName;
			this.sb = new StringBuilder();
			this.events = new StringBuilder();
			this.templates = new StringBuilder();
			this.sb.AppendLine("<instrumentationManifest xmlns=\"http://schemas.microsoft.com/win/2004/08/events\">");
			this.sb.AppendLine(" <instrumentation xmlns:xs=\"http://www.w3.org/2001/XMLSchema\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:win=\"http://manifests.microsoft.com/win/2004/08/windows/events\">");
			this.sb.AppendLine("  <events xmlns=\"http://schemas.microsoft.com/win/2004/08/events\">");
			StringBuilder stringBuilder = this.sb;
			StringBuilder stringBuilder2 = stringBuilder;
			StringBuilder.AppendInterpolatedStringHandler appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(27, 2, stringBuilder);
			appendInterpolatedStringHandler.AppendLiteral("<provider name=\"");
			appendInterpolatedStringHandler.AppendFormatted(providerName);
			appendInterpolatedStringHandler.AppendLiteral("\" guid=\"{");
			appendInterpolatedStringHandler.AppendFormatted<Guid>(providerGuid);
			appendInterpolatedStringHandler.AppendLiteral("}\"");
			stringBuilder2.Append(ref appendInterpolatedStringHandler);
			if (dllName != null)
			{
				stringBuilder = this.sb;
				StringBuilder stringBuilder3 = stringBuilder;
				appendInterpolatedStringHandler = new StringBuilder.AppendInterpolatedStringHandler(39, 2, stringBuilder);
				appendInterpolatedStringHandler.AppendLiteral(" resourceFileName=\"");
				appendInterpolatedStringHandler.AppendFormatted(dllName);
				appendInterpolatedStringHandler.AppendLiteral("\" messageFileName=\"");
				appendInterpolatedStringHandler.AppendFormatted(dllName);
				appendInterpolatedStringHandler.AppendLiteral("\"");
				stringBuilder3.Append(ref appendInterpolatedStringHandler);
			}
			this.sb.Append(" symbol=\"");
			int length = this.sb.Length;
			this.sb.Append(providerName);
			this.sb.Replace('.', '_', length, this.sb.Length - length).Replace("-", "", length, this.sb.Length - length);
			this.sb.AppendLine("\">");
		}

		// Token: 0x06008CF2 RID: 36082 RVA: 0x00159A04 File Offset: 0x00157C04
		internal ManifestBuilder(ResourceManager resources, EventManifestOptions flags)
		{
			this.providerName = "";
			this.flags = flags;
			this.resources = resources;
			this.sb = null;
			this.events = null;
			this.templates = null;
			this.opcodeTab = new Dictionary<int, string>();
			this.stringTab = new Dictionary<string, string>();
			this.errors = new List<string>();
			this.perEventByteArrayArgIndices = new Dictionary<string, List<int>>();
		}

		// Token: 0x06008CF3 RID: 36083 RVA: 0x00159A80 File Offset: 0x00157C80
		public void AddOpcode(string name, int value)
		{
			if ((this.flags & EventManifestOptions.Strict) != EventManifestOptions.None)
			{
				if (value <= 10 || value >= 239)
				{
					this.ManifestError(SR.Format(SR.EventSource_IllegalOpcodeValue, name, value), false);
				}
				string text;
				if (this.opcodeTab.TryGetValue(value, out text) && !name.Equals(text, StringComparison.Ordinal))
				{
					this.ManifestError(SR.Format(SR.EventSource_OpcodeCollision, name, text, value), false);
				}
			}
			this.opcodeTab[value] = name;
		}

		// Token: 0x06008CF4 RID: 36084 RVA: 0x00159AFC File Offset: 0x00157CFC
		public void AddTask(string name, int value)
		{
			if ((this.flags & EventManifestOptions.Strict) != EventManifestOptions.None)
			{
				if (value <= 0 || value >= 65535)
				{
					this.ManifestError(SR.Format(SR.EventSource_IllegalTaskValue, name, value), false);
				}
				string text;
				if (this.taskTab != null && this.taskTab.TryGetValue(value, out text) && !name.Equals(text, StringComparison.Ordinal))
				{
					this.ManifestError(SR.Format(SR.EventSource_TaskCollision, name, text, value), false);
				}
			}
			if (this.taskTab == null)
			{
				this.taskTab = new Dictionary<int, string>();
			}
			this.taskTab[value] = name;
		}

		// Token: 0x06008CF5 RID: 36085 RVA: 0x00159B94 File Offset: 0x00157D94
		public void AddKeyword(string name, ulong value)
		{
			if ((value & value - 1UL) != 0UL)
			{
				string eventSource_KeywordNeedPowerOfTwo = SR.EventSource_KeywordNeedPowerOfTwo;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 1);
				defaultInterpolatedStringHandler.AppendLiteral("0x");
				defaultInterpolatedStringHandler.AppendFormatted<ulong>(value, "x");
				this.ManifestError(SR.Format(eventSource_KeywordNeedPowerOfTwo, defaultInterpolatedStringHandler.ToStringAndClear(), name), true);
			}
			if ((this.flags & EventManifestOptions.Strict) != EventManifestOptions.None)
			{
				if (value >= 17592186044416UL && !name.StartsWith("Session", StringComparison.Ordinal))
				{
					string eventSource_IllegalKeywordsValue = SR.EventSource_IllegalKeywordsValue;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 1);
					defaultInterpolatedStringHandler.AppendLiteral("0x");
					defaultInterpolatedStringHandler.AppendFormatted<ulong>(value, "x");
					this.ManifestError(SR.Format(eventSource_IllegalKeywordsValue, name, defaultInterpolatedStringHandler.ToStringAndClear()), false);
				}
				string text;
				if (this.keywordTab != null && this.keywordTab.TryGetValue(value, out text) && !name.Equals(text, StringComparison.Ordinal))
				{
					string eventSource_KeywordCollision = SR.EventSource_KeywordCollision;
					object p = text;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 1);
					defaultInterpolatedStringHandler.AppendLiteral("0x");
					defaultInterpolatedStringHandler.AppendFormatted<ulong>(value, "x");
					this.ManifestError(SR.Format(eventSource_KeywordCollision, name, p, defaultInterpolatedStringHandler.ToStringAndClear()), false);
				}
			}
			if (this.keywordTab == null)
			{
				this.keywordTab = new Dictionary<ulong, string>();
			}
			this.keywordTab[value] = name;
		}

		// Token: 0x06008CF6 RID: 36086 RVA: 0x00159CC4 File Offset: 0x00157EC4
		public void AddChannel(string name, int value, EventChannelAttribute channelAttribute)
		{
			EventChannel eventChannel = (EventChannel)value;
			if (value < 16 || value > 255)
			{
				this.ManifestError(SR.Format(SR.EventSource_EventChannelOutOfRange, name, value), false);
			}
			else if (eventChannel >= EventChannel.Admin && eventChannel <= EventChannel.Debug && channelAttribute != null && ManifestBuilder.EventChannelToChannelType(eventChannel) != channelAttribute.EventChannelType)
			{
				this.ManifestError(SR.Format(SR.EventSource_ChannelTypeDoesNotMatchEventChannelValue, name, ((EventChannel)value).ToString()), false);
			}
			ulong channelKeyword = this.GetChannelKeyword(eventChannel, 0UL);
			if (this.channelTab == null)
			{
				this.channelTab = new Dictionary<int, ManifestBuilder.ChannelInfo>(4);
			}
			this.channelTab[value] = new ManifestBuilder.ChannelInfo
			{
				Name = name,
				Keywords = channelKeyword,
				Attribs = channelAttribute
			};
		}

		// Token: 0x06008CF7 RID: 36087 RVA: 0x00159D7C File Offset: 0x00157F7C
		private static EventChannelType EventChannelToChannelType(EventChannel channel)
		{
			return (EventChannelType)(channel - 16 + 1);
		}

		// Token: 0x06008CF8 RID: 36088 RVA: 0x00159D84 File Offset: 0x00157F84
		private static EventChannelAttribute GetDefaultChannelAttribute(EventChannel channel)
		{
			EventChannelAttribute eventChannelAttribute = new EventChannelAttribute();
			eventChannelAttribute.EventChannelType = ManifestBuilder.EventChannelToChannelType(channel);
			if (eventChannelAttribute.EventChannelType <= EventChannelType.Operational)
			{
				eventChannelAttribute.Enabled = true;
			}
			return eventChannelAttribute;
		}

		// Token: 0x06008CF9 RID: 36089 RVA: 0x00159DB4 File Offset: 0x00157FB4
		public ulong[] GetChannelData()
		{
			if (this.channelTab == null)
			{
				return Array.Empty<ulong>();
			}
			int num = -1;
			foreach (int num2 in this.channelTab.Keys)
			{
				if (num2 > num)
				{
					num = num2;
				}
			}
			ulong[] array = new ulong[num + 1];
			foreach (KeyValuePair<int, ManifestBuilder.ChannelInfo> keyValuePair in this.channelTab)
			{
				array[keyValuePair.Key] = keyValuePair.Value.Keywords;
			}
			return array;
		}

		// Token: 0x06008CFA RID: 36090 RVA: 0x00159E78 File Offset: 0x00158078
		public void StartEvent(string eventName, EventAttribute eventAttribute)
		{
			this.eventName = eventName;
			this.numParams = 0;
			this.byteArrArgIndices = null;
			StringBuilder stringBuilder = this.events;
			if (stringBuilder != null)
			{
				stringBuilder.Append("  <event value=\"").Append(eventAttribute.EventId).Append("\" version=\"").Append(eventAttribute.Version).Append("\" level=\"");
			}
			ManifestBuilder.AppendLevelName(this.events, eventAttribute.Level);
			StringBuilder stringBuilder2 = this.events;
			if (stringBuilder2 != null)
			{
				stringBuilder2.Append("\" symbol=\"").Append(eventName).Append('"');
			}
			this.WriteMessageAttrib(this.events, "event", eventName, eventAttribute.Message);
			if (eventAttribute.Keywords != EventKeywords.None)
			{
				StringBuilder stringBuilder3 = this.events;
				if (stringBuilder3 != null)
				{
					stringBuilder3.Append(" keywords=\"");
				}
				this.AppendKeywords(this.events, (ulong)eventAttribute.Keywords, eventName);
				StringBuilder stringBuilder4 = this.events;
				if (stringBuilder4 != null)
				{
					stringBuilder4.Append('"');
				}
			}
			if (eventAttribute.Opcode != EventOpcode.Info)
			{
				string opcodeName = this.GetOpcodeName(eventAttribute.Opcode, eventName);
				StringBuilder stringBuilder5 = this.events;
				if (stringBuilder5 != null)
				{
					stringBuilder5.Append(" opcode=\"").Append(opcodeName).Append('"');
				}
			}
			if (eventAttribute.Task != EventTask.None)
			{
				string taskName = this.GetTaskName(eventAttribute.Task, eventName);
				StringBuilder stringBuilder6 = this.events;
				if (stringBuilder6 != null)
				{
					stringBuilder6.Append(" task=\"").Append(taskName).Append('"');
				}
			}
			if (eventAttribute.Channel != EventChannel.None)
			{
				string channelName = this.GetChannelName(eventAttribute.Channel, eventName, eventAttribute.Message);
				StringBuilder stringBuilder7 = this.events;
				if (stringBuilder7 == null)
				{
					return;
				}
				stringBuilder7.Append(" channel=\"").Append(channelName).Append('"');
			}
		}

		// Token: 0x06008CFB RID: 36091 RVA: 0x0015A024 File Offset: 0x00158224
		public void AddEventParameter(Type type, string name)
		{
			if (this.numParams == 0)
			{
				StringBuilder stringBuilder = this.templates;
				if (stringBuilder != null)
				{
					stringBuilder.Append("  <template tid=\"").Append(this.eventName).AppendLine("Args\">");
				}
			}
			if (type == typeof(byte[]))
			{
				if (this.byteArrArgIndices == null)
				{
					this.byteArrArgIndices = new List<int>(4);
				}
				this.byteArrArgIndices.Add(this.numParams);
				this.numParams++;
				StringBuilder stringBuilder2 = this.templates;
				if (stringBuilder2 != null)
				{
					stringBuilder2.Append("   <data name=\"").Append(name).AppendLine("Size\" inType=\"win:UInt32\"/>");
				}
			}
			this.numParams++;
			StringBuilder stringBuilder3 = this.templates;
			if (stringBuilder3 != null)
			{
				stringBuilder3.Append("   <data name=\"").Append(name).Append("\" inType=\"").Append(this.GetTypeName(type)).Append('"');
			}
			if ((type.IsArray || type.IsPointer) && type.GetElementType() == typeof(byte))
			{
				StringBuilder stringBuilder4 = this.templates;
				if (stringBuilder4 != null)
				{
					stringBuilder4.Append(" length=\"").Append(name).Append("Size\"");
				}
			}
			if (type.IsEnum && Enum.GetUnderlyingType(type) != typeof(ulong) && Enum.GetUnderlyingType(type) != typeof(long))
			{
				StringBuilder stringBuilder5 = this.templates;
				if (stringBuilder5 != null)
				{
					stringBuilder5.Append(" map=\"").Append(type.Name).Append('"');
				}
				if (this.mapsTab == null)
				{
					this.mapsTab = new Dictionary<string, Type>();
				}
				this.mapsTab.TryAdd(type.Name, type);
			}
			StringBuilder stringBuilder6 = this.templates;
			if (stringBuilder6 == null)
			{
				return;
			}
			stringBuilder6.AppendLine("/>");
		}

		// Token: 0x06008CFC RID: 36092 RVA: 0x0015A204 File Offset: 0x00158404
		public void EndEvent()
		{
			if (this.numParams > 0)
			{
				StringBuilder stringBuilder = this.templates;
				if (stringBuilder != null)
				{
					stringBuilder.AppendLine("  </template>");
				}
				StringBuilder stringBuilder2 = this.events;
				if (stringBuilder2 != null)
				{
					stringBuilder2.Append(" template=\"").Append(this.eventName).Append("Args\"");
				}
			}
			StringBuilder stringBuilder3 = this.events;
			if (stringBuilder3 != null)
			{
				stringBuilder3.AppendLine("/>");
			}
			if (this.byteArrArgIndices != null)
			{
				this.perEventByteArrayArgIndices[this.eventName] = this.byteArrArgIndices;
			}
			string key = "event_" + this.eventName;
			string text;
			if (this.stringTab.TryGetValue(key, out text))
			{
				text = this.TranslateToManifestConvention(text, this.eventName);
				this.stringTab[key] = text;
			}
			this.eventName = null;
			this.numParams = 0;
			this.byteArrArgIndices = null;
		}

		// Token: 0x06008CFD RID: 36093 RVA: 0x0015A2E4 File Offset: 0x001584E4
		public ulong GetChannelKeyword(EventChannel channel, ulong channelKeyword = 0UL)
		{
			channelKeyword &= 17293822569102704640UL;
			if (this.channelTab == null)
			{
				this.channelTab = new Dictionary<int, ManifestBuilder.ChannelInfo>(4);
			}
			if (this.channelTab.Count == 8)
			{
				this.ManifestError(SR.EventSource_MaxChannelExceeded, false);
			}
			ManifestBuilder.ChannelInfo channelInfo;
			if (!this.channelTab.TryGetValue((int)channel, out channelInfo))
			{
				if (channelKeyword == 0UL)
				{
					channelKeyword = this.nextChannelKeywordBit;
					this.nextChannelKeywordBit >>= 1;
				}
			}
			else
			{
				channelKeyword = channelInfo.Keywords;
			}
			return channelKeyword;
		}

		// Token: 0x06008CFE RID: 36094 RVA: 0x0015A360 File Offset: 0x00158560
		public byte[] CreateManifest()
		{
			string text = this.CreateManifestString();
			if (!(text != ""))
			{
				return Array.Empty<byte>();
			}
			return Encoding.UTF8.GetBytes(text);
		}

		// Token: 0x170012D5 RID: 4821
		// (get) Token: 0x06008CFF RID: 36095 RVA: 0x0015A392 File Offset: 0x00158592
		public IList<string> Errors
		{
			get
			{
				return this.errors;
			}
		}

		// Token: 0x170012D6 RID: 4822
		// (get) Token: 0x06008D00 RID: 36096 RVA: 0x0015A39A File Offset: 0x0015859A
		public bool HasResources
		{
			get
			{
				return this.resources != null;
			}
		}

		// Token: 0x06008D01 RID: 36097 RVA: 0x0015A3A5 File Offset: 0x001585A5
		public void ManifestError(string msg, bool runtimeCritical = false)
		{
			if ((this.flags & EventManifestOptions.Strict) != EventManifestOptions.None)
			{
				this.errors.Add(msg);
				return;
			}
			if (runtimeCritical)
			{
				throw new ArgumentException(msg);
			}
		}

		// Token: 0x06008D02 RID: 36098 RVA: 0x0015A3C8 File Offset: 0x001585C8
		private unsafe string CreateManifestString()
		{
			Span<char> destination = new Span<char>(stackalloc byte[(UIntPtr)32], 16);
			if (this.channelTab != null)
			{
				StringBuilder stringBuilder = this.sb;
				if (stringBuilder != null)
				{
					stringBuilder.AppendLine(" <channels>");
				}
				List<KeyValuePair<int, ManifestBuilder.ChannelInfo>> list = new List<KeyValuePair<int, ManifestBuilder.ChannelInfo>>();
				foreach (KeyValuePair<int, ManifestBuilder.ChannelInfo> item in this.channelTab)
				{
					list.Add(item);
				}
				list.Sort((KeyValuePair<int, ManifestBuilder.ChannelInfo> p1, KeyValuePair<int, ManifestBuilder.ChannelInfo> p2) => -Comparer<ulong>.Default.Compare(p1.Value.Keywords, p2.Value.Keywords));
				foreach (KeyValuePair<int, ManifestBuilder.ChannelInfo> keyValuePair in list)
				{
					int key = keyValuePair.Key;
					ManifestBuilder.ChannelInfo value = keyValuePair.Value;
					string text = null;
					bool flag = false;
					string text2 = null;
					if (value.Attribs != null)
					{
						EventChannelAttribute attribs = value.Attribs;
						if (Enum.IsDefined<EventChannelType>(attribs.EventChannelType))
						{
							text = attribs.EventChannelType.ToString();
						}
						flag = attribs.Enabled;
					}
					if (text2 == null)
					{
						text2 = this.providerName + "/" + value.Name;
					}
					StringBuilder stringBuilder2 = this.sb;
					if (stringBuilder2 != null)
					{
						stringBuilder2.Append("  <channel chid=\"").Append(value.Name).Append("\" name=\"").Append(text2).Append('"');
					}
					this.WriteMessageAttrib(this.sb, "channel", value.Name, null);
					StringBuilder stringBuilder3 = this.sb;
					if (stringBuilder3 != null)
					{
						stringBuilder3.Append(" value=\"").Append(key).Append('"');
					}
					if (text != null)
					{
						StringBuilder stringBuilder4 = this.sb;
						if (stringBuilder4 != null)
						{
							stringBuilder4.Append(" type=\"").Append(text).Append('"');
						}
					}
					StringBuilder stringBuilder5 = this.sb;
					if (stringBuilder5 != null)
					{
						stringBuilder5.Append(" enabled=\"").Append(flag ? "true" : "false").AppendLine("\"/>");
					}
				}
				StringBuilder stringBuilder6 = this.sb;
				if (stringBuilder6 != null)
				{
					stringBuilder6.AppendLine(" </channels>");
				}
			}
			if (this.taskTab != null)
			{
				StringBuilder stringBuilder7 = this.sb;
				if (stringBuilder7 != null)
				{
					stringBuilder7.AppendLine(" <tasks>");
				}
				List<int> list2 = new List<int>(this.taskTab.Keys);
				list2.Sort();
				foreach (int num in list2)
				{
					StringBuilder stringBuilder8 = this.sb;
					if (stringBuilder8 != null)
					{
						stringBuilder8.Append("  <task");
					}
					this.WriteNameAndMessageAttribs(this.sb, "task", this.taskTab[num]);
					StringBuilder stringBuilder9 = this.sb;
					if (stringBuilder9 != null)
					{
						stringBuilder9.Append(" value=\"").Append(num).AppendLine("\"/>");
					}
				}
				StringBuilder stringBuilder10 = this.sb;
				if (stringBuilder10 != null)
				{
					stringBuilder10.AppendLine(" </tasks>");
				}
			}
			if (this.mapsTab != null)
			{
				StringBuilder stringBuilder11 = this.sb;
				if (stringBuilder11 != null)
				{
					stringBuilder11.AppendLine(" <maps>");
				}
				foreach (Type type in this.mapsTab.Values)
				{
					bool flag2 = EventSource.IsCustomAttributeDefinedHelper(type, typeof(FlagsAttribute), this.flags);
					string value2 = flag2 ? "bitMap" : "valueMap";
					StringBuilder stringBuilder12 = this.sb;
					if (stringBuilder12 != null)
					{
						stringBuilder12.Append("  <").Append(value2).Append(" name=\"").Append(type.Name).AppendLine("\">");
					}
					FieldInfo[] array = ManifestBuilder.<CreateManifestString>g__GetEnumFields|19_0(type);
					bool flag3 = false;
					foreach (FieldInfo fieldInfo in array)
					{
						object rawConstantValue = fieldInfo.GetRawConstantValue();
						if (rawConstantValue != null)
						{
							ulong value3;
							if (rawConstantValue is ulong)
							{
								value3 = (ulong)rawConstantValue;
							}
							else
							{
								value3 = (ulong)Convert.ToInt64(rawConstantValue);
							}
							if (!flag2 || BitOperations.IsPow2(value3))
							{
								int length;
								value3.TryFormat(destination, out length, "x", null);
								ReadOnlySpan<char> value4 = destination.Slice(0, length);
								StringBuilder stringBuilder13 = this.sb;
								if (stringBuilder13 != null)
								{
									stringBuilder13.Append("   <map value=\"0x").Append(value4).Append('"');
								}
								this.WriteMessageAttrib(this.sb, "map", type.Name + "." + fieldInfo.Name, fieldInfo.Name);
								StringBuilder stringBuilder14 = this.sb;
								if (stringBuilder14 != null)
								{
									stringBuilder14.AppendLine("/>");
								}
								flag3 = true;
							}
						}
					}
					if (!flag3)
					{
						StringBuilder stringBuilder15 = this.sb;
						if (stringBuilder15 != null)
						{
							stringBuilder15.Append("   <map value=\"0x0\"");
						}
						this.WriteMessageAttrib(this.sb, "map", type.Name + ".None", "None");
						StringBuilder stringBuilder16 = this.sb;
						if (stringBuilder16 != null)
						{
							stringBuilder16.AppendLine("/>");
						}
					}
					StringBuilder stringBuilder17 = this.sb;
					if (stringBuilder17 != null)
					{
						stringBuilder17.Append("  </").Append(value2).AppendLine(">");
					}
				}
				StringBuilder stringBuilder18 = this.sb;
				if (stringBuilder18 != null)
				{
					stringBuilder18.AppendLine(" </maps>");
				}
			}
			StringBuilder stringBuilder19 = this.sb;
			if (stringBuilder19 != null)
			{
				stringBuilder19.AppendLine(" <opcodes>");
			}
			List<int> list3 = new List<int>(this.opcodeTab.Keys);
			list3.Sort();
			foreach (int num2 in list3)
			{
				StringBuilder stringBuilder20 = this.sb;
				if (stringBuilder20 != null)
				{
					stringBuilder20.Append("  <opcode");
				}
				this.WriteNameAndMessageAttribs(this.sb, "opcode", this.opcodeTab[num2]);
				StringBuilder stringBuilder21 = this.sb;
				if (stringBuilder21 != null)
				{
					stringBuilder21.Append(" value=\"").Append(num2).AppendLine("\"/>");
				}
			}
			StringBuilder stringBuilder22 = this.sb;
			if (stringBuilder22 != null)
			{
				stringBuilder22.AppendLine(" </opcodes>");
			}
			if (this.keywordTab != null)
			{
				StringBuilder stringBuilder23 = this.sb;
				if (stringBuilder23 != null)
				{
					stringBuilder23.AppendLine(" <keywords>");
				}
				List<ulong> list4 = new List<ulong>(this.keywordTab.Keys);
				list4.Sort();
				foreach (ulong key2 in list4)
				{
					StringBuilder stringBuilder24 = this.sb;
					if (stringBuilder24 != null)
					{
						stringBuilder24.Append("  <keyword");
					}
					this.WriteNameAndMessageAttribs(this.sb, "keyword", this.keywordTab[key2]);
					int length2;
					key2.TryFormat(destination, out length2, "x", null);
					ReadOnlySpan<char> value5 = destination.Slice(0, length2);
					StringBuilder stringBuilder25 = this.sb;
					if (stringBuilder25 != null)
					{
						stringBuilder25.Append(" mask=\"0x").Append(value5).AppendLine("\"/>");
					}
				}
				StringBuilder stringBuilder26 = this.sb;
				if (stringBuilder26 != null)
				{
					stringBuilder26.AppendLine(" </keywords>");
				}
			}
			StringBuilder stringBuilder27 = this.sb;
			if (stringBuilder27 != null)
			{
				stringBuilder27.AppendLine(" <events>");
			}
			StringBuilder stringBuilder28 = this.sb;
			if (stringBuilder28 != null)
			{
				stringBuilder28.Append(this.events);
			}
			StringBuilder stringBuilder29 = this.sb;
			if (stringBuilder29 != null)
			{
				stringBuilder29.AppendLine(" </events>");
			}
			StringBuilder stringBuilder30 = this.sb;
			if (stringBuilder30 != null)
			{
				stringBuilder30.AppendLine(" <templates>");
			}
			StringBuilder stringBuilder31 = this.templates;
			if (stringBuilder31 != null && stringBuilder31.Length > 0)
			{
				StringBuilder stringBuilder32 = this.sb;
				if (stringBuilder32 != null)
				{
					stringBuilder32.Append(this.templates);
				}
			}
			else
			{
				StringBuilder stringBuilder33 = this.sb;
				if (stringBuilder33 != null)
				{
					stringBuilder33.AppendLine("    <template tid=\"_empty\"></template>");
				}
			}
			StringBuilder stringBuilder34 = this.sb;
			if (stringBuilder34 != null)
			{
				stringBuilder34.AppendLine(" </templates>");
			}
			StringBuilder stringBuilder35 = this.sb;
			if (stringBuilder35 != null)
			{
				stringBuilder35.AppendLine("</provider>");
			}
			StringBuilder stringBuilder36 = this.sb;
			if (stringBuilder36 != null)
			{
				stringBuilder36.AppendLine("</events>");
			}
			StringBuilder stringBuilder37 = this.sb;
			if (stringBuilder37 != null)
			{
				stringBuilder37.AppendLine("</instrumentation>");
			}
			StringBuilder stringBuilder38 = this.sb;
			if (stringBuilder38 != null)
			{
				stringBuilder38.AppendLine("<localization>");
			}
			string[] array3 = new string[this.stringTab.Keys.Count];
			this.stringTab.Keys.CopyTo(array3, 0);
			Array.Sort<string>(array3, StringComparer.Ordinal);
			CultureInfo currentUICulture = CultureInfo.CurrentUICulture;
			StringBuilder stringBuilder39 = this.sb;
			if (stringBuilder39 != null)
			{
				stringBuilder39.Append(" <resources culture=\"").Append(currentUICulture.Name).AppendLine("\">");
			}
			StringBuilder stringBuilder40 = this.sb;
			if (stringBuilder40 != null)
			{
				stringBuilder40.AppendLine("  <stringTable>");
			}
			foreach (string text3 in array3)
			{
				string localizedMessage = this.GetLocalizedMessage(text3, currentUICulture, true);
				StringBuilder stringBuilder41 = this.sb;
				if (stringBuilder41 != null)
				{
					stringBuilder41.Append("   <string id=\"").Append(text3).Append("\" value=\"").Append(localizedMessage).AppendLine("\"/>");
				}
			}
			StringBuilder stringBuilder42 = this.sb;
			if (stringBuilder42 != null)
			{
				stringBuilder42.AppendLine("  </stringTable>");
			}
			StringBuilder stringBuilder43 = this.sb;
			if (stringBuilder43 != null)
			{
				stringBuilder43.AppendLine(" </resources>");
			}
			StringBuilder stringBuilder44 = this.sb;
			if (stringBuilder44 != null)
			{
				stringBuilder44.AppendLine("</localization>");
			}
			StringBuilder stringBuilder45 = this.sb;
			if (stringBuilder45 != null)
			{
				stringBuilder45.AppendLine("</instrumentationManifest>");
			}
			StringBuilder stringBuilder46 = this.sb;
			return ((stringBuilder46 != null) ? stringBuilder46.ToString() : null) ?? "";
		}

		// Token: 0x06008D03 RID: 36099 RVA: 0x0015AE08 File Offset: 0x00159008
		private void WriteNameAndMessageAttribs(StringBuilder stringBuilder, string elementName, string name)
		{
			if (stringBuilder != null)
			{
				stringBuilder.Append(" name=\"").Append(name).Append('"');
			}
			this.WriteMessageAttrib(this.sb, elementName, name, name);
		}

		// Token: 0x06008D04 RID: 36100 RVA: 0x0015AE38 File Offset: 0x00159038
		private void WriteMessageAttrib(StringBuilder stringBuilder, string elementName, string name, string value)
		{
			string text = null;
			if (this.resources != null)
			{
				text = elementName + "_" + name;
				string @string = this.resources.GetString(text, CultureInfo.InvariantCulture);
				if (@string != null)
				{
					value = @string;
				}
			}
			if (value == null)
			{
				return;
			}
			if (text == null)
			{
				text = elementName + "_" + name;
			}
			if (stringBuilder != null)
			{
				stringBuilder.Append(" message=\"$(string.").Append(text).Append(")\"");
			}
			string text2;
			if (this.stringTab.TryGetValue(text, out text2) && !text2.Equals(value))
			{
				this.ManifestError(SR.Format(SR.EventSource_DuplicateStringKey, text), true);
				return;
			}
			this.stringTab[text] = value;
		}

		// Token: 0x06008D05 RID: 36101 RVA: 0x0015AEE4 File Offset: 0x001590E4
		internal string GetLocalizedMessage(string key, CultureInfo ci, bool etwFormat)
		{
			string text = null;
			if (this.resources != null)
			{
				string @string = this.resources.GetString(key, ci);
				if (@string != null)
				{
					text = @string;
					if (etwFormat && key.StartsWith("event_", StringComparison.Ordinal))
					{
						string evtName = key.Substring("event_".Length);
						text = this.TranslateToManifestConvention(text, evtName);
					}
				}
			}
			if (etwFormat && text == null)
			{
				this.stringTab.TryGetValue(key, out text);
			}
			return text;
		}

		// Token: 0x06008D06 RID: 36102 RVA: 0x0015AF50 File Offset: 0x00159150
		private static void AppendLevelName(StringBuilder sb, EventLevel level)
		{
			if (level < (EventLevel)16 && sb != null)
			{
				sb.Append("win:");
			}
			if (sb != null)
			{
				string value;
				switch (level)
				{
				case EventLevel.LogAlways:
					value = "LogAlways";
					break;
				case EventLevel.Critical:
					value = "Critical";
					break;
				case EventLevel.Error:
					value = "Error";
					break;
				case EventLevel.Warning:
					value = "Warning";
					break;
				case EventLevel.Informational:
					value = "Informational";
					break;
				case EventLevel.Verbose:
					value = "Verbose";
					break;
				default:
				{
					int num = (int)level;
					value = num.ToString();
					break;
				}
				}
				sb.Append(value);
			}
		}

		// Token: 0x06008D07 RID: 36103 RVA: 0x0015AFD8 File Offset: 0x001591D8
		private string GetChannelName(EventChannel channel, string eventName, string eventMessage)
		{
			ManifestBuilder.ChannelInfo channelInfo;
			if (this.channelTab == null || !this.channelTab.TryGetValue((int)channel, out channelInfo))
			{
				if (channel < EventChannel.Admin)
				{
					this.ManifestError(SR.Format(SR.EventSource_UndefinedChannel, channel, eventName), false);
				}
				if (this.channelTab == null)
				{
					this.channelTab = new Dictionary<int, ManifestBuilder.ChannelInfo>(4);
				}
				string text = channel.ToString();
				if (EventChannel.Debug < channel)
				{
					text = "Channel" + text;
				}
				this.AddChannel(text, (int)channel, ManifestBuilder.GetDefaultChannelAttribute(channel));
				if (!this.channelTab.TryGetValue((int)channel, out channelInfo))
				{
					this.ManifestError(SR.Format(SR.EventSource_UndefinedChannel, channel, eventName), false);
				}
			}
			if (this.resources != null && eventMessage == null)
			{
				eventMessage = this.resources.GetString("event_" + eventName, CultureInfo.InvariantCulture);
			}
			if (channelInfo.Attribs.EventChannelType == EventChannelType.Admin && eventMessage == null)
			{
				this.ManifestError(SR.Format(SR.EventSource_EventWithAdminChannelMustHaveMessage, eventName, channelInfo.Name), false);
			}
			return channelInfo.Name;
		}

		// Token: 0x06008D08 RID: 36104 RVA: 0x0015B0E0 File Offset: 0x001592E0
		private string GetTaskName(EventTask task, string eventName)
		{
			if (task == EventTask.None)
			{
				return "";
			}
			if (this.taskTab == null)
			{
				this.taskTab = new Dictionary<int, string>();
			}
			string result;
			if (!this.taskTab.TryGetValue((int)task, out result))
			{
				this.taskTab[(int)task] = eventName;
				result = eventName;
			}
			return result;
		}

		// Token: 0x06008D09 RID: 36105 RVA: 0x0015B12C File Offset: 0x0015932C
		private string GetOpcodeName(EventOpcode opcode, string eventName)
		{
			switch (opcode)
			{
			case EventOpcode.Info:
				return "win:Info";
			case EventOpcode.Start:
				return "win:Start";
			case EventOpcode.Stop:
				return "win:Stop";
			case EventOpcode.DataCollectionStart:
				return "win:DC_Start";
			case EventOpcode.DataCollectionStop:
				return "win:DC_Stop";
			case EventOpcode.Extension:
				return "win:Extension";
			case EventOpcode.Reply:
				return "win:Reply";
			case EventOpcode.Resume:
				return "win:Resume";
			case EventOpcode.Suspend:
				return "win:Suspend";
			case EventOpcode.Send:
				return "win:Send";
			default:
				if (opcode != EventOpcode.Receive)
				{
					string result;
					if (this.opcodeTab == null || !this.opcodeTab.TryGetValue((int)opcode, out result))
					{
						this.ManifestError(SR.Format(SR.EventSource_UndefinedOpcode, opcode, eventName), true);
						result = null;
					}
					return result;
				}
				return "win:Receive";
			}
		}

		// Token: 0x06008D0A RID: 36106 RVA: 0x0015B1E8 File Offset: 0x001593E8
		private void AppendKeywords(StringBuilder sb, ulong keywords, string eventName)
		{
			keywords &= 1152921504606846975UL;
			bool flag = false;
			for (ulong num = 1UL; num != 0UL; num <<= 1)
			{
				if ((keywords & num) != 0UL)
				{
					string text = null;
					if ((this.keywordTab == null || !this.keywordTab.TryGetValue(num, out text)) && num >= 281474976710656UL)
					{
						text = string.Empty;
					}
					if (text == null)
					{
						this.ManifestError(SR.Format(SR.EventSource_UndefinedKeyword, "0x" + num.ToString("x", CultureInfo.CurrentCulture), eventName), true);
						text = string.Empty;
					}
					if (text.Length != 0)
					{
						if (flag && sb != null)
						{
							sb.Append(' ');
						}
						if (sb != null)
						{
							sb.Append(text);
						}
						flag = true;
					}
				}
			}
		}

		// Token: 0x06008D0B RID: 36107 RVA: 0x0015B2A4 File Offset: 0x001594A4
		private string GetTypeName(Type type)
		{
			if (type.IsEnum)
			{
				string typeName = this.GetTypeName(type.GetEnumUnderlyingType());
				string result;
				if (!(typeName == "win:Int8"))
				{
					if (!(typeName == "win:Int16"))
					{
						if (!(typeName == "win:Int32"))
						{
							if (!(typeName == "win:Int64"))
							{
								result = typeName;
							}
							else
							{
								result = "win:UInt64";
							}
						}
						else
						{
							result = "win:UInt32";
						}
					}
					else
					{
						result = "win:UInt16";
					}
				}
				else
				{
					result = "win:UInt8";
				}
				return result;
			}
			switch (Type.GetTypeCode(type))
			{
			case TypeCode.Boolean:
				return "win:Boolean";
			case TypeCode.Char:
			case TypeCode.UInt16:
				return "win:UInt16";
			case TypeCode.SByte:
				return "win:Int8";
			case TypeCode.Byte:
				return "win:UInt8";
			case TypeCode.Int16:
				return "win:Int16";
			case TypeCode.Int32:
				return "win:Int32";
			case TypeCode.UInt32:
				return "win:UInt32";
			case TypeCode.Int64:
				return "win:Int64";
			case TypeCode.UInt64:
				return "win:UInt64";
			case TypeCode.Single:
				return "win:Float";
			case TypeCode.Double:
				return "win:Double";
			case TypeCode.DateTime:
				return "win:FILETIME";
			case TypeCode.String:
				return "win:UnicodeString";
			}
			if (type == typeof(Guid))
			{
				return "win:GUID";
			}
			if (type == typeof(IntPtr))
			{
				return "win:Pointer";
			}
			if ((type.IsArray || type.IsPointer) && type.GetElementType() == typeof(byte))
			{
				return "win:Binary";
			}
			this.ManifestError(SR.Format(SR.EventSource_UnsupportedEventTypeInManifest, type.Name), true);
			return string.Empty;
		}

		// Token: 0x06008D0C RID: 36108 RVA: 0x0015B438 File Offset: 0x00159638
		private static void UpdateStringBuilder([NotNull] ref StringBuilder stringBuilder, string eventMessage, int startIndex, int count)
		{
			if (stringBuilder == null)
			{
				stringBuilder = new StringBuilder();
			}
			stringBuilder.Append(eventMessage, startIndex, count);
		}

		// Token: 0x06008D0D RID: 36109 RVA: 0x0015B450 File Offset: 0x00159650
		private string TranslateToManifestConvention(string eventMessage, string evtName)
		{
			StringBuilder stringBuilder = null;
			int num = 0;
			int i = 0;
			while (i < eventMessage.Length)
			{
				int num4;
				if (eventMessage[i] == '%')
				{
					ManifestBuilder.UpdateStringBuilder(ref stringBuilder, eventMessage, num, i - num);
					stringBuilder.Append("%%");
					i++;
					num = i;
				}
				else if (i < eventMessage.Length - 1 && ((eventMessage[i] == '{' && eventMessage[i + 1] == '{') || (eventMessage[i] == '}' && eventMessage[i + 1] == '}')))
				{
					ManifestBuilder.UpdateStringBuilder(ref stringBuilder, eventMessage, num, i - num);
					stringBuilder.Append(eventMessage[i]);
					i++;
					i++;
					num = i;
				}
				else if (eventMessage[i] == '{')
				{
					int num2 = i;
					i++;
					int num3 = 0;
					while (i < eventMessage.Length && char.IsDigit(eventMessage[i]))
					{
						num3 = num3 * 10 + (int)eventMessage[i] - 48;
						i++;
					}
					if (i < eventMessage.Length && eventMessage[i] == '}')
					{
						i++;
						ManifestBuilder.UpdateStringBuilder(ref stringBuilder, eventMessage, num, num2 - num);
						int value = this.TranslateIndexToManifestConvention(num3, evtName);
						stringBuilder.Append('%').Append(value);
						if (i < eventMessage.Length && eventMessage[i] == '!')
						{
							i++;
							stringBuilder.Append("%!");
						}
						num = i;
					}
					else
					{
						this.ManifestError(SR.Format(SR.EventSource_UnsupportedMessageProperty, evtName, eventMessage), false);
					}
				}
				else if ((num4 = "&<>'\"\r\n\t".IndexOf(eventMessage[i])) >= 0)
				{
					ManifestBuilder.UpdateStringBuilder(ref stringBuilder, eventMessage, num, i - num);
					i++;
					stringBuilder.Append(ManifestBuilder.s_escapes[num4]);
					num = i;
				}
				else
				{
					i++;
				}
			}
			if (stringBuilder == null)
			{
				return eventMessage;
			}
			ManifestBuilder.UpdateStringBuilder(ref stringBuilder, eventMessage, num, i - num);
			return stringBuilder.ToString();
		}

		// Token: 0x06008D0E RID: 36110 RVA: 0x0015B620 File Offset: 0x00159820
		private int TranslateIndexToManifestConvention(int idx, string evtName)
		{
			List<int> list;
			if (this.perEventByteArrayArgIndices.TryGetValue(evtName, out list))
			{
				foreach (int num in list)
				{
					if (idx < num)
					{
						break;
					}
					idx++;
				}
			}
			return idx + 1;
		}

		// Token: 0x06008D10 RID: 36112 RVA: 0x0015B6DC File Offset: 0x001598DC
		[CompilerGenerated]
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2070:UnrecognizedReflectionPattern", Justification = "Trimmer does not trim enums")]
		internal static FieldInfo[] <CreateManifestString>g__GetEnumFields|19_0(Type localEnumType)
		{
			return localEnumType.GetFields(BindingFlags.DeclaredOnly | BindingFlags.Static | BindingFlags.Public);
		}

		// Token: 0x04002039 RID: 8249
		private static readonly string[] s_escapes = new string[]
		{
			"&amp;",
			"&lt;",
			"&gt;",
			"&apos;",
			"&quot;",
			"%r",
			"%n",
			"%t"
		};

		// Token: 0x0400203A RID: 8250
		private readonly Dictionary<int, string> opcodeTab;

		// Token: 0x0400203B RID: 8251
		private Dictionary<int, string> taskTab;

		// Token: 0x0400203C RID: 8252
		private Dictionary<int, ManifestBuilder.ChannelInfo> channelTab;

		// Token: 0x0400203D RID: 8253
		private Dictionary<ulong, string> keywordTab;

		// Token: 0x0400203E RID: 8254
		private Dictionary<string, Type> mapsTab;

		// Token: 0x0400203F RID: 8255
		private readonly Dictionary<string, string> stringTab;

		// Token: 0x04002040 RID: 8256
		private ulong nextChannelKeywordBit = 9223372036854775808UL;

		// Token: 0x04002041 RID: 8257
		private readonly StringBuilder sb;

		// Token: 0x04002042 RID: 8258
		private readonly StringBuilder events;

		// Token: 0x04002043 RID: 8259
		private readonly StringBuilder templates;

		// Token: 0x04002044 RID: 8260
		private readonly string providerName;

		// Token: 0x04002045 RID: 8261
		private readonly ResourceManager resources;

		// Token: 0x04002046 RID: 8262
		private readonly EventManifestOptions flags;

		// Token: 0x04002047 RID: 8263
		private readonly List<string> errors;

		// Token: 0x04002048 RID: 8264
		private readonly Dictionary<string, List<int>> perEventByteArrayArgIndices;

		// Token: 0x04002049 RID: 8265
		private string eventName;

		// Token: 0x0400204A RID: 8266
		private int numParams;

		// Token: 0x0400204B RID: 8267
		private List<int> byteArrArgIndices;

		// Token: 0x02000902 RID: 2306
		private sealed class ChannelInfo
		{
			// Token: 0x0400204C RID: 8268
			public string Name;

			// Token: 0x0400204D RID: 8269
			public ulong Keywords;

			// Token: 0x0400204E RID: 8270
			public EventChannelAttribute Attribs;
		}
	}
}
