using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011BB RID: 4539
	[NetMessage(EMessageId.SecWorldStartFlowResponse)]
	public sealed class SecWorldStartFlowResponse : IMessage<SecWorldStartFlowResponse>, IMessage, IEquatable<SecWorldStartFlowResponse>, IDeepCloneable<SecWorldStartFlowResponse>, IBufferMessage
	{
		// Token: 0x0601838C RID: 99212 RVA: 0x00386B79 File Offset: 0x00384D79
		[NullableContext(1)]
		public static SecWorldStartFlowResponse Create()
		{
			return new SecWorldStartFlowResponse();
		}

		// Token: 0x1700519B RID: 20891
		// (get) Token: 0x0601838D RID: 99213 RVA: 0x00386B80 File Offset: 0x00384D80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700519C RID: 20892
		// (get) Token: 0x0601838E RID: 99214 RVA: 0x00386B83 File Offset: 0x00384D83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SecWorldStartFlowResponse.Descriptor;
			}
		}

		// Token: 0x0601838F RID: 99215 RVA: 0x00386B8A File Offset: 0x00384D8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecWorldStartFlowResponse()
		{
		}

		// Token: 0x06018390 RID: 99216 RVA: 0x00386B94 File Offset: 0x00384D94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecWorldStartFlowResponse(SecWorldStartFlowResponse other) : this()
		{
			this.logId_ = other.logId_;
			this.error_ = ((other.error_ != null) ? other.error_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018391 RID: 99217 RVA: 0x00386BE0 File Offset: 0x00384DE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecWorldStartFlowResponse Clone()
		{
			return new SecWorldStartFlowResponse(this);
		}

		// Token: 0x1700519D RID: 20893
		// (get) Token: 0x06018392 RID: 99218 RVA: 0x00386BE8 File Offset: 0x00384DE8
		// (set) Token: 0x06018393 RID: 99219 RVA: 0x00386BF0 File Offset: 0x00384DF0
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

		// Token: 0x1700519E RID: 20894
		// (get) Token: 0x06018394 RID: 99220 RVA: 0x00386BF9 File Offset: 0x00384DF9
		// (set) Token: 0x06018395 RID: 99221 RVA: 0x00386C01 File Offset: 0x00384E01
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

		// Token: 0x06018396 RID: 99222 RVA: 0x00386C0A File Offset: 0x00384E0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SecWorldStartFlowResponse);
		}

		// Token: 0x06018397 RID: 99223 RVA: 0x00386C18 File Offset: 0x00384E18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SecWorldStartFlowResponse other)
		{
			return other != null && (other == this || (this.LogId == other.LogId && object.Equals(this.Error, other.Error) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018398 RID: 99224 RVA: 0x00386C68 File Offset: 0x00384E68
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

		// Token: 0x06018399 RID: 99225 RVA: 0x00386CBD File Offset: 0x00384EBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601839A RID: 99226 RVA: 0x00386CCA File Offset: 0x00384ECA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601839B RID: 99227 RVA: 0x00386CD4 File Offset: 0x00384ED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.error_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.Error);
			}
			if (this.LogId != 0L)
			{
				output.WriteRawTag(120);
				output.WriteInt64(this.LogId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601839C RID: 99228 RVA: 0x00386D30 File Offset: 0x00384F30
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

		// Token: 0x0601839D RID: 99229 RVA: 0x00386D88 File Offset: 0x00384F88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SecWorldStartFlowResponse other)
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

		// Token: 0x0601839E RID: 99230 RVA: 0x00386DF0 File Offset: 0x00384FF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601839F RID: 99231 RVA: 0x00386DFC File Offset: 0x00384FFC
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
				if (num != 66U)
				{
					if (num != 120U)
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

		// Token: 0x04008FA6 RID: 36774
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008FA7 RID: 36775
		public const int LogIdFieldNumber = 15;

		// Token: 0x04008FA8 RID: 36776
		private long logId_;

		// Token: 0x04008FA9 RID: 36777
		public const int ErrorFieldNumber = 8;

		// Token: 0x04008FAA RID: 36778
		private DErrorResult error_;
	}
}
