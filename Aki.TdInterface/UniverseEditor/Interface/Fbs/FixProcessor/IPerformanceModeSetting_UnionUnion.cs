using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.FixProcessor
{
	// Token: 0x02004BD2 RID: 19410
	public class IPerformanceModeSetting_UnionUnion
	{
		// Token: 0x17008962 RID: 35170
		// (get) Token: 0x0601DA1E RID: 121374 RVA: 0x00428C05 File Offset: 0x00426E05
		// (set) Token: 0x0601DA1F RID: 121375 RVA: 0x00428C0D File Offset: 0x00426E0D
		public IPerformanceModeSetting_Union Type { get; set; }

		// Token: 0x17008963 RID: 35171
		// (get) Token: 0x0601DA20 RID: 121376 RVA: 0x00428C16 File Offset: 0x00426E16
		// (set) Token: 0x0601DA21 RID: 121377 RVA: 0x00428C1E File Offset: 0x00426E1E
		public object Value { get; set; }

		// Token: 0x0601DA22 RID: 121378 RVA: 0x00428C27 File Offset: 0x00426E27
		public IPerformanceModeSetting_UnionUnion()
		{
			this.Type = IPerformanceModeSetting_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601DA23 RID: 121379 RVA: 0x00428C3D File Offset: 0x00426E3D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601DA24 RID: 121380 RVA: 0x00428C4F File Offset: 0x00426E4F
		public IPerformanceModeSettingT AsIPerformanceModeSetting()
		{
			return this.As<IPerformanceModeSettingT>();
		}

		// Token: 0x0601DA25 RID: 121381 RVA: 0x00428C57 File Offset: 0x00426E57
		public static IPerformanceModeSetting_UnionUnion FromIPerformanceModeSetting(IPerformanceModeSettingT _iperformancemodesetting)
		{
			return new IPerformanceModeSetting_UnionUnion
			{
				Type = IPerformanceModeSetting_Union.IPerformanceModeSetting,
				Value = _iperformancemodesetting
			};
		}

		// Token: 0x0601DA26 RID: 121382 RVA: 0x00428C6C File Offset: 0x00426E6C
		public IHighPerformanceModeT AsIHighPerformanceMode()
		{
			return this.As<IHighPerformanceModeT>();
		}

		// Token: 0x0601DA27 RID: 121383 RVA: 0x00428C74 File Offset: 0x00426E74
		public static IPerformanceModeSetting_UnionUnion FromIHighPerformanceMode(IHighPerformanceModeT _ihighperformancemode)
		{
			return new IPerformanceModeSetting_UnionUnion
			{
				Type = IPerformanceModeSetting_Union.IHighPerformanceMode,
				Value = _ihighperformancemode
			};
		}

		// Token: 0x0601DA28 RID: 121384 RVA: 0x00428C8C File Offset: 0x00426E8C
		public static int Pack(FlatBufferBuilder builder, IPerformanceModeSetting_UnionUnion _o)
		{
			IPerformanceModeSetting_Union type = _o.Type;
			if (type == IPerformanceModeSetting_Union.IPerformanceModeSetting)
			{
				return IPerformanceModeSetting.Pack(builder, _o.AsIPerformanceModeSetting()).Value;
			}
			if (type != IPerformanceModeSetting_Union.IHighPerformanceMode)
			{
				return 0;
			}
			return IHighPerformanceMode.Pack(builder, _o.AsIHighPerformanceMode()).Value;
		}
	}
}
