using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000289 RID: 649
	public sealed class ChildQuestNodeFinishActionCtxPb : IMessage<ChildQuestNodeFinishActionCtxPb>, IMessage, IEquatable<ChildQuestNodeFinishActionCtxPb>, IDeepCloneable<ChildQuestNodeFinishActionCtxPb>, IBufferMessage
	{
		// Token: 0x060043C2 RID: 17346 RVA: 0x000A5E54 File Offset: 0x000A4054
		[NullableContext(1)]
		public static ChildQuestNodeFinishActionCtxPb Create()
		{
			return new ChildQuestNodeFinishActionCtxPb();
		}

		// Token: 0x17000B8C RID: 2956
		// (get) Token: 0x060043C3 RID: 17347 RVA: 0x000A5E5B File Offset: 0x000A405B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000B8D RID: 2957
		// (get) Token: 0x060043C4 RID: 17348 RVA: 0x000A5E5E File Offset: 0x000A405E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChildQuestNodeFinishActionCtxPb.Descriptor;
			}
		}

		// Token: 0x060043C5 RID: 17349 RVA: 0x000A5E65 File Offset: 0x000A4065
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChildQuestNodeFinishActionCtxPb()
		{
		}

		// Token: 0x060043C6 RID: 17350 RVA: 0x000A5E6D File Offset: 0x000A406D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChildQuestNodeFinishActionCtxPb(ChildQuestNodeFinishActionCtxPb other) : this()
		{
			this.behaviorTreeCtx_ = ((other.behaviorTreeCtx_ != null) ? other.behaviorTreeCtx_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060043C7 RID: 17351 RVA: 0x000A5EA2 File Offset: 0x000A40A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChildQuestNodeFinishActionCtxPb Clone()
		{
			return new ChildQuestNodeFinishActionCtxPb(this);
		}

		// Token: 0x17000B8E RID: 2958
		// (get) Token: 0x060043C8 RID: 17352 RVA: 0x000A5EAA File Offset: 0x000A40AA
		// (set) Token: 0x060043C9 RID: 17353 RVA: 0x000A5EB2 File Offset: 0x000A40B2
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

		// Token: 0x060043CA RID: 17354 RVA: 0x000A5EBB File Offset: 0x000A40BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChildQuestNodeFinishActionCtxPb);
		}

		// Token: 0x060043CB RID: 17355 RVA: 0x000A5EC9 File Offset: 0x000A40C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChildQuestNodeFinishActionCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.BehaviorTreeCtx, other.BehaviorTreeCtx) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060043CC RID: 17356 RVA: 0x000A5EFC File Offset: 0x000A40FC
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

		// Token: 0x060043CD RID: 17357 RVA: 0x000A5F38 File Offset: 0x000A4138
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060043CE RID: 17358 RVA: 0x000A5F45 File Offset: 0x000A4145
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060043CF RID: 17359 RVA: 0x000A5F4E File Offset: 0x000A414E
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

		// Token: 0x060043D0 RID: 17360 RVA: 0x000A5F80 File Offset: 0x000A4180
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

		// Token: 0x060043D1 RID: 17361 RVA: 0x000A5FC0 File Offset: 0x000A41C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChildQuestNodeFinishActionCtxPb other)
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

		// Token: 0x060043D2 RID: 17362 RVA: 0x000A6014 File Offset: 0x000A4214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060043D3 RID: 17363 RVA: 0x000A6020 File Offset: 0x000A4220
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

		// Token: 0x04002E62 RID: 11874
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002E63 RID: 11875
		public const int BehaviorTreeCtxFieldNumber = 1;

		// Token: 0x04002E64 RID: 11876
		private BehaviorTreeCtxPb behaviorTreeCtx_;
	}
}
