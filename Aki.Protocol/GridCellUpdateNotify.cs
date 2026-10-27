using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000717 RID: 1815
	[NetMessage(EMessageId.GridCellUpdateNotify)]
	public sealed class GridCellUpdateNotify : IMessage<GridCellUpdateNotify>, IMessage, IEquatable<GridCellUpdateNotify>, IDeepCloneable<GridCellUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600A4F4 RID: 42228 RVA: 0x0018DEC0 File Offset: 0x0018C0C0
		[NullableContext(1)]
		public static GridCellUpdateNotify Create()
		{
			return new GridCellUpdateNotify();
		}

		// Token: 0x17002128 RID: 8488
		// (get) Token: 0x0600A4F5 RID: 42229 RVA: 0x0018DEC7 File Offset: 0x0018C0C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002129 RID: 8489
		// (get) Token: 0x0600A4F6 RID: 42230 RVA: 0x0018DECA File Offset: 0x0018C0CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GridCellUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600A4F7 RID: 42231 RVA: 0x0018DED1 File Offset: 0x0018C0D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GridCellUpdateNotify()
		{
		}

		// Token: 0x0600A4F8 RID: 42232 RVA: 0x0018DEDC File Offset: 0x0018C0DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GridCellUpdateNotify(GridCellUpdateNotify other) : this()
		{
			this.isAdd_ = other.isAdd_;
			this.levelGridData_ = ((other.levelGridData_ != null) ? other.levelGridData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A4F9 RID: 42233 RVA: 0x0018DF28 File Offset: 0x0018C128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GridCellUpdateNotify Clone()
		{
			return new GridCellUpdateNotify(this);
		}

		// Token: 0x1700212A RID: 8490
		// (get) Token: 0x0600A4FA RID: 42234 RVA: 0x0018DF30 File Offset: 0x0018C130
		// (set) Token: 0x0600A4FB RID: 42235 RVA: 0x0018DF38 File Offset: 0x0018C138
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsAdd
		{
			get
			{
				return this.isAdd_;
			}
			set
			{
				this.isAdd_ = value;
			}
		}

		// Token: 0x1700212B RID: 8491
		// (get) Token: 0x0600A4FC RID: 42236 RVA: 0x0018DF41 File Offset: 0x0018C141
		// (set) Token: 0x0600A4FD RID: 42237 RVA: 0x0018DF49 File Offset: 0x0018C149
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelGridPbData LevelGridData
		{
			get
			{
				return this.levelGridData_;
			}
			set
			{
				this.levelGridData_ = value;
			}
		}

		// Token: 0x0600A4FE RID: 42238 RVA: 0x0018DF52 File Offset: 0x0018C152
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GridCellUpdateNotify);
		}

		// Token: 0x0600A4FF RID: 42239 RVA: 0x0018DF60 File Offset: 0x0018C160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GridCellUpdateNotify other)
		{
			return other != null && (other == this || (this.IsAdd == other.IsAdd && object.Equals(this.LevelGridData, other.LevelGridData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A500 RID: 42240 RVA: 0x0018DFB0 File Offset: 0x0018C1B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsAdd)
			{
				num ^= this.IsAdd.GetHashCode();
			}
			if (this.levelGridData_ != null)
			{
				num ^= this.LevelGridData.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A501 RID: 42241 RVA: 0x0018E005 File Offset: 0x0018C205
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A502 RID: 42242 RVA: 0x0018E012 File Offset: 0x0018C212
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A503 RID: 42243 RVA: 0x0018E01C File Offset: 0x0018C21C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.levelGridData_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.LevelGridData);
			}
			if (this.IsAdd)
			{
				output.WriteRawTag(112);
				output.WriteBool(this.IsAdd);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A504 RID: 42244 RVA: 0x0018E078 File Offset: 0x0018C278
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsAdd)
			{
				num += 2;
			}
			if (this.levelGridData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.LevelGridData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A505 RID: 42245 RVA: 0x0018E0C4 File Offset: 0x0018C2C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GridCellUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsAdd)
			{
				this.IsAdd = other.IsAdd;
			}
			if (other.levelGridData_ != null)
			{
				if (this.levelGridData_ == null)
				{
					this.LevelGridData = new LevelGridPbData();
				}
				this.LevelGridData.MergeFrom(other.LevelGridData);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A506 RID: 42246 RVA: 0x0018E12C File Offset: 0x0018C32C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A507 RID: 42247 RVA: 0x0018E138 File Offset: 0x0018C338
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
				if (num != 26U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.IsAdd = input.ReadBool();
					}
				}
				else
				{
					if (this.levelGridData_ == null)
					{
						this.LevelGridData = new LevelGridPbData();
					}
					input.ReadMessage(this.LevelGridData);
				}
			}
		}

		// Token: 0x04004BE7 RID: 19431
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004BE8 RID: 19432
		public const int IsAddFieldNumber = 14;

		// Token: 0x04004BE9 RID: 19433
		private bool isAdd_;

		// Token: 0x04004BEA RID: 19434
		public const int LevelGridDataFieldNumber = 3;

		// Token: 0x04004BEB RID: 19435
		private LevelGridPbData levelGridData_;
	}
}
