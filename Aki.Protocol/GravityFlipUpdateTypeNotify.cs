using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006FD RID: 1789
	[NetMessage(EMessageId.GravityFlipUpdateTypeNotify)]
	public sealed class GravityFlipUpdateTypeNotify : IMessage<GravityFlipUpdateTypeNotify>, IMessage, IEquatable<GravityFlipUpdateTypeNotify>, IDeepCloneable<GravityFlipUpdateTypeNotify>, IBufferMessage
	{
		// Token: 0x0600A32E RID: 41774 RVA: 0x0018A7E4 File Offset: 0x001889E4
		[NullableContext(1)]
		public static GravityFlipUpdateTypeNotify Create()
		{
			return new GravityFlipUpdateTypeNotify();
		}

		// Token: 0x170020CA RID: 8394
		// (get) Token: 0x0600A32F RID: 41775 RVA: 0x0018A7EB File Offset: 0x001889EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170020CB RID: 8395
		// (get) Token: 0x0600A330 RID: 41776 RVA: 0x0018A7EE File Offset: 0x001889EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GravityFlipUpdateTypeNotify.Descriptor;
			}
		}

		// Token: 0x0600A331 RID: 41777 RVA: 0x0018A7F5 File Offset: 0x001889F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GravityFlipUpdateTypeNotify()
		{
		}

		// Token: 0x0600A332 RID: 41778 RVA: 0x0018A7FD File Offset: 0x001889FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GravityFlipUpdateTypeNotify(GravityFlipUpdateTypeNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.newGravityFlipType_ = other.newGravityFlipType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A333 RID: 41779 RVA: 0x0018A82E File Offset: 0x00188A2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GravityFlipUpdateTypeNotify Clone()
		{
			return new GravityFlipUpdateTypeNotify(this);
		}

		// Token: 0x170020CC RID: 8396
		// (get) Token: 0x0600A334 RID: 41780 RVA: 0x0018A836 File Offset: 0x00188A36
		// (set) Token: 0x0600A335 RID: 41781 RVA: 0x0018A83E File Offset: 0x00188A3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x170020CD RID: 8397
		// (get) Token: 0x0600A336 RID: 41782 RVA: 0x0018A847 File Offset: 0x00188A47
		// (set) Token: 0x0600A337 RID: 41783 RVA: 0x0018A84F File Offset: 0x00188A4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GravityFlipType NewGravityFlipType
		{
			get
			{
				return this.newGravityFlipType_;
			}
			set
			{
				this.newGravityFlipType_ = value;
			}
		}

		// Token: 0x0600A338 RID: 41784 RVA: 0x0018A858 File Offset: 0x00188A58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GravityFlipUpdateTypeNotify);
		}

		// Token: 0x0600A339 RID: 41785 RVA: 0x0018A866 File Offset: 0x00188A66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GravityFlipUpdateTypeNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.NewGravityFlipType == other.NewGravityFlipType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A33A RID: 41786 RVA: 0x0018A8A4 File Offset: 0x00188AA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.NewGravityFlipType != GravityFlipType.GravityUp)
			{
				num ^= this.NewGravityFlipType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A33B RID: 41787 RVA: 0x0018A902 File Offset: 0x00188B02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A33C RID: 41788 RVA: 0x0018A90F File Offset: 0x00188B0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A33D RID: 41789 RVA: 0x0018A918 File Offset: 0x00188B18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NewGravityFlipType != GravityFlipType.GravityUp)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.NewGravityFlipType);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A33E RID: 41790 RVA: 0x0018A974 File Offset: 0x00188B74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.NewGravityFlipType != GravityFlipType.GravityUp)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.NewGravityFlipType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A33F RID: 41791 RVA: 0x0018A9CC File Offset: 0x00188BCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GravityFlipUpdateTypeNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.NewGravityFlipType != GravityFlipType.GravityUp)
			{
				this.NewGravityFlipType = other.NewGravityFlipType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A340 RID: 41792 RVA: 0x0018AA1C File Offset: 0x00188C1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A341 RID: 41793 RVA: 0x0018AA28 File Offset: 0x00188C28
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
				if (num != 32U)
				{
					if (num != 40U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.EntityId = input.ReadInt64();
					}
				}
				else
				{
					this.NewGravityFlipType = (GravityFlipType)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004BCA RID: 19402
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004BCB RID: 19403
		public const int EntityIdFieldNumber = 5;

		// Token: 0x04004BCC RID: 19404
		private long entityId_;

		// Token: 0x04004BCD RID: 19405
		public const int NewGravityFlipTypeFieldNumber = 4;

		// Token: 0x04004BCE RID: 19406
		private GravityFlipType newGravityFlipType_;
	}
}
