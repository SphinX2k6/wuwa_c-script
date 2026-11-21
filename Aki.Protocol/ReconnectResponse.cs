using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EC3 RID: 3779
	[NetMessage(EMessageId.ReconnectResponse)]
	public sealed class ReconnectResponse : IMessage<ReconnectResponse>, IMessage, IEquatable<ReconnectResponse>, IDeepCloneable<ReconnectResponse>, IBufferMessage
	{
		// Token: 0x06014491 RID: 83089 RVA: 0x002F3350 File Offset: 0x002F1550
		[NullableContext(1)]
		public static ReconnectResponse Create()
		{
			return new ReconnectResponse();
		}

		// Token: 0x17004372 RID: 17266
		// (get) Token: 0x06014492 RID: 83090 RVA: 0x002F3357 File Offset: 0x002F1557
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004373 RID: 17267
		// (get) Token: 0x06014493 RID: 83091 RVA: 0x002F335A File Offset: 0x002F155A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ReconnectResponse.Descriptor;
			}
		}

		// Token: 0x06014494 RID: 83092 RVA: 0x002F3361 File Offset: 0x002F1561
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReconnectResponse()
		{
		}

		// Token: 0x06014495 RID: 83093 RVA: 0x002F336C File Offset: 0x002F156C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReconnectResponse(ReconnectResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.lastRecvSeqNo_ = other.lastRecvSeqNo_;
			this.timestamp_ = other.timestamp_;
			this.isPermittedSilentLogin_ = other.isPermittedSilentLogin_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014496 RID: 83094 RVA: 0x002F33C0 File Offset: 0x002F15C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReconnectResponse Clone()
		{
			return new ReconnectResponse(this);
		}

		// Token: 0x17004374 RID: 17268
		// (get) Token: 0x06014497 RID: 83095 RVA: 0x002F33C8 File Offset: 0x002F15C8
		// (set) Token: 0x06014498 RID: 83096 RVA: 0x002F33D0 File Offset: 0x002F15D0
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

		// Token: 0x17004375 RID: 17269
		// (get) Token: 0x06014499 RID: 83097 RVA: 0x002F33D9 File Offset: 0x002F15D9
		// (set) Token: 0x0601449A RID: 83098 RVA: 0x002F33E1 File Offset: 0x002F15E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LastRecvSeqNo
		{
			get
			{
				return this.lastRecvSeqNo_;
			}
			set
			{
				this.lastRecvSeqNo_ = value;
			}
		}

		// Token: 0x17004376 RID: 17270
		// (get) Token: 0x0601449B RID: 83099 RVA: 0x002F33EA File Offset: 0x002F15EA
		// (set) Token: 0x0601449C RID: 83100 RVA: 0x002F33F2 File Offset: 0x002F15F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Timestamp
		{
			get
			{
				return this.timestamp_;
			}
			set
			{
				this.timestamp_ = value;
			}
		}

		// Token: 0x17004377 RID: 17271
		// (get) Token: 0x0601449D RID: 83101 RVA: 0x002F33FB File Offset: 0x002F15FB
		// (set) Token: 0x0601449E RID: 83102 RVA: 0x002F3403 File Offset: 0x002F1603
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsPermittedSilentLogin
		{
			get
			{
				return this.isPermittedSilentLogin_;
			}
			set
			{
				this.isPermittedSilentLogin_ = value;
			}
		}

		// Token: 0x0601449F RID: 83103 RVA: 0x002F340C File Offset: 0x002F160C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ReconnectResponse);
		}

		// Token: 0x060144A0 RID: 83104 RVA: 0x002F341C File Offset: 0x002F161C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ReconnectResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.LastRecvSeqNo == other.LastRecvSeqNo && this.Timestamp == other.Timestamp && this.IsPermittedSilentLogin == other.IsPermittedSilentLogin && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060144A1 RID: 83105 RVA: 0x002F3488 File Offset: 0x002F1688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.LastRecvSeqNo != 0)
			{
				num ^= this.LastRecvSeqNo.GetHashCode();
			}
			if (this.Timestamp != 0L)
			{
				num ^= this.Timestamp.GetHashCode();
			}
			if (this.IsPermittedSilentLogin)
			{
				num ^= this.IsPermittedSilentLogin.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060144A2 RID: 83106 RVA: 0x002F3519 File Offset: 0x002F1719
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060144A3 RID: 83107 RVA: 0x002F3526 File Offset: 0x002F1726
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060144A4 RID: 83108 RVA: 0x002F3530 File Offset: 0x002F1730
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.LastRecvSeqNo != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.LastRecvSeqNo);
			}
			if (this.Timestamp != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.Timestamp);
			}
			if (this.IsPermittedSilentLogin)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.IsPermittedSilentLogin);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060144A5 RID: 83109 RVA: 0x002F35C0 File Offset: 0x002F17C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.LastRecvSeqNo != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LastRecvSeqNo);
			}
			if (this.Timestamp != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Timestamp);
			}
			if (this.IsPermittedSilentLogin)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060144A6 RID: 83110 RVA: 0x002F363C File Offset: 0x002F183C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ReconnectResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.LastRecvSeqNo != 0)
			{
				this.LastRecvSeqNo = other.LastRecvSeqNo;
			}
			if (other.Timestamp != 0L)
			{
				this.Timestamp = other.Timestamp;
			}
			if (other.IsPermittedSilentLogin)
			{
				this.IsPermittedSilentLogin = other.IsPermittedSilentLogin;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060144A7 RID: 83111 RVA: 0x002F36B4 File Offset: 0x002F18B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060144A8 RID: 83112 RVA: 0x002F36C0 File Offset: 0x002F18C0
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 16U)
					{
						this.LastRecvSeqNo = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.Timestamp = input.ReadInt64();
						continue;
					}
					if (num == 32U)
					{
						this.IsPermittedSilentLogin = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007BA6 RID: 31654
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007BA7 RID: 31655
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x04007BA8 RID: 31656
		private ErrorCode errorCode_;

		// Token: 0x04007BA9 RID: 31657
		public const int LastRecvSeqNoFieldNumber = 2;

		// Token: 0x04007BAA RID: 31658
		private int lastRecvSeqNo_;

		// Token: 0x04007BAB RID: 31659
		public const int TimestampFieldNumber = 3;

		// Token: 0x04007BAC RID: 31660
		private long timestamp_;

		// Token: 0x04007BAD RID: 31661
		public const int IsPermittedSilentLoginFieldNumber = 4;

		// Token: 0x04007BAE RID: 31662
		private bool isPermittedSilentLogin_;
	}
}
