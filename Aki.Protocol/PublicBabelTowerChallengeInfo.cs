using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DE2 RID: 3554
	public sealed class PublicBabelTowerChallengeInfo : IMessage<PublicBabelTowerChallengeInfo>, IMessage, IEquatable<PublicBabelTowerChallengeInfo>, IDeepCloneable<PublicBabelTowerChallengeInfo>, IBufferMessage
	{
		// Token: 0x0601324E RID: 78414 RVA: 0x002CA45B File Offset: 0x002C865B
		[NullableContext(1)]
		public static PublicBabelTowerChallengeInfo Create()
		{
			return new PublicBabelTowerChallengeInfo();
		}

		// Token: 0x17003F86 RID: 16262
		// (get) Token: 0x0601324F RID: 78415 RVA: 0x002CA462 File Offset: 0x002C8662
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PublicBabelTowerChallengeInfo> Parser
		{
			get
			{
				return PublicBabelTowerChallengeInfo._parser;
			}
		}

		// Token: 0x17003F87 RID: 16263
		// (get) Token: 0x06013250 RID: 78416 RVA: 0x002CA469 File Offset: 0x002C8669
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003F88 RID: 16264
		// (get) Token: 0x06013251 RID: 78417 RVA: 0x002CA46C File Offset: 0x002C866C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PublicBabelTowerChallengeInfo.Descriptor;
			}
		}

		// Token: 0x06013252 RID: 78418 RVA: 0x002CA473 File Offset: 0x002C8673
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PublicBabelTowerChallengeInfo()
		{
		}

		// Token: 0x06013253 RID: 78419 RVA: 0x002CA488 File Offset: 0x002C8688
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

		// Token: 0x06013254 RID: 78420 RVA: 0x002CA4E1 File Offset: 0x002C86E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PublicBabelTowerChallengeInfo Clone()
		{
			return new PublicBabelTowerChallengeInfo(this);
		}

		// Token: 0x17003F89 RID: 16265
		// (get) Token: 0x06013255 RID: 78421 RVA: 0x002CA4E9 File Offset: 0x002C86E9
		// (set) Token: 0x06013256 RID: 78422 RVA: 0x002CA4F1 File Offset: 0x002C86F1
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

		// Token: 0x17003F8A RID: 16266
		// (get) Token: 0x06013257 RID: 78423 RVA: 0x002CA4FA File Offset: 0x002C86FA
		// (set) Token: 0x06013258 RID: 78424 RVA: 0x002CA502 File Offset: 0x002C8702
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

		// Token: 0x17003F8B RID: 16267
		// (get) Token: 0x06013259 RID: 78425 RVA: 0x002CA50B File Offset: 0x002C870B
		// (set) Token: 0x0601325A RID: 78426 RVA: 0x002CA513 File Offset: 0x002C8713
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

		// Token: 0x17003F8C RID: 16268
		// (get) Token: 0x0601325B RID: 78427 RVA: 0x002CA51C File Offset: 0x002C871C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<BabelPassRoleInfo> BabelPassRoleInfos
		{
			get
			{
				return this.babelPassRoleInfos_;
			}
		}

		// Token: 0x0601325C RID: 78428 RVA: 0x002CA524 File Offset: 0x002C8724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PublicBabelTowerChallengeInfo);
		}

		// Token: 0x0601325D RID: 78429 RVA: 0x002CA534 File Offset: 0x002C8734
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PublicBabelTowerChallengeInfo other)
		{
			return other != null && (other == this || (this.ChallengeId == other.ChallengeId && this.Star == other.Star && this.UseTime == other.UseTime && this.babelPassRoleInfos_.Equals(other.babelPassRoleInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601325E RID: 78430 RVA: 0x002CA5A4 File Offset: 0x002C87A4
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

		// Token: 0x0601325F RID: 78431 RVA: 0x002CA623 File Offset: 0x002C8823
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013260 RID: 78432 RVA: 0x002CA630 File Offset: 0x002C8830
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013261 RID: 78433 RVA: 0x002CA63C File Offset: 0x002C883C
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

		// Token: 0x06013262 RID: 78434 RVA: 0x002CA6C4 File Offset: 0x002C88C4
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

		// Token: 0x06013263 RID: 78435 RVA: 0x002CA748 File Offset: 0x002C8948
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

		// Token: 0x06013264 RID: 78436 RVA: 0x002CA7BD File Offset: 0x002C89BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013265 RID: 78437 RVA: 0x002CA7C8 File Offset: 0x002C89C8
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

		// Token: 0x04007656 RID: 30294
		private static readonly MessageParser<PublicBabelTowerChallengeInfo> _parser = new MessageParser<PublicBabelTowerChallengeInfo>(() => new PublicBabelTowerChallengeInfo());

		// Token: 0x04007657 RID: 30295
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007658 RID: 30296
		public const int ChallengeIdFieldNumber = 1;

		// Token: 0x04007659 RID: 30297
		private int challengeId_;

		// Token: 0x0400765A RID: 30298
		public const int StarFieldNumber = 2;

		// Token: 0x0400765B RID: 30299
		private int star_;

		// Token: 0x0400765C RID: 30300
		public const int UseTimeFieldNumber = 3;

		// Token: 0x0400765D RID: 30301
		private int useTime_;

		// Token: 0x0400765E RID: 30302
		public const int BabelPassRoleInfosFieldNumber = 4;

		// Token: 0x0400765F RID: 30303
		private static readonly FieldCodec<BabelPassRoleInfo> _repeated_babelPassRoleInfos_codec = FieldCodec.ForMessage<BabelPassRoleInfo>(34U, BabelPassRoleInfo.Parser);

		// Token: 0x04007660 RID: 30304
		private readonly RepeatedField<BabelPassRoleInfo> babelPassRoleInfos_ = new RepeatedField<BabelPassRoleInfo>();
	}
}
