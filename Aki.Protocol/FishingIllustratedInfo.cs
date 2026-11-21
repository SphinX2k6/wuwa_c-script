using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200054B RID: 1355
	public sealed class FishingIllustratedInfo : IMessage<FishingIllustratedInfo>, IMessage, IEquatable<FishingIllustratedInfo>, IDeepCloneable<FishingIllustratedInfo>, IBufferMessage
	{
		// Token: 0x06007EE4 RID: 32484 RVA: 0x00133234 File Offset: 0x00131434
		[NullableContext(1)]
		public static FishingIllustratedInfo Create()
		{
			return new FishingIllustratedInfo();
		}

		// Token: 0x170018AC RID: 6316
		// (get) Token: 0x06007EE5 RID: 32485 RVA: 0x0013323B File Offset: 0x0013143B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170018AD RID: 6317
		// (get) Token: 0x06007EE6 RID: 32486 RVA: 0x0013323E File Offset: 0x0013143E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingIllustratedInfo.Descriptor;
			}
		}

		// Token: 0x06007EE7 RID: 32487 RVA: 0x00133245 File Offset: 0x00131445
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingIllustratedInfo()
		{
		}

		// Token: 0x06007EE8 RID: 32488 RVA: 0x00133270 File Offset: 0x00131470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingIllustratedInfo(FishingIllustratedInfo other) : this()
		{
			this.illustratedList_ = other.illustratedList_.Clone();
			this.rewardedId_ = other.rewardedId_.Clone();
			this.unlockDetections_ = other.unlockDetections_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007EE9 RID: 32489 RVA: 0x001332C7 File Offset: 0x001314C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingIllustratedInfo Clone()
		{
			return new FishingIllustratedInfo(this);
		}

		// Token: 0x170018AE RID: 6318
		// (get) Token: 0x06007EEA RID: 32490 RVA: 0x001332CF File Offset: 0x001314CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<OneFishingIllustratedInfo> IllustratedList
		{
			get
			{
				return this.illustratedList_;
			}
		}

		// Token: 0x170018AF RID: 6319
		// (get) Token: 0x06007EEB RID: 32491 RVA: 0x001332D7 File Offset: 0x001314D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FishingIllustratedRewardInfo> RewardedId
		{
			get
			{
				return this.rewardedId_;
			}
		}

		// Token: 0x170018B0 RID: 6320
		// (get) Token: 0x06007EEC RID: 32492 RVA: 0x001332DF File Offset: 0x001314DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockDetections
		{
			get
			{
				return this.unlockDetections_;
			}
		}

		// Token: 0x06007EED RID: 32493 RVA: 0x001332E7 File Offset: 0x001314E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingIllustratedInfo);
		}

		// Token: 0x06007EEE RID: 32494 RVA: 0x001332F8 File Offset: 0x001314F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingIllustratedInfo other)
		{
			return other != null && (other == this || (this.illustratedList_.Equals(other.illustratedList_) && this.rewardedId_.Equals(other.rewardedId_) && this.unlockDetections_.Equals(other.unlockDetections_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007EEF RID: 32495 RVA: 0x00133360 File Offset: 0x00131560
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

		// Token: 0x06007EF0 RID: 32496 RVA: 0x001333B0 File Offset: 0x001315B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007EF1 RID: 32497 RVA: 0x001333BD File Offset: 0x001315BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007EF2 RID: 32498 RVA: 0x001333C8 File Offset: 0x001315C8
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

		// Token: 0x06007EF3 RID: 32499 RVA: 0x0013341C File Offset: 0x0013161C
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

		// Token: 0x06007EF4 RID: 32500 RVA: 0x0013347C File Offset: 0x0013167C
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

		// Token: 0x06007EF5 RID: 32501 RVA: 0x001334D7 File Offset: 0x001316D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007EF6 RID: 32502 RVA: 0x001334E0 File Offset: 0x001316E0
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

		// Token: 0x0400408C RID: 16524
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400408D RID: 16525
		public const int IllustratedListFieldNumber = 1;

		// Token: 0x0400408E RID: 16526
		private static readonly FieldCodec<OneFishingIllustratedInfo> _repeated_illustratedList_codec = FieldCodec.ForMessage<OneFishingIllustratedInfo>(10U, OneFishingIllustratedInfo.Parser);

		// Token: 0x0400408F RID: 16527
		private readonly RepeatedField<OneFishingIllustratedInfo> illustratedList_ = new RepeatedField<OneFishingIllustratedInfo>();

		// Token: 0x04004090 RID: 16528
		public const int RewardedIdFieldNumber = 2;

		// Token: 0x04004091 RID: 16529
		private static readonly FieldCodec<FishingIllustratedRewardInfo> _repeated_rewardedId_codec = FieldCodec.ForMessage<FishingIllustratedRewardInfo>(18U, FishingIllustratedRewardInfo.Parser);

		// Token: 0x04004092 RID: 16530
		private readonly RepeatedField<FishingIllustratedRewardInfo> rewardedId_ = new RepeatedField<FishingIllustratedRewardInfo>();

		// Token: 0x04004093 RID: 16531
		public const int UnlockDetectionsFieldNumber = 3;

		// Token: 0x04004094 RID: 16532
		private static readonly FieldCodec<int> _repeated_unlockDetections_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04004095 RID: 16533
		private readonly RepeatedField<int> unlockDetections_ = new RepeatedField<int>();
	}
}
