using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011E9 RID: 4585
	[NetMessage(EMessageId.SecFBRoundStartFlowResponse)]
	public sealed class SecFBRoundStartFlowResponse : IMessage<SecFBRoundStartFlowResponse>, IMessage, IEquatable<SecFBRoundStartFlowResponse>, IDeepCloneable<SecFBRoundStartFlowResponse>, IBufferMessage
	{
		// Token: 0x060187BA RID: 100282 RVA: 0x00390F41 File Offset: 0x0038F141
		[NullableContext(1)]
		public static SecFBRoundStartFlowResponse Create()
		{
			return new SecFBRoundStartFlowResponse();
		}

		// Token: 0x17005295 RID: 21141
		// (get) Token: 0x060187BB RID: 100283 RVA: 0x00390F48 File Offset: 0x0038F148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005296 RID: 21142
		// (get) Token: 0x060187BC RID: 100284 RVA: 0x00390F4B File Offset: 0x0038F14B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SecFBRoundStartFlowResponse.Descriptor;
			}
		}

		// Token: 0x060187BD RID: 100285 RVA: 0x00390F52 File Offset: 0x0038F152
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecFBRoundStartFlowResponse()
		{
		}

		// Token: 0x060187BE RID: 100286 RVA: 0x00390F5A File Offset: 0x0038F15A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecFBRoundStartFlowResponse(SecFBRoundStartFlowResponse other) : this()
		{
			this.logId_ = other.logId_;
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060187BF RID: 100287 RVA: 0x00390F8B File Offset: 0x0038F18B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SecFBRoundStartFlowResponse Clone()
		{
			return new SecFBRoundStartFlowResponse(this);
		}

		// Token: 0x17005297 RID: 21143
		// (get) Token: 0x060187C0 RID: 100288 RVA: 0x00390F93 File Offset: 0x0038F193
		// (set) Token: 0x060187C1 RID: 100289 RVA: 0x00390F9B File Offset: 0x0038F19B
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

		// Token: 0x17005298 RID: 21144
		// (get) Token: 0x060187C2 RID: 100290 RVA: 0x00390FA4 File Offset: 0x0038F1A4
		// (set) Token: 0x060187C3 RID: 100291 RVA: 0x00390FAC File Offset: 0x0038F1AC
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

		// Token: 0x060187C4 RID: 100292 RVA: 0x00390FB5 File Offset: 0x0038F1B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SecFBRoundStartFlowResponse);
		}

		// Token: 0x060187C5 RID: 100293 RVA: 0x00390FC3 File Offset: 0x0038F1C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SecFBRoundStartFlowResponse other)
		{
			return other != null && (other == this || (this.LogId == other.LogId && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060187C6 RID: 100294 RVA: 0x00391004 File Offset: 0x0038F204
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LogId != 0L)
			{
				num ^= this.LogId.GetHashCode();
			}
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

		// Token: 0x060187C7 RID: 100295 RVA: 0x00391062 File Offset: 0x0038F262
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060187C8 RID: 100296 RVA: 0x0039106F File Offset: 0x0038F26F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060187C9 RID: 100297 RVA: 0x00391078 File Offset: 0x0038F278
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.LogId != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.LogId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060187CA RID: 100298 RVA: 0x003910D4 File Offset: 0x0038F2D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LogId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.LogId);
			}
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

		// Token: 0x060187CB RID: 100299 RVA: 0x0039112C File Offset: 0x0038F32C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SecFBRoundStartFlowResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LogId != 0L)
			{
				this.LogId = other.LogId;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060187CC RID: 100300 RVA: 0x0039117C File Offset: 0x0038F37C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060187CD RID: 100301 RVA: 0x00391188 File Offset: 0x0038F388
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
				if (num != 32U)
				{
					if (num != 96U)
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009178 RID: 37240
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009179 RID: 37241
		public const int LogIdFieldNumber = 12;

		// Token: 0x0400917A RID: 37242
		private long logId_;

		// Token: 0x0400917B RID: 37243
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x0400917C RID: 37244
		private ErrorCode errorCode_;
	}
}
