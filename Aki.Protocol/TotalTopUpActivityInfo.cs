using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200138A RID: 5002
	public sealed class TotalTopUpActivityInfo : IMessage<TotalTopUpActivityInfo>, IMessage, IEquatable<TotalTopUpActivityInfo>, IDeepCloneable<TotalTopUpActivityInfo>, IBufferMessage
	{
		// Token: 0x0601A8C1 RID: 108737 RVA: 0x003DA17C File Offset: 0x003D837C
		[NullableContext(1)]
		public static TotalTopUpActivityInfo Create()
		{
			return new TotalTopUpActivityInfo();
		}

		// Token: 0x17005983 RID: 22915
		// (get) Token: 0x0601A8C2 RID: 108738 RVA: 0x003DA183 File Offset: 0x003D8383
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005984 RID: 22916
		// (get) Token: 0x0601A8C3 RID: 108739 RVA: 0x003DA186 File Offset: 0x003D8386
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TotalTopUpActivityInfo.Descriptor;
			}
		}

		// Token: 0x0601A8C4 RID: 108740 RVA: 0x003DA18D File Offset: 0x003D838D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TotalTopUpActivityInfo()
		{
		}

		// Token: 0x0601A8C5 RID: 108741 RVA: 0x003DA1A0 File Offset: 0x003D83A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TotalTopUpActivityInfo(TotalTopUpActivityInfo other) : this()
		{
			this.score_ = other.score_;
			this.totalTopUpRewardInfos_ = other.totalTopUpRewardInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A8C6 RID: 108742 RVA: 0x003DA1D6 File Offset: 0x003D83D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TotalTopUpActivityInfo Clone()
		{
			return new TotalTopUpActivityInfo(this);
		}

		// Token: 0x17005985 RID: 22917
		// (get) Token: 0x0601A8C7 RID: 108743 RVA: 0x003DA1DE File Offset: 0x003D83DE
		// (set) Token: 0x0601A8C8 RID: 108744 RVA: 0x003DA1E6 File Offset: 0x003D83E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Score
		{
			get
			{
				return this.score_;
			}
			set
			{
				this.score_ = value;
			}
		}

		// Token: 0x17005986 RID: 22918
		// (get) Token: 0x0601A8C9 RID: 108745 RVA: 0x003DA1EF File Offset: 0x003D83EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TotalTopUpRewardInfo> TotalTopUpRewardInfos
		{
			get
			{
				return this.totalTopUpRewardInfos_;
			}
		}

		// Token: 0x0601A8CA RID: 108746 RVA: 0x003DA1F7 File Offset: 0x003D83F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TotalTopUpActivityInfo);
		}

		// Token: 0x0601A8CB RID: 108747 RVA: 0x003DA208 File Offset: 0x003D8408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TotalTopUpActivityInfo other)
		{
			return other != null && (other == this || (this.Score == other.Score && this.totalTopUpRewardInfos_.Equals(other.totalTopUpRewardInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A8CC RID: 108748 RVA: 0x003DA258 File Offset: 0x003D8458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Score != 0)
			{
				num ^= this.Score.GetHashCode();
			}
			num ^= this.totalTopUpRewardInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A8CD RID: 108749 RVA: 0x003DA2A5 File Offset: 0x003D84A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A8CE RID: 108750 RVA: 0x003DA2B2 File Offset: 0x003D84B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A8CF RID: 108751 RVA: 0x003DA2BC File Offset: 0x003D84BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Score != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Score);
			}
			this.totalTopUpRewardInfos_.WriteTo(ref output, TotalTopUpActivityInfo._repeated_totalTopUpRewardInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A8D0 RID: 108752 RVA: 0x003DA30C File Offset: 0x003D850C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Score != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Score);
			}
			num += this.totalTopUpRewardInfos_.CalculateSize(TotalTopUpActivityInfo._repeated_totalTopUpRewardInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A8D1 RID: 108753 RVA: 0x003DA360 File Offset: 0x003D8560
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TotalTopUpActivityInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Score != 0)
			{
				this.Score = other.Score;
			}
			this.totalTopUpRewardInfos_.Add(other.totalTopUpRewardInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A8D2 RID: 108754 RVA: 0x003DA3AD File Offset: 0x003D85AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A8D3 RID: 108755 RVA: 0x003DA3B8 File Offset: 0x003D85B8
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
				if (num != 8U)
				{
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.totalTopUpRewardInfos_.AddEntriesFrom(ref input, TotalTopUpActivityInfo._repeated_totalTopUpRewardInfos_codec);
					}
				}
				else
				{
					this.Score = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009A5A RID: 39514
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009A5B RID: 39515
		public const int ScoreFieldNumber = 1;

		// Token: 0x04009A5C RID: 39516
		private int score_;

		// Token: 0x04009A5D RID: 39517
		public const int TotalTopUpRewardInfosFieldNumber = 2;

		// Token: 0x04009A5E RID: 39518
		private static readonly FieldCodec<TotalTopUpRewardInfo> _repeated_totalTopUpRewardInfos_codec = FieldCodec.ForMessage<TotalTopUpRewardInfo>(18U, TotalTopUpRewardInfo.Parser);

		// Token: 0x04009A5F RID: 39519
		private readonly RepeatedField<TotalTopUpRewardInfo> totalTopUpRewardInfos_ = new RepeatedField<TotalTopUpRewardInfo>();
	}
}
