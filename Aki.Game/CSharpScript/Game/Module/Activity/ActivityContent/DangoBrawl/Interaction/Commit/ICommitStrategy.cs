using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Interaction.Commit
{
	// Token: 0x020057D7 RID: 22487
	[NullableContext(1)]
	public interface ICommitStrategy
	{
		// Token: 0x0603783C RID: 227388
		[return: Nullable(0)]
		UniTask<EPlaceResult> Commit(IDragSourceAdapter adapter, IDragVisual visual, [Nullable(2)] DragTarget target, [Nullable(2)] ItemSucAnchor anchor);
	}
}
