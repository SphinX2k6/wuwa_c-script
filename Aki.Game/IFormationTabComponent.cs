using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;

// Token: 0x020010C5 RID: 4293
[NullableContext(1)]
public interface IFormationTabComponent
{
	// Token: 0x0600AA9D RID: 43677
	void Destroy();

	// Token: 0x0600AA9E RID: 43678
	UniTask RefreshTabItemAsync(int length);

	// Token: 0x0600AA9F RID: 43679
	void SelectToggleByIndex(int index, bool bIgnored = false);

	// Token: 0x0600AAA0 RID: 43680
	int GetSelectedIndex();

	// Token: 0x0600AAA1 RID: 43681
	void ScrollToToggleByIndex(int index);

	// Token: 0x0600AAA2 RID: 43682
	[NullableContext(2)]
	EditFormationTabItem GetTabItemByIndex(int index);

	// Token: 0x0600AAA3 RID: 43683
	void RefreshTitleByIndex(int index);

	// Token: 0x0600AAA4 RID: 43684
	void SetCanChange(Func<int, bool> callback);
}
