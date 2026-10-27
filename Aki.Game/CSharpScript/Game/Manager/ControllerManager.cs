using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Framework;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Manager
{
	// Token: 0x02006944 RID: 26948
	public class ControllerManager : ControllerManagerBase
	{
		// Token: 0x06043274 RID: 275060 RVA: 0x0105E41B File Offset: 0x0105C61B
		public override bool Init()
		{
			bool result = base.Init();
			EventSystem.Instance.Add<bool>(EEventName.OnBattleStateChanged, new Action<bool>(this.OnBattleStateChanged));
			return result;
		}

		// Token: 0x06043275 RID: 275061 RVA: 0x0105E43F File Offset: 0x0105C63F
		public override bool Clear()
		{
			bool result = base.Clear();
			EventSystem.Instance.Remove<bool>(EEventName.OnBattleStateChanged, new Action<bool>(this.OnBattleStateChanged));
			return result;
		}

		// Token: 0x06043276 RID: 275062 RVA: 0x0105E463 File Offset: 0x0105C663
		private void OnBattleStateChanged(bool isInFight)
		{
			this.IsInFight = isInFight;
		}

		// Token: 0x04022F96 RID: 143254
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		public static readonly ControllerManager Instance = new ControllerManager();
	}
}
