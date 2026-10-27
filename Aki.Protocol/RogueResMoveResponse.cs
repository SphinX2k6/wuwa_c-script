using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FF8 RID: 4088
	[NetMessage(EMessageId.RogueResMoveResponse)]
	public sealed class RogueResMoveResponse : IMessage<RogueResMoveResponse>, IMessage, IEquatable<RogueResMoveResponse>, IDeepCloneable<RogueResMoveResponse>, IBufferMessage
	{
		// Token: 0x06015D9A RID: 89498 RVA: 0x0032C688 File Offset: 0x0032A888
		[NullableContext(1)]
		public static RogueResMoveResponse Create()
		{
			return new RogueResMoveResponse();
		}

		// Token: 0x170048F1 RID: 18673
		// (get) Token: 0x06015D9B RID: 89499 RVA: 0x0032C68F File Offset: 0x0032A88F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170048F2 RID: 18674
		// (get) Token: 0x06015D9C RID: 89500 RVA: 0x0032C692 File Offset: 0x0032A892
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResMoveResponse.Descriptor;
			}
		}

		// Token: 0x06015D9D RID: 89501 RVA: 0x0032C699 File Offset: 0x0032A899
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResMoveResponse()
		{
		}

		// Token: 0x06015D9E RID: 89502 RVA: 0x0032C6A1 File Offset: 0x0032A8A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResMoveResponse(RogueResMoveResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015D9F RID: 89503 RVA: 0x0032C6C6 File Offset: 0x0032A8C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResMoveResponse Clone()
		{
			return new RogueResMoveResponse(this);
		}

		// Token: 0x170048F3 RID: 18675
		// (get) Token: 0x06015DA0 RID: 89504 RVA: 0x0032C6CE File Offset: 0x0032A8CE
		// (set) Token: 0x06015DA1 RID: 89505 RVA: 0x0032C6D6 File Offset: 0x0032A8D6
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

		// Token: 0x06015DA2 RID: 89506 RVA: 0x0032C6DF File Offset: 0x0032A8DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResMoveResponse);
		}

		// Token: 0x06015DA3 RID: 89507 RVA: 0x0032C6ED File Offset: 0x0032A8ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResMoveResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015DA4 RID: 89508 RVA: 0x0032C71C File Offset: 0x0032A91C
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

		// Token: 0x06015DA5 RID: 89509 RVA: 0x0032C761 File Offset: 0x0032A961
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015DA6 RID: 89510 RVA: 0x0032C76E File Offset: 0x0032A96E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015DA7 RID: 89511 RVA: 0x0032C777 File Offset: 0x0032A977
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015DA8 RID: 89512 RVA: 0x0032C7AC File Offset: 0x0032A9AC
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

		// Token: 0x06015DA9 RID: 89513 RVA: 0x0032C7EA File Offset: 0x0032A9EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResMoveResponse other)
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

		// Token: 0x06015DAA RID: 89514 RVA: 0x0032C81B File Offset: 0x0032AA1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015DAB RID: 89515 RVA: 0x0032C824 File Offset: 0x0032AA24
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008311 RID: 33553
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008312 RID: 33554
		public const int ErrCodeFieldNumber = 8;

		// Token: 0x04008313 RID: 33555
		private ErrorCode errCode_;
	}
}
