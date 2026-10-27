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

// Token: 0x020028A2 RID: 10402
[NullableContext(1)]
[Nullable(0)]
public class RoleSkillBranchPopView : UiViewBase
{
	// Token: 0x06015779 RID: 87929 RVA: 0x0056A12E File Offset: 0x0056832E
	public RoleSkillBranchPopView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0601577A RID: 87930 RVA: 0x0056A150 File Offset: 0x00568350
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

	// Token: 0x0601577B RID: 87931 RVA: 0x0056A260 File Offset: 0x00568460
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

	// Token: 0x0601577C RID: 87932 RVA: 0x0056A472 File Offset: 0x00568672
	private RoleSkillBranchPopView.RoleSkillBranchPopViewRoleItem CreateRoleItem()
	{
		return new RoleSkillBranchPopView.RoleSkillBranchPopViewRoleItem();
	}

	// Token: 0x0601577D RID: 87933 RVA: 0x0056A479 File Offset: 0x00568679
	private RoleSkillBranchPopView.TeamTabItem CreateTeamTabItem()
	{
		return new RoleSkillBranchPopView.TeamTabItem
		{
			SelectHandler = new Action<int>(this.ClickTabHandler)
		};
	}

	// Token: 0x0601577E RID: 87934 RVA: 0x0056A492 File Offset: 0x00568692
	private void ClickTabHandler(int index)
	{
		this.SelectTab(index, true);
	}

	// Token: 0x0601577F RID: 87935 RVA: 0x0056A49C File Offset: 0x0056869C
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

	// Token: 0x0400A002 RID: 40962
	protected static readonly IReadOnlyList<string> teamTabTextKey = new List<string>
	{
		"GhostShipTeamName_Text1",
		"GhostShipTeamName_Text2"
	};

	// Token: 0x0400A003 RID: 40963
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<RoleSkillBranchPopView.RoleSkillBranchPopViewRoleItem, RoleSkillBranchPopView.RoleData> RoleLayout;

	// Token: 0x0400A004 RID: 40964
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<RoleSkillBranchPopView.TeamTabItem, int> TabLayout;

	// Token: 0x0400A005 RID: 40965
	private List<List<RoleSkillBranchPopView.RoleData>> TabData = new List<List<RoleSkillBranchPopView.RoleData>>();

	// Token: 0x0400A006 RID: 40966
	private List<int> TabIndex = new List<int>();

	// Token: 0x02008EA7 RID: 36519
	[NullableContext(0)]
	public class RoleData
	{
		// Token: 0x1700A091 RID: 41105
		// (get) Token: 0x0604B83F RID: 309311 RVA: 0x013DA353 File Offset: 0x013D8553
		// (set) Token: 0x0604B840 RID: 309312 RVA: 0x013DA35B File Offset: 0x013D855B
		public int RoleId { get; set; }

		// Token: 0x1700A092 RID: 41106
		// (get) Token: 0x0604B841 RID: 309313 RVA: 0x013DA364 File Offset: 0x013D8564
		// (set) Token: 0x0604B842 RID: 309314 RVA: 0x013DA36C File Offset: 0x013D856C
		public int SkillBranchIndex { get; set; } = -1;
	}

	// Token: 0x02008EA8 RID: 36520
	[NullableContext(0)]
	private enum EChild
	{
		// Token: 0x0402E428 RID: 189480
		TextTitle,
		// Token: 0x0402E429 RID: 189481
		PanelRoleList,
		// Token: 0x0402E42A RID: 189482
		ItemRole,
		// Token: 0x0402E42B RID: 189483
		ItemTextSingleTeam,
		// Token: 0x0402E42C RID: 189484
		PanelTeamTab,
		// Token: 0x0402E42D RID: 189485
		ItemTeamTab,
		// Token: 0x0402E42E RID: 189486
		ItemTextMultiTeam
	}

