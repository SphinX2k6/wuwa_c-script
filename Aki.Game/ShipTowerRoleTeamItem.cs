using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020029CD RID: 10701
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class ShipTowerRoleTeamItem : GridProxyAbstract<FormationData>
{
	// Token: 0x060162DA RID: 90842 RVA: 0x0059BFA0 File Offset: 0x0059A1A0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUISprite))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggleRoot))
		};
	}

	// Token: 0x060162DB RID: 90843 RVA: 0x0059C060 File Offset: 0x0059A260
	protected override UniTask OnBeforeStartAsync()
	{
		ShipTowerRoleTeamItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ShipTowerRoleTeamItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060162DC RID: 90844 RVA: 0x0059C0A3 File Offset: 0x0059A2A3
	[NullableContext(2)]
	private UUIExtendToggle GetItemToggle()
	{
		return base.GetExtendToggle(0);
	}

	// Token: 0x060162DD RID: 90845 RVA: 0x0059C0AC File Offset: 0x0059A2AC
	private void OnClickToggleRoot(EToggleState state)
	{
		UUIExtendToggle itemToggle = this.GetItemToggle();
		if (itemToggle != null)
		{
			itemToggle.SetToggleStateForce(EToggleState.ETT_Checked, false, false, false);
		}
		IScrollViewDelegate<IGridProxy<FormationData>, FormationData> scrollViewDelegate = base.ScrollViewDelegate;
		if (scrollViewDelegate == null)
		{
			return;
		}
		scrollViewDelegate.SelectGridProxy(base.GridIndex, base.DisplayIndex, false);
	}

	// Token: 0x060162DE RID: 90846 RVA: 0x0059C0E0 File Offset: 0x0059A2E0
	public override void Refresh(FormationData data, bool isSelected, int gridIndex)
	{
		this.ItemData = data;
		bool flag = true;
		List<int> roleIdListWithTrial = data.GetRoleIdListWithTrial(false);
		for (int i = 0; i < this.RoleList.Count; i++)
		{
			int num = (i < roleIdListWithTrial.Count) ? roleIdListWithTrial[i] : 0;
			MediumItemGrid mediumItemGrid = this.RoleList[i];
			if (num != 0)
			{
				RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(num, true);
				ShipTowerRoleData allTeamRoleData = ShipTowerModel.Instance.GetAllTeamRoleData(num);
				FormationRoleData roleDataById2 = data.GetRoleDataById(num);
				int roleCurrentBranchIndex = RoleModel.Instance.GetRoleCurrentBranchIndex(num);
				CharacterMediumItemGrid parameters = new CharacterMediumItemGrid
				{
					ItemConfigId = new int?(num),
					SkinId = ((roleDataById2 != null) ? roleDataById2.RoleSkinId : 0),
					BottomTextId = "Text_LevelShow_Text",
					BottomTextParameter = new object[]
					{
						roleDataById.GetLevelData().GetLevel()
					},
					ElementId = new int?(roleDataById.GetRoleConfig().ElementId),
					HalfAreaInfo = allTeamRoleData,
					IsTrialRoleVisible = new bool?(roleDataById.IsTrialRole()),
					SkillBranchIndex = ((roleCurrentBranchIndex > -1) ? new int?(roleCurrentBranchIndex) : null)
				};
				mediumItemGrid.Apply<CharacterMediumItemGrid>(parameters);
				if (allTeamRoleData == null)
				{
					flag = false;
				}
			}
			else
			{
				flag = false;
				mediumItemGrid.Apply<OnlyEmptyItemGrid>(new OnlyEmptyItemGrid());
			}
		}
		base.GetText(1).SetText(data.FormationId.ToString(), true);
		if (flag)
		{
			List<int> roleIdList = data.RoleIdList;
			flag = false;
			for (int j = 0; j < this.StageData.TeamDataList.Count; j++)
			{
				List<int> roleIdListEdit = this.StageData.TeamDataList[j].GetRoleIdListEdit();
				if (roleIdListEdit.Count == roleIdList.Count)
				{
					bool flag2 = true;
					for (int k = 0; k < roleIdList.Count; k++)
					{
						if (roleIdListEdit[k] != roleIdList[k])
						{
							flag2 = false;
							break;
						}
					}
					if (flag2)
					{
						flag = true;
						break;
					}
				}
			}
		}
		UUISprite sprite = base.GetSprite(5);
		if (sprite == null)
		{
			return;
		}
		sprite.SetUIActive(flag);
	}

	// Token: 0x060162DF RID: 90847 RVA: 0x0059C2FF File Offset: 0x0059A4FF
	public override void OnSelected(bool fireEvent)
	{
		UUIExtendToggle itemToggle = this.GetItemToggle();
		if (itemToggle != null)
		{
			itemToggle.SetToggleStateForce(EToggleState.ETT_Checked, false, false, false);
		}
		Action<FormationData> onClickCallback = this.OnClickCallback;
		if (onClickCallback == null)
		{
			return;
		}
		onClickCallback(this.ItemData);
	}

	// Token: 0x060162E0 RID: 90848 RVA: 0x0059C32C File Offset: 0x0059A52C
	public override void OnDeselected(bool fireEvent)
	{
		UUIExtendToggle itemToggle = this.GetItemToggle();
		if (itemToggle == null)
		{
			return;
		}
		itemToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x0400A525 RID: 42277
	private readonly List<MediumItemGrid> RoleList = new List<MediumItemGrid>();

	// Token: 0x0400A526 RID: 42278
	private FormationData ItemData;

	// Token: 0x0400A527 RID: 42279
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<FormationData> OnClickCallback;

	// Token: 0x0400A528 RID: 42280
	public ShipTowerStageData StageData;

	// Token: 0x02008FF1 RID: 36849
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x0402E9C6 RID: 190918
		public const int ToggleRoot = 0;

		// Token: 0x0402E9C7 RID: 190919
		public const int TxtTeamIndex = 1;

		// Token: 0x0402E9C8 RID: 190920
		public const int ItemRole1 = 2;

		// Token: 0x0402E9C9 RID: 190921
		public const int ItemRole2 = 3;

		// Token: 0x0402E9CA RID: 190922
		public const int ItemRole3 = 4;

		// Token: 0x0402E9CB RID: 190923
		public const int SpriteApplyAll = 5;
	}
}
