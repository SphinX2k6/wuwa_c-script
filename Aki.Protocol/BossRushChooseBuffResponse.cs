using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001D3 RID: 467
	[NetMessage(EMessageId.BossRushChooseBuffResponse)]
	public sealed class BossRushChooseBuffResponse : IMessage<BossRushChooseBuffResponse>, IMessage, IEquatable<BossRushChooseBuffResponse>, IDeepCloneable<BossRushChooseBuffResponse>, IBufferMessage
	{
		// Token: 0x0600350A RID: 13578 RVA: 0x0008569A File Offset: 0x0008389A
		[NullableContext(1)]
		public static BossRushChooseBuffResponse Create()
		{
			return new BossRushChooseBuffResponse();
		}

		// Token: 0x1700086D RID: 2157
		// (get) Token: 0x0600350B RID: 13579 RVA: 0x000856A1 File Offset: 0x000838A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700086E RID: 2158
		// (get) Token: 0x0600350C RID: 13580 RVA: 0x000856A4 File Offset: 0x000838A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BossRushChooseBuffResponse.Descriptor;
			}
		}

		// Token: 0x0600350D RID: 13581 RVA: 0x000856AB File Offset: 0x000838AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushChooseBuffResponse()
		{
		}

		// Token: 0x0600350E RID: 13582 RVA: 0x000856BE File Offset: 0x000838BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushChooseBuffResponse(BossRushChooseBuffResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.buffIds_ = other.buffIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600350F RID: 13583 RVA: 0x000856F4 File Offset: 0x000838F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushChooseBuffResponse Clone()
		{
			return new BossRushChooseBuffResponse(this);
		}

		// Token: 0x1700086F RID: 2159
		// (get) Token: 0x06003510 RID: 13584 RVA: 0x000856FC File Offset: 0x000838FC
		// (set) Token: 0x06003511 RID: 13585 RVA: 0x00085704 File Offset: 0x00083904
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

		// Token: 0x17000870 RID: 2160
		// (get) Token: 0x06003512 RID: 13586 RVA: 0x0008570D File Offset: 0x0008390D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> BuffIds
		{
			get
			{
				return this.buffIds_;
			}
		}

		// Token: 0x06003513 RID: 13587 RVA: 0x00085715 File Offset: 0x00083915
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BossRushChooseBuffResponse);
		}

		// Token: 0x06003514 RID: 13588 RVA: 0x00085724 File Offset: 0x00083924
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BossRushChooseBuffResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.buffIds_.Equals(other.buffIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003515 RID: 13589 RVA: 0x00085774 File Offset: 0x00083974
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.buffIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003516 RID: 13590 RVA: 0x000857C7 File Offset: 0x000839C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003517 RID: 13591 RVA: 0x000857D4 File Offset: 0x000839D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003518 RID: 13592 RVA: 0x000857E0 File Offset: 0x000839E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.buffIds_.WriteTo(ref output, BossRushChooseBuffResponse._repeated_buffIds_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003519 RID: 13593 RVA: 0x00085830 File Offset: 0x00083A30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.buffIds_.CalculateSize(BossRushChooseBuffResponse._repeated_buffIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600351A RID: 13594 RVA: 0x00085884 File Offset: 0x00083A84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BossRushChooseBuffResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.buffIds_.Add(other.buffIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600351B RID: 13595 RVA: 0x000858D1 File Offset: 0x00083AD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600351C RID: 13596 RVA: 0x000858DC File Offset: 0x00083ADC
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
				if (num != 32U && num != 34U)
				{
					if (num != 56U)
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
					this.buffIds_.AddEntriesFrom(ref input, BossRushChooseBuffResponse._repeated_buffIds_codec);
				}
			}
		}

		// Token: 0x04002A2C RID: 10796
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002A2D RID: 10797
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x04002A2E RID: 10798
		private ErrorCode errorCode_;

		// Token: 0x04002A2F RID: 10799
		public const int BuffIdsFieldNumber = 4;

		// Token: 0x04002A30 RID: 10800
		private static readonly FieldCodec<int> _repeated_buffIds_codec = FieldCodec.ForInt32(34U);

		// Token: 0x04002A31 RID: 10801
		private readonly RepeatedField<int> buffIds_ = new RepeatedField<int>();
	}
}
