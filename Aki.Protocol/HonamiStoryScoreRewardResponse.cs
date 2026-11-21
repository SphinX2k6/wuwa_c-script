using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200078D RID: 1933
	[NetMessage(EMessageId.HonamiStoryScoreRewardResponse)]
	public sealed class HonamiStoryScoreRewardResponse : IMessage<HonamiStoryScoreRewardResponse>, IMessage, IEquatable<HonamiStoryScoreRewardResponse>, IDeepCloneable<HonamiStoryScoreRewardResponse>, IBufferMessage
	{
		// Token: 0x0600AEB9 RID: 44729 RVA: 0x001A3AD8 File Offset: 0x001A1CD8
		[NullableContext(1)]
		public static HonamiStoryScoreRewardResponse Create()
		{
			return new HonamiStoryScoreRewardResponse();
		}

		// Token: 0x17002339 RID: 9017
		// (get) Token: 0x0600AEBA RID: 44730 RVA: 0x001A3ADF File Offset: 0x001A1CDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700233A RID: 9018
		// (get) Token: 0x0600AEBB RID: 44731 RVA: 0x001A3AE2 File Offset: 0x001A1CE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryScoreRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600AEBC RID: 44732 RVA: 0x001A3AE9 File Offset: 0x001A1CE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryScoreRewardResponse()
		{
		}

		// Token: 0x0600AEBD RID: 44733 RVA: 0x001A3AFC File Offset: 0x001A1CFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryScoreRewardResponse(HonamiStoryScoreRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.scoreRewardId_ = other.scoreRewardId_.Clone();
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AEBE RID: 44734 RVA: 0x001A3B49 File Offset: 0x001A1D49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryScoreRewardResponse Clone()
		{
			return new HonamiStoryScoreRewardResponse(this);
		}

		// Token: 0x1700233B RID: 9019
		// (get) Token: 0x0600AEBF RID: 44735 RVA: 0x001A3B51 File Offset: 0x001A1D51
		// (set) Token: 0x0600AEC0 RID: 44736 RVA: 0x001A3B59 File Offset: 0x001A1D59
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

		// Token: 0x1700233C RID: 9020
		// (get) Token: 0x0600AEC1 RID: 44737 RVA: 0x001A3B62 File Offset: 0x001A1D62
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ScoreRewardId
		{
			get
			{
				return this.scoreRewardId_;
			}
		}

		// Token: 0x1700233D RID: 9021
		// (get) Token: 0x0600AEC2 RID: 44738 RVA: 0x001A3B6A File Offset: 0x001A1D6A
		// (set) Token: 0x0600AEC3 RID: 44739 RVA: 0x001A3B72 File Offset: 0x001A1D72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x0600AEC4 RID: 44740 RVA: 0x001A3B7B File Offset: 0x001A1D7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryScoreRewardResponse);
		}

		// Token: 0x0600AEC5 RID: 44741 RVA: 0x001A3B8C File Offset: 0x001A1D8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryScoreRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.scoreRewardId_.Equals(other.scoreRewardId_) && this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AEC6 RID: 44742 RVA: 0x001A3BEC File Offset: 0x001A1DEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.scoreRewardId_.GetHashCode();
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AEC7 RID: 44743 RVA: 0x001A3C58 File Offset: 0x001A1E58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AEC8 RID: 44744 RVA: 0x001A3C65 File Offset: 0x001A1E65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AEC9 RID: 44745 RVA: 0x001A3C70 File Offset: 0x001A1E70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.scoreRewardId_.WriteTo(ref output, HonamiStoryScoreRewardResponse._repeated_scoreRewardId_codec);
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.ActivityId);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AECA RID: 44746 RVA: 0x001A3CDC File Offset: 0x001A1EDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.scoreRewardId_.CalculateSize(HonamiStoryScoreRewardResponse._repeated_scoreRewardId_codec);
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AECB RID: 44747 RVA: 0x001A3D48 File Offset: 0x001A1F48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryScoreRewardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.scoreRewardId_.Add(other.scoreRewardId_);
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AECC RID: 44748 RVA: 0x001A3DA9 File Offset: 0x001A1FA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AECD RID: 44749 RVA: 0x001A3DB4 File Offset: 0x001A1FB4
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
				if (num <= 66U)
				{
					if (num == 64U || num == 66U)
					{
						this.scoreRewardId_.AddEntriesFrom(ref input, HonamiStoryScoreRewardResponse._repeated_scoreRewardId_codec);
						continue;
					}
				}
				else
				{
					if (num == 104U)
					{
						this.ActivityId = input.ReadInt32();
						continue;
					}
					if (num == 112U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004F1C RID: 20252
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004F1D RID: 20253
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x04004F1E RID: 20254
		private ErrorCode errorCode_;

		// Token: 0x04004F1F RID: 20255
		public const int ScoreRewardIdFieldNumber = 8;

		// Token: 0x04004F20 RID: 20256
		private static readonly FieldCodec<int> _repeated_scoreRewardId_codec = FieldCodec.ForInt32(66U);

		// Token: 0x04004F21 RID: 20257
		private readonly RepeatedField<int> scoreRewardId_ = new RepeatedField<int>();

		// Token: 0x04004F22 RID: 20258
		public const int ActivityIdFieldNumber = 13;

		// Token: 0x04004F23 RID: 20259
		private int activityId_;
	}
}
