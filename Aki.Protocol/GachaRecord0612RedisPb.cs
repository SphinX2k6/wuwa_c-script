using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200069B RID: 1691
	public sealed class GachaRecord0612RedisPb : IMessage<GachaRecord0612RedisPb>, IMessage, IEquatable<GachaRecord0612RedisPb>, IDeepCloneable<GachaRecord0612RedisPb>, IBufferMessage
	{
		// Token: 0x06009AD8 RID: 39640 RVA: 0x00175B13 File Offset: 0x00173D13
		[NullableContext(1)]
		public static GachaRecord0612RedisPb Create()
		{
			return new GachaRecord0612RedisPb();
		}

		// Token: 0x17001EFB RID: 7931
		// (get) Token: 0x06009AD9 RID: 39641 RVA: 0x00175B1A File Offset: 0x00173D1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001EFC RID: 7932
		// (get) Token: 0x06009ADA RID: 39642 RVA: 0x00175B1D File Offset: 0x00173D1D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GachaRecord0612RedisPb.Descriptor;
			}
		}

		// Token: 0x06009ADB RID: 39643 RVA: 0x00175B24 File Offset: 0x00173D24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaRecord0612RedisPb()
		{
		}

		// Token: 0x06009ADC RID: 39644 RVA: 0x00175B37 File Offset: 0x00173D37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaRecord0612RedisPb(GachaRecord0612RedisPb other) : this()
		{
			this.itemTimes_ = other.itemTimes_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009ADD RID: 39645 RVA: 0x00175B61 File Offset: 0x00173D61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaRecord0612RedisPb Clone()
		{
			return new GachaRecord0612RedisPb(this);
		}

		// Token: 0x17001EFD RID: 7933
		// (get) Token: 0x06009ADE RID: 39646 RVA: 0x00175B69 File Offset: 0x00173D69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> ItemTimes
		{
			get
			{
				return this.itemTimes_;
			}
		}

		// Token: 0x06009ADF RID: 39647 RVA: 0x00175B71 File Offset: 0x00173D71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GachaRecord0612RedisPb);
		}

		// Token: 0x06009AE0 RID: 39648 RVA: 0x00175B7F File Offset: 0x00173D7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GachaRecord0612RedisPb other)
		{
			return other != null && (other == this || (this.ItemTimes.Equals(other.ItemTimes) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009AE1 RID: 39649 RVA: 0x00175BB4 File Offset: 0x00173DB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.ItemTimes.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009AE2 RID: 39650 RVA: 0x00175BE8 File Offset: 0x00173DE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009AE3 RID: 39651 RVA: 0x00175BF5 File Offset: 0x00173DF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009AE4 RID: 39652 RVA: 0x00175BFE File Offset: 0x00173DFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.itemTimes_.WriteTo(ref output, GachaRecord0612RedisPb._map_itemTimes_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009AE5 RID: 39653 RVA: 0x00175C28 File Offset: 0x00173E28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.itemTimes_.CalculateSize(GachaRecord0612RedisPb._map_itemTimes_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009AE6 RID: 39654 RVA: 0x00175C61 File Offset: 0x00173E61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GachaRecord0612RedisPb other)
		{
			if (other == null)
			{
				return;
			}
			this.itemTimes_.MergeFrom(other.itemTimes_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009AE7 RID: 39655 RVA: 0x00175C8F File Offset: 0x00173E8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009AE8 RID: 39656 RVA: 0x00175C98 File Offset: 0x00173E98
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
					this.itemTimes_.AddEntriesFrom(ref input, GachaRecord0612RedisPb._map_itemTimes_codec);
				}
			}
		}

		// Token: 0x04004938 RID: 18744
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004939 RID: 18745
		public const int ItemTimesFieldNumber = 1;

		// Token: 0x0400493A RID: 18746
		private static readonly MapField<int, int>.Codec _map_itemTimes_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 10U);

		// Token: 0x0400493B RID: 18747
		private readonly MapField<int, int> itemTimes_ = new MapField<int, int>();
	}
}
