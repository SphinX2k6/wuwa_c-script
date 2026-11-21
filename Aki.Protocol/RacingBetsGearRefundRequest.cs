using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E4C RID: 3660
	[NetMessage(EMessageId.RacingBetsGearRefundRequest)]
	public sealed class RacingBetsGearRefundRequest : IMessage<RacingBetsGearRefundRequest>, IMessage, IEquatable<RacingBetsGearRefundRequest>, IDeepCloneable<RacingBetsGearRefundRequest>, IBufferMessage
	{
		// Token: 0x06013AD5 RID: 80597 RVA: 0x002DCC4C File Offset: 0x002DAE4C
		[NullableContext(1)]
		public static RacingBetsGearRefundRequest Create()
		{
			return new RacingBetsGearRefundRequest();
		}

		// Token: 0x17004154 RID: 16724
		// (get) Token: 0x06013AD6 RID: 80598 RVA: 0x002DCC53 File Offset: 0x002DAE53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004155 RID: 16725
		// (get) Token: 0x06013AD7 RID: 80599 RVA: 0x002DCC56 File Offset: 0x002DAE56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsGearRefundRequest.Descriptor;
			}
		}

		// Token: 0x06013AD8 RID: 80600 RVA: 0x002DCC5D File Offset: 0x002DAE5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsGearRefundRequest()
		{
		}

		// Token: 0x06013AD9 RID: 80601 RVA: 0x002DCC65 File Offset: 0x002DAE65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsGearRefundRequest(RacingBetsGearRefundRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.legMatchId_ = other.legMatchId_;
			this.dangoId_ = other.dangoId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013ADA RID: 80602 RVA: 0x002DCCA2 File Offset: 0x002DAEA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsGearRefundRequest Clone()
		{
			return new RacingBetsGearRefundRequest(this);
		}

		// Token: 0x17004156 RID: 16726
		// (get) Token: 0x06013ADB RID: 80603 RVA: 0x002DCCAA File Offset: 0x002DAEAA
		// (set) Token: 0x06013ADC RID: 80604 RVA: 0x002DCCB2 File Offset: 0x002DAEB2
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

		// Token: 0x17004157 RID: 16727
		// (get) Token: 0x06013ADD RID: 80605 RVA: 0x002DCCBB File Offset: 0x002DAEBB
		// (set) Token: 0x06013ADE RID: 80606 RVA: 0x002DCCC3 File Offset: 0x002DAEC3
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

		// Token: 0x17004158 RID: 16728
		// (get) Token: 0x06013ADF RID: 80607 RVA: 0x002DCCCC File Offset: 0x002DAECC
		// (set) Token: 0x06013AE0 RID: 80608 RVA: 0x002DCCD4 File Offset: 0x002DAED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DangoId
		{
			get
			{
				return this.dangoId_;
			}
			set
			{
				this.dangoId_ = value;
			}
		}

		// Token: 0x06013AE1 RID: 80609 RVA: 0x002DCCDD File Offset: 0x002DAEDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsGearRefundRequest);
		}

		// Token: 0x06013AE2 RID: 80610 RVA: 0x002DCCEC File Offset: 0x002DAEEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsGearRefundRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.LegMatchId == other.LegMatchId && this.DangoId == other.DangoId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013AE3 RID: 80611 RVA: 0x002DCD48 File Offset: 0x002DAF48
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
			if (this.DangoId != 0)
			{
				num ^= this.DangoId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013AE4 RID: 80612 RVA: 0x002DCDB9 File Offset: 0x002DAFB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013AE5 RID: 80613 RVA: 0x002DCDC6 File Offset: 0x002DAFC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013AE6 RID: 80614 RVA: 0x002DCDD0 File Offset: 0x002DAFD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DangoId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.DangoId);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.ActivityId);
			}
			if (this.LegMatchId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.LegMatchId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013AE7 RID: 80615 RVA: 0x002DCE48 File Offset: 0x002DB048
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
			if (this.DangoId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DangoId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013AE8 RID: 80616 RVA: 0x002DCEB8 File Offset: 0x002DB0B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetsGearRefundRequest other)
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
			if (other.DangoId != 0)
			{
				this.DangoId = other.DangoId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013AE9 RID: 80617 RVA: 0x002DCF1C File Offset: 0x002DB11C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013AEA RID: 80618 RVA: 0x002DCF28 File Offset: 0x002DB128
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
					if (num != 56U)
					{
						if (num != 112U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.LegMatchId = input.ReadInt32();
						}
					}
					else
					{
						this.ActivityId = input.ReadInt32();
					}
				}
				else
				{
					this.DangoId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040078D3 RID: 30931
		private UnknownFieldSet _unknownFields;

		// Token: 0x040078D4 RID: 30932
		public const int ActivityIdFieldNumber = 7;

		// Token: 0x040078D5 RID: 30933
		private int activityId_;

		// Token: 0x040078D6 RID: 30934
		public const int LegMatchIdFieldNumber = 14;

		// Token: 0x040078D7 RID: 30935
		private int legMatchId_;

		// Token: 0x040078D8 RID: 30936
		public const int DangoIdFieldNumber = 4;

		// Token: 0x040078D9 RID: 30937
		private int dangoId_;
	}
}
