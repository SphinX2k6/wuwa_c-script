using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004BA4 RID: 19364
	public struct ICompareFishingPrestigeLevelCondition : IFlatbufferObject
	{
		// Token: 0x17008C8D RID: 35981
		// (get) Token: 0x0601E886 RID: 125062 RVA: 0x00445B40 File Offset: 0x00443D40
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E887 RID: 125063 RVA: 0x00445B4D File Offset: 0x00443D4D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E888 RID: 125064 RVA: 0x00445B54 File Offset: 0x00443D54
		public static ICompareFishingPrestigeLevelCondition GetRootAsICompareFishingPrestigeLevelCondition(ByteBuffer _bb)
		{
			return ICompareFishingPrestigeLevelCondition.GetRootAsICompareFishingPrestigeLevelCondition(_bb, default(ICompareFishingPrestigeLevelCondition));
		}

		// Token: 0x0601E889 RID: 125065 RVA: 0x00445B70 File Offset: 0x00443D70
		public static ICompareFishingPrestigeLevelCondition GetRootAsICompareFishingPrestigeLevelCondition(ByteBuffer _bb, ICompareFishingPrestigeLevelCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E88A RID: 125066 RVA: 0x00445B8D File Offset: 0x00443D8D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E88B RID: 125067 RVA: 0x00445B9C File Offset: 0x00443D9C
		public ICompareFishingPrestigeLevelCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008C8E RID: 35982
		// (get) Token: 0x0601E88C RID: 125068 RVA: 0x00445BAC File Offset: 0x00443DAC
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

		// Token: 0x17008C8F RID: 35983
		// (get) Token: 0x0601E88D RID: 125069 RVA: 0x00445BE8 File Offset: 0x00443DE8
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

		// Token: 0x17008C90 RID: 35984
		// (get) Token: 0x0601E88E RID: 125070 RVA: 0x00445C24 File Offset: 0x00443E24
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

		// Token: 0x0601E88F RID: 125071 RVA: 0x00445C60 File Offset: 0x00443E60
		public static Offset<ICompareFishingPrestigeLevelCondition> CreateICompareFishingPrestigeLevelCondition(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, ECompare Compare = ECompare.Eq, int PrestigeLevel = 0)
		{
			builder.StartTable(3);
			ICompareFishingPrestigeLevelCondition.AddPrestigeLevel(builder, PrestigeLevel);
			ICompareFishingPrestigeLevelCondition.AddCompare(builder, Compare);
			ICompareFishingPrestigeLevelCondition.AddType(builder, Type);
			return ICompareFishingPrestigeLevelCondition.EndICompareFishingPrestigeLevelCondition(builder);
		}

		// Token: 0x0601E890 RID: 125072 RVA: 0x00445C84 File Offset: 0x00443E84
		public static void StartICompareFishingPrestigeLevelCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601E891 RID: 125073 RVA: 0x00445C8D File Offset: 0x00443E8D
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E892 RID: 125074 RVA: 0x00445C98 File Offset: 0x00443E98
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(1, (byte)compare, 0);
		}

		// Token: 0x0601E893 RID: 125075 RVA: 0x00445CA3 File Offset: 0x00443EA3
		public static void AddPrestigeLevel(FlatBufferBuilder builder, int prestigeLevel)
		{
			builder.AddInt(2, prestigeLevel, 0);
		}

		// Token: 0x0601E894 RID: 125076 RVA: 0x00445CAE File Offset: 0x00443EAE
		public static Offset<ICompareFishingPrestigeLevelCondition> EndICompareFishingPrestigeLevelCondition(FlatBufferBuilder builder)
		{
			return new Offset<ICompareFishingPrestigeLevelCondition>(builder.EndTable());
		}

		// Token: 0x0601E895 RID: 125077 RVA: 0x00445CBC File Offset: 0x00443EBC
		public ICompareFishingPrestigeLevelConditionT UnPack()
		{
			ICompareFishingPrestigeLevelConditionT compareFishingPrestigeLevelConditionT = new ICompareFishingPrestigeLevelConditionT();
			this.UnPackTo(compareFishingPrestigeLevelConditionT);
			return compareFishingPrestigeLevelConditionT;
		}

		// Token: 0x0601E896 RID: 125078 RVA: 0x00445CD7 File Offset: 0x00443ED7
		public void UnPackTo(ICompareFishingPrestigeLevelConditionT _o)
		{
			_o.Type = this.Type;
			_o.Compare = this.Compare;
			_o.PrestigeLevel = this.PrestigeLevel;
		}

		// Token: 0x0601E897 RID: 125079 RVA: 0x00445D00 File Offset: 0x00443F00
		public static Offset<ICompareFishingPrestigeLevelCondition> Pack(FlatBufferBuilder builder, ICompareFishingPrestigeLevelConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICompareFishingPrestigeLevelCondition>);
			}
			return ICompareFishingPrestigeLevelCondition.CreateICompareFishingPrestigeLevelCondition(builder, _o.Type, _o.Compare, _o.PrestigeLevel);
		}

		// Token: 0x0400D482 RID: 54402
		private Table __p;
	}
}
