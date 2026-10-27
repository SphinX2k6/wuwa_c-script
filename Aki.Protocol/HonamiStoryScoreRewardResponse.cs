using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007A1 RID: 1953
	[NetMessage(EMessageId.HonamiStoryScoreRewardResponse)]
	public sealed class HonamiStoryScoreRewardResponse : IMessage<HonamiStoryScoreRewardResponse>, IMessage, IEquatable<HonamiStoryScoreRewardResponse>, IDeepCloneable<HonamiStoryScoreRewardResponse>, IBufferMessage
	{
		// Token: 0x0600B00F RID: 45071 RVA: 0x001A6504 File Offset: 0x001A4704
		[NullableContext(1)]
		public static HonamiStoryScoreRewardResponse Create()
		{
			return new HonamiStoryScoreRewardResponse();
		}

		// Token: 0x17002383 RID: 9091
		// (get) Token: 0x0600B010 RID: 45072 RVA: 0x001A650B File Offset: 0x001A470B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002384 RID: 9092
		// (get) Token: 0x0600B011 RID: 45073 RVA: 0x001A650E File Offset: 0x001A470E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryScoreRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600B012 RID: 45074 RVA: 0x001A6515 File Offset: 0x001A4715
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryScoreRewardResponse()
		{
		}

		// Token: 0x0600B013 RID: 45075 RVA: 0x001A6528 File Offset: 0x001A4728
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryScoreRewardResponse(HonamiStoryScoreRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.scoreRewardId_ = other.scoreRewardId_.Clone();
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B014 RID: 45076 RVA: 0x001A6575 File Offset: 0x001A4775
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryScoreRewardResponse Clone()
		{
			return new HonamiStoryScoreRewardResponse(this);
		}

		// Token: 0x17002385 RID: 9093
		// (get) Token: 0x0600B015 RID: 45077 RVA: 0x001A657D File Offset: 0x001A477D
		// (set) Token: 0x0600B016 RID: 45078 RVA: 0x001A6585 File Offset: 0x001A4785
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

		// Token: 0x17002386 RID: 9094
		// (get) Token: 0x0600B017 RID: 45079 RVA: 0x001A658E File Offset: 0x001A478E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> ScoreRewardId
		{
			get
			{
				return this.scoreRewardId_;
			}
		}

		// Token: 0x17002387 RID: 9095
		// (get) Token: 0x0600B018 RID: 45080 RVA: 0x001A6596 File Offset: 0x001A4796
		// (set) Token: 0x0600B019 RID: 45081 RVA: 0x001A659E File Offset: 0x001A479E
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

		// Token: 0x0600B01A RID: 45082 RVA: 0x001A65A7 File Offset: 0x001A47A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryScoreRewardResponse);
		}

		// Token: 0x0600B01B RID: 45083 RVA: 0x001A65B8 File Offset: 0x001A47B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryScoreRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.scoreRewardId_.Equals(other.scoreRewardId_) && this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B01C RID: 45084 RVA: 0x001A6618 File Offset: 0x001A4818
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

		// Token: 0x0600B01D RID: 45085 RVA: 0x001A6684 File Offset: 0x001A4884
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B01E RID: 45086 RVA: 0x001A6691 File Offset: 0x001A4891
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B01F RID: 45087 RVA: 0x001A669C File Offset: 0x001A489C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.scoreRewardId_.WriteTo(ref output, HonamiStoryScoreRewardResponse._repeated_scoreRewardId_codec);
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.ActivityId);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B020 RID: 45088 RVA: 0x001A6708 File Offset: 0x001A4908
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

		// Token: 0x0600B021 RID: 45089 RVA: 0x001A6774 File Offset: 0x001A4974
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

		// Token: 0x0600B022 RID: 45090 RVA: 0x001A67D5 File Offset: 0x001A49D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B023 RID: 45091 RVA: 0x001A67E0 File Offset: 0x001A49E0
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
				if (num <= 26U)
				{
					if (num == 24U || num == 26U)
					{
						this.scoreRewardId_.AddEntriesFrom(ref input, HonamiStoryScoreRewardResponse._repeated_scoreRewardId_codec);
						continue;
					}
				}
				else
				{
					if (num == 32U)
					{
						this.ActivityId = input.ReadInt32();
						continue;
					}
					if (num == 88U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004F23 RID: 20259
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004F24 RID: 20260
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x04004F25 RID: 20261
		private ErrorCode errorCode_;

		// Token: 0x04004F26 RID: 20262
		public const int ScoreRewardIdFieldNumber = 3;

		// Token: 0x04004F27 RID: 20263
		private static readonly FieldCodec<int> _repeated_scoreRewardId_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04004F28 RID: 20264
		private readonly RepeatedField<int> scoreRewardId_ = new RepeatedField<int>();

		// Token: 0x04004F29 RID: 20265
		public const int ActivityIdFieldNumber = 4;

		// Token: 0x04004F2A RID: 20266
		private int activityId_;
	}
}
