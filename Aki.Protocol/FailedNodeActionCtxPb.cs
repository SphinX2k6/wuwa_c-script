using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000502 RID: 1282
	public sealed class FailedNodeActionCtxPb : IMessage<FailedNodeActionCtxPb>, IMessage, IEquatable<FailedNodeActionCtxPb>, IDeepCloneable<FailedNodeActionCtxPb>, IBufferMessage
	{
		// Token: 0x06007917 RID: 30999 RVA: 0x00126CD9 File Offset: 0x00124ED9
		[NullableContext(1)]
		public static FailedNodeActionCtxPb Create()
		{
			return new FailedNodeActionCtxPb();
		}

		// Token: 0x17001776 RID: 6006
		// (get) Token: 0x06007918 RID: 31000 RVA: 0x00126CE0 File Offset: 0x00124EE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001777 RID: 6007
		// (get) Token: 0x06007919 RID: 31001 RVA: 0x00126CE3 File Offset: 0x00124EE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FailedNodeActionCtxPb.Descriptor;
			}
		}

		// Token: 0x0600791A RID: 31002 RVA: 0x00126CEA File Offset: 0x00124EEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FailedNodeActionCtxPb()
		{
		}

		// Token: 0x0600791B RID: 31003 RVA: 0x00126CF2 File Offset: 0x00124EF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FailedNodeActionCtxPb(FailedNodeActionCtxPb other) : this()
		{
			this.behaviorTreeCtx_ = ((other.behaviorTreeCtx_ != null) ? other.behaviorTreeCtx_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600791C RID: 31004 RVA: 0x00126D27 File Offset: 0x00124F27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FailedNodeActionCtxPb Clone()
		{
			return new FailedNodeActionCtxPb(this);
		}

		// Token: 0x17001778 RID: 6008
		// (get) Token: 0x0600791D RID: 31005 RVA: 0x00126D2F File Offset: 0x00124F2F
		// (set) Token: 0x0600791E RID: 31006 RVA: 0x00126D37 File Offset: 0x00124F37
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

		// Token: 0x0600791F RID: 31007 RVA: 0x00126D40 File Offset: 0x00124F40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FailedNodeActionCtxPb);
		}

		// Token: 0x06007920 RID: 31008 RVA: 0x00126D4E File Offset: 0x00124F4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FailedNodeActionCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.BehaviorTreeCtx, other.BehaviorTreeCtx) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007921 RID: 31009 RVA: 0x00126D84 File Offset: 0x00124F84
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

		// Token: 0x06007922 RID: 31010 RVA: 0x00126DC0 File Offset: 0x00124FC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007923 RID: 31011 RVA: 0x00126DCD File Offset: 0x00124FCD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007924 RID: 31012 RVA: 0x00126DD6 File Offset: 0x00124FD6
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

		// Token: 0x06007925 RID: 31013 RVA: 0x00126E08 File Offset: 0x00125008
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

		// Token: 0x06007926 RID: 31014 RVA: 0x00126E48 File Offset: 0x00125048
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

		// Token: 0x06007927 RID: 31015 RVA: 0x00126E9C File Offset: 0x0012509C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007928 RID: 31016 RVA: 0x00126EA8 File Offset: 0x001250A8
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

		// Token: 0x04003EE7 RID: 16103
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003EE8 RID: 16104
		public const int BehaviorTreeCtxFieldNumber = 1;

		// Token: 0x04003EE9 RID: 16105
		private BehaviorTreeCtxPb behaviorTreeCtx_;
	}
}
