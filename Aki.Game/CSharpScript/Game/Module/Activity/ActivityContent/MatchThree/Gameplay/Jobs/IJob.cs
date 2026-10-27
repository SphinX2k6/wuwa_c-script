using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Jobs
{
	// Token: 0x02006506 RID: 25862
	[NullableContext(1)]
	public interface IJob
	{
		// Token: 0x17009519 RID: 38169
		// (get) Token: 0x06040E9B RID: 265883
		int ExecutionOrder { get; }

		// Token: 0x06040E9C RID: 265884
		UniTask ExecuteAsync(IMatchThreePresentation presenter);
	}
}
