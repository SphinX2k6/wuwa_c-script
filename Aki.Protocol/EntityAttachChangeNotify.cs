using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000454 RID: 1108
	[NetMessage(EMessageId.EntityAttachChangeNotify)]
	public sealed class EntityAttachChangeNotify : IMessage<EntityAttachChangeNotify>, IMessage, IEquatable<EntityAttachChangeNotify>, IDeepCloneable<EntityAttachChangeNotify>, IBufferMessage
	{
		// Token: 0x06006A4E RID: 27214 RVA: 0x00101232 File Offset: 0x000FF432
		[NullableContext(1)]
		public static EntityAttachChangeNotify Create()
		{
			return new EntityAttachChangeNotify();
		}

		// Token: 0x1700141F RID: 5151
		// (get) Token: 0x06006A4F RID: 27215 RVA: 0x00101239 File Offset: 0x000FF439
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001420 RID: 5152
		// (get) Token: 0x06006A50 RID: 27216 RVA: 0x0010123C File Offset: 0x000FF43C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityAttachChangeNotify.Descriptor;
			}
		}

		// Token: 0x06006A51 RID: 27217 RVA: 0x00101243 File Offset: 0x000FF443
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityAttachChangeNotify()
		{
		}

		// Token: 0x06006A52 RID: 27218 RVA: 0x0010124C File Offset: 0x000FF44C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityAttachChangeNotify(EntityAttachChangeNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.relatePos_ = ((other.relatePos_ != null) ? other.relatePos_.Clone() : null);
			this.relateRot_ = ((other.relateRot_ != null) ? other.relateRot_.Clone() : null);
			this.targetType_ = other.targetType_;
			EntityAttachChangeNotify.TargetOneofCase targetCase = other.TargetCase;
			if (targetCase != EntityAttachChangeNotify.TargetOneofCase.AttachPath)
			{
				if (targetCase == EntityAttachChangeNotify.TargetOneofCase.AttachEntity)
				{
					this.AttachEntity = other.AttachEntity.Clone();
				}
			}
			else
			{
				this.AttachPath = other.AttachPath;
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006A53 RID: 27219 RVA: 0x001012EE File Offset: 0x000FF4EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityAttachChangeNotify Clone()
		{
			return new EntityAttachChangeNotify(this);
		}

		// Token: 0x17001421 RID: 5153
		// (get) Token: 0x06006A54 RID: 27220 RVA: 0x001012F6 File Offset: 0x000FF4F6
		// (set) Token: 0x06006A55 RID: 27221 RVA: 0x001012FE File Offset: 0x000FF4FE
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

		// Token: 0x17001422 RID: 5154
		// (get) Token: 0x06006A56 RID: 27222 RVA: 0x00101307 File Offset: 0x000FF507
		// (set) Token: 0x06006A57 RID: 27223 RVA: 0x0010130F File Offset: 0x000FF50F
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

		// Token: 0x17001423 RID: 5155
		// (get) Token: 0x06006A58 RID: 27224 RVA: 0x00101318 File Offset: 0x000FF518
		// (set) Token: 0x06006A59 RID: 27225 RVA: 0x00101320 File Offset: 0x000FF520
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

		// Token: 0x17001424 RID: 5156
		// (get) Token: 0x06006A5A RID: 27226 RVA: 0x00101329 File Offset: 0x000FF529
		// (set) Token: 0x06006A5B RID: 27227 RVA: 0x00101331 File Offset: 0x000FF531
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

		// Token: 0x17001425 RID: 5157
		// (get) Token: 0x06006A5C RID: 27228 RVA: 0x0010133A File Offset: 0x000FF53A
		// (set) Token: 0x06006A5D RID: 27229 RVA: 0x00101352 File Offset: 0x000FF552
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

		// Token: 0x17001426 RID: 5158
		// (get) Token: 0x06006A5E RID: 27230 RVA: 0x00101368 File Offset: 0x000FF568
		// (set) Token: 0x06006A5F RID: 27231 RVA: 0x00101383 File Offset: 0x000FF583
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

		// Token: 0x17001427 RID: 5159
		// (get) Token: 0x06006A60 RID: 27232 RVA: 0x0010139D File Offset: 0x000FF59D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasAttachPath
		{
			get
			{
				return this.targetCase_ == EntityAttachChangeNotify.TargetOneofCase.AttachPath;
			}
		}

		// Token: 0x06006A61 RID: 27233 RVA: 0x001013A8 File Offset: 0x000FF5A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearAttachPath()
		{
			if (this.HasAttachPath)
			{
				this.ClearTarget();
			}
		}

		// Token: 0x17001428 RID: 5160
		// (get) Token: 0x06006A62 RID: 27234 RVA: 0x001013B8 File Offset: 0x000FF5B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityAttachChangeNotify.TargetOneofCase TargetCase
		{
			get
			{
				return this.targetCase_;
			}
		}

		// Token: 0x06006A63 RID: 27235 RVA: 0x001013C0 File Offset: 0x000FF5C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearTarget()
		{
			this.targetCase_ = EntityAttachChangeNotify.TargetOneofCase.None;
			this.target_ = null;
		}

		// Token: 0x06006A64 RID: 27236 RVA: 0x001013D0 File Offset: 0x000FF5D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityAttachChangeNotify);
		}

		// Token: 0x06006A65 RID: 27237 RVA: 0x001013E0 File Offset: 0x000FF5E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityAttachChangeNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this.RelatePos, other.RelatePos) && object.Equals(this.RelateRot, other.RelateRot) && this.TargetType == other.TargetType && object.Equals(this.AttachEntity, other.AttachEntity) && !(this.AttachPath != other.AttachPath) && this.TargetCase == other.TargetCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006A66 RID: 27238 RVA: 0x00101490 File Offset: 0x000FF690
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

		// Token: 0x06006A67 RID: 27239 RVA: 0x00101550 File Offset: 0x000FF750
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006A68 RID: 27240 RVA: 0x0010155D File Offset: 0x000FF75D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006A69 RID: 27241 RVA: 0x00101568 File Offset: 0x000FF768
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HasAttachPath)
			{
				output.WriteRawTag(10);
				output.WriteString(this.AttachPath);
			}
			if (this.targetCase_ == EntityAttachChangeNotify.TargetOneofCase.AttachEntity)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.AttachEntity);
			}
			if (this.relateRot_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.RelateRot);
			}
			if (this.TargetType != AttachTargetType.AttachTargetNone)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.TargetType);
			}
			if (this.relatePos_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.RelatePos);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(104);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006A6A RID: 27242 RVA: 0x00101634 File Offset: 0x000FF834
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

		// Token: 0x06006A6B RID: 27243 RVA: 0x001016EC File Offset: 0x000FF8EC
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
			if (targetCase != EntityAttachChangeNotify.TargetOneofCase.AttachPath)
			{
				if (targetCase == EntityAttachChangeNotify.TargetOneofCase.AttachEntity)
				{
					if (this.AttachEntity == null)
					{
						this.AttachEntity = new AttachTargetEntityInfo();
					}
					this.AttachEntity.MergeFrom(other.AttachEntity);
				}
			}
			else
			{
				this.AttachPath = other.AttachPath;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006A6C RID: 27244 RVA: 0x001017D5 File Offset: 0x000FF9D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006A6D RID: 27245 RVA: 0x001017E0 File Offset: 0x000FF9E0
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
				if (num <= 42U)
				{
					if (num == 10U)
					{
						this.AttachPath = input.ReadString();
						continue;
					}
					if (num == 26U)
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
					if (num == 42U)
					{
						if (this.relateRot_ == null)
						{
							this.RelateRot = new Rotator();
						}
						input.ReadMessage(this.RelateRot);
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.TargetType = (AttachTargetType)input.ReadEnum();
						continue;
					}
					if (num == 90U)
					{
						if (this.relatePos_ == null)
						{
							this.RelatePos = new Vector();
						}
						input.ReadMessage(this.RelatePos);
						continue;
					}
					if (num == 104U)
					{
						this.EntityId = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003AA3 RID: 15011
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003AA4 RID: 15012
		public const int EntityIdFieldNumber = 13;

		// Token: 0x04003AA5 RID: 15013
		private long entityId_;

		// Token: 0x04003AA6 RID: 15014
		public const int RelatePosFieldNumber = 11;

		// Token: 0x04003AA7 RID: 15015
		private Vector relatePos_;

		// Token: 0x04003AA8 RID: 15016
		public const int RelateRotFieldNumber = 5;

		// Token: 0x04003AA9 RID: 15017
		private Rotator relateRot_;

		// Token: 0x04003AAA RID: 15018
		public const int TargetTypeFieldNumber = 10;

		// Token: 0x04003AAB RID: 15019
		private AttachTargetType targetType_;

		// Token: 0x04003AAC RID: 15020
		public const int AttachEntityFieldNumber = 3;

		// Token: 0x04003AAD RID: 15021
		public const int AttachPathFieldNumber = 1;

		// Token: 0x04003AAE RID: 15022
		private object target_;

		// Token: 0x04003AAF RID: 15023
		private EntityAttachChangeNotify.TargetOneofCase targetCase_;

		// Token: 0x020017E3 RID: 6115
		public enum TargetOneofCase
		{
			// Token: 0x0400CB40 RID: 52032
			None,
			// Token: 0x0400CB41 RID: 52033
			AttachEntity = 3,
			// Token: 0x0400CB42 RID: 52034
			AttachPath = 1
		}
	}
}
