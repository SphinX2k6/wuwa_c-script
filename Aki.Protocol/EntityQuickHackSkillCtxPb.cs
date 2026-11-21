using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200049E RID: 1182
	public sealed class EntityQuickHackSkillCtxPb : IMessage<EntityQuickHackSkillCtxPb>, IMessage, IEquatable<EntityQuickHackSkillCtxPb>, IDeepCloneable<EntityQuickHackSkillCtxPb>, IBufferMessage
	{
		// Token: 0x0600713A RID: 28986 RVA: 0x0011680D File Offset: 0x00114A0D
		[NullableContext(1)]
		public static EntityQuickHackSkillCtxPb Create()
		{
			return new EntityQuickHackSkillCtxPb();
		}

		// Token: 0x170015DD RID: 5597
		// (get) Token: 0x0600713B RID: 28987 RVA: 0x00116814 File Offset: 0x00114A14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170015DE RID: 5598
		// (get) Token: 0x0600713C RID: 28988 RVA: 0x00116817 File Offset: 0x00114A17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityQuickHackSkillCtxPb.Descriptor;
			}
		}

		// Token: 0x0600713D RID: 28989 RVA: 0x0011681E File Offset: 0x00114A1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityQuickHackSkillCtxPb()
		{
		}

		// Token: 0x0600713E RID: 28990 RVA: 0x00116828 File Offset: 0x00114A28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityQuickHackSkillCtxPb(EntityQuickHackSkillCtxPb other) : this()
		{
			this.skillId_ = other.skillId_;
			this.entityState_ = other.entityState_;
			this.entityCtx_ = ((other.entityCtx_ != null) ? other.entityCtx_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600713F RID: 28991 RVA: 0x00116880 File Offset: 0x00114A80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityQuickHackSkillCtxPb Clone()
		{
			return new EntityQuickHackSkillCtxPb(this);
		}

		// Token: 0x170015DF RID: 5599
		// (get) Token: 0x06007140 RID: 28992 RVA: 0x00116888 File Offset: 0x00114A88
		// (set) Token: 0x06007141 RID: 28993 RVA: 0x00116890 File Offset: 0x00114A90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkillId
		{
			get
			{
				return this.skillId_;
			}
			set
			{
				this.skillId_ = value;
			}
		}

		// Token: 0x170015E0 RID: 5600
		// (get) Token: 0x06007142 RID: 28994 RVA: 0x00116899 File Offset: 0x00114A99
		// (set) Token: 0x06007143 RID: 28995 RVA: 0x001168A1 File Offset: 0x00114AA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EntityState
		{
			get
			{
				return this.entityState_;
			}
			set
			{
				this.entityState_ = value;
			}
		}

		// Token: 0x170015E1 RID: 5601
		// (get) Token: 0x06007144 RID: 28996 RVA: 0x001168AA File Offset: 0x00114AAA
		// (set) Token: 0x06007145 RID: 28997 RVA: 0x001168B2 File Offset: 0x00114AB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityCtxPb EntityCtx
		{
			get
			{
				return this.entityCtx_;
			}
			set
			{
				this.entityCtx_ = value;
			}
		}

		// Token: 0x06007146 RID: 28998 RVA: 0x001168BB File Offset: 0x00114ABB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityQuickHackSkillCtxPb);
		}

		// Token: 0x06007147 RID: 28999 RVA: 0x001168CC File Offset: 0x00114ACC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityQuickHackSkillCtxPb other)
		{
			return other != null && (other == this || (this.SkillId == other.SkillId && this.EntityState == other.EntityState && object.Equals(this.EntityCtx, other.EntityCtx) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007148 RID: 29000 RVA: 0x0011692C File Offset: 0x00114B2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SkillId != 0)
			{
				num ^= this.SkillId.GetHashCode();
			}
			if (this.EntityState != 0)
			{
				num ^= this.EntityState.GetHashCode();
			}
			if (this.entityCtx_ != null)
			{
				num ^= this.EntityCtx.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007149 RID: 29001 RVA: 0x0011699A File Offset: 0x00114B9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600714A RID: 29002 RVA: 0x001169A7 File Offset: 0x00114BA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600714B RID: 29003 RVA: 0x001169B0 File Offset: 0x00114BB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SkillId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SkillId);
			}
			if (this.EntityState != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.EntityState);
			}
			if (this.entityCtx_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.EntityCtx);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600714C RID: 29004 RVA: 0x00116A24 File Offset: 0x00114C24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SkillId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkillId);
			}
			if (this.EntityState != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EntityState);
			}
			if (this.entityCtx_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EntityCtx);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600714D RID: 29005 RVA: 0x00116A94 File Offset: 0x00114C94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityQuickHackSkillCtxPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SkillId != 0)
			{
				this.SkillId = other.SkillId;
			}
			if (other.EntityState != 0)
			{
				this.EntityState = other.EntityState;
			}
			if (other.entityCtx_ != null)
			{
				if (this.entityCtx_ == null)
				{
					this.EntityCtx = new EntityCtxPb();
				}
				this.EntityCtx.MergeFrom(other.EntityCtx);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600714E RID: 29006 RVA: 0x00116B10 File Offset: 0x00114D10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600714F RID: 29007 RVA: 0x00116B1C File Offset: 0x00114D1C
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
				if (num != 8U)
				{
					if (num != 16U)
					{
						if (num != 26U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.entityCtx_ == null)
							{
								this.EntityCtx = new EntityCtxPb();
							}
							input.ReadMessage(this.EntityCtx);
						}
					}
					else
					{
						this.EntityState = input.ReadInt32();
					}
				}
				else
				{
					this.SkillId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003CE4 RID: 15588
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003CE5 RID: 15589
		public const int SkillIdFieldNumber = 1;

		// Token: 0x04003CE6 RID: 15590
		private int skillId_;

		// Token: 0x04003CE7 RID: 15591
		public const int EntityStateFieldNumber = 2;

		// Token: 0x04003CE8 RID: 15592
		private int entityState_;

		// Token: 0x04003CE9 RID: 15593
		public const int EntityCtxFieldNumber = 3;

		// Token: 0x04003CEA RID: 15594
		private EntityCtxPb entityCtx_;
	}
}
