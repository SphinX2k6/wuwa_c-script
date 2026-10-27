using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200070E RID: 1806
	public sealed class GravityFlipComponentPb : IMessage<GravityFlipComponentPb>, IMessage, IEquatable<GravityFlipComponentPb>, IDeepCloneable<GravityFlipComponentPb>, IBufferMessage
	{
		// Token: 0x0600A44A RID: 42058 RVA: 0x0018CAFC File Offset: 0x0018ACFC
		[NullableContext(1)]
		public static GravityFlipComponentPb Create()
		{
			return new GravityFlipComponentPb();
		}

		// Token: 0x17002109 RID: 8457
		// (get) Token: 0x0600A44B RID: 42059 RVA: 0x0018CB03 File Offset: 0x0018AD03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700210A RID: 8458
		// (get) Token: 0x0600A44C RID: 42060 RVA: 0x0018CB06 File Offset: 0x0018AD06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GravityFlipComponentPb.Descriptor;
			}
		}

		// Token: 0x0600A44D RID: 42061 RVA: 0x0018CB0D File Offset: 0x0018AD0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GravityFlipComponentPb()
		{
		}

		// Token: 0x0600A44E RID: 42062 RVA: 0x0018CB15 File Offset: 0x0018AD15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GravityFlipComponentPb(GravityFlipComponentPb other) : this()
		{
			this.curGravityFlipType_ = other.curGravityFlipType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A44F RID: 42063 RVA: 0x0018CB3A File Offset: 0x0018AD3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GravityFlipComponentPb Clone()
		{
			return new GravityFlipComponentPb(this);
		}

		// Token: 0x1700210B RID: 8459
		// (get) Token: 0x0600A450 RID: 42064 RVA: 0x0018CB42 File Offset: 0x0018AD42
		// (set) Token: 0x0600A451 RID: 42065 RVA: 0x0018CB4A File Offset: 0x0018AD4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GravityFlipType CurGravityFlipType
		{
			get
			{
				return this.curGravityFlipType_;
			}
			set
			{
				this.curGravityFlipType_ = value;
			}
		}

		// Token: 0x0600A452 RID: 42066 RVA: 0x0018CB53 File Offset: 0x0018AD53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GravityFlipComponentPb);
		}

		// Token: 0x0600A453 RID: 42067 RVA: 0x0018CB61 File Offset: 0x0018AD61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GravityFlipComponentPb other)
		{
			return other != null && (other == this || (this.CurGravityFlipType == other.CurGravityFlipType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A454 RID: 42068 RVA: 0x0018CB90 File Offset: 0x0018AD90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CurGravityFlipType != GravityFlipType.GravityUp)
			{
				num ^= this.CurGravityFlipType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A455 RID: 42069 RVA: 0x0018CBD5 File Offset: 0x0018ADD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A456 RID: 42070 RVA: 0x0018CBE2 File Offset: 0x0018ADE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A457 RID: 42071 RVA: 0x0018CBEB File Offset: 0x0018ADEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CurGravityFlipType != GravityFlipType.GravityUp)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.CurGravityFlipType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A458 RID: 42072 RVA: 0x0018CC1C File Offset: 0x0018AE1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CurGravityFlipType != GravityFlipType.GravityUp)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.CurGravityFlipType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A459 RID: 42073 RVA: 0x0018CC5A File Offset: 0x0018AE5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GravityFlipComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CurGravityFlipType != GravityFlipType.GravityUp)
			{
				this.CurGravityFlipType = other.CurGravityFlipType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A45A RID: 42074 RVA: 0x0018CC8B File Offset: 0x0018AE8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A45B RID: 42075 RVA: 0x0018CC94 File Offset: 0x0018AE94
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.CurGravityFlipType = (GravityFlipType)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004BC4 RID: 19396
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004BC5 RID: 19397
		public const int CurGravityFlipTypeFieldNumber = 1;

		// Token: 0x04004BC6 RID: 19398
		private GravityFlipType curGravityFlipType_;
	}
}
