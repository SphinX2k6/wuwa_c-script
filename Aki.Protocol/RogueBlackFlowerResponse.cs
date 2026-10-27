using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F82 RID: 3970
	[NetMessage(EMessageId.RogueBlackFlowerResponse)]
	public sealed class RogueBlackFlowerResponse : IMessage<RogueBlackFlowerResponse>, IMessage, IEquatable<RogueBlackFlowerResponse>, IDeepCloneable<RogueBlackFlowerResponse>, IBufferMessage
	{
		// Token: 0x0601538A RID: 86922 RVA: 0x003138F4 File Offset: 0x00311AF4
		[NullableContext(1)]
		public static RogueBlackFlowerResponse Create()
		{
			return new RogueBlackFlowerResponse();
		}

		// Token: 0x1700469B RID: 18075
		// (get) Token: 0x0601538B RID: 86923 RVA: 0x003138FB File Offset: 0x00311AFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700469C RID: 18076
		// (get) Token: 0x0601538C RID: 86924 RVA: 0x003138FE File Offset: 0x00311AFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueBlackFlowerResponse.Descriptor;
			}
		}

		// Token: 0x0601538D RID: 86925 RVA: 0x00313905 File Offset: 0x00311B05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueBlackFlowerResponse()
		{
		}

		// Token: 0x0601538E RID: 86926 RVA: 0x0031390D File Offset: 0x00311B0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueBlackFlowerResponse(RogueBlackFlowerResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601538F RID: 86927 RVA: 0x00313932 File Offset: 0x00311B32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueBlackFlowerResponse Clone()
		{
			return new RogueBlackFlowerResponse(this);
		}

		// Token: 0x1700469D RID: 18077
		// (get) Token: 0x06015390 RID: 86928 RVA: 0x0031393A File Offset: 0x00311B3A
		// (set) Token: 0x06015391 RID: 86929 RVA: 0x00313942 File Offset: 0x00311B42
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

		// Token: 0x06015392 RID: 86930 RVA: 0x0031394B File Offset: 0x00311B4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueBlackFlowerResponse);
		}

		// Token: 0x06015393 RID: 86931 RVA: 0x00313959 File Offset: 0x00311B59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueBlackFlowerResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015394 RID: 86932 RVA: 0x00313988 File Offset: 0x00311B88
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

		// Token: 0x06015395 RID: 86933 RVA: 0x003139CD File Offset: 0x00311BCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015396 RID: 86934 RVA: 0x003139DA File Offset: 0x00311BDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015397 RID: 86935 RVA: 0x003139E3 File Offset: 0x00311BE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015398 RID: 86936 RVA: 0x00313A18 File Offset: 0x00311C18
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

		// Token: 0x06015399 RID: 86937 RVA: 0x00313A56 File Offset: 0x00311C56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueBlackFlowerResponse other)
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

		// Token: 0x0601539A RID: 86938 RVA: 0x00313A87 File Offset: 0x00311C87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601539B RID: 86939 RVA: 0x00313A90 File Offset: 0x00311C90
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
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007F91 RID: 32657
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007F92 RID: 32658
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x04007F93 RID: 32659
		private ErrorCode errorCode_;
	}
}
