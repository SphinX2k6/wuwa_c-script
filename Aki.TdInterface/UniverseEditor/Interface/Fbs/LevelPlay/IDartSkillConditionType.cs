using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020048ED RID: 18669
	public struct IDartSkillConditionType : IFlatbufferObject
	{
		// Token: 0x1700820C RID: 33292
		// (get) Token: 0x0601BA5D RID: 113245 RVA: 0x003E8DA3 File Offset: 0x003E6FA3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601BA5E RID: 113246 RVA: 0x003E8DB0 File Offset: 0x003E6FB0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601BA5F RID: 113247 RVA: 0x003E8DB8 File Offset: 0x003E6FB8
		public static IDartSkillConditionType GetRootAsIDartSkillConditionType(ByteBuffer _bb)
		{
			return IDartSkillConditionType.GetRootAsIDartSkillConditionType(_bb, default(IDartSkillConditionType));
		}

		// Token: 0x0601BA60 RID: 113248 RVA: 0x003E8DD4 File Offset: 0x003E6FD4
		public static IDartSkillConditionType GetRootAsIDartSkillConditionType(ByteBuffer _bb, IDartSkillConditionType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601BA61 RID: 113249 RVA: 0x003E8DF1 File Offset: 0x003E6FF1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601BA62 RID: 113250 RVA: 0x003E8E00 File Offset: 0x003E7000
		public IDartSkillConditionType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700820D RID: 33293
		// (get) Token: 0x0601BA63 RID: 113251 RVA: 0x003E8E10 File Offset: 0x003E7010
		public EDartSkillConditionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EDartSkillConditionType.RemainScoreGe;
				}
				return (EDartSkillConditionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BA64 RID: 113252 RVA: 0x003E8E4C File Offset: 0x003E704C
		public static Offset<IDartSkillConditionType> CreateIDartSkillConditionType(FlatBufferBuilder builder, EDartSkillConditionType Type = EDartSkillConditionType.RemainScoreGe)
		{
			builder.StartTable(1);
			IDartSkillConditionType.AddType(builder, Type);
			return IDartSkillConditionType.EndIDartSkillConditionType(builder);
		}

		// Token: 0x0601BA65 RID: 113253 RVA: 0x003E8E62 File Offset: 0x003E7062
		public static void StartIDartSkillConditionType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601BA66 RID: 113254 RVA: 0x003E8E6B File Offset: 0x003E706B
		public static void AddType(FlatBufferBuilder builder, EDartSkillConditionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601BA67 RID: 113255 RVA: 0x003E8E76 File Offset: 0x003E7076
		public static Offset<IDartSkillConditionType> EndIDartSkillConditionType(FlatBufferBuilder builder)
		{
			return new Offset<IDartSkillConditionType>(builder.EndTable());
		}

		// Token: 0x0601BA68 RID: 113256 RVA: 0x003E8E84 File Offset: 0x003E7084
		public IDartSkillConditionTypeT UnPack()
		{
			IDartSkillConditionTypeT dartSkillConditionTypeT = new IDartSkillConditionTypeT();
			this.UnPackTo(dartSkillConditionTypeT);
			return dartSkillConditionTypeT;
		}

		// Token: 0x0601BA69 RID: 113257 RVA: 0x003E8E9F File Offset: 0x003E709F
		public void UnPackTo(IDartSkillConditionTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601BA6A RID: 113258 RVA: 0x003E8EB0 File Offset: 0x003E70B0
		public static Offset<IDartSkillConditionType> Pack(FlatBufferBuilder builder, IDartSkillConditionTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDartSkillConditionType>);
			}
			return IDartSkillConditionType.CreateIDartSkillConditionType(builder, _o.Type);
		}

		// Token: 0x0400CEA9 RID: 52905
		private Table __p;
	}
}
