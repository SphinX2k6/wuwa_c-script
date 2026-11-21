using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029CE RID: 10702
	public class IDetectBattleStateType
	{
		// Token: 0x0600ECE3 RID: 60643 RVA: 0x0022D7DF File Offset: 0x0022B9DF
		public static IDetectBattleStateType Create(IDetectBattleStateType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDetectBattleStateType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170045F5 RID: 17909
		// (get) Token: 0x0600ECE4 RID: 60644 RVA: 0x0022D7FE File Offset: 0x0022B9FE
		public virtual EDetectBattleConditionType Type
		{
			get
			{
				return (EDetectBattleConditionType)this.Instance.Type;
			}
		}

		// Token: 0x04008262 RID: 33378
		private IDetectBattleStateType Instance;
	}
}
