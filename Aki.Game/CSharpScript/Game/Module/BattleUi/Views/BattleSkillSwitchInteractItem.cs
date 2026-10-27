using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005CF4 RID: 23796
	public class BattleSkillSwitchInteractItem : UiPanelBase
	{
		// Token: 0x0603C41E RID: 246814 RVA: 0x00E6CCCC File Offset: 0x00E6AECC
		[NullableContext(1)]
		public void Init(UUIItem parentItem)
		{
			base.CreateThenShowByResourceIdAsync("UiItem_HandleSkillSwitchIcon", parentItem, false).ContinueWith(new Action(this.RefreshVisible)).Forget();
		}

		// Token: 0x0603C41F RID: 246815 RVA: 0x00E6CCF1 File Offset: 0x00E6AEF1
		public void RefreshEnable(bool bEnable)
		{
			this.IsEnable = bEnable;
			this.RefreshVisible();
		}

		// Token: 0x0603C420 RID: 246816 RVA: 0x00E6CD00 File Offset: 0x00E6AF00
		public void RefreshVisible()
		{
			this.SetActive(this.IsEnable);
		}

		// Token: 0x0401F666 RID: 128614
		public bool IsEnable;
	}
}
