using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004AE RID: 1198
	[NetMessage(EMessageId.EntityStaticHookMoveNotify)]
	public sealed class EntityStaticHookMoveNotify : IMessage<EntityStaticHookMoveNotify>, IMessage, IEquatable<EntityStaticHookMoveNotify>, IDeepCloneable<EntityStaticHookMoveNotify>, IBufferMessage
	{
		// Token: 0x06007282 RID: 29314 RVA: 0x00119453 File Offset: 0x00117653
		[NullableContext(1)]
		public static EntityStaticHookMoveNotify Create()
		{
			return new EntityStaticHookMoveNotify();
		}

		// Token: 0x17001621 RID: 5665
		// (get) Token: 0x06007283 RID: 29315 RVA: 0x0011945A File Offset: 0x0011765A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001622 RID: 5666
		// (get) Token: 0x06007284 RID: 29316 RVA: 0x0011945D File Offset: 0x0011765D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityStaticHookMoveNotify.Descriptor;
			}
		}

		// Token: 0x06007285 RID: 29317 RVA: 0x00119464 File Offset: 0x00117664
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityStaticHookMoveNotify()
		{
		}

		// Token: 0x06007286 RID: 29318 RVA: 0x0011946C File Offset: 0x0011766C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityStaticHookMoveNotify(EntityStaticHookMoveNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.hookMoveType_ = other.hookMoveType_;
			EntityStaticHookMoveNotify.TargetOneofCase targetCase = other.TargetCase;
			if (targetCase != EntityStaticHookMoveNotify.TargetOneofCase.TargetPos)
			{
				if (targetCase == EntityStaticHookMoveNotify.TargetOneofCase.TargetEntityId)
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

		// Token: 0x06007287 RID: 29319 RVA: 0x001194D8 File Offset: 0x001176D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityStaticHookMoveNotify Clone()
		{
			return new EntityStaticHookMoveNotify(this);
		}

		// Token: 0x17001623 RID: 5667
		// (get) Token: 0x06007288 RID: 29320 RVA: 0x001194E0 File Offset: 0x001176E0
		// (set) Token: 0x06007289 RID: 29321 RVA: 0x001194E8 File Offset: 0x001176E8
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

		// Token: 0x17001624 RID: 5668
		// (get) Token: 0x0600728A RID: 29322 RVA: 0x001194F1 File Offset: 0x001176F1
		// (set) Token: 0x0600728B RID: 29323 RVA: 0x001194F9 File Offset: 0x001176F9
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

		// Token: 0x17001625 RID: 5669
		// (get) Token: 0x0600728C RID: 29324 RVA: 0x00119502 File Offset: 0x00117702
		// (set) Token: 0x0600728D RID: 29325 RVA: 0x0011951A File Offset: 0x0011771A
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

		// Token: 0x17001626 RID: 5670
		// (get) Token: 0x0600728E RID: 29326 RVA: 0x00119530 File Offset: 0x00117730
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasTargetEntityId
		{
			get
			{
				return this.targetCase_ == EntityStaticHookMoveNotify.TargetOneofCase.TargetEntityId;
			}
		}

		// Token: 0x0600728F RID: 29327 RVA: 0x0011953C File Offset: 0x0011773C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearTargetEntityId()
		{
			if (this.HasTargetEntityId)
			{
				this.ClearTarget();
			}
		}

		// Token: 0x17001627 RID: 5671
		// (get) Token: 0x06007290 RID: 29328 RVA: 0x0011954C File Offset: 0x0011774C
		// (set) Token: 0x06007291 RID: 29329 RVA: 0x00119565 File Offset: 0x00117765
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

		// Token: 0x17001628 RID: 5672
		// (get) Token: 0x06007292 RID: 29330 RVA: 0x0011957C File Offset: 0x0011777C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityStaticHookMoveNotify.TargetOneofCase TargetCase
		{
			get
			{
				return this.targetCase_;
			}
		}

		// Token: 0x06007293 RID: 29331 RVA: 0x00119584 File Offset: 0x00117784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearTarget()
		{
			this.targetCase_ = EntityStaticHookMoveNotify.TargetOneofCase.None;
			this.target_ = null;
		}

		// Token: 0x06007294 RID: 29332 RVA: 0x00119594 File Offset: 0x00117794
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityStaticHookMoveNotify);
		}

		// Token: 0x06007295 RID: 29333 RVA: 0x001195A4 File Offset: 0x001177A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityStaticHookMoveNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.HookMoveType == other.HookMoveType && this.TargetEntityId == other.TargetEntityId && object.Equals(this.TargetPos, other.TargetPos) && this.TargetCase == other.TargetCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007296 RID: 29334 RVA: 0x00119624 File Offset: 0x00117824
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

		// Token: 0x06007297 RID: 29335 RVA: 0x001196BC File Offset: 0x001178BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007298 RID: 29336 RVA: 0x001196C9 File Offset: 0x001178C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007299 RID: 29337 RVA: 0x001196D4 File Offset: 0x001178D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(72);
				output.WriteInt64(this.EntityId);
			}
			if (this.targetCase_ == EntityStaticHookMoveNotify.TargetOneofCase.TargetPos)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.TargetPos);
			}
			if (this.HookMoveType != StaticHookMoveType.Hook)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.HookMoveType);
			}
			if (this.HasTargetEntityId)
			{
				output.WriteRawTag(112);
				output.WriteInt64(this.TargetEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600729A RID: 29338 RVA: 0x00119768 File Offset: 0x00117968
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

		// Token: 0x0600729B RID: 29339 RVA: 0x001197F0 File Offset: 0x001179F0
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
			if (targetCase != EntityStaticHookMoveNotify.TargetOneofCase.TargetPos)
			{
				if (targetCase == EntityStaticHookMoveNotify.TargetOneofCase.TargetEntityId)
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

		// Token: 0x0600729C RID: 29340 RVA: 0x00119883 File Offset: 0x00117A83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600729D RID: 29341 RVA: 0x0011988C File Offset: 0x00117A8C
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
				if (num <= 82U)
				{
					if (num == 72U)
					{
						this.EntityId = input.ReadInt64();
						continue;
					}
					if (num == 82U)
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
					if (num == 104U)
					{
						this.HookMoveType = (StaticHookMoveType)input.ReadEnum();
						continue;
					}
					if (num == 112U)
					{
						this.TargetEntityId = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003D3C RID: 15676
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D3D RID: 15677
		public const int EntityIdFieldNumber = 9;

		// Token: 0x04003D3E RID: 15678
		private long entityId_;

		// Token: 0x04003D3F RID: 15679
		public const int HookMoveTypeFieldNumber = 13;

		// Token: 0x04003D40 RID: 15680
		private StaticHookMoveType hookMoveType_;

		// Token: 0x04003D41 RID: 15681
		public const int TargetEntityIdFieldNumber = 14;

		// Token: 0x04003D42 RID: 15682
		public const int TargetPosFieldNumber = 10;

		// Token: 0x04003D43 RID: 15683
		private object target_;

		// Token: 0x04003D44 RID: 15684
		private EntityStaticHookMoveNotify.TargetOneofCase targetCase_;

		// Token: 0x020017F0 RID: 6128
		public enum TargetOneofCase
		{
			// Token: 0x0400CBB5 RID: 52149
			None,
			// Token: 0x0400CBB6 RID: 52150
			TargetEntityId = 14,
			// Token: 0x0400CBB7 RID: 52151
			TargetPos = 10
		}
	}
}
