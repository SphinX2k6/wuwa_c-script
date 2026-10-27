using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001B6 RID: 438
	public sealed class BoardGridDynamicConfig : IMessage<BoardGridDynamicConfig>, IMessage, IEquatable<BoardGridDynamicConfig>, IDeepCloneable<BoardGridDynamicConfig>, IBufferMessage
	{
		// Token: 0x060032CF RID: 13007 RVA: 0x00080D2B File Offset: 0x0007EF2B
		[NullableContext(1)]
		public static BoardGridDynamicConfig Create()
		{
			return new BoardGridDynamicConfig();
		}

		// Token: 0x170007FA RID: 2042
		// (get) Token: 0x060032D0 RID: 13008 RVA: 0x00080D32 File Offset: 0x0007EF32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<BoardGridDynamicConfig> Parser
		{
			get
			{
				return BoardGridDynamicConfig._parser;
			}
		}

		// Token: 0x170007FB RID: 2043
		// (get) Token: 0x060032D1 RID: 13009 RVA: 0x00080D39 File Offset: 0x0007EF39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170007FC RID: 2044
		// (get) Token: 0x060032D2 RID: 13010 RVA: 0x00080D3C File Offset: 0x0007EF3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BoardGridDynamicConfig.Descriptor;
			}
		}

		// Token: 0x060032D3 RID: 13011 RVA: 0x00080D43 File Offset: 0x0007EF43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BoardGridDynamicConfig()
		{
		}

		// Token: 0x060032D4 RID: 13012 RVA: 0x00080D4B File Offset: 0x0007EF4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BoardGridDynamicConfig(BoardGridDynamicConfig other) : this()
		{
			this.rowIndex_ = other.rowIndex_;
			this.columnIndex_ = other.columnIndex_;
			this.flags_ = other.flags_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060032D5 RID: 13013 RVA: 0x00080D88 File Offset: 0x0007EF88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BoardGridDynamicConfig Clone()
		{
			return new BoardGridDynamicConfig(this);
		}

		// Token: 0x170007FD RID: 2045
		// (get) Token: 0x060032D6 RID: 13014 RVA: 0x00080D90 File Offset: 0x0007EF90
		// (set) Token: 0x060032D7 RID: 13015 RVA: 0x00080D98 File Offset: 0x0007EF98
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

		// Token: 0x170007FE RID: 2046
		// (get) Token: 0x060032D8 RID: 13016 RVA: 0x00080DA1 File Offset: 0x0007EFA1
		// (set) Token: 0x060032D9 RID: 13017 RVA: 0x00080DA9 File Offset: 0x0007EFA9
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

		// Token: 0x170007FF RID: 2047
		// (get) Token: 0x060032DA RID: 13018 RVA: 0x00080DB2 File Offset: 0x0007EFB2
		// (set) Token: 0x060032DB RID: 13019 RVA: 0x00080DBA File Offset: 0x0007EFBA
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

		// Token: 0x060032DC RID: 13020 RVA: 0x00080DC3 File Offset: 0x0007EFC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BoardGridDynamicConfig);
		}

		// Token: 0x060032DD RID: 13021 RVA: 0x00080DD4 File Offset: 0x0007EFD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BoardGridDynamicConfig other)
		{
			return other != null && (other == this || (this.RowIndex == other.RowIndex && this.ColumnIndex == other.ColumnIndex && this.Flags == other.Flags && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060032DE RID: 13022 RVA: 0x00080E30 File Offset: 0x0007F030
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

		// Token: 0x060032DF RID: 13023 RVA: 0x00080EA1 File Offset: 0x0007F0A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060032E0 RID: 13024 RVA: 0x00080EAE File Offset: 0x0007F0AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060032E1 RID: 13025 RVA: 0x00080EB8 File Offset: 0x0007F0B8
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

		// Token: 0x060032E2 RID: 13026 RVA: 0x00080F2C File Offset: 0x0007F12C
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

		// Token: 0x060032E3 RID: 13027 RVA: 0x00080F9C File Offset: 0x0007F19C
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

		// Token: 0x060032E4 RID: 13028 RVA: 0x00081000 File Offset: 0x0007F200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060032E5 RID: 13029 RVA: 0x0008100C File Offset: 0x0007F20C
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

		// Token: 0x0400298E RID: 10638
		private static readonly MessageParser<BoardGridDynamicConfig> _parser = new MessageParser<BoardGridDynamicConfig>(() => new BoardGridDynamicConfig());

		// Token: 0x0400298F RID: 10639
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002990 RID: 10640
		public const int RowIndexFieldNumber = 1;

		// Token: 0x04002991 RID: 10641
		private int rowIndex_;

		// Token: 0x04002992 RID: 10642
		public const int ColumnIndexFieldNumber = 2;

		// Token: 0x04002993 RID: 10643
		private int columnIndex_;

		// Token: 0x04002994 RID: 10644
		public const int FlagsFieldNumber = 3;

		// Token: 0x04002995 RID: 10645
		private long flags_;
	}
}
