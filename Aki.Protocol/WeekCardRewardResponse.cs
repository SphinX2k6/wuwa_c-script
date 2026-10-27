using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001509 RID: 5385
	[NetMessage(EMessageId.WeekCardRewardResponse)]
	public sealed class WeekCardRewardResponse : IMessage<WeekCardRewardResponse>, IMessage, IEquatable<WeekCardRewardResponse>, IDeepCloneable<WeekCardRewardResponse>, IBufferMessage
	{
		// Token: 0x0601C766 RID: 116582 RVA: 0x0041C695 File Offset: 0x0041A895
		[NullableContext(1)]
		public static WeekCardRewardResponse Create()
		{
			return new WeekCardRewardResponse();
		}

		// Token: 0x17005FF3 RID: 24563
		// (get) Token: 0x0601C767 RID: 116583 RVA: 0x0041C69C File Offset: 0x0041A89C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005FF4 RID: 24564
		// (get) Token: 0x0601C768 RID: 116584 RVA: 0x0041C69F File Offset: 0x0041A89F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WeekCardRewardResponse.Descriptor;
			}
		}

		// Token: 0x0601C769 RID: 116585 RVA: 0x0041C6A6 File Offset: 0x0041A8A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeekCardRewardResponse()
		{
		}

		// Token: 0x0601C76A RID: 116586 RVA: 0x0041C6AE File Offset: 0x0041A8AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeekCardRewardResponse(WeekCardRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C76B RID: 116587 RVA: 0x0041C6D3 File Offset: 0x0041A8D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeekCardRewardResponse Clone()
		{
			return new WeekCardRewardResponse(this);
		}

		// Token: 0x17005FF5 RID: 24565
		// (get) Token: 0x0601C76C RID: 116588 RVA: 0x0041C6DB File Offset: 0x0041A8DB
		// (set) Token: 0x0601C76D RID: 116589 RVA: 0x0041C6E3 File Offset: 0x0041A8E3
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

		// Token: 0x0601C76E RID: 116590 RVA: 0x0041C6EC File Offset: 0x0041A8EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WeekCardRewardResponse);
		}

		// Token: 0x0601C76F RID: 116591 RVA: 0x0041C6FA File Offset: 0x0041A8FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WeekCardRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C770 RID: 116592 RVA: 0x0041C728 File Offset: 0x0041A928
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

		// Token: 0x0601C771 RID: 116593 RVA: 0x0041C76D File Offset: 0x0041A96D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C772 RID: 116594 RVA: 0x0041C77A File Offset: 0x0041A97A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C773 RID: 116595 RVA: 0x0041C783 File Offset: 0x0041A983
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

		// Token: 0x0601C774 RID: 116596 RVA: 0x0041C7B8 File Offset: 0x0041A9B8
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

		// Token: 0x0601C775 RID: 116597 RVA: 0x0041C7F6 File Offset: 0x0041A9F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WeekCardRewardResponse other)
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

		// Token: 0x0601C776 RID: 116598 RVA: 0x0041C827 File Offset: 0x0041AA27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C777 RID: 116599 RVA: 0x0041C830 File Offset: 0x0041AA30
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

		// Token: 0x0400A2ED RID: 41709
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A2EE RID: 41710
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x0400A2EF RID: 41711
		private ErrorCode errorCode_;
	}
}
