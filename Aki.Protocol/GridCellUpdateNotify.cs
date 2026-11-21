using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000703 RID: 1795
	[NetMessage(EMessageId.GridCellUpdateNotify)]
	public sealed class GridCellUpdateNotify : IMessage<GridCellUpdateNotify>, IMessage, IEquatable<GridCellUpdateNotify>, IDeepCloneable<GridCellUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600A39E RID: 41886 RVA: 0x0018B48C File Offset: 0x0018968C
		[NullableContext(1)]
		public static GridCellUpdateNotify Create()
		{
			return new GridCellUpdateNotify();
		}

		// Token: 0x170020DE RID: 8414
		// (get) Token: 0x0600A39F RID: 41887 RVA: 0x0018B493 File Offset: 0x00189693
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170020DF RID: 8415
		// (get) Token: 0x0600A3A0 RID: 41888 RVA: 0x0018B496 File Offset: 0x00189696
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GridCellUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600A3A1 RID: 41889 RVA: 0x0018B49D File Offset: 0x0018969D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GridCellUpdateNotify()
		{
		}

		// Token: 0x0600A3A2 RID: 41890 RVA: 0x0018B4A8 File Offset: 0x001896A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GridCellUpdateNotify(GridCellUpdateNotify other) : this()
		{
			this.isAdd_ = other.isAdd_;
			this.levelGridData_ = ((other.levelGridData_ != null) ? other.levelGridData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A3A3 RID: 41891 RVA: 0x0018B4F4 File Offset: 0x001896F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GridCellUpdateNotify Clone()
		{
			return new GridCellUpdateNotify(this);
		}

		// Token: 0x170020E0 RID: 8416
		// (get) Token: 0x0600A3A4 RID: 41892 RVA: 0x0018B4FC File Offset: 0x001896FC
		// (set) Token: 0x0600A3A5 RID: 41893 RVA: 0x0018B504 File Offset: 0x00189704
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

		// Token: 0x170020E1 RID: 8417
		// (get) Token: 0x0600A3A6 RID: 41894 RVA: 0x0018B50D File Offset: 0x0018970D
		// (set) Token: 0x0600A3A7 RID: 41895 RVA: 0x0018B515 File Offset: 0x00189715
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

		// Token: 0x0600A3A8 RID: 41896 RVA: 0x0018B51E File Offset: 0x0018971E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GridCellUpdateNotify);
		}

		// Token: 0x0600A3A9 RID: 41897 RVA: 0x0018B52C File Offset: 0x0018972C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GridCellUpdateNotify other)
		{
			return other != null && (other == this || (this.IsAdd == other.IsAdd && object.Equals(this.LevelGridData, other.LevelGridData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A3AA RID: 41898 RVA: 0x0018B57C File Offset: 0x0018977C
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

		// Token: 0x0600A3AB RID: 41899 RVA: 0x0018B5D1 File Offset: 0x001897D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A3AC RID: 41900 RVA: 0x0018B5DE File Offset: 0x001897DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A3AD RID: 41901 RVA: 0x0018B5E8 File Offset: 0x001897E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.levelGridData_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.LevelGridData);
			}
			if (this.IsAdd)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.IsAdd);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A3AE RID: 41902 RVA: 0x0018B644 File Offset: 0x00189844
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

		// Token: 0x0600A3AF RID: 41903 RVA: 0x0018B690 File Offset: 0x00189890
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

		// Token: 0x0600A3B0 RID: 41904 RVA: 0x0018B6F8 File Offset: 0x001898F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A3B1 RID: 41905 RVA: 0x0018B704 File Offset: 0x00189904
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
				if (num != 50U)
				{
					if (num != 64U)
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

		// Token: 0x04004BE0 RID: 19424
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004BE1 RID: 19425
		public const int IsAddFieldNumber = 8;

		// Token: 0x04004BE2 RID: 19426
		private bool isAdd_;

		// Token: 0x04004BE3 RID: 19427
		public const int LevelGridDataFieldNumber = 6;

		// Token: 0x04004BE4 RID: 19428
		private LevelGridPbData levelGridData_;
	}
}
