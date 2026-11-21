using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200143C RID: 5180
	[NetMessage(EMessageId.TowerRewardRequest)]
	public sealed class TowerRewardRequest : IMessage<TowerRewardRequest>, IMessage, IEquatable<TowerRewardRequest>, IDeepCloneable<TowerRewardRequest>, IBufferMessage
	{
		// Token: 0x0601B860 RID: 112736 RVA: 0x00400264 File Offset: 0x003FE464
		[NullableContext(1)]
		public static TowerRewardRequest Create()
		{
			return new TowerRewardRequest();
		}

		// Token: 0x17005D2E RID: 23854
		// (get) Token: 0x0601B861 RID: 112737 RVA: 0x0040026B File Offset: 0x003FE46B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005D2F RID: 23855
		// (get) Token: 0x0601B862 RID: 112738 RVA: 0x0040026E File Offset: 0x003FE46E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerRewardRequest.Descriptor;
			}
		}

		// Token: 0x0601B863 RID: 112739 RVA: 0x00400275 File Offset: 0x003FE475
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerRewardRequest()
		{
		}

		// Token: 0x0601B864 RID: 112740 RVA: 0x00400288 File Offset: 0x003FE488
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerRewardRequest(TowerRewardRequest other) : this()
		{
			this.difficulty_ = other.difficulty_;
			this.rewardIndex_ = other.rewardIndex_;
			this.rewardIndexList_ = other.rewardIndexList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B865 RID: 112741 RVA: 0x004002D5 File Offset: 0x003FE4D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerRewardRequest Clone()
		{
			return new TowerRewardRequest(this);
		}

		// Token: 0x17005D30 RID: 23856
		// (get) Token: 0x0601B866 RID: 112742 RVA: 0x004002DD File Offset: 0x003FE4DD
		// (set) Token: 0x0601B867 RID: 112743 RVA: 0x004002E5 File Offset: 0x003FE4E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Difficulty
		{
			get
			{
				return this.difficulty_;
			}
			set
			{
				this.difficulty_ = value;
			}
		}

		// Token: 0x17005D31 RID: 23857
		// (get) Token: 0x0601B868 RID: 112744 RVA: 0x004002EE File Offset: 0x003FE4EE
		// (set) Token: 0x0601B869 RID: 112745 RVA: 0x004002F6 File Offset: 0x003FE4F6
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

		// Token: 0x17005D32 RID: 23858
		// (get) Token: 0x0601B86A RID: 112746 RVA: 0x004002FF File Offset: 0x003FE4FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RewardIndexList
		{
			get
			{
				return this.rewardIndexList_;
			}
		}

		// Token: 0x0601B86B RID: 112747 RVA: 0x00400307 File Offset: 0x003FE507
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerRewardRequest);
		}

		// Token: 0x0601B86C RID: 112748 RVA: 0x00400318 File Offset: 0x003FE518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerRewardRequest other)
		{
			return other != null && (other == this || (this.Difficulty == other.Difficulty && this.RewardIndex == other.RewardIndex && this.rewardIndexList_.Equals(other.rewardIndexList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B86D RID: 112749 RVA: 0x00400378 File Offset: 0x003FE578
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Difficulty != 0)
			{
				num ^= this.Difficulty.GetHashCode();
			}
			if (this.RewardIndex != 0)
			{
				num ^= this.RewardIndex.GetHashCode();
			}
			num ^= this.rewardIndexList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B86E RID: 112750 RVA: 0x004003DE File Offset: 0x003FE5DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B86F RID: 112751 RVA: 0x004003EB File Offset: 0x003FE5EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B870 RID: 112752 RVA: 0x004003F4 File Offset: 0x003FE5F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.rewardIndexList_.WriteTo(ref output, TowerRewardRequest._repeated_rewardIndexList_codec);
			if (this.RewardIndex != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.RewardIndex);
			}
			if (this.Difficulty != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.Difficulty);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B871 RID: 112753 RVA: 0x00400460 File Offset: 0x003FE660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Difficulty != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Difficulty);
			}
			if (this.RewardIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RewardIndex);
			}
			num += this.rewardIndexList_.CalculateSize(TowerRewardRequest._repeated_rewardIndexList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B872 RID: 112754 RVA: 0x004004CC File Offset: 0x003FE6CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TowerRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Difficulty != 0)
			{
				this.Difficulty = other.Difficulty;
			}
			if (other.RewardIndex != 0)
			{
				this.RewardIndex = other.RewardIndex;
			}
			this.rewardIndexList_.Add(other.rewardIndexList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B873 RID: 112755 RVA: 0x0040052D File Offset: 0x003FE72D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B874 RID: 112756 RVA: 0x00400538 File Offset: 0x003FE738
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
				if (num <= 18U)
				{
					if (num == 16U || num == 18U)
					{
						this.rewardIndexList_.AddEntriesFrom(ref input, TowerRewardRequest._repeated_rewardIndexList_codec);
						continue;
					}
				}
				else
				{
					if (num == 48U)
					{
						this.RewardIndex = input.ReadInt32();
						continue;
					}
					if (num == 64U)
					{
						this.Difficulty = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400A021 RID: 40993
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A022 RID: 40994
		public const int DifficultyFieldNumber = 8;

		// Token: 0x0400A023 RID: 40995
		private int difficulty_;

		// Token: 0x0400A024 RID: 40996
		public const int RewardIndexFieldNumber = 6;

		// Token: 0x0400A025 RID: 40997
		private int rewardIndex_;

		// Token: 0x0400A026 RID: 40998
		public const int RewardIndexListFieldNumber = 2;

		// Token: 0x0400A027 RID: 40999
		private static readonly FieldCodec<int> _repeated_rewardIndexList_codec = FieldCodec.ForInt32(18U);

		// Token: 0x0400A028 RID: 41000
		private readonly RepeatedField<int> rewardIndexList_ = new RepeatedField<int>();
	}
}
