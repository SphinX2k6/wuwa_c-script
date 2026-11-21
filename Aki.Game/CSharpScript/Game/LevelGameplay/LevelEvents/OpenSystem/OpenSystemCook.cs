using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02005D4A RID: 23882
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemCook : OpenSystemBase
	{
		// Token: 0x0603A4E0 RID: 238816 RVA: 0x0107A9D5 File Offset: 0x01078BD5
		public OpenSystemCook(LevelEventOpenSystem eventBase)
		{
			Dictionary<int, EUiViewName> dictionary = new Dictionary<int, EUiViewName>();
			dictionary[0] = EUiViewName.CookRootView;
			dictionary[1] = EUiViewName.CookMechanismRootView;
			dictionary[2] = EUiViewName.CookSchoolMechanismRootView;
			this.CookViewMap = dictionary;
			base..ctor(eventBase);
		}

		// Token: 0x0603A4E1 RID: 238817 RVA: 0x0107AA10 File Offset: 0x01078C10
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemCook.<ExecuteOpenView>d__2 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.<>4__this = this;
			<ExecuteOpenView>d__.inParams = inParams;
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemCook.<ExecuteOpenView>d__2>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x0603A4E2 RID: 238818 RVA: 0x0107AA5C File Offset: 0x01078C5C
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			if (inParams == null)
			{
				return new EUiViewName?(EUiViewName.CookRootView);
			}
			EUiViewName value;
			if (this.CookViewMap.TryGetValue(inParams.BoardId, out value))
			{
				return new EUiViewName?(value);
			}
			return new EUiViewName?(EUiViewName.CookRootView);
		}

		// Token: 0x0401EC2A RID: 125994
		private readonly Dictionary<int, EUiViewName> CookViewMap;
	}
}
