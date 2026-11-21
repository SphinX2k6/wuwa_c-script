using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001154 RID: 4436
	[NetMessage(EMessageId.RoverRogueResourcesUpdateNotify)]
	public sealed class RoverRogueResourcesUpdateNotify : IMessage<RoverRogueResourcesUpdateNotify>, IMessage, IEquatable<RoverRogueResourcesUpdateNotify>, IDeepCloneable<RoverRogueResourcesUpdateNotify>, IBufferMessage
	{
		// Token: 0x06017B2D RID: 97069 RVA: 0x00372CDF File Offset: 0x00370EDF
		[NullableContext(1)]
		public static RoverRogueResourcesUpdateNotify Create()
		{
			return new RoverRogueResourcesUpdateNotify();
		}

		// Token: 0x17004FB7 RID: 20407
		// (get) Token: 0x06017B2E RID: 97070 RVA: 0x00372CE6 File Offset: 0x00370EE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004FB8 RID: 20408
		// (get) Token: 0x06017B2F RID: 97071 RVA: 0x00372CE9 File Offset: 0x00370EE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueResourcesUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06017B30 RID: 97072 RVA: 0x00372CF0 File Offset: 0x00370EF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueResourcesUpdateNotify()
		{
		}

		// Token: 0x06017B31 RID: 97073 RVA: 0x00372D10 File Offset: 0x00370F10
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

		// Token: 0x06017B32 RID: 97074 RVA: 0x00372D92 File Offset: 0x00370F92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueResourcesUpdateNotify Clone()
		{
			return new RoverRogueResourcesUpdateNotify(this);
		}

		// Token: 0x17004FB9 RID: 20409
		// (get) Token: 0x06017B33 RID: 97075 RVA: 0x00372D9A File Offset: 0x00370F9A
		// (set) Token: 0x06017B34 RID: 97076 RVA: 0x00372DA2 File Offset: 0x00370FA2
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

		// Token: 0x17004FBA RID: 20410
		// (get) Token: 0x06017B35 RID: 97077 RVA: 0x00372DAB File Offset: 0x00370FAB
		// (set) Token: 0x06017B36 RID: 97078 RVA: 0x00372DB3 File Offset: 0x00370FB3
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

		// Token: 0x17004FBB RID: 20411
		// (get) Token: 0x06017B37 RID: 97079 RVA: 0x00372DBC File Offset: 0x00370FBC
		// (set) Token: 0x06017B38 RID: 97080 RVA: 0x00372DC4 File Offset: 0x00370FC4
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

		// Token: 0x17004FBC RID: 20412
		// (get) Token: 0x06017B39 RID: 97081 RVA: 0x00372DCD File Offset: 0x00370FCD
		// (set) Token: 0x06017B3A RID: 97082 RVA: 0x00372DD5 File Offset: 0x00370FD5
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

		// Token: 0x17004FBD RID: 20413
		// (get) Token: 0x06017B3B RID: 97083 RVA: 0x00372DDE File Offset: 0x00370FDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoverRogueResourcesItem> Item
		{
			get
			{
				return this.item_;
			}
		}

		// Token: 0x17004FBE RID: 20414
		// (get) Token: 0x06017B3C RID: 97084 RVA: 0x00372DE6 File Offset: 0x00370FE6
		// (set) Token: 0x06017B3D RID: 97085 RVA: 0x00372DEE File Offset: 0x00370FEE
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

		// Token: 0x17004FBF RID: 20415
		// (get) Token: 0x06017B3E RID: 97086 RVA: 0x00372DF7 File Offset: 0x00370FF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoverRogueAttChange> AttChange
		{
			get
			{
				return this.attChange_;
			}
		}

		// Token: 0x06017B3F RID: 97087 RVA: 0x00372DFF File Offset: 0x00370FFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueResourcesUpdateNotify);
		}

		// Token: 0x06017B40 RID: 97088 RVA: 0x00372E10 File Offset: 0x00371010
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueResourcesUpdateNotify other)
		{
			return other != null && (other == this || (this.HpMax == other.HpMax && this.Coin == other.Coin && this.TalentPoint == other.TalentPoint && this.GoldEfficiency == other.GoldEfficiency && this.item_.Equals(other.item_) && this.EffectId == other.EffectId && this.attChange_.Equals(other.attChange_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017B41 RID: 97089 RVA: 0x00372EB4 File Offset: 0x003710B4
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

		// Token: 0x06017B42 RID: 97090 RVA: 0x00372F73 File Offset: 0x00371173
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017B43 RID: 97091 RVA: 0x00372F80 File Offset: 0x00371180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017B44 RID: 97092 RVA: 0x00372F8C File Offset: 0x0037118C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Coin != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Coin);
			}
			if (this.EffectId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.EffectId);
			}
			if (this.HpMax != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.HpMax);
			}
			this.attChange_.WriteTo(ref output, RoverRogueResourcesUpdateNotify._repeated_attChange_codec);
			if (this.GoldEfficiency != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.GoldEfficiency);
			}
			this.item_.WriteTo(ref output, RoverRogueResourcesUpdateNotify._repeated_item_codec);
			if (this.TalentPoint != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.TalentPoint);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017B45 RID: 97093 RVA: 0x0037305C File Offset: 0x0037125C
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

		// Token: 0x06017B46 RID: 97094 RVA: 0x00373120 File Offset: 0x00371320
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

		// Token: 0x06017B47 RID: 97095 RVA: 0x003731CE File Offset: 0x003713CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017B48 RID: 97096 RVA: 0x003731D8 File Offset: 0x003713D8
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
				if (num <= 56U)
				{
					if (num == 32U)
					{
						this.Coin = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.EffectId = input.ReadInt32();
						continue;
					}
					if (num == 56U)
					{
						this.HpMax = input.ReadInt32();
						continue;
					}
				}
				else if (num <= 72U)
				{
					if (num == 66U)
					{
						this.attChange_.AddEntriesFrom(ref input, RoverRogueResourcesUpdateNotify._repeated_attChange_codec);
						continue;
					}
					if (num == 72U)
					{
						this.GoldEfficiency = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 106U)
					{
						this.item_.AddEntriesFrom(ref input, RoverRogueResourcesUpdateNotify._repeated_item_codec);
						continue;
					}
					if (num == 120U)
					{
						this.TalentPoint = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04008D5B RID: 36187
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008D5C RID: 36188
		public const int HpMaxFieldNumber = 7;

		// Token: 0x04008D5D RID: 36189
		private int hpMax_;

		// Token: 0x04008D5E RID: 36190
		public const int CoinFieldNumber = 4;

		// Token: 0x04008D5F RID: 36191
		private int coin_;

		// Token: 0x04008D60 RID: 36192
		public const int TalentPointFieldNumber = 15;

		// Token: 0x04008D61 RID: 36193
		private int talentPoint_;

		// Token: 0x04008D62 RID: 36194
		public const int GoldEfficiencyFieldNumber = 9;

		// Token: 0x04008D63 RID: 36195
		private int goldEfficiency_;

		// Token: 0x04008D64 RID: 36196
		public const int ItemFieldNumber = 13;

		// Token: 0x04008D65 RID: 36197
		private static readonly FieldCodec<RoverRogueResourcesItem> _repeated_item_codec = FieldCodec.ForMessage<RoverRogueResourcesItem>(106U, RoverRogueResourcesItem.Parser);

		// Token: 0x04008D66 RID: 36198
		private readonly RepeatedField<RoverRogueResourcesItem> item_ = new RepeatedField<RoverRogueResourcesItem>();

		// Token: 0x04008D67 RID: 36199
		public const int EffectIdFieldNumber = 5;

		// Token: 0x04008D68 RID: 36200
		private int effectId_;

		// Token: 0x04008D69 RID: 36201
		public const int AttChangeFieldNumber = 8;

		// Token: 0x04008D6A RID: 36202
		private static readonly FieldCodec<RoverRogueAttChange> _repeated_attChange_codec = FieldCodec.ForMessage<RoverRogueAttChange>(66U, RoverRogueAttChange.Parser);

		// Token: 0x04008D6B RID: 36203
		private readonly RepeatedField<RoverRogueAttChange> attChange_ = new RepeatedField<RoverRogueAttChange>();
	}
}
