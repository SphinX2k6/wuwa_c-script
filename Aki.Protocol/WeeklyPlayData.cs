using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001510 RID: 5392
	public sealed class WeeklyPlayData : IMessage<WeeklyPlayData>, IMessage, IEquatable<WeeklyPlayData>, IDeepCloneable<WeeklyPlayData>, IBufferMessage
	{
		// Token: 0x0601C7ED RID: 116717 RVA: 0x0041D7D1 File Offset: 0x0041B9D1
		[NullableContext(1)]
		public static WeeklyPlayData Create()
		{
			return new WeeklyPlayData();
		}

		// Token: 0x1700600D RID: 24589
		// (get) Token: 0x0601C7EE RID: 116718 RVA: 0x0041D7D8 File Offset: 0x0041B9D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<WeeklyPlayData> Parser
		{
			get
			{
				return WeeklyPlayData._parser;
			}
		}

		// Token: 0x1700600E RID: 24590
		// (get) Token: 0x0601C7EF RID: 116719 RVA: 0x0041D7DF File Offset: 0x0041B9DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700600F RID: 24591
		// (get) Token: 0x0601C7F0 RID: 116720 RVA: 0x0041D7E2 File Offset: 0x0041B9E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WeeklyPlayData.Descriptor;
			}
		}

		// Token: 0x0601C7F1 RID: 116721 RVA: 0x0041D7E9 File Offset: 0x0041B9E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeeklyPlayData()
		{
		}

		// Token: 0x0601C7F2 RID: 116722 RVA: 0x0041D7F4 File Offset: 0x0041B9F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeeklyPlayData(WeeklyPlayData other) : this()
		{
			this.id_ = other.id_;
			this.type_ = other.type_;
			WeeklyPlayData.PlayDataOneofCase playDataCase = other.PlayDataCase;
			if (playDataCase != WeeklyPlayData.PlayDataOneofCase.RogueWeeklyPlayData)
			{
				if (playDataCase == WeeklyPlayData.PlayDataOneofCase.FloroFarmPlayData)
				{
					this.FloroFarmPlayData = other.FloroFarmPlayData.Clone();
				}
			}
			else
			{
				this.RogueWeeklyPlayData = other.RogueWeeklyPlayData.Clone();
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C7F3 RID: 116723 RVA: 0x0041D86D File Offset: 0x0041BA6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeeklyPlayData Clone()
		{
			return new WeeklyPlayData(this);
		}

		// Token: 0x17006010 RID: 24592
		// (get) Token: 0x0601C7F4 RID: 116724 RVA: 0x0041D875 File Offset: 0x0041BA75
		// (set) Token: 0x0601C7F5 RID: 116725 RVA: 0x0041D87D File Offset: 0x0041BA7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x17006011 RID: 24593
		// (get) Token: 0x0601C7F6 RID: 116726 RVA: 0x0041D886 File Offset: 0x0041BA86
		// (set) Token: 0x0601C7F7 RID: 116727 RVA: 0x0041D88E File Offset: 0x0041BA8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActivityType Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x17006012 RID: 24594
		// (get) Token: 0x0601C7F8 RID: 116728 RVA: 0x0041D897 File Offset: 0x0041BA97
		// (set) Token: 0x0601C7F9 RID: 116729 RVA: 0x0041D8B3 File Offset: 0x0041BAB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyPlayData RogueWeeklyPlayData
		{
			get
			{
				if (this.playDataCase_ != WeeklyPlayData.PlayDataOneofCase.RogueWeeklyPlayData)
				{
					return null;
				}
				return (RogueWeeklyPlayData)this.playData_;
			}
			set
			{
				this.playData_ = value;
				this.playDataCase_ = ((value == null) ? WeeklyPlayData.PlayDataOneofCase.None : WeeklyPlayData.PlayDataOneofCase.RogueWeeklyPlayData);
			}
		}

		// Token: 0x17006013 RID: 24595
		// (get) Token: 0x0601C7FA RID: 116730 RVA: 0x0041D8CD File Offset: 0x0041BACD
		// (set) Token: 0x0601C7FB RID: 116731 RVA: 0x0041D8E9 File Offset: 0x0041BAE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroFarmPlayData FloroFarmPlayData
		{
			get
			{
				if (this.playDataCase_ != WeeklyPlayData.PlayDataOneofCase.FloroFarmPlayData)
				{
					return null;
				}
				return (FloroFarmPlayData)this.playData_;
			}
			set
			{
				this.playData_ = value;
				this.playDataCase_ = ((value == null) ? WeeklyPlayData.PlayDataOneofCase.None : WeeklyPlayData.PlayDataOneofCase.FloroFarmPlayData);
			}
		}

		// Token: 0x17006014 RID: 24596
		// (get) Token: 0x0601C7FC RID: 116732 RVA: 0x0041D903 File Offset: 0x0041BB03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeeklyPlayData.PlayDataOneofCase PlayDataCase
		{
			get
			{
				return this.playDataCase_;
			}
		}

		// Token: 0x0601C7FD RID: 116733 RVA: 0x0041D90B File Offset: 0x0041BB0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearPlayData()
		{
			this.playDataCase_ = WeeklyPlayData.PlayDataOneofCase.None;
			this.playData_ = null;
		}

		// Token: 0x0601C7FE RID: 116734 RVA: 0x0041D91B File Offset: 0x0041BB1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WeeklyPlayData);
		}

		// Token: 0x0601C7FF RID: 116735 RVA: 0x0041D92C File Offset: 0x0041BB2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WeeklyPlayData other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Type == other.Type && object.Equals(this.RogueWeeklyPlayData, other.RogueWeeklyPlayData) && object.Equals(this.FloroFarmPlayData, other.FloroFarmPlayData) && this.PlayDataCase == other.PlayDataCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C800 RID: 116736 RVA: 0x0041D9B0 File Offset: 0x0041BBB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Type != ActivityType.Parkour)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.playDataCase_ == WeeklyPlayData.PlayDataOneofCase.RogueWeeklyPlayData)
			{
				num ^= this.RogueWeeklyPlayData.GetHashCode();
			}
			if (this.playDataCase_ == WeeklyPlayData.PlayDataOneofCase.FloroFarmPlayData)
			{
				num ^= this.FloroFarmPlayData.GetHashCode();
			}
			num ^= (int)this.playDataCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C801 RID: 116737 RVA: 0x0041DA4D File Offset: 0x0041BC4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C802 RID: 116738 RVA: 0x0041DA5A File Offset: 0x0041BC5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C803 RID: 116739 RVA: 0x0041DA64 File Offset: 0x0041BC64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.Type != ActivityType.Parkour)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.Type);
			}
			if (this.playDataCase_ == WeeklyPlayData.PlayDataOneofCase.RogueWeeklyPlayData)
			{
				output.WriteRawTag(130, 241, 4);
				output.WriteMessage(this.RogueWeeklyPlayData);
			}
			if (this.playDataCase_ == WeeklyPlayData.PlayDataOneofCase.FloroFarmPlayData)
			{
				output.WriteRawTag(138, 241, 4);
				output.WriteMessage(this.FloroFarmPlayData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C804 RID: 116740 RVA: 0x0041DB10 File Offset: 0x0041BD10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.Type != ActivityType.Parkour)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			if (this.playDataCase_ == WeeklyPlayData.PlayDataOneofCase.RogueWeeklyPlayData)
			{
				num += 3 + CodedOutputStream.ComputeMessageSize(this.RogueWeeklyPlayData);
			}
			if (this.playDataCase_ == WeeklyPlayData.PlayDataOneofCase.FloroFarmPlayData)
			{
				num += 3 + CodedOutputStream.ComputeMessageSize(this.FloroFarmPlayData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C805 RID: 116741 RVA: 0x0041DBA0 File Offset: 0x0041BDA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WeeklyPlayData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Type != ActivityType.Parkour)
			{
				this.Type = other.Type;
			}
			WeeklyPlayData.PlayDataOneofCase playDataCase = other.PlayDataCase;
			if (playDataCase != WeeklyPlayData.PlayDataOneofCase.RogueWeeklyPlayData)
			{
				if (playDataCase == WeeklyPlayData.PlayDataOneofCase.FloroFarmPlayData)
				{
					if (this.FloroFarmPlayData == null)
					{
						this.FloroFarmPlayData = new FloroFarmPlayData();
					}
					this.FloroFarmPlayData.MergeFrom(other.FloroFarmPlayData);
				}
			}
			else
			{
				if (this.RogueWeeklyPlayData == null)
				{
					this.RogueWeeklyPlayData = new RogueWeeklyPlayData();
				}
				this.RogueWeeklyPlayData.MergeFrom(other.RogueWeeklyPlayData);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C806 RID: 116742 RVA: 0x0041DC53 File Offset: 0x0041BE53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C807 RID: 116743 RVA: 0x0041DC5C File Offset: 0x0041BE5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if ((num & 7U) == 4U)
				{
					return;
				}
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.Id = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.Type = (ActivityType)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 80002U)
					{
						RogueWeeklyPlayData rogueWeeklyPlayData = new RogueWeeklyPlayData();
						if (this.playDataCase_ == WeeklyPlayData.PlayDataOneofCase.RogueWeeklyPlayData)
						{
							rogueWeeklyPlayData.MergeFrom(this.RogueWeeklyPlayData);
						}
						input.ReadMessage(rogueWeeklyPlayData);
						this.RogueWeeklyPlayData = rogueWeeklyPlayData;
						continue;
					}
					if (num == 80010U)
					{
						FloroFarmPlayData floroFarmPlayData = new FloroFarmPlayData();
						if (this.playDataCase_ == WeeklyPlayData.PlayDataOneofCase.FloroFarmPlayData)
						{
							floroFarmPlayData.MergeFrom(this.FloroFarmPlayData);
						}
						input.ReadMessage(floroFarmPlayData);
						this.FloroFarmPlayData = floroFarmPlayData;
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400A30F RID: 41743
		private static readonly MessageParser<WeeklyPlayData> _parser = new MessageParser<WeeklyPlayData>(() => new WeeklyPlayData());

		// Token: 0x0400A310 RID: 41744
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A311 RID: 41745
		public const int IdFieldNumber = 1;

		// Token: 0x0400A312 RID: 41746
		private int id_;

		// Token: 0x0400A313 RID: 41747
		public const int TypeFieldNumber = 2;

		// Token: 0x0400A314 RID: 41748
		private ActivityType type_;

		// Token: 0x0400A315 RID: 41749
		public const int RogueWeeklyPlayDataFieldNumber = 10000;

		// Token: 0x0400A316 RID: 41750
		public const int FloroFarmPlayDataFieldNumber = 10001;

		// Token: 0x0400A317 RID: 41751
		private object playData_;

		// Token: 0x0400A318 RID: 41752
		private WeeklyPlayData.PlayDataOneofCase playDataCase_;

		// Token: 0x020019F4 RID: 6644
		public enum PlayDataOneofCase
		{
			// Token: 0x0400CADF RID: 51935
			None,
			// Token: 0x0400CAE0 RID: 51936
			RogueWeeklyPlayData = 10000,
			// Token: 0x0400CAE1 RID: 51937
			FloroFarmPlayData
		}
	}
}
