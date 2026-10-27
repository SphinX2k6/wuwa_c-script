using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x0200610F RID: 24847
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeSubViewBlessingSuitSelect : RoverlikeActionSubViewBase
	{
		// Token: 0x1700917A RID: 37242
		// (get) Token: 0x0603ED10 RID: 257296 RVA: 0x00F2B9EC File Offset: 0x00F29BEC
		public override ERoverActionSubViewType SubViewType
		{
			get
			{
				return ERoverActionSubViewType.BlessingSuitSelect;
			}
		}

		// Token: 0x1700917B RID: 37243
		// (get) Token: 0x0603ED11 RID: 257297 RVA: 0x00F2B9EF File Offset: 0x00F29BEF
		public override string ResourceId
		{
			get
			{
				return "UiItem_RoverlikeBlessingSetChoose";
			}
		}

		// Token: 0x0603ED12 RID: 257298 RVA: 0x00F2B9F8 File Offset: 0x00F29BF8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIScrollViewWithScrollbarComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnBtnArrowRightClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnBtnArrowLeftClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603ED13 RID: 257299 RVA: 0x00F2BB68 File Offset: 0x00F29D68
		protected override void OnStart()
		{
			this.ConfirmBtn = new ButtonItem(base.GetItem(6));
			this.ConfirmBtn.SetFunction(delegate(int _)
			{
				this.OnConfirmClick();
			});
			this.AttributeScroll = new GenericScrollViewNew<RoverlikeBlessingCardItem, IRoverlikeBlessingItemData>(base.GetScrollViewWithScrollbar(0), new Func<RoverlikeBlessingCardItem>(this.CreateAttributeItem), null, false, null);
			this.RoleLayout = new GenericLayout<RoverlikeBlessingRoleItem, IRoverlikeBlessingRoleData>(base.GetVerticalLayout(4), new Func<RoverlikeBlessingRoleItem>(this.CreateRoleItem), base.GetItem(5).GetOwner() as AUIBaseActor, false, true);
		}

		// Token: 0x0603ED14 RID: 257300 RVA: 0x00F2BBF0 File Offset: 0x00F29DF0
		private void OnBtnArrowRightClick()
		{
			if (this.AllSuitDataList.Count <= 1)
			{
				return;
			}
			this.CurrentSuitIndex = (this.CurrentSuitIndex + 1) % this.AllSuitDataList.Count;
			this.RefreshCurrentSuit();
		}

		// Token: 0x0603ED15 RID: 257301 RVA: 0x00F2BC21 File Offset: 0x00F29E21
		private void OnBtnArrowLeftClick()
		{
			if (this.AllSuitDataList.Count <= 1)
			{
				return;
			}
			this.CurrentSuitIndex = (this.CurrentSuitIndex - 1 + this.AllSuitDataList.Count) % this.AllSuitDataList.Count;
			this.RefreshCurrentSuit();
		}

		// Token: 0x0603ED16 RID: 257302 RVA: 0x00F2BC5E File Offset: 0x00F29E5E
		private void OnConfirmClick()
		{
			base.TryInteractAction(delegate
			{
				IRoverlikeBlessingSuitData roverlikeBlessingSuitData = this.AllSuitDataList[this.CurrentSuitIndex];
				if (roverlikeBlessingSuitData == null)
				{
					return;
				}
				RoverlikeActivityData currentActivityData = RoverlikeActivityController.Instance.GetCurrentActivityData();
				if (currentActivityData == null)
				{
					return;
				}
				RoverlikeController.Instance.RoverRogueBlessGroupSelectRequest(currentActivityData.Id, roverlikeBlessingSuitData.SuitId, delegate(bool isSuccess)
				{
					if (isSuccess)
					{
						RoverlikeController.Instance.FinishActionSubView(this.IncId);
					}
				});
			});
		}

		// Token: 0x0603ED17 RID: 257303 RVA: 0x00F2BC74 File Offset: 0x00F29E74
		private void OnRoleItemClick(IRoverlikeBlessingRoleData data)
		{
			if (this.GetCurrentRoleId() == data.RoleId)
			{
				return;
			}
			int currentSuitIndex;
			if (this.RoleIdToSuitIndexMap.TryGetValue(data.RoleId, out currentSuitIndex))
			{
				this.CurrentSuitIndex = currentSuitIndex;
				this.RefreshCurrentSuit();
			}
		}

		// Token: 0x0603ED18 RID: 257304 RVA: 0x00F2BCB2 File Offset: 0x00F29EB2
		private RoverlikeBlessingCardItem CreateAttributeItem()
		{
			return new RoverlikeBlessingCardItem();
		}

		// Token: 0x0603ED19 RID: 257305 RVA: 0x00F2BCB9 File Offset: 0x00F29EB9
		private RoverlikeBlessingRoleItem CreateRoleItem()
		{
			RoverlikeBlessingRoleItem roverlikeBlessingRoleItem = new RoverlikeBlessingRoleItem();
			roverlikeBlessingRoleItem.BindOnRoleClick(new Action<IRoverlikeBlessingRoleData>(this.OnRoleItemClick));
			return roverlikeBlessingRoleItem;
		}

		// Token: 0x0603ED1A RID: 257306 RVA: 0x00F2BCD2 File Offset: 0x00F29ED2
		private void RefreshCurrentSuit()
		{
			this.SelectCurrentRole();
			this.RefreshAttributeScroll();
		}

		// Token: 0x0603ED1B RID: 257307 RVA: 0x00F2BCE0 File Offset: 0x00F29EE0
		private void InitRoleSlots()
		{
			HashSet<int> hashSet = new HashSet<int>();
			this.RoleDataList = new List<IRoverlikeBlessingRoleData>();
			this.RoleIdToSuitIndexMap.Clear();
			for (int i = 0; i < this.AllSuitDataList.Count; i++)
			{
				RoverRogueBlessGroup? blessGroupConfig = RoverlikeConfig.Instance.GetBlessGroupConfig(this.AllSuitDataList[i].SuitId);
				if (blessGroupConfig != null && !hashSet.Contains(blessGroupConfig.Value.BlessRoleId))
				{
					hashSet.Add(blessGroupConfig.Value.BlessRoleId);
					this.RoleIdToSuitIndexMap[blessGroupConfig.Value.BlessRoleId] = i;
					RoverlikeBlessingRoleData item = new RoverlikeBlessingRoleData
					{
						RoleId = blessGroupConfig.Value.BlessRoleId,
						IsSelected = false
					};
					this.RoleDataList.Add(item);
				}
			}
			this.RefreshRoleLayout();
		}

		// Token: 0x0603ED1C RID: 257308 RVA: 0x00F2BDC8 File Offset: 0x00F29FC8
		private void RefreshRoleLayout()
		{
			bool uiactive = this.RoleDataList.Count > 1;
			base.GetButton(2).RootUIComp.Get().SetUIActive(uiactive);
			base.GetButton(3).RootUIComp.Get().SetUIActive(uiactive);
			GenericLayout<RoverlikeBlessingRoleItem, IRoverlikeBlessingRoleData> roleLayout = this.RoleLayout;
			if (roleLayout == null)
			{
				return;
			}
			roleLayout.RefreshByData(this.RoleDataList, delegate
			{
				this.SelectCurrentRole();
			}, true);
		}

		// Token: 0x0603ED1D RID: 257309 RVA: 0x00F2BE3C File Offset: 0x00F2A03C
		private void SelectCurrentRole()
		{
			int currentRoleId = this.GetCurrentRoleId();
			if (currentRoleId > 0)
			{
				GenericLayout<RoverlikeBlessingRoleItem, IRoverlikeBlessingRoleData> roleLayout = this.RoleLayout;
				if (roleLayout == null)
				{
					return;
				}
				roleLayout.SelectGridProxyByKey(currentRoleId, false);
			}
		}

		// Token: 0x0603ED1E RID: 257310 RVA: 0x00F2BE6C File Offset: 0x00F2A06C
		private int GetCurrentRoleId()
		{
			IRoverlikeBlessingSuitData roverlikeBlessingSuitData = this.AllSuitDataList[this.CurrentSuitIndex];
			if (roverlikeBlessingSuitData == null)
			{
				return 0;
			}
			RoverRogueBlessGroup? blessGroupConfig = RoverlikeConfig.Instance.GetBlessGroupConfig(roverlikeBlessingSuitData.SuitId);
			if (blessGroupConfig == null)
			{
				return 0;
			}
			return blessGroupConfig.GetValueOrDefault().BlessRoleId;
		}

		// Token: 0x0603ED1F RID: 257311 RVA: 0x00F2BEBC File Offset: 0x00F2A0BC
		private void RefreshAttributeScroll()
		{
			IRoverlikeBlessingSuitData roverlikeBlessingSuitData = this.AllSuitDataList[this.CurrentSuitIndex];
			if (roverlikeBlessingSuitData == null)
			{
				return;
			}
			List<IRoverlikeBlessingItemData> list = new List<IRoverlikeBlessingItemData>();
			foreach (int blessId in roverlikeBlessingSuitData.BlessingIdList)
			{
				list.Add(new RoverlikeBlessingItemData
				{
					BlessId = blessId,
					AllowToggleInteract = new bool?(false)
				});
			}
			this.AttributeScroll.RefreshByData(list, new Action(this.OnAttributeScrollRefreshed), true);
		}

		// Token: 0x0603ED20 RID: 257312 RVA: 0x00F2BF5C File Offset: 0x00F2A15C
		private void OnAttributeScrollRefreshed()
		{
			EventSystem.Instance.Emit<string>(EEventName.OnGuideTriggerEvent, "RoverlikeBlessingSuitSelect");
		}

		// Token: 0x0603ED21 RID: 257313 RVA: 0x00F2BF74 File Offset: 0x00F2A174
		public override void OnRefreshSubView()
		{
			IRoverlikeBlessingSuitSelectParam roverlikeBlessingSuitSelectParam = this.OpenParam as IRoverlikeBlessingSuitSelectParam;
			if (roverlikeBlessingSuitSelectParam == null || roverlikeBlessingSuitSelectParam.SuitDataList.Count == 0)
			{
				return;
			}
			this.AllSuitDataList = roverlikeBlessingSuitSelectParam.SuitDataList;
			this.CurrentSuitIndex = roverlikeBlessingSuitSelectParam.SelectedIndex;
			this.InitRoleSlots();
			this.RefreshAttributeScroll();
		}

		// Token: 0x04020D05 RID: 134405
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<RoverlikeBlessingCardItem, IRoverlikeBlessingItemData> AttributeScroll;

		// Token: 0x04020D06 RID: 134406
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RoverlikeBlessingRoleItem, IRoverlikeBlessingRoleData> RoleLayout;

		// Token: 0x04020D07 RID: 134407
		private List<IRoverlikeBlessingRoleData> RoleDataList = new List<IRoverlikeBlessingRoleData>();

		// Token: 0x04020D08 RID: 134408
		[Nullable(2)]
		private ButtonItem ConfirmBtn;

		// Token: 0x04020D09 RID: 134409
		private List<IRoverlikeBlessingSuitData> AllSuitDataList = new List<IRoverlikeBlessingSuitData>();

		// Token: 0x04020D0A RID: 134410
		private int CurrentSuitIndex;

		// Token: 0x04020D0B RID: 134411
		private readonly Dictionary<int, int> RoleIdToSuitIndexMap = new Dictionary<int, int>();

		// Token: 0x0200C367 RID: 50023
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403AF7E RID: 241534
			public const int ScrollView = 0;

			// Token: 0x0403AF7F RID: 241535
			public const int ItemAttribute = 1;

			// Token: 0x0403AF80 RID: 241536
			public const int BtnArrowRight = 2;

			// Token: 0x0403AF81 RID: 241537
			public const int BtnArrowLeft = 3;

			// Token: 0x0403AF82 RID: 241538
			public const int RoleLayout = 4;

			// Token: 0x0403AF83 RID: 241539
			public const int ItemRoleTemplate = 5;

			// Token: 0x0403AF84 RID: 241540
			public const int ItemConfirm = 6;
		}
	}
}
