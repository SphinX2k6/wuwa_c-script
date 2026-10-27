using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.BossPiling.View.Item
{
	// Token: 0x02005C28 RID: 23592
	[NullableContext(1)]
	[Nullable(0)]
	public class BossPilingTeamPanel : UiPanelBase
	{
		// Token: 0x0603B97E RID: 244094 RVA: 0x00E37135 File Offset: 0x00E35335
		public BossPilingTeamPanel(int levelId)
		{
			this.LevelId = levelId;
		}

		// Token: 0x0603B97F RID: 244095 RVA: 0x00E37168 File Offset: 0x00E35368
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickedBtn));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603B980 RID: 244096 RVA: 0x00E372B4 File Offset: 0x00E354B4
		protected override UniTask OnBeforeStartAsync()
		{
			BossPilingTeamPanel.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<BossPilingTeamPanel.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603B981 RID: 244097 RVA: 0x00E372F8 File Offset: 0x00E354F8
		protected override void OnStart()
		{
			BossPilingLevels value = BossPilingConfig.Instance.GetLevelInfo(this.LevelId).Value;
			if (value.RecommendFetter().Length != 0)
			{
				BossPilingFetterItem element = this.Element1;
				if (element != null)
				{
					element.SetUiActive(true);
				}
				BossPilingFetterItem element2 = this.Element1;
				if (element2 != null)
				{
					element2.Refresh(value.RecommendFetter()[0]);
				}
			}
			else
			{
				BossPilingFetterItem element3 = this.Element1;
				if (element3 != null)
				{
					element3.SetUiActive(false);
				}
			}
			if (value.RecommendFetter().Length > 1)
			{
				BossPilingFetterItem element4 = this.Element2;
				if (element4 != null)
				{
					element4.SetUiActive(true);
				}
				BossPilingFetterItem element5 = this.Element2;
				if (element5 != null)
				{
					element5.Refresh(value.RecommendFetter()[1]);
				}
			}
			else
			{
				BossPilingFetterItem element6 = this.Element2;
				if (element6 != null)
				{
					element6.SetUiActive(false);
				}
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "BossPilingActivity_DungeonDetail13", new <>z__ReadOnlySingleElementList<object>(value.RecommendLevel));
			BossPilingLevelInfo levelInfo = BossPilingModel.Instance.GetActivityData().GetLevelInfo(this.LevelId);
			this.RoleData = new List<int>(levelInfo.SelectedRoleIds);
			for (int i = this.RoleData.Count; i < 3; i++)
			{
				this.RoleData.Add(0);
			}
			this.TagData = new List<int>(levelInfo.SelectedTagBranchIds);
			for (int j = this.TagData.Count; j < 3; j++)
			{
				this.TagData.Add(0);
			}
			this.RefreshRoleList();
			EventSystem.Instance.Add(EEventName.OnRoleChangeEnd, new Action(this.OnRoleChangeEnd));
			EventSystem.Instance.Add<int>(EEventName.OnRoleSkillBranchInGamePlayChanged, new Action<int>(this.OnRoleTagChange));
		}

		// Token: 0x0603B982 RID: 244098 RVA: 0x00E37499 File Offset: 0x00E35699
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove(EEventName.OnRoleChangeEnd, new Action(this.OnRoleChangeEnd));
			EventSystem.Instance.Remove<int>(EEventName.OnRoleSkillBranchInGamePlayChanged, new Action<int>(this.OnRoleTagChange));
		}

		// Token: 0x0603B983 RID: 244099 RVA: 0x00E374D3 File Offset: 0x00E356D3
		[return: Nullable(new byte[]
		{
			0,
			1,
			1
		})]
		public ValueTuple<List<int>, List<int>> GetTeamListResult()
		{
			return new ValueTuple<List<int>, List<int>>(this.RoleData, this.TagData);
		}

		// Token: 0x0603B984 RID: 244100 RVA: 0x00E374E8 File Offset: 0x00E356E8
		protected void RefreshRoleList()
		{
			List<BossPilingTeamRoleInfo> list = new List<BossPilingTeamRoleInfo>();
			for (int i = 0; i < this.RoleData.Count; i++)
			{
				BossPilingTeamRoleInfo item = new BossPilingTeamRoleInfo
				{
					RoleId = this.RoleData[i],
					TagId = this.TagData[i]
				};
				list.Add(item);
			}
			this.Layout.RefreshByData(list, null, false);
		}

		// Token: 0x0603B985 RID: 244101 RVA: 0x00E37550 File Offset: 0x00E35750
		private BossPilingRoleItem CreateItem()
		{
			return new BossPilingRoleItem
			{
				OnClickedCb = new Action<int, int>(this.OnClickedCb)
			};
		}

		// Token: 0x0603B986 RID: 244102 RVA: 0x00E3756C File Offset: 0x00E3576C
		private MultiTeamRoleSelectData GetSelectViewData()
		{
			RoleInstance[] roleList = RoleModel.Instance.GetRoleList();
			List<MultiTeamRoleGridData> list = new List<MultiTeamRoleGridData>();
			BossPilingLevels value = BossPilingConfig.Instance.GetLevelInfo(this.LevelId).Value;
			int fightFormationId = InstanceDungeonConfig.Instance.GetConfig(value.InstIds()[0]).Value.FightFormationId;
			FightFormation value2 = FormationConfig.Instance.GetFightFormationConfig(fightFormationId).Value;
			foreach (RoleInstance roleInstance in roleList)
			{
				if (roleInstance.GetRoleId() != 0)
				{
					MultiTeamRoleGridData item = MultiTeamRoleGridData.Phrase(roleInstance, false, value2.RecommendFormation().Contains(roleInstance.GetRoleId()), false, false);
					list.Add(item);
				}
			}
			List<MultiTeamRoleGridData> list2 = new List<MultiTeamRoleGridData>();
			foreach (int id in value2.TrialRoleIter())
			{
				TrialRoleInfo? trialRoleConfigByGroupId = RoleConfig.Instance.GetTrialRoleConfigByGroupId(id);
				RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(trialRoleConfigByGroupId.Value.Id, true);
				if (roleDataById != null)
				{
					list2.Add(MultiTeamRoleGridData.Phrase(roleDataById, false, false, false, false));
				}
			}
			MultiTeamRoleData item2 = MultiTeamRoleData.Phrase("BossRushNormalRole", list);
			List<MultiTeamRoleData> list3 = new List<MultiTeamRoleData>();
			if (list2.Count > 0)
			{
				MultiTeamRoleData item3 = MultiTeamRoleData.Phrase("BossRushTrailRole", list2);
				list3.Add(item3);
			}
			list3.Add(item2);
			MultiTeamRoleSelectData multiTeamRoleSelectData = MultiTeamRoleSelectData.Phrase(new EFilterSortGroupId?(EFilterSortGroupId.EditFormation), 3, this.RoleData.ToArray(), delegate
			{
				for (int j = 0; j < this.RoleData.Count; j++)
				{
					int num = this.RoleData[j];
					if (this.TagChangeRoleSet.Contains(num))
					{
						this.TagData[j] = RoleModel.Instance.GetRoleSkillBranchIdInCurrentGamePlay(num);
					}
					if (RoleModel.Instance.IsMainRole(num))
					{
						int? curSelectMainRoleId = RoleModel.Instance.GetCurSelectMainRoleId();
						int? num2 = curSelectMainRoleId;
						int num3 = num;
						if (!(num2.GetValueOrDefault() == num3 & num2 != null))
						{
							num2 = curSelectMainRoleId;
							num3 = 0;
							if (!(num2.GetValueOrDefault() == num3 & num2 != null))
							{
								this.RoleData[j] = curSelectMainRoleId.Value;
							}
						}
					}
				}
				this.RefreshRoleList();
			}, null, delegate(int[] idList, int[] tagConfigId)
			{
				for (int j = 0; j < idList.Length; j++)
				{
					this.RoleData[j] = idList[j];
					this.TagData[j] = tagConfigId[j];
				}
				this.RefreshRoleList();
			}, null, list3, null, "", "");
			multiTeamRoleSelectData.IfCanSelectCheck = new Func<int, int[], bool>(this.IfCanSelectCheck);
			MultiTeamTagDataItem multiTeamTagData = MultiTeamTagDataItem.Phrase(this.TagData.ToArray(), ESkillBranchCacheType.BossPiling);
			multiTeamRoleSelectData.SetMultiTeamTagData(multiTeamTagData);
			this.TagChangeRoleSet.Clear();
			return multiTeamRoleSelectData;
		}

		// Token: 0x0603B987 RID: 244103 RVA: 0x00E37768 File Offset: 0x00E35968
		private bool IfCanSelectCheck(int roleConfigId, int[] selectedRoleList)
		{
			RoleConfig instance = RoleConfig.Instance;
			int? num = (instance != null) ? new int?(instance.GetBaseRoleId(roleConfigId)) : null;
			foreach (int num2 in selectedRoleList)
			{
				if (num2 != 0)
				{
					RoleConfig instance2 = RoleConfig.Instance;
					int? num3 = (instance2 != null) ? new int?(instance2.GetBaseRoleId(num2)) : null;
					int? num4 = num;
					if ((num3.GetValueOrDefault() == num4.GetValueOrDefault() & num3 != null == (num4 != null)) && roleConfigId != num2)
					{
						ScrollingTipsController.Instance.ShowTipsByTextId("BossRushSameFormation", Array.Empty<object>());
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x0603B988 RID: 244104 RVA: 0x00E37811 File Offset: 0x00E35A11
		private void OnClickedCb(int roleId, int index)
		{
			UiManager.Instance.OpenView(EUiViewName.MultiTeamRoleSelectView, this.GetSelectViewData(), null);
		}

		// Token: 0x0603B989 RID: 244105 RVA: 0x00E37829 File Offset: 0x00E35A29
		private void OnClickedBtn()
		{
			UiManager.Instance.OpenView(EUiViewName.MultiTeamRoleSelectView, this.GetSelectViewData(), null);
		}

		// Token: 0x0603B98A RID: 244106 RVA: 0x00E37844 File Offset: 0x00E35A44
		private void OnRoleChangeEnd()
		{
			for (int i = 0; i < this.RoleData.Count; i++)
			{
				int num = this.RoleData[i];
				if (RoleModel.Instance.IsMainRole(num))
				{
					int? curSelectMainRoleId = RoleModel.Instance.GetCurSelectMainRoleId();
					int? num2 = curSelectMainRoleId;
					int num3 = num;
					if (!(num2.GetValueOrDefault() == num3 & num2 != null))
					{
						num2 = curSelectMainRoleId;
						num3 = 0;
						if (!(num2.GetValueOrDefault() == num3 & num2 != null))
						{
							this.RoleData[i] = curSelectMainRoleId.Value;
						}
					}
				}
			}
			this.RefreshRoleList();
		}

		// Token: 0x0603B98B RID: 244107 RVA: 0x00E378D9 File Offset: 0x00E35AD9
		private void OnRoleTagChange(int roleId)
		{
			this.TagChangeRoleSet.Add(roleId);
		}

		// Token: 0x0401F069 RID: 127081
		protected GenericLayout<BossPilingRoleItem, BossPilingTeamRoleInfo> Layout;

		// Token: 0x0401F06A RID: 127082
		protected BossPilingFetterItem Element1;

		// Token: 0x0401F06B RID: 127083
		protected BossPilingFetterItem Element2;

		// Token: 0x0401F06C RID: 127084
		protected List<int> RoleData = new List<int>();

		// Token: 0x0401F06D RID: 127085
		protected HashSet<int> TagChangeRoleSet = new HashSet<int>();

		// Token: 0x0401F06E RID: 127086
		protected List<int> TagData = new List<int>();

		// Token: 0x0401F06F RID: 127087
		protected int LevelId;

		// Token: 0x0200BE11 RID: 48657
		[NullableContext(0)]
		private enum EDefine
		{
			// Token: 0x0403950F RID: 234767
			Btn,
			// Token: 0x04039510 RID: 234768
			TxtLevel,
			// Token: 0x04039511 RID: 234769
			TxtFetter,
			// Token: 0x04039512 RID: 234770
			ElementItem1,
			// Token: 0x04039513 RID: 234771
			ElementItem2,
			// Token: 0x04039514 RID: 234772
			PanelRole,
			// Token: 0x04039515 RID: 234773
			RoleItem
		}
	}
}
