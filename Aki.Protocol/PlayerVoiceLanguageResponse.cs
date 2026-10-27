using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DBA RID: 3514
	[NetMessage(EMessageId.PlayerVoiceLanguageResponse)]
	public sealed class PlayerVoiceLanguageResponse : IMessage<PlayerVoiceLanguageResponse>, IMessage, IEquatable<PlayerVoiceLanguageResponse>, IDeepCloneable<PlayerVoiceLanguageResponse>, IBufferMessage
	{
		// Token: 0x06012EE5 RID: 77541 RVA: 0x002C2E66 File Offset: 0x002C1066
		[NullableContext(1)]
		public static PlayerVoiceLanguageResponse Create()
		{
			return new PlayerVoiceLanguageResponse();
		}

		// Token: 0x17003ED8 RID: 16088
		// (get) Token: 0x06012EE6 RID: 77542 RVA: 0x002C2E6D File Offset: 0x002C106D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003ED9 RID: 16089
		// (get) Token: 0x06012EE7 RID: 77543 RVA: 0x002C2E70 File Offset: 0x002C1070
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerVoiceLanguageResponse.Descriptor;
			}
		}

		// Token: 0x06012EE8 RID: 77544 RVA: 0x002C2E77 File Offset: 0x002C1077
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerVoiceLanguageResponse()
		{
		}

		// Token: 0x06012EE9 RID: 77545 RVA: 0x002C2E8A File Offset: 0x002C108A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerVoiceLanguageResponse(PlayerVoiceLanguageResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.roleVoices_ = other.roleVoices_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012EEA RID: 77546 RVA: 0x002C2EC0 File Offset: 0x002C10C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerVoiceLanguageResponse Clone()
		{
			return new PlayerVoiceLanguageResponse(this);
		}

		// Token: 0x17003EDA RID: 16090
		// (get) Token: 0x06012EEB RID: 77547 RVA: 0x002C2EC8 File Offset: 0x002C10C8
		// (set) Token: 0x06012EEC RID: 77548 RVA: 0x002C2ED0 File Offset: 0x002C10D0
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

		// Token: 0x17003EDB RID: 16091
		// (get) Token: 0x06012EED RID: 77549 RVA: 0x002C2ED9 File Offset: 0x002C10D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoleVoice> RoleVoices
		{
			get
			{
				return this.roleVoices_;
			}
		}

		// Token: 0x06012EEE RID: 77550 RVA: 0x002C2EE1 File Offset: 0x002C10E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerVoiceLanguageResponse);
		}

		// Token: 0x06012EEF RID: 77551 RVA: 0x002C2EF0 File Offset: 0x002C10F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerVoiceLanguageResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.roleVoices_.Equals(other.roleVoices_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012EF0 RID: 77552 RVA: 0x002C2F40 File Offset: 0x002C1140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.roleVoices_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012EF1 RID: 77553 RVA: 0x002C2F93 File Offset: 0x002C1193
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012EF2 RID: 77554 RVA: 0x002C2FA0 File Offset: 0x002C11A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012EF3 RID: 77555 RVA: 0x002C2FAC File Offset: 0x002C11AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.roleVoices_.WriteTo(ref output, PlayerVoiceLanguageResponse._repeated_roleVoices_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012EF4 RID: 77556 RVA: 0x002C2FFC File Offset: 0x002C11FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.roleVoices_.CalculateSize(PlayerVoiceLanguageResponse._repeated_roleVoices_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012EF5 RID: 77557 RVA: 0x002C3050 File Offset: 0x002C1250
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerVoiceLanguageResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.roleVoices_.Add(other.roleVoices_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012EF6 RID: 77558 RVA: 0x002C309D File Offset: 0x002C129D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012EF7 RID: 77559 RVA: 0x002C30A8 File Offset: 0x002C12A8
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
					if (num != 106U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.roleVoices_.AddEntriesFrom(ref input, PlayerVoiceLanguageResponse._repeated_roleVoices_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400751F RID: 29983
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007520 RID: 29984
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x04007521 RID: 29985
		private ErrorCode errorCode_;

		// Token: 0x04007522 RID: 29986
		public const int RoleVoicesFieldNumber = 13;

		// Token: 0x04007523 RID: 29987
		private static readonly FieldCodec<RoleVoice> _repeated_roleVoices_codec = FieldCodec.ForMessage<RoleVoice>(106U, RoleVoice.Parser);

		// Token: 0x04007524 RID: 29988
		private readonly RepeatedField<RoleVoice> roleVoices_ = new RepeatedField<RoleVoice>();
	}
}
