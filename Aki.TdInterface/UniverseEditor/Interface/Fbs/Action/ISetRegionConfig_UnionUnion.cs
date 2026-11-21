using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200782E RID: 30766
	public class ISetRegionConfig_UnionUnion
	{
		// Token: 0x1700E1BB RID: 57787
		// (get) Token: 0x060361A9 RID: 221609 RVA: 0x0073FB85 File Offset: 0x0073DD85
		// (set) Token: 0x060361AA RID: 221610 RVA: 0x0073FB8D File Offset: 0x0073DD8D
		public ISetRegionConfig_Union Type { get; set; }

		// Token: 0x1700E1BC RID: 57788
		// (get) Token: 0x060361AB RID: 221611 RVA: 0x0073FB96 File Offset: 0x0073DD96
		// (set) Token: 0x060361AC RID: 221612 RVA: 0x0073FB9E File Offset: 0x0073DD9E
		public object Value { get; set; }

		// Token: 0x060361AD RID: 221613 RVA: 0x0073FBA7 File Offset: 0x0073DDA7
		public ISetRegionConfig_UnionUnion()
		{
			this.Type = ISetRegionConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060361AE RID: 221614 RVA: 0x0073FBBD File Offset: 0x0073DDBD
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060361AF RID: 221615 RVA: 0x0073FBCF File Offset: 0x0073DDCF
		public ISetRegionConfigT AsISetRegionConfig()
		{
			return this.As<ISetRegionConfigT>();
		}

		// Token: 0x060361B0 RID: 221616 RVA: 0x0073FBD7 File Offset: 0x0073DDD7
		public static ISetRegionConfig_UnionUnion FromISetRegionConfig(ISetRegionConfigT _isetregionconfig)
		{
			return new ISetRegionConfig_UnionUnion
			{
				Type = ISetRegionConfig_Union.ISetRegionConfig,
				Value = _isetregionconfig
			};
		}

		// Token: 0x060361B1 RID: 221617 RVA: 0x0073FBEC File Offset: 0x0073DDEC
		public ISetRegionMpcT AsISetRegionMpc()
		{
			return this.As<ISetRegionMpcT>();
		}

		// Token: 0x060361B2 RID: 221618 RVA: 0x0073FBF4 File Offset: 0x0073DDF4
		public static ISetRegionConfig_UnionUnion FromISetRegionMpc(ISetRegionMpcT _isetregionmpc)
		{
			return new ISetRegionConfig_UnionUnion
			{
				Type = ISetRegionConfig_Union.ISetRegionMpc,
				Value = _isetregionmpc
			};
		}

		// Token: 0x060361B3 RID: 221619 RVA: 0x0073FC0C File Offset: 0x0073DE0C
		public static int Pack(FlatBufferBuilder builder, ISetRegionConfig_UnionUnion _o)
		{
			ISetRegionConfig_Union type = _o.Type;
			if (type == ISetRegionConfig_Union.ISetRegionConfig)
			{
				return ISetRegionConfig.Pack(builder, _o.AsISetRegionConfig()).Value;
			}
			if (type != ISetRegionConfig_Union.ISetRegionMpc)
			{
				return 0;
			}
			return ISetRegionMpc.Pack(builder, _o.AsISetRegionMpc()).Value;
		}
	}
}
