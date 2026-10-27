using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004B5 RID: 1205
	public sealed class EntityQuickHackSkillCtxPb : IMessage<EntityQuickHackSkillCtxPb>, IMessage, IEquatable<EntityQuickHackSkillCtxPb>, IDeepCloneable<EntityQuickHackSkillCtxPb>, IBufferMessage
	{
		// Token: 0x060072CA RID: 29386 RVA: 0x00119931 File Offset: 0x00117B31
		[NullableContext(1)]
		public static EntityQuickHackSkillCtxPb Create()
		{
			return new EntityQuickHackSkillCtxPb();
		}

		// Token: 0x17001632 RID: 5682
		// (get) Token: 0x060072CB RID: 29387 RVA: 0x00119938 File Offset: 0x00117B38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001633 RID: 5683
		// (get) Token: 0x060072CC RID: 29388 RVA: 0x0011993B File Offset: 0x00117B3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityQuickHackSkillCtxPb.Descriptor;
			}
		}

		// Token: 0x060072CD RID: 29389 RVA: 0x00119942 File Offset: 0x00117B42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityQuickHackSkillCtxPb()
		{
		}

		// Token: 0x060072CE RID: 29390 RVA: 0x0011994C File Offset: 0x00117B4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityQuickHackSkillCtxPb(EntityQuickHackSkillCtxPb other) : this()
		{
			this.skillId_ = other.skillId_;
			this.entityState_ = other.entityState_;
			this.entityCtx_ = ((other.entityCtx_ != null) ? other.entityCtx_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060072CF RID: 29391 RVA: 0x001199A4 File Offset: 0x00117BA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityQuickHackSkillCtxPb Clone()
		{
			return new EntityQuickHackSkillCtxPb(this);
		}

		// Token: 0x17001634 RID: 5684
		// (get) Token: 0x060072D0 RID: 29392 RVA: 0x001199AC File Offset: 0x00117BAC
		// (set) Token: 0x060072D1 RID: 29393 RVA: 0x001199B4 File Offset: 0x00117BB4
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

		// Token: 0x17001635 RID: 5685
		// (get) Token: 0x060072D2 RID: 29394 RVA: 0x001199BD File Offset: 0x00117BBD
		// (set) Token: 0x060072D3 RID: 29395 RVA: 0x001199C5 File Offset: 0x00117BC5
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

		// Token: 0x17001636 RID: 5686
		// (get) Token: 0x060072D4 RID: 29396 RVA: 0x001199CE File Offset: 0x00117BCE
		// (set) Token: 0x060072D5 RID: 29397 RVA: 0x001199D6 File Offset: 0x00117BD6
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

		// Token: 0x060072D6 RID: 29398 RVA: 0x001199DF File Offset: 0x00117BDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityQuickHackSkillCtxPb);
		}

		// Token: 0x060072D7 RID: 29399 RVA: 0x001199F0 File Offset: 0x00117BF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityQuickHackSkillCtxPb other)
		{
			return other != null && (other == this || (this.SkillId == other.SkillId && this.EntityState == other.EntityState && object.Equals(this.EntityCtx, other.EntityCtx) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060072D8 RID: 29400 RVA: 0x00119A50 File Offset: 0x00117C50
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

		// Token: 0x060072D9 RID: 29401 RVA: 0x00119ABE File Offset: 0x00117CBE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060072DA RID: 29402 RVA: 0x00119ACB File Offset: 0x00117CCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060072DB RID: 29403 RVA: 0x00119AD4 File Offset: 0x00117CD4
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

		// Token: 0x060072DC RID: 29404 RVA: 0x00119B48 File Offset: 0x00117D48
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

		// Token: 0x060072DD RID: 29405 RVA: 0x00119BB8 File Offset: 0x00117DB8
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

		// Token: 0x060072DE RID: 29406 RVA: 0x00119C34 File Offset: 0x00117E34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060072DF RID: 29407 RVA: 0x00119C40 File Offset: 0x00117E40
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

		// Token: 0x04003CF8 RID: 15608
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003CF9 RID: 15609
		public const int SkillIdFieldNumber = 1;

		// Token: 0x04003CFA RID: 15610
		private int skillId_;

		// Token: 0x04003CFB RID: 15611
		public const int EntityStateFieldNumber = 2;

		// Token: 0x04003CFC RID: 15612
		private int entityState_;

		// Token: 0x04003CFD RID: 15613
		public const int EntityCtxFieldNumber = 3;

		// Token: 0x04003CFE RID: 15614
		private EntityCtxPb entityCtx_;
	}
}
