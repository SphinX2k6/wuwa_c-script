using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardItem.Item
{
	// Token: 0x020051D0 RID: 20944
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class CardElementCountItem : GridProxyAbstract<CardElementCount>
	{
		// Token: 0x060359C1 RID: 219585 RVA: 0x00CB38A0 File Offset: 0x00CB1AA0
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(3, typeof(UUISprite)),
				new ValueTuple<int, Type>(4, typeof(UUISprite))
			};
		}

		// Token: 0x060359C2 RID: 219586 RVA: 0x00CB3928 File Offset: 0x00CB1B28
		protected override UniTask OnBeforeStartAsync()
		{
			CardElementCountItem.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<CardElementCountItem.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060359C3 RID: 219587 RVA: 0x00CB396B File Offset: 0x00CB1B6B
		protected override void OnStart()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(2);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.OnStateChange.Add(new Action<EToggleState>(this.OnClickToggle));
		}

		// Token: 0x060359C4 RID: 219588 RVA: 0x00CB398F File Offset: 0x00CB1B8F
		public override void Refresh(CardElementCount data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			this.RefreshElement();
			this.RefreshCount();
		}

		// Token: 0x060359C5 RID: 219589 RVA: 0x00CB39A4 File Offset: 0x00CB1BA4
		private void RefreshElement()
		{
			int elementId = this.Data.ElementId;
			if (elementId == -1)
			{
				UUISprite sprite = base.GetSprite(4);
				if (sprite != null)
				{
					sprite.SetUIActive(true);
				}
				this.ItemElement.SetActive(false);
				return;
			}
			if (elementId != 0)
			{
				this.ItemElement.Refresh((ECardElement)this.Data.ElementId, false, 0);
				this.ItemElement.SetActive(this.Data.ElementId != 0);
				return;
			}
			UUISprite sprite2 = base.GetSprite(3);
			if (sprite2 != null)
			{
				sprite2.SetUIActive(true);
			}
			this.ItemElement.SetActive(false);
		}

		// Token: 0x060359C6 RID: 219590 RVA: 0x00CB3A38 File Offset: 0x00CB1C38
		private void RefreshCount()
		{
			string text = this.Data.Count.ToString();
			string text2 = this.Data.All.ToString();
			base.GetText(1).SetText(StringUtils.Format("{0}/{1}", new string[]
			{
				text,
				text2
			}), true);
		}

		// Token: 0x060359C7 RID: 219591 RVA: 0x00CB3A8C File Offset: 0x00CB1C8C
		private void OnClickToggle(EToggleState state)
		{
			if (state == EToggleState.ETT_UnChecked)
			{
				return;
			}
			if (this.Data == null)
			{
				return;
			}
			Action<int> selectCallBack = this.SelectCallBack;
			if (selectCallBack != null)
			{
				selectCallBack(this.Data.ElementId);
			}
			IScrollViewDelegate<IGridProxy<CardElementCount>, CardElementCount> scrollViewDelegate = base.ScrollViewDelegate;
			if (scrollViewDelegate == null)
			{
				return;
			}
			scrollViewDelegate.SelectGridProxy(base.GridIndex, base.DisplayIndex, false);
		}

		// Token: 0x060359C8 RID: 219592 RVA: 0x00CB3ADF File Offset: 0x00CB1CDF
		public override void OnSelected(bool fireEvent)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(2);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleState(EToggleState.ETT_Checked, fireEvent, false, false);
		}

		// Token: 0x060359C9 RID: 219593 RVA: 0x00CB3AF7 File Offset: 0x00CB1CF7
		public override void OnDeselected(bool fireEvent)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(2);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleState(EToggleState.ETT_UnChecked, fireEvent, false, false);
		}

		// Token: 0x060359CA RID: 219594 RVA: 0x00CB3B0F File Offset: 0x00CB1D0F
		public override object GetKey(CardElementCount data, int displayIndex)
		{
			return data.ElementId;
		}

		// Token: 0x0401C747 RID: 116551
		private CardElementCount Data;

		// Token: 0x0401C748 RID: 116552
		private CardElementItem ItemElement;

		// Token: 0x0401C749 RID: 116553
		public Action<int> SelectCallBack;

		// Token: 0x0200B35F RID: 45919
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x040365E4 RID: 222692
			public const int ItemElement = 0;

			// Token: 0x040365E5 RID: 222693
			public const int TextCount = 1;

			// Token: 0x040365E6 RID: 222694
			public const int Toggle = 2;

			// Token: 0x040365E7 RID: 222695
			public const int IconOther = 3;

			// Token: 0x040365E8 RID: 222696
			public const int IconAll = 4;
		}
	}
}
