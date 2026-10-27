using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.MovieMode
{
	// Token: 0x02005381 RID: 21377
	[NullableContext(2)]
	public interface IExitMovieModeParams
	{
		// Token: 0x1700837B RID: 33659
		// (get) Token: 0x060369EA RID: 223722
		// (set) Token: 0x060369EB RID: 223723
		float BlendTime { get; set; }

		// Token: 0x1700837C RID: 33660
		// (get) Token: 0x060369EC RID: 223724
		// (set) Token: 0x060369ED RID: 223725
		float? BlackFadeInTime { get; set; }

		// Token: 0x1700837D RID: 33661
		// (get) Token: 0x060369EE RID: 223726
		// (set) Token: 0x060369EF RID: 223727
		Func<UniTask> AfterBlackFadeInCallbackAsync { get; set; }
	}
}
