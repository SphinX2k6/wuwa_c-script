using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E50 RID: 3664
	public sealed class RacingBetsDangoActionChangeHigh : IMessage<RacingBetsDangoActionChangeHigh>, IMessage, IEquatable<RacingBetsDangoActionChangeHigh>, IDeepCloneable<RacingBetsDangoActionChangeHigh>, IBufferMessage
	{
		// Token: 0x06013ABC RID: 80572 RVA: 0x002DC071 File Offset: 0x002DA271
		[NullableContext(1)]
		public static RacingBetsDangoActionChangeHigh Create()
		{
			return new RacingBetsDangoActionChangeHigh();
		}

		// Token: 0x17004147 RID: 16711
		// (get) Token: 0x06013ABD RID: 80573 RVA: 0x002DC078 File Offset: 0x002DA278
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004148 RID: 16712
		// (get) Token: 0x06013ABE RID: 80574 RVA: 0x002DC07B File Offset: 0x002DA27B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsDangoActionChangeHigh.Descriptor;
			}
		}

		// Token: 0x06013ABF RID: 80575 RVA: 0x002DC082 File Offset: 0x002DA282
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsDangoActionChangeHigh()
		{
		}

		// Token: 0x06013AC0 RID: 80576 RVA: 0x002DC095 File Offset: 0x002DA295
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsDangoActionChangeHigh(RacingBetsDangoActionChangeHigh other) : this()
		{
			this.data_ = other.data_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013AC1 RID: 80577 RVA: 0x002DC0BF File Offset: 0x002DA2BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsDangoActionChangeHigh Clone()
		{
			return new RacingBetsDangoActionChangeHigh(this);
		}

		// Token: 0x17004149 RID: 16713
		// (get) Token: 0x06013AC2 RID: 80578 RVA: 0x002DC0C7 File Offset: 0x002DA2C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RacingBetsChangeHighData> Data
		{
			get
			{
				return this.data_;
			}
		}

		// Token: 0x06013AC3 RID: 80579 RVA: 0x002DC0CF File Offset: 0x002DA2CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsDangoActionChangeHigh);
		}

		// Token: 0x06013AC4 RID: 80580 RVA: 0x002DC0DD File Offset: 0x002DA2DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsDangoActionChangeHigh other)
		{
			return other != null && (other == this || (this.data_.Equals(other.data_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013AC5 RID: 80581 RVA: 0x002DC110 File Offset: 0x002DA310
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

		// Token: 0x06013AC6 RID: 80582 RVA: 0x002DC144 File Offset: 0x002DA344
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013AC7 RID: 80583 RVA: 0x002DC151 File Offset: 0x002DA351
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013AC8 RID: 80584 RVA: 0x002DC15A File Offset: 0x002DA35A
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

		// Token: 0x06013AC9 RID: 80585 RVA: 0x002DC184 File Offset: 0x002DA384
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

		// Token: 0x06013ACA RID: 80586 RVA: 0x002DC1BD File Offset: 0x002DA3BD
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

		// Token: 0x06013ACB RID: 80587 RVA: 0x002DC1EB File Offset: 0x002DA3EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013ACC RID: 80588 RVA: 0x002DC1F4 File Offset: 0x002DA3F4
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

		// Token: 0x0400785C RID: 30812
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400785D RID: 30813
		public const int DataFieldNumber = 1;

		// Token: 0x0400785E RID: 30814
		private static readonly FieldCodec<RacingBetsChangeHighData> _repeated_data_codec = FieldCodec.ForMessage<RacingBetsChangeHighData>(10U, RacingBetsChangeHighData.Parser);

		// Token: 0x0400785F RID: 30815
		private readonly RepeatedField<RacingBetsChangeHighData> data_ = new RepeatedField<RacingBetsChangeHighData>();
	}
}
