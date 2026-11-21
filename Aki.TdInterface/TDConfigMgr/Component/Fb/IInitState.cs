using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000B53 RID: 2899
	public class IInitState
	{
		// Token: 0x06004246 RID: 16966 RVA: 0x000A883E File Offset: 0x000A6A3E
		public static IInitState Create(IInitState? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInitState
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000F9B RID: 3995
		// (get) Token: 0x06004247 RID: 16967 RVA: 0x000A885D File Offset: 0x000A6A5D
		public virtual EInitStateType Type
		{
			get
			{
				return (EInitStateType)this.Instance.Type;
			}
		}

		// Token: 0x040024B8 RID: 9400
		private IInitState Instance;
	}
}
