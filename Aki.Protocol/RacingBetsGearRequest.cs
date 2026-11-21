using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E4E RID: 3662
	[NetMessage(EMessageId.RacingBetsGearRequest)]
	public sealed class RacingBetsGearRequest : IMessage<RacingBetsGearRequest>, IMessage, IEquatable<RacingBetsGearRequest>, IDeepCloneable<RacingBetsGearRequest>, IBufferMessage
	{
		// Token: 0x06013AFF RID: 80639 RVA: 0x002DD287 File Offset: 0x002DB487
		[NullableContext(1)]
		public static RacingBetsGearRequest Create()
		{
			return new RacingBetsGearRequest();
		}

		// Token: 0x1700415D RID: 16733
		// (get) Token: 0x06013B00 RID: 80640 RVA: 0x002DD28E File Offset: 0x002DB48E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700415E RID: 16734
		// (get) Token: 0x06013B01 RID: 80641 RVA: 0x002DD291 File Offset: 0x002DB491
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsGearRequest.Descriptor;
			}
		}

		// Token: 0x06013B02 RID: 80642 RVA: 0x002DD298 File Offset: 0x002DB498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsGearRequest()
		{
		}

		// Token: 0x06013B03 RID: 80643 RVA: 0x002DD2AC File Offset: 0x002DB4AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsGearRequest(RacingBetsGearRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.legMatchId_ = other.legMatchId_;
			this.dangoId_ = other.dangoId_;
			this.gearId_ = other.gearId_;
			this.cash_ = other.cash_;
			this.oddsVersion_ = other.oddsVersion_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013B04 RID: 80644 RVA: 0x002DD318 File Offset: 0x002DB518
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsGearRequest Clone()
		{
			return new RacingBetsGearRequest(this);
		}

		// Token: 0x1700415F RID: 16735
		// (get) Token: 0x06013B05 RID: 80645 RVA: 0x002DD320 File Offset: 0x002DB520
		// (set) Token: 0x06013B06 RID: 80646 RVA: 0x002DD328 File Offset: 0x002DB528
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

		// Token: 0x17004160 RID: 16736
		// (get) Token: 0x06013B07 RID: 80647 RVA: 0x002DD331 File Offset: 0x002DB531
		// (set) Token: 0x06013B08 RID: 80648 RVA: 0x002DD339 File Offset: 0x002DB539
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

		// Token: 0x17004161 RID: 16737
		// (get) Token: 0x06013B09 RID: 80649 RVA: 0x002DD342 File Offset: 0x002DB542
		// (set) Token: 0x06013B0A RID: 80650 RVA: 0x002DD34A File Offset: 0x002DB54A
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

		// Token: 0x17004162 RID: 16738
		// (get) Token: 0x06013B0B RID: 80651 RVA: 0x002DD353 File Offset: 0x002DB553
		// (set) Token: 0x06013B0C RID: 80652 RVA: 0x002DD35B File Offset: 0x002DB55B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GearId
		{
			get
			{
				return this.gearId_;
			}
			set
			{
				this.gearId_ = value;
			}
		}

		// Token: 0x17004163 RID: 16739
		// (get) Token: 0x06013B0D RID: 80653 RVA: 0x002DD364 File Offset: 0x002DB564
		// (set) Token: 0x06013B0E RID: 80654 RVA: 0x002DD36C File Offset: 0x002DB56C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Cash
		{
			get
			{
				return this.cash_;
			}
			set
			{
				this.cash_ = value;
			}
		}

		// Token: 0x17004164 RID: 16740
		// (get) Token: 0x06013B0F RID: 80655 RVA: 0x002DD375 File Offset: 0x002DB575
		// (set) Token: 0x06013B10 RID: 80656 RVA: 0x002DD37D File Offset: 0x002DB57D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string OddsVersion
		{
			get
			{
				return this.oddsVersion_;
			}
			set
			{
				this.oddsVersion_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x06013B11 RID: 80657 RVA: 0x002DD390 File Offset: 0x002DB590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsGearRequest);
		}

		// Token: 0x06013B12 RID: 80658 RVA: 0x002DD3A0 File Offset: 0x002DB5A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsGearRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.LegMatchId == other.LegMatchId && this.DangoId == other.DangoId && this.GearId == other.GearId && this.Cash == other.Cash && !(this.OddsVersion != other.OddsVersion) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013B13 RID: 80659 RVA: 0x002DD430 File Offset: 0x002DB630
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
			if (this.GearId != 0)
			{
				num ^= this.GearId.GetHashCode();
			}
			if (this.Cash != 0)
			{
				num ^= this.Cash.GetHashCode();
			}
			if (this.OddsVersion.Length != 0)
			{
				num ^= this.OddsVersion.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013B14 RID: 80660 RVA: 0x002DD4EE File Offset: 0x002DB6EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013B15 RID: 80661 RVA: 0x002DD4FB File Offset: 0x002DB6FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013B16 RID: 80662 RVA: 0x002DD504 File Offset: 0x002DB704
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DangoId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.DangoId);
			}
			if (this.OddsVersion.Length != 0)
			{
				output.WriteRawTag(74);
				output.WriteString(this.OddsVersion);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.ActivityId);
			}
			if (this.Cash != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.Cash);
			}
			if (this.LegMatchId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.LegMatchId);
			}
			if (this.GearId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.GearId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013B17 RID: 80663 RVA: 0x002DD5D4 File Offset: 0x002DB7D4
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
			if (this.GearId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GearId);
			}
			if (this.Cash != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Cash);
			}
			if (this.OddsVersion.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.OddsVersion);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013B18 RID: 80664 RVA: 0x002DD690 File Offset: 0x002DB890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetsGearRequest other)
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
			if (other.GearId != 0)
			{
				this.GearId = other.GearId;
			}
			if (other.Cash != 0)
			{
				this.Cash = other.Cash;
			}
			if (other.OddsVersion.Length != 0)
			{
				this.OddsVersion = other.OddsVersion;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013B19 RID: 80665 RVA: 0x002DD735 File Offset: 0x002DB935
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013B1A RID: 80666 RVA: 0x002DD740 File Offset: 0x002DB940
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
				if (num <= 96U)
				{
					if (num == 40U)
					{
						this.DangoId = input.ReadInt32();
						continue;
					}
					if (num == 74U)
					{
						this.OddsVersion = input.ReadString();
						continue;
					}
					if (num == 96U)
					{
						this.ActivityId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 104U)
					{
						this.Cash = input.ReadInt32();
						continue;
					}
					if (num == 112U)
					{
						this.LegMatchId = input.ReadInt32();
						continue;
					}
					if (num == 120U)
					{
						this.GearId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040078DF RID: 30943
		private UnknownFieldSet _unknownFields;

		// Token: 0x040078E0 RID: 30944
		public const int ActivityIdFieldNumber = 12;

		// Token: 0x040078E1 RID: 30945
		private int activityId_;

		// Token: 0x040078E2 RID: 30946
		public const int LegMatchIdFieldNumber = 14;

		// Token: 0x040078E3 RID: 30947
		private int legMatchId_;

		// Token: 0x040078E4 RID: 30948
		public const int DangoIdFieldNumber = 5;

		// Token: 0x040078E5 RID: 30949
		private int dangoId_;

		// Token: 0x040078E6 RID: 30950
		public const int GearIdFieldNumber = 15;

		// Token: 0x040078E7 RID: 30951
		private int gearId_;

		// Token: 0x040078E8 RID: 30952
		public const int CashFieldNumber = 13;

		// Token: 0x040078E9 RID: 30953
		private int cash_;

		// Token: 0x040078EA RID: 30954
		public const int OddsVersionFieldNumber = 9;

		// Token: 0x040078EB RID: 30955
		private string oddsVersion_ = "";
	}
}
