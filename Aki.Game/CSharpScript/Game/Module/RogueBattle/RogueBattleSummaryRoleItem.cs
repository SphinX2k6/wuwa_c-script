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
	// Token: 0x02003E74 RID: 15988
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueBattleSummaryRoleItem : UiPanelBase
	{
		// Token: 0x06028A2B RID: 166443 RVA: 0x00B67F10 File Offset: 0x00B66110
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

		// Token: 0x06028A2C RID: 166444 RVA: 0x00B67FE5 File Offset: 0x00B661E5
		protected override void OnStart()
		{
			this.LoopScroll = new GenericScrollViewNew<RogueBattleMapRoleLayoutGrid, IRogueBattleMapRoleGridInfo>(base.GetScrollViewWithScrollbar(5), new Func<RogueBattleMapRoleLayoutGrid>(this.CreateLoopItem), null, false, null);
			this.InitAttributeItemList();
		}

		// Token: 0x06028A2D RID: 166445 RVA: 0x00B6800E File Offset: 0x00B6620E
		protected override void OnBeforeShow()
		{
			this.UpdateAttribute();
			this.RefreshFormation();
		}

		// Token: 0x06028A2E RID: 166446 RVA: 0x00B6801C File Offset: 0x00B6621C
		protected override void OnBeforeDestroy()
		{
			this.LoopScroll = null;
			foreach (AttributeItem attributeItem in this.AttributeItemList)
			{
				attributeItem.Destroy(null);
			}
			this.AttributeItemList.Clear();
		}

		// Token: 0x06028A2F RID: 166447 RVA: 0x00B68080 File Offset: 0x00B66280
		private RogueBattleMapRoleLayoutGrid CreateLoopItem()
		{
			return new RogueBattleMapRoleLayoutGrid();
		}

		// Token: 0x06028A30 RID: 166448 RVA: 0x00B68088 File Offset: 0x00B66288
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

		// Token: 0x06028A31 RID: 166449 RVA: 0x00B68130 File Offset: 0x00B66330
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

		// Token: 0x06028A32 RID: 166450 RVA: 0x00B681DC File Offset: 0x00B663DC
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

		// Token: 0x06028A33 RID: 166451 RVA: 0x00B6825C File Offset: 0x00B6645C
		private void OnClickMore()
		{
			SceneTeamItem sceneTeamItem = SceneTeamModel.Instance.GetTeamItems(false)[0];
			RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(sceneTeamItem.GetConfigId, true);
			UiManager.Instance.OpenView(EUiViewName.RoleAttributeDetailView, roleDataById.GetShowAttrList(), null);
		}

		// Token: 0x04016191 RID: 90513
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericScrollViewNew<RogueBattleMapRoleLayoutGrid, IRogueBattleMapRoleGridInfo> LoopScroll;

		// Token: 0x04016192 RID: 90514
		protected List<AttributeItem> AttributeItemList = new List<AttributeItem>();
	}
}