	// Token: 0x02008EA9 RID: 36521
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoleSkillBranchPopViewRoleItem : GridProxyAbstract<RoleSkillBranchPopView.RoleData>
	{
		// Token: 0x0604B844 RID: 309316 RVA: 0x013DA384 File Offset: 0x013D8584
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

		// Token: 0x0604B845 RID: 309317 RVA: 0x013DA4B4 File Offset: 0x013D86B4
		protected override UniTask OnBeforeStartAsync()
		{
			RoleSkillBranchPopView.RoleSkillBranchPopViewRoleItem.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoleSkillBranchPopView.RoleSkillBranchPopViewRoleItem.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0604B846 RID: 309318 RVA: 0x013DA4F8 File Offset: 0x013D86F8
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

		// Token: 0x0604B847 RID: 309319 RVA: 0x013DA6B4 File Offset: 0x013D88B4
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

		// Token: 0x0604B848 RID: 309320 RVA: 0x013DA700 File Offset: 0x013D8900
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

		// Token: 0x0402E42F RID: 189487
		private int RoleId;

		// Token: 0x0402E430 RID: 189488
		[Nullable(2)]
		private RoleSkillBranchPopView.SkillBranchItem SkillBranchItem;

		// Token: 0x0200D055 RID: 53333
		[NullableContext(0)]
		private enum EChild
		{
			// Token: 0x0403E93E RID: 256318
			ItemBtn,
			// Token: 0x0403E93F RID: 256319
			RoleItem,
			// Token: 0x0403E940 RID: 256320
			RoleSpine,
			// Token: 0x0403E941 RID: 256321
			TextBranchName,
			// Token: 0x0403E942 RID: 256322
			PanelSkillBranch,
			// Token: 0x0403E943 RID: 256323
			PanelLock,
			// Token: 0x0403E944 RID: 256324
			TextLock,
			// Token: 0x0403E945 RID: 256325
			PanelSkillBranchItem
		}
	}

	// Token: 0x02008EAA RID: 36522
	[NullableContext(0)]
	public class TeamTabItem : GridProxyAbstract<int>
	{
		// Token: 0x0604B84A RID: 309322 RVA: 0x013DA778 File Offset: 0x013D8978
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

		// Token: 0x0604B84B RID: 309323 RVA: 0x013DA81E File Offset: 0x013D8A1E
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

		// Token: 0x0604B84C RID: 309324 RVA: 0x013DA83D File Offset: 0x013D8A3D
		public void SetIsSelected(bool isSelected)
		{
			base.GetExtendToggle(0).SetToggleState(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		}

		// Token: 0x0604B84D RID: 309325 RVA: 0x013DA858 File Offset: 0x013D8A58
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

		// Token: 0x0402E431 RID: 189489
		[Nullable(2)]
		public Action<int> SelectHandler;

		// Token: 0x0200D058 RID: 53336
		private enum EChild
		{
			// Token: 0x0403E94E RID: 256334
			Toggle,
			// Token: 0x0403E94F RID: 256335
			TextName
		}
	}

	// Token: 0x02008EAB RID: 36523
	[NullableContext(0)]
	public class SkillBranchItem : CommonRoleSkillBranchSwitchItem
	{
		// Token: 0x0604B84F RID: 309327 RVA: 0x013DA8B0 File Offset: 0x013D8AB0
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

		// Token: 0x0604B850 RID: 309328 RVA: 0x013DA9DC File Offset: 0x013D8BDC
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

		// Token: 0x0604B851 RID: 309329 RVA: 0x013DAA3D File Offset: 0x013D8C3D
		[NullableContext(1)]
		protected override UUIExtendToggle GetBranchToggle()
		{
			return base.GetExtendToggle(0);
		}

		// Token: 0x0604B852 RID: 309330 RVA: 0x013DAA48 File Offset: 0x013D8C48
		private void SetMiddleIconToLeft(bool isLeft)
		{
			UUIItem item = base.GetItem(1);
			FVector fvector = new FVector(0f, (float)(isLeft ? 0 : 180), 0f);
			FRotator frotator = FRotator.MakeFromEuler(fvector);
			item.SetUIRelativeRotation(frotator);
		}

		// Token: 0x0200D059 RID: 53337
		private enum EChild
		{
			// Token: 0x0403E951 RID: 256337
			Toggle,
			// Token: 0x0403E952 RID: 256338
			ItemSpriteMiddle,
			// Token: 0x0403E953 RID: 256339
			SpriteTagIconL,
			// Token: 0x0403E954 RID: 256340
			ItemTagL,
			// Token: 0x0403E955 RID: 256341
			SpriteTagIconR,
			// Token: 0x0403E956 RID: 256342
			ItemTagR
		}
	}
}
