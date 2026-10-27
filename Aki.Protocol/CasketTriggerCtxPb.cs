using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200023A RID: 570
	public sealed class CasketTriggerCtxPb : IMessage<CasketTriggerCtxPb>, IMessage, IEquatable<CasketTriggerCtxPb>, IDeepCloneable<CasketTriggerCtxPb>, IBufferMessage
	{
		// Token: 0x06003D73 RID: 15731 RVA: 0x000981EF File Offset: 0x000963EF
		[NullableContext(1)]
		public static CasketTriggerCtxPb Create()
		{
			return new CasketTriggerCtxPb();
		}

		// Token: 0x17000A3E RID: 2622
		// (get) Token: 0x06003D74 RID: 15732 RVA: 0x000981F6 File Offset: 0x000963F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000A3F RID: 2623
		// (get) Token: 0x06003D75 RID: 15733 RVA: 0x000981F9 File Offset: 0x000963F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CasketTriggerCtxPb.Descriptor;
			}
		}

		// Token: 0x06003D76 RID: 15734 RVA: 0x00098200 File Offset: 0x00096400
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CasketTriggerCtxPb()
		{
		}

		// Token: 0x06003D77 RID: 15735 RVA: 0x00098208 File Offset: 0x00096408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CasketTriggerCtxPb(CasketTriggerCtxPb other) : this()
		{
			this.entityCtx_ = ((other.entityCtx_ != null) ? other.entityCtx_.Clone() : null);
			this.index_ = other.index_;
			this.isEnter_ = other.isEnter_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003D78 RID: 15736 RVA: 0x00098260 File Offset: 0x00096460
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CasketTriggerCtxPb Clone()
		{
			return new CasketTriggerCtxPb(this);
		}

		// Token: 0x17000A40 RID: 2624
		// (get) Token: 0x06003D79 RID: 15737 RVA: 0x00098268 File Offset: 0x00096468
		// (set) Token: 0x06003D7A RID: 15738 RVA: 0x00098270 File Offset: 0x00096470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityCtxPb EntityCtx
		{
			get
			{
				return this.entityCtx_;
			}
			set
			{
				this.entityCtx_ = value;
			}
		}

		// Token: 0x17000A41 RID: 2625
		// (get) Token: 0x06003D7B RID: 15739 RVA: 0x00098279 File Offset: 0x00096479
		// (set) Token: 0x06003D7C RID: 15740 RVA: 0x00098281 File Offset: 0x00096481
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Index
		{
			get
			{
				return this.index_;
			}
			set
			{
				this.index_ = value;
			}
		}

		// Token: 0x17000A42 RID: 2626
		// (get) Token: 0x06003D7D RID: 15741 RVA: 0x0009828A File Offset: 0x0009648A
		// (set) Token: 0x06003D7E RID: 15742 RVA: 0x00098292 File Offset: 0x00096492
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsEnter
		{
			get
			{
				return this.isEnter_;
			}
			set
			{
				this.isEnter_ = value;
			}
		}

		// Token: 0x06003D7F RID: 15743 RVA: 0x0009829B File Offset: 0x0009649B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CasketTriggerCtxPb);
		}

		// Token: 0x06003D80 RID: 15744 RVA: 0x000982AC File Offset: 0x000964AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CasketTriggerCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.EntityCtx, other.EntityCtx) && this.Index == other.Index && this.IsEnter == other.IsEnter && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003D81 RID: 15745 RVA: 0x0009830C File Offset: 0x0009650C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.entityCtx_ != null)
			{
				num ^= this.EntityCtx.GetHashCode();
			}
			if (this.Index != 0)
			{
				num ^= this.Index.GetHashCode();
			}
			if (this.IsEnter)
			{
				num ^= this.IsEnter.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06003D82 RID: 15746 RVA: 0x0009837A File Offset: 0x0009657A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003D83 RID: 15747 RVA: 0x00098387 File Offset: 0x00096587
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003D84 RID: 15748 RVA: 0x00098390 File Offset: 0x00096590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.entityCtx_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.EntityCtx);
			}
			if (this.Index != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Index);
			}
			if (this.IsEnter)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsEnter);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003D85 RID: 15749 RVA: 0x00098408 File Offset: 0x00096608
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.entityCtx_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EntityCtx);
			}
			if (this.Index != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Index);
			}
			if (this.IsEnter)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06003D86 RID: 15750 RVA: 0x0009846C File Offset: 0x0009666C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CasketTriggerCtxPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.entityCtx_ != null)
			{
				if (this.entityCtx_ == null)
				{
					this.EntityCtx = new EntityCtxPb();
				}
				this.EntityCtx.MergeFrom(other.EntityCtx);
			}
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			if (other.IsEnter)
			{
				this.IsEnter = other.IsEnter;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06003D87 RID: 15751 RVA: 0x000984E8 File Offset: 0x000966E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003D88 RID: 15752 RVA: 0x000984F4 File Offset: 0x000966F4
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
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.IsEnter = input.ReadBool();
						}
					}
					else
					{
						this.Index = input.ReadInt32();
					}
				}
				else
				{
					if (this.entityCtx_ == null)
					{
						this.EntityCtx = new EntityCtxPb();
					}
					input.ReadMessage(this.EntityCtx);
				}
			}
		}

		// Token: 0x04002CAA RID: 11434
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002CAB RID: 11435
		public const int EntityCtxFieldNumber = 1;

		// Token: 0x04002CAC RID: 11436
		private EntityCtxPb entityCtx_;

		// Token: 0x04002CAD RID: 11437
		public const int IndexFieldNumber = 2;

		// Token: 0x04002CAE RID: 11438
		private int index_;

		// Token: 0x04002CAF RID: 11439
		public const int IsEnterFieldNumber = 3;

		// Token: 0x04002CB0 RID: 11440
		private bool isEnter_;
	}
}
