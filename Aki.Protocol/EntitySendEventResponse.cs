using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004BF RID: 1215
	[NetMessage(EMessageId.EntitySendEventResponse)]
	public sealed class EntitySendEventResponse : IMessage<EntitySendEventResponse>, IMessage, IEquatable<EntitySendEventResponse>, IDeepCloneable<EntitySendEventResponse>, IBufferMessage
	{
		// Token: 0x06007396 RID: 29590 RVA: 0x0011B524 File Offset: 0x00119724
		[NullableContext(1)]
		public static EntitySendEventResponse Create()
		{
			return new EntitySendEventResponse();
		}

		// Token: 0x1700165C RID: 5724
		// (get) Token: 0x06007397 RID: 29591 RVA: 0x0011B52B File Offset: 0x0011972B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700165D RID: 5725
		// (get) Token: 0x06007398 RID: 29592 RVA: 0x0011B52E File Offset: 0x0011972E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntitySendEventResponse.Descriptor;
			}
		}

		// Token: 0x06007399 RID: 29593 RVA: 0x0011B535 File Offset: 0x00119735
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntitySendEventResponse()
		{
		}

		// Token: 0x0600739A RID: 29594 RVA: 0x0011B53D File Offset: 0x0011973D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntitySendEventResponse(EntitySendEventResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600739B RID: 29595 RVA: 0x0011B562 File Offset: 0x00119762
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntitySendEventResponse Clone()
		{
			return new EntitySendEventResponse(this);
		}

		// Token: 0x1700165E RID: 5726
		// (get) Token: 0x0600739C RID: 29596 RVA: 0x0011B56A File Offset: 0x0011976A
		// (set) Token: 0x0600739D RID: 29597 RVA: 0x0011B572 File Offset: 0x00119772
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

		// Token: 0x0600739E RID: 29598 RVA: 0x0011B57B File Offset: 0x0011977B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntitySendEventResponse);
		}

		// Token: 0x0600739F RID: 29599 RVA: 0x0011B589 File Offset: 0x00119789
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntitySendEventResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060073A0 RID: 29600 RVA: 0x0011B5B8 File Offset: 0x001197B8
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

		// Token: 0x060073A1 RID: 29601 RVA: 0x0011B5FD File Offset: 0x001197FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060073A2 RID: 29602 RVA: 0x0011B60A File Offset: 0x0011980A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060073A3 RID: 29603 RVA: 0x0011B613 File Offset: 0x00119813
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060073A4 RID: 29604 RVA: 0x0011B644 File Offset: 0x00119844
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

		// Token: 0x060073A5 RID: 29605 RVA: 0x0011B682 File Offset: 0x00119882
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntitySendEventResponse other)
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

		// Token: 0x060073A6 RID: 29606 RVA: 0x0011B6B3 File Offset: 0x001198B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060073A7 RID: 29607 RVA: 0x0011B6BC File Offset: 0x001198BC
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003D2E RID: 15662
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003D2F RID: 15663
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x04003D30 RID: 15664
		private ErrorCode errorCode_;
	}
}
