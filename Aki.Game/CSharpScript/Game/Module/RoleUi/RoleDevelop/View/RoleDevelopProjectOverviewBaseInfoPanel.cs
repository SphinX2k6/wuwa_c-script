using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.RoleUi.RoleDevelop.Data;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop.View
{
	// Token: 0x02003D00 RID: 15616
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class RoleDevelopProjectOverviewBaseInfoPanel : UiPanelBase
	{
		// Token: 0x06027F9F RID: 163743 RVA: 0x00B2F32F File Offset: 0x00B2D52F
		public void RefreshPanel(RoleDevelopData data, bool forceRefresh = false)
		{
			this.Data = data;
			this.OnRefreshPanel(forceRefresh);
		}

		// Token: 0x06027FA0 RID: 163744 RVA: 0x00B2F33F File Offset: 0x00B2D53F
		public void SetSwitchCategoryCallback(Action<ERoleDevelopCategoryType> callback)
		{
			this.SwitchCategoryCallback = callback;
		}

		// Token: 0x06027FA1 RID: 163745 RVA: 0x00B2F348 File Offset: 0x00B2D548
		protected void SwitchCategory(ERoleDevelopCategoryType categoryType)
		{
			Action<ERoleDevelopCategoryType> switchCategoryCallback = this.SwitchCategoryCallback;
			if (switchCategoryCallback == null)
			{
				return;
			}
			switchCategoryCallback(categoryType);
		}

		// Token: 0x06027FA2 RID: 163746
		protected abstract void OnRefreshPanel(bool forceRefresh);

		// Token: 0x04015C5A RID: 89178
		[Nullable(2)]
		protected RoleDevelopData Data;

		// Token: 0x04015C5B RID: 89179
		[Nullable(2)]
		private Action<ERoleDevelopCategoryType> SwitchCategoryCallback;
	}
}
