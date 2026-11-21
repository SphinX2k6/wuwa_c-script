using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.MovieMode
{
	// Token: 0x02004364 RID: 17252
	[NullableContext(2)]
	public interface IExitMovieModeParams
	{
		// Token: 0x17005747 RID: 22343
		// (get) Token: 0x0602B930 RID: 178480
		// (set) Token: 0x0602B931 RID: 178481
		float BlendTime { get; set; }

		// Token: 0x17005748 RID: 22344
		// (get) Token: 0x0602B932 RID: 178482
		// (set) Token: 0x0602B933 RID: 178483
		float? BlackFadeInTime { get; set; }

		// Token: 0x17005749 RID: 22345
		// (get) Token: 0x0602B934 RID: 178484
		// (set) Token: 0x0602B935 RID: 178485
		Func<UniTask> AfterBlackFadeInCallbackAsync { get; set; }
	}
}
