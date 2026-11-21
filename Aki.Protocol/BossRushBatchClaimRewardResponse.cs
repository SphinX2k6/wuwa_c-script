using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001D3 RID: 467
	[NetMessage(EMessageId.BossRushBatchClaimRewardResponse)]
	public sealed class BossRushBatchClaimRewardResponse : IMessage<BossRushBatchClaimRewardResponse>, IMessage, IEquatable<BossRushBatchClaimRewardResponse>, IDeepCloneable<BossRushBatchClaimRewardResponse>, IBufferMessage
	{
		// Token: 0x06003551 RID: 13649 RVA: 0x0008673C File Offset: 0x0008493C
		[NullableContext(1)]
		public static BossRushBatchClaimRewardResponse Create()
		{
			return new BossRushBatchClaimRewardResponse();
		}

		// Token: 0x1700087B RID: 2171
		// (get) Token: 0x06003552 RID: 13650 RVA: 0x00086743 File Offset: 0x00084943
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700087C RID: 2172
		// (get) Token: 0x06003553 RID: 13651 RVA: 0x00086746 File Offset: 0x00084946
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BossRushBatchClaimRewardResponse.Descriptor;
			}
		}

		// Token: 0x06003554 RID: 13652 RVA: 0x0008674D File Offset: 0x0008494D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushBatchClaimRewardResponse()
		{
		}

		// Token: 0x06003555 RID: 13653 RVA: 0x00086755 File Offset: 0x00084955
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushBatchClaimRewardResponse(BossRushBatchClaimRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003556 RID: 13654 RVA: 0x0008677A File Offset: 0x0008497A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushBatchClaimRewardResponse Clone()
		{
			return new BossRushBatchClaimRewardResponse(this);
		}

		// Token: 0x1700087D RID: 2173
		// (get) Token: 0x06003557 RID: 13655 RVA: 0x00086782 File Offset: 0x00084982
		// (set) Token: 0x06003558 RID: 13656 RVA: 0x0008678A File Offset: 0x0008498A
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

		// Token: 0x06003559 RID: 13657 RVA: 0x00086793 File Offset: 0x00084993
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BossRushBatchClaimRewardResponse);
		}

		// Token: 0x0600355A RID: 13658 RVA: 0x000867A1 File Offset: 0x000849A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BossRushBatchClaimRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600355B RID: 13659 RVA: 0x000867D0 File Offset: 0x000849D0
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

		// Token: 0x0600355C RID: 13660 RVA: 0x00086815 File Offset: 0x00084A15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600355D RID: 13661 RVA: 0x00086822 File Offset: 0x00084A22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600355E RID: 13662 RVA: 0x0008682B File Offset: 0x00084A2B
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

		// Token: 0x0600355F RID: 13663 RVA: 0x00086860 File Offset: 0x00084A60
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

		// Token: 0x06003560 RID: 13664 RVA: 0x0008689E File Offset: 0x00084A9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BossRushBatchClaimRewardResponse other)
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

		// Token: 0x06003561 RID: 13665 RVA: 0x000868CF File Offset: 0x00084ACF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003562 RID: 13666 RVA: 0x000868D8 File Offset: 0x00084AD8
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

		// Token: 0x04002A9D RID: 10909
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002A9E RID: 10910
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x04002A9F RID: 10911
		private ErrorCode errorCode_;
	}
}
