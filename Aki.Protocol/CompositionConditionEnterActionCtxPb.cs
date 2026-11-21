using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002CB RID: 715
	public sealed class CompositionConditionEnterActionCtxPb : IMessage<CompositionConditionEnterActionCtxPb>, IMessage, IEquatable<CompositionConditionEnterActionCtxPb>, IDeepCloneable<CompositionConditionEnterActionCtxPb>, IBufferMessage
	{
		// Token: 0x060049A3 RID: 18851 RVA: 0x000B4658 File Offset: 0x000B2858
		[NullableContext(1)]
		public static CompositionConditionEnterActionCtxPb Create()
		{
			return new CompositionConditionEnterActionCtxPb();
		}

		// Token: 0x17000CE1 RID: 3297
		// (get) Token: 0x060049A4 RID: 18852 RVA: 0x000B465F File Offset: 0x000B285F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000CE2 RID: 3298
		// (get) Token: 0x060049A5 RID: 18853 RVA: 0x000B4662 File Offset: 0x000B2862
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CompositionConditionEnterActionCtxPb.Descriptor;
			}
		}

		// Token: 0x060049A6 RID: 18854 RVA: 0x000B4669 File Offset: 0x000B2869
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CompositionConditionEnterActionCtxPb()
		{
		}

		// Token: 0x060049A7 RID: 18855 RVA: 0x000B4674 File Offset: 0x000B2874
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CompositionConditionEnterActionCtxPb(CompositionConditionEnterActionCtxPb other) : this()
		{
			this.behaviorTreeCtx_ = ((other.behaviorTreeCtx_ != null) ? other.behaviorTreeCtx_.Clone() : null);
			this.conditionIndex_ = other.conditionIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060049A8 RID: 18856 RVA: 0x000B46C0 File Offset: 0x000B28C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CompositionConditionEnterActionCtxPb Clone()
		{
			return new CompositionConditionEnterActionCtxPb(this);
		}

		// Token: 0x17000CE3 RID: 3299
		// (get) Token: 0x060049A9 RID: 18857 RVA: 0x000B46C8 File Offset: 0x000B28C8
		// (set) Token: 0x060049AA RID: 18858 RVA: 0x000B46D0 File Offset: 0x000B28D0
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

		// Token: 0x17000CE4 RID: 3300
		// (get) Token: 0x060049AB RID: 18859 RVA: 0x000B46D9 File Offset: 0x000B28D9
		// (set) Token: 0x060049AC RID: 18860 RVA: 0x000B46E1 File Offset: 0x000B28E1
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

		// Token: 0x060049AD RID: 18861 RVA: 0x000B46EA File Offset: 0x000B28EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CompositionConditionEnterActionCtxPb);
		}

		// Token: 0x060049AE RID: 18862 RVA: 0x000B46F8 File Offset: 0x000B28F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CompositionConditionEnterActionCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.BehaviorTreeCtx, other.BehaviorTreeCtx) && this.ConditionIndex == other.ConditionIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060049AF RID: 18863 RVA: 0x000B4748 File Offset: 0x000B2948
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

		// Token: 0x060049B0 RID: 18864 RVA: 0x000B479D File Offset: 0x000B299D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060049B1 RID: 18865 RVA: 0x000B47AA File Offset: 0x000B29AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060049B2 RID: 18866 RVA: 0x000B47B4 File Offset: 0x000B29B4
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

		// Token: 0x060049B3 RID: 18867 RVA: 0x000B4810 File Offset: 0x000B2A10
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

		// Token: 0x060049B4 RID: 18868 RVA: 0x000B4868 File Offset: 0x000B2A68
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

		// Token: 0x060049B5 RID: 18869 RVA: 0x000B48D0 File Offset: 0x000B2AD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060049B6 RID: 18870 RVA: 0x000B48DC File Offset: 0x000B2ADC
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

		// Token: 0x0400308D RID: 12429
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400308E RID: 12430
		public const int BehaviorTreeCtxFieldNumber = 1;

		// Token: 0x0400308F RID: 12431
		private BehaviorTreeCtxPb behaviorTreeCtx_;

		// Token: 0x04003090 RID: 12432
		public const int ConditionIndexFieldNumber = 2;

		// Token: 0x04003091 RID: 12433
		private int conditionIndex_;
	}
}
