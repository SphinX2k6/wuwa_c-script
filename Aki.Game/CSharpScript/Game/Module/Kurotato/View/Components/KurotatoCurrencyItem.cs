using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.Components
{
	// Token: 0x02004747 RID: 18247
	[NullableContext(1)]
	[Nullable(0)]
	public class KurotatoCurrencyItem : CommonCurrencyItem
	{
		// Token: 0x0602DCDA RID: 187610 RVA: 0x00CD1428 File Offset: 0x00CCF628
		public UniTask Init(UUIItem item, EKurotatoSystemVarType currencyType)
		{
			KurotatoCurrencyItem.<Init>d__2 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.item = item;
			<Init>d__.currencyType = currencyType;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<KurotatoCurrencyItem.<Init>d__2>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x0602DCDB RID: 187611 RVA: 0x00CD147B File Offset: 0x00CCF67B
		protected override void OnStart()
		{
			this.SeqPlayer = new LevelSequencePlayer(base.GetRootItem());
			base.OnStart();
		}

		// Token: 0x0602DCDC RID: 187612 RVA: 0x00CD1494 File Offset: 0x00CCF694
		public override void AddEventListener()
		{
			KurotatoModel.Instance.BattleData.BehaviorDelegate.AddTreeVarUpdateDelegate(this.CurrencyType.Value.ToEnumString(), new TTreeVarUpdateDelegate(this.OnSurvivorsCurrencyUpdate));
		}

		// Token: 0x0602DCDD RID: 187613 RVA: 0x00CD14C6 File Offset: 0x00CCF6C6
		public override void RemoveEventListener()
		{
			KurotatoModel.Instance.BattleData.BehaviorDelegate.RemoveTreeVarUpdateDelegate(this.CurrencyType.Value.ToEnumString(), new TTreeVarUpdateDelegate(this.OnSurvivorsCurrencyUpdate));
		}

		// Token: 0x0602DCDE RID: 187614 RVA: 0x00CD14F8 File Offset: 0x00CCF6F8
		public void OnSurvivorsCurrencyUpdate([Nullable(2)] VarDefinePb lastVarDefine, VarDefinePb newVarDefine)
		{
			int num = (int)MathUtils.Instance.LongToNumber(newVarDefine.Int);
			base.SetCount(num);
			if (lastVarDefine == null)
			{
				return;
			}
			int num2 = (int)MathUtils.Instance.LongToNumber(lastVarDefine.Int);
			if (num > num2)
			{
				this.SeqPlayer.PlayOrReplaySequenceByName("Acquire", false, null);
				return;
			}
			if (num < num2)
			{
				this.SeqPlayer.PlayOrReplaySequenceByName("Lose", false, null);
			}
		}

		// Token: 0x040187C2 RID: 100290
		private EKurotatoSystemVarType? CurrencyType;

		// Token: 0x040187C3 RID: 100291
		private LevelSequencePlayer SeqPlayer;
	}
}
