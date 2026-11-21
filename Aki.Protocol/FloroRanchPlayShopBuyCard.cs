using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005B8 RID: 1464
	public sealed class FloroRanchPlayShopBuyCard : IMessage<FloroRanchPlayShopBuyCard>, IMessage, IEquatable<FloroRanchPlayShopBuyCard>, IDeepCloneable<FloroRanchPlayShopBuyCard>, IBufferMessage
	{
		// Token: 0x060087E2 RID: 34786 RVA: 0x00148565 File Offset: 0x00146765
		[NullableContext(1)]
		public static FloroRanchPlayShopBuyCard Create()
		{
			return new FloroRanchPlayShopBuyCard();
		}

		// Token: 0x17001AAC RID: 6828
		// (get) Token: 0x060087E3 RID: 34787 RVA: 0x0014856C File Offset: 0x0014676C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001AAD RID: 6829
		// (get) Token: 0x060087E4 RID: 34788 RVA: 0x0014856F File Offset: 0x0014676F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchPlayShopBuyCard.Descriptor;
			}
		}

		// Token: 0x060087E5 RID: 34789 RVA: 0x00148576 File Offset: 0x00146776
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayShopBuyCard()
		{
		}

		// Token: 0x060087E6 RID: 34790 RVA: 0x0014857E File Offset: 0x0014677E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayShopBuyCard(FloroRanchPlayShopBuyCard other) : this()
		{
			this.newPhantom_ = ((other.newPhantom_ != null) ? other.newPhantom_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060087E7 RID: 34791 RVA: 0x001485B3 File Offset: 0x001467B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayShopBuyCard Clone()
		{
			return new FloroRanchPlayShopBuyCard(this);
		}

		// Token: 0x17001AAE RID: 6830
		// (get) Token: 0x060087E8 RID: 34792 RVA: 0x001485BB File Offset: 0x001467BB
		// (set) Token: 0x060087E9 RID: 34793 RVA: 0x001485C3 File Offset: 0x001467C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayUnit NewPhantom
		{
			get
			{
				return this.newPhantom_;
			}
			set
			{
				this.newPhantom_ = value;
			}
		}

		// Token: 0x060087EA RID: 34794 RVA: 0x001485CC File Offset: 0x001467CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchPlayShopBuyCard);
		}

		// Token: 0x060087EB RID: 34795 RVA: 0x001485DA File Offset: 0x001467DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchPlayShopBuyCard other)
		{
			return other != null && (other == this || (object.Equals(this.NewPhantom, other.NewPhantom) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060087EC RID: 34796 RVA: 0x00148610 File Offset: 0x00146810
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.newPhantom_ != null)
			{
				num ^= this.NewPhantom.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060087ED RID: 34797 RVA: 0x0014864C File Offset: 0x0014684C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060087EE RID: 34798 RVA: 0x00148659 File Offset: 0x00146859
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060087EF RID: 34799 RVA: 0x00148662 File Offset: 0x00146862
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.newPhantom_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.NewPhantom);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060087F0 RID: 34800 RVA: 0x00148694 File Offset: 0x00146894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.newPhantom_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.NewPhantom);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060087F1 RID: 34801 RVA: 0x001486D4 File Offset: 0x001468D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchPlayShopBuyCard other)
		{
			if (other == null)
			{
				return;
			}
			if (other.newPhantom_ != null)
			{
				if (this.newPhantom_ == null)
				{
					this.NewPhantom = new FloroRanchPlayUnit();
				}
				this.NewPhantom.MergeFrom(other.NewPhantom);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060087F2 RID: 34802 RVA: 0x00148728 File Offset: 0x00146928
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060087F3 RID: 34803 RVA: 0x00148734 File Offset: 0x00146934
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
					if (this.newPhantom_ == null)
					{
						this.NewPhantom = new FloroRanchPlayUnit();
					}
					input.ReadMessage(this.NewPhantom);
				}
			}
		}

		// Token: 0x04004380 RID: 17280
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004381 RID: 17281
		public const int NewPhantomFieldNumber = 1;

		// Token: 0x04004382 RID: 17282
		private FloroRanchPlayUnit newPhantom_;
	}
}
