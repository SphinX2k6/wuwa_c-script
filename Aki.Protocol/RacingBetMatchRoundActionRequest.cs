using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E32 RID: 3634
	[NetMessage(EMessageId.RacingBetMatchRoundActionRequest)]
	public sealed class RacingBetMatchRoundActionRequest : IMessage<RacingBetMatchRoundActionRequest>, IMessage, IEquatable<RacingBetMatchRoundActionRequest>, IDeepCloneable<RacingBetMatchRoundActionRequest>, IBufferMessage
	{
		// Token: 0x06013898 RID: 80024 RVA: 0x002D76E0 File Offset: 0x002D58E0
		[NullableContext(1)]
		public static RacingBetMatchRoundActionRequest Create()
		{
			return new RacingBetMatchRoundActionRequest();
		}

		// Token: 0x170040D0 RID: 16592
		// (get) Token: 0x06013899 RID: 80025 RVA: 0x002D76E7 File Offset: 0x002D58E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170040D1 RID: 16593
		// (get) Token: 0x0601389A RID: 80026 RVA: 0x002D76EA File Offset: 0x002D58EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetMatchRoundActionRequest.Descriptor;
			}
		}

		// Token: 0x0601389B RID: 80027 RVA: 0x002D76F1 File Offset: 0x002D58F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetMatchRoundActionRequest()
		{
		}

		// Token: 0x0601389C RID: 80028 RVA: 0x002D76F9 File Offset: 0x002D58F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetMatchRoundActionRequest(RacingBetMatchRoundActionRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.legMatchId_ = other.legMatchId_;
			this.order_ = other.order_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601389D RID: 80029 RVA: 0x002D7736 File Offset: 0x002D5936
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetMatchRoundActionRequest Clone()
		{
			return new RacingBetMatchRoundActionRequest(this);
		}

		// Token: 0x170040D2 RID: 16594
		// (get) Token: 0x0601389E RID: 80030 RVA: 0x002D773E File Offset: 0x002D593E
		// (set) Token: 0x0601389F RID: 80031 RVA: 0x002D7746 File Offset: 0x002D5946
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x170040D3 RID: 16595
		// (get) Token: 0x060138A0 RID: 80032 RVA: 0x002D774F File Offset: 0x002D594F
		// (set) Token: 0x060138A1 RID: 80033 RVA: 0x002D7757 File Offset: 0x002D5957
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LegMatchId
		{
			get
			{
				return this.legMatchId_;
			}
			set
			{
				this.legMatchId_ = value;
			}
		}

		// Token: 0x170040D4 RID: 16596
		// (get) Token: 0x060138A2 RID: 80034 RVA: 0x002D7760 File Offset: 0x002D5960
		// (set) Token: 0x060138A3 RID: 80035 RVA: 0x002D7768 File Offset: 0x002D5968
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Order
		{
			get
			{
				return this.order_;
			}
			set
			{
				this.order_ = value;
			}
		}

		// Token: 0x060138A4 RID: 80036 RVA: 0x002D7771 File Offset: 0x002D5971
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetMatchRoundActionRequest);
		}

		// Token: 0x060138A5 RID: 80037 RVA: 0x002D7780 File Offset: 0x002D5980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetMatchRoundActionRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.LegMatchId == other.LegMatchId && this.Order == other.Order && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060138A6 RID: 80038 RVA: 0x002D77DC File Offset: 0x002D59DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.LegMatchId != 0)
			{
				num ^= this.LegMatchId.GetHashCode();
			}
			if (this.Order != 0)
			{
				num ^= this.Order.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060138A7 RID: 80039 RVA: 0x002D784D File Offset: 0x002D5A4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060138A8 RID: 80040 RVA: 0x002D785A File Offset: 0x002D5A5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060138A9 RID: 80041 RVA: 0x002D7864 File Offset: 0x002D5A64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LegMatchId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.LegMatchId);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.ActivityId);
			}
			if (this.Order != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.Order);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060138AA RID: 80042 RVA: 0x002D78DC File Offset: 0x002D5ADC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.LegMatchId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LegMatchId);
			}
			if (this.Order != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Order);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060138AB RID: 80043 RVA: 0x002D794C File Offset: 0x002D5B4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetMatchRoundActionRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.LegMatchId != 0)
			{
				this.LegMatchId = other.LegMatchId;
			}
			if (other.Order != 0)
			{
				this.Order = other.Order;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060138AC RID: 80044 RVA: 0x002D79B0 File Offset: 0x002D5BB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060138AD RID: 80045 RVA: 0x002D79BC File Offset: 0x002D5BBC
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
				if (num != 32U)
				{
					if (num != 112U)
					{
						if (num != 120U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Order = input.ReadInt32();
						}
					}
					else
					{
						this.ActivityId = input.ReadInt32();
					}
				}
				else
				{
					this.LegMatchId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007810 RID: 30736
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007811 RID: 30737
		public const int ActivityIdFieldNumber = 14;

		// Token: 0x04007812 RID: 30738
		private int activityId_;

		// Token: 0x04007813 RID: 30739
		public const int LegMatchIdFieldNumber = 4;

		// Token: 0x04007814 RID: 30740
		private int legMatchId_;

		// Token: 0x04007815 RID: 30741
		public const int OrderFieldNumber = 15;

		// Token: 0x04007816 RID: 30742
		private int order_;
	}
}
