using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001C3 RID: 451
	public sealed class BookItemInfo : IMessage<BookItemInfo>, IMessage, IEquatable<BookItemInfo>, IDeepCloneable<BookItemInfo>, IBufferMessage
	{
		// Token: 0x06003411 RID: 13329 RVA: 0x00083C70 File Offset: 0x00081E70
		[NullableContext(1)]
		public static BookItemInfo Create()
		{
			return new BookItemInfo();
		}

		// Token: 0x17000838 RID: 2104
		// (get) Token: 0x06003412 RID: 13330 RVA: 0x00083C77 File Offset: 0x00081E77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BookItemInfo> Parser
		{
			get
			{
				return BookItemInfo._parser;
			}
		}

		// Token: 0x17000839 RID: 2105
		// (get) Token: 0x06003413 RID: 13331 RVA: 0x00083C7E File Offset: 0x00081E7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700083A RID: 2106
		// (get) Token: 0x06003414 RID: 13332 RVA: 0x00083C81 File Offset: 0x00081E81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BookItemInfo.Descriptor;
			}
		}

		// Token: 0x06003415 RID: 13333 RVA: 0x00083C88 File Offset: 0x00081E88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BookItemInfo()
		{
		}

		// Token: 0x06003416 RID: 13334 RVA: 0x00083C90 File Offset: 0x00081E90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BookItemInfo(BookItemInfo other) : this()
		{
			this.bookItemId_ = other.bookItemId_;
			this.bookItemState_ = other.bookItemState_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003417 RID: 13335 RVA: 0x00083CC1 File Offset: 0x00081EC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BookItemInfo Clone()
		{
			return new BookItemInfo(this);
		}

		// Token: 0x1700083B RID: 2107
		// (get) Token: 0x06003418 RID: 13336 RVA: 0x00083CC9 File Offset: 0x00081EC9
		// (set) Token: 0x06003419 RID: 13337 RVA: 0x00083CD1 File Offset: 0x00081ED1
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

		// Token: 0x1700083C RID: 2108
		// (get) Token: 0x0600341A RID: 13338 RVA: 0x00083CDA File Offset: 0x00081EDA
		// (set) Token: 0x0600341B RID: 13339 RVA: 0x00083CE2 File Offset: 0x00081EE2
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

		// Token: 0x0600341C RID: 13340 RVA: 0x00083CEB File Offset: 0x00081EEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BookItemInfo);
		}

		// Token: 0x0600341D RID: 13341 RVA: 0x00083CF9 File Offset: 0x00081EF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BookItemInfo other)
		{
			return other != null && (other == this || (this.BookItemId == other.BookItemId && this.BookItemState == other.BookItemState && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600341E RID: 13342 RVA: 0x00083D38 File Offset: 0x00081F38
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

		// Token: 0x0600341F RID: 13343 RVA: 0x00083D96 File Offset: 0x00081F96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003420 RID: 13344 RVA: 0x00083DA3 File Offset: 0x00081FA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003421 RID: 13345 RVA: 0x00083DAC File Offset: 0x00081FAC
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

		// Token: 0x06003422 RID: 13346 RVA: 0x00083E04 File Offset: 0x00082004
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

		// Token: 0x06003423 RID: 13347 RVA: 0x00083E5C File Offset: 0x0008205C
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

		// Token: 0x06003424 RID: 13348 RVA: 0x00083EAC File Offset: 0x000820AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003425 RID: 13349 RVA: 0x00083EB8 File Offset: 0x000820B8
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

		// Token: 0x04002A39 RID: 10809
		private static readonly MessageParser<BookItemInfo> _parser = new MessageParser<BookItemInfo>(() => new BookItemInfo());

		// Token: 0x04002A3A RID: 10810
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002A3B RID: 10811
		public const int BookItemIdFieldNumber = 1;

		// Token: 0x04002A3C RID: 10812
		private int bookItemId_;

		// Token: 0x04002A3D RID: 10813
		public const int BookItemStateFieldNumber = 2;

		// Token: 0x04002A3E RID: 10814
		private BookItemState bookItemState_;
	}
}
