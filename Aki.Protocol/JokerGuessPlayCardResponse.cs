using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000860 RID: 2144
	[NetMessage(EMessageId.JokerGuessPlayCardResponse)]
	public sealed class JokerGuessPlayCardResponse : IMessage<JokerGuessPlayCardResponse>, IMessage, IEquatable<JokerGuessPlayCardResponse>, IDeepCloneable<JokerGuessPlayCardResponse>, IBufferMessage
	{
		// Token: 0x0600BF63 RID: 48995 RVA: 0x001C7328 File Offset: 0x001C5528
		[NullableContext(1)]
		public static JokerGuessPlayCardResponse Create()
		{
			return new JokerGuessPlayCardResponse();
		}

		// Token: 0x170026A7 RID: 9895
		// (get) Token: 0x0600BF64 RID: 48996 RVA: 0x001C732F File Offset: 0x001C552F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170026A8 RID: 9896
		// (get) Token: 0x0600BF65 RID: 48997 RVA: 0x001C7332 File Offset: 0x001C5532
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return JokerGuessPlayCardResponse.Descriptor;
			}
		}

		// Token: 0x0600BF66 RID: 48998 RVA: 0x001C7339 File Offset: 0x001C5539
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessPlayCardResponse()
		{
		}

		// Token: 0x0600BF67 RID: 48999 RVA: 0x001C734C File Offset: 0x001C554C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessPlayCardResponse(JokerGuessPlayCardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.cmd_ = other.cmd_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BF68 RID: 49000 RVA: 0x001C7382 File Offset: 0x001C5582
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessPlayCardResponse Clone()
		{
			return new JokerGuessPlayCardResponse(this);
		}

		// Token: 0x170026A9 RID: 9897
		// (get) Token: 0x0600BF69 RID: 49001 RVA: 0x001C738A File Offset: 0x001C558A
		// (set) Token: 0x0600BF6A RID: 49002 RVA: 0x001C7392 File Offset: 0x001C5592
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

		// Token: 0x170026AA RID: 9898
		// (get) Token: 0x0600BF6B RID: 49003 RVA: 0x001C739B File Offset: 0x001C559B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<JokerGuessOp> Cmd
		{
			get
			{
				return this.cmd_;
			}
		}

		// Token: 0x0600BF6C RID: 49004 RVA: 0x001C73A3 File Offset: 0x001C55A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as JokerGuessPlayCardResponse);
		}

		// Token: 0x0600BF6D RID: 49005 RVA: 0x001C73B4 File Offset: 0x001C55B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(JokerGuessPlayCardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.cmd_.Equals(other.cmd_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BF6E RID: 49006 RVA: 0x001C7404 File Offset: 0x001C5604
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

		// Token: 0x0600BF6F RID: 49007 RVA: 0x001C7457 File Offset: 0x001C5657
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BF70 RID: 49008 RVA: 0x001C7464 File Offset: 0x001C5664
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BF71 RID: 49009 RVA: 0x001C7470 File Offset: 0x001C5670
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.cmd_.WriteTo(ref output, JokerGuessPlayCardResponse._repeated_cmd_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BF72 RID: 49010 RVA: 0x001C74C0 File Offset: 0x001C56C0
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

		// Token: 0x0600BF73 RID: 49011 RVA: 0x001C7514 File Offset: 0x001C5714
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

		// Token: 0x0600BF74 RID: 49012 RVA: 0x001C7561 File Offset: 0x001C5761
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BF75 RID: 49013 RVA: 0x001C756C File Offset: 0x001C576C
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
				if (num != 16U)
				{
					if (num != 106U)
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

		// Token: 0x040053A8 RID: 21416
		private UnknownFieldSet _unknownFields;

		// Token: 0x040053A9 RID: 21417
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x040053AA RID: 21418
		private ErrorCode errorCode_;

		// Token: 0x040053AB RID: 21419
		public const int CmdFieldNumber = 13;

		// Token: 0x040053AC RID: 21420
		private static readonly FieldCodec<JokerGuessOp> _repeated_cmd_codec = FieldCodec.ForMessage<JokerGuessOp>(106U, JokerGuessOp.Parser);

		// Token: 0x040053AD RID: 21421
		private readonly RepeatedField<JokerGuessOp> cmd_ = new RepeatedField<JokerGuessOp>();
	}
}
