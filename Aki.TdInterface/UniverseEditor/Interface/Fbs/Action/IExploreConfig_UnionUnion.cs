using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006742 RID: 26434
	public class IExploreConfig_UnionUnion
	{
		// Token: 0x1700C441 RID: 50241
		// (get) Token: 0x0602DFA1 RID: 188321 RVA: 0x00648B15 File Offset: 0x00646D15
		// (set) Token: 0x0602DFA2 RID: 188322 RVA: 0x00648B1D File Offset: 0x00646D1D
		public IExploreConfig_Union Type { get; set; }

		// Token: 0x1700C442 RID: 50242
		// (get) Token: 0x0602DFA3 RID: 188323 RVA: 0x00648B26 File Offset: 0x00646D26
		// (set) Token: 0x0602DFA4 RID: 188324 RVA: 0x00648B2E File Offset: 0x00646D2E
		public object Value { get; set; }

		// Token: 0x0602DFA5 RID: 188325 RVA: 0x00648B37 File Offset: 0x00646D37
		public IExploreConfig_UnionUnion()
		{
			this.Type = IExploreConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602DFA6 RID: 188326 RVA: 0x00648B4D File Offset: 0x00646D4D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602DFA7 RID: 188327 RVA: 0x00648B5F File Offset: 0x00646D5F
		public IExploreConfigT AsIExploreConfig()
		{
			return this.As<IExploreConfigT>();
		}

		// Token: 0x0602DFA8 RID: 188328 RVA: 0x00648B67 File Offset: 0x00646D67
		public static IExploreConfig_UnionUnion FromIExploreConfig(IExploreConfigT _iexploreconfig)
		{
			return new IExploreConfig_UnionUnion
			{
				Type = IExploreConfig_Union.IExploreConfig,
				Value = _iexploreconfig
			};
		}

		// Token: 0x0602DFA9 RID: 188329 RVA: 0x00648B7C File Offset: 0x00646D7C
		public ITeleControlConfigT AsITeleControlConfig()
		{
			return this.As<ITeleControlConfigT>();
		}

		// Token: 0x0602DFAA RID: 188330 RVA: 0x00648B84 File Offset: 0x00646D84
		public static IExploreConfig_UnionUnion FromITeleControlConfig(ITeleControlConfigT _itelecontrolconfig)
		{
			return new IExploreConfig_UnionUnion
			{
				Type = IExploreConfig_Union.ITeleControlConfig,
				Value = _itelecontrolconfig
			};
		}

		// Token: 0x0602DFAB RID: 188331 RVA: 0x00648B9C File Offset: 0x00646D9C
		public static int Pack(FlatBufferBuilder builder, IExploreConfig_UnionUnion _o)
		{
			IExploreConfig_Union type = _o.Type;
			if (type == IExploreConfig_Union.IExploreConfig)
			{
				return IExploreConfig.Pack(builder, _o.AsIExploreConfig()).Value;
			}
			if (type != IExploreConfig_Union.ITeleControlConfig)
			{
				return 0;
			}
			return ITeleControlConfig.Pack(builder, _o.AsITeleControlConfig()).Value;
		}
	}
}
