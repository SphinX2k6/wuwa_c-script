using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000869 RID: 2153
	[NetMessage(EMessageId.JokerGuessUseSkillResponse)]
	public sealed class JokerGuessUseSkillResponse : IMessage<JokerGuessUseSkillResponse>, IMessage, IEquatable<JokerGuessUseSkillResponse>, IDeepCloneable<JokerGuessUseSkillResponse>, IBufferMessage
	{
		// Token: 0x0600C01D RID: 49181 RVA: 0x001C8D9C File Offset: 0x001C6F9C
		[NullableContext(1)]
		public static JokerGuessUseSkillResponse Create()
		{
			return new JokerGuessUseSkillResponse();
		}

		// Token: 0x170026CE RID: 9934
		// (get) Token: 0x0600C01E RID: 49182 RVA: 0x001C8DA3 File Offset: 0x001C6FA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170026CF RID: 9935
		// (get) Token: 0x0600C01F RID: 49183 RVA: 0x001C8DA6 File Offset: 0x001C6FA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return JokerGuessUseSkillResponse.Descriptor;
			}
		}

		// Token: 0x0600C020 RID: 49184 RVA: 0x001C8DAD File Offset: 0x001C6FAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessUseSkillResponse()
		{
		}

		// Token: 0x0600C021 RID: 49185 RVA: 0x001C8DC0 File Offset: 0x001C6FC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessUseSkillResponse(JokerGuessUseSkillResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.cmd_ = other.cmd_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C022 RID: 49186 RVA: 0x001C8DF6 File Offset: 0x001C6FF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessUseSkillResponse Clone()
		{
			return new JokerGuessUseSkillResponse(this);
		}

		// Token: 0x170026D0 RID: 9936
		// (get) Token: 0x0600C023 RID: 49187 RVA: 0x001C8DFE File Offset: 0x001C6FFE
		// (set) Token: 0x0600C024 RID: 49188 RVA: 0x001C8E06 File Offset: 0x001C7006
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

		// Token: 0x170026D1 RID: 9937
		// (get) Token: 0x0600C025 RID: 49189 RVA: 0x001C8E0F File Offset: 0x001C700F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<JokerGuessOp> Cmd
		{
			get
			{
				return this.cmd_;
			}
		}

		// Token: 0x0600C026 RID: 49190 RVA: 0x001C8E17 File Offset: 0x001C7017
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as JokerGuessUseSkillResponse);
		}

		// Token: 0x0600C027 RID: 49191 RVA: 0x001C8E28 File Offset: 0x001C7028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(JokerGuessUseSkillResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.cmd_.Equals(other.cmd_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C028 RID: 49192 RVA: 0x001C8E78 File Offset: 0x001C7078
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

		// Token: 0x0600C029 RID: 49193 RVA: 0x001C8ECB File Offset: 0x001C70CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C02A RID: 49194 RVA: 0x001C8ED8 File Offset: 0x001C70D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C02B RID: 49195 RVA: 0x001C8EE4 File Offset: 0x001C70E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.cmd_.WriteTo(ref output, JokerGuessUseSkillResponse._repeated_cmd_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C02C RID: 49196 RVA: 0x001C8F34 File Offset: 0x001C7134
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

		// Token: 0x0600C02D RID: 49197 RVA: 0x001C8F88 File Offset: 0x001C7188
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

		// Token: 0x0600C02E RID: 49198 RVA: 0x001C8FD5 File Offset: 0x001C71D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C02F RID: 49199 RVA: 0x001C8FE0 File Offset: 0x001C71E0
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
				if (num != 48U)
				{
					if (num != 82U)
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

		// Token: 0x040053DD RID: 21469
		private UnknownFieldSet _unknownFields;

		// Token: 0x040053DE RID: 21470
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x040053DF RID: 21471
		private ErrorCode errorCode_;

		// Token: 0x040053E0 RID: 21472
		public const int CmdFieldNumber = 10;

		// Token: 0x040053E1 RID: 21473
		private static readonly FieldCodec<JokerGuessOp> _repeated_cmd_codec = FieldCodec.ForMessage<JokerGuessOp>(82U, JokerGuessOp.Parser);

		// Token: 0x040053E2 RID: 21474
		private readonly RepeatedField<JokerGuessOp> cmd_ = new RepeatedField<JokerGuessOp>();
	}
}
