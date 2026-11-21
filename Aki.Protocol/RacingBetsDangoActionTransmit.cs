using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E44 RID: 3652
	public sealed class RacingBetsDangoActionTransmit : IMessage<RacingBetsDangoActionTransmit>, IMessage, IEquatable<RacingBetsDangoActionTransmit>, IDeepCloneable<RacingBetsDangoActionTransmit>, IBufferMessage
	{
		// Token: 0x06013A2D RID: 80429 RVA: 0x002DB61E File Offset: 0x002D981E
		[NullableContext(1)]
		public static RacingBetsDangoActionTransmit Create()
		{
			return new RacingBetsDangoActionTransmit();
		}

		// Token: 0x17004130 RID: 16688
		// (get) Token: 0x06013A2E RID: 80430 RVA: 0x002DB625 File Offset: 0x002D9825
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004131 RID: 16689
		// (get) Token: 0x06013A2F RID: 80431 RVA: 0x002DB628 File Offset: 0x002D9828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsDangoActionTransmit.Descriptor;
			}
		}

		// Token: 0x06013A30 RID: 80432 RVA: 0x002DB62F File Offset: 0x002D982F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsDangoActionTransmit()
		{
		}

		// Token: 0x06013A31 RID: 80433 RVA: 0x002DB642 File Offset: 0x002D9842
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsDangoActionTransmit(RacingBetsDangoActionTransmit other) : this()
		{
			this.data_ = other.data_.Clone();
			this.triggerDangoId_ = other.triggerDangoId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013A32 RID: 80434 RVA: 0x002DB678 File Offset: 0x002D9878
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsDangoActionTransmit Clone()
		{
			return new RacingBetsDangoActionTransmit(this);
		}

		// Token: 0x17004132 RID: 16690
		// (get) Token: 0x06013A33 RID: 80435 RVA: 0x002DB680 File Offset: 0x002D9880
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RacingBetsTransmitData> Data
		{
			get
			{
				return this.data_;
			}
		}

		// Token: 0x17004133 RID: 16691
		// (get) Token: 0x06013A34 RID: 80436 RVA: 0x002DB688 File Offset: 0x002D9888
		// (set) Token: 0x06013A35 RID: 80437 RVA: 0x002DB690 File Offset: 0x002D9890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TriggerDangoId
		{
			get
			{
				return this.triggerDangoId_;
			}
			set
			{
				this.triggerDangoId_ = value;
			}
		}

		// Token: 0x06013A36 RID: 80438 RVA: 0x002DB699 File Offset: 0x002D9899
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsDangoActionTransmit);
		}

		// Token: 0x06013A37 RID: 80439 RVA: 0x002DB6A8 File Offset: 0x002D98A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsDangoActionTransmit other)
		{
			return other != null && (other == this || (this.data_.Equals(other.data_) && this.TriggerDangoId == other.TriggerDangoId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013A38 RID: 80440 RVA: 0x002DB6F8 File Offset: 0x002D98F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.data_.GetHashCode();
			if (this.TriggerDangoId != 0)
			{
				num ^= this.TriggerDangoId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013A39 RID: 80441 RVA: 0x002DB745 File Offset: 0x002D9945
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013A3A RID: 80442 RVA: 0x002DB752 File Offset: 0x002D9952
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013A3B RID: 80443 RVA: 0x002DB75C File Offset: 0x002D995C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.data_.WriteTo(ref output, RacingBetsDangoActionTransmit._repeated_data_codec);
			if (this.TriggerDangoId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.TriggerDangoId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013A3C RID: 80444 RVA: 0x002DB7AC File Offset: 0x002D99AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.data_.CalculateSize(RacingBetsDangoActionTransmit._repeated_data_codec);
			if (this.TriggerDangoId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TriggerDangoId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013A3D RID: 80445 RVA: 0x002DB800 File Offset: 0x002D9A00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetsDangoActionTransmit other)
		{
			if (other == null)
			{
				return;
			}
			this.data_.Add(other.data_);
			if (other.TriggerDangoId != 0)
			{
				this.TriggerDangoId = other.TriggerDangoId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013A3E RID: 80446 RVA: 0x002DB84D File Offset: 0x002D9A4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013A3F RID: 80447 RVA: 0x002DB858 File Offset: 0x002D9A58
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
					if (num != 32U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.TriggerDangoId = input.ReadInt32();
					}
				}
				else
				{
					this.data_.AddEntriesFrom(ref input, RacingBetsDangoActionTransmit._repeated_data_codec);
				}
			}
		}

		// Token: 0x040078A3 RID: 30883
		private UnknownFieldSet _unknownFields;

		// Token: 0x040078A4 RID: 30884
		public const int DataFieldNumber = 1;

		// Token: 0x040078A5 RID: 30885
		private static readonly FieldCodec<RacingBetsTransmitData> _repeated_data_codec = FieldCodec.ForMessage<RacingBetsTransmitData>(10U, RacingBetsTransmitData.Parser);

		// Token: 0x040078A6 RID: 30886
		private readonly RepeatedField<RacingBetsTransmitData> data_ = new RepeatedField<RacingBetsTransmitData>();

		// Token: 0x040078A7 RID: 30887
		public const int TriggerDangoIdFieldNumber = 4;

		// Token: 0x040078A8 RID: 30888
		private int triggerDangoId_;
	}
}
