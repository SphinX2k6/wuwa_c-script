using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000480 RID: 1152
	[NetMessage(EMessageId.EntityInteractingNotify)]
	public sealed class EntityInteractingNotify : IMessage<EntityInteractingNotify>, IMessage, IEquatable<EntityInteractingNotify>, IDeepCloneable<EntityInteractingNotify>, IBufferMessage
	{
		// Token: 0x06006EB0 RID: 28336 RVA: 0x0011080B File Offset: 0x0010EA0B
		[NullableContext(1)]
		public static EntityInteractingNotify Create()
		{
			return new EntityInteractingNotify();
		}

		// Token: 0x1700154B RID: 5451
		// (get) Token: 0x06006EB1 RID: 28337 RVA: 0x00110812 File Offset: 0x0010EA12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700154C RID: 5452
		// (get) Token: 0x06006EB2 RID: 28338 RVA: 0x00110815 File Offset: 0x0010EA15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityInteractingNotify.Descriptor;
			}
		}

		// Token: 0x06006EB3 RID: 28339 RVA: 0x0011081C File Offset: 0x0010EA1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityInteractingNotify()
		{
		}

		// Token: 0x06006EB4 RID: 28340 RVA: 0x00110824 File Offset: 0x0010EA24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityInteractingNotify(EntityInteractingNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.isInteracting_ = other.isInteracting_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006EB5 RID: 28341 RVA: 0x00110855 File Offset: 0x0010EA55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityInteractingNotify Clone()
		{
			return new EntityInteractingNotify(this);
		}

		// Token: 0x1700154D RID: 5453
		// (get) Token: 0x06006EB6 RID: 28342 RVA: 0x0011085D File Offset: 0x0010EA5D
		// (set) Token: 0x06006EB7 RID: 28343 RVA: 0x00110865 File Offset: 0x0010EA65
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

		// Token: 0x1700154E RID: 5454
		// (get) Token: 0x06006EB8 RID: 28344 RVA: 0x0011086E File Offset: 0x0010EA6E
		// (set) Token: 0x06006EB9 RID: 28345 RVA: 0x00110876 File Offset: 0x0010EA76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsInteracting
		{
			get
			{
				return this.isInteracting_;
			}
			set
			{
				this.isInteracting_ = value;
			}
		}

		// Token: 0x06006EBA RID: 28346 RVA: 0x0011087F File Offset: 0x0010EA7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityInteractingNotify);
		}

		// Token: 0x06006EBB RID: 28347 RVA: 0x0011088D File Offset: 0x0010EA8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityInteractingNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.IsInteracting == other.IsInteracting && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006EBC RID: 28348 RVA: 0x001108CC File Offset: 0x0010EACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.IsInteracting)
			{
				num ^= this.IsInteracting.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006EBD RID: 28349 RVA: 0x00110924 File Offset: 0x0010EB24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006EBE RID: 28350 RVA: 0x00110931 File Offset: 0x0010EB31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006EBF RID: 28351 RVA: 0x0011093C File Offset: 0x0010EB3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsInteracting)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsInteracting);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(104);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006EC0 RID: 28352 RVA: 0x00110998 File Offset: 0x0010EB98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.IsInteracting)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006EC1 RID: 28353 RVA: 0x001109E4 File Offset: 0x0010EBE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityInteractingNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.IsInteracting)
			{
				this.IsInteracting = other.IsInteracting;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006EC2 RID: 28354 RVA: 0x00110A34 File Offset: 0x0010EC34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006EC3 RID: 28355 RVA: 0x00110A40 File Offset: 0x0010EC40
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
				if (num != 16U)
				{
					if (num != 104U)
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
					this.IsInteracting = input.ReadBool();
				}
			}
		}

		// Token: 0x04003C19 RID: 15385
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C1A RID: 15386
		public const int EntityIdFieldNumber = 13;

		// Token: 0x04003C1B RID: 15387
		private long entityId_;

		// Token: 0x04003C1C RID: 15388
		public const int IsInteractingFieldNumber = 2;

		// Token: 0x04003C1D RID: 15389
		private bool isInteracting_;
	}
}
