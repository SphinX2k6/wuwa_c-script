using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C60 RID: 3168
	[NetMessage(EMessageId.PhantomBattleDealCardNotify)]
	public sealed class PhantomBattleDealCardNotify : IMessage<PhantomBattleDealCardNotify>, IMessage, IEquatable<PhantomBattleDealCardNotify>, IDeepCloneable<PhantomBattleDealCardNotify>, IBufferMessage
	{
		// Token: 0x06011330 RID: 70448 RVA: 0x00285384 File Offset: 0x00283584
		[NullableContext(1)]
		public static PhantomBattleDealCardNotify Create()
		{
			return new PhantomBattleDealCardNotify();
		}

		// Token: 0x170038E4 RID: 14564
		// (get) Token: 0x06011331 RID: 70449 RVA: 0x0028538B File Offset: 0x0028358B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170038E5 RID: 14565
		// (get) Token: 0x06011332 RID: 70450 RVA: 0x0028538E File Offset: 0x0028358E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleDealCardNotify.Descriptor;
			}
		}

		// Token: 0x06011333 RID: 70451 RVA: 0x00285395 File Offset: 0x00283595
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDealCardNotify()
		{
		}

		// Token: 0x06011334 RID: 70452 RVA: 0x002853A8 File Offset: 0x002835A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDealCardNotify(PhantomBattleDealCardNotify other) : this()
		{
			this.phantomBattleHandCardInfos_ = other.phantomBattleHandCardInfos_.Clone();
			this.curCardLibraryNum_ = other.curCardLibraryNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011335 RID: 70453 RVA: 0x002853DE File Offset: 0x002835DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDealCardNotify Clone()
		{
			return new PhantomBattleDealCardNotify(this);
		}

		// Token: 0x170038E6 RID: 14566
		// (get) Token: 0x06011336 RID: 70454 RVA: 0x002853E6 File Offset: 0x002835E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomBattleHandCardInfo> PhantomBattleHandCardInfos
		{
			get
			{
				return this.phantomBattleHandCardInfos_;
			}
		}

		// Token: 0x170038E7 RID: 14567
		// (get) Token: 0x06011337 RID: 70455 RVA: 0x002853EE File Offset: 0x002835EE
		// (set) Token: 0x06011338 RID: 70456 RVA: 0x002853F6 File Offset: 0x002835F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurCardLibraryNum
		{
			get
			{
				return this.curCardLibraryNum_;
			}
			set
			{
				this.curCardLibraryNum_ = value;
			}
		}

		// Token: 0x06011339 RID: 70457 RVA: 0x002853FF File Offset: 0x002835FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleDealCardNotify);
		}

		// Token: 0x0601133A RID: 70458 RVA: 0x00285410 File Offset: 0x00283610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleDealCardNotify other)
		{
			return other != null && (other == this || (this.phantomBattleHandCardInfos_.Equals(other.phantomBattleHandCardInfos_) && this.CurCardLibraryNum == other.CurCardLibraryNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601133B RID: 70459 RVA: 0x00285460 File Offset: 0x00283660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.phantomBattleHandCardInfos_.GetHashCode();
			if (this.CurCardLibraryNum != 0)
			{
				num ^= this.CurCardLibraryNum.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601133C RID: 70460 RVA: 0x002854AD File Offset: 0x002836AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601133D RID: 70461 RVA: 0x002854BA File Offset: 0x002836BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601133E RID: 70462 RVA: 0x002854C4 File Offset: 0x002836C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CurCardLibraryNum != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.CurCardLibraryNum);
			}
			this.phantomBattleHandCardInfos_.WriteTo(ref output, PhantomBattleDealCardNotify._repeated_phantomBattleHandCardInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601133F RID: 70463 RVA: 0x00285514 File Offset: 0x00283714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.phantomBattleHandCardInfos_.CalculateSize(PhantomBattleDealCardNotify._repeated_phantomBattleHandCardInfos_codec);
			if (this.CurCardLibraryNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurCardLibraryNum);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011340 RID: 70464 RVA: 0x00285568 File Offset: 0x00283768
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleDealCardNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.phantomBattleHandCardInfos_.Add(other.phantomBattleHandCardInfos_);
			if (other.CurCardLibraryNum != 0)
			{
				this.CurCardLibraryNum = other.CurCardLibraryNum;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011341 RID: 70465 RVA: 0x002855B5 File Offset: 0x002837B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011342 RID: 70466 RVA: 0x002855C0 File Offset: 0x002837C0
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
				if (num != 80U)
				{
					if (num != 122U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.phantomBattleHandCardInfos_.AddEntriesFrom(ref input, PhantomBattleDealCardNotify._repeated_phantomBattleHandCardInfos_codec);
					}
				}
				else
				{
					this.CurCardLibraryNum = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006D42 RID: 27970
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006D43 RID: 27971
		public const int PhantomBattleHandCardInfosFieldNumber = 15;

		// Token: 0x04006D44 RID: 27972
		private static readonly FieldCodec<PhantomBattleHandCardInfo> _repeated_phantomBattleHandCardInfos_codec = FieldCodec.ForMessage<PhantomBattleHandCardInfo>(122U, PhantomBattleHandCardInfo.Parser);

		// Token: 0x04006D45 RID: 27973
		private readonly RepeatedField<PhantomBattleHandCardInfo> phantomBattleHandCardInfos_ = new RepeatedField<PhantomBattleHandCardInfo>();

		// Token: 0x04006D46 RID: 27974
		public const int CurCardLibraryNumFieldNumber = 10;

		// Token: 0x04006D47 RID: 27975
		private int curCardLibraryNum_;
	}
}
