using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C33 RID: 3123
	[NetMessage(EMessageId.PhantomBattleCallCardResponse)]
	public sealed class PhantomBattleCallCardResponse : IMessage<PhantomBattleCallCardResponse>, IMessage, IEquatable<PhantomBattleCallCardResponse>, IDeepCloneable<PhantomBattleCallCardResponse>, IBufferMessage
	{
		// Token: 0x06010F59 RID: 69465 RVA: 0x0027C118 File Offset: 0x0027A318
		[NullableContext(1)]
		public static PhantomBattleCallCardResponse Create()
		{
			return new PhantomBattleCallCardResponse();
		}

		// Token: 0x17003803 RID: 14339
		// (get) Token: 0x06010F5A RID: 69466 RVA: 0x0027C11F File Offset: 0x0027A31F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003804 RID: 14340
		// (get) Token: 0x06010F5B RID: 69467 RVA: 0x0027C122 File Offset: 0x0027A322
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleCallCardResponse.Descriptor;
			}
		}

		// Token: 0x06010F5C RID: 69468 RVA: 0x0027C129 File Offset: 0x0027A329
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCallCardResponse()
		{
		}

		// Token: 0x06010F5D RID: 69469 RVA: 0x0027C13C File Offset: 0x0027A33C
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

		// Token: 0x06010F5E RID: 69470 RVA: 0x0027C195 File Offset: 0x0027A395
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleCallCardResponse Clone()
		{
			return new PhantomBattleCallCardResponse(this);
		}

		// Token: 0x17003805 RID: 14341
		// (get) Token: 0x06010F5F RID: 69471 RVA: 0x0027C19D File Offset: 0x0027A39D
		// (set) Token: 0x06010F60 RID: 69472 RVA: 0x0027C1A5 File Offset: 0x0027A3A5
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

		// Token: 0x17003806 RID: 14342
		// (get) Token: 0x06010F61 RID: 69473 RVA: 0x0027C1AE File Offset: 0x0027A3AE
		// (set) Token: 0x06010F62 RID: 69474 RVA: 0x0027C1B6 File Offset: 0x0027A3B6
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

		// Token: 0x17003807 RID: 14343
		// (get) Token: 0x06010F63 RID: 69475 RVA: 0x0027C1BF File Offset: 0x0027A3BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomBattleFighterInfo> PhantomBattleFighterInfo
		{
			get
			{
				return this.phantomBattleFighterInfo_;
			}
		}

		// Token: 0x17003808 RID: 14344
		// (get) Token: 0x06010F64 RID: 69476 RVA: 0x0027C1C7 File Offset: 0x0027A3C7
		// (set) Token: 0x06010F65 RID: 69477 RVA: 0x0027C1CF File Offset: 0x0027A3CF
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

		// Token: 0x06010F66 RID: 69478 RVA: 0x0027C1D8 File Offset: 0x0027A3D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleCallCardResponse);
		}

		// Token: 0x06010F67 RID: 69479 RVA: 0x0027C1E8 File Offset: 0x0027A3E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleCallCardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.EffectUid == other.EffectUid && this.phantomBattleFighterInfo_.Equals(other.phantomBattleFighterInfo_) && this.HeapNum == other.HeapNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010F68 RID: 69480 RVA: 0x0027C258 File Offset: 0x0027A458
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

		// Token: 0x06010F69 RID: 69481 RVA: 0x0027C2DD File Offset: 0x0027A4DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010F6A RID: 69482 RVA: 0x0027C2EA File Offset: 0x0027A4EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010F6B RID: 69483 RVA: 0x0027C2F4 File Offset: 0x0027A4F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.phantomBattleFighterInfo_.WriteTo(ref output, PhantomBattleCallCardResponse._repeated_phantomBattleFighterInfo_codec);
			if (this.EffectUid != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.EffectUid);
			}
			if (this.HeapNum != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.HeapNum);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010F6C RID: 69484 RVA: 0x0027C37C File Offset: 0x0027A57C
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

		// Token: 0x06010F6D RID: 69485 RVA: 0x0027C400 File Offset: 0x0027A600
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

		// Token: 0x06010F6E RID: 69486 RVA: 0x0027C475 File Offset: 0x0027A675
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010F6F RID: 69487 RVA: 0x0027C480 File Offset: 0x0027A680
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
				if (num <= 72U)
				{
					if (num == 18U)
					{
						this.phantomBattleFighterInfo_.AddEntriesFrom(ref input, PhantomBattleCallCardResponse._repeated_phantomBattleFighterInfo_codec);
						continue;
					}
					if (num == 72U)
					{
						this.EffectUid = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.HeapNum = input.ReadInt32();
						continue;
					}
					if (num == 104U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006BEE RID: 27630
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006BEF RID: 27631
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x04006BF0 RID: 27632
		private ErrorCode errorCode_;

		// Token: 0x04006BF1 RID: 27633
		public const int EffectUidFieldNumber = 9;

		// Token: 0x04006BF2 RID: 27634
		private int effectUid_;

		// Token: 0x04006BF3 RID: 27635
		public const int PhantomBattleFighterInfoFieldNumber = 2;

		// Token: 0x04006BF4 RID: 27636
		private static readonly FieldCodec<PhantomBattleFighterInfo> _repeated_phantomBattleFighterInfo_codec = FieldCodec.ForMessage<PhantomBattleFighterInfo>(18U, Aki.Protocol.PhantomBattleFighterInfo.Parser);

		// Token: 0x04006BF5 RID: 27637
		private readonly RepeatedField<PhantomBattleFighterInfo> phantomBattleFighterInfo_ = new RepeatedField<PhantomBattleFighterInfo>();

		// Token: 0x04006BF6 RID: 27638
		public const int HeapNumFieldNumber = 11;

		// Token: 0x04006BF7 RID: 27639
		private int heapNum_;
	}
}
