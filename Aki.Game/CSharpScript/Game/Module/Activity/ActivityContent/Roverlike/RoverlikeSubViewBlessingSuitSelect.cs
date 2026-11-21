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
	// Token: 0x0200508D RID: 20621
	[NullableContext(1)]
	[Nullable(0)]
	public class RoverlikeSubViewBlessingSuitSelect : RoverlikeActionSubViewBase
	{
		// Token: 0x170064DC RID: 25820
		// (get) Token: 0x060339D2 RID: 211410 RVA: 0x00E72800 File Offset: 0x00E70A00
		public override ERoverActionSubViewType SubViewType
		{
			get
			{
				return ERoverActionSubViewType.BlessingSuitSelect;
			}
		}

		// Token: 0x170064DD RID: 25821
		// (get) Token: 0x060339D3 RID: 211411 RVA: 0x00E72803 File Offset: 0x00E70A03
		public override string ResourceId
		{
			get
			{
				return "UiItem_RoverlikeBlessingSetChoose";
			}
		}

		// Token: 0x060339D4 RID: 211412 RVA: 0x00E7280C File Offset: 0x00E70A0C
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

		// Token: 0x060339D5 RID: 211413 RVA: 0x00E7297C File Offset: 0x00E70B7C
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

		// Token: 0x060339D6 RID: 211414 RVA: 0x00E72A04 File Offset: 0x00E70C04
		private void OnBtnArrowRightClick()
		{
			if (this.AllSuitDataList.Count <= 1)
			{
				return;
			}
			this.CurrentSuitIndex = (this.CurrentSuitIndex + 1) % this.AllSuitDataList.Count;
			this.RefreshCurrentSuit();
		}

		// Token: 0x060339D7 RID: 211415 RVA: 0x00E72A35 File Offset: 0x00E70C35
		private void OnBtnArrowLeftClick()
		{
			if (this.AllSuitDataList.Count <= 1)
			{
				return;
			}
			this.CurrentSuitIndex = (this.CurrentSuitIndex - 1 + this.AllSuitDataList.Count) % this.AllSuitDataList.Count;
			this.RefreshCurrentSuit();
		}

		// Token: 0x060339D8 RID: 211416 RVA: 0x00E72A72 File Offset: 0x00E70C72
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

		// Token: 0x060339D9 RID: 211417 RVA: 0x00E72A88 File Offset: 0x00E70C88
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

		// Token: 0x060339DA RID: 211418 RVA: 0x00E72AC6 File Offset: 0x00E70CC6
		private RoverlikeBlessingCardItem CreateAttributeItem()
		{
			return new RoverlikeBlessingCardItem();
		}

		// Token: 0x060339DB RID: 211419 RVA: 0x00E72ACD File Offset: 0x00E70CCD
		private RoverlikeBlessingRoleItem CreateRoleItem()
		{
			RoverlikeBlessingRoleItem roverlikeBlessingRoleItem = new RoverlikeBlessingRoleItem();
			roverlikeBlessingRoleItem.BindOnRoleClick(new Action<IRoverlikeBlessingRoleData>(this.OnRoleItemClick));
			return roverlikeBlessingRoleItem;
		}

		// Token: 0x060339DC RID: 211420 RVA: 0x00E72AE6 File Offset: 0x00E70CE6
		private void RefreshCurrentSuit()
		{
			this.SelectCurrentRole();
			this.RefreshAttributeScroll();
		}

		// Token: 0x060339DD RID: 211421 RVA: 0x00E72AF4 File Offset: 0x00E70CF4
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

		// Token: 0x060339DE RID: 211422 RVA: 0x00E72BDC File Offset: 0x00E70DDC
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

		// Token: 0x060339DF RID: 211423 RVA: 0x00E72C50 File Offset: 0x00E70E50
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

		// Token: 0x060339E0 RID: 211424 RVA: 0x00E72C80 File Offset: 0x00E70E80
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

		// Token: 0x060339E1 RID: 211425 RVA: 0x00E72CD0 File Offset: 0x00E70ED0
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

		// Token: 0x060339E2 RID: 211426 RVA: 0x00E72D70 File Offset: 0x00E70F70
		private void OnAttributeScrollRefreshed()
		{
			EventSystem.Instance.Emit<string>(EEventName.OnGuideTriggerEvent, "RoverlikeBlessingSuitSelect");
		}

		// Token: 0x060339E3 RID: 211427 RVA: 0x00E72D88 File Offset: 0x00E70F88
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

		// Token: 0x0401B632 RID: 112178
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<RoverlikeBlessingCardItem, IRoverlikeBlessingItemData> AttributeScroll;

		// Token: 0x0401B633 RID: 112179
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RoverlikeBlessingRoleItem, IRoverlikeBlessingRoleData> RoleLayout;

		// Token: 0x0401B634 RID: 112180
		private List<IRoverlikeBlessingRoleData> RoleDataList = new List<IRoverlikeBlessingRoleData>();

		// Token: 0x0401B635 RID: 112181
		[Nullable(2)]
		private ButtonItem ConfirmBtn;

		// Token: 0x0401B636 RID: 112182
		private List<IRoverlikeBlessingSuitData> AllSuitDataList = new List<IRoverlikeBlessingSuitData>();

		// Token: 0x0401B637 RID: 112183
		private int CurrentSuitIndex;

		// Token: 0x0401B638 RID: 112184
		private readonly Dictionary<int, int> RoleIdToSuitIndexMap = new Dictionary<int, int>();

		// Token: 0x0200AD4F RID: 44367
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x040358E3 RID: 219363
			public const int ScrollView = 0;

			// Token: 0x040358E4 RID: 219364
			public const int ItemAttribute = 1;

			// Token: 0x040358E5 RID: 219365
			public const int BtnArrowRight = 2;

			// Token: 0x040358E6 RID: 219366
			public const int BtnArrowLeft = 3;

			// Token: 0x040358E7 RID: 219367
			public const int RoleLayout = 4;

			// Token: 0x040358E8 RID: 219368
			public const int ItemRoleTemplate = 5;

			// Token: 0x040358E9 RID: 219369
			public const int ItemConfirm = 6;
		}
	}
}
