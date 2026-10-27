using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000555 RID: 1365
	[NetMessage(EMessageId.FishingEntrustRefreshResponse)]
	public sealed class FishingEntrustRefreshResponse : IMessage<FishingEntrustRefreshResponse>, IMessage, IEquatable<FishingEntrustRefreshResponse>, IDeepCloneable<FishingEntrustRefreshResponse>, IBufferMessage
	{
		// Token: 0x06007F75 RID: 32629 RVA: 0x001343A5 File Offset: 0x001325A5
		[NullableContext(1)]
		public static FishingEntrustRefreshResponse Create()
		{
			return new FishingEntrustRefreshResponse();
		}

		// Token: 0x170018CF RID: 6351
		// (get) Token: 0x06007F76 RID: 32630 RVA: 0x001343AC File Offset: 0x001325AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170018D0 RID: 6352
		// (get) Token: 0x06007F77 RID: 32631 RVA: 0x001343AF File Offset: 0x001325AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingEntrustRefreshResponse.Descriptor;
			}
		}

		// Token: 0x06007F78 RID: 32632 RVA: 0x001343B6 File Offset: 0x001325B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingEntrustRefreshResponse()
		{
		}

		// Token: 0x06007F79 RID: 32633 RVA: 0x001343BE File Offset: 0x001325BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingEntrustRefreshResponse(FishingEntrustRefreshResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.entrustId_ = other.entrustId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007F7A RID: 32634 RVA: 0x001343EF File Offset: 0x001325EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingEntrustRefreshResponse Clone()
		{
			return new FishingEntrustRefreshResponse(this);
		}

		// Token: 0x170018D1 RID: 6353
		// (get) Token: 0x06007F7B RID: 32635 RVA: 0x001343F7 File Offset: 0x001325F7
		// (set) Token: 0x06007F7C RID: 32636 RVA: 0x001343FF File Offset: 0x001325FF
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

		// Token: 0x170018D2 RID: 6354
		// (get) Token: 0x06007F7D RID: 32637 RVA: 0x00134408 File Offset: 0x00132608
		// (set) Token: 0x06007F7E RID: 32638 RVA: 0x00134410 File Offset: 0x00132610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EntrustId
		{
			get
			{
				return this.entrustId_;
			}
			set
			{
				this.entrustId_ = value;
			}
		}

		// Token: 0x06007F7F RID: 32639 RVA: 0x00134419 File Offset: 0x00132619
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingEntrustRefreshResponse);
		}

		// Token: 0x06007F80 RID: 32640 RVA: 0x00134427 File Offset: 0x00132627
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingEntrustRefreshResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.EntrustId == other.EntrustId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007F81 RID: 32641 RVA: 0x00134468 File Offset: 0x00132668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.EntrustId != 0)
			{
				num ^= this.EntrustId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007F82 RID: 32642 RVA: 0x001344C6 File Offset: 0x001326C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007F83 RID: 32643 RVA: 0x001344D3 File Offset: 0x001326D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007F84 RID: 32644 RVA: 0x001344DC File Offset: 0x001326DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.EntrustId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.EntrustId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007F85 RID: 32645 RVA: 0x00134538 File Offset: 0x00132738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.EntrustId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EntrustId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007F86 RID: 32646 RVA: 0x00134590 File Offset: 0x00132790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingEntrustRefreshResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.EntrustId != 0)
			{
				this.EntrustId = other.EntrustId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007F87 RID: 32647 RVA: 0x001345E0 File Offset: 0x001327E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007F88 RID: 32648 RVA: 0x001345EC File Offset: 0x001327EC
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
				if (num != 88U)
				{
					if (num != 112U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.EntrustId = input.ReadInt32();
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004061 RID: 16481
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004062 RID: 16482
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x04004063 RID: 16483
		private ErrorCode errorCode_;

		// Token: 0x04004064 RID: 16484
		public const int EntrustIdFieldNumber = 14;

		// Token: 0x04004065 RID: 16485
		private int entrustId_;
	}
}
