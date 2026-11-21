using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x020056F0 RID: 22256
	[NullableContext(1)]
	public interface IDragSourceAdapter
	{
		// Token: 0x170069E5 RID: 27109
		// (get) Token: 0x06036D6E RID: 224622
		EDragSourceKind Kind { get; }

		// Token: 0x06036D6F RID: 224623
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		UniTask<BuildResult> Build(IDangoBrawlDraggableView sourceView);

		// Token: 0x06036D70 RID: 224624
		void Cancel(IDragVisual visual, [Nullable(2)] ItemSucAnchor anchor);

		// Token: 0x06036D71 RID: 224625
		[return: Nullable(0)]
		UniTask<bool> Commit(IDragVisual visual, DragTarget target, [Nullable(2)] ItemSucAnchor anchor, [Nullable(new byte[]
		{
			2,
			1
		})] DangoBrawlBagOpInfo[] extraOps = null);

		// Token: 0x06036D72 RID: 224626
		[return: Nullable(2)]
		OpSnapshot ApplyLocal(IDragVisual visual, DragTarget target, [Nullable(2)] ItemSucAnchor anchor);

		// Token: 0x06036D73 RID: 224627
		DangoBrawlBagOpInfo[] BuildServerOpInfo(IDragVisual visual, DragTarget target);
	}
}
