using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200085A RID: 2138
	[NetMessage(EMessageId.ItemPkgOpenNotify)]
	public sealed class ItemPkgOpenNotify : IMessage<ItemPkgOpenNotify>, IMessage, IEquatable<ItemPkgOpenNotify>, IDeepCloneable<ItemPkgOpenNotify>, IBufferMessage
	{
		// Token: 0x0600BE97 RID: 48791 RVA: 0x001C4CCD File Offset: 0x001C2ECD
		[NullableContext(1)]
		public static ItemPkgOpenNotify Create()
		{
			return new ItemPkgOpenNotify();
		}

		// Token: 0x1700267C RID: 9852
		// (get) Token: 0x0600BE98 RID: 48792 RVA: 0x001C4CD4 File Offset: 0x001C2ED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700267D RID: 9853
		// (get) Token: 0x0600BE99 RID: 48793 RVA: 0x001C4CD7 File Offset: 0x001C2ED7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ItemPkgOpenNotify.Descriptor;
			}
		}

		// Token: 0x0600BE9A RID: 48794 RVA: 0x001C4CDE File Offset: 0x001C2EDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemPkgOpenNotify()
		{
		}

		// Token: 0x0600BE9B RID: 48795 RVA: 0x001C4CF1 File Offset: 0x001C2EF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemPkgOpenNotify(ItemPkgOpenNotify other) : this()
		{
			this.openPkg_ = other.openPkg_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BE9C RID: 48796 RVA: 0x001C4D1B File Offset: 0x001C2F1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemPkgOpenNotify Clone()
		{
			return new ItemPkgOpenNotify(this);
		}

		// Token: 0x1700267E RID: 9854
		// (get) Token: 0x0600BE9D RID: 48797 RVA: 0x001C4D23 File Offset: 0x001C2F23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> OpenPkg
		{
			get
			{
				return this.openPkg_;
			}
		}

		// Token: 0x0600BE9E RID: 48798 RVA: 0x001C4D2B File Offset: 0x001C2F2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ItemPkgOpenNotify);
		}

		// Token: 0x0600BE9F RID: 48799 RVA: 0x001C4D39 File Offset: 0x001C2F39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ItemPkgOpenNotify other)
		{
			return other != null && (other == this || (this.openPkg_.Equals(other.openPkg_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BEA0 RID: 48800 RVA: 0x001C4D6C File Offset: 0x001C2F6C
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

		// Token: 0x0600BEA1 RID: 48801 RVA: 0x001C4DA0 File Offset: 0x001C2FA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BEA2 RID: 48802 RVA: 0x001C4DAD File Offset: 0x001C2FAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BEA3 RID: 48803 RVA: 0x001C4DB6 File Offset: 0x001C2FB6
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

		// Token: 0x0600BEA4 RID: 48804 RVA: 0x001C4DE0 File Offset: 0x001C2FE0
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

		// Token: 0x0600BEA5 RID: 48805 RVA: 0x001C4E19 File Offset: 0x001C3019
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

		// Token: 0x0600BEA6 RID: 48806 RVA: 0x001C4E47 File Offset: 0x001C3047
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BEA7 RID: 48807 RVA: 0x001C4E50 File Offset: 0x001C3050
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
				if (num != 80U && num != 82U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.openPkg_.AddEntriesFrom(ref input, ItemPkgOpenNotify._repeated_openPkg_codec);
				}
			}
		}

		// Token: 0x04005318 RID: 21272
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005319 RID: 21273
		public const int OpenPkgFieldNumber = 10;

		// Token: 0x0400531A RID: 21274
		private static readonly FieldCodec<int> _repeated_openPkg_codec = FieldCodec.ForInt32(82U);

		// Token: 0x0400531B RID: 21275
		private readonly RepeatedField<int> openPkg_ = new RepeatedField<int>();
	}
}
