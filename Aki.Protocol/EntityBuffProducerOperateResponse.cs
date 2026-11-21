using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200045F RID: 1119
	[NetMessage(EMessageId.EntityBuffProducerOperateResponse)]
	public sealed class EntityBuffProducerOperateResponse : IMessage<EntityBuffProducerOperateResponse>, IMessage, IEquatable<EntityBuffProducerOperateResponse>, IDeepCloneable<EntityBuffProducerOperateResponse>, IBufferMessage
	{
		// Token: 0x06006B44 RID: 27460 RVA: 0x001039E0 File Offset: 0x00101BE0
		[NullableContext(1)]
		public static EntityBuffProducerOperateResponse Create()
		{
			return new EntityBuffProducerOperateResponse();
		}

		// Token: 0x1700145A RID: 5210
		// (get) Token: 0x06006B45 RID: 27461 RVA: 0x001039E7 File Offset: 0x00101BE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700145B RID: 5211
		// (get) Token: 0x06006B46 RID: 27462 RVA: 0x001039EA File Offset: 0x00101BEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityBuffProducerOperateResponse.Descriptor;
			}
		}

		// Token: 0x06006B47 RID: 27463 RVA: 0x001039F1 File Offset: 0x00101BF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBuffProducerOperateResponse()
		{
		}

		// Token: 0x06006B48 RID: 27464 RVA: 0x001039F9 File Offset: 0x00101BF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBuffProducerOperateResponse(EntityBuffProducerOperateResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.opType_ = other.opType_;
			this.opEntityId_ = other.opEntityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006B49 RID: 27465 RVA: 0x00103A36 File Offset: 0x00101C36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBuffProducerOperateResponse Clone()
		{
			return new EntityBuffProducerOperateResponse(this);
		}

		// Token: 0x1700145C RID: 5212
		// (get) Token: 0x06006B4A RID: 27466 RVA: 0x00103A3E File Offset: 0x00101C3E
		// (set) Token: 0x06006B4B RID: 27467 RVA: 0x00103A46 File Offset: 0x00101C46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x1700145D RID: 5213
		// (get) Token: 0x06006B4C RID: 27468 RVA: 0x00103A4F File Offset: 0x00101C4F
		// (set) Token: 0x06006B4D RID: 27469 RVA: 0x00103A57 File Offset: 0x00101C57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffOperateType OpType
		{
			get
			{
				return this.opType_;
			}
			set
			{
				this.opType_ = value;
			}
		}

		// Token: 0x1700145E RID: 5214
		// (get) Token: 0x06006B4E RID: 27470 RVA: 0x00103A60 File Offset: 0x00101C60
		// (set) Token: 0x06006B4F RID: 27471 RVA: 0x00103A68 File Offset: 0x00101C68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long OpEntityId
		{
			get
			{
				return this.opEntityId_;
			}
			set
			{
				this.opEntityId_ = value;
			}
		}

		// Token: 0x06006B50 RID: 27472 RVA: 0x00103A71 File Offset: 0x00101C71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityBuffProducerOperateResponse);
		}

		// Token: 0x06006B51 RID: 27473 RVA: 0x00103A80 File Offset: 0x00101C80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityBuffProducerOperateResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.OpType == other.OpType && this.OpEntityId == other.OpEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006B52 RID: 27474 RVA: 0x00103ADC File Offset: 0x00101CDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.OpType != BuffOperateType.AddBuff)
			{
				num ^= this.OpType.GetHashCode();
			}
			if (this.OpEntityId != 0L)
			{
				num ^= this.OpEntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006B53 RID: 27475 RVA: 0x00103B59 File Offset: 0x00101D59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006B54 RID: 27476 RVA: 0x00103B66 File Offset: 0x00101D66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006B55 RID: 27477 RVA: 0x00103B70 File Offset: 0x00101D70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.OpEntityId != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.OpEntityId);
			}
			if (this.OpType != BuffOperateType.AddBuff)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.OpType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006B56 RID: 27478 RVA: 0x00103BE8 File Offset: 0x00101DE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.OpType != BuffOperateType.AddBuff)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.OpType);
			}
			if (this.OpEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.OpEntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006B57 RID: 27479 RVA: 0x00103C58 File Offset: 0x00101E58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityBuffProducerOperateResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.OpType != BuffOperateType.AddBuff)
			{
				this.OpType = other.OpType;
			}
			if (other.OpEntityId != 0L)
			{
				this.OpEntityId = other.OpEntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006B58 RID: 27480 RVA: 0x00103CBC File Offset: 0x00101EBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006B59 RID: 27481 RVA: 0x00103CC8 File Offset: 0x00101EC8
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
				if (num != 32U)
				{
					if (num != 56U)
					{
						if (num != 88U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.OpType = (BuffOperateType)input.ReadEnum();
						}
					}
					else
					{
						this.OpEntityId = input.ReadInt64();
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003AFA RID: 15098
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003AFB RID: 15099
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x04003AFC RID: 15100
		private ErrorCode errorCode_;

		// Token: 0x04003AFD RID: 15101
		public const int OpTypeFieldNumber = 11;

		// Token: 0x04003AFE RID: 15102
		private BuffOperateType opType_;

		// Token: 0x04003AFF RID: 15103
		public const int OpEntityIdFieldNumber = 7;

		// Token: 0x04003B00 RID: 15104
		private long opEntityId_;
	}
}
