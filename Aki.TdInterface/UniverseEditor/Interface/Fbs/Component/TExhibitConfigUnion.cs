using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C16 RID: 23574
	public class TExhibitConfigUnion
	{
		// Token: 0x1700B1EC RID: 45548
		// (get) Token: 0x060286E5 RID: 165605 RVA: 0x005908F6 File Offset: 0x0058EAF6
		// (set) Token: 0x060286E6 RID: 165606 RVA: 0x005908FE File Offset: 0x0058EAFE
		public TExhibitConfig Type { get; set; }

		// Token: 0x1700B1ED RID: 45549
		// (get) Token: 0x060286E7 RID: 165607 RVA: 0x00590907 File Offset: 0x0058EB07
		// (set) Token: 0x060286E8 RID: 165608 RVA: 0x0059090F File Offset: 0x0058EB0F
		public object Value { get; set; }

		// Token: 0x060286E9 RID: 165609 RVA: 0x00590918 File Offset: 0x0058EB18
		public TExhibitConfigUnion()
		{
			this.Type = TExhibitConfig.NONE;
			this.Value = null;
		}

		// Token: 0x060286EA RID: 165610 RVA: 0x0059092E File Offset: 0x0058EB2E
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060286EB RID: 165611 RVA: 0x00590940 File Offset: 0x0058EB40
		public IPhantomExhibitConfigT AsIPhantomExhibitConfig()
		{
			return this.As<IPhantomExhibitConfigT>();
		}

		// Token: 0x060286EC RID: 165612 RVA: 0x00590948 File Offset: 0x0058EB48
		public static TExhibitConfigUnion FromIPhantomExhibitConfig(IPhantomExhibitConfigT _iphantomexhibitconfig)
		{
			return new TExhibitConfigUnion
			{
				Type = TExhibitConfig.IPhantomExhibitConfig,
				Value = _iphantomexhibitconfig
			};
		}

		// Token: 0x060286ED RID: 165613 RVA: 0x0059095D File Offset: 0x0058EB5D
		public IWeaponExhibitConfigT AsIWeaponExhibitConfig()
		{
			return this.As<IWeaponExhibitConfigT>();
		}

		// Token: 0x060286EE RID: 165614 RVA: 0x00590965 File Offset: 0x0058EB65
		public static TExhibitConfigUnion FromIWeaponExhibitConfig(IWeaponExhibitConfigT _iweaponexhibitconfig)
		{
			return new TExhibitConfigUnion
			{
				Type = TExhibitConfig.IWeaponExhibitConfig,
				Value = _iweaponexhibitconfig
			};
		}

		// Token: 0x060286EF RID: 165615 RVA: 0x0059097C File Offset: 0x0058EB7C
		public static int Pack(FlatBufferBuilder builder, TExhibitConfigUnion _o)
		{
			TExhibitConfig type = _o.Type;
			if (type == TExhibitConfig.IPhantomExhibitConfig)
			{
				return IPhantomExhibitConfig.Pack(builder, _o.AsIPhantomExhibitConfig()).Value;
			}
			if (type != TExhibitConfig.IWeaponExhibitConfig)
			{
				return 0;
			}
			return IWeaponExhibitConfig.Pack(builder, _o.AsIWeaponExhibitConfig()).Value;
		}
	}
}
