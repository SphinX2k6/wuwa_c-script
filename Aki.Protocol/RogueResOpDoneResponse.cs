using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FFD RID: 4093
	[NetMessage(EMessageId.RogueResOpDoneResponse)]
	public sealed class RogueResOpDoneResponse : IMessage<RogueResOpDoneResponse>, IMessage, IEquatable<RogueResOpDoneResponse>, IDeepCloneable<RogueResOpDoneResponse>, IBufferMessage
	{
		// Token: 0x06015E14 RID: 89620 RVA: 0x0032DF09 File Offset: 0x0032C109
		[NullableContext(1)]
		public static RogueResOpDoneResponse Create()
		{
			return new RogueResOpDoneResponse();
		}

		// Token: 0x17004911 RID: 18705
		// (get) Token: 0x06015E15 RID: 89621 RVA: 0x0032DF10 File Offset: 0x0032C110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004912 RID: 18706
		// (get) Token: 0x06015E16 RID: 89622 RVA: 0x0032DF13 File Offset: 0x0032C113
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResOpDoneResponse.Descriptor;
			}
		}

		// Token: 0x06015E17 RID: 89623 RVA: 0x0032DF1A File Offset: 0x0032C11A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResOpDoneResponse()
		{
		}

		// Token: 0x06015E18 RID: 89624 RVA: 0x0032DF22 File Offset: 0x0032C122
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResOpDoneResponse(RogueResOpDoneResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015E19 RID: 89625 RVA: 0x0032DF47 File Offset: 0x0032C147
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResOpDoneResponse Clone()
		{
			return new RogueResOpDoneResponse(this);
		}

		// Token: 0x17004913 RID: 18707
		// (get) Token: 0x06015E1A RID: 89626 RVA: 0x0032DF4F File Offset: 0x0032C14F
		// (set) Token: 0x06015E1B RID: 89627 RVA: 0x0032DF57 File Offset: 0x0032C157
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrCode
		{
			get
			{
				return this.errCode_;
			}
			set
			{
				this.errCode_ = value;
			}
		}

		// Token: 0x06015E1C RID: 89628 RVA: 0x0032DF60 File Offset: 0x0032C160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResOpDoneResponse);
		}

		// Token: 0x06015E1D RID: 89629 RVA: 0x0032DF6E File Offset: 0x0032C16E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResOpDoneResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015E1E RID: 89630 RVA: 0x0032DF9C File Offset: 0x0032C19C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrCode != ErrorCode.Success)
			{
				num ^= this.ErrCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015E1F RID: 89631 RVA: 0x0032DFE1 File Offset: 0x0032C1E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015E20 RID: 89632 RVA: 0x0032DFEE File Offset: 0x0032C1EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015E21 RID: 89633 RVA: 0x0032DFF7 File Offset: 0x0032C1F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015E22 RID: 89634 RVA: 0x0032E02C File Offset: 0x0032C22C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015E23 RID: 89635 RVA: 0x0032E06A File Offset: 0x0032C26A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResOpDoneResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrCode != ErrorCode.Success)
			{
				this.ErrCode = other.ErrCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015E24 RID: 89636 RVA: 0x0032E09B File Offset: 0x0032C29B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015E25 RID: 89637 RVA: 0x0032E0A4 File Offset: 0x0032C2A4
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400833C RID: 33596
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400833D RID: 33597
		public const int ErrCodeFieldNumber = 14;

		// Token: 0x0400833E RID: 33598
		private ErrorCode errCode_;
	}
}
