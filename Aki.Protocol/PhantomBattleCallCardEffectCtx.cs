using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C40 RID: 3136
	public sealed class PhantomBattleCallCardEffectCtx : IMessage<PhantomBattleCallCardEffectCtx>, IMessage, IEquatable<PhantomBattleCallCardEffectCtx>, IDeepCloneable<PhantomBattleCallCardEffectCtx>, IBufferMessage
	{
		// Token: 0x06011011 RID: 69649 RVA: 0x0027D275 File Offset: 0x0027B475
		[NullableContext(1)]
		public static PhantomBattleCallCardEffectCtx Create()
		{
			return new PhantomBattleCallCardEffectCtx();
		}

		// Token: 0x17003828 RID: 14376
		// (get) Token: 0x06011012 RID: 69650 RVA: 0x0027D27C File Offset: 0x0027B47C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003829 RID: 14377
		// (get) Token: 0x06011013 RID: 69651 RVA: 0x0027D27F File Offset: 0x0027B47F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleCallCardEffectCtx.Descriptor;
			}
		}

		// Token: 0x06011014 RID: 69652 RVA: 0x0027D286 File Offset: 0x0027B486
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCallCardEffectCtx()
		{
		}

		// Token: 0x06011015 RID: 69653 RVA: 0x0027D29C File Offset: 0x0027B49C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCallCardEffectCtx(PhantomBattleCallCardEffectCtx other) : this()
		{
			this.phantomBattleFighterInfo_ = other.phantomBattleFighterInfo_.Clone();
			this.fromType_ = other.fromType_;
			this.heapNum_ = other.heapNum_;
			this.headNum_ = other.headNum_;
			this.camp_ = other.camp_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011016 RID: 69654 RVA: 0x0027D301 File Offset: 0x0027B501
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCallCardEffectCtx Clone()
		{
			return new PhantomBattleCallCardEffectCtx(this);
		}

		// Token: 0x1700382A RID: 14378
		// (get) Token: 0x06011017 RID: 69655 RVA: 0x0027D309 File Offset: 0x0027B509
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomBattleFighterInfo> PhantomBattleFighterInfo
		{
			get
			{
				return this.phantomBattleFighterInfo_;
			}
		}

		// Token: 0x1700382B RID: 14379
		// (get) Token: 0x06011018 RID: 69656 RVA: 0x0027D311 File Offset: 0x0027B511
		// (set) Token: 0x06011019 RID: 69657 RVA: 0x0027D319 File Offset: 0x0027B519
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleSelectedCardFromType FromType
		{
			get
			{
				return this.fromType_;
			}
			set
			{
				this.fromType_ = value;
			}
		}

		// Token: 0x1700382C RID: 14380
		// (get) Token: 0x0601101A RID: 69658 RVA: 0x0027D322 File Offset: 0x0027B522
		// (set) Token: 0x0601101B RID: 69659 RVA: 0x0027D32A File Offset: 0x0027B52A
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

		// Token: 0x1700382D RID: 14381
		// (get) Token: 0x0601101C RID: 69660 RVA: 0x0027D333 File Offset: 0x0027B533
		// (set) Token: 0x0601101D RID: 69661 RVA: 0x0027D33B File Offset: 0x0027B53B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HeadNum
		{
			get
			{
				return this.headNum_;
			}
			set
			{
				this.headNum_ = value;
			}
		}

		// Token: 0x1700382E RID: 14382
		// (get) Token: 0x0601101E RID: 69662 RVA: 0x0027D344 File Offset: 0x0027B544
		// (set) Token: 0x0601101F RID: 69663 RVA: 0x0027D34C File Offset: 0x0027B54C
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

		// Token: 0x06011020 RID: 69664 RVA: 0x0027D355 File Offset: 0x0027B555
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleCallCardEffectCtx);
		}

		// Token: 0x06011021 RID: 69665 RVA: 0x0027D364 File Offset: 0x0027B564
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleCallCardEffectCtx other)
		{
			return other != null && (other == this || (this.phantomBattleFighterInfo_.Equals(other.phantomBattleFighterInfo_) && this.FromType == other.FromType && this.HeapNum == other.HeapNum && this.HeadNum == other.HeadNum && this.Camp == other.Camp && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011022 RID: 69666 RVA: 0x0027D3E4 File Offset: 0x0027B5E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.phantomBattleFighterInfo_.GetHashCode();
			if (this.FromType != PhantomBattleSelectedCardFromType.HandCard)
			{
				num ^= this.FromType.GetHashCode();
			}
			if (this.HeapNum != 0)
			{
				num ^= this.HeapNum.GetHashCode();
			}
			if (this.HeadNum != 0)
			{
				num ^= this.HeadNum.GetHashCode();
			}
			if (this.Camp != PhantomBattleEffectCardCamp.GamerFighterNpc)
			{
				num ^= this.Camp.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011023 RID: 69667 RVA: 0x0027D488 File Offset: 0x0027B688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011024 RID: 69668 RVA: 0x0027D495 File Offset: 0x0027B695
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011025 RID: 69669 RVA: 0x0027D4A0 File Offset: 0x0027B6A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.phantomBattleFighterInfo_.WriteTo(ref output, PhantomBattleCallCardEffectCtx._repeated_phantomBattleFighterInfo_codec);
			if (this.FromType != PhantomBattleSelectedCardFromType.HandCard)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.FromType);
			}
			if (this.HeapNum != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.HeapNum);
			}
			if (this.HeadNum != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.HeadNum);
			}
			if (this.Camp != PhantomBattleEffectCardCamp.GamerFighterNpc)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.Camp);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011026 RID: 69670 RVA: 0x0027D544 File Offset: 0x0027B744
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.phantomBattleFighterInfo_.CalculateSize(PhantomBattleCallCardEffectCtx._repeated_phantomBattleFighterInfo_codec);
			if (this.FromType != PhantomBattleSelectedCardFromType.HandCard)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.FromType);
			}
			if (this.HeapNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HeapNum);
			}
			if (this.HeadNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HeadNum);
			}
			if (this.Camp != PhantomBattleEffectCardCamp.GamerFighterNpc)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Camp);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011027 RID: 69671 RVA: 0x0027D5E0 File Offset: 0x0027B7E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleCallCardEffectCtx other)
		{
			if (other == null)
			{
				return;
			}
			this.phantomBattleFighterInfo_.Add(other.phantomBattleFighterInfo_);
			if (other.FromType != PhantomBattleSelectedCardFromType.HandCard)
			{
				this.FromType = other.FromType;
			}
			if (other.HeapNum != 0)
			{
				this.HeapNum = other.HeapNum;
			}
			if (other.HeadNum != 0)
			{
				this.HeadNum = other.HeadNum;
			}
			if (other.Camp != PhantomBattleEffectCardCamp.GamerFighterNpc)
			{
				this.Camp = other.Camp;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011028 RID: 69672 RVA: 0x0027D669 File Offset: 0x0027B869
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011029 RID: 69673 RVA: 0x0027D674 File Offset: 0x0027B874
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
					if (num == 10U)
					{
						this.phantomBattleFighterInfo_.AddEntriesFrom(ref input, PhantomBattleCallCardEffectCtx._repeated_phantomBattleFighterInfo_codec);
						continue;
					}
					if (num == 16U)
					{
						this.FromType = (PhantomBattleSelectedCardFromType)input.ReadEnum();
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
						this.HeadNum = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.Camp = (PhantomBattleEffectCardCamp)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006BBC RID: 27580
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006BBD RID: 27581
		public const int PhantomBattleFighterInfoFieldNumber = 1;

		// Token: 0x04006BBE RID: 27582
		private static readonly FieldCodec<PhantomBattleFighterInfo> _repeated_phantomBattleFighterInfo_codec = FieldCodec.ForMessage<PhantomBattleFighterInfo>(10U, Aki.Protocol.PhantomBattleFighterInfo.Parser);

		// Token: 0x04006BBF RID: 27583
		private readonly RepeatedField<PhantomBattleFighterInfo> phantomBattleFighterInfo_ = new RepeatedField<PhantomBattleFighterInfo>();

		// Token: 0x04006BC0 RID: 27584
		public const int FromTypeFieldNumber = 2;

		// Token: 0x04006BC1 RID: 27585
		private PhantomBattleSelectedCardFromType fromType_;

		// Token: 0x04006BC2 RID: 27586
		public const int HeapNumFieldNumber = 3;

		// Token: 0x04006BC3 RID: 27587
		private int heapNum_;

		// Token: 0x04006BC4 RID: 27588
		public const int HeadNumFieldNumber = 4;

		// Token: 0x04006BC5 RID: 27589
		private int headNum_;

		// Token: 0x04006BC6 RID: 27590
		public const int CampFieldNumber = 5;

		// Token: 0x04006BC7 RID: 27591
		private PhantomBattleEffectCardCamp camp_;
	}
}
