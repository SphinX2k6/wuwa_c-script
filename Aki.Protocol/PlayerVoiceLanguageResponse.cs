using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DAA RID: 3498
	[NetMessage(EMessageId.PlayerVoiceLanguageResponse)]
	public sealed class PlayerVoiceLanguageResponse : IMessage<PlayerVoiceLanguageResponse>, IMessage, IEquatable<PlayerVoiceLanguageResponse>, IDeepCloneable<PlayerVoiceLanguageResponse>, IBufferMessage
	{
		// Token: 0x06012DE9 RID: 77289 RVA: 0x002C1242 File Offset: 0x002BF442
		[NullableContext(1)]
		public static PlayerVoiceLanguageResponse Create()
		{
			return new PlayerVoiceLanguageResponse();
		}

		// Token: 0x17003EA3 RID: 16035
		// (get) Token: 0x06012DEA RID: 77290 RVA: 0x002C1249 File Offset: 0x002BF449
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003EA4 RID: 16036
		// (get) Token: 0x06012DEB RID: 77291 RVA: 0x002C124C File Offset: 0x002BF44C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerVoiceLanguageResponse.Descriptor;
			}
		}

		// Token: 0x06012DEC RID: 77292 RVA: 0x002C1253 File Offset: 0x002BF453
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerVoiceLanguageResponse()
		{
		}

		// Token: 0x06012DED RID: 77293 RVA: 0x002C1266 File Offset: 0x002BF466
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerVoiceLanguageResponse(PlayerVoiceLanguageResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.roleVoices_ = other.roleVoices_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012DEE RID: 77294 RVA: 0x002C129C File Offset: 0x002BF49C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerVoiceLanguageResponse Clone()
		{
			return new PlayerVoiceLanguageResponse(this);
		}

		// Token: 0x17003EA5 RID: 16037
		// (get) Token: 0x06012DEF RID: 77295 RVA: 0x002C12A4 File Offset: 0x002BF4A4
		// (set) Token: 0x06012DF0 RID: 77296 RVA: 0x002C12AC File Offset: 0x002BF4AC
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

		// Token: 0x17003EA6 RID: 16038
		// (get) Token: 0x06012DF1 RID: 77297 RVA: 0x002C12B5 File Offset: 0x002BF4B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoleVoice> RoleVoices
		{
			get
			{
				return this.roleVoices_;
			}
		}

		// Token: 0x06012DF2 RID: 77298 RVA: 0x002C12BD File Offset: 0x002BF4BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerVoiceLanguageResponse);
		}

		// Token: 0x06012DF3 RID: 77299 RVA: 0x002C12CC File Offset: 0x002BF4CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerVoiceLanguageResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.roleVoices_.Equals(other.roleVoices_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012DF4 RID: 77300 RVA: 0x002C131C File Offset: 0x002BF51C
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

		// Token: 0x06012DF5 RID: 77301 RVA: 0x002C136F File Offset: 0x002BF56F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012DF6 RID: 77302 RVA: 0x002C137C File Offset: 0x002BF57C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012DF7 RID: 77303 RVA: 0x002C1388 File Offset: 0x002BF588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.roleVoices_.WriteTo(ref output, PlayerVoiceLanguageResponse._repeated_roleVoices_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012DF8 RID: 77304 RVA: 0x002C13D8 File Offset: 0x002BF5D8
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

		// Token: 0x06012DF9 RID: 77305 RVA: 0x002C142C File Offset: 0x002BF62C
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

		// Token: 0x06012DFA RID: 77306 RVA: 0x002C1479 File Offset: 0x002BF679
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012DFB RID: 77307 RVA: 0x002C1484 File Offset: 0x002BF684
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
				if (num != 40U)
				{
					if (num != 98U)
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

		// Token: 0x04007537 RID: 30007
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007538 RID: 30008
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x04007539 RID: 30009
		private ErrorCode errorCode_;

		// Token: 0x0400753A RID: 30010
		public const int RoleVoicesFieldNumber = 12;

		// Token: 0x0400753B RID: 30011
		private static readonly FieldCodec<RoleVoice> _repeated_roleVoices_codec = FieldCodec.ForMessage<RoleVoice>(98U, RoleVoice.Parser);

		// Token: 0x0400753C RID: 30012
		private readonly RepeatedField<RoleVoice> roleVoices_ = new RepeatedField<RoleVoice>();
	}
}
