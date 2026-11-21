using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200119F RID: 4511
	public sealed class SceneItemLifeCycleComponentCreateCtxPb : IMessage<SceneItemLifeCycleComponentCreateCtxPb>, IMessage, IEquatable<SceneItemLifeCycleComponentCreateCtxPb>, IDeepCloneable<SceneItemLifeCycleComponentCreateCtxPb>, IBufferMessage
	{
		// Token: 0x0601818A RID: 98698 RVA: 0x00382414 File Offset: 0x00380614
		[NullableContext(1)]
		public static SceneItemLifeCycleComponentCreateCtxPb Create()
		{
			return new SceneItemLifeCycleComponentCreateCtxPb();
		}

		// Token: 0x17005131 RID: 20785
		// (get) Token: 0x0601818B RID: 98699 RVA: 0x0038241B File Offset: 0x0038061B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005132 RID: 20786
		// (get) Token: 0x0601818C RID: 98700 RVA: 0x0038241E File Offset: 0x0038061E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneItemLifeCycleComponentCreateCtxPb.Descriptor;
			}
		}

		// Token: 0x0601818D RID: 98701 RVA: 0x00382425 File Offset: 0x00380625
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemLifeCycleComponentCreateCtxPb()
		{
		}

		// Token: 0x0601818E RID: 98702 RVA: 0x0038242D File Offset: 0x0038062D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemLifeCycleComponentCreateCtxPb(SceneItemLifeCycleComponentCreateCtxPb other) : this()
		{
			this.entityCtx_ = ((other.entityCtx_ != null) ? other.entityCtx_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601818F RID: 98703 RVA: 0x00382462 File Offset: 0x00380662
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneItemLifeCycleComponentCreateCtxPb Clone()
		{
			return new SceneItemLifeCycleComponentCreateCtxPb(this);
		}

		// Token: 0x17005133 RID: 20787
		// (get) Token: 0x06018190 RID: 98704 RVA: 0x0038246A File Offset: 0x0038066A
		// (set) Token: 0x06018191 RID: 98705 RVA: 0x00382472 File Offset: 0x00380672
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

		// Token: 0x06018192 RID: 98706 RVA: 0x0038247B File Offset: 0x0038067B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneItemLifeCycleComponentCreateCtxPb);
		}

		// Token: 0x06018193 RID: 98707 RVA: 0x00382489 File Offset: 0x00380689
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneItemLifeCycleComponentCreateCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.EntityCtx, other.EntityCtx) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018194 RID: 98708 RVA: 0x003824BC File Offset: 0x003806BC
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

		// Token: 0x06018195 RID: 98709 RVA: 0x003824F8 File Offset: 0x003806F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018196 RID: 98710 RVA: 0x00382505 File Offset: 0x00380705
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018197 RID: 98711 RVA: 0x0038250E File Offset: 0x0038070E
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

		// Token: 0x06018198 RID: 98712 RVA: 0x00382540 File Offset: 0x00380740
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

		// Token: 0x06018199 RID: 98713 RVA: 0x00382580 File Offset: 0x00380780
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneItemLifeCycleComponentCreateCtxPb other)
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

		// Token: 0x0601819A RID: 98714 RVA: 0x003825D4 File Offset: 0x003807D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601819B RID: 98715 RVA: 0x003825E0 File Offset: 0x003807E0
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

		// Token: 0x04008F83 RID: 36739
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008F84 RID: 36740
		public const int EntityCtxFieldNumber = 1;

		// Token: 0x04008F85 RID: 36741
		private EntityCtxPb entityCtx_;
	}
}
