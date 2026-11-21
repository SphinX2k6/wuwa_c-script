using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200067F RID: 1663
	[NetMessage(EMessageId.GachaInfoResponse)]
	public sealed class GachaInfoResponse : IMessage<GachaInfoResponse>, IMessage, IEquatable<GachaInfoResponse>, IDeepCloneable<GachaInfoResponse>, IBufferMessage
	{
		// Token: 0x060098C1 RID: 39105 RVA: 0x00170CDC File Offset: 0x0016EEDC
		[NullableContext(1)]
		public static GachaInfoResponse Create()
		{
			return new GachaInfoResponse();
		}

		// Token: 0x17001E7D RID: 7805
		// (get) Token: 0x060098C2 RID: 39106 RVA: 0x00170CE3 File Offset: 0x0016EEE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001E7E RID: 7806
		// (get) Token: 0x060098C3 RID: 39107 RVA: 0x00170CE6 File Offset: 0x0016EEE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GachaInfoResponse.Descriptor;
			}
		}

		// Token: 0x060098C4 RID: 39108 RVA: 0x00170CED File Offset: 0x0016EEED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaInfoResponse()
		{
		}

		// Token: 0x060098C5 RID: 39109 RVA: 0x00170D0C File Offset: 0x0016EF0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaInfoResponse(GachaInfoResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.gachaInfos_ = other.gachaInfos_.Clone();
			this.dailyTotalLeftTimes_ = other.dailyTotalLeftTimes_;
			this.recordId_ = other.recordId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060098C6 RID: 39110 RVA: 0x00170D65 File Offset: 0x0016EF65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaInfoResponse Clone()
		{
			return new GachaInfoResponse(this);
		}

		// Token: 0x17001E7F RID: 7807
		// (get) Token: 0x060098C7 RID: 39111 RVA: 0x00170D6D File Offset: 0x0016EF6D
		// (set) Token: 0x060098C8 RID: 39112 RVA: 0x00170D75 File Offset: 0x0016EF75
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

		// Token: 0x17001E80 RID: 7808
		// (get) Token: 0x060098C9 RID: 39113 RVA: 0x00170D7E File Offset: 0x0016EF7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GachaInfo> GachaInfos
		{
			get
			{
				return this.gachaInfos_;
			}
		}

		// Token: 0x17001E81 RID: 7809
		// (get) Token: 0x060098CA RID: 39114 RVA: 0x00170D86 File Offset: 0x0016EF86
		// (set) Token: 0x060098CB RID: 39115 RVA: 0x00170D8E File Offset: 0x0016EF8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DailyTotalLeftTimes
		{
			get
			{
				return this.dailyTotalLeftTimes_;
			}
			set
			{
				this.dailyTotalLeftTimes_ = value;
			}
		}

		// Token: 0x17001E82 RID: 7810
		// (get) Token: 0x060098CC RID: 39116 RVA: 0x00170D97 File Offset: 0x0016EF97
		// (set) Token: 0x060098CD RID: 39117 RVA: 0x00170D9F File Offset: 0x0016EF9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string RecordId
		{
			get
			{
				return this.recordId_;
			}
			set
			{
				this.recordId_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x060098CE RID: 39118 RVA: 0x00170DB2 File Offset: 0x0016EFB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GachaInfoResponse);
		}

		// Token: 0x060098CF RID: 39119 RVA: 0x00170DC0 File Offset: 0x0016EFC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GachaInfoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.gachaInfos_.Equals(other.gachaInfos_) && this.DailyTotalLeftTimes == other.DailyTotalLeftTimes && !(this.RecordId != other.RecordId) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060098D0 RID: 39120 RVA: 0x00170E34 File Offset: 0x0016F034
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.gachaInfos_.GetHashCode();
			if (this.DailyTotalLeftTimes != 0)
			{
				num ^= this.DailyTotalLeftTimes.GetHashCode();
			}
			if (this.RecordId.Length != 0)
			{
				num ^= this.RecordId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060098D1 RID: 39121 RVA: 0x00170EBB File Offset: 0x0016F0BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060098D2 RID: 39122 RVA: 0x00170EC8 File Offset: 0x0016F0C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060098D3 RID: 39123 RVA: 0x00170ED4 File Offset: 0x0016F0D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.gachaInfos_.WriteTo(ref output, GachaInfoResponse._repeated_gachaInfos_codec);
			if (this.RecordId.Length != 0)
			{
				output.WriteRawTag(74);
				output.WriteString(this.RecordId);
			}
			if (this.DailyTotalLeftTimes != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.DailyTotalLeftTimes);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060098D4 RID: 39124 RVA: 0x00170F60 File Offset: 0x0016F160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.gachaInfos_.CalculateSize(GachaInfoResponse._repeated_gachaInfos_codec);
			if (this.DailyTotalLeftTimes != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DailyTotalLeftTimes);
			}
			if (this.RecordId.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.RecordId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060098D5 RID: 39125 RVA: 0x00170FE8 File Offset: 0x0016F1E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GachaInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.gachaInfos_.Add(other.gachaInfos_);
			if (other.DailyTotalLeftTimes != 0)
			{
				this.DailyTotalLeftTimes = other.DailyTotalLeftTimes;
			}
			if (other.RecordId.Length != 0)
			{
				this.RecordId = other.RecordId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060098D6 RID: 39126 RVA: 0x00171062 File Offset: 0x0016F262
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060098D7 RID: 39127 RVA: 0x0017106C File Offset: 0x0016F26C
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
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 42U)
					{
						this.gachaInfos_.AddEntriesFrom(ref input, GachaInfoResponse._repeated_gachaInfos_codec);
						continue;
					}
				}
				else
				{
					if (num == 74U)
					{
						this.RecordId = input.ReadString();
						continue;
					}
					if (num == 80U)
					{
						this.DailyTotalLeftTimes = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040048DA RID: 18650
		private UnknownFieldSet _unknownFields;

		// Token: 0x040048DB RID: 18651
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x040048DC RID: 18652
		private ErrorCode errorCode_;

		// Token: 0x040048DD RID: 18653
		public const int GachaInfosFieldNumber = 5;

		// Token: 0x040048DE RID: 18654
		private static readonly FieldCodec<GachaInfo> _repeated_gachaInfos_codec = FieldCodec.ForMessage<GachaInfo>(42U, GachaInfo.Parser);

		// Token: 0x040048DF RID: 18655
		private readonly RepeatedField<GachaInfo> gachaInfos_ = new RepeatedField<GachaInfo>();

		// Token: 0x040048E0 RID: 18656
		public const int DailyTotalLeftTimesFieldNumber = 10;

		// Token: 0x040048E1 RID: 18657
		private int dailyTotalLeftTimes_;

		// Token: 0x040048E2 RID: 18658
		public const int RecordIdFieldNumber = 9;

		// Token: 0x040048E3 RID: 18659
		private string recordId_ = "";
	}
}
