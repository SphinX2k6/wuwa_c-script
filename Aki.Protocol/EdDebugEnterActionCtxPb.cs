using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200041F RID: 1055
	public sealed class EdDebugEnterActionCtxPb : IMessage<EdDebugEnterActionCtxPb>, IMessage, IEquatable<EdDebugEnterActionCtxPb>, IDeepCloneable<EdDebugEnterActionCtxPb>, IBufferMessage
	{
		// Token: 0x0600657E RID: 25982 RVA: 0x000F4503 File Offset: 0x000F2703
		[NullableContext(1)]
		public static EdDebugEnterActionCtxPb Create()
		{
			return new EdDebugEnterActionCtxPb();
		}

		// Token: 0x1700130A RID: 4874
		// (get) Token: 0x0600657F RID: 25983 RVA: 0x000F450A File Offset: 0x000F270A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700130B RID: 4875
		// (get) Token: 0x06006580 RID: 25984 RVA: 0x000F450D File Offset: 0x000F270D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EdDebugEnterActionCtxPb.Descriptor;
			}
		}

		// Token: 0x06006581 RID: 25985 RVA: 0x000F4514 File Offset: 0x000F2714
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EdDebugEnterActionCtxPb()
		{
		}

		// Token: 0x06006582 RID: 25986 RVA: 0x000F451C File Offset: 0x000F271C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EdDebugEnterActionCtxPb(EdDebugEnterActionCtxPb other) : this()
		{
			this.behaviorTreeCtx_ = ((other.behaviorTreeCtx_ != null) ? other.behaviorTreeCtx_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006583 RID: 25987 RVA: 0x000F4551 File Offset: 0x000F2751
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EdDebugEnterActionCtxPb Clone()
		{
			return new EdDebugEnterActionCtxPb(this);
		}

		// Token: 0x1700130C RID: 4876
		// (get) Token: 0x06006584 RID: 25988 RVA: 0x000F4559 File Offset: 0x000F2759
		// (set) Token: 0x06006585 RID: 25989 RVA: 0x000F4561 File Offset: 0x000F2761
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

		// Token: 0x06006586 RID: 25990 RVA: 0x000F456A File Offset: 0x000F276A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EdDebugEnterActionCtxPb);
		}

		// Token: 0x06006587 RID: 25991 RVA: 0x000F4578 File Offset: 0x000F2778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EdDebugEnterActionCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.BehaviorTreeCtx, other.BehaviorTreeCtx) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006588 RID: 25992 RVA: 0x000F45AC File Offset: 0x000F27AC
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

		// Token: 0x06006589 RID: 25993 RVA: 0x000F45E8 File Offset: 0x000F27E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600658A RID: 25994 RVA: 0x000F45F5 File Offset: 0x000F27F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600658B RID: 25995 RVA: 0x000F45FE File Offset: 0x000F27FE
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

		// Token: 0x0600658C RID: 25996 RVA: 0x000F4630 File Offset: 0x000F2830
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

		// Token: 0x0600658D RID: 25997 RVA: 0x000F4670 File Offset: 0x000F2870
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

		// Token: 0x0600658E RID: 25998 RVA: 0x000F46C4 File Offset: 0x000F28C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600658F RID: 25999 RVA: 0x000F46D0 File Offset: 0x000F28D0
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

		// Token: 0x040038DE RID: 14558
		private UnknownFieldSet _unknownFields;

		// Token: 0x040038DF RID: 14559
		public const int BehaviorTreeCtxFieldNumber = 1;

		// Token: 0x040038E0 RID: 14560
		private BehaviorTreeCtxPb behaviorTreeCtx_;
	}
}
