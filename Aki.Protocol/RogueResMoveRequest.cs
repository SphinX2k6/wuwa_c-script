using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FF7 RID: 4087
	[NetMessage(EMessageId.RogueResMoveRequest)]
	public sealed class RogueResMoveRequest : IMessage<RogueResMoveRequest>, IMessage, IEquatable<RogueResMoveRequest>, IDeepCloneable<RogueResMoveRequest>, IBufferMessage
	{
		// Token: 0x06015D88 RID: 89480 RVA: 0x0032C464 File Offset: 0x0032A664
		[NullableContext(1)]
		public static RogueResMoveRequest Create()
		{
			return new RogueResMoveRequest();
		}

		// Token: 0x170048EE RID: 18670
		// (get) Token: 0x06015D89 RID: 89481 RVA: 0x0032C46B File Offset: 0x0032A66B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170048EF RID: 18671
		// (get) Token: 0x06015D8A RID: 89482 RVA: 0x0032C46E File Offset: 0x0032A66E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResMoveRequest.Descriptor;
			}
		}

		// Token: 0x06015D8B RID: 89483 RVA: 0x0032C475 File Offset: 0x0032A675
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResMoveRequest()
		{
		}

		// Token: 0x06015D8C RID: 89484 RVA: 0x0032C47D File Offset: 0x0032A67D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResMoveRequest(RogueResMoveRequest other) : this()
		{
			this.moveOp_ = ((other.moveOp_ != null) ? other.moveOp_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015D8D RID: 89485 RVA: 0x0032C4B2 File Offset: 0x0032A6B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResMoveRequest Clone()
		{
			return new RogueResMoveRequest(this);
		}

		// Token: 0x170048F0 RID: 18672
		// (get) Token: 0x06015D8E RID: 89486 RVA: 0x0032C4BA File Offset: 0x0032A6BA
		// (set) Token: 0x06015D8F RID: 89487 RVA: 0x0032C4C2 File Offset: 0x0032A6C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MoveOp MoveOp
		{
			get
			{
				return this.moveOp_;
			}
			set
			{
				this.moveOp_ = value;
			}
		}

		// Token: 0x06015D90 RID: 89488 RVA: 0x0032C4CB File Offset: 0x0032A6CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResMoveRequest);
		}

		// Token: 0x06015D91 RID: 89489 RVA: 0x0032C4D9 File Offset: 0x0032A6D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResMoveRequest other)
		{
			return other != null && (other == this || (object.Equals(this.MoveOp, other.MoveOp) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015D92 RID: 89490 RVA: 0x0032C50C File Offset: 0x0032A70C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.moveOp_ != null)
			{
				num ^= this.MoveOp.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015D93 RID: 89491 RVA: 0x0032C548 File Offset: 0x0032A748
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015D94 RID: 89492 RVA: 0x0032C555 File Offset: 0x0032A755
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015D95 RID: 89493 RVA: 0x0032C55E File Offset: 0x0032A75E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.moveOp_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.MoveOp);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015D96 RID: 89494 RVA: 0x0032C590 File Offset: 0x0032A790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.moveOp_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MoveOp);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015D97 RID: 89495 RVA: 0x0032C5D0 File Offset: 0x0032A7D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResMoveRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.moveOp_ != null)
			{
				if (this.moveOp_ == null)
				{
					this.MoveOp = new MoveOp();
				}
				this.MoveOp.MergeFrom(other.MoveOp);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015D98 RID: 89496 RVA: 0x0032C624 File Offset: 0x0032A824
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015D99 RID: 89497 RVA: 0x0032C630 File Offset: 0x0032A830
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
				if (num != 18U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.moveOp_ == null)
					{
						this.MoveOp = new MoveOp();
					}
					input.ReadMessage(this.MoveOp);
				}
			}
		}

		// Token: 0x0400830E RID: 33550
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400830F RID: 33551
		public const int MoveOpFieldNumber = 2;

		// Token: 0x04008310 RID: 33552
		private MoveOp moveOp_;
	}
}
