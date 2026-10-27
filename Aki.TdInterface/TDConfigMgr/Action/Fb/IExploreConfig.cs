using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028F6 RID: 10486
	public class IExploreConfig
	{
		// Token: 0x0600E8E9 RID: 59625 RVA: 0x00222AFD File Offset: 0x00220CFD
		[NullableContext(1)]
		public static IExploreConfig Create(IExploreConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IExploreConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170048BF RID: 18623
		// (get) Token: 0x0600E8EA RID: 59626 RVA: 0x00222B1C File Offset: 0x00220D1C
		public virtual EExploreStateType Type
		{
			get
			{
				return (EExploreStateType)this.Instance.Type;
			}
		}

		// Token: 0x04008094 RID: 32916
		private IExploreConfig Instance;
	}
}
