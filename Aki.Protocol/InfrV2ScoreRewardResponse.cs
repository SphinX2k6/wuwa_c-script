using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000805 RID: 2053
	[NetMessage(EMessageId.InfrV2ScoreRewardResponse)]
	public sealed class InfrV2ScoreRewardResponse : IMessage<InfrV2ScoreRewardResponse>, IMessage, IEquatable<InfrV2ScoreRewardResponse>, IDeepCloneable<InfrV2ScoreRewardResponse>, IBufferMessage
	{
		// Token: 0x0600B7C8 RID: 47048 RVA: 0x001B6239 File Offset: 0x001B4439
		[NullableContext(1)]
		public static InfrV2ScoreRewardResponse Create()
		{
			return new InfrV2ScoreRewardResponse();
		}

		// Token: 0x1700250B RID: 9483
		// (get) Token: 0x0600B7C9 RID: 47049 RVA: 0x001B6240 File Offset: 0x001B4440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700250C RID: 9484
		// (get) Token: 0x0600B7CA RID: 47050 RVA: 0x001B6243 File Offset: 0x001B4443
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfrV2ScoreRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600B7CB RID: 47051 RVA: 0x001B624A File Offset: 0x001B444A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2ScoreRewardResponse()
		{
		}

		// Token: 0x0600B7CC RID: 47052 RVA: 0x001B6252 File Offset: 0x001B4452
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2ScoreRewardResponse(InfrV2ScoreRewardResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B7CD RID: 47053 RVA: 0x001B6277 File Offset: 0x001B4477
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfrV2ScoreRewardResponse Clone()
		{
			return new InfrV2ScoreRewardResponse(this);
		}

		// Token: 0x1700250D RID: 9485
		// (get) Token: 0x0600B7CE RID: 47054 RVA: 0x001B627F File Offset: 0x001B447F
		// (set) Token: 0x0600B7CF RID: 47055 RVA: 0x001B6287 File Offset: 0x001B4487
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

		// Token: 0x0600B7D0 RID: 47056 RVA: 0x001B6290 File Offset: 0x001B4490
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfrV2ScoreRewardResponse);
		}

		// Token: 0x0600B7D1 RID: 47057 RVA: 0x001B629E File Offset: 0x001B449E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfrV2ScoreRewardResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B7D2 RID: 47058 RVA: 0x001B62CC File Offset: 0x001B44CC
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

		// Token: 0x0600B7D3 RID: 47059 RVA: 0x001B6311 File Offset: 0x001B4511
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B7D4 RID: 47060 RVA: 0x001B631E File Offset: 0x001B451E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B7D5 RID: 47061 RVA: 0x001B6327 File Offset: 0x001B4527
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B7D6 RID: 47062 RVA: 0x001B635C File Offset: 0x001B455C
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

		// Token: 0x0600B7D7 RID: 47063 RVA: 0x001B639A File Offset: 0x001B459A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfrV2ScoreRewardResponse other)
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

		// Token: 0x0600B7D8 RID: 47064 RVA: 0x001B63CB File Offset: 0x001B45CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B7D9 RID: 47065 RVA: 0x001B63D4 File Offset: 0x001B45D4
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
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400511B RID: 20763
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400511C RID: 20764
		public const int ErrCodeFieldNumber = 13;

		// Token: 0x0400511D RID: 20765
		private ErrorCode errCode_;
	}
}
