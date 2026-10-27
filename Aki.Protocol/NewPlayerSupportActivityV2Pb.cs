using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B20 RID: 2848
	public sealed class NewPlayerSupportActivityV2Pb : IMessage<NewPlayerSupportActivityV2Pb>, IMessage, IEquatable<NewPlayerSupportActivityV2Pb>, IDeepCloneable<NewPlayerSupportActivityV2Pb>, IBufferMessage
	{
		// Token: 0x0600F73D RID: 63293 RVA: 0x00240C18 File Offset: 0x0023EE18
		[NullableContext(1)]
		public static NewPlayerSupportActivityV2Pb Create()
		{
			return new NewPlayerSupportActivityV2Pb();
		}

		// Token: 0x1700325A RID: 12890
		// (get) Token: 0x0600F73E RID: 63294 RVA: 0x00240C1F File Offset: 0x0023EE1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700325B RID: 12891
		// (get) Token: 0x0600F73F RID: 63295 RVA: 0x00240C22 File Offset: 0x0023EE22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewPlayerSupportActivityV2Pb.Descriptor;
			}
		}

		// Token: 0x0600F740 RID: 63296 RVA: 0x00240C29 File Offset: 0x0023EE29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewPlayerSupportActivityV2Pb()
		{
		}

		// Token: 0x0600F741 RID: 63297 RVA: 0x00240C48 File Offset: 0x0023EE48
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

		// Token: 0x0600F742 RID: 63298 RVA: 0x00240CF2 File Offset: 0x0023EEF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewPlayerSupportActivityV2Pb Clone()
		{
			return new NewPlayerSupportActivityV2Pb(this);
		}

		// Token: 0x1700325C RID: 12892
		// (get) Token: 0x0600F743 RID: 63299 RVA: 0x00240CFA File Offset: 0x0023EEFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<NewTrialRoleInfo> TrialRoleInfoList
		{
			get
			{
				return this.trialRoleInfoList_;
			}
		}

		// Token: 0x1700325D RID: 12893
		// (get) Token: 0x0600F744 RID: 63300 RVA: 0x00240D02 File Offset: 0x0023EF02
		// (set) Token: 0x0600F745 RID: 63301 RVA: 0x00240D0A File Offset: 0x0023EF0A
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

		// Token: 0x1700325E RID: 12894
		// (get) Token: 0x0600F746 RID: 63302 RVA: 0x00240D13 File Offset: 0x0023EF13
		// (set) Token: 0x0600F747 RID: 63303 RVA: 0x00240D1B File Offset: 0x0023EF1B
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

		// Token: 0x1700325F RID: 12895
		// (get) Token: 0x0600F748 RID: 63304 RVA: 0x00240D24 File Offset: 0x0023EF24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> DeduplicateGachaRoleIds
		{
			get
			{
				return this.deduplicateGachaRoleIds_;
			}
		}

		// Token: 0x17003260 RID: 12896
		// (get) Token: 0x0600F749 RID: 63305 RVA: 0x00240D2C File Offset: 0x0023EF2C
		// (set) Token: 0x0600F74A RID: 63306 RVA: 0x00240D34 File Offset: 0x0023EF34
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

		// Token: 0x17003261 RID: 12897
		// (get) Token: 0x0600F74B RID: 63307 RVA: 0x00240D3D File Offset: 0x0023EF3D
		// (set) Token: 0x0600F74C RID: 63308 RVA: 0x00240D45 File Offset: 0x0023EF45
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

		// Token: 0x17003262 RID: 12898
		// (get) Token: 0x0600F74D RID: 63309 RVA: 0x00240D4E File Offset: 0x0023EF4E
		// (set) Token: 0x0600F74E RID: 63310 RVA: 0x00240D56 File Offset: 0x0023EF56
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

		// Token: 0x17003263 RID: 12899
		// (get) Token: 0x0600F74F RID: 63311 RVA: 0x00240D5F File Offset: 0x0023EF5F
		// (set) Token: 0x0600F750 RID: 63312 RVA: 0x00240D67 File Offset: 0x0023EF67
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

		// Token: 0x17003264 RID: 12900
		// (get) Token: 0x0600F751 RID: 63313 RVA: 0x00240D70 File Offset: 0x0023EF70
		// (set) Token: 0x0600F752 RID: 63314 RVA: 0x00240D78 File Offset: 0x0023EF78
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

		// Token: 0x0600F753 RID: 63315 RVA: 0x00240D81 File Offset: 0x0023EF81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewPlayerSupportActivityV2Pb);
		}

		// Token: 0x0600F754 RID: 63316 RVA: 0x00240D90 File Offset: 0x0023EF90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewPlayerSupportActivityV2Pb other)
		{
			return other != null && (other == this || (this.trialRoleInfoList_.Equals(other.trialRoleInfoList_) && this.CurUseTrialRoleId == other.CurUseTrialRoleId && object.Equals(this.CurUseRoleInfo, other.CurUseRoleInfo) && this.deduplicateGachaRoleIds_.Equals(other.deduplicateGachaRoleIds_) && this.NbWeekCardEndShowTime == other.NbWeekCardEndShowTime && this.NbGiftPackEndShowTime == other.NbGiftPackEndShowTime && this.NbGachaEndShowTime == other.NbGachaEndShowTime && this.NbLivenessEndShowTime == other.NbLivenessEndShowTime && this.NewPlayerPoolFinalGachaRoleId == other.NewPlayerPoolFinalGachaRoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F755 RID: 63317 RVA: 0x00240E58 File Offset: 0x0023F058
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

		// Token: 0x0600F756 RID: 63318 RVA: 0x00240F46 File Offset: 0x0023F146
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F757 RID: 63319 RVA: 0x00240F53 File Offset: 0x0023F153
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F758 RID: 63320 RVA: 0x00240F5C File Offset: 0x0023F15C
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

		// Token: 0x0600F759 RID: 63321 RVA: 0x00241064 File Offset: 0x0023F264
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

		// Token: 0x0600F75A RID: 63322 RVA: 0x00241158 File Offset: 0x0023F358
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

		// Token: 0x0600F75B RID: 63323 RVA: 0x00241246 File Offset: 0x0023F446
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F75C RID: 63324 RVA: 0x00241250 File Offset: 0x0023F450
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

		// Token: 0x04006333 RID: 25395
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006334 RID: 25396
		public const int TrialRoleInfoListFieldNumber = 1;

		// Token: 0x04006335 RID: 25397
		private static readonly FieldCodec<NewTrialRoleInfo> _repeated_trialRoleInfoList_codec = FieldCodec.ForMessage<NewTrialRoleInfo>(10U, NewTrialRoleInfo.Parser);

		// Token: 0x04006336 RID: 25398
		private readonly RepeatedField<NewTrialRoleInfo> trialRoleInfoList_ = new RepeatedField<NewTrialRoleInfo>();

		// Token: 0x04006337 RID: 25399
		public const int CurUseTrialRoleIdFieldNumber = 3;

		// Token: 0x04006338 RID: 25400
		private int curUseTrialRoleId_;

		// Token: 0x04006339 RID: 25401
		public const int CurUseRoleInfoFieldNumber = 4;

		// Token: 0x0400633A RID: 25402
		private roleInfo curUseRoleInfo_;

		// Token: 0x0400633B RID: 25403
		public const int DeduplicateGachaRoleIdsFieldNumber = 5;

		// Token: 0x0400633C RID: 25404
		private static readonly FieldCodec<int> _repeated_deduplicateGachaRoleIds_codec = FieldCodec.ForInt32(42U);

		// Token: 0x0400633D RID: 25405
		private readonly RepeatedField<int> deduplicateGachaRoleIds_ = new RepeatedField<int>();

		// Token: 0x0400633E RID: 25406
		public const int NbWeekCardEndShowTimeFieldNumber = 6;

		// Token: 0x0400633F RID: 25407
		private long nbWeekCardEndShowTime_;

		// Token: 0x04006340 RID: 25408
		public const int NbGiftPackEndShowTimeFieldNumber = 7;

		// Token: 0x04006341 RID: 25409
		private long nbGiftPackEndShowTime_;

		// Token: 0x04006342 RID: 25410
		public const int NbGachaEndShowTimeFieldNumber = 8;

		// Token: 0x04006343 RID: 25411
		private long nbGachaEndShowTime_;

		// Token: 0x04006344 RID: 25412
		public const int NbLivenessEndShowTimeFieldNumber = 9;

		// Token: 0x04006345 RID: 25413
		private long nbLivenessEndShowTime_;

		// Token: 0x04006346 RID: 25414
		public const int NewPlayerPoolFinalGachaRoleIdFieldNumber = 10;

		// Token: 0x04006347 RID: 25415
		private int newPlayerPoolFinalGachaRoleId_;
	}
}
