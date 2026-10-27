using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000949 RID: 2377
	[NetMessage(EMessageId.LogicStateInitResponse)]
	public sealed class LogicStateInitResponse : IMessage<LogicStateInitResponse>, IMessage, IEquatable<LogicStateInitResponse>, IDeepCloneable<LogicStateInitResponse>, IBufferMessage
	{
		// Token: 0x0600D158 RID: 53592 RVA: 0x001ECC99 File Offset: 0x001EAE99
		[NullableContext(1)]
		public static LogicStateInitResponse Create()
		{
			return new LogicStateInitResponse();
		}

		// Token: 0x17002A4C RID: 10828
		// (get) Token: 0x0600D159 RID: 53593 RVA: 0x001ECCA0 File Offset: 0x001EAEA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002A4D RID: 10829
		// (get) Token: 0x0600D15A RID: 53594 RVA: 0x001ECCA3 File Offset: 0x001EAEA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LogicStateInitResponse.Descriptor;
			}
		}

		// Token: 0x0600D15B RID: 53595 RVA: 0x001ECCAA File Offset: 0x001EAEAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogicStateInitResponse()
		{
		}

		// Token: 0x0600D15C RID: 53596 RVA: 0x001ECCB2 File Offset: 0x001EAEB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogicStateInitResponse(LogicStateInitResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D15D RID: 53597 RVA: 0x001ECCD7 File Offset: 0x001EAED7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LogicStateInitResponse Clone()
		{
			return new LogicStateInitResponse(this);
		}

		// Token: 0x17002A4E RID: 10830
		// (get) Token: 0x0600D15E RID: 53598 RVA: 0x001ECCDF File Offset: 0x001EAEDF
		// (set) Token: 0x0600D15F RID: 53599 RVA: 0x001ECCE7 File Offset: 0x001EAEE7
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

		// Token: 0x0600D160 RID: 53600 RVA: 0x001ECCF0 File Offset: 0x001EAEF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LogicStateInitResponse);
		}

		// Token: 0x0600D161 RID: 53601 RVA: 0x001ECCFE File Offset: 0x001EAEFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LogicStateInitResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D162 RID: 53602 RVA: 0x001ECD2C File Offset: 0x001EAF2C
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

		// Token: 0x0600D163 RID: 53603 RVA: 0x001ECD71 File Offset: 0x001EAF71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D164 RID: 53604 RVA: 0x001ECD7E File Offset: 0x001EAF7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D165 RID: 53605 RVA: 0x001ECD87 File Offset: 0x001EAF87
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

		// Token: 0x0600D166 RID: 53606 RVA: 0x001ECDBC File Offset: 0x001EAFBC
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

		// Token: 0x0600D167 RID: 53607 RVA: 0x001ECDFA File Offset: 0x001EAFFA
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

		// Token: 0x0600D168 RID: 53608 RVA: 0x001ECE2B File Offset: 0x001EB02B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D169 RID: 53609 RVA: 0x001ECE34 File Offset: 0x001EB034
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

		// Token: 0x0400580A RID: 22538
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400580B RID: 22539
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x0400580C RID: 22540
		private ErrorCode errorCode_;
	}
}
