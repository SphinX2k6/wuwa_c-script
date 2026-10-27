using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200087A RID: 2170
	[NetMessage(EMessageId.JokerGuessUseSkillResponse)]
	public sealed class JokerGuessUseSkillResponse : IMessage<JokerGuessUseSkillResponse>, IMessage, IEquatable<JokerGuessUseSkillResponse>, IDeepCloneable<JokerGuessUseSkillResponse>, IBufferMessage
	{
		// Token: 0x0600C139 RID: 49465 RVA: 0x001CB084 File Offset: 0x001C9284
		[NullableContext(1)]
		public static JokerGuessUseSkillResponse Create()
		{
			return new JokerGuessUseSkillResponse();
		}

		// Token: 0x1700270D RID: 9997
		// (get) Token: 0x0600C13A RID: 49466 RVA: 0x001CB08B File Offset: 0x001C928B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700270E RID: 9998
		// (get) Token: 0x0600C13B RID: 49467 RVA: 0x001CB08E File Offset: 0x001C928E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return JokerGuessUseSkillResponse.Descriptor;
			}
		}

		// Token: 0x0600C13C RID: 49468 RVA: 0x001CB095 File Offset: 0x001C9295
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessUseSkillResponse()
		{
		}

		// Token: 0x0600C13D RID: 49469 RVA: 0x001CB0A8 File Offset: 0x001C92A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessUseSkillResponse(JokerGuessUseSkillResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.cmd_ = other.cmd_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C13E RID: 49470 RVA: 0x001CB0DE File Offset: 0x001C92DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessUseSkillResponse Clone()
		{
			return new JokerGuessUseSkillResponse(this);
		}

		// Token: 0x1700270F RID: 9999
		// (get) Token: 0x0600C13F RID: 49471 RVA: 0x001CB0E6 File Offset: 0x001C92E6
		// (set) Token: 0x0600C140 RID: 49472 RVA: 0x001CB0EE File Offset: 0x001C92EE
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

		// Token: 0x17002710 RID: 10000
		// (get) Token: 0x0600C141 RID: 49473 RVA: 0x001CB0F7 File Offset: 0x001C92F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<JokerGuessOp> Cmd
		{
			get
			{
				return this.cmd_;
			}
		}

		// Token: 0x0600C142 RID: 49474 RVA: 0x001CB0FF File Offset: 0x001C92FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as JokerGuessUseSkillResponse);
		}

		// Token: 0x0600C143 RID: 49475 RVA: 0x001CB110 File Offset: 0x001C9310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(JokerGuessUseSkillResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.cmd_.Equals(other.cmd_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C144 RID: 49476 RVA: 0x001CB160 File Offset: 0x001C9360
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.cmd_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C145 RID: 49477 RVA: 0x001CB1B3 File Offset: 0x001C93B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C146 RID: 49478 RVA: 0x001CB1C0 File Offset: 0x001C93C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C147 RID: 49479 RVA: 0x001CB1CC File Offset: 0x001C93CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.cmd_.WriteTo(ref output, JokerGuessUseSkillResponse._repeated_cmd_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C148 RID: 49480 RVA: 0x001CB21C File Offset: 0x001C941C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.cmd_.CalculateSize(JokerGuessUseSkillResponse._repeated_cmd_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C149 RID: 49481 RVA: 0x001CB270 File Offset: 0x001C9470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(JokerGuessUseSkillResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.cmd_.Add(other.cmd_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C14A RID: 49482 RVA: 0x001CB2BD File Offset: 0x001C94BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C14B RID: 49483 RVA: 0x001CB2C8 File Offset: 0x001C94C8
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
					if (num != 50U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.cmd_.AddEntriesFrom(ref input, JokerGuessUseSkillResponse._repeated_cmd_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040053D6 RID: 21462
		private UnknownFieldSet _unknownFields;

		// Token: 0x040053D7 RID: 21463
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x040053D8 RID: 21464
		private ErrorCode errorCode_;

		// Token: 0x040053D9 RID: 21465
		public const int CmdFieldNumber = 6;

		// Token: 0x040053DA RID: 21466
		private static readonly FieldCodec<JokerGuessOp> _repeated_cmd_codec = FieldCodec.ForMessage<JokerGuessOp>(50U, JokerGuessOp.Parser);

		// Token: 0x040053DB RID: 21467
		private readonly RepeatedField<JokerGuessOp> cmd_ = new RepeatedField<JokerGuessOp>();
	}
}
