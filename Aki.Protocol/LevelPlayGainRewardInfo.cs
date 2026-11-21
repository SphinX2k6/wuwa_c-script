using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008EA RID: 2282
	public sealed class LevelPlayGainRewardInfo : IMessage<LevelPlayGainRewardInfo>, IMessage, IEquatable<LevelPlayGainRewardInfo>, IDeepCloneable<LevelPlayGainRewardInfo>, IBufferMessage
	{
		// Token: 0x0600CA06 RID: 51718 RVA: 0x001DD54C File Offset: 0x001DB74C
		[NullableContext(1)]
		public static LevelPlayGainRewardInfo Create()
		{
			return new LevelPlayGainRewardInfo();
		}

		// Token: 0x170028C4 RID: 10436
		// (get) Token: 0x0600CA07 RID: 51719 RVA: 0x001DD553 File Offset: 0x001DB753
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LevelPlayGainRewardInfo> Parser
		{
			get
			{
				return LevelPlayGainRewardInfo._parser;
			}
		}

		// Token: 0x170028C5 RID: 10437
		// (get) Token: 0x0600CA08 RID: 51720 RVA: 0x001DD55A File Offset: 0x001DB75A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170028C6 RID: 10438
		// (get) Token: 0x0600CA09 RID: 51721 RVA: 0x001DD55D File Offset: 0x001DB75D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LevelPlayGainRewardInfo.Descriptor;
			}
		}

		// Token: 0x0600CA0A RID: 51722 RVA: 0x001DD564 File Offset: 0x001DB764
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayGainRewardInfo()
		{
		}

		// Token: 0x0600CA0B RID: 51723 RVA: 0x001DD582 File Offset: 0x001DB782
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayGainRewardInfo(LevelPlayGainRewardInfo other) : this()
		{
			this.rewardNodeIds_ = other.rewardNodeIds_.Clone();
			this.treasureBoxIds_ = other.treasureBoxIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CA0C RID: 51724 RVA: 0x001DD5BD File Offset: 0x001DB7BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayGainRewardInfo Clone()
		{
			return new LevelPlayGainRewardInfo(this);
		}

		// Token: 0x170028C7 RID: 10439
		// (get) Token: 0x0600CA0D RID: 51725 RVA: 0x001DD5C5 File Offset: 0x001DB7C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RewardNodeIds
		{
			get
			{
				return this.rewardNodeIds_;
			}
		}

		// Token: 0x170028C8 RID: 10440
		// (get) Token: 0x0600CA0E RID: 51726 RVA: 0x001DD5CD File Offset: 0x001DB7CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> TreasureBoxIds
		{
			get
			{
				return this.treasureBoxIds_;
			}
		}

		// Token: 0x0600CA0F RID: 51727 RVA: 0x001DD5D5 File Offset: 0x001DB7D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LevelPlayGainRewardInfo);
		}

		// Token: 0x0600CA10 RID: 51728 RVA: 0x001DD5E4 File Offset: 0x001DB7E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LevelPlayGainRewardInfo other)
		{
			return other != null && (other == this || (this.rewardNodeIds_.Equals(other.rewardNodeIds_) && this.treasureBoxIds_.Equals(other.treasureBoxIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CA11 RID: 51729 RVA: 0x001DD638 File Offset: 0x001DB838
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

		// Token: 0x0600CA12 RID: 51730 RVA: 0x001DD67A File Offset: 0x001DB87A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CA13 RID: 51731 RVA: 0x001DD687 File Offset: 0x001DB887
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CA14 RID: 51732 RVA: 0x001DD690 File Offset: 0x001DB890
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

		// Token: 0x0600CA15 RID: 51733 RVA: 0x001DD6C8 File Offset: 0x001DB8C8
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

		// Token: 0x0600CA16 RID: 51734 RVA: 0x001DD714 File Offset: 0x001DB914
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

		// Token: 0x0600CA17 RID: 51735 RVA: 0x001DD753 File Offset: 0x001DB953
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CA18 RID: 51736 RVA: 0x001DD75C File Offset: 0x001DB95C
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

		// Token: 0x04005658 RID: 22104
		private static readonly MessageParser<LevelPlayGainRewardInfo> _parser = new MessageParser<LevelPlayGainRewardInfo>(() => new LevelPlayGainRewardInfo());

		// Token: 0x04005659 RID: 22105
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400565A RID: 22106
		public const int RewardNodeIdsFieldNumber = 1;

		// Token: 0x0400565B RID: 22107
		private static readonly FieldCodec<int> _repeated_rewardNodeIds_codec = FieldCodec.ForInt32(10U);

		// Token: 0x0400565C RID: 22108
		private readonly RepeatedField<int> rewardNodeIds_ = new RepeatedField<int>();

		// Token: 0x0400565D RID: 22109
		public const int TreasureBoxIdsFieldNumber = 2;

		// Token: 0x0400565E RID: 22110
		private static readonly FieldCodec<int> _repeated_treasureBoxIds_codec = FieldCodec.ForInt32(18U);

		// Token: 0x0400565F RID: 22111
		private readonly RepeatedField<int> treasureBoxIds_ = new RepeatedField<int>();
	}
}
