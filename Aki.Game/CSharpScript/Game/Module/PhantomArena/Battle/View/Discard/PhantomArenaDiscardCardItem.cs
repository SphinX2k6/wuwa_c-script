using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Battle.Card;
using CSharpScript.Game.Module.PhantomArena.Battle.Model;
using CSharpScript.Game.Module.PhantomArena.Common.CardItem;
using CSharpScript.Game.Module.PhantomArena.Common.CardItem.Component;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Battle.View.Discard
{
	// Token: 0x02004234 RID: 16948
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class PhantomArenaDiscardCardItem : GridProxyAbstract<PhantomCardData>, IPhantomCardProxy, IPhantomCardProxyBase
	{
		// Token: 0x0602ADCB RID: 175563 RVA: 0x00C100DC File Offset: 0x00C0E2DC
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomArenaDiscardCardItem.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomArenaDiscardCardItem.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602ADCC RID: 175564 RVA: 0x00C10120 File Offset: 0x00C0E320
		public override void Refresh(PhantomCardData data, bool isSelected, int gridIndex)
		{
			this.Card.Refresh(data);
			EToggleState state = (data.UseCost == 0) ? EToggleState.ETT_UnDetermined : EToggleState.ETT_UnChecked;
			this.Card.SetToggleState(state, false);
			this.SetSelectStateWithoutSequence();
			this.SetChooseStateWithoutSequence();
		}

		// Token: 0x0602ADCD RID: 175565 RVA: 0x00C10160 File Offset: 0x00C0E360
		public void PointerClickCard(int id, EToggleState state)
		{
			if (this.Card.Data.IsField)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("PhantomBattle_1187", Array.Empty<object>());
				return;
			}
			if (this.Card.Data.UseCost == 0)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("PhantomBattle_1186", Array.Empty<object>());
				return;
			}
			Action<PhantomCardData, bool> clickCallback = this.ClickCallback;
			if (clickCallback == null)
			{
				return;
			}
			clickCallback(this.Card.Data, !this.IsChoose);
		}

		// Token: 0x0602ADCE RID: 175566 RVA: 0x00C101DF File Offset: 0x00C0E3DF
		public void SetSelectStateWithoutSequence()
		{
			this.Card.SetSelectedStateWithoutSequence();
		}

		// Token: 0x0602ADCF RID: 175567 RVA: 0x00C101EC File Offset: 0x00C0E3EC
		public void SetSelectState(bool value)
		{
			this.Card.SetSelectedState(value);
		}

		// Token: 0x0602ADD0 RID: 175568 RVA: 0x00C101FA File Offset: 0x00C0E3FA
		public void SetChooseStateWithoutSequence()
		{
			this.Card.GetComponent<CardCommonComponent>(ECardItemComponent.CardChooseComponent).SetComponentDisActiveWithoutSequence();
			this.IsChoose = false;
		}

		// Token: 0x0602ADD1 RID: 175569 RVA: 0x00C10214 File Offset: 0x00C0E414
		public void SetChooseState(bool value)
		{
			this.Card.GetComponent<CardCommonComponent>(ECardItemComponent.CardChooseComponent).SetComponentActive(value);
			this.IsChoose = value;
		}

		// Token: 0x0602ADD2 RID: 175570 RVA: 0x00C1022F File Offset: 0x00C0E42F
		public void PointerEnterCard(int id)
		{
		}

		// Token: 0x0602ADD3 RID: 175571 RVA: 0x00C10231 File Offset: 0x00C0E431
		public void PointerDownCard(int id, ULGUIPointerEventData eventData)
		{
		}

		// Token: 0x0602ADD4 RID: 175572 RVA: 0x00C10233 File Offset: 0x00C0E433
		public override object GetKey(PhantomCardData data, int displayIndex)
		{
			return data.CardId;
		}

		// Token: 0x04017337 RID: 95031
		public PhantomArenaCard Card;

		// Token: 0x04017338 RID: 95032
		public Action<PhantomCardData, bool> ClickCallback;

		// Token: 0x04017339 RID: 95033
		protected bool IsChoose;
	}
}
