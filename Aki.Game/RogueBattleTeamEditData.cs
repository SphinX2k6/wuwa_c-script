using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;

// Token: 0x02002776 RID: 10102
public class RogueBattleTeamEditData : UiPopViewData
{
	// Token: 0x06014B58 RID: 84824 RVA: 0x0053DD06 File Offset: 0x0053BF06
	public RogueBattleTeamEditData(int formationIndex, [Nullable(new byte[]
	{
		2,
		1
	})] Func<List<int>, UniTask> onTeamEditConfirm)
	{
		this.FormationIndex = formationIndex;
		this.OnTeamEditConfirm = onTeamEditConfirm;
	}

	// Token: 0x04009BD0 RID: 39888
	public int FormationIndex;

	// Token: 0x04009BD1 RID: 39889
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Func<List<int>, UniTask> OnTeamEditConfirm;
}
