using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002CC RID: 716
	public sealed class CompositionEnterActionCtxPb : IMessage<CompositionEnterActionCtxPb>, IMessage, IEquatable<CompositionEnterActionCtxPb>, IDeepCloneable<CompositionEnterActionCtxPb>, IBufferMessage
	{
		// Token: 0x060049B7 RID: 18871 RVA: 0x000B4947 File Offset: 0x000B2B47
		[NullableContext(1)]
		public static CompositionEnterActionCtxPb Create()
		{
			return new CompositionEnterActionCtxPb();
		}

		// Token: 0x17000CE5 RID: 3301
		// (get) Token: 0x060049B8 RID: 18872 RVA: 0x000B494E File Offset: 0x000B2B4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000CE6 RID: 3302
		// (get) Token: 0x060049B9 RID: 18873 RVA: 0x000B4951 File Offset: 0x000B2B51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CompositionEnterActionCtxPb.Descriptor;
			}
		}

		// Token: 0x060049BA RID: 18874 RVA: 0x000B4958 File Offset: 0x000B2B58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CompositionEnterActionCtxPb()
		{
		}

		// Token: 0x060049BB RID: 18875 RVA: 0x000B4960 File Offset: 0x000B2B60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CompositionEnterActionCtxPb(CompositionEnterActionCtxPb other) : this()
		{
			this.behaviorTreeCtx_ = ((other.behaviorTreeCtx_ != null) ? other.behaviorTreeCtx_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060049BC RID: 18876 RVA: 0x000B4995 File Offset: 0x000B2B95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CompositionEnterActionCtxPb Clone()
		{
			return new CompositionEnterActionCtxPb(this);
		}

		// Token: 0x17000CE7 RID: 3303
		// (get) Token: 0x060049BD RID: 18877 RVA: 0x000B499D File Offset: 0x000B2B9D
		// (set) Token: 0x060049BE RID: 18878 RVA: 0x000B49A5 File Offset: 0x000B2BA5
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

		// Token: 0x060049BF RID: 18879 RVA: 0x000B49AE File Offset: 0x000B2BAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CompositionEnterActionCtxPb);
		}

		// Token: 0x060049C0 RID: 18880 RVA: 0x000B49BC File Offset: 0x000B2BBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CompositionEnterActionCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.BehaviorTreeCtx, other.BehaviorTreeCtx) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060049C1 RID: 18881 RVA: 0x000B49F0 File Offset: 0x000B2BF0
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

		// Token: 0x060049C2 RID: 18882 RVA: 0x000B4A2C File Offset: 0x000B2C2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060049C3 RID: 18883 RVA: 0x000B4A39 File Offset: 0x000B2C39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060049C4 RID: 18884 RVA: 0x000B4A42 File Offset: 0x000B2C42
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

		// Token: 0x060049C5 RID: 18885 RVA: 0x000B4A74 File Offset: 0x000B2C74
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

		// Token: 0x060049C6 RID: 18886 RVA: 0x000B4AB4 File Offset: 0x000B2CB4
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

		// Token: 0x060049C7 RID: 18887 RVA: 0x000B4B08 File Offset: 0x000B2D08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060049C8 RID: 18888 RVA: 0x000B4B14 File Offset: 0x000B2D14
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

		// Token: 0x04003092 RID: 12434
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003093 RID: 12435
		public const int BehaviorTreeCtxFieldNumber = 1;

		// Token: 0x04003094 RID: 12436
		private BehaviorTreeCtxPb behaviorTreeCtx_;
	}
}
