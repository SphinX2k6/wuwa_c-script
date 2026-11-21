using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200095A RID: 2394
	[NetMessage(EMessageId.LstBattleRecordResponse)]
	public sealed class LstBattleRecordResponse : IMessage<LstBattleRecordResponse>, IMessage, IEquatable<LstBattleRecordResponse>, IDeepCloneable<LstBattleRecordResponse>, IBufferMessage
	{
		// Token: 0x0600D330 RID: 54064 RVA: 0x001F2092 File Offset: 0x001F0292
		[NullableContext(1)]
		public static LstBattleRecordResponse Create()
		{
			return new LstBattleRecordResponse();
		}

		// Token: 0x17002ABF RID: 10943
		// (get) Token: 0x0600D331 RID: 54065 RVA: 0x001F2099 File Offset: 0x001F0299
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002AC0 RID: 10944
		// (get) Token: 0x0600D332 RID: 54066 RVA: 0x001F209C File Offset: 0x001F029C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LstBattleRecordResponse.Descriptor;
			}
		}

		// Token: 0x0600D333 RID: 54067 RVA: 0x001F20A3 File Offset: 0x001F02A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LstBattleRecordResponse()
		{
		}

		// Token: 0x0600D334 RID: 54068 RVA: 0x001F20B8 File Offset: 0x001F02B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LstBattleRecordResponse(LstBattleRecordResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.lstLevelInfos_ = other.lstLevelInfos_.Clone();
			this.lastTotalRewardCount_ = other.lastTotalRewardCount_;
			this.lastCanRewardCount_ = other.lastCanRewardCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D335 RID: 54069 RVA: 0x001F2111 File Offset: 0x001F0311
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LstBattleRecordResponse Clone()
		{
			return new LstBattleRecordResponse(this);
		}

		// Token: 0x17002AC1 RID: 10945
		// (get) Token: 0x0600D336 RID: 54070 RVA: 0x001F2119 File Offset: 0x001F0319
		// (set) Token: 0x0600D337 RID: 54071 RVA: 0x001F2121 File Offset: 0x001F0321
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

		// Token: 0x17002AC2 RID: 10946
		// (get) Token: 0x0600D338 RID: 54072 RVA: 0x001F212A File Offset: 0x001F032A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<LstLevelInfo> LstLevelInfos
		{
			get
			{
				return this.lstLevelInfos_;
			}
		}

		// Token: 0x17002AC3 RID: 10947
		// (get) Token: 0x0600D339 RID: 54073 RVA: 0x001F2132 File Offset: 0x001F0332
		// (set) Token: 0x0600D33A RID: 54074 RVA: 0x001F213A File Offset: 0x001F033A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LastTotalRewardCount
		{
			get
			{
				return this.lastTotalRewardCount_;
			}
			set
			{
				this.lastTotalRewardCount_ = value;
			}
		}

		// Token: 0x17002AC4 RID: 10948
		// (get) Token: 0x0600D33B RID: 54075 RVA: 0x001F2143 File Offset: 0x001F0343
		// (set) Token: 0x0600D33C RID: 54076 RVA: 0x001F214B File Offset: 0x001F034B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LastCanRewardCount
		{
			get
			{
				return this.lastCanRewardCount_;
			}
			set
			{
				this.lastCanRewardCount_ = value;
			}
		}

		// Token: 0x0600D33D RID: 54077 RVA: 0x001F2154 File Offset: 0x001F0354
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LstBattleRecordResponse);
		}

		// Token: 0x0600D33E RID: 54078 RVA: 0x001F2164 File Offset: 0x001F0364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LstBattleRecordResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.lstLevelInfos_.Equals(other.lstLevelInfos_) && this.LastTotalRewardCount == other.LastTotalRewardCount && this.LastCanRewardCount == other.LastCanRewardCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D33F RID: 54079 RVA: 0x001F21D4 File Offset: 0x001F03D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.lstLevelInfos_.GetHashCode();
			if (this.LastTotalRewardCount != 0)
			{
				num ^= this.LastTotalRewardCount.GetHashCode();
			}
			if (this.LastCanRewardCount != 0)
			{
				num ^= this.LastCanRewardCount.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D340 RID: 54080 RVA: 0x001F2259 File Offset: 0x001F0459
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D341 RID: 54081 RVA: 0x001F2266 File Offset: 0x001F0466
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D342 RID: 54082 RVA: 0x001F2270 File Offset: 0x001F0470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LastCanRewardCount != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.LastCanRewardCount);
			}
			this.lstLevelInfos_.WriteTo(ref output, LstBattleRecordResponse._repeated_lstLevelInfos_codec);
			if (this.LastTotalRewardCount != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.LastTotalRewardCount);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D343 RID: 54083 RVA: 0x001F22F8 File Offset: 0x001F04F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.lstLevelInfos_.CalculateSize(LstBattleRecordResponse._repeated_lstLevelInfos_codec);
			if (this.LastTotalRewardCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LastTotalRewardCount);
			}
			if (this.LastCanRewardCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LastCanRewardCount);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D344 RID: 54084 RVA: 0x001F237C File Offset: 0x001F057C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LstBattleRecordResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.lstLevelInfos_.Add(other.lstLevelInfos_);
			if (other.LastTotalRewardCount != 0)
			{
				this.LastTotalRewardCount = other.LastTotalRewardCount;
			}
			if (other.LastCanRewardCount != 0)
			{
				this.LastCanRewardCount = other.LastCanRewardCount;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D345 RID: 54085 RVA: 0x001F23F1 File Offset: 0x001F05F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D346 RID: 54086 RVA: 0x001F23FC File Offset: 0x001F05FC
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
				if (num <= 90U)
				{
					if (num == 40U)
					{
						this.LastCanRewardCount = input.ReadInt32();
						continue;
					}
					if (num == 90U)
					{
						this.lstLevelInfos_.AddEntriesFrom(ref input, LstBattleRecordResponse._repeated_lstLevelInfos_codec);
						continue;
					}
				}
				else
				{
					if (num == 104U)
					{
						this.LastTotalRewardCount = input.ReadInt32();
						continue;
					}
					if (num == 120U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400591E RID: 22814
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400591F RID: 22815
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x04005920 RID: 22816
		private ErrorCode errorCode_;

		// Token: 0x04005921 RID: 22817
		public const int LstLevelInfosFieldNumber = 11;

		// Token: 0x04005922 RID: 22818
		private static readonly FieldCodec<LstLevelInfo> _repeated_lstLevelInfos_codec = FieldCodec.ForMessage<LstLevelInfo>(90U, LstLevelInfo.Parser);

		// Token: 0x04005923 RID: 22819
		private readonly RepeatedField<LstLevelInfo> lstLevelInfos_ = new RepeatedField<LstLevelInfo>();

		// Token: 0x04005924 RID: 22820
		public const int LastTotalRewardCountFieldNumber = 13;

		// Token: 0x04005925 RID: 22821
		private int lastTotalRewardCount_;

		// Token: 0x04005926 RID: 22822
		public const int LastCanRewardCountFieldNumber = 5;

		// Token: 0x04005927 RID: 22823
		private int lastCanRewardCount_;
	}
}
