using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C91 RID: 3217
	public sealed class PhantomBattleReconstruct : IMessage<PhantomBattleReconstruct>, IMessage, IEquatable<PhantomBattleReconstruct>, IDeepCloneable<PhantomBattleReconstruct>, IBufferMessage
	{
		// Token: 0x0601174D RID: 71501 RVA: 0x0028F2B9 File Offset: 0x0028D4B9
		[NullableContext(1)]
		public static PhantomBattleReconstruct Create()
		{
			return new PhantomBattleReconstruct();
		}

		// Token: 0x170039D1 RID: 14801
		// (get) Token: 0x0601174E RID: 71502 RVA: 0x0028F2C0 File Offset: 0x0028D4C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170039D2 RID: 14802
		// (get) Token: 0x0601174F RID: 71503 RVA: 0x0028F2C3 File Offset: 0x0028D4C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleReconstruct.Descriptor;
			}
		}

		// Token: 0x06011750 RID: 71504 RVA: 0x0028F2CA File Offset: 0x0028D4CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleReconstruct()
		{
		}

		// Token: 0x06011751 RID: 71505 RVA: 0x0028F2E0 File Offset: 0x0028D4E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleReconstruct(PhantomBattleReconstruct other) : this()
		{
			this.camp_ = other.camp_;
			this.cardUid_ = other.cardUid_.Clone();
			this.heapNum_ = other.heapNum_;
			this.type_ = other.type_;
			this.handNum_ = other.handNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011752 RID: 71506 RVA: 0x0028F345 File Offset: 0x0028D545
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleReconstruct Clone()
		{
			return new PhantomBattleReconstruct(this);
		}

		// Token: 0x170039D3 RID: 14803
		// (get) Token: 0x06011753 RID: 71507 RVA: 0x0028F34D File Offset: 0x0028D54D
		// (set) Token: 0x06011754 RID: 71508 RVA: 0x0028F355 File Offset: 0x0028D555
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleEffectCardCamp Camp
		{
			get
			{
				return this.camp_;
			}
			set
			{
				this.camp_ = value;
			}
		}

		// Token: 0x170039D4 RID: 14804
		// (get) Token: 0x06011755 RID: 71509 RVA: 0x0028F35E File Offset: 0x0028D55E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> CardUid
		{
			get
			{
				return this.cardUid_;
			}
		}

		// Token: 0x170039D5 RID: 14805
		// (get) Token: 0x06011756 RID: 71510 RVA: 0x0028F366 File Offset: 0x0028D566
		// (set) Token: 0x06011757 RID: 71511 RVA: 0x0028F36E File Offset: 0x0028D56E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HeapNum
		{
			get
			{
				return this.heapNum_;
			}
			set
			{
				this.heapNum_ = value;
			}
		}

		// Token: 0x170039D6 RID: 14806
		// (get) Token: 0x06011758 RID: 71512 RVA: 0x0028F377 File Offset: 0x0028D577
		// (set) Token: 0x06011759 RID: 71513 RVA: 0x0028F37F File Offset: 0x0028D57F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReconstructFromType Type
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

		// Token: 0x170039D7 RID: 14807
		// (get) Token: 0x0601175A RID: 71514 RVA: 0x0028F388 File Offset: 0x0028D588
		// (set) Token: 0x0601175B RID: 71515 RVA: 0x0028F390 File Offset: 0x0028D590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HandNum
		{
			get
			{
				return this.handNum_;
			}
			set
			{
				this.handNum_ = value;
			}
		}

		// Token: 0x0601175C RID: 71516 RVA: 0x0028F399 File Offset: 0x0028D599
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleReconstruct);
		}

		// Token: 0x0601175D RID: 71517 RVA: 0x0028F3A8 File Offset: 0x0028D5A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleReconstruct other)
		{
			return other != null && (other == this || (this.Camp == other.Camp && this.cardUid_.Equals(other.cardUid_) && this.HeapNum == other.HeapNum && this.Type == other.Type && this.HandNum == other.HandNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601175E RID: 71518 RVA: 0x0028F428 File Offset: 0x0028D628
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Camp != PhantomBattleEffectCardCamp.GamerFighterNpc)
			{
				num ^= this.Camp.GetHashCode();
			}
			num ^= this.cardUid_.GetHashCode();
			if (this.HeapNum != 0)
			{
				num ^= this.HeapNum.GetHashCode();
			}
			if (this.Type != ReconstructFromType.FromTypeHandCard)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.HandNum != 0)
			{
				num ^= this.HandNum.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601175F RID: 71519 RVA: 0x0028F4CC File Offset: 0x0028D6CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011760 RID: 71520 RVA: 0x0028F4D9 File Offset: 0x0028D6D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011761 RID: 71521 RVA: 0x0028F4E4 File Offset: 0x0028D6E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Camp != PhantomBattleEffectCardCamp.GamerFighterNpc)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.Camp);
			}
			this.cardUid_.WriteTo(ref output, PhantomBattleReconstruct._repeated_cardUid_codec);
			if (this.HeapNum != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.HeapNum);
			}
			if (this.Type != ReconstructFromType.FromTypeHandCard)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.Type);
			}
			if (this.HandNum != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.HandNum);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011762 RID: 71522 RVA: 0x0028F588 File Offset: 0x0028D788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Camp != PhantomBattleEffectCardCamp.GamerFighterNpc)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Camp);
			}
			num += this.cardUid_.CalculateSize(PhantomBattleReconstruct._repeated_cardUid_codec);
			if (this.HeapNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HeapNum);
			}
			if (this.Type != ReconstructFromType.FromTypeHandCard)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			if (this.HandNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HandNum);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011763 RID: 71523 RVA: 0x0028F624 File Offset: 0x0028D824
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleReconstruct other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Camp != PhantomBattleEffectCardCamp.GamerFighterNpc)
			{
				this.Camp = other.Camp;
			}
			this.cardUid_.Add(other.cardUid_);
			if (other.HeapNum != 0)
			{
				this.HeapNum = other.HeapNum;
			}
			if (other.Type != ReconstructFromType.FromTypeHandCard)
			{
				this.Type = other.Type;
			}
			if (other.HandNum != 0)
			{
				this.HandNum = other.HandNum;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011764 RID: 71524 RVA: 0x0028F6AD File Offset: 0x0028D8AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011765 RID: 71525 RVA: 0x0028F6B8 File Offset: 0x0028D8B8
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
				if (num <= 18U)
				{
					if (num == 8U)
					{
						this.Camp = (PhantomBattleEffectCardCamp)input.ReadEnum();
						continue;
					}
					if (num == 16U || num == 18U)
					{
						this.cardUid_.AddEntriesFrom(ref input, PhantomBattleReconstruct._repeated_cardUid_codec);
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.HeapNum = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.Type = (ReconstructFromType)input.ReadEnum();
						continue;
					}
					if (num == 40U)
					{
						this.HandNum = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006E8B RID: 28299
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006E8C RID: 28300
		public const int CampFieldNumber = 1;

		// Token: 0x04006E8D RID: 28301
		private PhantomBattleEffectCardCamp camp_;

		// Token: 0x04006E8E RID: 28302
		public const int CardUidFieldNumber = 2;

		// Token: 0x04006E8F RID: 28303
		private static readonly FieldCodec<int> _repeated_cardUid_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04006E90 RID: 28304
		private readonly RepeatedField<int> cardUid_ = new RepeatedField<int>();

		// Token: 0x04006E91 RID: 28305
		public const int HeapNumFieldNumber = 3;

		// Token: 0x04006E92 RID: 28306
		private int heapNum_;

		// Token: 0x04006E93 RID: 28307
		public const int TypeFieldNumber = 4;

		// Token: 0x04006E94 RID: 28308
		private ReconstructFromType type_;

		// Token: 0x04006E95 RID: 28309
		public const int HandNumFieldNumber = 5;

		// Token: 0x04006E96 RID: 28310
		private int handNum_;
	}
}
