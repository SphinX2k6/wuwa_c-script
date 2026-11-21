using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E41 RID: 3649
	public sealed class RacingBetsDangoActionDice : IMessage<RacingBetsDangoActionDice>, IMessage, IEquatable<RacingBetsDangoActionDice>, IDeepCloneable<RacingBetsDangoActionDice>, IBufferMessage
	{
		// Token: 0x060139E9 RID: 80361 RVA: 0x002DAB95 File Offset: 0x002D8D95
		[NullableContext(1)]
		public static RacingBetsDangoActionDice Create()
		{
			return new RacingBetsDangoActionDice();
		}

		// Token: 0x17004120 RID: 16672
		// (get) Token: 0x060139EA RID: 80362 RVA: 0x002DAB9C File Offset: 0x002D8D9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004121 RID: 16673
		// (get) Token: 0x060139EB RID: 80363 RVA: 0x002DAB9F File Offset: 0x002D8D9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsDangoActionDice.Descriptor;
			}
		}

		// Token: 0x060139EC RID: 80364 RVA: 0x002DABA6 File Offset: 0x002D8DA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsDangoActionDice()
		{
		}

		// Token: 0x060139ED RID: 80365 RVA: 0x002DABB9 File Offset: 0x002D8DB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsDangoActionDice(RacingBetsDangoActionDice other) : this()
		{
			this.diceNums_ = other.diceNums_.Clone();
			this.totalDice_ = other.totalDice_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060139EE RID: 80366 RVA: 0x002DABEF File Offset: 0x002D8DEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsDangoActionDice Clone()
		{
			return new RacingBetsDangoActionDice(this);
		}

		// Token: 0x17004122 RID: 16674
		// (get) Token: 0x060139EF RID: 80367 RVA: 0x002DABF7 File Offset: 0x002D8DF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> DiceNums
		{
			get
			{
				return this.diceNums_;
			}
		}

		// Token: 0x17004123 RID: 16675
		// (get) Token: 0x060139F0 RID: 80368 RVA: 0x002DABFF File Offset: 0x002D8DFF
		// (set) Token: 0x060139F1 RID: 80369 RVA: 0x002DAC07 File Offset: 0x002D8E07
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

		// Token: 0x060139F2 RID: 80370 RVA: 0x002DAC10 File Offset: 0x002D8E10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsDangoActionDice);
		}

		// Token: 0x060139F3 RID: 80371 RVA: 0x002DAC20 File Offset: 0x002D8E20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsDangoActionDice other)
		{
			return other != null && (other == this || (this.diceNums_.Equals(other.diceNums_) && this.TotalDice == other.TotalDice && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060139F4 RID: 80372 RVA: 0x002DAC70 File Offset: 0x002D8E70
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

		// Token: 0x060139F5 RID: 80373 RVA: 0x002DACBD File Offset: 0x002D8EBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060139F6 RID: 80374 RVA: 0x002DACCA File Offset: 0x002D8ECA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060139F7 RID: 80375 RVA: 0x002DACD4 File Offset: 0x002D8ED4
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

		// Token: 0x060139F8 RID: 80376 RVA: 0x002DAD24 File Offset: 0x002D8F24
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

		// Token: 0x060139F9 RID: 80377 RVA: 0x002DAD78 File Offset: 0x002D8F78
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

		// Token: 0x060139FA RID: 80378 RVA: 0x002DADC5 File Offset: 0x002D8FC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060139FB RID: 80379 RVA: 0x002DADD0 File Offset: 0x002D8FD0
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

		// Token: 0x0400788A RID: 30858
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400788B RID: 30859
		public const int DiceNumsFieldNumber = 1;

		// Token: 0x0400788C RID: 30860
		private static readonly FieldCodec<int> _repeated_diceNums_codec = FieldCodec.ForInt32(10U);

		// Token: 0x0400788D RID: 30861
		private readonly RepeatedField<int> diceNums_ = new RepeatedField<int>();

		// Token: 0x0400788E RID: 30862
		public const int TotalDiceFieldNumber = 2;

		// Token: 0x0400788F RID: 30863
		private int totalDice_;
	}
}
