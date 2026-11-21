using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.OpenSystem
{
	// Token: 0x02005D9B RID: 23963
	[NullableContext(1)]
	[Nullable(0)]
	public class OpenSystemSpringFestivalPictureAlbumView : OpenSystemBase
	{
		// Token: 0x0603A5D3 RID: 239059 RVA: 0x0107CA5B File Offset: 0x0107AC5B
		public OpenSystemSpringFestivalPictureAlbumView(LevelEventOpenSystem eventBase) : base(eventBase)
		{
		}

		// Token: 0x0603A5D4 RID: 239060 RVA: 0x0107CA64 File Offset: 0x0107AC64
		[return: Nullable(0)]
		public override UniTask<bool> ExecuteOpenView(OpenSystemBoard inParams, GeneralContext context)
		{
			OpenSystemSpringFestivalPictureAlbumView.<ExecuteOpenView>d__1 <ExecuteOpenView>d__;
			<ExecuteOpenView>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<ExecuteOpenView>d__.inParams = inParams;
			<ExecuteOpenView>d__.<>1__state = -1;
			<ExecuteOpenView>d__.<>t__builder.Start<OpenSystemSpringFestivalPictureAlbumView.<ExecuteOpenView>d__1>(ref <ExecuteOpenView>d__);
			return <ExecuteOpenView>d__.<>t__builder.Task;
		}

		// Token: 0x0603A5D5 RID: 239061 RVA: 0x0107CAA7 File Offset: 0x0107ACA7
		[NullableContext(2)]
		public override EUiViewName? GetViewName(OpenSystemBoard inParams = null, GeneralContext context = null)
		{
			return new EUiViewName?(EUiViewName.SpringManorAlbumView);
		}
	}
}
