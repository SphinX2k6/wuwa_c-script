using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001D7 RID: 471
	[NetMessage(EMessageId.BossRushChooseBuffResponse)]
	public sealed class BossRushChooseBuffResponse : IMessage<BossRushChooseBuffResponse>, IMessage, IEquatable<BossRushChooseBuffResponse>, IDeepCloneable<BossRushChooseBuffResponse>, IBufferMessage
	{
		// Token: 0x06003597 RID: 13719 RVA: 0x00086E0E File Offset: 0x0008500E
		[NullableContext(1)]
		public static BossRushChooseBuffResponse Create()
		{
			return new BossRushChooseBuffResponse();
		}

		// Token: 0x17000886 RID: 2182
		// (get) Token: 0x06003598 RID: 13720 RVA: 0x00086E15 File Offset: 0x00085015
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000887 RID: 2183
		// (get) Token: 0x06003599 RID: 13721 RVA: 0x00086E18 File Offset: 0x00085018
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BossRushChooseBuffResponse.Descriptor;
			}
		}

		// Token: 0x0600359A RID: 13722 RVA: 0x00086E1F File Offset: 0x0008501F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushChooseBuffResponse()
		{
		}

		// Token: 0x0600359B RID: 13723 RVA: 0x00086E32 File Offset: 0x00085032
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushChooseBuffResponse(BossRushChooseBuffResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.buffIds_ = other.buffIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600359C RID: 13724 RVA: 0x00086E68 File Offset: 0x00085068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BossRushChooseBuffResponse Clone()
		{
			return new BossRushChooseBuffResponse(this);
		}

		// Token: 0x17000888 RID: 2184
		// (get) Token: 0x0600359D RID: 13725 RVA: 0x00086E70 File Offset: 0x00085070
		// (set) Token: 0x0600359E RID: 13726 RVA: 0x00086E78 File Offset: 0x00085078
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

		// Token: 0x17000889 RID: 2185
		// (get) Token: 0x0600359F RID: 13727 RVA: 0x00086E81 File Offset: 0x00085081
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> BuffIds
		{
			get
			{
				return this.buffIds_;
			}
		}

		// Token: 0x060035A0 RID: 13728 RVA: 0x00086E89 File Offset: 0x00085089
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BossRushChooseBuffResponse);
		}

		// Token: 0x060035A1 RID: 13729 RVA: 0x00086E98 File Offset: 0x00085098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BossRushChooseBuffResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.buffIds_.Equals(other.buffIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060035A2 RID: 13730 RVA: 0x00086EE8 File Offset: 0x000850E8
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

		// Token: 0x060035A3 RID: 13731 RVA: 0x00086F3B File Offset: 0x0008513B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060035A4 RID: 13732 RVA: 0x00086F48 File Offset: 0x00085148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060035A5 RID: 13733 RVA: 0x00086F54 File Offset: 0x00085154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.buffIds_.WriteTo(ref output, BossRushChooseBuffResponse._repeated_buffIds_codec);
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

		// Token: 0x060035A6 RID: 13734 RVA: 0x00086FA4 File Offset: 0x000851A4
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

		// Token: 0x060035A7 RID: 13735 RVA: 0x00086FF8 File Offset: 0x000851F8
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

		// Token: 0x060035A8 RID: 13736 RVA: 0x00087045 File Offset: 0x00085245
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060035A9 RID: 13737 RVA: 0x00087050 File Offset: 0x00085250
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
				if (num != 48U && num != 50U)
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
					this.buffIds_.AddEntriesFrom(ref input, BossRushChooseBuffResponse._repeated_buffIds_codec);
				}
			}
		}

		// Token: 0x04002AA7 RID: 10919
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002AA8 RID: 10920
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x04002AA9 RID: 10921
		private ErrorCode errorCode_;

		// Token: 0x04002AAA RID: 10922
		public const int BuffIdsFieldNumber = 6;

		// Token: 0x04002AAB RID: 10923
		private static readonly FieldCodec<int> _repeated_buffIds_codec = FieldCodec.ForInt32(50U);

		// Token: 0x04002AAC RID: 10924
		private readonly RepeatedField<int> buffIds_ = new RepeatedField<int>();
	}
}
