using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C64 RID: 3172
	public sealed class PhantomBattleDealEffectCtx : IMessage<PhantomBattleDealEffectCtx>, IMessage, IEquatable<PhantomBattleDealEffectCtx>, IDeepCloneable<PhantomBattleDealEffectCtx>, IBufferMessage
	{
		// Token: 0x06011380 RID: 70528 RVA: 0x00285E1F File Offset: 0x0028401F
		[NullableContext(1)]
		public static PhantomBattleDealEffectCtx Create()
		{
			return new PhantomBattleDealEffectCtx();
		}

		// Token: 0x170038F4 RID: 14580
		// (get) Token: 0x06011381 RID: 70529 RVA: 0x00285E26 File Offset: 0x00284026
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170038F5 RID: 14581
		// (get) Token: 0x06011382 RID: 70530 RVA: 0x00285E29 File Offset: 0x00284029
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleDealEffectCtx.Descriptor;
			}
		}

		// Token: 0x06011383 RID: 70531 RVA: 0x00285E30 File Offset: 0x00284030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDealEffectCtx()
		{
		}

		// Token: 0x06011384 RID: 70532 RVA: 0x00285E43 File Offset: 0x00284043
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDealEffectCtx(PhantomBattleDealEffectCtx other) : this()
		{
			this.phantomBattleHandCardInfos_ = other.phantomBattleHandCardInfos_.Clone();
			this.cardLibraryNum_ = other.cardLibraryNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011385 RID: 70533 RVA: 0x00285E79 File Offset: 0x00284079
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDealEffectCtx Clone()
		{
			return new PhantomBattleDealEffectCtx(this);
		}

		// Token: 0x170038F6 RID: 14582
		// (get) Token: 0x06011386 RID: 70534 RVA: 0x00285E81 File Offset: 0x00284081
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomBattleHandCardInfo> PhantomBattleHandCardInfos
		{
			get
			{
				return this.phantomBattleHandCardInfos_;
			}
		}

		// Token: 0x170038F7 RID: 14583
		// (get) Token: 0x06011387 RID: 70535 RVA: 0x00285E89 File Offset: 0x00284089
		// (set) Token: 0x06011388 RID: 70536 RVA: 0x00285E91 File Offset: 0x00284091
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CardLibraryNum
		{
			get
			{
				return this.cardLibraryNum_;
			}
			set
			{
				this.cardLibraryNum_ = value;
			}
		}

		// Token: 0x06011389 RID: 70537 RVA: 0x00285E9A File Offset: 0x0028409A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleDealEffectCtx);
		}

		// Token: 0x0601138A RID: 70538 RVA: 0x00285EA8 File Offset: 0x002840A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleDealEffectCtx other)
		{
			return other != null && (other == this || (this.phantomBattleHandCardInfos_.Equals(other.phantomBattleHandCardInfos_) && this.CardLibraryNum == other.CardLibraryNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601138B RID: 70539 RVA: 0x00285EF8 File Offset: 0x002840F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.phantomBattleHandCardInfos_.GetHashCode();
			if (this.CardLibraryNum != 0)
			{
				num ^= this.CardLibraryNum.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601138C RID: 70540 RVA: 0x00285F45 File Offset: 0x00284145
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601138D RID: 70541 RVA: 0x00285F52 File Offset: 0x00284152
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601138E RID: 70542 RVA: 0x00285F5C File Offset: 0x0028415C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.phantomBattleHandCardInfos_.WriteTo(ref output, PhantomBattleDealEffectCtx._repeated_phantomBattleHandCardInfos_codec);
			if (this.CardLibraryNum != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.CardLibraryNum);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601138F RID: 70543 RVA: 0x00285FAC File Offset: 0x002841AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.phantomBattleHandCardInfos_.CalculateSize(PhantomBattleDealEffectCtx._repeated_phantomBattleHandCardInfos_codec);
			if (this.CardLibraryNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CardLibraryNum);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011390 RID: 70544 RVA: 0x00286000 File Offset: 0x00284200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleDealEffectCtx other)
		{
			if (other == null)
			{
				return;
			}
			this.phantomBattleHandCardInfos_.Add(other.phantomBattleHandCardInfos_);
			if (other.CardLibraryNum != 0)
			{
				this.CardLibraryNum = other.CardLibraryNum;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011391 RID: 70545 RVA: 0x0028604D File Offset: 0x0028424D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011392 RID: 70546 RVA: 0x00286058 File Offset: 0x00284258
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
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.CardLibraryNum = input.ReadInt32();
					}
				}
				else
				{
					this.phantomBattleHandCardInfos_.AddEntriesFrom(ref input, PhantomBattleDealEffectCtx._repeated_phantomBattleHandCardInfos_codec);
				}
			}
		}

		// Token: 0x04006D5A RID: 27994
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006D5B RID: 27995
		public const int PhantomBattleHandCardInfosFieldNumber = 1;

		// Token: 0x04006D5C RID: 27996
		private static readonly FieldCodec<PhantomBattleHandCardInfo> _repeated_phantomBattleHandCardInfos_codec = FieldCodec.ForMessage<PhantomBattleHandCardInfo>(10U, PhantomBattleHandCardInfo.Parser);

		// Token: 0x04006D5D RID: 27997
		private readonly RepeatedField<PhantomBattleHandCardInfo> phantomBattleHandCardInfos_ = new RepeatedField<PhantomBattleHandCardInfo>();

		// Token: 0x04006D5E RID: 27998
		public const int CardLibraryNumFieldNumber = 2;

		// Token: 0x04006D5F RID: 27999
		private int cardLibraryNum_;
	}
}
