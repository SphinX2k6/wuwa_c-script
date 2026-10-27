using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.FixProcessor
{
	// Token: 0x0200476A RID: 18282
	public class IPerformanceModeSetting_UnionUnion
	{
		// Token: 0x17008321 RID: 33569
		// (get) Token: 0x0601C249 RID: 115273 RVA: 0x003FC969 File Offset: 0x003FAB69
		// (set) Token: 0x0601C24A RID: 115274 RVA: 0x003FC971 File Offset: 0x003FAB71
		public IPerformanceModeSetting_Union Type { get; set; }

		// Token: 0x17008322 RID: 33570
		// (get) Token: 0x0601C24B RID: 115275 RVA: 0x003FC97A File Offset: 0x003FAB7A
		// (set) Token: 0x0601C24C RID: 115276 RVA: 0x003FC982 File Offset: 0x003FAB82
		public object Value { get; set; }

		// Token: 0x0601C24D RID: 115277 RVA: 0x003FC98B File Offset: 0x003FAB8B
		public IPerformanceModeSetting_UnionUnion()
		{
			this.Type = IPerformanceModeSetting_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601C24E RID: 115278 RVA: 0x003FC9A1 File Offset: 0x003FABA1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601C24F RID: 115279 RVA: 0x003FC9B3 File Offset: 0x003FABB3
		public IPerformanceModeSettingT AsIPerformanceModeSetting()
		{
			return this.As<IPerformanceModeSettingT>();
		}

		// Token: 0x0601C250 RID: 115280 RVA: 0x003FC9BB File Offset: 0x003FABBB
		public static IPerformanceModeSetting_UnionUnion FromIPerformanceModeSetting(IPerformanceModeSettingT _iperformancemodesetting)
		{
			return new IPerformanceModeSetting_UnionUnion
			{
				Type = IPerformanceModeSetting_Union.IPerformanceModeSetting,
				Value = _iperformancemodesetting
			};
		}

		// Token: 0x0601C251 RID: 115281 RVA: 0x003FC9D0 File Offset: 0x003FABD0
		public IHighPerformanceModeT AsIHighPerformanceMode()
		{
			return this.As<IHighPerformanceModeT>();
		}

		// Token: 0x0601C252 RID: 115282 RVA: 0x003FC9D8 File Offset: 0x003FABD8
		public static IPerformanceModeSetting_UnionUnion FromIHighPerformanceMode(IHighPerformanceModeT _ihighperformancemode)
		{
			return new IPerformanceModeSetting_UnionUnion
			{
				Type = IPerformanceModeSetting_Union.IHighPerformanceMode,
				Value = _ihighperformancemode
			};
		}

		// Token: 0x0601C253 RID: 115283 RVA: 0x003FC9F0 File Offset: 0x003FABF0
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
