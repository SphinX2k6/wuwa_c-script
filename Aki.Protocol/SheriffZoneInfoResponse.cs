using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001223 RID: 4643
	[NetMessage(EMessageId.SheriffZoneInfoResponse)]
	public sealed class SheriffZoneInfoResponse : IMessage<SheriffZoneInfoResponse>, IMessage, IEquatable<SheriffZoneInfoResponse>, IDeepCloneable<SheriffZoneInfoResponse>, IBufferMessage
	{
		// Token: 0x06018CB8 RID: 101560 RVA: 0x0039D2DD File Offset: 0x0039B4DD
		[NullableContext(1)]
		public static SheriffZoneInfoResponse Create()
		{
			return new SheriffZoneInfoResponse();
		}

		// Token: 0x170053BB RID: 21435
		// (get) Token: 0x06018CB9 RID: 101561 RVA: 0x0039D2E4 File Offset: 0x0039B4E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170053BC RID: 21436
		// (get) Token: 0x06018CBA RID: 101562 RVA: 0x0039D2E7 File Offset: 0x0039B4E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SheriffZoneInfoResponse.Descriptor;
			}
		}

		// Token: 0x06018CBB RID: 101563 RVA: 0x0039D2EE File Offset: 0x0039B4EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SheriffZoneInfoResponse()
		{
		}

		// Token: 0x06018CBC RID: 101564 RVA: 0x0039D301 File Offset: 0x0039B501
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SheriffZoneInfoResponse(SheriffZoneInfoResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.zoneInfos_ = other.zoneInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018CBD RID: 101565 RVA: 0x0039D337 File Offset: 0x0039B537
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SheriffZoneInfoResponse Clone()
		{
			return new SheriffZoneInfoResponse(this);
		}

		// Token: 0x170053BD RID: 21437
		// (get) Token: 0x06018CBE RID: 101566 RVA: 0x0039D33F File Offset: 0x0039B53F
		// (set) Token: 0x06018CBF RID: 101567 RVA: 0x0039D347 File Offset: 0x0039B547
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

		// Token: 0x170053BE RID: 21438
		// (get) Token: 0x06018CC0 RID: 101568 RVA: 0x0039D350 File Offset: 0x0039B550
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SheriffZoneInfo> ZoneInfos
		{
			get
			{
				return this.zoneInfos_;
			}
		}

		// Token: 0x06018CC1 RID: 101569 RVA: 0x0039D358 File Offset: 0x0039B558
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SheriffZoneInfoResponse);
		}

		// Token: 0x06018CC2 RID: 101570 RVA: 0x0039D368 File Offset: 0x0039B568
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SheriffZoneInfoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.zoneInfos_.Equals(other.zoneInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018CC3 RID: 101571 RVA: 0x0039D3B8 File Offset: 0x0039B5B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.zoneInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018CC4 RID: 101572 RVA: 0x0039D40B File Offset: 0x0039B60B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018CC5 RID: 101573 RVA: 0x0039D418 File Offset: 0x0039B618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018CC6 RID: 101574 RVA: 0x0039D424 File Offset: 0x0039B624
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.zoneInfos_.WriteTo(ref output, SheriffZoneInfoResponse._repeated_zoneInfos_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018CC7 RID: 101575 RVA: 0x0039D474 File Offset: 0x0039B674
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.zoneInfos_.CalculateSize(SheriffZoneInfoResponse._repeated_zoneInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018CC8 RID: 101576 RVA: 0x0039D4C8 File Offset: 0x0039B6C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SheriffZoneInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.zoneInfos_.Add(other.zoneInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018CC9 RID: 101577 RVA: 0x0039D515 File Offset: 0x0039B715
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018CCA RID: 101578 RVA: 0x0039D520 File Offset: 0x0039B720
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
				if (num != 50U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.zoneInfos_.AddEntriesFrom(ref input, SheriffZoneInfoResponse._repeated_zoneInfos_codec);
				}
			}
		}

		// Token: 0x0400931F RID: 37663
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009320 RID: 37664
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x04009321 RID: 37665
		private ErrorCode errorCode_;

		// Token: 0x04009322 RID: 37666
		public const int ZoneInfosFieldNumber = 6;

		// Token: 0x04009323 RID: 37667
		private static readonly FieldCodec<SheriffZoneInfo> _repeated_zoneInfos_codec = FieldCodec.ForMessage<SheriffZoneInfo>(50U, SheriffZoneInfo.Parser);

		// Token: 0x04009324 RID: 37668
		private readonly RepeatedField<SheriffZoneInfo> zoneInfos_ = new RepeatedField<SheriffZoneInfo>();
	}
}
