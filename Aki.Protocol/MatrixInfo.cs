using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009BF RID: 2495
	public sealed class MatrixInfo : IMessage<MatrixInfo>, IMessage, IEquatable<MatrixInfo>, IDeepCloneable<MatrixInfo>, IBufferMessage
	{
		// Token: 0x0600DB39 RID: 56121 RVA: 0x00203809 File Offset: 0x00201A09
		[NullableContext(1)]
		public static MatrixInfo Create()
		{
			return new MatrixInfo();
		}

		// Token: 0x17002C6C RID: 11372
		// (get) Token: 0x0600DB3A RID: 56122 RVA: 0x00203810 File Offset: 0x00201A10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002C6D RID: 11373
		// (get) Token: 0x0600DB3B RID: 56123 RVA: 0x00203813 File Offset: 0x00201A13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MatrixInfo.Descriptor;
			}
		}

		// Token: 0x0600DB3C RID: 56124 RVA: 0x0020381A File Offset: 0x00201A1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatrixInfo()
		{
		}

		// Token: 0x0600DB3D RID: 56125 RVA: 0x00203822 File Offset: 0x00201A22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatrixInfo(MatrixInfo other) : this()
		{
			this.x_ = other.x_;
			this.y_ = other.y_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DB3E RID: 56126 RVA: 0x00203853 File Offset: 0x00201A53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatrixInfo Clone()
		{
			return new MatrixInfo(this);
		}

		// Token: 0x17002C6E RID: 11374
		// (get) Token: 0x0600DB3F RID: 56127 RVA: 0x0020385B File Offset: 0x00201A5B
		// (set) Token: 0x0600DB40 RID: 56128 RVA: 0x00203863 File Offset: 0x00201A63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int X
		{
			get
			{
				return this.x_;
			}
			set
			{
				this.x_ = value;
			}
		}

		// Token: 0x17002C6F RID: 11375
		// (get) Token: 0x0600DB41 RID: 56129 RVA: 0x0020386C File Offset: 0x00201A6C
		// (set) Token: 0x0600DB42 RID: 56130 RVA: 0x00203874 File Offset: 0x00201A74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Y
		{
			get
			{
				return this.y_;
			}
			set
			{
				this.y_ = value;
			}
		}

		// Token: 0x0600DB43 RID: 56131 RVA: 0x0020387D File Offset: 0x00201A7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MatrixInfo);
		}

		// Token: 0x0600DB44 RID: 56132 RVA: 0x0020388B File Offset: 0x00201A8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MatrixInfo other)
		{
			return other != null && (other == this || (this.X == other.X && this.Y == other.Y && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DB45 RID: 56133 RVA: 0x002038CC File Offset: 0x00201ACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.X != 0)
			{
				num ^= this.X.GetHashCode();
			}
			if (this.Y != 0)
			{
				num ^= this.Y.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DB46 RID: 56134 RVA: 0x00203924 File Offset: 0x00201B24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DB47 RID: 56135 RVA: 0x00203931 File Offset: 0x00201B31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DB48 RID: 56136 RVA: 0x0020393C File Offset: 0x00201B3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.X != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.X);
			}
			if (this.Y != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Y);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DB49 RID: 56137 RVA: 0x00203994 File Offset: 0x00201B94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.X != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.X);
			}
			if (this.Y != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Y);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DB4A RID: 56138 RVA: 0x002039EC File Offset: 0x00201BEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MatrixInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.X != 0)
			{
				this.X = other.X;
			}
			if (other.Y != 0)
			{
				this.Y = other.Y;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DB4B RID: 56139 RVA: 0x00203A3C File Offset: 0x00201C3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DB4C RID: 56140 RVA: 0x00203A48 File Offset: 0x00201C48
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
						this.Y = input.ReadInt32();
					}
				}
				else
				{
					this.X = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005B56 RID: 23382
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005B57 RID: 23383
		public const int XFieldNumber = 1;

		// Token: 0x04005B58 RID: 23384
		private int x_;

		// Token: 0x04005B59 RID: 23385
		public const int YFieldNumber = 2;

		// Token: 0x04005B5A RID: 23386
		private int y_;
	}
}
