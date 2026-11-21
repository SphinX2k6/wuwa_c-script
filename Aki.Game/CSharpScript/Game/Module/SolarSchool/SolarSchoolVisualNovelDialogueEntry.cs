using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A6F RID: 23151
	public static class SolarSchoolVisualNovelDialogueEntry
	{
		// Token: 0x06039074 RID: 233588 RVA: 0x00FF9614 File Offset: 0x00FF7814
		public static UniTask<bool> PlayAsync([Nullable(1)] string flowListName, int flowId, int stateId, int scriptId = 0)
		{
			SolarSchoolVisualNovelDialogueEntry.<PlayAsync>d__0 <PlayAsync>d__;
			<PlayAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<PlayAsync>d__.flowListName = flowListName;
			<PlayAsync>d__.flowId = flowId;
			<PlayAsync>d__.stateId = stateId;
			<PlayAsync>d__.scriptId = scriptId;
			<PlayAsync>d__.<>1__state = -1;
			<PlayAsync>d__.<>t__builder.Start<SolarSchoolVisualNovelDialogueEntry.<PlayAsync>d__0>(ref <PlayAsync>d__);
			return <PlayAsync>d__.<>t__builder.Task;
		}
	}
}
