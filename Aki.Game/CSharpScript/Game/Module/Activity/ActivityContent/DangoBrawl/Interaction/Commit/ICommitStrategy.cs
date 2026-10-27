using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction.Commit
{
	// Token: 0x02006887 RID: 26759
	[NullableContext(1)]
	public interface ICommitStrategy
	{
		// Token: 0x06042CE4 RID: 273636
		[return: Nullable(0)]
		UniTask<EPlaceResult> Commit(IDragSourceAdapter adapter, IDragVisual visual, [Nullable(2)] DragTarget target, [Nullable(2)] ItemSucAnchor anchor);
	}
}
