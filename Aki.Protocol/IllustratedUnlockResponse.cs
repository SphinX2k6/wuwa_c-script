using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007CE RID: 1998
	[NetMessage(EMessageId.IllustratedUnlockResponse)]
	public sealed class IllustratedUnlockResponse : IMessage<IllustratedUnlockResponse>, IMessage, IEquatable<IllustratedUnlockResponse>, IDeepCloneable<IllustratedUnlockResponse>, IBufferMessage
	{
		// Token: 0x0600B3A6 RID: 45990 RVA: 0x001ADE88 File Offset: 0x001AC088
		[NullableContext(1)]
		public static IllustratedUnlockResponse Create()
		{
			return new IllustratedUnlockResponse();
		}

		// Token: 0x17002441 RID: 9281
		// (get) Token: 0x0600B3A7 RID: 45991 RVA: 0x001ADE8F File Offset: 0x001AC08F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002442 RID: 9282
		// (get) Token: 0x0600B3A8 RID: 45992 RVA: 0x001ADE92 File Offset: 0x001AC092
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return IllustratedUnlockResponse.Descriptor;
			}
		}

		// Token: 0x0600B3A9 RID: 45993 RVA: 0x001ADE99 File Offset: 0x001AC099
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IllustratedUnlockResponse()
		{
		}

		// Token: 0x0600B3AA RID: 45994 RVA: 0x001ADEAC File Offset: 0x001AC0AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IllustratedUnlockResponse(IllustratedUnlockResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.errorParams_ = other.errorParams_.Clone();
			this.entry_ = ((other.entry_ != null) ? other.entry_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B3AB RID: 45995 RVA: 0x001ADF09 File Offset: 0x001AC109
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IllustratedUnlockResponse Clone()
		{
			return new IllustratedUnlockResponse(this);
		}

		// Token: 0x17002443 RID: 9283
		// (get) Token: 0x0600B3AC RID: 45996 RVA: 0x001ADF11 File Offset: 0x001AC111
		// (set) Token: 0x0600B3AD RID: 45997 RVA: 0x001ADF19 File Offset: 0x001AC119
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

		// Token: 0x17002444 RID: 9284
		// (get) Token: 0x0600B3AE RID: 45998 RVA: 0x001ADF22 File Offset: 0x001AC122
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> ErrorParams
		{
			get
			{
				return this.errorParams_;
			}
		}

		// Token: 0x17002445 RID: 9285
		// (get) Token: 0x0600B3AF RID: 45999 RVA: 0x001ADF2A File Offset: 0x001AC12A
		// (set) Token: 0x0600B3B0 RID: 46000 RVA: 0x001ADF32 File Offset: 0x001AC132
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public IllustratedEntry Entry
		{
			get
			{
				return this.entry_;
			}
			set
			{
				this.entry_ = value;
			}
		}

		// Token: 0x0600B3B1 RID: 46001 RVA: 0x001ADF3B File Offset: 0x001AC13B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as IllustratedUnlockResponse);
		}

		// Token: 0x0600B3B2 RID: 46002 RVA: 0x001ADF4C File Offset: 0x001AC14C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(IllustratedUnlockResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.errorParams_.Equals(other.errorParams_) && object.Equals(this.Entry, other.Entry) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B3B3 RID: 46003 RVA: 0x001ADFB0 File Offset: 0x001AC1B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.errorParams_.GetHashCode();
			if (this.entry_ != null)
			{
				num ^= this.Entry.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B3B4 RID: 46004 RVA: 0x001AE019 File Offset: 0x001AC219
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B3B5 RID: 46005 RVA: 0x001AE026 File Offset: 0x001AC226
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B3B6 RID: 46006 RVA: 0x001AE030 File Offset: 0x001AC230
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.entry_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.Entry);
			}
			this.errorParams_.WriteTo(ref output, IllustratedUnlockResponse._repeated_errorParams_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B3B7 RID: 46007 RVA: 0x001AE09C File Offset: 0x001AC29C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.errorParams_.CalculateSize(IllustratedUnlockResponse._repeated_errorParams_codec);
			if (this.entry_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Entry);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B3B8 RID: 46008 RVA: 0x001AE108 File Offset: 0x001AC308
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(IllustratedUnlockResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.errorParams_.Add(other.errorParams_);
			if (other.entry_ != null)
			{
				if (this.entry_ == null)
				{
					this.Entry = new IllustratedEntry();
				}
				this.Entry.MergeFrom(other.Entry);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B3B9 RID: 46009 RVA: 0x001AE181 File Offset: 0x001AC381
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B3BA RID: 46010 RVA: 0x001AE18C File Offset: 0x001AC38C
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
				if (num != 26U)
				{
					if (num != 58U)
					{
						if (num != 120U)
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
						this.errorParams_.AddEntriesFrom(ref input, IllustratedUnlockResponse._repeated_errorParams_codec);
					}
				}
				else
				{
					if (this.entry_ == null)
					{
						this.Entry = new IllustratedEntry();
					}
					input.ReadMessage(this.Entry);
				}
			}
		}

		// Token: 0x0400501C RID: 20508
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400501D RID: 20509
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x0400501E RID: 20510
		private ErrorCode errorCode_;

		// Token: 0x0400501F RID: 20511
		public const int ErrorParamsFieldNumber = 7;

		// Token: 0x04005020 RID: 20512
		private static readonly FieldCodec<string> _repeated_errorParams_codec = FieldCodec.ForString(58U);

		// Token: 0x04005021 RID: 20513
		private readonly RepeatedField<string> errorParams_ = new RepeatedField<string>();

		// Token: 0x04005022 RID: 20514
		public const int EntryFieldNumber = 3;

		// Token: 0x04005023 RID: 20515
		private IllustratedEntry entry_;
	}
}
