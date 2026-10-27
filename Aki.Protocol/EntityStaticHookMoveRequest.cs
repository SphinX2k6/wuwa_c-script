using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004C7 RID: 1223
	[NetMessage(EMessageId.EntityStaticHookMoveRequest)]
	public sealed class EntityStaticHookMoveRequest : IMessage<EntityStaticHookMoveRequest>, IMessage, IEquatable<EntityStaticHookMoveRequest>, IDeepCloneable<EntityStaticHookMoveRequest>, IBufferMessage
	{
		// Token: 0x0600744A RID: 29770 RVA: 0x0011CF2C File Offset: 0x0011B12C
		[NullableContext(1)]
		public static EntityStaticHookMoveRequest Create()
		{
			return new EntityStaticHookMoveRequest();
		}

		// Token: 0x17001686 RID: 5766
		// (get) Token: 0x0600744B RID: 29771 RVA: 0x0011CF33 File Offset: 0x0011B133
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001687 RID: 5767
		// (get) Token: 0x0600744C RID: 29772 RVA: 0x0011CF36 File Offset: 0x0011B136
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityStaticHookMoveRequest.Descriptor;
			}
		}

		// Token: 0x0600744D RID: 29773 RVA: 0x0011CF3D File Offset: 0x0011B13D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityStaticHookMoveRequest()
		{
		}

		// Token: 0x0600744E RID: 29774 RVA: 0x0011CF48 File Offset: 0x0011B148
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

		// Token: 0x0600744F RID: 29775 RVA: 0x0011CFB5 File Offset: 0x0011B1B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityStaticHookMoveRequest Clone()
		{
			return new EntityStaticHookMoveRequest(this);
		}

		// Token: 0x17001688 RID: 5768
		// (get) Token: 0x06007450 RID: 29776 RVA: 0x0011CFBD File Offset: 0x0011B1BD
		// (set) Token: 0x06007451 RID: 29777 RVA: 0x0011CFC5 File Offset: 0x0011B1C5
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

		// Token: 0x17001689 RID: 5769
		// (get) Token: 0x06007452 RID: 29778 RVA: 0x0011CFCE File Offset: 0x0011B1CE
		// (set) Token: 0x06007453 RID: 29779 RVA: 0x0011CFD6 File Offset: 0x0011B1D6
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

		// Token: 0x1700168A RID: 5770
		// (get) Token: 0x06007454 RID: 29780 RVA: 0x0011CFDF File Offset: 0x0011B1DF
		// (set) Token: 0x06007455 RID: 29781 RVA: 0x0011CFF7 File Offset: 0x0011B1F7
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

		// Token: 0x1700168B RID: 5771
		// (get) Token: 0x06007456 RID: 29782 RVA: 0x0011D00C File Offset: 0x0011B20C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasTargetEntityId
		{
			get
			{
				return this.targetCase_ == EntityStaticHookMoveRequest.TargetOneofCase.TargetEntityId;
			}
		}

		// Token: 0x06007457 RID: 29783 RVA: 0x0011D017 File Offset: 0x0011B217
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearTargetEntityId()
		{
			if (this.HasTargetEntityId)
			{
				this.ClearTarget();
			}
		}

		// Token: 0x1700168C RID: 5772
		// (get) Token: 0x06007458 RID: 29784 RVA: 0x0011D027 File Offset: 0x0011B227
		// (set) Token: 0x06007459 RID: 29785 RVA: 0x0011D040 File Offset: 0x0011B240
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

		// Token: 0x1700168D RID: 5773
		// (get) Token: 0x0600745A RID: 29786 RVA: 0x0011D057 File Offset: 0x0011B257
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityStaticHookMoveRequest.TargetOneofCase TargetCase
		{
			get
			{
				return this.targetCase_;
			}
		}

		// Token: 0x0600745B RID: 29787 RVA: 0x0011D05F File Offset: 0x0011B25F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearTarget()
		{
			this.targetCase_ = EntityStaticHookMoveRequest.TargetOneofCase.None;
			this.target_ = null;
		}

		// Token: 0x0600745C RID: 29788 RVA: 0x0011D06F File Offset: 0x0011B26F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityStaticHookMoveRequest);
		}

		// Token: 0x0600745D RID: 29789 RVA: 0x0011D080 File Offset: 0x0011B280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityStaticHookMoveRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.HookMoveType == other.HookMoveType && this.TargetEntityId == other.TargetEntityId && object.Equals(this.TargetPos, other.TargetPos) && this.TargetCase == other.TargetCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600745E RID: 29790 RVA: 0x0011D100 File Offset: 0x0011B300
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

		// Token: 0x0600745F RID: 29791 RVA: 0x0011D198 File Offset: 0x0011B398
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007460 RID: 29792 RVA: 0x0011D1A5 File Offset: 0x0011B3A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007461 RID: 29793 RVA: 0x0011D1B0 File Offset: 0x0011B3B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HasTargetEntityId)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.TargetEntityId);
			}
			if (this.HookMoveType != StaticHookMoveType.Hook)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.HookMoveType);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(104);
				output.WriteInt64(this.EntityId);
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

		// Token: 0x06007462 RID: 29794 RVA: 0x0011D244 File Offset: 0x0011B444
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

		// Token: 0x06007463 RID: 29795 RVA: 0x0011D2CC File Offset: 0x0011B4CC
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

		// Token: 0x06007464 RID: 29796 RVA: 0x0011D360 File Offset: 0x0011B560
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007465 RID: 29797 RVA: 0x0011D36C File Offset: 0x0011B56C
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
				if (num <= 24U)
				{
					if (num == 16U)
					{
						this.TargetEntityId = input.ReadInt64();
						continue;
					}
					if (num == 24U)
					{
						this.HookMoveType = (StaticHookMoveType)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 104U)
					{
						this.EntityId = input.ReadInt64();
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

		// Token: 0x04003D62 RID: 15714
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D63 RID: 15715
		public const int EntityIdFieldNumber = 13;

		// Token: 0x04003D64 RID: 15716
		private long entityId_;

		// Token: 0x04003D65 RID: 15717
		public const int HookMoveTypeFieldNumber = 3;

		// Token: 0x04003D66 RID: 15718
		private StaticHookMoveType hookMoveType_;

		// Token: 0x04003D67 RID: 15719
		public const int TargetEntityIdFieldNumber = 2;

		// Token: 0x04003D68 RID: 15720
		public const int TargetPosFieldNumber = 15;

		// Token: 0x04003D69 RID: 15721
		private object target_;

		// Token: 0x04003D6A RID: 15722
		private EntityStaticHookMoveRequest.TargetOneofCase targetCase_;

		// Token: 0x0200177A RID: 6010
		public enum TargetOneofCase
		{
			// Token: 0x0400C692 RID: 50834
			None,
			// Token: 0x0400C693 RID: 50835
			TargetEntityId = 2,
			// Token: 0x0400C694 RID: 50836
			TargetPos = 15
		}
	}
}
