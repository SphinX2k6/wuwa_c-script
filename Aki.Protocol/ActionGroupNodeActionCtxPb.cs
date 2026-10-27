using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200006F RID: 111
	public sealed class ActionGroupNodeActionCtxPb : IMessage<ActionGroupNodeActionCtxPb>, IMessage, IEquatable<ActionGroupNodeActionCtxPb>, IDeepCloneable<ActionGroupNodeActionCtxPb>, IBufferMessage
	{
		// Token: 0x06001742 RID: 5954 RVA: 0x0003CC92 File Offset: 0x0003AE92
		[NullableContext(1)]
		public static ActionGroupNodeActionCtxPb Create()
		{
			return new ActionGroupNodeActionCtxPb();
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x06001743 RID: 5955 RVA: 0x0003CC99 File Offset: 0x0003AE99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x06001744 RID: 5956 RVA: 0x0003CC9C File Offset: 0x0003AE9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActionGroupNodeActionCtxPb.Descriptor;
			}
		}

		// Token: 0x06001745 RID: 5957 RVA: 0x0003CCA3 File Offset: 0x0003AEA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionGroupNodeActionCtxPb()
		{
		}

		// Token: 0x06001746 RID: 5958 RVA: 0x0003CCAB File Offset: 0x0003AEAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionGroupNodeActionCtxPb(ActionGroupNodeActionCtxPb other) : this()
		{
			this.behaviorTreeCtx_ = ((other.behaviorTreeCtx_ != null) ? other.behaviorTreeCtx_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001747 RID: 5959 RVA: 0x0003CCE0 File Offset: 0x0003AEE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionGroupNodeActionCtxPb Clone()
		{
			return new ActionGroupNodeActionCtxPb(this);
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x06001748 RID: 5960 RVA: 0x0003CCE8 File Offset: 0x0003AEE8
		// (set) Token: 0x06001749 RID: 5961 RVA: 0x0003CCF0 File Offset: 0x0003AEF0
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

		// Token: 0x0600174A RID: 5962 RVA: 0x0003CCF9 File Offset: 0x0003AEF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActionGroupNodeActionCtxPb);
		}

		// Token: 0x0600174B RID: 5963 RVA: 0x0003CD07 File Offset: 0x0003AF07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActionGroupNodeActionCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.BehaviorTreeCtx, other.BehaviorTreeCtx) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600174C RID: 5964 RVA: 0x0003CD3C File Offset: 0x0003AF3C
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

		// Token: 0x0600174D RID: 5965 RVA: 0x0003CD78 File Offset: 0x0003AF78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600174E RID: 5966 RVA: 0x0003CD85 File Offset: 0x0003AF85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600174F RID: 5967 RVA: 0x0003CD8E File Offset: 0x0003AF8E
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

		// Token: 0x06001750 RID: 5968 RVA: 0x0003CDC0 File Offset: 0x0003AFC0
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

		// Token: 0x06001751 RID: 5969 RVA: 0x0003CE00 File Offset: 0x0003B000
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ActionGroupNodeActionCtxPb other)
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

		// Token: 0x06001752 RID: 5970 RVA: 0x0003CE54 File Offset: 0x0003B054
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001753 RID: 5971 RVA: 0x0003CE60 File Offset: 0x0003B060
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

		// Token: 0x0400211C RID: 8476
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400211D RID: 8477
		public const int BehaviorTreeCtxFieldNumber = 1;

		// Token: 0x0400211E RID: 8478
		private BehaviorTreeCtxPb behaviorTreeCtx_;
	}
}
