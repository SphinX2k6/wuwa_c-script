using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E4F RID: 3663
	public sealed class RacingBetsDangoActionBlackHoleTransmit : IMessage<RacingBetsDangoActionBlackHoleTransmit>, IMessage, IEquatable<RacingBetsDangoActionBlackHoleTransmit>, IDeepCloneable<RacingBetsDangoActionBlackHoleTransmit>, IBufferMessage
	{
		// Token: 0x06013AAA RID: 80554 RVA: 0x002DBE91 File Offset: 0x002DA091
		[NullableContext(1)]
		public static RacingBetsDangoActionBlackHoleTransmit Create()
		{
			return new RacingBetsDangoActionBlackHoleTransmit();
		}

		// Token: 0x17004144 RID: 16708
		// (get) Token: 0x06013AAB RID: 80555 RVA: 0x002DBE98 File Offset: 0x002DA098
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004145 RID: 16709
		// (get) Token: 0x06013AAC RID: 80556 RVA: 0x002DBE9B File Offset: 0x002DA09B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsDangoActionBlackHoleTransmit.Descriptor;
			}
		}

		// Token: 0x06013AAD RID: 80557 RVA: 0x002DBEA2 File Offset: 0x002DA0A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsDangoActionBlackHoleTransmit()
		{
		}

		// Token: 0x06013AAE RID: 80558 RVA: 0x002DBEB5 File Offset: 0x002DA0B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsDangoActionBlackHoleTransmit(RacingBetsDangoActionBlackHoleTransmit other) : this()
		{
			this.data_ = other.data_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013AAF RID: 80559 RVA: 0x002DBEDF File Offset: 0x002DA0DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsDangoActionBlackHoleTransmit Clone()
		{
			return new RacingBetsDangoActionBlackHoleTransmit(this);
		}

		// Token: 0x17004146 RID: 16710
		// (get) Token: 0x06013AB0 RID: 80560 RVA: 0x002DBEE7 File Offset: 0x002DA0E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RacingBetsTransmitData> Data
		{
			get
			{
				return this.data_;
			}
		}

		// Token: 0x06013AB1 RID: 80561 RVA: 0x002DBEEF File Offset: 0x002DA0EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsDangoActionBlackHoleTransmit);
		}

		// Token: 0x06013AB2 RID: 80562 RVA: 0x002DBEFD File Offset: 0x002DA0FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsDangoActionBlackHoleTransmit other)
		{
			return other != null && (other == this || (this.data_.Equals(other.data_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013AB3 RID: 80563 RVA: 0x002DBF30 File Offset: 0x002DA130
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

		// Token: 0x06013AB4 RID: 80564 RVA: 0x002DBF64 File Offset: 0x002DA164
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013AB5 RID: 80565 RVA: 0x002DBF71 File Offset: 0x002DA171
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013AB6 RID: 80566 RVA: 0x002DBF7A File Offset: 0x002DA17A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.data_.WriteTo(ref output, RacingBetsDangoActionBlackHoleTransmit._repeated_data_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013AB7 RID: 80567 RVA: 0x002DBFA4 File Offset: 0x002DA1A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.data_.CalculateSize(RacingBetsDangoActionBlackHoleTransmit._repeated_data_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013AB8 RID: 80568 RVA: 0x002DBFDD File Offset: 0x002DA1DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetsDangoActionBlackHoleTransmit other)
		{
			if (other == null)
			{
				return;
			}
			this.data_.Add(other.data_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013AB9 RID: 80569 RVA: 0x002DC00B File Offset: 0x002DA20B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013ABA RID: 80570 RVA: 0x002DC014 File Offset: 0x002DA214
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
					this.data_.AddEntriesFrom(ref input, RacingBetsDangoActionBlackHoleTransmit._repeated_data_codec);
				}
			}
		}

		// Token: 0x04007858 RID: 30808
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007859 RID: 30809
		public const int DataFieldNumber = 1;

		// Token: 0x0400785A RID: 30810
		private static readonly FieldCodec<RacingBetsTransmitData> _repeated_data_codec = FieldCodec.ForMessage<RacingBetsTransmitData>(10U, RacingBetsTransmitData.Parser);

		// Token: 0x0400785B RID: 30811
		private readonly RepeatedField<RacingBetsTransmitData> data_ = new RepeatedField<RacingBetsTransmitData>();
	}
}
