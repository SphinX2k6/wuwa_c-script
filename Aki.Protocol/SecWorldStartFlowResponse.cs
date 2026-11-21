using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011F5 RID: 4597
	[NetMessage(EMessageId.SecWorldStartFlowResponse)]
	public sealed class SecWorldStartFlowResponse : IMessage<SecWorldStartFlowResponse>, IMessage, IEquatable<SecWorldStartFlowResponse>, IDeepCloneable<SecWorldStartFlowResponse>, IBufferMessage
	{
		// Token: 0x0601892D RID: 100653 RVA: 0x00395EAA File Offset: 0x003940AA
		[NullableContext(1)]
		public static SecWorldStartFlowResponse Create()
		{
			return new SecWorldStartFlowResponse();
		}

		// Token: 0x17005307 RID: 21255
		// (get) Token: 0x0601892E RID: 100654 RVA: 0x00395EB1 File Offset: 0x003940B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005308 RID: 21256
		// (get) Token: 0x0601892F RID: 100655 RVA: 0x00395EB4 File Offset: 0x003940B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SecWorldStartFlowResponse.Descriptor;
			}
		}

		// Token: 0x06018930 RID: 100656 RVA: 0x00395EBB File Offset: 0x003940BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecWorldStartFlowResponse()
		{
		}

		// Token: 0x06018931 RID: 100657 RVA: 0x00395EC4 File Offset: 0x003940C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecWorldStartFlowResponse(SecWorldStartFlowResponse other) : this()
		{
			this.logId_ = other.logId_;
			this.error_ = ((other.error_ != null) ? other.error_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018932 RID: 100658 RVA: 0x00395F10 File Offset: 0x00394110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecWorldStartFlowResponse Clone()
		{
			return new SecWorldStartFlowResponse(this);
		}

		// Token: 0x17005309 RID: 21257
		// (get) Token: 0x06018933 RID: 100659 RVA: 0x00395F18 File Offset: 0x00394118
		// (set) Token: 0x06018934 RID: 100660 RVA: 0x00395F20 File Offset: 0x00394120
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

		// Token: 0x1700530A RID: 21258
		// (get) Token: 0x06018935 RID: 100661 RVA: 0x00395F29 File Offset: 0x00394129
		// (set) Token: 0x06018936 RID: 100662 RVA: 0x00395F31 File Offset: 0x00394131
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

		// Token: 0x06018937 RID: 100663 RVA: 0x00395F3A File Offset: 0x0039413A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SecWorldStartFlowResponse);
		}

		// Token: 0x06018938 RID: 100664 RVA: 0x00395F48 File Offset: 0x00394148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SecWorldStartFlowResponse other)
		{
			return other != null && (other == this || (this.LogId == other.LogId && object.Equals(this.Error, other.Error) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018939 RID: 100665 RVA: 0x00395F98 File Offset: 0x00394198
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

		// Token: 0x0601893A RID: 100666 RVA: 0x00395FED File Offset: 0x003941ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601893B RID: 100667 RVA: 0x00395FFA File Offset: 0x003941FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601893C RID: 100668 RVA: 0x00396004 File Offset: 0x00394204
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.error_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Error);
			}
			if (this.LogId != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.LogId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601893D RID: 100669 RVA: 0x00396060 File Offset: 0x00394260
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

		// Token: 0x0601893E RID: 100670 RVA: 0x003960B8 File Offset: 0x003942B8
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

		// Token: 0x0601893F RID: 100671 RVA: 0x00396120 File Offset: 0x00394320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018940 RID: 100672 RVA: 0x0039612C File Offset: 0x0039432C
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
				if (num != 34U)
				{
					if (num != 56U)
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

		// Token: 0x04009239 RID: 37433
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400923A RID: 37434
		public const int LogIdFieldNumber = 7;

		// Token: 0x0400923B RID: 37435
		private long logId_;

		// Token: 0x0400923C RID: 37436
		public const int ErrorFieldNumber = 4;

		// Token: 0x0400923D RID: 37437
		private DErrorResult error_;
	}
}
