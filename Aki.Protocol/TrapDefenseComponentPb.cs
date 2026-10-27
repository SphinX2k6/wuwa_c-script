using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200141C RID: 5148
	public sealed class TrapDefenseComponentPb : IMessage<TrapDefenseComponentPb>, IMessage, IEquatable<TrapDefenseComponentPb>, IDeepCloneable<TrapDefenseComponentPb>, IBufferMessage
	{
		// Token: 0x0601B494 RID: 111764 RVA: 0x003F417D File Offset: 0x003F237D
		[NullableContext(1)]
		public static TrapDefenseComponentPb Create()
		{
			return new TrapDefenseComponentPb();
		}

		// Token: 0x17005C0A RID: 23562
		// (get) Token: 0x0601B495 RID: 111765 RVA: 0x003F4184 File Offset: 0x003F2384
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005C0B RID: 23563
		// (get) Token: 0x0601B496 RID: 111766 RVA: 0x003F4187 File Offset: 0x003F2387
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseComponentPb.Descriptor;
			}
		}

		// Token: 0x0601B497 RID: 111767 RVA: 0x003F418E File Offset: 0x003F238E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseComponentPb()
		{
		}

		// Token: 0x0601B498 RID: 111768 RVA: 0x003F4198 File Offset: 0x003F2398
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

		// Token: 0x0601B499 RID: 111769 RVA: 0x003F423E File Offset: 0x003F243E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseComponentPb Clone()
		{
			return new TrapDefenseComponentPb(this);
		}

		// Token: 0x17005C0C RID: 23564
		// (get) Token: 0x0601B49A RID: 111770 RVA: 0x003F4246 File Offset: 0x003F2446
		// (set) Token: 0x0601B49B RID: 111771 RVA: 0x003F425E File Offset: 0x003F245E
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

		// Token: 0x17005C0D RID: 23565
		// (get) Token: 0x0601B49C RID: 111772 RVA: 0x003F4274 File Offset: 0x003F2474
		// (set) Token: 0x0601B49D RID: 111773 RVA: 0x003F428C File Offset: 0x003F248C
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

		// Token: 0x17005C0E RID: 23566
		// (get) Token: 0x0601B49E RID: 111774 RVA: 0x003F42A2 File Offset: 0x003F24A2
		// (set) Token: 0x0601B49F RID: 111775 RVA: 0x003F42BA File Offset: 0x003F24BA
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

		// Token: 0x17005C0F RID: 23567
		// (get) Token: 0x0601B4A0 RID: 111776 RVA: 0x003F42D0 File Offset: 0x003F24D0
		// (set) Token: 0x0601B4A1 RID: 111777 RVA: 0x003F42E8 File Offset: 0x003F24E8
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

		// Token: 0x17005C10 RID: 23568
		// (get) Token: 0x0601B4A2 RID: 111778 RVA: 0x003F42FE File Offset: 0x003F24FE
		// (set) Token: 0x0601B4A3 RID: 111779 RVA: 0x003F4316 File Offset: 0x003F2516
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

		// Token: 0x17005C11 RID: 23569
		// (get) Token: 0x0601B4A4 RID: 111780 RVA: 0x003F432C File Offset: 0x003F252C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseComponentPb.DataOneofCase DataCase
		{
			get
			{
				return this.dataCase_;
			}
		}

		// Token: 0x0601B4A5 RID: 111781 RVA: 0x003F4334 File Offset: 0x003F2534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void ClearData()
		{
			this.dataCase_ = TrapDefenseComponentPb.DataOneofCase.None;
			this.data_ = null;
		}

		// Token: 0x0601B4A6 RID: 111782 RVA: 0x003F4344 File Offset: 0x003F2544
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseComponentPb);
		}

		// Token: 0x0601B4A7 RID: 111783 RVA: 0x003F4354 File Offset: 0x003F2554
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseComponentPb other)
		{
			return other != null && (other == this || (object.Equals(this.BuildingPbData, other.BuildingPbData) && object.Equals(this.AuxiliaryPbData, other.AuxiliaryPbData) && object.Equals(this.MonsterPbData, other.MonsterPbData) && object.Equals(this.GoldenCoinPbData, other.GoldenCoinPbData) && object.Equals(this.SpecialCellPbData, other.SpecialCellPbData) && this.DataCase == other.DataCase && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B4A8 RID: 111784 RVA: 0x003F43F8 File Offset: 0x003F25F8
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

		// Token: 0x0601B4A9 RID: 111785 RVA: 0x003F449A File Offset: 0x003F269A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B4AA RID: 111786 RVA: 0x003F44A7 File Offset: 0x003F26A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B4AB RID: 111787 RVA: 0x003F44B0 File Offset: 0x003F26B0
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

		// Token: 0x0601B4AC RID: 111788 RVA: 0x003F4564 File Offset: 0x003F2764
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

		// Token: 0x0601B4AD RID: 111789 RVA: 0x003F4608 File Offset: 0x003F2808
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

		// Token: 0x0601B4AE RID: 111790 RVA: 0x003F4717 File Offset: 0x003F2917
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B4AF RID: 111791 RVA: 0x003F4720 File Offset: 0x003F2920
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

		// Token: 0x04009DBF RID: 40383
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009DC0 RID: 40384
		public const int BuildingPbDataFieldNumber = 1;

		// Token: 0x04009DC1 RID: 40385
		public const int AuxiliaryPbDataFieldNumber = 2;

		// Token: 0x04009DC2 RID: 40386
		public const int MonsterPbDataFieldNumber = 3;

		// Token: 0x04009DC3 RID: 40387
		public const int GoldenCoinPbDataFieldNumber = 4;

		// Token: 0x04009DC4 RID: 40388
		public const int SpecialCellPbDataFieldNumber = 5;

		// Token: 0x04009DC5 RID: 40389
		private object data_;

		// Token: 0x04009DC6 RID: 40390
		private TrapDefenseComponentPb.DataOneofCase dataCase_;

		// Token: 0x020019D8 RID: 6616
		public enum DataOneofCase
		{
			// Token: 0x0400CAA2 RID: 51874
			None,
			// Token: 0x0400CAA3 RID: 51875
			BuildingPbData,
			// Token: 0x0400CAA4 RID: 51876
			AuxiliaryPbData,
			// Token: 0x0400CAA5 RID: 51877
			MonsterPbData,
			// Token: 0x0400CAA6 RID: 51878
			GoldenCoinPbData,
			// Token: 0x0400CAA7 RID: 51879
			SpecialCellPbData
		}
	}
}
