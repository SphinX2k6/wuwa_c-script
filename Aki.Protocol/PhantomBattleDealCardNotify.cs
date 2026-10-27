using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C70 RID: 3184
	[NetMessage(EMessageId.PhantomBattleDealCardNotify)]
	public sealed class PhantomBattleDealCardNotify : IMessage<PhantomBattleDealCardNotify>, IMessage, IEquatable<PhantomBattleDealCardNotify>, IDeepCloneable<PhantomBattleDealCardNotify>, IBufferMessage
	{
		// Token: 0x06011430 RID: 70704 RVA: 0x002870F4 File Offset: 0x002852F4
		[NullableContext(1)]
		public static PhantomBattleDealCardNotify Create()
		{
			return new PhantomBattleDealCardNotify();
		}

		// Token: 0x1700391B RID: 14619
		// (get) Token: 0x06011431 RID: 70705 RVA: 0x002870FB File Offset: 0x002852FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700391C RID: 14620
		// (get) Token: 0x06011432 RID: 70706 RVA: 0x002870FE File Offset: 0x002852FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleDealCardNotify.Descriptor;
			}
		}

		// Token: 0x06011433 RID: 70707 RVA: 0x00287105 File Offset: 0x00285305
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDealCardNotify()
		{
		}

		// Token: 0x06011434 RID: 70708 RVA: 0x00287118 File Offset: 0x00285318
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDealCardNotify(PhantomBattleDealCardNotify other) : this()
		{
			this.phantomBattleHandCardInfos_ = other.phantomBattleHandCardInfos_.Clone();
			this.curCardLibraryNum_ = other.curCardLibraryNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011435 RID: 70709 RVA: 0x0028714E File Offset: 0x0028534E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDealCardNotify Clone()
		{
			return new PhantomBattleDealCardNotify(this);
		}

		// Token: 0x1700391D RID: 14621
		// (get) Token: 0x06011436 RID: 70710 RVA: 0x00287156 File Offset: 0x00285356
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomBattleHandCardInfo> PhantomBattleHandCardInfos
		{
			get
			{
				return this.phantomBattleHandCardInfos_;
			}
		}

		// Token: 0x1700391E RID: 14622
		// (get) Token: 0x06011437 RID: 70711 RVA: 0x0028715E File Offset: 0x0028535E
		// (set) Token: 0x06011438 RID: 70712 RVA: 0x00287166 File Offset: 0x00285366
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

		// Token: 0x06011439 RID: 70713 RVA: 0x0028716F File Offset: 0x0028536F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleDealCardNotify);
		}

		// Token: 0x0601143A RID: 70714 RVA: 0x00287180 File Offset: 0x00285380
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleDealCardNotify other)
		{
			return other != null && (other == this || (this.phantomBattleHandCardInfos_.Equals(other.phantomBattleHandCardInfos_) && this.CurCardLibraryNum == other.CurCardLibraryNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601143B RID: 70715 RVA: 0x002871D0 File Offset: 0x002853D0
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

		// Token: 0x0601143C RID: 70716 RVA: 0x0028721D File Offset: 0x0028541D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601143D RID: 70717 RVA: 0x0028722A File Offset: 0x0028542A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601143E RID: 70718 RVA: 0x00287234 File Offset: 0x00285434
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.phantomBattleHandCardInfos_.WriteTo(ref output, PhantomBattleDealCardNotify._repeated_phantomBattleHandCardInfos_codec);
			if (this.CurCardLibraryNum != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.CurCardLibraryNum);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601143F RID: 70719 RVA: 0x00287284 File Offset: 0x00285484
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

		// Token: 0x06011440 RID: 70720 RVA: 0x002872D8 File Offset: 0x002854D8
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

		// Token: 0x06011441 RID: 70721 RVA: 0x00287325 File Offset: 0x00285525
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011442 RID: 70722 RVA: 0x00287330 File Offset: 0x00285530
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
					if (num != 64U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.CurCardLibraryNum = input.ReadInt32();
					}
				}
				else
				{
					this.phantomBattleHandCardInfos_.AddEntriesFrom(ref input, PhantomBattleDealCardNotify._repeated_phantomBattleHandCardInfos_codec);
				}
			}
		}

		// Token: 0x04006D2E RID: 27950
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006D2F RID: 27951
		public const int PhantomBattleHandCardInfosFieldNumber = 1;

		// Token: 0x04006D30 RID: 27952
		private static readonly FieldCodec<PhantomBattleHandCardInfo> _repeated_phantomBattleHandCardInfos_codec = FieldCodec.ForMessage<PhantomBattleHandCardInfo>(10U, PhantomBattleHandCardInfo.Parser);

		// Token: 0x04006D31 RID: 27953
		private readonly RepeatedField<PhantomBattleHandCardInfo> phantomBattleHandCardInfos_ = new RepeatedField<PhantomBattleHandCardInfo>();

		// Token: 0x04006D32 RID: 27954
		public const int CurCardLibraryNumFieldNumber = 8;

		// Token: 0x04006D33 RID: 27955
		private int curCardLibraryNum_;
	}
}
