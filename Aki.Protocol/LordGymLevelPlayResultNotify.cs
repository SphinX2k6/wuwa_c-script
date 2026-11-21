using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000951 RID: 2385
	[NetMessage(EMessageId.LordGymLevelPlayResultNotify)]
	public sealed class LordGymLevelPlayResultNotify : IMessage<LordGymLevelPlayResultNotify>, IMessage, IEquatable<LordGymLevelPlayResultNotify>, IDeepCloneable<LordGymLevelPlayResultNotify>, IBufferMessage
	{
		// Token: 0x0600D27F RID: 53887 RVA: 0x001F0A64 File Offset: 0x001EEC64
		[NullableContext(1)]
		public static LordGymLevelPlayResultNotify Create()
		{
			return new LordGymLevelPlayResultNotify();
		}

		// Token: 0x17002A9C RID: 10908
		// (get) Token: 0x0600D280 RID: 53888 RVA: 0x001F0A6B File Offset: 0x001EEC6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002A9D RID: 10909
		// (get) Token: 0x0600D281 RID: 53889 RVA: 0x001F0A6E File Offset: 0x001EEC6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LordGymLevelPlayResultNotify.Descriptor;
			}
		}

		// Token: 0x0600D282 RID: 53890 RVA: 0x001F0A75 File Offset: 0x001EEC75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LordGymLevelPlayResultNotify()
		{
		}

		// Token: 0x0600D283 RID: 53891 RVA: 0x001F0A88 File Offset: 0x001EEC88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LordGymLevelPlayResultNotify(LordGymLevelPlayResultNotify other) : this()
		{
			this.isSuccess_ = other.isSuccess_;
			this.isNewRecord_ = other.isNewRecord_;
			this.lordGymPassRecord_ = ((other.lordGymPassRecord_ != null) ? other.lordGymPassRecord_.Clone() : null);
			this.failLoadGymId_ = other.failLoadGymId_;
			this.itemDatas_ = other.itemDatas_.Clone();
			this.isPkgFull_ = other.isPkgFull_;
			this.passTime_ = other.passTime_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D284 RID: 53892 RVA: 0x001F0B15 File Offset: 0x001EED15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LordGymLevelPlayResultNotify Clone()
		{
			return new LordGymLevelPlayResultNotify(this);
		}

		// Token: 0x17002A9E RID: 10910
		// (get) Token: 0x0600D285 RID: 53893 RVA: 0x001F0B1D File Offset: 0x001EED1D
		// (set) Token: 0x0600D286 RID: 53894 RVA: 0x001F0B25 File Offset: 0x001EED25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsSuccess
		{
			get
			{
				return this.isSuccess_;
			}
			set
			{
				this.isSuccess_ = value;
			}
		}

		// Token: 0x17002A9F RID: 10911
		// (get) Token: 0x0600D287 RID: 53895 RVA: 0x001F0B2E File Offset: 0x001EED2E
		// (set) Token: 0x0600D288 RID: 53896 RVA: 0x001F0B36 File Offset: 0x001EED36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsNewRecord
		{
			get
			{
				return this.isNewRecord_;
			}
			set
			{
				this.isNewRecord_ = value;
			}
		}

		// Token: 0x17002AA0 RID: 10912
		// (get) Token: 0x0600D289 RID: 53897 RVA: 0x001F0B3F File Offset: 0x001EED3F
		// (set) Token: 0x0600D28A RID: 53898 RVA: 0x001F0B47 File Offset: 0x001EED47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LordGymPassRecord LordGymPassRecord
		{
			get
			{
				return this.lordGymPassRecord_;
			}
			set
			{
				this.lordGymPassRecord_ = value;
			}
		}

		// Token: 0x17002AA1 RID: 10913
		// (get) Token: 0x0600D28B RID: 53899 RVA: 0x001F0B50 File Offset: 0x001EED50
		// (set) Token: 0x0600D28C RID: 53900 RVA: 0x001F0B58 File Offset: 0x001EED58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FailLoadGymId
		{
			get
			{
				return this.failLoadGymId_;
			}
			set
			{
				this.failLoadGymId_ = value;
			}
		}

		// Token: 0x17002AA2 RID: 10914
		// (get) Token: 0x0600D28D RID: 53901 RVA: 0x001F0B61 File Offset: 0x001EED61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ItemData> ItemDatas
		{
			get
			{
				return this.itemDatas_;
			}
		}

		// Token: 0x17002AA3 RID: 10915
		// (get) Token: 0x0600D28E RID: 53902 RVA: 0x001F0B69 File Offset: 0x001EED69
		// (set) Token: 0x0600D28F RID: 53903 RVA: 0x001F0B71 File Offset: 0x001EED71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsPkgFull
		{
			get
			{
				return this.isPkgFull_;
			}
			set
			{
				this.isPkgFull_ = value;
			}
		}

		// Token: 0x17002AA4 RID: 10916
		// (get) Token: 0x0600D290 RID: 53904 RVA: 0x001F0B7A File Offset: 0x001EED7A
		// (set) Token: 0x0600D291 RID: 53905 RVA: 0x001F0B82 File Offset: 0x001EED82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PassTime
		{
			get
			{
				return this.passTime_;
			}
			set
			{
				this.passTime_ = value;
			}
		}

		// Token: 0x0600D292 RID: 53906 RVA: 0x001F0B8B File Offset: 0x001EED8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LordGymLevelPlayResultNotify);
		}

		// Token: 0x0600D293 RID: 53907 RVA: 0x001F0B9C File Offset: 0x001EED9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LordGymLevelPlayResultNotify other)
		{
			return other != null && (other == this || (this.IsSuccess == other.IsSuccess && this.IsNewRecord == other.IsNewRecord && object.Equals(this.LordGymPassRecord, other.LordGymPassRecord) && this.FailLoadGymId == other.FailLoadGymId && this.itemDatas_.Equals(other.itemDatas_) && this.IsPkgFull == other.IsPkgFull && this.PassTime == other.PassTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D294 RID: 53908 RVA: 0x001F0C40 File Offset: 0x001EEE40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsSuccess)
			{
				num ^= this.IsSuccess.GetHashCode();
			}
			if (this.IsNewRecord)
			{
				num ^= this.IsNewRecord.GetHashCode();
			}
			if (this.lordGymPassRecord_ != null)
			{
				num ^= this.LordGymPassRecord.GetHashCode();
			}
			if (this.FailLoadGymId != 0)
			{
				num ^= this.FailLoadGymId.GetHashCode();
			}
			num ^= this.itemDatas_.GetHashCode();
			if (this.IsPkgFull)
			{
				num ^= this.IsPkgFull.GetHashCode();
			}
			if (this.PassTime != 0)
			{
				num ^= this.PassTime.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D295 RID: 53909 RVA: 0x001F0D07 File Offset: 0x001EEF07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D296 RID: 53910 RVA: 0x001F0D14 File Offset: 0x001EEF14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D297 RID: 53911 RVA: 0x001F0D20 File Offset: 0x001EEF20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FailLoadGymId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.FailLoadGymId);
			}
			if (this.IsSuccess)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.IsSuccess);
			}
			if (this.PassTime != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.PassTime);
			}
			if (this.lordGymPassRecord_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.LordGymPassRecord);
			}
			if (this.IsNewRecord)
			{
				output.WriteRawTag(72);
				output.WriteBool(this.IsNewRecord);
			}
			if (this.IsPkgFull)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.IsPkgFull);
			}
			this.itemDatas_.WriteTo(ref output, LordGymLevelPlayResultNotify._repeated_itemDatas_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D298 RID: 53912 RVA: 0x001F0DFC File Offset: 0x001EEFFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsSuccess)
			{
				num += 2;
			}
			if (this.IsNewRecord)
			{
				num += 2;
			}
			if (this.lordGymPassRecord_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.LordGymPassRecord);
			}
			if (this.FailLoadGymId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FailLoadGymId);
			}
			num += this.itemDatas_.CalculateSize(LordGymLevelPlayResultNotify._repeated_itemDatas_codec);
			if (this.IsPkgFull)
			{
				num += 2;
			}
			if (this.PassTime != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PassTime);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D299 RID: 53913 RVA: 0x001F0EA4 File Offset: 0x001EF0A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LordGymLevelPlayResultNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsSuccess)
			{
				this.IsSuccess = other.IsSuccess;
			}
			if (other.IsNewRecord)
			{
				this.IsNewRecord = other.IsNewRecord;
			}
			if (other.lordGymPassRecord_ != null)
			{
				if (this.lordGymPassRecord_ == null)
				{
					this.LordGymPassRecord = new LordGymPassRecord();
				}
				this.LordGymPassRecord.MergeFrom(other.LordGymPassRecord);
			}
			if (other.FailLoadGymId != 0)
			{
				this.FailLoadGymId = other.FailLoadGymId;
			}
			this.itemDatas_.Add(other.itemDatas_);
			if (other.IsPkgFull)
			{
				this.IsPkgFull = other.IsPkgFull;
			}
			if (other.PassTime != 0)
			{
				this.PassTime = other.PassTime;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D29A RID: 53914 RVA: 0x001F0F6D File Offset: 0x001EF16D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D29B RID: 53915 RVA: 0x001F0F78 File Offset: 0x001EF178
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
				if (num <= 56U)
				{
					if (num == 8U)
					{
						this.FailLoadGymId = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.IsSuccess = input.ReadBool();
						continue;
					}
					if (num == 56U)
					{
						this.PassTime = input.ReadInt32();
						continue;
					}
				}
				else if (num <= 72U)
				{
					if (num == 66U)
					{
						if (this.lordGymPassRecord_ == null)
						{
							this.LordGymPassRecord = new LordGymPassRecord();
						}
						input.ReadMessage(this.LordGymPassRecord);
						continue;
					}
					if (num == 72U)
					{
						this.IsNewRecord = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.IsPkgFull = input.ReadBool();
						continue;
					}
					if (num == 98U)
					{
						this.itemDatas_.AddEntriesFrom(ref input, LordGymLevelPlayResultNotify._repeated_itemDatas_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040058F1 RID: 22769
		private UnknownFieldSet _unknownFields;

		// Token: 0x040058F2 RID: 22770
		public const int IsSuccessFieldNumber = 4;

		// Token: 0x040058F3 RID: 22771
		private bool isSuccess_;

		// Token: 0x040058F4 RID: 22772
		public const int IsNewRecordFieldNumber = 9;

		// Token: 0x040058F5 RID: 22773
		private bool isNewRecord_;

		// Token: 0x040058F6 RID: 22774
		public const int LordGymPassRecordFieldNumber = 8;

		// Token: 0x040058F7 RID: 22775
		private LordGymPassRecord lordGymPassRecord_;

		// Token: 0x040058F8 RID: 22776
		public const int FailLoadGymIdFieldNumber = 1;

		// Token: 0x040058F9 RID: 22777
		private int failLoadGymId_;

		// Token: 0x040058FA RID: 22778
		public const int ItemDatasFieldNumber = 12;

		// Token: 0x040058FB RID: 22779
		private static readonly FieldCodec<ItemData> _repeated_itemDatas_codec = FieldCodec.ForMessage<ItemData>(98U, ItemData.Parser);

		// Token: 0x040058FC RID: 22780
		private readonly RepeatedField<ItemData> itemDatas_ = new RepeatedField<ItemData>();

		// Token: 0x040058FD RID: 22781
		public const int IsPkgFullFieldNumber = 11;

		// Token: 0x040058FE RID: 22782
		private bool isPkgFull_;

		// Token: 0x040058FF RID: 22783
		public const int PassTimeFieldNumber = 7;

		// Token: 0x04005900 RID: 22784
		private int passTime_;
	}
}
