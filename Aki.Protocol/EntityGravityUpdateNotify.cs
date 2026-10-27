using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000491 RID: 1169
	[NetMessage(EMessageId.EntityGravityUpdateNotify)]
	public sealed class EntityGravityUpdateNotify : IMessage<EntityGravityUpdateNotify>, IMessage, IEquatable<EntityGravityUpdateNotify>, IDeepCloneable<EntityGravityUpdateNotify>, IBufferMessage
	{
		// Token: 0x06006FC2 RID: 28610 RVA: 0x001125C7 File Offset: 0x001107C7
		[NullableContext(1)]
		public static EntityGravityUpdateNotify Create()
		{
			return new EntityGravityUpdateNotify();
		}

		// Token: 0x17001585 RID: 5509
		// (get) Token: 0x06006FC3 RID: 28611 RVA: 0x001125CE File Offset: 0x001107CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001586 RID: 5510
		// (get) Token: 0x06006FC4 RID: 28612 RVA: 0x001125D1 File Offset: 0x001107D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityGravityUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06006FC5 RID: 28613 RVA: 0x001125D8 File Offset: 0x001107D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityGravityUpdateNotify()
		{
		}

		// Token: 0x06006FC6 RID: 28614 RVA: 0x001125E0 File Offset: 0x001107E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityGravityUpdateNotify(EntityGravityUpdateNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.preGravityDirection_ = ((other.preGravityDirection_ != null) ? other.preGravityDirection_.Clone() : null);
			this.curGravityDirection_ = ((other.curGravityDirection_ != null) ? other.curGravityDirection_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006FC7 RID: 28615 RVA: 0x00112648 File Offset: 0x00110848
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityGravityUpdateNotify Clone()
		{
			return new EntityGravityUpdateNotify(this);
		}

		// Token: 0x17001587 RID: 5511
		// (get) Token: 0x06006FC8 RID: 28616 RVA: 0x00112650 File Offset: 0x00110850
		// (set) Token: 0x06006FC9 RID: 28617 RVA: 0x00112658 File Offset: 0x00110858
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

		// Token: 0x17001588 RID: 5512
		// (get) Token: 0x06006FCA RID: 28618 RVA: 0x00112661 File Offset: 0x00110861
		// (set) Token: 0x06006FCB RID: 28619 RVA: 0x00112669 File Offset: 0x00110869
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

		// Token: 0x17001589 RID: 5513
		// (get) Token: 0x06006FCC RID: 28620 RVA: 0x00112672 File Offset: 0x00110872
		// (set) Token: 0x06006FCD RID: 28621 RVA: 0x0011267A File Offset: 0x0011087A
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

		// Token: 0x06006FCE RID: 28622 RVA: 0x00112683 File Offset: 0x00110883
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityGravityUpdateNotify);
		}

		// Token: 0x06006FCF RID: 28623 RVA: 0x00112694 File Offset: 0x00110894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityGravityUpdateNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this.PreGravityDirection, other.PreGravityDirection) && object.Equals(this.CurGravityDirection, other.CurGravityDirection) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006FD0 RID: 28624 RVA: 0x001126F8 File Offset: 0x001108F8
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

		// Token: 0x06006FD1 RID: 28625 RVA: 0x00112763 File Offset: 0x00110963
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006FD2 RID: 28626 RVA: 0x00112770 File Offset: 0x00110970
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006FD3 RID: 28627 RVA: 0x0011277C File Offset: 0x0011097C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.preGravityDirection_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.PreGravityDirection);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.EntityId);
			}
			if (this.curGravityDirection_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(this.CurGravityDirection);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006FD4 RID: 28628 RVA: 0x001127F4 File Offset: 0x001109F4
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

		// Token: 0x06006FD5 RID: 28629 RVA: 0x00112864 File Offset: 0x00110A64
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

		// Token: 0x06006FD6 RID: 28630 RVA: 0x001128F8 File Offset: 0x00110AF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006FD7 RID: 28631 RVA: 0x00112904 File Offset: 0x00110B04
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
						if (num != 106U)
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

		// Token: 0x04003C09 RID: 15369
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C0A RID: 15370
		public const int EntityIdFieldNumber = 8;

		// Token: 0x04003C0B RID: 15371
		private long entityId_;

		// Token: 0x04003C0C RID: 15372
		public const int PreGravityDirectionFieldNumber = 6;

		// Token: 0x04003C0D RID: 15373
		private Vector preGravityDirection_;

		// Token: 0x04003C0E RID: 15374
		public const int CurGravityDirectionFieldNumber = 13;

		// Token: 0x04003C0F RID: 15375
		private Vector curGravityDirection_;
	}
}
