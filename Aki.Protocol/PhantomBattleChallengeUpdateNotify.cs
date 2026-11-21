using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C5C RID: 3164
	[NetMessage(EMessageId.PhantomBattleChallengeUpdateNotify)]
	public sealed class PhantomBattleChallengeUpdateNotify : IMessage<PhantomBattleChallengeUpdateNotify>, IMessage, IEquatable<PhantomBattleChallengeUpdateNotify>, IDeepCloneable<PhantomBattleChallengeUpdateNotify>, IBufferMessage
	{
		// Token: 0x060112D0 RID: 70352 RVA: 0x002843ED File Offset: 0x002825ED
		[NullableContext(1)]
		public static PhantomBattleChallengeUpdateNotify Create()
		{
			return new PhantomBattleChallengeUpdateNotify();
		}

		// Token: 0x170038CC RID: 14540
		// (get) Token: 0x060112D1 RID: 70353 RVA: 0x002843F4 File Offset: 0x002825F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170038CD RID: 14541
		// (get) Token: 0x060112D2 RID: 70354 RVA: 0x002843F7 File Offset: 0x002825F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleChallengeUpdateNotify.Descriptor;
			}
		}

		// Token: 0x060112D3 RID: 70355 RVA: 0x002843FE File Offset: 0x002825FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleChallengeUpdateNotify()
		{
		}

		// Token: 0x060112D4 RID: 70356 RVA: 0x00284414 File Offset: 0x00282614
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleChallengeUpdateNotify(PhantomBattleChallengeUpdateNotify other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.challengeId_ = other.challengeId_;
			this.firstWin_ = other.firstWin_;
			this.unlock_ = other.unlock_;
			this.isUncover_ = other.isUncover_;
			this.isShow_ = other.isShow_;
			this.isPassRewarded_ = other.isPassRewarded_;
			this.challengeInfo_ = other.challengeInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060112D5 RID: 70357 RVA: 0x0028449D File Offset: 0x0028269D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleChallengeUpdateNotify Clone()
		{
			return new PhantomBattleChallengeUpdateNotify(this);
		}

		// Token: 0x170038CE RID: 14542
		// (get) Token: 0x060112D6 RID: 70358 RVA: 0x002844A5 File Offset: 0x002826A5
		// (set) Token: 0x060112D7 RID: 70359 RVA: 0x002844AD File Offset: 0x002826AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x170038CF RID: 14543
		// (get) Token: 0x060112D8 RID: 70360 RVA: 0x002844B6 File Offset: 0x002826B6
		// (set) Token: 0x060112D9 RID: 70361 RVA: 0x002844BE File Offset: 0x002826BE
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

		// Token: 0x170038D0 RID: 14544
		// (get) Token: 0x060112DA RID: 70362 RVA: 0x002844C7 File Offset: 0x002826C7
		// (set) Token: 0x060112DB RID: 70363 RVA: 0x002844CF File Offset: 0x002826CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool FirstWin
		{
			get
			{
				return this.firstWin_;
			}
			set
			{
				this.firstWin_ = value;
			}
		}

		// Token: 0x170038D1 RID: 14545
		// (get) Token: 0x060112DC RID: 70364 RVA: 0x002844D8 File Offset: 0x002826D8
		// (set) Token: 0x060112DD RID: 70365 RVA: 0x002844E0 File Offset: 0x002826E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Unlock
		{
			get
			{
				return this.unlock_;
			}
			set
			{
				this.unlock_ = value;
			}
		}

		// Token: 0x170038D2 RID: 14546
		// (get) Token: 0x060112DE RID: 70366 RVA: 0x002844E9 File Offset: 0x002826E9
		// (set) Token: 0x060112DF RID: 70367 RVA: 0x002844F1 File Offset: 0x002826F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsUncover
		{
			get
			{
				return this.isUncover_;
			}
			set
			{
				this.isUncover_ = value;
			}
		}

		// Token: 0x170038D3 RID: 14547
		// (get) Token: 0x060112E0 RID: 70368 RVA: 0x002844FA File Offset: 0x002826FA
		// (set) Token: 0x060112E1 RID: 70369 RVA: 0x00284502 File Offset: 0x00282702
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsShow
		{
			get
			{
				return this.isShow_;
			}
			set
			{
				this.isShow_ = value;
			}
		}

		// Token: 0x170038D4 RID: 14548
		// (get) Token: 0x060112E2 RID: 70370 RVA: 0x0028450B File Offset: 0x0028270B
		// (set) Token: 0x060112E3 RID: 70371 RVA: 0x00284513 File Offset: 0x00282713
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsPassRewarded
		{
			get
			{
				return this.isPassRewarded_;
			}
			set
			{
				this.isPassRewarded_ = value;
			}
		}

		// Token: 0x170038D5 RID: 14549
		// (get) Token: 0x060112E4 RID: 70372 RVA: 0x0028451C File Offset: 0x0028271C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomBattleChallengeInfo> ChallengeInfo
		{
			get
			{
				return this.challengeInfo_;
			}
		}

		// Token: 0x060112E5 RID: 70373 RVA: 0x00284524 File Offset: 0x00282724
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleChallengeUpdateNotify);
		}

		// Token: 0x060112E6 RID: 70374 RVA: 0x00284534 File Offset: 0x00282734
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleChallengeUpdateNotify other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.ChallengeId == other.ChallengeId && this.FirstWin == other.FirstWin && this.Unlock == other.Unlock && this.IsUncover == other.IsUncover && this.IsShow == other.IsShow && this.IsPassRewarded == other.IsPassRewarded && this.challengeInfo_.Equals(other.challengeInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060112E7 RID: 70375 RVA: 0x002845E4 File Offset: 0x002827E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.ChallengeId != 0)
			{
				num ^= this.ChallengeId.GetHashCode();
			}
			if (this.FirstWin)
			{
				num ^= this.FirstWin.GetHashCode();
			}
			if (this.Unlock)
			{
				num ^= this.Unlock.GetHashCode();
			}
			if (this.IsUncover)
			{
				num ^= this.IsUncover.GetHashCode();
			}
			if (this.IsShow)
			{
				num ^= this.IsShow.GetHashCode();
			}
			if (this.IsPassRewarded)
			{
				num ^= this.IsPassRewarded.GetHashCode();
			}
			num ^= this.challengeInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060112E8 RID: 70376 RVA: 0x002846CD File Offset: 0x002828CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060112E9 RID: 70377 RVA: 0x002846DA File Offset: 0x002828DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060112EA RID: 70378 RVA: 0x002846E4 File Offset: 0x002828E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsShow)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsShow);
			}
			if (this.FirstWin)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.FirstWin);
			}
			this.challengeInfo_.WriteTo(ref output, PhantomBattleChallengeUpdateNotify._repeated_challengeInfo_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.ChallengeId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.ChallengeId);
			}
			if (this.IsUncover)
			{
				output.WriteRawTag(80);
				output.WriteBool(this.IsUncover);
			}
			if (this.Unlock)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.Unlock);
			}
			if (this.IsPassRewarded)
			{
				output.WriteRawTag(112);
				output.WriteBool(this.IsPassRewarded);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060112EB RID: 70379 RVA: 0x002847DC File Offset: 0x002829DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.ChallengeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ChallengeId);
			}
			if (this.FirstWin)
			{
				num += 2;
			}
			if (this.Unlock)
			{
				num += 2;
			}
			if (this.IsUncover)
			{
				num += 2;
			}
			if (this.IsShow)
			{
				num += 2;
			}
			if (this.IsPassRewarded)
			{
				num += 2;
			}
			num += this.challengeInfo_.CalculateSize(PhantomBattleChallengeUpdateNotify._repeated_challengeInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060112EC RID: 70380 RVA: 0x00284884 File Offset: 0x00282A84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleChallengeUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.ChallengeId != 0)
			{
				this.ChallengeId = other.ChallengeId;
			}
			if (other.FirstWin)
			{
				this.FirstWin = other.FirstWin;
			}
			if (other.Unlock)
			{
				this.Unlock = other.Unlock;
			}
			if (other.IsUncover)
			{
				this.IsUncover = other.IsUncover;
			}
			if (other.IsShow)
			{
				this.IsShow = other.IsShow;
			}
			if (other.IsPassRewarded)
			{
				this.IsPassRewarded = other.IsPassRewarded;
			}
			this.challengeInfo_.Add(other.challengeInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060112ED RID: 70381 RVA: 0x00284949 File Offset: 0x00282B49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060112EE RID: 70382 RVA: 0x00284954 File Offset: 0x00282B54
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
				if (num <= 40U)
				{
					if (num <= 24U)
					{
						if (num == 16U)
						{
							this.IsShow = input.ReadBool();
							continue;
						}
						if (num == 24U)
						{
							this.FirstWin = input.ReadBool();
							continue;
						}
					}
					else
					{
						if (num == 34U)
						{
							this.challengeInfo_.AddEntriesFrom(ref input, PhantomBattleChallengeUpdateNotify._repeated_challengeInfo_codec);
							continue;
						}
						if (num == 40U)
						{
							this.ErrorCode = (ErrorCode)input.ReadEnum();
							continue;
						}
					}
				}
				else if (num <= 80U)
				{
					if (num == 72U)
					{
						this.ChallengeId = input.ReadInt32();
						continue;
					}
					if (num == 80U)
					{
						this.IsUncover = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.Unlock = input.ReadBool();
						continue;
					}
					if (num == 112U)
					{
						this.IsPassRewarded = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006D1A RID: 27930
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006D1B RID: 27931
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x04006D1C RID: 27932
		private ErrorCode errorCode_;

		// Token: 0x04006D1D RID: 27933
		public const int ChallengeIdFieldNumber = 9;

		// Token: 0x04006D1E RID: 27934
		private int challengeId_;

		// Token: 0x04006D1F RID: 27935
		public const int FirstWinFieldNumber = 3;

		// Token: 0x04006D20 RID: 27936
		private bool firstWin_;

		// Token: 0x04006D21 RID: 27937
		public const int UnlockFieldNumber = 11;

		// Token: 0x04006D22 RID: 27938
		private bool unlock_;

		// Token: 0x04006D23 RID: 27939
		public const int IsUncoverFieldNumber = 10;

		// Token: 0x04006D24 RID: 27940
		private bool isUncover_;

		// Token: 0x04006D25 RID: 27941
		public const int IsShowFieldNumber = 2;

		// Token: 0x04006D26 RID: 27942
		private bool isShow_;

		// Token: 0x04006D27 RID: 27943
		public const int IsPassRewardedFieldNumber = 14;

		// Token: 0x04006D28 RID: 27944
		private bool isPassRewarded_;

		// Token: 0x04006D29 RID: 27945
		public const int ChallengeInfoFieldNumber = 4;

		// Token: 0x04006D2A RID: 27946
		private static readonly FieldCodec<PhantomBattleChallengeInfo> _repeated_challengeInfo_codec = FieldCodec.ForMessage<PhantomBattleChallengeInfo>(34U, PhantomBattleChallengeInfo.Parser);

		// Token: 0x04006D2B RID: 27947
		private readonly RepeatedField<PhantomBattleChallengeInfo> challengeInfo_ = new RepeatedField<PhantomBattleChallengeInfo>();
	}
}
