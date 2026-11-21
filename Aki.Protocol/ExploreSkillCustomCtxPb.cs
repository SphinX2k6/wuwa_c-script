using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020004ED RID: 1261
	public sealed class ExploreSkillCustomCtxPb : IMessage<ExploreSkillCustomCtxPb>, IMessage, IEquatable<ExploreSkillCustomCtxPb>, IDeepCloneable<ExploreSkillCustomCtxPb>, IBufferMessage
	{
		// Token: 0x06007767 RID: 30567 RVA: 0x001232CC File Offset: 0x001214CC
		[NullableContext(1)]
		public static ExploreSkillCustomCtxPb Create()
		{
			return new ExploreSkillCustomCtxPb();
		}

		// Token: 0x1700171B RID: 5915
		// (get) Token: 0x06007768 RID: 30568 RVA: 0x001232D3 File Offset: 0x001214D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700171C RID: 5916
		// (get) Token: 0x06007769 RID: 30569 RVA: 0x001232D6 File Offset: 0x001214D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ExploreSkillCustomCtxPb.Descriptor;
			}
		}

		// Token: 0x0600776A RID: 30570 RVA: 0x001232DD File Offset: 0x001214DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreSkillCustomCtxPb()
		{
		}

		// Token: 0x0600776B RID: 30571 RVA: 0x001232E5 File Offset: 0x001214E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreSkillCustomCtxPb(ExploreSkillCustomCtxPb other) : this()
		{
			this.entityCtx_ = ((other.entityCtx_ != null) ? other.entityCtx_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600776C RID: 30572 RVA: 0x0012331A File Offset: 0x0012151A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ExploreSkillCustomCtxPb Clone()
		{
			return new ExploreSkillCustomCtxPb(this);
		}

		// Token: 0x1700171D RID: 5917
		// (get) Token: 0x0600776D RID: 30573 RVA: 0x00123322 File Offset: 0x00121522
		// (set) Token: 0x0600776E RID: 30574 RVA: 0x0012332A File Offset: 0x0012152A
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

		// Token: 0x0600776F RID: 30575 RVA: 0x00123333 File Offset: 0x00121533
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ExploreSkillCustomCtxPb);
		}

		// Token: 0x06007770 RID: 30576 RVA: 0x00123341 File Offset: 0x00121541
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ExploreSkillCustomCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.EntityCtx, other.EntityCtx) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007771 RID: 30577 RVA: 0x00123374 File Offset: 0x00121574
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.entityCtx_ != null)
			{
				num ^= this.EntityCtx.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007772 RID: 30578 RVA: 0x001233B0 File Offset: 0x001215B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007773 RID: 30579 RVA: 0x001233BD File Offset: 0x001215BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007774 RID: 30580 RVA: 0x001233C6 File Offset: 0x001215C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.entityCtx_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.EntityCtx);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007775 RID: 30581 RVA: 0x001233F8 File Offset: 0x001215F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.entityCtx_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EntityCtx);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007776 RID: 30582 RVA: 0x00123438 File Offset: 0x00121638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ExploreSkillCustomCtxPb other)
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
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007777 RID: 30583 RVA: 0x0012348C File Offset: 0x0012168C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007778 RID: 30584 RVA: 0x00123498 File Offset: 0x00121698
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
					if (this.entityCtx_ == null)
					{
						this.EntityCtx = new EntityCtxPb();
					}
					input.ReadMessage(this.EntityCtx);
				}
			}
		}

		// Token: 0x04003E73 RID: 15987
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003E74 RID: 15988
		public const int EntityCtxFieldNumber = 1;

		// Token: 0x04003E75 RID: 15989
		private EntityCtxPb entityCtx_;
	}
}
