using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001F48 RID: 8008
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class ShipTowerRoleTeamItem : GridProxyAbstract<FormationData>
{
	// Token: 0x06013CE0 RID: 81120 RVA: 0x005C6F58 File Offset: 0x005C5158
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

	// Token: 0x06013CE1 RID: 81121 RVA: 0x005C7018 File Offset: 0x005C5218
	protected override UniTask OnBeforeStartAsync()
	{
		ShipTowerRoleTeamItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ShipTowerRoleTeamItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013CE2 RID: 81122 RVA: 0x005C705B File Offset: 0x005C525B
	[NullableContext(2)]
	private UUIExtendToggle GetItemToggle()
	{
		return base.GetExtendToggle(0);
	}

	// Token: 0x06013CE3 RID: 81123 RVA: 0x005C7064 File Offset: 0x005C5264
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

	// Token: 0x06013CE4 RID: 81124 RVA: 0x005C7098 File Offset: 0x005C5298
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

	// Token: 0x06013CE5 RID: 81125 RVA: 0x005C72B7 File Offset: 0x005C54B7
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

	// Token: 0x06013CE6 RID: 81126 RVA: 0x005C72E4 File Offset: 0x005C54E4
	public override void OnDeselected(bool fireEvent)
	{
		UUIExtendToggle itemToggle = this.GetItemToggle();
		if (itemToggle == null)
		{
			return;
		}
		itemToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x0400A90F RID: 43279
	private readonly List<MediumItemGrid> RoleList = new List<MediumItemGrid>();

	// Token: 0x0400A910 RID: 43280
	private FormationData ItemData;

	// Token: 0x0400A911 RID: 43281
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<FormationData> OnClickCallback;

	// Token: 0x0400A912 RID: 43282
	public ShipTowerStageData StageData;

	// Token: 0x02008238 RID: 33336
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x0402A0BE RID: 172222
		public const int ToggleRoot = 0;

		// Token: 0x0402A0BF RID: 172223
		public const int TxtTeamIndex = 1;

		// Token: 0x0402A0C0 RID: 172224
		public const int ItemRole1 = 2;

		// Token: 0x0402A0C1 RID: 172225
		public const int ItemRole2 = 3;

		// Token: 0x0402A0C2 RID: 172226
		public const int ItemRole3 = 4;

		// Token: 0x0402A0C3 RID: 172227
		public const int SpriteApplyAll = 5;
	}
}
