using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000408 RID: 1032
	public sealed class EdDebugEnterActionCtxPb : IMessage<EdDebugEnterActionCtxPb>, IMessage, IEquatable<EdDebugEnterActionCtxPb>, IDeepCloneable<EdDebugEnterActionCtxPb>, IBufferMessage
	{
		// Token: 0x060063EE RID: 25582 RVA: 0x000F138F File Offset: 0x000EF58F
		[NullableContext(1)]
		public static EdDebugEnterActionCtxPb Create()
		{
			return new EdDebugEnterActionCtxPb();
		}

		// Token: 0x170012B5 RID: 4789
		// (get) Token: 0x060063EF RID: 25583 RVA: 0x000F1396 File Offset: 0x000EF596
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170012B6 RID: 4790
		// (get) Token: 0x060063F0 RID: 25584 RVA: 0x000F1399 File Offset: 0x000EF599
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EdDebugEnterActionCtxPb.Descriptor;
			}
		}

		// Token: 0x060063F1 RID: 25585 RVA: 0x000F13A0 File Offset: 0x000EF5A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EdDebugEnterActionCtxPb()
		{
		}

		// Token: 0x060063F2 RID: 25586 RVA: 0x000F13A8 File Offset: 0x000EF5A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EdDebugEnterActionCtxPb(EdDebugEnterActionCtxPb other) : this()
		{
			this.behaviorTreeCtx_ = ((other.behaviorTreeCtx_ != null) ? other.behaviorTreeCtx_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060063F3 RID: 25587 RVA: 0x000F13DD File Offset: 0x000EF5DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EdDebugEnterActionCtxPb Clone()
		{
			return new EdDebugEnterActionCtxPb(this);
		}

		// Token: 0x170012B7 RID: 4791
		// (get) Token: 0x060063F4 RID: 25588 RVA: 0x000F13E5 File Offset: 0x000EF5E5
		// (set) Token: 0x060063F5 RID: 25589 RVA: 0x000F13ED File Offset: 0x000EF5ED
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

		// Token: 0x060063F6 RID: 25590 RVA: 0x000F13F6 File Offset: 0x000EF5F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EdDebugEnterActionCtxPb);
		}

		// Token: 0x060063F7 RID: 25591 RVA: 0x000F1404 File Offset: 0x000EF604
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EdDebugEnterActionCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.BehaviorTreeCtx, other.BehaviorTreeCtx) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060063F8 RID: 25592 RVA: 0x000F1438 File Offset: 0x000EF638
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

		// Token: 0x060063F9 RID: 25593 RVA: 0x000F1474 File Offset: 0x000EF674
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060063FA RID: 25594 RVA: 0x000F1481 File Offset: 0x000EF681
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060063FB RID: 25595 RVA: 0x000F148A File Offset: 0x000EF68A
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

		// Token: 0x060063FC RID: 25596 RVA: 0x000F14BC File Offset: 0x000EF6BC
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

		// Token: 0x060063FD RID: 25597 RVA: 0x000F14FC File Offset: 0x000EF6FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EdDebugEnterActionCtxPb other)
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

		// Token: 0x060063FE RID: 25598 RVA: 0x000F1550 File Offset: 0x000EF750
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060063FF RID: 25599 RVA: 0x000F155C File Offset: 0x000EF75C
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

		// Token: 0x040038CB RID: 14539
		private UnknownFieldSet _unknownFields;

		// Token: 0x040038CC RID: 14540
		public const int BehaviorTreeCtxFieldNumber = 1;

		// Token: 0x040038CD RID: 14541
		private BehaviorTreeCtxPb behaviorTreeCtx_;
	}
}
