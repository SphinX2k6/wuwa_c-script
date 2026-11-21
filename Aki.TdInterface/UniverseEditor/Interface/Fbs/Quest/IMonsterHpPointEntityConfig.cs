using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004373 RID: 17267
	public struct IMonsterHpPointEntityConfig : IFlatbufferObject
	{
		// Token: 0x17007679 RID: 30329
		// (get) Token: 0x0601863D RID: 99901 RVA: 0x0037A646 File Offset: 0x00378846
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601863E RID: 99902 RVA: 0x0037A653 File Offset: 0x00378853
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601863F RID: 99903 RVA: 0x0037A65C File Offset: 0x0037885C
		public static IMonsterHpPointEntityConfig GetRootAsIMonsterHpPointEntityConfig(ByteBuffer _bb)
		{
			return IMonsterHpPointEntityConfig.GetRootAsIMonsterHpPointEntityConfig(_bb, default(IMonsterHpPointEntityConfig));
		}

		// Token: 0x06018640 RID: 99904 RVA: 0x0037A678 File Offset: 0x00378878
		public static IMonsterHpPointEntityConfig GetRootAsIMonsterHpPointEntityConfig(ByteBuffer _bb, IMonsterHpPointEntityConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018641 RID: 99905 RVA: 0x0037A695 File Offset: 0x00378895
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018642 RID: 99906 RVA: 0x0037A6A4 File Offset: 0x003788A4
		public IMonsterHpPointEntityConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700767A RID: 30330
		// (get) Token: 0x06018643 RID: 99907 RVA: 0x0037A6B4 File Offset: 0x003788B4
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

		// Token: 0x1700767B RID: 30331
		// (get) Token: 0x06018644 RID: 99908 RVA: 0x0037A6F0 File Offset: 0x003788F0
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

		// Token: 0x06018645 RID: 99909 RVA: 0x0037A72C File Offset: 0x0037892C
		public static Offset<IMonsterHpPointEntityConfig> CreateIMonsterHpPointEntityConfig(FlatBufferBuilder builder, int EntityId = 0, int PointOfEveryOnePercentHp = 0)
		{
			builder.StartTable(2);
			IMonsterHpPointEntityConfig.AddPointOfEveryOnePercentHp(builder, PointOfEveryOnePercentHp);
			IMonsterHpPointEntityConfig.AddEntityId(builder, EntityId);
			return IMonsterHpPointEntityConfig.EndIMonsterHpPointEntityConfig(builder);
		}

		// Token: 0x06018646 RID: 99910 RVA: 0x0037A749 File Offset: 0x00378949
		public static void StartIMonsterHpPointEntityConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06018647 RID: 99911 RVA: 0x0037A752 File Offset: 0x00378952
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(0, entityId, 0);
		}

		// Token: 0x06018648 RID: 99912 RVA: 0x0037A75D File Offset: 0x0037895D
		public static void AddPointOfEveryOnePercentHp(FlatBufferBuilder builder, int pointOfEveryOnePercentHp)
		{
			builder.AddInt(1, pointOfEveryOnePercentHp, 0);
		}

		// Token: 0x06018649 RID: 99913 RVA: 0x0037A768 File Offset: 0x00378968
		public static Offset<IMonsterHpPointEntityConfig> EndIMonsterHpPointEntityConfig(FlatBufferBuilder builder)
		{
			return new Offset<IMonsterHpPointEntityConfig>(builder.EndTable());
		}

		// Token: 0x0601864A RID: 99914 RVA: 0x0037A778 File Offset: 0x00378978
		public IMonsterHpPointEntityConfigT UnPack()
		{
			IMonsterHpPointEntityConfigT monsterHpPointEntityConfigT = new IMonsterHpPointEntityConfigT();
			this.UnPackTo(monsterHpPointEntityConfigT);
			return monsterHpPointEntityConfigT;
		}

		// Token: 0x0601864B RID: 99915 RVA: 0x0037A793 File Offset: 0x00378993
		public void UnPackTo(IMonsterHpPointEntityConfigT _o)
		{
			_o.EntityId = this.EntityId;
			_o.PointOfEveryOnePercentHp = this.PointOfEveryOnePercentHp;
		}

		// Token: 0x0601864C RID: 99916 RVA: 0x0037A7B0 File Offset: 0x003789B0
		public static Offset<IMonsterHpPointEntityConfig> Pack(FlatBufferBuilder builder, IMonsterHpPointEntityConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMonsterHpPointEntityConfig>);
			}
			return IMonsterHpPointEntityConfig.CreateIMonsterHpPointEntityConfig(builder, _o.EntityId, _o.PointOfEveryOnePercentHp);
		}

		// Token: 0x0400C323 RID: 49955
		private Table __p;
	}
}
