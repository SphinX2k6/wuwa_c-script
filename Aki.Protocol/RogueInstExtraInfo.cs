using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F88 RID: 3976
	public sealed class RogueInstExtraInfo : IMessage<RogueInstExtraInfo>, IMessage, IEquatable<RogueInstExtraInfo>, IDeepCloneable<RogueInstExtraInfo>, IBufferMessage
	{
		// Token: 0x06015437 RID: 87095 RVA: 0x00315ADF File Offset: 0x00313CDF
		[NullableContext(1)]
		public static RogueInstExtraInfo Create()
		{
			return new RogueInstExtraInfo();
		}

		// Token: 0x170046D1 RID: 18129
		// (get) Token: 0x06015438 RID: 87096 RVA: 0x00315AE6 File Offset: 0x00313CE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170046D2 RID: 18130
		// (get) Token: 0x06015439 RID: 87097 RVA: 0x00315AE9 File Offset: 0x00313CE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueInstExtraInfo.Descriptor;
			}
		}

		// Token: 0x0601543A RID: 87098 RVA: 0x00315AF0 File Offset: 0x00313CF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueInstExtraInfo()
		{
		}

		// Token: 0x0601543B RID: 87099 RVA: 0x00315B1C File Offset: 0x00313D1C
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

		// Token: 0x0601543C RID: 87100 RVA: 0x00315B7F File Offset: 0x00313D7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueInstExtraInfo Clone()
		{
			return new RogueInstExtraInfo(this);
		}

		// Token: 0x170046D3 RID: 18131
		// (get) Token: 0x0601543D RID: 87101 RVA: 0x00315B87 File Offset: 0x00313D87
		// (set) Token: 0x0601543E RID: 87102 RVA: 0x00315B8F File Offset: 0x00313D8F
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

		// Token: 0x170046D4 RID: 18132
		// (get) Token: 0x0601543F RID: 87103 RVA: 0x00315B98 File Offset: 0x00313D98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueHotEntryInfo> RogueHotEntryInfos
		{
			get
			{
				return this.rogueHotEntryInfos_;
			}
		}

		// Token: 0x170046D5 RID: 18133
		// (get) Token: 0x06015440 RID: 87104 RVA: 0x00315BA0 File Offset: 0x00313DA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockRoleIds
		{
			get
			{
				return this.unlockRoleIds_;
			}
		}

		// Token: 0x170046D6 RID: 18134
		// (get) Token: 0x06015441 RID: 87105 RVA: 0x00315BA8 File Offset: 0x00313DA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockedPhantomIds
		{
			get
			{
				return this.unlockedPhantomIds_;
			}
		}

		// Token: 0x06015442 RID: 87106 RVA: 0x00315BB0 File Offset: 0x00313DB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueInstExtraInfo);
		}

		// Token: 0x06015443 RID: 87107 RVA: 0x00315BC0 File Offset: 0x00313DC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueInstExtraInfo other)
		{
			return other != null && (other == this || (this.SeasonId == other.SeasonId && this.rogueHotEntryInfos_.Equals(other.rogueHotEntryInfos_) && this.unlockRoleIds_.Equals(other.unlockRoleIds_) && this.unlockedPhantomIds_.Equals(other.unlockedPhantomIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015444 RID: 87108 RVA: 0x00315C38 File Offset: 0x00313E38
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

		// Token: 0x06015445 RID: 87109 RVA: 0x00315CA1 File Offset: 0x00313EA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015446 RID: 87110 RVA: 0x00315CAE File Offset: 0x00313EAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015447 RID: 87111 RVA: 0x00315CB8 File Offset: 0x00313EB8
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

		// Token: 0x06015448 RID: 87112 RVA: 0x00315D28 File Offset: 0x00313F28
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

		// Token: 0x06015449 RID: 87113 RVA: 0x00315DA0 File Offset: 0x00313FA0
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

		// Token: 0x0601544A RID: 87114 RVA: 0x00315E0F File Offset: 0x0031400F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601544B RID: 87115 RVA: 0x00315E18 File Offset: 0x00314018
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

		// Token: 0x04007FEF RID: 32751
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007FF0 RID: 32752
		public const int SeasonIdFieldNumber = 1;

		// Token: 0x04007FF1 RID: 32753
		private int seasonId_;

		// Token: 0x04007FF2 RID: 32754
		public const int RogueHotEntryInfosFieldNumber = 2;

		// Token: 0x04007FF3 RID: 32755
		private static readonly FieldCodec<RogueHotEntryInfo> _repeated_rogueHotEntryInfos_codec = FieldCodec.ForMessage<RogueHotEntryInfo>(18U, RogueHotEntryInfo.Parser);

		// Token: 0x04007FF4 RID: 32756
		private readonly RepeatedField<RogueHotEntryInfo> rogueHotEntryInfos_ = new RepeatedField<RogueHotEntryInfo>();

		// Token: 0x04007FF5 RID: 32757
		public const int UnlockRoleIdsFieldNumber = 3;

		// Token: 0x04007FF6 RID: 32758
		private static readonly FieldCodec<int> _repeated_unlockRoleIds_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04007FF7 RID: 32759
		private readonly RepeatedField<int> unlockRoleIds_ = new RepeatedField<int>();

		// Token: 0x04007FF8 RID: 32760
		public const int UnlockedPhantomIdsFieldNumber = 4;

		// Token: 0x04007FF9 RID: 32761
		private static readonly FieldCodec<int> _repeated_unlockedPhantomIds_codec = FieldCodec.ForInt32(34U);

		// Token: 0x04007FFA RID: 32762
		private readonly RepeatedField<int> unlockedPhantomIds_ = new RepeatedField<int>();
	}
}
