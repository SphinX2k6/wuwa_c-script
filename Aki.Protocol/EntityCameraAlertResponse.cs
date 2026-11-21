using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000465 RID: 1125
	[NetMessage(EMessageId.EntityCameraAlertResponse)]
	public sealed class EntityCameraAlertResponse : IMessage<EntityCameraAlertResponse>, IMessage, IEquatable<EntityCameraAlertResponse>, IDeepCloneable<EntityCameraAlertResponse>, IBufferMessage
	{
		// Token: 0x06006BB8 RID: 27576 RVA: 0x00104840 File Offset: 0x00102A40
		[NullableContext(1)]
		public static EntityCameraAlertResponse Create()
		{
			return new EntityCameraAlertResponse();
		}

		// Token: 0x17001470 RID: 5232
		// (get) Token: 0x06006BB9 RID: 27577 RVA: 0x00104847 File Offset: 0x00102A47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001471 RID: 5233
		// (get) Token: 0x06006BBA RID: 27578 RVA: 0x0010484A File Offset: 0x00102A4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityCameraAlertResponse.Descriptor;
			}
		}

		// Token: 0x06006BBB RID: 27579 RVA: 0x00104851 File Offset: 0x00102A51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityCameraAlertResponse()
		{
		}

		// Token: 0x06006BBC RID: 27580 RVA: 0x00104859 File Offset: 0x00102A59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityCameraAlertResponse(EntityCameraAlertResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.entityId_ = other.entityId_;
			this.isAlert_ = other.isAlert_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006BBD RID: 27581 RVA: 0x00104896 File Offset: 0x00102A96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityCameraAlertResponse Clone()
		{
			return new EntityCameraAlertResponse(this);
		}

		// Token: 0x17001472 RID: 5234
		// (get) Token: 0x06006BBE RID: 27582 RVA: 0x0010489E File Offset: 0x00102A9E
		// (set) Token: 0x06006BBF RID: 27583 RVA: 0x001048A6 File Offset: 0x00102AA6
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

		// Token: 0x17001473 RID: 5235
		// (get) Token: 0x06006BC0 RID: 27584 RVA: 0x001048AF File Offset: 0x00102AAF
		// (set) Token: 0x06006BC1 RID: 27585 RVA: 0x001048B7 File Offset: 0x00102AB7
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

		// Token: 0x17001474 RID: 5236
		// (get) Token: 0x06006BC2 RID: 27586 RVA: 0x001048C0 File Offset: 0x00102AC0
		// (set) Token: 0x06006BC3 RID: 27587 RVA: 0x001048C8 File Offset: 0x00102AC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsAlert
		{
			get
			{
				return this.isAlert_;
			}
			set
			{
				this.isAlert_ = value;
			}
		}

		// Token: 0x06006BC4 RID: 27588 RVA: 0x001048D1 File Offset: 0x00102AD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityCameraAlertResponse);
		}

		// Token: 0x06006BC5 RID: 27589 RVA: 0x001048E0 File Offset: 0x00102AE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityCameraAlertResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.EntityId == other.EntityId && this.IsAlert == other.IsAlert && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006BC6 RID: 27590 RVA: 0x0010493C File Offset: 0x00102B3C
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
			if (this.IsAlert)
			{
				num ^= this.IsAlert.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006BC7 RID: 27591 RVA: 0x001049B3 File Offset: 0x00102BB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006BC8 RID: 27592 RVA: 0x001049C0 File Offset: 0x00102BC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006BC9 RID: 27593 RVA: 0x001049CC File Offset: 0x00102BCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.EntityId);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.IsAlert)
			{
				output.WriteRawTag(112);
				output.WriteBool(this.IsAlert);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006BCA RID: 27594 RVA: 0x00104A44 File Offset: 0x00102C44
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
			if (this.IsAlert)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006BCB RID: 27595 RVA: 0x00104AA8 File Offset: 0x00102CA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityCameraAlertResponse other)
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
			if (other.IsAlert)
			{
				this.IsAlert = other.IsAlert;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006BCC RID: 27596 RVA: 0x00104B0C File Offset: 0x00102D0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006BCD RID: 27597 RVA: 0x00104B18 File Offset: 0x00102D18
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
				if (num != 40U)
				{
					if (num != 104U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.IsAlert = input.ReadBool();
						}
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04003B14 RID: 15124
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003B15 RID: 15125
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x04003B16 RID: 15126
		private ErrorCode errorCode_;

		// Token: 0x04003B17 RID: 15127
		public const int EntityIdFieldNumber = 5;

		// Token: 0x04003B18 RID: 15128
		private long entityId_;

		// Token: 0x04003B19 RID: 15129
		public const int IsAlertFieldNumber = 14;

		// Token: 0x04003B1A RID: 15130
		private bool isAlert_;
	}
}
