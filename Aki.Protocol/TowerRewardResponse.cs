using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200143D RID: 5181
	[NetMessage(EMessageId.TowerRewardResponse)]
	public sealed class TowerRewardResponse : IMessage<TowerRewardResponse>, IMessage, IEquatable<TowerRewardResponse>, IDeepCloneable<TowerRewardResponse>, IBufferMessage
	{
		// Token: 0x0601B876 RID: 112758 RVA: 0x004005C2 File Offset: 0x003FE7C2
		[NullableContext(1)]
		public static TowerRewardResponse Create()
		{
			return new TowerRewardResponse();
		}

		// Token: 0x17005D33 RID: 23859
		// (get) Token: 0x0601B877 RID: 112759 RVA: 0x004005C9 File Offset: 0x003FE7C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005D34 RID: 23860
		// (get) Token: 0x0601B878 RID: 112760 RVA: 0x004005CC File Offset: 0x003FE7CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerRewardResponse.Descriptor;
			}
		}

		// Token: 0x0601B879 RID: 112761 RVA: 0x004005D3 File Offset: 0x003FE7D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerRewardResponse()
		{
		}

		// Token: 0x0601B87A RID: 112762 RVA: 0x004005E8 File Offset: 0x003FE7E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerRewardResponse(TowerRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.needUpdateSeason_ = other.needUpdateSeason_;
			this.rewardIndexList_ = other.rewardIndexList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B87B RID: 112763 RVA: 0x00400635 File Offset: 0x003FE835
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerRewardResponse Clone()
		{
			return new TowerRewardResponse(this);
		}

		// Token: 0x17005D35 RID: 23861
		// (get) Token: 0x0601B87C RID: 112764 RVA: 0x0040063D File Offset: 0x003FE83D
		// (set) Token: 0x0601B87D RID: 112765 RVA: 0x00400645 File Offset: 0x003FE845
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

		// Token: 0x17005D36 RID: 23862
		// (get) Token: 0x0601B87E RID: 112766 RVA: 0x0040064E File Offset: 0x003FE84E
		// (set) Token: 0x0601B87F RID: 112767 RVA: 0x00400656 File Offset: 0x003FE856
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool NeedUpdateSeason
		{
			get
			{
				return this.needUpdateSeason_;
			}
			set
			{
				this.needUpdateSeason_ = value;
			}
		}

		// Token: 0x17005D37 RID: 23863
		// (get) Token: 0x0601B880 RID: 112768 RVA: 0x0040065F File Offset: 0x003FE85F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RewardIndexList
		{
			get
			{
				return this.rewardIndexList_;
			}
		}

		// Token: 0x0601B881 RID: 112769 RVA: 0x00400667 File Offset: 0x003FE867
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerRewardResponse);
		}

		// Token: 0x0601B882 RID: 112770 RVA: 0x00400678 File Offset: 0x003FE878
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.NeedUpdateSeason == other.NeedUpdateSeason && this.rewardIndexList_.Equals(other.rewardIndexList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B883 RID: 112771 RVA: 0x004006D8 File Offset: 0x003FE8D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.NeedUpdateSeason)
			{
				num ^= this.NeedUpdateSeason.GetHashCode();
			}
			num ^= this.rewardIndexList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B884 RID: 112772 RVA: 0x00400744 File Offset: 0x003FE944
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B885 RID: 112773 RVA: 0x00400751 File Offset: 0x003FE951
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B886 RID: 112774 RVA: 0x0040075C File Offset: 0x003FE95C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.NeedUpdateSeason)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.NeedUpdateSeason);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.rewardIndexList_.WriteTo(ref output, TowerRewardResponse._repeated_rewardIndexList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B887 RID: 112775 RVA: 0x004007C8 File Offset: 0x003FE9C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.NeedUpdateSeason)
			{
				num += 2;
			}
			num += this.rewardIndexList_.CalculateSize(TowerRewardResponse._repeated_rewardIndexList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B888 RID: 112776 RVA: 0x00400828 File Offset: 0x003FEA28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TowerRewardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.NeedUpdateSeason)
			{
				this.NeedUpdateSeason = other.NeedUpdateSeason;
			}
			this.rewardIndexList_.Add(other.rewardIndexList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B889 RID: 112777 RVA: 0x00400889 File Offset: 0x003FEA89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B88A RID: 112778 RVA: 0x00400894 File Offset: 0x003FEA94
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
				if (num <= 32U)
				{
					if (num == 24U)
					{
						this.NeedUpdateSeason = input.ReadBool();
						continue;
					}
					if (num == 32U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				else if (num == 120U || num == 122U)
				{
					this.rewardIndexList_.AddEntriesFrom(ref input, TowerRewardResponse._repeated_rewardIndexList_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400A029 RID: 41001
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A02A RID: 41002
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x0400A02B RID: 41003
		private ErrorCode errorCode_;

		// Token: 0x0400A02C RID: 41004
		public const int NeedUpdateSeasonFieldNumber = 3;

		// Token: 0x0400A02D RID: 41005
		private bool needUpdateSeason_;

		// Token: 0x0400A02E RID: 41006
		public const int RewardIndexListFieldNumber = 15;

		// Token: 0x0400A02F RID: 41007
		private static readonly FieldCodec<int> _repeated_rewardIndexList_codec = FieldCodec.ForInt32(122U);

		// Token: 0x0400A030 RID: 41008
		private readonly RepeatedField<int> rewardIndexList_ = new RepeatedField<int>();
	}
}
