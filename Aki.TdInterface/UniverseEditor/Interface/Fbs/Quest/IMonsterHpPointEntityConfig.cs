using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F35 RID: 16181
	public struct IMonsterHpPointEntityConfig : IFlatbufferObject
	{
		// Token: 0x17007088 RID: 28808
		// (get) Token: 0x06016FDB RID: 94171 RVA: 0x003511D4 File Offset: 0x0034F3D4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016FDC RID: 94172 RVA: 0x003511E1 File Offset: 0x0034F3E1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016FDD RID: 94173 RVA: 0x003511E8 File Offset: 0x0034F3E8
		public static IMonsterHpPointEntityConfig GetRootAsIMonsterHpPointEntityConfig(ByteBuffer _bb)
		{
			return IMonsterHpPointEntityConfig.GetRootAsIMonsterHpPointEntityConfig(_bb, default(IMonsterHpPointEntityConfig));
		}

		// Token: 0x06016FDE RID: 94174 RVA: 0x00351204 File Offset: 0x0034F404
		public static IMonsterHpPointEntityConfig GetRootAsIMonsterHpPointEntityConfig(ByteBuffer _bb, IMonsterHpPointEntityConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016FDF RID: 94175 RVA: 0x00351221 File Offset: 0x0034F421
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016FE0 RID: 94176 RVA: 0x00351230 File Offset: 0x0034F430
		public IMonsterHpPointEntityConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007089 RID: 28809
		// (get) Token: 0x06016FE1 RID: 94177 RVA: 0x00351240 File Offset: 0x0034F440
		public int EntityId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700708A RID: 28810
		// (get) Token: 0x06016FE2 RID: 94178 RVA: 0x0035127C File Offset: 0x0034F47C
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

		// Token: 0x06016FE3 RID: 94179 RVA: 0x003512B8 File Offset: 0x0034F4B8
		public static Offset<IMonsterHpPointEntityConfig> CreateIMonsterHpPointEntityConfig(FlatBufferBuilder builder, int EntityId = 0, int PointOfEveryOnePercentHp = 0)
		{
			builder.StartTable(2);
			IMonsterHpPointEntityConfig.AddPointOfEveryOnePercentHp(builder, PointOfEveryOnePercentHp);
			IMonsterHpPointEntityConfig.AddEntityId(builder, EntityId);
			return IMonsterHpPointEntityConfig.EndIMonsterHpPointEntityConfig(builder);
		}

		// Token: 0x06016FE4 RID: 94180 RVA: 0x003512D5 File Offset: 0x0034F4D5
		public static void StartIMonsterHpPointEntityConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06016FE5 RID: 94181 RVA: 0x003512DE File Offset: 0x0034F4DE
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(0, entityId, 0);
		}

		// Token: 0x06016FE6 RID: 94182 RVA: 0x003512E9 File Offset: 0x0034F4E9
		public static void AddPointOfEveryOnePercentHp(FlatBufferBuilder builder, int pointOfEveryOnePercentHp)
		{
			builder.AddInt(1, pointOfEveryOnePercentHp, 0);
		}

		// Token: 0x06016FE7 RID: 94183 RVA: 0x003512F4 File Offset: 0x0034F4F4
		public static Offset<IMonsterHpPointEntityConfig> EndIMonsterHpPointEntityConfig(FlatBufferBuilder builder)
		{
			return new Offset<IMonsterHpPointEntityConfig>(builder.EndTable());
		}

		// Token: 0x06016FE8 RID: 94184 RVA: 0x00351304 File Offset: 0x0034F504
		public IMonsterHpPointEntityConfigT UnPack()
		{
			IMonsterHpPointEntityConfigT monsterHpPointEntityConfigT = new IMonsterHpPointEntityConfigT();
			this.UnPackTo(monsterHpPointEntityConfigT);
			return monsterHpPointEntityConfigT;
		}

		// Token: 0x06016FE9 RID: 94185 RVA: 0x0035131F File Offset: 0x0034F51F
		public void UnPackTo(IMonsterHpPointEntityConfigT _o)
		{
			_o.EntityId = this.EntityId;
			_o.PointOfEveryOnePercentHp = this.PointOfEveryOnePercentHp;
		}

		// Token: 0x06016FEA RID: 94186 RVA: 0x0035133C File Offset: 0x0034F53C
		public static Offset<IMonsterHpPointEntityConfig> Pack(FlatBufferBuilder builder, IMonsterHpPointEntityConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMonsterHpPointEntityConfig>);
			}
			return IMonsterHpPointEntityConfig.CreateIMonsterHpPointEntityConfig(builder, _o.EntityId, _o.PointOfEveryOnePercentHp);
		}

		// Token: 0x0400B945 RID: 47429
		private Table __p;
	}
}
