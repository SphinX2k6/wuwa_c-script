using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002C4 RID: 708
	public sealed class CompositionConditionEnterActionCtxPb : IMessage<CompositionConditionEnterActionCtxPb>, IMessage, IEquatable<CompositionConditionEnterActionCtxPb>, IDeepCloneable<CompositionConditionEnterActionCtxPb>, IBufferMessage
	{
		// Token: 0x060048CA RID: 18634 RVA: 0x000B2271 File Offset: 0x000B0471
		[NullableContext(1)]
		public static CompositionConditionEnterActionCtxPb Create()
		{
			return new CompositionConditionEnterActionCtxPb();
		}

		// Token: 0x17000CB4 RID: 3252
		// (get) Token: 0x060048CB RID: 18635 RVA: 0x000B2278 File Offset: 0x000B0478
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000CB5 RID: 3253
		// (get) Token: 0x060048CC RID: 18636 RVA: 0x000B227B File Offset: 0x000B047B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CompositionConditionEnterActionCtxPb.Descriptor;
			}
		}

		// Token: 0x060048CD RID: 18637 RVA: 0x000B2282 File Offset: 0x000B0482
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CompositionConditionEnterActionCtxPb()
		{
		}

		// Token: 0x060048CE RID: 18638 RVA: 0x000B228C File Offset: 0x000B048C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CompositionConditionEnterActionCtxPb(CompositionConditionEnterActionCtxPb other) : this()
		{
			this.behaviorTreeCtx_ = ((other.behaviorTreeCtx_ != null) ? other.behaviorTreeCtx_.Clone() : null);
			this.conditionIndex_ = other.conditionIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060048CF RID: 18639 RVA: 0x000B22D8 File Offset: 0x000B04D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CompositionConditionEnterActionCtxPb Clone()
		{
			return new CompositionConditionEnterActionCtxPb(this);
		}

		// Token: 0x17000CB6 RID: 3254
		// (get) Token: 0x060048D0 RID: 18640 RVA: 0x000B22E0 File Offset: 0x000B04E0
		// (set) Token: 0x060048D1 RID: 18641 RVA: 0x000B22E8 File Offset: 0x000B04E8
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

		// Token: 0x17000CB7 RID: 3255
		// (get) Token: 0x060048D2 RID: 18642 RVA: 0x000B22F1 File Offset: 0x000B04F1
		// (set) Token: 0x060048D3 RID: 18643 RVA: 0x000B22F9 File Offset: 0x000B04F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConditionIndex
		{
			get
			{
				return this.conditionIndex_;
			}
			set
			{
				this.conditionIndex_ = value;
			}
		}

		// Token: 0x060048D4 RID: 18644 RVA: 0x000B2302 File Offset: 0x000B0502
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CompositionConditionEnterActionCtxPb);
		}

		// Token: 0x060048D5 RID: 18645 RVA: 0x000B2310 File Offset: 0x000B0510
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CompositionConditionEnterActionCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.BehaviorTreeCtx, other.BehaviorTreeCtx) && this.ConditionIndex == other.ConditionIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060048D6 RID: 18646 RVA: 0x000B2360 File Offset: 0x000B0560
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.behaviorTreeCtx_ != null)
			{
				num ^= this.BehaviorTreeCtx.GetHashCode();
			}
			if (this.ConditionIndex != 0)
			{
				num ^= this.ConditionIndex.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060048D7 RID: 18647 RVA: 0x000B23B5 File Offset: 0x000B05B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060048D8 RID: 18648 RVA: 0x000B23C2 File Offset: 0x000B05C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060048D9 RID: 18649 RVA: 0x000B23CC File Offset: 0x000B05CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.behaviorTreeCtx_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.BehaviorTreeCtx);
			}
			if (this.ConditionIndex != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ConditionIndex);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060048DA RID: 18650 RVA: 0x000B2428 File Offset: 0x000B0628
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.behaviorTreeCtx_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BehaviorTreeCtx);
			}
			if (this.ConditionIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConditionIndex);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060048DB RID: 18651 RVA: 0x000B2480 File Offset: 0x000B0680
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CompositionConditionEnterActionCtxPb other)
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
			if (other.ConditionIndex != 0)
			{
				this.ConditionIndex = other.ConditionIndex;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060048DC RID: 18652 RVA: 0x000B24E8 File Offset: 0x000B06E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060048DD RID: 18653 RVA: 0x000B24F4 File Offset: 0x000B06F4
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
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ConditionIndex = input.ReadInt32();
					}
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

		// Token: 0x04002FF6 RID: 12278
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002FF7 RID: 12279
		public const int BehaviorTreeCtxFieldNumber = 1;

		// Token: 0x04002FF8 RID: 12280
		private BehaviorTreeCtxPb behaviorTreeCtx_;

		// Token: 0x04002FF9 RID: 12281
		public const int ConditionIndexFieldNumber = 2;

		// Token: 0x04002FFA RID: 12282
		private int conditionIndex_;
	}
}
