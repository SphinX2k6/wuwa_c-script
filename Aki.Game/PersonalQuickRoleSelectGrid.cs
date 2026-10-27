using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common;
using CSharpScript.Game.Module.Common.MediumItemGrid;

// Token: 0x020023E0 RID: 9184
public class PersonalQuickRoleSelectGrid : TeamRoleGrid
{
	// Token: 0x060125BF RID: 75199 RVA: 0x004865E4 File Offset: 0x004847E4
	[NullableContext(1)]
	protected override void OnRefresh(RoleDataBase data, bool isSelected, int gridIndex)
	{
		RoleLevelData levelData = data.GetLevelData();
		int dataId = data.GetDataId();
		int? num = new int?(RoleSelectModel.Instance.GetRoleIndex(dataId));
		RoleSkinData roleOriginalSkinData = RoleSkinModel.Instance.GetRoleOriginalSkinData(dataId, true);
		Func<int, bool> isHighlightIndex = this.IsHighlightIndex;
		bool? highlightIndex = (isHighlightIndex != null) ? new bool?(isHighlightIndex(num.Value)) : null;
		CharacterMediumItemGrid characterMediumItemGrid = new CharacterMediumItemGrid();
		characterMediumItemGrid.ItemConfigId = new int?(dataId);
		characterMediumItemGrid.SkinId = roleOriginalSkinData.GetItemId();
		characterMediumItemGrid.BottomTextId = "Text_LevelShow_Text";
		characterMediumItemGrid.BottomTextParameter = new object[]
		{
			levelData.GetLevel()
		};
		CharacterMediumItemGrid characterMediumItemGrid2 = characterMediumItemGrid;
		int? num2 = num;
		int num3 = 0;
		characterMediumItemGrid2.Index = ((num2.GetValueOrDefault() > num3 & num2 != null) ? num : null);
		characterMediumItemGrid.HighlightIndex = highlightIndex;
		characterMediumItemGrid.ElementId = new int?(data.GetRoleConfig().ElementId);
		characterMediumItemGrid.Data = data;
		characterMediumItemGrid.IsNewVisible = new bool?(NewFlagModel.Instance.HasNewFlag(ELocalStoragePlayerKey.PersonalDataItem, dataId));
		CharacterMediumItemGrid parameters = characterMediumItemGrid;
		base.Apply<CharacterMediumItemGrid>(parameters);
		bool bSelected = RoleSelectModel.Instance.SelectedRoleSet.Contains(dataId);
		this.SetSelected(bSelected, true);
	}
}
