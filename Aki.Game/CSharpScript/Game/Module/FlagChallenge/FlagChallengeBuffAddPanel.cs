using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.FlagChallenge
{
	// Token: 0x02004A33 RID: 18995
	[NullableContext(1)]
	[Nullable(0)]
	public class FlagChallengeBuffAddPanel : UiPanelBase
	{
		// Token: 0x0602F955 RID: 194901 RVA: 0x00D454D4 File Offset: 0x00D436D4
		public FlagChallengeBuffAddPanel(int activityId)
		{
			this.ActivityId = activityId;
		}

		// Token: 0x0602F956 RID: 194902 RVA: 0x00D454E4 File Offset: 0x00D436E4
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

		// Token: 0x0602F957 RID: 194903 RVA: 0x00D455E8 File Offset: 0x00D437E8
		protected override void OnStart()
		{
			UUILayoutBase layoutBase = base.GetLayoutBase(1);
			AUIBaseActor gridActor = base.GetItem(2).GetOwner() as AUIBaseActor;
			this.ItemLayout = new GenericLayout<FlagChallengeBuffAddItem, FlagChallengeBuffAddItemData>(layoutBase, new Func<FlagChallengeBuffAddItem>(this.CreateItem), gridActor, false, true);
			base.GetLayoutBase(6).RootUIComp.Get().SetUIActive(false);
			base.GetItem(7).SetUIActive(false);
		}

		// Token: 0x0602F958 RID: 194904 RVA: 0x00D45651 File Offset: 0x00D43851
		protected override void OnBeforeShow()
		{
			this.UpdateView();
		}

		// Token: 0x0602F959 RID: 194905 RVA: 0x00D45659 File Offset: 0x00D43859
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

		// Token: 0x0602F95A RID: 194906 RVA: 0x00D45673 File Offset: 0x00D43873
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

		// Token: 0x0602F95B RID: 194907 RVA: 0x00D4568C File Offset: 0x00D4388C
		private FlagChallengeBuffAddItem CreateItem()
		{
			return new FlagChallengeBuffAddItem();
		}

		// Token: 0x0602F95C RID: 194908 RVA: 0x00D45693 File Offset: 0x00D43893
		public void UpdateView()
		{
			this.UpdateTitle();
			this.UpdateLvAddDesc();
			this.UpdateList();
		}

		// Token: 0x0602F95D RID: 194909 RVA: 0x00D456A8 File Offset: 0x00D438A8
		public void UpdateTitle()
		{
			string key = "Morale_title_22";
			base.GetText(4).ShowTextNew(key);
			base.GetText(8).SetUIActive(false);
		}

		// Token: 0x0602F95E RID: 194910 RVA: 0x00D456D8 File Offset: 0x00D438D8
		public void UpdateList()
		{
			List<FlagChallengeBuffAddItemData> allRoleAttrAddList = FlagChallengeModel.Instance.GetAllRoleAttrAddList(this.ActivityId);
			this.ItemLayout.RefreshByData(allRoleAttrAddList, null, false);
		}

		// Token: 0x0602F95F RID: 194911 RVA: 0x00D45704 File Offset: 0x00D43904
		public void UpdateLvAddDesc()
		{
			base.GetText(5).SetText(FlagChallengeModel.Instance.GetAllRoleAttrAddDesc(this.ActivityId), true);
		}

		// Token: 0x0602F960 RID: 194912 RVA: 0x00D45723 File Offset: 0x00D43923
		public void SetCloseCallback(Action callback)
		{
			this.CloseCallback = callback;
		}

		// Token: 0x040193A5 RID: 103333
		public int ActivityId;

		// Token: 0x040193A6 RID: 103334
		public GenericLayout<FlagChallengeBuffAddItem, FlagChallengeBuffAddItemData> ItemLayout;

		// Token: 0x040193A7 RID: 103335
		[Nullable(2)]
		private Action CloseCallback;
	}
}
