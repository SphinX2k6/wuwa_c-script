using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Battle.Dialog;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.PhantomArena.Battle.View.Bvb
{
	// Token: 0x02004244 RID: 16964
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaBattleDetailsViewProxy
	{
		// Token: 0x0602AED6 RID: 175830 RVA: 0x00C145C9 File Offset: 0x00C127C9
		public void RegisterView(PhantomArenaBattleDetailsView view)
		{
			this.View = view;
		}

		// Token: 0x0602AED7 RID: 175831 RVA: 0x00C145D4 File Offset: 0x00C127D4
		public void SetOwnAllSettlePoint(long entityId, int settlePoint)
		{
			this.OwnSettlePointMap[entityId] = settlePoint;
			int num = 0;
			foreach (int num2 in this.OwnSettlePointMap.Values)
			{
				num += num2;
			}
			this.View.SetOwnAllSettlePoint(num);
		}

		// Token: 0x0602AED8 RID: 175832 RVA: 0x00C14644 File Offset: 0x00C12844
		public void SetOpponentSettlePoint(long entityId, int settlePoint)
		{
			this.OpponentSettlePointMap[entityId] = settlePoint;
			int num = 0;
			foreach (int num2 in this.OpponentSettlePointMap.Values)
			{
				num += num2;
			}
			this.View.SetOpponentSettlePoint(num);
		}

		// Token: 0x17005638 RID: 22072
		// (get) Token: 0x0602AED9 RID: 175833 RVA: 0x00C146B4 File Offset: 0x00C128B4
		public bool IsInGamepadNavigation
		{
			get
			{
				return this.IsInGamepadNavigationInternal;
			}
		}

		// Token: 0x0602AEDA RID: 175834 RVA: 0x00C146BC File Offset: 0x00C128BC
		public void SetIsInGamepadNavigation(bool isInGamepadNavigation)
		{
			this.IsInGamepadNavigationInternal = isInGamepadNavigation;
			InputDistributeController.Instance.RefreshInputTag();
		}

		// Token: 0x040173A3 RID: 95139
		private PhantomArenaBattleDetailsView View;

		// Token: 0x040173A4 RID: 95140
		private readonly Dictionary<long, int> OwnSettlePointMap = new Dictionary<long, int>();

		// Token: 0x040173A5 RID: 95141
		private readonly Dictionary<long, int> OpponentSettlePointMap = new Dictionary<long, int>();

		// Token: 0x040173A6 RID: 95142
		public PhantomArenaBattleDialog DialogManager = new PhantomArenaBattleDialog();

		// Token: 0x040173A7 RID: 95143
		private bool IsInGamepadNavigationInternal;
	}
}
