using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DF3 RID: 3571
	public sealed class PublicBabelTowerInfo : IMessage<PublicBabelTowerInfo>, IMessage, IEquatable<PublicBabelTowerInfo>, IDeepCloneable<PublicBabelTowerInfo>, IBufferMessage
	{
		// Token: 0x0601334C RID: 78668 RVA: 0x002CBF42 File Offset: 0x002CA142
		[NullableContext(1)]
		public static PublicBabelTowerInfo Create()
		{
			return new PublicBabelTowerInfo();
		}

		// Token: 0x17003FB7 RID: 16311
		// (get) Token: 0x0601334D RID: 78669 RVA: 0x002CBF49 File Offset: 0x002CA149
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PublicBabelTowerInfo> Parser
		{
			get
			{
				return PublicBabelTowerInfo._parser;
			}
		}

		// Token: 0x17003FB8 RID: 16312
		// (get) Token: 0x0601334E RID: 78670 RVA: 0x002CBF50 File Offset: 0x002CA150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003FB9 RID: 16313
		// (get) Token: 0x0601334F RID: 78671 RVA: 0x002CBF53 File Offset: 0x002CA153
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PublicBabelTowerInfo.Descriptor;
			}
		}

		// Token: 0x06013350 RID: 78672 RVA: 0x002CBF5A File Offset: 0x002CA15A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PublicBabelTowerInfo()
		{
		}

		// Token: 0x06013351 RID: 78673 RVA: 0x002CBF78 File Offset: 0x002CA178
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PublicBabelTowerInfo(PublicBabelTowerInfo other) : this()
		{
			this.challengeInfo_ = other.challengeInfo_.Clone();
			this.playerId_ = other.playerId_;
			this.name_ = other.name_;
			this.headId_ = other.headId_;
			this.titleId_ = other.titleId_;
			this.titleExtraParam_ = other.titleExtraParam_;
			this.showName_ = other.showName_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013352 RID: 78674 RVA: 0x002CBFF5 File Offset: 0x002CA1F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PublicBabelTowerInfo Clone()
		{
			return new PublicBabelTowerInfo(this);
		}

		// Token: 0x17003FBA RID: 16314
		// (get) Token: 0x06013353 RID: 78675 RVA: 0x002CBFFD File Offset: 0x002CA1FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PublicBabelTowerChallengeInfo> ChallengeInfo
		{
			get
			{
				return this.challengeInfo_;
			}
		}

		// Token: 0x17003FBB RID: 16315
		// (get) Token: 0x06013354 RID: 78676 RVA: 0x002CC005 File Offset: 0x002CA205
		// (set) Token: 0x06013355 RID: 78677 RVA: 0x002CC00D File Offset: 0x002CA20D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerId
		{
			get
			{
				return this.playerId_;
			}
			set
			{
				this.playerId_ = value;
			}
		}

		// Token: 0x17003FBC RID: 16316
		// (get) Token: 0x06013356 RID: 78678 RVA: 0x002CC016 File Offset: 0x002CA216
		// (set) Token: 0x06013357 RID: 78679 RVA: 0x002CC01E File Offset: 0x002CA21E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Name
		{
			get
			{
				return this.name_;
			}
			set
			{
				this.name_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17003FBD RID: 16317
		// (get) Token: 0x06013358 RID: 78680 RVA: 0x002CC031 File Offset: 0x002CA231
		// (set) Token: 0x06013359 RID: 78681 RVA: 0x002CC039 File Offset: 0x002CA239
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HeadId
		{
			get
			{
				return this.headId_;
			}
			set
			{
				this.headId_ = value;
			}
		}

		// Token: 0x17003FBE RID: 16318
		// (get) Token: 0x0601335A RID: 78682 RVA: 0x002CC042 File Offset: 0x002CA242
		// (set) Token: 0x0601335B RID: 78683 RVA: 0x002CC04A File Offset: 0x002CA24A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TitleId
		{
			get
			{
				return this.titleId_;
			}
			set
			{
				this.titleId_ = value;
			}
		}

		// Token: 0x17003FBF RID: 16319
		// (get) Token: 0x0601335C RID: 78684 RVA: 0x002CC053 File Offset: 0x002CA253
		// (set) Token: 0x0601335D RID: 78685 RVA: 0x002CC05B File Offset: 0x002CA25B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TitleExtraParam
		{
			get
			{
				return this.titleExtraParam_;
			}
			set
			{
				this.titleExtraParam_ = value;
			}
		}

		// Token: 0x17003FC0 RID: 16320
		// (get) Token: 0x0601335E RID: 78686 RVA: 0x002CC064 File Offset: 0x002CA264
		// (set) Token: 0x0601335F RID: 78687 RVA: 0x002CC06C File Offset: 0x002CA26C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool ShowName
		{
			get
			{
				return this.showName_;
			}
			set
			{
				this.showName_ = value;
			}
		}

		// Token: 0x06013360 RID: 78688 RVA: 0x002CC075 File Offset: 0x002CA275
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PublicBabelTowerInfo);
		}

		// Token: 0x06013361 RID: 78689 RVA: 0x002CC084 File Offset: 0x002CA284
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PublicBabelTowerInfo other)
		{
			return other != null && (other == this || (this.challengeInfo_.Equals(other.challengeInfo_) && this.PlayerId == other.PlayerId && !(this.Name != other.Name) && this.HeadId == other.HeadId && this.TitleId == other.TitleId && this.TitleExtraParam == other.TitleExtraParam && this.ShowName == other.ShowName && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013362 RID: 78690 RVA: 0x002CC128 File Offset: 0x002CA328
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.challengeInfo_.GetHashCode();
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this.Name.Length != 0)
			{
				num ^= this.Name.GetHashCode();
			}
			if (this.HeadId != 0)
			{
				num ^= this.HeadId.GetHashCode();
			}
			if (this.TitleId != 0)
			{
				num ^= this.TitleId.GetHashCode();
			}
			if (this.TitleExtraParam != 0)
			{
				num ^= this.TitleExtraParam.GetHashCode();
			}
			if (this.ShowName)
			{
				num ^= this.ShowName.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013363 RID: 78691 RVA: 0x002CC1F4 File Offset: 0x002CA3F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013364 RID: 78692 RVA: 0x002CC201 File Offset: 0x002CA401
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013365 RID: 78693 RVA: 0x002CC20C File Offset: 0x002CA40C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.challengeInfo_.WriteTo(ref output, PublicBabelTowerInfo._repeated_challengeInfo_codec);
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.PlayerId);
			}
			if (this.Name.Length != 0)
			{
				output.WriteRawTag(34);
				output.WriteString(this.Name);
			}
			if (this.HeadId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.HeadId);
			}
			if (this.TitleId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.TitleId);
			}
			if (this.TitleExtraParam != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.TitleExtraParam);
			}
			if (this.ShowName)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.ShowName);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013366 RID: 78694 RVA: 0x002CC2EC File Offset: 0x002CA4EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.challengeInfo_.CalculateSize(PublicBabelTowerInfo._repeated_challengeInfo_codec);
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this.Name.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Name);
			}
			if (this.HeadId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HeadId);
			}
			if (this.TitleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TitleId);
			}
			if (this.TitleExtraParam != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TitleExtraParam);
			}
			if (this.ShowName)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013367 RID: 78695 RVA: 0x002CC3B0 File Offset: 0x002CA5B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PublicBabelTowerInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.challengeInfo_.Add(other.challengeInfo_);
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			if (other.Name.Length != 0)
			{
				this.Name = other.Name;
			}
			if (other.HeadId != 0)
			{
				this.HeadId = other.HeadId;
			}
			if (other.TitleId != 0)
			{
				this.TitleId = other.TitleId;
			}
			if (other.TitleExtraParam != 0)
			{
				this.TitleExtraParam = other.TitleExtraParam;
			}
			if (other.ShowName)
			{
				this.ShowName = other.ShowName;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013368 RID: 78696 RVA: 0x002CC466 File Offset: 0x002CA666
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013369 RID: 78697 RVA: 0x002CC470 File Offset: 0x002CA670
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
				if (num <= 34U)
				{
					if (num == 10U)
					{
						this.challengeInfo_.AddEntriesFrom(ref input, PublicBabelTowerInfo._repeated_challengeInfo_codec);
						continue;
					}
					if (num == 24U)
					{
						this.PlayerId = input.ReadInt32();
						continue;
					}
					if (num == 34U)
					{
						this.Name = input.ReadString();
						continue;
					}
				}
				else if (num <= 48U)
				{
					if (num == 40U)
					{
						this.HeadId = input.ReadInt32();
						continue;
					}
					if (num == 48U)
					{
						this.TitleId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.TitleExtraParam = input.ReadInt32();
						continue;
					}
					if (num == 72U)
					{
						this.ShowName = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007637 RID: 30263
		private static readonly MessageParser<PublicBabelTowerInfo> _parser = new MessageParser<PublicBabelTowerInfo>(() => new PublicBabelTowerInfo());

		// Token: 0x04007638 RID: 30264
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007639 RID: 30265
		public const int ChallengeInfoFieldNumber = 1;

		// Token: 0x0400763A RID: 30266
		private static readonly FieldCodec<PublicBabelTowerChallengeInfo> _repeated_challengeInfo_codec = FieldCodec.ForMessage<PublicBabelTowerChallengeInfo>(10U, PublicBabelTowerChallengeInfo.Parser);

		// Token: 0x0400763B RID: 30267
		private readonly RepeatedField<PublicBabelTowerChallengeInfo> challengeInfo_ = new RepeatedField<PublicBabelTowerChallengeInfo>();

		// Token: 0x0400763C RID: 30268
		public const int PlayerIdFieldNumber = 3;

		// Token: 0x0400763D RID: 30269
		private int playerId_;

		// Token: 0x0400763E RID: 30270
		public const int NameFieldNumber = 4;

		// Token: 0x0400763F RID: 30271
		private string name_ = "";

		// Token: 0x04007640 RID: 30272
		public const int HeadIdFieldNumber = 5;

		// Token: 0x04007641 RID: 30273
		private int headId_;

		// Token: 0x04007642 RID: 30274
		public const int TitleIdFieldNumber = 6;

		// Token: 0x04007643 RID: 30275
		private int titleId_;

		// Token: 0x04007644 RID: 30276
		public const int TitleExtraParamFieldNumber = 7;

		// Token: 0x04007645 RID: 30277
		private int titleExtraParam_;

		// Token: 0x04007646 RID: 30278
		public const int ShowNameFieldNumber = 9;

		// Token: 0x04007647 RID: 30279
		private bool showName_;
	}
}
