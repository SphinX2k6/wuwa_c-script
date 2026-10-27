using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardItem.Component.Bvb
{
	// Token: 0x020051FD RID: 20989
	public class BattleCardEffectItem : UiPanelBase
	{
		// Token: 0x06035B22 RID: 219938 RVA: 0x00CB7085 File Offset: 0x00CB5285
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUINiagara)),
				new ValueTuple<int, Type>(1, typeof(UUINiagara))
			};
		}

		// Token: 0x06035B23 RID: 219939 RVA: 0x00CB70C0 File Offset: 0x00CB52C0
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

		// Token: 0x06035B24 RID: 219940 RVA: 0x00CB7114 File Offset: 0x00CB5314
		protected override UniTask OnBeforeStartAsync()
		{
			BattleCardEffectItem.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<BattleCardEffectItem.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035B25 RID: 219941 RVA: 0x00CB7158 File Offset: 0x00CB5358
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

		// Token: 0x06035B26 RID: 219942 RVA: 0x00CB71A4 File Offset: 0x00CB53A4
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

		// Token: 0x06035B27 RID: 219943 RVA: 0x00CB71F0 File Offset: 0x00CB53F0
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

		// Token: 0x06035B28 RID: 219944 RVA: 0x00CB7238 File Offset: 0x00CB5438
		public void SetCardConfigId(int cardConfigId)
		{
			this.CardConfigId = cardConfigId;
		}

		// Token: 0x0401C799 RID: 116633
		protected int CardConfigId;

		// Token: 0x0200B390 RID: 45968
		private static class EBattleCardEffectItem
		{
			// Token: 0x040366CB RID: 222923
			public const int StartOneNiagara = 0;

			// Token: 0x040366CC RID: 222924
			public const int StartTwoNiagara = 1;
		}
	}
}
