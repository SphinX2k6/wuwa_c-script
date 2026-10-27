using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.Entrance
{
	// Token: 0x02005168 RID: 20840
	public class PhantomBattleTaskTabItem : GridProxyAbstract<int>
	{
		// Token: 0x0603547F RID: 218239 RVA: 0x00C9DF10 File Offset: 0x00C9C110
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClicked))
			};
		}

		// Token: 0x06035480 RID: 218240 RVA: 0x00C9DF90 File Offset: 0x00C9C190
		public override void Refresh(int data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			PhantomBattleTaskTab? taskTabConfigById = PhantomArenaConfig.Instance.GetTaskTabConfigById(data);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), taskTabConfigById.Value.Title, Array.Empty<object>());
			this.RefreshRedDot();
		}

		// Token: 0x06035481 RID: 218241 RVA: 0x00C9DFDC File Offset: 0x00C9C1DC
		public void RefreshRedDot()
		{
			bool uiactive = PhantomArenaModel.Instance.CheckTaskRedDotByTab(this.Data, this.ActivityId);
			UUIItem item = base.GetItem(2);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(uiactive);
		}

		// Token: 0x06035482 RID: 218242 RVA: 0x00C9E012 File Offset: 0x00C9C212
		private void OnClicked(EToggleState toggleState)
		{
			if (this.OnClickedCb != null)
			{
				this.OnClickedCb(this.Data);
			}
		}

		// Token: 0x06035483 RID: 218243 RVA: 0x00C9E030 File Offset: 0x00C9C230
		public void SetToggleState(bool bSelect, bool bFire)
		{
			EToggleState state = bSelect ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			base.GetExtendToggle(0).SetToggleState(state, bFire, false, false);
		}

		// Token: 0x0401C574 RID: 116084
		private int Data;

		// Token: 0x0401C575 RID: 116085
		public int ActivityId;

		// Token: 0x0401C576 RID: 116086
		[Nullable(2)]
		public Action<int> OnClickedCb;

		// Token: 0x0200B2CA RID: 45770
		private class ETabComponents
		{
			// Token: 0x040362BA RID: 221882
			public const int Toggle = 0;

			// Token: 0x040362BB RID: 221883
			public const int Title = 1;

			// Token: 0x040362BC RID: 221884
			public const int RedDot = 2;
		}
	}
}
