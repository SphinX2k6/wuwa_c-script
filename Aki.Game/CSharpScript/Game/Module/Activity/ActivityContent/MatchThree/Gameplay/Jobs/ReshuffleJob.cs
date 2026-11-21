using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Jobs
{
	// Token: 0x0200549D RID: 21661
	public class ReshuffleJob : IJob
	{
		// Token: 0x17006881 RID: 26753
		// (get) Token: 0x06035B82 RID: 220034 RVA: 0x00F02B5C File Offset: 0x00F00D5C
		public int ExecutionOrder
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x06035B83 RID: 220035 RVA: 0x00F02B5F File Offset: 0x00F00D5F
		[NullableContext(1)]
		public UniTask ExecuteAsync(IMatchThreePresentation view)
		{
			return view.PlayReshuffleAsync();
		}
	}
}
