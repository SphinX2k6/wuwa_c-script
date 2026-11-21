using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DEE RID: 3566
	public class IViewDistanceMode
	{
		// Token: 0x060050DD RID: 20701 RVA: 0x000C88B8 File Offset: 0x000C6AB8
		public static IViewDistanceMode Create(IViewDistanceMode? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IViewDistanceMode
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170018FC RID: 6396
		// (get) Token: 0x060050DE RID: 20702 RVA: 0x000C88D7 File Offset: 0x000C6AD7
		public virtual EViewDistanceType Type
		{
			get
			{
				return (EViewDistanceType)this.Instance.Type;
			}
		}

		// Token: 0x04002E13 RID: 11795
		private IViewDistanceMode Instance;
	}
}
