using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200072B RID: 1835
	public sealed class HarvestActivity : IMessage<HarvestActivity>, IMessage, IEquatable<HarvestActivity>, IDeepCloneable<HarvestActivity>, IBufferMessage
	{
		// Token: 0x0600A6C5 RID: 42693 RVA: 0x00191E39 File Offset: 0x00190039
		[NullableContext(1)]
		public static HarvestActivity Create()
		{
			return new HarvestActivity();
		}

		// Token: 0x17002183 RID: 8579
		// (get) Token: 0x0600A6C6 RID: 42694 RVA: 0x00191E40 File Offset: 0x00190040
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002184 RID: 8580
		// (get) Token: 0x0600A6C7 RID: 42695 RVA: 0x00191E43 File Offset: 0x00190043
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HarvestActivity.Descriptor;
			}
		}

		// Token: 0x0600A6C8 RID: 42696 RVA: 0x00191E4A File Offset: 0x0019004A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HarvestActivity()
		{
		}

		// Token: 0x0600A6C9 RID: 42697 RVA: 0x00191E68 File Offset: 0x00190068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HarvestActivity(HarvestActivity other) : this()
		{
			this.harvestPointRewards_ = other.harvestPointRewards_.Clone();
			this.harvestLevelRewards_ = other.harvestLevelRewards_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A6CA RID: 42698 RVA: 0x00191EA3 File Offset: 0x001900A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HarvestActivity Clone()
		{
			return new HarvestActivity(this);
		}

		// Token: 0x17002185 RID: 8581
		// (get) Token: 0x0600A6CB RID: 42699 RVA: 0x00191EAB File Offset: 0x001900AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<HarvestPointReward> HarvestPointRewards
		{
			get
			{
				return this.harvestPointRewards_;
			}
		}

		// Token: 0x17002186 RID: 8582
		// (get) Token: 0x0600A6CC RID: 42700 RVA: 0x00191EB3 File Offset: 0x001900B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<HarvestLevelReward> HarvestLevelRewards
		{
			get
			{
				return this.harvestLevelRewards_;
			}
		}

		// Token: 0x0600A6CD RID: 42701 RVA: 0x00191EBB File Offset: 0x001900BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HarvestActivity);
		}

		// Token: 0x0600A6CE RID: 42702 RVA: 0x00191ECC File Offset: 0x001900CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HarvestActivity other)
		{
			return other != null && (other == this || (this.harvestPointRewards_.Equals(other.harvestPointRewards_) && this.harvestLevelRewards_.Equals(other.harvestLevelRewards_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A6CF RID: 42703 RVA: 0x00191F20 File Offset: 0x00190120
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.harvestPointRewards_.GetHashCode();
			num ^= this.harvestLevelRewards_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A6D0 RID: 42704 RVA: 0x00191F62 File Offset: 0x00190162
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A6D1 RID: 42705 RVA: 0x00191F6F File Offset: 0x0019016F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A6D2 RID: 42706 RVA: 0x00191F78 File Offset: 0x00190178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.harvestPointRewards_.WriteTo(ref output, HarvestActivity._repeated_harvestPointRewards_codec);
			this.harvestLevelRewards_.WriteTo(ref output, HarvestActivity._repeated_harvestLevelRewards_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A6D3 RID: 42707 RVA: 0x00191FB0 File Offset: 0x001901B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.harvestPointRewards_.CalculateSize(HarvestActivity._repeated_harvestPointRewards_codec);
			num += this.harvestLevelRewards_.CalculateSize(HarvestActivity._repeated_harvestLevelRewards_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A6D4 RID: 42708 RVA: 0x00191FFC File Offset: 0x001901FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HarvestActivity other)
		{
			if (other == null)
			{
				return;
			}
			this.harvestPointRewards_.Add(other.harvestPointRewards_);
			this.harvestLevelRewards_.Add(other.harvestLevelRewards_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A6D5 RID: 42709 RVA: 0x0019203B File Offset: 0x0019023B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A6D6 RID: 42710 RVA: 0x00192044 File Offset: 0x00190244
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
				if (num != 10U)
				{
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.harvestLevelRewards_.AddEntriesFrom(ref input, HarvestActivity._repeated_harvestLevelRewards_codec);
					}
				}
				else
				{
					this.harvestPointRewards_.AddEntriesFrom(ref input, HarvestActivity._repeated_harvestPointRewards_codec);
				}
			}
		}

		// Token: 0x04004CB6 RID: 19638
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004CB7 RID: 19639
		public const int HarvestPointRewardsFieldNumber = 1;

		// Token: 0x04004CB8 RID: 19640
		private static readonly FieldCodec<HarvestPointReward> _repeated_harvestPointRewards_codec = FieldCodec.ForMessage<HarvestPointReward>(10U, HarvestPointReward.Parser);

		// Token: 0x04004CB9 RID: 19641
		private readonly RepeatedField<HarvestPointReward> harvestPointRewards_ = new RepeatedField<HarvestPointReward>();

		// Token: 0x04004CBA RID: 19642
		public const int HarvestLevelRewardsFieldNumber = 2;

		// Token: 0x04004CBB RID: 19643
		private static readonly FieldCodec<HarvestLevelReward> _repeated_harvestLevelRewards_codec = FieldCodec.ForMessage<HarvestLevelReward>(18U, HarvestLevelReward.Parser);

		// Token: 0x04004CBC RID: 19644
		private readonly RepeatedField<HarvestLevelReward> harvestLevelRewards_ = new RepeatedField<HarvestLevelReward>();
	}
}
