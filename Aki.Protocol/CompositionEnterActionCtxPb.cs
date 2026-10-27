using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002C5 RID: 709
	public sealed class CompositionEnterActionCtxPb : IMessage<CompositionEnterActionCtxPb>, IMessage, IEquatable<CompositionEnterActionCtxPb>, IDeepCloneable<CompositionEnterActionCtxPb>, IBufferMessage
	{
		// Token: 0x060048DE RID: 18654 RVA: 0x000B255F File Offset: 0x000B075F
		[NullableContext(1)]
		public static CompositionEnterActionCtxPb Create()
		{
			return new CompositionEnterActionCtxPb();
		}

		// Token: 0x17000CB8 RID: 3256
		// (get) Token: 0x060048DF RID: 18655 RVA: 0x000B2566 File Offset: 0x000B0766
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000CB9 RID: 3257
		// (get) Token: 0x060048E0 RID: 18656 RVA: 0x000B2569 File Offset: 0x000B0769
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CompositionEnterActionCtxPb.Descriptor;
			}
		}

		// Token: 0x060048E1 RID: 18657 RVA: 0x000B2570 File Offset: 0x000B0770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CompositionEnterActionCtxPb()
		{
		}

		// Token: 0x060048E2 RID: 18658 RVA: 0x000B2578 File Offset: 0x000B0778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CompositionEnterActionCtxPb(CompositionEnterActionCtxPb other) : this()
		{
			this.behaviorTreeCtx_ = ((other.behaviorTreeCtx_ != null) ? other.behaviorTreeCtx_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060048E3 RID: 18659 RVA: 0x000B25AD File Offset: 0x000B07AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CompositionEnterActionCtxPb Clone()
		{
			return new CompositionEnterActionCtxPb(this);
		}

		// Token: 0x17000CBA RID: 3258
		// (get) Token: 0x060048E4 RID: 18660 RVA: 0x000B25B5 File Offset: 0x000B07B5
		// (set) Token: 0x060048E5 RID: 18661 RVA: 0x000B25BD File Offset: 0x000B07BD
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

		// Token: 0x060048E6 RID: 18662 RVA: 0x000B25C6 File Offset: 0x000B07C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CompositionEnterActionCtxPb);
		}

		// Token: 0x060048E7 RID: 18663 RVA: 0x000B25D4 File Offset: 0x000B07D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CompositionEnterActionCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.BehaviorTreeCtx, other.BehaviorTreeCtx) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060048E8 RID: 18664 RVA: 0x000B2608 File Offset: 0x000B0808
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

		// Token: 0x060048E9 RID: 18665 RVA: 0x000B2644 File Offset: 0x000B0844
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060048EA RID: 18666 RVA: 0x000B2651 File Offset: 0x000B0851
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060048EB RID: 18667 RVA: 0x000B265A File Offset: 0x000B085A
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

		// Token: 0x060048EC RID: 18668 RVA: 0x000B268C File Offset: 0x000B088C
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

		// Token: 0x060048ED RID: 18669 RVA: 0x000B26CC File Offset: 0x000B08CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CompositionEnterActionCtxPb other)
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

		// Token: 0x060048EE RID: 18670 RVA: 0x000B2720 File Offset: 0x000B0920
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060048EF RID: 18671 RVA: 0x000B272C File Offset: 0x000B092C
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

		// Token: 0x04002FFB RID: 12283
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002FFC RID: 12284
		public const int BehaviorTreeCtxFieldNumber = 1;

		// Token: 0x04002FFD RID: 12285
		private BehaviorTreeCtxPb behaviorTreeCtx_;
	}
}
