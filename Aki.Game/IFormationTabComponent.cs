using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;

// Token: 0x02001C06 RID: 7174
[NullableContext(1)]
public interface IFormationTabComponent
{
	// Token: 0x0600D68A RID: 54922
	void Destroy();

	// Token: 0x0600D68B RID: 54923
	UniTask RefreshTabItemAsync(int length);

	// Token: 0x0600D68C RID: 54924
	void SelectToggleByIndex(int index, bool bIgnored = false);

	// Token: 0x0600D68D RID: 54925
	int GetSelectedIndex();

	// Token: 0x0600D68E RID: 54926
	void ScrollToToggleByIndex(int index);

	// Token: 0x0600D68F RID: 54927
	[NullableContext(2)]
	EditFormationTabItem GetTabItemByIndex(int index);

	// Token: 0x0600D690 RID: 54928
	void RefreshTitleByIndex(int index);

	// Token: 0x0600D691 RID: 54929
	void SetCanChange(Func<int, bool> callback);
}
