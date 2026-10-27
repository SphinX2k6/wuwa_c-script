using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009D0 RID: 2512
	public sealed class MatrixInfo : IMessage<MatrixInfo>, IMessage, IEquatable<MatrixInfo>, IDeepCloneable<MatrixInfo>, IBufferMessage
	{
		// Token: 0x0600DC53 RID: 56403 RVA: 0x002059FC File Offset: 0x00203BFC
		[NullableContext(1)]
		public static MatrixInfo Create()
		{
			return new MatrixInfo();
		}

		// Token: 0x17002CAA RID: 11434
		// (get) Token: 0x0600DC54 RID: 56404 RVA: 0x00205A03 File Offset: 0x00203C03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002CAB RID: 11435
		// (get) Token: 0x0600DC55 RID: 56405 RVA: 0x00205A06 File Offset: 0x00203C06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MatrixInfo.Descriptor;
			}
		}

		// Token: 0x0600DC56 RID: 56406 RVA: 0x00205A0D File Offset: 0x00203C0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatrixInfo()
		{
		}

		// Token: 0x0600DC57 RID: 56407 RVA: 0x00205A15 File Offset: 0x00203C15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatrixInfo(MatrixInfo other) : this()
		{
			this.x_ = other.x_;
			this.y_ = other.y_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DC58 RID: 56408 RVA: 0x00205A46 File Offset: 0x00203C46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatrixInfo Clone()
		{
			return new MatrixInfo(this);
		}

		// Token: 0x17002CAC RID: 11436
		// (get) Token: 0x0600DC59 RID: 56409 RVA: 0x00205A4E File Offset: 0x00203C4E
		// (set) Token: 0x0600DC5A RID: 56410 RVA: 0x00205A56 File Offset: 0x00203C56
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

		// Token: 0x17002CAD RID: 11437
		// (get) Token: 0x0600DC5B RID: 56411 RVA: 0x00205A5F File Offset: 0x00203C5F
		// (set) Token: 0x0600DC5C RID: 56412 RVA: 0x00205A67 File Offset: 0x00203C67
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

		// Token: 0x0600DC5D RID: 56413 RVA: 0x00205A70 File Offset: 0x00203C70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MatrixInfo);
		}

		// Token: 0x0600DC5E RID: 56414 RVA: 0x00205A7E File Offset: 0x00203C7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MatrixInfo other)
		{
			return other != null && (other == this || (this.X == other.X && this.Y == other.Y && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DC5F RID: 56415 RVA: 0x00205ABC File Offset: 0x00203CBC
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

		// Token: 0x0600DC60 RID: 56416 RVA: 0x00205B14 File Offset: 0x00203D14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DC61 RID: 56417 RVA: 0x00205B21 File Offset: 0x00203D21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DC62 RID: 56418 RVA: 0x00205B2C File Offset: 0x00203D2C
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

		// Token: 0x0600DC63 RID: 56419 RVA: 0x00205B84 File Offset: 0x00203D84
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

		// Token: 0x0600DC64 RID: 56420 RVA: 0x00205BDC File Offset: 0x00203DDC
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

		// Token: 0x0600DC65 RID: 56421 RVA: 0x00205C2C File Offset: 0x00203E2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DC66 RID: 56422 RVA: 0x00205C38 File Offset: 0x00203E38
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

		// Token: 0x04005B4D RID: 23373
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005B4E RID: 23374
		public const int XFieldNumber = 1;

		// Token: 0x04005B4F RID: 23375
		private int x_;

		// Token: 0x04005B50 RID: 23376
		public const int YFieldNumber = 2;

		// Token: 0x04005B51 RID: 23377
		private int y_;
	}
}
