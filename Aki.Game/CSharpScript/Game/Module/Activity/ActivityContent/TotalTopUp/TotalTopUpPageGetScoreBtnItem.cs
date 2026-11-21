using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp
{
	// Token: 0x02004FA2 RID: 20386
	public class TotalTopUpPageGetScoreBtnItem : UiPanelBase
	{
		// Token: 0x0603319D RID: 209309 RVA: 0x00E52CAC File Offset: 0x00E50EAC
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action(this.OnClickReward))
			};
		}

		// Token: 0x0603319E RID: 209310 RVA: 0x00E52D13 File Offset: 0x00E50F13
		protected override void OnStart()
		{
			UUIItem item = base.GetItem(1);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(false);
		}

		// Token: 0x0603319F RID: 209311 RVA: 0x00E52D27 File Offset: 0x00E50F27
		private void OnClickReward()
		{
			Action onClickCallback = this.OnClickCallback;
			if (onClickCallback == null)
			{
				return;
			}
			onClickCallback();
		}

		// Token: 0x0401B21B RID: 111131
		[Nullable(2)]
		public Action OnClickCallback;

		// Token: 0x0200AC9D RID: 44189
		private class ENode
		{
			// Token: 0x04035650 RID: 218704
			public const int Btn = 0;

			// Token: 0x04035651 RID: 218705
			public const int ItemRedDot = 1;
		}
	}
}
