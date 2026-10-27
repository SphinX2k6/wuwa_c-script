using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x02006595 RID: 26005
	[NullableContext(1)]
	public interface IDockyardWareHouseInterface
	{
		// Token: 0x06041339 RID: 267065
		void WareHouseItemClick(DockyardItemBlockOriginalData itemData);

		// Token: 0x0604133A RID: 267066
		void WareHouseItemDragBegin(DockyardItemBlockOriginalData itemData);

		// Token: 0x0604133B RID: 267067
		[NullableContext(0)]
		UniTask<bool> TrySetSelectedItemBlockConfirm();

		// Token: 0x0604133C RID: 267068
		bool IsWareHouseItemCanClick(int id);

		// Token: 0x0604133D RID: 267069
		int GetSelectedId();
	}
}
