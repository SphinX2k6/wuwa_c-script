using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005472 RID: 21618
	public struct IBulletHitConfig : IFlatbufferObject
	{
		// Token: 0x170099B8 RID: 39352
		// (get) Token: 0x06021F53 RID: 139091 RVA: 0x004AE17E File Offset: 0x004AC37E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021F54 RID: 139092 RVA: 0x004AE18B File Offset: 0x004AC38B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021F55 RID: 139093 RVA: 0x004AE194 File Offset: 0x004AC394
		public static IBulletHitConfig GetRootAsIBulletHitConfig(ByteBuffer _bb)
		{
			return IBulletHitConfig.GetRootAsIBulletHitConfig(_bb, default(IBulletHitConfig));
		}

		// Token: 0x06021F56 RID: 139094 RVA: 0x004AE1B0 File Offset: 0x004AC3B0
		public static IBulletHitConfig GetRootAsIBulletHitConfig(ByteBuffer _bb, IBulletHitConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021F57 RID: 139095 RVA: 0x004AE1CD File Offset: 0x004AC3CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021F58 RID: 139096 RVA: 0x004AE1DC File Offset: 0x004AC3DC
		public IBulletHitConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170099B9 RID: 39353
		// (get) Token: 0x06021F59 RID: 139097 RVA: 0x004AE1EC File Offset: 0x004AC3EC
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

		// Token: 0x06021F5A RID: 139098 RVA: 0x004AE228 File Offset: 0x004AC428
		public TTable? HitBullet<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06021F5B RID: 139099 RVA: 0x004AE26C File Offset: 0x004AC46C
		public IHitBulletTypeAllCharacterAttack HitBulletAsIHitBulletTypeAllCharacterAttack()
		{
			return this.HitBullet<IHitBulletTypeAllCharacterAttack>().Value;
		}

		// Token: 0x06021F5C RID: 139100 RVA: 0x004AE288 File Offset: 0x004AC488
		public IHitBulletTypeCrystalAttack HitBulletAsIHitBulletTypeCrystalAttack()
		{
			return this.HitBullet<IHitBulletTypeCrystalAttack>().Value;
		}

		// Token: 0x06021F5D RID: 139101 RVA: 0x004AE2A4 File Offset: 0x004AC4A4
		public IHitBulletTypeFixedBulletId HitBulletAsIHitBulletTypeFixedBulletId()
		{
			return this.HitBullet<IHitBulletTypeFixedBulletId>().Value;
		}

		// Token: 0x06021F5E RID: 139102 RVA: 0x004AE2C0 File Offset: 0x004AC4C0
		public IHitBulletTypeOnlyDropAttack HitBulletAsIHitBulletTypeOnlyDropAttack()
		{
			return this.HitBullet<IHitBulletTypeOnlyDropAttack>().Value;
		}

		// Token: 0x06021F5F RID: 139103 RVA: 0x004AE2DC File Offset: 0x004AC4DC
		public IHitBulletTypePlayerAttack HitBulletAsIHitBulletTypePlayerAttack()
		{
			return this.HitBullet<IHitBulletTypePlayerAttack>().Value;
		}

		// Token: 0x06021F60 RID: 139104 RVA: 0x004AE2F8 File Offset: 0x004AC4F8
		public IHitBulletTypePlayerOrThrenodianAttack HitBulletAsIHitBulletTypePlayerOrThrenodianAttack()
		{
			return this.HitBullet<IHitBulletTypePlayerOrThrenodianAttack>().Value;
		}

		// Token: 0x170099BA RID: 39354
		// (get) Token: 0x06021F61 RID: 139105 RVA: 0x004AE314 File Offset: 0x004AC514
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

		// Token: 0x170099BB RID: 39355
		// (get) Token: 0x06021F62 RID: 139106 RVA: 0x004AE374 File Offset: 0x004AC574
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

		// Token: 0x06021F63 RID: 139107 RVA: 0x004AE3D2 File Offset: 0x004AC5D2
		public static Offset<IBulletHitConfig> CreateIBulletHitConfig(FlatBufferBuilder builder, THitBulletType HitBullet_type = THitBulletType.NONE, int HitBulletOffset = 0, Offset<IHitTimeScaleRatio> AttackerHitTimeScaleRatioOffset = default(Offset<IHitTimeScaleRatio>), Offset<IHitTimeScaleRatio> VictimHitTimeScaleRatioOffset = default(Offset<IHitTimeScaleRatio>))
		{
			builder.StartTable(4);
			IBulletHitConfig.AddVictimHitTimeScaleRatio(builder, VictimHitTimeScaleRatioOffset);
			IBulletHitConfig.AddAttackerHitTimeScaleRatio(builder, AttackerHitTimeScaleRatioOffset);
			IBulletHitConfig.AddHitBullet(builder, HitBulletOffset);
			IBulletHitConfig.AddHitBulletType(builder, HitBullet_type);
			return IBulletHitConfig.EndIBulletHitConfig(builder);
		}

		// Token: 0x06021F64 RID: 139108 RVA: 0x004AE3FE File Offset: 0x004AC5FE
		public static void StartIBulletHitConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06021F65 RID: 139109 RVA: 0x004AE407 File Offset: 0x004AC607
		public static void AddHitBulletType(FlatBufferBuilder builder, THitBulletType hitBulletType)
		{
			builder.AddByte(0, (byte)hitBulletType, 0);
		}

		// Token: 0x06021F66 RID: 139110 RVA: 0x004AE412 File Offset: 0x004AC612
		public static void AddHitBullet(FlatBufferBuilder builder, int hitBulletOffset)
		{
			builder.AddOffset(1, hitBulletOffset, 0);
		}

		// Token: 0x06021F67 RID: 139111 RVA: 0x004AE41D File Offset: 0x004AC61D
		public static void AddAttackerHitTimeScaleRatio(FlatBufferBuilder builder, Offset<IHitTimeScaleRatio> attackerHitTimeScaleRatioOffset)
		{
			builder.AddOffset(2, attackerHitTimeScaleRatioOffset.Value, 0);
		}

		// Token: 0x06021F68 RID: 139112 RVA: 0x004AE42D File Offset: 0x004AC62D
		public static void AddVictimHitTimeScaleRatio(FlatBufferBuilder builder, Offset<IHitTimeScaleRatio> victimHitTimeScaleRatioOffset)
		{
			builder.AddOffset(3, victimHitTimeScaleRatioOffset.Value, 0);
		}

		// Token: 0x06021F69 RID: 139113 RVA: 0x004AE43D File Offset: 0x004AC63D
		public static Offset<IBulletHitConfig> EndIBulletHitConfig(FlatBufferBuilder builder)
		{
			return new Offset<IBulletHitConfig>(builder.EndTable());
		}

		// Token: 0x06021F6A RID: 139114 RVA: 0x004AE44C File Offset: 0x004AC64C
		public IBulletHitConfigT UnPack()
		{
			IBulletHitConfigT bulletHitConfigT = new IBulletHitConfigT();
			this.UnPackTo(bulletHitConfigT);
			return bulletHitConfigT;
		}

		// Token: 0x06021F6B RID: 139115 RVA: 0x004AE468 File Offset: 0x004AC668
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

		// Token: 0x06021F6C RID: 139116 RVA: 0x004AE67C File Offset: 0x004AC87C
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

		// Token: 0x0400E95C RID: 59740
		private Table __p;
	}
}
