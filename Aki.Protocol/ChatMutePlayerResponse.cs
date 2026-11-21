using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000282 RID: 642
	[NetMessage(EMessageId.ChatMutePlayerResponse)]
	public sealed class ChatMutePlayerResponse : IMessage<ChatMutePlayerResponse>, IMessage, IEquatable<ChatMutePlayerResponse>, IDeepCloneable<ChatMutePlayerResponse>, IBufferMessage
	{
		// Token: 0x06004384 RID: 17284 RVA: 0x000A5DFF File Offset: 0x000A3FFF
		[NullableContext(1)]
		public static ChatMutePlayerResponse Create()
		{
			return new ChatMutePlayerResponse();
		}

		// Token: 0x17000B81 RID: 2945
		// (get) Token: 0x06004385 RID: 17285 RVA: 0x000A5E06 File Offset: 0x000A4006
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000B82 RID: 2946
		// (get) Token: 0x06004386 RID: 17286 RVA: 0x000A5E09 File Offset: 0x000A4009
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChatMutePlayerResponse.Descriptor;
			}
		}

		// Token: 0x06004387 RID: 17287 RVA: 0x000A5E10 File Offset: 0x000A4010
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChatMutePlayerResponse()
		{
		}

		// Token: 0x06004388 RID: 17288 RVA: 0x000A5E23 File Offset: 0x000A4023
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChatMutePlayerResponse(ChatMutePlayerResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.removeMutes_ = other.removeMutes_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004389 RID: 17289 RVA: 0x000A5E59 File Offset: 0x000A4059
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChatMutePlayerResponse Clone()
		{
			return new ChatMutePlayerResponse(this);
		}

		// Token: 0x17000B83 RID: 2947
		// (get) Token: 0x0600438A RID: 17290 RVA: 0x000A5E61 File Offset: 0x000A4061
		// (set) Token: 0x0600438B RID: 17291 RVA: 0x000A5E69 File Offset: 0x000A4069
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

		// Token: 0x17000B84 RID: 2948
		// (get) Token: 0x0600438C RID: 17292 RVA: 0x000A5E72 File Offset: 0x000A4072
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RemoveMutes
		{
			get
			{
				return this.removeMutes_;
			}
		}

		// Token: 0x0600438D RID: 17293 RVA: 0x000A5E7A File Offset: 0x000A407A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChatMutePlayerResponse);
		}

		// Token: 0x0600438E RID: 17294 RVA: 0x000A5E88 File Offset: 0x000A4088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChatMutePlayerResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.removeMutes_.Equals(other.removeMutes_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600438F RID: 17295 RVA: 0x000A5ED8 File Offset: 0x000A40D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.removeMutes_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004390 RID: 17296 RVA: 0x000A5F2B File Offset: 0x000A412B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004391 RID: 17297 RVA: 0x000A5F38 File Offset: 0x000A4138
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004392 RID: 17298 RVA: 0x000A5F44 File Offset: 0x000A4144
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.removeMutes_.WriteTo(ref output, ChatMutePlayerResponse._repeated_removeMutes_codec);
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

		// Token: 0x06004393 RID: 17299 RVA: 0x000A5F94 File Offset: 0x000A4194
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.removeMutes_.CalculateSize(ChatMutePlayerResponse._repeated_removeMutes_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004394 RID: 17300 RVA: 0x000A5FE8 File Offset: 0x000A41E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChatMutePlayerResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.removeMutes_.Add(other.removeMutes_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004395 RID: 17301 RVA: 0x000A6035 File Offset: 0x000A4235
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004396 RID: 17302 RVA: 0x000A6040 File Offset: 0x000A4240
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
				if (num != 80U && num != 82U)
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
					this.removeMutes_.AddEntriesFrom(ref input, ChatMutePlayerResponse._repeated_removeMutes_codec);
				}
			}
		}

		// Token: 0x04002EB0 RID: 11952
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002EB1 RID: 11953
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x04002EB2 RID: 11954
		private ErrorCode errorCode_;

		// Token: 0x04002EB3 RID: 11955
		public const int RemoveMutesFieldNumber = 10;

		// Token: 0x04002EB4 RID: 11956
		private static readonly FieldCodec<int> _repeated_removeMutes_codec = FieldCodec.ForInt32(82U);

		// Token: 0x04002EB5 RID: 11957
		private readonly RepeatedField<int> removeMutes_ = new RepeatedField<int>();
	}
}
