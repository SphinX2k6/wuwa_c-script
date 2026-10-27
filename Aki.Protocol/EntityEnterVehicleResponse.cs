using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000489 RID: 1161
	[NetMessage(EMessageId.EntityEnterVehicleResponse)]
	public sealed class EntityEnterVehicleResponse : IMessage<EntityEnterVehicleResponse>, IMessage, IEquatable<EntityEnterVehicleResponse>, IDeepCloneable<EntityEnterVehicleResponse>, IBufferMessage
	{
		// Token: 0x06006F20 RID: 28448 RVA: 0x00110ED0 File Offset: 0x0010F0D0
		[NullableContext(1)]
		public static EntityEnterVehicleResponse Create()
		{
			return new EntityEnterVehicleResponse();
		}

		// Token: 0x17001563 RID: 5475
		// (get) Token: 0x06006F21 RID: 28449 RVA: 0x00110ED7 File Offset: 0x0010F0D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001564 RID: 5476
		// (get) Token: 0x06006F22 RID: 28450 RVA: 0x00110EDA File Offset: 0x0010F0DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityEnterVehicleResponse.Descriptor;
			}
		}

		// Token: 0x06006F23 RID: 28451 RVA: 0x00110EE1 File Offset: 0x0010F0E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityEnterVehicleResponse()
		{
		}

		// Token: 0x06006F24 RID: 28452 RVA: 0x00110EE9 File Offset: 0x0010F0E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityEnterVehicleResponse(EntityEnterVehicleResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006F25 RID: 28453 RVA: 0x00110F0E File Offset: 0x0010F10E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityEnterVehicleResponse Clone()
		{
			return new EntityEnterVehicleResponse(this);
		}

		// Token: 0x17001565 RID: 5477
		// (get) Token: 0x06006F26 RID: 28454 RVA: 0x00110F16 File Offset: 0x0010F116
		// (set) Token: 0x06006F27 RID: 28455 RVA: 0x00110F1E File Offset: 0x0010F11E
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

		// Token: 0x06006F28 RID: 28456 RVA: 0x00110F27 File Offset: 0x0010F127
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityEnterVehicleResponse);
		}

		// Token: 0x06006F29 RID: 28457 RVA: 0x00110F35 File Offset: 0x0010F135
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityEnterVehicleResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006F2A RID: 28458 RVA: 0x00110F64 File Offset: 0x0010F164
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006F2B RID: 28459 RVA: 0x00110FA9 File Offset: 0x0010F1A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006F2C RID: 28460 RVA: 0x00110FB6 File Offset: 0x0010F1B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006F2D RID: 28461 RVA: 0x00110FBF File Offset: 0x0010F1BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006F2E RID: 28462 RVA: 0x00110FF4 File Offset: 0x0010F1F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006F2F RID: 28463 RVA: 0x00111032 File Offset: 0x0010F232
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityEnterVehicleResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006F30 RID: 28464 RVA: 0x00111063 File Offset: 0x0010F263
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006F31 RID: 28465 RVA: 0x0011106C File Offset: 0x0010F26C
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
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003BDA RID: 15322
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003BDB RID: 15323
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x04003BDC RID: 15324
		private ErrorCode errorCode_;
	}
}
