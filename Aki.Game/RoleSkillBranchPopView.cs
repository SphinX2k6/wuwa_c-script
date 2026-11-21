using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.MoonChasing;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Skin;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001E1D RID: 7709
[NullableContext(1)]
[Nullable(0)]
public class RoleSkillBranchPopView : UiViewBase
{
	// Token: 0x06013179 RID: 78201 RVA: 0x00594F76 File Offset: 0x00593176
	public RoleSkillBranchPopView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0601317A RID: 78202 RVA: 0x00594F98 File Offset: 0x00593198
	protected unsafe override void OnRegisterComponent()
	{
		int num = 7;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIHorizontalLayout));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0601317B RID: 78203 RVA: 0x005950A8 File Offset: 0x005932A8
	protected override void OnStart()
	{
		this.RoleLayout = new GenericLayout<RoleSkillBranchPopView.RoleSkillBranchPopViewRoleItem, RoleSkillBranchPopView.RoleData>(base.GetHorizontalLayout(1), new Func<RoleSkillBranchPopView.RoleSkillBranchPopViewRoleItem>(this.CreateRoleItem), base.GetItem(2).GetOwner() as AUIBaseActor, false, true);
		this.TabLayout = new GenericLayout<RoleSkillBranchPopView.TeamTabItem, int>(base.GetHorizontalLayout(4), new Func<RoleSkillBranchPopView.TeamTabItem>(this.CreateTeamTabItem), base.GetItem(5).GetOwner() as AUIBaseActor, false, true);
		RoleSkillBranchPopViewParams roleSkillBranchPopViewParams = this.OpenParam as RoleSkillBranchPopViewParams;
		if (roleSkillBranchPopViewParams == null)
		{
			return;
		}
		this.TabData.Clear();
		this.TabIndex.Clear();
		for (int i = 0; i < roleSkillBranchPopViewParams.RoleSkillBranchTeamTabDataList.Count; i++)
		{
			RoleSkillBranchTeamTabData roleSkillBranchTeamTabData = roleSkillBranchPopViewParams.RoleSkillBranchTeamTabDataList[i];
			if (roleSkillBranchTeamTabData.RoleSkillBranchTeamDataList.Count > 0)
			{
				this.TabIndex.Add(roleSkillBranchTeamTabData.TeamIndex);
				List<RoleSkillBranchPopView.RoleData> list = new List<RoleSkillBranchPopView.RoleData>(roleSkillBranchTeamTabData.RoleSkillBranchTeamDataList.Count);
				for (int j = 0; j < roleSkillBranchTeamTabData.RoleSkillBranchTeamDataList.Count; j++)
				{
					ValueTuple<int, int> valueTuple = roleSkillBranchTeamTabData.RoleSkillBranchTeamDataList[j];
					list.Add(new RoleSkillBranchPopView.RoleData
					{
						RoleId = valueTuple.Item1,
						SkillBranchIndex = valueTuple.Item2
					});
				}
				this.TabData.Add(list);
			}
		}
		int selectTabPos = 0;
		if (this.TabIndex.Count > 1)
		{
			selectTabPos = roleSkillBranchPopViewParams.PreferredTabIndex.GetValueOrDefault();
		}
		List<int> data = new List<int>(this.TabIndex);
		GenericLayout<RoleSkillBranchPopView.TeamTabItem, int> tabLayout = this.TabLayout;
		if (tabLayout != null)
		{
			tabLayout.RefreshByData(data, delegate
			{
				this.SelectTab(selectTabPos, true);
			}, false);
		}
		base.GetItem(3).SetUIActive(this.TabIndex.Count == 1);
		base.GetItem(6).SetUIActive(this.TabIndex.Count > 1);
		base.GetHorizontalLayout(4).RootUIComp.Get().SetUIActive(this.TabIndex.Count > 1);
	}

	// Token: 0x0601317C RID: 78204 RVA: 0x005952BA File Offset: 0x005934BA
	private RoleSkillBranchPopView.RoleSkillBranchPopViewRoleItem CreateRoleItem()
	{
		return new RoleSkillBranchPopView.RoleSkillBranchPopViewRoleItem();
	}

	// Token: 0x0601317D RID: 78205 RVA: 0x005952C1 File Offset: 0x005934C1
	private RoleSkillBranchPopView.TeamTabItem CreateTeamTabItem()
	{
		return new RoleSkillBranchPopView.TeamTabItem
		{
			SelectHandler = new Action<int>(this.ClickTabHandler)
		};
	}

	// Token: 0x0601317E RID: 78206 RVA: 0x005952DA File Offset: 0x005934DA
	private void ClickTabHandler(int index)
	{
		this.SelectTab(index, true);
	}

	// Token: 0x0601317F RID: 78207 RVA: 0x005952E4 File Offset: 0x005934E4
	private void SelectTab(int index, bool needRefresh = true)
	{
		for (int i = 0; i < this.TabIndex.Count; i++)
		{
			GenericLayout<RoleSkillBranchPopView.TeamTabItem, int> tabLayout = this.TabLayout;
			RoleSkillBranchPopView.TeamTabItem teamTabItem = (tabLayout != null) ? tabLayout.GetLayoutItemByIndex(i) : null;
			if (teamTabItem != null)
			{
				teamTabItem.SetIsSelected(i == index);
			}
		}
		if (needRefresh)
		{
			GenericLayout<RoleSkillBranchPopView.RoleSkillBranchPopViewRoleItem, RoleSkillBranchPopView.RoleData> roleLayout = this.RoleLayout;
			if (roleLayout == null)
			{
				return;
			}
			roleLayout.RefreshByData(this.TabData[index], null, false);
		}
	}

	// Token: 0x0400A3EB RID: 41963
	protected static readonly IReadOnlyList<string> teamTabTextKey = new List<string>
	{
		"GhostShipTeamName_Text1",
		"GhostShipTeamName_Text2"
	};

	// Token: 0x0400A3EC RID: 41964
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<RoleSkillBranchPopView.RoleSkillBranchPopViewRoleItem, RoleSkillBranchPopView.RoleData> RoleLayout;

	// Token: 0x0400A3ED RID: 41965
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<RoleSkillBranchPopView.TeamTabItem, int> TabLayout;

	// Token: 0x0400A3EE RID: 41966
	private List<List<RoleSkillBranchPopView.RoleData>> TabData = new List<List<RoleSkillBranchPopView.RoleData>>();

	// Token: 0x0400A3EF RID: 41967
	private List<int> TabIndex = new List<int>();

	// Token: 0x020080EE RID: 33006
	[NullableContext(0)]
	public class RoleData
	{
		// Token: 0x1700782F RID: 30767
		// (get) Token: 0x06041D40 RID: 269632 RVA: 0x013855C7 File Offset: 0x013837C7
		// (set) Token: 0x06041D41 RID: 269633 RVA: 0x013855CF File Offset: 0x013837CF
		public int RoleId { get; set; }

		// Token: 0x17007830 RID: 30768
		// (get) Token: 0x06041D42 RID: 269634 RVA: 0x013855D8 File Offset: 0x013837D8
		// (set) Token: 0x06041D43 RID: 269635 RVA: 0x013855E0 File Offset: 0x013837E0
		public int SkillBranchIndex { get; set; } = -1;
	}

	// Token: 0x020080EF RID: 33007
	[NullableContext(0)]
	private enum EChild
	{
		// Token: 0x04029B25 RID: 170789
		TextTitle,
		// Token: 0x04029B26 RID: 170790
		PanelRoleList,
		// Token: 0x04029B27 RID: 170791
		ItemRole,
		// Token: 0x04029B28 RID: 170792
		ItemTextSingleTeam,
		// Token: 0x04029B29 RID: 170793
		PanelTeamTab,
		// Token: 0x04029B2A RID: 170794
		ItemTeamTab,
		// Token: 0x04029B2B RID: 170795
		ItemTextMultiTeam
	}

	// Token: 0x020080F0 RID: 33008
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoleSkillBranchPopViewRoleItem : GridProxyAbstract<RoleSkillBranchPopView.RoleData>
	{
		// Token: 0x06041D45 RID: 269637 RVA: 0x013855F8 File Offset: 0x013837F8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 8;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(USpineSkeletonAnimationComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06041D46 RID: 269638 RVA: 0x01385728 File Offset: 0x01383928
		protected override UniTask OnBeforeStartAsync()
		{
			RoleSkillBranchPopView.RoleSkillBranchPopViewRoleItem.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoleSkillBranchPopView.RoleSkillBranchPopViewRoleItem.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06041D47 RID: 269639 RVA: 0x0138576C File Offset: 0x0138396C
		public override void Refresh(RoleSkillBranchPopView.RoleData data, bool isSelected, int gridIndex)
		{
			this.RoleId = data.RoleId;
			UUIItem roleItem = base.GetItem(1);
			roleItem.SetAlpha(0f);
			USpineSkeletonAnimationComponent roleSpine = base.GetSpine(2);
			roleSpine.SetActive(this.RoleId > 0, false);
			if (this.RoleId <= 0)
			{
				roleItem.SetAlpha(0f);
				return;
			}
			int itemId = RoleSkinModel.Instance.GetRoleSkinDataByRoleId(this.RoleId).ItemId;
			RoleSkin value = SkinConfig.Instance.GetRoleSkinConfig(itemId).Value;
			string formationSpineAtlas = value.FormationSpineAtlas;
			string formationSpineSkeletonData = value.FormationSpineSkeletonData;
			Func<int, float> param = new Func<int, float>(value.SpineParam);
			base.SetSpineAssetByPath(formationSpineAtlas, formationSpineSkeletonData, roleSpine).ContinueWith(delegate()
			{
				roleSpine.SetAnimation(0, ESpineAnimation.Idle.ToString(), true);
				roleItem.SetAlpha(1f);
				roleItem.SetAnchorOffsetX(param(0));
				roleItem.SetAnchorOffsetY(param(1));
				roleItem.SetUIItemScale(new FVector(param(2), param(2), param(2)));
			});
			int roleSkillBranchIndexInCurrentGamePlay = RoleModel.Instance.GetRoleSkillBranchIndexInCurrentGamePlay(this.RoleId);
			bool flag = roleSkillBranchIndexInCurrentGamePlay > -1;
			UUIItem item = base.GetItem(5);
			if (item != null)
			{
				item.SetUIActive(!flag);
			}
			UUIItem item2 = base.GetItem(4);
			if (item2 != null)
			{
				item2.SetUIActive(flag);
			}
			if (!flag)
			{
				return;
			}
			RoleSkillBranchPopView.SkillBranchItem skillBranchItem = this.SkillBranchItem;
			if (skillBranchItem != null)
			{
				skillBranchItem.SetActiveBranchIndex(roleSkillBranchIndexInCurrentGamePlay);
			}
			RoleSkillBranchPopView.SkillBranchItem skillBranchItem2 = this.SkillBranchItem;
			if (skillBranchItem2 != null)
			{
				skillBranchItem2.RefreshIcon(new Func<int, string>(this.RefreshSkillBranchIconHandler));
			}
			int roleBranchIdByIndex = RoleModel.Instance.GetRoleBranchIdByIndex(this.RoleId, roleSkillBranchIndexInCurrentGamePlay);
			SkillBranch? skillBranchConfigById = RoleConfig.Instance.GetSkillBranchConfigById(roleBranchIdByIndex);
			if (skillBranchConfigById == null)
			{
				return;
			}
			UUIText text = base.GetText(3);
			LguiUtil.Instance.SetLocalTextNew(text, skillBranchConfigById.Value.Name, Array.Empty<object>());
		}

		// Token: 0x06041D48 RID: 269640 RVA: 0x01385928 File Offset: 0x01383B28
		private string RefreshSkillBranchIconHandler(int index)
		{
			int roleBranchIdByIndex = RoleModel.Instance.GetRoleBranchIdByIndex(this.RoleId, index);
			SkillBranch? skillBranchConfigById = RoleConfig.Instance.GetSkillBranchConfigById(roleBranchIdByIndex);
			if (skillBranchConfigById == null)
			{
				return string.Empty;
			}
			return skillBranchConfigById.Value.Icon;
		}

		// Token: 0x06041D49 RID: 269641 RVA: 0x01385974 File Offset: 0x01383B74
		private void SwitchSkillBranchHandler(int branchIndex)
		{
			int roleBranchIdByIndex = RoleModel.Instance.GetRoleBranchIdByIndex(this.RoleId, branchIndex);
			SkillBranch? skillBranchConfigById = RoleConfig.Instance.GetSkillBranchConfigById(roleBranchIdByIndex);
			if (skillBranchConfigById == null)
			{
				return;
			}
			RoleController.Instance.ModifyRoleSkillBranchInCurrentGamePlay(this.RoleId, roleBranchIdByIndex, true);
			UUIText text = base.GetText(3);
			LguiUtil.Instance.SetLocalTextNew(text, skillBranchConfigById.Value.Name, Array.Empty<object>());
		}

		// Token: 0x04029B2C RID: 170796
		private int RoleId;

		// Token: 0x04029B2D RID: 170797
		[Nullable(2)]
		private RoleSkillBranchPopView.SkillBranchItem SkillBranchItem;

		// Token: 0x0200BC33 RID: 48179
		[NullableContext(0)]
		private enum EChild
		{
			// Token: 0x04039D86 RID: 236934
			ItemBtn,
			// Token: 0x04039D87 RID: 236935
			RoleItem,
			// Token: 0x04039D88 RID: 236936
			RoleSpine,
			// Token: 0x04039D89 RID: 236937
			TextBranchName,
			// Token: 0x04039D8A RID: 236938
			PanelSkillBranch,
			// Token: 0x04039D8B RID: 236939
			PanelLock,
			// Token: 0x04039D8C RID: 236940
			TextLock,
			// Token: 0x04039D8D RID: 236941
			PanelSkillBranchItem
		}
	}

	// Token: 0x020080F1 RID: 33009
	[NullableContext(0)]
	public class TeamTabItem : GridProxyAbstract<int>
	{
		// Token: 0x06041D4B RID: 269643 RVA: 0x013859EC File Offset: 0x01383BEC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleStateChange));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06041D4C RID: 269644 RVA: 0x01385A92 File Offset: 0x01383C92
		private void OnToggleStateChange(EToggleState state)
		{
			if (state != EToggleState.ETT_Checked)
			{
				return;
			}
			Action<int> selectHandler = this.SelectHandler;
			if (selectHandler == null)
			{
				return;
			}
			selectHandler(base.GridIndex);
		}

		// Token: 0x06041D4D RID: 269645 RVA: 0x01385AB1 File Offset: 0x01383CB1
		public void SetIsSelected(bool isSelected)
		{
			base.GetExtendToggle(0).SetToggleState(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x06041D4E RID: 269646 RVA: 0x01385ACC File Offset: 0x01383CCC
		public override void Refresh(int index, bool isSelected, int gridIndex)
		{
			UUIText text = base.GetText(1);
			string text2 = (index >= 0 && index < RoleSkillBranchPopView.teamTabTextKey.Count) ? RoleSkillBranchPopView.teamTabTextKey[index] : null;
			if (string.IsNullOrEmpty(text2))
			{
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(text, text2, Array.Empty<object>());
		}

		// Token: 0x04029B2E RID: 170798
		[Nullable(2)]
		public Action<int> SelectHandler;

		// Token: 0x0200BC36 RID: 48182
		private enum EChild
		{
			// Token: 0x04039D96 RID: 236950
			Toggle,
			// Token: 0x04039D97 RID: 236951
			TextName
		}
	}

	// Token: 0x020080F2 RID: 33010
	[NullableContext(0)]
	public class SkillBranchItem : CommonRoleSkillBranchSwitchItem
	{
		// Token: 0x06041D50 RID: 269648 RVA: 0x01385B24 File Offset: 0x01383D24
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(base.OnToggleStateChange));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06041D51 RID: 269649 RVA: 0x01385C50 File Offset: 0x01383E50
		[NullableContext(1)]
		protected override SkillBranchSwitchItemGroup[] CollectBranchItems()
		{
			return new SkillBranchSwitchItemGroup[]
			{
				new SkillBranchSwitchItemGroup
				{
					SpriteTagIcon = base.GetSprite(2),
					ActiveIndexHandler = delegate(bool active)
					{
						base.GetItem(3).SetUIActive(active);
						this.SetMiddleIconToLeft(active);
					}
				},
				new SkillBranchSwitchItemGroup
				{
					SpriteTagIcon = base.GetSprite(4),
					ActiveIndexHandler = delegate(bool active)
					{
						base.GetItem(5).SetUIActive(active);
					}
				}
			};
		}

		// Token: 0x06041D52 RID: 269650 RVA: 0x01385CB1 File Offset: 0x01383EB1
		[NullableContext(1)]
		protected override UUIExtendToggle GetBranchToggle()
		{
			return base.GetExtendToggle(0);
		}

		// Token: 0x06041D53 RID: 269651 RVA: 0x01385CBC File Offset: 0x01383EBC
		private void SetMiddleIconToLeft(bool isLeft)
		{
			UUIItem item = base.GetItem(1);
			FVector fvector = new FVector(0f, (float)(isLeft ? 0 : 180), 0f);
			FRotator frotator = FRotator.MakeFromEuler(fvector);
			item.SetUIRelativeRotation(frotator);
		}

		// Token: 0x0200BC37 RID: 48183
		private enum EChild
		{
			// Token: 0x04039D99 RID: 236953
			Toggle,
			// Token: 0x04039D9A RID: 236954
			ItemSpriteMiddle,
			// Token: 0x04039D9B RID: 236955
			SpriteTagIconL,
			// Token: 0x04039D9C RID: 236956
			ItemTagL,
			// Token: 0x04039D9D RID: 236957
			SpriteTagIconR,
			// Token: 0x04039D9E RID: 236958
			ItemTagR
		}
	}
}
