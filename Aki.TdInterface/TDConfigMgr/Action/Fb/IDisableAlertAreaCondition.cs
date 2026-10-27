using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029EE RID: 10734
	public class IDisableAlertAreaCondition
	{
		// Token: 0x0600ED02 RID: 60674 RVA: 0x00229595 File Offset: 0x00227795
		[NullableContext(1)]
		public static IDisableAlertAreaCondition Create(IDisableAlertAreaCondition? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDisableAlertAreaCondition
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004AE8 RID: 19176
		// (get) Token: 0x0600ED03 RID: 60675 RVA: 0x002295B4 File Offset: 0x002277B4
		public virtual EDisableAlertAreaCondition Type
		{
			get
			{
				return (EDisableAlertAreaCondition)this.Instance.Type;
			}
		}

		// Token: 0x04008286 RID: 33414
		private IDisableAlertAreaCondition Instance;
	}
}
