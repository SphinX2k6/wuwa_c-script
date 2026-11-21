using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006184 RID: 24964
	public struct IWeaponExhibitConfig : IFlatbufferObject
	{
		// Token: 0x1700BA25 RID: 47653
		// (get) Token: 0x0602A6AB RID: 173739 RVA: 0x005C962C File Offset: 0x005C782C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A6AC RID: 173740 RVA: 0x005C9639 File Offset: 0x005C7839
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A6AD RID: 173741 RVA: 0x005C9640 File Offset: 0x005C7840
		public static IWeaponExhibitConfig GetRootAsIWeaponExhibitConfig(ByteBuffer _bb)
		{
			return IWeaponExhibitConfig.GetRootAsIWeaponExhibitConfig(_bb, default(IWeaponExhibitConfig));
		}

		// Token: 0x0602A6AE RID: 173742 RVA: 0x005C965C File Offset: 0x005C785C
		public static IWeaponExhibitConfig GetRootAsIWeaponExhibitConfig(ByteBuffer _bb, IWeaponExhibitConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A6AF RID: 173743 RVA: 0x005C9679 File Offset: 0x005C7879
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A6B0 RID: 173744 RVA: 0x005C9688 File Offset: 0x005C7888
		public IWeaponExhibitConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BA26 RID: 47654
		// (get) Token: 0x0602A6B1 RID: 173745 RVA: 0x005C9698 File Offset: 0x005C7898
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

		// Token: 0x1700BA27 RID: 47655
		// (get) Token: 0x0602A6B2 RID: 173746 RVA: 0x005C96D4 File Offset: 0x005C78D4
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

		// Token: 0x1700BA28 RID: 47656
		// (get) Token: 0x0602A6B3 RID: 173747 RVA: 0x005C9734 File Offset: 0x005C7934
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

		// Token: 0x0602A6B4 RID: 173748 RVA: 0x005C9791 File Offset: 0x005C7991
		public static Offset<IWeaponExhibitConfig> CreateIWeaponExhibitConfig(FlatBufferBuilder builder, EExhibitItemType Type = EExhibitItemType.Phantom, Offset<IVectorInfo> OffsetOffset = default(Offset<IVectorInfo>), Offset<IExhibitEffect> ActiveEffectOffset = default(Offset<IExhibitEffect>))
		{
			builder.StartTable(3);
			IWeaponExhibitConfig.AddActiveEffect(builder, ActiveEffectOffset);
			IWeaponExhibitConfig.AddOffset(builder, OffsetOffset);
			IWeaponExhibitConfig.AddType(builder, Type);
			return IWeaponExhibitConfig.EndIWeaponExhibitConfig(builder);
		}

		// Token: 0x0602A6B5 RID: 173749 RVA: 0x005C97B5 File Offset: 0x005C79B5
		public static void StartIWeaponExhibitConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602A6B6 RID: 173750 RVA: 0x005C97BE File Offset: 0x005C79BE
		public static void AddType(FlatBufferBuilder builder, EExhibitItemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602A6B7 RID: 173751 RVA: 0x005C97C9 File Offset: 0x005C79C9
		public static void AddOffset(FlatBufferBuilder builder, Offset<IVectorInfo> offsetOffset)
		{
			builder.AddOffset(1, offsetOffset.Value, 0);
		}

		// Token: 0x0602A6B8 RID: 173752 RVA: 0x005C97D9 File Offset: 0x005C79D9
		public static void AddActiveEffect(FlatBufferBuilder builder, Offset<IExhibitEffect> activeEffectOffset)
		{
			builder.AddOffset(2, activeEffectOffset.Value, 0);
		}

		// Token: 0x0602A6B9 RID: 173753 RVA: 0x005C97E9 File Offset: 0x005C79E9
		public static Offset<IWeaponExhibitConfig> EndIWeaponExhibitConfig(FlatBufferBuilder builder)
		{
			return new Offset<IWeaponExhibitConfig>(builder.EndTable());
		}

		// Token: 0x0602A6BA RID: 173754 RVA: 0x005C97F8 File Offset: 0x005C79F8
		public IWeaponExhibitConfigT UnPack()
		{
			IWeaponExhibitConfigT weaponExhibitConfigT = new IWeaponExhibitConfigT();
			this.UnPackTo(weaponExhibitConfigT);
			return weaponExhibitConfigT;
		}

		// Token: 0x0602A6BB RID: 173755 RVA: 0x005C9814 File Offset: 0x005C7A14
		public void UnPackTo(IWeaponExhibitConfigT _o)
		{
			_o.Type = this.Type;
			_o.Offset = ((this.Offset != null) ? this.Offset.Value.UnPack() : null);
			_o.ActiveEffect = ((this.ActiveEffect != null) ? this.ActiveEffect.Value.UnPack() : null);
		}

		// Token: 0x0602A6BC RID: 173756 RVA: 0x005C988C File Offset: 0x005C7A8C
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

		// Token: 0x0400FFC8 RID: 65480
		private Table __p;
	}
}
