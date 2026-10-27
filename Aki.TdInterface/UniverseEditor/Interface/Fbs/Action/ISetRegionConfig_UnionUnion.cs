using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007062 RID: 28770
	public class ISetRegionConfig_UnionUnion
	{
		// Token: 0x1700D5D8 RID: 54744
		// (get) Token: 0x06032F08 RID: 208648 RVA: 0x006DF5D1 File Offset: 0x006DD7D1
		// (set) Token: 0x06032F09 RID: 208649 RVA: 0x006DF5D9 File Offset: 0x006DD7D9
		public ISetRegionConfig_Union Type { get; set; }

		// Token: 0x1700D5D9 RID: 54745
		// (get) Token: 0x06032F0A RID: 208650 RVA: 0x006DF5E2 File Offset: 0x006DD7E2
		// (set) Token: 0x06032F0B RID: 208651 RVA: 0x006DF5EA File Offset: 0x006DD7EA
		public object Value { get; set; }

		// Token: 0x06032F0C RID: 208652 RVA: 0x006DF5F3 File Offset: 0x006DD7F3
		public ISetRegionConfig_UnionUnion()
		{
			this.Type = ISetRegionConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06032F0D RID: 208653 RVA: 0x006DF609 File Offset: 0x006DD809
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06032F0E RID: 208654 RVA: 0x006DF61B File Offset: 0x006DD81B
		public ISetRegionConfigT AsISetRegionConfig()
		{
			return this.As<ISetRegionConfigT>();
		}

		// Token: 0x06032F0F RID: 208655 RVA: 0x006DF623 File Offset: 0x006DD823
		public static ISetRegionConfig_UnionUnion FromISetRegionConfig(ISetRegionConfigT _isetregionconfig)
		{
			return new ISetRegionConfig_UnionUnion
			{
				Type = ISetRegionConfig_Union.ISetRegionConfig,
				Value = _isetregionconfig
			};
		}

		// Token: 0x06032F10 RID: 208656 RVA: 0x006DF638 File Offset: 0x006DD838
		public ISetRegionMpcT AsISetRegionMpc()
		{
			return this.As<ISetRegionMpcT>();
		}

		// Token: 0x06032F11 RID: 208657 RVA: 0x006DF640 File Offset: 0x006DD840
		public static ISetRegionConfig_UnionUnion FromISetRegionMpc(ISetRegionMpcT _isetregionmpc)
		{
			return new ISetRegionConfig_UnionUnion
			{
				Type = ISetRegionConfig_Union.ISetRegionMpc,
				Value = _isetregionmpc
			};
		}

		// Token: 0x06032F12 RID: 208658 RVA: 0x006DF658 File Offset: 0x006DD858
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
