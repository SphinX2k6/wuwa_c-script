using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000862 RID: 2146
	[NetMessage(EMessageId.JokerGuessRewardResponse)]
	public sealed class JokerGuessRewardResponse : IMessage<JokerGuessRewardResponse>, IMessage, IEquatable<JokerGuessRewardResponse>, IDeepCloneable<JokerGuessRewardResponse>, IBufferMessage
	{
		// Token: 0x0600BF89 RID: 49033 RVA: 0x001C77B5 File Offset: 0x001C59B5
		[NullableContext(1)]
		public static JokerGuessRewardResponse Create()
		{
			return new JokerGuessRewardResponse();
		}

		// Token: 0x170026AE RID: 9902
		// (get) Token: 0x0600BF8A RID: 49034 RVA: 0x001C77BC File Offset: 0x001C59BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170026AF RID: 9903
		// (get) Token: 0x0600BF8B RID: 49035 RVA: 0x001C77BF File Offset: 0x001C59BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return JokerGuessRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600BF8C RID: 49036 RVA: 0x001C77C6 File Offset: 0x001C59C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessRewardResponse()
		{
		}

		// Token: 0x0600BF8D RID: 49037 RVA: 0x001C77CE File Offset: 0x001C59CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessRewardResponse(JokerGuessRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BF8E RID: 49038 RVA: 0x001C77F3 File Offset: 0x001C59F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessRewardResponse Clone()
		{
			return new JokerGuessRewardResponse(this);
		}

		// Token: 0x170026B0 RID: 9904
		// (get) Token: 0x0600BF8F RID: 49039 RVA: 0x001C77FB File Offset: 0x001C59FB
		// (set) Token: 0x0600BF90 RID: 49040 RVA: 0x001C7803 File Offset: 0x001C5A03
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

		// Token: 0x0600BF91 RID: 49041 RVA: 0x001C780C File Offset: 0x001C5A0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as JokerGuessRewardResponse);
		}

		// Token: 0x0600BF92 RID: 49042 RVA: 0x001C781A File Offset: 0x001C5A1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(JokerGuessRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BF93 RID: 49043 RVA: 0x001C7848 File Offset: 0x001C5A48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BF94 RID: 49044 RVA: 0x001C788D File Offset: 0x001C5A8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BF95 RID: 49045 RVA: 0x001C789A File Offset: 0x001C5A9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BF96 RID: 49046 RVA: 0x001C78A3 File Offset: 0x001C5AA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BF97 RID: 49047 RVA: 0x001C78D8 File Offset: 0x001C5AD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BF98 RID: 49048 RVA: 0x001C7916 File Offset: 0x001C5B16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(JokerGuessRewardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BF99 RID: 49049 RVA: 0x001C7947 File Offset: 0x001C5B47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BF9A RID: 49050 RVA: 0x001C7950 File Offset: 0x001C5B50
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040053B1 RID: 21425
		private UnknownFieldSet _unknownFields;

		// Token: 0x040053B2 RID: 21426
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x040053B3 RID: 21427
		private ErrorCode errorCode_;
	}
}
