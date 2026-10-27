using System;
using Aki.UniverseEditor.Interface.Fbs.Match;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F38 RID: 16184
	public struct IMonsterHpPointTypeConfig : IFlatbufferObject
	{
		// Token: 0x1700708D RID: 28813
		// (get) Token: 0x06016FF1 RID: 94193 RVA: 0x003513D2 File Offset: 0x0034F5D2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016FF2 RID: 94194 RVA: 0x003513DF File Offset: 0x0034F5DF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016FF3 RID: 94195 RVA: 0x003513E8 File Offset: 0x0034F5E8
		public static IMonsterHpPointTypeConfig GetRootAsIMonsterHpPointTypeConfig(ByteBuffer _bb)
		{
			return IMonsterHpPointTypeConfig.GetRootAsIMonsterHpPointTypeConfig(_bb, default(IMonsterHpPointTypeConfig));
		}

		// Token: 0x06016FF4 RID: 94196 RVA: 0x00351404 File Offset: 0x0034F604
		public static IMonsterHpPointTypeConfig GetRootAsIMonsterHpPointTypeConfig(ByteBuffer _bb, IMonsterHpPointTypeConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016FF5 RID: 94197 RVA: 0x00351421 File Offset: 0x0034F621
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016FF6 RID: 94198 RVA: 0x00351430 File Offset: 0x0034F630
		public IMonsterHpPointTypeConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700708E RID: 28814
		// (get) Token: 0x06016FF7 RID: 94199 RVA: 0x00351440 File Offset: 0x0034F640
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

		// Token: 0x1700708F RID: 28815
		// (get) Token: 0x06016FF8 RID: 94200 RVA: 0x0035147C File Offset: 0x0034F67C
		public int PointOfEveryOnePercentHp
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

		// Token: 0x06016FF9 RID: 94201 RVA: 0x003514B8 File Offset: 0x0034F6B8
		public static Offset<IMonsterHpPointTypeConfig> CreateIMonsterHpPointTypeConfig(FlatBufferBuilder builder, EMonsterMatchType MonsterType = EMonsterMatchType.Normal, int PointOfEveryOnePercentHp = 0)
		{
			builder.StartTable(2);
			IMonsterHpPointTypeConfig.AddPointOfEveryOnePercentHp(builder, PointOfEveryOnePercentHp);
			IMonsterHpPointTypeConfig.AddMonsterType(builder, MonsterType);
			return IMonsterHpPointTypeConfig.EndIMonsterHpPointTypeConfig(builder);
		}

		// Token: 0x06016FFA RID: 94202 RVA: 0x003514D5 File Offset: 0x0034F6D5
		public static void StartIMonsterHpPointTypeConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06016FFB RID: 94203 RVA: 0x003514DE File Offset: 0x0034F6DE
		public static void AddMonsterType(FlatBufferBuilder builder, EMonsterMatchType monsterType)
		{
			builder.AddByte(0, (byte)monsterType, 0);
		}

		// Token: 0x06016FFC RID: 94204 RVA: 0x003514E9 File Offset: 0x0034F6E9
		public static void AddPointOfEveryOnePercentHp(FlatBufferBuilder builder, int pointOfEveryOnePercentHp)
		{
			builder.AddInt(1, pointOfEveryOnePercentHp, 0);
		}

		// Token: 0x06016FFD RID: 94205 RVA: 0x003514F4 File Offset: 0x0034F6F4
		public static Offset<IMonsterHpPointTypeConfig> EndIMonsterHpPointTypeConfig(FlatBufferBuilder builder)
		{
			return new Offset<IMonsterHpPointTypeConfig>(builder.EndTable());
		}

		// Token: 0x06016FFE RID: 94206 RVA: 0x00351504 File Offset: 0x0034F704
		public IMonsterHpPointTypeConfigT UnPack()
		{
			IMonsterHpPointTypeConfigT monsterHpPointTypeConfigT = new IMonsterHpPointTypeConfigT();
			this.UnPackTo(monsterHpPointTypeConfigT);
			return monsterHpPointTypeConfigT;
		}

		// Token: 0x06016FFF RID: 94207 RVA: 0x0035151F File Offset: 0x0034F71F
		public void UnPackTo(IMonsterHpPointTypeConfigT _o)
		{
			_o.MonsterType = this.MonsterType;
			_o.PointOfEveryOnePercentHp = this.PointOfEveryOnePercentHp;
		}

		// Token: 0x06017000 RID: 94208 RVA: 0x0035153C File Offset: 0x0034F73C
		public static Offset<IMonsterHpPointTypeConfig> Pack(FlatBufferBuilder builder, IMonsterHpPointTypeConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMonsterHpPointTypeConfig>);
			}
			return IMonsterHpPointTypeConfig.CreateIMonsterHpPointTypeConfig(builder, _o.MonsterType, _o.PointOfEveryOnePercentHp);
		}

		// Token: 0x0400B948 RID: 47432
		private Table __p;
	}
}
