using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200045E RID: 1118
	[NetMessage(EMessageId.EntityBuffProducerOperateRequest)]
	public sealed class EntityBuffProducerOperateRequest : IMessage<EntityBuffProducerOperateRequest>, IMessage, IEquatable<EntityBuffProducerOperateRequest>, IDeepCloneable<EntityBuffProducerOperateRequest>, IBufferMessage
	{
		// Token: 0x06006B30 RID: 27440 RVA: 0x00103741 File Offset: 0x00101941
		[NullableContext(1)]
		public static EntityBuffProducerOperateRequest Create()
		{
			return new EntityBuffProducerOperateRequest();
		}

		// Token: 0x17001456 RID: 5206
		// (get) Token: 0x06006B31 RID: 27441 RVA: 0x00103748 File Offset: 0x00101948
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001457 RID: 5207
		// (get) Token: 0x06006B32 RID: 27442 RVA: 0x0010374B File Offset: 0x0010194B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityBuffProducerOperateRequest.Descriptor;
			}
		}

		// Token: 0x06006B33 RID: 27443 RVA: 0x00103752 File Offset: 0x00101952
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBuffProducerOperateRequest()
		{
		}

		// Token: 0x06006B34 RID: 27444 RVA: 0x0010375A File Offset: 0x0010195A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBuffProducerOperateRequest(EntityBuffProducerOperateRequest other) : this()
		{
			this.opType_ = other.opType_;
			this.opEntityId_ = other.opEntityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006B35 RID: 27445 RVA: 0x0010378B File Offset: 0x0010198B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBuffProducerOperateRequest Clone()
		{
			return new EntityBuffProducerOperateRequest(this);
		}

		// Token: 0x17001458 RID: 5208
		// (get) Token: 0x06006B36 RID: 27446 RVA: 0x00103793 File Offset: 0x00101993
		// (set) Token: 0x06006B37 RID: 27447 RVA: 0x0010379B File Offset: 0x0010199B
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

		// Token: 0x17001459 RID: 5209
		// (get) Token: 0x06006B38 RID: 27448 RVA: 0x001037A4 File Offset: 0x001019A4
		// (set) Token: 0x06006B39 RID: 27449 RVA: 0x001037AC File Offset: 0x001019AC
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

		// Token: 0x06006B3A RID: 27450 RVA: 0x001037B5 File Offset: 0x001019B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityBuffProducerOperateRequest);
		}

		// Token: 0x06006B3B RID: 27451 RVA: 0x001037C3 File Offset: 0x001019C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityBuffProducerOperateRequest other)
		{
			return other != null && (other == this || (this.OpType == other.OpType && this.OpEntityId == other.OpEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006B3C RID: 27452 RVA: 0x00103804 File Offset: 0x00101A04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x06006B3D RID: 27453 RVA: 0x00103862 File Offset: 0x00101A62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006B3E RID: 27454 RVA: 0x0010386F File Offset: 0x00101A6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006B3F RID: 27455 RVA: 0x00103878 File Offset: 0x00101A78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.OpEntityId != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.OpEntityId);
			}
			if (this.OpType != BuffOperateType.AddBuff)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.OpType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006B40 RID: 27456 RVA: 0x001038D4 File Offset: 0x00101AD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
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

		// Token: 0x06006B41 RID: 27457 RVA: 0x0010392C File Offset: 0x00101B2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityBuffProducerOperateRequest other)
		{
			if (other == null)
			{
				return;
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

		// Token: 0x06006B42 RID: 27458 RVA: 0x0010397C File Offset: 0x00101B7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006B43 RID: 27459 RVA: 0x00103988 File Offset: 0x00101B88
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
					if (num != 72U)
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
		}

		// Token: 0x04003AF5 RID: 15093
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003AF6 RID: 15094
		public const int OpTypeFieldNumber = 9;

		// Token: 0x04003AF7 RID: 15095
		private BuffOperateType opType_;

		// Token: 0x04003AF8 RID: 15096
		public const int OpEntityIdFieldNumber = 4;

		// Token: 0x04003AF9 RID: 15097
		private long opEntityId_;
	}
}
