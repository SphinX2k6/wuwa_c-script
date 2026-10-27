using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000497 RID: 1175
	[NetMessage(EMessageId.EntityInteractingNotify)]
	public sealed class EntityInteractingNotify : IMessage<EntityInteractingNotify>, IMessage, IEquatable<EntityInteractingNotify>, IDeepCloneable<EntityInteractingNotify>, IBufferMessage
	{
		// Token: 0x0600703E RID: 28734 RVA: 0x0011387F File Offset: 0x00111A7F
		[NullableContext(1)]
		public static EntityInteractingNotify Create()
		{
			return new EntityInteractingNotify();
		}

		// Token: 0x1700159F RID: 5535
		// (get) Token: 0x0600703F RID: 28735 RVA: 0x00113886 File Offset: 0x00111A86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170015A0 RID: 5536
		// (get) Token: 0x06007040 RID: 28736 RVA: 0x00113889 File Offset: 0x00111A89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityInteractingNotify.Descriptor;
			}
		}

		// Token: 0x06007041 RID: 28737 RVA: 0x00113890 File Offset: 0x00111A90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityInteractingNotify()
		{
		}

		// Token: 0x06007042 RID: 28738 RVA: 0x00113898 File Offset: 0x00111A98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityInteractingNotify(EntityInteractingNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.isInteracting_ = other.isInteracting_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007043 RID: 28739 RVA: 0x001138C9 File Offset: 0x00111AC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityInteractingNotify Clone()
		{
			return new EntityInteractingNotify(this);
		}

		// Token: 0x170015A1 RID: 5537
		// (get) Token: 0x06007044 RID: 28740 RVA: 0x001138D1 File Offset: 0x00111AD1
		// (set) Token: 0x06007045 RID: 28741 RVA: 0x001138D9 File Offset: 0x00111AD9
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

		// Token: 0x170015A2 RID: 5538
		// (get) Token: 0x06007046 RID: 28742 RVA: 0x001138E2 File Offset: 0x00111AE2
		// (set) Token: 0x06007047 RID: 28743 RVA: 0x001138EA File Offset: 0x00111AEA
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

		// Token: 0x06007048 RID: 28744 RVA: 0x001138F3 File Offset: 0x00111AF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityInteractingNotify);
		}

		// Token: 0x06007049 RID: 28745 RVA: 0x00113901 File Offset: 0x00111B01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityInteractingNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.IsInteracting == other.IsInteracting && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600704A RID: 28746 RVA: 0x00113940 File Offset: 0x00111B40
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

		// Token: 0x0600704B RID: 28747 RVA: 0x00113998 File Offset: 0x00111B98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600704C RID: 28748 RVA: 0x001139A5 File Offset: 0x00111BA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600704D RID: 28749 RVA: 0x001139B0 File Offset: 0x00111BB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsInteracting)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.IsInteracting);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(120);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600704E RID: 28750 RVA: 0x00113A0C File Offset: 0x00111C0C
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

		// Token: 0x0600704F RID: 28751 RVA: 0x00113A58 File Offset: 0x00111C58
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

		// Token: 0x06007050 RID: 28752 RVA: 0x00113AA8 File Offset: 0x00111CA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007051 RID: 28753 RVA: 0x00113AB4 File Offset: 0x00111CB4
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
					if (num != 120U)
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

		// Token: 0x04003C2B RID: 15403
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C2C RID: 15404
		public const int EntityIdFieldNumber = 15;

		// Token: 0x04003C2D RID: 15405
		private long entityId_;

		// Token: 0x04003C2E RID: 15406
		public const int IsInteractingFieldNumber = 9;

		// Token: 0x04003C2F RID: 15407
		private bool isInteracting_;
	}
}
