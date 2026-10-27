using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200073F RID: 1855
	public sealed class HarvestActivity : IMessage<HarvestActivity>, IMessage, IEquatable<HarvestActivity>, IDeepCloneable<HarvestActivity>, IBufferMessage
	{
		// Token: 0x0600A81B RID: 43035 RVA: 0x00194865 File Offset: 0x00192A65
		[NullableContext(1)]
		public static HarvestActivity Create()
		{
			return new HarvestActivity();
		}

		// Token: 0x170021CD RID: 8653
		// (get) Token: 0x0600A81C RID: 43036 RVA: 0x0019486C File Offset: 0x00192A6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170021CE RID: 8654
		// (get) Token: 0x0600A81D RID: 43037 RVA: 0x0019486F File Offset: 0x00192A6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HarvestActivity.Descriptor;
			}
		}

		// Token: 0x0600A81E RID: 43038 RVA: 0x00194876 File Offset: 0x00192A76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HarvestActivity()
		{
		}

		// Token: 0x0600A81F RID: 43039 RVA: 0x00194894 File Offset: 0x00192A94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HarvestActivity(HarvestActivity other) : this()
		{
			this.harvestPointRewards_ = other.harvestPointRewards_.Clone();
			this.harvestLevelRewards_ = other.harvestLevelRewards_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A820 RID: 43040 RVA: 0x001948CF File Offset: 0x00192ACF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HarvestActivity Clone()
		{
			return new HarvestActivity(this);
		}

		// Token: 0x170021CF RID: 8655
		// (get) Token: 0x0600A821 RID: 43041 RVA: 0x001948D7 File Offset: 0x00192AD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<HarvestPointReward> HarvestPointRewards
		{
			get
			{
				return this.harvestPointRewards_;
			}
		}

		// Token: 0x170021D0 RID: 8656
		// (get) Token: 0x0600A822 RID: 43042 RVA: 0x001948DF File Offset: 0x00192ADF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<HarvestLevelReward> HarvestLevelRewards
		{
			get
			{
				return this.harvestLevelRewards_;
			}
		}

		// Token: 0x0600A823 RID: 43043 RVA: 0x001948E7 File Offset: 0x00192AE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HarvestActivity);
		}

		// Token: 0x0600A824 RID: 43044 RVA: 0x001948F8 File Offset: 0x00192AF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HarvestActivity other)
		{
			return other != null && (other == this || (this.harvestPointRewards_.Equals(other.harvestPointRewards_) && this.harvestLevelRewards_.Equals(other.harvestLevelRewards_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A825 RID: 43045 RVA: 0x0019494C File Offset: 0x00192B4C
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

		// Token: 0x0600A826 RID: 43046 RVA: 0x0019498E File Offset: 0x00192B8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A827 RID: 43047 RVA: 0x0019499B File Offset: 0x00192B9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A828 RID: 43048 RVA: 0x001949A4 File Offset: 0x00192BA4
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

		// Token: 0x0600A829 RID: 43049 RVA: 0x001949DC File Offset: 0x00192BDC
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

		// Token: 0x0600A82A RID: 43050 RVA: 0x00194A28 File Offset: 0x00192C28
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

		// Token: 0x0600A82B RID: 43051 RVA: 0x00194A67 File Offset: 0x00192C67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A82C RID: 43052 RVA: 0x00194A70 File Offset: 0x00192C70
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

		// Token: 0x04004CBD RID: 19645
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004CBE RID: 19646
		public const int HarvestPointRewardsFieldNumber = 1;

		// Token: 0x04004CBF RID: 19647
		private static readonly FieldCodec<HarvestPointReward> _repeated_harvestPointRewards_codec = FieldCodec.ForMessage<HarvestPointReward>(10U, HarvestPointReward.Parser);

		// Token: 0x04004CC0 RID: 19648
		private readonly RepeatedField<HarvestPointReward> harvestPointRewards_ = new RepeatedField<HarvestPointReward>();

		// Token: 0x04004CC1 RID: 19649
		public const int HarvestLevelRewardsFieldNumber = 2;

		// Token: 0x04004CC2 RID: 19650
		private static readonly FieldCodec<HarvestLevelReward> _repeated_harvestLevelRewards_codec = FieldCodec.ForMessage<HarvestLevelReward>(18U, HarvestLevelReward.Parser);

		// Token: 0x04004CC3 RID: 19651
		private readonly RepeatedField<HarvestLevelReward> harvestLevelRewards_ = new RepeatedField<HarvestLevelReward>();
	}
}
