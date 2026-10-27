using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200504F RID: 20559
	public class ICurveControlConfig_UnionUnion
	{
		// Token: 0x1700952C RID: 38188
		// (get) Token: 0x06020F1B RID: 134939 RVA: 0x004945F9 File Offset: 0x004927F9
		// (set) Token: 0x06020F1C RID: 134940 RVA: 0x00494601 File Offset: 0x00492801
		public ICurveControlConfig_Union Type { get; set; }

		// Token: 0x1700952D RID: 38189
		// (get) Token: 0x06020F1D RID: 134941 RVA: 0x0049460A File Offset: 0x0049280A
		// (set) Token: 0x06020F1E RID: 134942 RVA: 0x00494612 File Offset: 0x00492812
		public object Value { get; set; }

		// Token: 0x06020F1F RID: 134943 RVA: 0x0049461B File Offset: 0x0049281B
		public ICurveControlConfig_UnionUnion()
		{
			this.Type = ICurveControlConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06020F20 RID: 134944 RVA: 0x00494631 File Offset: 0x00492831
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06020F21 RID: 134945 RVA: 0x00494643 File Offset: 0x00492843
		public ICurveControlConfigT AsICurveControlConfig()
		{
			return this.As<ICurveControlConfigT>();
		}

		// Token: 0x06020F22 RID: 134946 RVA: 0x0049464B File Offset: 0x0049284B
		public static ICurveControlConfig_UnionUnion FromICurveControlConfig(ICurveControlConfigT _icurvecontrolconfig)
		{
			return new ICurveControlConfig_UnionUnion
			{
				Type = ICurveControlConfig_Union.ICurveControlConfig,
				Value = _icurvecontrolconfig
			};
		}

		// Token: 0x06020F23 RID: 134947 RVA: 0x00494660 File Offset: 0x00492860
		public IChargeSlashControlT AsIChargeSlashControl()
		{
			return this.As<IChargeSlashControlT>();
		}

		// Token: 0x06020F24 RID: 134948 RVA: 0x00494668 File Offset: 0x00492868
		public static ICurveControlConfig_UnionUnion FromIChargeSlashControl(IChargeSlashControlT _ichargeslashcontrol)
		{
			return new ICurveControlConfig_UnionUnion
			{
				Type = ICurveControlConfig_Union.IChargeSlashControl,
				Value = _ichargeslashcontrol
			};
		}

		// Token: 0x06020F25 RID: 134949 RVA: 0x00494680 File Offset: 0x00492880
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
