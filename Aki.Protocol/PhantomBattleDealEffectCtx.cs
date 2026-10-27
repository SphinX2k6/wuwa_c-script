using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C74 RID: 3188
	public sealed class PhantomBattleDealEffectCtx : IMessage<PhantomBattleDealEffectCtx>, IMessage, IEquatable<PhantomBattleDealEffectCtx>, IDeepCloneable<PhantomBattleDealEffectCtx>, IBufferMessage
	{
		// Token: 0x06011480 RID: 70784 RVA: 0x00287B8F File Offset: 0x00285D8F
		[NullableContext(1)]
		public static PhantomBattleDealEffectCtx Create()
		{
			return new PhantomBattleDealEffectCtx();
		}

		// Token: 0x1700392B RID: 14635
		// (get) Token: 0x06011481 RID: 70785 RVA: 0x00287B96 File Offset: 0x00285D96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700392C RID: 14636
		// (get) Token: 0x06011482 RID: 70786 RVA: 0x00287B99 File Offset: 0x00285D99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleDealEffectCtx.Descriptor;
			}
		}

		// Token: 0x06011483 RID: 70787 RVA: 0x00287BA0 File Offset: 0x00285DA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDealEffectCtx()
		{
		}

		// Token: 0x06011484 RID: 70788 RVA: 0x00287BB3 File Offset: 0x00285DB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDealEffectCtx(PhantomBattleDealEffectCtx other) : this()
		{
			this.phantomBattleHandCardInfos_ = other.phantomBattleHandCardInfos_.Clone();
			this.cardLibraryNum_ = other.cardLibraryNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011485 RID: 70789 RVA: 0x00287BE9 File Offset: 0x00285DE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDealEffectCtx Clone()
		{
			return new PhantomBattleDealEffectCtx(this);
		}

		// Token: 0x1700392D RID: 14637
		// (get) Token: 0x06011486 RID: 70790 RVA: 0x00287BF1 File Offset: 0x00285DF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomBattleHandCardInfo> PhantomBattleHandCardInfos
		{
			get
			{
				return this.phantomBattleHandCardInfos_;
			}
		}

		// Token: 0x1700392E RID: 14638
		// (get) Token: 0x06011487 RID: 70791 RVA: 0x00287BF9 File Offset: 0x00285DF9
		// (set) Token: 0x06011488 RID: 70792 RVA: 0x00287C01 File Offset: 0x00285E01
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

		// Token: 0x06011489 RID: 70793 RVA: 0x00287C0A File Offset: 0x00285E0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleDealEffectCtx);
		}

		// Token: 0x0601148A RID: 70794 RVA: 0x00287C18 File Offset: 0x00285E18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleDealEffectCtx other)
		{
			return other != null && (other == this || (this.phantomBattleHandCardInfos_.Equals(other.phantomBattleHandCardInfos_) && this.CardLibraryNum == other.CardLibraryNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601148B RID: 70795 RVA: 0x00287C68 File Offset: 0x00285E68
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

		// Token: 0x0601148C RID: 70796 RVA: 0x00287CB5 File Offset: 0x00285EB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601148D RID: 70797 RVA: 0x00287CC2 File Offset: 0x00285EC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601148E RID: 70798 RVA: 0x00287CCC File Offset: 0x00285ECC
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

		// Token: 0x0601148F RID: 70799 RVA: 0x00287D1C File Offset: 0x00285F1C
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

		// Token: 0x06011490 RID: 70800 RVA: 0x00287D70 File Offset: 0x00285F70
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

		// Token: 0x06011491 RID: 70801 RVA: 0x00287DBD File Offset: 0x00285FBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011492 RID: 70802 RVA: 0x00287DC8 File Offset: 0x00285FC8
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

		// Token: 0x04006D46 RID: 27974
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006D47 RID: 27975
		public const int PhantomBattleHandCardInfosFieldNumber = 1;

		// Token: 0x04006D48 RID: 27976
		private static readonly FieldCodec<PhantomBattleHandCardInfo> _repeated_phantomBattleHandCardInfos_codec = FieldCodec.ForMessage<PhantomBattleHandCardInfo>(10U, PhantomBattleHandCardInfo.Parser);

		// Token: 0x04006D49 RID: 27977
		private readonly RepeatedField<PhantomBattleHandCardInfo> phantomBattleHandCardInfos_ = new RepeatedField<PhantomBattleHandCardInfo>();

		// Token: 0x04006D4A RID: 27978
		public const int CardLibraryNumFieldNumber = 2;

		// Token: 0x04006D4B RID: 27979
		private int cardLibraryNum_;
	}
}
