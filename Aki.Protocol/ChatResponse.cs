using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000285 RID: 645
	[NetMessage(EMessageId.ChatResponse)]
	public sealed class ChatResponse : IMessage<ChatResponse>, IMessage, IEquatable<ChatResponse>, IDeepCloneable<ChatResponse>, IBufferMessage
	{
		// Token: 0x060043C0 RID: 17344 RVA: 0x000A6632 File Offset: 0x000A4832
		[NullableContext(1)]
		public static ChatResponse Create()
		{
			return new ChatResponse();
		}

		// Token: 0x17000B8D RID: 2957
		// (get) Token: 0x060043C1 RID: 17345 RVA: 0x000A6639 File Offset: 0x000A4839
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000B8E RID: 2958
		// (get) Token: 0x060043C2 RID: 17346 RVA: 0x000A663C File Offset: 0x000A483C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChatResponse.Descriptor;
			}
		}

		// Token: 0x060043C3 RID: 17347 RVA: 0x000A6643 File Offset: 0x000A4843
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChatResponse()
		{
		}

		// Token: 0x060043C4 RID: 17348 RVA: 0x000A6664 File Offset: 0x000A4864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChatResponse(ChatResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.errorParams_ = other.errorParams_.Clone();
			this.data_ = other.data_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060043C5 RID: 17349 RVA: 0x000A66B6 File Offset: 0x000A48B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChatResponse Clone()
		{
			return new ChatResponse(this);
		}

		// Token: 0x17000B8F RID: 2959
		// (get) Token: 0x060043C6 RID: 17350 RVA: 0x000A66BE File Offset: 0x000A48BE
		// (set) Token: 0x060043C7 RID: 17351 RVA: 0x000A66C6 File Offset: 0x000A48C6
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

		// Token: 0x17000B90 RID: 2960
		// (get) Token: 0x060043C8 RID: 17352 RVA: 0x000A66CF File Offset: 0x000A48CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<string> ErrorParams
		{
			get
			{
				return this.errorParams_;
			}
		}

		// Token: 0x17000B91 RID: 2961
		// (get) Token: 0x060043C9 RID: 17353 RVA: 0x000A66D7 File Offset: 0x000A48D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, string> Data
		{
			get
			{
				return this.data_;
			}
		}

		// Token: 0x060043CA RID: 17354 RVA: 0x000A66DF File Offset: 0x000A48DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChatResponse);
		}

		// Token: 0x060043CB RID: 17355 RVA: 0x000A66F0 File Offset: 0x000A48F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChatResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.errorParams_.Equals(other.errorParams_) && this.Data.Equals(other.Data) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060043CC RID: 17356 RVA: 0x000A6754 File Offset: 0x000A4954
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

		// Token: 0x060043CD RID: 17357 RVA: 0x000A67B5 File Offset: 0x000A49B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060043CE RID: 17358 RVA: 0x000A67C2 File Offset: 0x000A49C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060043CF RID: 17359 RVA: 0x000A67CC File Offset: 0x000A49CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.errorParams_.WriteTo(ref output, ChatResponse._repeated_errorParams_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.data_.WriteTo(ref output, ChatResponse._map_data_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060043D0 RID: 17360 RVA: 0x000A682C File Offset: 0x000A4A2C
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

		// Token: 0x060043D1 RID: 17361 RVA: 0x000A6890 File Offset: 0x000A4A90
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

		// Token: 0x060043D2 RID: 17362 RVA: 0x000A68EE File Offset: 0x000A4AEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060043D3 RID: 17363 RVA: 0x000A68F8 File Offset: 0x000A4AF8
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
				if (num != 58U)
				{
					if (num != 80U)
					{
						if (num != 114U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.data_.AddEntriesFrom(ref input, ChatResponse._map_data_codec);
						}
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
		}

		// Token: 0x04002EC1 RID: 11969
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002EC2 RID: 11970
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x04002EC3 RID: 11971
		private ErrorCode errorCode_;

		// Token: 0x04002EC4 RID: 11972
		public const int ErrorParamsFieldNumber = 7;

		// Token: 0x04002EC5 RID: 11973
		private static readonly FieldCodec<string> _repeated_errorParams_codec = FieldCodec.ForString(58U);

		// Token: 0x04002EC6 RID: 11974
		private readonly RepeatedField<string> errorParams_ = new RepeatedField<string>();

		// Token: 0x04002EC7 RID: 11975
		public const int DataFieldNumber = 14;

		// Token: 0x04002EC8 RID: 11976
		private static readonly MapField<int, string>.Codec _map_data_codec = new MapField<int, string>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForString(18U, ""), 114U);

		// Token: 0x04002EC9 RID: 11977
		private readonly MapField<int, string> data_ = new MapField<int, string>();
	}
}
