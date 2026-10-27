using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Jobs
{
	// Token: 0x0200651F RID: 25887
	public class ReshuffleJob : IJob
	{
		// Token: 0x1700951F RID: 38175
		// (get) Token: 0x06040EBE RID: 265918 RVA: 0x00FBBB2C File Offset: 0x00FB9D2C
		public int ExecutionOrder
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x06040EBF RID: 265919 RVA: 0x00FBBB2F File Offset: 0x00FB9D2F
		[NullableContext(1)]
		public UniTask ExecuteAsync(IMatchThreePresentation view)
		{
			return view.PlayReshuffleAsync();
		}
	}
}
