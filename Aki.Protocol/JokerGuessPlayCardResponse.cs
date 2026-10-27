using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000871 RID: 2161
	[NetMessage(EMessageId.JokerGuessPlayCardResponse)]
	public sealed class JokerGuessPlayCardResponse : IMessage<JokerGuessPlayCardResponse>, IMessage, IEquatable<JokerGuessPlayCardResponse>, IDeepCloneable<JokerGuessPlayCardResponse>, IBufferMessage
	{
		// Token: 0x0600C07F RID: 49279 RVA: 0x001C9610 File Offset: 0x001C7810
		[NullableContext(1)]
		public static JokerGuessPlayCardResponse Create()
		{
			return new JokerGuessPlayCardResponse();
		}

		// Token: 0x170026E6 RID: 9958
		// (get) Token: 0x0600C080 RID: 49280 RVA: 0x001C9617 File Offset: 0x001C7817
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170026E7 RID: 9959
		// (get) Token: 0x0600C081 RID: 49281 RVA: 0x001C961A File Offset: 0x001C781A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return JokerGuessPlayCardResponse.Descriptor;
			}
		}

		// Token: 0x0600C082 RID: 49282 RVA: 0x001C9621 File Offset: 0x001C7821
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessPlayCardResponse()
		{
		}

		// Token: 0x0600C083 RID: 49283 RVA: 0x001C9634 File Offset: 0x001C7834
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessPlayCardResponse(JokerGuessPlayCardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.cmd_ = other.cmd_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C084 RID: 49284 RVA: 0x001C966A File Offset: 0x001C786A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessPlayCardResponse Clone()
		{
			return new JokerGuessPlayCardResponse(this);
		}

		// Token: 0x170026E8 RID: 9960
		// (get) Token: 0x0600C085 RID: 49285 RVA: 0x001C9672 File Offset: 0x001C7872
		// (set) Token: 0x0600C086 RID: 49286 RVA: 0x001C967A File Offset: 0x001C787A
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

		// Token: 0x170026E9 RID: 9961
		// (get) Token: 0x0600C087 RID: 49287 RVA: 0x001C9683 File Offset: 0x001C7883
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<JokerGuessOp> Cmd
		{
			get
			{
				return this.cmd_;
			}
		}

		// Token: 0x0600C088 RID: 49288 RVA: 0x001C968B File Offset: 0x001C788B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as JokerGuessPlayCardResponse);
		}

		// Token: 0x0600C089 RID: 49289 RVA: 0x001C969C File Offset: 0x001C789C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(JokerGuessPlayCardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.cmd_.Equals(other.cmd_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C08A RID: 49290 RVA: 0x001C96EC File Offset: 0x001C78EC
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

		// Token: 0x0600C08B RID: 49291 RVA: 0x001C973F File Offset: 0x001C793F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C08C RID: 49292 RVA: 0x001C974C File Offset: 0x001C794C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C08D RID: 49293 RVA: 0x001C9758 File Offset: 0x001C7958
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.cmd_.WriteTo(ref output, JokerGuessPlayCardResponse._repeated_cmd_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C08E RID: 49294 RVA: 0x001C97A8 File Offset: 0x001C79A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.cmd_.CalculateSize(JokerGuessPlayCardResponse._repeated_cmd_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C08F RID: 49295 RVA: 0x001C97FC File Offset: 0x001C79FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(JokerGuessPlayCardResponse other)
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

		// Token: 0x0600C090 RID: 49296 RVA: 0x001C9849 File Offset: 0x001C7A49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C091 RID: 49297 RVA: 0x001C9854 File Offset: 0x001C7A54
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
				if (num != 24U)
				{
					if (num != 42U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.cmd_.AddEntriesFrom(ref input, JokerGuessPlayCardResponse._repeated_cmd_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040053A1 RID: 21409
		private UnknownFieldSet _unknownFields;

		// Token: 0x040053A2 RID: 21410
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x040053A3 RID: 21411
		private ErrorCode errorCode_;

		// Token: 0x040053A4 RID: 21412
		public const int CmdFieldNumber = 5;

		// Token: 0x040053A5 RID: 21413
		private static readonly FieldCodec<JokerGuessOp> _repeated_cmd_codec = FieldCodec.ForMessage<JokerGuessOp>(42U, JokerGuessOp.Parser);

		// Token: 0x040053A6 RID: 21414
		private readonly RepeatedField<JokerGuessOp> cmd_ = new RepeatedField<JokerGuessOp>();
	}
}
