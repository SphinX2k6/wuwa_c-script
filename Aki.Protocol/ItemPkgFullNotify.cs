using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000859 RID: 2137
	[NetMessage(EMessageId.ItemPkgFullNotify)]
	public sealed class ItemPkgFullNotify : IMessage<ItemPkgFullNotify>, IMessage, IEquatable<ItemPkgFullNotify>, IDeepCloneable<ItemPkgFullNotify>, IBufferMessage
	{
		// Token: 0x0600BE85 RID: 48773 RVA: 0x001C4AF5 File Offset: 0x001C2CF5
		[NullableContext(1)]
		public static ItemPkgFullNotify Create()
		{
			return new ItemPkgFullNotify();
		}

		// Token: 0x17002679 RID: 9849
		// (get) Token: 0x0600BE86 RID: 48774 RVA: 0x001C4AFC File Offset: 0x001C2CFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700267A RID: 9850
		// (get) Token: 0x0600BE87 RID: 48775 RVA: 0x001C4AFF File Offset: 0x001C2CFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ItemPkgFullNotify.Descriptor;
			}
		}

		// Token: 0x0600BE88 RID: 48776 RVA: 0x001C4B06 File Offset: 0x001C2D06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemPkgFullNotify()
		{
		}

		// Token: 0x0600BE89 RID: 48777 RVA: 0x001C4B0E File Offset: 0x001C2D0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemPkgFullNotify(ItemPkgFullNotify other) : this()
		{
			this.pkgType_ = other.pkgType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BE8A RID: 48778 RVA: 0x001C4B33 File Offset: 0x001C2D33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemPkgFullNotify Clone()
		{
			return new ItemPkgFullNotify(this);
		}

		// Token: 0x1700267B RID: 9851
		// (get) Token: 0x0600BE8B RID: 48779 RVA: 0x001C4B3B File Offset: 0x001C2D3B
		// (set) Token: 0x0600BE8C RID: 48780 RVA: 0x001C4B43 File Offset: 0x001C2D43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PkgType
		{
			get
			{
				return this.pkgType_;
			}
			set
			{
				this.pkgType_ = value;
			}
		}

		// Token: 0x0600BE8D RID: 48781 RVA: 0x001C4B4C File Offset: 0x001C2D4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ItemPkgFullNotify);
		}

		// Token: 0x0600BE8E RID: 48782 RVA: 0x001C4B5A File Offset: 0x001C2D5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ItemPkgFullNotify other)
		{
			return other != null && (other == this || (this.PkgType == other.PkgType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BE8F RID: 48783 RVA: 0x001C4B88 File Offset: 0x001C2D88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PkgType != 0)
			{
				num ^= this.PkgType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BE90 RID: 48784 RVA: 0x001C4BC7 File Offset: 0x001C2DC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BE91 RID: 48785 RVA: 0x001C4BD4 File Offset: 0x001C2DD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BE92 RID: 48786 RVA: 0x001C4BDD File Offset: 0x001C2DDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PkgType != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.PkgType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BE93 RID: 48787 RVA: 0x001C4C10 File Offset: 0x001C2E10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PkgType != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PkgType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BE94 RID: 48788 RVA: 0x001C4C4E File Offset: 0x001C2E4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ItemPkgFullNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PkgType != 0)
			{
				this.PkgType = other.PkgType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BE95 RID: 48789 RVA: 0x001C4C7F File Offset: 0x001C2E7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BE96 RID: 48790 RVA: 0x001C4C88 File Offset: 0x001C2E88
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.PkgType = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005315 RID: 21269
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005316 RID: 21270
		public const int PkgTypeFieldNumber = 3;

		// Token: 0x04005317 RID: 21271
		private int pkgType_;
	}
}
