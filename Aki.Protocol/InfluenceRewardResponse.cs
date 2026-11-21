using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007BF RID: 1983
	[NetMessage(EMessageId.InfluenceRewardResponse)]
	public sealed class InfluenceRewardResponse : IMessage<InfluenceRewardResponse>, IMessage, IEquatable<InfluenceRewardResponse>, IDeepCloneable<InfluenceRewardResponse>, IBufferMessage
	{
		// Token: 0x0600B2AC RID: 45740 RVA: 0x001ABEBD File Offset: 0x001AA0BD
		[NullableContext(1)]
		public static InfluenceRewardResponse Create()
		{
			return new InfluenceRewardResponse();
		}

		// Token: 0x17002407 RID: 9223
		// (get) Token: 0x0600B2AD RID: 45741 RVA: 0x001ABEC4 File Offset: 0x001AA0C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002408 RID: 9224
		// (get) Token: 0x0600B2AE RID: 45742 RVA: 0x001ABEC7 File Offset: 0x001AA0C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InfluenceRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600B2AF RID: 45743 RVA: 0x001ABECE File Offset: 0x001AA0CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfluenceRewardResponse()
		{
		}

		// Token: 0x0600B2B0 RID: 45744 RVA: 0x001ABEE4 File Offset: 0x001AA0E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfluenceRewardResponse(InfluenceRewardResponse other) : this()
		{
			this.code_ = other.code_;
			this.influenceId_ = other.influenceId_;
			this.rewardIndex_ = other.rewardIndex_;
			this.rewardItems_ = other.rewardItems_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B2B1 RID: 45745 RVA: 0x001ABF3D File Offset: 0x001AA13D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InfluenceRewardResponse Clone()
		{
			return new InfluenceRewardResponse(this);
		}

		// Token: 0x17002409 RID: 9225
		// (get) Token: 0x0600B2B2 RID: 45746 RVA: 0x001ABF45 File Offset: 0x001AA145
		// (set) Token: 0x0600B2B3 RID: 45747 RVA: 0x001ABF4D File Offset: 0x001AA14D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Code
		{
			get
			{
				return this.code_;
			}
			set
			{
				this.code_ = value;
			}
		}

		// Token: 0x1700240A RID: 9226
		// (get) Token: 0x0600B2B4 RID: 45748 RVA: 0x001ABF56 File Offset: 0x001AA156
		// (set) Token: 0x0600B2B5 RID: 45749 RVA: 0x001ABF5E File Offset: 0x001AA15E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InfluenceId
		{
			get
			{
				return this.influenceId_;
			}
			set
			{
				this.influenceId_ = value;
			}
		}

		// Token: 0x1700240B RID: 9227
		// (get) Token: 0x0600B2B6 RID: 45750 RVA: 0x001ABF67 File Offset: 0x001AA167
		// (set) Token: 0x0600B2B7 RID: 45751 RVA: 0x001ABF6F File Offset: 0x001AA16F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RewardIndex
		{
			get
			{
				return this.rewardIndex_;
			}
			set
			{
				this.rewardIndex_ = value;
			}
		}

		// Token: 0x1700240C RID: 9228
		// (get) Token: 0x0600B2B8 RID: 45752 RVA: 0x001ABF78 File Offset: 0x001AA178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> RewardItems
		{
			get
			{
				return this.rewardItems_;
			}
		}

		// Token: 0x0600B2B9 RID: 45753 RVA: 0x001ABF80 File Offset: 0x001AA180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InfluenceRewardResponse);
		}

		// Token: 0x0600B2BA RID: 45754 RVA: 0x001ABF90 File Offset: 0x001AA190
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InfluenceRewardResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.InfluenceId == other.InfluenceId && this.RewardIndex == other.RewardIndex && this.RewardItems.Equals(other.RewardItems) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B2BB RID: 45755 RVA: 0x001AC000 File Offset: 0x001AA200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			if (this.InfluenceId != 0)
			{
				num ^= this.InfluenceId.GetHashCode();
			}
			if (this.RewardIndex != 0)
			{
				num ^= this.RewardIndex.GetHashCode();
			}
			num ^= this.RewardItems.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B2BC RID: 45756 RVA: 0x001AC085 File Offset: 0x001AA285
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B2BD RID: 45757 RVA: 0x001AC092 File Offset: 0x001AA292
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B2BE RID: 45758 RVA: 0x001AC09C File Offset: 0x001AA29C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RewardIndex != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.RewardIndex);
			}
			this.rewardItems_.WriteTo(ref output, InfluenceRewardResponse._map_rewardItems_codec);
			if (this.InfluenceId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.InfluenceId);
			}
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B2BF RID: 45759 RVA: 0x001AC124 File Offset: 0x001AA324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			if (this.InfluenceId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InfluenceId);
			}
			if (this.RewardIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RewardIndex);
			}
			num += this.rewardItems_.CalculateSize(InfluenceRewardResponse._map_rewardItems_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B2C0 RID: 45760 RVA: 0x001AC1A8 File Offset: 0x001AA3A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InfluenceRewardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			if (other.InfluenceId != 0)
			{
				this.InfluenceId = other.InfluenceId;
			}
			if (other.RewardIndex != 0)
			{
				this.RewardIndex = other.RewardIndex;
			}
			this.rewardItems_.MergeFrom(other.rewardItems_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B2C1 RID: 45761 RVA: 0x001AC21D File Offset: 0x001AA41D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B2C2 RID: 45762 RVA: 0x001AC228 File Offset: 0x001AA428
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
				if (num <= 42U)
				{
					if (num == 16U)
					{
						this.RewardIndex = input.ReadInt32();
						continue;
					}
					if (num == 42U)
					{
						this.rewardItems_.AddEntriesFrom(ref input, InfluenceRewardResponse._map_rewardItems_codec);
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.InfluenceId = input.ReadInt32();
						continue;
					}
					if (num == 80U)
					{
						this.Code = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04005029 RID: 20521
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400502A RID: 20522
		public const int CodeFieldNumber = 10;

		// Token: 0x0400502B RID: 20523
		private ErrorCode code_;

		// Token: 0x0400502C RID: 20524
		public const int InfluenceIdFieldNumber = 7;

		// Token: 0x0400502D RID: 20525
		private int influenceId_;

		// Token: 0x0400502E RID: 20526
		public const int RewardIndexFieldNumber = 2;

		// Token: 0x0400502F RID: 20527
		private int rewardIndex_;

		// Token: 0x04005030 RID: 20528
		public const int RewardItemsFieldNumber = 5;

		// Token: 0x04005031 RID: 20529
		private static readonly MapField<int, int>.Codec _map_rewardItems_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 42U);

		// Token: 0x04005032 RID: 20530
		private readonly MapField<int, int> rewardItems_ = new MapField<int, int>();
	}
}
