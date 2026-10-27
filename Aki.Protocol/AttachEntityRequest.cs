using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200011F RID: 287
	[NetMessage(EMessageId.AttachEntityRequest)]
	public sealed class AttachEntityRequest : IMessage<AttachEntityRequest>, IMessage, IEquatable<AttachEntityRequest>, IDeepCloneable<AttachEntityRequest>, IBufferMessage
	{
		// Token: 0x060026CD RID: 9933 RVA: 0x00066F35 File Offset: 0x00065135
		[NullableContext(1)]
		public static AttachEntityRequest Create()
		{
			return new AttachEntityRequest();
		}

		// Token: 0x17000577 RID: 1399
		// (get) Token: 0x060026CE RID: 9934 RVA: 0x00066F3C File Offset: 0x0006513C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000578 RID: 1400
		// (get) Token: 0x060026CF RID: 9935 RVA: 0x00066F3F File Offset: 0x0006513F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AttachEntityRequest.Descriptor;
			}
		}

		// Token: 0x060026D0 RID: 9936 RVA: 0x00066F46 File Offset: 0x00065146
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AttachEntityRequest()
		{
		}

		// Token: 0x060026D1 RID: 9937 RVA: 0x00066F50 File Offset: 0x00065150
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

		// Token: 0x060026D2 RID: 9938 RVA: 0x00066FF3 File Offset: 0x000651F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AttachEntityRequest Clone()
		{
			return new AttachEntityRequest(this);
		}

		// Token: 0x17000579 RID: 1401
		// (get) Token: 0x060026D3 RID: 9939 RVA: 0x00066FFB File Offset: 0x000651FB
		// (set) Token: 0x060026D4 RID: 9940 RVA: 0x00067003 File Offset: 0x00065203
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

		// Token: 0x1700057A RID: 1402
		// (get) Token: 0x060026D5 RID: 9941 RVA: 0x0006700C File Offset: 0x0006520C
		// (set) Token: 0x060026D6 RID: 9942 RVA: 0x00067014 File Offset: 0x00065214
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

		// Token: 0x1700057B RID: 1403
		// (get) Token: 0x060026D7 RID: 9943 RVA: 0x0006701D File Offset: 0x0006521D
		// (set) Token: 0x060026D8 RID: 9944 RVA: 0x00067025 File Offset: 0x00065225
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

		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x060026D9 RID: 9945 RVA: 0x0006702E File Offset: 0x0006522E
		// (set) Token: 0x060026DA RID: 9946 RVA: 0x00067036 File Offset: 0x00065236
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

		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x060026DB RID: 9947 RVA: 0x0006703F File Offset: 0x0006523F
		// (set) Token: 0x060026DC RID: 9948 RVA: 0x00067058 File Offset: 0x00065258
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

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x060026DD RID: 9949 RVA: 0x0006706F File Offset: 0x0006526F
		// (set) Token: 0x060026DE RID: 9950 RVA: 0x0006708A File Offset: 0x0006528A
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

		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x060026DF RID: 9951 RVA: 0x000670A4 File Offset: 0x000652A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasAttachPath
		{
			get
			{
				return this.targetCase_ == AttachEntityRequest.TargetOneofCase.AttachPath;
			}
		}

		// Token: 0x060026E0 RID: 9952 RVA: 0x000670AF File Offset: 0x000652AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearAttachPath()
		{
			if (this.HasAttachPath)
			{
				this.ClearTarget();
			}
		}

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x060026E1 RID: 9953 RVA: 0x000670BF File Offset: 0x000652BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AttachEntityRequest.TargetOneofCase TargetCase
		{
			get
			{
				return this.targetCase_;
			}
		}

		// Token: 0x060026E2 RID: 9954 RVA: 0x000670C7 File Offset: 0x000652C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearTarget()
		{
			this.targetCase_ = AttachEntityRequest.TargetOneofCase.None;
			this.target_ = null;
		}

		// Token: 0x060026E3 RID: 9955 RVA: 0x000670D7 File Offset: 0x000652D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AttachEntityRequest);
		}

		// Token: 0x060026E4 RID: 9956 RVA: 0x000670E8 File Offset: 0x000652E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AttachEntityRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this.RelatePos, other.RelatePos) && object.Equals(this.RelateRot, other.RelateRot) && this.TargetType == other.TargetType && object.Equals(this.AttachEntity, other.AttachEntity) && !(this.AttachPath != other.AttachPath) && this.TargetCase == other.TargetCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060026E5 RID: 9957 RVA: 0x00067198 File Offset: 0x00065398
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

		// Token: 0x060026E6 RID: 9958 RVA: 0x00067259 File Offset: 0x00065459
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060026E7 RID: 9959 RVA: 0x00067266 File Offset: 0x00065466
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060026E8 RID: 9960 RVA: 0x00067270 File Offset: 0x00065470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.relateRot_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.RelateRot);
			}
			if (this.relatePos_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.RelatePos);
			}
			if (this.TargetType != AttachTargetType.AttachTargetNone)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.TargetType);
			}
			if (this.HasAttachPath)
			{
				output.WriteRawTag(58);
				output.WriteString(this.AttachPath);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(104);
				output.WriteInt64(this.EntityId);
			}
			if (this.targetCase_ == AttachEntityRequest.TargetOneofCase.AttachEntity)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.AttachEntity);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060026E9 RID: 9961 RVA: 0x0006733C File Offset: 0x0006553C
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

		// Token: 0x060026EA RID: 9962 RVA: 0x000673F4 File Offset: 0x000655F4
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

		// Token: 0x060026EB RID: 9963 RVA: 0x000674DE File Offset: 0x000656DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060026EC RID: 9964 RVA: 0x000674E8 File Offset: 0x000656E8
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
					if (num == 26U)
					{
						if (this.relateRot_ == null)
						{
							this.RelateRot = new Rotator();
						}
						input.ReadMessage(this.RelateRot);
						continue;
					}
					if (num == 34U)
					{
						if (this.relatePos_ == null)
						{
							this.RelatePos = new Vector();
						}
						input.ReadMessage(this.RelatePos);
						continue;
					}
					if (num == 48U)
					{
						this.TargetType = (AttachTargetType)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 58U)
					{
						this.AttachPath = input.ReadString();
						continue;
					}
					if (num == 104U)
					{
						this.EntityId = input.ReadInt64();
						continue;
					}
					if (num == 122U)
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
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002633 RID: 9779
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002634 RID: 9780
		public const int EntityIdFieldNumber = 13;

		// Token: 0x04002635 RID: 9781
		private long entityId_;

		// Token: 0x04002636 RID: 9782
		public const int RelatePosFieldNumber = 4;

		// Token: 0x04002637 RID: 9783
		private Vector relatePos_;

		// Token: 0x04002638 RID: 9784
		public const int RelateRotFieldNumber = 3;

		// Token: 0x04002639 RID: 9785
		private Rotator relateRot_;

		// Token: 0x0400263A RID: 9786
		public const int TargetTypeFieldNumber = 6;

		// Token: 0x0400263B RID: 9787
		private AttachTargetType targetType_;

		// Token: 0x0400263C RID: 9788
		public const int AttachEntityFieldNumber = 15;

		// Token: 0x0400263D RID: 9789
		public const int AttachPathFieldNumber = 7;

		// Token: 0x0400263E RID: 9790
		private object target_;

		// Token: 0x0400263F RID: 9791
		private AttachEntityRequest.TargetOneofCase targetCase_;

		// Token: 0x020016EE RID: 5870
		public enum TargetOneofCase
		{
			// Token: 0x0400C52A RID: 50474
			None,
			// Token: 0x0400C52B RID: 50475
			AttachEntity = 15,
			// Token: 0x0400C52C RID: 50476
			AttachPath = 7
		}
	}
}
