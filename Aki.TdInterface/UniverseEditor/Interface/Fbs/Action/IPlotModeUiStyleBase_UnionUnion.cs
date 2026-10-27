using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D5A RID: 27994
	public class IPlotModeUiStyleBase_UnionUnion
	{
		// Token: 0x1700D0C2 RID: 53442
		// (get) Token: 0x060316D0 RID: 202448 RVA: 0x006B3A95 File Offset: 0x006B1C95
		// (set) Token: 0x060316D1 RID: 202449 RVA: 0x006B3A9D File Offset: 0x006B1C9D
		public IPlotModeUiStyleBase_Union Type { get; set; }

		// Token: 0x1700D0C3 RID: 53443
		// (get) Token: 0x060316D2 RID: 202450 RVA: 0x006B3AA6 File Offset: 0x006B1CA6
		// (set) Token: 0x060316D3 RID: 202451 RVA: 0x006B3AAE File Offset: 0x006B1CAE
		public object Value { get; set; }

		// Token: 0x060316D4 RID: 202452 RVA: 0x006B3AB7 File Offset: 0x006B1CB7
		public IPlotModeUiStyleBase_UnionUnion()
		{
			this.Type = IPlotModeUiStyleBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060316D5 RID: 202453 RVA: 0x006B3ACD File Offset: 0x006B1CCD
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060316D6 RID: 202454 RVA: 0x006B3ADF File Offset: 0x006B1CDF
		public IPlotModeUiStyleBaseT AsIPlotModeUiStyleBase()
		{
			return this.As<IPlotModeUiStyleBaseT>();
		}

		// Token: 0x060316D7 RID: 202455 RVA: 0x006B3AE7 File Offset: 0x006B1CE7
		public static IPlotModeUiStyleBase_UnionUnion FromIPlotModeUiStyleBase(IPlotModeUiStyleBaseT _iplotmodeuistylebase)
		{
			return new IPlotModeUiStyleBase_UnionUnion
			{
				Type = IPlotModeUiStyleBase_Union.IPlotModeUiStyleBase,
				Value = _iplotmodeuistylebase
			};
		}

		// Token: 0x060316D8 RID: 202456 RVA: 0x006B3AFC File Offset: 0x006B1CFC
		public IPlotModeUiStyleLevelDT AsIPlotModeUiStyleLevelD()
		{
			return this.As<IPlotModeUiStyleLevelDT>();
		}

		// Token: 0x060316D9 RID: 202457 RVA: 0x006B3B04 File Offset: 0x006B1D04
		public static IPlotModeUiStyleBase_UnionUnion FromIPlotModeUiStyleLevelD(IPlotModeUiStyleLevelDT _iplotmodeuistyleleveld)
		{
			return new IPlotModeUiStyleBase_UnionUnion
			{
				Type = IPlotModeUiStyleBase_Union.IPlotModeUiStyleLevelD,
				Value = _iplotmodeuistyleleveld
			};
		}

		// Token: 0x060316DA RID: 202458 RVA: 0x006B3B1C File Offset: 0x006B1D1C
		public static int Pack(FlatBufferBuilder builder, IPlotModeUiStyleBase_UnionUnion _o)
		{
			IPlotModeUiStyleBase_Union type = _o.Type;
			if (type == IPlotModeUiStyleBase_Union.IPlotModeUiStyleBase)
			{
				return IPlotModeUiStyleBase.Pack(builder, _o.AsIPlotModeUiStyleBase()).Value;
			}
			if (type != IPlotModeUiStyleBase_Union.IPlotModeUiStyleLevelD)
			{
				return 0;
			}
			return IPlotModeUiStyleLevelD.Pack(builder, _o.AsIPlotModeUiStyleLevelD()).Value;
		}
	}
}
