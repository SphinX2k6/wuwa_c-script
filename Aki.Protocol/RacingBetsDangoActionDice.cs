using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E51 RID: 3665
	public sealed class RacingBetsDangoActionDice : IMessage<RacingBetsDangoActionDice>, IMessage, IEquatable<RacingBetsDangoActionDice>, IDeepCloneable<RacingBetsDangoActionDice>, IBufferMessage
	{
		// Token: 0x06013ACE RID: 80590 RVA: 0x002DC251 File Offset: 0x002DA451
		[NullableContext(1)]
		public static RacingBetsDangoActionDice Create()
		{
			return new RacingBetsDangoActionDice();
		}

		// Token: 0x1700414A RID: 16714
		// (get) Token: 0x06013ACF RID: 80591 RVA: 0x002DC258 File Offset: 0x002DA458
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700414B RID: 16715
		// (get) Token: 0x06013AD0 RID: 80592 RVA: 0x002DC25B File Offset: 0x002DA45B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsDangoActionDice.Descriptor;
			}
		}

		// Token: 0x06013AD1 RID: 80593 RVA: 0x002DC262 File Offset: 0x002DA462
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsDangoActionDice()
		{
		}

		// Token: 0x06013AD2 RID: 80594 RVA: 0x002DC275 File Offset: 0x002DA475
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsDangoActionDice(RacingBetsDangoActionDice other) : this()
		{
			this.diceNums_ = other.diceNums_.Clone();
			this.totalDice_ = other.totalDice_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013AD3 RID: 80595 RVA: 0x002DC2AB File Offset: 0x002DA4AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsDangoActionDice Clone()
		{
			return new RacingBetsDangoActionDice(this);
		}

		// Token: 0x1700414C RID: 16716
		// (get) Token: 0x06013AD4 RID: 80596 RVA: 0x002DC2B3 File Offset: 0x002DA4B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> DiceNums
		{
			get
			{
				return this.diceNums_;
			}
		}

		// Token: 0x1700414D RID: 16717
		// (get) Token: 0x06013AD5 RID: 80597 RVA: 0x002DC2BB File Offset: 0x002DA4BB
		// (set) Token: 0x06013AD6 RID: 80598 RVA: 0x002DC2C3 File Offset: 0x002DA4C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TotalDice
		{
			get
			{
				return this.totalDice_;
			}
			set
			{
				this.totalDice_ = value;
			}
		}

		// Token: 0x06013AD7 RID: 80599 RVA: 0x002DC2CC File Offset: 0x002DA4CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsDangoActionDice);
		}

		// Token: 0x06013AD8 RID: 80600 RVA: 0x002DC2DC File Offset: 0x002DA4DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsDangoActionDice other)
		{
			return other != null && (other == this || (this.diceNums_.Equals(other.diceNums_) && this.TotalDice == other.TotalDice && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013AD9 RID: 80601 RVA: 0x002DC32C File Offset: 0x002DA52C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.diceNums_.GetHashCode();
			if (this.TotalDice != 0)
			{
				num ^= this.TotalDice.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013ADA RID: 80602 RVA: 0x002DC379 File Offset: 0x002DA579
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013ADB RID: 80603 RVA: 0x002DC386 File Offset: 0x002DA586
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013ADC RID: 80604 RVA: 0x002DC390 File Offset: 0x002DA590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.diceNums_.WriteTo(ref output, RacingBetsDangoActionDice._repeated_diceNums_codec);
			if (this.TotalDice != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.TotalDice);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013ADD RID: 80605 RVA: 0x002DC3E0 File Offset: 0x002DA5E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.diceNums_.CalculateSize(RacingBetsDangoActionDice._repeated_diceNums_codec);
			if (this.TotalDice != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TotalDice);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013ADE RID: 80606 RVA: 0x002DC434 File Offset: 0x002DA634
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetsDangoActionDice other)
		{
			if (other == null)
			{
				return;
			}
			this.diceNums_.Add(other.diceNums_);
			if (other.TotalDice != 0)
			{
				this.TotalDice = other.TotalDice;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013ADF RID: 80607 RVA: 0x002DC481 File Offset: 0x002DA681
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013AE0 RID: 80608 RVA: 0x002DC48C File Offset: 0x002DA68C
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
				if (num != 8U && num != 10U)
				{
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.TotalDice = input.ReadInt32();
					}
				}
				else
				{
					this.diceNums_.AddEntriesFrom(ref input, RacingBetsDangoActionDice._repeated_diceNums_codec);
				}
			}
		}

		// Token: 0x04007860 RID: 30816
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007861 RID: 30817
		public const int DiceNumsFieldNumber = 1;

		// Token: 0x04007862 RID: 30818
		private static readonly FieldCodec<int> _repeated_diceNums_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04007863 RID: 30819
		private readonly RepeatedField<int> diceNums_ = new RepeatedField<int>();

		// Token: 0x04007864 RID: 30820
		public const int TotalDiceFieldNumber = 2;

		// Token: 0x04007865 RID: 30821
		private int totalDice_;
	}
}
