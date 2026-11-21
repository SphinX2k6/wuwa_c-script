using System;
using Aki.UniverseEditor.Interface.Fbs.Match;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200437F RID: 17279
	public struct IMonsterPointTypeConfig : IFlatbufferObject
	{
		// Token: 0x1700768D RID: 30349
		// (get) Token: 0x0601869D RID: 99997 RVA: 0x0037AF72 File Offset: 0x00379172
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601869E RID: 99998 RVA: 0x0037AF7F File Offset: 0x0037917F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601869F RID: 99999 RVA: 0x0037AF88 File Offset: 0x00379188
		public static IMonsterPointTypeConfig GetRootAsIMonsterPointTypeConfig(ByteBuffer _bb)
		{
			return IMonsterPointTypeConfig.GetRootAsIMonsterPointTypeConfig(_bb, default(IMonsterPointTypeConfig));
		}

		// Token: 0x060186A0 RID: 100000 RVA: 0x0037AFA4 File Offset: 0x003791A4
		public static IMonsterPointTypeConfig GetRootAsIMonsterPointTypeConfig(ByteBuffer _bb, IMonsterPointTypeConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060186A1 RID: 100001 RVA: 0x0037AFC1 File Offset: 0x003791C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060186A2 RID: 100002 RVA: 0x0037AFD0 File Offset: 0x003791D0
		public IMonsterPointTypeConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700768E RID: 30350
		// (get) Token: 0x060186A3 RID: 100003 RVA: 0x0037AFE0 File Offset: 0x003791E0
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

		// Token: 0x1700768F RID: 30351
		// (get) Token: 0x060186A4 RID: 100004 RVA: 0x0037B01C File Offset: 0x0037921C
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

		// Token: 0x060186A5 RID: 100005 RVA: 0x0037B058 File Offset: 0x00379258
		public static Offset<IMonsterPointTypeConfig> CreateIMonsterPointTypeConfig(FlatBufferBuilder builder, EMonsterMatchType MonsterType = EMonsterMatchType.Normal, int Point = 0)
		{
			builder.StartTable(2);
			IMonsterPointTypeConfig.AddPoint(builder, Point);
			IMonsterPointTypeConfig.AddMonsterType(builder, MonsterType);
			return IMonsterPointTypeConfig.EndIMonsterPointTypeConfig(builder);
		}

		// Token: 0x060186A6 RID: 100006 RVA: 0x0037B075 File Offset: 0x00379275
		public static void StartIMonsterPointTypeConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060186A7 RID: 100007 RVA: 0x0037B07E File Offset: 0x0037927E
		public static void AddMonsterType(FlatBufferBuilder builder, EMonsterMatchType monsterType)
		{
			builder.AddByte(0, (byte)monsterType, 0);
		}

		// Token: 0x060186A8 RID: 100008 RVA: 0x0037B089 File Offset: 0x00379289
		public static void AddPoint(FlatBufferBuilder builder, int point)
		{
			builder.AddInt(1, point, 0);
		}

		// Token: 0x060186A9 RID: 100009 RVA: 0x0037B094 File Offset: 0x00379294
		public static Offset<IMonsterPointTypeConfig> EndIMonsterPointTypeConfig(FlatBufferBuilder builder)
		{
			return new Offset<IMonsterPointTypeConfig>(builder.EndTable());
		}

		// Token: 0x060186AA RID: 100010 RVA: 0x0037B0A4 File Offset: 0x003792A4
		public IMonsterPointTypeConfigT UnPack()
		{
			IMonsterPointTypeConfigT monsterPointTypeConfigT = new IMonsterPointTypeConfigT();
			this.UnPackTo(monsterPointTypeConfigT);
			return monsterPointTypeConfigT;
		}

		// Token: 0x060186AB RID: 100011 RVA: 0x0037B0BF File Offset: 0x003792BF
		public void UnPackTo(IMonsterPointTypeConfigT _o)
		{
			_o.MonsterType = this.MonsterType;
			_o.Point = this.Point;
		}

		// Token: 0x060186AC RID: 100012 RVA: 0x0037B0DC File Offset: 0x003792DC
		public static Offset<IMonsterPointTypeConfig> Pack(FlatBufferBuilder builder, IMonsterPointTypeConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMonsterPointTypeConfig>);
			}
			return IMonsterPointTypeConfig.CreateIMonsterPointTypeConfig(builder, _o.MonsterType, _o.Point);
		}

		// Token: 0x0400C32F RID: 49967
		private Table __p;
	}
}
