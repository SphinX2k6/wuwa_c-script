using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000518 RID: 1304
	public sealed class FailedNodeActionCtxPb : IMessage<FailedNodeActionCtxPb>, IMessage, IEquatable<FailedNodeActionCtxPb>, IDeepCloneable<FailedNodeActionCtxPb>, IBufferMessage
	{
		// Token: 0x06007A93 RID: 31379 RVA: 0x00129B6D File Offset: 0x00127D6D
		[NullableContext(1)]
		public static FailedNodeActionCtxPb Create()
		{
			return new FailedNodeActionCtxPb();
		}

		// Token: 0x170017C7 RID: 6087
		// (get) Token: 0x06007A94 RID: 31380 RVA: 0x00129B74 File Offset: 0x00127D74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170017C8 RID: 6088
		// (get) Token: 0x06007A95 RID: 31381 RVA: 0x00129B77 File Offset: 0x00127D77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FailedNodeActionCtxPb.Descriptor;
			}
		}

		// Token: 0x06007A96 RID: 31382 RVA: 0x00129B7E File Offset: 0x00127D7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FailedNodeActionCtxPb()
		{
		}

		// Token: 0x06007A97 RID: 31383 RVA: 0x00129B86 File Offset: 0x00127D86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FailedNodeActionCtxPb(FailedNodeActionCtxPb other) : this()
		{
			this.behaviorTreeCtx_ = ((other.behaviorTreeCtx_ != null) ? other.behaviorTreeCtx_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007A98 RID: 31384 RVA: 0x00129BBB File Offset: 0x00127DBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FailedNodeActionCtxPb Clone()
		{
			return new FailedNodeActionCtxPb(this);
		}

		// Token: 0x170017C9 RID: 6089
		// (get) Token: 0x06007A99 RID: 31385 RVA: 0x00129BC3 File Offset: 0x00127DC3
		// (set) Token: 0x06007A9A RID: 31386 RVA: 0x00129BCB File Offset: 0x00127DCB
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

		// Token: 0x06007A9B RID: 31387 RVA: 0x00129BD4 File Offset: 0x00127DD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FailedNodeActionCtxPb);
		}

		// Token: 0x06007A9C RID: 31388 RVA: 0x00129BE2 File Offset: 0x00127DE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FailedNodeActionCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.BehaviorTreeCtx, other.BehaviorTreeCtx) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007A9D RID: 31389 RVA: 0x00129C18 File Offset: 0x00127E18
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

		// Token: 0x06007A9E RID: 31390 RVA: 0x00129C54 File Offset: 0x00127E54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007A9F RID: 31391 RVA: 0x00129C61 File Offset: 0x00127E61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007AA0 RID: 31392 RVA: 0x00129C6A File Offset: 0x00127E6A
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

		// Token: 0x06007AA1 RID: 31393 RVA: 0x00129C9C File Offset: 0x00127E9C
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

		// Token: 0x06007AA2 RID: 31394 RVA: 0x00129CDC File Offset: 0x00127EDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FailedNodeActionCtxPb other)
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

		// Token: 0x06007AA3 RID: 31395 RVA: 0x00129D30 File Offset: 0x00127F30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007AA4 RID: 31396 RVA: 0x00129D3C File Offset: 0x00127F3C
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

		// Token: 0x04003EF6 RID: 16118
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003EF7 RID: 16119
		public const int BehaviorTreeCtxFieldNumber = 1;

		// Token: 0x04003EF8 RID: 16120
		private BehaviorTreeCtxPb behaviorTreeCtx_;
	}
}
