using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000824 RID: 2084
	[NetMessage(EMessageId.InstEntranceDetailResponse)]
	public sealed class InstEntranceDetailResponse : IMessage<InstEntranceDetailResponse>, IMessage, IEquatable<InstEntranceDetailResponse>, IDeepCloneable<InstEntranceDetailResponse>, IBufferMessage
	{
		// Token: 0x0600BA26 RID: 47654 RVA: 0x001BADA5 File Offset: 0x001B8FA5
		[NullableContext(1)]
		public static InstEntranceDetailResponse Create()
		{
			return new InstEntranceDetailResponse();
		}

		// Token: 0x17002581 RID: 9601
		// (get) Token: 0x0600BA27 RID: 47655 RVA: 0x001BADAC File Offset: 0x001B8FAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002582 RID: 9602
		// (get) Token: 0x0600BA28 RID: 47656 RVA: 0x001BADAF File Offset: 0x001B8FAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InstEntranceDetailResponse.Descriptor;
			}
		}

		// Token: 0x0600BA29 RID: 47657 RVA: 0x001BADB6 File Offset: 0x001B8FB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstEntranceDetailResponse()
		{
		}

		// Token: 0x0600BA2A RID: 47658 RVA: 0x001BADCC File Offset: 0x001B8FCC
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

		// Token: 0x0600BA2B RID: 47659 RVA: 0x001BAE25 File Offset: 0x001B9025
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstEntranceDetailResponse Clone()
		{
			return new InstEntranceDetailResponse(this);
		}

		// Token: 0x17002583 RID: 9603
		// (get) Token: 0x0600BA2C RID: 47660 RVA: 0x001BAE2D File Offset: 0x001B902D
		// (set) Token: 0x0600BA2D RID: 47661 RVA: 0x001BAE35 File Offset: 0x001B9035
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

		// Token: 0x17002584 RID: 9604
		// (get) Token: 0x0600BA2E RID: 47662 RVA: 0x001BAE3E File Offset: 0x001B903E
		// (set) Token: 0x0600BA2F RID: 47663 RVA: 0x001BAE46 File Offset: 0x001B9046
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

		// Token: 0x17002585 RID: 9605
		// (get) Token: 0x0600BA30 RID: 47664 RVA: 0x001BAE4F File Offset: 0x001B904F
		// (set) Token: 0x0600BA31 RID: 47665 RVA: 0x001BAE57 File Offset: 0x001B9057
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

		// Token: 0x17002586 RID: 9606
		// (get) Token: 0x0600BA32 RID: 47666 RVA: 0x001BAE60 File Offset: 0x001B9060
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<InstDetailEntry> InstDetailEntryList
		{
			get
			{
				return this.instDetailEntryList_;
			}
		}

		// Token: 0x0600BA33 RID: 47667 RVA: 0x001BAE68 File Offset: 0x001B9068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InstEntranceDetailResponse);
		}

		// Token: 0x0600BA34 RID: 47668 RVA: 0x001BAE78 File Offset: 0x001B9078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InstEntranceDetailResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.EntranceId == other.EntranceId && this.LimitEndTime == other.LimitEndTime && this.instDetailEntryList_.Equals(other.instDetailEntryList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BA35 RID: 47669 RVA: 0x001BAEE8 File Offset: 0x001B90E8
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

		// Token: 0x0600BA36 RID: 47670 RVA: 0x001BAF6D File Offset: 0x001B916D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BA37 RID: 47671 RVA: 0x001BAF7A File Offset: 0x001B917A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BA38 RID: 47672 RVA: 0x001BAF84 File Offset: 0x001B9184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LimitEndTime != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.LimitEndTime);
			}
			this.instDetailEntryList_.WriteTo(ref output, InstEntranceDetailResponse._repeated_instDetailEntryList_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.EntranceId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.EntranceId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BA39 RID: 47673 RVA: 0x001BB00C File Offset: 0x001B920C
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

		// Token: 0x0600BA3A RID: 47674 RVA: 0x001BB090 File Offset: 0x001B9290
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

		// Token: 0x0600BA3B RID: 47675 RVA: 0x001BB105 File Offset: 0x001B9305
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BA3C RID: 47676 RVA: 0x001BB110 File Offset: 0x001B9310
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
					if (num == 16U)
					{
						this.LimitEndTime = input.ReadInt64();
						continue;
					}
					if (num == 42U)
					{
						this.instDetailEntryList_.AddEntriesFrom(ref input, InstEntranceDetailResponse._repeated_instDetailEntryList_codec);
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 120U)
					{
						this.EntranceId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040051AF RID: 20911
		private UnknownFieldSet _unknownFields;

		// Token: 0x040051B0 RID: 20912
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x040051B1 RID: 20913
		private ErrorCode errorCode_;

		// Token: 0x040051B2 RID: 20914
		public const int EntranceIdFieldNumber = 15;

		// Token: 0x040051B3 RID: 20915
		private int entranceId_;

		// Token: 0x040051B4 RID: 20916
		public const int LimitEndTimeFieldNumber = 2;

		// Token: 0x040051B5 RID: 20917
		private long limitEndTime_;

		// Token: 0x040051B6 RID: 20918
		public const int InstDetailEntryListFieldNumber = 5;

		// Token: 0x040051B7 RID: 20919
		private static readonly FieldCodec<InstDetailEntry> _repeated_instDetailEntryList_codec = FieldCodec.ForMessage<InstDetailEntry>(42U, InstDetailEntry.Parser);

		// Token: 0x040051B8 RID: 20920
		private readonly RepeatedField<InstDetailEntry> instDetailEntryList_ = new RepeatedField<InstDetailEntry>();
	}
}
