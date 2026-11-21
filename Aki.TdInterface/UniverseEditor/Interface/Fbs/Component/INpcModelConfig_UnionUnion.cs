using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BCB RID: 23499
	public class INpcModelConfig_UnionUnion
	{
		// Token: 0x1700ABCC RID: 43980
		// (get) Token: 0x06026C1C RID: 158748 RVA: 0x0054DFED File Offset: 0x0054C1ED
		// (set) Token: 0x06026C1D RID: 158749 RVA: 0x0054DFF5 File Offset: 0x0054C1F5
		public INpcModelConfig_Union Type { get; set; }

		// Token: 0x1700ABCD RID: 43981
		// (get) Token: 0x06026C1E RID: 158750 RVA: 0x0054DFFE File Offset: 0x0054C1FE
		// (set) Token: 0x06026C1F RID: 158751 RVA: 0x0054E006 File Offset: 0x0054C206
		public object Value { get; set; }

		// Token: 0x06026C20 RID: 158752 RVA: 0x0054E00F File Offset: 0x0054C20F
		public INpcModelConfig_UnionUnion()
		{
			this.Type = INpcModelConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06026C21 RID: 158753 RVA: 0x0054E025 File Offset: 0x0054C225
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06026C22 RID: 158754 RVA: 0x0054E037 File Offset: 0x0054C237
		public INpcModelConfigT AsINpcModelConfig()
		{
			return this.As<INpcModelConfigT>();
		}

		// Token: 0x06026C23 RID: 158755 RVA: 0x0054E03F File Offset: 0x0054C23F
		public static INpcModelConfig_UnionUnion FromINpcModelConfig(INpcModelConfigT _inpcmodelconfig)
		{
			return new INpcModelConfig_UnionUnion
			{
				Type = INpcModelConfig_Union.INpcModelConfig,
				Value = _inpcmodelconfig
			};
		}

		// Token: 0x06026C24 RID: 158756 RVA: 0x0054E054 File Offset: 0x0054C254
		public IMeshNpcModelT AsIMeshNpcModel()
		{
			return this.As<IMeshNpcModelT>();
		}

		// Token: 0x06026C25 RID: 158757 RVA: 0x0054E05C File Offset: 0x0054C25C
		public static INpcModelConfig_UnionUnion FromIMeshNpcModel(IMeshNpcModelT _imeshnpcmodel)
		{
			return new INpcModelConfig_UnionUnion
			{
				Type = INpcModelConfig_Union.IMeshNpcModel,
				Value = _imeshnpcmodel
			};
		}

		// Token: 0x06026C26 RID: 158758 RVA: 0x0054E071 File Offset: 0x0054C271
		public IDaNpcModelT AsIDaNpcModel()
		{
			return this.As<IDaNpcModelT>();
		}

		// Token: 0x06026C27 RID: 158759 RVA: 0x0054E079 File Offset: 0x0054C279
		public static INpcModelConfig_UnionUnion FromIDaNpcModel(IDaNpcModelT _idanpcmodel)
		{
			return new INpcModelConfig_UnionUnion
			{
				Type = INpcModelConfig_Union.IDaNpcModel,
				Value = _idanpcmodel
			};
		}

		// Token: 0x06026C28 RID: 158760 RVA: 0x0054E08E File Offset: 0x0054C28E
		public ICombineDaNpcModelT AsICombineDaNpcModel()
		{
			return this.As<ICombineDaNpcModelT>();
		}

		// Token: 0x06026C29 RID: 158761 RVA: 0x0054E096 File Offset: 0x0054C296
		public static INpcModelConfig_UnionUnion FromICombineDaNpcModel(ICombineDaNpcModelT _icombinedanpcmodel)
		{
			return new INpcModelConfig_UnionUnion
			{
				Type = INpcModelConfig_Union.ICombineDaNpcModel,
				Value = _icombinedanpcmodel
			};
		}

		// Token: 0x06026C2A RID: 158762 RVA: 0x0054E0AC File Offset: 0x0054C2AC
		public static int Pack(FlatBufferBuilder builder, INpcModelConfig_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case INpcModelConfig_Union.INpcModelConfig:
				return INpcModelConfig.Pack(builder, _o.AsINpcModelConfig()).Value;
			case INpcModelConfig_Union.IMeshNpcModel:
				return IMeshNpcModel.Pack(builder, _o.AsIMeshNpcModel()).Value;
			case INpcModelConfig_Union.IDaNpcModel:
				return IDaNpcModel.Pack(builder, _o.AsIDaNpcModel()).Value;
			case INpcModelConfig_Union.ICombineDaNpcModel:
				return ICombineDaNpcModel.Pack(builder, _o.AsICombineDaNpcModel()).Value;
			default:
				return 0;
			}
		}
	}
}
