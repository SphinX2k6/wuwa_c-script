using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200085A RID: 2138
	[NetMessage(EMessageId.JokerGuessDrawCardResponse)]
	public sealed class JokerGuessDrawCardResponse : IMessage<JokerGuessDrawCardResponse>, IMessage, IEquatable<JokerGuessDrawCardResponse>, IDeepCloneable<JokerGuessDrawCardResponse>, IBufferMessage
	{
		// Token: 0x0600BED3 RID: 48851 RVA: 0x001C58BD File Offset: 0x001C3ABD
		[NullableContext(1)]
		public static JokerGuessDrawCardResponse Create()
		{
			return new JokerGuessDrawCardResponse();
		}

		// Token: 0x17002683 RID: 9859
		// (get) Token: 0x0600BED4 RID: 48852 RVA: 0x001C58C4 File Offset: 0x001C3AC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002684 RID: 9860
		// (get) Token: 0x0600BED5 RID: 48853 RVA: 0x001C58C7 File Offset: 0x001C3AC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return JokerGuessDrawCardResponse.Descriptor;
			}
		}

		// Token: 0x0600BED6 RID: 48854 RVA: 0x001C58CE File Offset: 0x001C3ACE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessDrawCardResponse()
		{
		}

		// Token: 0x0600BED7 RID: 48855 RVA: 0x001C58E4 File Offset: 0x001C3AE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessDrawCardResponse(JokerGuessDrawCardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.cmd_ = other.cmd_.Clone();
			this.drawCardResult_ = other.drawCardResult_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BED8 RID: 48856 RVA: 0x001C5931 File Offset: 0x001C3B31
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessDrawCardResponse Clone()
		{
			return new JokerGuessDrawCardResponse(this);
		}

		// Token: 0x17002685 RID: 9861
		// (get) Token: 0x0600BED9 RID: 48857 RVA: 0x001C5939 File Offset: 0x001C3B39
		// (set) Token: 0x0600BEDA RID: 48858 RVA: 0x001C5941 File Offset: 0x001C3B41
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

		// Token: 0x17002686 RID: 9862
		// (get) Token: 0x0600BEDB RID: 48859 RVA: 0x001C594A File Offset: 0x001C3B4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<JokerGuessOp> Cmd
		{
			get
			{
				return this.cmd_;
			}
		}

		// Token: 0x17002687 RID: 9863
		// (get) Token: 0x0600BEDC RID: 48860 RVA: 0x001C5952 File Offset: 0x001C3B52
		// (set) Token: 0x0600BEDD RID: 48861 RVA: 0x001C595A File Offset: 0x001C3B5A
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

		// Token: 0x0600BEDE RID: 48862 RVA: 0x001C5963 File Offset: 0x001C3B63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as JokerGuessDrawCardResponse);
		}

		// Token: 0x0600BEDF RID: 48863 RVA: 0x001C5974 File Offset: 0x001C3B74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(JokerGuessDrawCardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.cmd_.Equals(other.cmd_) && this.DrawCardResult == other.DrawCardResult && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BEE0 RID: 48864 RVA: 0x001C59D4 File Offset: 0x001C3BD4
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

		// Token: 0x0600BEE1 RID: 48865 RVA: 0x001C5A40 File Offset: 0x001C3C40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BEE2 RID: 48866 RVA: 0x001C5A4D File Offset: 0x001C3C4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BEE3 RID: 48867 RVA: 0x001C5A58 File Offset: 0x001C3C58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DrawCardResult != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.DrawCardResult);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.cmd_.WriteTo(ref output, JokerGuessDrawCardResponse._repeated_cmd_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BEE4 RID: 48868 RVA: 0x001C5AC4 File Offset: 0x001C3CC4
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

		// Token: 0x0600BEE5 RID: 48869 RVA: 0x001C5B30 File Offset: 0x001C3D30
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

		// Token: 0x0600BEE6 RID: 48870 RVA: 0x001C5B91 File Offset: 0x001C3D91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BEE7 RID: 48871 RVA: 0x001C5B9C File Offset: 0x001C3D9C
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
					if (num != 80U)
					{
						if (num != 90U)
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
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.DrawCardResult = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400537C RID: 21372
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400537D RID: 21373
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x0400537E RID: 21374
		private ErrorCode errorCode_;

		// Token: 0x0400537F RID: 21375
		public const int CmdFieldNumber = 11;

		// Token: 0x04005380 RID: 21376
		private static readonly FieldCodec<JokerGuessOp> _repeated_cmd_codec = FieldCodec.ForMessage<JokerGuessOp>(90U, JokerGuessOp.Parser);

		// Token: 0x04005381 RID: 21377
		private readonly RepeatedField<JokerGuessOp> cmd_ = new RepeatedField<JokerGuessOp>();

		// Token: 0x04005382 RID: 21378
		public const int DrawCardResultFieldNumber = 1;

		// Token: 0x04005383 RID: 21379
		private int drawCardResult_;
	}
}
