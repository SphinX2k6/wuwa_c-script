using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F78 RID: 3960
	public sealed class RogueInstExtraInfo : IMessage<RogueInstExtraInfo>, IMessage, IEquatable<RogueInstExtraInfo>, IDeepCloneable<RogueInstExtraInfo>, IBufferMessage
	{
		// Token: 0x06015352 RID: 86866 RVA: 0x0031442B File Offset: 0x0031262B
		[NullableContext(1)]
		public static RogueInstExtraInfo Create()
		{
			return new RogueInstExtraInfo();
		}

		// Token: 0x170046A7 RID: 18087
		// (get) Token: 0x06015353 RID: 86867 RVA: 0x00314432 File Offset: 0x00312632
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170046A8 RID: 18088
		// (get) Token: 0x06015354 RID: 86868 RVA: 0x00314435 File Offset: 0x00312635
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueInstExtraInfo.Descriptor;
			}
		}

		// Token: 0x06015355 RID: 86869 RVA: 0x0031443C File Offset: 0x0031263C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueInstExtraInfo()
		{
		}

		// Token: 0x06015356 RID: 86870 RVA: 0x00314468 File Offset: 0x00312668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueInstExtraInfo(RogueInstExtraInfo other) : this()
		{
			this.seasonId_ = other.seasonId_;
			this.rogueHotEntryInfos_ = other.rogueHotEntryInfos_.Clone();
			this.unlockRoleIds_ = other.unlockRoleIds_.Clone();
			this.unlockedPhantomIds_ = other.unlockedPhantomIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015357 RID: 86871 RVA: 0x003144CB File Offset: 0x003126CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueInstExtraInfo Clone()
		{
			return new RogueInstExtraInfo(this);
		}

		// Token: 0x170046A9 RID: 18089
		// (get) Token: 0x06015358 RID: 86872 RVA: 0x003144D3 File Offset: 0x003126D3
		// (set) Token: 0x06015359 RID: 86873 RVA: 0x003144DB File Offset: 0x003126DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SeasonId
		{
			get
			{
				return this.seasonId_;
			}
			set
			{
				this.seasonId_ = value;
			}
		}

		// Token: 0x170046AA RID: 18090
		// (get) Token: 0x0601535A RID: 86874 RVA: 0x003144E4 File Offset: 0x003126E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueHotEntryInfo> RogueHotEntryInfos
		{
			get
			{
				return this.rogueHotEntryInfos_;
			}
		}

		// Token: 0x170046AB RID: 18091
		// (get) Token: 0x0601535B RID: 86875 RVA: 0x003144EC File Offset: 0x003126EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockRoleIds
		{
			get
			{
				return this.unlockRoleIds_;
			}
		}

		// Token: 0x170046AC RID: 18092
		// (get) Token: 0x0601535C RID: 86876 RVA: 0x003144F4 File Offset: 0x003126F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockedPhantomIds
		{
			get
			{
				return this.unlockedPhantomIds_;
			}
		}

		// Token: 0x0601535D RID: 86877 RVA: 0x003144FC File Offset: 0x003126FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueInstExtraInfo);
		}

		// Token: 0x0601535E RID: 86878 RVA: 0x0031450C File Offset: 0x0031270C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueInstExtraInfo other)
		{
			return other != null && (other == this || (this.SeasonId == other.SeasonId && this.rogueHotEntryInfos_.Equals(other.rogueHotEntryInfos_) && this.unlockRoleIds_.Equals(other.unlockRoleIds_) && this.unlockedPhantomIds_.Equals(other.unlockedPhantomIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601535F RID: 86879 RVA: 0x00314584 File Offset: 0x00312784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SeasonId != 0)
			{
				num ^= this.SeasonId.GetHashCode();
			}
			num ^= this.rogueHotEntryInfos_.GetHashCode();
			num ^= this.unlockRoleIds_.GetHashCode();
			num ^= this.unlockedPhantomIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015360 RID: 86880 RVA: 0x003145ED File Offset: 0x003127ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015361 RID: 86881 RVA: 0x003145FA File Offset: 0x003127FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015362 RID: 86882 RVA: 0x00314604 File Offset: 0x00312804
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SeasonId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.SeasonId);
			}
			this.rogueHotEntryInfos_.WriteTo(ref output, RogueInstExtraInfo._repeated_rogueHotEntryInfos_codec);
			this.unlockRoleIds_.WriteTo(ref output, RogueInstExtraInfo._repeated_unlockRoleIds_codec);
			this.unlockedPhantomIds_.WriteTo(ref output, RogueInstExtraInfo._repeated_unlockedPhantomIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015363 RID: 86883 RVA: 0x00314674 File Offset: 0x00312874
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SeasonId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SeasonId);
			}
			num += this.rogueHotEntryInfos_.CalculateSize(RogueInstExtraInfo._repeated_rogueHotEntryInfos_codec);
			num += this.unlockRoleIds_.CalculateSize(RogueInstExtraInfo._repeated_unlockRoleIds_codec);
			num += this.unlockedPhantomIds_.CalculateSize(RogueInstExtraInfo._repeated_unlockedPhantomIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015364 RID: 86884 RVA: 0x003146EC File Offset: 0x003128EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueInstExtraInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SeasonId != 0)
			{
				this.SeasonId = other.SeasonId;
			}
			this.rogueHotEntryInfos_.Add(other.rogueHotEntryInfos_);
			this.unlockRoleIds_.Add(other.unlockRoleIds_);
			this.unlockedPhantomIds_.Add(other.unlockedPhantomIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015365 RID: 86885 RVA: 0x0031475B File Offset: 0x0031295B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015366 RID: 86886 RVA: 0x00314764 File Offset: 0x00312964
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
				if (num <= 24U)
				{
					if (num == 8U)
					{
						this.SeasonId = input.ReadInt32();
						continue;
					}
					if (num == 18U)
					{
						this.rogueHotEntryInfos_.AddEntriesFrom(ref input, RogueInstExtraInfo._repeated_rogueHotEntryInfos_codec);
						continue;
					}
					if (num == 24U)
					{
						goto IL_65;
					}
				}
				else
				{
					if (num == 26U)
					{
						goto IL_65;
					}
					if (num == 32U || num == 34U)
					{
						this.unlockedPhantomIds_.AddEntriesFrom(ref input, RogueInstExtraInfo._repeated_unlockedPhantomIds_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_65:
				this.unlockRoleIds_.AddEntriesFrom(ref input, RogueInstExtraInfo._repeated_unlockRoleIds_codec);
			}
		}

		// Token: 0x04008019 RID: 32793
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400801A RID: 32794
		public const int SeasonIdFieldNumber = 1;

		// Token: 0x0400801B RID: 32795
		private int seasonId_;

		// Token: 0x0400801C RID: 32796
		public const int RogueHotEntryInfosFieldNumber = 2;

		// Token: 0x0400801D RID: 32797
		private static readonly FieldCodec<RogueHotEntryInfo> _repeated_rogueHotEntryInfos_codec = FieldCodec.ForMessage<RogueHotEntryInfo>(18U, RogueHotEntryInfo.Parser);

		// Token: 0x0400801E RID: 32798
		private readonly RepeatedField<RogueHotEntryInfo> rogueHotEntryInfos_ = new RepeatedField<RogueHotEntryInfo>();

		// Token: 0x0400801F RID: 32799
		public const int UnlockRoleIdsFieldNumber = 3;

		// Token: 0x04008020 RID: 32800
		private static readonly FieldCodec<int> _repeated_unlockRoleIds_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04008021 RID: 32801
		private readonly RepeatedField<int> unlockRoleIds_ = new RepeatedField<int>();

		// Token: 0x04008022 RID: 32802
		public const int UnlockedPhantomIdsFieldNumber = 4;

		// Token: 0x04008023 RID: 32803
		private static readonly FieldCodec<int> _repeated_unlockedPhantomIds_codec = FieldCodec.ForInt32(34U);

		// Token: 0x04008024 RID: 32804
		private readonly RepeatedField<int> unlockedPhantomIds_ = new RepeatedField<int>();
	}
}
