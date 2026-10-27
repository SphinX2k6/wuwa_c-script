using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Battle.Dialog;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.PhantomArena.Battle.View.Bvb
{
	// Token: 0x02005274 RID: 21108
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaBattleDetailsViewProxy
	{
		// Token: 0x06035FDB RID: 221147 RVA: 0x00CC6EC9 File Offset: 0x00CC50C9
		public void RegisterView(PhantomArenaBattleDetailsView view)
		{
			this.View = view;
		}

		// Token: 0x06035FDC RID: 221148 RVA: 0x00CC6ED4 File Offset: 0x00CC50D4
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

		// Token: 0x06035FDD RID: 221149 RVA: 0x00CC6F44 File Offset: 0x00CC5144
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

		// Token: 0x17008278 RID: 33400
		// (get) Token: 0x06035FDE RID: 221150 RVA: 0x00CC6FB4 File Offset: 0x00CC51B4
		public bool IsInGamepadNavigation
		{
			get
			{
				return this.IsInGamepadNavigationInternal;
			}
		}

		// Token: 0x06035FDF RID: 221151 RVA: 0x00CC6FBC File Offset: 0x00CC51BC
		public void SetIsInGamepadNavigation(bool isInGamepadNavigation)
		{
			this.IsInGamepadNavigationInternal = isInGamepadNavigation;
			InputDistributeController.Instance.RefreshInputTag();
		}

		// Token: 0x0401C96E RID: 117102
		private PhantomArenaBattleDetailsView View;

		// Token: 0x0401C96F RID: 117103
		private readonly Dictionary<long, int> OwnSettlePointMap = new Dictionary<long, int>();

		// Token: 0x0401C970 RID: 117104
		private readonly Dictionary<long, int> OpponentSettlePointMap = new Dictionary<long, int>();

		// Token: 0x0401C971 RID: 117105
		public PhantomArenaBattleDialog DialogManager = new PhantomArenaBattleDialog();

		// Token: 0x0401C972 RID: 117106
		private bool IsInGamepadNavigationInternal;
	}
}
