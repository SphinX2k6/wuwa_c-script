using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004C6 RID: 1222
	[NetMessage(EMessageId.EntityStaticHookMovePush)]
	public sealed class EntityStaticHookMovePush : IMessage<EntityStaticHookMovePush>, IMessage, IEquatable<EntityStaticHookMovePush>, IDeepCloneable<EntityStaticHookMovePush>, IBufferMessage
	{
		// Token: 0x0600742E RID: 29742 RVA: 0x0011CA4C File Offset: 0x0011AC4C
		[NullableContext(1)]
		public static EntityStaticHookMovePush Create()
		{
			return new EntityStaticHookMovePush();
		}

		// Token: 0x1700167E RID: 5758
		// (get) Token: 0x0600742F RID: 29743 RVA: 0x0011CA53 File Offset: 0x0011AC53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700167F RID: 5759
		// (get) Token: 0x06007430 RID: 29744 RVA: 0x0011CA56 File Offset: 0x0011AC56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityStaticHookMovePush.Descriptor;
			}
		}

		// Token: 0x06007431 RID: 29745 RVA: 0x0011CA5D File Offset: 0x0011AC5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityStaticHookMovePush()
		{
		}

		// Token: 0x06007432 RID: 29746 RVA: 0x0011CA68 File Offset: 0x0011AC68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityStaticHookMovePush(EntityStaticHookMovePush other) : this()
		{
			this.entityId_ = other.entityId_;
			this.hookMoveType_ = other.hookMoveType_;
			EntityStaticHookMovePush.TargetOneofCase targetCase = other.TargetCase;
			if (targetCase != EntityStaticHookMovePush.TargetOneofCase.TargetEntityId)
			{
				if (targetCase == EntityStaticHookMovePush.TargetOneofCase.TargetPos)
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

		// Token: 0x06007433 RID: 29747 RVA: 0x0011CAD4 File Offset: 0x0011ACD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityStaticHookMovePush Clone()
		{
			return new EntityStaticHookMovePush(this);
		}

		// Token: 0x17001680 RID: 5760
		// (get) Token: 0x06007434 RID: 29748 RVA: 0x0011CADC File Offset: 0x0011ACDC
		// (set) Token: 0x06007435 RID: 29749 RVA: 0x0011CAE4 File Offset: 0x0011ACE4
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

		// Token: 0x17001681 RID: 5761
		// (get) Token: 0x06007436 RID: 29750 RVA: 0x0011CAED File Offset: 0x0011ACED
		// (set) Token: 0x06007437 RID: 29751 RVA: 0x0011CAF5 File Offset: 0x0011ACF5
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

		// Token: 0x17001682 RID: 5762
		// (get) Token: 0x06007438 RID: 29752 RVA: 0x0011CAFE File Offset: 0x0011ACFE
		// (set) Token: 0x06007439 RID: 29753 RVA: 0x0011CB16 File Offset: 0x0011AD16
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
				this.targetCase_ = EntityStaticHookMovePush.TargetOneofCase.TargetEntityId;
			}
		}

		// Token: 0x17001683 RID: 5763
		// (get) Token: 0x0600743A RID: 29754 RVA: 0x0011CB2B File Offset: 0x0011AD2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasTargetEntityId
		{
			get
			{
				return this.targetCase_ == EntityStaticHookMovePush.TargetOneofCase.TargetEntityId;
			}
		}

		// Token: 0x0600743B RID: 29755 RVA: 0x0011CB36 File Offset: 0x0011AD36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearTargetEntityId()
		{
			if (this.HasTargetEntityId)
			{
				this.ClearTarget();
			}
		}

		// Token: 0x17001684 RID: 5764
		// (get) Token: 0x0600743C RID: 29756 RVA: 0x0011CB46 File Offset: 0x0011AD46
		// (set) Token: 0x0600743D RID: 29757 RVA: 0x0011CB5E File Offset: 0x0011AD5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector TargetPos
		{
			get
			{
				if (this.targetCase_ != EntityStaticHookMovePush.TargetOneofCase.TargetPos)
				{
					return null;
				}
				return (Vector)this.target_;
			}
			set
			{
				this.target_ = value;
				this.targetCase_ = ((value == null) ? EntityStaticHookMovePush.TargetOneofCase.None : EntityStaticHookMovePush.TargetOneofCase.TargetPos);
			}
		}

		// Token: 0x17001685 RID: 5765
		// (get) Token: 0x0600743E RID: 29758 RVA: 0x0011CB74 File Offset: 0x0011AD74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityStaticHookMovePush.TargetOneofCase TargetCase
		{
			get
			{
				return this.targetCase_;
			}
		}

		// Token: 0x0600743F RID: 29759 RVA: 0x0011CB7C File Offset: 0x0011AD7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearTarget()
		{
			this.targetCase_ = EntityStaticHookMovePush.TargetOneofCase.None;
			this.target_ = null;
		}

		// Token: 0x06007440 RID: 29760 RVA: 0x0011CB8C File Offset: 0x0011AD8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityStaticHookMovePush);
		}

		// Token: 0x06007441 RID: 29761 RVA: 0x0011CB9C File Offset: 0x0011AD9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityStaticHookMovePush other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.HookMoveType == other.HookMoveType && this.TargetEntityId == other.TargetEntityId && object.Equals(this.TargetPos, other.TargetPos) && this.TargetCase == other.TargetCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007442 RID: 29762 RVA: 0x0011CC1C File Offset: 0x0011AE1C
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
			if (this.targetCase_ == EntityStaticHookMovePush.TargetOneofCase.TargetPos)
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

		// Token: 0x06007443 RID: 29763 RVA: 0x0011CCB3 File Offset: 0x0011AEB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007444 RID: 29764 RVA: 0x0011CCC0 File Offset: 0x0011AEC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007445 RID: 29765 RVA: 0x0011CCCC File Offset: 0x0011AECC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HasTargetEntityId)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.TargetEntityId);
			}
			if (this.targetCase_ == EntityStaticHookMovePush.TargetOneofCase.TargetPos)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.TargetPos);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(72);
				output.WriteInt64(this.EntityId);
			}
			if (this.HookMoveType != StaticHookMoveType.Hook)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.HookMoveType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007446 RID: 29766 RVA: 0x0011CD60 File Offset: 0x0011AF60
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
			if (this.targetCase_ == EntityStaticHookMovePush.TargetOneofCase.TargetPos)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TargetPos);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007447 RID: 29767 RVA: 0x0011CDE8 File Offset: 0x0011AFE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityStaticHookMovePush other)
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
			EntityStaticHookMovePush.TargetOneofCase targetCase = other.TargetCase;
			if (targetCase != EntityStaticHookMovePush.TargetOneofCase.TargetEntityId)
			{
				if (targetCase == EntityStaticHookMovePush.TargetOneofCase.TargetPos)
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

		// Token: 0x06007448 RID: 29768 RVA: 0x0011CE7B File Offset: 0x0011B07B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007449 RID: 29769 RVA: 0x0011CE84 File Offset: 0x0011B084
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
				if (num <= 58U)
				{
					if (num == 24U)
					{
						this.TargetEntityId = input.ReadInt64();
						continue;
					}
					if (num == 58U)
					{
						Vector vector = new Vector();
						if (this.targetCase_ == EntityStaticHookMovePush.TargetOneofCase.TargetPos)
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
					if (num == 72U)
					{
						this.EntityId = input.ReadInt64();
						continue;
					}
					if (num == 80U)
					{
						this.HookMoveType = (StaticHookMoveType)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003D59 RID: 15705
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D5A RID: 15706
		public const int EntityIdFieldNumber = 9;

		// Token: 0x04003D5B RID: 15707
		private long entityId_;

		// Token: 0x04003D5C RID: 15708
		public const int HookMoveTypeFieldNumber = 10;

		// Token: 0x04003D5D RID: 15709
		private StaticHookMoveType hookMoveType_;

		// Token: 0x04003D5E RID: 15710
		public const int TargetEntityIdFieldNumber = 3;

		// Token: 0x04003D5F RID: 15711
		public const int TargetPosFieldNumber = 7;

		// Token: 0x04003D60 RID: 15712
		private object target_;

		// Token: 0x04003D61 RID: 15713
		private EntityStaticHookMovePush.TargetOneofCase targetCase_;

		// Token: 0x02001779 RID: 6009
		public enum TargetOneofCase
		{
			// Token: 0x0400C68E RID: 50830
			None,
			// Token: 0x0400C68F RID: 50831
			TargetEntityId = 3,
			// Token: 0x0400C690 RID: 50832
			TargetPos = 7
		}
	}
}
