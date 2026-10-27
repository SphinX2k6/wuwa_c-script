using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013F2 RID: 5106
	public sealed class TrampleActiveCtxPb : IMessage<TrampleActiveCtxPb>, IMessage, IEquatable<TrampleActiveCtxPb>, IDeepCloneable<TrampleActiveCtxPb>, IBufferMessage
	{
		// Token: 0x0601B0ED RID: 110829 RVA: 0x003EB110 File Offset: 0x003E9310
		[NullableContext(1)]
		public static TrampleActiveCtxPb Create()
		{
			return new TrampleActiveCtxPb();
		}

		// Token: 0x17005B2F RID: 23343
		// (get) Token: 0x0601B0EE RID: 110830 RVA: 0x003EB117 File Offset: 0x003E9317
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005B30 RID: 23344
		// (get) Token: 0x0601B0EF RID: 110831 RVA: 0x003EB11A File Offset: 0x003E931A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrampleActiveCtxPb.Descriptor;
			}
		}

		// Token: 0x0601B0F0 RID: 110832 RVA: 0x003EB121 File Offset: 0x003E9321
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrampleActiveCtxPb()
		{
		}

		// Token: 0x0601B0F1 RID: 110833 RVA: 0x003EB129 File Offset: 0x003E9329
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrampleActiveCtxPb(TrampleActiveCtxPb other) : this()
		{
			this.entityCtx_ = ((other.entityCtx_ != null) ? other.entityCtx_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B0F2 RID: 110834 RVA: 0x003EB15E File Offset: 0x003E935E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrampleActiveCtxPb Clone()
		{
			return new TrampleActiveCtxPb(this);
		}

		// Token: 0x17005B31 RID: 23345
		// (get) Token: 0x0601B0F3 RID: 110835 RVA: 0x003EB166 File Offset: 0x003E9366
		// (set) Token: 0x0601B0F4 RID: 110836 RVA: 0x003EB16E File Offset: 0x003E936E
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

		// Token: 0x0601B0F5 RID: 110837 RVA: 0x003EB177 File Offset: 0x003E9377
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrampleActiveCtxPb);
		}

		// Token: 0x0601B0F6 RID: 110838 RVA: 0x003EB185 File Offset: 0x003E9385
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrampleActiveCtxPb other)
		{
			return other != null && (other == this || (object.Equals(this.EntityCtx, other.EntityCtx) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B0F7 RID: 110839 RVA: 0x003EB1B8 File Offset: 0x003E93B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.entityCtx_ != null)
			{
				num ^= this.EntityCtx.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B0F8 RID: 110840 RVA: 0x003EB1F4 File Offset: 0x003E93F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B0F9 RID: 110841 RVA: 0x003EB201 File Offset: 0x003E9401
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B0FA RID: 110842 RVA: 0x003EB20A File Offset: 0x003E940A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.entityCtx_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.EntityCtx);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B0FB RID: 110843 RVA: 0x003EB23C File Offset: 0x003E943C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.entityCtx_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.EntityCtx);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B0FC RID: 110844 RVA: 0x003EB27C File Offset: 0x003E947C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrampleActiveCtxPb other)
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
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B0FD RID: 110845 RVA: 0x003EB2D0 File Offset: 0x003E94D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B0FE RID: 110846 RVA: 0x003EB2DC File Offset: 0x003E94DC
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
					if (this.entityCtx_ == null)
					{
						this.EntityCtx = new EntityCtxPb();
					}
					input.ReadMessage(this.EntityCtx);
				}
			}
		}

		// Token: 0x04009C91 RID: 40081
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009C92 RID: 40082
		public const int EntityCtxFieldNumber = 1;

		// Token: 0x04009C93 RID: 40083
		private EntityCtxPb entityCtx_;
	}
}
