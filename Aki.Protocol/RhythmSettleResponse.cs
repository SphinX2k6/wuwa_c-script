using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F39 RID: 3897
	[NetMessage(EMessageId.RhythmSettleResponse)]
	public sealed class RhythmSettleResponse : IMessage<RhythmSettleResponse>, IMessage, IEquatable<RhythmSettleResponse>, IDeepCloneable<RhythmSettleResponse>, IBufferMessage
	{
		// Token: 0x06014E10 RID: 85520 RVA: 0x0030824E File Offset: 0x0030644E
		[NullableContext(1)]
		public static RhythmSettleResponse Create()
		{
			return new RhythmSettleResponse();
		}

		// Token: 0x17004575 RID: 17781
		// (get) Token: 0x06014E11 RID: 85521 RVA: 0x00308255 File Offset: 0x00306455
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004576 RID: 17782
		// (get) Token: 0x06014E12 RID: 85522 RVA: 0x00308258 File Offset: 0x00306458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RhythmSettleResponse.Descriptor;
			}
		}

		// Token: 0x06014E13 RID: 85523 RVA: 0x0030825F File Offset: 0x0030645F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmSettleResponse()
		{
		}

		// Token: 0x06014E14 RID: 85524 RVA: 0x00308268 File Offset: 0x00306468
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmSettleResponse(RhythmSettleResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this.payload_ = ((other.payload_ != null) ? other.payload_.Clone() : null);
			this.bestScoreFlag_ = other.bestScoreFlag_;
			this.bestScore_ = other.bestScore_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014E15 RID: 85525 RVA: 0x003082CC File Offset: 0x003064CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmSettleResponse Clone()
		{
			return new RhythmSettleResponse(this);
		}

		// Token: 0x17004577 RID: 17783
		// (get) Token: 0x06014E16 RID: 85526 RVA: 0x003082D4 File Offset: 0x003064D4
		// (set) Token: 0x06014E17 RID: 85527 RVA: 0x003082DC File Offset: 0x003064DC
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

		// Token: 0x17004578 RID: 17784
		// (get) Token: 0x06014E18 RID: 85528 RVA: 0x003082E5 File Offset: 0x003064E5
		// (set) Token: 0x06014E19 RID: 85529 RVA: 0x003082ED File Offset: 0x003064ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmResultPayload Payload
		{
			get
			{
				return this.payload_;
			}
			set
			{
				this.payload_ = value;
			}
		}

		// Token: 0x17004579 RID: 17785
		// (get) Token: 0x06014E1A RID: 85530 RVA: 0x003082F6 File Offset: 0x003064F6
		// (set) Token: 0x06014E1B RID: 85531 RVA: 0x003082FE File Offset: 0x003064FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool BestScoreFlag
		{
			get
			{
				return this.bestScoreFlag_;
			}
			set
			{
				this.bestScoreFlag_ = value;
			}
		}

		// Token: 0x1700457A RID: 17786
		// (get) Token: 0x06014E1C RID: 85532 RVA: 0x00308307 File Offset: 0x00306507
		// (set) Token: 0x06014E1D RID: 85533 RVA: 0x0030830F File Offset: 0x0030650F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BestScore
		{
			get
			{
				return this.bestScore_;
			}
			set
			{
				this.bestScore_ = value;
			}
		}

		// Token: 0x06014E1E RID: 85534 RVA: 0x00308318 File Offset: 0x00306518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RhythmSettleResponse);
		}

		// Token: 0x06014E1F RID: 85535 RVA: 0x00308328 File Offset: 0x00306528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RhythmSettleResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this.Payload, other.Payload) && this.BestScoreFlag == other.BestScoreFlag && this.BestScore == other.BestScore && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014E20 RID: 85536 RVA: 0x00308398 File Offset: 0x00306598
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrCode != ErrorCode.Success)
			{
				num ^= this.ErrCode.GetHashCode();
			}
			if (this.payload_ != null)
			{
				num ^= this.Payload.GetHashCode();
			}
			if (this.BestScoreFlag)
			{
				num ^= this.BestScoreFlag.GetHashCode();
			}
			if (this.BestScore != 0)
			{
				num ^= this.BestScore.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014E21 RID: 85537 RVA: 0x00308425 File Offset: 0x00306625
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014E22 RID: 85538 RVA: 0x00308432 File Offset: 0x00306632
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014E23 RID: 85539 RVA: 0x0030843C File Offset: 0x0030663C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BestScore != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.BestScore);
			}
			if (this.BestScoreFlag)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.BestScoreFlag);
			}
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this.payload_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.Payload);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014E24 RID: 85540 RVA: 0x003084D0 File Offset: 0x003066D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrCode);
			}
			if (this.payload_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Payload);
			}
			if (this.BestScoreFlag)
			{
				num += 2;
			}
			if (this.BestScore != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BestScore);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014E25 RID: 85541 RVA: 0x0030854C File Offset: 0x0030674C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RhythmSettleResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrCode != ErrorCode.Success)
			{
				this.ErrCode = other.ErrCode;
			}
			if (other.payload_ != null)
			{
				if (this.payload_ == null)
				{
					this.Payload = new RhythmResultPayload();
				}
				this.Payload.MergeFrom(other.Payload);
			}
			if (other.BestScoreFlag)
			{
				this.BestScoreFlag = other.BestScoreFlag;
			}
			if (other.BestScore != 0)
			{
				this.BestScore = other.BestScore;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014E26 RID: 85542 RVA: 0x003085DC File Offset: 0x003067DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014E27 RID: 85543 RVA: 0x003085E8 File Offset: 0x003067E8
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
				if (num <= 56U)
				{
					if (num == 24U)
					{
						this.BestScore = input.ReadInt32();
						continue;
					}
					if (num == 56U)
					{
						this.BestScoreFlag = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.ErrCode = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 122U)
					{
						if (this.payload_ == null)
						{
							this.Payload = new RhythmResultPayload();
						}
						input.ReadMessage(this.Payload);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007E65 RID: 32357
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007E66 RID: 32358
		public const int ErrCodeFieldNumber = 10;

		// Token: 0x04007E67 RID: 32359
		private ErrorCode errCode_;

		// Token: 0x04007E68 RID: 32360
		public const int PayloadFieldNumber = 15;

		// Token: 0x04007E69 RID: 32361
		private RhythmResultPayload payload_;

		// Token: 0x04007E6A RID: 32362
		public const int BestScoreFlagFieldNumber = 7;

		// Token: 0x04007E6B RID: 32363
		private bool bestScoreFlag_;

		// Token: 0x04007E6C RID: 32364
		public const int BestScoreFieldNumber = 3;

		// Token: 0x04007E6D RID: 32365
		private int bestScore_;
	}
}
