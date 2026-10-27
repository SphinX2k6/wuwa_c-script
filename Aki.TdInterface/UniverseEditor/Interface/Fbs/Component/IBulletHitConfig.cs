using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F40 RID: 20288
	public struct IBulletHitConfig : IFlatbufferObject
	{
		// Token: 0x17009236 RID: 37430
		// (get) Token: 0x060201E3 RID: 131555 RVA: 0x00477DEA File Offset: 0x00475FEA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060201E4 RID: 131556 RVA: 0x00477DF7 File Offset: 0x00475FF7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060201E5 RID: 131557 RVA: 0x00477E00 File Offset: 0x00476000
		public static IBulletHitConfig GetRootAsIBulletHitConfig(ByteBuffer _bb)
		{
			return IBulletHitConfig.GetRootAsIBulletHitConfig(_bb, default(IBulletHitConfig));
		}

		// Token: 0x060201E6 RID: 131558 RVA: 0x00477E1C File Offset: 0x0047601C
		public static IBulletHitConfig GetRootAsIBulletHitConfig(ByteBuffer _bb, IBulletHitConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060201E7 RID: 131559 RVA: 0x00477E39 File Offset: 0x00476039
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060201E8 RID: 131560 RVA: 0x00477E48 File Offset: 0x00476048
		public IBulletHitConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009237 RID: 37431
		// (get) Token: 0x060201E9 RID: 131561 RVA: 0x00477E58 File Offset: 0x00476058
		public THitBulletType HitBulletType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return THitBulletType.NONE;
				}
				return (THitBulletType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060201EA RID: 131562 RVA: 0x00477E94 File Offset: 0x00476094
		public TTable? HitBullet<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060201EB RID: 131563 RVA: 0x00477ED8 File Offset: 0x004760D8
		public IHitBulletTypeAllCharacterAttack HitBulletAsIHitBulletTypeAllCharacterAttack()
		{
			return this.HitBullet<IHitBulletTypeAllCharacterAttack>().Value;
		}

		// Token: 0x060201EC RID: 131564 RVA: 0x00477EF4 File Offset: 0x004760F4
		public IHitBulletTypeCrystalAttack HitBulletAsIHitBulletTypeCrystalAttack()
		{
			return this.HitBullet<IHitBulletTypeCrystalAttack>().Value;
		}

		// Token: 0x060201ED RID: 131565 RVA: 0x00477F10 File Offset: 0x00476110
		public IHitBulletTypeFixedBulletId HitBulletAsIHitBulletTypeFixedBulletId()
		{
			return this.HitBullet<IHitBulletTypeFixedBulletId>().Value;
		}

		// Token: 0x060201EE RID: 131566 RVA: 0x00477F2C File Offset: 0x0047612C
		public IHitBulletTypeOnlyDropAttack HitBulletAsIHitBulletTypeOnlyDropAttack()
		{
			return this.HitBullet<IHitBulletTypeOnlyDropAttack>().Value;
		}

		// Token: 0x060201EF RID: 131567 RVA: 0x00477F48 File Offset: 0x00476148
		public IHitBulletTypePlayerAttack HitBulletAsIHitBulletTypePlayerAttack()
		{
			return this.HitBullet<IHitBulletTypePlayerAttack>().Value;
		}

		// Token: 0x060201F0 RID: 131568 RVA: 0x00477F64 File Offset: 0x00476164
		public IHitBulletTypePlayerOrThrenodianAttack HitBulletAsIHitBulletTypePlayerOrThrenodianAttack()
		{
			return this.HitBullet<IHitBulletTypePlayerOrThrenodianAttack>().Value;
		}

		// Token: 0x17009238 RID: 37432
		// (get) Token: 0x060201F1 RID: 131569 RVA: 0x00477F80 File Offset: 0x00476180
		public IHitTimeScaleRatio? AttackerHitTimeScaleRatio
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IHitTimeScaleRatio?(default(IHitTimeScaleRatio).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17009239 RID: 37433
		// (get) Token: 0x060201F2 RID: 131570 RVA: 0x00477FE0 File Offset: 0x004761E0
		public IHitTimeScaleRatio? VictimHitTimeScaleRatio
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IHitTimeScaleRatio?(default(IHitTimeScaleRatio).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060201F3 RID: 131571 RVA: 0x0047803E File Offset: 0x0047623E
		public static Offset<IBulletHitConfig> CreateIBulletHitConfig(FlatBufferBuilder builder, THitBulletType HitBullet_type = THitBulletType.NONE, int HitBulletOffset = 0, Offset<IHitTimeScaleRatio> AttackerHitTimeScaleRatioOffset = default(Offset<IHitTimeScaleRatio>), Offset<IHitTimeScaleRatio> VictimHitTimeScaleRatioOffset = default(Offset<IHitTimeScaleRatio>))
		{
			builder.StartTable(4);
			IBulletHitConfig.AddVictimHitTimeScaleRatio(builder, VictimHitTimeScaleRatioOffset);
			IBulletHitConfig.AddAttackerHitTimeScaleRatio(builder, AttackerHitTimeScaleRatioOffset);
			IBulletHitConfig.AddHitBullet(builder, HitBulletOffset);
			IBulletHitConfig.AddHitBulletType(builder, HitBullet_type);
			return IBulletHitConfig.EndIBulletHitConfig(builder);
		}

		// Token: 0x060201F4 RID: 131572 RVA: 0x0047806A File Offset: 0x0047626A
		public static void StartIBulletHitConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060201F5 RID: 131573 RVA: 0x00478073 File Offset: 0x00476273
		public static void AddHitBulletType(FlatBufferBuilder builder, THitBulletType hitBulletType)
		{
			builder.AddByte(0, (byte)hitBulletType, 0);
		}

		// Token: 0x060201F6 RID: 131574 RVA: 0x0047807E File Offset: 0x0047627E
		public static void AddHitBullet(FlatBufferBuilder builder, int hitBulletOffset)
		{
			builder.AddOffset(1, hitBulletOffset, 0);
		}

		// Token: 0x060201F7 RID: 131575 RVA: 0x00478089 File Offset: 0x00476289
		public static void AddAttackerHitTimeScaleRatio(FlatBufferBuilder builder, Offset<IHitTimeScaleRatio> attackerHitTimeScaleRatioOffset)
		{
			builder.AddOffset(2, attackerHitTimeScaleRatioOffset.Value, 0);
		}

		// Token: 0x060201F8 RID: 131576 RVA: 0x00478099 File Offset: 0x00476299
		public static void AddVictimHitTimeScaleRatio(FlatBufferBuilder builder, Offset<IHitTimeScaleRatio> victimHitTimeScaleRatioOffset)
		{
			builder.AddOffset(3, victimHitTimeScaleRatioOffset.Value, 0);
		}

		// Token: 0x060201F9 RID: 131577 RVA: 0x004780A9 File Offset: 0x004762A9
		public static Offset<IBulletHitConfig> EndIBulletHitConfig(FlatBufferBuilder builder)
		{
			return new Offset<IBulletHitConfig>(builder.EndTable());
		}

		// Token: 0x060201FA RID: 131578 RVA: 0x004780B8 File Offset: 0x004762B8
		public IBulletHitConfigT UnPack()
		{
			IBulletHitConfigT bulletHitConfigT = new IBulletHitConfigT();
			this.UnPackTo(bulletHitConfigT);
			return bulletHitConfigT;
		}

		// Token: 0x060201FB RID: 131579 RVA: 0x004780D4 File Offset: 0x004762D4
		public void UnPackTo(IBulletHitConfigT _o)
		{
			_o.HitBullet = new THitBulletTypeUnion();
			_o.HitBullet.Type = this.HitBulletType;
			switch (this.HitBulletType)
			{
			case THitBulletType.IHitBulletTypeAllCharacterAttack:
				_o.HitBullet.Value = ((this.HitBullet<IHitBulletTypeAllCharacterAttack>() != null) ? this.HitBullet<IHitBulletTypeAllCharacterAttack>().Value.UnPack() : null);
				break;
			case THitBulletType.IHitBulletTypeCrystalAttack:
				_o.HitBullet.Value = ((this.HitBullet<IHitBulletTypeCrystalAttack>() != null) ? this.HitBullet<IHitBulletTypeCrystalAttack>().Value.UnPack() : null);
				break;
			case THitBulletType.IHitBulletTypeFixedBulletId:
				_o.HitBullet.Value = ((this.HitBullet<IHitBulletTypeFixedBulletId>() != null) ? this.HitBullet<IHitBulletTypeFixedBulletId>().Value.UnPack() : null);
				break;
			case THitBulletType.IHitBulletTypeOnlyDropAttack:
				_o.HitBullet.Value = ((this.HitBullet<IHitBulletTypeOnlyDropAttack>() != null) ? this.HitBullet<IHitBulletTypeOnlyDropAttack>().Value.UnPack() : null);
				break;
			case THitBulletType.IHitBulletTypePlayerAttack:
				_o.HitBullet.Value = ((this.HitBullet<IHitBulletTypePlayerAttack>() != null) ? this.HitBullet<IHitBulletTypePlayerAttack>().Value.UnPack() : null);
				break;
			case THitBulletType.IHitBulletTypePlayerOrThrenodianAttack:
				_o.HitBullet.Value = ((this.HitBullet<IHitBulletTypePlayerOrThrenodianAttack>() != null) ? this.HitBullet<IHitBulletTypePlayerOrThrenodianAttack>().Value.UnPack() : null);
				break;
			}
			_o.AttackerHitTimeScaleRatio = ((this.AttackerHitTimeScaleRatio != null) ? this.AttackerHitTimeScaleRatio.Value.UnPack() : null);
			_o.VictimHitTimeScaleRatio = ((this.VictimHitTimeScaleRatio != null) ? this.VictimHitTimeScaleRatio.Value.UnPack() : null);
		}

		// Token: 0x060201FC RID: 131580 RVA: 0x004782E8 File Offset: 0x004764E8
		public static Offset<IBulletHitConfig> Pack(FlatBufferBuilder builder, IBulletHitConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBulletHitConfig>);
			}
			THitBulletType hitBullet_type = (_o.HitBullet == null) ? THitBulletType.NONE : _o.HitBullet.Type;
			int hitBulletOffset = (_o.HitBullet == null) ? 0 : THitBulletTypeUnion.Pack(builder, _o.HitBullet);
			Offset<IHitTimeScaleRatio> attackerHitTimeScaleRatioOffset = (_o.AttackerHitTimeScaleRatio == null) ? default(Offset<IHitTimeScaleRatio>) : IHitTimeScaleRatio.Pack(builder, _o.AttackerHitTimeScaleRatio);
			Offset<IHitTimeScaleRatio> victimHitTimeScaleRatioOffset = (_o.VictimHitTimeScaleRatio == null) ? default(Offset<IHitTimeScaleRatio>) : IHitTimeScaleRatio.Pack(builder, _o.VictimHitTimeScaleRatio);
			return IBulletHitConfig.CreateIBulletHitConfig(builder, hitBullet_type, hitBulletOffset, attackerHitTimeScaleRatioOffset, victimHitTimeScaleRatioOffset);
		}

		// Token: 0x0400DDAD RID: 56749
		private Table __p;
	}
}
