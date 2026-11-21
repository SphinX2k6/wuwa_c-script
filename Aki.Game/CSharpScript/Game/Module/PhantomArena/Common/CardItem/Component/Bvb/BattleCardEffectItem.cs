using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardItem.Component.Bvb
{
	// Token: 0x020041CD RID: 16845
	public class BattleCardEffectItem : UiPanelBase
	{
		// Token: 0x0602AA1D RID: 174621 RVA: 0x00C046C1 File Offset: 0x00C028C1
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUINiagara)),
				new ValueTuple<int, Type>(1, typeof(UUINiagara))
			};
		}

		// Token: 0x0602AA1E RID: 174622 RVA: 0x00C046FC File Offset: 0x00C028FC
		[NullableContext(1)]
		protected UniTask RefreshNiagara(string path, UUINiagara niagara)
		{
			BattleCardEffectItem.<RefreshNiagara>d__3 <RefreshNiagara>d__;
			<RefreshNiagara>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshNiagara>d__.<>4__this = this;
			<RefreshNiagara>d__.path = path;
			<RefreshNiagara>d__.niagara = niagara;
			<RefreshNiagara>d__.<>1__state = -1;
			<RefreshNiagara>d__.<>t__builder.Start<BattleCardEffectItem.<RefreshNiagara>d__3>(ref <RefreshNiagara>d__);
			return <RefreshNiagara>d__.<>t__builder.Task;
		}

		// Token: 0x0602AA1F RID: 174623 RVA: 0x00C04750 File Offset: 0x00C02950
		protected override UniTask OnBeforeStartAsync()
		{
			BattleCardEffectItem.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<BattleCardEffectItem.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602AA20 RID: 174624 RVA: 0x00C04794 File Offset: 0x00C02994
		private UniTask RefreshEffect(int configId)
		{
			BattleCardEffectItem.<RefreshEffect>d__5 <RefreshEffect>d__;
			<RefreshEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshEffect>d__.<>4__this = this;
			<RefreshEffect>d__.configId = configId;
			<RefreshEffect>d__.<>1__state = -1;
			<RefreshEffect>d__.<>t__builder.Start<BattleCardEffectItem.<RefreshEffect>d__5>(ref <RefreshEffect>d__);
			return <RefreshEffect>d__.<>t__builder.Task;
		}

		// Token: 0x0602AA21 RID: 174625 RVA: 0x00C047E0 File Offset: 0x00C029E0
		public UniTask RefreshEffectById(int configId)
		{
			BattleCardEffectItem.<RefreshEffectById>d__6 <RefreshEffectById>d__;
			<RefreshEffectById>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshEffectById>d__.<>4__this = this;
			<RefreshEffectById>d__.configId = configId;
			<RefreshEffectById>d__.<>1__state = -1;
			<RefreshEffectById>d__.<>t__builder.Start<BattleCardEffectItem.<RefreshEffectById>d__6>(ref <RefreshEffectById>d__);
			return <RefreshEffectById>d__.<>t__builder.Task;
		}

		// Token: 0x0602AA22 RID: 174626 RVA: 0x00C0482C File Offset: 0x00C02A2C
		public void PlayStartEffect()
		{
			UUINiagara uiNiagara = base.GetUiNiagara(0);
			UUINiagara uiNiagara2 = base.GetUiNiagara(1);
			this.SetActive(true);
			if (uiNiagara != null && uiNiagara.IsUIActiveSelf())
			{
				uiNiagara.ActivateSystem(true);
			}
			if (uiNiagara2 != null && uiNiagara2.IsUIActiveSelf())
			{
				uiNiagara2.ActivateSystem(true);
			}
		}

		// Token: 0x0602AA23 RID: 174627 RVA: 0x00C04874 File Offset: 0x00C02A74
		public void SetCardConfigId(int cardConfigId)
		{
			this.CardConfigId = cardConfigId;
		}

		// Token: 0x040171CE RID: 94670
		protected int CardConfigId;

		// Token: 0x02009DC8 RID: 40392
		private static class EBattleCardEffectItem
		{
			// Token: 0x0403111E RID: 200990
			public const int StartOneNiagara = 0;

			// Token: 0x0403111F RID: 200991
			public const int StartTwoNiagara = 1;
		}
	}
}
