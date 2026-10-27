using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DF2 RID: 3570
	public sealed class PublicBabelTowerChallengeInfo : IMessage<PublicBabelTowerChallengeInfo>, IMessage, IEquatable<PublicBabelTowerChallengeInfo>, IDeepCloneable<PublicBabelTowerChallengeInfo>, IBufferMessage
	{
		// Token: 0x06013333 RID: 78643 RVA: 0x002CBB1F File Offset: 0x002C9D1F
		[NullableContext(1)]
		public static PublicBabelTowerChallengeInfo Create()
		{
			return new PublicBabelTowerChallengeInfo();
		}

		// Token: 0x17003FB0 RID: 16304
		// (get) Token: 0x06013334 RID: 78644 RVA: 0x002CBB26 File Offset: 0x002C9D26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PublicBabelTowerChallengeInfo> Parser
		{
			get
			{
				return PublicBabelTowerChallengeInfo._parser;
			}
		}

		// Token: 0x17003FB1 RID: 16305
		// (get) Token: 0x06013335 RID: 78645 RVA: 0x002CBB2D File Offset: 0x002C9D2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003FB2 RID: 16306
		// (get) Token: 0x06013336 RID: 78646 RVA: 0x002CBB30 File Offset: 0x002C9D30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PublicBabelTowerChallengeInfo.Descriptor;
			}
		}

		// Token: 0x06013337 RID: 78647 RVA: 0x002CBB37 File Offset: 0x002C9D37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PublicBabelTowerChallengeInfo()
		{
		}

		// Token: 0x06013338 RID: 78648 RVA: 0x002CBB4C File Offset: 0x002C9D4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PublicBabelTowerChallengeInfo(PublicBabelTowerChallengeInfo other) : this()
		{
			this.challengeId_ = other.challengeId_;
			this.star_ = other.star_;
			this.useTime_ = other.useTime_;
			this.babelPassRoleInfos_ = other.babelPassRoleInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013339 RID: 78649 RVA: 0x002CBBA5 File Offset: 0x002C9DA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PublicBabelTowerChallengeInfo Clone()
		{
			return new PublicBabelTowerChallengeInfo(this);
		}

		// Token: 0x17003FB3 RID: 16307
		// (get) Token: 0x0601333A RID: 78650 RVA: 0x002CBBAD File Offset: 0x002C9DAD
		// (set) Token: 0x0601333B RID: 78651 RVA: 0x002CBBB5 File Offset: 0x002C9DB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ChallengeId
		{
			get
			{
				return this.challengeId_;
			}
			set
			{
				this.challengeId_ = value;
			}
		}

		// Token: 0x17003FB4 RID: 16308
		// (get) Token: 0x0601333C RID: 78652 RVA: 0x002CBBBE File Offset: 0x002C9DBE
		// (set) Token: 0x0601333D RID: 78653 RVA: 0x002CBBC6 File Offset: 0x002C9DC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Star
		{
			get
			{
				return this.star_;
			}
			set
			{
				this.star_ = value;
			}
		}

		// Token: 0x17003FB5 RID: 16309
		// (get) Token: 0x0601333E RID: 78654 RVA: 0x002CBBCF File Offset: 0x002C9DCF
		// (set) Token: 0x0601333F RID: 78655 RVA: 0x002CBBD7 File Offset: 0x002C9DD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int UseTime
		{
			get
			{
				return this.useTime_;
			}
			set
			{
				this.useTime_ = value;
			}
		}

		// Token: 0x17003FB6 RID: 16310
		// (get) Token: 0x06013340 RID: 78656 RVA: 0x002CBBE0 File Offset: 0x002C9DE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BabelPassRoleInfo> BabelPassRoleInfos
		{
			get
			{
				return this.babelPassRoleInfos_;
			}
		}

		// Token: 0x06013341 RID: 78657 RVA: 0x002CBBE8 File Offset: 0x002C9DE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PublicBabelTowerChallengeInfo);
		}

		// Token: 0x06013342 RID: 78658 RVA: 0x002CBBF8 File Offset: 0x002C9DF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PublicBabelTowerChallengeInfo other)
		{
			return other != null && (other == this || (this.ChallengeId == other.ChallengeId && this.Star == other.Star && this.UseTime == other.UseTime && this.babelPassRoleInfos_.Equals(other.babelPassRoleInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013343 RID: 78659 RVA: 0x002CBC68 File Offset: 0x002C9E68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ChallengeId != 0)
			{
				num ^= this.ChallengeId.GetHashCode();
			}
			if (this.Star != 0)
			{
				num ^= this.Star.GetHashCode();
			}
			if (this.UseTime != 0)
			{
				num ^= this.UseTime.GetHashCode();
			}
			num ^= this.babelPassRoleInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013344 RID: 78660 RVA: 0x002CBCE7 File Offset: 0x002C9EE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013345 RID: 78661 RVA: 0x002CBCF4 File Offset: 0x002C9EF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013346 RID: 78662 RVA: 0x002CBD00 File Offset: 0x002C9F00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ChallengeId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ChallengeId);
			}
			if (this.Star != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Star);
			}
			if (this.UseTime != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.UseTime);
			}
			this.babelPassRoleInfos_.WriteTo(ref output, PublicBabelTowerChallengeInfo._repeated_babelPassRoleInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013347 RID: 78663 RVA: 0x002CBD88 File Offset: 0x002C9F88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ChallengeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChallengeId);
			}
			if (this.Star != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Star);
			}
			if (this.UseTime != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.UseTime);
			}
			num += this.babelPassRoleInfos_.CalculateSize(PublicBabelTowerChallengeInfo._repeated_babelPassRoleInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013348 RID: 78664 RVA: 0x002CBE0C File Offset: 0x002CA00C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PublicBabelTowerChallengeInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ChallengeId != 0)
			{
				this.ChallengeId = other.ChallengeId;
			}
			if (other.Star != 0)
			{
				this.Star = other.Star;
			}
			if (other.UseTime != 0)
			{
				this.UseTime = other.UseTime;
			}
			this.babelPassRoleInfos_.Add(other.babelPassRoleInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013349 RID: 78665 RVA: 0x002CBE81 File Offset: 0x002CA081
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601334A RID: 78666 RVA: 0x002CBE8C File Offset: 0x002CA08C
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.ChallengeId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.Star = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.UseTime = input.ReadInt32();
						continue;
					}
					if (num == 34U)
					{
						this.babelPassRoleInfos_.AddEntriesFrom(ref input, PublicBabelTowerChallengeInfo._repeated_babelPassRoleInfos_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400762C RID: 30252
		private static readonly MessageParser<PublicBabelTowerChallengeInfo> _parser = new MessageParser<PublicBabelTowerChallengeInfo>(() => new PublicBabelTowerChallengeInfo());

		// Token: 0x0400762D RID: 30253
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400762E RID: 30254
		public const int ChallengeIdFieldNumber = 1;

		// Token: 0x0400762F RID: 30255
		private int challengeId_;

		// Token: 0x04007630 RID: 30256
		public const int StarFieldNumber = 2;

		// Token: 0x04007631 RID: 30257
		private int star_;

		// Token: 0x04007632 RID: 30258
		public const int UseTimeFieldNumber = 3;

		// Token: 0x04007633 RID: 30259
		private int useTime_;

		// Token: 0x04007634 RID: 30260
		public const int BabelPassRoleInfosFieldNumber = 4;

		// Token: 0x04007635 RID: 30261
		private static readonly FieldCodec<BabelPassRoleInfo> _repeated_babelPassRoleInfos_codec = FieldCodec.ForMessage<BabelPassRoleInfo>(34U, BabelPassRoleInfo.Parser);

		// Token: 0x04007636 RID: 30262
		private readonly RepeatedField<BabelPassRoleInfo> babelPassRoleInfos_ = new RepeatedField<BabelPassRoleInfo>();
	}
}
