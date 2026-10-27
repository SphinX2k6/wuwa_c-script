using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200102D RID: 4141
	[NetMessage(EMessageId.RogueWeeklyArtifactSelectResponse)]
	public sealed class RogueWeeklyArtifactSelectResponse : IMessage<RogueWeeklyArtifactSelectResponse>, IMessage, IEquatable<RogueWeeklyArtifactSelectResponse>, IDeepCloneable<RogueWeeklyArtifactSelectResponse>, IBufferMessage
	{
		// Token: 0x06016213 RID: 90643 RVA: 0x0033703C File Offset: 0x0033523C
		[NullableContext(1)]
		public static RogueWeeklyArtifactSelectResponse Create()
		{
			return new RogueWeeklyArtifactSelectResponse();
		}

		// Token: 0x170049F5 RID: 18933
		// (get) Token: 0x06016214 RID: 90644 RVA: 0x00337043 File Offset: 0x00335243
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170049F6 RID: 18934
		// (get) Token: 0x06016215 RID: 90645 RVA: 0x00337046 File Offset: 0x00335246
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueWeeklyArtifactSelectResponse.Descriptor;
			}
		}

		// Token: 0x06016216 RID: 90646 RVA: 0x0033704D File Offset: 0x0033524D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyArtifactSelectResponse()
		{
		}

		// Token: 0x06016217 RID: 90647 RVA: 0x00337055 File Offset: 0x00335255
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyArtifactSelectResponse(RogueWeeklyArtifactSelectResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016218 RID: 90648 RVA: 0x0033707A File Offset: 0x0033527A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueWeeklyArtifactSelectResponse Clone()
		{
			return new RogueWeeklyArtifactSelectResponse(this);
		}

		// Token: 0x170049F7 RID: 18935
		// (get) Token: 0x06016219 RID: 90649 RVA: 0x00337082 File Offset: 0x00335282
		// (set) Token: 0x0601621A RID: 90650 RVA: 0x0033708A File Offset: 0x0033528A
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

		// Token: 0x0601621B RID: 90651 RVA: 0x00337093 File Offset: 0x00335293
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueWeeklyArtifactSelectResponse);
		}

		// Token: 0x0601621C RID: 90652 RVA: 0x003370A1 File Offset: 0x003352A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueWeeklyArtifactSelectResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601621D RID: 90653 RVA: 0x003370D0 File Offset: 0x003352D0
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

		// Token: 0x0601621E RID: 90654 RVA: 0x00337115 File Offset: 0x00335315
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601621F RID: 90655 RVA: 0x00337122 File Offset: 0x00335322
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016220 RID: 90656 RVA: 0x0033712B File Offset: 0x0033532B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016221 RID: 90657 RVA: 0x00337160 File Offset: 0x00335360
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

		// Token: 0x06016222 RID: 90658 RVA: 0x0033719E File Offset: 0x0033539E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueWeeklyArtifactSelectResponse other)
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

		// Token: 0x06016223 RID: 90659 RVA: 0x003371CF File Offset: 0x003353CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016224 RID: 90660 RVA: 0x003371D8 File Offset: 0x003353D8
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400847F RID: 33919
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008480 RID: 33920
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x04008481 RID: 33921
		private ErrorCode errorCode_;
	}
}
