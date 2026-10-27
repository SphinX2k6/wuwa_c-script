using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200076D RID: 1901
	[NetMessage(EMessageId.HonamiStoryBagSizeUpdateNotify)]
	public sealed class HonamiStoryBagSizeUpdateNotify : IMessage<HonamiStoryBagSizeUpdateNotify>, IMessage, IEquatable<HonamiStoryBagSizeUpdateNotify>, IDeepCloneable<HonamiStoryBagSizeUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600ABE8 RID: 44008 RVA: 0x0019D6D1 File Offset: 0x0019B8D1
		[NullableContext(1)]
		public static HonamiStoryBagSizeUpdateNotify Create()
		{
			return new HonamiStoryBagSizeUpdateNotify();
		}

		// Token: 0x170022A5 RID: 8869
		// (get) Token: 0x0600ABE9 RID: 44009 RVA: 0x0019D6D8 File Offset: 0x0019B8D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170022A6 RID: 8870
		// (get) Token: 0x0600ABEA RID: 44010 RVA: 0x0019D6DB File Offset: 0x0019B8DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryBagSizeUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600ABEB RID: 44011 RVA: 0x0019D6E2 File Offset: 0x0019B8E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryBagSizeUpdateNotify()
		{
		}

		// Token: 0x0600ABEC RID: 44012 RVA: 0x0019D6F5 File Offset: 0x0019B8F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryBagSizeUpdateNotify(HonamiStoryBagSizeUpdateNotify other) : this()
		{
			this.bagSize_ = other.bagSize_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600ABED RID: 44013 RVA: 0x0019D71F File Offset: 0x0019B91F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryBagSizeUpdateNotify Clone()
		{
			return new HonamiStoryBagSizeUpdateNotify(this);
		}

		// Token: 0x170022A7 RID: 8871
		// (get) Token: 0x0600ABEE RID: 44014 RVA: 0x0019D727 File Offset: 0x0019B927
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> BagSize
		{
			get
			{
				return this.bagSize_;
			}
		}

		// Token: 0x0600ABEF RID: 44015 RVA: 0x0019D72F File Offset: 0x0019B92F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryBagSizeUpdateNotify);
		}

		// Token: 0x0600ABF0 RID: 44016 RVA: 0x0019D73D File Offset: 0x0019B93D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryBagSizeUpdateNotify other)
		{
			return other != null && (other == this || (this.BagSize.Equals(other.BagSize) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600ABF1 RID: 44017 RVA: 0x0019D770 File Offset: 0x0019B970
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

		// Token: 0x0600ABF2 RID: 44018 RVA: 0x0019D7A4 File Offset: 0x0019B9A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600ABF3 RID: 44019 RVA: 0x0019D7B1 File Offset: 0x0019B9B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600ABF4 RID: 44020 RVA: 0x0019D7BA File Offset: 0x0019B9BA
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

		// Token: 0x0600ABF5 RID: 44021 RVA: 0x0019D7E4 File Offset: 0x0019B9E4
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

		// Token: 0x0600ABF6 RID: 44022 RVA: 0x0019D81D File Offset: 0x0019BA1D
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

		// Token: 0x0600ABF7 RID: 44023 RVA: 0x0019D84B File Offset: 0x0019BA4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600ABF8 RID: 44024 RVA: 0x0019D854 File Offset: 0x0019BA54
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
				if (num != 50U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.bagSize_.AddEntriesFrom(ref input, HonamiStoryBagSizeUpdateNotify._map_bagSize_codec);
				}
			}
		}

		// Token: 0x04004DF5 RID: 19957
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004DF6 RID: 19958
		public const int BagSizeFieldNumber = 6;

		// Token: 0x04004DF7 RID: 19959
		private static readonly MapField<int, int>.Codec _map_bagSize_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 50U);

		// Token: 0x04004DF8 RID: 19960
		private readonly MapField<int, int> bagSize_ = new MapField<int, int>();
	}
}
