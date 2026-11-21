using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E40 RID: 3648
	public sealed class RacingBetsDangoActionChangeHigh : IMessage<RacingBetsDangoActionChangeHigh>, IMessage, IEquatable<RacingBetsDangoActionChangeHigh>, IDeepCloneable<RacingBetsDangoActionChangeHigh>, IBufferMessage
	{
		// Token: 0x060139D7 RID: 80343 RVA: 0x002DA9B5 File Offset: 0x002D8BB5
		[NullableContext(1)]
		public static RacingBetsDangoActionChangeHigh Create()
		{
			return new RacingBetsDangoActionChangeHigh();
		}

		// Token: 0x1700411D RID: 16669
		// (get) Token: 0x060139D8 RID: 80344 RVA: 0x002DA9BC File Offset: 0x002D8BBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700411E RID: 16670
		// (get) Token: 0x060139D9 RID: 80345 RVA: 0x002DA9BF File Offset: 0x002D8BBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsDangoActionChangeHigh.Descriptor;
			}
		}

		// Token: 0x060139DA RID: 80346 RVA: 0x002DA9C6 File Offset: 0x002D8BC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsDangoActionChangeHigh()
		{
		}

		// Token: 0x060139DB RID: 80347 RVA: 0x002DA9D9 File Offset: 0x002D8BD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsDangoActionChangeHigh(RacingBetsDangoActionChangeHigh other) : this()
		{
			this.data_ = other.data_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060139DC RID: 80348 RVA: 0x002DAA03 File Offset: 0x002D8C03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsDangoActionChangeHigh Clone()
		{
			return new RacingBetsDangoActionChangeHigh(this);
		}

		// Token: 0x1700411F RID: 16671
		// (get) Token: 0x060139DD RID: 80349 RVA: 0x002DAA0B File Offset: 0x002D8C0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RacingBetsChangeHighData> Data
		{
			get
			{
				return this.data_;
			}
		}

		// Token: 0x060139DE RID: 80350 RVA: 0x002DAA13 File Offset: 0x002D8C13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsDangoActionChangeHigh);
		}

		// Token: 0x060139DF RID: 80351 RVA: 0x002DAA21 File Offset: 0x002D8C21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsDangoActionChangeHigh other)
		{
			return other != null && (other == this || (this.data_.Equals(other.data_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060139E0 RID: 80352 RVA: 0x002DAA54 File Offset: 0x002D8C54
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

		// Token: 0x060139E1 RID: 80353 RVA: 0x002DAA88 File Offset: 0x002D8C88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060139E2 RID: 80354 RVA: 0x002DAA95 File Offset: 0x002D8C95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060139E3 RID: 80355 RVA: 0x002DAA9E File Offset: 0x002D8C9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.data_.WriteTo(ref output, RacingBetsDangoActionChangeHigh._repeated_data_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060139E4 RID: 80356 RVA: 0x002DAAC8 File Offset: 0x002D8CC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.data_.CalculateSize(RacingBetsDangoActionChangeHigh._repeated_data_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060139E5 RID: 80357 RVA: 0x002DAB01 File Offset: 0x002D8D01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetsDangoActionChangeHigh other)
		{
			if (other == null)
			{
				return;
			}
			this.data_.Add(other.data_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060139E6 RID: 80358 RVA: 0x002DAB2F File Offset: 0x002D8D2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060139E7 RID: 80359 RVA: 0x002DAB38 File Offset: 0x002D8D38
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
					this.data_.AddEntriesFrom(ref input, RacingBetsDangoActionChangeHigh._repeated_data_codec);
				}
			}
		}

		// Token: 0x04007886 RID: 30854
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007887 RID: 30855
		public const int DataFieldNumber = 1;

		// Token: 0x04007888 RID: 30856
		private static readonly FieldCodec<RacingBetsChangeHighData> _repeated_data_codec = FieldCodec.ForMessage<RacingBetsChangeHighData>(10U, RacingBetsChangeHighData.Parser);

		// Token: 0x04007889 RID: 30857
		private readonly RepeatedField<RacingBetsChangeHighData> data_ = new RepeatedField<RacingBetsChangeHighData>();
	}
}
