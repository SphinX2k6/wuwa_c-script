using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000878 RID: 2168
	[NetMessage(EMessageId.JokerGuessStartNewResponse)]
	public sealed class JokerGuessStartNewResponse : IMessage<JokerGuessStartNewResponse>, IMessage, IEquatable<JokerGuessStartNewResponse>, IDeepCloneable<JokerGuessStartNewResponse>, IBufferMessage
	{
		// Token: 0x0600C10F RID: 49423 RVA: 0x001CAA4C File Offset: 0x001C8C4C
		[NullableContext(1)]
		public static JokerGuessStartNewResponse Create()
		{
			return new JokerGuessStartNewResponse();
		}

		// Token: 0x17002704 RID: 9988
		// (get) Token: 0x0600C110 RID: 49424 RVA: 0x001CAA53 File Offset: 0x001C8C53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002705 RID: 9989
		// (get) Token: 0x0600C111 RID: 49425 RVA: 0x001CAA56 File Offset: 0x001C8C56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return JokerGuessStartNewResponse.Descriptor;
			}
		}

		// Token: 0x0600C112 RID: 49426 RVA: 0x001CAA5D File Offset: 0x001C8C5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessStartNewResponse()
		{
		}

		// Token: 0x0600C113 RID: 49427 RVA: 0x001CAA70 File Offset: 0x001C8C70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessStartNewResponse(JokerGuessStartNewResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.initData_ = ((other.initData_ != null) ? other.initData_.Clone() : null);
			this.cmd_ = other.cmd_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C114 RID: 49428 RVA: 0x001CAACD File Offset: 0x001C8CCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessStartNewResponse Clone()
		{
			return new JokerGuessStartNewResponse(this);
		}

		// Token: 0x17002706 RID: 9990
		// (get) Token: 0x0600C115 RID: 49429 RVA: 0x001CAAD5 File Offset: 0x001C8CD5
		// (set) Token: 0x0600C116 RID: 49430 RVA: 0x001CAADD File Offset: 0x001C8CDD
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

		// Token: 0x17002707 RID: 9991
		// (get) Token: 0x0600C117 RID: 49431 RVA: 0x001CAAE6 File Offset: 0x001C8CE6
		// (set) Token: 0x0600C118 RID: 49432 RVA: 0x001CAAEE File Offset: 0x001C8CEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessInitGame InitData
		{
			get
			{
				return this.initData_;
			}
			set
			{
				this.initData_ = value;
			}
		}

		// Token: 0x17002708 RID: 9992
		// (get) Token: 0x0600C119 RID: 49433 RVA: 0x001CAAF7 File Offset: 0x001C8CF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<JokerGuessOp> Cmd
		{
			get
			{
				return this.cmd_;
			}
		}

		// Token: 0x0600C11A RID: 49434 RVA: 0x001CAAFF File Offset: 0x001C8CFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as JokerGuessStartNewResponse);
		}

		// Token: 0x0600C11B RID: 49435 RVA: 0x001CAB10 File Offset: 0x001C8D10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(JokerGuessStartNewResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this.InitData, other.InitData) && this.cmd_.Equals(other.cmd_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C11C RID: 49436 RVA: 0x001CAB74 File Offset: 0x001C8D74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.initData_ != null)
			{
				num ^= this.InitData.GetHashCode();
			}
			num ^= this.cmd_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C11D RID: 49437 RVA: 0x001CABDD File Offset: 0x001C8DDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C11E RID: 49438 RVA: 0x001CABEA File Offset: 0x001C8DEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C11F RID: 49439 RVA: 0x001CABF4 File Offset: 0x001C8DF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.initData_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(this.InitData);
			}
			this.cmd_.WriteTo(ref output, JokerGuessStartNewResponse._repeated_cmd_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C120 RID: 49440 RVA: 0x001CAC60 File Offset: 0x001C8E60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.initData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.InitData);
			}
			num += this.cmd_.CalculateSize(JokerGuessStartNewResponse._repeated_cmd_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C121 RID: 49441 RVA: 0x001CACCC File Offset: 0x001C8ECC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(JokerGuessStartNewResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.initData_ != null)
			{
				if (this.initData_ == null)
				{
					this.InitData = new JokerGuessInitGame();
				}
				this.InitData.MergeFrom(other.InitData);
			}
			this.cmd_.Add(other.cmd_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C122 RID: 49442 RVA: 0x001CAD45 File Offset: 0x001C8F45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C123 RID: 49443 RVA: 0x001CAD50 File Offset: 0x001C8F50
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
				if (num != 8U)
				{
					if (num != 82U)
					{
						if (num != 114U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.cmd_.AddEntriesFrom(ref input, JokerGuessStartNewResponse._repeated_cmd_codec);
						}
					}
					else
					{
						if (this.initData_ == null)
						{
							this.InitData = new JokerGuessInitGame();
						}
						input.ReadMessage(this.InitData);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040053C9 RID: 21449
		private UnknownFieldSet _unknownFields;

		// Token: 0x040053CA RID: 21450
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x040053CB RID: 21451
		private ErrorCode errorCode_;

		// Token: 0x040053CC RID: 21452
		public const int InitDataFieldNumber = 10;

		// Token: 0x040053CD RID: 21453
		private JokerGuessInitGame initData_;

		// Token: 0x040053CE RID: 21454
		public const int CmdFieldNumber = 14;

		// Token: 0x040053CF RID: 21455
		private static readonly FieldCodec<JokerGuessOp> _repeated_cmd_codec = FieldCodec.ForMessage<JokerGuessOp>(114U, JokerGuessOp.Parser);

		// Token: 0x040053D0 RID: 21456
		private readonly RepeatedField<JokerGuessOp> cmd_ = new RepeatedField<JokerGuessOp>();
	}
}
