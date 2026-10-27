using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001BF RID: 447
	public sealed class BookItemInfo : IMessage<BookItemInfo>, IMessage, IEquatable<BookItemInfo>, IDeepCloneable<BookItemInfo>, IBufferMessage
	{
		// Token: 0x06003384 RID: 13188 RVA: 0x00082500 File Offset: 0x00080700
		[NullableContext(1)]
		public static BookItemInfo Create()
		{
			return new BookItemInfo();
		}

		// Token: 0x1700081F RID: 2079
		// (get) Token: 0x06003385 RID: 13189 RVA: 0x00082507 File Offset: 0x00080707
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BookItemInfo> Parser
		{
			get
			{
				return BookItemInfo._parser;
			}
		}

		// Token: 0x17000820 RID: 2080
		// (get) Token: 0x06003386 RID: 13190 RVA: 0x0008250E File Offset: 0x0008070E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000821 RID: 2081
		// (get) Token: 0x06003387 RID: 13191 RVA: 0x00082511 File Offset: 0x00080711
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BookItemInfo.Descriptor;
			}
		}

		// Token: 0x06003388 RID: 13192 RVA: 0x00082518 File Offset: 0x00080718
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BookItemInfo()
		{
		}

		// Token: 0x06003389 RID: 13193 RVA: 0x00082520 File Offset: 0x00080720
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BookItemInfo(BookItemInfo other) : this()
		{
			this.bookItemId_ = other.bookItemId_;
			this.bookItemState_ = other.bookItemState_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600338A RID: 13194 RVA: 0x00082551 File Offset: 0x00080751
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BookItemInfo Clone()
		{
			return new BookItemInfo(this);
		}

		// Token: 0x17000822 RID: 2082
		// (get) Token: 0x0600338B RID: 13195 RVA: 0x00082559 File Offset: 0x00080759
		// (set) Token: 0x0600338C RID: 13196 RVA: 0x00082561 File Offset: 0x00080761
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BookItemId
		{
			get
			{
				return this.bookItemId_;
			}
			set
			{
				this.bookItemId_ = value;
			}
		}

		// Token: 0x17000823 RID: 2083
		// (get) Token: 0x0600338D RID: 13197 RVA: 0x0008256A File Offset: 0x0008076A
		// (set) Token: 0x0600338E RID: 13198 RVA: 0x00082572 File Offset: 0x00080772
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BookItemState BookItemState
		{
			get
			{
				return this.bookItemState_;
			}
			set
			{
				this.bookItemState_ = value;
			}
		}

		// Token: 0x0600338F RID: 13199 RVA: 0x0008257B File Offset: 0x0008077B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BookItemInfo);
		}

		// Token: 0x06003390 RID: 13200 RVA: 0x00082589 File Offset: 0x00080789
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BookItemInfo other)
		{
			return other != null && (other == this || (this.BookItemId == other.BookItemId && this.BookItemState == other.BookItemState && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003391 RID: 13201 RVA: 0x000825C8 File Offset: 0x000807C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BookItemId != 0)
			{
				num ^= this.BookItemId.GetHashCode();
			}
			if (this.BookItemState != BookItemState.BookItemLock)
			{
				num ^= this.BookItemState.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003392 RID: 13202 RVA: 0x00082626 File Offset: 0x00080826
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003393 RID: 13203 RVA: 0x00082633 File Offset: 0x00080833
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003394 RID: 13204 RVA: 0x0008263C File Offset: 0x0008083C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BookItemId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.BookItemId);
			}
			if (this.BookItemState != BookItemState.BookItemLock)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.BookItemState);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003395 RID: 13205 RVA: 0x00082694 File Offset: 0x00080894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BookItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BookItemId);
			}
			if (this.BookItemState != BookItemState.BookItemLock)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.BookItemState);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003396 RID: 13206 RVA: 0x000826EC File Offset: 0x000808EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BookItemInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BookItemId != 0)
			{
				this.BookItemId = other.BookItemId;
			}
			if (other.BookItemState != BookItemState.BookItemLock)
			{
				this.BookItemState = other.BookItemState;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003397 RID: 13207 RVA: 0x0008273C File Offset: 0x0008093C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003398 RID: 13208 RVA: 0x00082748 File Offset: 0x00080948
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
				if (num != 8U)
				{
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.BookItemState = (BookItemState)input.ReadEnum();
					}
				}
				else
				{
					this.BookItemId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040029BE RID: 10686
		private static readonly MessageParser<BookItemInfo> _parser = new MessageParser<BookItemInfo>(() => new BookItemInfo());

		// Token: 0x040029BF RID: 10687
		private UnknownFieldSet _unknownFields;

		// Token: 0x040029C0 RID: 10688
		public const int BookItemIdFieldNumber = 1;

		// Token: 0x040029C1 RID: 10689
		private int bookItemId_;

		// Token: 0x040029C2 RID: 10690
		public const int BookItemStateFieldNumber = 2;

		// Token: 0x040029C3 RID: 10691
		private BookItemState bookItemState_;
	}
}
