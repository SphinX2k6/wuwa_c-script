using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002963 RID: 10595
	public class IFocusOnMapMark
	{
		// Token: 0x0600EAE0 RID: 60128 RVA: 0x00226254 File Offset: 0x00224454
		[NullableContext(1)]
		public static IFocusOnMapMark Create(IFocusOnMapMark? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFocusOnMapMark
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170049DC RID: 18908
		// (get) Token: 0x0600EAE1 RID: 60129 RVA: 0x00226273 File Offset: 0x00224473
		public virtual EMapMarkType Type
		{
			get
			{
				return (EMapMarkType)this.Instance.Type;
			}
		}

		// Token: 0x0400816B RID: 33131
		private IFocusOnMapMark Instance;
	}
}
