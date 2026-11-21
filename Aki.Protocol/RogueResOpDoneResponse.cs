using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FED RID: 4077
	[NetMessage(EMessageId.RogueResOpDoneResponse)]
	public sealed class RogueResOpDoneResponse : IMessage<RogueResOpDoneResponse>, IMessage, IEquatable<RogueResOpDoneResponse>, IDeepCloneable<RogueResOpDoneResponse>, IBufferMessage
	{
		// Token: 0x06015D2F RID: 89391 RVA: 0x0032C846 File Offset: 0x0032AA46
		[NullableContext(1)]
		public static RogueResOpDoneResponse Create()
		{
			return new RogueResOpDoneResponse();
		}

		// Token: 0x170048E7 RID: 18663
		// (get) Token: 0x06015D30 RID: 89392 RVA: 0x0032C84D File Offset: 0x0032AA4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170048E8 RID: 18664
		// (get) Token: 0x06015D31 RID: 89393 RVA: 0x0032C850 File Offset: 0x0032AA50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResOpDoneResponse.Descriptor;
			}
		}

		// Token: 0x06015D32 RID: 89394 RVA: 0x0032C857 File Offset: 0x0032AA57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResOpDoneResponse()
		{
		}

		// Token: 0x06015D33 RID: 89395 RVA: 0x0032C85F File Offset: 0x0032AA5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResOpDoneResponse(RogueResOpDoneResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015D34 RID: 89396 RVA: 0x0032C884 File Offset: 0x0032AA84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResOpDoneResponse Clone()
		{
			return new RogueResOpDoneResponse(this);
		}

		// Token: 0x170048E9 RID: 18665
		// (get) Token: 0x06015D35 RID: 89397 RVA: 0x0032C88C File Offset: 0x0032AA8C
		// (set) Token: 0x06015D36 RID: 89398 RVA: 0x0032C894 File Offset: 0x0032AA94
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

		// Token: 0x06015D37 RID: 89399 RVA: 0x0032C89D File Offset: 0x0032AA9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResOpDoneResponse);
		}

		// Token: 0x06015D38 RID: 89400 RVA: 0x0032C8AB File Offset: 0x0032AAAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResOpDoneResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015D39 RID: 89401 RVA: 0x0032C8DC File Offset: 0x0032AADC
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

		// Token: 0x06015D3A RID: 89402 RVA: 0x0032C921 File Offset: 0x0032AB21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015D3B RID: 89403 RVA: 0x0032C92E File Offset: 0x0032AB2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015D3C RID: 89404 RVA: 0x0032C937 File Offset: 0x0032AB37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015D3D RID: 89405 RVA: 0x0032C96C File Offset: 0x0032AB6C
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

		// Token: 0x06015D3E RID: 89406 RVA: 0x0032C9AA File Offset: 0x0032ABAA
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

		// Token: 0x06015D3F RID: 89407 RVA: 0x0032C9DB File Offset: 0x0032ABDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015D40 RID: 89408 RVA: 0x0032C9E4 File Offset: 0x0032ABE4
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
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008366 RID: 33638
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008367 RID: 33639
		public const int ErrCodeFieldNumber = 12;

		// Token: 0x04008368 RID: 33640
		private ErrorCode errCode_;
	}
}
