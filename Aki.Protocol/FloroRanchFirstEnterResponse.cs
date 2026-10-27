using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005B3 RID: 1459
	[NetMessage(EMessageId.FloroRanchFirstEnterResponse)]
	public sealed class FloroRanchFirstEnterResponse : IMessage<FloroRanchFirstEnterResponse>, IMessage, IEquatable<FloroRanchFirstEnterResponse>, IDeepCloneable<FloroRanchFirstEnterResponse>, IBufferMessage
	{
		// Token: 0x060086CC RID: 34508 RVA: 0x00143F18 File Offset: 0x00142118
		[NullableContext(1)]
		public static FloroRanchFirstEnterResponse Create()
		{
			return new FloroRanchFirstEnterResponse();
		}

		// Token: 0x17001A4F RID: 6735
		// (get) Token: 0x060086CD RID: 34509 RVA: 0x00143F1F File Offset: 0x0014211F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001A50 RID: 6736
		// (get) Token: 0x060086CE RID: 34510 RVA: 0x00143F22 File Offset: 0x00142122
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchFirstEnterResponse.Descriptor;
			}
		}

		// Token: 0x060086CF RID: 34511 RVA: 0x00143F29 File Offset: 0x00142129
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchFirstEnterResponse()
		{
		}

		// Token: 0x060086D0 RID: 34512 RVA: 0x00143F31 File Offset: 0x00142131
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchFirstEnterResponse(FloroRanchFirstEnterResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060086D1 RID: 34513 RVA: 0x00143F56 File Offset: 0x00142156
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchFirstEnterResponse Clone()
		{
			return new FloroRanchFirstEnterResponse(this);
		}

		// Token: 0x17001A51 RID: 6737
		// (get) Token: 0x060086D2 RID: 34514 RVA: 0x00143F5E File Offset: 0x0014215E
		// (set) Token: 0x060086D3 RID: 34515 RVA: 0x00143F66 File Offset: 0x00142166
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

		// Token: 0x060086D4 RID: 34516 RVA: 0x00143F6F File Offset: 0x0014216F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchFirstEnterResponse);
		}

		// Token: 0x060086D5 RID: 34517 RVA: 0x00143F7D File Offset: 0x0014217D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchFirstEnterResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060086D6 RID: 34518 RVA: 0x00143FAC File Offset: 0x001421AC
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

		// Token: 0x060086D7 RID: 34519 RVA: 0x00143FF1 File Offset: 0x001421F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060086D8 RID: 34520 RVA: 0x00143FFE File Offset: 0x001421FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060086D9 RID: 34521 RVA: 0x00144007 File Offset: 0x00142207
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060086DA RID: 34522 RVA: 0x0014403C File Offset: 0x0014223C
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

		// Token: 0x060086DB RID: 34523 RVA: 0x0014407A File Offset: 0x0014227A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchFirstEnterResponse other)
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

		// Token: 0x060086DC RID: 34524 RVA: 0x001440AB File Offset: 0x001422AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060086DD RID: 34525 RVA: 0x001440B4 File Offset: 0x001422B4
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400426C RID: 17004
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400426D RID: 17005
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x0400426E RID: 17006
		private ErrorCode errorCode_;
	}
}
