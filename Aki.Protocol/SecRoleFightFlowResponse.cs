using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011EF RID: 4591
	[NetMessage(EMessageId.SecRoleFightFlowResponse)]
	public sealed class SecRoleFightFlowResponse : IMessage<SecRoleFightFlowResponse>, IMessage, IEquatable<SecRoleFightFlowResponse>, IDeepCloneable<SecRoleFightFlowResponse>, IBufferMessage
	{
		// Token: 0x0601886D RID: 100461 RVA: 0x0039337D File Offset: 0x0039157D
		[NullableContext(1)]
		public static SecRoleFightFlowResponse Create()
		{
			return new SecRoleFightFlowResponse();
		}

		// Token: 0x170052CB RID: 21195
		// (get) Token: 0x0601886E RID: 100462 RVA: 0x00393384 File Offset: 0x00391584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170052CC RID: 21196
		// (get) Token: 0x0601886F RID: 100463 RVA: 0x00393387 File Offset: 0x00391587
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SecRoleFightFlowResponse.Descriptor;
			}
		}

		// Token: 0x06018870 RID: 100464 RVA: 0x0039338E File Offset: 0x0039158E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecRoleFightFlowResponse()
		{
		}

		// Token: 0x06018871 RID: 100465 RVA: 0x00393398 File Offset: 0x00391598
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecRoleFightFlowResponse(SecRoleFightFlowResponse other) : this()
		{
			this.logId_ = other.logId_;
			this.error_ = ((other.error_ != null) ? other.error_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018872 RID: 100466 RVA: 0x003933E4 File Offset: 0x003915E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecRoleFightFlowResponse Clone()
		{
			return new SecRoleFightFlowResponse(this);
		}

		// Token: 0x170052CD RID: 21197
		// (get) Token: 0x06018873 RID: 100467 RVA: 0x003933EC File Offset: 0x003915EC
		// (set) Token: 0x06018874 RID: 100468 RVA: 0x003933F4 File Offset: 0x003915F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long LogId
		{
			get
			{
				return this.logId_;
			}
			set
			{
				this.logId_ = value;
			}
		}

		// Token: 0x170052CE RID: 21198
		// (get) Token: 0x06018875 RID: 100469 RVA: 0x003933FD File Offset: 0x003915FD
		// (set) Token: 0x06018876 RID: 100470 RVA: 0x00393405 File Offset: 0x00391605
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DErrorResult Error
		{
			get
			{
				return this.error_;
			}
			set
			{
				this.error_ = value;
			}
		}

		// Token: 0x06018877 RID: 100471 RVA: 0x0039340E File Offset: 0x0039160E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SecRoleFightFlowResponse);
		}

		// Token: 0x06018878 RID: 100472 RVA: 0x0039341C File Offset: 0x0039161C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SecRoleFightFlowResponse other)
		{
			return other != null && (other == this || (this.LogId == other.LogId && object.Equals(this.Error, other.Error) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018879 RID: 100473 RVA: 0x0039346C File Offset: 0x0039166C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LogId != 0L)
			{
				num ^= this.LogId.GetHashCode();
			}
			if (this.error_ != null)
			{
				num ^= this.Error.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601887A RID: 100474 RVA: 0x003934C1 File Offset: 0x003916C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601887B RID: 100475 RVA: 0x003934CE File Offset: 0x003916CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601887C RID: 100476 RVA: 0x003934D8 File Offset: 0x003916D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.error_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.Error);
			}
			if (this.LogId != 0L)
			{
				output.WriteRawTag(112);
				output.WriteInt64(this.LogId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601887D RID: 100477 RVA: 0x00393534 File Offset: 0x00391734
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LogId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.LogId);
			}
			if (this.error_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Error);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601887E RID: 100478 RVA: 0x0039358C File Offset: 0x0039178C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SecRoleFightFlowResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LogId != 0L)
			{
				this.LogId = other.LogId;
			}
			if (other.error_ != null)
			{
				if (this.error_ == null)
				{
					this.Error = new DErrorResult();
				}
				this.Error.MergeFrom(other.Error);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601887F RID: 100479 RVA: 0x003935F4 File Offset: 0x003917F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018880 RID: 100480 RVA: 0x00393600 File Offset: 0x00391800
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
				if (num != 42U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.LogId = input.ReadInt64();
					}
				}
				else
				{
					if (this.error_ == null)
					{
						this.Error = new DErrorResult();
					}
					input.ReadMessage(this.Error);
				}
			}
		}

		// Token: 0x040091D3 RID: 37331
		private UnknownFieldSet _unknownFields;

		// Token: 0x040091D4 RID: 37332
		public const int LogIdFieldNumber = 14;

		// Token: 0x040091D5 RID: 37333
		private long logId_;

		// Token: 0x040091D6 RID: 37334
		public const int ErrorFieldNumber = 5;

		// Token: 0x040091D7 RID: 37335
		private DErrorResult error_;
	}
}
