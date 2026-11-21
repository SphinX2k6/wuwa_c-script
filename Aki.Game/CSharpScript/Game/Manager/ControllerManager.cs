using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Framework;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Manager
{
	// Token: 0x02005A9F RID: 23199
	public class ControllerManager : ControllerManagerBase
	{
		// Token: 0x060392AB RID: 234155 RVA: 0x010025DA File Offset: 0x010007DA
		public override bool Init()
		{
			bool result = base.Init();
			EventSystem.Instance.Add<bool>(EEventName.OnBattleStateChanged, new Action<bool>(this.OnBattleStateChanged));
			return result;
		}

		// Token: 0x060392AC RID: 234156 RVA: 0x010025FE File Offset: 0x010007FE
		public override bool Clear()
		{
			bool result = base.Clear();
			EventSystem.Instance.Remove<bool>(EEventName.OnBattleStateChanged, new Action<bool>(this.OnBattleStateChanged));
			return result;
		}

		// Token: 0x060392AD RID: 234157 RVA: 0x01002622 File Offset: 0x01000822
		private void OnBattleStateChanged(bool isInFight)
		{
			this.IsInFight = isInFight;
		}

		// Token: 0x0401E180 RID: 123264
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		public static readonly ControllerManager Instance = new ControllerManager();
	}
}
