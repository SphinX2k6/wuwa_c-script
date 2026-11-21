using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000533 RID: 1331
	[NetMessage(EMessageId.FishingActivityMilestoneRewardResponse)]
	public sealed class FishingActivityMilestoneRewardResponse : IMessage<FishingActivityMilestoneRewardResponse>, IMessage, IEquatable<FishingActivityMilestoneRewardResponse>, IDeepCloneable<FishingActivityMilestoneRewardResponse>, IBufferMessage
	{
		// Token: 0x06007D0C RID: 32012 RVA: 0x0012F520 File Offset: 0x0012D720
		[NullableContext(1)]
		public static FishingActivityMilestoneRewardResponse Create()
		{
			return new FishingActivityMilestoneRewardResponse();
		}

		// Token: 0x1700184E RID: 6222
		// (get) Token: 0x06007D0D RID: 32013 RVA: 0x0012F527 File Offset: 0x0012D727
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700184F RID: 6223
		// (get) Token: 0x06007D0E RID: 32014 RVA: 0x0012F52A File Offset: 0x0012D72A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingActivityMilestoneRewardResponse.Descriptor;
			}
		}

		// Token: 0x06007D0F RID: 32015 RVA: 0x0012F531 File Offset: 0x0012D731
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingActivityMilestoneRewardResponse()
		{
		}

		// Token: 0x06007D10 RID: 32016 RVA: 0x0012F539 File Offset: 0x0012D739
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingActivityMilestoneRewardResponse(FishingActivityMilestoneRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007D11 RID: 32017 RVA: 0x0012F55E File Offset: 0x0012D75E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingActivityMilestoneRewardResponse Clone()
		{
			return new FishingActivityMilestoneRewardResponse(this);
		}

		// Token: 0x17001850 RID: 6224
		// (get) Token: 0x06007D12 RID: 32018 RVA: 0x0012F566 File Offset: 0x0012D766
		// (set) Token: 0x06007D13 RID: 32019 RVA: 0x0012F56E File Offset: 0x0012D76E
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

		// Token: 0x06007D14 RID: 32020 RVA: 0x0012F577 File Offset: 0x0012D777
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingActivityMilestoneRewardResponse);
		}

		// Token: 0x06007D15 RID: 32021 RVA: 0x0012F585 File Offset: 0x0012D785
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingActivityMilestoneRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007D16 RID: 32022 RVA: 0x0012F5B4 File Offset: 0x0012D7B4
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

		// Token: 0x06007D17 RID: 32023 RVA: 0x0012F5F9 File Offset: 0x0012D7F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007D18 RID: 32024 RVA: 0x0012F606 File Offset: 0x0012D806
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007D19 RID: 32025 RVA: 0x0012F60F File Offset: 0x0012D80F
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

		// Token: 0x06007D1A RID: 32026 RVA: 0x0012F644 File Offset: 0x0012D844
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

		// Token: 0x06007D1B RID: 32027 RVA: 0x0012F682 File Offset: 0x0012D882
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingActivityMilestoneRewardResponse other)
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

		// Token: 0x06007D1C RID: 32028 RVA: 0x0012F6B3 File Offset: 0x0012D8B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007D1D RID: 32029 RVA: 0x0012F6BC File Offset: 0x0012D8BC
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

		// Token: 0x04004010 RID: 16400
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004011 RID: 16401
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x04004012 RID: 16402
		private ErrorCode errorCode_;
	}
}
