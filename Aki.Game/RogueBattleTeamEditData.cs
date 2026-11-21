using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;

// Token: 0x02001C61 RID: 7265
public class RogueBattleTeamEditData : UiPopViewData
{
	// Token: 0x0601203B RID: 73787 RVA: 0x0054CB16 File Offset: 0x0054AD16
	public RogueBattleTeamEditData(int formationIndex, [Nullable(new byte[]
	{
		2,
		1
	})] Func<List<int>, UniTask> onTeamEditConfirm)
	{
		this.FormationIndex = formationIndex;
		this.OnTeamEditConfirm = onTeamEditConfirm;
	}

	// Token: 0x04009D28 RID: 40232
	public int FormationIndex;

	// Token: 0x04009D29 RID: 40233
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Func<List<int>, UniTask> OnTeamEditConfirm;
}
