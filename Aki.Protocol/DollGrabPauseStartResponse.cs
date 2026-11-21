using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003DC RID: 988
	[NetMessage(EMessageId.DollGrabPauseStartResponse)]
	public sealed class DollGrabPauseStartResponse : IMessage<DollGrabPauseStartResponse>, IMessage, IEquatable<DollGrabPauseStartResponse>, IDeepCloneable<DollGrabPauseStartResponse>, IBufferMessage
	{
		// Token: 0x06006055 RID: 24661 RVA: 0x000E8DF1 File Offset: 0x000E6FF1
		[NullableContext(1)]
		public static DollGrabPauseStartResponse Create()
		{
			return new DollGrabPauseStartResponse();
		}

		// Token: 0x170011E9 RID: 4585
		// (get) Token: 0x06006056 RID: 24662 RVA: 0x000E8DF8 File Offset: 0x000E6FF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170011EA RID: 4586
		// (get) Token: 0x06006057 RID: 24663 RVA: 0x000E8DFB File Offset: 0x000E6FFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DollGrabPauseStartResponse.Descriptor;
			}
		}

		// Token: 0x06006058 RID: 24664 RVA: 0x000E8E02 File Offset: 0x000E7002
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGrabPauseStartResponse()
		{
		}

		// Token: 0x06006059 RID: 24665 RVA: 0x000E8E0A File Offset: 0x000E700A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGrabPauseStartResponse(DollGrabPauseStartResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600605A RID: 24666 RVA: 0x000E8E2F File Offset: 0x000E702F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGrabPauseStartResponse Clone()
		{
			return new DollGrabPauseStartResponse(this);
		}

		// Token: 0x170011EB RID: 4587
		// (get) Token: 0x0600605B RID: 24667 RVA: 0x000E8E37 File Offset: 0x000E7037
		// (set) Token: 0x0600605C RID: 24668 RVA: 0x000E8E3F File Offset: 0x000E703F
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

		// Token: 0x0600605D RID: 24669 RVA: 0x000E8E48 File Offset: 0x000E7048
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DollGrabPauseStartResponse);
		}

		// Token: 0x0600605E RID: 24670 RVA: 0x000E8E56 File Offset: 0x000E7056
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DollGrabPauseStartResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600605F RID: 24671 RVA: 0x000E8E84 File Offset: 0x000E7084
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

		// Token: 0x06006060 RID: 24672 RVA: 0x000E8EC9 File Offset: 0x000E70C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006061 RID: 24673 RVA: 0x000E8ED6 File Offset: 0x000E70D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006062 RID: 24674 RVA: 0x000E8EDF File Offset: 0x000E70DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006063 RID: 24675 RVA: 0x000E8F14 File Offset: 0x000E7114
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

		// Token: 0x06006064 RID: 24676 RVA: 0x000E8F52 File Offset: 0x000E7152
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DollGrabPauseStartResponse other)
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

		// Token: 0x06006065 RID: 24677 RVA: 0x000E8F83 File Offset: 0x000E7183
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006066 RID: 24678 RVA: 0x000E8F8C File Offset: 0x000E718C
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
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040037A4 RID: 14244
		private UnknownFieldSet _unknownFields;

		// Token: 0x040037A5 RID: 14245
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x040037A6 RID: 14246
		private ErrorCode errorCode_;
	}
}
