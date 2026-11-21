using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003CE RID: 974
	public sealed class DoInteractChildQuestNodeCtxPb : IMessage<DoInteractChildQuestNodeCtxPb>, IMessage, IEquatable<DoInteractChildQuestNodeCtxPb>, IDeepCloneable<DoInteractChildQuestNodeCtxPb>, IBufferMessage
	{
		// Token: 0x06005F4B RID: 24395 RVA: 0x000E6ECC File Offset: 0x000E50CC
		[NullableContext(1)]
		public static DoInteractChildQuestNodeCtxPb Create()
		{
			return new DoInteractChildQuestNodeCtxPb();
		}

		// Token: 0x170011B7 RID: 4535
		// (get) Token: 0x06005F4C RID: 24396 RVA: 0x000E6ED3 File Offset: 0x000E50D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170011B8 RID: 4536
		// (get) Token: 0x06005F4D RID: 24397 RVA: 0x000E6ED6 File Offset: 0x000E50D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DoInteractChildQuestNodeCtxPb.Descriptor;
			}
		}

		// Token: 0x06005F4E RID: 24398 RVA: 0x000E6EDD File Offset: 0x000E50DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DoInteractChildQuestNodeCtxPb()
		{
		}

		// Token: 0x06005F4F RID: 24399 RVA: 0x000E6EE5 File Offset: 0x000E50E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DoInteractChildQuestNodeCtxPb(DoInteractChildQuestNodeCtxPb other) : this()
		{
			this.behaviorTreeCtx_ = ((other.behaviorTreeCtx_ != null) ? other.behaviorTreeCtx_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005F50 RID: 24400 RVA: 0x000E6F1A File Offset: 0x000E511A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DoInteractChildQuestNodeCtxPb Clone()
		{
			return new DoInteractChildQuestNodeCtxPb(this);
		}

		// Token: 0x170011B9 RID: 4537
		// (get) Token: 0x06005F51 RID: 24401 RVA: 0x000E6F22 File Offset: 0x000E5122
		// (set) Token: 0x06005F52 RID: 24402 RVA: 0x000E6F2A File Offset: 0x000E512A
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

		// Token: 0x06005F53 RID: 24403 RVA: 0x000E6F33 File Offset: 0x000E5133
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DoInteractChildQuestNodeCtxPb);
		}

		// Token: 0x06005F54 RID: 24404 RVA: 0x000E6F41 File Offset: 0x000E5141
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DoInteractChildQuestNodeCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.BehaviorTreeCtx, other.BehaviorTreeCtx) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005F55 RID: 24405 RVA: 0x000E6F74 File Offset: 0x000E5174
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

		// Token: 0x06005F56 RID: 24406 RVA: 0x000E6FB0 File Offset: 0x000E51B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005F57 RID: 24407 RVA: 0x000E6FBD File Offset: 0x000E51BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005F58 RID: 24408 RVA: 0x000E6FC6 File Offset: 0x000E51C6
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

		// Token: 0x06005F59 RID: 24409 RVA: 0x000E6FF8 File Offset: 0x000E51F8
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

		// Token: 0x06005F5A RID: 24410 RVA: 0x000E7038 File Offset: 0x000E5238
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DoInteractChildQuestNodeCtxPb other)
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

		// Token: 0x06005F5B RID: 24411 RVA: 0x000E708C File Offset: 0x000E528C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005F5C RID: 24412 RVA: 0x000E7098 File Offset: 0x000E5298
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

		// Token: 0x04003767 RID: 14183
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003768 RID: 14184
		public const int BehaviorTreeCtxFieldNumber = 1;

		// Token: 0x04003769 RID: 14185
		private BehaviorTreeCtxPb behaviorTreeCtx_;
	}
}
