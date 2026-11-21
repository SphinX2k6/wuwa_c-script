using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200028D RID: 653
	public sealed class ChildQuestNodeEnterActionCtxPb : IMessage<ChildQuestNodeEnterActionCtxPb>, IMessage, IEquatable<ChildQuestNodeEnterActionCtxPb>, IDeepCloneable<ChildQuestNodeEnterActionCtxPb>, IBufferMessage
	{
		// Token: 0x06004457 RID: 17495 RVA: 0x000A78F5 File Offset: 0x000A5AF5
		[NullableContext(1)]
		public static ChildQuestNodeEnterActionCtxPb Create()
		{
			return new ChildQuestNodeEnterActionCtxPb();
		}

		// Token: 0x17000BA9 RID: 2985
		// (get) Token: 0x06004458 RID: 17496 RVA: 0x000A78FC File Offset: 0x000A5AFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000BAA RID: 2986
		// (get) Token: 0x06004459 RID: 17497 RVA: 0x000A78FF File Offset: 0x000A5AFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChildQuestNodeEnterActionCtxPb.Descriptor;
			}
		}

		// Token: 0x0600445A RID: 17498 RVA: 0x000A7906 File Offset: 0x000A5B06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChildQuestNodeEnterActionCtxPb()
		{
		}

		// Token: 0x0600445B RID: 17499 RVA: 0x000A790E File Offset: 0x000A5B0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChildQuestNodeEnterActionCtxPb(ChildQuestNodeEnterActionCtxPb other) : this()
		{
			this.behaviorTreeCtx_ = ((other.behaviorTreeCtx_ != null) ? other.behaviorTreeCtx_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600445C RID: 17500 RVA: 0x000A7943 File Offset: 0x000A5B43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChildQuestNodeEnterActionCtxPb Clone()
		{
			return new ChildQuestNodeEnterActionCtxPb(this);
		}

		// Token: 0x17000BAB RID: 2987
		// (get) Token: 0x0600445D RID: 17501 RVA: 0x000A794B File Offset: 0x000A5B4B
		// (set) Token: 0x0600445E RID: 17502 RVA: 0x000A7953 File Offset: 0x000A5B53
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

		// Token: 0x0600445F RID: 17503 RVA: 0x000A795C File Offset: 0x000A5B5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChildQuestNodeEnterActionCtxPb);
		}

		// Token: 0x06004460 RID: 17504 RVA: 0x000A796A File Offset: 0x000A5B6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChildQuestNodeEnterActionCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.BehaviorTreeCtx, other.BehaviorTreeCtx) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004461 RID: 17505 RVA: 0x000A79A0 File Offset: 0x000A5BA0
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

		// Token: 0x06004462 RID: 17506 RVA: 0x000A79DC File Offset: 0x000A5BDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004463 RID: 17507 RVA: 0x000A79E9 File Offset: 0x000A5BE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004464 RID: 17508 RVA: 0x000A79F2 File Offset: 0x000A5BF2
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

		// Token: 0x06004465 RID: 17509 RVA: 0x000A7A24 File Offset: 0x000A5C24
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

		// Token: 0x06004466 RID: 17510 RVA: 0x000A7A64 File Offset: 0x000A5C64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChildQuestNodeEnterActionCtxPb other)
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

		// Token: 0x06004467 RID: 17511 RVA: 0x000A7AB8 File Offset: 0x000A5CB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004468 RID: 17512 RVA: 0x000A7AC4 File Offset: 0x000A5CC4
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

		// Token: 0x04002EE3 RID: 12003
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002EE4 RID: 12004
		public const int BehaviorTreeCtxFieldNumber = 1;

		// Token: 0x04002EE5 RID: 12005
		private BehaviorTreeCtxPb behaviorTreeCtx_;
	}
}
