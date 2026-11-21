using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000848 RID: 2120
	[NetMessage(EMessageId.ItemPkgOpenNotify)]
	public sealed class ItemPkgOpenNotify : IMessage<ItemPkgOpenNotify>, IMessage, IEquatable<ItemPkgOpenNotify>, IDeepCloneable<ItemPkgOpenNotify>, IBufferMessage
	{
		// Token: 0x0600BD69 RID: 48489 RVA: 0x001C2801 File Offset: 0x001C0A01
		[NullableContext(1)]
		public static ItemPkgOpenNotify Create()
		{
			return new ItemPkgOpenNotify();
		}

		// Token: 0x1700263A RID: 9786
		// (get) Token: 0x0600BD6A RID: 48490 RVA: 0x001C2808 File Offset: 0x001C0A08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700263B RID: 9787
		// (get) Token: 0x0600BD6B RID: 48491 RVA: 0x001C280B File Offset: 0x001C0A0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ItemPkgOpenNotify.Descriptor;
			}
		}

		// Token: 0x0600BD6C RID: 48492 RVA: 0x001C2812 File Offset: 0x001C0A12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemPkgOpenNotify()
		{
		}

		// Token: 0x0600BD6D RID: 48493 RVA: 0x001C2825 File Offset: 0x001C0A25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemPkgOpenNotify(ItemPkgOpenNotify other) : this()
		{
			this.openPkg_ = other.openPkg_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BD6E RID: 48494 RVA: 0x001C284F File Offset: 0x001C0A4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemPkgOpenNotify Clone()
		{
			return new ItemPkgOpenNotify(this);
		}

		// Token: 0x1700263C RID: 9788
		// (get) Token: 0x0600BD6F RID: 48495 RVA: 0x001C2857 File Offset: 0x001C0A57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> OpenPkg
		{
			get
			{
				return this.openPkg_;
			}
		}

		// Token: 0x0600BD70 RID: 48496 RVA: 0x001C285F File Offset: 0x001C0A5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ItemPkgOpenNotify);
		}

		// Token: 0x0600BD71 RID: 48497 RVA: 0x001C286D File Offset: 0x001C0A6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ItemPkgOpenNotify other)
		{
			return other != null && (other == this || (this.openPkg_.Equals(other.openPkg_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BD72 RID: 48498 RVA: 0x001C28A0 File Offset: 0x001C0AA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.openPkg_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BD73 RID: 48499 RVA: 0x001C28D4 File Offset: 0x001C0AD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BD74 RID: 48500 RVA: 0x001C28E1 File Offset: 0x001C0AE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BD75 RID: 48501 RVA: 0x001C28EA File Offset: 0x001C0AEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.openPkg_.WriteTo(ref output, ItemPkgOpenNotify._repeated_openPkg_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BD76 RID: 48502 RVA: 0x001C2914 File Offset: 0x001C0B14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.openPkg_.CalculateSize(ItemPkgOpenNotify._repeated_openPkg_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BD77 RID: 48503 RVA: 0x001C294D File Offset: 0x001C0B4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ItemPkgOpenNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.openPkg_.Add(other.openPkg_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BD78 RID: 48504 RVA: 0x001C297B File Offset: 0x001C0B7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BD79 RID: 48505 RVA: 0x001C2984 File Offset: 0x001C0B84
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
				if (num != 72U && num != 74U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.openPkg_.AddEntriesFrom(ref input, ItemPkgOpenNotify._repeated_openPkg_codec);
				}
			}
		}

		// Token: 0x0400531B RID: 21275
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400531C RID: 21276
		public const int OpenPkgFieldNumber = 9;

		// Token: 0x0400531D RID: 21277
		private static readonly FieldCodec<int> _repeated_openPkg_codec = FieldCodec.ForInt32(74U);

		// Token: 0x0400531E RID: 21278
		private readonly RepeatedField<int> openPkg_ = new RepeatedField<int>();
	}
}
