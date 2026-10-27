using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020026E4 RID: 9956
	public class IExecBattleActionType
	{
		// Token: 0x0600DE6A RID: 56938 RVA: 0x0020FFB8 File Offset: 0x0020E1B8
		[NullableContext(1)]
		public static IExecBattleActionType Create(IExecBattleActionType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IExecBattleActionType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004264 RID: 16996
		// (get) Token: 0x0600DE6B RID: 56939 RVA: 0x0020FFD7 File Offset: 0x0020E1D7
		public virtual EExecBattleActionType Type
		{
			get
			{
				return (EExecBattleActionType)this.Instance.Type;
			}
		}

		// Token: 0x04007B76 RID: 31606
		private IExecBattleActionType Instance;
	}
}
