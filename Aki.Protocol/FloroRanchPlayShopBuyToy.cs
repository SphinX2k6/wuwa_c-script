using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005BC RID: 1468
	public sealed class FloroRanchPlayShopBuyToy : IMessage<FloroRanchPlayShopBuyToy>, IMessage, IEquatable<FloroRanchPlayShopBuyToy>, IDeepCloneable<FloroRanchPlayShopBuyToy>, IBufferMessage
	{
		// Token: 0x06008844 RID: 34884 RVA: 0x0014970F File Offset: 0x0014790F
		[NullableContext(1)]
		public static FloroRanchPlayShopBuyToy Create()
		{
			return new FloroRanchPlayShopBuyToy();
		}

		// Token: 0x17001AC5 RID: 6853
		// (get) Token: 0x06008845 RID: 34885 RVA: 0x00149716 File Offset: 0x00147916
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001AC6 RID: 6854
		// (get) Token: 0x06008846 RID: 34886 RVA: 0x00149719 File Offset: 0x00147919
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchPlayShopBuyToy.Descriptor;
			}
		}

		// Token: 0x06008847 RID: 34887 RVA: 0x00149720 File Offset: 0x00147920
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayShopBuyToy()
		{
		}

		// Token: 0x06008848 RID: 34888 RVA: 0x00149728 File Offset: 0x00147928
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayShopBuyToy(FloroRanchPlayShopBuyToy other) : this()
		{
			this.newToy_ = ((other.newToy_ != null) ? other.newToy_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008849 RID: 34889 RVA: 0x0014975D File Offset: 0x0014795D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayShopBuyToy Clone()
		{
			return new FloroRanchPlayShopBuyToy(this);
		}

		// Token: 0x17001AC7 RID: 6855
		// (get) Token: 0x0600884A RID: 34890 RVA: 0x00149765 File Offset: 0x00147965
		// (set) Token: 0x0600884B RID: 34891 RVA: 0x0014976D File Offset: 0x0014796D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayUnit NewToy
		{
			get
			{
				return this.newToy_;
			}
			set
			{
				this.newToy_ = value;
			}
		}

		// Token: 0x0600884C RID: 34892 RVA: 0x00149776 File Offset: 0x00147976
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchPlayShopBuyToy);
		}

		// Token: 0x0600884D RID: 34893 RVA: 0x00149784 File Offset: 0x00147984
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchPlayShopBuyToy other)
		{
			return other != null && (other == this || (object.Equals(this.NewToy, other.NewToy) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600884E RID: 34894 RVA: 0x001497B8 File Offset: 0x001479B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.newToy_ != null)
			{
				num ^= this.NewToy.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600884F RID: 34895 RVA: 0x001497F4 File Offset: 0x001479F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008850 RID: 34896 RVA: 0x00149801 File Offset: 0x00147A01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008851 RID: 34897 RVA: 0x0014980A File Offset: 0x00147A0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.newToy_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.NewToy);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008852 RID: 34898 RVA: 0x0014983C File Offset: 0x00147A3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.newToy_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.NewToy);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008853 RID: 34899 RVA: 0x0014987C File Offset: 0x00147A7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchPlayShopBuyToy other)
		{
			if (other == null)
			{
				return;
			}
			if (other.newToy_ != null)
			{
				if (this.newToy_ == null)
				{
					this.NewToy = new FloroRanchPlayUnit();
				}
				this.NewToy.MergeFrom(other.NewToy);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008854 RID: 34900 RVA: 0x001498D0 File Offset: 0x00147AD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008855 RID: 34901 RVA: 0x001498DC File Offset: 0x00147ADC
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
					if (this.newToy_ == null)
					{
						this.NewToy = new FloroRanchPlayUnit();
					}
					input.ReadMessage(this.NewToy);
				}
			}
		}

		// Token: 0x040043A4 RID: 17316
		private UnknownFieldSet _unknownFields;

		// Token: 0x040043A5 RID: 17317
		public const int NewToyFieldNumber = 1;

		// Token: 0x040043A6 RID: 17318
		private FloroRanchPlayUnit newToy_;
	}
}
