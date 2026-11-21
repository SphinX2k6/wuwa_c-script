using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001235 RID: 4661
	[NetMessage(EMessageId.ShopUnlockNotify)]
	public sealed class ShopUnlockNotify : IMessage<ShopUnlockNotify>, IMessage, IEquatable<ShopUnlockNotify>, IDeepCloneable<ShopUnlockNotify>, IBufferMessage
	{
		// Token: 0x06018E5D RID: 101981 RVA: 0x003A163F File Offset: 0x0039F83F
		[NullableContext(1)]
		public static ShopUnlockNotify Create()
		{
			return new ShopUnlockNotify();
		}

		// Token: 0x17005423 RID: 21539
		// (get) Token: 0x06018E5E RID: 101982 RVA: 0x003A1646 File Offset: 0x0039F846
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005424 RID: 21540
		// (get) Token: 0x06018E5F RID: 101983 RVA: 0x003A1649 File Offset: 0x0039F849
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ShopUnlockNotify.Descriptor;
			}
		}

		// Token: 0x06018E60 RID: 101984 RVA: 0x003A1650 File Offset: 0x0039F850
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShopUnlockNotify()
		{
		}

		// Token: 0x06018E61 RID: 101985 RVA: 0x003A1663 File Offset: 0x0039F863
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShopUnlockNotify(ShopUnlockNotify other) : this()
		{
			this.unlockList_ = other.unlockList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018E62 RID: 101986 RVA: 0x003A168D File Offset: 0x0039F88D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShopUnlockNotify Clone()
		{
			return new ShopUnlockNotify(this);
		}

		// Token: 0x17005425 RID: 21541
		// (get) Token: 0x06018E63 RID: 101987 RVA: 0x003A1695 File Offset: 0x0039F895
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<UnlockInfo> UnlockList
		{
			get
			{
				return this.unlockList_;
			}
		}

		// Token: 0x06018E64 RID: 101988 RVA: 0x003A169D File Offset: 0x0039F89D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ShopUnlockNotify);
		}

		// Token: 0x06018E65 RID: 101989 RVA: 0x003A16AB File Offset: 0x0039F8AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ShopUnlockNotify other)
		{
			return other != null && (other == this || (this.unlockList_.Equals(other.unlockList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018E66 RID: 101990 RVA: 0x003A16E0 File Offset: 0x0039F8E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.unlockList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018E67 RID: 101991 RVA: 0x003A1714 File Offset: 0x0039F914
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018E68 RID: 101992 RVA: 0x003A1721 File Offset: 0x0039F921
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018E69 RID: 101993 RVA: 0x003A172A File Offset: 0x0039F92A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.unlockList_.WriteTo(ref output, ShopUnlockNotify._repeated_unlockList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018E6A RID: 101994 RVA: 0x003A1754 File Offset: 0x0039F954
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.unlockList_.CalculateSize(ShopUnlockNotify._repeated_unlockList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018E6B RID: 101995 RVA: 0x003A178D File Offset: 0x0039F98D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ShopUnlockNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.unlockList_.Add(other.unlockList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018E6C RID: 101996 RVA: 0x003A17BB File Offset: 0x0039F9BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018E6D RID: 101997 RVA: 0x003A17C4 File Offset: 0x0039F9C4
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
				if (num != 98U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.unlockList_.AddEntriesFrom(ref input, ShopUnlockNotify._repeated_unlockList_codec);
				}
			}
		}

		// Token: 0x040093BC RID: 37820
		private UnknownFieldSet _unknownFields;

		// Token: 0x040093BD RID: 37821
		public const int UnlockListFieldNumber = 12;

		// Token: 0x040093BE RID: 37822
		private static readonly FieldCodec<UnlockInfo> _repeated_unlockList_codec = FieldCodec.ForMessage<UnlockInfo>(98U, UnlockInfo.Parser);

		// Token: 0x040093BF RID: 37823
		private readonly RepeatedField<UnlockInfo> unlockList_ = new RepeatedField<UnlockInfo>();
	}
}
