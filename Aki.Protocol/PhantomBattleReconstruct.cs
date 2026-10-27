using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CA1 RID: 3233
	public sealed class PhantomBattleReconstruct : IMessage<PhantomBattleReconstruct>, IMessage, IEquatable<PhantomBattleReconstruct>, IDeepCloneable<PhantomBattleReconstruct>, IBufferMessage
	{
		// Token: 0x0601184D RID: 71757 RVA: 0x00291025 File Offset: 0x0028F225
		[NullableContext(1)]
		public static PhantomBattleReconstruct Create()
		{
			return new PhantomBattleReconstruct();
		}

		// Token: 0x17003A08 RID: 14856
		// (get) Token: 0x0601184E RID: 71758 RVA: 0x0029102C File Offset: 0x0028F22C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003A09 RID: 14857
		// (get) Token: 0x0601184F RID: 71759 RVA: 0x0029102F File Offset: 0x0028F22F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleReconstruct.Descriptor;
			}
		}

		// Token: 0x06011850 RID: 71760 RVA: 0x00291036 File Offset: 0x0028F236
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleReconstruct()
		{
		}

		// Token: 0x06011851 RID: 71761 RVA: 0x0029104C File Offset: 0x0028F24C
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

		// Token: 0x06011852 RID: 71762 RVA: 0x002910B1 File Offset: 0x0028F2B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleReconstruct Clone()
		{
			return new PhantomBattleReconstruct(this);
		}

		// Token: 0x17003A0A RID: 14858
		// (get) Token: 0x06011853 RID: 71763 RVA: 0x002910B9 File Offset: 0x0028F2B9
		// (set) Token: 0x06011854 RID: 71764 RVA: 0x002910C1 File Offset: 0x0028F2C1
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

		// Token: 0x17003A0B RID: 14859
		// (get) Token: 0x06011855 RID: 71765 RVA: 0x002910CA File Offset: 0x0028F2CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> CardUid
		{
			get
			{
				return this.cardUid_;
			}
		}

		// Token: 0x17003A0C RID: 14860
		// (get) Token: 0x06011856 RID: 71766 RVA: 0x002910D2 File Offset: 0x0028F2D2
		// (set) Token: 0x06011857 RID: 71767 RVA: 0x002910DA File Offset: 0x0028F2DA
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

		// Token: 0x17003A0D RID: 14861
		// (get) Token: 0x06011858 RID: 71768 RVA: 0x002910E3 File Offset: 0x0028F2E3
		// (set) Token: 0x06011859 RID: 71769 RVA: 0x002910EB File Offset: 0x0028F2EB
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

		// Token: 0x17003A0E RID: 14862
		// (get) Token: 0x0601185A RID: 71770 RVA: 0x002910F4 File Offset: 0x0028F2F4
		// (set) Token: 0x0601185B RID: 71771 RVA: 0x002910FC File Offset: 0x0028F2FC
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

		// Token: 0x0601185C RID: 71772 RVA: 0x00291105 File Offset: 0x0028F305
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleReconstruct);
		}

		// Token: 0x0601185D RID: 71773 RVA: 0x00291114 File Offset: 0x0028F314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleReconstruct other)
		{
			return other != null && (other == this || (this.Camp == other.Camp && this.cardUid_.Equals(other.cardUid_) && this.HeapNum == other.HeapNum && this.Type == other.Type && this.HandNum == other.HandNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601185E RID: 71774 RVA: 0x00291194 File Offset: 0x0028F394
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

		// Token: 0x0601185F RID: 71775 RVA: 0x00291238 File Offset: 0x0028F438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011860 RID: 71776 RVA: 0x00291245 File Offset: 0x0028F445
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011861 RID: 71777 RVA: 0x00291250 File Offset: 0x0028F450
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

		// Token: 0x06011862 RID: 71778 RVA: 0x002912F4 File Offset: 0x0028F4F4
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

		// Token: 0x06011863 RID: 71779 RVA: 0x00291390 File Offset: 0x0028F590
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

		// Token: 0x06011864 RID: 71780 RVA: 0x00291419 File Offset: 0x0028F619
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011865 RID: 71781 RVA: 0x00291424 File Offset: 0x0028F624
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

		// Token: 0x04006E77 RID: 28279
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006E78 RID: 28280
		public const int CampFieldNumber = 1;

		// Token: 0x04006E79 RID: 28281
		private PhantomBattleEffectCardCamp camp_;

		// Token: 0x04006E7A RID: 28282
		public const int CardUidFieldNumber = 2;

		// Token: 0x04006E7B RID: 28283
		private static readonly FieldCodec<int> _repeated_cardUid_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04006E7C RID: 28284
		private readonly RepeatedField<int> cardUid_ = new RepeatedField<int>();

		// Token: 0x04006E7D RID: 28285
		public const int HeapNumFieldNumber = 3;

		// Token: 0x04006E7E RID: 28286
		private int heapNum_;

		// Token: 0x04006E7F RID: 28287
		public const int TypeFieldNumber = 4;

		// Token: 0x04006E80 RID: 28288
		private ReconstructFromType type_;

		// Token: 0x04006E81 RID: 28289
		public const int HandNumFieldNumber = 5;

		// Token: 0x04006E82 RID: 28290
		private int handNum_;
	}
}
