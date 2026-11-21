using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.MediumItemGrid;

// Token: 0x02001CDD RID: 7389
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class RoleTowerMonsterPreviewGridItem : LoopScrollMediumItemGrid<RoleTowerMonsterInfoData>
{
	// Token: 0x0601249F RID: 74911 RVA: 0x00564BE0 File Offset: 0x00562DE0
	protected override void OnRefresh(RoleTowerMonsterInfoData data, bool isSelected, int gridIndex)
	{
		int monsterInfoId = data.MonsterInfoId;
		MonsterInfo? monsterInfoConfig = MonsterInfoConfig.Instance.GetMonsterInfoConfig(monsterInfoId);
		base.Apply<PhantomMediumItemGrid>(new PhantomMediumItemGrid
		{
			MonsterId = new int?(monsterInfoId),
			BottomText = ((monsterInfoConfig == null) ? string.Empty : MonsterInfoConfig.Instance.GetMonsterName(monsterInfoId)),
			RoleTowerEnemyLevel = RoleTowerModel.Instance.GetCurLevelEntityLevel(),
			RoleTowerElementId = RoleTowerMonsterPreviewGridItem.GetMonsterElementId(monsterInfoConfig),
			Data = data
		});
	}

	// Token: 0x060124A0 RID: 74912 RVA: 0x00564C5C File Offset: 0x00562E5C
	private static int? GetMonsterElementId(MonsterInfo? monsterCfg)
	{
		if (monsterCfg == null || monsterCfg.Value.ElementIdArrayLength <= 0)
		{
			return null;
		}
		return new int?(monsterCfg.Value.ElementIdArray(0));
	}

	// Token: 0x060124A1 RID: 74913 RVA: 0x00564CA3 File Offset: 0x00562EA3
	protected override bool OnCanExecuteChange()
	{
		return false;
	}

	// Token: 0x060124A2 RID: 74914 RVA: 0x00564CA6 File Offset: 0x00562EA6
	public override object GetKey(RoleTowerMonsterInfoData data, int displayIndex)
	{
		return displayIndex;
	}
}
