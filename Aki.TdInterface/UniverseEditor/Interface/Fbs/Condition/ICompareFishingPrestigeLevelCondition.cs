using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200508E RID: 20622
	public struct ICompareFishingPrestigeLevelCondition : IFlatbufferObject
	{
		// Token: 0x170093A6 RID: 37798
		// (get) Token: 0x06020432 RID: 132146 RVA: 0x004786A4 File Offset: 0x004768A4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020433 RID: 132147 RVA: 0x004786B1 File Offset: 0x004768B1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020434 RID: 132148 RVA: 0x004786B8 File Offset: 0x004768B8
		public static ICompareFishingPrestigeLevelCondition GetRootAsICompareFishingPrestigeLevelCondition(ByteBuffer _bb)
		{
			return ICompareFishingPrestigeLevelCondition.GetRootAsICompareFishingPrestigeLevelCondition(_bb, default(ICompareFishingPrestigeLevelCondition));
		}

		// Token: 0x06020435 RID: 132149 RVA: 0x004786D4 File Offset: 0x004768D4
		public static ICompareFishingPrestigeLevelCondition GetRootAsICompareFishingPrestigeLevelCondition(ByteBuffer _bb, ICompareFishingPrestigeLevelCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020436 RID: 132150 RVA: 0x004786F1 File Offset: 0x004768F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020437 RID: 132151 RVA: 0x00478700 File Offset: 0x00476900
		public ICompareFishingPrestigeLevelCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170093A7 RID: 37799
		// (get) Token: 0x06020438 RID: 132152 RVA: 0x00478710 File Offset: 0x00476910
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170093A8 RID: 37800
		// (get) Token: 0x06020439 RID: 132153 RVA: 0x0047874C File Offset: 0x0047694C
		public ECompare Compare
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return ECompare.Eq;
				}
				return (ECompare)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170093A9 RID: 37801
		// (get) Token: 0x0602043A RID: 132154 RVA: 0x00478788 File Offset: 0x00476988
		public int PrestigeLevel
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602043B RID: 132155 RVA: 0x004787C4 File Offset: 0x004769C4
		public static Offset<ICompareFishingPrestigeLevelCondition> CreateICompareFishingPrestigeLevelCondition(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, ECompare Compare = ECompare.Eq, int PrestigeLevel = 0)
		{
			builder.StartTable(3);
			ICompareFishingPrestigeLevelCondition.AddPrestigeLevel(builder, PrestigeLevel);
			ICompareFishingPrestigeLevelCondition.AddCompare(builder, Compare);
			ICompareFishingPrestigeLevelCondition.AddType(builder, Type);
			return ICompareFishingPrestigeLevelCondition.EndICompareFishingPrestigeLevelCondition(builder);
		}

		// Token: 0x0602043C RID: 132156 RVA: 0x004787E8 File Offset: 0x004769E8
		public static void StartICompareFishingPrestigeLevelCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602043D RID: 132157 RVA: 0x004787F1 File Offset: 0x004769F1
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602043E RID: 132158 RVA: 0x004787FC File Offset: 0x004769FC
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(1, (byte)compare, 0);
		}

		// Token: 0x0602043F RID: 132159 RVA: 0x00478807 File Offset: 0x00476A07
		public static void AddPrestigeLevel(FlatBufferBuilder builder, int prestigeLevel)
		{
			builder.AddInt(2, prestigeLevel, 0);
		}

		// Token: 0x06020440 RID: 132160 RVA: 0x00478812 File Offset: 0x00476A12
		public static Offset<ICompareFishingPrestigeLevelCondition> EndICompareFishingPrestigeLevelCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICompareFishingPrestigeLevelCondition>(builder.EndTable());
		}

		// Token: 0x06020441 RID: 132161 RVA: 0x00478820 File Offset: 0x00476A20
		public ICompareFishingPrestigeLevelConditionT UnPack()
		{
			ICompareFishingPrestigeLevelConditionT compareFishingPrestigeLevelConditionT = new ICompareFishingPrestigeLevelConditionT();
			this.UnPackTo(compareFishingPrestigeLevelConditionT);
			return compareFishingPrestigeLevelConditionT;
		}

		// Token: 0x06020442 RID: 132162 RVA: 0x0047883B File Offset: 0x00476A3B
		public void UnPackTo(ICompareFishingPrestigeLevelConditionT _o)
		{
			_o.Type = this.Type;
			_o.Compare = this.Compare;
			_o.PrestigeLevel = this.PrestigeLevel;
		}

		// Token: 0x06020443 RID: 132163 RVA: 0x00478864 File Offset: 0x00476A64
		public static Offset<ICompareFishingPrestigeLevelCondition> Pack(FlatBufferBuilder builder, ICompareFishingPrestigeLevelConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICompareFishingPrestigeLevelCondition>);
			}
			return ICompareFishingPrestigeLevelCondition.CreateICompareFishingPrestigeLevelCondition(builder, _o.Type, _o.Compare, _o.PrestigeLevel);
		}

		// Token: 0x0400DF87 RID: 57223
		private Table __p;
	}
}
