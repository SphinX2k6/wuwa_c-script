using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.FlagChallenge
{
	// Token: 0x02005A57 RID: 23127
	[NullableContext(1)]
	[Nullable(0)]
	public class FlagChallengeBuffAddPanel : UiPanelBase
	{
		// Token: 0x0603AA0C RID: 240140 RVA: 0x00DF4F50 File Offset: 0x00DF3150
		public FlagChallengeBuffAddPanel(int activityId)
		{
			this.ActivityId = activityId;
		}

		// Token: 0x0603AA0D RID: 240141 RVA: 0x00DF4F60 File Offset: 0x00DF3160
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(1, typeof(UUILayoutBase)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIText)),
				new ValueTuple<int, Type>(5, typeof(UUIText)),
				new ValueTuple<int, Type>(6, typeof(UUILayoutBase)),
				new ValueTuple<int, Type>(7, typeof(UUIItem)),
				new ValueTuple<int, Type>(8, typeof(UUIText))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action(this.OnBtnMask))
			};
		}

		// Token: 0x0603AA0E RID: 240142 RVA: 0x00DF5064 File Offset: 0x00DF3264
		protected override void OnStart()
		{
			UUILayoutBase layoutBase = base.GetLayoutBase(1);
			AUIBaseActor gridActor = base.GetItem(2).GetOwner() as AUIBaseActor;
			this.ItemLayout = new GenericLayout<FlagChallengeBuffAddItem, FlagChallengeBuffAddItemData>(layoutBase, new Func<FlagChallengeBuffAddItem>(this.CreateItem), gridActor, false, true);
			base.GetLayoutBase(6).RootUIComp.Get().SetUIActive(false);
			base.GetItem(7).SetUIActive(false);
		}

		// Token: 0x0603AA0F RID: 240143 RVA: 0x00DF50CD File Offset: 0x00DF32CD
		protected override void OnBeforeShow()
		{
			this.UpdateView();
		}

		// Token: 0x0603AA10 RID: 240144 RVA: 0x00DF50D5 File Offset: 0x00DF32D5
		protected override void OnBeforeDestroy()
		{
			if (base.GetActive())
			{
				Action closeCallback = this.CloseCallback;
				if (closeCallback == null)
				{
					return;
				}
				closeCallback();
			}
		}

		// Token: 0x0603AA11 RID: 240145 RVA: 0x00DF50EF File Offset: 0x00DF32EF
		private void OnBtnMask()
		{
			this.SetActive(false);
			Action closeCallback = this.CloseCallback;
			if (closeCallback == null)
			{
				return;
			}
			closeCallback();
		}

		// Token: 0x0603AA12 RID: 240146 RVA: 0x00DF5108 File Offset: 0x00DF3308
		private FlagChallengeBuffAddItem CreateItem()
		{
			return new FlagChallengeBuffAddItem();
		}

		// Token: 0x0603AA13 RID: 240147 RVA: 0x00DF510F File Offset: 0x00DF330F
		public void UpdateView()
		{
			this.UpdateTitle();
			this.UpdateLvAddDesc();
			this.UpdateList();
		}

		// Token: 0x0603AA14 RID: 240148 RVA: 0x00DF5124 File Offset: 0x00DF3324
		public void UpdateTitle()
		{
			string key = "Morale_title_22";
			base.GetText(4).ShowTextNew(key);
			base.GetText(8).SetUIActive(false);
		}

		// Token: 0x0603AA15 RID: 240149 RVA: 0x00DF5154 File Offset: 0x00DF3354
		public void UpdateList()
		{
			List<FlagChallengeBuffAddItemData> allRoleAttrAddList = FlagChallengeModel.Instance.GetAllRoleAttrAddList(this.ActivityId);
			this.ItemLayout.RefreshByData(allRoleAttrAddList, null, false);
		}

		// Token: 0x0603AA16 RID: 240150 RVA: 0x00DF5180 File Offset: 0x00DF3380
		public void UpdateLvAddDesc()
		{
			base.GetText(5).SetText(FlagChallengeModel.Instance.GetAllRoleAttrAddDesc(this.ActivityId), true);
		}

		// Token: 0x0603AA17 RID: 240151 RVA: 0x00DF519F File Offset: 0x00DF339F
		public void SetCloseCallback(Action callback)
		{
			this.CloseCallback = callback;
		}

		// Token: 0x0401E8FE RID: 125182
		public int ActivityId;

		// Token: 0x0401E8FF RID: 125183
		public GenericLayout<FlagChallengeBuffAddItem, FlagChallengeBuffAddItemData> ItemLayout;

		// Token: 0x0401E900 RID: 125184
		[Nullable(2)]
		private Action CloseCallback;
	}
}
