using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x02001DEF RID: 7663
[NullableContext(1)]
[Nullable(0)]
public class RoleFavorViewComponentBase : UiPanelBase
{
	// Token: 0x06012EF1 RID: 77553 RVA: 0x0058CC59 File Offset: 0x0058AE59
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

	// Token: 0x06012EF2 RID: 77554 RVA: 0x0058CC80 File Offset: 0x0058AE80
	protected virtual void OnSetData(RoleFavorContentDataBase contentData)
	{
	}

	// Token: 0x06012EF3 RID: 77555 RVA: 0x0058CC82 File Offset: 0x0058AE82
	protected virtual void OnRefreshView()
	{
	}

	// Token: 0x06012EF4 RID: 77556 RVA: 0x0058CC84 File Offset: 0x0058AE84
	public void SetComponentActive(bool active)
	{
		this.IsActive = active;
		if (this.RootItem != null)
		{
			this.RootItem.SetUIActive(active);
		}
	}

	// Token: 0x06012EF5 RID: 77557 RVA: 0x0058CCA1 File Offset: 0x0058AEA1
	[NullableContext(2)]
	public RoleFavorContentDataBase GetContentData()
	{
		return this.ContentData;
	}

	// Token: 0x06012EF6 RID: 77558 RVA: 0x0058CCA9 File Offset: 0x0058AEA9
	protected override void OnBeforeDestroy()
	{
		this.ContentData = null;
		this.IsActive = false;
	}

	// Token: 0x0400A333 RID: 41779
	[Nullable(2)]
	protected RoleFavorContentDataBase ContentData;

	// Token: 0x0400A334 RID: 41780
	protected bool IsActive;
}
