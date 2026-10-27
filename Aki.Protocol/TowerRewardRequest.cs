using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013C9 RID: 5065
	[NetMessage(EMessageId.TowerRewardRequest)]
	public sealed class TowerRewardRequest : IMessage<TowerRewardRequest>, IMessage, IEquatable<TowerRewardRequest>, IDeepCloneable<TowerRewardRequest>, IBufferMessage
	{
		// Token: 0x0601ADD5 RID: 110037 RVA: 0x003E4FA0 File Offset: 0x003E31A0
		[NullableContext(1)]
		public static TowerRewardRequest Create()
		{
			return new TowerRewardRequest();
		}

		// Token: 0x17005A99 RID: 23193
		// (get) Token: 0x0601ADD6 RID: 110038 RVA: 0x003E4FA7 File Offset: 0x003E31A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005A9A RID: 23194
		// (get) Token: 0x0601ADD7 RID: 110039 RVA: 0x003E4FAA File Offset: 0x003E31AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerRewardRequest.Descriptor;
			}
		}

		// Token: 0x0601ADD8 RID: 110040 RVA: 0x003E4FB1 File Offset: 0x003E31B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerRewardRequest()
		{
		}

		// Token: 0x0601ADD9 RID: 110041 RVA: 0x003E4FC4 File Offset: 0x003E31C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerRewardRequest(TowerRewardRequest other) : this()
		{
			this.difficulty_ = other.difficulty_;
			this.rewardIndex_ = other.rewardIndex_;
			this.rewardIndexList_ = other.rewardIndexList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601ADDA RID: 110042 RVA: 0x003E5011 File Offset: 0x003E3211
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerRewardRequest Clone()
		{
			return new TowerRewardRequest(this);
		}

		// Token: 0x17005A9B RID: 23195
		// (get) Token: 0x0601ADDB RID: 110043 RVA: 0x003E5019 File Offset: 0x003E3219
		// (set) Token: 0x0601ADDC RID: 110044 RVA: 0x003E5021 File Offset: 0x003E3221
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

		// Token: 0x17005A9C RID: 23196
		// (get) Token: 0x0601ADDD RID: 110045 RVA: 0x003E502A File Offset: 0x003E322A
		// (set) Token: 0x0601ADDE RID: 110046 RVA: 0x003E5032 File Offset: 0x003E3232
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

		// Token: 0x17005A9D RID: 23197
		// (get) Token: 0x0601ADDF RID: 110047 RVA: 0x003E503B File Offset: 0x003E323B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RewardIndexList
		{
			get
			{
				return this.rewardIndexList_;
			}
		}

		// Token: 0x0601ADE0 RID: 110048 RVA: 0x003E5043 File Offset: 0x003E3243
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerRewardRequest);
		}

		// Token: 0x0601ADE1 RID: 110049 RVA: 0x003E5054 File Offset: 0x003E3254
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerRewardRequest other)
		{
			return other != null && (other == this || (this.Difficulty == other.Difficulty && this.RewardIndex == other.RewardIndex && this.rewardIndexList_.Equals(other.rewardIndexList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601ADE2 RID: 110050 RVA: 0x003E50B4 File Offset: 0x003E32B4
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

		// Token: 0x0601ADE3 RID: 110051 RVA: 0x003E511A File Offset: 0x003E331A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601ADE4 RID: 110052 RVA: 0x003E5127 File Offset: 0x003E3327
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601ADE5 RID: 110053 RVA: 0x003E5130 File Offset: 0x003E3330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.rewardIndexList_.WriteTo(ref output, TowerRewardRequest._repeated_rewardIndexList_codec);
			if (this.RewardIndex != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.RewardIndex);
			}
			if (this.Difficulty != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.Difficulty);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601ADE6 RID: 110054 RVA: 0x003E519C File Offset: 0x003E339C
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

		// Token: 0x0601ADE7 RID: 110055 RVA: 0x003E5208 File Offset: 0x003E3408
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

		// Token: 0x0601ADE8 RID: 110056 RVA: 0x003E5269 File Offset: 0x003E3469
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601ADE9 RID: 110057 RVA: 0x003E5274 File Offset: 0x003E3474
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
						this.rewardIndexList_.AddEntriesFrom(ref input, TowerRewardRequest._repeated_rewardIndexList_codec);
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.RewardIndex = input.ReadInt32();
						continue;
					}
					if (num == 120U)
					{
						this.Difficulty = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009BDA RID: 39898
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009BDB RID: 39899
		public const int DifficultyFieldNumber = 15;

		// Token: 0x04009BDC RID: 39900
		private int difficulty_;

		// Token: 0x04009BDD RID: 39901
		public const int RewardIndexFieldNumber = 11;

		// Token: 0x04009BDE RID: 39902
		private int rewardIndex_;

		// Token: 0x04009BDF RID: 39903
		public const int RewardIndexListFieldNumber = 1;

		// Token: 0x04009BE0 RID: 39904
		private static readonly FieldCodec<int> _repeated_rewardIndexList_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04009BE1 RID: 39905
		private readonly RepeatedField<int> rewardIndexList_ = new RepeatedField<int>();
	}
}
