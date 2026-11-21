using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200148F RID: 5263
	public sealed class TrapDefenseComponentPb : IMessage<TrapDefenseComponentPb>, IMessage, IEquatable<TrapDefenseComponentPb>, IDeepCloneable<TrapDefenseComponentPb>, IBufferMessage
	{
		// Token: 0x0601BF1F RID: 114463 RVA: 0x0040F451 File Offset: 0x0040D651
		[NullableContext(1)]
		public static TrapDefenseComponentPb Create()
		{
			return new TrapDefenseComponentPb();
		}

		// Token: 0x17005E9F RID: 24223
		// (get) Token: 0x0601BF20 RID: 114464 RVA: 0x0040F458 File Offset: 0x0040D658
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005EA0 RID: 24224
		// (get) Token: 0x0601BF21 RID: 114465 RVA: 0x0040F45B File Offset: 0x0040D65B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseComponentPb.Descriptor;
			}
		}

		// Token: 0x0601BF22 RID: 114466 RVA: 0x0040F462 File Offset: 0x0040D662
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseComponentPb()
		{
		}

		// Token: 0x0601BF23 RID: 114467 RVA: 0x0040F46C File Offset: 0x0040D66C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseComponentPb(TrapDefenseComponentPb other) : this()
		{
			switch (other.DataCase)
			{
			case TrapDefenseComponentPb.DataOneofCase.BuildingPbData:
				this.BuildingPbData = other.BuildingPbData.Clone();
				break;
			case TrapDefenseComponentPb.DataOneofCase.AuxiliaryPbData:
				this.AuxiliaryPbData = other.AuxiliaryPbData.Clone();
				break;
			case TrapDefenseComponentPb.DataOneofCase.MonsterPbData:
				this.MonsterPbData = other.MonsterPbData.Clone();
				break;
			case TrapDefenseComponentPb.DataOneofCase.GoldenCoinPbData:
				this.GoldenCoinPbData = other.GoldenCoinPbData.Clone();
				break;
			case TrapDefenseComponentPb.DataOneofCase.SpecialCellPbData:
				this.SpecialCellPbData = other.SpecialCellPbData.Clone();
				break;
			}
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BF24 RID: 114468 RVA: 0x0040F512 File Offset: 0x0040D712
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseComponentPb Clone()
		{
			return new TrapDefenseComponentPb(this);
		}

		// Token: 0x17005EA1 RID: 24225
		// (get) Token: 0x0601BF25 RID: 114469 RVA: 0x0040F51A File Offset: 0x0040D71A
		// (set) Token: 0x0601BF26 RID: 114470 RVA: 0x0040F532 File Offset: 0x0040D732
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseBuildingPbData BuildingPbData
		{
			get
			{
				if (this.dataCase_ != TrapDefenseComponentPb.DataOneofCase.BuildingPbData)
				{
					return null;
				}
				return (TrapDefenseBuildingPbData)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? TrapDefenseComponentPb.DataOneofCase.None : TrapDefenseComponentPb.DataOneofCase.BuildingPbData);
			}
		}

		// Token: 0x17005EA2 RID: 24226
		// (get) Token: 0x0601BF27 RID: 114471 RVA: 0x0040F548 File Offset: 0x0040D748
		// (set) Token: 0x0601BF28 RID: 114472 RVA: 0x0040F560 File Offset: 0x0040D760
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseAuxiliaryPbData AuxiliaryPbData
		{
			get
			{
				if (this.dataCase_ != TrapDefenseComponentPb.DataOneofCase.AuxiliaryPbData)
				{
					return null;
				}
				return (TrapDefenseAuxiliaryPbData)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? TrapDefenseComponentPb.DataOneofCase.None : TrapDefenseComponentPb.DataOneofCase.AuxiliaryPbData);
			}
		}

		// Token: 0x17005EA3 RID: 24227
		// (get) Token: 0x0601BF29 RID: 114473 RVA: 0x0040F576 File Offset: 0x0040D776
		// (set) Token: 0x0601BF2A RID: 114474 RVA: 0x0040F58E File Offset: 0x0040D78E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseMonsterPbData MonsterPbData
		{
			get
			{
				if (this.dataCase_ != TrapDefenseComponentPb.DataOneofCase.MonsterPbData)
				{
					return null;
				}
				return (TrapDefenseMonsterPbData)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? TrapDefenseComponentPb.DataOneofCase.None : TrapDefenseComponentPb.DataOneofCase.MonsterPbData);
			}
		}

		// Token: 0x17005EA4 RID: 24228
		// (get) Token: 0x0601BF2B RID: 114475 RVA: 0x0040F5A4 File Offset: 0x0040D7A4
		// (set) Token: 0x0601BF2C RID: 114476 RVA: 0x0040F5BC File Offset: 0x0040D7BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseGoldenCoinPbData GoldenCoinPbData
		{
			get
			{
				if (this.dataCase_ != TrapDefenseComponentPb.DataOneofCase.GoldenCoinPbData)
				{
					return null;
				}
				return (TrapDefenseGoldenCoinPbData)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? TrapDefenseComponentPb.DataOneofCase.None : TrapDefenseComponentPb.DataOneofCase.GoldenCoinPbData);
			}
		}

		// Token: 0x17005EA5 RID: 24229
		// (get) Token: 0x0601BF2D RID: 114477 RVA: 0x0040F5D2 File Offset: 0x0040D7D2
		// (set) Token: 0x0601BF2E RID: 114478 RVA: 0x0040F5EA File Offset: 0x0040D7EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseSpecialCellPbData SpecialCellPbData
		{
			get
			{
				if (this.dataCase_ != TrapDefenseComponentPb.DataOneofCase.SpecialCellPbData)
				{
					return null;
				}
				return (TrapDefenseSpecialCellPbData)this.data_;
			}
			set
			{
				this.data_ = value;
				this.dataCase_ = ((value == null) ? TrapDefenseComponentPb.DataOneofCase.None : TrapDefenseComponentPb.DataOneofCase.SpecialCellPbData);
			}
		}

		// Token: 0x17005EA6 RID: 24230
		// (get) Token: 0x0601BF2F RID: 114479 RVA: 0x0040F600 File Offset: 0x0040D800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseComponentPb.DataOneofCase DataCase
		{
			get
			{
				return this.dataCase_;
			}
		}

		// Token: 0x0601BF30 RID: 114480 RVA: 0x0040F608 File Offset: 0x0040D808
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearData()
		{
			this.dataCase_ = TrapDefenseComponentPb.DataOneofCase.None;
			this.data_ = null;
		}

		// Token: 0x0601BF31 RID: 114481 RVA: 0x0040F618 File Offset: 0x0040D818
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseComponentPb);
		}

		// Token: 0x0601BF32 RID: 114482 RVA: 0x0040F628 File Offset: 0x0040D828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseComponentPb other)
		{
			return other != null && (other == this || (object.Equals(this.BuildingPbData, other.BuildingPbData) && object.Equals(this.AuxiliaryPbData, other.AuxiliaryPbData) && object.Equals(this.MonsterPbData, other.MonsterPbData) && object.Equals(this.GoldenCoinPbData, other.GoldenCoinPbData) && object.Equals(this.SpecialCellPbData, other.SpecialCellPbData) && this.DataCase == other.DataCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BF33 RID: 114483 RVA: 0x0040F6CC File Offset: 0x0040D8CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.dataCase_ == TrapDefenseComponentPb.DataOneofCase.BuildingPbData)
			{
				num ^= this.BuildingPbData.GetHashCode();
			}
			if (this.dataCase_ == TrapDefenseComponentPb.DataOneofCase.AuxiliaryPbData)
			{
				num ^= this.AuxiliaryPbData.GetHashCode();
			}
			if (this.dataCase_ == TrapDefenseComponentPb.DataOneofCase.MonsterPbData)
			{
				num ^= this.MonsterPbData.GetHashCode();
			}
			if (this.dataCase_ == TrapDefenseComponentPb.DataOneofCase.GoldenCoinPbData)
			{
				num ^= this.GoldenCoinPbData.GetHashCode();
			}
			if (this.dataCase_ == TrapDefenseComponentPb.DataOneofCase.SpecialCellPbData)
			{
				num ^= this.SpecialCellPbData.GetHashCode();
			}
			num ^= (int)this.dataCase_;
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601BF34 RID: 114484 RVA: 0x0040F76E File Offset: 0x0040D96E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BF35 RID: 114485 RVA: 0x0040F77B File Offset: 0x0040D97B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BF36 RID: 114486 RVA: 0x0040F784 File Offset: 0x0040D984
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.dataCase_ == TrapDefenseComponentPb.DataOneofCase.BuildingPbData)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.BuildingPbData);
			}
			if (this.dataCase_ == TrapDefenseComponentPb.DataOneofCase.AuxiliaryPbData)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.AuxiliaryPbData);
			}
			if (this.dataCase_ == TrapDefenseComponentPb.DataOneofCase.MonsterPbData)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.MonsterPbData);
			}
			if (this.dataCase_ == TrapDefenseComponentPb.DataOneofCase.GoldenCoinPbData)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.GoldenCoinPbData);
			}
			if (this.dataCase_ == TrapDefenseComponentPb.DataOneofCase.SpecialCellPbData)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.SpecialCellPbData);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BF37 RID: 114487 RVA: 0x0040F838 File Offset: 0x0040DA38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.dataCase_ == TrapDefenseComponentPb.DataOneofCase.BuildingPbData)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.BuildingPbData);
			}
			if (this.dataCase_ == TrapDefenseComponentPb.DataOneofCase.AuxiliaryPbData)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.AuxiliaryPbData);
			}
			if (this.dataCase_ == TrapDefenseComponentPb.DataOneofCase.MonsterPbData)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.MonsterPbData);
			}
			if (this.dataCase_ == TrapDefenseComponentPb.DataOneofCase.GoldenCoinPbData)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.GoldenCoinPbData);
			}
			if (this.dataCase_ == TrapDefenseComponentPb.DataOneofCase.SpecialCellPbData)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.SpecialCellPbData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601BF38 RID: 114488 RVA: 0x0040F8DC File Offset: 0x0040DADC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			switch (other.DataCase)
			{
			case TrapDefenseComponentPb.DataOneofCase.BuildingPbData:
				if (this.BuildingPbData == null)
				{
					this.BuildingPbData = new TrapDefenseBuildingPbData();
				}
				this.BuildingPbData.MergeFrom(other.BuildingPbData);
				break;
			case TrapDefenseComponentPb.DataOneofCase.AuxiliaryPbData:
				if (this.AuxiliaryPbData == null)
				{
					this.AuxiliaryPbData = new TrapDefenseAuxiliaryPbData();
				}
				this.AuxiliaryPbData.MergeFrom(other.AuxiliaryPbData);
				break;
			case TrapDefenseComponentPb.DataOneofCase.MonsterPbData:
				if (this.MonsterPbData == null)
				{
					this.MonsterPbData = new TrapDefenseMonsterPbData();
				}
				this.MonsterPbData.MergeFrom(other.MonsterPbData);
				break;
			case TrapDefenseComponentPb.DataOneofCase.GoldenCoinPbData:
				if (this.GoldenCoinPbData == null)
				{
					this.GoldenCoinPbData = new TrapDefenseGoldenCoinPbData();
				}
				this.GoldenCoinPbData.MergeFrom(other.GoldenCoinPbData);
				break;
			case TrapDefenseComponentPb.DataOneofCase.SpecialCellPbData:
				if (this.SpecialCellPbData == null)
				{
					this.SpecialCellPbData = new TrapDefenseSpecialCellPbData();
				}
				this.SpecialCellPbData.MergeFrom(other.SpecialCellPbData);
				break;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BF39 RID: 114489 RVA: 0x0040F9EB File Offset: 0x0040DBEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BF3A RID: 114490 RVA: 0x0040F9F4 File Offset: 0x0040DBF4
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
				if (num <= 18U)
				{
					if (num == 10U)
					{
						TrapDefenseBuildingPbData trapDefenseBuildingPbData = new TrapDefenseBuildingPbData();
						if (this.dataCase_ == TrapDefenseComponentPb.DataOneofCase.BuildingPbData)
						{
							trapDefenseBuildingPbData.MergeFrom(this.BuildingPbData);
						}
						input.ReadMessage(trapDefenseBuildingPbData);
						this.BuildingPbData = trapDefenseBuildingPbData;
						continue;
					}
					if (num == 18U)
					{
						TrapDefenseAuxiliaryPbData trapDefenseAuxiliaryPbData = new TrapDefenseAuxiliaryPbData();
						if (this.dataCase_ == TrapDefenseComponentPb.DataOneofCase.AuxiliaryPbData)
						{
							trapDefenseAuxiliaryPbData.MergeFrom(this.AuxiliaryPbData);
						}
						input.ReadMessage(trapDefenseAuxiliaryPbData);
						this.AuxiliaryPbData = trapDefenseAuxiliaryPbData;
						continue;
					}
				}
				else
				{
					if (num == 26U)
					{
						TrapDefenseMonsterPbData trapDefenseMonsterPbData = new TrapDefenseMonsterPbData();
						if (this.dataCase_ == TrapDefenseComponentPb.DataOneofCase.MonsterPbData)
						{
							trapDefenseMonsterPbData.MergeFrom(this.MonsterPbData);
						}
						input.ReadMessage(trapDefenseMonsterPbData);
						this.MonsterPbData = trapDefenseMonsterPbData;
						continue;
					}
					if (num == 34U)
					{
						TrapDefenseGoldenCoinPbData trapDefenseGoldenCoinPbData = new TrapDefenseGoldenCoinPbData();
						if (this.dataCase_ == TrapDefenseComponentPb.DataOneofCase.GoldenCoinPbData)
						{
							trapDefenseGoldenCoinPbData.MergeFrom(this.GoldenCoinPbData);
						}
						input.ReadMessage(trapDefenseGoldenCoinPbData);
						this.GoldenCoinPbData = trapDefenseGoldenCoinPbData;
						continue;
					}
					if (num == 42U)
					{
						TrapDefenseSpecialCellPbData trapDefenseSpecialCellPbData = new TrapDefenseSpecialCellPbData();
						if (this.dataCase_ == TrapDefenseComponentPb.DataOneofCase.SpecialCellPbData)
						{
							trapDefenseSpecialCellPbData.MergeFrom(this.SpecialCellPbData);
						}
						input.ReadMessage(trapDefenseSpecialCellPbData);
						this.SpecialCellPbData = trapDefenseSpecialCellPbData;
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400A206 RID: 41478
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A207 RID: 41479
		public const int BuildingPbDataFieldNumber = 1;

		// Token: 0x0400A208 RID: 41480
		public const int AuxiliaryPbDataFieldNumber = 2;

		// Token: 0x0400A209 RID: 41481
		public const int MonsterPbDataFieldNumber = 3;

		// Token: 0x0400A20A RID: 41482
		public const int GoldenCoinPbDataFieldNumber = 4;

		// Token: 0x0400A20B RID: 41483
		public const int SpecialCellPbDataFieldNumber = 5;

		// Token: 0x0400A20C RID: 41484
		private object data_;

		// Token: 0x0400A20D RID: 41485
		private TrapDefenseComponentPb.DataOneofCase dataCase_;

		// Token: 0x02001A7A RID: 6778
		public enum DataOneofCase
		{
			// Token: 0x0400D00D RID: 53261
			None,
			// Token: 0x0400D00E RID: 53262
			BuildingPbData,
			// Token: 0x0400D00F RID: 53263
			AuxiliaryPbData,
			// Token: 0x0400D010 RID: 53264
			MonsterPbData,
			// Token: 0x0400D011 RID: 53265
			GoldenCoinPbData,
			// Token: 0x0400D012 RID: 53266
			SpecialCellPbData
		}
	}
}
