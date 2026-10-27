using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x02002874 RID: 10356
[NullableContext(1)]
[Nullable(0)]
public class RoleFavorViewComponentBase : UiPanelBase
{
	// Token: 0x060154F3 RID: 87283 RVA: 0x00561EFD File Offset: 0x005600FD
	public void SetData(RoleFavorContentDataBase contentData, bool isActive = true)
	{
		this.ContentData = contentData;
		this.IsActive = isActive;
		this.OnSetData(contentData);
		if (isActive)
		{
			this.OnRefreshView();
		}
		this.SetComponentActive(isActive);
	}

	// Token: 0x060154F4 RID: 87284 RVA: 0x00561F24 File Offset: 0x00560124
	protected virtual void OnSetData(RoleFavorContentDataBase contentData)
	{
	}

	// Token: 0x060154F5 RID: 87285 RVA: 0x00561F26 File Offset: 0x00560126
	protected virtual void OnRefreshView()
	{
	}

	// Token: 0x060154F6 RID: 87286 RVA: 0x00561F28 File Offset: 0x00560128
	public void SetComponentActive(bool active)
	{
		this.IsActive = active;
		if (this.RootItem != null)
		{
			this.RootItem.SetUIActive(active);
		}
	}

	// Token: 0x060154F7 RID: 87287 RVA: 0x00561F45 File Offset: 0x00560145
	[NullableContext(2)]
	public RoleFavorContentDataBase GetContentData()
	{
		return this.ContentData;
	}

	// Token: 0x060154F8 RID: 87288 RVA: 0x00561F4D File Offset: 0x0056014D
	protected override void OnBeforeDestroy()
	{
		this.ContentData = null;
		this.IsActive = false;
	}

	// Token: 0x04009F4A RID: 40778
	[Nullable(2)]
	protected RoleFavorContentDataBase ContentData;

	// Token: 0x04009F4B RID: 40779
	protected bool IsActive;
}
