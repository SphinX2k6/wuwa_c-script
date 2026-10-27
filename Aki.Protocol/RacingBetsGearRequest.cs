using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E5E RID: 3678
	[NetMessage(EMessageId.RacingBetsGearRequest)]
	public sealed class RacingBetsGearRequest : IMessage<RacingBetsGearRequest>, IMessage, IEquatable<RacingBetsGearRequest>, IDeepCloneable<RacingBetsGearRequest>, IBufferMessage
	{
		// Token: 0x06013BE4 RID: 80868 RVA: 0x002DE93F File Offset: 0x002DCB3F
		[NullableContext(1)]
		public static RacingBetsGearRequest Create()
		{
			return new RacingBetsGearRequest();
		}

		// Token: 0x17004187 RID: 16775
		// (get) Token: 0x06013BE5 RID: 80869 RVA: 0x002DE946 File Offset: 0x002DCB46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004188 RID: 16776
		// (get) Token: 0x06013BE6 RID: 80870 RVA: 0x002DE949 File Offset: 0x002DCB49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsGearRequest.Descriptor;
			}
		}

		// Token: 0x06013BE7 RID: 80871 RVA: 0x002DE950 File Offset: 0x002DCB50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsGearRequest()
		{
		}

		// Token: 0x06013BE8 RID: 80872 RVA: 0x002DE964 File Offset: 0x002DCB64
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

		// Token: 0x06013BE9 RID: 80873 RVA: 0x002DE9D0 File Offset: 0x002DCBD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsGearRequest Clone()
		{
			return new RacingBetsGearRequest(this);
		}

		// Token: 0x17004189 RID: 16777
		// (get) Token: 0x06013BEA RID: 80874 RVA: 0x002DE9D8 File Offset: 0x002DCBD8
		// (set) Token: 0x06013BEB RID: 80875 RVA: 0x002DE9E0 File Offset: 0x002DCBE0
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

		// Token: 0x1700418A RID: 16778
		// (get) Token: 0x06013BEC RID: 80876 RVA: 0x002DE9E9 File Offset: 0x002DCBE9
		// (set) Token: 0x06013BED RID: 80877 RVA: 0x002DE9F1 File Offset: 0x002DCBF1
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

		// Token: 0x1700418B RID: 16779
		// (get) Token: 0x06013BEE RID: 80878 RVA: 0x002DE9FA File Offset: 0x002DCBFA
		// (set) Token: 0x06013BEF RID: 80879 RVA: 0x002DEA02 File Offset: 0x002DCC02
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

		// Token: 0x1700418C RID: 16780
		// (get) Token: 0x06013BF0 RID: 80880 RVA: 0x002DEA0B File Offset: 0x002DCC0B
		// (set) Token: 0x06013BF1 RID: 80881 RVA: 0x002DEA13 File Offset: 0x002DCC13
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

		// Token: 0x1700418D RID: 16781
		// (get) Token: 0x06013BF2 RID: 80882 RVA: 0x002DEA1C File Offset: 0x002DCC1C
		// (set) Token: 0x06013BF3 RID: 80883 RVA: 0x002DEA24 File Offset: 0x002DCC24
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

		// Token: 0x1700418E RID: 16782
		// (get) Token: 0x06013BF4 RID: 80884 RVA: 0x002DEA2D File Offset: 0x002DCC2D
		// (set) Token: 0x06013BF5 RID: 80885 RVA: 0x002DEA35 File Offset: 0x002DCC35
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

		// Token: 0x06013BF6 RID: 80886 RVA: 0x002DEA48 File Offset: 0x002DCC48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsGearRequest);
		}

		// Token: 0x06013BF7 RID: 80887 RVA: 0x002DEA58 File Offset: 0x002DCC58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsGearRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.LegMatchId == other.LegMatchId && this.DangoId == other.DangoId && this.GearId == other.GearId && this.Cash == other.Cash && !(this.OddsVersion != other.OddsVersion) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013BF8 RID: 80888 RVA: 0x002DEAE8 File Offset: 0x002DCCE8
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

		// Token: 0x06013BF9 RID: 80889 RVA: 0x002DEBA6 File Offset: 0x002DCDA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013BFA RID: 80890 RVA: 0x002DEBB3 File Offset: 0x002DCDB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013BFB RID: 80891 RVA: 0x002DEBBC File Offset: 0x002DCDBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DangoId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.DangoId);
			}
			if (this.LegMatchId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.LegMatchId);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.ActivityId);
			}
			if (this.OddsVersion.Length != 0)
			{
				output.WriteRawTag(74);
				output.WriteString(this.OddsVersion);
			}
			if (this.GearId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.GearId);
			}
			if (this.Cash != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.Cash);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013BFC RID: 80892 RVA: 0x002DEC8C File Offset: 0x002DCE8C
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

		// Token: 0x06013BFD RID: 80893 RVA: 0x002DED48 File Offset: 0x002DCF48
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

		// Token: 0x06013BFE RID: 80894 RVA: 0x002DEDED File Offset: 0x002DCFED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013BFF RID: 80895 RVA: 0x002DEDF8 File Offset: 0x002DCFF8
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
				if (num <= 32U)
				{
					if (num == 16U)
					{
						this.DangoId = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						this.LegMatchId = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.ActivityId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 74U)
					{
						this.OddsVersion = input.ReadString();
						continue;
					}
					if (num == 96U)
					{
						this.GearId = input.ReadInt32();
						continue;
					}
					if (num == 104U)
					{
						this.Cash = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040078B5 RID: 30901
		private UnknownFieldSet _unknownFields;

		// Token: 0x040078B6 RID: 30902
		public const int ActivityIdFieldNumber = 4;

		// Token: 0x040078B7 RID: 30903
		private int activityId_;

		// Token: 0x040078B8 RID: 30904
		public const int LegMatchIdFieldNumber = 3;

		// Token: 0x040078B9 RID: 30905
		private int legMatchId_;

		// Token: 0x040078BA RID: 30906
		public const int DangoIdFieldNumber = 2;

		// Token: 0x040078BB RID: 30907
		private int dangoId_;

		// Token: 0x040078BC RID: 30908
		public const int GearIdFieldNumber = 12;

		// Token: 0x040078BD RID: 30909
		private int gearId_;

		// Token: 0x040078BE RID: 30910
		public const int CashFieldNumber = 13;

		// Token: 0x040078BF RID: 30911
		private int cash_;

		// Token: 0x040078C0 RID: 30912
		public const int OddsVersionFieldNumber = 9;

		// Token: 0x040078C1 RID: 30913
		private string oddsVersion_ = "";
	}
}
