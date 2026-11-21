using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000438 RID: 1080
	public sealed class EnterBigWorldInstContext : IMessage<EnterBigWorldInstContext>, IMessage, IEquatable<EnterBigWorldInstContext>, IDeepCloneable<EnterBigWorldInstContext>, IBufferMessage
	{
		// Token: 0x060067C7 RID: 26567 RVA: 0x000F9988 File Offset: 0x000F7B88
		[NullableContext(1)]
		public static EnterBigWorldInstContext Create()
		{
			return new EnterBigWorldInstContext();
		}

		// Token: 0x17001383 RID: 4995
		// (get) Token: 0x060067C8 RID: 26568 RVA: 0x000F998F File Offset: 0x000F7B8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001384 RID: 4996
		// (get) Token: 0x060067C9 RID: 26569 RVA: 0x000F9992 File Offset: 0x000F7B92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnterBigWorldInstContext.Descriptor;
			}
		}

		// Token: 0x060067CA RID: 26570 RVA: 0x000F9999 File Offset: 0x000F7B99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterBigWorldInstContext()
		{
		}

		// Token: 0x060067CB RID: 26571 RVA: 0x000F99A1 File Offset: 0x000F7BA1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterBigWorldInstContext(EnterBigWorldInstContext other) : this()
		{
			if (other.EnterCtxCase == EnterBigWorldInstContext.EnterCtxOneofCase.SpringFestivalCtx)
			{
				this.SpringFestivalCtx = other.SpringFestivalCtx.Clone();
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060067CC RID: 26572 RVA: 0x000F99D4 File Offset: 0x000F7BD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterBigWorldInstContext Clone()
		{
			return new EnterBigWorldInstContext(this);
		}

		// Token: 0x17001385 RID: 4997
		// (get) Token: 0x060067CD RID: 26573 RVA: 0x000F99DC File Offset: 0x000F7BDC
		// (set) Token: 0x060067CE RID: 26574 RVA: 0x000F99F4 File Offset: 0x000F7BF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SpringFestivalCtx SpringFestivalCtx
		{
			get
			{
				if (this.enterCtxCase_ != EnterBigWorldInstContext.EnterCtxOneofCase.SpringFestivalCtx)
				{
					return null;
				}
				return (SpringFestivalCtx)this.enterCtx_;
			}
			set
			{
				this.enterCtx_ = value;
				this.enterCtxCase_ = ((value == null) ? EnterBigWorldInstContext.EnterCtxOneofCase.None : EnterBigWorldInstContext.EnterCtxOneofCase.SpringFestivalCtx);
			}
		}

		// Token: 0x17001386 RID: 4998
		// (get) Token: 0x060067CF RID: 26575 RVA: 0x000F9A0A File Offset: 0x000F7C0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnterBigWorldInstContext.EnterCtxOneofCase EnterCtxCase
		{
			get
			{
				return this.enterCtxCase_;
			}
		}

		// Token: 0x060067D0 RID: 26576 RVA: 0x000F9A12 File Offset: 0x000F7C12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearEnterCtx()
		{
			this.enterCtxCase_ = EnterBigWorldInstContext.EnterCtxOneofCase.None;
			this.enterCtx_ = null;
		}

		// Token: 0x060067D1 RID: 26577 RVA: 0x000F9A22 File Offset: 0x000F7C22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnterBigWorldInstContext);
		}

		// Token: 0x060067D2 RID: 26578 RVA: 0x000F9A30 File Offset: 0x000F7C30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnterBigWorldInstContext other)
		{
			return other != null && (other == this || (object.Equals(this.SpringFestivalCtx, other.SpringFestivalCtx) && this.EnterCtxCase == other.EnterCtxCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060067D3 RID: 26579 RVA: 0x000F9A80 File Offset: 0x000F7C80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.enterCtxCase_ == EnterBigWorldInstContext.EnterCtxOneofCase.SpringFestivalCtx)
			{
				num ^= this.SpringFestivalCtx.GetHashCode();
			}
			num ^= (int)this.enterCtxCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060067D4 RID: 26580 RVA: 0x000F9AC6 File Offset: 0x000F7CC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060067D5 RID: 26581 RVA: 0x000F9AD3 File Offset: 0x000F7CD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060067D6 RID: 26582 RVA: 0x000F9ADC File Offset: 0x000F7CDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.enterCtxCase_ == EnterBigWorldInstContext.EnterCtxOneofCase.SpringFestivalCtx)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.SpringFestivalCtx);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060067D7 RID: 26583 RVA: 0x000F9B10 File Offset: 0x000F7D10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.enterCtxCase_ == EnterBigWorldInstContext.EnterCtxOneofCase.SpringFestivalCtx)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SpringFestivalCtx);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060067D8 RID: 26584 RVA: 0x000F9B50 File Offset: 0x000F7D50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnterBigWorldInstContext other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EnterCtxCase == EnterBigWorldInstContext.EnterCtxOneofCase.SpringFestivalCtx)
			{
				if (this.SpringFestivalCtx == null)
				{
					this.SpringFestivalCtx = new SpringFestivalCtx();
				}
				this.SpringFestivalCtx.MergeFrom(other.SpringFestivalCtx);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060067D9 RID: 26585 RVA: 0x000F9BA5 File Offset: 0x000F7DA5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060067DA RID: 26586 RVA: 0x000F9BB0 File Offset: 0x000F7DB0
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
					SpringFestivalCtx springFestivalCtx = new SpringFestivalCtx();
					if (this.enterCtxCase_ == EnterBigWorldInstContext.EnterCtxOneofCase.SpringFestivalCtx)
					{
						springFestivalCtx.MergeFrom(this.SpringFestivalCtx);
					}
					input.ReadMessage(springFestivalCtx);
					this.SpringFestivalCtx = springFestivalCtx;
				}
			}
		}

		// Token: 0x040039DC RID: 14812
		private UnknownFieldSet _unknownFields;

		// Token: 0x040039DD RID: 14813
		public const int SpringFestivalCtxFieldNumber = 1;

		// Token: 0x040039DE RID: 14814
		private object enterCtx_;

		// Token: 0x040039DF RID: 14815
		private EnterBigWorldInstContext.EnterCtxOneofCase enterCtxCase_;

		// Token: 0x020017E1 RID: 6113
		public enum EnterCtxOneofCase
		{
			// Token: 0x0400CB17 RID: 51991
			None,
			// Token: 0x0400CB18 RID: 51992
			SpringFestivalCtx
		}
	}
}
