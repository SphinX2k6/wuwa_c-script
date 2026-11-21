using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006D3 RID: 1747
	[NetMessage(EMessageId.GiantStableValueActivityResponse)]
	public sealed class GiantStableValueActivityResponse : IMessage<GiantStableValueActivityResponse>, IMessage, IEquatable<GiantStableValueActivityResponse>, IDeepCloneable<GiantStableValueActivityResponse>, IBufferMessage
	{
		// Token: 0x06009FDA RID: 40922 RVA: 0x00183815 File Offset: 0x00181A15
		[NullableContext(1)]
		public static GiantStableValueActivityResponse Create()
		{
			return new GiantStableValueActivityResponse();
		}

		// Token: 0x17002018 RID: 8216
		// (get) Token: 0x06009FDB RID: 40923 RVA: 0x0018381C File Offset: 0x00181A1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002019 RID: 8217
		// (get) Token: 0x06009FDC RID: 40924 RVA: 0x0018381F File Offset: 0x00181A1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GiantStableValueActivityResponse.Descriptor;
			}
		}

		// Token: 0x06009FDD RID: 40925 RVA: 0x00183826 File Offset: 0x00181A26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantStableValueActivityResponse()
		{
		}

		// Token: 0x06009FDE RID: 40926 RVA: 0x00183839 File Offset: 0x00181A39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantStableValueActivityResponse(GiantStableValueActivityResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.gotRewardIds_ = other.gotRewardIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009FDF RID: 40927 RVA: 0x0018386F File Offset: 0x00181A6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GiantStableValueActivityResponse Clone()
		{
			return new GiantStableValueActivityResponse(this);
		}

		// Token: 0x1700201A RID: 8218
		// (get) Token: 0x06009FE0 RID: 40928 RVA: 0x00183877 File Offset: 0x00181A77
		// (set) Token: 0x06009FE1 RID: 40929 RVA: 0x0018387F File Offset: 0x00181A7F
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

		// Token: 0x1700201B RID: 8219
		// (get) Token: 0x06009FE2 RID: 40930 RVA: 0x00183888 File Offset: 0x00181A88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> GotRewardIds
		{
			get
			{
				return this.gotRewardIds_;
			}
		}

		// Token: 0x06009FE3 RID: 40931 RVA: 0x00183890 File Offset: 0x00181A90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GiantStableValueActivityResponse);
		}

		// Token: 0x06009FE4 RID: 40932 RVA: 0x001838A0 File Offset: 0x00181AA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GiantStableValueActivityResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.gotRewardIds_.Equals(other.gotRewardIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009FE5 RID: 40933 RVA: 0x001838F0 File Offset: 0x00181AF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.gotRewardIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009FE6 RID: 40934 RVA: 0x00183943 File Offset: 0x00181B43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009FE7 RID: 40935 RVA: 0x00183950 File Offset: 0x00181B50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009FE8 RID: 40936 RVA: 0x0018395C File Offset: 0x00181B5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.gotRewardIds_.WriteTo(ref output, GiantStableValueActivityResponse._repeated_gotRewardIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009FE9 RID: 40937 RVA: 0x001839AC File Offset: 0x00181BAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.gotRewardIds_.CalculateSize(GiantStableValueActivityResponse._repeated_gotRewardIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009FEA RID: 40938 RVA: 0x00183A00 File Offset: 0x00181C00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GiantStableValueActivityResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.gotRewardIds_.Add(other.gotRewardIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009FEB RID: 40939 RVA: 0x00183A4D File Offset: 0x00181C4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009FEC RID: 40940 RVA: 0x00183A58 File Offset: 0x00181C58
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
				if (num != 24U)
				{
					if (num != 72U && num != 74U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.gotRewardIds_.AddEntriesFrom(ref input, GiantStableValueActivityResponse._repeated_gotRewardIds_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004ADF RID: 19167
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004AE0 RID: 19168
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x04004AE1 RID: 19169
		private ErrorCode errorCode_;

		// Token: 0x04004AE2 RID: 19170
		public const int GotRewardIdsFieldNumber = 9;

		// Token: 0x04004AE3 RID: 19171
		private static readonly FieldCodec<int> _repeated_gotRewardIds_codec = FieldCodec.ForInt32(74U);

		// Token: 0x04004AE4 RID: 19172
		private readonly RepeatedField<int> gotRewardIds_ = new RepeatedField<int>();
	}
}
