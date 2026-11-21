using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004CD6 RID: 19670
	public class BattleSkillSwitchInteractItem : UiPanelBase
	{
		// Token: 0x06031374 RID: 201588 RVA: 0x00DBD280 File Offset: 0x00DBB480
		[NullableContext(1)]
		public void Init(UUIItem parentItem)
		{
			base.CreateThenShowByResourceIdAsync("UiItem_HandleSkillSwitchIcon", parentItem, false).ContinueWith(new Action(this.RefreshVisible)).Forget();
		}

		// Token: 0x06031375 RID: 201589 RVA: 0x00DBD2A5 File Offset: 0x00DBB4A5
		public void RefreshEnable(bool bEnable)
		{
			this.IsEnable = bEnable;
			this.RefreshVisible();
		}

		// Token: 0x06031376 RID: 201590 RVA: 0x00DBD2B4 File Offset: 0x00DBB4B4
		public void RefreshVisible()
		{
			this.SetActive(this.IsEnable);
		}

		// Token: 0x0401A11F RID: 106783
		public bool IsEnable;
	}
}
