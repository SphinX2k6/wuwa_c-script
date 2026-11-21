using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002CE1 RID: 11489
	public class ICustomAlertValue : ISetAlertValueType
	{
		// Token: 0x0600FBB1 RID: 64433 RVA: 0x002470C1 File Offset: 0x002452C1
		public static ICustomAlertValue Create(ICustomAlertValue? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICustomAlertValue
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004E9D RID: 20125
		// (get) Token: 0x0600FBB2 RID: 64434 RVA: 0x002470E0 File Offset: 0x002452E0
		public override EValueChangeType Type
		{
			get
			{
				return (EValueChangeType)this.Instance.Type;
			}
		}

		// Token: 0x17004E9E RID: 20126
		// (get) Token: 0x0600FBB3 RID: 64435 RVA: 0x002470ED File Offset: 0x002452ED
		public virtual float CustomValue
		{
			get
			{
				return this.Instance.CustomValue;
			}
		}

		// Token: 0x0400897F RID: 35199
		private ICustomAlertValue Instance;
	}
}
