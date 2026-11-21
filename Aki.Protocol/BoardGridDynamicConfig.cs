using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001BA RID: 442
	public sealed class BoardGridDynamicConfig : IMessage<BoardGridDynamicConfig>, IMessage, IEquatable<BoardGridDynamicConfig>, IDeepCloneable<BoardGridDynamicConfig>, IBufferMessage
	{
		// Token: 0x0600335C RID: 13148 RVA: 0x0008249C File Offset: 0x0008069C
		[NullableContext(1)]
		public static BoardGridDynamicConfig Create()
		{
			return new BoardGridDynamicConfig();
		}

		// Token: 0x17000813 RID: 2067
		// (get) Token: 0x0600335D RID: 13149 RVA: 0x000824A3 File Offset: 0x000806A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BoardGridDynamicConfig> Parser
		{
			get
			{
				return BoardGridDynamicConfig._parser;
			}
		}

		// Token: 0x17000814 RID: 2068
		// (get) Token: 0x0600335E RID: 13150 RVA: 0x000824AA File Offset: 0x000806AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000815 RID: 2069
		// (get) Token: 0x0600335F RID: 13151 RVA: 0x000824AD File Offset: 0x000806AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BoardGridDynamicConfig.Descriptor;
			}
		}

		// Token: 0x06003360 RID: 13152 RVA: 0x000824B4 File Offset: 0x000806B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BoardGridDynamicConfig()
		{
		}

		// Token: 0x06003361 RID: 13153 RVA: 0x000824BC File Offset: 0x000806BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BoardGridDynamicConfig(BoardGridDynamicConfig other) : this()
		{
			this.rowIndex_ = other.rowIndex_;
			this.columnIndex_ = other.columnIndex_;
			this.flags_ = other.flags_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003362 RID: 13154 RVA: 0x000824F9 File Offset: 0x000806F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BoardGridDynamicConfig Clone()
		{
			return new BoardGridDynamicConfig(this);
		}

		// Token: 0x17000816 RID: 2070
		// (get) Token: 0x06003363 RID: 13155 RVA: 0x00082501 File Offset: 0x00080701
		// (set) Token: 0x06003364 RID: 13156 RVA: 0x00082509 File Offset: 0x00080709
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RowIndex
		{
			get
			{
				return this.rowIndex_;
			}
			set
			{
				this.rowIndex_ = value;
			}
		}

		// Token: 0x17000817 RID: 2071
		// (get) Token: 0x06003365 RID: 13157 RVA: 0x00082512 File Offset: 0x00080712
		// (set) Token: 0x06003366 RID: 13158 RVA: 0x0008251A File Offset: 0x0008071A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ColumnIndex
		{
			get
			{
				return this.columnIndex_;
			}
			set
			{
				this.columnIndex_ = value;
			}
		}

		// Token: 0x17000818 RID: 2072
		// (get) Token: 0x06003367 RID: 13159 RVA: 0x00082523 File Offset: 0x00080723
		// (set) Token: 0x06003368 RID: 13160 RVA: 0x0008252B File Offset: 0x0008072B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Flags
		{
			get
			{
				return this.flags_;
			}
			set
			{
				this.flags_ = value;
			}
		}

		// Token: 0x06003369 RID: 13161 RVA: 0x00082534 File Offset: 0x00080734
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BoardGridDynamicConfig);
		}

		// Token: 0x0600336A RID: 13162 RVA: 0x00082544 File Offset: 0x00080744
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BoardGridDynamicConfig other)
		{
			return other != null && (other == this || (this.RowIndex == other.RowIndex && this.ColumnIndex == other.ColumnIndex && this.Flags == other.Flags && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600336B RID: 13163 RVA: 0x000825A0 File Offset: 0x000807A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RowIndex != 0)
			{
				num ^= this.RowIndex.GetHashCode();
			}
			if (this.ColumnIndex != 0)
			{
				num ^= this.ColumnIndex.GetHashCode();
			}
			if (this.Flags != 0L)
			{
				num ^= this.Flags.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600336C RID: 13164 RVA: 0x00082611 File Offset: 0x00080811
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600336D RID: 13165 RVA: 0x0008261E File Offset: 0x0008081E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600336E RID: 13166 RVA: 0x00082628 File Offset: 0x00080828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RowIndex != 0)
			{
				output.WriteRawTag(8);
				output.WriteSInt32(this.RowIndex);
			}
			if (this.ColumnIndex != 0)
			{
				output.WriteRawTag(16);
				output.WriteSInt32(this.ColumnIndex);
			}
			if (this.Flags != 0L)
			{
				output.WriteRawTag(24);
				output.WriteSInt64(this.Flags);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600336F RID: 13167 RVA: 0x0008269C File Offset: 0x0008089C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RowIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeSInt32Size(this.RowIndex);
			}
			if (this.ColumnIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeSInt32Size(this.ColumnIndex);
			}
			if (this.Flags != 0L)
			{
				num += 1 + CodedOutputStream.ComputeSInt64Size(this.Flags);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003370 RID: 13168 RVA: 0x0008270C File Offset: 0x0008090C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BoardGridDynamicConfig other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RowIndex != 0)
			{
				this.RowIndex = other.RowIndex;
			}
			if (other.ColumnIndex != 0)
			{
				this.ColumnIndex = other.ColumnIndex;
			}
			if (other.Flags != 0L)
			{
				this.Flags = other.Flags;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003371 RID: 13169 RVA: 0x00082770 File Offset: 0x00080970
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003372 RID: 13170 RVA: 0x0008277C File Offset: 0x0008097C
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
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Flags = input.ReadSInt64();
						}
					}
					else
					{
						this.ColumnIndex = input.ReadSInt32();
					}
				}
				else
				{
					this.RowIndex = input.ReadSInt32();
				}
			}
		}

		// Token: 0x04002A09 RID: 10761
		private static readonly MessageParser<BoardGridDynamicConfig> _parser = new MessageParser<BoardGridDynamicConfig>(() => new BoardGridDynamicConfig());

		// Token: 0x04002A0A RID: 10762
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002A0B RID: 10763
		public const int RowIndexFieldNumber = 1;

		// Token: 0x04002A0C RID: 10764
		private int rowIndex_;

		// Token: 0x04002A0D RID: 10765
		public const int ColumnIndexFieldNumber = 2;

		// Token: 0x04002A0E RID: 10766
		private int columnIndex_;

		// Token: 0x04002A0F RID: 10767
		public const int FlagsFieldNumber = 3;

		// Token: 0x04002A10 RID: 10768
		private long flags_;
	}
}
