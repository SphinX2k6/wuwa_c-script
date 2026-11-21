using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006235 RID: 25141
	public class TExhibitConfigUnion
	{
		// Token: 0x1700BB3A RID: 47930
		// (get) Token: 0x0602ACD5 RID: 175317 RVA: 0x005D883E File Offset: 0x005D6A3E
		// (set) Token: 0x0602ACD6 RID: 175318 RVA: 0x005D8846 File Offset: 0x005D6A46
		public TExhibitConfig Type { get; set; }

		// Token: 0x1700BB3B RID: 47931
		// (get) Token: 0x0602ACD7 RID: 175319 RVA: 0x005D884F File Offset: 0x005D6A4F
		// (set) Token: 0x0602ACD8 RID: 175320 RVA: 0x005D8857 File Offset: 0x005D6A57
		public object Value { get; set; }

		// Token: 0x0602ACD9 RID: 175321 RVA: 0x005D8860 File Offset: 0x005D6A60
		public TExhibitConfigUnion()
		{
			this.Type = TExhibitConfig.NONE;
			this.Value = null;
		}

		// Token: 0x0602ACDA RID: 175322 RVA: 0x005D8876 File Offset: 0x005D6A76
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602ACDB RID: 175323 RVA: 0x005D8888 File Offset: 0x005D6A88
		public IPhantomExhibitConfigT AsIPhantomExhibitConfig()
		{
			return this.As<IPhantomExhibitConfigT>();
		}

		// Token: 0x0602ACDC RID: 175324 RVA: 0x005D8890 File Offset: 0x005D6A90
		public static TExhibitConfigUnion FromIPhantomExhibitConfig(IPhantomExhibitConfigT _iphantomexhibitconfig)
		{
			return new TExhibitConfigUnion
			{
				Type = TExhibitConfig.IPhantomExhibitConfig,
				Value = _iphantomexhibitconfig
			};
		}

		// Token: 0x0602ACDD RID: 175325 RVA: 0x005D88A5 File Offset: 0x005D6AA5
		public IWeaponExhibitConfigT AsIWeaponExhibitConfig()
		{
			return this.As<IWeaponExhibitConfigT>();
		}

		// Token: 0x0602ACDE RID: 175326 RVA: 0x005D88AD File Offset: 0x005D6AAD
		public static TExhibitConfigUnion FromIWeaponExhibitConfig(IWeaponExhibitConfigT _iweaponexhibitconfig)
		{
			return new TExhibitConfigUnion
			{
				Type = TExhibitConfig.IWeaponExhibitConfig,
				Value = _iweaponexhibitconfig
			};
		}

		// Token: 0x0602ACDF RID: 175327 RVA: 0x005D88C4 File Offset: 0x005D6AC4
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
