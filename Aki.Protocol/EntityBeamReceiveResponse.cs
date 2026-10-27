using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000471 RID: 1137
	[NetMessage(EMessageId.EntityBeamReceiveResponse)]
	public sealed class EntityBeamReceiveResponse : IMessage<EntityBeamReceiveResponse>, IMessage, IEquatable<EntityBeamReceiveResponse>, IDeepCloneable<EntityBeamReceiveResponse>, IBufferMessage
	{
		// Token: 0x06006C6E RID: 27758 RVA: 0x00105D2C File Offset: 0x00103F2C
		[NullableContext(1)]
		public static EntityBeamReceiveResponse Create()
		{
			return new EntityBeamReceiveResponse();
		}

		// Token: 0x1700149A RID: 5274
		// (get) Token: 0x06006C6F RID: 27759 RVA: 0x00105D33 File Offset: 0x00103F33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700149B RID: 5275
		// (get) Token: 0x06006C70 RID: 27760 RVA: 0x00105D36 File Offset: 0x00103F36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityBeamReceiveResponse.Descriptor;
			}
		}

		// Token: 0x06006C71 RID: 27761 RVA: 0x00105D3D File Offset: 0x00103F3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBeamReceiveResponse()
		{
		}

		// Token: 0x06006C72 RID: 27762 RVA: 0x00105D45 File Offset: 0x00103F45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBeamReceiveResponse(EntityBeamReceiveResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.entityId_ = other.entityId_;
			this.receiveType_ = other.receiveType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006C73 RID: 27763 RVA: 0x00105D82 File Offset: 0x00103F82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBeamReceiveResponse Clone()
		{
			return new EntityBeamReceiveResponse(this);
		}

		// Token: 0x1700149C RID: 5276
		// (get) Token: 0x06006C74 RID: 27764 RVA: 0x00105D8A File Offset: 0x00103F8A
		// (set) Token: 0x06006C75 RID: 27765 RVA: 0x00105D92 File Offset: 0x00103F92
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

		// Token: 0x1700149D RID: 5277
		// (get) Token: 0x06006C76 RID: 27766 RVA: 0x00105D9B File Offset: 0x00103F9B
		// (set) Token: 0x06006C77 RID: 27767 RVA: 0x00105DA3 File Offset: 0x00103FA3
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

		// Token: 0x1700149E RID: 5278
		// (get) Token: 0x06006C78 RID: 27768 RVA: 0x00105DAC File Offset: 0x00103FAC
		// (set) Token: 0x06006C79 RID: 27769 RVA: 0x00105DB4 File Offset: 0x00103FB4
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

		// Token: 0x06006C7A RID: 27770 RVA: 0x00105DBD File Offset: 0x00103FBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityBeamReceiveResponse);
		}

		// Token: 0x06006C7B RID: 27771 RVA: 0x00105DCC File Offset: 0x00103FCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityBeamReceiveResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.EntityId == other.EntityId && this.ReceiveType == other.ReceiveType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006C7C RID: 27772 RVA: 0x00105E28 File Offset: 0x00104028
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

		// Token: 0x06006C7D RID: 27773 RVA: 0x00105EA5 File Offset: 0x001040A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006C7E RID: 27774 RVA: 0x00105EB2 File Offset: 0x001040B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006C7F RID: 27775 RVA: 0x00105EBC File Offset: 0x001040BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.EntityId);
			}
			if (this.ReceiveType != EntityBeamReceiveType.BeginAction)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ReceiveType);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006C80 RID: 27776 RVA: 0x00105F34 File Offset: 0x00104134
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

		// Token: 0x06006C81 RID: 27777 RVA: 0x00105FA4 File Offset: 0x001041A4
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

		// Token: 0x06006C82 RID: 27778 RVA: 0x00106008 File Offset: 0x00104208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006C83 RID: 27779 RVA: 0x00106014 File Offset: 0x00104214
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
				if (num != 16U)
				{
					if (num != 80U)
					{
						if (num != 88U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04003AF1 RID: 15089
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003AF2 RID: 15090
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x04003AF3 RID: 15091
		private ErrorCode errorCode_;

		// Token: 0x04003AF4 RID: 15092
		public const int EntityIdFieldNumber = 2;

		// Token: 0x04003AF5 RID: 15093
		private long entityId_;

		// Token: 0x04003AF6 RID: 15094
		public const int ReceiveTypeFieldNumber = 10;

		// Token: 0x04003AF7 RID: 15095
		private EntityBeamReceiveType receiveType_;
	}
}
