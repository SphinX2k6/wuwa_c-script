using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.LineCross
{
	// Token: 0x02006561 RID: 25953
	internal class DifficultLineCrossItem : UiPanelBase
	{
		// Token: 0x06041096 RID: 266390 RVA: 0x00FC325C File Offset: 0x00FC145C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06041097 RID: 266391 RVA: 0x00FC3344 File Offset: 0x00FC1544
		protected override void OnStart()
		{
		}

		// Token: 0x06041098 RID: 266392 RVA: 0x00FC3348 File Offset: 0x00FC1548
		private bool OnCanExecuteChange()
		{
			LineCrossDetailViewModel lineCrossDetailViewModel = this.LineCrossDetailViewModel;
			bool? flag = (lineCrossDetailViewModel != null) ? new bool?(lineCrossDetailViewModel.GetChallengeLockState(this.Data.Value)) : null;
			if (flag != null && flag.Value)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("LineCross_Locked", Array.Empty<object>());
				return false;
			}
			return true;
		}

		// Token: 0x06041099 RID: 266393 RVA: 0x00FC33A9 File Offset: 0x00FC15A9
		[NullableContext(1)]
		public void SetModel(LineCrossDetailViewModel vm)
		{
			this.LineCrossDetailViewModel = vm;
		}

		// Token: 0x0604109A RID: 266394 RVA: 0x00FC33B2 File Offset: 0x00FC15B2
		private void OnClickToggle(EToggleState toggleState)
		{
			LineCrossDetailViewModel lineCrossDetailViewModel = this.LineCrossDetailViewModel;
			if (lineCrossDetailViewModel == null)
			{
				return;
			}
			lineCrossDetailViewModel.OnSelectChallenge(this.Data.Value);
		}

		// Token: 0x0604109B RID: 266395 RVA: 0x00FC33D0 File Offset: 0x00FC15D0
		public void Refresh(int data, int selectData)
		{
			this.Data = new int?(data);
			LineCrossDetailViewModel lineCrossDetailViewModel = this.LineCrossDetailViewModel;
			string text = (lineCrossDetailViewModel != null) ? lineCrossDetailViewModel.GetChallengeTitleId(data) : null;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), text ?? string.Empty, Array.Empty<object>());
			this.RefreshToggle(selectData);
			RedDotController.Instance.UnBindGivenUi(ERedDotName.LineCrossChallengeRedDot, base.GetItem(3), data);
			RedDotController.Instance.BindRedDot(ERedDotName.LineCrossChallengeRedDot, base.GetItem(3), null, data);
			LineCrossDetailViewModel lineCrossDetailViewModel2 = this.LineCrossDetailViewModel;
			bool? flag = (lineCrossDetailViewModel2 != null) ? new bool?(lineCrossDetailViewModel2.GetChallengeFinishState(data)) : null;
			UUIItem item = base.GetItem(2);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(flag != null && flag.Value);
		}

		// Token: 0x0604109C RID: 266396 RVA: 0x00FC3498 File Offset: 0x00FC1698
		public void RefreshToggle(int data)
		{
			LineCrossDetailViewModel lineCrossDetailViewModel = this.LineCrossDetailViewModel;
			bool? flag = (lineCrossDetailViewModel != null) ? new bool?(lineCrossDetailViewModel.GetChallengeLockState(this.Data.Value)) : null;
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle != null)
			{
				extendToggle.CanExecuteChange.Unbind();
			}
			int? data2 = this.Data;
			EToggleState etoggleState = (data2.GetValueOrDefault() == data & data2 != null) ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
			EToggleState state = (flag != null && flag.Value) ? EToggleState.ETT_UnDetermined : etoggleState;
			UUIExtendToggle extendToggle2 = base.GetExtendToggle(0);
			if (extendToggle2 != null)
			{
				extendToggle2.SetToggleState(state, false, false, false);
			}
			UUIExtendToggle extendToggle3 = base.GetExtendToggle(0);
			if (extendToggle3 == null)
			{
				return;
			}
			extendToggle3.CanExecuteChange.Bind(new Func<bool>(this.OnCanExecuteChange));
		}

		// Token: 0x04021E73 RID: 138867
		[Nullable(2)]
		private LineCrossDetailViewModel LineCrossDetailViewModel;

		// Token: 0x04021E74 RID: 138868
		private int? Data;

		// Token: 0x0200C758 RID: 51032
		private class EDifficultItem
		{
			// Token: 0x0403C3A3 RID: 246691
			public const int Toggle = 0;

			// Token: 0x0403C3A4 RID: 246692
			public const int Text = 1;

			// Token: 0x0403C3A5 RID: 246693
			public const int FinishItem = 2;

			// Token: 0x0403C3A6 RID: 246694
			public const int RedDot = 3;
		}
	}
}
