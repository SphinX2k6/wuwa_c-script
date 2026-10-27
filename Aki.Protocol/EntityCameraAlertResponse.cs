using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200047C RID: 1148
	[NetMessage(EMessageId.EntityCameraAlertResponse)]
	public sealed class EntityCameraAlertResponse : IMessage<EntityCameraAlertResponse>, IMessage, IEquatable<EntityCameraAlertResponse>, IDeepCloneable<EntityCameraAlertResponse>, IBufferMessage
	{
		// Token: 0x06006D46 RID: 27974 RVA: 0x001078B4 File Offset: 0x00105AB4
		[NullableContext(1)]
		public static EntityCameraAlertResponse Create()
		{
			return new EntityCameraAlertResponse();
		}

		// Token: 0x170014C4 RID: 5316
		// (get) Token: 0x06006D47 RID: 27975 RVA: 0x001078BB File Offset: 0x00105ABB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170014C5 RID: 5317
		// (get) Token: 0x06006D48 RID: 27976 RVA: 0x001078BE File Offset: 0x00105ABE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityCameraAlertResponse.Descriptor;
			}
		}

		// Token: 0x06006D49 RID: 27977 RVA: 0x001078C5 File Offset: 0x00105AC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityCameraAlertResponse()
		{
		}

		// Token: 0x06006D4A RID: 27978 RVA: 0x001078CD File Offset: 0x00105ACD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityCameraAlertResponse(EntityCameraAlertResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.entityId_ = other.entityId_;
			this.isAlert_ = other.isAlert_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006D4B RID: 27979 RVA: 0x0010790A File Offset: 0x00105B0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityCameraAlertResponse Clone()
		{
			return new EntityCameraAlertResponse(this);
		}

		// Token: 0x170014C6 RID: 5318
		// (get) Token: 0x06006D4C RID: 27980 RVA: 0x00107912 File Offset: 0x00105B12
		// (set) Token: 0x06006D4D RID: 27981 RVA: 0x0010791A File Offset: 0x00105B1A
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

		// Token: 0x170014C7 RID: 5319
		// (get) Token: 0x06006D4E RID: 27982 RVA: 0x00107923 File Offset: 0x00105B23
		// (set) Token: 0x06006D4F RID: 27983 RVA: 0x0010792B File Offset: 0x00105B2B
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

		// Token: 0x170014C8 RID: 5320
		// (get) Token: 0x06006D50 RID: 27984 RVA: 0x00107934 File Offset: 0x00105B34
		// (set) Token: 0x06006D51 RID: 27985 RVA: 0x0010793C File Offset: 0x00105B3C
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

		// Token: 0x06006D52 RID: 27986 RVA: 0x00107945 File Offset: 0x00105B45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityCameraAlertResponse);
		}

		// Token: 0x06006D53 RID: 27987 RVA: 0x00107954 File Offset: 0x00105B54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityCameraAlertResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.EntityId == other.EntityId && this.IsAlert == other.IsAlert && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006D54 RID: 27988 RVA: 0x001079B0 File Offset: 0x00105BB0
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

		// Token: 0x06006D55 RID: 27989 RVA: 0x00107A27 File Offset: 0x00105C27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006D56 RID: 27990 RVA: 0x00107A34 File Offset: 0x00105C34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006D57 RID: 27991 RVA: 0x00107A40 File Offset: 0x00105C40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsAlert)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsAlert);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
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

		// Token: 0x06006D58 RID: 27992 RVA: 0x00107AB8 File Offset: 0x00105CB8
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

		// Token: 0x06006D59 RID: 27993 RVA: 0x00107B1C File Offset: 0x00105D1C
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

		// Token: 0x06006D5A RID: 27994 RVA: 0x00107B80 File Offset: 0x00105D80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006D5B RID: 27995 RVA: 0x00107B8C File Offset: 0x00105D8C
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
						if (num != 104U)
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
					this.IsAlert = input.ReadBool();
				}
			}
		}

		// Token: 0x04003B26 RID: 15142
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003B27 RID: 15143
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x04003B28 RID: 15144
		private ErrorCode errorCode_;

		// Token: 0x04003B29 RID: 15145
		public const int EntityIdFieldNumber = 13;

		// Token: 0x04003B2A RID: 15146
		private long entityId_;

		// Token: 0x04003B2B RID: 15147
		public const int IsAlertFieldNumber = 2;

		// Token: 0x04003B2C RID: 15148
		private bool isAlert_;
	}
}
