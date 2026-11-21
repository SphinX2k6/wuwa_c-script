using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C47 RID: 11335
	public class IDisableMapMark : ToggleMapMarkState
	{
		// Token: 0x0600F952 RID: 63826 RVA: 0x002438CB File Offset: 0x00241ACB
		public static IDisableMapMark Create(IDisableMapMark? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDisableMapMark
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004D72 RID: 19826
		// (get) Token: 0x0600F953 RID: 63827 RVA: 0x002438EA File Offset: 0x00241AEA
		public override EMapMarkState Type
		{
			get
			{
				return (EMapMarkState)this.Instance.Type;
			}
		}

		// Token: 0x17004D73 RID: 19827
		// (get) Token: 0x0600F954 RID: 63828 RVA: 0x002438F7 File Offset: 0x00241AF7
		public virtual int MarkId
		{
			get
			{
				return this.Instance.MarkId;
			}
		}

		// Token: 0x0400884B RID: 34891
		private IDisableMapMark Instance;
	}
}
