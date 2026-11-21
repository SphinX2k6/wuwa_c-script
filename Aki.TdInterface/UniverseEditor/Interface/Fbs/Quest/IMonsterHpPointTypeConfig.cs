using System;
using Aki.UniverseEditor.Interface.Fbs.Match;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004376 RID: 17270
	public struct IMonsterHpPointTypeConfig : IFlatbufferObject
	{
		// Token: 0x1700767E RID: 30334
		// (get) Token: 0x06018653 RID: 99923 RVA: 0x0037A846 File Offset: 0x00378A46
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018654 RID: 99924 RVA: 0x0037A853 File Offset: 0x00378A53
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018655 RID: 99925 RVA: 0x0037A85C File Offset: 0x00378A5C
		public static IMonsterHpPointTypeConfig GetRootAsIMonsterHpPointTypeConfig(ByteBuffer _bb)
		{
			return IMonsterHpPointTypeConfig.GetRootAsIMonsterHpPointTypeConfig(_bb, default(IMonsterHpPointTypeConfig));
		}

		// Token: 0x06018656 RID: 99926 RVA: 0x0037A878 File Offset: 0x00378A78
		public static IMonsterHpPointTypeConfig GetRootAsIMonsterHpPointTypeConfig(ByteBuffer _bb, IMonsterHpPointTypeConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018657 RID: 99927 RVA: 0x0037A895 File Offset: 0x00378A95
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018658 RID: 99928 RVA: 0x0037A8A4 File Offset: 0x00378AA4
		public IMonsterHpPointTypeConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700767F RID: 30335
		// (get) Token: 0x06018659 RID: 99929 RVA: 0x0037A8B4 File Offset: 0x00378AB4
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

		// Token: 0x17007680 RID: 30336
		// (get) Token: 0x0601865A RID: 99930 RVA: 0x0037A8F0 File Offset: 0x00378AF0
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

		// Token: 0x0601865B RID: 99931 RVA: 0x0037A92C File Offset: 0x00378B2C
		public static Offset<IMonsterHpPointTypeConfig> CreateIMonsterHpPointTypeConfig(FlatBufferBuilder builder, EMonsterMatchType MonsterType = EMonsterMatchType.Normal, int PointOfEveryOnePercentHp = 0)
		{
			builder.StartTable(2);
			IMonsterHpPointTypeConfig.AddPointOfEveryOnePercentHp(builder, PointOfEveryOnePercentHp);
			IMonsterHpPointTypeConfig.AddMonsterType(builder, MonsterType);
			return IMonsterHpPointTypeConfig.EndIMonsterHpPointTypeConfig(builder);
		}

		// Token: 0x0601865C RID: 99932 RVA: 0x0037A949 File Offset: 0x00378B49
		public static void StartIMonsterHpPointTypeConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601865D RID: 99933 RVA: 0x0037A952 File Offset: 0x00378B52
		public static void AddMonsterType(FlatBufferBuilder builder, EMonsterMatchType monsterType)
		{
			builder.AddByte(0, (byte)monsterType, 0);
		}

		// Token: 0x0601865E RID: 99934 RVA: 0x0037A95D File Offset: 0x00378B5D
		public static void AddPointOfEveryOnePercentHp(FlatBufferBuilder builder, int pointOfEveryOnePercentHp)
		{
			builder.AddInt(1, pointOfEveryOnePercentHp, 0);
		}

		// Token: 0x0601865F RID: 99935 RVA: 0x0037A968 File Offset: 0x00378B68
		public static Offset<IMonsterHpPointTypeConfig> EndIMonsterHpPointTypeConfig(FlatBufferBuilder builder)
		{
			return new Offset<IMonsterHpPointTypeConfig>(builder.EndTable());
		}

		// Token: 0x06018660 RID: 99936 RVA: 0x0037A978 File Offset: 0x00378B78
		public IMonsterHpPointTypeConfigT UnPack()
		{
			IMonsterHpPointTypeConfigT monsterHpPointTypeConfigT = new IMonsterHpPointTypeConfigT();
			this.UnPackTo(monsterHpPointTypeConfigT);
			return monsterHpPointTypeConfigT;
		}

		// Token: 0x06018661 RID: 99937 RVA: 0x0037A993 File Offset: 0x00378B93
		public void UnPackTo(IMonsterHpPointTypeConfigT _o)
		{
			_o.MonsterType = this.MonsterType;
			_o.PointOfEveryOnePercentHp = this.PointOfEveryOnePercentHp;
		}

		// Token: 0x06018662 RID: 99938 RVA: 0x0037A9B0 File Offset: 0x00378BB0
		public static Offset<IMonsterHpPointTypeConfig> Pack(FlatBufferBuilder builder, IMonsterHpPointTypeConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMonsterHpPointTypeConfig>);
			}
			return IMonsterHpPointTypeConfig.CreateIMonsterHpPointTypeConfig(builder, _o.MonsterType, _o.PointOfEveryOnePercentHp);
		}

		// Token: 0x0400C326 RID: 49958
		private Table __p;
	}
}
