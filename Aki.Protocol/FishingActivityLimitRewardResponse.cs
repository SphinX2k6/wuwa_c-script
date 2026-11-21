using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200052E RID: 1326
	[NetMessage(EMessageId.FishingActivityLimitRewardResponse)]
	public sealed class FishingActivityLimitRewardResponse : IMessage<FishingActivityLimitRewardResponse>, IMessage, IEquatable<FishingActivityLimitRewardResponse>, IDeepCloneable<FishingActivityLimitRewardResponse>, IBufferMessage
	{
		// Token: 0x06007CB0 RID: 31920 RVA: 0x0012EAD5 File Offset: 0x0012CCD5
		[NullableContext(1)]
		public static FishingActivityLimitRewardResponse Create()
		{
			return new FishingActivityLimitRewardResponse();
		}

		// Token: 0x1700183E RID: 6206
		// (get) Token: 0x06007CB1 RID: 31921 RVA: 0x0012EADC File Offset: 0x0012CCDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700183F RID: 6207
		// (get) Token: 0x06007CB2 RID: 31922 RVA: 0x0012EADF File Offset: 0x0012CCDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingActivityLimitRewardResponse.Descriptor;
			}
		}

		// Token: 0x06007CB3 RID: 31923 RVA: 0x0012EAE6 File Offset: 0x0012CCE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingActivityLimitRewardResponse()
		{
		}

		// Token: 0x06007CB4 RID: 31924 RVA: 0x0012EAEE File Offset: 0x0012CCEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingActivityLimitRewardResponse(FishingActivityLimitRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007CB5 RID: 31925 RVA: 0x0012EB13 File Offset: 0x0012CD13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingActivityLimitRewardResponse Clone()
		{
			return new FishingActivityLimitRewardResponse(this);
		}

		// Token: 0x17001840 RID: 6208
		// (get) Token: 0x06007CB6 RID: 31926 RVA: 0x0012EB1B File Offset: 0x0012CD1B
		// (set) Token: 0x06007CB7 RID: 31927 RVA: 0x0012EB23 File Offset: 0x0012CD23
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

		// Token: 0x06007CB8 RID: 31928 RVA: 0x0012EB2C File Offset: 0x0012CD2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingActivityLimitRewardResponse);
		}

		// Token: 0x06007CB9 RID: 31929 RVA: 0x0012EB3A File Offset: 0x0012CD3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingActivityLimitRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007CBA RID: 31930 RVA: 0x0012EB68 File Offset: 0x0012CD68
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

		// Token: 0x06007CBB RID: 31931 RVA: 0x0012EBAD File Offset: 0x0012CDAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007CBC RID: 31932 RVA: 0x0012EBBA File Offset: 0x0012CDBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007CBD RID: 31933 RVA: 0x0012EBC3 File Offset: 0x0012CDC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007CBE RID: 31934 RVA: 0x0012EBF8 File Offset: 0x0012CDF8
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

		// Token: 0x06007CBF RID: 31935 RVA: 0x0012EC36 File Offset: 0x0012CE36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingActivityLimitRewardResponse other)
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

		// Token: 0x06007CC0 RID: 31936 RVA: 0x0012EC67 File Offset: 0x0012CE67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007CC1 RID: 31937 RVA: 0x0012EC70 File Offset: 0x0012CE70
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003FFC RID: 16380
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003FFD RID: 16381
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x04003FFE RID: 16382
		private ErrorCode errorCode_;
	}
}
