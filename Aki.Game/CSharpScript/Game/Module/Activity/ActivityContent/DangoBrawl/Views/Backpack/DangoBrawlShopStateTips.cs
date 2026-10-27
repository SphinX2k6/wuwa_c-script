using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Views.Backpack
{
	// Token: 0x0200684F RID: 26703
	public class DangoBrawlShopStateTips : UiViewBase
	{
		// Token: 0x06042AA8 RID: 273064 RVA: 0x01036ADC File Offset: 0x01034CDC
		[NullableContext(1)]
		public DangoBrawlShopStateTips(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06042AA9 RID: 273065 RVA: 0x01036AE8 File Offset: 0x01034CE8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06042AAA RID: 273066 RVA: 0x01036B72 File Offset: 0x01034D72
		protected override void OnBeforeShow()
		{
			this.RefreshGenderPanel();
			this.RefreshRoundNum();
		}

		// Token: 0x06042AAB RID: 273067 RVA: 0x01036B80 File Offset: 0x01034D80
		protected override void OnAfterShow()
		{
			base.CloseMe(null);
		}

		// Token: 0x06042AAC RID: 273068 RVA: 0x01036B89 File Offset: 0x01034D89
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Emit(EEventName.OnDangoBrawlShopStateTipsClosed);
		}

		// Token: 0x06042AAD RID: 273069 RVA: 0x01036B9C File Offset: 0x01034D9C
		private void RefreshGenderPanel()
		{
			bool flag = PlayerInfoModel.Instance.GetPlayerGender() == EPlayerGender.Male;
			UUIItem item = base.GetItem(0);
			if (item != null)
			{
				item.SetUIActive(flag);
			}
			UUIItem item2 = base.GetItem(1);
			if (item2 == null)
			{
				return;
			}
			item2.SetUIActive(!flag);
		}

		// Token: 0x06042AAE RID: 273070 RVA: 0x01036BE0 File Offset: 0x01034DE0
		private void RefreshRoundNum()
		{
			ActivityDangoBrawlData myActivityData = ActivityDangoBrawlController.Instance.MyActivityData;
			int num = (myActivityData != null) ? myActivityData.GetShopRound() : 0;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "DangoBrawlBattleUIText_026", new <>z__ReadOnlySingleElementList<object>(num));
		}

		// Token: 0x0200CA1E RID: 51742
		private enum EComponent
		{
			// Token: 0x0403D145 RID: 250181
			PnlMale,
			// Token: 0x0403D146 RID: 250182
			PnlFemale,
			// Token: 0x0403D147 RID: 250183
			TxtRoundNum
		}
	}
}
