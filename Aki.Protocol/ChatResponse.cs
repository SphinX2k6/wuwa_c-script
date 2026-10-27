using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000280 RID: 640
	[NetMessage(EMessageId.ChatResponse)]
	public sealed class ChatResponse : IMessage<ChatResponse>, IMessage, IEquatable<ChatResponse>, IDeepCloneable<ChatResponse>, IBufferMessage
	{
		// Token: 0x06004319 RID: 17177 RVA: 0x000A496A File Offset: 0x000A2B6A
		[NullableContext(1)]
		public static ChatResponse Create()
		{
			return new ChatResponse();
		}

		// Token: 0x17000B6D RID: 2925
		// (get) Token: 0x0600431A RID: 17178 RVA: 0x000A4971 File Offset: 0x000A2B71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000B6E RID: 2926
		// (get) Token: 0x0600431B RID: 17179 RVA: 0x000A4974 File Offset: 0x000A2B74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChatResponse.Descriptor;
			}
		}

		// Token: 0x0600431C RID: 17180 RVA: 0x000A497B File Offset: 0x000A2B7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChatResponse()
		{
		}

		// Token: 0x0600431D RID: 17181 RVA: 0x000A499C File Offset: 0x000A2B9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChatResponse(ChatResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.errorParams_ = other.errorParams_.Clone();
			this.data_ = other.data_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600431E RID: 17182 RVA: 0x000A49EE File Offset: 0x000A2BEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChatResponse Clone()
		{
			return new ChatResponse(this);
		}

		// Token: 0x17000B6F RID: 2927
		// (get) Token: 0x0600431F RID: 17183 RVA: 0x000A49F6 File Offset: 0x000A2BF6
		// (set) Token: 0x06004320 RID: 17184 RVA: 0x000A49FE File Offset: 0x000A2BFE
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

		// Token: 0x17000B70 RID: 2928
		// (get) Token: 0x06004321 RID: 17185 RVA: 0x000A4A07 File Offset: 0x000A2C07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> ErrorParams
		{
			get
			{
				return this.errorParams_;
			}
		}

		// Token: 0x17000B71 RID: 2929
		// (get) Token: 0x06004322 RID: 17186 RVA: 0x000A4A0F File Offset: 0x000A2C0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, string> Data
		{
			get
			{
				return this.data_;
			}
		}

		// Token: 0x06004323 RID: 17187 RVA: 0x000A4A17 File Offset: 0x000A2C17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChatResponse);
		}

		// Token: 0x06004324 RID: 17188 RVA: 0x000A4A28 File Offset: 0x000A2C28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChatResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.errorParams_.Equals(other.errorParams_) && this.Data.Equals(other.Data) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004325 RID: 17189 RVA: 0x000A4A8C File Offset: 0x000A2C8C
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
			num ^= this.Data.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004326 RID: 17190 RVA: 0x000A4AED File Offset: 0x000A2CED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004327 RID: 17191 RVA: 0x000A4AFA File Offset: 0x000A2CFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004328 RID: 17192 RVA: 0x000A4B04 File Offset: 0x000A2D04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.data_.WriteTo(ref output, ChatResponse._map_data_codec);
			this.errorParams_.WriteTo(ref output, ChatResponse._repeated_errorParams_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004329 RID: 17193 RVA: 0x000A4B64 File Offset: 0x000A2D64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.errorParams_.CalculateSize(ChatResponse._repeated_errorParams_codec);
			num += this.data_.CalculateSize(ChatResponse._map_data_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600432A RID: 17194 RVA: 0x000A4BC8 File Offset: 0x000A2DC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChatResponse other)
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
			this.data_.MergeFrom(other.data_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600432B RID: 17195 RVA: 0x000A4C26 File Offset: 0x000A2E26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600432C RID: 17196 RVA: 0x000A4C30 File Offset: 0x000A2E30
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
				if (num != 90U)
				{
					if (num != 106U)
					{
						if (num != 112U)
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
						this.errorParams_.AddEntriesFrom(ref input, ChatResponse._repeated_errorParams_codec);
					}
				}
				else
				{
					this.data_.AddEntriesFrom(ref input, ChatResponse._map_data_codec);
				}
			}
		}

		// Token: 0x04002E3D RID: 11837
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002E3E RID: 11838
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x04002E3F RID: 11839
		private ErrorCode errorCode_;

		// Token: 0x04002E40 RID: 11840
		public const int ErrorParamsFieldNumber = 13;

		// Token: 0x04002E41 RID: 11841
		private static readonly FieldCodec<string> _repeated_errorParams_codec = FieldCodec.ForString(106U);

		// Token: 0x04002E42 RID: 11842
		private readonly RepeatedField<string> errorParams_ = new RepeatedField<string>();

		// Token: 0x04002E43 RID: 11843
		public const int DataFieldNumber = 11;

		// Token: 0x04002E44 RID: 11844
		private static readonly MapField<int, string>.Codec _map_data_codec = new MapField<int, string>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForString(18U, ""), 90U);

		// Token: 0x04002E45 RID: 11845
		private readonly MapField<int, string> data_ = new MapField<int, string>();
	}
}
