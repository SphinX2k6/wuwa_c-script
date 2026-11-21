using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DE3 RID: 3555
	public sealed class PublicBabelTowerInfo : IMessage<PublicBabelTowerInfo>, IMessage, IEquatable<PublicBabelTowerInfo>, IDeepCloneable<PublicBabelTowerInfo>, IBufferMessage
	{
		// Token: 0x06013267 RID: 78439 RVA: 0x002CA87E File Offset: 0x002C8A7E
		[NullableContext(1)]
		public static PublicBabelTowerInfo Create()
		{
			return new PublicBabelTowerInfo();
		}

		// Token: 0x17003F8D RID: 16269
		// (get) Token: 0x06013268 RID: 78440 RVA: 0x002CA885 File Offset: 0x002C8A85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PublicBabelTowerInfo> Parser
		{
			get
			{
				return PublicBabelTowerInfo._parser;
			}
		}

		// Token: 0x17003F8E RID: 16270
		// (get) Token: 0x06013269 RID: 78441 RVA: 0x002CA88C File Offset: 0x002C8A8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003F8F RID: 16271
		// (get) Token: 0x0601326A RID: 78442 RVA: 0x002CA88F File Offset: 0x002C8A8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PublicBabelTowerInfo.Descriptor;
			}
		}

		// Token: 0x0601326B RID: 78443 RVA: 0x002CA896 File Offset: 0x002C8A96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PublicBabelTowerInfo()
		{
		}

		// Token: 0x0601326C RID: 78444 RVA: 0x002CA8B4 File Offset: 0x002C8AB4
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

		// Token: 0x0601326D RID: 78445 RVA: 0x002CA931 File Offset: 0x002C8B31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PublicBabelTowerInfo Clone()
		{
			return new PublicBabelTowerInfo(this);
		}

		// Token: 0x17003F90 RID: 16272
		// (get) Token: 0x0601326E RID: 78446 RVA: 0x002CA939 File Offset: 0x002C8B39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PublicBabelTowerChallengeInfo> ChallengeInfo
		{
			get
			{
				return this.challengeInfo_;
			}
		}

		// Token: 0x17003F91 RID: 16273
		// (get) Token: 0x0601326F RID: 78447 RVA: 0x002CA941 File Offset: 0x002C8B41
		// (set) Token: 0x06013270 RID: 78448 RVA: 0x002CA949 File Offset: 0x002C8B49
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

		// Token: 0x17003F92 RID: 16274
		// (get) Token: 0x06013271 RID: 78449 RVA: 0x002CA952 File Offset: 0x002C8B52
		// (set) Token: 0x06013272 RID: 78450 RVA: 0x002CA95A File Offset: 0x002C8B5A
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

		// Token: 0x17003F93 RID: 16275
		// (get) Token: 0x06013273 RID: 78451 RVA: 0x002CA96D File Offset: 0x002C8B6D
		// (set) Token: 0x06013274 RID: 78452 RVA: 0x002CA975 File Offset: 0x002C8B75
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

		// Token: 0x17003F94 RID: 16276
		// (get) Token: 0x06013275 RID: 78453 RVA: 0x002CA97E File Offset: 0x002C8B7E
		// (set) Token: 0x06013276 RID: 78454 RVA: 0x002CA986 File Offset: 0x002C8B86
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

		// Token: 0x17003F95 RID: 16277
		// (get) Token: 0x06013277 RID: 78455 RVA: 0x002CA98F File Offset: 0x002C8B8F
		// (set) Token: 0x06013278 RID: 78456 RVA: 0x002CA997 File Offset: 0x002C8B97
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

		// Token: 0x17003F96 RID: 16278
		// (get) Token: 0x06013279 RID: 78457 RVA: 0x002CA9A0 File Offset: 0x002C8BA0
		// (set) Token: 0x0601327A RID: 78458 RVA: 0x002CA9A8 File Offset: 0x002C8BA8
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

		// Token: 0x0601327B RID: 78459 RVA: 0x002CA9B1 File Offset: 0x002C8BB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PublicBabelTowerInfo);
		}

		// Token: 0x0601327C RID: 78460 RVA: 0x002CA9C0 File Offset: 0x002C8BC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PublicBabelTowerInfo other)
		{
			return other != null && (other == this || (this.challengeInfo_.Equals(other.challengeInfo_) && this.PlayerId == other.PlayerId && !(this.Name != other.Name) && this.HeadId == other.HeadId && this.TitleId == other.TitleId && this.TitleExtraParam == other.TitleExtraParam && this.ShowName == other.ShowName && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601327D RID: 78461 RVA: 0x002CAA64 File Offset: 0x002C8C64
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

		// Token: 0x0601327E RID: 78462 RVA: 0x002CAB30 File Offset: 0x002C8D30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601327F RID: 78463 RVA: 0x002CAB3D File Offset: 0x002C8D3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013280 RID: 78464 RVA: 0x002CAB48 File Offset: 0x002C8D48
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

		// Token: 0x06013281 RID: 78465 RVA: 0x002CAC28 File Offset: 0x002C8E28
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

		// Token: 0x06013282 RID: 78466 RVA: 0x002CACEC File Offset: 0x002C8EEC
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

		// Token: 0x06013283 RID: 78467 RVA: 0x002CADA2 File Offset: 0x002C8FA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013284 RID: 78468 RVA: 0x002CADAC File Offset: 0x002C8FAC
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

		// Token: 0x04007661 RID: 30305
		private static readonly MessageParser<PublicBabelTowerInfo> _parser = new MessageParser<PublicBabelTowerInfo>(() => new PublicBabelTowerInfo());

		// Token: 0x04007662 RID: 30306
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007663 RID: 30307
		public const int ChallengeInfoFieldNumber = 1;

		// Token: 0x04007664 RID: 30308
		private static readonly FieldCodec<PublicBabelTowerChallengeInfo> _repeated_challengeInfo_codec = FieldCodec.ForMessage<PublicBabelTowerChallengeInfo>(10U, PublicBabelTowerChallengeInfo.Parser);

		// Token: 0x04007665 RID: 30309
		private readonly RepeatedField<PublicBabelTowerChallengeInfo> challengeInfo_ = new RepeatedField<PublicBabelTowerChallengeInfo>();

		// Token: 0x04007666 RID: 30310
		public const int PlayerIdFieldNumber = 3;

		// Token: 0x04007667 RID: 30311
		private int playerId_;

		// Token: 0x04007668 RID: 30312
		public const int NameFieldNumber = 4;

		// Token: 0x04007669 RID: 30313
		private string name_ = "";

		// Token: 0x0400766A RID: 30314
		public const int HeadIdFieldNumber = 5;

		// Token: 0x0400766B RID: 30315
		private int headId_;

		// Token: 0x0400766C RID: 30316
		public const int TitleIdFieldNumber = 6;

		// Token: 0x0400766D RID: 30317
		private int titleId_;

		// Token: 0x0400766E RID: 30318
		public const int TitleExtraParamFieldNumber = 7;

		// Token: 0x0400766F RID: 30319
		private int titleExtraParam_;

		// Token: 0x04007670 RID: 30320
		public const int ShowNameFieldNumber = 9;

		// Token: 0x04007671 RID: 30321
		private bool showName_;
	}
}
