using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074D5 RID: 29909
	public class IPlotModeUiStyleBase_UnionUnion
	{
		// Token: 0x1700DC0A RID: 56330
		// (get) Token: 0x060346CC RID: 214732 RVA: 0x0070F17D File Offset: 0x0070D37D
		// (set) Token: 0x060346CD RID: 214733 RVA: 0x0070F185 File Offset: 0x0070D385
		public IPlotModeUiStyleBase_Union Type { get; set; }

		// Token: 0x1700DC0B RID: 56331
		// (get) Token: 0x060346CE RID: 214734 RVA: 0x0070F18E File Offset: 0x0070D38E
		// (set) Token: 0x060346CF RID: 214735 RVA: 0x0070F196 File Offset: 0x0070D396
		public object Value { get; set; }

		// Token: 0x060346D0 RID: 214736 RVA: 0x0070F19F File Offset: 0x0070D39F
		public IPlotModeUiStyleBase_UnionUnion()
		{
			this.Type = IPlotModeUiStyleBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060346D1 RID: 214737 RVA: 0x0070F1B5 File Offset: 0x0070D3B5
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060346D2 RID: 214738 RVA: 0x0070F1C7 File Offset: 0x0070D3C7
		public IPlotModeUiStyleBaseT AsIPlotModeUiStyleBase()
		{
			return this.As<IPlotModeUiStyleBaseT>();
		}

		// Token: 0x060346D3 RID: 214739 RVA: 0x0070F1CF File Offset: 0x0070D3CF
		public static IPlotModeUiStyleBase_UnionUnion FromIPlotModeUiStyleBase(IPlotModeUiStyleBaseT _iplotmodeuistylebase)
		{
			return new IPlotModeUiStyleBase_UnionUnion
			{
				Type = IPlotModeUiStyleBase_Union.IPlotModeUiStyleBase,
				Value = _iplotmodeuistylebase
			};
		}

		// Token: 0x060346D4 RID: 214740 RVA: 0x0070F1E4 File Offset: 0x0070D3E4
		public IPlotModeUiStyleLevelDT AsIPlotModeUiStyleLevelD()
		{
			return this.As<IPlotModeUiStyleLevelDT>();
		}

		// Token: 0x060346D5 RID: 214741 RVA: 0x0070F1EC File Offset: 0x0070D3EC
		public static IPlotModeUiStyleBase_UnionUnion FromIPlotModeUiStyleLevelD(IPlotModeUiStyleLevelDT _iplotmodeuistyleleveld)
		{
			return new IPlotModeUiStyleBase_UnionUnion
			{
				Type = IPlotModeUiStyleBase_Union.IPlotModeUiStyleLevelD,
				Value = _iplotmodeuistyleleveld
			};
		}

		// Token: 0x060346D6 RID: 214742 RVA: 0x0070F204 File Offset: 0x0070D404
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
