using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E3F RID: 3647
	public sealed class RacingBetsDangoActionBlackHoleTransmit : IMessage<RacingBetsDangoActionBlackHoleTransmit>, IMessage, IEquatable<RacingBetsDangoActionBlackHoleTransmit>, IDeepCloneable<RacingBetsDangoActionBlackHoleTransmit>, IBufferMessage
	{
		// Token: 0x060139C5 RID: 80325 RVA: 0x002DA7D5 File Offset: 0x002D89D5
		[NullableContext(1)]
		public static RacingBetsDangoActionBlackHoleTransmit Create()
		{
			return new RacingBetsDangoActionBlackHoleTransmit();
		}

		// Token: 0x1700411A RID: 16666
		// (get) Token: 0x060139C6 RID: 80326 RVA: 0x002DA7DC File Offset: 0x002D89DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700411B RID: 16667
		// (get) Token: 0x060139C7 RID: 80327 RVA: 0x002DA7DF File Offset: 0x002D89DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsDangoActionBlackHoleTransmit.Descriptor;
			}
		}

		// Token: 0x060139C8 RID: 80328 RVA: 0x002DA7E6 File Offset: 0x002D89E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsDangoActionBlackHoleTransmit()
		{
		}

		// Token: 0x060139C9 RID: 80329 RVA: 0x002DA7F9 File Offset: 0x002D89F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsDangoActionBlackHoleTransmit(RacingBetsDangoActionBlackHoleTransmit other) : this()
		{
			this.data_ = other.data_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060139CA RID: 80330 RVA: 0x002DA823 File Offset: 0x002D8A23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsDangoActionBlackHoleTransmit Clone()
		{
			return new RacingBetsDangoActionBlackHoleTransmit(this);
		}

		// Token: 0x1700411C RID: 16668
		// (get) Token: 0x060139CB RID: 80331 RVA: 0x002DA82B File Offset: 0x002D8A2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RacingBetsTransmitData> Data
		{
			get
			{
				return this.data_;
			}
		}

		// Token: 0x060139CC RID: 80332 RVA: 0x002DA833 File Offset: 0x002D8A33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsDangoActionBlackHoleTransmit);
		}

		// Token: 0x060139CD RID: 80333 RVA: 0x002DA841 File Offset: 0x002D8A41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsDangoActionBlackHoleTransmit other)
		{
			return other != null && (other == this || (this.data_.Equals(other.data_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060139CE RID: 80334 RVA: 0x002DA874 File Offset: 0x002D8A74
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

		// Token: 0x060139CF RID: 80335 RVA: 0x002DA8A8 File Offset: 0x002D8AA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060139D0 RID: 80336 RVA: 0x002DA8B5 File Offset: 0x002D8AB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060139D1 RID: 80337 RVA: 0x002DA8BE File Offset: 0x002D8ABE
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

		// Token: 0x060139D2 RID: 80338 RVA: 0x002DA8E8 File Offset: 0x002D8AE8
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

		// Token: 0x060139D3 RID: 80339 RVA: 0x002DA921 File Offset: 0x002D8B21
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

		// Token: 0x060139D4 RID: 80340 RVA: 0x002DA94F File Offset: 0x002D8B4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060139D5 RID: 80341 RVA: 0x002DA958 File Offset: 0x002D8B58
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

		// Token: 0x04007882 RID: 30850
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007883 RID: 30851
		public const int DataFieldNumber = 1;

		// Token: 0x04007884 RID: 30852
		private static readonly FieldCodec<RacingBetsTransmitData> _repeated_data_codec = FieldCodec.ForMessage<RacingBetsTransmitData>(10U, RacingBetsTransmitData.Parser);

		// Token: 0x04007885 RID: 30853
		private readonly RepeatedField<RacingBetsTransmitData> data_ = new RepeatedField<RacingBetsTransmitData>();
	}
}
