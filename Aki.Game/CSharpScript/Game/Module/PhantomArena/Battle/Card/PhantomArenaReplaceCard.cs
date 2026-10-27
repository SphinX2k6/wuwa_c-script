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
	// Token: 0x020052C0 RID: 21184
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class PhantomArenaReplaceCard : GridProxyAbstract<PhantomCardData>, IPhantomCardProxy, IPhantomCardProxyBase
	{
		// Token: 0x06036300 RID: 221952 RVA: 0x00CD1F84 File Offset: 0x00CD0184
		protected override UniTask OnBeforeStartAsync()
		{
			PhantomArenaReplaceCard.<OnBeforeStartAsync>d__2 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomArenaReplaceCard.<OnBeforeStartAsync>d__2>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06036301 RID: 221953 RVA: 0x00CD1FC7 File Offset: 0x00CD01C7
		public override void Refresh(PhantomCardData data, bool isSelected, int gridIndex)
		{
			this.Card.Refresh(data);
		}

		// Token: 0x06036302 RID: 221954 RVA: 0x00CD1FD5 File Offset: 0x00CD01D5
		private void ShowReplaceState()
		{
			CardReplaceComponent component = this.Card.GetComponent<CardReplaceComponent>(ECardItemComponent.CardReplaceComponent);
			if (component == null)
			{
				return;
			}
			component.SetActive(true);
		}

		// Token: 0x06036303 RID: 221955 RVA: 0x00CD1FEE File Offset: 0x00CD01EE
		private void HideReplaceState()
		{
			CardReplaceComponent component = this.Card.GetComponent<CardReplaceComponent>(ECardItemComponent.CardReplaceComponent);
			if (component == null)
			{
				return;
			}
			component.SetActive(false);
		}

		// Token: 0x06036304 RID: 221956 RVA: 0x00CD2007 File Offset: 0x00CD0207
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

		// Token: 0x06036305 RID: 221957 RVA: 0x00CD203E File Offset: 0x00CD023E
		public void SetSelectState(bool value)
		{
			this.Card.SetSelectedState(value);
		}

		// Token: 0x06036306 RID: 221958 RVA: 0x00CD204C File Offset: 0x00CD024C
		public void PointerEnterCard(int id)
		{
		}

		// Token: 0x06036307 RID: 221959 RVA: 0x00CD204E File Offset: 0x00CD024E
		public void PointerDownCard(int id, ULGUIPointerEventData eventData)
		{
		}

		// Token: 0x06036308 RID: 221960 RVA: 0x00CD2050 File Offset: 0x00CD0250
		public override object GetKey(PhantomCardData data, int displayIndex)
		{
			return data.CardId;
		}

		// Token: 0x0401CAAA RID: 117418
		public PhantomArenaCard Card;

		// Token: 0x0401CAAB RID: 117419
		public Action<int, bool> ClickCallback;
	}
}
