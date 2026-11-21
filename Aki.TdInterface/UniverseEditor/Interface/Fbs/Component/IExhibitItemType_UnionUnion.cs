using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200573D RID: 22333
	public class IExhibitItemType_UnionUnion
	{
		// Token: 0x1700A144 RID: 41284
		// (get) Token: 0x06023EEE RID: 147182 RVA: 0x004F0859 File Offset: 0x004EEA59
		// (set) Token: 0x06023EEF RID: 147183 RVA: 0x004F0861 File Offset: 0x004EEA61
		public IExhibitItemType_Union Type { get; set; }

		// Token: 0x1700A145 RID: 41285
		// (get) Token: 0x06023EF0 RID: 147184 RVA: 0x004F086A File Offset: 0x004EEA6A
		// (set) Token: 0x06023EF1 RID: 147185 RVA: 0x004F0872 File Offset: 0x004EEA72
		public object Value { get; set; }

		// Token: 0x06023EF2 RID: 147186 RVA: 0x004F087B File Offset: 0x004EEA7B
		public IExhibitItemType_UnionUnion()
		{
			this.Type = IExhibitItemType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06023EF3 RID: 147187 RVA: 0x004F0891 File Offset: 0x004EEA91
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06023EF4 RID: 147188 RVA: 0x004F08A3 File Offset: 0x004EEAA3
		public IExhibitItemTypeT AsIExhibitItemType()
		{
			return this.As<IExhibitItemTypeT>();
		}

		// Token: 0x06023EF5 RID: 147189 RVA: 0x004F08AB File Offset: 0x004EEAAB
		public static IExhibitItemType_UnionUnion FromIExhibitItemType(IExhibitItemTypeT _iexhibititemtype)
		{
			return new IExhibitItemType_UnionUnion
			{
				Type = IExhibitItemType_Union.IExhibitItemType,
				Value = _iexhibititemtype
			};
		}

		// Token: 0x06023EF6 RID: 147190 RVA: 0x004F08C0 File Offset: 0x004EEAC0
		public IPhantomExhibitConfigT AsIPhantomExhibitConfig()
		{
			return this.As<IPhantomExhibitConfigT>();
		}

		// Token: 0x06023EF7 RID: 147191 RVA: 0x004F08C8 File Offset: 0x004EEAC8
		public static IExhibitItemType_UnionUnion FromIPhantomExhibitConfig(IPhantomExhibitConfigT _iphantomexhibitconfig)
		{
			return new IExhibitItemType_UnionUnion
			{
				Type = IExhibitItemType_Union.IPhantomExhibitConfig,
				Value = _iphantomexhibitconfig
			};
		}

		// Token: 0x06023EF8 RID: 147192 RVA: 0x004F08DD File Offset: 0x004EEADD
		public IWeaponExhibitConfigT AsIWeaponExhibitConfig()
		{
			return this.As<IWeaponExhibitConfigT>();
		}

		// Token: 0x06023EF9 RID: 147193 RVA: 0x004F08E5 File Offset: 0x004EEAE5
		public static IExhibitItemType_UnionUnion FromIWeaponExhibitConfig(IWeaponExhibitConfigT _iweaponexhibitconfig)
		{
			return new IExhibitItemType_UnionUnion
			{
				Type = IExhibitItemType_Union.IWeaponExhibitConfig,
				Value = _iweaponexhibitconfig
			};
		}

		// Token: 0x06023EFA RID: 147194 RVA: 0x004F08FC File Offset: 0x004EEAFC
		public static int Pack(FlatBufferBuilder builder, IExhibitItemType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IExhibitItemType_Union.IExhibitItemType:
				return IExhibitItemType.Pack(builder, _o.AsIExhibitItemType()).Value;
			case IExhibitItemType_Union.IPhantomExhibitConfig:
				return IPhantomExhibitConfig.Pack(builder, _o.AsIPhantomExhibitConfig()).Value;
			case IExhibitItemType_Union.IWeaponExhibitConfig:
				return IWeaponExhibitConfig.Pack(builder, _o.AsIWeaponExhibitConfig()).Value;
			default:
				return 0;
			}
		}
	}
}
