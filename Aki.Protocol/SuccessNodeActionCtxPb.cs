using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012A9 RID: 4777
	public sealed class SuccessNodeActionCtxPb : IMessage<SuccessNodeActionCtxPb>, IMessage, IEquatable<SuccessNodeActionCtxPb>, IDeepCloneable<SuccessNodeActionCtxPb>, IBufferMessage
	{
		// Token: 0x060196C8 RID: 104136 RVA: 0x003B1FAD File Offset: 0x003B01AD
		[NullableContext(1)]
		public static SuccessNodeActionCtxPb Create()
		{
			return new SuccessNodeActionCtxPb();
		}

		// Token: 0x170055BD RID: 21949
		// (get) Token: 0x060196C9 RID: 104137 RVA: 0x003B1FB4 File Offset: 0x003B01B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170055BE RID: 21950
		// (get) Token: 0x060196CA RID: 104138 RVA: 0x003B1FB7 File Offset: 0x003B01B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SuccessNodeActionCtxPb.Descriptor;
			}
		}

		// Token: 0x060196CB RID: 104139 RVA: 0x003B1FBE File Offset: 0x003B01BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SuccessNodeActionCtxPb()
		{
		}

		// Token: 0x060196CC RID: 104140 RVA: 0x003B1FC6 File Offset: 0x003B01C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SuccessNodeActionCtxPb(SuccessNodeActionCtxPb other) : this()
		{
			this.behaviorTreeCtx_ = ((other.behaviorTreeCtx_ != null) ? other.behaviorTreeCtx_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060196CD RID: 104141 RVA: 0x003B1FFB File Offset: 0x003B01FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SuccessNodeActionCtxPb Clone()
		{
			return new SuccessNodeActionCtxPb(this);
		}

		// Token: 0x170055BF RID: 21951
		// (get) Token: 0x060196CE RID: 104142 RVA: 0x003B2003 File Offset: 0x003B0203
		// (set) Token: 0x060196CF RID: 104143 RVA: 0x003B200B File Offset: 0x003B020B
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

		// Token: 0x060196D0 RID: 104144 RVA: 0x003B2014 File Offset: 0x003B0214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SuccessNodeActionCtxPb);
		}

		// Token: 0x060196D1 RID: 104145 RVA: 0x003B2022 File Offset: 0x003B0222
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SuccessNodeActionCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.BehaviorTreeCtx, other.BehaviorTreeCtx) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060196D2 RID: 104146 RVA: 0x003B2058 File Offset: 0x003B0258
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

		// Token: 0x060196D3 RID: 104147 RVA: 0x003B2094 File Offset: 0x003B0294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060196D4 RID: 104148 RVA: 0x003B20A1 File Offset: 0x003B02A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060196D5 RID: 104149 RVA: 0x003B20AA File Offset: 0x003B02AA
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

		// Token: 0x060196D6 RID: 104150 RVA: 0x003B20DC File Offset: 0x003B02DC
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

		// Token: 0x060196D7 RID: 104151 RVA: 0x003B211C File Offset: 0x003B031C
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

		// Token: 0x060196D8 RID: 104152 RVA: 0x003B2170 File Offset: 0x003B0370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060196D9 RID: 104153 RVA: 0x003B217C File Offset: 0x003B037C
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

		// Token: 0x04009544 RID: 38212
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009545 RID: 38213
		public const int BehaviorTreeCtxFieldNumber = 1;

		// Token: 0x04009546 RID: 38214
		private BehaviorTreeCtxPb behaviorTreeCtx_;
	}
}
