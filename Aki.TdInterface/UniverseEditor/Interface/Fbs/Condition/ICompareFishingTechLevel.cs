using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004BA7 RID: 19367
	public struct ICompareFishingTechLevel : IFlatbufferObject
	{
		// Token: 0x17008C94 RID: 35988
		// (get) Token: 0x0601E8A0 RID: 125088 RVA: 0x00445DD0 File Offset: 0x00443FD0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601E8A1 RID: 125089 RVA: 0x00445DDD File Offset: 0x00443FDD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601E8A2 RID: 125090 RVA: 0x00445DE4 File Offset: 0x00443FE4
		public static ICompareFishingTechLevel GetRootAsICompareFishingTechLevel(ByteBuffer _bb)
		{
			return ICompareFishingTechLevel.GetRootAsICompareFishingTechLevel(_bb, default(ICompareFishingTechLevel));
		}

		// Token: 0x0601E8A3 RID: 125091 RVA: 0x00445E00 File Offset: 0x00444000
		public static ICompareFishingTechLevel GetRootAsICompareFishingTechLevel(ByteBuffer _bb, ICompareFishingTechLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601E8A4 RID: 125092 RVA: 0x00445E1D File Offset: 0x0044401D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601E8A5 RID: 125093 RVA: 0x00445E2C File Offset: 0x0044402C
		public ICompareFishingTechLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008C95 RID: 35989
		// (get) Token: 0x0601E8A6 RID: 125094 RVA: 0x00445E3C File Offset: 0x0044403C
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

		// Token: 0x17008C96 RID: 35990
		// (get) Token: 0x0601E8A7 RID: 125095 RVA: 0x00445E78 File Offset: 0x00444078
		public int TechId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008C97 RID: 35991
		// (get) Token: 0x0601E8A8 RID: 125096 RVA: 0x00445EB4 File Offset: 0x004440B4
		public ECompare Compare
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return ECompare.Eq;
				}
				return (ECompare)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008C98 RID: 35992
		// (get) Token: 0x0601E8A9 RID: 125097 RVA: 0x00445EF0 File Offset: 0x004440F0
		public int TechLevel
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601E8AA RID: 125098 RVA: 0x00445F2D File Offset: 0x0044412D
		public static Offset<ICompareFishingTechLevel> CreateICompareFishingTechLevel(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, int TechId = 0, ECompare Compare = ECompare.Eq, int TechLevel = 0)
		{
			builder.StartTable(4);
			ICompareFishingTechLevel.AddTechLevel(builder, TechLevel);
			ICompareFishingTechLevel.AddTechId(builder, TechId);
			ICompareFishingTechLevel.AddCompare(builder, Compare);
			ICompareFishingTechLevel.AddType(builder, Type);
			return ICompareFishingTechLevel.EndICompareFishingTechLevel(builder);
		}

		// Token: 0x0601E8AB RID: 125099 RVA: 0x00445F59 File Offset: 0x00444159
		public static void StartICompareFishingTechLevel(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0601E8AC RID: 125100 RVA: 0x00445F62 File Offset: 0x00444162
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601E8AD RID: 125101 RVA: 0x00445F6D File Offset: 0x0044416D
		public static void AddTechId(FlatBufferBuilder builder, int techId)
		{
			builder.AddInt(1, techId, 0);
		}

		// Token: 0x0601E8AE RID: 125102 RVA: 0x00445F78 File Offset: 0x00444178
		public static void AddCompare(FlatBufferBuilder builder, ECompare compare)
		{
			builder.AddByte(2, (byte)compare, 0);
		}

		// Token: 0x0601E8AF RID: 125103 RVA: 0x00445F83 File Offset: 0x00444183
		public static void AddTechLevel(FlatBufferBuilder builder, int techLevel)
		{
			builder.AddInt(3, techLevel, 0);
		}

		// Token: 0x0601E8B0 RID: 125104 RVA: 0x00445F8E File Offset: 0x0044418E
		public static Offset<ICompareFishingTechLevel> EndICompareFishingTechLevel(FlatBufferBuilder builder)
		{
			return new Offset<ICompareFishingTechLevel>(builder.EndTable());
		}

		// Token: 0x0601E8B1 RID: 125105 RVA: 0x00445F9C File Offset: 0x0044419C
		public ICompareFishingTechLevelT UnPack()
		{
			ICompareFishingTechLevelT compareFishingTechLevelT = new ICompareFishingTechLevelT();
			this.UnPackTo(compareFishingTechLevelT);
			return compareFishingTechLevelT;
		}

		// Token: 0x0601E8B2 RID: 125106 RVA: 0x00445FB7 File Offset: 0x004441B7
		public void UnPackTo(ICompareFishingTechLevelT _o)
		{
			_o.Type = this.Type;
			_o.TechId = this.TechId;
			_o.Compare = this.Compare;
			_o.TechLevel = this.TechLevel;
		}

		// Token: 0x0601E8B3 RID: 125107 RVA: 0x00445FEC File Offset: 0x004441EC
		public static Offset<ICompareFishingTechLevel> Pack(FlatBufferBuilder builder, ICompareFishingTechLevelT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICompareFishingTechLevel>);
			}
			return ICompareFishingTechLevel.CreateICompareFishingTechLevel(builder, _o.Type, _o.TechId, _o.Compare, _o.TechLevel);
		}

		// Token: 0x0400D486 RID: 54406
		private Table __p;
	}
}
