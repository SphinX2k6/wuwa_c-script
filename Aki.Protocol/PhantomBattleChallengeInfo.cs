using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C5A RID: 3162
	public sealed class PhantomBattleChallengeInfo : IMessage<PhantomBattleChallengeInfo>, IMessage, IEquatable<PhantomBattleChallengeInfo>, IDeepCloneable<PhantomBattleChallengeInfo>, IBufferMessage
	{
		// Token: 0x0601129D RID: 70301 RVA: 0x00283B80 File Offset: 0x00281D80
		[NullableContext(1)]
		public static PhantomBattleChallengeInfo Create()
		{
			return new PhantomBattleChallengeInfo();
		}

		// Token: 0x170038BE RID: 14526
		// (get) Token: 0x0601129E RID: 70302 RVA: 0x00283B87 File Offset: 0x00281D87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PhantomBattleChallengeInfo> Parser
		{
			get
			{
				return PhantomBattleChallengeInfo._parser;
			}
		}

		// Token: 0x170038BF RID: 14527
		// (get) Token: 0x0601129F RID: 70303 RVA: 0x00283B8E File Offset: 0x00281D8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170038C0 RID: 14528
		// (get) Token: 0x060112A0 RID: 70304 RVA: 0x00283B91 File Offset: 0x00281D91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleChallengeInfo.Descriptor;
			}
		}

		// Token: 0x060112A1 RID: 70305 RVA: 0x00283B98 File Offset: 0x00281D98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleChallengeInfo()
		{
		}

		// Token: 0x060112A2 RID: 70306 RVA: 0x00283BAC File Offset: 0x00281DAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleChallengeInfo(PhantomBattleChallengeInfo other) : this()
		{
			this.phantomBattleChallengeId_ = other.phantomBattleChallengeId_;
			this.isUnlock_ = other.isUnlock_;
			this.isPassRewarded_ = other.isPassRewarded_;
			this.lastCardRoleId_ = other.lastCardRoleId_;
			this.lastCardGroupIndex_ = other.lastCardGroupIndex_;
			this.finishConditions_ = other.finishConditions_.Clone();
			this.isUncover_ = other.isUncover_;
			this.isShow_ = other.isShow_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060112A3 RID: 70307 RVA: 0x00283C35 File Offset: 0x00281E35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleChallengeInfo Clone()
		{
			return new PhantomBattleChallengeInfo(this);
		}

		// Token: 0x170038C1 RID: 14529
		// (get) Token: 0x060112A4 RID: 70308 RVA: 0x00283C3D File Offset: 0x00281E3D
		// (set) Token: 0x060112A5 RID: 70309 RVA: 0x00283C45 File Offset: 0x00281E45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PhantomBattleChallengeId
		{
			get
			{
				return this.phantomBattleChallengeId_;
			}
			set
			{
				this.phantomBattleChallengeId_ = value;
			}
		}

		// Token: 0x170038C2 RID: 14530
		// (get) Token: 0x060112A6 RID: 70310 RVA: 0x00283C4E File Offset: 0x00281E4E
		// (set) Token: 0x060112A7 RID: 70311 RVA: 0x00283C56 File Offset: 0x00281E56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsUnlock
		{
			get
			{
				return this.isUnlock_;
			}
			set
			{
				this.isUnlock_ = value;
			}
		}

		// Token: 0x170038C3 RID: 14531
		// (get) Token: 0x060112A8 RID: 70312 RVA: 0x00283C5F File Offset: 0x00281E5F
		// (set) Token: 0x060112A9 RID: 70313 RVA: 0x00283C67 File Offset: 0x00281E67
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

		// Token: 0x170038C4 RID: 14532
		// (get) Token: 0x060112AA RID: 70314 RVA: 0x00283C70 File Offset: 0x00281E70
		// (set) Token: 0x060112AB RID: 70315 RVA: 0x00283C78 File Offset: 0x00281E78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LastCardRoleId
		{
			get
			{
				return this.lastCardRoleId_;
			}
			set
			{
				this.lastCardRoleId_ = value;
			}
		}

		// Token: 0x170038C5 RID: 14533
		// (get) Token: 0x060112AC RID: 70316 RVA: 0x00283C81 File Offset: 0x00281E81
		// (set) Token: 0x060112AD RID: 70317 RVA: 0x00283C89 File Offset: 0x00281E89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LastCardGroupIndex
		{
			get
			{
				return this.lastCardGroupIndex_;
			}
			set
			{
				this.lastCardGroupIndex_ = value;
			}
		}

		// Token: 0x170038C6 RID: 14534
		// (get) Token: 0x060112AE RID: 70318 RVA: 0x00283C92 File Offset: 0x00281E92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> FinishConditions
		{
			get
			{
				return this.finishConditions_;
			}
		}

		// Token: 0x170038C7 RID: 14535
		// (get) Token: 0x060112AF RID: 70319 RVA: 0x00283C9A File Offset: 0x00281E9A
		// (set) Token: 0x060112B0 RID: 70320 RVA: 0x00283CA2 File Offset: 0x00281EA2
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

		// Token: 0x170038C8 RID: 14536
		// (get) Token: 0x060112B1 RID: 70321 RVA: 0x00283CAB File Offset: 0x00281EAB
		// (set) Token: 0x060112B2 RID: 70322 RVA: 0x00283CB3 File Offset: 0x00281EB3
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

		// Token: 0x060112B3 RID: 70323 RVA: 0x00283CBC File Offset: 0x00281EBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleChallengeInfo);
		}

		// Token: 0x060112B4 RID: 70324 RVA: 0x00283CCC File Offset: 0x00281ECC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleChallengeInfo other)
		{
			return other != null && (other == this || (this.PhantomBattleChallengeId == other.PhantomBattleChallengeId && this.IsUnlock == other.IsUnlock && this.IsPassRewarded == other.IsPassRewarded && this.LastCardRoleId == other.LastCardRoleId && this.LastCardGroupIndex == other.LastCardGroupIndex && this.finishConditions_.Equals(other.finishConditions_) && this.IsUncover == other.IsUncover && this.IsShow == other.IsShow && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060112B5 RID: 70325 RVA: 0x00283D7C File Offset: 0x00281F7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PhantomBattleChallengeId != 0)
			{
				num ^= this.PhantomBattleChallengeId.GetHashCode();
			}
			if (this.IsUnlock)
			{
				num ^= this.IsUnlock.GetHashCode();
			}
			if (this.IsPassRewarded)
			{
				num ^= this.IsPassRewarded.GetHashCode();
			}
			if (this.LastCardRoleId != 0)
			{
				num ^= this.LastCardRoleId.GetHashCode();
			}
			if (this.LastCardGroupIndex != 0)
			{
				num ^= this.LastCardGroupIndex.GetHashCode();
			}
			num ^= this.finishConditions_.GetHashCode();
			if (this.IsUncover)
			{
				num ^= this.IsUncover.GetHashCode();
			}
			if (this.IsShow)
			{
				num ^= this.IsShow.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060112B6 RID: 70326 RVA: 0x00283E5F File Offset: 0x0028205F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060112B7 RID: 70327 RVA: 0x00283E6C File Offset: 0x0028206C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060112B8 RID: 70328 RVA: 0x00283E78 File Offset: 0x00282078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PhantomBattleChallengeId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.PhantomBattleChallengeId);
			}
			if (this.IsUnlock)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.IsUnlock);
			}
			if (this.IsPassRewarded)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsPassRewarded);
			}
			if (this.LastCardRoleId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.LastCardRoleId);
			}
			if (this.LastCardGroupIndex != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.LastCardGroupIndex);
			}
			this.finishConditions_.WriteTo(ref output, PhantomBattleChallengeInfo._repeated_finishConditions_codec);
			if (this.IsUncover)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.IsUncover);
			}
			if (this.IsShow)
			{
				output.WriteRawTag(64);
				output.WriteBool(this.IsShow);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060112B9 RID: 70329 RVA: 0x00283F70 File Offset: 0x00282170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PhantomBattleChallengeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PhantomBattleChallengeId);
			}
			if (this.IsUnlock)
			{
				num += 2;
			}
			if (this.IsPassRewarded)
			{
				num += 2;
			}
			if (this.LastCardRoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LastCardRoleId);
			}
			if (this.LastCardGroupIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LastCardGroupIndex);
			}
			num += this.finishConditions_.CalculateSize(PhantomBattleChallengeInfo._repeated_finishConditions_codec);
			if (this.IsUncover)
			{
				num += 2;
			}
			if (this.IsShow)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060112BA RID: 70330 RVA: 0x00284024 File Offset: 0x00282224
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleChallengeInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PhantomBattleChallengeId != 0)
			{
				this.PhantomBattleChallengeId = other.PhantomBattleChallengeId;
			}
			if (other.IsUnlock)
			{
				this.IsUnlock = other.IsUnlock;
			}
			if (other.IsPassRewarded)
			{
				this.IsPassRewarded = other.IsPassRewarded;
			}
			if (other.LastCardRoleId != 0)
			{
				this.LastCardRoleId = other.LastCardRoleId;
			}
			if (other.LastCardGroupIndex != 0)
			{
				this.LastCardGroupIndex = other.LastCardGroupIndex;
			}
			this.finishConditions_.Add(other.finishConditions_);
			if (other.IsUncover)
			{
				this.IsUncover = other.IsUncover;
			}
			if (other.IsShow)
			{
				this.IsShow = other.IsShow;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060112BB RID: 70331 RVA: 0x002840E9 File Offset: 0x002822E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060112BC RID: 70332 RVA: 0x002840F4 File Offset: 0x002822F4
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
				if (num > 32U)
				{
					if (num <= 48U)
					{
						if (num == 40U)
						{
							this.LastCardGroupIndex = input.ReadInt32();
							continue;
						}
						if (num != 48U)
						{
							goto IL_4D;
						}
					}
					else if (num != 50U)
					{
						if (num == 56U)
						{
							this.IsUncover = input.ReadBool();
							continue;
						}
						if (num != 64U)
						{
							goto IL_4D;
						}
						this.IsShow = input.ReadBool();
						continue;
					}
					this.finishConditions_.AddEntriesFrom(ref input, PhantomBattleChallengeInfo._repeated_finishConditions_codec);
					continue;
				}
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.PhantomBattleChallengeId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.IsUnlock = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.IsPassRewarded = input.ReadBool();
						continue;
					}
					if (num == 32U)
					{
						this.LastCardRoleId = input.ReadInt32();
						continue;
					}
				}
				IL_4D:
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04006D03 RID: 27907
		private static readonly MessageParser<PhantomBattleChallengeInfo> _parser = new MessageParser<PhantomBattleChallengeInfo>(() => new PhantomBattleChallengeInfo());

		// Token: 0x04006D04 RID: 27908
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006D05 RID: 27909
		public const int PhantomBattleChallengeIdFieldNumber = 1;

		// Token: 0x04006D06 RID: 27910
		private int phantomBattleChallengeId_;

		// Token: 0x04006D07 RID: 27911
		public const int IsUnlockFieldNumber = 2;

		// Token: 0x04006D08 RID: 27912
		private bool isUnlock_;

		// Token: 0x04006D09 RID: 27913
		public const int IsPassRewardedFieldNumber = 3;

		// Token: 0x04006D0A RID: 27914
		private bool isPassRewarded_;

		// Token: 0x04006D0B RID: 27915
		public const int LastCardRoleIdFieldNumber = 4;

		// Token: 0x04006D0C RID: 27916
		private int lastCardRoleId_;

		// Token: 0x04006D0D RID: 27917
		public const int LastCardGroupIndexFieldNumber = 5;

		// Token: 0x04006D0E RID: 27918
		private int lastCardGroupIndex_;

		// Token: 0x04006D0F RID: 27919
		public const int FinishConditionsFieldNumber = 6;

		// Token: 0x04006D10 RID: 27920
		private static readonly FieldCodec<int> _repeated_finishConditions_codec = FieldCodec.ForInt32(50U);

		// Token: 0x04006D11 RID: 27921
		private readonly RepeatedField<int> finishConditions_ = new RepeatedField<int>();

		// Token: 0x04006D12 RID: 27922
		public const int IsUncoverFieldNumber = 7;

		// Token: 0x04006D13 RID: 27923
		private bool isUncover_;

		// Token: 0x04006D14 RID: 27924
		public const int IsShowFieldNumber = 8;

		// Token: 0x04006D15 RID: 27925
		private bool isShow_;
	}
}
