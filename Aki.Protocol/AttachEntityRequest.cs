using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000121 RID: 289
	[NetMessage(EMessageId.AttachEntityRequest)]
	public sealed class AttachEntityRequest : IMessage<AttachEntityRequest>, IMessage, IEquatable<AttachEntityRequest>, IDeepCloneable<AttachEntityRequest>, IBufferMessage
	{
		// Token: 0x0600272C RID: 10028 RVA: 0x00067F59 File Offset: 0x00066159
		[NullableContext(1)]
		public static AttachEntityRequest Create()
		{
			return new AttachEntityRequest();
		}

		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x0600272D RID: 10029 RVA: 0x00067F60 File Offset: 0x00066160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x0600272E RID: 10030 RVA: 0x00067F63 File Offset: 0x00066163
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AttachEntityRequest.Descriptor;
			}
		}

		// Token: 0x0600272F RID: 10031 RVA: 0x00067F6A File Offset: 0x0006616A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AttachEntityRequest()
		{
		}

		// Token: 0x06002730 RID: 10032 RVA: 0x00067F74 File Offset: 0x00066174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AttachEntityRequest(AttachEntityRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.relatePos_ = ((other.relatePos_ != null) ? other.relatePos_.Clone() : null);
			this.relateRot_ = ((other.relateRot_ != null) ? other.relateRot_.Clone() : null);
			this.targetType_ = other.targetType_;
			AttachEntityRequest.TargetOneofCase targetCase = other.TargetCase;
			if (targetCase != AttachEntityRequest.TargetOneofCase.AttachPath)
			{
				if (targetCase == AttachEntityRequest.TargetOneofCase.AttachEntity)
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

		// Token: 0x06002731 RID: 10033 RVA: 0x00068018 File Offset: 0x00066218
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AttachEntityRequest Clone()
		{
			return new AttachEntityRequest(this);
		}

		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x06002732 RID: 10034 RVA: 0x00068020 File Offset: 0x00066220
		// (set) Token: 0x06002733 RID: 10035 RVA: 0x00068028 File Offset: 0x00066228
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

		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x06002734 RID: 10036 RVA: 0x00068031 File Offset: 0x00066231
		// (set) Token: 0x06002735 RID: 10037 RVA: 0x00068039 File Offset: 0x00066239
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

		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x06002736 RID: 10038 RVA: 0x00068042 File Offset: 0x00066242
		// (set) Token: 0x06002737 RID: 10039 RVA: 0x0006804A File Offset: 0x0006624A
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

		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x06002738 RID: 10040 RVA: 0x00068053 File Offset: 0x00066253
		// (set) Token: 0x06002739 RID: 10041 RVA: 0x0006805B File Offset: 0x0006625B
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

		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x0600273A RID: 10042 RVA: 0x00068064 File Offset: 0x00066264
		// (set) Token: 0x0600273B RID: 10043 RVA: 0x0006807D File Offset: 0x0006627D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AttachTargetEntityInfo AttachEntity
		{
			get
			{
				if (this.targetCase_ != AttachEntityRequest.TargetOneofCase.AttachEntity)
				{
					return null;
				}
				return (AttachTargetEntityInfo)this.target_;
			}
			set
			{
				this.target_ = value;
				this.targetCase_ = ((value == null) ? AttachEntityRequest.TargetOneofCase.None : AttachEntityRequest.TargetOneofCase.AttachEntity);
			}
		}

		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x0600273C RID: 10044 RVA: 0x00068094 File Offset: 0x00066294
		// (set) Token: 0x0600273D RID: 10045 RVA: 0x000680AF File Offset: 0x000662AF
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
				this.targetCase_ = AttachEntityRequest.TargetOneofCase.AttachPath;
			}
		}

		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x0600273E RID: 10046 RVA: 0x000680CA File Offset: 0x000662CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasAttachPath
		{
			get
			{
				return this.targetCase_ == AttachEntityRequest.TargetOneofCase.AttachPath;
			}
		}

		// Token: 0x0600273F RID: 10047 RVA: 0x000680D6 File Offset: 0x000662D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearAttachPath()
		{
			if (this.HasAttachPath)
			{
				this.ClearTarget();
			}
		}

		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x06002740 RID: 10048 RVA: 0x000680E6 File Offset: 0x000662E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AttachEntityRequest.TargetOneofCase TargetCase
		{
			get
			{
				return this.targetCase_;
			}
		}

		// Token: 0x06002741 RID: 10049 RVA: 0x000680EE File Offset: 0x000662EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearTarget()
		{
			this.targetCase_ = AttachEntityRequest.TargetOneofCase.None;
			this.target_ = null;
		}

		// Token: 0x06002742 RID: 10050 RVA: 0x000680FE File Offset: 0x000662FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AttachEntityRequest);
		}

		// Token: 0x06002743 RID: 10051 RVA: 0x0006810C File Offset: 0x0006630C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AttachEntityRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this.RelatePos, other.RelatePos) && object.Equals(this.RelateRot, other.RelateRot) && this.TargetType == other.TargetType && object.Equals(this.AttachEntity, other.AttachEntity) && !(this.AttachPath != other.AttachPath) && this.TargetCase == other.TargetCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002744 RID: 10052 RVA: 0x000681BC File Offset: 0x000663BC
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
			if (this.targetCase_ == AttachEntityRequest.TargetOneofCase.AttachEntity)
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

		// Token: 0x06002745 RID: 10053 RVA: 0x0006827D File Offset: 0x0006647D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002746 RID: 10054 RVA: 0x0006828A File Offset: 0x0006648A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002747 RID: 10055 RVA: 0x00068294 File Offset: 0x00066494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.relatePos_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.RelatePos);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.EntityId);
			}
			if (this.TargetType != AttachTargetType.AttachTargetNone)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.TargetType);
			}
			if (this.HasAttachPath)
			{
				output.WriteRawTag(90);
				output.WriteString(this.AttachPath);
			}
			if (this.targetCase_ == AttachEntityRequest.TargetOneofCase.AttachEntity)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.AttachEntity);
			}
			if (this.relateRot_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.RelateRot);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002748 RID: 10056 RVA: 0x00068360 File Offset: 0x00066560
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
			if (this.targetCase_ == AttachEntityRequest.TargetOneofCase.AttachEntity)
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

		// Token: 0x06002749 RID: 10057 RVA: 0x00068418 File Offset: 0x00066618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AttachEntityRequest other)
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
			AttachEntityRequest.TargetOneofCase targetCase = other.TargetCase;
			if (targetCase != AttachEntityRequest.TargetOneofCase.AttachPath)
			{
				if (targetCase == AttachEntityRequest.TargetOneofCase.AttachEntity)
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

		// Token: 0x0600274A RID: 10058 RVA: 0x00068503 File Offset: 0x00066703
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600274B RID: 10059 RVA: 0x0006850C File Offset: 0x0006670C
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
				if (num <= 40U)
				{
					if (num == 26U)
					{
						if (this.relatePos_ == null)
						{
							this.RelatePos = new Vector();
						}
						input.ReadMessage(this.RelatePos);
						continue;
					}
					if (num == 32U)
					{
						this.EntityId = input.ReadInt64();
						continue;
					}
					if (num == 40U)
					{
						this.TargetType = (AttachTargetType)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 90U)
					{
						this.AttachPath = input.ReadString();
						continue;
					}
					if (num == 114U)
					{
						AttachTargetEntityInfo attachTargetEntityInfo = new AttachTargetEntityInfo();
						if (this.targetCase_ == AttachEntityRequest.TargetOneofCase.AttachEntity)
						{
							attachTargetEntityInfo.MergeFrom(this.AttachEntity);
						}
						input.ReadMessage(attachTargetEntityInfo);
						this.AttachEntity = attachTargetEntityInfo;
						continue;
					}
					if (num == 122U)
					{
						if (this.relateRot_ == null)
						{
							this.RelateRot = new Rotator();
						}
						input.ReadMessage(this.RelateRot);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400269E RID: 9886
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400269F RID: 9887
		public const int EntityIdFieldNumber = 4;

		// Token: 0x040026A0 RID: 9888
		private long entityId_;

		// Token: 0x040026A1 RID: 9889
		public const int RelatePosFieldNumber = 3;

		// Token: 0x040026A2 RID: 9890
		private Vector relatePos_;

		// Token: 0x040026A3 RID: 9891
		public const int RelateRotFieldNumber = 15;

		// Token: 0x040026A4 RID: 9892
		private Rotator relateRot_;

		// Token: 0x040026A5 RID: 9893
		public const int TargetTypeFieldNumber = 5;

		// Token: 0x040026A6 RID: 9894
		private AttachTargetType targetType_;

		// Token: 0x040026A7 RID: 9895
		public const int AttachEntityFieldNumber = 14;

		// Token: 0x040026A8 RID: 9896
		public const int AttachPathFieldNumber = 11;

		// Token: 0x040026A9 RID: 9897
		private object target_;

		// Token: 0x040026AA RID: 9898
		private AttachEntityRequest.TargetOneofCase targetCase_;

		// Token: 0x0200176A RID: 5994
		public enum TargetOneofCase
		{
			// Token: 0x0400CA5B RID: 51803
			None,
			// Token: 0x0400CA5C RID: 51804
			AttachEntity = 14,
			// Token: 0x0400CA5D RID: 51805
			AttachPath = 11
		}
	}
}
