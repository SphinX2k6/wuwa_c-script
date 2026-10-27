using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000693 RID: 1683
	[NetMessage(EMessageId.GachaInfoResponse)]
	public sealed class GachaInfoResponse : IMessage<GachaInfoResponse>, IMessage, IEquatable<GachaInfoResponse>, IDeepCloneable<GachaInfoResponse>, IBufferMessage
	{
		// Token: 0x06009A17 RID: 39447 RVA: 0x00173711 File Offset: 0x00171911
		[NullableContext(1)]
		public static GachaInfoResponse Create()
		{
			return new GachaInfoResponse();
		}

		// Token: 0x17001EC7 RID: 7879
		// (get) Token: 0x06009A18 RID: 39448 RVA: 0x00173718 File Offset: 0x00171918
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001EC8 RID: 7880
		// (get) Token: 0x06009A19 RID: 39449 RVA: 0x0017371B File Offset: 0x0017191B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GachaInfoResponse.Descriptor;
			}
		}

		// Token: 0x06009A1A RID: 39450 RVA: 0x00173722 File Offset: 0x00171922
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaInfoResponse()
		{
		}

		// Token: 0x06009A1B RID: 39451 RVA: 0x00173740 File Offset: 0x00171940
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

		// Token: 0x06009A1C RID: 39452 RVA: 0x00173799 File Offset: 0x00171999
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaInfoResponse Clone()
		{
			return new GachaInfoResponse(this);
		}

		// Token: 0x17001EC9 RID: 7881
		// (get) Token: 0x06009A1D RID: 39453 RVA: 0x001737A1 File Offset: 0x001719A1
		// (set) Token: 0x06009A1E RID: 39454 RVA: 0x001737A9 File Offset: 0x001719A9
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

		// Token: 0x17001ECA RID: 7882
		// (get) Token: 0x06009A1F RID: 39455 RVA: 0x001737B2 File Offset: 0x001719B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<GachaInfo> GachaInfos
		{
			get
			{
				return this.gachaInfos_;
			}
		}

		// Token: 0x17001ECB RID: 7883
		// (get) Token: 0x06009A20 RID: 39456 RVA: 0x001737BA File Offset: 0x001719BA
		// (set) Token: 0x06009A21 RID: 39457 RVA: 0x001737C2 File Offset: 0x001719C2
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

		// Token: 0x17001ECC RID: 7884
		// (get) Token: 0x06009A22 RID: 39458 RVA: 0x001737CB File Offset: 0x001719CB
		// (set) Token: 0x06009A23 RID: 39459 RVA: 0x001737D3 File Offset: 0x001719D3
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

		// Token: 0x06009A24 RID: 39460 RVA: 0x001737E6 File Offset: 0x001719E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GachaInfoResponse);
		}

		// Token: 0x06009A25 RID: 39461 RVA: 0x001737F4 File Offset: 0x001719F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GachaInfoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.gachaInfos_.Equals(other.gachaInfos_) && this.DailyTotalLeftTimes == other.DailyTotalLeftTimes && !(this.RecordId != other.RecordId) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009A26 RID: 39462 RVA: 0x00173868 File Offset: 0x00171A68
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

		// Token: 0x06009A27 RID: 39463 RVA: 0x001738EF File Offset: 0x00171AEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009A28 RID: 39464 RVA: 0x001738FC File Offset: 0x00171AFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009A29 RID: 39465 RVA: 0x00173908 File Offset: 0x00171B08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.gachaInfos_.WriteTo(ref output, GachaInfoResponse._repeated_gachaInfos_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.DailyTotalLeftTimes != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.DailyTotalLeftTimes);
			}
			if (this.RecordId.Length != 0)
			{
				output.WriteRawTag(122);
				output.WriteString(this.RecordId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009A2A RID: 39466 RVA: 0x00173994 File Offset: 0x00171B94
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

		// Token: 0x06009A2B RID: 39467 RVA: 0x00173A1C File Offset: 0x00171C1C
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

		// Token: 0x06009A2C RID: 39468 RVA: 0x00173A96 File Offset: 0x00171C96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009A2D RID: 39469 RVA: 0x00173AA0 File Offset: 0x00171CA0
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
				if (num <= 48U)
				{
					if (num == 10U)
					{
						this.gachaInfos_.AddEntriesFrom(ref input, GachaInfoResponse._repeated_gachaInfos_codec);
						continue;
					}
					if (num == 48U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 112U)
					{
						this.DailyTotalLeftTimes = input.ReadInt32();
						continue;
					}
					if (num == 122U)
					{
						this.RecordId = input.ReadString();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040048E1 RID: 18657
		private UnknownFieldSet _unknownFields;

		// Token: 0x040048E2 RID: 18658
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x040048E3 RID: 18659
		private ErrorCode errorCode_;

		// Token: 0x040048E4 RID: 18660
		public const int GachaInfosFieldNumber = 1;

		// Token: 0x040048E5 RID: 18661
		private static readonly FieldCodec<GachaInfo> _repeated_gachaInfos_codec = FieldCodec.ForMessage<GachaInfo>(10U, GachaInfo.Parser);

		// Token: 0x040048E6 RID: 18662
		private readonly RepeatedField<GachaInfo> gachaInfos_ = new RepeatedField<GachaInfo>();

		// Token: 0x040048E7 RID: 18663
		public const int DailyTotalLeftTimesFieldNumber = 14;

		// Token: 0x040048E8 RID: 18664
		private int dailyTotalLeftTimes_;

		// Token: 0x040048E9 RID: 18665
		public const int RecordIdFieldNumber = 15;

		// Token: 0x040048EA RID: 18666
		private string recordId_ = "";
	}
}
