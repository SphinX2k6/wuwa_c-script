using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011DF RID: 4575
	[NetMessage(EMessageId.SetQuestResourceStateResponse)]
	public sealed class SetQuestResourceStateResponse : IMessage<SetQuestResourceStateResponse>, IMessage, IEquatable<SetQuestResourceStateResponse>, IDeepCloneable<SetQuestResourceStateResponse>, IBufferMessage
	{
		// Token: 0x06018638 RID: 99896 RVA: 0x0038BDF1 File Offset: 0x00389FF1
		[NullableContext(1)]
		public static SetQuestResourceStateResponse Create()
		{
			return new SetQuestResourceStateResponse();
		}

		// Token: 0x17005219 RID: 21017
		// (get) Token: 0x06018639 RID: 99897 RVA: 0x0038BDF8 File Offset: 0x00389FF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700521A RID: 21018
		// (get) Token: 0x0601863A RID: 99898 RVA: 0x0038BDFB File Offset: 0x00389FFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SetQuestResourceStateResponse.Descriptor;
			}
		}

		// Token: 0x0601863B RID: 99899 RVA: 0x0038BE02 File Offset: 0x0038A002
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetQuestResourceStateResponse()
		{
		}

		// Token: 0x0601863C RID: 99900 RVA: 0x0038BE0A File Offset: 0x0038A00A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetQuestResourceStateResponse(SetQuestResourceStateResponse other) : this()
		{
			this.errorId_ = other.errorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601863D RID: 99901 RVA: 0x0038BE2F File Offset: 0x0038A02F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SetQuestResourceStateResponse Clone()
		{
			return new SetQuestResourceStateResponse(this);
		}

		// Token: 0x1700521B RID: 21019
		// (get) Token: 0x0601863E RID: 99902 RVA: 0x0038BE37 File Offset: 0x0038A037
		// (set) Token: 0x0601863F RID: 99903 RVA: 0x0038BE3F File Offset: 0x0038A03F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorId
		{
			get
			{
				return this.errorId_;
			}
			set
			{
				this.errorId_ = value;
			}
		}

		// Token: 0x06018640 RID: 99904 RVA: 0x0038BE48 File Offset: 0x0038A048
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SetQuestResourceStateResponse);
		}

		// Token: 0x06018641 RID: 99905 RVA: 0x0038BE56 File Offset: 0x0038A056
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SetQuestResourceStateResponse other)
		{
			return other != null && (other == this || (this.ErrorId == other.ErrorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018642 RID: 99906 RVA: 0x0038BE84 File Offset: 0x0038A084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorId != ErrorCode.Success)
			{
				num ^= this.ErrorId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018643 RID: 99907 RVA: 0x0038BEC9 File Offset: 0x0038A0C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018644 RID: 99908 RVA: 0x0038BED6 File Offset: 0x0038A0D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018645 RID: 99909 RVA: 0x0038BEDF File Offset: 0x0038A0DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorId != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018646 RID: 99910 RVA: 0x0038BF14 File Offset: 0x0038A114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorId != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018647 RID: 99911 RVA: 0x0038BF52 File Offset: 0x0038A152
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SetQuestResourceStateResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorId != ErrorCode.Success)
			{
				this.ErrorId = other.ErrorId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018648 RID: 99912 RVA: 0x0038BF83 File Offset: 0x0038A183
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018649 RID: 99913 RVA: 0x0038BF8C File Offset: 0x0038A18C
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
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorId = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009037 RID: 36919
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009038 RID: 36920
		public const int ErrorIdFieldNumber = 7;

		// Token: 0x04009039 RID: 36921
		private ErrorCode errorId_;
	}
}
