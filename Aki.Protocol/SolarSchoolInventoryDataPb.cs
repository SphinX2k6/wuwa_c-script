using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012AF RID: 4783
	public sealed class SolarSchoolInventoryDataPb : IMessage<SolarSchoolInventoryDataPb>, IMessage, IEquatable<SolarSchoolInventoryDataPb>, IDeepCloneable<SolarSchoolInventoryDataPb>, IBufferMessage
	{
		// Token: 0x06019881 RID: 104577 RVA: 0x003B966F File Offset: 0x003B786F
		[NullableContext(1)]
		public static SolarSchoolInventoryDataPb Create()
		{
			return new SolarSchoolInventoryDataPb();
		}

		// Token: 0x17005669 RID: 22121
		// (get) Token: 0x06019882 RID: 104578 RVA: 0x003B9676 File Offset: 0x003B7876
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700566A RID: 22122
		// (get) Token: 0x06019883 RID: 104579 RVA: 0x003B9679 File Offset: 0x003B7879
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SolarSchoolInventoryDataPb.Descriptor;
			}
		}

		// Token: 0x06019884 RID: 104580 RVA: 0x003B9680 File Offset: 0x003B7880
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolInventoryDataPb()
		{
		}

		// Token: 0x06019885 RID: 104581 RVA: 0x003B969E File Offset: 0x003B789E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolInventoryDataPb(SolarSchoolInventoryDataPb other) : this()
		{
			this.items_ = other.items_.Clone();
			this.gotItemBit_ = other.gotItemBit_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019886 RID: 104582 RVA: 0x003B96D9 File Offset: 0x003B78D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SolarSchoolInventoryDataPb Clone()
		{
			return new SolarSchoolInventoryDataPb(this);
		}

		// Token: 0x1700566B RID: 22123
		// (get) Token: 0x06019887 RID: 104583 RVA: 0x003B96E1 File Offset: 0x003B78E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SolarSchoolIdCountPb> Items
		{
			get
			{
				return this.items_;
			}
		}

		// Token: 0x1700566C RID: 22124
		// (get) Token: 0x06019888 RID: 104584 RVA: 0x003B96E9 File Offset: 0x003B78E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> GotItemBit
		{
			get
			{
				return this.gotItemBit_;
			}
		}

		// Token: 0x06019889 RID: 104585 RVA: 0x003B96F1 File Offset: 0x003B78F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SolarSchoolInventoryDataPb);
		}

		// Token: 0x0601988A RID: 104586 RVA: 0x003B9700 File Offset: 0x003B7900
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SolarSchoolInventoryDataPb other)
		{
			return other != null && (other == this || (this.items_.Equals(other.items_) && this.gotItemBit_.Equals(other.gotItemBit_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601988B RID: 104587 RVA: 0x003B9754 File Offset: 0x003B7954
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.items_.GetHashCode();
			num ^= this.gotItemBit_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601988C RID: 104588 RVA: 0x003B9796 File Offset: 0x003B7996
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601988D RID: 104589 RVA: 0x003B97A3 File Offset: 0x003B79A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601988E RID: 104590 RVA: 0x003B97AC File Offset: 0x003B79AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.items_.WriteTo(ref output, SolarSchoolInventoryDataPb._repeated_items_codec);
			this.gotItemBit_.WriteTo(ref output, SolarSchoolInventoryDataPb._repeated_gotItemBit_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601988F RID: 104591 RVA: 0x003B97E4 File Offset: 0x003B79E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.items_.CalculateSize(SolarSchoolInventoryDataPb._repeated_items_codec);
			num += this.gotItemBit_.CalculateSize(SolarSchoolInventoryDataPb._repeated_gotItemBit_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019890 RID: 104592 RVA: 0x003B9830 File Offset: 0x003B7A30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SolarSchoolInventoryDataPb other)
		{
			if (other == null)
			{
				return;
			}
			this.items_.Add(other.items_);
			this.gotItemBit_.Add(other.gotItemBit_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019891 RID: 104593 RVA: 0x003B986F File Offset: 0x003B7A6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019892 RID: 104594 RVA: 0x003B9878 File Offset: 0x003B7A78
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
					if (num != 16U && num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.gotItemBit_.AddEntriesFrom(ref input, SolarSchoolInventoryDataPb._repeated_gotItemBit_codec);
					}
				}
				else
				{
					this.items_.AddEntriesFrom(ref input, SolarSchoolInventoryDataPb._repeated_items_codec);
				}
			}
		}

		// Token: 0x040096DD RID: 38621
		private UnknownFieldSet _unknownFields;

		// Token: 0x040096DE RID: 38622
		public const int ItemsFieldNumber = 1;

		// Token: 0x040096DF RID: 38623
		private static readonly FieldCodec<SolarSchoolIdCountPb> _repeated_items_codec = FieldCodec.ForMessage<SolarSchoolIdCountPb>(10U, SolarSchoolIdCountPb.Parser);

		// Token: 0x040096E0 RID: 38624
		private readonly RepeatedField<SolarSchoolIdCountPb> items_ = new RepeatedField<SolarSchoolIdCountPb>();

		// Token: 0x040096E1 RID: 38625
		public const int GotItemBitFieldNumber = 2;

		// Token: 0x040096E2 RID: 38626
		private static readonly FieldCodec<long> _repeated_gotItemBit_codec = FieldCodec.ForInt64(18U);

		// Token: 0x040096E3 RID: 38627
		private readonly RepeatedField<long> gotItemBit_ = new RepeatedField<long>();
	}
}
