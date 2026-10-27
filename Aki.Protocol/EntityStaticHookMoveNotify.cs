using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004C5 RID: 1221
	[NetMessage(EMessageId.EntityStaticHookMoveNotify)]
	public sealed class EntityStaticHookMoveNotify : IMessage<EntityStaticHookMoveNotify>, IMessage, IEquatable<EntityStaticHookMoveNotify>, IDeepCloneable<EntityStaticHookMoveNotify>, IBufferMessage
	{
		// Token: 0x06007412 RID: 29714 RVA: 0x0011C566 File Offset: 0x0011A766
		[NullableContext(1)]
		public static EntityStaticHookMoveNotify Create()
		{
			return new EntityStaticHookMoveNotify();
		}

		// Token: 0x17001676 RID: 5750
		// (get) Token: 0x06007413 RID: 29715 RVA: 0x0011C56D File Offset: 0x0011A76D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001677 RID: 5751
		// (get) Token: 0x06007414 RID: 29716 RVA: 0x0011C570 File Offset: 0x0011A770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityStaticHookMoveNotify.Descriptor;
			}
		}

		// Token: 0x06007415 RID: 29717 RVA: 0x0011C577 File Offset: 0x0011A777
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityStaticHookMoveNotify()
		{
		}

		// Token: 0x06007416 RID: 29718 RVA: 0x0011C580 File Offset: 0x0011A780
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityStaticHookMoveNotify(EntityStaticHookMoveNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.hookMoveType_ = other.hookMoveType_;
			EntityStaticHookMoveNotify.TargetOneofCase targetCase = other.TargetCase;
			if (targetCase != EntityStaticHookMoveNotify.TargetOneofCase.TargetEntityId)
			{
				if (targetCase == EntityStaticHookMoveNotify.TargetOneofCase.TargetPos)
				{
					this.TargetPos = other.TargetPos.Clone();
				}
			}
			else
			{
				this.TargetEntityId = other.TargetEntityId;
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007417 RID: 29719 RVA: 0x0011C5ED File Offset: 0x0011A7ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityStaticHookMoveNotify Clone()
		{
			return new EntityStaticHookMoveNotify(this);
		}

		// Token: 0x17001678 RID: 5752
		// (get) Token: 0x06007418 RID: 29720 RVA: 0x0011C5F5 File Offset: 0x0011A7F5
		// (set) Token: 0x06007419 RID: 29721 RVA: 0x0011C5FD File Offset: 0x0011A7FD
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

		// Token: 0x17001679 RID: 5753
		// (get) Token: 0x0600741A RID: 29722 RVA: 0x0011C606 File Offset: 0x0011A806
		// (set) Token: 0x0600741B RID: 29723 RVA: 0x0011C60E File Offset: 0x0011A80E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StaticHookMoveType HookMoveType
		{
			get
			{
				return this.hookMoveType_;
			}
			set
			{
				this.hookMoveType_ = value;
			}
		}

		// Token: 0x1700167A RID: 5754
		// (get) Token: 0x0600741C RID: 29724 RVA: 0x0011C617 File Offset: 0x0011A817
		// (set) Token: 0x0600741D RID: 29725 RVA: 0x0011C62F File Offset: 0x0011A82F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long TargetEntityId
		{
			get
			{
				if (!this.HasTargetEntityId)
				{
					return 0L;
				}
				return (long)this.target_;
			}
			set
			{
				this.target_ = value;
				this.targetCase_ = EntityStaticHookMoveNotify.TargetOneofCase.TargetEntityId;
			}
		}

		// Token: 0x1700167B RID: 5755
		// (get) Token: 0x0600741E RID: 29726 RVA: 0x0011C644 File Offset: 0x0011A844
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasTargetEntityId
		{
			get
			{
				return this.targetCase_ == EntityStaticHookMoveNotify.TargetOneofCase.TargetEntityId;
			}
		}

		// Token: 0x0600741F RID: 29727 RVA: 0x0011C64F File Offset: 0x0011A84F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearTargetEntityId()
		{
			if (this.HasTargetEntityId)
			{
				this.ClearTarget();
			}
		}

		// Token: 0x1700167C RID: 5756
		// (get) Token: 0x06007420 RID: 29728 RVA: 0x0011C65F File Offset: 0x0011A85F
		// (set) Token: 0x06007421 RID: 29729 RVA: 0x0011C678 File Offset: 0x0011A878
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector TargetPos
		{
			get
			{
				if (this.targetCase_ != EntityStaticHookMoveNotify.TargetOneofCase.TargetPos)
				{
					return null;
				}
				return (Vector)this.target_;
			}
			set
			{
				this.target_ = value;
				this.targetCase_ = ((value == null) ? EntityStaticHookMoveNotify.TargetOneofCase.None : EntityStaticHookMoveNotify.TargetOneofCase.TargetPos);
			}
		}

		// Token: 0x1700167D RID: 5757
		// (get) Token: 0x06007422 RID: 29730 RVA: 0x0011C68F File Offset: 0x0011A88F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityStaticHookMoveNotify.TargetOneofCase TargetCase
		{
			get
			{
				return this.targetCase_;
			}
		}

		// Token: 0x06007423 RID: 29731 RVA: 0x0011C697 File Offset: 0x0011A897
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearTarget()
		{
			this.targetCase_ = EntityStaticHookMoveNotify.TargetOneofCase.None;
			this.target_ = null;
		}

		// Token: 0x06007424 RID: 29732 RVA: 0x0011C6A7 File Offset: 0x0011A8A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityStaticHookMoveNotify);
		}

		// Token: 0x06007425 RID: 29733 RVA: 0x0011C6B8 File Offset: 0x0011A8B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityStaticHookMoveNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.HookMoveType == other.HookMoveType && this.TargetEntityId == other.TargetEntityId && object.Equals(this.TargetPos, other.TargetPos) && this.TargetCase == other.TargetCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007426 RID: 29734 RVA: 0x0011C738 File Offset: 0x0011A938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.HookMoveType != StaticHookMoveType.Hook)
			{
				num ^= this.HookMoveType.GetHashCode();
			}
			if (this.HasTargetEntityId)
			{
				num ^= this.TargetEntityId.GetHashCode();
			}
			if (this.targetCase_ == EntityStaticHookMoveNotify.TargetOneofCase.TargetPos)
			{
				num ^= this.TargetPos.GetHashCode();
			}
			num ^= (int)this.targetCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007427 RID: 29735 RVA: 0x0011C7D0 File Offset: 0x0011A9D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007428 RID: 29736 RVA: 0x0011C7DD File Offset: 0x0011A9DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007429 RID: 29737 RVA: 0x0011C7E8 File Offset: 0x0011A9E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HasTargetEntityId)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.TargetEntityId);
			}
			if (this.targetCase_ == EntityStaticHookMoveNotify.TargetOneofCase.TargetPos)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.TargetPos);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(88);
				output.WriteInt64(this.EntityId);
			}
			if (this.HookMoveType != StaticHookMoveType.Hook)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.HookMoveType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600742A RID: 29738 RVA: 0x0011C87C File Offset: 0x0011AA7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.HookMoveType != StaticHookMoveType.Hook)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.HookMoveType);
			}
			if (this.HasTargetEntityId)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.TargetEntityId);
			}
			if (this.targetCase_ == EntityStaticHookMoveNotify.TargetOneofCase.TargetPos)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TargetPos);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600742B RID: 29739 RVA: 0x0011C904 File Offset: 0x0011AB04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityStaticHookMoveNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.HookMoveType != StaticHookMoveType.Hook)
			{
				this.HookMoveType = other.HookMoveType;
			}
			EntityStaticHookMoveNotify.TargetOneofCase targetCase = other.TargetCase;
			if (targetCase != EntityStaticHookMoveNotify.TargetOneofCase.TargetEntityId)
			{
				if (targetCase == EntityStaticHookMoveNotify.TargetOneofCase.TargetPos)
				{
					if (this.TargetPos == null)
					{
						this.TargetPos = new Vector();
					}
					this.TargetPos.MergeFrom(other.TargetPos);
				}
			}
			else
			{
				this.TargetEntityId = other.TargetEntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600742C RID: 29740 RVA: 0x0011C998 File Offset: 0x0011AB98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600742D RID: 29741 RVA: 0x0011C9A4 File Offset: 0x0011ABA4
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
				if (num <= 74U)
				{
					if (num == 8U)
					{
						this.TargetEntityId = input.ReadInt64();
						continue;
					}
					if (num == 74U)
					{
						Vector vector = new Vector();
						if (this.targetCase_ == EntityStaticHookMoveNotify.TargetOneofCase.TargetPos)
						{
							vector.MergeFrom(this.TargetPos);
						}
						input.ReadMessage(vector);
						this.TargetPos = vector;
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.EntityId = input.ReadInt64();
						continue;
					}
					if (num == 96U)
					{
						this.HookMoveType = (StaticHookMoveType)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003D50 RID: 15696
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D51 RID: 15697
		public const int EntityIdFieldNumber = 11;

		// Token: 0x04003D52 RID: 15698
		private long entityId_;

		// Token: 0x04003D53 RID: 15699
		public const int HookMoveTypeFieldNumber = 12;

		// Token: 0x04003D54 RID: 15700
		private StaticHookMoveType hookMoveType_;

		// Token: 0x04003D55 RID: 15701
		public const int TargetEntityIdFieldNumber = 1;

		// Token: 0x04003D56 RID: 15702
		public const int TargetPosFieldNumber = 9;

		// Token: 0x04003D57 RID: 15703
		private object target_;

		// Token: 0x04003D58 RID: 15704
		private EntityStaticHookMoveNotify.TargetOneofCase targetCase_;

		// Token: 0x02001778 RID: 6008
		public enum TargetOneofCase
		{
			// Token: 0x0400C68A RID: 50826
			None,
			// Token: 0x0400C68B RID: 50827
			TargetEntityId,
			// Token: 0x0400C68C RID: 50828
			TargetPos = 9
		}
	}
}
