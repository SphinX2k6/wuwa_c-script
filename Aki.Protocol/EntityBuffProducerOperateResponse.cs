using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000476 RID: 1142
	[NetMessage(EMessageId.EntityBuffProducerOperateResponse)]
	public sealed class EntityBuffProducerOperateResponse : IMessage<EntityBuffProducerOperateResponse>, IMessage, IEquatable<EntityBuffProducerOperateResponse>, IDeepCloneable<EntityBuffProducerOperateResponse>, IBufferMessage
	{
		// Token: 0x06006CD2 RID: 27858 RVA: 0x00106A54 File Offset: 0x00104C54
		[NullableContext(1)]
		public static EntityBuffProducerOperateResponse Create()
		{
			return new EntityBuffProducerOperateResponse();
		}

		// Token: 0x170014AE RID: 5294
		// (get) Token: 0x06006CD3 RID: 27859 RVA: 0x00106A5B File Offset: 0x00104C5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170014AF RID: 5295
		// (get) Token: 0x06006CD4 RID: 27860 RVA: 0x00106A5E File Offset: 0x00104C5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityBuffProducerOperateResponse.Descriptor;
			}
		}

		// Token: 0x06006CD5 RID: 27861 RVA: 0x00106A65 File Offset: 0x00104C65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBuffProducerOperateResponse()
		{
		}

		// Token: 0x06006CD6 RID: 27862 RVA: 0x00106A6D File Offset: 0x00104C6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBuffProducerOperateResponse(EntityBuffProducerOperateResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.opType_ = other.opType_;
			this.opEntityId_ = other.opEntityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006CD7 RID: 27863 RVA: 0x00106AAA File Offset: 0x00104CAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBuffProducerOperateResponse Clone()
		{
			return new EntityBuffProducerOperateResponse(this);
		}

		// Token: 0x170014B0 RID: 5296
		// (get) Token: 0x06006CD8 RID: 27864 RVA: 0x00106AB2 File Offset: 0x00104CB2
		// (set) Token: 0x06006CD9 RID: 27865 RVA: 0x00106ABA File Offset: 0x00104CBA
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

		// Token: 0x170014B1 RID: 5297
		// (get) Token: 0x06006CDA RID: 27866 RVA: 0x00106AC3 File Offset: 0x00104CC3
		// (set) Token: 0x06006CDB RID: 27867 RVA: 0x00106ACB File Offset: 0x00104CCB
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

		// Token: 0x170014B2 RID: 5298
		// (get) Token: 0x06006CDC RID: 27868 RVA: 0x00106AD4 File Offset: 0x00104CD4
		// (set) Token: 0x06006CDD RID: 27869 RVA: 0x00106ADC File Offset: 0x00104CDC
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

		// Token: 0x06006CDE RID: 27870 RVA: 0x00106AE5 File Offset: 0x00104CE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityBuffProducerOperateResponse);
		}

		// Token: 0x06006CDF RID: 27871 RVA: 0x00106AF4 File Offset: 0x00104CF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityBuffProducerOperateResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.OpType == other.OpType && this.OpEntityId == other.OpEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006CE0 RID: 27872 RVA: 0x00106B50 File Offset: 0x00104D50
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

		// Token: 0x06006CE1 RID: 27873 RVA: 0x00106BCD File Offset: 0x00104DCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006CE2 RID: 27874 RVA: 0x00106BDA File Offset: 0x00104DDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006CE3 RID: 27875 RVA: 0x00106BE4 File Offset: 0x00104DE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.OpEntityId != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.OpEntityId);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.OpType != BuffOperateType.AddBuff)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.OpType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006CE4 RID: 27876 RVA: 0x00106C5C File Offset: 0x00104E5C
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

		// Token: 0x06006CE5 RID: 27877 RVA: 0x00106CCC File Offset: 0x00104ECC
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

		// Token: 0x06006CE6 RID: 27878 RVA: 0x00106D30 File Offset: 0x00104F30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006CE7 RID: 27879 RVA: 0x00106D3C File Offset: 0x00104F3C
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
				if (num != 64U)
				{
					if (num != 112U)
					{
						if (num != 120U)
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
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.OpEntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04003B0C RID: 15116
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003B0D RID: 15117
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x04003B0E RID: 15118
		private ErrorCode errorCode_;

		// Token: 0x04003B0F RID: 15119
		public const int OpTypeFieldNumber = 15;

		// Token: 0x04003B10 RID: 15120
		private BuffOperateType opType_;

		// Token: 0x04003B11 RID: 15121
		public const int OpEntityIdFieldNumber = 8;

		// Token: 0x04003B12 RID: 15122
		private long opEntityId_;
	}
}
