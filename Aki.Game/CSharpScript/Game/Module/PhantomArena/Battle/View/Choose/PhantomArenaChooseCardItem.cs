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
	// Token: 0x02004239 RID: 16953
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class PhantomArenaChooseCardItem : GridProxyAbstract<PhantomCardData>, IPhantomCardProxy, IPhantomCardProxyBase
	{
		// Token: 0x0602AE11 RID: 175633 RVA: 0x00C10BE8 File Offset: 0x00C0EDE8
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomArenaChooseCardItem.<OnBeforeStartAsync>d__2 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomArenaChooseCardItem.<OnBeforeStartAsync>d__2>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602AE12 RID: 175634 RVA: 0x00C10C2B File Offset: 0x00C0EE2B
		public override void Refresh(PhantomCardData data, bool isSelected, int gridIndex)
		{
			this.Card.Refresh(data);
			this.Card.SetToggleState(EToggleState.ETT_UnChecked, false);
			this.SetSelectStateWithoutSequence();
			this.SetChooseStateWithoutSequence();
		}

		// Token: 0x0602AE13 RID: 175635 RVA: 0x00C10C52 File Offset: 0x00C0EE52
		public void SetSelectStateWithoutSequence()
		{
			this.Card.SetSelectedStateWithoutSequence();
		}

		// Token: 0x0602AE14 RID: 175636 RVA: 0x00C10C5F File Offset: 0x00C0EE5F
		public void SetSelectState(bool value)
		{
			this.Card.SetSelectedState(value);
		}

		// Token: 0x0602AE15 RID: 175637 RVA: 0x00C10C6D File Offset: 0x00C0EE6D
		public void SetChooseStateWithoutSequence()
		{
			this.Card.GetComponent<CardCommonComponent>(ECardItemComponent.CardChooseComponent).SetComponentDisActiveWithoutSequence();
		}

		// Token: 0x0602AE16 RID: 175638 RVA: 0x00C10C80 File Offset: 0x00C0EE80
		public void SetChooseState(bool value)
		{
			this.Card.GetComponent<CardCommonComponent>(ECardItemComponent.CardChooseComponent).SetComponentActive(value);
		}

		// Token: 0x0602AE17 RID: 175639 RVA: 0x00C10C94 File Offset: 0x00C0EE94
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

		// Token: 0x0602AE18 RID: 175640 RVA: 0x00C10CD3 File Offset: 0x00C0EED3
		public void PointerEnterCard(int id)
		{
		}

		// Token: 0x0602AE19 RID: 175641 RVA: 0x00C10CD5 File Offset: 0x00C0EED5
		public void PointerDownCard(int id, ULGUIPointerEventData eventData)
		{
		}

		// Token: 0x0602AE1A RID: 175642 RVA: 0x00C10CD7 File Offset: 0x00C0EED7
		public override object GetKey(PhantomCardData data, int displayIndex)
		{
			return data.CardId;
		}

		// Token: 0x04017347 RID: 95047
		public PhantomArenaCard Card;

		// Token: 0x04017348 RID: 95048
		public Action<PhantomCardData, bool> ClickCallback;
	}
}
