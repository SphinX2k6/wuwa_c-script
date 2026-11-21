using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001BC RID: 444
	public sealed class BoardGridPositionInfo : IMessage<BoardGridPositionInfo>, IMessage, IEquatable<BoardGridPositionInfo>, IDeepCloneable<BoardGridPositionInfo>, IBufferMessage
	{
		// Token: 0x06003388 RID: 13192 RVA: 0x00082AAC File Offset: 0x00080CAC
		[NullableContext(1)]
		public static BoardGridPositionInfo Create()
		{
			return new BoardGridPositionInfo();
		}

		// Token: 0x1700081D RID: 2077
		// (get) Token: 0x06003389 RID: 13193 RVA: 0x00082AB3 File Offset: 0x00080CB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700081E RID: 2078
		// (get) Token: 0x0600338A RID: 13194 RVA: 0x00082AB6 File Offset: 0x00080CB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BoardGridPositionInfo.Descriptor;
			}
		}

		// Token: 0x0600338B RID: 13195 RVA: 0x00082ABD File Offset: 0x00080CBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BoardGridPositionInfo()
		{
		}

		// Token: 0x0600338C RID: 13196 RVA: 0x00082AC5 File Offset: 0x00080CC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BoardGridPositionInfo(BoardGridPositionInfo other) : this()
		{
			this.row_ = other.row_;
			this.column_ = other.column_;
			this.rotAngle_ = other.rotAngle_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600338D RID: 13197 RVA: 0x00082B02 File Offset: 0x00080D02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BoardGridPositionInfo Clone()
		{
			return new BoardGridPositionInfo(this);
		}

		// Token: 0x1700081F RID: 2079
		// (get) Token: 0x0600338E RID: 13198 RVA: 0x00082B0A File Offset: 0x00080D0A
		// (set) Token: 0x0600338F RID: 13199 RVA: 0x00082B12 File Offset: 0x00080D12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Row
		{
			get
			{
				return this.row_;
			}
			set
			{
				this.row_ = value;
			}
		}

		// Token: 0x17000820 RID: 2080
		// (get) Token: 0x06003390 RID: 13200 RVA: 0x00082B1B File Offset: 0x00080D1B
		// (set) Token: 0x06003391 RID: 13201 RVA: 0x00082B23 File Offset: 0x00080D23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Column
		{
			get
			{
				return this.column_;
			}
			set
			{
				this.column_ = value;
			}
		}

		// Token: 0x17000821 RID: 2081
		// (get) Token: 0x06003392 RID: 13202 RVA: 0x00082B2C File Offset: 0x00080D2C
		// (set) Token: 0x06003393 RID: 13203 RVA: 0x00082B34 File Offset: 0x00080D34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RotAngle
		{
			get
			{
				return this.rotAngle_;
			}
			set
			{
				this.rotAngle_ = value;
			}
		}

		// Token: 0x06003394 RID: 13204 RVA: 0x00082B3D File Offset: 0x00080D3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BoardGridPositionInfo);
		}

		// Token: 0x06003395 RID: 13205 RVA: 0x00082B4C File Offset: 0x00080D4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BoardGridPositionInfo other)
		{
			return other != null && (other == this || (this.Row == other.Row && this.Column == other.Column && this.RotAngle == other.RotAngle && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003396 RID: 13206 RVA: 0x00082BA8 File Offset: 0x00080DA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Row != 0)
			{
				num ^= this.Row.GetHashCode();
			}
			if (this.Column != 0)
			{
				num ^= this.Column.GetHashCode();
			}
			if (this.RotAngle != 0)
			{
				num ^= this.RotAngle.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003397 RID: 13207 RVA: 0x00082C19 File Offset: 0x00080E19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003398 RID: 13208 RVA: 0x00082C26 File Offset: 0x00080E26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003399 RID: 13209 RVA: 0x00082C30 File Offset: 0x00080E30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Row != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Row);
			}
			if (this.Column != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Column);
			}
			if (this.RotAngle != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.RotAngle);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600339A RID: 13210 RVA: 0x00082CA4 File Offset: 0x00080EA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Row != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Row);
			}
			if (this.Column != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Column);
			}
			if (this.RotAngle != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RotAngle);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600339B RID: 13211 RVA: 0x00082D14 File Offset: 0x00080F14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BoardGridPositionInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Row != 0)
			{
				this.Row = other.Row;
			}
			if (other.Column != 0)
			{
				this.Column = other.Column;
			}
			if (other.RotAngle != 0)
			{
				this.RotAngle = other.RotAngle;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600339C RID: 13212 RVA: 0x00082D78 File Offset: 0x00080F78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600339D RID: 13213 RVA: 0x00082D84 File Offset: 0x00080F84
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
							this.RotAngle = input.ReadInt32();
						}
					}
					else
					{
						this.Column = input.ReadInt32();
					}
				}
				else
				{
					this.Row = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002A17 RID: 10775
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002A18 RID: 10776
		public const int RowFieldNumber = 1;

		// Token: 0x04002A19 RID: 10777
		private int row_;

		// Token: 0x04002A1A RID: 10778
		public const int ColumnFieldNumber = 2;

		// Token: 0x04002A1B RID: 10779
		private int column_;

		// Token: 0x04002A1C RID: 10780
		public const int RotAngleFieldNumber = 3;

		// Token: 0x04002A1D RID: 10781
		private int rotAngle_;
	}
}
