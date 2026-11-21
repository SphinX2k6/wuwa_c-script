using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhoneMessage.View;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004CDB RID: 19675
	[NullableContext(2)]
	[Nullable(0)]
	public class BattleViewProxy
	{
		// Token: 0x06031401 RID: 201729 RVA: 0x00DC0363 File Offset: 0x00DBE563
		[NullableContext(1)]
		public void RegisterBattleView(BattleView battleView)
		{
			this.BattleView = battleView;
		}

		// Token: 0x06031402 RID: 201730 RVA: 0x00DC036C File Offset: 0x00DBE56C
		public UUIItem GetTopPanelPhoneMsgButtonItem()
		{
			return this.BattleView.GetTopPanelPhoneMsgButtonItem();
		}

		// Token: 0x06031403 RID: 201731 RVA: 0x00DC0379 File Offset: 0x00DBE579
		public IPhoneMessageButtonImplement GetTopPanelPhoneMsgButton()
		{
			return this.BattleView.GetTopPanelPhoneMsgButton();
		}

		// Token: 0x0401A14D RID: 106829
		public BattleHeadStatePanel HeadStatePanel;

		// Token: 0x0401A14E RID: 106830
		public BattleView BattleView;
	}
}
