using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x020067A0 RID: 26528
	[NullableContext(1)]
	public interface IDragSourceAdapter
	{
		// Token: 0x170096A4 RID: 38564
		// (get) Token: 0x06042218 RID: 270872
		EDragSourceKind Kind { get; }

		// Token: 0x06042219 RID: 270873
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		UniTask<BuildResult> Build(IDangoBrawlDraggableView sourceView);

		// Token: 0x0604221A RID: 270874
		void Cancel(IDragVisual visual, [Nullable(2)] ItemSucAnchor anchor);

		// Token: 0x0604221B RID: 270875
		[return: Nullable(0)]
		UniTask<bool> Commit(IDragVisual visual, DragTarget target, [Nullable(2)] ItemSucAnchor anchor, [Nullable(new byte[]
		{
			2,
			1
		})] DangoBrawlBagOpInfo[] extraOps = null);

		// Token: 0x0604221C RID: 270876
		[return: Nullable(2)]
		OpSnapshot ApplyLocal(IDragVisual visual, DragTarget target, [Nullable(2)] ItemSucAnchor anchor);

		// Token: 0x0604221D RID: 270877
		DangoBrawlBagOpInfo[] BuildServerOpInfo(IDragVisual visual, DragTarget target);
	}
}
