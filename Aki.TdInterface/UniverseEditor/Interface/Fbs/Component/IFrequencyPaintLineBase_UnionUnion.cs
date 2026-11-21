using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005854 RID: 22612
	public class IFrequencyPaintLineBase_UnionUnion
	{
		// Token: 0x1700A3C6 RID: 41926
		// (get) Token: 0x06024A23 RID: 150051 RVA: 0x005087BD File Offset: 0x005069BD
		// (set) Token: 0x06024A24 RID: 150052 RVA: 0x005087C5 File Offset: 0x005069C5
		public IFrequencyPaintLineBase_Union Type { get; set; }

		// Token: 0x1700A3C7 RID: 41927
		// (get) Token: 0x06024A25 RID: 150053 RVA: 0x005087CE File Offset: 0x005069CE
		// (set) Token: 0x06024A26 RID: 150054 RVA: 0x005087D6 File Offset: 0x005069D6
		public object Value { get; set; }

		// Token: 0x06024A27 RID: 150055 RVA: 0x005087DF File Offset: 0x005069DF
		public IFrequencyPaintLineBase_UnionUnion()
		{
			this.Type = IFrequencyPaintLineBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06024A28 RID: 150056 RVA: 0x005087F5 File Offset: 0x005069F5
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06024A29 RID: 150057 RVA: 0x00508807 File Offset: 0x00506A07
		public IFrequencyPaintLineBaseT AsIFrequencyPaintLineBase()
		{
			return this.As<IFrequencyPaintLineBaseT>();
		}

		// Token: 0x06024A2A RID: 150058 RVA: 0x0050880F File Offset: 0x00506A0F
		public static IFrequencyPaintLineBase_UnionUnion FromIFrequencyPaintLineBase(IFrequencyPaintLineBaseT _ifrequencypaintlinebase)
		{
			return new IFrequencyPaintLineBase_UnionUnion
			{
				Type = IFrequencyPaintLineBase_Union.IFrequencyPaintLineBase,
				Value = _ifrequencypaintlinebase
			};
		}

		// Token: 0x06024A2B RID: 150059 RVA: 0x00508824 File Offset: 0x00506A24
		public IFrequencyPaintStraightLineT AsIFrequencyPaintStraightLine()
		{
			return this.As<IFrequencyPaintStraightLineT>();
		}

		// Token: 0x06024A2C RID: 150060 RVA: 0x0050882C File Offset: 0x00506A2C
		public static IFrequencyPaintLineBase_UnionUnion FromIFrequencyPaintStraightLine(IFrequencyPaintStraightLineT _ifrequencypaintstraightline)
		{
			return new IFrequencyPaintLineBase_UnionUnion
			{
				Type = IFrequencyPaintLineBase_Union.IFrequencyPaintStraightLine,
				Value = _ifrequencypaintstraightline
			};
		}

		// Token: 0x06024A2D RID: 150061 RVA: 0x00508841 File Offset: 0x00506A41
		public IFrequencyPaintConnectLineT AsIFrequencyPaintConnectLine()
		{
			return this.As<IFrequencyPaintConnectLineT>();
		}

		// Token: 0x06024A2E RID: 150062 RVA: 0x00508849 File Offset: 0x00506A49
		public static IFrequencyPaintLineBase_UnionUnion FromIFrequencyPaintConnectLine(IFrequencyPaintConnectLineT _ifrequencypaintconnectline)
		{
			return new IFrequencyPaintLineBase_UnionUnion
			{
				Type = IFrequencyPaintLineBase_Union.IFrequencyPaintConnectLine,
				Value = _ifrequencypaintconnectline
			};
		}

		// Token: 0x06024A2F RID: 150063 RVA: 0x0050885E File Offset: 0x00506A5E
		public IFrequencyPaintEncloseLineT AsIFrequencyPaintEncloseLine()
		{
			return this.As<IFrequencyPaintEncloseLineT>();
		}

		// Token: 0x06024A30 RID: 150064 RVA: 0x00508866 File Offset: 0x00506A66
		public static IFrequencyPaintLineBase_UnionUnion FromIFrequencyPaintEncloseLine(IFrequencyPaintEncloseLineT _ifrequencypaintencloseline)
		{
			return new IFrequencyPaintLineBase_UnionUnion
			{
				Type = IFrequencyPaintLineBase_Union.IFrequencyPaintEncloseLine,
				Value = _ifrequencypaintencloseline
			};
		}

		// Token: 0x06024A31 RID: 150065 RVA: 0x0050887B File Offset: 0x00506A7B
		public IFrequencyPaintStrokeLineT AsIFrequencyPaintStrokeLine()
		{
			return this.As<IFrequencyPaintStrokeLineT>();
		}

		// Token: 0x06024A32 RID: 150066 RVA: 0x00508883 File Offset: 0x00506A83
		public static IFrequencyPaintLineBase_UnionUnion FromIFrequencyPaintStrokeLine(IFrequencyPaintStrokeLineT _ifrequencypaintstrokeline)
		{
			return new IFrequencyPaintLineBase_UnionUnion
			{
				Type = IFrequencyPaintLineBase_Union.IFrequencyPaintStrokeLine,
				Value = _ifrequencypaintstrokeline
			};
		}

		// Token: 0x06024A33 RID: 150067 RVA: 0x00508898 File Offset: 0x00506A98
		public static int Pack(FlatBufferBuilder builder, IFrequencyPaintLineBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IFrequencyPaintLineBase_Union.IFrequencyPaintLineBase:
				return IFrequencyPaintLineBase.Pack(builder, _o.AsIFrequencyPaintLineBase()).Value;
			case IFrequencyPaintLineBase_Union.IFrequencyPaintStraightLine:
				return IFrequencyPaintStraightLine.Pack(builder, _o.AsIFrequencyPaintStraightLine()).Value;
			case IFrequencyPaintLineBase_Union.IFrequencyPaintConnectLine:
				return IFrequencyPaintConnectLine.Pack(builder, _o.AsIFrequencyPaintConnectLine()).Value;
			case IFrequencyPaintLineBase_Union.IFrequencyPaintEncloseLine:
				return IFrequencyPaintEncloseLine.Pack(builder, _o.AsIFrequencyPaintEncloseLine()).Value;
			case IFrequencyPaintLineBase_Union.IFrequencyPaintStrokeLine:
				return IFrequencyPaintStrokeLine.Pack(builder, _o.AsIFrequencyPaintStrokeLine()).Value;
			default:
				return 0;
			}
		}
	}
}
