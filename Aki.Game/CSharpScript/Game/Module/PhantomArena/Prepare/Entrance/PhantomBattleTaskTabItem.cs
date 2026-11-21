using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.Entrance
{
	// Token: 0x02004138 RID: 16696
	public class PhantomBattleTaskTabItem : GridProxyAbstract<int>
	{
		// Token: 0x0602A37B RID: 172923 RVA: 0x00BEB45C File Offset: 0x00BE965C
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

		// Token: 0x0602A37C RID: 172924 RVA: 0x00BEB4DC File Offset: 0x00BE96DC
		public override void Refresh(int data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			PhantomBattleTaskTab? taskTabConfigById = PhantomArenaConfig.Instance.GetTaskTabConfigById(data);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), taskTabConfigById.Value.Title, Array.Empty<object>());
			this.RefreshRedDot();
		}

		// Token: 0x0602A37D RID: 172925 RVA: 0x00BEB528 File Offset: 0x00BE9728
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

		// Token: 0x0602A37E RID: 172926 RVA: 0x00BEB55E File Offset: 0x00BE975E
		private void OnClicked(EToggleState toggleState)
		{
			if (this.OnClickedCb != null)
			{
				this.OnClickedCb(this.Data);
			}
		}

		// Token: 0x0602A37F RID: 172927 RVA: 0x00BEB57C File Offset: 0x00BE977C
		public void SetToggleState(bool bSelect, bool bFire)
		{
			EToggleState state = bSelect ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			base.GetExtendToggle(0).SetToggleState(state, bFire, false, false);
		}

		// Token: 0x04016FA9 RID: 94121
		private int Data;

		// Token: 0x04016FAA RID: 94122
		public int ActivityId;

		// Token: 0x04016FAB RID: 94123
		[Nullable(2)]
		public Action<int> OnClickedCb;

		// Token: 0x02009D04 RID: 40196
		private class ETabComponents
		{
			// Token: 0x04030D11 RID: 199953
			public const int Toggle = 0;

			// Token: 0x04030D12 RID: 199954
			public const int Title = 1;

			// Token: 0x04030D13 RID: 199955
			public const int RedDot = 2;
		}
	}
}
