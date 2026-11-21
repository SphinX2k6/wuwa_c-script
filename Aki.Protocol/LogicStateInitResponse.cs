using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000938 RID: 2360
	[NetMessage(EMessageId.LogicStateInitResponse)]
	public sealed class LogicStateInitResponse : IMessage<LogicStateInitResponse>, IMessage, IEquatable<LogicStateInitResponse>, IDeepCloneable<LogicStateInitResponse>, IBufferMessage
	{
		// Token: 0x0600D03C RID: 53308 RVA: 0x001EA9C5 File Offset: 0x001E8BC5
		[NullableContext(1)]
		public static LogicStateInitResponse Create()
		{
			return new LogicStateInitResponse();
		}

		// Token: 0x17002A0D RID: 10765
		// (get) Token: 0x0600D03D RID: 53309 RVA: 0x001EA9CC File Offset: 0x001E8BCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002A0E RID: 10766
		// (get) Token: 0x0600D03E RID: 53310 RVA: 0x001EA9CF File Offset: 0x001E8BCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LogicStateInitResponse.Descriptor;
			}
		}

		// Token: 0x0600D03F RID: 53311 RVA: 0x001EA9D6 File Offset: 0x001E8BD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogicStateInitResponse()
		{
		}

		// Token: 0x0600D040 RID: 53312 RVA: 0x001EA9DE File Offset: 0x001E8BDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogicStateInitResponse(LogicStateInitResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D041 RID: 53313 RVA: 0x001EAA03 File Offset: 0x001E8C03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogicStateInitResponse Clone()
		{
			return new LogicStateInitResponse(this);
		}

		// Token: 0x17002A0F RID: 10767
		// (get) Token: 0x0600D042 RID: 53314 RVA: 0x001EAA0B File Offset: 0x001E8C0B
		// (set) Token: 0x0600D043 RID: 53315 RVA: 0x001EAA13 File Offset: 0x001E8C13
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

		// Token: 0x0600D044 RID: 53316 RVA: 0x001EAA1C File Offset: 0x001E8C1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LogicStateInitResponse);
		}

		// Token: 0x0600D045 RID: 53317 RVA: 0x001EAA2A File Offset: 0x001E8C2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LogicStateInitResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D046 RID: 53318 RVA: 0x001EAA58 File Offset: 0x001E8C58
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

		// Token: 0x0600D047 RID: 53319 RVA: 0x001EAA9D File Offset: 0x001E8C9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D048 RID: 53320 RVA: 0x001EAAAA File Offset: 0x001E8CAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D049 RID: 53321 RVA: 0x001EAAB3 File Offset: 0x001E8CB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D04A RID: 53322 RVA: 0x001EAAE8 File Offset: 0x001E8CE8
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

		// Token: 0x0600D04B RID: 53323 RVA: 0x001EAB26 File Offset: 0x001E8D26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LogicStateInitResponse other)
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

		// Token: 0x0600D04C RID: 53324 RVA: 0x001EAB57 File Offset: 0x001E8D57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D04D RID: 53325 RVA: 0x001EAB60 File Offset: 0x001E8D60
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
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005811 RID: 22545
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005812 RID: 22546
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x04005813 RID: 22547
		private ErrorCode errorCode_;
	}
}
