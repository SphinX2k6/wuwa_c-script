using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000563 RID: 1379
	[NetMessage(EMessageId.FishingIllustratedRewardInfoUpdateNotify)]
	public sealed class FishingIllustratedRewardInfoUpdateNotify : IMessage<FishingIllustratedRewardInfoUpdateNotify>, IMessage, IEquatable<FishingIllustratedRewardInfoUpdateNotify>, IDeepCloneable<FishingIllustratedRewardInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x06008090 RID: 32912 RVA: 0x0013692E File Offset: 0x00134B2E
		[NullableContext(1)]
		public static FishingIllustratedRewardInfoUpdateNotify Create()
		{
			return new FishingIllustratedRewardInfoUpdateNotify();
		}

		// Token: 0x1700190A RID: 6410
		// (get) Token: 0x06008091 RID: 32913 RVA: 0x00136935 File Offset: 0x00134B35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700190B RID: 6411
		// (get) Token: 0x06008092 RID: 32914 RVA: 0x00136938 File Offset: 0x00134B38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingIllustratedRewardInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06008093 RID: 32915 RVA: 0x0013693F File Offset: 0x00134B3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingIllustratedRewardInfoUpdateNotify()
		{
		}

		// Token: 0x06008094 RID: 32916 RVA: 0x00136947 File Offset: 0x00134B47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingIllustratedRewardInfoUpdateNotify(FishingIllustratedRewardInfoUpdateNotify other) : this()
		{
			this.rewardInfo_ = ((other.rewardInfo_ != null) ? other.rewardInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008095 RID: 32917 RVA: 0x0013697C File Offset: 0x00134B7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingIllustratedRewardInfoUpdateNotify Clone()
		{
			return new FishingIllustratedRewardInfoUpdateNotify(this);
		}

		// Token: 0x1700190C RID: 6412
		// (get) Token: 0x06008096 RID: 32918 RVA: 0x00136984 File Offset: 0x00134B84
		// (set) Token: 0x06008097 RID: 32919 RVA: 0x0013698C File Offset: 0x00134B8C
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

		// Token: 0x06008098 RID: 32920 RVA: 0x00136995 File Offset: 0x00134B95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingIllustratedRewardInfoUpdateNotify);
		}

		// Token: 0x06008099 RID: 32921 RVA: 0x001369A3 File Offset: 0x00134BA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingIllustratedRewardInfoUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.RewardInfo, other.RewardInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600809A RID: 32922 RVA: 0x001369D8 File Offset: 0x00134BD8
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

		// Token: 0x0600809B RID: 32923 RVA: 0x00136A14 File Offset: 0x00134C14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600809C RID: 32924 RVA: 0x00136A21 File Offset: 0x00134C21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600809D RID: 32925 RVA: 0x00136A2A File Offset: 0x00134C2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.rewardInfo_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.RewardInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600809E RID: 32926 RVA: 0x00136A5C File Offset: 0x00134C5C
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

		// Token: 0x0600809F RID: 32927 RVA: 0x00136A9C File Offset: 0x00134C9C
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

		// Token: 0x060080A0 RID: 32928 RVA: 0x00136AF0 File Offset: 0x00134CF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060080A1 RID: 32929 RVA: 0x00136AFC File Offset: 0x00134CFC
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
				if (num != 10U)
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

		// Token: 0x040040B2 RID: 16562
		private UnknownFieldSet _unknownFields;

		// Token: 0x040040B3 RID: 16563
		public const int RewardInfoFieldNumber = 1;

		// Token: 0x040040B4 RID: 16564
		private FishingIllustratedRewardInfo rewardInfo_;
	}
}
