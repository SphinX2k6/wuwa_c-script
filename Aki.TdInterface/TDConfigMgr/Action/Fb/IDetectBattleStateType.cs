using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002707 RID: 9991
	public class IDetectBattleStateType
	{
		// Token: 0x0600DEF7 RID: 57079 RVA: 0x00210E36 File Offset: 0x0020F036
		[NullableContext(1)]
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

		// Token: 0x170042AB RID: 17067
		// (get) Token: 0x0600DEF8 RID: 57080 RVA: 0x00210E55 File Offset: 0x0020F055
		public virtual EDetectBattleConditionType Type
		{
			get
			{
				return (EDetectBattleConditionType)this.Instance.Type;
			}
		}

		// Token: 0x04007BBD RID: 31677
		private IDetectBattleStateType Instance;
	}
}
