using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055B1 RID: 21937
	public class ICurveControlConfig_UnionUnion
	{
		// Token: 0x17009D12 RID: 40210
		// (get) Token: 0x06022E55 RID: 142933 RVA: 0x004CE2AD File Offset: 0x004CC4AD
		// (set) Token: 0x06022E56 RID: 142934 RVA: 0x004CE2B5 File Offset: 0x004CC4B5
		public ICurveControlConfig_Union Type { get; set; }

		// Token: 0x17009D13 RID: 40211
		// (get) Token: 0x06022E57 RID: 142935 RVA: 0x004CE2BE File Offset: 0x004CC4BE
		// (set) Token: 0x06022E58 RID: 142936 RVA: 0x004CE2C6 File Offset: 0x004CC4C6
		public object Value { get; set; }

		// Token: 0x06022E59 RID: 142937 RVA: 0x004CE2CF File Offset: 0x004CC4CF
		public ICurveControlConfig_UnionUnion()
		{
			this.Type = ICurveControlConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06022E5A RID: 142938 RVA: 0x004CE2E5 File Offset: 0x004CC4E5
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06022E5B RID: 142939 RVA: 0x004CE2F7 File Offset: 0x004CC4F7
		public ICurveControlConfigT AsICurveControlConfig()
		{
			return this.As<ICurveControlConfigT>();
		}

		// Token: 0x06022E5C RID: 142940 RVA: 0x004CE2FF File Offset: 0x004CC4FF
		public static ICurveControlConfig_UnionUnion FromICurveControlConfig(ICurveControlConfigT _icurvecontrolconfig)
		{
			return new ICurveControlConfig_UnionUnion
			{
				Type = ICurveControlConfig_Union.ICurveControlConfig,
				Value = _icurvecontrolconfig
			};
		}

		// Token: 0x06022E5D RID: 142941 RVA: 0x004CE314 File Offset: 0x004CC514
		public IChargeSlashControlT AsIChargeSlashControl()
		{
			return this.As<IChargeSlashControlT>();
		}

		// Token: 0x06022E5E RID: 142942 RVA: 0x004CE31C File Offset: 0x004CC51C
		public static ICurveControlConfig_UnionUnion FromIChargeSlashControl(IChargeSlashControlT _ichargeslashcontrol)
		{
			return new ICurveControlConfig_UnionUnion
			{
				Type = ICurveControlConfig_Union.IChargeSlashControl,
				Value = _ichargeslashcontrol
			};
		}

		// Token: 0x06022E5F RID: 142943 RVA: 0x004CE334 File Offset: 0x004CC534
		public static int Pack(FlatBufferBuilder builder, ICurveControlConfig_UnionUnion _o)
		{
			ICurveControlConfig_Union type = _o.Type;
			if (type == ICurveControlConfig_Union.ICurveControlConfig)
			{
				return ICurveControlConfig.Pack(builder, _o.AsICurveControlConfig()).Value;
			}
			if (type != ICurveControlConfig_Union.IChargeSlashControl)
			{
				return 0;
			}
			return IChargeSlashControl.Pack(builder, _o.AsIChargeSlashControl()).Value;
		}
	}
}
