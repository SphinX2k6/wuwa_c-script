using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Views.Backpack
{
	// Token: 0x0200579F RID: 22431
	public class DangoBrawlShopStateTips : UiViewBase
	{
		// Token: 0x060375FD RID: 226813 RVA: 0x00F78028 File Offset: 0x00F76228
		[NullableContext(1)]
		public DangoBrawlShopStateTips(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060375FE RID: 226814 RVA: 0x00F78034 File Offset: 0x00F76234
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

		// Token: 0x060375FF RID: 226815 RVA: 0x00F780BE File Offset: 0x00F762BE
		protected override void OnBeforeShow()
		{
			this.RefreshGenderPanel();
			this.RefreshRoundNum();
		}

		// Token: 0x06037600 RID: 226816 RVA: 0x00F780CC File Offset: 0x00F762CC
		protected override void OnAfterShow()
		{
			base.CloseMe(null);
		}

		// Token: 0x06037601 RID: 226817 RVA: 0x00F780D5 File Offset: 0x00F762D5
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Emit(EEventName.OnDangoBrawlShopStateTipsClosed);
		}

		// Token: 0x06037602 RID: 226818 RVA: 0x00F780E8 File Offset: 0x00F762E8
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

		// Token: 0x06037603 RID: 226819 RVA: 0x00F7812C File Offset: 0x00F7632C
		private void RefreshRoundNum()
		{
			ActivityDangoBrawlData myActivityData = ActivityDangoBrawlController.Instance.MyActivityData;
			int num = (myActivityData != null) ? myActivityData.GetShopRound() : 0;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), "DangoBrawlBattleUIText_026", new <>z__ReadOnlySingleElementList<object>(num));
		}

		// Token: 0x0200B3E8 RID: 46056
		private enum EComponent
		{
			// Token: 0x04037A2A RID: 227882
			PnlMale,
			// Token: 0x04037A2B RID: 227883
			PnlFemale,
			// Token: 0x04037A2C RID: 227884
			TxtRoundNum
		}
	}
}
