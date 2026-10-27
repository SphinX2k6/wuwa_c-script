using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000ECC RID: 3788
	[NetMessage(EMessageId.ReceivedSilentFirstAwardResponse)]
	public sealed class ReceivedSilentFirstAwardResponse : IMessage<ReceivedSilentFirstAwardResponse>, IMessage, IEquatable<ReceivedSilentFirstAwardResponse>, IDeepCloneable<ReceivedSilentFirstAwardResponse>, IBufferMessage
	{
		// Token: 0x060144E9 RID: 83177 RVA: 0x002F3709 File Offset: 0x002F1909
		[NullableContext(1)]
		public static ReceivedSilentFirstAwardResponse Create()
		{
			return new ReceivedSilentFirstAwardResponse();
		}

		// Token: 0x1700437F RID: 17279
		// (get) Token: 0x060144EA RID: 83178 RVA: 0x002F3710 File Offset: 0x002F1910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004380 RID: 17280
		// (get) Token: 0x060144EB RID: 83179 RVA: 0x002F3713 File Offset: 0x002F1913
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ReceivedSilentFirstAwardResponse.Descriptor;
			}
		}

		// Token: 0x060144EC RID: 83180 RVA: 0x002F371A File Offset: 0x002F191A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReceivedSilentFirstAwardResponse()
		{
		}

		// Token: 0x060144ED RID: 83181 RVA: 0x002F3738 File Offset: 0x002F1938
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReceivedSilentFirstAwardResponse(ReceivedSilentFirstAwardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.errorParams_ = other.errorParams_.Clone();
			this.itemMap_ = other.itemMap_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060144EE RID: 83182 RVA: 0x002F378A File Offset: 0x002F198A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReceivedSilentFirstAwardResponse Clone()
		{
			return new ReceivedSilentFirstAwardResponse(this);
		}

		// Token: 0x17004381 RID: 17281
		// (get) Token: 0x060144EF RID: 83183 RVA: 0x002F3792 File Offset: 0x002F1992
		// (set) Token: 0x060144F0 RID: 83184 RVA: 0x002F379A File Offset: 0x002F199A
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

		// Token: 0x17004382 RID: 17282
		// (get) Token: 0x060144F1 RID: 83185 RVA: 0x002F37A3 File Offset: 0x002F19A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> ErrorParams
		{
			get
			{
				return this.errorParams_;
			}
		}

		// Token: 0x17004383 RID: 17283
		// (get) Token: 0x060144F2 RID: 83186 RVA: 0x002F37AB File Offset: 0x002F19AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> ItemMap
		{
			get
			{
				return this.itemMap_;
			}
		}

		// Token: 0x060144F3 RID: 83187 RVA: 0x002F37B3 File Offset: 0x002F19B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ReceivedSilentFirstAwardResponse);
		}

		// Token: 0x060144F4 RID: 83188 RVA: 0x002F37C4 File Offset: 0x002F19C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ReceivedSilentFirstAwardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.errorParams_.Equals(other.errorParams_) && this.ItemMap.Equals(other.ItemMap) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060144F5 RID: 83189 RVA: 0x002F3828 File Offset: 0x002F1A28
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
			num ^= this.ItemMap.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060144F6 RID: 83190 RVA: 0x002F3889 File Offset: 0x002F1A89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060144F7 RID: 83191 RVA: 0x002F3896 File Offset: 0x002F1A96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060144F8 RID: 83192 RVA: 0x002F38A0 File Offset: 0x002F1AA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.errorParams_.WriteTo(ref output, ReceivedSilentFirstAwardResponse._repeated_errorParams_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.itemMap_.WriteTo(ref output, ReceivedSilentFirstAwardResponse._map_itemMap_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060144F9 RID: 83193 RVA: 0x002F3900 File Offset: 0x002F1B00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.errorParams_.CalculateSize(ReceivedSilentFirstAwardResponse._repeated_errorParams_codec);
			num += this.itemMap_.CalculateSize(ReceivedSilentFirstAwardResponse._map_itemMap_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060144FA RID: 83194 RVA: 0x002F3964 File Offset: 0x002F1B64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ReceivedSilentFirstAwardResponse other)
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
			this.itemMap_.MergeFrom(other.itemMap_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060144FB RID: 83195 RVA: 0x002F39C2 File Offset: 0x002F1BC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060144FC RID: 83196 RVA: 0x002F39CC File Offset: 0x002F1BCC
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
				if (num != 66U)
				{
					if (num != 88U)
					{
						if (num != 114U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.itemMap_.AddEntriesFrom(ref input, ReceivedSilentFirstAwardResponse._map_itemMap_codec);
						}
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.errorParams_.AddEntriesFrom(ref input, ReceivedSilentFirstAwardResponse._repeated_errorParams_codec);
				}
			}
		}

		// Token: 0x04007B55 RID: 31573
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007B56 RID: 31574
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x04007B57 RID: 31575
		private ErrorCode errorCode_;

		// Token: 0x04007B58 RID: 31576
		public const int ErrorParamsFieldNumber = 8;

		// Token: 0x04007B59 RID: 31577
		private static readonly FieldCodec<string> _repeated_errorParams_codec = FieldCodec.ForString(66U);

		// Token: 0x04007B5A RID: 31578
		private readonly RepeatedField<string> errorParams_ = new RepeatedField<string>();

		// Token: 0x04007B5B RID: 31579
		public const int ItemMapFieldNumber = 14;

		// Token: 0x04007B5C RID: 31580
		private static readonly MapField<int, int>.Codec _map_itemMap_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 114U);

		// Token: 0x04007B5D RID: 31581
		private readonly MapField<int, int> itemMap_ = new MapField<int, int>();
	}
}
