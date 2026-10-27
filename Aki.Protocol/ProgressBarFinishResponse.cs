using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DE9 RID: 3561
	[NetMessage(EMessageId.ProgressBarFinishResponse)]
	public sealed class ProgressBarFinishResponse : IMessage<ProgressBarFinishResponse>, IMessage, IEquatable<ProgressBarFinishResponse>, IDeepCloneable<ProgressBarFinishResponse>, IBufferMessage
	{
		// Token: 0x06013283 RID: 78467 RVA: 0x002CA56D File Offset: 0x002C876D
		[NullableContext(1)]
		public static ProgressBarFinishResponse Create()
		{
			return new ProgressBarFinishResponse();
		}

		// Token: 0x17003F8E RID: 16270
		// (get) Token: 0x06013284 RID: 78468 RVA: 0x002CA574 File Offset: 0x002C8774
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003F8F RID: 16271
		// (get) Token: 0x06013285 RID: 78469 RVA: 0x002CA577 File Offset: 0x002C8777
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ProgressBarFinishResponse.Descriptor;
			}
		}

		// Token: 0x06013286 RID: 78470 RVA: 0x002CA57E File Offset: 0x002C877E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ProgressBarFinishResponse()
		{
		}

		// Token: 0x06013287 RID: 78471 RVA: 0x002CA586 File Offset: 0x002C8786
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ProgressBarFinishResponse(ProgressBarFinishResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013288 RID: 78472 RVA: 0x002CA5AB File Offset: 0x002C87AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ProgressBarFinishResponse Clone()
		{
			return new ProgressBarFinishResponse(this);
		}

		// Token: 0x17003F90 RID: 16272
		// (get) Token: 0x06013289 RID: 78473 RVA: 0x002CA5B3 File Offset: 0x002C87B3
		// (set) Token: 0x0601328A RID: 78474 RVA: 0x002CA5BB File Offset: 0x002C87BB
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

		// Token: 0x0601328B RID: 78475 RVA: 0x002CA5C4 File Offset: 0x002C87C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ProgressBarFinishResponse);
		}

		// Token: 0x0601328C RID: 78476 RVA: 0x002CA5D2 File Offset: 0x002C87D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ProgressBarFinishResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601328D RID: 78477 RVA: 0x002CA600 File Offset: 0x002C8800
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

		// Token: 0x0601328E RID: 78478 RVA: 0x002CA645 File Offset: 0x002C8845
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601328F RID: 78479 RVA: 0x002CA652 File Offset: 0x002C8852
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013290 RID: 78480 RVA: 0x002CA65B File Offset: 0x002C885B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013291 RID: 78481 RVA: 0x002CA690 File Offset: 0x002C8890
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

		// Token: 0x06013292 RID: 78482 RVA: 0x002CA6CE File Offset: 0x002C88CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ProgressBarFinishResponse other)
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

		// Token: 0x06013293 RID: 78483 RVA: 0x002CA6FF File Offset: 0x002C88FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013294 RID: 78484 RVA: 0x002CA708 File Offset: 0x002C8908
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007603 RID: 30211
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007604 RID: 30212
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x04007605 RID: 30213
		private ErrorCode errorCode_;
	}
}
