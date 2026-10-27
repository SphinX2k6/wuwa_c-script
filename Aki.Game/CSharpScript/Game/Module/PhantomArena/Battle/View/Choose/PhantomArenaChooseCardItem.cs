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

namespace CSharpScript.Game.Module.PhantomArena.Battle.View.Choose
{
	// Token: 0x02005269 RID: 21097
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class PhantomArenaChooseCardItem : GridProxyAbstract<PhantomCardData>, IPhantomCardProxy, IPhantomCardProxyBase
	{
		// Token: 0x06035F16 RID: 220950 RVA: 0x00CC3520 File Offset: 0x00CC1720
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomArenaChooseCardItem.<OnBeforeStartAsync>d__2 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomArenaChooseCardItem.<OnBeforeStartAsync>d__2>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06035F17 RID: 220951 RVA: 0x00CC3563 File Offset: 0x00CC1763
		public override void Refresh(PhantomCardData data, bool isSelected, int gridIndex)
		{
			this.Card.Refresh(data);
			this.Card.SetToggleState(EToggleState.ETT_UnChecked, false);
			this.SetSelectStateWithoutSequence();
			this.SetChooseStateWithoutSequence();
		}

		// Token: 0x06035F18 RID: 220952 RVA: 0x00CC358A File Offset: 0x00CC178A
		public void SetSelectStateWithoutSequence()
		{
			this.Card.SetSelectedStateWithoutSequence();
		}

		// Token: 0x06035F19 RID: 220953 RVA: 0x00CC3597 File Offset: 0x00CC1797
		public void SetSelectState(bool value)
		{
			this.Card.SetSelectedState(value);
		}

		// Token: 0x06035F1A RID: 220954 RVA: 0x00CC35A5 File Offset: 0x00CC17A5
		public void SetChooseStateWithoutSequence()
		{
			this.Card.GetComponent<CardCommonComponent>(ECardItemComponent.CardChooseComponent).SetComponentDisActiveWithoutSequence();
		}

		// Token: 0x06035F1B RID: 220955 RVA: 0x00CC35B8 File Offset: 0x00CC17B8
		public void SetChooseState(bool value)
		{
			this.Card.GetComponent<CardCommonComponent>(ECardItemComponent.CardChooseComponent).SetComponentActive(value);
		}

		// Token: 0x06035F1C RID: 220956 RVA: 0x00CC35CC File Offset: 0x00CC17CC
		public void PointerClickCard(int id, EToggleState state)
		{
			if (state == EToggleState.ETT_Checked)
			{
				Action<PhantomCardData, bool> clickCallback = this.ClickCallback;
				if (clickCallback == null)
				{
					return;
				}
				clickCallback(this.Card.Data, true);
				return;
			}
			else
			{
				Action<PhantomCardData, bool> clickCallback2 = this.ClickCallback;
				if (clickCallback2 == null)
				{
					return;
				}
				clickCallback2(this.Card.Data, false);
				return;
			}
		}

		// Token: 0x06035F1D RID: 220957 RVA: 0x00CC360B File Offset: 0x00CC180B
		public void PointerEnterCard(int id)
		{
		}

		// Token: 0x06035F1E RID: 220958 RVA: 0x00CC360D File Offset: 0x00CC180D
		public void PointerDownCard(int id, ULGUIPointerEventData eventData)
		{
		}

		// Token: 0x06035F1F RID: 220959 RVA: 0x00CC360F File Offset: 0x00CC180F
		public override object GetKey(PhantomCardData data, int displayIndex)
		{
			return data.CardId;
		}

		// Token: 0x0401C912 RID: 117010
		public PhantomArenaCard Card;

		// Token: 0x0401C913 RID: 117011
		public Action<PhantomCardData, bool> ClickCallback;
	}
}
