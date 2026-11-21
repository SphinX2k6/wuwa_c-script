using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004B0 RID: 1200
	[NetMessage(EMessageId.EntityStaticHookMoveRequest)]
	public sealed class EntityStaticHookMoveRequest : IMessage<EntityStaticHookMoveRequest>, IMessage, IEquatable<EntityStaticHookMoveRequest>, IDeepCloneable<EntityStaticHookMoveRequest>, IBufferMessage
	{
		// Token: 0x060072BA RID: 29370 RVA: 0x00119E14 File Offset: 0x00118014
		[NullableContext(1)]
		public static EntityStaticHookMoveRequest Create()
		{
			return new EntityStaticHookMoveRequest();
		}

		// Token: 0x17001631 RID: 5681
		// (get) Token: 0x060072BB RID: 29371 RVA: 0x00119E1B File Offset: 0x0011801B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001632 RID: 5682
		// (get) Token: 0x060072BC RID: 29372 RVA: 0x00119E1E File Offset: 0x0011801E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityStaticHookMoveRequest.Descriptor;
			}
		}

		// Token: 0x060072BD RID: 29373 RVA: 0x00119E25 File Offset: 0x00118025
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityStaticHookMoveRequest()
		{
		}

		// Token: 0x060072BE RID: 29374 RVA: 0x00119E30 File Offset: 0x00118030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityStaticHookMoveRequest(EntityStaticHookMoveRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.hookMoveType_ = other.hookMoveType_;
			EntityStaticHookMoveRequest.TargetOneofCase targetCase = other.TargetCase;
			if (targetCase != EntityStaticHookMoveRequest.TargetOneofCase.TargetEntityId)
			{
				if (targetCase == EntityStaticHookMoveRequest.TargetOneofCase.TargetPos)
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

		// Token: 0x060072BF RID: 29375 RVA: 0x00119E9E File Offset: 0x0011809E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityStaticHookMoveRequest Clone()
		{
			return new EntityStaticHookMoveRequest(this);
		}

		// Token: 0x17001633 RID: 5683
		// (get) Token: 0x060072C0 RID: 29376 RVA: 0x00119EA6 File Offset: 0x001180A6
		// (set) Token: 0x060072C1 RID: 29377 RVA: 0x00119EAE File Offset: 0x001180AE
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

		// Token: 0x17001634 RID: 5684
		// (get) Token: 0x060072C2 RID: 29378 RVA: 0x00119EB7 File Offset: 0x001180B7
		// (set) Token: 0x060072C3 RID: 29379 RVA: 0x00119EBF File Offset: 0x001180BF
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

		// Token: 0x17001635 RID: 5685
		// (get) Token: 0x060072C4 RID: 29380 RVA: 0x00119EC8 File Offset: 0x001180C8
		// (set) Token: 0x060072C5 RID: 29381 RVA: 0x00119EE0 File Offset: 0x001180E0
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
				this.targetCase_ = EntityStaticHookMoveRequest.TargetOneofCase.TargetEntityId;
			}
		}

		// Token: 0x17001636 RID: 5686
		// (get) Token: 0x060072C6 RID: 29382 RVA: 0x00119EF6 File Offset: 0x001180F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasTargetEntityId
		{
			get
			{
				return this.targetCase_ == EntityStaticHookMoveRequest.TargetOneofCase.TargetEntityId;
			}
		}

		// Token: 0x060072C7 RID: 29383 RVA: 0x00119F02 File Offset: 0x00118102
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearTargetEntityId()
		{
			if (this.HasTargetEntityId)
			{
				this.ClearTarget();
			}
		}

		// Token: 0x17001637 RID: 5687
		// (get) Token: 0x060072C8 RID: 29384 RVA: 0x00119F12 File Offset: 0x00118112
		// (set) Token: 0x060072C9 RID: 29385 RVA: 0x00119F2B File Offset: 0x0011812B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector TargetPos
		{
			get
			{
				if (this.targetCase_ != EntityStaticHookMoveRequest.TargetOneofCase.TargetPos)
				{
					return null;
				}
				return (Vector)this.target_;
			}
			set
			{
				this.target_ = value;
				this.targetCase_ = ((value == null) ? EntityStaticHookMoveRequest.TargetOneofCase.None : EntityStaticHookMoveRequest.TargetOneofCase.TargetPos);
			}
		}

		// Token: 0x17001638 RID: 5688
		// (get) Token: 0x060072CA RID: 29386 RVA: 0x00119F42 File Offset: 0x00118142
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityStaticHookMoveRequest.TargetOneofCase TargetCase
		{
			get
			{
				return this.targetCase_;
			}
		}

		// Token: 0x060072CB RID: 29387 RVA: 0x00119F4A File Offset: 0x0011814A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearTarget()
		{
			this.targetCase_ = EntityStaticHookMoveRequest.TargetOneofCase.None;
			this.target_ = null;
		}

		// Token: 0x060072CC RID: 29388 RVA: 0x00119F5A File Offset: 0x0011815A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityStaticHookMoveRequest);
		}

		// Token: 0x060072CD RID: 29389 RVA: 0x00119F68 File Offset: 0x00118168
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityStaticHookMoveRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.HookMoveType == other.HookMoveType && this.TargetEntityId == other.TargetEntityId && object.Equals(this.TargetPos, other.TargetPos) && this.TargetCase == other.TargetCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060072CE RID: 29390 RVA: 0x00119FE8 File Offset: 0x001181E8
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
			if (this.targetCase_ == EntityStaticHookMoveRequest.TargetOneofCase.TargetPos)
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

		// Token: 0x060072CF RID: 29391 RVA: 0x0011A080 File Offset: 0x00118280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060072D0 RID: 29392 RVA: 0x0011A08D File Offset: 0x0011828D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060072D1 RID: 29393 RVA: 0x0011A098 File Offset: 0x00118298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.EntityId);
			}
			if (this.HasTargetEntityId)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.TargetEntityId);
			}
			if (this.HookMoveType != StaticHookMoveType.Hook)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.HookMoveType);
			}
			if (this.targetCase_ == EntityStaticHookMoveRequest.TargetOneofCase.TargetPos)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.TargetPos);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060072D2 RID: 29394 RVA: 0x0011A12C File Offset: 0x0011832C
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
			if (this.targetCase_ == EntityStaticHookMoveRequest.TargetOneofCase.TargetPos)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TargetPos);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060072D3 RID: 29395 RVA: 0x0011A1B4 File Offset: 0x001183B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityStaticHookMoveRequest other)
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
			EntityStaticHookMoveRequest.TargetOneofCase targetCase = other.TargetCase;
			if (targetCase != EntityStaticHookMoveRequest.TargetOneofCase.TargetEntityId)
			{
				if (targetCase == EntityStaticHookMoveRequest.TargetOneofCase.TargetPos)
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

		// Token: 0x060072D4 RID: 29396 RVA: 0x0011A249 File Offset: 0x00118449
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060072D5 RID: 29397 RVA: 0x0011A254 File Offset: 0x00118454
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
				if (num <= 80U)
				{
					if (num == 16U)
					{
						this.EntityId = input.ReadInt64();
						continue;
					}
					if (num == 80U)
					{
						this.TargetEntityId = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.HookMoveType = (StaticHookMoveType)input.ReadEnum();
						continue;
					}
					if (num == 122U)
					{
						Vector vector = new Vector();
						if (this.targetCase_ == EntityStaticHookMoveRequest.TargetOneofCase.TargetPos)
						{
							vector.MergeFrom(this.TargetPos);
						}
						input.ReadMessage(vector);
						this.TargetPos = vector;
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003D4E RID: 15694
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D4F RID: 15695
		public const int EntityIdFieldNumber = 2;

		// Token: 0x04003D50 RID: 15696
		private long entityId_;

		// Token: 0x04003D51 RID: 15697
		public const int HookMoveTypeFieldNumber = 12;

		// Token: 0x04003D52 RID: 15698
		private StaticHookMoveType hookMoveType_;

		// Token: 0x04003D53 RID: 15699
		public const int TargetEntityIdFieldNumber = 10;

		// Token: 0x04003D54 RID: 15700
		public const int TargetPosFieldNumber = 15;

		// Token: 0x04003D55 RID: 15701
		private object target_;

		// Token: 0x04003D56 RID: 15702
		private EntityStaticHookMoveRequest.TargetOneofCase targetCase_;

		// Token: 0x020017F2 RID: 6130
		public enum TargetOneofCase
		{
			// Token: 0x0400CBBD RID: 52157
			None,
			// Token: 0x0400CBBE RID: 52158
			TargetEntityId = 10,
			// Token: 0x0400CBBF RID: 52159
			TargetPos = 15
		}
	}
}
