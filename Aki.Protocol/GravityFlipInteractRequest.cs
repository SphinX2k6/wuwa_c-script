using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006FB RID: 1787
	[NetMessage(EMessageId.GravityFlipInteractRequest)]
	public sealed class GravityFlipInteractRequest : IMessage<GravityFlipInteractRequest>, IMessage, IEquatable<GravityFlipInteractRequest>, IDeepCloneable<GravityFlipInteractRequest>, IBufferMessage
	{
		// Token: 0x0600A306 RID: 41734 RVA: 0x0018A2A4 File Offset: 0x001884A4
		[NullableContext(1)]
		public static GravityFlipInteractRequest Create()
		{
			return new GravityFlipInteractRequest();
		}

		// Token: 0x170020C2 RID: 8386
		// (get) Token: 0x0600A307 RID: 41735 RVA: 0x0018A2AB File Offset: 0x001884AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170020C3 RID: 8387
		// (get) Token: 0x0600A308 RID: 41736 RVA: 0x0018A2AE File Offset: 0x001884AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GravityFlipInteractRequest.Descriptor;
			}
		}

		// Token: 0x0600A309 RID: 41737 RVA: 0x0018A2B5 File Offset: 0x001884B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GravityFlipInteractRequest()
		{
		}

		// Token: 0x0600A30A RID: 41738 RVA: 0x0018A2BD File Offset: 0x001884BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GravityFlipInteractRequest(GravityFlipInteractRequest other) : this()
		{
			this.gravityFlipEntityId_ = other.gravityFlipEntityId_;
			this.targetGravityFlipType_ = other.targetGravityFlipType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A30B RID: 41739 RVA: 0x0018A2EE File Offset: 0x001884EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GravityFlipInteractRequest Clone()
		{
			return new GravityFlipInteractRequest(this);
		}

		// Token: 0x170020C4 RID: 8388
		// (get) Token: 0x0600A30C RID: 41740 RVA: 0x0018A2F6 File Offset: 0x001884F6
		// (set) Token: 0x0600A30D RID: 41741 RVA: 0x0018A2FE File Offset: 0x001884FE
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

		// Token: 0x170020C5 RID: 8389
		// (get) Token: 0x0600A30E RID: 41742 RVA: 0x0018A307 File Offset: 0x00188507
		// (set) Token: 0x0600A30F RID: 41743 RVA: 0x0018A30F File Offset: 0x0018850F
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

		// Token: 0x0600A310 RID: 41744 RVA: 0x0018A318 File Offset: 0x00188518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GravityFlipInteractRequest);
		}

		// Token: 0x0600A311 RID: 41745 RVA: 0x0018A326 File Offset: 0x00188526
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GravityFlipInteractRequest other)
		{
			return other != null && (other == this || (this.GravityFlipEntityId == other.GravityFlipEntityId && this.TargetGravityFlipType == other.TargetGravityFlipType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A312 RID: 41746 RVA: 0x0018A364 File Offset: 0x00188564
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

		// Token: 0x0600A313 RID: 41747 RVA: 0x0018A3C2 File Offset: 0x001885C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A314 RID: 41748 RVA: 0x0018A3CF File Offset: 0x001885CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A315 RID: 41749 RVA: 0x0018A3D8 File Offset: 0x001885D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GravityFlipEntityId != 0L)
			{
				output.WriteRawTag(72);
				output.WriteInt64(this.GravityFlipEntityId);
			}
			if (this.TargetGravityFlipType != GravityFlipType.GravityUp)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.TargetGravityFlipType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A316 RID: 41750 RVA: 0x0018A434 File Offset: 0x00188634
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

		// Token: 0x0600A317 RID: 41751 RVA: 0x0018A48C File Offset: 0x0018868C
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

		// Token: 0x0600A318 RID: 41752 RVA: 0x0018A4DC File Offset: 0x001886DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A319 RID: 41753 RVA: 0x0018A4E8 File Offset: 0x001886E8
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
				if (num != 72U)
				{
					if (num != 104U)
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

		// Token: 0x04004BC0 RID: 19392
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004BC1 RID: 19393
		public const int GravityFlipEntityIdFieldNumber = 9;

		// Token: 0x04004BC2 RID: 19394
		private long gravityFlipEntityId_;

		// Token: 0x04004BC3 RID: 19395
		public const int TargetGravityFlipTypeFieldNumber = 13;

		// Token: 0x04004BC4 RID: 19396
		private GravityFlipType targetGravityFlipType_;
	}
}
