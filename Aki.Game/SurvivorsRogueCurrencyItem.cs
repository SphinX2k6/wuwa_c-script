using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Quest;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002B5E RID: 11102
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsRogueCurrencyItem : CommonCurrencyItem
{
	// Token: 0x06017045 RID: 94277 RVA: 0x005D81FC File Offset: 0x005D63FC
	public UniTask Init(UUIItem item)
	{
		SurvivorsRogueCurrencyItem.<Init>d__0 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.item = item;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<SurvivorsRogueCurrencyItem.<Init>d__0>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x06017046 RID: 94278 RVA: 0x005D8247 File Offset: 0x005D6447
	public override void AddEventListener()
	{
		SurvivorsRogueModel.Instance.BattleData.BehaviorDelegate.AddTreeVarUpdateDelegate(ESurvivorsRougeSystemVarType.Gold.ToEnumString(), new TTreeVarUpdateDelegate(this.OnSurvivorsCurrencyUpdate));
	}

	// Token: 0x06017047 RID: 94279 RVA: 0x005D826F File Offset: 0x005D646F
	public override void RemoveEventListener()
	{
		SurvivorsRogueModel.Instance.BattleData.BehaviorDelegate.RemoveTreeVarUpdateDelegate(ESurvivorsRougeSystemVarType.Gold.ToEnumString(), new TTreeVarUpdateDelegate(this.OnSurvivorsCurrencyUpdate));
	}

	// Token: 0x06017048 RID: 94280 RVA: 0x005D8298 File Offset: 0x005D6498
	private void OnSurvivorsCurrencyUpdate(VarDefinePb lastVarDefine, VarDefinePb newVarDefine)
	{
		long num = MathUtils.Instance.LongToNumber(newVarDefine.Int);
		base.SetCount((int)num);
	}
}
