using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Quest;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02003A8E RID: 14990
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseGoldCostItem : CommonCurrencyItem
	{
		// Token: 0x06026850 RID: 157776 RVA: 0x00ACBDD0 File Offset: 0x00AC9FD0
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

		// Token: 0x06026851 RID: 157777 RVA: 0x00ACBE1B File Offset: 0x00ACA01B
		public override void AddEventListener()
		{
			TrapDefenseModel.Instance.BattleData.AddTreeVarUpdateDelegate(ETrapDefenseSystemVarType.Gold, new TTreeVarUpdateDelegate(this.OnCurrentGoldUpdate));
		}

		// Token: 0x06026852 RID: 157778 RVA: 0x00ACBE39 File Offset: 0x00ACA039
		public override void RemoveEventListener()
		{
			TrapDefenseModel.Instance.BattleData.RemoveTreeVarUpdateDelegate(ETrapDefenseSystemVarType.Gold, new TTreeVarUpdateDelegate(this.OnCurrentGoldUpdate));
		}

		// Token: 0x06026853 RID: 157779 RVA: 0x00ACBE58 File Offset: 0x00ACA058
		public void OnCurrentGoldUpdate(VarDefinePb lastVarDefine, VarDefinePb newVarDefine)
		{
			long num = MathUtils.Instance.LongToNumber(newVarDefine.Int);
			base.SetCount((int)num);
		}

		// Token: 0x06026854 RID: 157780 RVA: 0x00ACBE7E File Offset: 0x00ACA07E
		public void UpdateGoldCostNum()
		{
			base.SetCount((int)TrapDefenseModel.Instance.BattleData.GetGoldNum());
		}
	}
}
