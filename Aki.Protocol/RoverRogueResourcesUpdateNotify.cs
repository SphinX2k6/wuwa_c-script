using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200111A RID: 4378
	[NetMessage(EMessageId.RoverRogueResourcesUpdateNotify)]
	public sealed class RoverRogueResourcesUpdateNotify : IMessage<RoverRogueResourcesUpdateNotify>, IMessage, IEquatable<RoverRogueResourcesUpdateNotify>, IDeepCloneable<RoverRogueResourcesUpdateNotify>, IBufferMessage
	{
		// Token: 0x0601758C RID: 95628 RVA: 0x0036398F File Offset: 0x00361B8F
		[NullableContext(1)]
		public static RoverRogueResourcesUpdateNotify Create()
		{
			return new RoverRogueResourcesUpdateNotify();
		}

		// Token: 0x17004E4B RID: 20043
		// (get) Token: 0x0601758D RID: 95629 RVA: 0x00363996 File Offset: 0x00361B96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004E4C RID: 20044
		// (get) Token: 0x0601758E RID: 95630 RVA: 0x00363999 File Offset: 0x00361B99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueResourcesUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0601758F RID: 95631 RVA: 0x003639A0 File Offset: 0x00361BA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueResourcesUpdateNotify()
		{
		}

		// Token: 0x06017590 RID: 95632 RVA: 0x003639C0 File Offset: 0x00361BC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueResourcesUpdateNotify(RoverRogueResourcesUpdateNotify other) : this()
		{
			this.hpMax_ = other.hpMax_;
			this.coin_ = other.coin_;
			this.talentPoint_ = other.talentPoint_;
			this.goldEfficiency_ = other.goldEfficiency_;
			this.item_ = other.item_.Clone();
			this.effectId_ = other.effectId_;
			this.attChange_ = other.attChange_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017591 RID: 95633 RVA: 0x00363A42 File Offset: 0x00361C42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueResourcesUpdateNotify Clone()
		{
			return new RoverRogueResourcesUpdateNotify(this);
		}

		// Token: 0x17004E4D RID: 20045
		// (get) Token: 0x06017592 RID: 95634 RVA: 0x00363A4A File Offset: 0x00361C4A
		// (set) Token: 0x06017593 RID: 95635 RVA: 0x00363A52 File Offset: 0x00361C52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HpMax
		{
			get
			{
				return this.hpMax_;
			}
			set
			{
				this.hpMax_ = value;
			}
		}

		// Token: 0x17004E4E RID: 20046
		// (get) Token: 0x06017594 RID: 95636 RVA: 0x00363A5B File Offset: 0x00361C5B
		// (set) Token: 0x06017595 RID: 95637 RVA: 0x00363A63 File Offset: 0x00361C63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Coin
		{
			get
			{
				return this.coin_;
			}
			set
			{
				this.coin_ = value;
			}
		}

		// Token: 0x17004E4F RID: 20047
		// (get) Token: 0x06017596 RID: 95638 RVA: 0x00363A6C File Offset: 0x00361C6C
		// (set) Token: 0x06017597 RID: 95639 RVA: 0x00363A74 File Offset: 0x00361C74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TalentPoint
		{
			get
			{
				return this.talentPoint_;
			}
			set
			{
				this.talentPoint_ = value;
			}
		}

		// Token: 0x17004E50 RID: 20048
		// (get) Token: 0x06017598 RID: 95640 RVA: 0x00363A7D File Offset: 0x00361C7D
		// (set) Token: 0x06017599 RID: 95641 RVA: 0x00363A85 File Offset: 0x00361C85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GoldEfficiency
		{
			get
			{
				return this.goldEfficiency_;
			}
			set
			{
				this.goldEfficiency_ = value;
			}
		}

		// Token: 0x17004E51 RID: 20049
		// (get) Token: 0x0601759A RID: 95642 RVA: 0x00363A8E File Offset: 0x00361C8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoverRogueResourcesItem> Item
		{
			get
			{
				return this.item_;
			}
		}

		// Token: 0x17004E52 RID: 20050
		// (get) Token: 0x0601759B RID: 95643 RVA: 0x00363A96 File Offset: 0x00361C96
		// (set) Token: 0x0601759C RID: 95644 RVA: 0x00363A9E File Offset: 0x00361C9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EffectId
		{
			get
			{
				return this.effectId_;
			}
			set
			{
				this.effectId_ = value;
			}
		}

		// Token: 0x17004E53 RID: 20051
		// (get) Token: 0x0601759D RID: 95645 RVA: 0x00363AA7 File Offset: 0x00361CA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoverRogueAttChange> AttChange
		{
			get
			{
				return this.attChange_;
			}
		}

		// Token: 0x0601759E RID: 95646 RVA: 0x00363AAF File Offset: 0x00361CAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueResourcesUpdateNotify);
		}

		// Token: 0x0601759F RID: 95647 RVA: 0x00363AC0 File Offset: 0x00361CC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueResourcesUpdateNotify other)
		{
			return other != null && (other == this || (this.HpMax == other.HpMax && this.Coin == other.Coin && this.TalentPoint == other.TalentPoint && this.GoldEfficiency == other.GoldEfficiency && this.item_.Equals(other.item_) && this.EffectId == other.EffectId && this.attChange_.Equals(other.attChange_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060175A0 RID: 95648 RVA: 0x00363B64 File Offset: 0x00361D64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HpMax != 0)
			{
				num ^= this.HpMax.GetHashCode();
			}
			if (this.Coin != 0)
			{
				num ^= this.Coin.GetHashCode();
			}
			if (this.TalentPoint != 0)
			{
				num ^= this.TalentPoint.GetHashCode();
			}
			if (this.GoldEfficiency != 0)
			{
				num ^= this.GoldEfficiency.GetHashCode();
			}
			num ^= this.item_.GetHashCode();
			if (this.EffectId != 0)
			{
				num ^= this.EffectId.GetHashCode();
			}
			num ^= this.attChange_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060175A1 RID: 95649 RVA: 0x00363C23 File Offset: 0x00361E23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060175A2 RID: 95650 RVA: 0x00363C30 File Offset: 0x00361E30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060175A3 RID: 95651 RVA: 0x00363C3C File Offset: 0x00361E3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.attChange_.WriteTo(ref output, RoverRogueResourcesUpdateNotify._repeated_attChange_codec);
			if (this.Coin != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Coin);
			}
			if (this.HpMax != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.HpMax);
			}
			if (this.TalentPoint != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.TalentPoint);
			}
			this.item_.WriteTo(ref output, RoverRogueResourcesUpdateNotify._repeated_item_codec);
			if (this.EffectId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.EffectId);
			}
			if (this.GoldEfficiency != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.GoldEfficiency);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060175A4 RID: 95652 RVA: 0x00363D0C File Offset: 0x00361F0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HpMax != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HpMax);
			}
			if (this.Coin != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Coin);
			}
			if (this.TalentPoint != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TalentPoint);
			}
			if (this.GoldEfficiency != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GoldEfficiency);
			}
			num += this.item_.CalculateSize(RoverRogueResourcesUpdateNotify._repeated_item_codec);
			if (this.EffectId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EffectId);
			}
			num += this.attChange_.CalculateSize(RoverRogueResourcesUpdateNotify._repeated_attChange_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060175A5 RID: 95653 RVA: 0x00363DD0 File Offset: 0x00361FD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueResourcesUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HpMax != 0)
			{
				this.HpMax = other.HpMax;
			}
			if (other.Coin != 0)
			{
				this.Coin = other.Coin;
			}
			if (other.TalentPoint != 0)
			{
				this.TalentPoint = other.TalentPoint;
			}
			if (other.GoldEfficiency != 0)
			{
				this.GoldEfficiency = other.GoldEfficiency;
			}
			this.item_.Add(other.item_);
			if (other.EffectId != 0)
			{
				this.EffectId = other.EffectId;
			}
			this.attChange_.Add(other.attChange_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060175A6 RID: 95654 RVA: 0x00363E7E File Offset: 0x0036207E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060175A7 RID: 95655 RVA: 0x00363E88 File Offset: 0x00362088
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
				if (num <= 40U)
				{
					if (num == 18U)
					{
						this.attChange_.AddEntriesFrom(ref input, RoverRogueResourcesUpdateNotify._repeated_attChange_codec);
						continue;
					}
					if (num == 32U)
					{
						this.Coin = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.HpMax = input.ReadInt32();
						continue;
					}
				}
				else if (num <= 58U)
				{
					if (num == 48U)
					{
						this.TalentPoint = input.ReadInt32();
						continue;
					}
					if (num == 58U)
					{
						this.item_.AddEntriesFrom(ref input, RoverRogueResourcesUpdateNotify._repeated_item_codec);
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.EffectId = input.ReadInt32();
						continue;
					}
					if (num == 96U)
					{
						this.GoldEfficiency = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008AC8 RID: 35528
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008AC9 RID: 35529
		public const int HpMaxFieldNumber = 5;

		// Token: 0x04008ACA RID: 35530
		private int hpMax_;

		// Token: 0x04008ACB RID: 35531
		public const int CoinFieldNumber = 4;

		// Token: 0x04008ACC RID: 35532
		private int coin_;

		// Token: 0x04008ACD RID: 35533
		public const int TalentPointFieldNumber = 6;

		// Token: 0x04008ACE RID: 35534
		private int talentPoint_;

		// Token: 0x04008ACF RID: 35535
		public const int GoldEfficiencyFieldNumber = 12;

		// Token: 0x04008AD0 RID: 35536
		private int goldEfficiency_;

		// Token: 0x04008AD1 RID: 35537
		public const int ItemFieldNumber = 7;

		// Token: 0x04008AD2 RID: 35538
		private static readonly FieldCodec<RoverRogueResourcesItem> _repeated_item_codec = FieldCodec.ForMessage<RoverRogueResourcesItem>(58U, RoverRogueResourcesItem.Parser);

		// Token: 0x04008AD3 RID: 35539
		private readonly RepeatedField<RoverRogueResourcesItem> item_ = new RepeatedField<RoverRogueResourcesItem>();

		// Token: 0x04008AD4 RID: 35540
		public const int EffectIdFieldNumber = 10;

		// Token: 0x04008AD5 RID: 35541
		private int effectId_;

		// Token: 0x04008AD6 RID: 35542
		public const int AttChangeFieldNumber = 2;

		// Token: 0x04008AD7 RID: 35543
		private static readonly FieldCodec<RoverRogueAttChange> _repeated_attChange_codec = FieldCodec.ForMessage<RoverRogueAttChange>(18U, RoverRogueAttChange.Parser);

		// Token: 0x04008AD8 RID: 35544
		private readonly RepeatedField<RoverRogueAttChange> attChange_ = new RepeatedField<RoverRogueAttChange>();
	}
}
