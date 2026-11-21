using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EBC RID: 3772
	[NetMessage(EMessageId.ReceivedSilentFirstAwardResponse)]
	public sealed class ReceivedSilentFirstAwardResponse : IMessage<ReceivedSilentFirstAwardResponse>, IMessage, IEquatable<ReceivedSilentFirstAwardResponse>, IDeepCloneable<ReceivedSilentFirstAwardResponse>, IBufferMessage
	{
		// Token: 0x06014404 RID: 82948 RVA: 0x002F2055 File Offset: 0x002F0255
		[NullableContext(1)]
		public static ReceivedSilentFirstAwardResponse Create()
		{
			return new ReceivedSilentFirstAwardResponse();
		}

		// Token: 0x17004355 RID: 17237
		// (get) Token: 0x06014405 RID: 82949 RVA: 0x002F205C File Offset: 0x002F025C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004356 RID: 17238
		// (get) Token: 0x06014406 RID: 82950 RVA: 0x002F205F File Offset: 0x002F025F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ReceivedSilentFirstAwardResponse.Descriptor;
			}
		}

		// Token: 0x06014407 RID: 82951 RVA: 0x002F2066 File Offset: 0x002F0266
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReceivedSilentFirstAwardResponse()
		{
		}

		// Token: 0x06014408 RID: 82952 RVA: 0x002F2084 File Offset: 0x002F0284
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReceivedSilentFirstAwardResponse(ReceivedSilentFirstAwardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.errorParams_ = other.errorParams_.Clone();
			this.itemMap_ = other.itemMap_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014409 RID: 82953 RVA: 0x002F20D6 File Offset: 0x002F02D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReceivedSilentFirstAwardResponse Clone()
		{
			return new ReceivedSilentFirstAwardResponse(this);
		}

		// Token: 0x17004357 RID: 17239
		// (get) Token: 0x0601440A RID: 82954 RVA: 0x002F20DE File Offset: 0x002F02DE
		// (set) Token: 0x0601440B RID: 82955 RVA: 0x002F20E6 File Offset: 0x002F02E6
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

		// Token: 0x17004358 RID: 17240
		// (get) Token: 0x0601440C RID: 82956 RVA: 0x002F20EF File Offset: 0x002F02EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> ErrorParams
		{
			get
			{
				return this.errorParams_;
			}
		}

		// Token: 0x17004359 RID: 17241
		// (get) Token: 0x0601440D RID: 82957 RVA: 0x002F20F7 File Offset: 0x002F02F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> ItemMap
		{
			get
			{
				return this.itemMap_;
			}
		}

		// Token: 0x0601440E RID: 82958 RVA: 0x002F20FF File Offset: 0x002F02FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ReceivedSilentFirstAwardResponse);
		}

		// Token: 0x0601440F RID: 82959 RVA: 0x002F2110 File Offset: 0x002F0310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ReceivedSilentFirstAwardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.errorParams_.Equals(other.errorParams_) && this.ItemMap.Equals(other.ItemMap) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014410 RID: 82960 RVA: 0x002F2174 File Offset: 0x002F0374
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

		// Token: 0x06014411 RID: 82961 RVA: 0x002F21D5 File Offset: 0x002F03D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014412 RID: 82962 RVA: 0x002F21E2 File Offset: 0x002F03E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014413 RID: 82963 RVA: 0x002F21EC File Offset: 0x002F03EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.itemMap_.WriteTo(ref output, ReceivedSilentFirstAwardResponse._map_itemMap_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.errorParams_.WriteTo(ref output, ReceivedSilentFirstAwardResponse._repeated_errorParams_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014414 RID: 82964 RVA: 0x002F224C File Offset: 0x002F044C
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

		// Token: 0x06014415 RID: 82965 RVA: 0x002F22B0 File Offset: 0x002F04B0
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

		// Token: 0x06014416 RID: 82966 RVA: 0x002F230E File Offset: 0x002F050E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014417 RID: 82967 RVA: 0x002F2318 File Offset: 0x002F0518
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
				if (num != 34U)
				{
					if (num != 56U)
					{
						if (num != 114U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.errorParams_.AddEntriesFrom(ref input, ReceivedSilentFirstAwardResponse._repeated_errorParams_codec);
						}
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.itemMap_.AddEntriesFrom(ref input, ReceivedSilentFirstAwardResponse._map_itemMap_codec);
				}
			}
		}

		// Token: 0x04007B7F RID: 31615
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007B80 RID: 31616
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x04007B81 RID: 31617
		private ErrorCode errorCode_;

		// Token: 0x04007B82 RID: 31618
		public const int ErrorParamsFieldNumber = 14;

		// Token: 0x04007B83 RID: 31619
		private static readonly FieldCodec<string> _repeated_errorParams_codec = FieldCodec.ForString(114U);

		// Token: 0x04007B84 RID: 31620
		private readonly RepeatedField<string> errorParams_ = new RepeatedField<string>();

		// Token: 0x04007B85 RID: 31621
		public const int ItemMapFieldNumber = 4;

		// Token: 0x04007B86 RID: 31622
		private static readonly MapField<int, int>.Codec _map_itemMap_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 34U);

		// Token: 0x04007B87 RID: 31623
		private readonly MapField<int, int> itemMap_ = new MapField<int, int>();
	}
}
