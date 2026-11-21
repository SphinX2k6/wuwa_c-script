using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002CDF RID: 11487
	public class ISetAlertValueType
	{
		// Token: 0x0600FBAA RID: 64426 RVA: 0x0024704C File Offset: 0x0024524C
		public static ISetAlertValueType Create(ISetAlertValueType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetAlertValueType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004E9A RID: 20122
		// (get) Token: 0x0600FBAB RID: 64427 RVA: 0x0024706B File Offset: 0x0024526B
		public virtual EValueChangeType Type
		{
			get
			{
				return (EValueChangeType)this.Instance.Type;
			}
		}

		// Token: 0x0400897D RID: 35197
		private ISetAlertValueType Instance;
	}
}
