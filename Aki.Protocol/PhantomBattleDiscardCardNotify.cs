using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C6E RID: 3182
	[NetMessage(EMessageId.PhantomBattleDiscardCardNotify)]
	public sealed class PhantomBattleDiscardCardNotify : IMessage<PhantomBattleDiscardCardNotify>, IMessage, IEquatable<PhantomBattleDiscardCardNotify>, IDeepCloneable<PhantomBattleDiscardCardNotify>, IBufferMessage
	{
		// Token: 0x06011452 RID: 70738 RVA: 0x00287C80 File Offset: 0x00285E80
		[NullableContext(1)]
		public static PhantomBattleDiscardCardNotify Create()
		{
			return new PhantomBattleDiscardCardNotify();
		}

		// Token: 0x17003924 RID: 14628
		// (get) Token: 0x06011453 RID: 70739 RVA: 0x00287C87 File Offset: 0x00285E87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003925 RID: 14629
		// (get) Token: 0x06011454 RID: 70740 RVA: 0x00287C8A File Offset: 0x00285E8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleDiscardCardNotify.Descriptor;
			}
		}

		// Token: 0x06011455 RID: 70741 RVA: 0x00287C91 File Offset: 0x00285E91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDiscardCardNotify()
		{
		}

		// Token: 0x06011456 RID: 70742 RVA: 0x00287CA4 File Offset: 0x00285EA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDiscardCardNotify(PhantomBattleDiscardCardNotify other) : this()
		{
			this.discardCardNum_ = other.discardCardNum_;
			this.phantomBattleHandCardInfos_ = other.phantomBattleHandCardInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011457 RID: 70743 RVA: 0x00287CDA File Offset: 0x00285EDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDiscardCardNotify Clone()
		{
			return new PhantomBattleDiscardCardNotify(this);
		}

		// Token: 0x17003926 RID: 14630
		// (get) Token: 0x06011458 RID: 70744 RVA: 0x00287CE2 File Offset: 0x00285EE2
		// (set) Token: 0x06011459 RID: 70745 RVA: 0x00287CEA File Offset: 0x00285EEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DiscardCardNum
		{
			get
			{
				return this.discardCardNum_;
			}
			set
			{
				this.discardCardNum_ = value;
			}
		}

		// Token: 0x17003927 RID: 14631
		// (get) Token: 0x0601145A RID: 70746 RVA: 0x00287CF3 File Offset: 0x00285EF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomBattleHandCardInfo> PhantomBattleHandCardInfos
		{
			get
			{
				return this.phantomBattleHandCardInfos_;
			}
		}

		// Token: 0x0601145B RID: 70747 RVA: 0x00287CFB File Offset: 0x00285EFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleDiscardCardNotify);
		}

		// Token: 0x0601145C RID: 70748 RVA: 0x00287D0C File Offset: 0x00285F0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleDiscardCardNotify other)
		{
			return other != null && (other == this || (this.DiscardCardNum == other.DiscardCardNum && this.phantomBattleHandCardInfos_.Equals(other.phantomBattleHandCardInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601145D RID: 70749 RVA: 0x00287D5C File Offset: 0x00285F5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DiscardCardNum != 0)
			{
				num ^= this.DiscardCardNum.GetHashCode();
			}
			num ^= this.phantomBattleHandCardInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601145E RID: 70750 RVA: 0x00287DA9 File Offset: 0x00285FA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601145F RID: 70751 RVA: 0x00287DB6 File Offset: 0x00285FB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011460 RID: 70752 RVA: 0x00287DC0 File Offset: 0x00285FC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DiscardCardNum != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.DiscardCardNum);
			}
			this.phantomBattleHandCardInfos_.WriteTo(ref output, PhantomBattleDiscardCardNotify._repeated_phantomBattleHandCardInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011461 RID: 70753 RVA: 0x00287E10 File Offset: 0x00286010
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DiscardCardNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DiscardCardNum);
			}
			num += this.phantomBattleHandCardInfos_.CalculateSize(PhantomBattleDiscardCardNotify._repeated_phantomBattleHandCardInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011462 RID: 70754 RVA: 0x00287E64 File Offset: 0x00286064
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleDiscardCardNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DiscardCardNum != 0)
			{
				this.DiscardCardNum = other.DiscardCardNum;
			}
			this.phantomBattleHandCardInfos_.Add(other.phantomBattleHandCardInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011463 RID: 70755 RVA: 0x00287EB1 File Offset: 0x002860B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011464 RID: 70756 RVA: 0x00287EBC File Offset: 0x002860BC
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
				if (num != 48U)
				{
					if (num != 90U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.phantomBattleHandCardInfos_.AddEntriesFrom(ref input, PhantomBattleDiscardCardNotify._repeated_phantomBattleHandCardInfos_codec);
					}
				}
				else
				{
					this.DiscardCardNum = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006DA0 RID: 28064
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006DA1 RID: 28065
		public const int DiscardCardNumFieldNumber = 6;

		// Token: 0x04006DA2 RID: 28066
		private int discardCardNum_;

		// Token: 0x04006DA3 RID: 28067
		public const int PhantomBattleHandCardInfosFieldNumber = 11;

		// Token: 0x04006DA4 RID: 28068
		private static readonly FieldCodec<PhantomBattleHandCardInfo> _repeated_phantomBattleHandCardInfos_codec = FieldCodec.ForMessage<PhantomBattleHandCardInfo>(90U, PhantomBattleHandCardInfo.Parser);

		// Token: 0x04006DA5 RID: 28069
		private readonly RepeatedField<PhantomBattleHandCardInfo> phantomBattleHandCardInfos_ = new RepeatedField<PhantomBattleHandCardInfo>();
	}
}
