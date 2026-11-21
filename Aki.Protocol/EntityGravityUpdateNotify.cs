using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200047A RID: 1146
	[NetMessage(EMessageId.EntityGravityUpdateNotify)]
	public sealed class EntityGravityUpdateNotify : IMessage<EntityGravityUpdateNotify>, IMessage, IEquatable<EntityGravityUpdateNotify>, IDeepCloneable<EntityGravityUpdateNotify>, IBufferMessage
	{
		// Token: 0x06006E34 RID: 28212 RVA: 0x0010F553 File Offset: 0x0010D753
		[NullableContext(1)]
		public static EntityGravityUpdateNotify Create()
		{
			return new EntityGravityUpdateNotify();
		}

		// Token: 0x17001531 RID: 5425
		// (get) Token: 0x06006E35 RID: 28213 RVA: 0x0010F55A File Offset: 0x0010D75A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001532 RID: 5426
		// (get) Token: 0x06006E36 RID: 28214 RVA: 0x0010F55D File Offset: 0x0010D75D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityGravityUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06006E37 RID: 28215 RVA: 0x0010F564 File Offset: 0x0010D764
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityGravityUpdateNotify()
		{
		}

		// Token: 0x06006E38 RID: 28216 RVA: 0x0010F56C File Offset: 0x0010D76C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityGravityUpdateNotify(EntityGravityUpdateNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.preGravityDirection_ = ((other.preGravityDirection_ != null) ? other.preGravityDirection_.Clone() : null);
			this.curGravityDirection_ = ((other.curGravityDirection_ != null) ? other.curGravityDirection_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006E39 RID: 28217 RVA: 0x0010F5D4 File Offset: 0x0010D7D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityGravityUpdateNotify Clone()
		{
			return new EntityGravityUpdateNotify(this);
		}

		// Token: 0x17001533 RID: 5427
		// (get) Token: 0x06006E3A RID: 28218 RVA: 0x0010F5DC File Offset: 0x0010D7DC
		// (set) Token: 0x06006E3B RID: 28219 RVA: 0x0010F5E4 File Offset: 0x0010D7E4
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

		// Token: 0x17001534 RID: 5428
		// (get) Token: 0x06006E3C RID: 28220 RVA: 0x0010F5ED File Offset: 0x0010D7ED
		// (set) Token: 0x06006E3D RID: 28221 RVA: 0x0010F5F5 File Offset: 0x0010D7F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector PreGravityDirection
		{
			get
			{
				return this.preGravityDirection_;
			}
			set
			{
				this.preGravityDirection_ = value;
			}
		}

		// Token: 0x17001535 RID: 5429
		// (get) Token: 0x06006E3E RID: 28222 RVA: 0x0010F5FE File Offset: 0x0010D7FE
		// (set) Token: 0x06006E3F RID: 28223 RVA: 0x0010F606 File Offset: 0x0010D806
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector CurGravityDirection
		{
			get
			{
				return this.curGravityDirection_;
			}
			set
			{
				this.curGravityDirection_ = value;
			}
		}

		// Token: 0x06006E40 RID: 28224 RVA: 0x0010F60F File Offset: 0x0010D80F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityGravityUpdateNotify);
		}

		// Token: 0x06006E41 RID: 28225 RVA: 0x0010F620 File Offset: 0x0010D820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityGravityUpdateNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this.PreGravityDirection, other.PreGravityDirection) && object.Equals(this.CurGravityDirection, other.CurGravityDirection) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006E42 RID: 28226 RVA: 0x0010F684 File Offset: 0x0010D884
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.preGravityDirection_ != null)
			{
				num ^= this.PreGravityDirection.GetHashCode();
			}
			if (this.curGravityDirection_ != null)
			{
				num ^= this.CurGravityDirection.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006E43 RID: 28227 RVA: 0x0010F6EF File Offset: 0x0010D8EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006E44 RID: 28228 RVA: 0x0010F6FC File Offset: 0x0010D8FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006E45 RID: 28229 RVA: 0x0010F708 File Offset: 0x0010D908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.preGravityDirection_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.PreGravityDirection);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.EntityId);
			}
			if (this.curGravityDirection_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.CurGravityDirection);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006E46 RID: 28230 RVA: 0x0010F780 File Offset: 0x0010D980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.preGravityDirection_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PreGravityDirection);
			}
			if (this.curGravityDirection_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CurGravityDirection);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006E47 RID: 28231 RVA: 0x0010F7F0 File Offset: 0x0010D9F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityGravityUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.preGravityDirection_ != null)
			{
				if (this.preGravityDirection_ == null)
				{
					this.PreGravityDirection = new Vector();
				}
				this.PreGravityDirection.MergeFrom(other.PreGravityDirection);
			}
			if (other.curGravityDirection_ != null)
			{
				if (this.curGravityDirection_ == null)
				{
					this.CurGravityDirection = new Vector();
				}
				this.CurGravityDirection.MergeFrom(other.CurGravityDirection);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006E48 RID: 28232 RVA: 0x0010F884 File Offset: 0x0010DA84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006E49 RID: 28233 RVA: 0x0010F890 File Offset: 0x0010DA90
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
				if (num != 34U)
				{
					if (num != 56U)
					{
						if (num != 122U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.curGravityDirection_ == null)
							{
								this.CurGravityDirection = new Vector();
							}
							input.ReadMessage(this.CurGravityDirection);
						}
					}
					else
					{
						this.EntityId = input.ReadInt64();
					}
				}
				else
				{
					if (this.preGravityDirection_ == null)
					{
						this.PreGravityDirection = new Vector();
					}
					input.ReadMessage(this.PreGravityDirection);
				}
			}
		}

		// Token: 0x04003BF7 RID: 15351
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003BF8 RID: 15352
		public const int EntityIdFieldNumber = 7;

		// Token: 0x04003BF9 RID: 15353
		private long entityId_;

		// Token: 0x04003BFA RID: 15354
		public const int PreGravityDirectionFieldNumber = 4;

		// Token: 0x04003BFB RID: 15355
		private Vector preGravityDirection_;

		// Token: 0x04003BFC RID: 15356
		public const int CurGravityDirectionFieldNumber = 15;

		// Token: 0x04003BFD RID: 15357
		private Vector curGravityDirection_;
	}
}
