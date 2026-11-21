using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004AF RID: 1199
	[NetMessage(EMessageId.EntityStaticHookMovePush)]
	public sealed class EntityStaticHookMovePush : IMessage<EntityStaticHookMovePush>, IMessage, IEquatable<EntityStaticHookMovePush>, IDeepCloneable<EntityStaticHookMovePush>, IBufferMessage
	{
		// Token: 0x0600729E RID: 29342 RVA: 0x00119935 File Offset: 0x00117B35
		[NullableContext(1)]
		public static EntityStaticHookMovePush Create()
		{
			return new EntityStaticHookMovePush();
		}

		// Token: 0x17001629 RID: 5673
		// (get) Token: 0x0600729F RID: 29343 RVA: 0x0011993C File Offset: 0x00117B3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700162A RID: 5674
		// (get) Token: 0x060072A0 RID: 29344 RVA: 0x0011993F File Offset: 0x00117B3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityStaticHookMovePush.Descriptor;
			}
		}

		// Token: 0x060072A1 RID: 29345 RVA: 0x00119946 File Offset: 0x00117B46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityStaticHookMovePush()
		{
		}

		// Token: 0x060072A2 RID: 29346 RVA: 0x00119950 File Offset: 0x00117B50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityStaticHookMovePush(EntityStaticHookMovePush other) : this()
		{
			this.entityId_ = other.entityId_;
			this.hookMoveType_ = other.hookMoveType_;
			EntityStaticHookMovePush.TargetOneofCase targetCase = other.TargetCase;
			if (targetCase != EntityStaticHookMovePush.TargetOneofCase.TargetPos)
			{
				if (targetCase == EntityStaticHookMovePush.TargetOneofCase.TargetEntityId)
				{
					this.TargetEntityId = other.TargetEntityId;
				}
			}
			else
			{
				this.TargetPos = other.TargetPos.Clone();
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060072A3 RID: 29347 RVA: 0x001199BB File Offset: 0x00117BBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityStaticHookMovePush Clone()
		{
			return new EntityStaticHookMovePush(this);
		}

		// Token: 0x1700162B RID: 5675
		// (get) Token: 0x060072A4 RID: 29348 RVA: 0x001199C3 File Offset: 0x00117BC3
		// (set) Token: 0x060072A5 RID: 29349 RVA: 0x001199CB File Offset: 0x00117BCB
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

		// Token: 0x1700162C RID: 5676
		// (get) Token: 0x060072A6 RID: 29350 RVA: 0x001199D4 File Offset: 0x00117BD4
		// (set) Token: 0x060072A7 RID: 29351 RVA: 0x001199DC File Offset: 0x00117BDC
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

		// Token: 0x1700162D RID: 5677
		// (get) Token: 0x060072A8 RID: 29352 RVA: 0x001199E5 File Offset: 0x00117BE5
		// (set) Token: 0x060072A9 RID: 29353 RVA: 0x001199FD File Offset: 0x00117BFD
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

		// Token: 0x1700162E RID: 5678
		// (get) Token: 0x060072AA RID: 29354 RVA: 0x00119A13 File Offset: 0x00117C13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasTargetEntityId
		{
			get
			{
				return this.targetCase_ == EntityStaticHookMovePush.TargetOneofCase.TargetEntityId;
			}
		}

		// Token: 0x060072AB RID: 29355 RVA: 0x00119A1F File Offset: 0x00117C1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearTargetEntityId()
		{
			if (this.HasTargetEntityId)
			{
				this.ClearTarget();
			}
		}

		// Token: 0x1700162F RID: 5679
		// (get) Token: 0x060072AC RID: 29356 RVA: 0x00119A2F File Offset: 0x00117C2F
		// (set) Token: 0x060072AD RID: 29357 RVA: 0x00119A47 File Offset: 0x00117C47
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

		// Token: 0x17001630 RID: 5680
		// (get) Token: 0x060072AE RID: 29358 RVA: 0x00119A5D File Offset: 0x00117C5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityStaticHookMovePush.TargetOneofCase TargetCase
		{
			get
			{
				return this.targetCase_;
			}
		}

		// Token: 0x060072AF RID: 29359 RVA: 0x00119A65 File Offset: 0x00117C65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearTarget()
		{
			this.targetCase_ = EntityStaticHookMovePush.TargetOneofCase.None;
			this.target_ = null;
		}

		// Token: 0x060072B0 RID: 29360 RVA: 0x00119A75 File Offset: 0x00117C75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityStaticHookMovePush);
		}

		// Token: 0x060072B1 RID: 29361 RVA: 0x00119A84 File Offset: 0x00117C84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityStaticHookMovePush other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.HookMoveType == other.HookMoveType && this.TargetEntityId == other.TargetEntityId && object.Equals(this.TargetPos, other.TargetPos) && this.TargetCase == other.TargetCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060072B2 RID: 29362 RVA: 0x00119B04 File Offset: 0x00117D04
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

		// Token: 0x060072B3 RID: 29363 RVA: 0x00119B9B File Offset: 0x00117D9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060072B4 RID: 29364 RVA: 0x00119BA8 File Offset: 0x00117DA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060072B5 RID: 29365 RVA: 0x00119BB4 File Offset: 0x00117DB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.targetCase_ == EntityStaticHookMovePush.TargetOneofCase.TargetPos)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.TargetPos);
			}
			if (this.HookMoveType != StaticHookMoveType.Hook)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.HookMoveType);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.EntityId);
			}
			if (this.HasTargetEntityId)
			{
				output.WriteRawTag(120);
				output.WriteInt64(this.TargetEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060072B6 RID: 29366 RVA: 0x00119C48 File Offset: 0x00117E48
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

		// Token: 0x060072B7 RID: 29367 RVA: 0x00119CD0 File Offset: 0x00117ED0
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
			if (targetCase != EntityStaticHookMovePush.TargetOneofCase.TargetPos)
			{
				if (targetCase == EntityStaticHookMovePush.TargetOneofCase.TargetEntityId)
				{
					this.TargetEntityId = other.TargetEntityId;
				}
			}
			else
			{
				if (this.TargetPos == null)
				{
					this.TargetPos = new Vector();
				}
				this.TargetPos.MergeFrom(other.TargetPos);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060072B8 RID: 29368 RVA: 0x00119D62 File Offset: 0x00117F62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060072B9 RID: 29369 RVA: 0x00119D6C File Offset: 0x00117F6C
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
				if (num <= 48U)
				{
					if (num == 34U)
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
					if (num == 48U)
					{
						this.HookMoveType = (StaticHookMoveType)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.EntityId = input.ReadInt64();
						continue;
					}
					if (num == 120U)
					{
						this.TargetEntityId = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003D45 RID: 15685
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D46 RID: 15686
		public const int EntityIdFieldNumber = 12;

		// Token: 0x04003D47 RID: 15687
		private long entityId_;

		// Token: 0x04003D48 RID: 15688
		public const int HookMoveTypeFieldNumber = 6;

		// Token: 0x04003D49 RID: 15689
		private StaticHookMoveType hookMoveType_;

		// Token: 0x04003D4A RID: 15690
		public const int TargetEntityIdFieldNumber = 15;

		// Token: 0x04003D4B RID: 15691
		public const int TargetPosFieldNumber = 4;

		// Token: 0x04003D4C RID: 15692
		private object target_;

		// Token: 0x04003D4D RID: 15693
		private EntityStaticHookMovePush.TargetOneofCase targetCase_;

		// Token: 0x020017F1 RID: 6129
		public enum TargetOneofCase
		{
			// Token: 0x0400CBB9 RID: 52153
			None,
			// Token: 0x0400CBBA RID: 52154
			TargetEntityId = 15,
			// Token: 0x0400CBBB RID: 52155
			TargetPos = 4
		}
	}
}
