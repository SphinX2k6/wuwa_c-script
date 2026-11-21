using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000070 RID: 112
	public sealed class ActionGroupNodeActionCtxPb : IMessage<ActionGroupNodeActionCtxPb>, IMessage, IEquatable<ActionGroupNodeActionCtxPb>, IDeepCloneable<ActionGroupNodeActionCtxPb>, IBufferMessage
	{
		// Token: 0x06001785 RID: 6021 RVA: 0x0003D632 File Offset: 0x0003B832
		[NullableContext(1)]
		public static ActionGroupNodeActionCtxPb Create()
		{
			return new ActionGroupNodeActionCtxPb();
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x06001786 RID: 6022 RVA: 0x0003D639 File Offset: 0x0003B839
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x06001787 RID: 6023 RVA: 0x0003D63C File Offset: 0x0003B83C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ActionGroupNodeActionCtxPb.Descriptor;
			}
		}

		// Token: 0x06001788 RID: 6024 RVA: 0x0003D643 File Offset: 0x0003B843
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionGroupNodeActionCtxPb()
		{
		}

		// Token: 0x06001789 RID: 6025 RVA: 0x0003D64B File Offset: 0x0003B84B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionGroupNodeActionCtxPb(ActionGroupNodeActionCtxPb other) : this()
		{
			this.behaviorTreeCtx_ = ((other.behaviorTreeCtx_ != null) ? other.behaviorTreeCtx_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600178A RID: 6026 RVA: 0x0003D680 File Offset: 0x0003B880
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ActionGroupNodeActionCtxPb Clone()
		{
			return new ActionGroupNodeActionCtxPb(this);
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x0600178B RID: 6027 RVA: 0x0003D688 File Offset: 0x0003B888
		// (set) Token: 0x0600178C RID: 6028 RVA: 0x0003D690 File Offset: 0x0003B890
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

		// Token: 0x0600178D RID: 6029 RVA: 0x0003D699 File Offset: 0x0003B899
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ActionGroupNodeActionCtxPb);
		}

		// Token: 0x0600178E RID: 6030 RVA: 0x0003D6A7 File Offset: 0x0003B8A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ActionGroupNodeActionCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.BehaviorTreeCtx, other.BehaviorTreeCtx) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600178F RID: 6031 RVA: 0x0003D6DC File Offset: 0x0003B8DC
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

		// Token: 0x06001790 RID: 6032 RVA: 0x0003D718 File Offset: 0x0003B918
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001791 RID: 6033 RVA: 0x0003D725 File Offset: 0x0003B925
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001792 RID: 6034 RVA: 0x0003D72E File Offset: 0x0003B92E
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

		// Token: 0x06001793 RID: 6035 RVA: 0x0003D760 File Offset: 0x0003B960
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

		// Token: 0x06001794 RID: 6036 RVA: 0x0003D7A0 File Offset: 0x0003B9A0
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

		// Token: 0x06001795 RID: 6037 RVA: 0x0003D7F4 File Offset: 0x0003B9F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001796 RID: 6038 RVA: 0x0003D800 File Offset: 0x0003BA00
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

		// Token: 0x0400217B RID: 8571
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400217C RID: 8572
		public const int BehaviorTreeCtxFieldNumber = 1;

		// Token: 0x0400217D RID: 8573
		private BehaviorTreeCtxPb behaviorTreeCtx_;
	}
}
