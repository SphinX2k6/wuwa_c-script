using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Common;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02004EAB RID: 20139
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueBattleSummaryRoleItem : UiPanelBase
	{
		// Token: 0x06033BC0 RID: 211904 RVA: 0x00C1E9F8 File Offset: 0x00C1CBF8
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIScrollViewWithScrollbarComponent)),
				new ValueTuple<int, Type>(6, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(3, new Action(this.OnClickMore))
			};
		}

		// Token: 0x06033BC1 RID: 211905 RVA: 0x00C1EACD File Offset: 0x00C1CCCD
		protected override void OnStart()
		{
			this.LoopScroll = new GenericScrollViewNew<RogueBattleMapRoleLayoutGrid, IRogueBattleMapRoleGridInfo>(base.GetScrollViewWithScrollbar(5), new Func<RogueBattleMapRoleLayoutGrid>(this.CreateLoopItem), null, false, null);
			this.InitAttributeItemList();
		}

		// Token: 0x06033BC2 RID: 211906 RVA: 0x00C1EAF6 File Offset: 0x00C1CCF6
		protected override void OnBeforeShow()
		{
			this.UpdateAttribute();
			this.RefreshFormation();
		}

		// Token: 0x06033BC3 RID: 211907 RVA: 0x00C1EB04 File Offset: 0x00C1CD04
		protected override void OnBeforeDestroy()
		{
			this.LoopScroll = null;
			foreach (AttributeItem attributeItem in this.AttributeItemList)
			{
				attributeItem.Destroy(null);
			}
			this.AttributeItemList.Clear();
		}

		// Token: 0x06033BC4 RID: 211908 RVA: 0x00C1EB68 File Offset: 0x00C1CD68
		private RogueBattleMapRoleLayoutGrid CreateLoopItem()
		{
			return new RogueBattleMapRoleLayoutGrid();
		}

		// Token: 0x06033BC5 RID: 211909 RVA: 0x00C1EB70 File Offset: 0x00C1CD70
		private void RefreshFormation()
		{
			List<IRogueBattleMapRoleGridInfo> list = new List<IRogueBattleMapRoleGridInfo>();
			List<SceneTeamItem> teamItems = SceneTeamModel.Instance.GetTeamItems(false);
			List<int> list2 = new List<int>
			{
				teamItems[0].GetConfigId
			};
			for (int i = 1; i < teamItems.Count; i++)
			{
				RogueBattleMapRoleGridInfo item = new RogueBattleMapRoleGridInfo
				{
					ConfigId = teamItems[i].GetConfigId,
					IsGain = true,
					NeedLevel = false
				};
				list.Add(item);
				list2.Add(teamItems[i].GetConfigId);
			}
			RogueBattleModel.Instance.SummaryRoleList = list2;
			GenericScrollViewNew<RogueBattleMapRoleLayoutGrid, IRogueBattleMapRoleGridInfo> loopScroll = this.LoopScroll;
			if (loopScroll == null)
			{
				return;
			}
			loopScroll.RefreshByData(list, null, false);
		}

		// Token: 0x06033BC6 RID: 211910 RVA: 0x00C1EC18 File Offset: 0x00C1CE18
		private void InitAttributeItemList()
		{
			IReadOnlyList<int> intArrayConfig = ConfigCommonParamById.GetIntArrayConfig("RoleAttributeDisplay6");
			UUIItem item = base.GetItem(1);
			UUIItem item2 = base.GetItem(2);
			int count = intArrayConfig.Count;
			for (int i = 0; i < count; i++)
			{
				UUIItem uuiitem;
				if (i == 0)
				{
					uuiitem = item2;
				}
				else
				{
					uuiitem = LguiUtil.Instance.CopyItem(item2, item);
				}
				int id = intArrayConfig[i];
				AttributeItem attributeItem = new AttributeItem();
				attributeItem.CreateThenShowByActor(uuiitem.GetOwner());
				attributeItem.UpdateParam(id, false);
				if (count > 2 && i % 2 == 0)
				{
					attributeItem.SetBgActive(true);
				}
				else
				{
					attributeItem.SetBgActive(false);
				}
				this.AttributeItemList.Add(attributeItem);
			}
		}

		// Token: 0x06033BC7 RID: 211911 RVA: 0x00C1ECC4 File Offset: 0x00C1CEC4
		protected void UpdateAttribute()
		{
			IReadOnlyList<int> intArrayConfig = ConfigCommonParamById.GetIntArrayConfig("RoleAttributeDisplay6");
			SceneTeamItem sceneTeamItem = SceneTeamModel.Instance.GetTeamItems(false)[0];
			RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(sceneTeamItem.GetConfigId, true);
			for (int i = 0; i < this.AttributeItemList.Count; i++)
			{
				AttributeItem attributeItem = this.AttributeItemList[i];
				int id = intArrayConfig[i];
				float showAttributeValueById = roleDataById.GetShowAttributeValueById(id);
				attributeItem.SetCurrentValue(showAttributeValueById);
				attributeItem.SetActive(true);
			}
		}

		// Token: 0x06033BC8 RID: 211912 RVA: 0x00C1ED44 File Offset: 0x00C1CF44
		private void OnClickMore()
		{
			SceneTeamItem sceneTeamItem = SceneTeamModel.Instance.GetTeamItems(false)[0];
			RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(sceneTeamItem.GetConfigId, true);
			UiManager.Instance.OpenView(EUiViewName.RoleAttributeDetailView, roleDataById.GetShowAttrList(), null);
		}

		// Token: 0x0401B7BE RID: 112574
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<RogueBattleMapRoleLayoutGrid, IRogueBattleMapRoleGridInfo> LoopScroll;

		// Token: 0x0401B7BF RID: 112575
		protected List<AttributeItem> AttributeItemList = new List<AttributeItem>();
	}
}
