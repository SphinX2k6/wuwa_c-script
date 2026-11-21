using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000731 RID: 1841
	[NetMessage(EMessageId.HarvestActivityPointNotify)]
	public sealed class HarvestActivityPointNotify : IMessage<HarvestActivityPointNotify>, IMessage, IEquatable<HarvestActivityPointNotify>, IDeepCloneable<HarvestActivityPointNotify>, IBufferMessage
	{
		// Token: 0x0600A73C RID: 42812 RVA: 0x00192DF6 File Offset: 0x00190FF6
		[NullableContext(1)]
		public static HarvestActivityPointNotify Create()
		{
			return new HarvestActivityPointNotify();
		}

		// Token: 0x1700219B RID: 8603
		// (get) Token: 0x0600A73D RID: 42813 RVA: 0x00192DFD File Offset: 0x00190FFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700219C RID: 8604
		// (get) Token: 0x0600A73E RID: 42814 RVA: 0x00192E00 File Offset: 0x00191000
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HarvestActivityPointNotify.Descriptor;
			}
		}

		// Token: 0x0600A73F RID: 42815 RVA: 0x00192E07 File Offset: 0x00191007
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HarvestActivityPointNotify()
		{
		}

		// Token: 0x0600A740 RID: 42816 RVA: 0x00192E1A File Offset: 0x0019101A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HarvestActivityPointNotify(HarvestActivityPointNotify other) : this()
		{
			this.activityId_ = other.activityId_;
			this.harvestPointReward_ = other.harvestPointReward_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A741 RID: 42817 RVA: 0x00192E50 File Offset: 0x00191050
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HarvestActivityPointNotify Clone()
		{
			return new HarvestActivityPointNotify(this);
		}

		// Token: 0x1700219D RID: 8605
		// (get) Token: 0x0600A742 RID: 42818 RVA: 0x00192E58 File Offset: 0x00191058
		// (set) Token: 0x0600A743 RID: 42819 RVA: 0x00192E60 File Offset: 0x00191060
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x1700219E RID: 8606
		// (get) Token: 0x0600A744 RID: 42820 RVA: 0x00192E69 File Offset: 0x00191069
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<HarvestPointReward> HarvestPointReward
		{
			get
			{
				return this.harvestPointReward_;
			}
		}

		// Token: 0x0600A745 RID: 42821 RVA: 0x00192E71 File Offset: 0x00191071
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HarvestActivityPointNotify);
		}

		// Token: 0x0600A746 RID: 42822 RVA: 0x00192E80 File Offset: 0x00191080
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HarvestActivityPointNotify other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.harvestPointReward_.Equals(other.harvestPointReward_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A747 RID: 42823 RVA: 0x00192ED0 File Offset: 0x001910D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			num ^= this.harvestPointReward_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A748 RID: 42824 RVA: 0x00192F1D File Offset: 0x0019111D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A749 RID: 42825 RVA: 0x00192F2A File Offset: 0x0019112A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A74A RID: 42826 RVA: 0x00192F34 File Offset: 0x00191134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.harvestPointReward_.WriteTo(ref output, HarvestActivityPointNotify._repeated_harvestPointReward_codec);
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A74B RID: 42827 RVA: 0x00192F84 File Offset: 0x00191184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			num += this.harvestPointReward_.CalculateSize(HarvestActivityPointNotify._repeated_harvestPointReward_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A74C RID: 42828 RVA: 0x00192FD8 File Offset: 0x001911D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HarvestActivityPointNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this.harvestPointReward_.Add(other.harvestPointReward_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A74D RID: 42829 RVA: 0x00193025 File Offset: 0x00191225
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A74E RID: 42830 RVA: 0x00193030 File Offset: 0x00191230
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
				if (num != 18U)
				{
					if (num != 24U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ActivityId = input.ReadInt32();
					}
				}
				else
				{
					this.harvestPointReward_.AddEntriesFrom(ref input, HarvestActivityPointNotify._repeated_harvestPointReward_codec);
				}
			}
		}

		// Token: 0x04004CD8 RID: 19672
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004CD9 RID: 19673
		public const int ActivityIdFieldNumber = 3;

		// Token: 0x04004CDA RID: 19674
		private int activityId_;

		// Token: 0x04004CDB RID: 19675
		public const int HarvestPointRewardFieldNumber = 2;

		// Token: 0x04004CDC RID: 19676
		private static readonly FieldCodec<HarvestPointReward> _repeated_harvestPointReward_codec = FieldCodec.ForMessage<HarvestPointReward>(18U, Aki.Protocol.HarvestPointReward.Parser);

		// Token: 0x04004CDD RID: 19677
		private readonly RepeatedField<HarvestPointReward> harvestPointReward_ = new RepeatedField<HarvestPointReward>();
	}
}
