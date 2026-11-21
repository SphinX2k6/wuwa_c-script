using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200009F RID: 159
	[NetMessage(EMessageId.AddChapterResultResponse)]
	public sealed class AddChapterResultResponse : IMessage<AddChapterResultResponse>, IMessage, IEquatable<AddChapterResultResponse>, IDeepCloneable<AddChapterResultResponse>, IBufferMessage
	{
		// Token: 0x06001C60 RID: 7264 RVA: 0x0004EE4B File Offset: 0x0004D04B
		[NullableContext(1)]
		public static AddChapterResultResponse Create()
		{
			return new AddChapterResultResponse();
		}

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x06001C61 RID: 7265 RVA: 0x0004EE52 File Offset: 0x0004D052
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x06001C62 RID: 7266 RVA: 0x0004EE55 File Offset: 0x0004D055
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AddChapterResultResponse.Descriptor;
			}
		}

		// Token: 0x06001C63 RID: 7267 RVA: 0x0004EE5C File Offset: 0x0004D05C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddChapterResultResponse()
		{
		}

		// Token: 0x06001C64 RID: 7268 RVA: 0x0004EE64 File Offset: 0x0004D064
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddChapterResultResponse(AddChapterResultResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001C65 RID: 7269 RVA: 0x0004EE89 File Offset: 0x0004D089
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AddChapterResultResponse Clone()
		{
			return new AddChapterResultResponse(this);
		}

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x06001C66 RID: 7270 RVA: 0x0004EE91 File Offset: 0x0004D091
		// (set) Token: 0x06001C67 RID: 7271 RVA: 0x0004EE99 File Offset: 0x0004D099
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

		// Token: 0x06001C68 RID: 7272 RVA: 0x0004EEA2 File Offset: 0x0004D0A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AddChapterResultResponse);
		}

		// Token: 0x06001C69 RID: 7273 RVA: 0x0004EEB0 File Offset: 0x0004D0B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AddChapterResultResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001C6A RID: 7274 RVA: 0x0004EEE0 File Offset: 0x0004D0E0
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

		// Token: 0x06001C6B RID: 7275 RVA: 0x0004EF25 File Offset: 0x0004D125
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001C6C RID: 7276 RVA: 0x0004EF32 File Offset: 0x0004D132
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001C6D RID: 7277 RVA: 0x0004EF3B File Offset: 0x0004D13B
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

		// Token: 0x06001C6E RID: 7278 RVA: 0x0004EF70 File Offset: 0x0004D170
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

		// Token: 0x06001C6F RID: 7279 RVA: 0x0004EFAE File Offset: 0x0004D1AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AddChapterResultResponse other)
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

		// Token: 0x06001C70 RID: 7280 RVA: 0x0004EFDF File Offset: 0x0004D1DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001C71 RID: 7281 RVA: 0x0004EFE8 File Offset: 0x0004D1E8
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

		// Token: 0x04002328 RID: 9000
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002329 RID: 9001
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x0400232A RID: 9002
		private ErrorCode errorCode_;
	}
}
