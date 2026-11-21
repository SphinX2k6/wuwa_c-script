using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Quest;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020020DA RID: 8410
[NullableContext(1)]
[Nullable(0)]
public class SurvivorsRogueCurrencyItem : CommonCurrencyItem
{
	// Token: 0x06014A76 RID: 84598 RVA: 0x00604D64 File Offset: 0x00602F64
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

	// Token: 0x06014A77 RID: 84599 RVA: 0x00604DAF File Offset: 0x00602FAF
	public override void AddEventListener()
	{
		SurvivorsRogueModel.Instance.BattleData.BehaviorDelegate.AddTreeVarUpdateDelegate(ESurvivorsRougeSystemVarType.Gold.ToEnumString(), new TTreeVarUpdateDelegate(this.OnSurvivorsCurrencyUpdate));
	}

	// Token: 0x06014A78 RID: 84600 RVA: 0x00604DD7 File Offset: 0x00602FD7
	public override void RemoveEventListener()
	{
		SurvivorsRogueModel.Instance.BattleData.BehaviorDelegate.RemoveTreeVarUpdateDelegate(ESurvivorsRougeSystemVarType.Gold.ToEnumString(), new TTreeVarUpdateDelegate(this.OnSurvivorsCurrencyUpdate));
	}

	// Token: 0x06014A79 RID: 84601 RVA: 0x00604E00 File Offset: 0x00603000
	private void OnSurvivorsCurrencyUpdate(VarDefinePb lastVarDefine, VarDefinePb newVarDefine)
	{
		long num = MathUtils.Instance.LongToNumber(newVarDefine.Int);
		base.SetCount((int)num);
	}
}
