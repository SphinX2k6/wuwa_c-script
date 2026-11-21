using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000915 RID: 2325
	public sealed class LinkageCheckInActivityData : IMessage<LinkageCheckInActivityData>, IMessage, IEquatable<LinkageCheckInActivityData>, IDeepCloneable<LinkageCheckInActivityData>, IBufferMessage
	{
		// Token: 0x0600CD7A RID: 52602 RVA: 0x001E4AF9 File Offset: 0x001E2CF9
		[NullableContext(1)]
		public static LinkageCheckInActivityData Create()
		{
			return new LinkageCheckInActivityData();
		}

		// Token: 0x1700297D RID: 10621
		// (get) Token: 0x0600CD7B RID: 52603 RVA: 0x001E4B00 File Offset: 0x001E2D00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700297E RID: 10622
		// (get) Token: 0x0600CD7C RID: 52604 RVA: 0x001E4B03 File Offset: 0x001E2D03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LinkageCheckInActivityData.Descriptor;
			}
		}

		// Token: 0x0600CD7D RID: 52605 RVA: 0x001E4B0A File Offset: 0x001E2D0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LinkageCheckInActivityData()
		{
		}

		// Token: 0x0600CD7E RID: 52606 RVA: 0x001E4B28 File Offset: 0x001E2D28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LinkageCheckInActivityData(LinkageCheckInActivityData other) : this()
		{
			this.checkInDay_ = other.checkInDay_;
			this.normalReward_ = other.normalReward_.Clone();
			this.keepReward_ = other.keepReward_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CD7F RID: 52607 RVA: 0x001E4B7A File Offset: 0x001E2D7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LinkageCheckInActivityData Clone()
		{
			return new LinkageCheckInActivityData(this);
		}

		// Token: 0x1700297F RID: 10623
		// (get) Token: 0x0600CD80 RID: 52608 RVA: 0x001E4B82 File Offset: 0x001E2D82
		// (set) Token: 0x0600CD81 RID: 52609 RVA: 0x001E4B8A File Offset: 0x001E2D8A
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

		// Token: 0x17002980 RID: 10624
		// (get) Token: 0x0600CD82 RID: 52610 RVA: 0x001E4B93 File Offset: 0x001E2D93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> NormalReward
		{
			get
			{
				return this.normalReward_;
			}
		}

		// Token: 0x17002981 RID: 10625
		// (get) Token: 0x0600CD83 RID: 52611 RVA: 0x001E4B9B File Offset: 0x001E2D9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> KeepReward
		{
			get
			{
				return this.keepReward_;
			}
		}

		// Token: 0x0600CD84 RID: 52612 RVA: 0x001E4BA3 File Offset: 0x001E2DA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LinkageCheckInActivityData);
		}

		// Token: 0x0600CD85 RID: 52613 RVA: 0x001E4BB4 File Offset: 0x001E2DB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LinkageCheckInActivityData other)
		{
			return other != null && (other == this || (this.CheckInDay == other.CheckInDay && this.normalReward_.Equals(other.normalReward_) && this.keepReward_.Equals(other.keepReward_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CD86 RID: 52614 RVA: 0x001E4C18 File Offset: 0x001E2E18
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

		// Token: 0x0600CD87 RID: 52615 RVA: 0x001E4C73 File Offset: 0x001E2E73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CD88 RID: 52616 RVA: 0x001E4C80 File Offset: 0x001E2E80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CD89 RID: 52617 RVA: 0x001E4C8C File Offset: 0x001E2E8C
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

		// Token: 0x0600CD8A RID: 52618 RVA: 0x001E4CEC File Offset: 0x001E2EEC
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

		// Token: 0x0600CD8B RID: 52619 RVA: 0x001E4D50 File Offset: 0x001E2F50
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

		// Token: 0x0600CD8C RID: 52620 RVA: 0x001E4DAE File Offset: 0x001E2FAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CD8D RID: 52621 RVA: 0x001E4DB8 File Offset: 0x001E2FB8
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

		// Token: 0x0400574F RID: 22351
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005750 RID: 22352
		public const int CheckInDayFieldNumber = 1;

		// Token: 0x04005751 RID: 22353
		private int checkInDay_;

		// Token: 0x04005752 RID: 22354
		public const int NormalRewardFieldNumber = 2;

		// Token: 0x04005753 RID: 22355
		private static readonly FieldCodec<int> _repeated_normalReward_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04005754 RID: 22356
		private readonly RepeatedField<int> normalReward_ = new RepeatedField<int>();

		// Token: 0x04005755 RID: 22357
		public const int KeepRewardFieldNumber = 3;

		// Token: 0x04005756 RID: 22358
		private static readonly FieldCodec<int> _repeated_keepReward_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04005757 RID: 22359
		private readonly RepeatedField<int> keepReward_ = new RepeatedField<int>();
	}
}
