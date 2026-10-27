using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C7E RID: 3198
	[NetMessage(EMessageId.PhantomBattleDiscardCardNotify)]
	public sealed class PhantomBattleDiscardCardNotify : IMessage<PhantomBattleDiscardCardNotify>, IMessage, IEquatable<PhantomBattleDiscardCardNotify>, IDeepCloneable<PhantomBattleDiscardCardNotify>, IBufferMessage
	{
		// Token: 0x06011552 RID: 70994 RVA: 0x002899F0 File Offset: 0x00287BF0
		[NullableContext(1)]
		public static PhantomBattleDiscardCardNotify Create()
		{
			return new PhantomBattleDiscardCardNotify();
		}

		// Token: 0x1700395B RID: 14683
		// (get) Token: 0x06011553 RID: 70995 RVA: 0x002899F7 File Offset: 0x00287BF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700395C RID: 14684
		// (get) Token: 0x06011554 RID: 70996 RVA: 0x002899FA File Offset: 0x00287BFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleDiscardCardNotify.Descriptor;
			}
		}

		// Token: 0x06011555 RID: 70997 RVA: 0x00289A01 File Offset: 0x00287C01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDiscardCardNotify()
		{
		}

		// Token: 0x06011556 RID: 70998 RVA: 0x00289A14 File Offset: 0x00287C14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDiscardCardNotify(PhantomBattleDiscardCardNotify other) : this()
		{
			this.discardCardNum_ = other.discardCardNum_;
			this.phantomBattleHandCardInfos_ = other.phantomBattleHandCardInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011557 RID: 70999 RVA: 0x00289A4A File Offset: 0x00287C4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleDiscardCardNotify Clone()
		{
			return new PhantomBattleDiscardCardNotify(this);
		}

		// Token: 0x1700395D RID: 14685
		// (get) Token: 0x06011558 RID: 71000 RVA: 0x00289A52 File Offset: 0x00287C52
		// (set) Token: 0x06011559 RID: 71001 RVA: 0x00289A5A File Offset: 0x00287C5A
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

		// Token: 0x1700395E RID: 14686
		// (get) Token: 0x0601155A RID: 71002 RVA: 0x00289A63 File Offset: 0x00287C63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomBattleHandCardInfo> PhantomBattleHandCardInfos
		{
			get
			{
				return this.phantomBattleHandCardInfos_;
			}
		}

		// Token: 0x0601155B RID: 71003 RVA: 0x00289A6B File Offset: 0x00287C6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleDiscardCardNotify);
		}

		// Token: 0x0601155C RID: 71004 RVA: 0x00289A7C File Offset: 0x00287C7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleDiscardCardNotify other)
		{
			return other != null && (other == this || (this.DiscardCardNum == other.DiscardCardNum && this.phantomBattleHandCardInfos_.Equals(other.phantomBattleHandCardInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601155D RID: 71005 RVA: 0x00289ACC File Offset: 0x00287CCC
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

		// Token: 0x0601155E RID: 71006 RVA: 0x00289B19 File Offset: 0x00287D19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601155F RID: 71007 RVA: 0x00289B26 File Offset: 0x00287D26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011560 RID: 71008 RVA: 0x00289B30 File Offset: 0x00287D30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.phantomBattleHandCardInfos_.WriteTo(ref output, PhantomBattleDiscardCardNotify._repeated_phantomBattleHandCardInfos_codec);
			if (this.DiscardCardNum != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.DiscardCardNum);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011561 RID: 71009 RVA: 0x00289B80 File Offset: 0x00287D80
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

		// Token: 0x06011562 RID: 71010 RVA: 0x00289BD4 File Offset: 0x00287DD4
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

		// Token: 0x06011563 RID: 71011 RVA: 0x00289C21 File Offset: 0x00287E21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011564 RID: 71012 RVA: 0x00289C2C File Offset: 0x00287E2C
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
				if (num != 34U)
				{
					if (num != 80U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.DiscardCardNum = input.ReadInt32();
					}
				}
				else
				{
					this.phantomBattleHandCardInfos_.AddEntriesFrom(ref input, PhantomBattleDiscardCardNotify._repeated_phantomBattleHandCardInfos_codec);
				}
			}
		}

		// Token: 0x04006D8C RID: 28044
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006D8D RID: 28045
		public const int DiscardCardNumFieldNumber = 10;

		// Token: 0x04006D8E RID: 28046
		private int discardCardNum_;

		// Token: 0x04006D8F RID: 28047
		public const int PhantomBattleHandCardInfosFieldNumber = 4;

		// Token: 0x04006D90 RID: 28048
		private static readonly FieldCodec<PhantomBattleHandCardInfo> _repeated_phantomBattleHandCardInfos_codec = FieldCodec.ForMessage<PhantomBattleHandCardInfo>(34U, PhantomBattleHandCardInfo.Parser);

		// Token: 0x04006D91 RID: 28049
		private readonly RepeatedField<PhantomBattleHandCardInfo> phantomBattleHandCardInfos_ = new RepeatedField<PhantomBattleHandCardInfo>();
	}
}
