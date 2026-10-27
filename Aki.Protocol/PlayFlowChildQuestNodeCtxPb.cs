using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DC2 RID: 3522
	public sealed class PlayFlowChildQuestNodeCtxPb : IMessage<PlayFlowChildQuestNodeCtxPb>, IMessage, IEquatable<PlayFlowChildQuestNodeCtxPb>, IDeepCloneable<PlayFlowChildQuestNodeCtxPb>, IBufferMessage
	{
		// Token: 0x06012F7B RID: 77691 RVA: 0x002C4070 File Offset: 0x002C2270
		[NullableContext(1)]
		public static PlayFlowChildQuestNodeCtxPb Create()
		{
			return new PlayFlowChildQuestNodeCtxPb();
		}

		// Token: 0x17003EF3 RID: 16115
		// (get) Token: 0x06012F7C RID: 77692 RVA: 0x002C4077 File Offset: 0x002C2277
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003EF4 RID: 16116
		// (get) Token: 0x06012F7D RID: 77693 RVA: 0x002C407A File Offset: 0x002C227A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayFlowChildQuestNodeCtxPb.Descriptor;
			}
		}

		// Token: 0x06012F7E RID: 77694 RVA: 0x002C4081 File Offset: 0x002C2281
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayFlowChildQuestNodeCtxPb()
		{
		}

		// Token: 0x06012F7F RID: 77695 RVA: 0x002C4089 File Offset: 0x002C2289
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayFlowChildQuestNodeCtxPb(PlayFlowChildQuestNodeCtxPb other) : this()
		{
			this.behaviorTreeCtx_ = ((other.behaviorTreeCtx_ != null) ? other.behaviorTreeCtx_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012F80 RID: 77696 RVA: 0x002C40BE File Offset: 0x002C22BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayFlowChildQuestNodeCtxPb Clone()
		{
			return new PlayFlowChildQuestNodeCtxPb(this);
		}

		// Token: 0x17003EF5 RID: 16117
		// (get) Token: 0x06012F81 RID: 77697 RVA: 0x002C40C6 File Offset: 0x002C22C6
		// (set) Token: 0x06012F82 RID: 77698 RVA: 0x002C40CE File Offset: 0x002C22CE
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

		// Token: 0x06012F83 RID: 77699 RVA: 0x002C40D7 File Offset: 0x002C22D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayFlowChildQuestNodeCtxPb);
		}

		// Token: 0x06012F84 RID: 77700 RVA: 0x002C40E5 File Offset: 0x002C22E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayFlowChildQuestNodeCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.BehaviorTreeCtx, other.BehaviorTreeCtx) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012F85 RID: 77701 RVA: 0x002C4118 File Offset: 0x002C2318
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

		// Token: 0x06012F86 RID: 77702 RVA: 0x002C4154 File Offset: 0x002C2354
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012F87 RID: 77703 RVA: 0x002C4161 File Offset: 0x002C2361
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012F88 RID: 77704 RVA: 0x002C416A File Offset: 0x002C236A
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

		// Token: 0x06012F89 RID: 77705 RVA: 0x002C419C File Offset: 0x002C239C
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

		// Token: 0x06012F8A RID: 77706 RVA: 0x002C41DC File Offset: 0x002C23DC
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

		// Token: 0x06012F8B RID: 77707 RVA: 0x002C4230 File Offset: 0x002C2430
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012F8C RID: 77708 RVA: 0x002C423C File Offset: 0x002C243C
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

		// Token: 0x0400753F RID: 30015
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007540 RID: 30016
		public const int BehaviorTreeCtxFieldNumber = 1;

		// Token: 0x04007541 RID: 30017
		private BehaviorTreeCtxPb behaviorTreeCtx_;
	}
}
