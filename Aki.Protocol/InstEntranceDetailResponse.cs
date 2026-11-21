using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000810 RID: 2064
	[NetMessage(EMessageId.InstEntranceDetailResponse)]
	public sealed class InstEntranceDetailResponse : IMessage<InstEntranceDetailResponse>, IMessage, IEquatable<InstEntranceDetailResponse>, IDeepCloneable<InstEntranceDetailResponse>, IBufferMessage
	{
		// Token: 0x0600B8D0 RID: 47312 RVA: 0x001B8369 File Offset: 0x001B6569
		[NullableContext(1)]
		public static InstEntranceDetailResponse Create()
		{
			return new InstEntranceDetailResponse();
		}

		// Token: 0x17002537 RID: 9527
		// (get) Token: 0x0600B8D1 RID: 47313 RVA: 0x001B8370 File Offset: 0x001B6570
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002538 RID: 9528
		// (get) Token: 0x0600B8D2 RID: 47314 RVA: 0x001B8373 File Offset: 0x001B6573
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InstEntranceDetailResponse.Descriptor;
			}
		}

		// Token: 0x0600B8D3 RID: 47315 RVA: 0x001B837A File Offset: 0x001B657A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstEntranceDetailResponse()
		{
		}

		// Token: 0x0600B8D4 RID: 47316 RVA: 0x001B8390 File Offset: 0x001B6590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstEntranceDetailResponse(InstEntranceDetailResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.entranceId_ = other.entranceId_;
			this.limitEndTime_ = other.limitEndTime_;
			this.instDetailEntryList_ = other.instDetailEntryList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B8D5 RID: 47317 RVA: 0x001B83E9 File Offset: 0x001B65E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstEntranceDetailResponse Clone()
		{
			return new InstEntranceDetailResponse(this);
		}

		// Token: 0x17002539 RID: 9529
		// (get) Token: 0x0600B8D6 RID: 47318 RVA: 0x001B83F1 File Offset: 0x001B65F1
		// (set) Token: 0x0600B8D7 RID: 47319 RVA: 0x001B83F9 File Offset: 0x001B65F9
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

		// Token: 0x1700253A RID: 9530
		// (get) Token: 0x0600B8D8 RID: 47320 RVA: 0x001B8402 File Offset: 0x001B6602
		// (set) Token: 0x0600B8D9 RID: 47321 RVA: 0x001B840A File Offset: 0x001B660A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EntranceId
		{
			get
			{
				return this.entranceId_;
			}
			set
			{
				this.entranceId_ = value;
			}
		}

		// Token: 0x1700253B RID: 9531
		// (get) Token: 0x0600B8DA RID: 47322 RVA: 0x001B8413 File Offset: 0x001B6613
		// (set) Token: 0x0600B8DB RID: 47323 RVA: 0x001B841B File Offset: 0x001B661B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long LimitEndTime
		{
			get
			{
				return this.limitEndTime_;
			}
			set
			{
				this.limitEndTime_ = value;
			}
		}

		// Token: 0x1700253C RID: 9532
		// (get) Token: 0x0600B8DC RID: 47324 RVA: 0x001B8424 File Offset: 0x001B6624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<InstDetailEntry> InstDetailEntryList
		{
			get
			{
				return this.instDetailEntryList_;
			}
		}

		// Token: 0x0600B8DD RID: 47325 RVA: 0x001B842C File Offset: 0x001B662C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InstEntranceDetailResponse);
		}

		// Token: 0x0600B8DE RID: 47326 RVA: 0x001B843C File Offset: 0x001B663C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InstEntranceDetailResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.EntranceId == other.EntranceId && this.LimitEndTime == other.LimitEndTime && this.instDetailEntryList_.Equals(other.instDetailEntryList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B8DF RID: 47327 RVA: 0x001B84AC File Offset: 0x001B66AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.EntranceId != 0)
			{
				num ^= this.EntranceId.GetHashCode();
			}
			if (this.LimitEndTime != 0L)
			{
				num ^= this.LimitEndTime.GetHashCode();
			}
			num ^= this.instDetailEntryList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B8E0 RID: 47328 RVA: 0x001B8531 File Offset: 0x001B6731
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B8E1 RID: 47329 RVA: 0x001B853E File Offset: 0x001B673E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B8E2 RID: 47330 RVA: 0x001B8548 File Offset: 0x001B6748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.LimitEndTime != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.LimitEndTime);
			}
			if (this.EntranceId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.EntranceId);
			}
			this.instDetailEntryList_.WriteTo(ref output, InstEntranceDetailResponse._repeated_instDetailEntryList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B8E3 RID: 47331 RVA: 0x001B85D0 File Offset: 0x001B67D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.EntranceId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EntranceId);
			}
			if (this.LimitEndTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.LimitEndTime);
			}
			num += this.instDetailEntryList_.CalculateSize(InstEntranceDetailResponse._repeated_instDetailEntryList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B8E4 RID: 47332 RVA: 0x001B8654 File Offset: 0x001B6854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InstEntranceDetailResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.EntranceId != 0)
			{
				this.EntranceId = other.EntranceId;
			}
			if (other.LimitEndTime != 0L)
			{
				this.LimitEndTime = other.LimitEndTime;
			}
			this.instDetailEntryList_.Add(other.instDetailEntryList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B8E5 RID: 47333 RVA: 0x001B86C9 File Offset: 0x001B68C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B8E6 RID: 47334 RVA: 0x001B86D4 File Offset: 0x001B68D4
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
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 16U)
					{
						this.LimitEndTime = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.EntranceId = input.ReadInt32();
						continue;
					}
					if (num == 34U)
					{
						this.instDetailEntryList_.AddEntriesFrom(ref input, InstEntranceDetailResponse._repeated_instDetailEntryList_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040051A8 RID: 20904
		private UnknownFieldSet _unknownFields;

		// Token: 0x040051A9 RID: 20905
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x040051AA RID: 20906
		private ErrorCode errorCode_;

		// Token: 0x040051AB RID: 20907
		public const int EntranceIdFieldNumber = 3;

		// Token: 0x040051AC RID: 20908
		private int entranceId_;

		// Token: 0x040051AD RID: 20909
		public const int LimitEndTimeFieldNumber = 2;

		// Token: 0x040051AE RID: 20910
		private long limitEndTime_;

		// Token: 0x040051AF RID: 20911
		public const int InstDetailEntryListFieldNumber = 4;

		// Token: 0x040051B0 RID: 20912
		private static readonly FieldCodec<InstDetailEntry> _repeated_instDetailEntryList_codec = FieldCodec.ForMessage<InstDetailEntry>(34U, InstDetailEntry.Parser);

		// Token: 0x040051B1 RID: 20913
		private readonly RepeatedField<InstDetailEntry> instDetailEntryList_ = new RepeatedField<InstDetailEntry>();
	}
}
