using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001412 RID: 5138
	public sealed class TrapDefenseBuildingPbData : IMessage<TrapDefenseBuildingPbData>, IMessage, IEquatable<TrapDefenseBuildingPbData>, IDeepCloneable<TrapDefenseBuildingPbData>, IBufferMessage
	{
		// Token: 0x0601B3BF RID: 111551 RVA: 0x003F2491 File Offset: 0x003F0691
		[NullableContext(1)]
		public static TrapDefenseBuildingPbData Create()
		{
			return new TrapDefenseBuildingPbData();
		}

		// Token: 0x17005BDB RID: 23515
		// (get) Token: 0x0601B3C0 RID: 111552 RVA: 0x003F2498 File Offset: 0x003F0698
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005BDC RID: 23516
		// (get) Token: 0x0601B3C1 RID: 111553 RVA: 0x003F249B File Offset: 0x003F069B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseBuildingPbData.Descriptor;
			}
		}

		// Token: 0x0601B3C2 RID: 111554 RVA: 0x003F24A2 File Offset: 0x003F06A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseBuildingPbData()
		{
		}

		// Token: 0x0601B3C3 RID: 111555 RVA: 0x003F24AC File Offset: 0x003F06AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseBuildingPbData(TrapDefenseBuildingPbData other) : this()
		{
			this.configId_ = other.configId_;
			this.battleLevel_ = other.battleLevel_;
			this.constructCost_ = other.constructCost_;
			this.deconstructReturn_ = other.deconstructReturn_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B3C4 RID: 111556 RVA: 0x003F2500 File Offset: 0x003F0700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseBuildingPbData Clone()
		{
			return new TrapDefenseBuildingPbData(this);
		}

		// Token: 0x17005BDD RID: 23517
		// (get) Token: 0x0601B3C5 RID: 111557 RVA: 0x003F2508 File Offset: 0x003F0708
		// (set) Token: 0x0601B3C6 RID: 111558 RVA: 0x003F2510 File Offset: 0x003F0710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConfigId
		{
			get
			{
				return this.configId_;
			}
			set
			{
				this.configId_ = value;
			}
		}

		// Token: 0x17005BDE RID: 23518
		// (get) Token: 0x0601B3C7 RID: 111559 RVA: 0x003F2519 File Offset: 0x003F0719
		// (set) Token: 0x0601B3C8 RID: 111560 RVA: 0x003F2521 File Offset: 0x003F0721
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BattleLevel
		{
			get
			{
				return this.battleLevel_;
			}
			set
			{
				this.battleLevel_ = value;
			}
		}

		// Token: 0x17005BDF RID: 23519
		// (get) Token: 0x0601B3C9 RID: 111561 RVA: 0x003F252A File Offset: 0x003F072A
		// (set) Token: 0x0601B3CA RID: 111562 RVA: 0x003F2532 File Offset: 0x003F0732
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConstructCost
		{
			get
			{
				return this.constructCost_;
			}
			set
			{
				this.constructCost_ = value;
			}
		}

		// Token: 0x17005BE0 RID: 23520
		// (get) Token: 0x0601B3CB RID: 111563 RVA: 0x003F253B File Offset: 0x003F073B
		// (set) Token: 0x0601B3CC RID: 111564 RVA: 0x003F2543 File Offset: 0x003F0743
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DeconstructReturn
		{
			get
			{
				return this.deconstructReturn_;
			}
			set
			{
				this.deconstructReturn_ = value;
			}
		}

		// Token: 0x0601B3CD RID: 111565 RVA: 0x003F254C File Offset: 0x003F074C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseBuildingPbData);
		}

		// Token: 0x0601B3CE RID: 111566 RVA: 0x003F255C File Offset: 0x003F075C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseBuildingPbData other)
		{
			return other != null && (other == this || (this.ConfigId == other.ConfigId && this.BattleLevel == other.BattleLevel && this.ConstructCost == other.ConstructCost && this.DeconstructReturn == other.DeconstructReturn && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B3CF RID: 111567 RVA: 0x003F25C8 File Offset: 0x003F07C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ConfigId != 0)
			{
				num ^= this.ConfigId.GetHashCode();
			}
			if (this.BattleLevel != 0)
			{
				num ^= this.BattleLevel.GetHashCode();
			}
			if (this.ConstructCost != 0)
			{
				num ^= this.ConstructCost.GetHashCode();
			}
			if (this.DeconstructReturn != 0)
			{
				num ^= this.DeconstructReturn.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B3D0 RID: 111568 RVA: 0x003F2652 File Offset: 0x003F0852
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B3D1 RID: 111569 RVA: 0x003F265F File Offset: 0x003F085F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B3D2 RID: 111570 RVA: 0x003F2668 File Offset: 0x003F0868
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ConfigId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ConfigId);
			}
			if (this.BattleLevel != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.BattleLevel);
			}
			if (this.ConstructCost != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ConstructCost);
			}
			if (this.DeconstructReturn != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.DeconstructReturn);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B3D3 RID: 111571 RVA: 0x003F26F8 File Offset: 0x003F08F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConfigId);
			}
			if (this.BattleLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BattleLevel);
			}
			if (this.ConstructCost != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConstructCost);
			}
			if (this.DeconstructReturn != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DeconstructReturn);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B3D4 RID: 111572 RVA: 0x003F2780 File Offset: 0x003F0980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseBuildingPbData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ConfigId != 0)
			{
				this.ConfigId = other.ConfigId;
			}
			if (other.BattleLevel != 0)
			{
				this.BattleLevel = other.BattleLevel;
			}
			if (other.ConstructCost != 0)
			{
				this.ConstructCost = other.ConstructCost;
			}
			if (other.DeconstructReturn != 0)
			{
				this.DeconstructReturn = other.DeconstructReturn;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B3D5 RID: 111573 RVA: 0x003F27F8 File Offset: 0x003F09F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B3D6 RID: 111574 RVA: 0x003F2804 File Offset: 0x003F0A04
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.ConfigId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.BattleLevel = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.ConstructCost = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.DeconstructReturn = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009D84 RID: 40324
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009D85 RID: 40325
		public const int ConfigIdFieldNumber = 1;

		// Token: 0x04009D86 RID: 40326
		private int configId_;

		// Token: 0x04009D87 RID: 40327
		public const int BattleLevelFieldNumber = 2;

		// Token: 0x04009D88 RID: 40328
		private int battleLevel_;

		// Token: 0x04009D89 RID: 40329
		public const int ConstructCostFieldNumber = 3;

		// Token: 0x04009D8A RID: 40330
		private int constructCost_;

		// Token: 0x04009D8B RID: 40331
		public const int DeconstructReturnFieldNumber = 4;

		// Token: 0x04009D8C RID: 40332
		private int deconstructReturn_;
	}
}
