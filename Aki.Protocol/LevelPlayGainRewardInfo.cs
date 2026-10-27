using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008FB RID: 2299
	public sealed class LevelPlayGainRewardInfo : IMessage<LevelPlayGainRewardInfo>, IMessage, IEquatable<LevelPlayGainRewardInfo>, IDeepCloneable<LevelPlayGainRewardInfo>, IBufferMessage
	{
		// Token: 0x0600CB22 RID: 52002 RVA: 0x001DF828 File Offset: 0x001DDA28
		[NullableContext(1)]
		public static LevelPlayGainRewardInfo Create()
		{
			return new LevelPlayGainRewardInfo();
		}

		// Token: 0x17002903 RID: 10499
		// (get) Token: 0x0600CB23 RID: 52003 RVA: 0x001DF82F File Offset: 0x001DDA2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LevelPlayGainRewardInfo> Parser
		{
			get
			{
				return LevelPlayGainRewardInfo._parser;
			}
		}

		// Token: 0x17002904 RID: 10500
		// (get) Token: 0x0600CB24 RID: 52004 RVA: 0x001DF836 File Offset: 0x001DDA36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002905 RID: 10501
		// (get) Token: 0x0600CB25 RID: 52005 RVA: 0x001DF839 File Offset: 0x001DDA39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LevelPlayGainRewardInfo.Descriptor;
			}
		}

		// Token: 0x0600CB26 RID: 52006 RVA: 0x001DF840 File Offset: 0x001DDA40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayGainRewardInfo()
		{
		}

		// Token: 0x0600CB27 RID: 52007 RVA: 0x001DF85E File Offset: 0x001DDA5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayGainRewardInfo(LevelPlayGainRewardInfo other) : this()
		{
			this.rewardNodeIds_ = other.rewardNodeIds_.Clone();
			this.treasureBoxIds_ = other.treasureBoxIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CB28 RID: 52008 RVA: 0x001DF899 File Offset: 0x001DDA99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayGainRewardInfo Clone()
		{
			return new LevelPlayGainRewardInfo(this);
		}

		// Token: 0x17002906 RID: 10502
		// (get) Token: 0x0600CB29 RID: 52009 RVA: 0x001DF8A1 File Offset: 0x001DDAA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RewardNodeIds
		{
			get
			{
				return this.rewardNodeIds_;
			}
		}

		// Token: 0x17002907 RID: 10503
		// (get) Token: 0x0600CB2A RID: 52010 RVA: 0x001DF8A9 File Offset: 0x001DDAA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TreasureBoxIds
		{
			get
			{
				return this.treasureBoxIds_;
			}
		}

		// Token: 0x0600CB2B RID: 52011 RVA: 0x001DF8B1 File Offset: 0x001DDAB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LevelPlayGainRewardInfo);
		}

		// Token: 0x0600CB2C RID: 52012 RVA: 0x001DF8C0 File Offset: 0x001DDAC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LevelPlayGainRewardInfo other)
		{
			return other != null && (other == this || (this.rewardNodeIds_.Equals(other.rewardNodeIds_) && this.treasureBoxIds_.Equals(other.treasureBoxIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CB2D RID: 52013 RVA: 0x001DF914 File Offset: 0x001DDB14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.rewardNodeIds_.GetHashCode();
			num ^= this.treasureBoxIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CB2E RID: 52014 RVA: 0x001DF956 File Offset: 0x001DDB56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CB2F RID: 52015 RVA: 0x001DF963 File Offset: 0x001DDB63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CB30 RID: 52016 RVA: 0x001DF96C File Offset: 0x001DDB6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.rewardNodeIds_.WriteTo(ref output, LevelPlayGainRewardInfo._repeated_rewardNodeIds_codec);
			this.treasureBoxIds_.WriteTo(ref output, LevelPlayGainRewardInfo._repeated_treasureBoxIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CB31 RID: 52017 RVA: 0x001DF9A4 File Offset: 0x001DDBA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.rewardNodeIds_.CalculateSize(LevelPlayGainRewardInfo._repeated_rewardNodeIds_codec);
			num += this.treasureBoxIds_.CalculateSize(LevelPlayGainRewardInfo._repeated_treasureBoxIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CB32 RID: 52018 RVA: 0x001DF9F0 File Offset: 0x001DDBF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LevelPlayGainRewardInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.rewardNodeIds_.Add(other.rewardNodeIds_);
			this.treasureBoxIds_.Add(other.treasureBoxIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CB33 RID: 52019 RVA: 0x001DFA2F File Offset: 0x001DDC2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CB34 RID: 52020 RVA: 0x001DFA38 File Offset: 0x001DDC38
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
				if (num <= 10U)
				{
					if (num == 8U || num == 10U)
					{
						this.rewardNodeIds_.AddEntriesFrom(ref input, LevelPlayGainRewardInfo._repeated_rewardNodeIds_codec);
						continue;
					}
				}
				else if (num == 16U || num == 18U)
				{
					this.treasureBoxIds_.AddEntriesFrom(ref input, LevelPlayGainRewardInfo._repeated_treasureBoxIds_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005651 RID: 22097
		private static readonly MessageParser<LevelPlayGainRewardInfo> _parser = new MessageParser<LevelPlayGainRewardInfo>(() => new LevelPlayGainRewardInfo());

		// Token: 0x04005652 RID: 22098
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005653 RID: 22099
		public const int RewardNodeIdsFieldNumber = 1;

		// Token: 0x04005654 RID: 22100
		private static readonly FieldCodec<int> _repeated_rewardNodeIds_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04005655 RID: 22101
		private readonly RepeatedField<int> rewardNodeIds_ = new RepeatedField<int>();

		// Token: 0x04005656 RID: 22102
		public const int TreasureBoxIdsFieldNumber = 2;

		// Token: 0x04005657 RID: 22103
		private static readonly FieldCodec<int> _repeated_treasureBoxIds_codec = FieldCodec.ForInt32(18U);

		// Token: 0x04005658 RID: 22104
		private readonly RepeatedField<int> treasureBoxIds_ = new RepeatedField<int>();
	}
}
