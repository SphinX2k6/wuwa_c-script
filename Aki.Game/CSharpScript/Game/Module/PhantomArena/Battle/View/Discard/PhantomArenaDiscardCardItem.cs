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
	// Token: 0x02005264 RID: 21092
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class PhantomArenaDiscardCardItem : GridProxyAbstract<PhantomCardData>, IPhantomCardProxy, IPhantomCardProxyBase
	{
		// Token: 0x06035ED0 RID: 220880 RVA: 0x00CC2A4C File Offset: 0x00CC0C4C
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomArenaDiscardCardItem.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomArenaDiscardCardItem.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035ED1 RID: 220881 RVA: 0x00CC2A90 File Offset: 0x00CC0C90
		public override void Refresh(PhantomCardData data, bool isSelected, int gridIndex)
		{
			this.Card.Refresh(data);
			EToggleState state = (data.UseCost == 0) ? EToggleState.ETT_UnDetermined : EToggleState.ETT_UnChecked;
			this.Card.SetToggleState(state, false);
			this.SetSelectStateWithoutSequence();
			this.SetChooseStateWithoutSequence();
		}

		// Token: 0x06035ED2 RID: 220882 RVA: 0x00CC2AD0 File Offset: 0x00CC0CD0
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

		// Token: 0x06035ED3 RID: 220883 RVA: 0x00CC2B4F File Offset: 0x00CC0D4F
		public void SetSelectStateWithoutSequence()
		{
			this.Card.SetSelectedStateWithoutSequence();
		}

		// Token: 0x06035ED4 RID: 220884 RVA: 0x00CC2B5C File Offset: 0x00CC0D5C
		public void SetSelectState(bool value)
		{
			this.Card.SetSelectedState(value);
		}

		// Token: 0x06035ED5 RID: 220885 RVA: 0x00CC2B6A File Offset: 0x00CC0D6A
		public void SetChooseStateWithoutSequence()
		{
			this.Card.GetComponent<CardCommonComponent>(ECardItemComponent.CardChooseComponent).SetComponentDisActiveWithoutSequence();
			this.IsChoose = false;
		}

		// Token: 0x06035ED6 RID: 220886 RVA: 0x00CC2B84 File Offset: 0x00CC0D84
		public void SetChooseState(bool value)
		{
			this.Card.GetComponent<CardCommonComponent>(ECardItemComponent.CardChooseComponent).SetComponentActive(value);
			this.IsChoose = value;
		}

		// Token: 0x06035ED7 RID: 220887 RVA: 0x00CC2B9F File Offset: 0x00CC0D9F
		public void PointerEnterCard(int id)
		{
		}

		// Token: 0x06035ED8 RID: 220888 RVA: 0x00CC2BA1 File Offset: 0x00CC0DA1
		public void PointerDownCard(int id, ULGUIPointerEventData eventData)
		{
		}

		// Token: 0x06035ED9 RID: 220889 RVA: 0x00CC2BA3 File Offset: 0x00CC0DA3
		public override object GetKey(PhantomCardData data, int displayIndex)
		{
			return data.CardId;
		}

		// Token: 0x0401C902 RID: 116994
		public PhantomArenaCard Card;

		// Token: 0x0401C903 RID: 116995
		public Action<PhantomCardData, bool> ClickCallback;

		// Token: 0x0401C904 RID: 116996
		protected bool IsChoose;
	}
}
