using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000ED2 RID: 3794
	[NetMessage(EMessageId.ReconnectRequest)]
	public sealed class ReconnectRequest : IMessage<ReconnectRequest>, IMessage, IEquatable<ReconnectRequest>, IDeepCloneable<ReconnectRequest>, IBufferMessage
	{
		// Token: 0x0601455E RID: 83294 RVA: 0x002F45BB File Offset: 0x002F27BB
		[NullableContext(1)]
		public static ReconnectRequest Create()
		{
			return new ReconnectRequest();
		}

		// Token: 0x17004396 RID: 17302
		// (get) Token: 0x0601455F RID: 83295 RVA: 0x002F45C2 File Offset: 0x002F27C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004397 RID: 17303
		// (get) Token: 0x06014560 RID: 83296 RVA: 0x002F45C5 File Offset: 0x002F27C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ReconnectRequest.Descriptor;
			}
		}

		// Token: 0x06014561 RID: 83297 RVA: 0x002F45CC File Offset: 0x002F27CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReconnectRequest()
		{
		}

		// Token: 0x06014562 RID: 83298 RVA: 0x002F45EC File Offset: 0x002F27EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReconnectRequest(ReconnectRequest other) : this()
		{
			this.playerId_ = other.playerId_;
			this.lastSvrSeqNo_ = other.lastSvrSeqNo_;
			this.reconnectToken_ = other.reconnectToken_;
			this.reconnectTraceId_ = other.reconnectTraceId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014563 RID: 83299 RVA: 0x002F4640 File Offset: 0x002F2840
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReconnectRequest Clone()
		{
			return new ReconnectRequest(this);
		}

		// Token: 0x17004398 RID: 17304
		// (get) Token: 0x06014564 RID: 83300 RVA: 0x002F4648 File Offset: 0x002F2848
		// (set) Token: 0x06014565 RID: 83301 RVA: 0x002F4650 File Offset: 0x002F2850
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerId
		{
			get
			{
				return this.playerId_;
			}
			set
			{
				this.playerId_ = value;
			}
		}

		// Token: 0x17004399 RID: 17305
		// (get) Token: 0x06014566 RID: 83302 RVA: 0x002F4659 File Offset: 0x002F2859
		// (set) Token: 0x06014567 RID: 83303 RVA: 0x002F4661 File Offset: 0x002F2861
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LastSvrSeqNo
		{
			get
			{
				return this.lastSvrSeqNo_;
			}
			set
			{
				this.lastSvrSeqNo_ = value;
			}
		}

		// Token: 0x1700439A RID: 17306
		// (get) Token: 0x06014568 RID: 83304 RVA: 0x002F466A File Offset: 0x002F286A
		// (set) Token: 0x06014569 RID: 83305 RVA: 0x002F4672 File Offset: 0x002F2872
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string ReconnectToken
		{
			get
			{
				return this.reconnectToken_;
			}
			set
			{
				this.reconnectToken_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700439B RID: 17307
		// (get) Token: 0x0601456A RID: 83306 RVA: 0x002F4685 File Offset: 0x002F2885
		// (set) Token: 0x0601456B RID: 83307 RVA: 0x002F468D File Offset: 0x002F288D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string ReconnectTraceId
		{
			get
			{
				return this.reconnectTraceId_;
			}
			set
			{
				this.reconnectTraceId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x0601456C RID: 83308 RVA: 0x002F46A0 File Offset: 0x002F28A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ReconnectRequest);
		}

		// Token: 0x0601456D RID: 83309 RVA: 0x002F46B0 File Offset: 0x002F28B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ReconnectRequest other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.LastSvrSeqNo == other.LastSvrSeqNo && !(this.ReconnectToken != other.ReconnectToken) && !(this.ReconnectTraceId != other.ReconnectTraceId) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601456E RID: 83310 RVA: 0x002F4724 File Offset: 0x002F2924
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this.LastSvrSeqNo != 0)
			{
				num ^= this.LastSvrSeqNo.GetHashCode();
			}
			if (this.ReconnectToken.Length != 0)
			{
				num ^= this.ReconnectToken.GetHashCode();
			}
			if (this.ReconnectTraceId.Length != 0)
			{
				num ^= this.ReconnectTraceId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601456F RID: 83311 RVA: 0x002F47B2 File Offset: 0x002F29B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014570 RID: 83312 RVA: 0x002F47BF File Offset: 0x002F29BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014571 RID: 83313 RVA: 0x002F47C8 File Offset: 0x002F29C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.PlayerId);
			}
			if (this.LastSvrSeqNo != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.LastSvrSeqNo);
			}
			if (this.ReconnectToken.Length != 0)
			{
				output.WriteRawTag(26);
				output.WriteString(this.ReconnectToken);
			}
			if (this.ReconnectTraceId.Length != 0)
			{
				output.WriteRawTag(34);
				output.WriteString(this.ReconnectTraceId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014572 RID: 83314 RVA: 0x002F4864 File Offset: 0x002F2A64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this.LastSvrSeqNo != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LastSvrSeqNo);
			}
			if (this.ReconnectToken.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ReconnectToken);
			}
			if (this.ReconnectTraceId.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ReconnectTraceId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014573 RID: 83315 RVA: 0x002F48F4 File Offset: 0x002F2AF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ReconnectRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			if (other.LastSvrSeqNo != 0)
			{
				this.LastSvrSeqNo = other.LastSvrSeqNo;
			}
			if (other.ReconnectToken.Length != 0)
			{
				this.ReconnectToken = other.ReconnectToken;
			}
			if (other.ReconnectTraceId.Length != 0)
			{
				this.ReconnectTraceId = other.ReconnectTraceId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014574 RID: 83316 RVA: 0x002F4976 File Offset: 0x002F2B76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014575 RID: 83317 RVA: 0x002F4980 File Offset: 0x002F2B80
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
						this.PlayerId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.LastSvrSeqNo = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 26U)
					{
						this.ReconnectToken = input.ReadString();
						continue;
					}
					if (num == 34U)
					{
						this.ReconnectTraceId = input.ReadString();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007B73 RID: 31603
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007B74 RID: 31604
		public const int PlayerIdFieldNumber = 1;

		// Token: 0x04007B75 RID: 31605
		private int playerId_;

		// Token: 0x04007B76 RID: 31606
		public const int LastSvrSeqNoFieldNumber = 2;

		// Token: 0x04007B77 RID: 31607
		private int lastSvrSeqNo_;

		// Token: 0x04007B78 RID: 31608
		public const int ReconnectTokenFieldNumber = 3;

		// Token: 0x04007B79 RID: 31609
		private string reconnectToken_ = "";

		// Token: 0x04007B7A RID: 31610
		public const int ReconnectTraceIdFieldNumber = 4;

		// Token: 0x04007B7B RID: 31611
		private string reconnectTraceId_ = "";
	}
}
