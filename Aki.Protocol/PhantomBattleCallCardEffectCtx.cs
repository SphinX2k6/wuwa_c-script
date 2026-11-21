using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C30 RID: 3120
	public sealed class PhantomBattleCallCardEffectCtx : IMessage<PhantomBattleCallCardEffectCtx>, IMessage, IEquatable<PhantomBattleCallCardEffectCtx>, IDeepCloneable<PhantomBattleCallCardEffectCtx>, IBufferMessage
	{
		// Token: 0x06010F11 RID: 69393 RVA: 0x0027B510 File Offset: 0x00279710
		[NullableContext(1)]
		public static PhantomBattleCallCardEffectCtx Create()
		{
			return new PhantomBattleCallCardEffectCtx();
		}

		// Token: 0x170037F1 RID: 14321
		// (get) Token: 0x06010F12 RID: 69394 RVA: 0x0027B517 File Offset: 0x00279717
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170037F2 RID: 14322
		// (get) Token: 0x06010F13 RID: 69395 RVA: 0x0027B51A File Offset: 0x0027971A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleCallCardEffectCtx.Descriptor;
			}
		}

		// Token: 0x06010F14 RID: 69396 RVA: 0x0027B521 File Offset: 0x00279721
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCallCardEffectCtx()
		{
		}

		// Token: 0x06010F15 RID: 69397 RVA: 0x0027B534 File Offset: 0x00279734
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

		// Token: 0x06010F16 RID: 69398 RVA: 0x0027B599 File Offset: 0x00279799
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCallCardEffectCtx Clone()
		{
			return new PhantomBattleCallCardEffectCtx(this);
		}

		// Token: 0x170037F3 RID: 14323
		// (get) Token: 0x06010F17 RID: 69399 RVA: 0x0027B5A1 File Offset: 0x002797A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomBattleFighterInfo> PhantomBattleFighterInfo
		{
			get
			{
				return this.phantomBattleFighterInfo_;
			}
		}

		// Token: 0x170037F4 RID: 14324
		// (get) Token: 0x06010F18 RID: 69400 RVA: 0x0027B5A9 File Offset: 0x002797A9
		// (set) Token: 0x06010F19 RID: 69401 RVA: 0x0027B5B1 File Offset: 0x002797B1
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

		// Token: 0x170037F5 RID: 14325
		// (get) Token: 0x06010F1A RID: 69402 RVA: 0x0027B5BA File Offset: 0x002797BA
		// (set) Token: 0x06010F1B RID: 69403 RVA: 0x0027B5C2 File Offset: 0x002797C2
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

		// Token: 0x170037F6 RID: 14326
		// (get) Token: 0x06010F1C RID: 69404 RVA: 0x0027B5CB File Offset: 0x002797CB
		// (set) Token: 0x06010F1D RID: 69405 RVA: 0x0027B5D3 File Offset: 0x002797D3
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

		// Token: 0x170037F7 RID: 14327
		// (get) Token: 0x06010F1E RID: 69406 RVA: 0x0027B5DC File Offset: 0x002797DC
		// (set) Token: 0x06010F1F RID: 69407 RVA: 0x0027B5E4 File Offset: 0x002797E4
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

		// Token: 0x06010F20 RID: 69408 RVA: 0x0027B5ED File Offset: 0x002797ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleCallCardEffectCtx);
		}

		// Token: 0x06010F21 RID: 69409 RVA: 0x0027B5FC File Offset: 0x002797FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleCallCardEffectCtx other)
		{
			return other != null && (other == this || (this.phantomBattleFighterInfo_.Equals(other.phantomBattleFighterInfo_) && this.FromType == other.FromType && this.HeapNum == other.HeapNum && this.HeadNum == other.HeadNum && this.Camp == other.Camp && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010F22 RID: 69410 RVA: 0x0027B67C File Offset: 0x0027987C
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

		// Token: 0x06010F23 RID: 69411 RVA: 0x0027B720 File Offset: 0x00279920
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010F24 RID: 69412 RVA: 0x0027B72D File Offset: 0x0027992D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010F25 RID: 69413 RVA: 0x0027B738 File Offset: 0x00279938
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

		// Token: 0x06010F26 RID: 69414 RVA: 0x0027B7DC File Offset: 0x002799DC
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

		// Token: 0x06010F27 RID: 69415 RVA: 0x0027B878 File Offset: 0x00279A78
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

		// Token: 0x06010F28 RID: 69416 RVA: 0x0027B901 File Offset: 0x00279B01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010F29 RID: 69417 RVA: 0x0027B90C File Offset: 0x00279B0C
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

		// Token: 0x04006BD0 RID: 27600
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006BD1 RID: 27601
		public const int PhantomBattleFighterInfoFieldNumber = 1;

		// Token: 0x04006BD2 RID: 27602
		private static readonly FieldCodec<PhantomBattleFighterInfo> _repeated_phantomBattleFighterInfo_codec = FieldCodec.ForMessage<PhantomBattleFighterInfo>(10U, Aki.Protocol.PhantomBattleFighterInfo.Parser);

		// Token: 0x04006BD3 RID: 27603
		private readonly RepeatedField<PhantomBattleFighterInfo> phantomBattleFighterInfo_ = new RepeatedField<PhantomBattleFighterInfo>();

		// Token: 0x04006BD4 RID: 27604
		public const int FromTypeFieldNumber = 2;

		// Token: 0x04006BD5 RID: 27605
		private PhantomBattleSelectedCardFromType fromType_;

		// Token: 0x04006BD6 RID: 27606
		public const int HeapNumFieldNumber = 3;

		// Token: 0x04006BD7 RID: 27607
		private int heapNum_;

		// Token: 0x04006BD8 RID: 27608
		public const int HeadNumFieldNumber = 4;

		// Token: 0x04006BD9 RID: 27609
		private int headNum_;

		// Token: 0x04006BDA RID: 27610
		public const int CampFieldNumber = 5;

		// Token: 0x04006BDB RID: 27611
		private PhantomBattleEffectCardCamp camp_;
	}
}
