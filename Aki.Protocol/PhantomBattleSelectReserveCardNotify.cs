using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CAF RID: 3247
	[NetMessage(EMessageId.PhantomBattleSelectReserveCardNotify)]
	public sealed class PhantomBattleSelectReserveCardNotify : IMessage<PhantomBattleSelectReserveCardNotify>, IMessage, IEquatable<PhantomBattleSelectReserveCardNotify>, IDeepCloneable<PhantomBattleSelectReserveCardNotify>, IBufferMessage
	{
		// Token: 0x0601196E RID: 72046 RVA: 0x002936B5 File Offset: 0x002918B5
		[NullableContext(1)]
		public static PhantomBattleSelectReserveCardNotify Create()
		{
			return new PhantomBattleSelectReserveCardNotify();
		}

		// Token: 0x17003A45 RID: 14917
		// (get) Token: 0x0601196F RID: 72047 RVA: 0x002936BC File Offset: 0x002918BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003A46 RID: 14918
		// (get) Token: 0x06011970 RID: 72048 RVA: 0x002936BF File Offset: 0x002918BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleSelectReserveCardNotify.Descriptor;
			}
		}

		// Token: 0x06011971 RID: 72049 RVA: 0x002936C6 File Offset: 0x002918C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleSelectReserveCardNotify()
		{
		}

		// Token: 0x06011972 RID: 72050 RVA: 0x002936D9 File Offset: 0x002918D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleSelectReserveCardNotify(PhantomBattleSelectReserveCardNotify other) : this()
		{
			this.reserveCardNum_ = other.reserveCardNum_;
			this.phantomBattleHandCardInfos_ = other.phantomBattleHandCardInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011973 RID: 72051 RVA: 0x0029370F File Offset: 0x0029190F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleSelectReserveCardNotify Clone()
		{
			return new PhantomBattleSelectReserveCardNotify(this);
		}

		// Token: 0x17003A47 RID: 14919
		// (get) Token: 0x06011974 RID: 72052 RVA: 0x00293717 File Offset: 0x00291917
		// (set) Token: 0x06011975 RID: 72053 RVA: 0x0029371F File Offset: 0x0029191F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ReserveCardNum
		{
			get
			{
				return this.reserveCardNum_;
			}
			set
			{
				this.reserveCardNum_ = value;
			}
		}

		// Token: 0x17003A48 RID: 14920
		// (get) Token: 0x06011976 RID: 72054 RVA: 0x00293728 File Offset: 0x00291928
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomBattleHandCardInfo> PhantomBattleHandCardInfos
		{
			get
			{
				return this.phantomBattleHandCardInfos_;
			}
		}

		// Token: 0x06011977 RID: 72055 RVA: 0x00293730 File Offset: 0x00291930
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleSelectReserveCardNotify);
		}

		// Token: 0x06011978 RID: 72056 RVA: 0x00293740 File Offset: 0x00291940
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleSelectReserveCardNotify other)
		{
			return other != null && (other == this || (this.ReserveCardNum == other.ReserveCardNum && this.phantomBattleHandCardInfos_.Equals(other.phantomBattleHandCardInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011979 RID: 72057 RVA: 0x00293790 File Offset: 0x00291990
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ReserveCardNum != 0)
			{
				num ^= this.ReserveCardNum.GetHashCode();
			}
			num ^= this.phantomBattleHandCardInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601197A RID: 72058 RVA: 0x002937DD File Offset: 0x002919DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601197B RID: 72059 RVA: 0x002937EA File Offset: 0x002919EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601197C RID: 72060 RVA: 0x002937F4 File Offset: 0x002919F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.phantomBattleHandCardInfos_.WriteTo(ref output, PhantomBattleSelectReserveCardNotify._repeated_phantomBattleHandCardInfos_codec);
			if (this.ReserveCardNum != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.ReserveCardNum);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601197D RID: 72061 RVA: 0x00293844 File Offset: 0x00291A44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ReserveCardNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ReserveCardNum);
			}
			num += this.phantomBattleHandCardInfos_.CalculateSize(PhantomBattleSelectReserveCardNotify._repeated_phantomBattleHandCardInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601197E RID: 72062 RVA: 0x00293898 File Offset: 0x00291A98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleSelectReserveCardNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ReserveCardNum != 0)
			{
				this.ReserveCardNum = other.ReserveCardNum;
			}
			this.phantomBattleHandCardInfos_.Add(other.phantomBattleHandCardInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601197F RID: 72063 RVA: 0x002938E5 File Offset: 0x00291AE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011980 RID: 72064 RVA: 0x002938F0 File Offset: 0x00291AF0
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
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ReserveCardNum = input.ReadInt32();
					}
				}
				else
				{
					this.phantomBattleHandCardInfos_.AddEntriesFrom(ref input, PhantomBattleSelectReserveCardNotify._repeated_phantomBattleHandCardInfos_codec);
				}
			}
		}

		// Token: 0x04006ECD RID: 28365
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006ECE RID: 28366
		public const int ReserveCardNumFieldNumber = 14;

		// Token: 0x04006ECF RID: 28367
		private int reserveCardNum_;

		// Token: 0x04006ED0 RID: 28368
		public const int PhantomBattleHandCardInfosFieldNumber = 4;

		// Token: 0x04006ED1 RID: 28369
		private static readonly FieldCodec<PhantomBattleHandCardInfo> _repeated_phantomBattleHandCardInfos_codec = FieldCodec.ForMessage<PhantomBattleHandCardInfo>(34U, PhantomBattleHandCardInfo.Parser);

		// Token: 0x04006ED2 RID: 28370
		private readonly RepeatedField<PhantomBattleHandCardInfo> phantomBattleHandCardInfos_ = new RepeatedField<PhantomBattleHandCardInfo>();
	}
}
