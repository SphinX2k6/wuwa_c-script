using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200086B RID: 2155
	[NetMessage(EMessageId.JokerGuessDrawCardResponse)]
	public sealed class JokerGuessDrawCardResponse : IMessage<JokerGuessDrawCardResponse>, IMessage, IEquatable<JokerGuessDrawCardResponse>, IDeepCloneable<JokerGuessDrawCardResponse>, IBufferMessage
	{
		// Token: 0x0600BFEF RID: 49135 RVA: 0x001C7BA5 File Offset: 0x001C5DA5
		[NullableContext(1)]
		public static JokerGuessDrawCardResponse Create()
		{
			return new JokerGuessDrawCardResponse();
		}

		// Token: 0x170026C2 RID: 9922
		// (get) Token: 0x0600BFF0 RID: 49136 RVA: 0x001C7BAC File Offset: 0x001C5DAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170026C3 RID: 9923
		// (get) Token: 0x0600BFF1 RID: 49137 RVA: 0x001C7BAF File Offset: 0x001C5DAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return JokerGuessDrawCardResponse.Descriptor;
			}
		}

		// Token: 0x0600BFF2 RID: 49138 RVA: 0x001C7BB6 File Offset: 0x001C5DB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessDrawCardResponse()
		{
		}

		// Token: 0x0600BFF3 RID: 49139 RVA: 0x001C7BCC File Offset: 0x001C5DCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessDrawCardResponse(JokerGuessDrawCardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.cmd_ = other.cmd_.Clone();
			this.drawCardResult_ = other.drawCardResult_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BFF4 RID: 49140 RVA: 0x001C7C19 File Offset: 0x001C5E19
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessDrawCardResponse Clone()
		{
			return new JokerGuessDrawCardResponse(this);
		}

		// Token: 0x170026C4 RID: 9924
		// (get) Token: 0x0600BFF5 RID: 49141 RVA: 0x001C7C21 File Offset: 0x001C5E21
		// (set) Token: 0x0600BFF6 RID: 49142 RVA: 0x001C7C29 File Offset: 0x001C5E29
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

		// Token: 0x170026C5 RID: 9925
		// (get) Token: 0x0600BFF7 RID: 49143 RVA: 0x001C7C32 File Offset: 0x001C5E32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<JokerGuessOp> Cmd
		{
			get
			{
				return this.cmd_;
			}
		}

		// Token: 0x170026C6 RID: 9926
		// (get) Token: 0x0600BFF8 RID: 49144 RVA: 0x001C7C3A File Offset: 0x001C5E3A
		// (set) Token: 0x0600BFF9 RID: 49145 RVA: 0x001C7C42 File Offset: 0x001C5E42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DrawCardResult
		{
			get
			{
				return this.drawCardResult_;
			}
			set
			{
				this.drawCardResult_ = value;
			}
		}

		// Token: 0x0600BFFA RID: 49146 RVA: 0x001C7C4B File Offset: 0x001C5E4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as JokerGuessDrawCardResponse);
		}

		// Token: 0x0600BFFB RID: 49147 RVA: 0x001C7C5C File Offset: 0x001C5E5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(JokerGuessDrawCardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.cmd_.Equals(other.cmd_) && this.DrawCardResult == other.DrawCardResult && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BFFC RID: 49148 RVA: 0x001C7CBC File Offset: 0x001C5EBC
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
			if (this.DrawCardResult != 0)
			{
				num ^= this.DrawCardResult.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BFFD RID: 49149 RVA: 0x001C7D28 File Offset: 0x001C5F28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BFFE RID: 49150 RVA: 0x001C7D35 File Offset: 0x001C5F35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BFFF RID: 49151 RVA: 0x001C7D40 File Offset: 0x001C5F40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.DrawCardResult != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.DrawCardResult);
			}
			this.cmd_.WriteTo(ref output, JokerGuessDrawCardResponse._repeated_cmd_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C000 RID: 49152 RVA: 0x001C7DAC File Offset: 0x001C5FAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.cmd_.CalculateSize(JokerGuessDrawCardResponse._repeated_cmd_codec);
			if (this.DrawCardResult != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DrawCardResult);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C001 RID: 49153 RVA: 0x001C7E18 File Offset: 0x001C6018
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(JokerGuessDrawCardResponse other)
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
			if (other.DrawCardResult != 0)
			{
				this.DrawCardResult = other.DrawCardResult;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C002 RID: 49154 RVA: 0x001C7E79 File Offset: 0x001C6079
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C003 RID: 49155 RVA: 0x001C7E84 File Offset: 0x001C6084
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
					if (num != 64U)
					{
						if (num != 74U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.cmd_.AddEntriesFrom(ref input, JokerGuessDrawCardResponse._repeated_cmd_codec);
						}
					}
					else
					{
						this.DrawCardResult = input.ReadInt32();
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005375 RID: 21365
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005376 RID: 21366
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x04005377 RID: 21367
		private ErrorCode errorCode_;

		// Token: 0x04005378 RID: 21368
		public const int CmdFieldNumber = 9;

		// Token: 0x04005379 RID: 21369
		private static readonly FieldCodec<JokerGuessOp> _repeated_cmd_codec = FieldCodec.ForMessage<JokerGuessOp>(74U, JokerGuessOp.Parser);

		// Token: 0x0400537A RID: 21370
		private readonly RepeatedField<JokerGuessOp> cmd_ = new RepeatedField<JokerGuessOp>();

		// Token: 0x0400537B RID: 21371
		public const int DrawCardResultFieldNumber = 8;

		// Token: 0x0400537C RID: 21372
		private int drawCardResult_;
	}
}
