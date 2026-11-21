using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Common.CardItem.Item
{
	// Token: 0x020041A0 RID: 16800
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class CardElementCountItem : GridProxyAbstract<CardElementCount>
	{
		// Token: 0x0602A8BC RID: 174268 RVA: 0x00C00EDC File Offset: 0x00BFF0DC
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

		// Token: 0x0602A8BD RID: 174269 RVA: 0x00C00F64 File Offset: 0x00BFF164
		protected override UniTask OnBeforeStartAsync()
		{
			CardElementCountItem.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<CardElementCountItem.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602A8BE RID: 174270 RVA: 0x00C00FA7 File Offset: 0x00BFF1A7
		protected override void OnStart()
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(2);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.OnStateChange.Add(new Action<EToggleState>(this.OnClickToggle));
		}

		// Token: 0x0602A8BF RID: 174271 RVA: 0x00C00FCB File Offset: 0x00BFF1CB
		public override void Refresh(CardElementCount data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			this.RefreshElement();
			this.RefreshCount();
		}

		// Token: 0x0602A8C0 RID: 174272 RVA: 0x00C00FE0 File Offset: 0x00BFF1E0
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

		// Token: 0x0602A8C1 RID: 174273 RVA: 0x00C01074 File Offset: 0x00BFF274
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

		// Token: 0x0602A8C2 RID: 174274 RVA: 0x00C010C8 File Offset: 0x00BFF2C8
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

		// Token: 0x0602A8C3 RID: 174275 RVA: 0x00C0111B File Offset: 0x00BFF31B
		public override void OnSelected(bool fireEvent)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(2);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleState(EToggleState.ETT_Checked, fireEvent, false, false);
		}

		// Token: 0x0602A8C4 RID: 174276 RVA: 0x00C01133 File Offset: 0x00BFF333
		public override void OnDeselected(bool fireEvent)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(2);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleState(EToggleState.ETT_UnChecked, fireEvent, false, false);
		}

		// Token: 0x0602A8C5 RID: 174277 RVA: 0x00C0114B File Offset: 0x00BFF34B
		public override object GetKey(CardElementCount data, int displayIndex)
		{
			return data.ElementId;
		}

		// Token: 0x0401717C RID: 94588
		private CardElementCount Data;

		// Token: 0x0401717D RID: 94589
		private CardElementItem ItemElement;

		// Token: 0x0401717E RID: 94590
		public Action<int> SelectCallBack;

		// Token: 0x02009D97 RID: 40343
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x04031037 RID: 200759
			public const int ItemElement = 0;

			// Token: 0x04031038 RID: 200760
			public const int TextCount = 1;

			// Token: 0x04031039 RID: 200761
			public const int Toggle = 2;

			// Token: 0x0403103A RID: 200762
			public const int IconOther = 3;

			// Token: 0x0403103B RID: 200763
			public const int IconAll = 4;
		}
	}
}
