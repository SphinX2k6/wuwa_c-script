using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F49 RID: 3913
	[NetMessage(EMessageId.RhythmSettleResponse)]
	public sealed class RhythmSettleResponse : IMessage<RhythmSettleResponse>, IMessage, IEquatable<RhythmSettleResponse>, IDeepCloneable<RhythmSettleResponse>, IBufferMessage
	{
		// Token: 0x06014EF5 RID: 85749 RVA: 0x0030990A File Offset: 0x00307B0A
		[NullableContext(1)]
		public static RhythmSettleResponse Create()
		{
			return new RhythmSettleResponse();
		}

		// Token: 0x1700459F RID: 17823
		// (get) Token: 0x06014EF6 RID: 85750 RVA: 0x00309911 File Offset: 0x00307B11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170045A0 RID: 17824
		// (get) Token: 0x06014EF7 RID: 85751 RVA: 0x00309914 File Offset: 0x00307B14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RhythmSettleResponse.Descriptor;
			}
		}

		// Token: 0x06014EF8 RID: 85752 RVA: 0x0030991B File Offset: 0x00307B1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmSettleResponse()
		{
		}

		// Token: 0x06014EF9 RID: 85753 RVA: 0x00309924 File Offset: 0x00307B24
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

		// Token: 0x06014EFA RID: 85754 RVA: 0x00309988 File Offset: 0x00307B88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmSettleResponse Clone()
		{
			return new RhythmSettleResponse(this);
		}

		// Token: 0x170045A1 RID: 17825
		// (get) Token: 0x06014EFB RID: 85755 RVA: 0x00309990 File Offset: 0x00307B90
		// (set) Token: 0x06014EFC RID: 85756 RVA: 0x00309998 File Offset: 0x00307B98
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

		// Token: 0x170045A2 RID: 17826
		// (get) Token: 0x06014EFD RID: 85757 RVA: 0x003099A1 File Offset: 0x00307BA1
		// (set) Token: 0x06014EFE RID: 85758 RVA: 0x003099A9 File Offset: 0x00307BA9
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

		// Token: 0x170045A3 RID: 17827
		// (get) Token: 0x06014EFF RID: 85759 RVA: 0x003099B2 File Offset: 0x00307BB2
		// (set) Token: 0x06014F00 RID: 85760 RVA: 0x003099BA File Offset: 0x00307BBA
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

		// Token: 0x170045A4 RID: 17828
		// (get) Token: 0x06014F01 RID: 85761 RVA: 0x003099C3 File Offset: 0x00307BC3
		// (set) Token: 0x06014F02 RID: 85762 RVA: 0x003099CB File Offset: 0x00307BCB
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

		// Token: 0x06014F03 RID: 85763 RVA: 0x003099D4 File Offset: 0x00307BD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RhythmSettleResponse);
		}

		// Token: 0x06014F04 RID: 85764 RVA: 0x003099E4 File Offset: 0x00307BE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RhythmSettleResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this.Payload, other.Payload) && this.BestScoreFlag == other.BestScoreFlag && this.BestScore == other.BestScore && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014F05 RID: 85765 RVA: 0x00309A54 File Offset: 0x00307C54
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

		// Token: 0x06014F06 RID: 85766 RVA: 0x00309AE1 File Offset: 0x00307CE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014F07 RID: 85767 RVA: 0x00309AEE File Offset: 0x00307CEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014F08 RID: 85768 RVA: 0x00309AF8 File Offset: 0x00307CF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this.BestScore != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.BestScore);
			}
			if (this.BestScoreFlag)
			{
				output.WriteRawTag(104);
				output.WriteBool(this.BestScoreFlag);
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

		// Token: 0x06014F09 RID: 85769 RVA: 0x00309B8C File Offset: 0x00307D8C
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

		// Token: 0x06014F0A RID: 85770 RVA: 0x00309C08 File Offset: 0x00307E08
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

		// Token: 0x06014F0B RID: 85771 RVA: 0x00309C98 File Offset: 0x00307E98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014F0C RID: 85772 RVA: 0x00309CA4 File Offset: 0x00307EA4
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
					if (num == 40U)
					{
						this.ErrCode = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 56U)
					{
						this.BestScore = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 104U)
					{
						this.BestScoreFlag = input.ReadBool();
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

		// Token: 0x04007E3B RID: 32315
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007E3C RID: 32316
		public const int ErrCodeFieldNumber = 5;

		// Token: 0x04007E3D RID: 32317
		private ErrorCode errCode_;

		// Token: 0x04007E3E RID: 32318
		public const int PayloadFieldNumber = 15;

		// Token: 0x04007E3F RID: 32319
		private RhythmResultPayload payload_;

		// Token: 0x04007E40 RID: 32320
		public const int BestScoreFlagFieldNumber = 13;

		// Token: 0x04007E41 RID: 32321
		private bool bestScoreFlag_;

		// Token: 0x04007E42 RID: 32322
		public const int BestScoreFieldNumber = 7;

		// Token: 0x04007E43 RID: 32323
		private int bestScore_;
	}
}
