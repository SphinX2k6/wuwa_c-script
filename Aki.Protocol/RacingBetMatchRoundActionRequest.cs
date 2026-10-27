using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E42 RID: 3650
	[NetMessage(EMessageId.RacingBetMatchRoundActionRequest)]
	public sealed class RacingBetMatchRoundActionRequest : IMessage<RacingBetMatchRoundActionRequest>, IMessage, IEquatable<RacingBetMatchRoundActionRequest>, IDeepCloneable<RacingBetMatchRoundActionRequest>, IBufferMessage
	{
		// Token: 0x0601397D RID: 80253 RVA: 0x002D8DA0 File Offset: 0x002D6FA0
		[NullableContext(1)]
		public static RacingBetMatchRoundActionRequest Create()
		{
			return new RacingBetMatchRoundActionRequest();
		}

		// Token: 0x170040FA RID: 16634
		// (get) Token: 0x0601397E RID: 80254 RVA: 0x002D8DA7 File Offset: 0x002D6FA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170040FB RID: 16635
		// (get) Token: 0x0601397F RID: 80255 RVA: 0x002D8DAA File Offset: 0x002D6FAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetMatchRoundActionRequest.Descriptor;
			}
		}

		// Token: 0x06013980 RID: 80256 RVA: 0x002D8DB1 File Offset: 0x002D6FB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetMatchRoundActionRequest()
		{
		}

		// Token: 0x06013981 RID: 80257 RVA: 0x002D8DB9 File Offset: 0x002D6FB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetMatchRoundActionRequest(RacingBetMatchRoundActionRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.legMatchId_ = other.legMatchId_;
			this.order_ = other.order_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013982 RID: 80258 RVA: 0x002D8DF6 File Offset: 0x002D6FF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetMatchRoundActionRequest Clone()
		{
			return new RacingBetMatchRoundActionRequest(this);
		}

		// Token: 0x170040FC RID: 16636
		// (get) Token: 0x06013983 RID: 80259 RVA: 0x002D8DFE File Offset: 0x002D6FFE
		// (set) Token: 0x06013984 RID: 80260 RVA: 0x002D8E06 File Offset: 0x002D7006
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

		// Token: 0x170040FD RID: 16637
		// (get) Token: 0x06013985 RID: 80261 RVA: 0x002D8E0F File Offset: 0x002D700F
		// (set) Token: 0x06013986 RID: 80262 RVA: 0x002D8E17 File Offset: 0x002D7017
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

		// Token: 0x170040FE RID: 16638
		// (get) Token: 0x06013987 RID: 80263 RVA: 0x002D8E20 File Offset: 0x002D7020
		// (set) Token: 0x06013988 RID: 80264 RVA: 0x002D8E28 File Offset: 0x002D7028
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

		// Token: 0x06013989 RID: 80265 RVA: 0x002D8E31 File Offset: 0x002D7031
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetMatchRoundActionRequest);
		}

		// Token: 0x0601398A RID: 80266 RVA: 0x002D8E40 File Offset: 0x002D7040
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetMatchRoundActionRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.LegMatchId == other.LegMatchId && this.Order == other.Order && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601398B RID: 80267 RVA: 0x002D8E9C File Offset: 0x002D709C
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

		// Token: 0x0601398C RID: 80268 RVA: 0x002D8F0D File Offset: 0x002D710D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601398D RID: 80269 RVA: 0x002D8F1A File Offset: 0x002D711A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601398E RID: 80270 RVA: 0x002D8F24 File Offset: 0x002D7124
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LegMatchId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.LegMatchId);
			}
			if (this.Order != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.Order);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601398F RID: 80271 RVA: 0x002D8F98 File Offset: 0x002D7198
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

		// Token: 0x06013990 RID: 80272 RVA: 0x002D9008 File Offset: 0x002D7208
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

		// Token: 0x06013991 RID: 80273 RVA: 0x002D906C File Offset: 0x002D726C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013992 RID: 80274 RVA: 0x002D9078 File Offset: 0x002D7278
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
				if (num != 8U)
				{
					if (num != 96U)
					{
						if (num != 104U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ActivityId = input.ReadInt32();
						}
					}
					else
					{
						this.Order = input.ReadInt32();
					}
				}
				else
				{
					this.LegMatchId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040077E6 RID: 30694
		private UnknownFieldSet _unknownFields;

		// Token: 0x040077E7 RID: 30695
		public const int ActivityIdFieldNumber = 13;

		// Token: 0x040077E8 RID: 30696
		private int activityId_;

		// Token: 0x040077E9 RID: 30697
		public const int LegMatchIdFieldNumber = 1;

		// Token: 0x040077EA RID: 30698
		private int legMatchId_;

		// Token: 0x040077EB RID: 30699
		public const int OrderFieldNumber = 12;

		// Token: 0x040077EC RID: 30700
		private int order_;
	}
}
