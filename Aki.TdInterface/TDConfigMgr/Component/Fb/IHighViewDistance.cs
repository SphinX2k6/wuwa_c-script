using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DF1 RID: 3569
	public class IHighViewDistance : IViewDistanceMode
	{
		// Token: 0x060050E6 RID: 20710 RVA: 0x000C8954 File Offset: 0x000C6B54
		public static IHighViewDistance Create(IHighViewDistance? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHighViewDistance
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170018FF RID: 6399
		// (get) Token: 0x060050E7 RID: 20711 RVA: 0x000C8973 File Offset: 0x000C6B73
		public override EViewDistanceType Type
		{
			get
			{
				return (EViewDistanceType)this.Instance.Type;
			}
		}

		// Token: 0x04002E16 RID: 11798
		private IHighViewDistance Instance;
	}
}
