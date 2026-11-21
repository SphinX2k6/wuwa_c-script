using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200054E RID: 1358
	[NetMessage(EMessageId.FishingIllustratedRewardInfoUpdateNotify)]
	public sealed class FishingIllustratedRewardInfoUpdateNotify : IMessage<FishingIllustratedRewardInfoUpdateNotify>, IMessage, IEquatable<FishingIllustratedRewardInfoUpdateNotify>, IDeepCloneable<FishingIllustratedRewardInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x06007F28 RID: 32552 RVA: 0x00133D2E File Offset: 0x00131F2E
		[NullableContext(1)]
		public static FishingIllustratedRewardInfoUpdateNotify Create()
		{
			return new FishingIllustratedRewardInfoUpdateNotify();
		}

		// Token: 0x170018BD RID: 6333
		// (get) Token: 0x06007F29 RID: 32553 RVA: 0x00133D35 File Offset: 0x00131F35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170018BE RID: 6334
		// (get) Token: 0x06007F2A RID: 32554 RVA: 0x00133D38 File Offset: 0x00131F38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingIllustratedRewardInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06007F2B RID: 32555 RVA: 0x00133D3F File Offset: 0x00131F3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingIllustratedRewardInfoUpdateNotify()
		{
		}

		// Token: 0x06007F2C RID: 32556 RVA: 0x00133D47 File Offset: 0x00131F47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingIllustratedRewardInfoUpdateNotify(FishingIllustratedRewardInfoUpdateNotify other) : this()
		{
			this.rewardInfo_ = ((other.rewardInfo_ != null) ? other.rewardInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007F2D RID: 32557 RVA: 0x00133D7C File Offset: 0x00131F7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingIllustratedRewardInfoUpdateNotify Clone()
		{
			return new FishingIllustratedRewardInfoUpdateNotify(this);
		}

		// Token: 0x170018BF RID: 6335
		// (get) Token: 0x06007F2E RID: 32558 RVA: 0x00133D84 File Offset: 0x00131F84
		// (set) Token: 0x06007F2F RID: 32559 RVA: 0x00133D8C File Offset: 0x00131F8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingIllustratedRewardInfo RewardInfo
		{
			get
			{
				return this.rewardInfo_;
			}
			set
			{
				this.rewardInfo_ = value;
			}
		}

		// Token: 0x06007F30 RID: 32560 RVA: 0x00133D95 File Offset: 0x00131F95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingIllustratedRewardInfoUpdateNotify);
		}

		// Token: 0x06007F31 RID: 32561 RVA: 0x00133DA3 File Offset: 0x00131FA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingIllustratedRewardInfoUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.RewardInfo, other.RewardInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007F32 RID: 32562 RVA: 0x00133DD8 File Offset: 0x00131FD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.rewardInfo_ != null)
			{
				num ^= this.RewardInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007F33 RID: 32563 RVA: 0x00133E14 File Offset: 0x00132014
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007F34 RID: 32564 RVA: 0x00133E21 File Offset: 0x00132021
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007F35 RID: 32565 RVA: 0x00133E2A File Offset: 0x0013202A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.rewardInfo_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(this.RewardInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007F36 RID: 32566 RVA: 0x00133E5C File Offset: 0x0013205C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.rewardInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RewardInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007F37 RID: 32567 RVA: 0x00133E9C File Offset: 0x0013209C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingIllustratedRewardInfoUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.rewardInfo_ != null)
			{
				if (this.rewardInfo_ == null)
				{
					this.RewardInfo = new FishingIllustratedRewardInfo();
				}
				this.RewardInfo.MergeFrom(other.RewardInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007F38 RID: 32568 RVA: 0x00133EF0 File Offset: 0x001320F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007F39 RID: 32569 RVA: 0x00133EFC File Offset: 0x001320FC
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
				if (num != 74U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.rewardInfo_ == null)
					{
						this.RewardInfo = new FishingIllustratedRewardInfo();
					}
					input.ReadMessage(this.RewardInfo);
				}
			}
		}

		// Token: 0x040040A8 RID: 16552
		private UnknownFieldSet _unknownFields;

		// Token: 0x040040A9 RID: 16553
		public const int RewardInfoFieldNumber = 9;

		// Token: 0x040040AA RID: 16554
		private FishingIllustratedRewardInfo rewardInfo_;
	}
}
