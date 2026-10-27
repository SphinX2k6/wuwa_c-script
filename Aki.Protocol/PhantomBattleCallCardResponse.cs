using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C43 RID: 3139
	[NetMessage(EMessageId.PhantomBattleCallCardResponse)]
	public sealed class PhantomBattleCallCardResponse : IMessage<PhantomBattleCallCardResponse>, IMessage, IEquatable<PhantomBattleCallCardResponse>, IDeepCloneable<PhantomBattleCallCardResponse>, IBufferMessage
	{
		// Token: 0x06011059 RID: 69721 RVA: 0x0027DE80 File Offset: 0x0027C080
		[NullableContext(1)]
		public static PhantomBattleCallCardResponse Create()
		{
			return new PhantomBattleCallCardResponse();
		}

		// Token: 0x1700383A RID: 14394
		// (get) Token: 0x0601105A RID: 69722 RVA: 0x0027DE87 File Offset: 0x0027C087
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700383B RID: 14395
		// (get) Token: 0x0601105B RID: 69723 RVA: 0x0027DE8A File Offset: 0x0027C08A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleCallCardResponse.Descriptor;
			}
		}

		// Token: 0x0601105C RID: 69724 RVA: 0x0027DE91 File Offset: 0x0027C091
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCallCardResponse()
		{
		}

		// Token: 0x0601105D RID: 69725 RVA: 0x0027DEA4 File Offset: 0x0027C0A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCallCardResponse(PhantomBattleCallCardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.effectUid_ = other.effectUid_;
			this.phantomBattleFighterInfo_ = other.phantomBattleFighterInfo_.Clone();
			this.heapNum_ = other.heapNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601105E RID: 69726 RVA: 0x0027DEFD File Offset: 0x0027C0FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCallCardResponse Clone()
		{
			return new PhantomBattleCallCardResponse(this);
		}

		// Token: 0x1700383C RID: 14396
		// (get) Token: 0x0601105F RID: 69727 RVA: 0x0027DF05 File Offset: 0x0027C105
		// (set) Token: 0x06011060 RID: 69728 RVA: 0x0027DF0D File Offset: 0x0027C10D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x1700383D RID: 14397
		// (get) Token: 0x06011061 RID: 69729 RVA: 0x0027DF16 File Offset: 0x0027C116
		// (set) Token: 0x06011062 RID: 69730 RVA: 0x0027DF1E File Offset: 0x0027C11E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EffectUid
		{
			get
			{
				return this.effectUid_;
			}
			set
			{
				this.effectUid_ = value;
			}
		}

		// Token: 0x1700383E RID: 14398
		// (get) Token: 0x06011063 RID: 69731 RVA: 0x0027DF27 File Offset: 0x0027C127
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomBattleFighterInfo> PhantomBattleFighterInfo
		{
			get
			{
				return this.phantomBattleFighterInfo_;
			}
		}

		// Token: 0x1700383F RID: 14399
		// (get) Token: 0x06011064 RID: 69732 RVA: 0x0027DF2F File Offset: 0x0027C12F
		// (set) Token: 0x06011065 RID: 69733 RVA: 0x0027DF37 File Offset: 0x0027C137
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

		// Token: 0x06011066 RID: 69734 RVA: 0x0027DF40 File Offset: 0x0027C140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleCallCardResponse);
		}

		// Token: 0x06011067 RID: 69735 RVA: 0x0027DF50 File Offset: 0x0027C150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleCallCardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.EffectUid == other.EffectUid && this.phantomBattleFighterInfo_.Equals(other.phantomBattleFighterInfo_) && this.HeapNum == other.HeapNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011068 RID: 69736 RVA: 0x0027DFC0 File Offset: 0x0027C1C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.EffectUid != 0)
			{
				num ^= this.EffectUid.GetHashCode();
			}
			num ^= this.phantomBattleFighterInfo_.GetHashCode();
			if (this.HeapNum != 0)
			{
				num ^= this.HeapNum.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011069 RID: 69737 RVA: 0x0027E045 File Offset: 0x0027C245
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601106A RID: 69738 RVA: 0x0027E052 File Offset: 0x0027C252
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601106B RID: 69739 RVA: 0x0027E05C File Offset: 0x0027C25C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HeapNum != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.HeapNum);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.EffectUid != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.EffectUid);
			}
			this.phantomBattleFighterInfo_.WriteTo(ref output, PhantomBattleCallCardResponse._repeated_phantomBattleFighterInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601106C RID: 69740 RVA: 0x0027E0E4 File Offset: 0x0027C2E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.EffectUid != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EffectUid);
			}
			num += this.phantomBattleFighterInfo_.CalculateSize(PhantomBattleCallCardResponse._repeated_phantomBattleFighterInfo_codec);
			if (this.HeapNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HeapNum);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601106D RID: 69741 RVA: 0x0027E168 File Offset: 0x0027C368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleCallCardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.EffectUid != 0)
			{
				this.EffectUid = other.EffectUid;
			}
			this.phantomBattleFighterInfo_.Add(other.phantomBattleFighterInfo_);
			if (other.HeapNum != 0)
			{
				this.HeapNum = other.HeapNum;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601106E RID: 69742 RVA: 0x0027E1DD File Offset: 0x0027C3DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601106F RID: 69743 RVA: 0x0027E1E8 File Offset: 0x0027C3E8
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
				if (num <= 88U)
				{
					if (num == 40U)
					{
						this.HeapNum = input.ReadInt32();
						continue;
					}
					if (num == 88U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 104U)
					{
						this.EffectUid = input.ReadInt32();
						continue;
					}
					if (num == 114U)
					{
						this.phantomBattleFighterInfo_.AddEntriesFrom(ref input, PhantomBattleCallCardResponse._repeated_phantomBattleFighterInfo_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006BDA RID: 27610
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006BDB RID: 27611
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x04006BDC RID: 27612
		private ErrorCode errorCode_;

		// Token: 0x04006BDD RID: 27613
		public const int EffectUidFieldNumber = 13;

		// Token: 0x04006BDE RID: 27614
		private int effectUid_;

		// Token: 0x04006BDF RID: 27615
		public const int PhantomBattleFighterInfoFieldNumber = 14;

		// Token: 0x04006BE0 RID: 27616
		private static readonly FieldCodec<PhantomBattleFighterInfo> _repeated_phantomBattleFighterInfo_codec = FieldCodec.ForMessage<PhantomBattleFighterInfo>(114U, Aki.Protocol.PhantomBattleFighterInfo.Parser);

		// Token: 0x04006BE1 RID: 27617
		private readonly RepeatedField<PhantomBattleFighterInfo> phantomBattleFighterInfo_ = new RepeatedField<PhantomBattleFighterInfo>();

		// Token: 0x04006BE2 RID: 27618
		public const int HeapNumFieldNumber = 5;

		// Token: 0x04006BE3 RID: 27619
		private int heapNum_;
	}
}
