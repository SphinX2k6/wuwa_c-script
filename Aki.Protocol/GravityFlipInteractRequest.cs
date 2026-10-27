using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200070F RID: 1807
	[NetMessage(EMessageId.GravityFlipInteractRequest)]
	public sealed class GravityFlipInteractRequest : IMessage<GravityFlipInteractRequest>, IMessage, IEquatable<GravityFlipInteractRequest>, IDeepCloneable<GravityFlipInteractRequest>, IBufferMessage
	{
		// Token: 0x0600A45C RID: 42076 RVA: 0x0018CCD8 File Offset: 0x0018AED8
		[NullableContext(1)]
		public static GravityFlipInteractRequest Create()
		{
			return new GravityFlipInteractRequest();
		}

		// Token: 0x1700210C RID: 8460
		// (get) Token: 0x0600A45D RID: 42077 RVA: 0x0018CCDF File Offset: 0x0018AEDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700210D RID: 8461
		// (get) Token: 0x0600A45E RID: 42078 RVA: 0x0018CCE2 File Offset: 0x0018AEE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GravityFlipInteractRequest.Descriptor;
			}
		}

		// Token: 0x0600A45F RID: 42079 RVA: 0x0018CCE9 File Offset: 0x0018AEE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GravityFlipInteractRequest()
		{
		}

		// Token: 0x0600A460 RID: 42080 RVA: 0x0018CCF1 File Offset: 0x0018AEF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GravityFlipInteractRequest(GravityFlipInteractRequest other) : this()
		{
			this.gravityFlipEntityId_ = other.gravityFlipEntityId_;
			this.targetGravityFlipType_ = other.targetGravityFlipType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A461 RID: 42081 RVA: 0x0018CD22 File Offset: 0x0018AF22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GravityFlipInteractRequest Clone()
		{
			return new GravityFlipInteractRequest(this);
		}

		// Token: 0x1700210E RID: 8462
		// (get) Token: 0x0600A462 RID: 42082 RVA: 0x0018CD2A File Offset: 0x0018AF2A
		// (set) Token: 0x0600A463 RID: 42083 RVA: 0x0018CD32 File Offset: 0x0018AF32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long GravityFlipEntityId
		{
			get
			{
				return this.gravityFlipEntityId_;
			}
			set
			{
				this.gravityFlipEntityId_ = value;
			}
		}

		// Token: 0x1700210F RID: 8463
		// (get) Token: 0x0600A464 RID: 42084 RVA: 0x0018CD3B File Offset: 0x0018AF3B
		// (set) Token: 0x0600A465 RID: 42085 RVA: 0x0018CD43 File Offset: 0x0018AF43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GravityFlipType TargetGravityFlipType
		{
			get
			{
				return this.targetGravityFlipType_;
			}
			set
			{
				this.targetGravityFlipType_ = value;
			}
		}

		// Token: 0x0600A466 RID: 42086 RVA: 0x0018CD4C File Offset: 0x0018AF4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GravityFlipInteractRequest);
		}

		// Token: 0x0600A467 RID: 42087 RVA: 0x0018CD5A File Offset: 0x0018AF5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GravityFlipInteractRequest other)
		{
			return other != null && (other == this || (this.GravityFlipEntityId == other.GravityFlipEntityId && this.TargetGravityFlipType == other.TargetGravityFlipType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A468 RID: 42088 RVA: 0x0018CD98 File Offset: 0x0018AF98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GravityFlipEntityId != 0L)
			{
				num ^= this.GravityFlipEntityId.GetHashCode();
			}
			if (this.TargetGravityFlipType != GravityFlipType.GravityUp)
			{
				num ^= this.TargetGravityFlipType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A469 RID: 42089 RVA: 0x0018CDF6 File Offset: 0x0018AFF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A46A RID: 42090 RVA: 0x0018CE03 File Offset: 0x0018B003
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A46B RID: 42091 RVA: 0x0018CE0C File Offset: 0x0018B00C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GravityFlipEntityId != 0L)
			{
				output.WriteRawTag(88);
				output.WriteInt64(this.GravityFlipEntityId);
			}
			if (this.TargetGravityFlipType != GravityFlipType.GravityUp)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.TargetGravityFlipType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A46C RID: 42092 RVA: 0x0018CE68 File Offset: 0x0018B068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GravityFlipEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.GravityFlipEntityId);
			}
			if (this.TargetGravityFlipType != GravityFlipType.GravityUp)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.TargetGravityFlipType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A46D RID: 42093 RVA: 0x0018CEC0 File Offset: 0x0018B0C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GravityFlipInteractRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GravityFlipEntityId != 0L)
			{
				this.GravityFlipEntityId = other.GravityFlipEntityId;
			}
			if (other.TargetGravityFlipType != GravityFlipType.GravityUp)
			{
				this.TargetGravityFlipType = other.TargetGravityFlipType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A46E RID: 42094 RVA: 0x0018CF10 File Offset: 0x0018B110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A46F RID: 42095 RVA: 0x0018CF1C File Offset: 0x0018B11C
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
				if (num != 88U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.TargetGravityFlipType = (GravityFlipType)input.ReadEnum();
					}
				}
				else
				{
					this.GravityFlipEntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04004BC7 RID: 19399
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004BC8 RID: 19400
		public const int GravityFlipEntityIdFieldNumber = 11;

		// Token: 0x04004BC9 RID: 19401
		private long gravityFlipEntityId_;

		// Token: 0x04004BCA RID: 19402
		public const int TargetGravityFlipTypeFieldNumber = 15;

		// Token: 0x04004BCB RID: 19403
		private GravityFlipType targetGravityFlipType_;
	}
}
