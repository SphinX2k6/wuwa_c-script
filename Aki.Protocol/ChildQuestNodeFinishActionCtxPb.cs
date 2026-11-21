using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200028E RID: 654
	public sealed class ChildQuestNodeFinishActionCtxPb : IMessage<ChildQuestNodeFinishActionCtxPb>, IMessage, IEquatable<ChildQuestNodeFinishActionCtxPb>, IDeepCloneable<ChildQuestNodeFinishActionCtxPb>, IBufferMessage
	{
		// Token: 0x06004469 RID: 17513 RVA: 0x000A7B1C File Offset: 0x000A5D1C
		[NullableContext(1)]
		public static ChildQuestNodeFinishActionCtxPb Create()
		{
			return new ChildQuestNodeFinishActionCtxPb();
		}

		// Token: 0x17000BAC RID: 2988
		// (get) Token: 0x0600446A RID: 17514 RVA: 0x000A7B23 File Offset: 0x000A5D23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000BAD RID: 2989
		// (get) Token: 0x0600446B RID: 17515 RVA: 0x000A7B26 File Offset: 0x000A5D26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChildQuestNodeFinishActionCtxPb.Descriptor;
			}
		}

		// Token: 0x0600446C RID: 17516 RVA: 0x000A7B2D File Offset: 0x000A5D2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChildQuestNodeFinishActionCtxPb()
		{
		}

		// Token: 0x0600446D RID: 17517 RVA: 0x000A7B35 File Offset: 0x000A5D35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChildQuestNodeFinishActionCtxPb(ChildQuestNodeFinishActionCtxPb other) : this()
		{
			this.behaviorTreeCtx_ = ((other.behaviorTreeCtx_ != null) ? other.behaviorTreeCtx_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600446E RID: 17518 RVA: 0x000A7B6A File Offset: 0x000A5D6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChildQuestNodeFinishActionCtxPb Clone()
		{
			return new ChildQuestNodeFinishActionCtxPb(this);
		}

		// Token: 0x17000BAE RID: 2990
		// (get) Token: 0x0600446F RID: 17519 RVA: 0x000A7B72 File Offset: 0x000A5D72
		// (set) Token: 0x06004470 RID: 17520 RVA: 0x000A7B7A File Offset: 0x000A5D7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BehaviorTreeCtxPb BehaviorTreeCtx
		{
			get
			{
				return this.behaviorTreeCtx_;
			}
			set
			{
				this.behaviorTreeCtx_ = value;
			}
		}

		// Token: 0x06004471 RID: 17521 RVA: 0x000A7B83 File Offset: 0x000A5D83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChildQuestNodeFinishActionCtxPb);
		}

		// Token: 0x06004472 RID: 17522 RVA: 0x000A7B91 File Offset: 0x000A5D91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChildQuestNodeFinishActionCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.BehaviorTreeCtx, other.BehaviorTreeCtx) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004473 RID: 17523 RVA: 0x000A7BC4 File Offset: 0x000A5DC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.behaviorTreeCtx_ != null)
			{
				num ^= this.BehaviorTreeCtx.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004474 RID: 17524 RVA: 0x000A7C00 File Offset: 0x000A5E00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004475 RID: 17525 RVA: 0x000A7C0D File Offset: 0x000A5E0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004476 RID: 17526 RVA: 0x000A7C16 File Offset: 0x000A5E16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.behaviorTreeCtx_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.BehaviorTreeCtx);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004477 RID: 17527 RVA: 0x000A7C48 File Offset: 0x000A5E48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.behaviorTreeCtx_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BehaviorTreeCtx);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004478 RID: 17528 RVA: 0x000A7C88 File Offset: 0x000A5E88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChildQuestNodeFinishActionCtxPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.behaviorTreeCtx_ != null)
			{
				if (this.behaviorTreeCtx_ == null)
				{
					this.BehaviorTreeCtx = new BehaviorTreeCtxPb();
				}
				this.BehaviorTreeCtx.MergeFrom(other.BehaviorTreeCtx);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004479 RID: 17529 RVA: 0x000A7CDC File Offset: 0x000A5EDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600447A RID: 17530 RVA: 0x000A7CE8 File Offset: 0x000A5EE8
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
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.behaviorTreeCtx_ == null)
					{
						this.BehaviorTreeCtx = new BehaviorTreeCtxPb();
					}
					input.ReadMessage(this.BehaviorTreeCtx);
				}
			}
		}

		// Token: 0x04002EE6 RID: 12006
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002EE7 RID: 12007
		public const int BehaviorTreeCtxFieldNumber = 1;

		// Token: 0x04002EE8 RID: 12008
		private BehaviorTreeCtxPb behaviorTreeCtx_;
	}
}
