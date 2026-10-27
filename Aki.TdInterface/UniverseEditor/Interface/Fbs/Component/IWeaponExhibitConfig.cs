using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B6E RID: 23406
	public struct IWeaponExhibitConfig : IFlatbufferObject
	{
		// Token: 0x1700B0DD RID: 45277
		// (get) Token: 0x060280E7 RID: 164071 RVA: 0x00581B9C File Offset: 0x0057FD9C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060280E8 RID: 164072 RVA: 0x00581BA9 File Offset: 0x0057FDA9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060280E9 RID: 164073 RVA: 0x00581BB0 File Offset: 0x0057FDB0
		public static IWeaponExhibitConfig GetRootAsIWeaponExhibitConfig(ByteBuffer _bb)
		{
			return IWeaponExhibitConfig.GetRootAsIWeaponExhibitConfig(_bb, default(IWeaponExhibitConfig));
		}

		// Token: 0x060280EA RID: 164074 RVA: 0x00581BCC File Offset: 0x0057FDCC
		public static IWeaponExhibitConfig GetRootAsIWeaponExhibitConfig(ByteBuffer _bb, IWeaponExhibitConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060280EB RID: 164075 RVA: 0x00581BE9 File Offset: 0x0057FDE9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060280EC RID: 164076 RVA: 0x00581BF8 File Offset: 0x0057FDF8
		public IWeaponExhibitConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B0DE RID: 45278
		// (get) Token: 0x060280ED RID: 164077 RVA: 0x00581C08 File Offset: 0x0057FE08
		public EExhibitItemType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EExhibitItemType.Phantom;
				}
				return (EExhibitItemType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B0DF RID: 45279
		// (get) Token: 0x060280EE RID: 164078 RVA: 0x00581C44 File Offset: 0x0057FE44
		public IVectorInfo? Offset
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700B0E0 RID: 45280
		// (get) Token: 0x060280EF RID: 164079 RVA: 0x00581CA4 File Offset: 0x0057FEA4
		public IExhibitEffect? ActiveEffect
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IExhibitEffect?(default(IExhibitEffect).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060280F0 RID: 164080 RVA: 0x00581D01 File Offset: 0x0057FF01
		public static Offset<IWeaponExhibitConfig> CreateIWeaponExhibitConfig(FlatBufferBuilder builder, EExhibitItemType Type = EExhibitItemType.Phantom, Offset<IVectorInfo> OffsetOffset = default(Offset<IVectorInfo>), Offset<IExhibitEffect> ActiveEffectOffset = default(Offset<IExhibitEffect>))
		{
			builder.StartTable(3);
			IWeaponExhibitConfig.AddActiveEffect(builder, ActiveEffectOffset);
			IWeaponExhibitConfig.AddOffset(builder, OffsetOffset);
			IWeaponExhibitConfig.AddType(builder, Type);
			return IWeaponExhibitConfig.EndIWeaponExhibitConfig(builder);
		}

		// Token: 0x060280F1 RID: 164081 RVA: 0x00581D25 File Offset: 0x0057FF25
		public static void StartIWeaponExhibitConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060280F2 RID: 164082 RVA: 0x00581D2E File Offset: 0x0057FF2E
		public static void AddType(FlatBufferBuilder builder, EExhibitItemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060280F3 RID: 164083 RVA: 0x00581D39 File Offset: 0x0057FF39
		public static void AddOffset(FlatBufferBuilder builder, Offset<IVectorInfo> offsetOffset)
		{
			builder.AddOffset(1, offsetOffset.Value, 0);
		}

		// Token: 0x060280F4 RID: 164084 RVA: 0x00581D49 File Offset: 0x0057FF49
		public static void AddActiveEffect(FlatBufferBuilder builder, Offset<IExhibitEffect> activeEffectOffset)
		{
			builder.AddOffset(2, activeEffectOffset.Value, 0);
		}

		// Token: 0x060280F5 RID: 164085 RVA: 0x00581D59 File Offset: 0x0057FF59
		public static Offset<IWeaponExhibitConfig> EndIWeaponExhibitConfig(FlatBufferBuilder builder)
		{
			return new Offset<IWeaponExhibitConfig>(builder.EndTable());
		}

		// Token: 0x060280F6 RID: 164086 RVA: 0x00581D68 File Offset: 0x0057FF68
		public IWeaponExhibitConfigT UnPack()
		{
			IWeaponExhibitConfigT weaponExhibitConfigT = new IWeaponExhibitConfigT();
			this.UnPackTo(weaponExhibitConfigT);
			return weaponExhibitConfigT;
		}

		// Token: 0x060280F7 RID: 164087 RVA: 0x00581D84 File Offset: 0x0057FF84
		public void UnPackTo(IWeaponExhibitConfigT _o)
		{
			_o.Type = this.Type;
			_o.Offset = ((this.Offset != null) ? this.Offset.Value.UnPack() : null);
			_o.ActiveEffect = ((this.ActiveEffect != null) ? this.ActiveEffect.Value.UnPack() : null);
		}

		// Token: 0x060280F8 RID: 164088 RVA: 0x00581DFC File Offset: 0x0057FFFC
		public static Offset<IWeaponExhibitConfig> Pack(FlatBufferBuilder builder, IWeaponExhibitConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWeaponExhibitConfig>);
			}
			Offset<IVectorInfo> offsetOffset = (_o.Offset == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Offset);
			Offset<IExhibitEffect> activeEffectOffset = (_o.ActiveEffect == null) ? default(Offset<IExhibitEffect>) : IExhibitEffect.Pack(builder, _o.ActiveEffect);
			return IWeaponExhibitConfig.CreateIWeaponExhibitConfig(builder, _o.Type, offsetOffset, activeEffectOffset);
		}

		// Token: 0x0400F2C2 RID: 62146
		private Table __p;
	}
}
