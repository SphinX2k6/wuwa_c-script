using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005553 RID: 21843
	public struct IConditionHitConfigWithBullet : IFlatbufferObject
	{
		// Token: 0x17009C27 RID: 39975
		// (get) Token: 0x06022A83 RID: 141955 RVA: 0x004C5FAC File Offset: 0x004C41AC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022A84 RID: 141956 RVA: 0x004C5FB9 File Offset: 0x004C41B9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022A85 RID: 141957 RVA: 0x004C5FC0 File Offset: 0x004C41C0
		public static IConditionHitConfigWithBullet GetRootAsIConditionHitConfigWithBullet(ByteBuffer _bb)
		{
			return IConditionHitConfigWithBullet.GetRootAsIConditionHitConfigWithBullet(_bb, default(IConditionHitConfigWithBullet));
		}

		// Token: 0x06022A86 RID: 141958 RVA: 0x004C5FDC File Offset: 0x004C41DC
		public static IConditionHitConfigWithBullet GetRootAsIConditionHitConfigWithBullet(ByteBuffer _bb, IConditionHitConfigWithBullet obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022A87 RID: 141959 RVA: 0x004C5FF9 File Offset: 0x004C41F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022A88 RID: 141960 RVA: 0x004C6008 File Offset: 0x004C4208
		public IConditionHitConfigWithBullet __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009C28 RID: 39976
		// (get) Token: 0x06022A89 RID: 141961 RVA: 0x004C6018 File Offset: 0x004C4218
		public IConditionGroup? Conditions
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17009C29 RID: 39977
		// (get) Token: 0x06022A8A RID: 141962 RVA: 0x004C6078 File Offset: 0x004C4278
		public string State
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06022A8B RID: 141963 RVA: 0x004C60AF File Offset: 0x004C42AF
		public Span<byte> GetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06022A8C RID: 141964 RVA: 0x004C60BE File Offset: 0x004C42BE
		public byte[] GetStateArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17009C2A RID: 39978
		// (get) Token: 0x06022A8D RID: 141965 RVA: 0x004C60CC File Offset: 0x004C42CC
		public THitBulletType HitBulletsType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return THitBulletType.NONE;
				}
				return (THitBulletType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06022A8E RID: 141966 RVA: 0x004C6108 File Offset: 0x004C4308
		public TTable? HitBullets<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06022A8F RID: 141967 RVA: 0x004C6150 File Offset: 0x004C4350
		public IHitBulletTypeAllCharacterAttack HitBulletsAsIHitBulletTypeAllCharacterAttack()
		{
			return this.HitBullets<IHitBulletTypeAllCharacterAttack>().Value;
		}

		// Token: 0x06022A90 RID: 141968 RVA: 0x004C616C File Offset: 0x004C436C
		public IHitBulletTypeCrystalAttack HitBulletsAsIHitBulletTypeCrystalAttack()
		{
			return this.HitBullets<IHitBulletTypeCrystalAttack>().Value;
		}

		// Token: 0x06022A91 RID: 141969 RVA: 0x004C6188 File Offset: 0x004C4388
		public IHitBulletTypeFixedBulletId HitBulletsAsIHitBulletTypeFixedBulletId()
		{
			return this.HitBullets<IHitBulletTypeFixedBulletId>().Value;
		}

		// Token: 0x06022A92 RID: 141970 RVA: 0x004C61A4 File Offset: 0x004C43A4
		public IHitBulletTypeOnlyDropAttack HitBulletsAsIHitBulletTypeOnlyDropAttack()
		{
			return this.HitBullets<IHitBulletTypeOnlyDropAttack>().Value;
		}

		// Token: 0x06022A93 RID: 141971 RVA: 0x004C61C0 File Offset: 0x004C43C0
		public IHitBulletTypePlayerAttack HitBulletsAsIHitBulletTypePlayerAttack()
		{
			return this.HitBullets<IHitBulletTypePlayerAttack>().Value;
		}

		// Token: 0x06022A94 RID: 141972 RVA: 0x004C61DC File Offset: 0x004C43DC
		public IHitBulletTypePlayerOrThrenodianAttack HitBulletsAsIHitBulletTypePlayerOrThrenodianAttack()
		{
			return this.HitBullets<IHitBulletTypePlayerOrThrenodianAttack>().Value;
		}

		// Token: 0x06022A95 RID: 141973 RVA: 0x004C61F7 File Offset: 0x004C43F7
		public static Offset<IConditionHitConfigWithBullet> CreateIConditionHitConfigWithBullet(FlatBufferBuilder builder, Offset<IConditionGroup> ConditionsOffset = default(Offset<IConditionGroup>), StringOffset StateOffset = default(StringOffset), THitBulletType HitBullets_type = THitBulletType.NONE, int HitBulletsOffset = 0)
		{
			builder.StartTable(4);
			IConditionHitConfigWithBullet.AddHitBullets(builder, HitBulletsOffset);
			IConditionHitConfigWithBullet.AddState(builder, StateOffset);
			IConditionHitConfigWithBullet.AddConditions(builder, ConditionsOffset);
			IConditionHitConfigWithBullet.AddHitBulletsType(builder, HitBullets_type);
			return IConditionHitConfigWithBullet.EndIConditionHitConfigWithBullet(builder);
		}

		// Token: 0x06022A96 RID: 141974 RVA: 0x004C6223 File Offset: 0x004C4423
		public static void StartIConditionHitConfigWithBullet(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06022A97 RID: 141975 RVA: 0x004C622C File Offset: 0x004C442C
		public static void AddConditions(FlatBufferBuilder builder, Offset<IConditionGroup> conditionsOffset)
		{
			builder.AddOffset(0, conditionsOffset.Value, 0);
		}

		// Token: 0x06022A98 RID: 141976 RVA: 0x004C623C File Offset: 0x004C443C
		public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset)
		{
			builder.AddOffset(1, stateOffset.Value, 0);
		}

		// Token: 0x06022A99 RID: 141977 RVA: 0x004C624C File Offset: 0x004C444C
		public static void AddHitBulletsType(FlatBufferBuilder builder, THitBulletType hitBulletsType)
		{
			builder.AddByte(2, (byte)hitBulletsType, 0);
		}

		// Token: 0x06022A9A RID: 141978 RVA: 0x004C6257 File Offset: 0x004C4457
		public static void AddHitBullets(FlatBufferBuilder builder, int hitBulletsOffset)
		{
			builder.AddOffset(3, hitBulletsOffset, 0);
		}

		// Token: 0x06022A9B RID: 141979 RVA: 0x004C6262 File Offset: 0x004C4462
		public static Offset<IConditionHitConfigWithBullet> EndIConditionHitConfigWithBullet(FlatBufferBuilder builder)
		{
			return new Offset<IConditionHitConfigWithBullet>(builder.EndTable());
		}

		// Token: 0x06022A9C RID: 141980 RVA: 0x004C6270 File Offset: 0x004C4470
		public IConditionHitConfigWithBulletT UnPack()
		{
			IConditionHitConfigWithBulletT conditionHitConfigWithBulletT = new IConditionHitConfigWithBulletT();
			this.UnPackTo(conditionHitConfigWithBulletT);
			return conditionHitConfigWithBulletT;
		}

		// Token: 0x06022A9D RID: 141981 RVA: 0x004C628C File Offset: 0x004C448C
		public void UnPackTo(IConditionHitConfigWithBulletT _o)
		{
			_o.Conditions = ((this.Conditions != null) ? this.Conditions.Value.UnPack() : null);
			_o.State = this.State;
			_o.HitBullets = new THitBulletTypeUnion();
			_o.HitBullets.Type = this.HitBulletsType;
			switch (this.HitBulletsType)
			{
			case THitBulletType.IHitBulletTypeAllCharacterAttack:
				_o.HitBullets.Value = ((this.HitBullets<IHitBulletTypeAllCharacterAttack>() != null) ? this.HitBullets<IHitBulletTypeAllCharacterAttack>().Value.UnPack() : null);
				return;
			case THitBulletType.IHitBulletTypeCrystalAttack:
				_o.HitBullets.Value = ((this.HitBullets<IHitBulletTypeCrystalAttack>() != null) ? this.HitBullets<IHitBulletTypeCrystalAttack>().Value.UnPack() : null);
				return;
			case THitBulletType.IHitBulletTypeFixedBulletId:
				_o.HitBullets.Value = ((this.HitBullets<IHitBulletTypeFixedBulletId>() != null) ? this.HitBullets<IHitBulletTypeFixedBulletId>().Value.UnPack() : null);
				return;
			case THitBulletType.IHitBulletTypeOnlyDropAttack:
				_o.HitBullets.Value = ((this.HitBullets<IHitBulletTypeOnlyDropAttack>() != null) ? this.HitBullets<IHitBulletTypeOnlyDropAttack>().Value.UnPack() : null);
				return;
			case THitBulletType.IHitBulletTypePlayerAttack:
				_o.HitBullets.Value = ((this.HitBullets<IHitBulletTypePlayerAttack>() != null) ? this.HitBullets<IHitBulletTypePlayerAttack>().Value.UnPack() : null);
				return;
			case THitBulletType.IHitBulletTypePlayerOrThrenodianAttack:
				_o.HitBullets.Value = ((this.HitBullets<IHitBulletTypePlayerOrThrenodianAttack>() != null) ? this.HitBullets<IHitBulletTypePlayerOrThrenodianAttack>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x06022A9E RID: 141982 RVA: 0x004C6468 File Offset: 0x004C4668
		public static Offset<IConditionHitConfigWithBullet> Pack(FlatBufferBuilder builder, IConditionHitConfigWithBulletT _o)
		{
			if (_o == null)
			{
				return default(Offset<IConditionHitConfigWithBullet>);
			}
			Offset<IConditionGroup> conditionsOffset = (_o.Conditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.Conditions);
			StringOffset stateOffset = (_o.State == null) ? default(StringOffset) : builder.CreateString(_o.State);
			THitBulletType hitBullets_type = (_o.HitBullets == null) ? THitBulletType.NONE : _o.HitBullets.Type;
			int hitBulletsOffset = (_o.HitBullets == null) ? 0 : THitBulletTypeUnion.Pack(builder, _o.HitBullets);
			return IConditionHitConfigWithBullet.CreateIConditionHitConfigWithBullet(builder, conditionsOffset, stateOffset, hitBullets_type, hitBulletsOffset);
		}

		// Token: 0x0400EBA2 RID: 60322
		private Table __p;
	}
}
