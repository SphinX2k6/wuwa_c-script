using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardItem.Component.Bvb
{
	// Token: 0x020051FE RID: 20990
	public class BattleCardLoopEffectItem : UiPanelBase
	{
		// Token: 0x06035B2A RID: 219946 RVA: 0x00CB7249 File Offset: 0x00CB5449
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUINiagara))
			};
		}

		// Token: 0x06035B2B RID: 219947 RVA: 0x00CB726C File Offset: 0x00CB546C
		[NullableContext(1)]
		protected UniTask RefreshNiagara(string path, UUINiagara niagara)
		{
			BattleCardLoopEffectItem.<RefreshNiagara>d__3 <RefreshNiagara>d__;
			<RefreshNiagara>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshNiagara>d__.<>4__this = this;
			<RefreshNiagara>d__.path = path;
			<RefreshNiagara>d__.niagara = niagara;
			<RefreshNiagara>d__.<>1__state = -1;
			<RefreshNiagara>d__.<>t__builder.Start<BattleCardLoopEffectItem.<RefreshNiagara>d__3>(ref <RefreshNiagara>d__);
			return <RefreshNiagara>d__.<>t__builder.Task;
		}

		// Token: 0x06035B2C RID: 219948 RVA: 0x00CB72C0 File Offset: 0x00CB54C0
		protected override UniTask OnBeforeStartAsync()
		{
			BattleCardLoopEffectItem.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<BattleCardLoopEffectItem.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035B2D RID: 219949 RVA: 0x00CB7304 File Offset: 0x00CB5504
		private UniTask RefreshEffect(int configId)
		{
			BattleCardLoopEffectItem.<RefreshEffect>d__5 <RefreshEffect>d__;
			<RefreshEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshEffect>d__.<>4__this = this;
			<RefreshEffect>d__.<>1__state = -1;
			<RefreshEffect>d__.<>t__builder.Start<BattleCardLoopEffectItem.<RefreshEffect>d__5>(ref <RefreshEffect>d__);
			return <RefreshEffect>d__.<>t__builder.Task;
		}

		// Token: 0x06035B2E RID: 219950 RVA: 0x00CB7348 File Offset: 0x00CB5548
		public UniTask RefreshEffectById(int configId)
		{
			BattleCardLoopEffectItem.<RefreshEffectById>d__6 <RefreshEffectById>d__;
			<RefreshEffectById>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshEffectById>d__.<>4__this = this;
			<RefreshEffectById>d__.configId = configId;
			<RefreshEffectById>d__.<>1__state = -1;
			<RefreshEffectById>d__.<>t__builder.Start<BattleCardLoopEffectItem.<RefreshEffectById>d__6>(ref <RefreshEffectById>d__);
			return <RefreshEffectById>d__.<>t__builder.Task;
		}

		// Token: 0x06035B2F RID: 219951 RVA: 0x00CB7393 File Offset: 0x00CB5593
		public void SetCardConfigId(int cardConfigId)
		{
			this.CardConfigId = cardConfigId;
		}

		// Token: 0x0401C79A RID: 116634
		protected int CardConfigId;

		// Token: 0x0200B395 RID: 45973
		private static class EBattleCardLoopEffectItem
		{
			// Token: 0x040366E1 RID: 222945
			public const int LoopNiagara = 0;
		}
	}
}
