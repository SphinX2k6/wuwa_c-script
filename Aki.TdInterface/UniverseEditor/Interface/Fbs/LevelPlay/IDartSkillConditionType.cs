using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004485 RID: 17541
	public struct IDartSkillConditionType : IFlatbufferObject
	{
		// Token: 0x17007BCD RID: 31693
		// (get) Token: 0x0601A28C RID: 107148 RVA: 0x003BCB97 File Offset: 0x003BAD97
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A28D RID: 107149 RVA: 0x003BCBA4 File Offset: 0x003BADA4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A28E RID: 107150 RVA: 0x003BCBAC File Offset: 0x003BADAC
		public static IDartSkillConditionType GetRootAsIDartSkillConditionType(ByteBuffer _bb)
		{
			return IDartSkillConditionType.GetRootAsIDartSkillConditionType(_bb, default(IDartSkillConditionType));
		}

		// Token: 0x0601A28F RID: 107151 RVA: 0x003BCBC8 File Offset: 0x003BADC8
		public static IDartSkillConditionType GetRootAsIDartSkillConditionType(ByteBuffer _bb, IDartSkillConditionType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A290 RID: 107152 RVA: 0x003BCBE5 File Offset: 0x003BADE5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A291 RID: 107153 RVA: 0x003BCBF4 File Offset: 0x003BADF4
		public IDartSkillConditionType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007BCE RID: 31694
		// (get) Token: 0x0601A292 RID: 107154 RVA: 0x003BCC04 File Offset: 0x003BAE04
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

		// Token: 0x0601A293 RID: 107155 RVA: 0x003BCC40 File Offset: 0x003BAE40
		public static Offset<IDartSkillConditionType> CreateIDartSkillConditionType(FlatBufferBuilder builder, EDartSkillConditionType Type = EDartSkillConditionType.RemainScoreGe)
		{
			builder.StartTable(1);
			IDartSkillConditionType.AddType(builder, Type);
			return IDartSkillConditionType.EndIDartSkillConditionType(builder);
		}

		// Token: 0x0601A294 RID: 107156 RVA: 0x003BCC56 File Offset: 0x003BAE56
		public static void StartIDartSkillConditionType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601A295 RID: 107157 RVA: 0x003BCC5F File Offset: 0x003BAE5F
		public static void AddType(FlatBufferBuilder builder, EDartSkillConditionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601A296 RID: 107158 RVA: 0x003BCC6A File Offset: 0x003BAE6A
		public static Offset<IDartSkillConditionType> EndIDartSkillConditionType(FlatBufferBuilder builder)
		{
			return new Offset<IDartSkillConditionType>(builder.EndTable());
		}

		// Token: 0x0601A297 RID: 107159 RVA: 0x003BCC78 File Offset: 0x003BAE78
		public IDartSkillConditionTypeT UnPack()
		{
			IDartSkillConditionTypeT dartSkillConditionTypeT = new IDartSkillConditionTypeT();
			this.UnPackTo(dartSkillConditionTypeT);
			return dartSkillConditionTypeT;
		}

		// Token: 0x0601A298 RID: 107160 RVA: 0x003BCC93 File Offset: 0x003BAE93
		public void UnPackTo(IDartSkillConditionTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601A299 RID: 107161 RVA: 0x003BCCA4 File Offset: 0x003BAEA4
		public static Offset<IDartSkillConditionType> Pack(FlatBufferBuilder builder, IDartSkillConditionTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDartSkillConditionType>);
			}
			return IDartSkillConditionType.CreateIDartSkillConditionType(builder, _o.Type);
		}

		// Token: 0x0400C47B RID: 50299
		private Table __p;
	}
}
