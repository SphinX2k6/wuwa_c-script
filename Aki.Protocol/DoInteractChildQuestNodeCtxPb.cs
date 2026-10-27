using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003E5 RID: 997
	public sealed class DoInteractChildQuestNodeCtxPb : IMessage<DoInteractChildQuestNodeCtxPb>, IMessage, IEquatable<DoInteractChildQuestNodeCtxPb>, IDeepCloneable<DoInteractChildQuestNodeCtxPb>, IBufferMessage
	{
		// Token: 0x060060DB RID: 24795 RVA: 0x000EA04C File Offset: 0x000E824C
		[NullableContext(1)]
		public static DoInteractChildQuestNodeCtxPb Create()
		{
			return new DoInteractChildQuestNodeCtxPb();
		}

		// Token: 0x1700120C RID: 4620
		// (get) Token: 0x060060DC RID: 24796 RVA: 0x000EA053 File Offset: 0x000E8253
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700120D RID: 4621
		// (get) Token: 0x060060DD RID: 24797 RVA: 0x000EA056 File Offset: 0x000E8256
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DoInteractChildQuestNodeCtxPb.Descriptor;
			}
		}

		// Token: 0x060060DE RID: 24798 RVA: 0x000EA05D File Offset: 0x000E825D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DoInteractChildQuestNodeCtxPb()
		{
		}

		// Token: 0x060060DF RID: 24799 RVA: 0x000EA065 File Offset: 0x000E8265
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DoInteractChildQuestNodeCtxPb(DoInteractChildQuestNodeCtxPb other) : this()
		{
			this.behaviorTreeCtx_ = ((other.behaviorTreeCtx_ != null) ? other.behaviorTreeCtx_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060060E0 RID: 24800 RVA: 0x000EA09A File Offset: 0x000E829A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DoInteractChildQuestNodeCtxPb Clone()
		{
			return new DoInteractChildQuestNodeCtxPb(this);
		}

		// Token: 0x1700120E RID: 4622
		// (get) Token: 0x060060E1 RID: 24801 RVA: 0x000EA0A2 File Offset: 0x000E82A2
		// (set) Token: 0x060060E2 RID: 24802 RVA: 0x000EA0AA File Offset: 0x000E82AA
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

		// Token: 0x060060E3 RID: 24803 RVA: 0x000EA0B3 File Offset: 0x000E82B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DoInteractChildQuestNodeCtxPb);
		}

		// Token: 0x060060E4 RID: 24804 RVA: 0x000EA0C1 File Offset: 0x000E82C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DoInteractChildQuestNodeCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.BehaviorTreeCtx, other.BehaviorTreeCtx) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060060E5 RID: 24805 RVA: 0x000EA0F4 File Offset: 0x000E82F4
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

		// Token: 0x060060E6 RID: 24806 RVA: 0x000EA130 File Offset: 0x000E8330
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060060E7 RID: 24807 RVA: 0x000EA13D File Offset: 0x000E833D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060060E8 RID: 24808 RVA: 0x000EA146 File Offset: 0x000E8346
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

		// Token: 0x060060E9 RID: 24809 RVA: 0x000EA178 File Offset: 0x000E8378
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

		// Token: 0x060060EA RID: 24810 RVA: 0x000EA1B8 File Offset: 0x000E83B8
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

		// Token: 0x060060EB RID: 24811 RVA: 0x000EA20C File Offset: 0x000E840C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060060EC RID: 24812 RVA: 0x000EA218 File Offset: 0x000E8418
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

		// Token: 0x0400377A RID: 14202
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400377B RID: 14203
		public const int BehaviorTreeCtxFieldNumber = 1;

		// Token: 0x0400377C RID: 14204
		private BehaviorTreeCtxPb behaviorTreeCtx_;
	}
}
