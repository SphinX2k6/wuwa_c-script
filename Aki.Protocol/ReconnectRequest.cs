using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EC2 RID: 3778
	[NetMessage(EMessageId.ReconnectRequest)]
	public sealed class ReconnectRequest : IMessage<ReconnectRequest>, IMessage, IEquatable<ReconnectRequest>, IDeepCloneable<ReconnectRequest>, IBufferMessage
	{
		// Token: 0x06014479 RID: 83065 RVA: 0x002F2F07 File Offset: 0x002F1107
		[NullableContext(1)]
		public static ReconnectRequest Create()
		{
			return new ReconnectRequest();
		}

		// Token: 0x1700436C RID: 17260
		// (get) Token: 0x0601447A RID: 83066 RVA: 0x002F2F0E File Offset: 0x002F110E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700436D RID: 17261
		// (get) Token: 0x0601447B RID: 83067 RVA: 0x002F2F11 File Offset: 0x002F1111
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ReconnectRequest.Descriptor;
			}
		}

		// Token: 0x0601447C RID: 83068 RVA: 0x002F2F18 File Offset: 0x002F1118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReconnectRequest()
		{
		}

		// Token: 0x0601447D RID: 83069 RVA: 0x002F2F38 File Offset: 0x002F1138
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

		// Token: 0x0601447E RID: 83070 RVA: 0x002F2F8C File Offset: 0x002F118C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReconnectRequest Clone()
		{
			return new ReconnectRequest(this);
		}

		// Token: 0x1700436E RID: 17262
		// (get) Token: 0x0601447F RID: 83071 RVA: 0x002F2F94 File Offset: 0x002F1194
		// (set) Token: 0x06014480 RID: 83072 RVA: 0x002F2F9C File Offset: 0x002F119C
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

		// Token: 0x1700436F RID: 17263
		// (get) Token: 0x06014481 RID: 83073 RVA: 0x002F2FA5 File Offset: 0x002F11A5
		// (set) Token: 0x06014482 RID: 83074 RVA: 0x002F2FAD File Offset: 0x002F11AD
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

		// Token: 0x17004370 RID: 17264
		// (get) Token: 0x06014483 RID: 83075 RVA: 0x002F2FB6 File Offset: 0x002F11B6
		// (set) Token: 0x06014484 RID: 83076 RVA: 0x002F2FBE File Offset: 0x002F11BE
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

		// Token: 0x17004371 RID: 17265
		// (get) Token: 0x06014485 RID: 83077 RVA: 0x002F2FD1 File Offset: 0x002F11D1
		// (set) Token: 0x06014486 RID: 83078 RVA: 0x002F2FD9 File Offset: 0x002F11D9
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

		// Token: 0x06014487 RID: 83079 RVA: 0x002F2FEC File Offset: 0x002F11EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ReconnectRequest);
		}

		// Token: 0x06014488 RID: 83080 RVA: 0x002F2FFC File Offset: 0x002F11FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ReconnectRequest other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.LastSvrSeqNo == other.LastSvrSeqNo && !(this.ReconnectToken != other.ReconnectToken) && !(this.ReconnectTraceId != other.ReconnectTraceId) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014489 RID: 83081 RVA: 0x002F3070 File Offset: 0x002F1270
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

		// Token: 0x0601448A RID: 83082 RVA: 0x002F30FE File Offset: 0x002F12FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601448B RID: 83083 RVA: 0x002F310B File Offset: 0x002F130B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601448C RID: 83084 RVA: 0x002F3114 File Offset: 0x002F1314
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

		// Token: 0x0601448D RID: 83085 RVA: 0x002F31B0 File Offset: 0x002F13B0
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

		// Token: 0x0601448E RID: 83086 RVA: 0x002F3240 File Offset: 0x002F1440
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

		// Token: 0x0601448F RID: 83087 RVA: 0x002F32C2 File Offset: 0x002F14C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014490 RID: 83088 RVA: 0x002F32CC File Offset: 0x002F14CC
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

		// Token: 0x04007B9D RID: 31645
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007B9E RID: 31646
		public const int PlayerIdFieldNumber = 1;

		// Token: 0x04007B9F RID: 31647
		private int playerId_;

		// Token: 0x04007BA0 RID: 31648
		public const int LastSvrSeqNoFieldNumber = 2;

		// Token: 0x04007BA1 RID: 31649
		private int lastSvrSeqNo_;

		// Token: 0x04007BA2 RID: 31650
		public const int ReconnectTokenFieldNumber = 3;

		// Token: 0x04007BA3 RID: 31651
		private string reconnectToken_ = "";

		// Token: 0x04007BA4 RID: 31652
		public const int ReconnectTraceIdFieldNumber = 4;

		// Token: 0x04007BA5 RID: 31653
		private string reconnectTraceId_ = "";
	}
}
