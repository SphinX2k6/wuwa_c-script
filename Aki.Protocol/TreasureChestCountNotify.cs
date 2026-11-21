using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014D7 RID: 5335
	[NetMessage(EMessageId.TreasureChestCountNotify)]
	public sealed class TreasureChestCountNotify : IMessage<TreasureChestCountNotify>, IMessage, IEquatable<TreasureChestCountNotify>, IDeepCloneable<TreasureChestCountNotify>, IBufferMessage
	{
		// Token: 0x0601C4BC RID: 115900 RVA: 0x0041B1B8 File Offset: 0x004193B8
		[NullableContext(1)]
		public static TreasureChestCountNotify Create()
		{
			return new TreasureChestCountNotify();
		}

		// Token: 0x17005FC4 RID: 24516
		// (get) Token: 0x0601C4BD RID: 115901 RVA: 0x0041B1BF File Offset: 0x004193BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005FC5 RID: 24517
		// (get) Token: 0x0601C4BE RID: 115902 RVA: 0x0041B1C2 File Offset: 0x004193C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TreasureChestCountNotify.Descriptor;
			}
		}

		// Token: 0x0601C4BF RID: 115903 RVA: 0x0041B1C9 File Offset: 0x004193C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TreasureChestCountNotify()
		{
		}

		// Token: 0x0601C4C0 RID: 115904 RVA: 0x0041B1DC File Offset: 0x004193DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TreasureChestCountNotify(TreasureChestCountNotify other) : this()
		{
			this.data_ = other.data_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C4C1 RID: 115905 RVA: 0x0041B206 File Offset: 0x00419406
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TreasureChestCountNotify Clone()
		{
			return new TreasureChestCountNotify(this);
		}

		// Token: 0x17005FC6 RID: 24518
		// (get) Token: 0x0601C4C2 RID: 115906 RVA: 0x0041B20E File Offset: 0x0041940E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TreasureChestCountData> Data
		{
			get
			{
				return this.data_;
			}
		}

		// Token: 0x0601C4C3 RID: 115907 RVA: 0x0041B216 File Offset: 0x00419416
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TreasureChestCountNotify);
		}

		// Token: 0x0601C4C4 RID: 115908 RVA: 0x0041B224 File Offset: 0x00419424
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TreasureChestCountNotify other)
		{
			return other != null && (other == this || (this.data_.Equals(other.data_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C4C5 RID: 115909 RVA: 0x0041B258 File Offset: 0x00419458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.data_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C4C6 RID: 115910 RVA: 0x0041B28C File Offset: 0x0041948C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C4C7 RID: 115911 RVA: 0x0041B299 File Offset: 0x00419499
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C4C8 RID: 115912 RVA: 0x0041B2A2 File Offset: 0x004194A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.data_.WriteTo(ref output, TreasureChestCountNotify._repeated_data_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C4C9 RID: 115913 RVA: 0x0041B2CC File Offset: 0x004194CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.data_.CalculateSize(TreasureChestCountNotify._repeated_data_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C4CA RID: 115914 RVA: 0x0041B305 File Offset: 0x00419505
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TreasureChestCountNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.data_.Add(other.data_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C4CB RID: 115915 RVA: 0x0041B333 File Offset: 0x00419533
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C4CC RID: 115916 RVA: 0x0041B33C File Offset: 0x0041953C
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
					this.data_.AddEntriesFrom(ref input, TreasureChestCountNotify._repeated_data_codec);
				}
			}
		}

		// Token: 0x0400A384 RID: 41860
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A385 RID: 41861
		public const int DataFieldNumber = 1;

		// Token: 0x0400A386 RID: 41862
		private static readonly FieldCodec<TreasureChestCountData> _repeated_data_codec = FieldCodec.ForMessage<TreasureChestCountData>(10U, TreasureChestCountData.Parser);

		// Token: 0x0400A387 RID: 41863
		private readonly RepeatedField<TreasureChestCountData> data_ = new RepeatedField<TreasureChestCountData>();
	}
}
