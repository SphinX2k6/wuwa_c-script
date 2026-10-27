using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000288 RID: 648
	public sealed class ChildQuestNodeEnterActionCtxPb : IMessage<ChildQuestNodeEnterActionCtxPb>, IMessage, IEquatable<ChildQuestNodeEnterActionCtxPb>, IDeepCloneable<ChildQuestNodeEnterActionCtxPb>, IBufferMessage
	{
		// Token: 0x060043B0 RID: 17328 RVA: 0x000A5C2D File Offset: 0x000A3E2D
		[NullableContext(1)]
		public static ChildQuestNodeEnterActionCtxPb Create()
		{
			return new ChildQuestNodeEnterActionCtxPb();
		}

		// Token: 0x17000B89 RID: 2953
		// (get) Token: 0x060043B1 RID: 17329 RVA: 0x000A5C34 File Offset: 0x000A3E34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000B8A RID: 2954
		// (get) Token: 0x060043B2 RID: 17330 RVA: 0x000A5C37 File Offset: 0x000A3E37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChildQuestNodeEnterActionCtxPb.Descriptor;
			}
		}

		// Token: 0x060043B3 RID: 17331 RVA: 0x000A5C3E File Offset: 0x000A3E3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChildQuestNodeEnterActionCtxPb()
		{
		}

		// Token: 0x060043B4 RID: 17332 RVA: 0x000A5C46 File Offset: 0x000A3E46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChildQuestNodeEnterActionCtxPb(ChildQuestNodeEnterActionCtxPb other) : this()
		{
			this.behaviorTreeCtx_ = ((other.behaviorTreeCtx_ != null) ? other.behaviorTreeCtx_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060043B5 RID: 17333 RVA: 0x000A5C7B File Offset: 0x000A3E7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChildQuestNodeEnterActionCtxPb Clone()
		{
			return new ChildQuestNodeEnterActionCtxPb(this);
		}

		// Token: 0x17000B8B RID: 2955
		// (get) Token: 0x060043B6 RID: 17334 RVA: 0x000A5C83 File Offset: 0x000A3E83
		// (set) Token: 0x060043B7 RID: 17335 RVA: 0x000A5C8B File Offset: 0x000A3E8B
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

		// Token: 0x060043B8 RID: 17336 RVA: 0x000A5C94 File Offset: 0x000A3E94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChildQuestNodeEnterActionCtxPb);
		}

		// Token: 0x060043B9 RID: 17337 RVA: 0x000A5CA2 File Offset: 0x000A3EA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChildQuestNodeEnterActionCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.BehaviorTreeCtx, other.BehaviorTreeCtx) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060043BA RID: 17338 RVA: 0x000A5CD8 File Offset: 0x000A3ED8
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

		// Token: 0x060043BB RID: 17339 RVA: 0x000A5D14 File Offset: 0x000A3F14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060043BC RID: 17340 RVA: 0x000A5D21 File Offset: 0x000A3F21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060043BD RID: 17341 RVA: 0x000A5D2A File Offset: 0x000A3F2A
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

		// Token: 0x060043BE RID: 17342 RVA: 0x000A5D5C File Offset: 0x000A3F5C
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

		// Token: 0x060043BF RID: 17343 RVA: 0x000A5D9C File Offset: 0x000A3F9C
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

		// Token: 0x060043C0 RID: 17344 RVA: 0x000A5DF0 File Offset: 0x000A3FF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060043C1 RID: 17345 RVA: 0x000A5DFC File Offset: 0x000A3FFC
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

		// Token: 0x04002E5F RID: 11871
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002E60 RID: 11872
		public const int BehaviorTreeCtxFieldNumber = 1;

		// Token: 0x04002E61 RID: 11873
		private BehaviorTreeCtxPb behaviorTreeCtx_;
	}
}
