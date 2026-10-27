using System;
using Aki.UniverseEditor.Interface.Fbs.Match;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F41 RID: 16193
	public struct IMonsterPointTypeConfig : IFlatbufferObject
	{
		// Token: 0x1700709C RID: 28828
		// (get) Token: 0x0601703B RID: 94267 RVA: 0x00351AFE File Offset: 0x0034FCFE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601703C RID: 94268 RVA: 0x00351B0B File Offset: 0x0034FD0B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601703D RID: 94269 RVA: 0x00351B14 File Offset: 0x0034FD14
		public static IMonsterPointTypeConfig GetRootAsIMonsterPointTypeConfig(ByteBuffer _bb)
		{
			return IMonsterPointTypeConfig.GetRootAsIMonsterPointTypeConfig(_bb, default(IMonsterPointTypeConfig));
		}

		// Token: 0x0601703E RID: 94270 RVA: 0x00351B30 File Offset: 0x0034FD30
		public static IMonsterPointTypeConfig GetRootAsIMonsterPointTypeConfig(ByteBuffer _bb, IMonsterPointTypeConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601703F RID: 94271 RVA: 0x00351B4D File Offset: 0x0034FD4D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017040 RID: 94272 RVA: 0x00351B5C File Offset: 0x0034FD5C
		public IMonsterPointTypeConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700709D RID: 28829
		// (get) Token: 0x06017041 RID: 94273 RVA: 0x00351B6C File Offset: 0x0034FD6C
		public EMonsterMatchType MonsterType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMonsterMatchType.Normal;
				}
				return (EMonsterMatchType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700709E RID: 28830
		// (get) Token: 0x06017042 RID: 94274 RVA: 0x00351BA8 File Offset: 0x0034FDA8
		public int Point
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

		// Token: 0x06017043 RID: 94275 RVA: 0x00351BE4 File Offset: 0x0034FDE4
		public static Offset<IMonsterPointTypeConfig> CreateIMonsterPointTypeConfig(FlatBufferBuilder builder, EMonsterMatchType MonsterType = EMonsterMatchType.Normal, int Point = 0)
		{
			builder.StartTable(2);
			IMonsterPointTypeConfig.AddPoint(builder, Point);
			IMonsterPointTypeConfig.AddMonsterType(builder, MonsterType);
			return IMonsterPointTypeConfig.EndIMonsterPointTypeConfig(builder);
		}

		// Token: 0x06017044 RID: 94276 RVA: 0x00351C01 File Offset: 0x0034FE01
		public static void StartIMonsterPointTypeConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06017045 RID: 94277 RVA: 0x00351C0A File Offset: 0x0034FE0A
		public static void AddMonsterType(FlatBufferBuilder builder, EMonsterMatchType monsterType)
		{
			builder.AddByte(0, (byte)monsterType, 0);
		}

		// Token: 0x06017046 RID: 94278 RVA: 0x00351C15 File Offset: 0x0034FE15
		public static void AddPoint(FlatBufferBuilder builder, int point)
		{
			builder.AddInt(1, point, 0);
		}

		// Token: 0x06017047 RID: 94279 RVA: 0x00351C20 File Offset: 0x0034FE20
		public static Offset<IMonsterPointTypeConfig> EndIMonsterPointTypeConfig(FlatBufferBuilder builder)
		{
			return new Offset<IMonsterPointTypeConfig>(builder.EndTable());
		}

		// Token: 0x06017048 RID: 94280 RVA: 0x00351C30 File Offset: 0x0034FE30
		public IMonsterPointTypeConfigT UnPack()
		{
			IMonsterPointTypeConfigT monsterPointTypeConfigT = new IMonsterPointTypeConfigT();
			this.UnPackTo(monsterPointTypeConfigT);
			return monsterPointTypeConfigT;
		}

		// Token: 0x06017049 RID: 94281 RVA: 0x00351C4B File Offset: 0x0034FE4B
		public void UnPackTo(IMonsterPointTypeConfigT _o)
		{
			_o.MonsterType = this.MonsterType;
			_o.Point = this.Point;
		}

		// Token: 0x0601704A RID: 94282 RVA: 0x00351C68 File Offset: 0x0034FE68
		public static Offset<IMonsterPointTypeConfig> Pack(FlatBufferBuilder builder, IMonsterPointTypeConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMonsterPointTypeConfig>);
			}
			return IMonsterPointTypeConfig.CreateIMonsterPointTypeConfig(builder, _o.MonsterType, _o.Point);
		}

		// Token: 0x0400B951 RID: 47441
		private Table __p;
	}
}
