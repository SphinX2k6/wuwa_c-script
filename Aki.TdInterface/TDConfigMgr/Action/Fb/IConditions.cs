using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020028C3 RID: 10435
	public class IConditions
	{
		// Token: 0x0600E862 RID: 59490 RVA: 0x0022583D File Offset: 0x00223A3D
		public static IConditions Create(IConditions? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IConditions
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700438A RID: 17290
		// (get) Token: 0x0600E863 RID: 59491 RVA: 0x0022585C File Offset: 0x00223A5C
		public virtual string LogicOpType
		{
			get
			{
				return this.Instance.LogicOpType;
			}
		}

		// Token: 0x1700438B RID: 17291
		// (get) Token: 0x0600E864 RID: 59492 RVA: 0x0022586C File Offset: 0x00223A6C
		public virtual List<ICondition> Conditions
		{
			get
			{
				if (this._ConditionsInited)
				{
					return this._ConditionsCache;
				}
				this._ConditionsInited = true;
				int conditionsLength = this.Instance.ConditionsLength;
				this._ConditionsCache = new List<ICondition>(conditionsLength);
				for (int i = 0; i < conditionsLength; i++)
				{
					this._ConditionsCache.Add(ICondition.Create(this.Instance.Conditions(i)));
				}
				return this._ConditionsCache;
			}
		}

		// Token: 0x04007FFF RID: 32767
		private IConditions Instance;

		// Token: 0x04008000 RID: 32768
		private List<ICondition> _ConditionsCache;

		// Token: 0x04008001 RID: 32769
		private bool _ConditionsInited;
	}
}
