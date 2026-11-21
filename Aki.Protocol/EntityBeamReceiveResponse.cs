using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200045A RID: 1114
	[NetMessage(EMessageId.EntityBeamReceiveResponse)]
	public sealed class EntityBeamReceiveResponse : IMessage<EntityBeamReceiveResponse>, IMessage, IEquatable<EntityBeamReceiveResponse>, IDeepCloneable<EntityBeamReceiveResponse>, IBufferMessage
	{
		// Token: 0x06006AE0 RID: 27360 RVA: 0x00102CB8 File Offset: 0x00100EB8
		[NullableContext(1)]
		public static EntityBeamReceiveResponse Create()
		{
			return new EntityBeamReceiveResponse();
		}

		// Token: 0x17001446 RID: 5190
		// (get) Token: 0x06006AE1 RID: 27361 RVA: 0x00102CBF File Offset: 0x00100EBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001447 RID: 5191
		// (get) Token: 0x06006AE2 RID: 27362 RVA: 0x00102CC2 File Offset: 0x00100EC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityBeamReceiveResponse.Descriptor;
			}
		}

		// Token: 0x06006AE3 RID: 27363 RVA: 0x00102CC9 File Offset: 0x00100EC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBeamReceiveResponse()
		{
		}

		// Token: 0x06006AE4 RID: 27364 RVA: 0x00102CD1 File Offset: 0x00100ED1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBeamReceiveResponse(EntityBeamReceiveResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.entityId_ = other.entityId_;
			this.receiveType_ = other.receiveType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006AE5 RID: 27365 RVA: 0x00102D0E File Offset: 0x00100F0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBeamReceiveResponse Clone()
		{
			return new EntityBeamReceiveResponse(this);
		}

		// Token: 0x17001448 RID: 5192
		// (get) Token: 0x06006AE6 RID: 27366 RVA: 0x00102D16 File Offset: 0x00100F16
		// (set) Token: 0x06006AE7 RID: 27367 RVA: 0x00102D1E File Offset: 0x00100F1E
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

		// Token: 0x17001449 RID: 5193
		// (get) Token: 0x06006AE8 RID: 27368 RVA: 0x00102D27 File Offset: 0x00100F27
		// (set) Token: 0x06006AE9 RID: 27369 RVA: 0x00102D2F File Offset: 0x00100F2F
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

		// Token: 0x1700144A RID: 5194
		// (get) Token: 0x06006AEA RID: 27370 RVA: 0x00102D38 File Offset: 0x00100F38
		// (set) Token: 0x06006AEB RID: 27371 RVA: 0x00102D40 File Offset: 0x00100F40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBeamReceiveType ReceiveType
		{
			get
			{
				return this.receiveType_;
			}
			set
			{
				this.receiveType_ = value;
			}
		}

		// Token: 0x06006AEC RID: 27372 RVA: 0x00102D49 File Offset: 0x00100F49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityBeamReceiveResponse);
		}

		// Token: 0x06006AED RID: 27373 RVA: 0x00102D58 File Offset: 0x00100F58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityBeamReceiveResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.EntityId == other.EntityId && this.ReceiveType == other.ReceiveType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006AEE RID: 27374 RVA: 0x00102DB4 File Offset: 0x00100FB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.ReceiveType != EntityBeamReceiveType.BeginAction)
			{
				num ^= this.ReceiveType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006AEF RID: 27375 RVA: 0x00102E31 File Offset: 0x00101031
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006AF0 RID: 27376 RVA: 0x00102E3E File Offset: 0x0010103E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006AF1 RID: 27377 RVA: 0x00102E48 File Offset: 0x00101048
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ReceiveType != EntityBeamReceiveType.BeginAction)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ReceiveType);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(112);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006AF2 RID: 27378 RVA: 0x00102EC0 File Offset: 0x001010C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.ReceiveType != EntityBeamReceiveType.BeginAction)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ReceiveType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006AF3 RID: 27379 RVA: 0x00102F30 File Offset: 0x00101130
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityBeamReceiveResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.ReceiveType != EntityBeamReceiveType.BeginAction)
			{
				this.ReceiveType = other.ReceiveType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006AF4 RID: 27380 RVA: 0x00102F94 File Offset: 0x00101194
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006AF5 RID: 27381 RVA: 0x00102FA0 File Offset: 0x001011A0
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
				if (num != 72U)
				{
					if (num != 80U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.EntityId = input.ReadInt64();
						}
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.ReceiveType = (EntityBeamReceiveType)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003ADF RID: 15071
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003AE0 RID: 15072
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x04003AE1 RID: 15073
		private ErrorCode errorCode_;

		// Token: 0x04003AE2 RID: 15074
		public const int EntityIdFieldNumber = 14;

		// Token: 0x04003AE3 RID: 15075
		private long entityId_;

		// Token: 0x04003AE4 RID: 15076
		public const int ReceiveTypeFieldNumber = 9;

		// Token: 0x04003AE5 RID: 15077
		private EntityBeamReceiveType receiveType_;
	}
}
