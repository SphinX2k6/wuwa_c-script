using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004FF4 RID: 20468
	public struct IConditionHitConfigWithBullet : IFlatbufferObject
	{
		// Token: 0x17009446 RID: 37958
		// (get) Token: 0x06020B63 RID: 133987 RVA: 0x0048C55C File Offset: 0x0048A75C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06020B64 RID: 133988 RVA: 0x0048C569 File Offset: 0x0048A769
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06020B65 RID: 133989 RVA: 0x0048C570 File Offset: 0x0048A770
		public static IConditionHitConfigWithBullet GetRootAsIConditionHitConfigWithBullet(ByteBuffer _bb)
		{
			return IConditionHitConfigWithBullet.GetRootAsIConditionHitConfigWithBullet(_bb, default(IConditionHitConfigWithBullet));
		}

		// Token: 0x06020B66 RID: 133990 RVA: 0x0048C58C File Offset: 0x0048A78C
		public static IConditionHitConfigWithBullet GetRootAsIConditionHitConfigWithBullet(ByteBuffer _bb, IConditionHitConfigWithBullet obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06020B67 RID: 133991 RVA: 0x0048C5A9 File Offset: 0x0048A7A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06020B68 RID: 133992 RVA: 0x0048C5B8 File Offset: 0x0048A7B8
		public IConditionHitConfigWithBullet __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009447 RID: 37959
		// (get) Token: 0x06020B69 RID: 133993 RVA: 0x0048C5C8 File Offset: 0x0048A7C8
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

		// Token: 0x17009448 RID: 37960
		// (get) Token: 0x06020B6A RID: 133994 RVA: 0x0048C628 File Offset: 0x0048A828
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

		// Token: 0x06020B6B RID: 133995 RVA: 0x0048C65F File Offset: 0x0048A85F
		public Span<byte> GetStateBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06020B6C RID: 133996 RVA: 0x0048C66E File Offset: 0x0048A86E
		public byte[] GetStateArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x17009449 RID: 37961
		// (get) Token: 0x06020B6D RID: 133997 RVA: 0x0048C67C File Offset: 0x0048A87C
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

		// Token: 0x06020B6E RID: 133998 RVA: 0x0048C6B8 File Offset: 0x0048A8B8
		public TTable? HitBullets<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06020B6F RID: 133999 RVA: 0x0048C700 File Offset: 0x0048A900
		public IHitBulletTypeAllCharacterAttack HitBulletsAsIHitBulletTypeAllCharacterAttack()
		{
			return this.HitBullets<IHitBulletTypeAllCharacterAttack>().Value;
		}

		// Token: 0x06020B70 RID: 134000 RVA: 0x0048C71C File Offset: 0x0048A91C
		public IHitBulletTypeCrystalAttack HitBulletsAsIHitBulletTypeCrystalAttack()
		{
			return this.HitBullets<IHitBulletTypeCrystalAttack>().Value;
		}

		// Token: 0x06020B71 RID: 134001 RVA: 0x0048C738 File Offset: 0x0048A938
		public IHitBulletTypeFixedBulletId HitBulletsAsIHitBulletTypeFixedBulletId()
		{
			return this.HitBullets<IHitBulletTypeFixedBulletId>().Value;
		}

		// Token: 0x06020B72 RID: 134002 RVA: 0x0048C754 File Offset: 0x0048A954
		public IHitBulletTypeOnlyDropAttack HitBulletsAsIHitBulletTypeOnlyDropAttack()
		{
			return this.HitBullets<IHitBulletTypeOnlyDropAttack>().Value;
		}

		// Token: 0x06020B73 RID: 134003 RVA: 0x0048C770 File Offset: 0x0048A970
		public IHitBulletTypePlayerAttack HitBulletsAsIHitBulletTypePlayerAttack()
		{
			return this.HitBullets<IHitBulletTypePlayerAttack>().Value;
		}

		// Token: 0x06020B74 RID: 134004 RVA: 0x0048C78C File Offset: 0x0048A98C
		public IHitBulletTypePlayerOrThrenodianAttack HitBulletsAsIHitBulletTypePlayerOrThrenodianAttack()
		{
			return this.HitBullets<IHitBulletTypePlayerOrThrenodianAttack>().Value;
		}

		// Token: 0x06020B75 RID: 134005 RVA: 0x0048C7A7 File Offset: 0x0048A9A7
		public static Offset<IConditionHitConfigWithBullet> CreateIConditionHitConfigWithBullet(FlatBufferBuilder builder, Offset<IConditionGroup> ConditionsOffset = default(Offset<IConditionGroup>), StringOffset StateOffset = default(StringOffset), THitBulletType HitBullets_type = THitBulletType.NONE, int HitBulletsOffset = 0)
		{
			builder.StartTable(4);
			IConditionHitConfigWithBullet.AddHitBullets(builder, HitBulletsOffset);
			IConditionHitConfigWithBullet.AddState(builder, StateOffset);
			IConditionHitConfigWithBullet.AddConditions(builder, ConditionsOffset);
			IConditionHitConfigWithBullet.AddHitBulletsType(builder, HitBullets_type);
			return IConditionHitConfigWithBullet.EndIConditionHitConfigWithBullet(builder);
		}

		// Token: 0x06020B76 RID: 134006 RVA: 0x0048C7D3 File Offset: 0x0048A9D3
		public static void StartIConditionHitConfigWithBullet(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06020B77 RID: 134007 RVA: 0x0048C7DC File Offset: 0x0048A9DC
		public static void AddConditions(FlatBufferBuilder builder, Offset<IConditionGroup> conditionsOffset)
		{
			builder.AddOffset(0, conditionsOffset.Value, 0);
		}

		// Token: 0x06020B78 RID: 134008 RVA: 0x0048C7EC File Offset: 0x0048A9EC
		public static void AddState(FlatBufferBuilder builder, StringOffset stateOffset)
		{
			builder.AddOffset(1, stateOffset.Value, 0);
		}

		// Token: 0x06020B79 RID: 134009 RVA: 0x0048C7FC File Offset: 0x0048A9FC
		public static void AddHitBulletsType(FlatBufferBuilder builder, THitBulletType hitBulletsType)
		{
			builder.AddByte(2, (byte)hitBulletsType, 0);
		}

		// Token: 0x06020B7A RID: 134010 RVA: 0x0048C807 File Offset: 0x0048AA07
		public static void AddHitBullets(FlatBufferBuilder builder, int hitBulletsOffset)
		{
			builder.AddOffset(3, hitBulletsOffset, 0);
		}

		// Token: 0x06020B7B RID: 134011 RVA: 0x0048C812 File Offset: 0x0048AA12
		public static Offset<IConditionHitConfigWithBullet> EndIConditionHitConfigWithBullet(FlatBufferBuilder builder)
		{
			return new Offset<IConditionHitConfigWithBullet>(builder.EndTable());
		}

		// Token: 0x06020B7C RID: 134012 RVA: 0x0048C820 File Offset: 0x0048AA20
		public IConditionHitConfigWithBulletT UnPack()
		{
			IConditionHitConfigWithBulletT conditionHitConfigWithBulletT = new IConditionHitConfigWithBulletT();
			this.UnPackTo(conditionHitConfigWithBulletT);
			return conditionHitConfigWithBulletT;
		}

		// Token: 0x06020B7D RID: 134013 RVA: 0x0048C83C File Offset: 0x0048AA3C
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

		// Token: 0x06020B7E RID: 134014 RVA: 0x0048CA18 File Offset: 0x0048AC18
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

		// Token: 0x0400DFAC RID: 57260
		private Table __p;
	}
}
