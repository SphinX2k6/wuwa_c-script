using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000962 RID: 2402
	[NetMessage(EMessageId.LordGymLevelPlayResultNotify)]
	public sealed class LordGymLevelPlayResultNotify : IMessage<LordGymLevelPlayResultNotify>, IMessage, IEquatable<LordGymLevelPlayResultNotify>, IDeepCloneable<LordGymLevelPlayResultNotify>, IBufferMessage
	{
		// Token: 0x0600D399 RID: 54169 RVA: 0x001F2C48 File Offset: 0x001F0E48
		[NullableContext(1)]
		public static LordGymLevelPlayResultNotify Create()
		{
			return new LordGymLevelPlayResultNotify();
		}

		// Token: 0x17002ADA RID: 10970
		// (get) Token: 0x0600D39A RID: 54170 RVA: 0x001F2C4F File Offset: 0x001F0E4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002ADB RID: 10971
		// (get) Token: 0x0600D39B RID: 54171 RVA: 0x001F2C52 File Offset: 0x001F0E52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LordGymLevelPlayResultNotify.Descriptor;
			}
		}

		// Token: 0x0600D39C RID: 54172 RVA: 0x001F2C59 File Offset: 0x001F0E59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LordGymLevelPlayResultNotify()
		{
		}

		// Token: 0x0600D39D RID: 54173 RVA: 0x001F2C6C File Offset: 0x001F0E6C
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

		// Token: 0x0600D39E RID: 54174 RVA: 0x001F2CF9 File Offset: 0x001F0EF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LordGymLevelPlayResultNotify Clone()
		{
			return new LordGymLevelPlayResultNotify(this);
		}

		// Token: 0x17002ADC RID: 10972
		// (get) Token: 0x0600D39F RID: 54175 RVA: 0x001F2D01 File Offset: 0x001F0F01
		// (set) Token: 0x0600D3A0 RID: 54176 RVA: 0x001F2D09 File Offset: 0x001F0F09
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

		// Token: 0x17002ADD RID: 10973
		// (get) Token: 0x0600D3A1 RID: 54177 RVA: 0x001F2D12 File Offset: 0x001F0F12
		// (set) Token: 0x0600D3A2 RID: 54178 RVA: 0x001F2D1A File Offset: 0x001F0F1A
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

		// Token: 0x17002ADE RID: 10974
		// (get) Token: 0x0600D3A3 RID: 54179 RVA: 0x001F2D23 File Offset: 0x001F0F23
		// (set) Token: 0x0600D3A4 RID: 54180 RVA: 0x001F2D2B File Offset: 0x001F0F2B
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

		// Token: 0x17002ADF RID: 10975
		// (get) Token: 0x0600D3A5 RID: 54181 RVA: 0x001F2D34 File Offset: 0x001F0F34
		// (set) Token: 0x0600D3A6 RID: 54182 RVA: 0x001F2D3C File Offset: 0x001F0F3C
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

		// Token: 0x17002AE0 RID: 10976
		// (get) Token: 0x0600D3A7 RID: 54183 RVA: 0x001F2D45 File Offset: 0x001F0F45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ItemData> ItemDatas
		{
			get
			{
				return this.itemDatas_;
			}
		}

		// Token: 0x17002AE1 RID: 10977
		// (get) Token: 0x0600D3A8 RID: 54184 RVA: 0x001F2D4D File Offset: 0x001F0F4D
		// (set) Token: 0x0600D3A9 RID: 54185 RVA: 0x001F2D55 File Offset: 0x001F0F55
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

		// Token: 0x17002AE2 RID: 10978
		// (get) Token: 0x0600D3AA RID: 54186 RVA: 0x001F2D5E File Offset: 0x001F0F5E
		// (set) Token: 0x0600D3AB RID: 54187 RVA: 0x001F2D66 File Offset: 0x001F0F66
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

		// Token: 0x0600D3AC RID: 54188 RVA: 0x001F2D6F File Offset: 0x001F0F6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LordGymLevelPlayResultNotify);
		}

		// Token: 0x0600D3AD RID: 54189 RVA: 0x001F2D80 File Offset: 0x001F0F80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LordGymLevelPlayResultNotify other)
		{
			return other != null && (other == this || (this.IsSuccess == other.IsSuccess && this.IsNewRecord == other.IsNewRecord && object.Equals(this.LordGymPassRecord, other.LordGymPassRecord) && this.FailLoadGymId == other.FailLoadGymId && this.itemDatas_.Equals(other.itemDatas_) && this.IsPkgFull == other.IsPkgFull && this.PassTime == other.PassTime && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D3AE RID: 54190 RVA: 0x001F2E24 File Offset: 0x001F1024
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

		// Token: 0x0600D3AF RID: 54191 RVA: 0x001F2EEB File Offset: 0x001F10EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D3B0 RID: 54192 RVA: 0x001F2EF8 File Offset: 0x001F10F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D3B1 RID: 54193 RVA: 0x001F2F04 File Offset: 0x001F1104
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FailLoadGymId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.FailLoadGymId);
			}
			this.itemDatas_.WriteTo(ref output, LordGymLevelPlayResultNotify._repeated_itemDatas_codec);
			if (this.lordGymPassRecord_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.LordGymPassRecord);
			}
			if (this.IsPkgFull)
			{
				output.WriteRawTag(80);
				output.WriteBool(this.IsPkgFull);
			}
			if (this.IsSuccess)
			{
				output.WriteRawTag(96);
				output.WriteBool(this.IsSuccess);
			}
			if (this.IsNewRecord)
			{
				output.WriteRawTag(104);
				output.WriteBool(this.IsNewRecord);
			}
			if (this.PassTime != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.PassTime);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D3B2 RID: 54194 RVA: 0x001F2FE0 File Offset: 0x001F11E0
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

		// Token: 0x0600D3B3 RID: 54195 RVA: 0x001F3088 File Offset: 0x001F1288
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

		// Token: 0x0600D3B4 RID: 54196 RVA: 0x001F3151 File Offset: 0x001F1351
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D3B5 RID: 54197 RVA: 0x001F315C File Offset: 0x001F135C
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
					if (num == 8U)
					{
						this.FailLoadGymId = input.ReadInt32();
						continue;
					}
					if (num == 26U)
					{
						this.itemDatas_.AddEntriesFrom(ref input, LordGymLevelPlayResultNotify._repeated_itemDatas_codec);
						continue;
					}
					if (num == 42U)
					{
						if (this.lordGymPassRecord_ == null)
						{
							this.LordGymPassRecord = new LordGymPassRecord();
						}
						input.ReadMessage(this.LordGymPassRecord);
						continue;
					}
				}
				else if (num <= 96U)
				{
					if (num == 80U)
					{
						this.IsPkgFull = input.ReadBool();
						continue;
					}
					if (num == 96U)
					{
						this.IsSuccess = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 104U)
					{
						this.IsNewRecord = input.ReadBool();
						continue;
					}
					if (num == 112U)
					{
						this.PassTime = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040058E8 RID: 22760
		private UnknownFieldSet _unknownFields;

		// Token: 0x040058E9 RID: 22761
		public const int IsSuccessFieldNumber = 12;

		// Token: 0x040058EA RID: 22762
		private bool isSuccess_;

		// Token: 0x040058EB RID: 22763
		public const int IsNewRecordFieldNumber = 13;

		// Token: 0x040058EC RID: 22764
		private bool isNewRecord_;

		// Token: 0x040058ED RID: 22765
		public const int LordGymPassRecordFieldNumber = 5;

		// Token: 0x040058EE RID: 22766
		private LordGymPassRecord lordGymPassRecord_;

		// Token: 0x040058EF RID: 22767
		public const int FailLoadGymIdFieldNumber = 1;

		// Token: 0x040058F0 RID: 22768
		private int failLoadGymId_;

		// Token: 0x040058F1 RID: 22769
		public const int ItemDatasFieldNumber = 3;

		// Token: 0x040058F2 RID: 22770
		private static readonly FieldCodec<ItemData> _repeated_itemDatas_codec = FieldCodec.ForMessage<ItemData>(26U, ItemData.Parser);

		// Token: 0x040058F3 RID: 22771
		private readonly RepeatedField<ItemData> itemDatas_ = new RepeatedField<ItemData>();

		// Token: 0x040058F4 RID: 22772
		public const int IsPkgFullFieldNumber = 10;

		// Token: 0x040058F5 RID: 22773
		private bool isPkgFull_;

		// Token: 0x040058F6 RID: 22774
		public const int PassTimeFieldNumber = 14;

		// Token: 0x040058F7 RID: 22775
		private int passTime_;
	}
}
