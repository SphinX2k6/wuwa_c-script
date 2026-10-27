using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F15 RID: 3861
	public sealed class RenjuCompleteActionCtxPb : IMessage<RenjuCompleteActionCtxPb>, IMessage, IEquatable<RenjuCompleteActionCtxPb>, IDeepCloneable<RenjuCompleteActionCtxPb>, IBufferMessage
	{
		// Token: 0x06014AB6 RID: 84662 RVA: 0x002FFFF5 File Offset: 0x002FE1F5
		[NullableContext(1)]
		public static RenjuCompleteActionCtxPb Create()
		{
			return new RenjuCompleteActionCtxPb();
		}

		// Token: 0x170044B4 RID: 17588
		// (get) Token: 0x06014AB7 RID: 84663 RVA: 0x002FFFFC File Offset: 0x002FE1FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170044B5 RID: 17589
		// (get) Token: 0x06014AB8 RID: 84664 RVA: 0x002FFFFF File Offset: 0x002FE1FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RenjuCompleteActionCtxPb.Descriptor;
			}
		}

		// Token: 0x06014AB9 RID: 84665 RVA: 0x00300006 File Offset: 0x002FE206
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RenjuCompleteActionCtxPb()
		{
		}

		// Token: 0x06014ABA RID: 84666 RVA: 0x00300010 File Offset: 0x002FE210
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RenjuCompleteActionCtxPb(RenjuCompleteActionCtxPb other) : this()
		{
			this.entityCtx_ = ((other.entityCtx_ != null) ? other.entityCtx_.Clone() : null);
			this.controller_ = other.controller_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014ABB RID: 84667 RVA: 0x0030005C File Offset: 0x002FE25C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RenjuCompleteActionCtxPb Clone()
		{
			return new RenjuCompleteActionCtxPb(this);
		}

		// Token: 0x170044B6 RID: 17590
		// (get) Token: 0x06014ABC RID: 84668 RVA: 0x00300064 File Offset: 0x002FE264
		// (set) Token: 0x06014ABD RID: 84669 RVA: 0x0030006C File Offset: 0x002FE26C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityCtxPb EntityCtx
		{
			get
			{
				return this.entityCtx_;
			}
			set
			{
				this.entityCtx_ = value;
			}
		}

		// Token: 0x170044B7 RID: 17591
		// (get) Token: 0x06014ABE RID: 84670 RVA: 0x00300075 File Offset: 0x002FE275
		// (set) Token: 0x06014ABF RID: 84671 RVA: 0x0030007D File Offset: 0x002FE27D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Controller
		{
			get
			{
				return this.controller_;
			}
			set
			{
				this.controller_ = value;
			}
		}

		// Token: 0x06014AC0 RID: 84672 RVA: 0x00300086 File Offset: 0x002FE286
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RenjuCompleteActionCtxPb);
		}

		// Token: 0x06014AC1 RID: 84673 RVA: 0x00300094 File Offset: 0x002FE294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RenjuCompleteActionCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.EntityCtx, other.EntityCtx) && this.Controller == other.Controller && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014AC2 RID: 84674 RVA: 0x003000E4 File Offset: 0x002FE2E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.entityCtx_ != null)
			{
				num ^= this.EntityCtx.GetHashCode();
			}
			if (this.Controller != 0)
			{
				num ^= this.Controller.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014AC3 RID: 84675 RVA: 0x00300139 File Offset: 0x002FE339
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014AC4 RID: 84676 RVA: 0x00300146 File Offset: 0x002FE346
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014AC5 RID: 84677 RVA: 0x00300150 File Offset: 0x002FE350
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.entityCtx_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.EntityCtx);
			}
			if (this.Controller != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Controller);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014AC6 RID: 84678 RVA: 0x003001AC File Offset: 0x002FE3AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.entityCtx_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EntityCtx);
			}
			if (this.Controller != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Controller);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014AC7 RID: 84679 RVA: 0x00300204 File Offset: 0x002FE404
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RenjuCompleteActionCtxPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.entityCtx_ != null)
			{
				if (this.entityCtx_ == null)
				{
					this.EntityCtx = new EntityCtxPb();
				}
				this.EntityCtx.MergeFrom(other.EntityCtx);
			}
			if (other.Controller != 0)
			{
				this.Controller = other.Controller;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014AC8 RID: 84680 RVA: 0x0030026C File Offset: 0x002FE46C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014AC9 RID: 84681 RVA: 0x00300278 File Offset: 0x002FE478
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
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Controller = input.ReadInt32();
					}
				}
				else
				{
					if (this.entityCtx_ == null)
					{
						this.EntityCtx = new EntityCtxPb();
					}
					input.ReadMessage(this.EntityCtx);
				}
			}
		}

		// Token: 0x04007CFA RID: 31994
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007CFB RID: 31995
		public const int EntityCtxFieldNumber = 1;

		// Token: 0x04007CFC RID: 31996
		private EntityCtxPb entityCtx_;

		// Token: 0x04007CFD RID: 31997
		public const int ControllerFieldNumber = 2;

		// Token: 0x04007CFE RID: 31998
		private int controller_;
	}
}
