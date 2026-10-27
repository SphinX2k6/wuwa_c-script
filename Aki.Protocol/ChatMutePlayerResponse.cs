using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200027D RID: 637
	[NetMessage(EMessageId.ChatMutePlayerResponse)]
	public sealed class ChatMutePlayerResponse : IMessage<ChatMutePlayerResponse>, IMessage, IEquatable<ChatMutePlayerResponse>, IDeepCloneable<ChatMutePlayerResponse>, IBufferMessage
	{
		// Token: 0x060042DD RID: 17117 RVA: 0x000A4137 File Offset: 0x000A2337
		[NullableContext(1)]
		public static ChatMutePlayerResponse Create()
		{
			return new ChatMutePlayerResponse();
		}

		// Token: 0x17000B61 RID: 2913
		// (get) Token: 0x060042DE RID: 17118 RVA: 0x000A413E File Offset: 0x000A233E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000B62 RID: 2914
		// (get) Token: 0x060042DF RID: 17119 RVA: 0x000A4141 File Offset: 0x000A2341
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChatMutePlayerResponse.Descriptor;
			}
		}

		// Token: 0x060042E0 RID: 17120 RVA: 0x000A4148 File Offset: 0x000A2348
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChatMutePlayerResponse()
		{
		}

		// Token: 0x060042E1 RID: 17121 RVA: 0x000A415B File Offset: 0x000A235B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChatMutePlayerResponse(ChatMutePlayerResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.removeMutes_ = other.removeMutes_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060042E2 RID: 17122 RVA: 0x000A4191 File Offset: 0x000A2391
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChatMutePlayerResponse Clone()
		{
			return new ChatMutePlayerResponse(this);
		}

		// Token: 0x17000B63 RID: 2915
		// (get) Token: 0x060042E3 RID: 17123 RVA: 0x000A4199 File Offset: 0x000A2399
		// (set) Token: 0x060042E4 RID: 17124 RVA: 0x000A41A1 File Offset: 0x000A23A1
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

		// Token: 0x17000B64 RID: 2916
		// (get) Token: 0x060042E5 RID: 17125 RVA: 0x000A41AA File Offset: 0x000A23AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RemoveMutes
		{
			get
			{
				return this.removeMutes_;
			}
		}

		// Token: 0x060042E6 RID: 17126 RVA: 0x000A41B2 File Offset: 0x000A23B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChatMutePlayerResponse);
		}

		// Token: 0x060042E7 RID: 17127 RVA: 0x000A41C0 File Offset: 0x000A23C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChatMutePlayerResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.removeMutes_.Equals(other.removeMutes_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060042E8 RID: 17128 RVA: 0x000A4210 File Offset: 0x000A2410
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

		// Token: 0x060042E9 RID: 17129 RVA: 0x000A4263 File Offset: 0x000A2463
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060042EA RID: 17130 RVA: 0x000A4270 File Offset: 0x000A2470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060042EB RID: 17131 RVA: 0x000A427C File Offset: 0x000A247C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.removeMutes_.WriteTo(ref output, ChatMutePlayerResponse._repeated_removeMutes_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060042EC RID: 17132 RVA: 0x000A42CC File Offset: 0x000A24CC
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

		// Token: 0x060042ED RID: 17133 RVA: 0x000A4320 File Offset: 0x000A2520
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

		// Token: 0x060042EE RID: 17134 RVA: 0x000A436D File Offset: 0x000A256D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060042EF RID: 17135 RVA: 0x000A4378 File Offset: 0x000A2578
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
					if (num != 72U && num != 74U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.removeMutes_.AddEntriesFrom(ref input, ChatMutePlayerResponse._repeated_removeMutes_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002E2C RID: 11820
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002E2D RID: 11821
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x04002E2E RID: 11822
		private ErrorCode errorCode_;

		// Token: 0x04002E2F RID: 11823
		public const int RemoveMutesFieldNumber = 9;

		// Token: 0x04002E30 RID: 11824
		private static readonly FieldCodec<int> _repeated_removeMutes_codec = FieldCodec.ForInt32(74U);

		// Token: 0x04002E31 RID: 11825
		private readonly RepeatedField<int> removeMutes_ = new RepeatedField<int>();
	}
}
