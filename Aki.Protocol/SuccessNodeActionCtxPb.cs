using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001318 RID: 4888
	public sealed class SuccessNodeActionCtxPb : IMessage<SuccessNodeActionCtxPb>, IMessage, IEquatable<SuccessNodeActionCtxPb>, IDeepCloneable<SuccessNodeActionCtxPb>, IBufferMessage
	{
		// Token: 0x0601A0FE RID: 106750 RVA: 0x003CC6E1 File Offset: 0x003CA8E1
		[NullableContext(1)]
		public static SuccessNodeActionCtxPb Create()
		{
			return new SuccessNodeActionCtxPb();
		}

		// Token: 0x1700583E RID: 22590
		// (get) Token: 0x0601A0FF RID: 106751 RVA: 0x003CC6E8 File Offset: 0x003CA8E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700583F RID: 22591
		// (get) Token: 0x0601A100 RID: 106752 RVA: 0x003CC6EB File Offset: 0x003CA8EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SuccessNodeActionCtxPb.Descriptor;
			}
		}

		// Token: 0x0601A101 RID: 106753 RVA: 0x003CC6F2 File Offset: 0x003CA8F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SuccessNodeActionCtxPb()
		{
		}

		// Token: 0x0601A102 RID: 106754 RVA: 0x003CC6FA File Offset: 0x003CA8FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SuccessNodeActionCtxPb(SuccessNodeActionCtxPb other) : this()
		{
			this.behaviorTreeCtx_ = ((other.behaviorTreeCtx_ != null) ? other.behaviorTreeCtx_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A103 RID: 106755 RVA: 0x003CC72F File Offset: 0x003CA92F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SuccessNodeActionCtxPb Clone()
		{
			return new SuccessNodeActionCtxPb(this);
		}

		// Token: 0x17005840 RID: 22592
		// (get) Token: 0x0601A104 RID: 106756 RVA: 0x003CC737 File Offset: 0x003CA937
		// (set) Token: 0x0601A105 RID: 106757 RVA: 0x003CC73F File Offset: 0x003CA93F
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

		// Token: 0x0601A106 RID: 106758 RVA: 0x003CC748 File Offset: 0x003CA948
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SuccessNodeActionCtxPb);
		}

		// Token: 0x0601A107 RID: 106759 RVA: 0x003CC756 File Offset: 0x003CA956
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SuccessNodeActionCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.BehaviorTreeCtx, other.BehaviorTreeCtx) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A108 RID: 106760 RVA: 0x003CC78C File Offset: 0x003CA98C
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

		// Token: 0x0601A109 RID: 106761 RVA: 0x003CC7C8 File Offset: 0x003CA9C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A10A RID: 106762 RVA: 0x003CC7D5 File Offset: 0x003CA9D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A10B RID: 106763 RVA: 0x003CC7DE File Offset: 0x003CA9DE
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

		// Token: 0x0601A10C RID: 106764 RVA: 0x003CC810 File Offset: 0x003CAA10
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

		// Token: 0x0601A10D RID: 106765 RVA: 0x003CC850 File Offset: 0x003CAA50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SuccessNodeActionCtxPb other)
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

		// Token: 0x0601A10E RID: 106766 RVA: 0x003CC8A4 File Offset: 0x003CAAA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A10F RID: 106767 RVA: 0x003CC8B0 File Offset: 0x003CAAB0
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

		// Token: 0x0400996E RID: 39278
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400996F RID: 39279
		public const int BehaviorTreeCtxFieldNumber = 1;

		// Token: 0x04009970 RID: 39280
		private BehaviorTreeCtxPb behaviorTreeCtx_;
	}
}
