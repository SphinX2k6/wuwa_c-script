using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.Components
{
	// Token: 0x02005770 RID: 22384
	[NullableContext(1)]
	[Nullable(0)]
	public class KurotatoCurrencyItem : CommonCurrencyItem
	{
		// Token: 0x06038DCA RID: 232906 RVA: 0x00D8292C File Offset: 0x00D80B2C
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

		// Token: 0x06038DCB RID: 232907 RVA: 0x00D8297F File Offset: 0x00D80B7F
		protected override void OnStart()
		{
			this.SeqPlayer = new LevelSequencePlayer(base.GetRootItem());
			base.OnStart();
		}

		// Token: 0x06038DCC RID: 232908 RVA: 0x00D82998 File Offset: 0x00D80B98
		public override void AddEventListener()
		{
			KurotatoModel.Instance.BattleData.BehaviorDelegate.AddTreeVarUpdateDelegate(this.CurrencyType.Value.ToEnumString(), new TTreeVarUpdateDelegate(this.OnSurvivorsCurrencyUpdate));
		}

		// Token: 0x06038DCD RID: 232909 RVA: 0x00D829CA File Offset: 0x00D80BCA
		public override void RemoveEventListener()
		{
			KurotatoModel.Instance.BattleData.BehaviorDelegate.RemoveTreeVarUpdateDelegate(this.CurrencyType.Value.ToEnumString(), new TTreeVarUpdateDelegate(this.OnSurvivorsCurrencyUpdate));
		}

		// Token: 0x06038DCE RID: 232910 RVA: 0x00D829FC File Offset: 0x00D80BFC
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

		// Token: 0x0401DD2C RID: 122156
		private EKurotatoSystemVarType? CurrencyType;

		// Token: 0x0401DD2D RID: 122157
		private LevelSequencePlayer SeqPlayer;
	}
}
