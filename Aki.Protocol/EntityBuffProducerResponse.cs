using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000461 RID: 1121
	[NetMessage(EMessageId.EntityBuffProducerResponse)]
	public sealed class EntityBuffProducerResponse : IMessage<EntityBuffProducerResponse>, IMessage, IEquatable<EntityBuffProducerResponse>, IDeepCloneable<EntityBuffProducerResponse>, IBufferMessage
	{
		// Token: 0x06006B6C RID: 27500 RVA: 0x00103F0D File Offset: 0x0010210D
		[NullableContext(1)]
		public static EntityBuffProducerResponse Create()
		{
			return new EntityBuffProducerResponse();
		}

		// Token: 0x17001462 RID: 5218
		// (get) Token: 0x06006B6D RID: 27501 RVA: 0x00103F14 File Offset: 0x00102114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001463 RID: 5219
		// (get) Token: 0x06006B6E RID: 27502 RVA: 0x00103F17 File Offset: 0x00102117
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityBuffProducerResponse.Descriptor;
			}
		}

		// Token: 0x06006B6F RID: 27503 RVA: 0x00103F1E File Offset: 0x0010211E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBuffProducerResponse()
		{
		}

		// Token: 0x06006B70 RID: 27504 RVA: 0x00103F26 File Offset: 0x00102126
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBuffProducerResponse(EntityBuffProducerResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006B71 RID: 27505 RVA: 0x00103F4B File Offset: 0x0010214B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBuffProducerResponse Clone()
		{
			return new EntityBuffProducerResponse(this);
		}

		// Token: 0x17001464 RID: 5220
		// (get) Token: 0x06006B72 RID: 27506 RVA: 0x00103F53 File Offset: 0x00102153
		// (set) Token: 0x06006B73 RID: 27507 RVA: 0x00103F5B File Offset: 0x0010215B
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

		// Token: 0x06006B74 RID: 27508 RVA: 0x00103F64 File Offset: 0x00102164
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityBuffProducerResponse);
		}

		// Token: 0x06006B75 RID: 27509 RVA: 0x00103F72 File Offset: 0x00102172
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityBuffProducerResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006B76 RID: 27510 RVA: 0x00103FA0 File Offset: 0x001021A0
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

		// Token: 0x06006B77 RID: 27511 RVA: 0x00103FE5 File Offset: 0x001021E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006B78 RID: 27512 RVA: 0x00103FF2 File Offset: 0x001021F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006B79 RID: 27513 RVA: 0x00103FFB File Offset: 0x001021FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006B7A RID: 27514 RVA: 0x00104030 File Offset: 0x00102230
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

		// Token: 0x06006B7B RID: 27515 RVA: 0x0010406E File Offset: 0x0010226E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityBuffProducerResponse other)
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

		// Token: 0x06006B7C RID: 27516 RVA: 0x0010409F File Offset: 0x0010229F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006B7D RID: 27517 RVA: 0x001040A8 File Offset: 0x001022A8
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003B04 RID: 15108
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003B05 RID: 15109
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x04003B06 RID: 15110
		private ErrorCode errorCode_;
	}
}
