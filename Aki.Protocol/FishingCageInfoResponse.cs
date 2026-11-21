using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000538 RID: 1336
	[NetMessage(EMessageId.FishingCageInfoResponse)]
	public sealed class FishingCageInfoResponse : IMessage<FishingCageInfoResponse>, IMessage, IEquatable<FishingCageInfoResponse>, IDeepCloneable<FishingCageInfoResponse>, IBufferMessage
	{
		// Token: 0x06007D71 RID: 32113 RVA: 0x00130339 File Offset: 0x0012E539
		[NullableContext(1)]
		public static FishingCageInfoResponse Create()
		{
			return new FishingCageInfoResponse();
		}

		// Token: 0x17001863 RID: 6243
		// (get) Token: 0x06007D72 RID: 32114 RVA: 0x00130340 File Offset: 0x0012E540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001864 RID: 6244
		// (get) Token: 0x06007D73 RID: 32115 RVA: 0x00130343 File Offset: 0x0012E543
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingCageInfoResponse.Descriptor;
			}
		}

		// Token: 0x06007D74 RID: 32116 RVA: 0x0013034A File Offset: 0x0012E54A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingCageInfoResponse()
		{
		}

		// Token: 0x06007D75 RID: 32117 RVA: 0x00130354 File Offset: 0x0012E554
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingCageInfoResponse(FishingCageInfoResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.fishCageInfo_ = ((other.fishCageInfo_ != null) ? other.fishCageInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007D76 RID: 32118 RVA: 0x001303A0 File Offset: 0x0012E5A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingCageInfoResponse Clone()
		{
			return new FishingCageInfoResponse(this);
		}

		// Token: 0x17001865 RID: 6245
		// (get) Token: 0x06007D77 RID: 32119 RVA: 0x001303A8 File Offset: 0x0012E5A8
		// (set) Token: 0x06007D78 RID: 32120 RVA: 0x001303B0 File Offset: 0x0012E5B0
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

		// Token: 0x17001866 RID: 6246
		// (get) Token: 0x06007D79 RID: 32121 RVA: 0x001303B9 File Offset: 0x0012E5B9
		// (set) Token: 0x06007D7A RID: 32122 RVA: 0x001303C1 File Offset: 0x0012E5C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OneFishCage FishCageInfo
		{
			get
			{
				return this.fishCageInfo_;
			}
			set
			{
				this.fishCageInfo_ = value;
			}
		}

		// Token: 0x06007D7B RID: 32123 RVA: 0x001303CA File Offset: 0x0012E5CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingCageInfoResponse);
		}

		// Token: 0x06007D7C RID: 32124 RVA: 0x001303D8 File Offset: 0x0012E5D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingCageInfoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.FishCageInfo, other.FishCageInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007D7D RID: 32125 RVA: 0x00130428 File Offset: 0x0012E628
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.fishCageInfo_ != null)
			{
				num ^= this.FishCageInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007D7E RID: 32126 RVA: 0x00130483 File Offset: 0x0012E683
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007D7F RID: 32127 RVA: 0x00130490 File Offset: 0x0012E690
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007D80 RID: 32128 RVA: 0x0013049C File Offset: 0x0012E69C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.fishCageInfo_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.FishCageInfo);
			}
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

		// Token: 0x06007D81 RID: 32129 RVA: 0x001304F8 File Offset: 0x0012E6F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.fishCageInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FishCageInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007D82 RID: 32130 RVA: 0x00130550 File Offset: 0x0012E750
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingCageInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.fishCageInfo_ != null)
			{
				if (this.fishCageInfo_ == null)
				{
					this.FishCageInfo = new OneFishCage();
				}
				this.FishCageInfo.MergeFrom(other.FishCageInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007D83 RID: 32131 RVA: 0x001305B8 File Offset: 0x0012E7B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007D84 RID: 32132 RVA: 0x001305C4 File Offset: 0x0012E7C4
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
				if (num != 18U)
				{
					if (num != 40U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					if (this.fishCageInfo_ == null)
					{
						this.FishCageInfo = new OneFishCage();
					}
					input.ReadMessage(this.FishCageInfo);
				}
			}
		}

		// Token: 0x0400402D RID: 16429
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400402E RID: 16430
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x0400402F RID: 16431
		private ErrorCode errorCode_;

		// Token: 0x04004030 RID: 16432
		public const int FishCageInfoFieldNumber = 2;

		// Token: 0x04004031 RID: 16433
		private OneFishCage fishCageInfo_;
	}
}
