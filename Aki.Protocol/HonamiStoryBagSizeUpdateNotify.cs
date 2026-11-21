using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000759 RID: 1881
	[NetMessage(EMessageId.HonamiStoryBagSizeUpdateNotify)]
	public sealed class HonamiStoryBagSizeUpdateNotify : IMessage<HonamiStoryBagSizeUpdateNotify>, IMessage, IEquatable<HonamiStoryBagSizeUpdateNotify>, IDeepCloneable<HonamiStoryBagSizeUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600AA92 RID: 43666 RVA: 0x0019ACA9 File Offset: 0x00198EA9
		[NullableContext(1)]
		public static HonamiStoryBagSizeUpdateNotify Create()
		{
			return new HonamiStoryBagSizeUpdateNotify();
		}

		// Token: 0x1700225B RID: 8795
		// (get) Token: 0x0600AA93 RID: 43667 RVA: 0x0019ACB0 File Offset: 0x00198EB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700225C RID: 8796
		// (get) Token: 0x0600AA94 RID: 43668 RVA: 0x0019ACB3 File Offset: 0x00198EB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryBagSizeUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600AA95 RID: 43669 RVA: 0x0019ACBA File Offset: 0x00198EBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryBagSizeUpdateNotify()
		{
		}

		// Token: 0x0600AA96 RID: 43670 RVA: 0x0019ACCD File Offset: 0x00198ECD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryBagSizeUpdateNotify(HonamiStoryBagSizeUpdateNotify other) : this()
		{
			this.bagSize_ = other.bagSize_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AA97 RID: 43671 RVA: 0x0019ACF7 File Offset: 0x00198EF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryBagSizeUpdateNotify Clone()
		{
			return new HonamiStoryBagSizeUpdateNotify(this);
		}

		// Token: 0x1700225D RID: 8797
		// (get) Token: 0x0600AA98 RID: 43672 RVA: 0x0019ACFF File Offset: 0x00198EFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> BagSize
		{
			get
			{
				return this.bagSize_;
			}
		}

		// Token: 0x0600AA99 RID: 43673 RVA: 0x0019AD07 File Offset: 0x00198F07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryBagSizeUpdateNotify);
		}

		// Token: 0x0600AA9A RID: 43674 RVA: 0x0019AD15 File Offset: 0x00198F15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryBagSizeUpdateNotify other)
		{
			return other != null && (other == this || (this.BagSize.Equals(other.BagSize) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AA9B RID: 43675 RVA: 0x0019AD48 File Offset: 0x00198F48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.BagSize.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AA9C RID: 43676 RVA: 0x0019AD7C File Offset: 0x00198F7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AA9D RID: 43677 RVA: 0x0019AD89 File Offset: 0x00198F89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AA9E RID: 43678 RVA: 0x0019AD92 File Offset: 0x00198F92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.bagSize_.WriteTo(ref output, HonamiStoryBagSizeUpdateNotify._map_bagSize_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AA9F RID: 43679 RVA: 0x0019ADBC File Offset: 0x00198FBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.bagSize_.CalculateSize(HonamiStoryBagSizeUpdateNotify._map_bagSize_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AAA0 RID: 43680 RVA: 0x0019ADF5 File Offset: 0x00198FF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryBagSizeUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.bagSize_.MergeFrom(other.bagSize_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AAA1 RID: 43681 RVA: 0x0019AE23 File Offset: 0x00199023
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AAA2 RID: 43682 RVA: 0x0019AE2C File Offset: 0x0019902C
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
				if (num != 74U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.bagSize_.AddEntriesFrom(ref input, HonamiStoryBagSizeUpdateNotify._map_bagSize_codec);
				}
			}
		}

		// Token: 0x04004DEE RID: 19950
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004DEF RID: 19951
		public const int BagSizeFieldNumber = 9;

		// Token: 0x04004DF0 RID: 19952
		private static readonly MapField<int, int>.Codec _map_bagSize_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 74U);

		// Token: 0x04004DF1 RID: 19953
		private readonly MapField<int, int> bagSize_ = new MapField<int, int>();
	}
}
