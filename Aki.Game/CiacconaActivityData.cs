using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.CiacconaGal;

// Token: 0x02000692 RID: 1682
public class CiacconaActivityData : ActivityBaseData
{
	// Token: 0x06004D80 RID: 19840 RVA: 0x001A343C File Offset: 0x001A163C
	protected override bool GetExDataFinishShowState()
	{
		return CiacconaGalModel.Instance.HasAllRewardReceived();
	}

	// Token: 0x06004D81 RID: 19841 RVA: 0x001A3448 File Offset: 0x001A1648
	[NullableContext(1)]
	protected override void PhraseEx(ActivityData data)
	{
		CiacconaGalModel.Instance.UpdateByServerActivityData(data, base.Id);
	}

	// Token: 0x06004D82 RID: 19842 RVA: 0x001A345C File Offset: 0x001A165C
	public override bool GetExDataRedPointShowState()
	{
		bool flag = CiacconaGalModel.Instance.HasAnyEndingReward();
		bool flag2 = CiacconaGalModel.Instance.HasAnyProgressReward();
		bool flag3 = CiacconaGalModel.Instance.HasAnySubEndingReward();
		return flag || flag2 || flag3;
	}
}
