using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200448E RID: 17550
	public struct IDartSkillResultType : IFlatbufferObject
	{
		// Token: 0x17007BD5 RID: 31701
		// (get) Token: 0x0601A2CE RID: 107214 RVA: 0x003BD2BB File Offset: 0x003BB4BB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A2CF RID: 107215 RVA: 0x003BD2C8 File Offset: 0x003BB4C8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A2D0 RID: 107216 RVA: 0x003BD2D0 File Offset: 0x003BB4D0
		public static IDartSkillResultType GetRootAsIDartSkillResultType(ByteBuffer _bb)
		{
			return IDartSkillResultType.GetRootAsIDartSkillResultType(_bb, default(IDartSkillResultType));
		}

		// Token: 0x0601A2D1 RID: 107217 RVA: 0x003BD2EC File Offset: 0x003BB4EC
		public static IDartSkillResultType GetRootAsIDartSkillResultType(ByteBuffer _bb, IDartSkillResultType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A2D2 RID: 107218 RVA: 0x003BD309 File Offset: 0x003BB509
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A2D3 RID: 107219 RVA: 0x003BD318 File Offset: 0x003BB518
		public IDartSkillResultType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007BD6 RID: 31702
		// (get) Token: 0x0601A2D4 RID: 107220 RVA: 0x003BD328 File Offset: 0x003BB528
		public EDartSkillResultType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EDartSkillResultType.NoBust;
				}
				return (EDartSkillResultType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601A2D5 RID: 107221 RVA: 0x003BD364 File Offset: 0x003BB564
		public static Offset<IDartSkillResultType> CreateIDartSkillResultType(FlatBufferBuilder builder, EDartSkillResultType Type = EDartSkillResultType.NoBust)
		{
			builder.StartTable(1);
			IDartSkillResultType.AddType(builder, Type);
			return IDartSkillResultType.EndIDartSkillResultType(builder);
		}

		// Token: 0x0601A2D6 RID: 107222 RVA: 0x003BD37A File Offset: 0x003BB57A
		public static void StartIDartSkillResultType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601A2D7 RID: 107223 RVA: 0x003BD383 File Offset: 0x003BB583
		public static void AddType(FlatBufferBuilder builder, EDartSkillResultType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601A2D8 RID: 107224 RVA: 0x003BD38E File Offset: 0x003BB58E
		public static Offset<IDartSkillResultType> EndIDartSkillResultType(FlatBufferBuilder builder)
		{
			return new Offset<IDartSkillResultType>(builder.EndTable());
		}

		// Token: 0x0601A2D9 RID: 107225 RVA: 0x003BD39C File Offset: 0x003BB59C
		public IDartSkillResultTypeT UnPack()
		{
			IDartSkillResultTypeT dartSkillResultTypeT = new IDartSkillResultTypeT();
			this.UnPackTo(dartSkillResultTypeT);
			return dartSkillResultTypeT;
		}

		// Token: 0x0601A2DA RID: 107226 RVA: 0x003BD3B7 File Offset: 0x003BB5B7
		public void UnPackTo(IDartSkillResultTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601A2DB RID: 107227 RVA: 0x003BD3C8 File Offset: 0x003BB5C8
		public static Offset<IDartSkillResultType> Pack(FlatBufferBuilder builder, IDartSkillResultTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDartSkillResultType>);
			}
			return IDartSkillResultType.CreateIDartSkillResultType(builder, _o.Type);
		}

		// Token: 0x0400C48B RID: 50315
		private Table __p;
	}
}
