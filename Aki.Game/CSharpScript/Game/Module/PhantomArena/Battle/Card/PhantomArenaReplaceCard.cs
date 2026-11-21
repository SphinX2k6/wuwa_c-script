using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.PhantomArena.Battle.Model;
using CSharpScript.Game.Module.PhantomArena.Common.CardItem;
using CSharpScript.Game.Module.PhantomArena.Common.CardItem.Component;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Battle.Card
{
	// Token: 0x02004290 RID: 17040
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class PhantomArenaReplaceCard : GridProxyAbstract<PhantomCardData>, IPhantomCardProxy, IPhantomCardProxyBase
	{
		// Token: 0x0602B1FB RID: 176635 RVA: 0x00C1F6AC File Offset: 0x00C1D8AC
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomArenaReplaceCard.<OnBeforeStartAsync>d__2 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomArenaReplaceCard.<OnBeforeStartAsync>d__2>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602B1FC RID: 176636 RVA: 0x00C1F6EF File Offset: 0x00C1D8EF
		public override void Refresh(PhantomCardData data, bool isSelected, int gridIndex)
		{
			this.Card.Refresh(data);
		}

		// Token: 0x0602B1FD RID: 176637 RVA: 0x00C1F6FD File Offset: 0x00C1D8FD
		private void ShowReplaceState()
		{
			CardReplaceComponent component = this.Card.GetComponent<CardReplaceComponent>(ECardItemComponent.CardReplaceComponent);
			if (component == null)
			{
				return;
			}
			component.SetActive(true);
		}

		// Token: 0x0602B1FE RID: 176638 RVA: 0x00C1F716 File Offset: 0x00C1D916
		private void HideReplaceState()
		{
			CardReplaceComponent component = this.Card.GetComponent<CardReplaceComponent>(ECardItemComponent.CardReplaceComponent);
			if (component == null)
			{
				return;
			}
			component.SetActive(false);
		}

		// Token: 0x0602B1FF RID: 176639 RVA: 0x00C1F72F File Offset: 0x00C1D92F
		public void PointerClickCard(int id, EToggleState state)
		{
			if (state == EToggleState.ETT_Checked)
			{
				this.ShowReplaceState();
				Action<int, bool> clickCallback = this.ClickCallback;
				if (clickCallback == null)
				{
					return;
				}
				clickCallback(id, true);
				return;
			}
			else
			{
				this.HideReplaceState();
				Action<int, bool> clickCallback2 = this.ClickCallback;
				if (clickCallback2 == null)
				{
					return;
				}
				clickCallback2(id, false);
				return;
			}
		}

		// Token: 0x0602B200 RID: 176640 RVA: 0x00C1F766 File Offset: 0x00C1D966
		public void SetSelectState(bool value)
		{
			this.Card.SetSelectedState(value);
		}

		// Token: 0x0602B201 RID: 176641 RVA: 0x00C1F774 File Offset: 0x00C1D974
		public void PointerEnterCard(int id)
		{
		}

		// Token: 0x0602B202 RID: 176642 RVA: 0x00C1F776 File Offset: 0x00C1D976
		public void PointerDownCard(int id, ULGUIPointerEventData eventData)
		{
		}

		// Token: 0x0602B203 RID: 176643 RVA: 0x00C1F778 File Offset: 0x00C1D978
		public override object GetKey(PhantomCardData data, int displayIndex)
		{
			return data.CardId;
		}

		// Token: 0x040174DF RID: 95455
		public PhantomArenaCard Card;

		// Token: 0x040174E0 RID: 95456
		public Action<int, bool> ClickCallback;
	}
}
