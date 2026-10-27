using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000926 RID: 2342
	public sealed class LinkageCheckInActivityData : IMessage<LinkageCheckInActivityData>, IMessage, IEquatable<LinkageCheckInActivityData>, IDeepCloneable<LinkageCheckInActivityData>, IBufferMessage
	{
		// Token: 0x0600CE96 RID: 52886 RVA: 0x001E6DC9 File Offset: 0x001E4FC9
		[NullableContext(1)]
		public static LinkageCheckInActivityData Create()
		{
			return new LinkageCheckInActivityData();
		}

		// Token: 0x170029BC RID: 10684
		// (get) Token: 0x0600CE97 RID: 52887 RVA: 0x001E6DD0 File Offset: 0x001E4FD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170029BD RID: 10685
		// (get) Token: 0x0600CE98 RID: 52888 RVA: 0x001E6DD3 File Offset: 0x001E4FD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LinkageCheckInActivityData.Descriptor;
			}
		}

		// Token: 0x0600CE99 RID: 52889 RVA: 0x001E6DDA File Offset: 0x001E4FDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LinkageCheckInActivityData()
		{
		}

		// Token: 0x0600CE9A RID: 52890 RVA: 0x001E6DF8 File Offset: 0x001E4FF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LinkageCheckInActivityData(LinkageCheckInActivityData other) : this()
		{
			this.checkInDay_ = other.checkInDay_;
			this.normalReward_ = other.normalReward_.Clone();
			this.keepReward_ = other.keepReward_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CE9B RID: 52891 RVA: 0x001E6E4A File Offset: 0x001E504A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LinkageCheckInActivityData Clone()
		{
			return new LinkageCheckInActivityData(this);
		}

		// Token: 0x170029BE RID: 10686
		// (get) Token: 0x0600CE9C RID: 52892 RVA: 0x001E6E52 File Offset: 0x001E5052
		// (set) Token: 0x0600CE9D RID: 52893 RVA: 0x001E6E5A File Offset: 0x001E505A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CheckInDay
		{
			get
			{
				return this.checkInDay_;
			}
			set
			{
				this.checkInDay_ = value;
			}
		}

		// Token: 0x170029BF RID: 10687
		// (get) Token: 0x0600CE9E RID: 52894 RVA: 0x001E6E63 File Offset: 0x001E5063
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> NormalReward
		{
			get
			{
				return this.normalReward_;
			}
		}

		// Token: 0x170029C0 RID: 10688
		// (get) Token: 0x0600CE9F RID: 52895 RVA: 0x001E6E6B File Offset: 0x001E506B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> KeepReward
		{
			get
			{
				return this.keepReward_;
			}
		}

		// Token: 0x0600CEA0 RID: 52896 RVA: 0x001E6E73 File Offset: 0x001E5073
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LinkageCheckInActivityData);
		}

		// Token: 0x0600CEA1 RID: 52897 RVA: 0x001E6E84 File Offset: 0x001E5084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LinkageCheckInActivityData other)
		{
			return other != null && (other == this || (this.CheckInDay == other.CheckInDay && this.normalReward_.Equals(other.normalReward_) && this.keepReward_.Equals(other.keepReward_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CEA2 RID: 52898 RVA: 0x001E6EE8 File Offset: 0x001E50E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CheckInDay != 0)
			{
				num ^= this.CheckInDay.GetHashCode();
			}
			num ^= this.normalReward_.GetHashCode();
			num ^= this.keepReward_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CEA3 RID: 52899 RVA: 0x001E6F43 File Offset: 0x001E5143
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CEA4 RID: 52900 RVA: 0x001E6F50 File Offset: 0x001E5150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CEA5 RID: 52901 RVA: 0x001E6F5C File Offset: 0x001E515C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CheckInDay != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.CheckInDay);
			}
			this.normalReward_.WriteTo(ref output, LinkageCheckInActivityData._repeated_normalReward_codec);
			this.keepReward_.WriteTo(ref output, LinkageCheckInActivityData._repeated_keepReward_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CEA6 RID: 52902 RVA: 0x001E6FBC File Offset: 0x001E51BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CheckInDay != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CheckInDay);
			}
			num += this.normalReward_.CalculateSize(LinkageCheckInActivityData._repeated_normalReward_codec);
			num += this.keepReward_.CalculateSize(LinkageCheckInActivityData._repeated_keepReward_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CEA7 RID: 52903 RVA: 0x001E7020 File Offset: 0x001E5220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LinkageCheckInActivityData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CheckInDay != 0)
			{
				this.CheckInDay = other.CheckInDay;
			}
			this.normalReward_.Add(other.normalReward_);
			this.keepReward_.Add(other.keepReward_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CEA8 RID: 52904 RVA: 0x001E707E File Offset: 0x001E527E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CEA9 RID: 52905 RVA: 0x001E7088 File Offset: 0x001E5288
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
						this.CheckInDay = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						goto IL_4A;
					}
				}
				else
				{
					if (num == 18U)
					{
						goto IL_4A;
					}
					if (num == 24U || num == 26U)
					{
						this.keepReward_.AddEntriesFrom(ref input, LinkageCheckInActivityData._repeated_keepReward_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_4A:
				this.normalReward_.AddEntriesFrom(ref input, LinkageCheckInActivityData._repeated_normalReward_codec);
			}
		}

		// Token: 0x04005748 RID: 22344
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005749 RID: 22345
		public const int CheckInDayFieldNumber = 1;

		// Token: 0x0400574A RID: 22346
		private int checkInDay_;

		// Token: 0x0400574B RID: 22347
		public const int NormalRewardFieldNumber = 2;

		// Token: 0x0400574C RID: 22348
		private static readonly FieldCodec<int> _repeated_normalReward_codec = FieldCodec.ForInt32(18U);

		// Token: 0x0400574D RID: 22349
		private readonly RepeatedField<int> normalReward_ = new RepeatedField<int>();

		// Token: 0x0400574E RID: 22350
		public const int KeepRewardFieldNumber = 3;

		// Token: 0x0400574F RID: 22351
		private static readonly FieldCodec<int> _repeated_keepReward_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04005750 RID: 22352
		private readonly RepeatedField<int> keepReward_ = new RepeatedField<int>();
	}
}
