using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005351 RID: 21329
	public class IGroupFinishConfig_UnionUnion
	{
		// Token: 0x17009CB5 RID: 40117
		// (get) Token: 0x06022E38 RID: 142904 RVA: 0x004D5341 File Offset: 0x004D3541
		// (set) Token: 0x06022E39 RID: 142905 RVA: 0x004D5349 File Offset: 0x004D3549
		public IGroupFinishConfig_Union Type { get; set; }

		// Token: 0x17009CB6 RID: 40118
		// (get) Token: 0x06022E3A RID: 142906 RVA: 0x004D5352 File Offset: 0x004D3552
		// (set) Token: 0x06022E3B RID: 142907 RVA: 0x004D535A File Offset: 0x004D355A
		public object Value { get; set; }

		// Token: 0x06022E3C RID: 142908 RVA: 0x004D5363 File Offset: 0x004D3563
		public IGroupFinishConfig_UnionUnion()
		{
			this.Type = IGroupFinishConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06022E3D RID: 142909 RVA: 0x004D5379 File Offset: 0x004D3579
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06022E3E RID: 142910 RVA: 0x004D538B File Offset: 0x004D358B
		public IGroupFinishConfigT AsIGroupFinishConfig()
		{
			return this.As<IGroupFinishConfigT>();
		}

		// Token: 0x06022E3F RID: 142911 RVA: 0x004D5393 File Offset: 0x004D3593
		public static IGroupFinishConfig_UnionUnion FromIGroupFinishConfig(IGroupFinishConfigT _igroupfinishconfig)
		{
			return new IGroupFinishConfig_UnionUnion
			{
				Type = IGroupFinishConfig_Union.IGroupFinishConfig,
				Value = _igroupfinishconfig
			};
		}

		// Token: 0x06022E40 RID: 142912 RVA: 0x004D53A8 File Offset: 0x004D35A8
		public IGroupFinishSilenceT AsIGroupFinishSilence()
		{
			return this.As<IGroupFinishSilenceT>();
		}

		// Token: 0x06022E41 RID: 142913 RVA: 0x004D53B0 File Offset: 0x004D35B0
		public static IGroupFinishConfig_UnionUnion FromIGroupFinishSilence(IGroupFinishSilenceT _igroupfinishsilence)
		{
			return new IGroupFinishConfig_UnionUnion
			{
				Type = IGroupFinishConfig_Union.IGroupFinishSilence,
				Value = _igroupfinishsilence
			};
		}

		// Token: 0x06022E42 RID: 142914 RVA: 0x004D53C5 File Offset: 0x004D35C5
		public IGroupFinishDestroyT AsIGroupFinishDestroy()
		{
			return this.As<IGroupFinishDestroyT>();
		}

		// Token: 0x06022E43 RID: 142915 RVA: 0x004D53CD File Offset: 0x004D35CD
		public static IGroupFinishConfig_UnionUnion FromIGroupFinishDestroy(IGroupFinishDestroyT _igroupfinishdestroy)
		{
			return new IGroupFinishConfig_UnionUnion
			{
				Type = IGroupFinishConfig_Union.IGroupFinishDestroy,
				Value = _igroupfinishdestroy
			};
		}

		// Token: 0x06022E44 RID: 142916 RVA: 0x004D53E4 File Offset: 0x004D35E4
		public static int Pack(FlatBufferBuilder builder, IGroupFinishConfig_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IGroupFinishConfig_Union.IGroupFinishConfig:
				return IGroupFinishConfig.Pack(builder, _o.AsIGroupFinishConfig()).Value;
			case IGroupFinishConfig_Union.IGroupFinishSilence:
				return IGroupFinishSilence.Pack(builder, _o.AsIGroupFinishSilence()).Value;
			case IGroupFinishConfig_Union.IGroupFinishDestroy:
				return IGroupFinishDestroy.Pack(builder, _o.AsIGroupFinishDestroy()).Value;
			default:
				return 0;
			}
		}
	}
}
