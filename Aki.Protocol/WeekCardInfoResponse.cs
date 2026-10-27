using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001507 RID: 5383
	[NetMessage(EMessageId.WeekCardInfoResponse)]
	public sealed class WeekCardInfoResponse : IMessage<WeekCardInfoResponse>, IMessage, IEquatable<WeekCardInfoResponse>, IDeepCloneable<WeekCardInfoResponse>, IBufferMessage
	{
		// Token: 0x0601C73E RID: 116542 RVA: 0x0041C120 File Offset: 0x0041A320
		[NullableContext(1)]
		public static WeekCardInfoResponse Create()
		{
			return new WeekCardInfoResponse();
		}

		// Token: 0x17005FEB RID: 24555
		// (get) Token: 0x0601C73F RID: 116543 RVA: 0x0041C127 File Offset: 0x0041A327
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005FEC RID: 24556
		// (get) Token: 0x0601C740 RID: 116544 RVA: 0x0041C12A File Offset: 0x0041A32A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WeekCardInfoResponse.Descriptor;
			}
		}

		// Token: 0x0601C741 RID: 116545 RVA: 0x0041C131 File Offset: 0x0041A331
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeekCardInfoResponse()
		{
		}

		// Token: 0x0601C742 RID: 116546 RVA: 0x0041C144 File Offset: 0x0041A344
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeekCardInfoResponse(WeekCardInfoResponse other) : this()
		{
			this.infos_ = ((other.infos_ != null) ? other.infos_.Clone() : null);
			this.errorCode_ = other.errorCode_;
			this.weekCardInfos_ = other.weekCardInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C743 RID: 116547 RVA: 0x0041C1A1 File Offset: 0x0041A3A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeekCardInfoResponse Clone()
		{
			return new WeekCardInfoResponse(this);
		}

		// Token: 0x17005FED RID: 24557
		// (get) Token: 0x0601C744 RID: 116548 RVA: 0x0041C1A9 File Offset: 0x0041A3A9
		// (set) Token: 0x0601C745 RID: 116549 RVA: 0x0041C1B1 File Offset: 0x0041A3B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeekCardInfo Infos
		{
			get
			{
				return this.infos_;
			}
			set
			{
				this.infos_ = value;
			}
		}

		// Token: 0x17005FEE RID: 24558
		// (get) Token: 0x0601C746 RID: 116550 RVA: 0x0041C1BA File Offset: 0x0041A3BA
		// (set) Token: 0x0601C747 RID: 116551 RVA: 0x0041C1C2 File Offset: 0x0041A3C2
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

		// Token: 0x17005FEF RID: 24559
		// (get) Token: 0x0601C748 RID: 116552 RVA: 0x0041C1CB File Offset: 0x0041A3CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<WeekCardInfo> WeekCardInfos
		{
			get
			{
				return this.weekCardInfos_;
			}
		}

		// Token: 0x0601C749 RID: 116553 RVA: 0x0041C1D3 File Offset: 0x0041A3D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WeekCardInfoResponse);
		}

		// Token: 0x0601C74A RID: 116554 RVA: 0x0041C1E4 File Offset: 0x0041A3E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WeekCardInfoResponse other)
		{
			return other != null && (other == this || (object.Equals(this.Infos, other.Infos) && this.ErrorCode == other.ErrorCode && this.weekCardInfos_.Equals(other.weekCardInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C74B RID: 116555 RVA: 0x0041C248 File Offset: 0x0041A448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.infos_ != null)
			{
				num ^= this.Infos.GetHashCode();
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.weekCardInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C74C RID: 116556 RVA: 0x0041C2B1 File Offset: 0x0041A4B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C74D RID: 116557 RVA: 0x0041C2BE File Offset: 0x0041A4BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C74E RID: 116558 RVA: 0x0041C2C8 File Offset: 0x0041A4C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.weekCardInfos_.WriteTo(ref output, WeekCardInfoResponse._repeated_weekCardInfos_codec);
			if (this.infos_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.Infos);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C74F RID: 116559 RVA: 0x0041C334 File Offset: 0x0041A534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.infos_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Infos);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.weekCardInfos_.CalculateSize(WeekCardInfoResponse._repeated_weekCardInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C750 RID: 116560 RVA: 0x0041C3A0 File Offset: 0x0041A5A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WeekCardInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.infos_ != null)
			{
				if (this.infos_ == null)
				{
					this.Infos = new WeekCardInfo();
				}
				this.Infos.MergeFrom(other.Infos);
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.weekCardInfos_.Add(other.weekCardInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C751 RID: 116561 RVA: 0x0041C419 File Offset: 0x0041A619
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C752 RID: 116562 RVA: 0x0041C424 File Offset: 0x0041A624
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
				if (num != 32U)
				{
					if (num != 42U)
					{
						if (num != 114U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.infos_ == null)
							{
								this.Infos = new WeekCardInfo();
							}
							input.ReadMessage(this.Infos);
						}
					}
					else
					{
						this.weekCardInfos_.AddEntriesFrom(ref input, WeekCardInfoResponse._repeated_weekCardInfos_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400A2E2 RID: 41698
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A2E3 RID: 41699
		public const int InfosFieldNumber = 14;

		// Token: 0x0400A2E4 RID: 41700
		private WeekCardInfo infos_;

		// Token: 0x0400A2E5 RID: 41701
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x0400A2E6 RID: 41702
		private ErrorCode errorCode_;

		// Token: 0x0400A2E7 RID: 41703
		public const int WeekCardInfosFieldNumber = 5;

		// Token: 0x0400A2E8 RID: 41704
		private static readonly FieldCodec<WeekCardInfo> _repeated_weekCardInfos_codec = FieldCodec.ForMessage<WeekCardInfo>(42U, WeekCardInfo.Parser);

		// Token: 0x0400A2E9 RID: 41705
		private readonly RepeatedField<WeekCardInfo> weekCardInfos_ = new RepeatedField<WeekCardInfo>();
	}
}
