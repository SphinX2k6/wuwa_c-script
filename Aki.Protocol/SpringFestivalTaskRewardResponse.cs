using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012EA RID: 4842
	[NetMessage(EMessageId.SpringFestivalTaskRewardResponse)]
	public sealed class SpringFestivalTaskRewardResponse : IMessage<SpringFestivalTaskRewardResponse>, IMessage, IEquatable<SpringFestivalTaskRewardResponse>, IDeepCloneable<SpringFestivalTaskRewardResponse>, IBufferMessage
	{
		// Token: 0x06019D6A RID: 105834 RVA: 0x003C50C8 File Offset: 0x003C32C8
		[NullableContext(1)]
		public static SpringFestivalTaskRewardResponse Create()
		{
			return new SpringFestivalTaskRewardResponse();
		}

		// Token: 0x17005786 RID: 22406
		// (get) Token: 0x06019D6B RID: 105835 RVA: 0x003C50CF File Offset: 0x003C32CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005787 RID: 22407
		// (get) Token: 0x06019D6C RID: 105836 RVA: 0x003C50D2 File Offset: 0x003C32D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SpringFestivalTaskRewardResponse.Descriptor;
			}
		}

		// Token: 0x06019D6D RID: 105837 RVA: 0x003C50D9 File Offset: 0x003C32D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringFestivalTaskRewardResponse()
		{
		}

		// Token: 0x06019D6E RID: 105838 RVA: 0x003C50E1 File Offset: 0x003C32E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringFestivalTaskRewardResponse(SpringFestivalTaskRewardResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019D6F RID: 105839 RVA: 0x003C5106 File Offset: 0x003C3306
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringFestivalTaskRewardResponse Clone()
		{
			return new SpringFestivalTaskRewardResponse(this);
		}

		// Token: 0x17005788 RID: 22408
		// (get) Token: 0x06019D70 RID: 105840 RVA: 0x003C510E File Offset: 0x003C330E
		// (set) Token: 0x06019D71 RID: 105841 RVA: 0x003C5116 File Offset: 0x003C3316
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrCode
		{
			get
			{
				return this.errCode_;
			}
			set
			{
				this.errCode_ = value;
			}
		}

		// Token: 0x06019D72 RID: 105842 RVA: 0x003C511F File Offset: 0x003C331F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SpringFestivalTaskRewardResponse);
		}

		// Token: 0x06019D73 RID: 105843 RVA: 0x003C512D File Offset: 0x003C332D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SpringFestivalTaskRewardResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019D74 RID: 105844 RVA: 0x003C515C File Offset: 0x003C335C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrCode != ErrorCode.Success)
			{
				num ^= this.ErrCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019D75 RID: 105845 RVA: 0x003C51A1 File Offset: 0x003C33A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019D76 RID: 105846 RVA: 0x003C51AE File Offset: 0x003C33AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019D77 RID: 105847 RVA: 0x003C51B7 File Offset: 0x003C33B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019D78 RID: 105848 RVA: 0x003C51EC File Offset: 0x003C33EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019D79 RID: 105849 RVA: 0x003C522A File Offset: 0x003C342A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SpringFestivalTaskRewardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrCode != ErrorCode.Success)
			{
				this.ErrCode = other.ErrCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019D7A RID: 105850 RVA: 0x003C525B File Offset: 0x003C345B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019D7B RID: 105851 RVA: 0x003C5264 File Offset: 0x003C3464
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
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009882 RID: 39042
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009883 RID: 39043
		public const int ErrCodeFieldNumber = 12;

		// Token: 0x04009884 RID: 39044
		private ErrorCode errCode_;
	}
}
