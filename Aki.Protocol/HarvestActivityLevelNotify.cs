using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200072E RID: 1838
	[NetMessage(EMessageId.HarvestActivityLevelNotify)]
	public sealed class HarvestActivityLevelNotify : IMessage<HarvestActivityLevelNotify>, IMessage, IEquatable<HarvestActivityLevelNotify>, IDeepCloneable<HarvestActivityLevelNotify>, IBufferMessage
	{
		// Token: 0x0600A700 RID: 42752 RVA: 0x001925F5 File Offset: 0x001907F5
		[NullableContext(1)]
		public static HarvestActivityLevelNotify Create()
		{
			return new HarvestActivityLevelNotify();
		}

		// Token: 0x1700218F RID: 8591
		// (get) Token: 0x0600A701 RID: 42753 RVA: 0x001925FC File Offset: 0x001907FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002190 RID: 8592
		// (get) Token: 0x0600A702 RID: 42754 RVA: 0x001925FF File Offset: 0x001907FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HarvestActivityLevelNotify.Descriptor;
			}
		}

		// Token: 0x0600A703 RID: 42755 RVA: 0x00192606 File Offset: 0x00190806
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HarvestActivityLevelNotify()
		{
		}

		// Token: 0x0600A704 RID: 42756 RVA: 0x00192619 File Offset: 0x00190819
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HarvestActivityLevelNotify(HarvestActivityLevelNotify other) : this()
		{
			this.activityId_ = other.activityId_;
			this.harvestLevelRewards_ = other.harvestLevelRewards_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A705 RID: 42757 RVA: 0x0019264F File Offset: 0x0019084F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HarvestActivityLevelNotify Clone()
		{
			return new HarvestActivityLevelNotify(this);
		}

		// Token: 0x17002191 RID: 8593
		// (get) Token: 0x0600A706 RID: 42758 RVA: 0x00192657 File Offset: 0x00190857
		// (set) Token: 0x0600A707 RID: 42759 RVA: 0x0019265F File Offset: 0x0019085F
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

		// Token: 0x17002192 RID: 8594
		// (get) Token: 0x0600A708 RID: 42760 RVA: 0x00192668 File Offset: 0x00190868
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<HarvestLevelReward> HarvestLevelRewards
		{
			get
			{
				return this.harvestLevelRewards_;
			}
		}

		// Token: 0x0600A709 RID: 42761 RVA: 0x00192670 File Offset: 0x00190870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HarvestActivityLevelNotify);
		}

		// Token: 0x0600A70A RID: 42762 RVA: 0x00192680 File Offset: 0x00190880
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HarvestActivityLevelNotify other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.harvestLevelRewards_.Equals(other.harvestLevelRewards_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A70B RID: 42763 RVA: 0x001926D0 File Offset: 0x001908D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			num ^= this.harvestLevelRewards_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A70C RID: 42764 RVA: 0x0019271D File Offset: 0x0019091D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A70D RID: 42765 RVA: 0x0019272A File Offset: 0x0019092A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A70E RID: 42766 RVA: 0x00192734 File Offset: 0x00190934
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.harvestLevelRewards_.WriteTo(ref output, HarvestActivityLevelNotify._repeated_harvestLevelRewards_codec);
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A70F RID: 42767 RVA: 0x00192784 File Offset: 0x00190984
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			num += this.harvestLevelRewards_.CalculateSize(HarvestActivityLevelNotify._repeated_harvestLevelRewards_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A710 RID: 42768 RVA: 0x001927D8 File Offset: 0x001909D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HarvestActivityLevelNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this.harvestLevelRewards_.Add(other.harvestLevelRewards_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A711 RID: 42769 RVA: 0x00192825 File Offset: 0x00190A25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A712 RID: 42770 RVA: 0x00192830 File Offset: 0x00190A30
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
				if (num != 74U)
				{
					if (num != 120U)
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
					this.harvestLevelRewards_.AddEntriesFrom(ref input, HarvestActivityLevelNotify._repeated_harvestLevelRewards_codec);
				}
			}
		}

		// Token: 0x04004CC7 RID: 19655
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004CC8 RID: 19656
		public const int ActivityIdFieldNumber = 15;

		// Token: 0x04004CC9 RID: 19657
		private int activityId_;

		// Token: 0x04004CCA RID: 19658
		public const int HarvestLevelRewardsFieldNumber = 9;

		// Token: 0x04004CCB RID: 19659
		private static readonly FieldCodec<HarvestLevelReward> _repeated_harvestLevelRewards_codec = FieldCodec.ForMessage<HarvestLevelReward>(74U, HarvestLevelReward.Parser);

		// Token: 0x04004CCC RID: 19660
		private readonly RepeatedField<HarvestLevelReward> harvestLevelRewards_ = new RepeatedField<HarvestLevelReward>();
	}
}
