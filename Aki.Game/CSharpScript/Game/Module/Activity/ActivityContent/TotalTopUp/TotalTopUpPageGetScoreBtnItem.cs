using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp
{
	// Token: 0x02005FBB RID: 24507
	public class TotalTopUpPageGetScoreBtnItem : UiPanelBase
	{
		// Token: 0x0603E203 RID: 254467 RVA: 0x00F00FF0 File Offset: 0x00EFF1F0
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

		// Token: 0x0603E204 RID: 254468 RVA: 0x00F01057 File Offset: 0x00EFF257
		protected override void OnStart()
		{
			UUIItem item = base.GetItem(1);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(false);
		}

		// Token: 0x0603E205 RID: 254469 RVA: 0x00F0106B File Offset: 0x00EFF26B
		private void OnClickReward()
		{
			Action onClickCallback = this.OnClickCallback;
			if (onClickCallback == null)
			{
				return;
			}
			onClickCallback();
		}

		// Token: 0x04020749 RID: 132937
		[Nullable(2)]
		public Action OnClickCallback;

		// Token: 0x0200C292 RID: 49810
		private class ENode
		{
			// Token: 0x0403AC74 RID: 240756
			public const int Btn = 0;

			// Token: 0x0403AC75 RID: 240757
			public const int ItemRedDot = 1;
		}
	}
}
