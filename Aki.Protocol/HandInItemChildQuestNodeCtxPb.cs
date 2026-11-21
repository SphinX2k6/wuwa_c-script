using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000723 RID: 1827
	public sealed class HandInItemChildQuestNodeCtxPb : IMessage<HandInItemChildQuestNodeCtxPb>, IMessage, IEquatable<HandInItemChildQuestNodeCtxPb>, IDeepCloneable<HandInItemChildQuestNodeCtxPb>, IBufferMessage
	{
		// Token: 0x0600A621 RID: 42529 RVA: 0x001907E0 File Offset: 0x0018E9E0
		[NullableContext(1)]
		public static HandInItemChildQuestNodeCtxPb Create()
		{
			return new HandInItemChildQuestNodeCtxPb();
		}

		// Token: 0x17002161 RID: 8545
		// (get) Token: 0x0600A622 RID: 42530 RVA: 0x001907E7 File Offset: 0x0018E9E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002162 RID: 8546
		// (get) Token: 0x0600A623 RID: 42531 RVA: 0x001907EA File Offset: 0x0018E9EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HandInItemChildQuestNodeCtxPb.Descriptor;
			}
		}

		// Token: 0x0600A624 RID: 42532 RVA: 0x001907F1 File Offset: 0x0018E9F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HandInItemChildQuestNodeCtxPb()
		{
		}

		// Token: 0x0600A625 RID: 42533 RVA: 0x001907F9 File Offset: 0x0018E9F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HandInItemChildQuestNodeCtxPb(HandInItemChildQuestNodeCtxPb other) : this()
		{
			this.behaviorTreeCtx_ = ((other.behaviorTreeCtx_ != null) ? other.behaviorTreeCtx_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A626 RID: 42534 RVA: 0x0019082E File Offset: 0x0018EA2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HandInItemChildQuestNodeCtxPb Clone()
		{
			return new HandInItemChildQuestNodeCtxPb(this);
		}

		// Token: 0x17002163 RID: 8547
		// (get) Token: 0x0600A627 RID: 42535 RVA: 0x00190836 File Offset: 0x0018EA36
		// (set) Token: 0x0600A628 RID: 42536 RVA: 0x0019083E File Offset: 0x0018EA3E
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

		// Token: 0x0600A629 RID: 42537 RVA: 0x00190847 File Offset: 0x0018EA47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HandInItemChildQuestNodeCtxPb);
		}

		// Token: 0x0600A62A RID: 42538 RVA: 0x00190855 File Offset: 0x0018EA55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HandInItemChildQuestNodeCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.BehaviorTreeCtx, other.BehaviorTreeCtx) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A62B RID: 42539 RVA: 0x00190888 File Offset: 0x0018EA88
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

		// Token: 0x0600A62C RID: 42540 RVA: 0x001908C4 File Offset: 0x0018EAC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A62D RID: 42541 RVA: 0x001908D1 File Offset: 0x0018EAD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A62E RID: 42542 RVA: 0x001908DA File Offset: 0x0018EADA
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

		// Token: 0x0600A62F RID: 42543 RVA: 0x0019090C File Offset: 0x0018EB0C
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

		// Token: 0x0600A630 RID: 42544 RVA: 0x0019094C File Offset: 0x0018EB4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HandInItemChildQuestNodeCtxPb other)
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

		// Token: 0x0600A631 RID: 42545 RVA: 0x001909A0 File Offset: 0x0018EBA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A632 RID: 42546 RVA: 0x001909AC File Offset: 0x0018EBAC
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

		// Token: 0x04004C89 RID: 19593
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004C8A RID: 19594
		public const int BehaviorTreeCtxFieldNumber = 1;

		// Token: 0x04004C8B RID: 19595
		private BehaviorTreeCtxPb behaviorTreeCtx_;
	}
}
