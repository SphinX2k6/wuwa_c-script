using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000737 RID: 1847
	public sealed class HandInItemChildQuestNodeCtxPb : IMessage<HandInItemChildQuestNodeCtxPb>, IMessage, IEquatable<HandInItemChildQuestNodeCtxPb>, IDeepCloneable<HandInItemChildQuestNodeCtxPb>, IBufferMessage
	{
		// Token: 0x0600A777 RID: 42871 RVA: 0x00193214 File Offset: 0x00191414
		[NullableContext(1)]
		public static HandInItemChildQuestNodeCtxPb Create()
		{
			return new HandInItemChildQuestNodeCtxPb();
		}

		// Token: 0x170021AB RID: 8619
		// (get) Token: 0x0600A778 RID: 42872 RVA: 0x0019321B File Offset: 0x0019141B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170021AC RID: 8620
		// (get) Token: 0x0600A779 RID: 42873 RVA: 0x0019321E File Offset: 0x0019141E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HandInItemChildQuestNodeCtxPb.Descriptor;
			}
		}

		// Token: 0x0600A77A RID: 42874 RVA: 0x00193225 File Offset: 0x00191425
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HandInItemChildQuestNodeCtxPb()
		{
		}

		// Token: 0x0600A77B RID: 42875 RVA: 0x0019322D File Offset: 0x0019142D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HandInItemChildQuestNodeCtxPb(HandInItemChildQuestNodeCtxPb other) : this()
		{
			this.behaviorTreeCtx_ = ((other.behaviorTreeCtx_ != null) ? other.behaviorTreeCtx_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A77C RID: 42876 RVA: 0x00193262 File Offset: 0x00191462
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HandInItemChildQuestNodeCtxPb Clone()
		{
			return new HandInItemChildQuestNodeCtxPb(this);
		}

		// Token: 0x170021AD RID: 8621
		// (get) Token: 0x0600A77D RID: 42877 RVA: 0x0019326A File Offset: 0x0019146A
		// (set) Token: 0x0600A77E RID: 42878 RVA: 0x00193272 File Offset: 0x00191472
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

		// Token: 0x0600A77F RID: 42879 RVA: 0x0019327B File Offset: 0x0019147B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HandInItemChildQuestNodeCtxPb);
		}

		// Token: 0x0600A780 RID: 42880 RVA: 0x00193289 File Offset: 0x00191489
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HandInItemChildQuestNodeCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.BehaviorTreeCtx, other.BehaviorTreeCtx) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A781 RID: 42881 RVA: 0x001932BC File Offset: 0x001914BC
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

		// Token: 0x0600A782 RID: 42882 RVA: 0x001932F8 File Offset: 0x001914F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A783 RID: 42883 RVA: 0x00193305 File Offset: 0x00191505
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A784 RID: 42884 RVA: 0x0019330E File Offset: 0x0019150E
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

		// Token: 0x0600A785 RID: 42885 RVA: 0x00193340 File Offset: 0x00191540
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

		// Token: 0x0600A786 RID: 42886 RVA: 0x00193380 File Offset: 0x00191580
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

		// Token: 0x0600A787 RID: 42887 RVA: 0x001933D4 File Offset: 0x001915D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A788 RID: 42888 RVA: 0x001933E0 File Offset: 0x001915E0
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

		// Token: 0x04004C90 RID: 19600
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004C91 RID: 19601
		public const int BehaviorTreeCtxFieldNumber = 1;

		// Token: 0x04004C92 RID: 19602
		private BehaviorTreeCtxPb behaviorTreeCtx_;
	}
}
