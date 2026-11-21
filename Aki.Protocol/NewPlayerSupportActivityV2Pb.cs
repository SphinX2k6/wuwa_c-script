using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B0F RID: 2831
	public sealed class NewPlayerSupportActivityV2Pb : IMessage<NewPlayerSupportActivityV2Pb>, IMessage, IEquatable<NewPlayerSupportActivityV2Pb>, IDeepCloneable<NewPlayerSupportActivityV2Pb>, IBufferMessage
	{
		// Token: 0x0600F623 RID: 63011 RVA: 0x0023EA01 File Offset: 0x0023CC01
		[NullableContext(1)]
		public static NewPlayerSupportActivityV2Pb Create()
		{
			return new NewPlayerSupportActivityV2Pb();
		}

		// Token: 0x1700321C RID: 12828
		// (get) Token: 0x0600F624 RID: 63012 RVA: 0x0023EA08 File Offset: 0x0023CC08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700321D RID: 12829
		// (get) Token: 0x0600F625 RID: 63013 RVA: 0x0023EA0B File Offset: 0x0023CC0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewPlayerSupportActivityV2Pb.Descriptor;
			}
		}

		// Token: 0x0600F626 RID: 63014 RVA: 0x0023EA12 File Offset: 0x0023CC12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewPlayerSupportActivityV2Pb()
		{
		}

		// Token: 0x0600F627 RID: 63015 RVA: 0x0023EA30 File Offset: 0x0023CC30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewPlayerSupportActivityV2Pb(NewPlayerSupportActivityV2Pb other) : this()
		{
			this.trialRoleInfoList_ = other.trialRoleInfoList_.Clone();
			this.curUseTrialRoleId_ = other.curUseTrialRoleId_;
			this.curUseRoleInfo_ = ((other.curUseRoleInfo_ != null) ? other.curUseRoleInfo_.Clone() : null);
			this.deduplicateGachaRoleIds_ = other.deduplicateGachaRoleIds_.Clone();
			this.nbWeekCardEndShowTime_ = other.nbWeekCardEndShowTime_;
			this.nbGiftPackEndShowTime_ = other.nbGiftPackEndShowTime_;
			this.nbGachaEndShowTime_ = other.nbGachaEndShowTime_;
			this.nbLivenessEndShowTime_ = other.nbLivenessEndShowTime_;
			this.newPlayerPoolFinalGachaRoleId_ = other.newPlayerPoolFinalGachaRoleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F628 RID: 63016 RVA: 0x0023EADA File Offset: 0x0023CCDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewPlayerSupportActivityV2Pb Clone()
		{
			return new NewPlayerSupportActivityV2Pb(this);
		}

		// Token: 0x1700321E RID: 12830
		// (get) Token: 0x0600F629 RID: 63017 RVA: 0x0023EAE2 File Offset: 0x0023CCE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<NewTrialRoleInfo> TrialRoleInfoList
		{
			get
			{
				return this.trialRoleInfoList_;
			}
		}

		// Token: 0x1700321F RID: 12831
		// (get) Token: 0x0600F62A RID: 63018 RVA: 0x0023EAEA File Offset: 0x0023CCEA
		// (set) Token: 0x0600F62B RID: 63019 RVA: 0x0023EAF2 File Offset: 0x0023CCF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurUseTrialRoleId
		{
			get
			{
				return this.curUseTrialRoleId_;
			}
			set
			{
				this.curUseTrialRoleId_ = value;
			}
		}

		// Token: 0x17003220 RID: 12832
		// (get) Token: 0x0600F62C RID: 63020 RVA: 0x0023EAFB File Offset: 0x0023CCFB
		// (set) Token: 0x0600F62D RID: 63021 RVA: 0x0023EB03 File Offset: 0x0023CD03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public roleInfo CurUseRoleInfo
		{
			get
			{
				return this.curUseRoleInfo_;
			}
			set
			{
				this.curUseRoleInfo_ = value;
			}
		}

		// Token: 0x17003221 RID: 12833
		// (get) Token: 0x0600F62E RID: 63022 RVA: 0x0023EB0C File Offset: 0x0023CD0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> DeduplicateGachaRoleIds
		{
			get
			{
				return this.deduplicateGachaRoleIds_;
			}
		}

		// Token: 0x17003222 RID: 12834
		// (get) Token: 0x0600F62F RID: 63023 RVA: 0x0023EB14 File Offset: 0x0023CD14
		// (set) Token: 0x0600F630 RID: 63024 RVA: 0x0023EB1C File Offset: 0x0023CD1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long NbWeekCardEndShowTime
		{
			get
			{
				return this.nbWeekCardEndShowTime_;
			}
			set
			{
				this.nbWeekCardEndShowTime_ = value;
			}
		}

		// Token: 0x17003223 RID: 12835
		// (get) Token: 0x0600F631 RID: 63025 RVA: 0x0023EB25 File Offset: 0x0023CD25
		// (set) Token: 0x0600F632 RID: 63026 RVA: 0x0023EB2D File Offset: 0x0023CD2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long NbGiftPackEndShowTime
		{
			get
			{
				return this.nbGiftPackEndShowTime_;
			}
			set
			{
				this.nbGiftPackEndShowTime_ = value;
			}
		}

		// Token: 0x17003224 RID: 12836
		// (get) Token: 0x0600F633 RID: 63027 RVA: 0x0023EB36 File Offset: 0x0023CD36
		// (set) Token: 0x0600F634 RID: 63028 RVA: 0x0023EB3E File Offset: 0x0023CD3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long NbGachaEndShowTime
		{
			get
			{
				return this.nbGachaEndShowTime_;
			}
			set
			{
				this.nbGachaEndShowTime_ = value;
			}
		}

		// Token: 0x17003225 RID: 12837
		// (get) Token: 0x0600F635 RID: 63029 RVA: 0x0023EB47 File Offset: 0x0023CD47
		// (set) Token: 0x0600F636 RID: 63030 RVA: 0x0023EB4F File Offset: 0x0023CD4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long NbLivenessEndShowTime
		{
			get
			{
				return this.nbLivenessEndShowTime_;
			}
			set
			{
				this.nbLivenessEndShowTime_ = value;
			}
		}

		// Token: 0x17003226 RID: 12838
		// (get) Token: 0x0600F637 RID: 63031 RVA: 0x0023EB58 File Offset: 0x0023CD58
		// (set) Token: 0x0600F638 RID: 63032 RVA: 0x0023EB60 File Offset: 0x0023CD60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int NewPlayerPoolFinalGachaRoleId
		{
			get
			{
				return this.newPlayerPoolFinalGachaRoleId_;
			}
			set
			{
				this.newPlayerPoolFinalGachaRoleId_ = value;
			}
		}

		// Token: 0x0600F639 RID: 63033 RVA: 0x0023EB69 File Offset: 0x0023CD69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewPlayerSupportActivityV2Pb);
		}

		// Token: 0x0600F63A RID: 63034 RVA: 0x0023EB78 File Offset: 0x0023CD78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewPlayerSupportActivityV2Pb other)
		{
			return other != null && (other == this || (this.trialRoleInfoList_.Equals(other.trialRoleInfoList_) && this.CurUseTrialRoleId == other.CurUseTrialRoleId && object.Equals(this.CurUseRoleInfo, other.CurUseRoleInfo) && this.deduplicateGachaRoleIds_.Equals(other.deduplicateGachaRoleIds_) && this.NbWeekCardEndShowTime == other.NbWeekCardEndShowTime && this.NbGiftPackEndShowTime == other.NbGiftPackEndShowTime && this.NbGachaEndShowTime == other.NbGachaEndShowTime && this.NbLivenessEndShowTime == other.NbLivenessEndShowTime && this.NewPlayerPoolFinalGachaRoleId == other.NewPlayerPoolFinalGachaRoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F63B RID: 63035 RVA: 0x0023EC40 File Offset: 0x0023CE40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.trialRoleInfoList_.GetHashCode();
			if (this.CurUseTrialRoleId != 0)
			{
				num ^= this.CurUseTrialRoleId.GetHashCode();
			}
			if (this.curUseRoleInfo_ != null)
			{
				num ^= this.CurUseRoleInfo.GetHashCode();
			}
			num ^= this.deduplicateGachaRoleIds_.GetHashCode();
			if (this.NbWeekCardEndShowTime != 0L)
			{
				num ^= this.NbWeekCardEndShowTime.GetHashCode();
			}
			if (this.NbGiftPackEndShowTime != 0L)
			{
				num ^= this.NbGiftPackEndShowTime.GetHashCode();
			}
			if (this.NbGachaEndShowTime != 0L)
			{
				num ^= this.NbGachaEndShowTime.GetHashCode();
			}
			if (this.NbLivenessEndShowTime != 0L)
			{
				num ^= this.NbLivenessEndShowTime.GetHashCode();
			}
			if (this.NewPlayerPoolFinalGachaRoleId != 0)
			{
				num ^= this.NewPlayerPoolFinalGachaRoleId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F63C RID: 63036 RVA: 0x0023ED2E File Offset: 0x0023CF2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F63D RID: 63037 RVA: 0x0023ED3B File Offset: 0x0023CF3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F63E RID: 63038 RVA: 0x0023ED44 File Offset: 0x0023CF44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.trialRoleInfoList_.WriteTo(ref output, NewPlayerSupportActivityV2Pb._repeated_trialRoleInfoList_codec);
			if (this.CurUseTrialRoleId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.CurUseTrialRoleId);
			}
			if (this.curUseRoleInfo_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.CurUseRoleInfo);
			}
			this.deduplicateGachaRoleIds_.WriteTo(ref output, NewPlayerSupportActivityV2Pb._repeated_deduplicateGachaRoleIds_codec);
			if (this.NbWeekCardEndShowTime != 0L)
			{
				output.WriteRawTag(48);
				output.WriteInt64(this.NbWeekCardEndShowTime);
			}
			if (this.NbGiftPackEndShowTime != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.NbGiftPackEndShowTime);
			}
			if (this.NbGachaEndShowTime != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.NbGachaEndShowTime);
			}
			if (this.NbLivenessEndShowTime != 0L)
			{
				output.WriteRawTag(72);
				output.WriteInt64(this.NbLivenessEndShowTime);
			}
			if (this.NewPlayerPoolFinalGachaRoleId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.NewPlayerPoolFinalGachaRoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F63F RID: 63039 RVA: 0x0023EE4C File Offset: 0x0023D04C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.trialRoleInfoList_.CalculateSize(NewPlayerSupportActivityV2Pb._repeated_trialRoleInfoList_codec);
			if (this.CurUseTrialRoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurUseTrialRoleId);
			}
			if (this.curUseRoleInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CurUseRoleInfo);
			}
			num += this.deduplicateGachaRoleIds_.CalculateSize(NewPlayerSupportActivityV2Pb._repeated_deduplicateGachaRoleIds_codec);
			if (this.NbWeekCardEndShowTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.NbWeekCardEndShowTime);
			}
			if (this.NbGiftPackEndShowTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.NbGiftPackEndShowTime);
			}
			if (this.NbGachaEndShowTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.NbGachaEndShowTime);
			}
			if (this.NbLivenessEndShowTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.NbLivenessEndShowTime);
			}
			if (this.NewPlayerPoolFinalGachaRoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.NewPlayerPoolFinalGachaRoleId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F640 RID: 63040 RVA: 0x0023EF40 File Offset: 0x0023D140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewPlayerSupportActivityV2Pb other)
		{
			if (other == null)
			{
				return;
			}
			this.trialRoleInfoList_.Add(other.trialRoleInfoList_);
			if (other.CurUseTrialRoleId != 0)
			{
				this.CurUseTrialRoleId = other.CurUseTrialRoleId;
			}
			if (other.curUseRoleInfo_ != null)
			{
				if (this.curUseRoleInfo_ == null)
				{
					this.CurUseRoleInfo = new roleInfo();
				}
				this.CurUseRoleInfo.MergeFrom(other.CurUseRoleInfo);
			}
			this.deduplicateGachaRoleIds_.Add(other.deduplicateGachaRoleIds_);
			if (other.NbWeekCardEndShowTime != 0L)
			{
				this.NbWeekCardEndShowTime = other.NbWeekCardEndShowTime;
			}
			if (other.NbGiftPackEndShowTime != 0L)
			{
				this.NbGiftPackEndShowTime = other.NbGiftPackEndShowTime;
			}
			if (other.NbGachaEndShowTime != 0L)
			{
				this.NbGachaEndShowTime = other.NbGachaEndShowTime;
			}
			if (other.NbLivenessEndShowTime != 0L)
			{
				this.NbLivenessEndShowTime = other.NbLivenessEndShowTime;
			}
			if (other.NewPlayerPoolFinalGachaRoleId != 0)
			{
				this.NewPlayerPoolFinalGachaRoleId = other.NewPlayerPoolFinalGachaRoleId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F641 RID: 63041 RVA: 0x0023F02E File Offset: 0x0023D22E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F642 RID: 63042 RVA: 0x0023F038 File Offset: 0x0023D238
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
				if (num <= 42U)
				{
					if (num <= 24U)
					{
						if (num == 10U)
						{
							this.trialRoleInfoList_.AddEntriesFrom(ref input, NewPlayerSupportActivityV2Pb._repeated_trialRoleInfoList_codec);
							continue;
						}
						if (num == 24U)
						{
							this.CurUseTrialRoleId = input.ReadInt32();
							continue;
						}
					}
					else
					{
						if (num == 34U)
						{
							if (this.curUseRoleInfo_ == null)
							{
								this.CurUseRoleInfo = new roleInfo();
							}
							input.ReadMessage(this.CurUseRoleInfo);
							continue;
						}
						if (num == 40U || num == 42U)
						{
							this.deduplicateGachaRoleIds_.AddEntriesFrom(ref input, NewPlayerSupportActivityV2Pb._repeated_deduplicateGachaRoleIds_codec);
							continue;
						}
					}
				}
				else if (num <= 56U)
				{
					if (num == 48U)
					{
						this.NbWeekCardEndShowTime = input.ReadInt64();
						continue;
					}
					if (num == 56U)
					{
						this.NbGiftPackEndShowTime = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 64U)
					{
						this.NbGachaEndShowTime = input.ReadInt64();
						continue;
					}
					if (num == 72U)
					{
						this.NbLivenessEndShowTime = input.ReadInt64();
						continue;
					}
					if (num == 80U)
					{
						this.NewPlayerPoolFinalGachaRoleId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400633C RID: 25404
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400633D RID: 25405
		public const int TrialRoleInfoListFieldNumber = 1;

		// Token: 0x0400633E RID: 25406
		private static readonly FieldCodec<NewTrialRoleInfo> _repeated_trialRoleInfoList_codec = FieldCodec.ForMessage<NewTrialRoleInfo>(10U, NewTrialRoleInfo.Parser);

		// Token: 0x0400633F RID: 25407
		private readonly RepeatedField<NewTrialRoleInfo> trialRoleInfoList_ = new RepeatedField<NewTrialRoleInfo>();

		// Token: 0x04006340 RID: 25408
		public const int CurUseTrialRoleIdFieldNumber = 3;

		// Token: 0x04006341 RID: 25409
		private int curUseTrialRoleId_;

		// Token: 0x04006342 RID: 25410
		public const int CurUseRoleInfoFieldNumber = 4;

		// Token: 0x04006343 RID: 25411
		private roleInfo curUseRoleInfo_;

		// Token: 0x04006344 RID: 25412
		public const int DeduplicateGachaRoleIdsFieldNumber = 5;

		// Token: 0x04006345 RID: 25413
		private static readonly FieldCodec<int> _repeated_deduplicateGachaRoleIds_codec = FieldCodec.ForInt32(42U);

		// Token: 0x04006346 RID: 25414
		private readonly RepeatedField<int> deduplicateGachaRoleIds_ = new RepeatedField<int>();

		// Token: 0x04006347 RID: 25415
		public const int NbWeekCardEndShowTimeFieldNumber = 6;

		// Token: 0x04006348 RID: 25416
		private long nbWeekCardEndShowTime_;

		// Token: 0x04006349 RID: 25417
		public const int NbGiftPackEndShowTimeFieldNumber = 7;

		// Token: 0x0400634A RID: 25418
		private long nbGiftPackEndShowTime_;

		// Token: 0x0400634B RID: 25419
		public const int NbGachaEndShowTimeFieldNumber = 8;

		// Token: 0x0400634C RID: 25420
		private long nbGachaEndShowTime_;

		// Token: 0x0400634D RID: 25421
		public const int NbLivenessEndShowTimeFieldNumber = 9;

		// Token: 0x0400634E RID: 25422
		private long nbLivenessEndShowTime_;

		// Token: 0x0400634F RID: 25423
		public const int NewPlayerPoolFinalGachaRoleIdFieldNumber = 10;

		// Token: 0x04006350 RID: 25424
		private int newPlayerPoolFinalGachaRoleId_;
	}
}
