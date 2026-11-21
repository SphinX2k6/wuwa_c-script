using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006DC2 RID: 28098
	public class IExploreConfig_UnionUnion
	{
		// Token: 0x1700CDF7 RID: 52727
		// (get) Token: 0x060307E7 RID: 198631 RVA: 0x00696259 File Offset: 0x00694459
		// (set) Token: 0x060307E8 RID: 198632 RVA: 0x00696261 File Offset: 0x00694461
		public IExploreConfig_Union Type { get; set; }

		// Token: 0x1700CDF8 RID: 52728
		// (get) Token: 0x060307E9 RID: 198633 RVA: 0x0069626A File Offset: 0x0069446A
		// (set) Token: 0x060307EA RID: 198634 RVA: 0x00696272 File Offset: 0x00694472
		public object Value { get; set; }

		// Token: 0x060307EB RID: 198635 RVA: 0x0069627B File Offset: 0x0069447B
		public IExploreConfig_UnionUnion()
		{
			this.Type = IExploreConfig_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060307EC RID: 198636 RVA: 0x00696291 File Offset: 0x00694491
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060307ED RID: 198637 RVA: 0x006962A3 File Offset: 0x006944A3
		public IExploreConfigT AsIExploreConfig()
		{
			return this.As<IExploreConfigT>();
		}

		// Token: 0x060307EE RID: 198638 RVA: 0x006962AB File Offset: 0x006944AB
		public static IExploreConfig_UnionUnion FromIExploreConfig(IExploreConfigT _iexploreconfig)
		{
			return new IExploreConfig_UnionUnion
			{
				Type = IExploreConfig_Union.IExploreConfig,
				Value = _iexploreconfig
			};
		}

		// Token: 0x060307EF RID: 198639 RVA: 0x006962C0 File Offset: 0x006944C0
		public ITeleControlConfigT AsITeleControlConfig()
		{
			return this.As<ITeleControlConfigT>();
		}

		// Token: 0x060307F0 RID: 198640 RVA: 0x006962C8 File Offset: 0x006944C8
		public static IExploreConfig_UnionUnion FromITeleControlConfig(ITeleControlConfigT _itelecontrolconfig)
		{
			return new IExploreConfig_UnionUnion
			{
				Type = IExploreConfig_Union.ITeleControlConfig,
				Value = _itelecontrolconfig
			};
		}

		// Token: 0x060307F1 RID: 198641 RVA: 0x006962E0 File Offset: 0x006944E0
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
