using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E54 RID: 3668
	public sealed class RacingBetsDangoActionTransmit : IMessage<RacingBetsDangoActionTransmit>, IMessage, IEquatable<RacingBetsDangoActionTransmit>, IDeepCloneable<RacingBetsDangoActionTransmit>, IBufferMessage
	{
		// Token: 0x06013B12 RID: 80658 RVA: 0x002DCCDA File Offset: 0x002DAEDA
		[NullableContext(1)]
		public static RacingBetsDangoActionTransmit Create()
		{
			return new RacingBetsDangoActionTransmit();
		}

		// Token: 0x1700415A RID: 16730
		// (get) Token: 0x06013B13 RID: 80659 RVA: 0x002DCCE1 File Offset: 0x002DAEE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700415B RID: 16731
		// (get) Token: 0x06013B14 RID: 80660 RVA: 0x002DCCE4 File Offset: 0x002DAEE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsDangoActionTransmit.Descriptor;
			}
		}

		// Token: 0x06013B15 RID: 80661 RVA: 0x002DCCEB File Offset: 0x002DAEEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsDangoActionTransmit()
		{
		}

		// Token: 0x06013B16 RID: 80662 RVA: 0x002DCCFE File Offset: 0x002DAEFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsDangoActionTransmit(RacingBetsDangoActionTransmit other) : this()
		{
			this.data_ = other.data_.Clone();
			this.triggerDangoId_ = other.triggerDangoId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013B17 RID: 80663 RVA: 0x002DCD34 File Offset: 0x002DAF34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsDangoActionTransmit Clone()
		{
			return new RacingBetsDangoActionTransmit(this);
		}

		// Token: 0x1700415C RID: 16732
		// (get) Token: 0x06013B18 RID: 80664 RVA: 0x002DCD3C File Offset: 0x002DAF3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RacingBetsTransmitData> Data
		{
			get
			{
				return this.data_;
			}
		}

		// Token: 0x1700415D RID: 16733
		// (get) Token: 0x06013B19 RID: 80665 RVA: 0x002DCD44 File Offset: 0x002DAF44
		// (set) Token: 0x06013B1A RID: 80666 RVA: 0x002DCD4C File Offset: 0x002DAF4C
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

		// Token: 0x06013B1B RID: 80667 RVA: 0x002DCD55 File Offset: 0x002DAF55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsDangoActionTransmit);
		}

		// Token: 0x06013B1C RID: 80668 RVA: 0x002DCD64 File Offset: 0x002DAF64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsDangoActionTransmit other)
		{
			return other != null && (other == this || (this.data_.Equals(other.data_) && this.TriggerDangoId == other.TriggerDangoId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013B1D RID: 80669 RVA: 0x002DCDB4 File Offset: 0x002DAFB4
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

		// Token: 0x06013B1E RID: 80670 RVA: 0x002DCE01 File Offset: 0x002DB001
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013B1F RID: 80671 RVA: 0x002DCE0E File Offset: 0x002DB00E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013B20 RID: 80672 RVA: 0x002DCE18 File Offset: 0x002DB018
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

		// Token: 0x06013B21 RID: 80673 RVA: 0x002DCE68 File Offset: 0x002DB068
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

		// Token: 0x06013B22 RID: 80674 RVA: 0x002DCEBC File Offset: 0x002DB0BC
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

		// Token: 0x06013B23 RID: 80675 RVA: 0x002DCF09 File Offset: 0x002DB109
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013B24 RID: 80676 RVA: 0x002DCF14 File Offset: 0x002DB114
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

		// Token: 0x04007879 RID: 30841
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400787A RID: 30842
		public const int DataFieldNumber = 1;

		// Token: 0x0400787B RID: 30843
		private static readonly FieldCodec<RacingBetsTransmitData> _repeated_data_codec = FieldCodec.ForMessage<RacingBetsTransmitData>(10U, RacingBetsTransmitData.Parser);

		// Token: 0x0400787C RID: 30844
		private readonly RepeatedField<RacingBetsTransmitData> data_ = new RepeatedField<RacingBetsTransmitData>();

		// Token: 0x0400787D RID: 30845
		public const int TriggerDangoIdFieldNumber = 4;

		// Token: 0x0400787E RID: 30846
		private int triggerDangoId_;
	}
}
