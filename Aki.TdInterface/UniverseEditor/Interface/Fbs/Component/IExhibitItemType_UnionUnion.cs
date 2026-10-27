using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020051D8 RID: 20952
	public class IExhibitItemType_UnionUnion
	{
		// Token: 0x17009955 RID: 39253
		// (get) Token: 0x06021F96 RID: 139158 RVA: 0x004B67F1 File Offset: 0x004B49F1
		// (set) Token: 0x06021F97 RID: 139159 RVA: 0x004B67F9 File Offset: 0x004B49F9
		public IExhibitItemType_Union Type { get; set; }

		// Token: 0x17009956 RID: 39254
		// (get) Token: 0x06021F98 RID: 139160 RVA: 0x004B6802 File Offset: 0x004B4A02
		// (set) Token: 0x06021F99 RID: 139161 RVA: 0x004B680A File Offset: 0x004B4A0A
		public object Value { get; set; }

		// Token: 0x06021F9A RID: 139162 RVA: 0x004B6813 File Offset: 0x004B4A13
		public IExhibitItemType_UnionUnion()
		{
			this.Type = IExhibitItemType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06021F9B RID: 139163 RVA: 0x004B6829 File Offset: 0x004B4A29
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06021F9C RID: 139164 RVA: 0x004B683B File Offset: 0x004B4A3B
		public IExhibitItemTypeT AsIExhibitItemType()
		{
			return this.As<IExhibitItemTypeT>();
		}

		// Token: 0x06021F9D RID: 139165 RVA: 0x004B6843 File Offset: 0x004B4A43
		public static IExhibitItemType_UnionUnion FromIExhibitItemType(IExhibitItemTypeT _iexhibititemtype)
		{
			return new IExhibitItemType_UnionUnion
			{
				Type = IExhibitItemType_Union.IExhibitItemType,
				Value = _iexhibititemtype
			};
		}

		// Token: 0x06021F9E RID: 139166 RVA: 0x004B6858 File Offset: 0x004B4A58
		public IPhantomExhibitConfigT AsIPhantomExhibitConfig()
		{
			return this.As<IPhantomExhibitConfigT>();
		}

		// Token: 0x06021F9F RID: 139167 RVA: 0x004B6860 File Offset: 0x004B4A60
		public static IExhibitItemType_UnionUnion FromIPhantomExhibitConfig(IPhantomExhibitConfigT _iphantomexhibitconfig)
		{
			return new IExhibitItemType_UnionUnion
			{
				Type = IExhibitItemType_Union.IPhantomExhibitConfig,
				Value = _iphantomexhibitconfig
			};
		}

		// Token: 0x06021FA0 RID: 139168 RVA: 0x004B6875 File Offset: 0x004B4A75
		public IWeaponExhibitConfigT AsIWeaponExhibitConfig()
		{
			return this.As<IWeaponExhibitConfigT>();
		}

		// Token: 0x06021FA1 RID: 139169 RVA: 0x004B687D File Offset: 0x004B4A7D
		public static IExhibitItemType_UnionUnion FromIWeaponExhibitConfig(IWeaponExhibitConfigT _iweaponexhibitconfig)
		{
			return new IExhibitItemType_UnionUnion
			{
				Type = IExhibitItemType_Union.IWeaponExhibitConfig,
				Value = _iweaponexhibitconfig
			};
		}

		// Token: 0x06021FA2 RID: 139170 RVA: 0x004B6894 File Offset: 0x004B4A94
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
