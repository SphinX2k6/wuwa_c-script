using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001B8 RID: 440
	public sealed class BoardGridPositionInfo : IMessage<BoardGridPositionInfo>, IMessage, IEquatable<BoardGridPositionInfo>, IDeepCloneable<BoardGridPositionInfo>, IBufferMessage
	{
		// Token: 0x060032FB RID: 13051 RVA: 0x0008133C File Offset: 0x0007F53C
		[NullableContext(1)]
		public static BoardGridPositionInfo Create()
		{
			return new BoardGridPositionInfo();
		}

		// Token: 0x17000804 RID: 2052
		// (get) Token: 0x060032FC RID: 13052 RVA: 0x00081343 File Offset: 0x0007F543
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000805 RID: 2053
		// (get) Token: 0x060032FD RID: 13053 RVA: 0x00081346 File Offset: 0x0007F546
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BoardGridPositionInfo.Descriptor;
			}
		}

		// Token: 0x060032FE RID: 13054 RVA: 0x0008134D File Offset: 0x0007F54D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BoardGridPositionInfo()
		{
		}

		// Token: 0x060032FF RID: 13055 RVA: 0x00081355 File Offset: 0x0007F555
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BoardGridPositionInfo(BoardGridPositionInfo other) : this()
		{
			this.row_ = other.row_;
			this.column_ = other.column_;
			this.rotAngle_ = other.rotAngle_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003300 RID: 13056 RVA: 0x00081392 File Offset: 0x0007F592
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BoardGridPositionInfo Clone()
		{
			return new BoardGridPositionInfo(this);
		}

		// Token: 0x17000806 RID: 2054
		// (get) Token: 0x06003301 RID: 13057 RVA: 0x0008139A File Offset: 0x0007F59A
		// (set) Token: 0x06003302 RID: 13058 RVA: 0x000813A2 File Offset: 0x0007F5A2
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

		// Token: 0x17000807 RID: 2055
		// (get) Token: 0x06003303 RID: 13059 RVA: 0x000813AB File Offset: 0x0007F5AB
		// (set) Token: 0x06003304 RID: 13060 RVA: 0x000813B3 File Offset: 0x0007F5B3
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

		// Token: 0x17000808 RID: 2056
		// (get) Token: 0x06003305 RID: 13061 RVA: 0x000813BC File Offset: 0x0007F5BC
		// (set) Token: 0x06003306 RID: 13062 RVA: 0x000813C4 File Offset: 0x0007F5C4
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

		// Token: 0x06003307 RID: 13063 RVA: 0x000813CD File Offset: 0x0007F5CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BoardGridPositionInfo);
		}

		// Token: 0x06003308 RID: 13064 RVA: 0x000813DC File Offset: 0x0007F5DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BoardGridPositionInfo other)
		{
			return other != null && (other == this || (this.Row == other.Row && this.Column == other.Column && this.RotAngle == other.RotAngle && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003309 RID: 13065 RVA: 0x00081438 File Offset: 0x0007F638
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

		// Token: 0x0600330A RID: 13066 RVA: 0x000814A9 File Offset: 0x0007F6A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600330B RID: 13067 RVA: 0x000814B6 File Offset: 0x0007F6B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600330C RID: 13068 RVA: 0x000814C0 File Offset: 0x0007F6C0
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

		// Token: 0x0600330D RID: 13069 RVA: 0x00081534 File Offset: 0x0007F734
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

		// Token: 0x0600330E RID: 13070 RVA: 0x000815A4 File Offset: 0x0007F7A4
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

		// Token: 0x0600330F RID: 13071 RVA: 0x00081608 File Offset: 0x0007F808
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003310 RID: 13072 RVA: 0x00081614 File Offset: 0x0007F814
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

		// Token: 0x0400299C RID: 10652
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400299D RID: 10653
		public const int RowFieldNumber = 1;

		// Token: 0x0400299E RID: 10654
		private int row_;

		// Token: 0x0400299F RID: 10655
		public const int ColumnFieldNumber = 2;

		// Token: 0x040029A0 RID: 10656
		private int column_;

		// Token: 0x040029A1 RID: 10657
		public const int RotAngleFieldNumber = 3;

		// Token: 0x040029A2 RID: 10658
		private int rotAngle_;
	}
}
