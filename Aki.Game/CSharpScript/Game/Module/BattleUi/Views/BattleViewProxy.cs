using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhoneMessage.View;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005CF9 RID: 23801
	[NullableContext(2)]
	[Nullable(0)]
	public class BattleViewProxy
	{
		// Token: 0x0603C4A8 RID: 246952 RVA: 0x00E6FCFB File Offset: 0x00E6DEFB
		[NullableContext(1)]
		public void RegisterBattleView(BattleView battleView)
		{
			this.BattleView = battleView;
		}

		// Token: 0x0603C4A9 RID: 246953 RVA: 0x00E6FD04 File Offset: 0x00E6DF04
		public UUIItem GetTopPanelPhoneMsgButtonItem()
		{
			return this.BattleView.GetTopPanelPhoneMsgButtonItem();
		}

		// Token: 0x0603C4AA RID: 246954 RVA: 0x00E6FD11 File Offset: 0x00E6DF11
		public IPhoneMessageButtonImplement GetTopPanelPhoneMsgButton()
		{
			return this.BattleView.GetTopPanelPhoneMsgButton();
		}

		// Token: 0x0401F694 RID: 128660
		public BattleHeadStatePanel HeadStatePanel;

		// Token: 0x0401F695 RID: 128661
		public BattleView BattleView;
	}
}
