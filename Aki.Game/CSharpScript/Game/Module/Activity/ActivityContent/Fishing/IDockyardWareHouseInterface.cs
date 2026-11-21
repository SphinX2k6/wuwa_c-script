using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x02005513 RID: 21779
	[NullableContext(1)]
	public interface IDockyardWareHouseInterface
	{
		// Token: 0x06035FFE RID: 221182
		void WareHouseItemClick(DockyardItemBlockOriginalData itemData);

		// Token: 0x06035FFF RID: 221183
		void WareHouseItemDragBegin(DockyardItemBlockOriginalData itemData);

		// Token: 0x06036000 RID: 221184
		[NullableContext(0)]
		UniTask<bool> TrySetSelectedItemBlockConfirm();

		// Token: 0x06036001 RID: 221185
		bool IsWareHouseItemCanClick(int id);

		// Token: 0x06036002 RID: 221186
		int GetSelectedId();
	}
}
