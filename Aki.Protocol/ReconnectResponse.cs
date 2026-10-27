using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000ED3 RID: 3795
	[NetMessage(EMessageId.ReconnectResponse)]
	public sealed class ReconnectResponse : IMessage<ReconnectResponse>, IMessage, IEquatable<ReconnectResponse>, IDeepCloneable<ReconnectResponse>, IBufferMessage
	{
		// Token: 0x06014576 RID: 83318 RVA: 0x002F4A04 File Offset: 0x002F2C04
		[NullableContext(1)]
		public static ReconnectResponse Create()
		{
			return new ReconnectResponse();
		}

		// Token: 0x1700439C RID: 17308
		// (get) Token: 0x06014577 RID: 83319 RVA: 0x002F4A0B File Offset: 0x002F2C0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700439D RID: 17309
		// (get) Token: 0x06014578 RID: 83320 RVA: 0x002F4A0E File Offset: 0x002F2C0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ReconnectResponse.Descriptor;
			}
		}

		// Token: 0x06014579 RID: 83321 RVA: 0x002F4A15 File Offset: 0x002F2C15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReconnectResponse()
		{
		}

		// Token: 0x0601457A RID: 83322 RVA: 0x002F4A20 File Offset: 0x002F2C20
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

		// Token: 0x0601457B RID: 83323 RVA: 0x002F4A74 File Offset: 0x002F2C74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReconnectResponse Clone()
		{
			return new ReconnectResponse(this);
		}

		// Token: 0x1700439E RID: 17310
		// (get) Token: 0x0601457C RID: 83324 RVA: 0x002F4A7C File Offset: 0x002F2C7C
		// (set) Token: 0x0601457D RID: 83325 RVA: 0x002F4A84 File Offset: 0x002F2C84
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

		// Token: 0x1700439F RID: 17311
		// (get) Token: 0x0601457E RID: 83326 RVA: 0x002F4A8D File Offset: 0x002F2C8D
		// (set) Token: 0x0601457F RID: 83327 RVA: 0x002F4A95 File Offset: 0x002F2C95
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

		// Token: 0x170043A0 RID: 17312
		// (get) Token: 0x06014580 RID: 83328 RVA: 0x002F4A9E File Offset: 0x002F2C9E
		// (set) Token: 0x06014581 RID: 83329 RVA: 0x002F4AA6 File Offset: 0x002F2CA6
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

		// Token: 0x170043A1 RID: 17313
		// (get) Token: 0x06014582 RID: 83330 RVA: 0x002F4AAF File Offset: 0x002F2CAF
		// (set) Token: 0x06014583 RID: 83331 RVA: 0x002F4AB7 File Offset: 0x002F2CB7
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

		// Token: 0x06014584 RID: 83332 RVA: 0x002F4AC0 File Offset: 0x002F2CC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ReconnectResponse);
		}

		// Token: 0x06014585 RID: 83333 RVA: 0x002F4AD0 File Offset: 0x002F2CD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ReconnectResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.LastRecvSeqNo == other.LastRecvSeqNo && this.Timestamp == other.Timestamp && this.IsPermittedSilentLogin == other.IsPermittedSilentLogin && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014586 RID: 83334 RVA: 0x002F4B3C File Offset: 0x002F2D3C
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

		// Token: 0x06014587 RID: 83335 RVA: 0x002F4BCD File Offset: 0x002F2DCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014588 RID: 83336 RVA: 0x002F4BDA File Offset: 0x002F2DDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014589 RID: 83337 RVA: 0x002F4BE4 File Offset: 0x002F2DE4
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

		// Token: 0x0601458A RID: 83338 RVA: 0x002F4C74 File Offset: 0x002F2E74
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

		// Token: 0x0601458B RID: 83339 RVA: 0x002F4CF0 File Offset: 0x002F2EF0
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

		// Token: 0x0601458C RID: 83340 RVA: 0x002F4D68 File Offset: 0x002F2F68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601458D RID: 83341 RVA: 0x002F4D74 File Offset: 0x002F2F74
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

		// Token: 0x04007B7C RID: 31612
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007B7D RID: 31613
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x04007B7E RID: 31614
		private ErrorCode errorCode_;

		// Token: 0x04007B7F RID: 31615
		public const int LastRecvSeqNoFieldNumber = 2;

		// Token: 0x04007B80 RID: 31616
		private int lastRecvSeqNo_;

		// Token: 0x04007B81 RID: 31617
		public const int TimestampFieldNumber = 3;

		// Token: 0x04007B82 RID: 31618
		private long timestamp_;

		// Token: 0x04007B83 RID: 31619
		public const int IsPermittedSilentLoginFieldNumber = 4;

		// Token: 0x04007B84 RID: 31620
		private bool isPermittedSilentLogin_;
	}
}
