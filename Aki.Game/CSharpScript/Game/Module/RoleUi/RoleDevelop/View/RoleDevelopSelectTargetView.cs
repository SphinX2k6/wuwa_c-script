using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.RoleUi.RoleDevelop.Data;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.RoleUi.RoleDevelop.View
{
	// Token: 0x02003D1D RID: 15645
	[NullableContext(1)]
	[Nullable(0)]
	public class RoleDevelopSelectTargetView : UiViewBase
	{
		// Token: 0x060280D5 RID: 164053 RVA: 0x00B37400 File Offset: 0x00B35600
		public RoleDevelopSelectTargetView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x060280D6 RID: 164054 RVA: 0x00B37420 File Offset: 0x00B35620
		protected unsafe override void OnRegisterComponent()
		{
			int num = 15;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIGridLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIGridLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIScrollViewWithScrollbarComponent));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060280D7 RID: 164055 RVA: 0x00B37640 File Offset: 0x00B35840
		protected override UniTask OnBeforeStartAsync()
		{
			RoleDevelopSelectTargetView.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoleDevelopSelectTargetView.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060280D8 RID: 164056 RVA: 0x00B37683 File Offset: 0x00B35883
		protected override void OnStart()
		{
			this.RefreshRoleGridLayout();
			this.RefreshHotRoleGridLayout();
			EventSystem.Instance.Add(EEventName.RoleDevTargetRoleIdChange, new Action(this.OnRoleDevTargetRoleIdChange));
		}

		// Token: 0x060280D9 RID: 164057 RVA: 0x00B376AD File Offset: 0x00B358AD
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove(EEventName.RoleDevTargetRoleIdChange, new Action(this.OnRoleDevTargetRoleIdChange));
		}

		// Token: 0x060280DA RID: 164058 RVA: 0x00B376CC File Offset: 0x00B358CC
		private void InitData()
		{
			this.RoleDevelopDataList = RoleDevelopModel.Instance.GetNormalRoleDevelopData();
			List<RoleDevelopData> allHotRoleDevelopData = RoleDevelopModel.Instance.GetAllHotRoleDevelopData(false);
			RoleDevelopSelectTargetViewData roleDevelopSelectTargetViewData = this.OpenParam as RoleDevelopSelectTargetViewData;
			int? roleId = (roleDevelopSelectTargetViewData != null) ? roleDevelopSelectTargetViewData.RoleId : null;
			if (roleId != null && roleId.GetValueOrDefault() != 0)
			{
				this.CurSelectRoleDevelopData = (this.RoleDevelopDataList.Find((RoleDevelopData d) => d.GetId() == roleId.Value) ?? allHotRoleDevelopData.Find((RoleDevelopData d) => d.GetId() == roleId.Value));
			}
		}

		// Token: 0x060280DB RID: 164059 RVA: 0x00B37770 File Offset: 0x00B35970
		private void RefreshRoleGridLayout()
		{
			List<RoleDevelopData> roleDevelopDataList = this.RoleDevelopDataList;
			if (this.RoleDataList.Count <= 0)
			{
				foreach (RoleDevelopData roleDevelopData in roleDevelopDataList)
				{
					int id = roleDevelopData.GetId();
					RoleInstance roleInstance = RoleModel.Instance.GetRoleInstanceById(id);
					if (roleInstance == null)
					{
						roleInstance = new RoleInstance(id);
					}
					this.RoleDataList.Add(roleInstance);
				}
				this.FilterSortEntrance.UpdateData(EFilterSortGroupId.RoleDev, this.RoleDataList, Array.Empty<object>());
				return;
			}
			this.RoleLayout.RefreshByData(this.RoleDevelopDataList, new Action(this.OnRoleGridLayoutRefresh), true);
		}

		// Token: 0x060280DC RID: 164060 RVA: 0x00B3782C File Offset: 0x00B35A2C
		private void OnUpdateSortList(List<RoleDataBase> dataList, bool isOutSideChange, EFilterSortType operationType)
		{
			this.RoleDataList = dataList;
			Dictionary<int, int> orderMap = new Dictionary<int, int>();
			for (int i = 0; i < dataList.Count; i++)
			{
				orderMap[dataList[i].GetRoleId()] = i;
			}
			int targetRoleId = RoleDevelopModel.Instance.DevTargetRoleId;
			this.RoleDevelopDataList.Sort(delegate(RoleDevelopData a, RoleDevelopData b)
			{
				int id = a.GetId();
				int id2 = b.GetId();
				if (targetRoleId > 0)
				{
					if (id == targetRoleId)
					{
						return -1;
					}
					if (id2 == targetRoleId)
					{
						return 1;
					}
				}
				int num = orderMap.ContainsKey(id) ? orderMap[id] : int.MaxValue;
				int num2 = orderMap.ContainsKey(id2) ? orderMap[id2] : int.MaxValue;
				return num - num2;
			});
			base.GetScrollViewWithScrollbar(14).SetScrollProgress(0f);
			this.RoleLayout.RefreshByData(this.RoleDevelopDataList, new Action(this.OnRoleGridLayoutRefresh), true);
		}

		// Token: 0x060280DD RID: 164061 RVA: 0x00B378D4 File Offset: 0x00B35AD4
		private void RefreshHotRoleGridLayout()
		{
			List<RoleDevelopData> allHotRoleDevelopData = RoleDevelopModel.Instance.GetAllHotRoleDevelopData(true);
			if (allHotRoleDevelopData.Count <= 0)
			{
				this.HotRoleLayout.SetActive(false);
				return;
			}
			this.HotRoleLayout.SetActive(true);
			this.HotRoleLayout.RefreshByData(allHotRoleDevelopData, new Action(this.OnHotRoleGridLayoutRefresh), true);
		}

		// Token: 0x060280DE RID: 164062 RVA: 0x00B37928 File Offset: 0x00B35B28
		private void RefreshRoleView()
		{
			RoleDevelopRoleBaseData developRoleData = this.CurSelectRoleDevelopData.GetDevelopRoleData();
			base.SetTextureShowUntilLoaded(developRoleData.GetRoleIllustrationPath(), base.GetTexture(5), null);
			base.GetText(8).SetText(developRoleData.GetName(), true);
			ERoleDevelopHotRoleTag hotRoleTag = this.CurSelectRoleDevelopData.GetHotRoleTag();
			this.RoleDevelopTagItem.RefreshByData(hotRoleTag);
			int elementId = developRoleData.GetElementId();
			ElementInfo? elementConfig = CommonConfig.Instance.GetElementConfig(elementId);
			UUITexture texture = base.GetTexture(7);
			UUITexture texture2 = base.GetTexture(6);
			UUIText text = base.GetText(10);
			if (elementConfig != null)
			{
				base.SetElementIcon(elementConfig.Value.Icon2, texture, elementId, null);
				base.SetElementIcon(elementConfig.Value.Icon2, texture2, elementId, null);
				texture.SetColor(FColor.FromHex(elementConfig.Value.ElementColor));
				texture.SetUIActive(true);
				texture2.SetUIActive(true);
				LguiUtil.Instance.SetLocalTextNew(text, elementConfig.Value.Name, Array.Empty<object>());
				text.SetUIActive(true);
			}
			else
			{
				texture.SetUIActive(false);
				texture2.SetUIActive(false);
				text.SetUIActive(false);
			}
			this.ConditionLayout.RefreshByData(this.GetConditionItemDataList(), null, false);
			string textId = (RoleDevelopModel.Instance.DevTargetRoleId == this.CurSelectRoleDevelopData.GetId()) ? "RoleProject_CancelRoleButton" : "RoleProject_ConfirmRoleButton";
			this.ConfirmButton.SetLocalTextNew(textId, Array.Empty<object>());
		}

		// Token: 0x060280DF RID: 164063 RVA: 0x00B37ABC File Offset: 0x00B35CBC
		private List<RoleDevelopSelectTargetHintItemData> GetConditionItemDataList()
		{
			RoleDevelopData curSelectRoleDevelopData = this.CurSelectRoleDevelopData;
			if (curSelectRoleDevelopData == null)
			{
				return new List<RoleDevelopSelectTargetHintItemData>();
			}
			int id = curSelectRoleDevelopData.GetId();
			int num = RoleModel.Instance.IsRoleOwned(id) ? 1 : 0;
			bool flag = RoleDevelopUtil.IsAnyProspectRole(id);
			if (num == 0 || flag)
			{
				return new List<RoleDevelopSelectTargetHintItemData>
				{
					RoleDevelopSelectTargetView.BuildItemHint(id)
				};
			}
			List<RoleDevelopSelectTargetHintItemData> list = new List<RoleDevelopSelectTargetHintItemData>();
			RoleDevelopSelectTargetView.AddHint(list, RoleDevelopSelectTargetView.GetRoleHint(RoleDevelopUtil.GetRoleState(id)));
			RoleDevelopSelectTargetView.AddHint(list, RoleDevelopSelectTargetView.GetWeaponHint(RoleDevelopUtil.GetWeaponState(id)));
			RoleDevelopSelectTargetView.AddHint(list, RoleDevelopSelectTargetView.GetPhantomHint(RoleDevelopUtil.GetPhantomState(id)));
			RoleDevelopSelectTargetView.AddHint(list, RoleDevelopSelectTargetView.GetSkillHint(RoleDevelopUtil.GetSkillState(id)));
			if (list.Count == 0)
			{
				return new List<RoleDevelopSelectTargetHintItemData>
				{
					new RoleDevelopSelectTargetHintItemData
					{
						IconKey = "T_RoleDevelopTag1",
						DescKey = "RoleProject_ChoseRole_FinishTips"
					}
				};
			}
			list.Add(RoleDevelopSelectTargetView.BuildItemHint(id));
			return list;
		}

		// Token: 0x060280E0 RID: 164064 RVA: 0x00B37B91 File Offset: 0x00B35D91
		private static void AddHint(List<RoleDevelopSelectTargetHintItemData> result, [Nullable(2)] RoleDevelopSelectTargetHintItemData hint)
		{
			if (hint != null)
			{
				result.Add(hint);
			}
		}

		// Token: 0x060280E1 RID: 164065 RVA: 0x00B37B9D File Offset: 0x00B35D9D
		[NullableContext(2)]
		private static RoleDevelopSelectTargetHintItemData GetRoleHint(ERoleDevelopRoleState state)
		{
			if (state == ERoleDevelopRoleState.LevelNotEnough)
			{
				return new RoleDevelopSelectTargetHintItemData
				{
					IconKey = "T_RoleDevelopTag3",
					DescKey = "RoleProject_ChoseRole_RoleTips01"
				};
			}
			return null;
		}

		// Token: 0x060280E2 RID: 164066 RVA: 0x00B37BC0 File Offset: 0x00B35DC0
		[NullableContext(2)]
		private static RoleDevelopSelectTargetHintItemData GetWeaponHint(ERoleDevelopWeaponState state)
		{
			if (state - ERoleDevelopWeaponState.NotEquipped <= 1)
			{
				return new RoleDevelopSelectTargetHintItemData
				{
					IconKey = "T_RoleDevelopTag2",
					DescKey = "RoleProject_ChoseRole_WeaponTips01"
				};
			}
			if (state != ERoleDevelopWeaponState.LevelNotEnough)
			{
				return null;
			}
			return new RoleDevelopSelectTargetHintItemData
			{
				IconKey = "T_RoleDevelopTag3",
				DescKey = "RoleProject_ChoseRole_WeaponTips02"
			};
		}

		// Token: 0x060280E3 RID: 164067 RVA: 0x00B37C14 File Offset: 0x00B35E14
		[NullableContext(2)]
		private static RoleDevelopSelectTargetHintItemData GetPhantomHint(ERoleDevelopPhantomState state)
		{
			switch (state)
			{
			case ERoleDevelopPhantomState.CountNotEnough:
			case ERoleDevelopPhantomState.FetterNotTriggered:
				return new RoleDevelopSelectTargetHintItemData
				{
					IconKey = "T_RoleDevelopTag2",
					DescKey = "RoleProject_ChoseRole_PhantomTips01"
				};
			case ERoleDevelopPhantomState.QualityLow:
				return new RoleDevelopSelectTargetHintItemData
				{
					IconKey = "T_RoleDevelopTag2",
					DescKey = "RoleProject_ChoseRole_PhantomTips02"
				};
			case ERoleDevelopPhantomState.LevelNotEnough:
				return new RoleDevelopSelectTargetHintItemData
				{
					IconKey = "T_RoleDevelopTag2",
					DescKey = "RoleProject_ChoseRole_PhantomTips03"
				};
			case ERoleDevelopPhantomState.SubPropLocked:
				return new RoleDevelopSelectTargetHintItemData
				{
					IconKey = "T_RoleDevelopTag2",
					DescKey = "RoleProject_ChoseRole_PhantomTips04"
				};
			default:
				return null;
			}
		}

		// Token: 0x060280E4 RID: 164068 RVA: 0x00B37CB0 File Offset: 0x00B35EB0
		[NullableContext(2)]
		private static RoleDevelopSelectTargetHintItemData GetSkillHint(ERoleDevelopSkillState state)
		{
			if (state == ERoleDevelopSkillState.PlanNotFinished)
			{
				return new RoleDevelopSelectTargetHintItemData
				{
					IconKey = "T_RoleDevelopTag3",
					DescKey = "RoleProject_ChoseRole_SkillTips01"
				};
			}
			return null;
		}

		// Token: 0x060280E5 RID: 164069 RVA: 0x00B37CD4 File Offset: 0x00B35ED4
		private static RoleDevelopSelectTargetHintItemData BuildItemHint(int roleId)
		{
			bool flag = RoleDevelopUtil.GetItemState(roleId) == ERoleDevelopItemState.Enough;
			return new RoleDevelopSelectTargetHintItemData
			{
				IconKey = (flag ? "T_RoleDevelopTag1" : "T_RoleDevelopTag2"),
				DescKey = (flag ? "RoleProject_ChoseRole_ItemTips02" : "RoleProject_ChoseRole_ItemTips01")
			};
		}

		// Token: 0x060280E6 RID: 164070 RVA: 0x00B37D1C File Offset: 0x00B35F1C
		private void OnHotRoleGridItemSelected(RoleDevelopData data)
		{
			this.RoleLayout.DeselectCurrentGridProxy();
			this.HotRoleLayout.DeselectCurrentGridProxy();
			this.HotRoleLayout.SelectGridProxyByKey(data.GetId(), false);
			this.CurSelectRoleDevelopData = data;
			this.IsSelectedFromHotRole = true;
			this.RefreshRoleView();
		}

		// Token: 0x060280E7 RID: 164071 RVA: 0x00B37D6C File Offset: 0x00B35F6C
		private void OnRoleGridItemSelected(RoleDevelopData data)
		{
			this.RoleLayout.DeselectCurrentGridProxy();
			this.HotRoleLayout.DeselectCurrentGridProxy();
			this.RoleLayout.SelectGridProxyByKey(data.GetId(), false);
			this.CurSelectRoleDevelopData = data;
			this.IsSelectedFromHotRole = false;
			this.RefreshRoleView();
		}

		// Token: 0x060280E8 RID: 164072 RVA: 0x00B37DBC File Offset: 0x00B35FBC
		private void OnClickConfirmButton(int value)
		{
			int id = this.CurSelectRoleDevelopData.GetId();
			int num = (RoleDevelopModel.Instance.DevTargetRoleId == id) ? 0 : id;
			RoleDevelopSelectTargetViewData roleDevelopSelectTargetViewData = this.OpenParam as RoleDevelopSelectTargetViewData;
			ERoleDevelopUpdateTargetSource source = (roleDevelopSelectTargetViewData != null) ? roleDevelopSelectTargetViewData.Source : ERoleDevelopUpdateTargetSource.Detection;
			RoleController.Instance.RequestUpdateDevelopTarget(num, source, null, null);
			if (num != 0)
			{
				base.CloseMe(null);
			}
		}

		// Token: 0x060280E9 RID: 164073 RVA: 0x00B37E27 File Offset: 0x00B36027
		private void OnCloseButtonClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x060280EA RID: 164074 RVA: 0x00B37E30 File Offset: 0x00B36030
		private RoleDevelopHotRoleGridItem CreateHotRoleGridItem()
		{
			RoleDevelopHotRoleGridItem roleDevelopHotRoleGridItem = new RoleDevelopHotRoleGridItem();
			roleDevelopHotRoleGridItem.BindOnExtendToggleStateChanged(new Action<MediumItemGridExtendCallback>(this.OnHotRoleGridItemToggleChanged));
			roleDevelopHotRoleGridItem.BindOnCanExecuteChange(new Func<object, bool, EToggleState, bool>(this.OnHotRoleGridItemCanExecuteChange));
			return roleDevelopHotRoleGridItem;
		}

		// Token: 0x060280EB RID: 164075 RVA: 0x00B37E5B File Offset: 0x00B3605B
		private RoleDevelopGridItem CreateRoleGridItem()
		{
			RoleDevelopGridItem roleDevelopGridItem = new RoleDevelopGridItem();
			roleDevelopGridItem.BindOnExtendToggleStateChanged(new Action<MediumItemGridExtendCallback>(this.OnRoleGridItemToggleChanged));
			roleDevelopGridItem.BindOnCanExecuteChange(new Func<object, bool, EToggleState, bool>(this.OnRoleGridItemCanExecuteChange));
			return roleDevelopGridItem;
		}

		// Token: 0x060280EC RID: 164076 RVA: 0x00B37E86 File Offset: 0x00B36086
		private RoleDevelopSelectTargetHintItem CreateConditionItem()
		{
			return new RoleDevelopSelectTargetHintItem();
		}

		// Token: 0x060280ED RID: 164077 RVA: 0x00B37E8D File Offset: 0x00B3608D
		private bool IsNormalRole(int roleId)
		{
			return !RoleDevelopUtil.IsAnyProspectRole(roleId);
		}

		// Token: 0x060280EE RID: 164078 RVA: 0x00B37E98 File Offset: 0x00B36098
		private void OnRoleGridLayoutRefresh()
		{
			if (this.CurSelectRoleDevelopData == null)
			{
				this.CurSelectRoleDevelopData = this.RoleDevelopDataList[0];
			}
			int id = this.CurSelectRoleDevelopData.GetId();
			if (!this.IsNormalRole(id))
			{
				return;
			}
			this.RoleLayout.SelectGridProxyByKey(id, false);
			this.OnRoleGridItemSelected(this.CurSelectRoleDevelopData);
		}

		// Token: 0x060280EF RID: 164079 RVA: 0x00B37EF4 File Offset: 0x00B360F4
		private void OnHotRoleGridLayoutRefresh()
		{
			int id = this.CurSelectRoleDevelopData.GetId();
			if (this.IsNormalRole(id))
			{
				return;
			}
			this.HotRoleLayout.SelectGridProxyByKey(id, false);
			this.OnHotRoleGridItemSelected(this.CurSelectRoleDevelopData);
		}

		// Token: 0x060280F0 RID: 164080 RVA: 0x00B37F38 File Offset: 0x00B36138
		private void OnHotRoleGridItemToggleChanged(MediumItemGridExtendCallback callbackParameter)
		{
			this.OnHotRoleGridItemSelected((RoleDevelopData)callbackParameter.Data);
			base.PlayOrReplaySequence("Switch", false, null);
		}

		// Token: 0x060280F1 RID: 164081 RVA: 0x00B37F6C File Offset: 0x00B3616C
		private bool OnHotRoleGridItemCanExecuteChange(object data, bool isForceSelected, EToggleState state)
		{
			if (!this.IsSelectedFromHotRole)
			{
				return true;
			}
			int id = ((RoleDevelopData)data).GetId();
			RoleDevelopData curSelectRoleDevelopData = this.CurSelectRoleDevelopData;
			int? num = (curSelectRoleDevelopData != null) ? new int?(curSelectRoleDevelopData.GetId()) : null;
			return !(id == num.GetValueOrDefault() & num != null);
		}

		// Token: 0x060280F2 RID: 164082 RVA: 0x00B37FC4 File Offset: 0x00B361C4
		private void OnRoleGridItemToggleChanged(MediumItemGridExtendCallback callbackParameter)
		{
			this.OnRoleGridItemSelected((RoleDevelopData)callbackParameter.Data);
			base.PlayOrReplaySequence("Switch", false, null);
		}

		// Token: 0x060280F3 RID: 164083 RVA: 0x00B37FF8 File Offset: 0x00B361F8
		private bool OnRoleGridItemCanExecuteChange(object data, bool isForceSelected, EToggleState state)
		{
			if (this.IsSelectedFromHotRole)
			{
				return true;
			}
			int id = ((RoleDevelopData)data).GetId();
			RoleDevelopData curSelectRoleDevelopData = this.CurSelectRoleDevelopData;
			int? num = (curSelectRoleDevelopData != null) ? new int?(curSelectRoleDevelopData.GetId()) : null;
			return !(id == num.GetValueOrDefault() & num != null);
		}

		// Token: 0x060280F4 RID: 164084 RVA: 0x00B3804E File Offset: 0x00B3624E
		private void OnRoleDevTargetRoleIdChange()
		{
			if (RoleDevelopModel.Instance.DevTargetRoleId != 0)
			{
				return;
			}
			this.HotRoleLayout.RefreshWithoutDataSync();
			this.RoleLayout.RefreshWithoutDataSync();
			this.RefreshRoleView();
		}

		// Token: 0x04015CC3 RID: 89283
		private PopupCaptionItem CaptionItem;

		// Token: 0x04015CC4 RID: 89284
		private GenericLayout<RoleDevelopHotRoleGridItem, RoleDevelopData> HotRoleLayout;

		// Token: 0x04015CC5 RID: 89285
		private GenericLayout<RoleDevelopGridItem, RoleDevelopData> RoleLayout;

		// Token: 0x04015CC6 RID: 89286
		private FilterSortEntrance<RoleDataBase> FilterSortEntrance;

		// Token: 0x04015CC7 RID: 89287
		private RoleDevelopTagItem RoleDevelopTagItem;

		// Token: 0x04015CC8 RID: 89288
		private List<RoleDataBase> RoleDataList = new List<RoleDataBase>();

		// Token: 0x04015CC9 RID: 89289
		private List<RoleDevelopData> RoleDevelopDataList = new List<RoleDevelopData>();

		// Token: 0x04015CCA RID: 89290
		[Nullable(2)]
		private RoleDevelopData CurSelectRoleDevelopData;

		// Token: 0x04015CCB RID: 89291
		private bool IsSelectedFromHotRole;

		// Token: 0x04015CCC RID: 89292
		private ButtonItem ConfirmButton;

		// Token: 0x04015CCD RID: 89293
		private GenericLayout<RoleDevelopSelectTargetHintItem, RoleDevelopSelectTargetHintItemData> ConditionLayout;

		// Token: 0x020098FC RID: 39164
		[NullableContext(0)]
		private enum EComponentType
		{
			// Token: 0x0402FB92 RID: 195474
			CaptionItem,
			// Token: 0x0402FB93 RID: 195475
			HotRoleGrid,
			// Token: 0x0402FB94 RID: 195476
			HotRoleItem,
			// Token: 0x0402FB95 RID: 195477
			RoleGrid,
			// Token: 0x0402FB96 RID: 195478
			FilterSortItem,
			// Token: 0x0402FB97 RID: 195479
			RoleTexture,
			// Token: 0x0402FB98 RID: 195480
			ElementBgTexture,
			// Token: 0x0402FB99 RID: 195481
			ElementIconTexture,
			// Token: 0x0402FB9A RID: 195482
			NameText,
			// Token: 0x0402FB9B RID: 195483
			DevelopTag,
			// Token: 0x0402FB9C RID: 195484
			ElementText,
			// Token: 0x0402FB9D RID: 195485
			ConditionVerticalLayout,
			// Token: 0x0402FB9E RID: 195486
			ConditionItem,
			// Token: 0x0402FB9F RID: 195487
			ConfirmButton,
			// Token: 0x0402FBA0 RID: 195488
			ScrollView
		}
	}
}
