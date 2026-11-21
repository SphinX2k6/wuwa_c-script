using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F05 RID: 3845
	public sealed class RenjuCompleteActionCtxPb : IMessage<RenjuCompleteActionCtxPb>, IMessage, IEquatable<RenjuCompleteActionCtxPb>, IDeepCloneable<RenjuCompleteActionCtxPb>, IBufferMessage
	{
		// Token: 0x060149D1 RID: 84433 RVA: 0x002FE939 File Offset: 0x002FCB39
		[NullableContext(1)]
		public static RenjuCompleteActionCtxPb Create()
		{
			return new RenjuCompleteActionCtxPb();
		}

		// Token: 0x1700448A RID: 17546
		// (get) Token: 0x060149D2 RID: 84434 RVA: 0x002FE940 File Offset: 0x002FCB40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700448B RID: 17547
		// (get) Token: 0x060149D3 RID: 84435 RVA: 0x002FE943 File Offset: 0x002FCB43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RenjuCompleteActionCtxPb.Descriptor;
			}
		}

		// Token: 0x060149D4 RID: 84436 RVA: 0x002FE94A File Offset: 0x002FCB4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RenjuCompleteActionCtxPb()
		{
		}

		// Token: 0x060149D5 RID: 84437 RVA: 0x002FE954 File Offset: 0x002FCB54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RenjuCompleteActionCtxPb(RenjuCompleteActionCtxPb other) : this()
		{
			this.entityCtx_ = ((other.entityCtx_ != null) ? other.entityCtx_.Clone() : null);
			this.controller_ = other.controller_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060149D6 RID: 84438 RVA: 0x002FE9A0 File Offset: 0x002FCBA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RenjuCompleteActionCtxPb Clone()
		{
			return new RenjuCompleteActionCtxPb(this);
		}

		// Token: 0x1700448C RID: 17548
		// (get) Token: 0x060149D7 RID: 84439 RVA: 0x002FE9A8 File Offset: 0x002FCBA8
		// (set) Token: 0x060149D8 RID: 84440 RVA: 0x002FE9B0 File Offset: 0x002FCBB0
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

		// Token: 0x1700448D RID: 17549
		// (get) Token: 0x060149D9 RID: 84441 RVA: 0x002FE9B9 File Offset: 0x002FCBB9
		// (set) Token: 0x060149DA RID: 84442 RVA: 0x002FE9C1 File Offset: 0x002FCBC1
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

		// Token: 0x060149DB RID: 84443 RVA: 0x002FE9CA File Offset: 0x002FCBCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RenjuCompleteActionCtxPb);
		}

		// Token: 0x060149DC RID: 84444 RVA: 0x002FE9D8 File Offset: 0x002FCBD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RenjuCompleteActionCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.EntityCtx, other.EntityCtx) && this.Controller == other.Controller && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060149DD RID: 84445 RVA: 0x002FEA28 File Offset: 0x002FCC28
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

		// Token: 0x060149DE RID: 84446 RVA: 0x002FEA7D File Offset: 0x002FCC7D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060149DF RID: 84447 RVA: 0x002FEA8A File Offset: 0x002FCC8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060149E0 RID: 84448 RVA: 0x002FEA94 File Offset: 0x002FCC94
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

		// Token: 0x060149E1 RID: 84449 RVA: 0x002FEAF0 File Offset: 0x002FCCF0
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

		// Token: 0x060149E2 RID: 84450 RVA: 0x002FEB48 File Offset: 0x002FCD48
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

		// Token: 0x060149E3 RID: 84451 RVA: 0x002FEBB0 File Offset: 0x002FCDB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060149E4 RID: 84452 RVA: 0x002FEBBC File Offset: 0x002FCDBC
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

		// Token: 0x04007D24 RID: 32036
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007D25 RID: 32037
		public const int EntityCtxFieldNumber = 1;

		// Token: 0x04007D26 RID: 32038
		private EntityCtxPb entityCtx_;

		// Token: 0x04007D27 RID: 32039
		public const int ControllerFieldNumber = 2;

		// Token: 0x04007D28 RID: 32040
		private int controller_;
	}
}
