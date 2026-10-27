using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200046B RID: 1131
	[NetMessage(EMessageId.EntityAttachChangeNotify)]
	public sealed class EntityAttachChangeNotify : IMessage<EntityAttachChangeNotify>, IMessage, IEquatable<EntityAttachChangeNotify>, IDeepCloneable<EntityAttachChangeNotify>, IBufferMessage
	{
		// Token: 0x06006BDC RID: 27612 RVA: 0x001042A2 File Offset: 0x001024A2
		[NullableContext(1)]
		public static EntityAttachChangeNotify Create()
		{
			return new EntityAttachChangeNotify();
		}

		// Token: 0x17001473 RID: 5235
		// (get) Token: 0x06006BDD RID: 27613 RVA: 0x001042A9 File Offset: 0x001024A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001474 RID: 5236
		// (get) Token: 0x06006BDE RID: 27614 RVA: 0x001042AC File Offset: 0x001024AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityAttachChangeNotify.Descriptor;
			}
		}

		// Token: 0x06006BDF RID: 27615 RVA: 0x001042B3 File Offset: 0x001024B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityAttachChangeNotify()
		{
		}

		// Token: 0x06006BE0 RID: 27616 RVA: 0x001042BC File Offset: 0x001024BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityAttachChangeNotify(EntityAttachChangeNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.relatePos_ = ((other.relatePos_ != null) ? other.relatePos_.Clone() : null);
			this.relateRot_ = ((other.relateRot_ != null) ? other.relateRot_.Clone() : null);
			this.targetType_ = other.targetType_;
			EntityAttachChangeNotify.TargetOneofCase targetCase = other.TargetCase;
			if (targetCase != EntityAttachChangeNotify.TargetOneofCase.AttachEntity)
			{
				if (targetCase == EntityAttachChangeNotify.TargetOneofCase.AttachPath)
				{
					this.AttachPath = other.AttachPath;
				}
			}
			else
			{
				this.AttachEntity = other.AttachEntity.Clone();
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006BE1 RID: 27617 RVA: 0x00104361 File Offset: 0x00102561
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityAttachChangeNotify Clone()
		{
			return new EntityAttachChangeNotify(this);
		}

		// Token: 0x17001475 RID: 5237
		// (get) Token: 0x06006BE2 RID: 27618 RVA: 0x00104369 File Offset: 0x00102569
		// (set) Token: 0x06006BE3 RID: 27619 RVA: 0x00104371 File Offset: 0x00102571
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

		// Token: 0x17001476 RID: 5238
		// (get) Token: 0x06006BE4 RID: 27620 RVA: 0x0010437A File Offset: 0x0010257A
		// (set) Token: 0x06006BE5 RID: 27621 RVA: 0x00104382 File Offset: 0x00102582
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector RelatePos
		{
			get
			{
				return this.relatePos_;
			}
			set
			{
				this.relatePos_ = value;
			}
		}

		// Token: 0x17001477 RID: 5239
		// (get) Token: 0x06006BE6 RID: 27622 RVA: 0x0010438B File Offset: 0x0010258B
		// (set) Token: 0x06006BE7 RID: 27623 RVA: 0x00104393 File Offset: 0x00102593
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Rotator RelateRot
		{
			get
			{
				return this.relateRot_;
			}
			set
			{
				this.relateRot_ = value;
			}
		}

		// Token: 0x17001478 RID: 5240
		// (get) Token: 0x06006BE8 RID: 27624 RVA: 0x0010439C File Offset: 0x0010259C
		// (set) Token: 0x06006BE9 RID: 27625 RVA: 0x001043A4 File Offset: 0x001025A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AttachTargetType TargetType
		{
			get
			{
				return this.targetType_;
			}
			set
			{
				this.targetType_ = value;
			}
		}

		// Token: 0x17001479 RID: 5241
		// (get) Token: 0x06006BEA RID: 27626 RVA: 0x001043AD File Offset: 0x001025AD
		// (set) Token: 0x06006BEB RID: 27627 RVA: 0x001043C5 File Offset: 0x001025C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AttachTargetEntityInfo AttachEntity
		{
			get
			{
				if (this.targetCase_ != EntityAttachChangeNotify.TargetOneofCase.AttachEntity)
				{
					return null;
				}
				return (AttachTargetEntityInfo)this.target_;
			}
			set
			{
				this.target_ = value;
				this.targetCase_ = ((value == null) ? EntityAttachChangeNotify.TargetOneofCase.None : EntityAttachChangeNotify.TargetOneofCase.AttachEntity);
			}
		}

		// Token: 0x1700147A RID: 5242
		// (get) Token: 0x06006BEC RID: 27628 RVA: 0x001043DB File Offset: 0x001025DB
		// (set) Token: 0x06006BED RID: 27629 RVA: 0x001043F6 File Offset: 0x001025F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string AttachPath
		{
			get
			{
				if (!this.HasAttachPath)
				{
					return "";
				}
				return (string)this.target_;
			}
			set
			{
				this.target_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
				this.targetCase_ = EntityAttachChangeNotify.TargetOneofCase.AttachPath;
			}
		}

		// Token: 0x1700147B RID: 5243
		// (get) Token: 0x06006BEE RID: 27630 RVA: 0x00104411 File Offset: 0x00102611
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasAttachPath
		{
			get
			{
				return this.targetCase_ == EntityAttachChangeNotify.TargetOneofCase.AttachPath;
			}
		}

		// Token: 0x06006BEF RID: 27631 RVA: 0x0010441D File Offset: 0x0010261D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearAttachPath()
		{
			if (this.HasAttachPath)
			{
				this.ClearTarget();
			}
		}

		// Token: 0x1700147C RID: 5244
		// (get) Token: 0x06006BF0 RID: 27632 RVA: 0x0010442D File Offset: 0x0010262D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityAttachChangeNotify.TargetOneofCase TargetCase
		{
			get
			{
				return this.targetCase_;
			}
		}

		// Token: 0x06006BF1 RID: 27633 RVA: 0x00104435 File Offset: 0x00102635
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearTarget()
		{
			this.targetCase_ = EntityAttachChangeNotify.TargetOneofCase.None;
			this.target_ = null;
		}

		// Token: 0x06006BF2 RID: 27634 RVA: 0x00104445 File Offset: 0x00102645
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityAttachChangeNotify);
		}

		// Token: 0x06006BF3 RID: 27635 RVA: 0x00104454 File Offset: 0x00102654
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityAttachChangeNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this.RelatePos, other.RelatePos) && object.Equals(this.RelateRot, other.RelateRot) && this.TargetType == other.TargetType && object.Equals(this.AttachEntity, other.AttachEntity) && !(this.AttachPath != other.AttachPath) && this.TargetCase == other.TargetCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006BF4 RID: 27636 RVA: 0x00104504 File Offset: 0x00102704
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.relatePos_ != null)
			{
				num ^= this.RelatePos.GetHashCode();
			}
			if (this.relateRot_ != null)
			{
				num ^= this.RelateRot.GetHashCode();
			}
			if (this.TargetType != AttachTargetType.AttachTargetNone)
			{
				num ^= this.TargetType.GetHashCode();
			}
			if (this.targetCase_ == EntityAttachChangeNotify.TargetOneofCase.AttachEntity)
			{
				num ^= this.AttachEntity.GetHashCode();
			}
			if (this.HasAttachPath)
			{
				num ^= this.AttachPath.GetHashCode();
			}
			num ^= (int)this.targetCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006BF5 RID: 27637 RVA: 0x001045C4 File Offset: 0x001027C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006BF6 RID: 27638 RVA: 0x001045D1 File Offset: 0x001027D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006BF7 RID: 27639 RVA: 0x001045DC File Offset: 0x001027DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.targetCase_ == EntityAttachChangeNotify.TargetOneofCase.AttachEntity)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.AttachEntity);
			}
			if (this.relateRot_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.RelateRot);
			}
			if (this.HasAttachPath)
			{
				output.WriteRawTag(98);
				output.WriteString(this.AttachPath);
			}
			if (this.TargetType != AttachTargetType.AttachTargetNone)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.TargetType);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(112);
				output.WriteInt64(this.EntityId);
			}
			if (this.relatePos_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.RelatePos);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006BF8 RID: 27640 RVA: 0x001046A8 File Offset: 0x001028A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.relatePos_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RelatePos);
			}
			if (this.relateRot_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RelateRot);
			}
			if (this.TargetType != AttachTargetType.AttachTargetNone)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.TargetType);
			}
			if (this.targetCase_ == EntityAttachChangeNotify.TargetOneofCase.AttachEntity)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AttachEntity);
			}
			if (this.HasAttachPath)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.AttachPath);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006BF9 RID: 27641 RVA: 0x00104760 File Offset: 0x00102960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityAttachChangeNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.relatePos_ != null)
			{
				if (this.relatePos_ == null)
				{
					this.RelatePos = new Vector();
				}
				this.RelatePos.MergeFrom(other.RelatePos);
			}
			if (other.relateRot_ != null)
			{
				if (this.relateRot_ == null)
				{
					this.RelateRot = new Rotator();
				}
				this.RelateRot.MergeFrom(other.RelateRot);
			}
			if (other.TargetType != AttachTargetType.AttachTargetNone)
			{
				this.TargetType = other.TargetType;
			}
			EntityAttachChangeNotify.TargetOneofCase targetCase = other.TargetCase;
			if (targetCase != EntityAttachChangeNotify.TargetOneofCase.AttachEntity)
			{
				if (targetCase == EntityAttachChangeNotify.TargetOneofCase.AttachPath)
				{
					this.AttachPath = other.AttachPath;
				}
			}
			else
			{
				if (this.AttachEntity == null)
				{
					this.AttachEntity = new AttachTargetEntityInfo();
				}
				this.AttachEntity.MergeFrom(other.AttachEntity);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006BFA RID: 27642 RVA: 0x0010484C File Offset: 0x00102A4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006BFB RID: 27643 RVA: 0x00104858 File Offset: 0x00102A58
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
				if (num <= 98U)
				{
					if (num == 10U)
					{
						AttachTargetEntityInfo attachTargetEntityInfo = new AttachTargetEntityInfo();
						if (this.targetCase_ == EntityAttachChangeNotify.TargetOneofCase.AttachEntity)
						{
							attachTargetEntityInfo.MergeFrom(this.AttachEntity);
						}
						input.ReadMessage(attachTargetEntityInfo);
						this.AttachEntity = attachTargetEntityInfo;
						continue;
					}
					if (num == 66U)
					{
						if (this.relateRot_ == null)
						{
							this.RelateRot = new Rotator();
						}
						input.ReadMessage(this.RelateRot);
						continue;
					}
					if (num == 98U)
					{
						this.AttachPath = input.ReadString();
						continue;
					}
				}
				else
				{
					if (num == 104U)
					{
						this.TargetType = (AttachTargetType)input.ReadEnum();
						continue;
					}
					if (num == 112U)
					{
						this.EntityId = input.ReadInt64();
						continue;
					}
					if (num == 122U)
					{
						if (this.relatePos_ == null)
						{
							this.RelatePos = new Vector();
						}
						input.ReadMessage(this.RelatePos);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003AB5 RID: 15029
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003AB6 RID: 15030
		public const int EntityIdFieldNumber = 14;

		// Token: 0x04003AB7 RID: 15031
		private long entityId_;

		// Token: 0x04003AB8 RID: 15032
		public const int RelatePosFieldNumber = 15;

		// Token: 0x04003AB9 RID: 15033
		private Vector relatePos_;

		// Token: 0x04003ABA RID: 15034
		public const int RelateRotFieldNumber = 8;

		// Token: 0x04003ABB RID: 15035
		private Rotator relateRot_;

		// Token: 0x04003ABC RID: 15036
		public const int TargetTypeFieldNumber = 13;

		// Token: 0x04003ABD RID: 15037
		private AttachTargetType targetType_;

		// Token: 0x04003ABE RID: 15038
		public const int AttachEntityFieldNumber = 1;

		// Token: 0x04003ABF RID: 15039
		public const int AttachPathFieldNumber = 12;

		// Token: 0x04003AC0 RID: 15040
		private object target_;

		// Token: 0x04003AC1 RID: 15041
		private EntityAttachChangeNotify.TargetOneofCase targetCase_;

		// Token: 0x0200176B RID: 5995
		public enum TargetOneofCase
		{
			// Token: 0x0400C615 RID: 50709
			None,
			// Token: 0x0400C616 RID: 50710
			AttachEntity,
			// Token: 0x0400C617 RID: 50711
			AttachPath = 12
		}
	}
}
