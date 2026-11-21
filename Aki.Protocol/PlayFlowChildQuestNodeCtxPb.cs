using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DB2 RID: 3506
	public sealed class PlayFlowChildQuestNodeCtxPb : IMessage<PlayFlowChildQuestNodeCtxPb>, IMessage, IEquatable<PlayFlowChildQuestNodeCtxPb>, IDeepCloneable<PlayFlowChildQuestNodeCtxPb>, IBufferMessage
	{
		// Token: 0x06012E7F RID: 77439 RVA: 0x002C244B File Offset: 0x002C064B
		[NullableContext(1)]
		public static PlayFlowChildQuestNodeCtxPb Create()
		{
			return new PlayFlowChildQuestNodeCtxPb();
		}

		// Token: 0x17003EBE RID: 16062
		// (get) Token: 0x06012E80 RID: 77440 RVA: 0x002C2452 File Offset: 0x002C0652
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003EBF RID: 16063
		// (get) Token: 0x06012E81 RID: 77441 RVA: 0x002C2455 File Offset: 0x002C0655
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayFlowChildQuestNodeCtxPb.Descriptor;
			}
		}

		// Token: 0x06012E82 RID: 77442 RVA: 0x002C245C File Offset: 0x002C065C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayFlowChildQuestNodeCtxPb()
		{
		}

		// Token: 0x06012E83 RID: 77443 RVA: 0x002C2464 File Offset: 0x002C0664
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayFlowChildQuestNodeCtxPb(PlayFlowChildQuestNodeCtxPb other) : this()
		{
			this.behaviorTreeCtx_ = ((other.behaviorTreeCtx_ != null) ? other.behaviorTreeCtx_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012E84 RID: 77444 RVA: 0x002C2499 File Offset: 0x002C0699
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayFlowChildQuestNodeCtxPb Clone()
		{
			return new PlayFlowChildQuestNodeCtxPb(this);
		}

		// Token: 0x17003EC0 RID: 16064
		// (get) Token: 0x06012E85 RID: 77445 RVA: 0x002C24A1 File Offset: 0x002C06A1
		// (set) Token: 0x06012E86 RID: 77446 RVA: 0x002C24A9 File Offset: 0x002C06A9
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

		// Token: 0x06012E87 RID: 77447 RVA: 0x002C24B2 File Offset: 0x002C06B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayFlowChildQuestNodeCtxPb);
		}

		// Token: 0x06012E88 RID: 77448 RVA: 0x002C24C0 File Offset: 0x002C06C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayFlowChildQuestNodeCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.BehaviorTreeCtx, other.BehaviorTreeCtx) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012E89 RID: 77449 RVA: 0x002C24F4 File Offset: 0x002C06F4
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

		// Token: 0x06012E8A RID: 77450 RVA: 0x002C2530 File Offset: 0x002C0730
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012E8B RID: 77451 RVA: 0x002C253D File Offset: 0x002C073D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012E8C RID: 77452 RVA: 0x002C2546 File Offset: 0x002C0746
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

		// Token: 0x06012E8D RID: 77453 RVA: 0x002C2578 File Offset: 0x002C0778
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

		// Token: 0x06012E8E RID: 77454 RVA: 0x002C25B8 File Offset: 0x002C07B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayFlowChildQuestNodeCtxPb other)
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

		// Token: 0x06012E8F RID: 77455 RVA: 0x002C260C File Offset: 0x002C080C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012E90 RID: 77456 RVA: 0x002C2618 File Offset: 0x002C0818
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

		// Token: 0x04007557 RID: 30039
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007558 RID: 30040
		public const int BehaviorTreeCtxFieldNumber = 1;

		// Token: 0x04007559 RID: 30041
		private BehaviorTreeCtxPb behaviorTreeCtx_;
	}
}
