using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Quest;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004AE6 RID: 19174
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseGoldCostItem : CommonCurrencyItem
	{
		// Token: 0x06031AC0 RID: 203456 RVA: 0x00B87E1C File Offset: 0x00B8601C
		public UniTask Init(UUIItem item)
		{
			TrapDefenseGoldCostItem.<Init>d__0 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.item = item;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<TrapDefenseGoldCostItem.<Init>d__0>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x06031AC1 RID: 203457 RVA: 0x00B87E67 File Offset: 0x00B86067
		public override void AddEventListener()
		{
			TrapDefenseModel.Instance.BattleData.AddTreeVarUpdateDelegate(ETrapDefenseSystemVarType.Gold, new TTreeVarUpdateDelegate(this.OnCurrentGoldUpdate));
		}

		// Token: 0x06031AC2 RID: 203458 RVA: 0x00B87E85 File Offset: 0x00B86085
		public override void RemoveEventListener()
		{
			TrapDefenseModel.Instance.BattleData.RemoveTreeVarUpdateDelegate(ETrapDefenseSystemVarType.Gold, new TTreeVarUpdateDelegate(this.OnCurrentGoldUpdate));
		}

		// Token: 0x06031AC3 RID: 203459 RVA: 0x00B87EA4 File Offset: 0x00B860A4
		public void OnCurrentGoldUpdate(VarDefinePb lastVarDefine, VarDefinePb newVarDefine)
		{
			long num = MathUtils.Instance.LongToNumber(newVarDefine.Int);
			base.SetCount((int)num);
		}

		// Token: 0x06031AC4 RID: 203460 RVA: 0x00B87ECA File Offset: 0x00B860CA
		public void UpdateGoldCostNum()
		{
			base.SetCount((int)TrapDefenseModel.Instance.BattleData.GetGoldNum());
		}
	}
}
