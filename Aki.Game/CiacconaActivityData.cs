using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.CiacconaGal;

// Token: 0x020011DE RID: 4574
public class CiacconaActivityData : ActivityBaseData
{
	// Token: 0x060079E9 RID: 31209 RVA: 0x0019A78C File Offset: 0x0019898C
	protected override bool GetExDataFinishShowState()
	{
		return CiacconaGalModel.Instance.HasAllRewardReceived();
	}

	// Token: 0x060079EA RID: 31210 RVA: 0x0019A798 File Offset: 0x00198998
	[NullableContext(1)]
	protected override void PhraseEx(ActivityData data)
	{
		CiacconaGalModel.Instance.UpdateByServerActivityData(data, base.Id);
	}

	// Token: 0x060079EB RID: 31211 RVA: 0x0019A7AC File Offset: 0x001989AC
	public override bool GetExDataRedPointShowState()
	{
		bool flag = CiacconaGalModel.Instance.HasAnyEndingReward();
		bool flag2 = CiacconaGalModel.Instance.HasAnyProgressReward();
		bool flag3 = CiacconaGalModel.Instance.HasAnySubEndingReward();
		return flag || flag2 || flag3;
	}
}
