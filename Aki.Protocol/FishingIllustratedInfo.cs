using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000560 RID: 1376
	public sealed class FishingIllustratedInfo : IMessage<FishingIllustratedInfo>, IMessage, IEquatable<FishingIllustratedInfo>, IDeepCloneable<FishingIllustratedInfo>, IBufferMessage
	{
		// Token: 0x0600804C RID: 32844 RVA: 0x00135E34 File Offset: 0x00134034
		[NullableContext(1)]
		public static FishingIllustratedInfo Create()
		{
			return new FishingIllustratedInfo();
		}

		// Token: 0x170018F9 RID: 6393
		// (get) Token: 0x0600804D RID: 32845 RVA: 0x00135E3B File Offset: 0x0013403B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170018FA RID: 6394
		// (get) Token: 0x0600804E RID: 32846 RVA: 0x00135E3E File Offset: 0x0013403E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingIllustratedInfo.Descriptor;
			}
		}

		// Token: 0x0600804F RID: 32847 RVA: 0x00135E45 File Offset: 0x00134045
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingIllustratedInfo()
		{
		}

		// Token: 0x06008050 RID: 32848 RVA: 0x00135E70 File Offset: 0x00134070
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingIllustratedInfo(FishingIllustratedInfo other) : this()
		{
			this.illustratedList_ = other.illustratedList_.Clone();
			this.rewardedId_ = other.rewardedId_.Clone();
			this.unlockDetections_ = other.unlockDetections_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008051 RID: 32849 RVA: 0x00135EC7 File Offset: 0x001340C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingIllustratedInfo Clone()
		{
			return new FishingIllustratedInfo(this);
		}

		// Token: 0x170018FB RID: 6395
		// (get) Token: 0x06008052 RID: 32850 RVA: 0x00135ECF File Offset: 0x001340CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<OneFishingIllustratedInfo> IllustratedList
		{
			get
			{
				return this.illustratedList_;
			}
		}

		// Token: 0x170018FC RID: 6396
		// (get) Token: 0x06008053 RID: 32851 RVA: 0x00135ED7 File Offset: 0x001340D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FishingIllustratedRewardInfo> RewardedId
		{
			get
			{
				return this.rewardedId_;
			}
		}

		// Token: 0x170018FD RID: 6397
		// (get) Token: 0x06008054 RID: 32852 RVA: 0x00135EDF File Offset: 0x001340DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockDetections
		{
			get
			{
				return this.unlockDetections_;
			}
		}

		// Token: 0x06008055 RID: 32853 RVA: 0x00135EE7 File Offset: 0x001340E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingIllustratedInfo);
		}

		// Token: 0x06008056 RID: 32854 RVA: 0x00135EF8 File Offset: 0x001340F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingIllustratedInfo other)
		{
			return other != null && (other == this || (this.illustratedList_.Equals(other.illustratedList_) && this.rewardedId_.Equals(other.rewardedId_) && this.unlockDetections_.Equals(other.unlockDetections_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008057 RID: 32855 RVA: 0x00135F60 File Offset: 0x00134160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.illustratedList_.GetHashCode();
			num ^= this.rewardedId_.GetHashCode();
			num ^= this.unlockDetections_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008058 RID: 32856 RVA: 0x00135FB0 File Offset: 0x001341B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008059 RID: 32857 RVA: 0x00135FBD File Offset: 0x001341BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600805A RID: 32858 RVA: 0x00135FC8 File Offset: 0x001341C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.illustratedList_.WriteTo(ref output, FishingIllustratedInfo._repeated_illustratedList_codec);
			this.rewardedId_.WriteTo(ref output, FishingIllustratedInfo._repeated_rewardedId_codec);
			this.unlockDetections_.WriteTo(ref output, FishingIllustratedInfo._repeated_unlockDetections_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600805B RID: 32859 RVA: 0x0013601C File Offset: 0x0013421C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.illustratedList_.CalculateSize(FishingIllustratedInfo._repeated_illustratedList_codec);
			num += this.rewardedId_.CalculateSize(FishingIllustratedInfo._repeated_rewardedId_codec);
			num += this.unlockDetections_.CalculateSize(FishingIllustratedInfo._repeated_unlockDetections_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600805C RID: 32860 RVA: 0x0013607C File Offset: 0x0013427C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingIllustratedInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.illustratedList_.Add(other.illustratedList_);
			this.rewardedId_.Add(other.rewardedId_);
			this.unlockDetections_.Add(other.unlockDetections_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600805D RID: 32861 RVA: 0x001360D7 File Offset: 0x001342D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600805E RID: 32862 RVA: 0x001360E0 File Offset: 0x001342E0
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
					if (num == 10U)
					{
						this.illustratedList_.AddEntriesFrom(ref input, FishingIllustratedInfo._repeated_illustratedList_codec);
						continue;
					}
					if (num == 18U)
					{
						this.rewardedId_.AddEntriesFrom(ref input, FishingIllustratedInfo._repeated_rewardedId_codec);
						continue;
					}
				}
				else if (num == 24U || num == 26U)
				{
					this.unlockDetections_.AddEntriesFrom(ref input, FishingIllustratedInfo._repeated_unlockDetections_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004096 RID: 16534
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004097 RID: 16535
		public const int IllustratedListFieldNumber = 1;

		// Token: 0x04004098 RID: 16536
		private static readonly FieldCodec<OneFishingIllustratedInfo> _repeated_illustratedList_codec = FieldCodec.ForMessage<OneFishingIllustratedInfo>(10U, OneFishingIllustratedInfo.Parser);

		// Token: 0x04004099 RID: 16537
		private readonly RepeatedField<OneFishingIllustratedInfo> illustratedList_ = new RepeatedField<OneFishingIllustratedInfo>();

		// Token: 0x0400409A RID: 16538
		public const int RewardedIdFieldNumber = 2;

		// Token: 0x0400409B RID: 16539
		private static readonly FieldCodec<FishingIllustratedRewardInfo> _repeated_rewardedId_codec = FieldCodec.ForMessage<FishingIllustratedRewardInfo>(18U, FishingIllustratedRewardInfo.Parser);

		// Token: 0x0400409C RID: 16540
		private readonly RepeatedField<FishingIllustratedRewardInfo> rewardedId_ = new RepeatedField<FishingIllustratedRewardInfo>();

		// Token: 0x0400409D RID: 16541
		public const int UnlockDetectionsFieldNumber = 3;

		// Token: 0x0400409E RID: 16542
		private static readonly FieldCodec<int> _repeated_unlockDetections_codec = FieldCodec.ForInt32(26U);

		// Token: 0x0400409F RID: 16543
		private readonly RepeatedField<int> unlockDetections_ = new RepeatedField<int>();
	}
}
