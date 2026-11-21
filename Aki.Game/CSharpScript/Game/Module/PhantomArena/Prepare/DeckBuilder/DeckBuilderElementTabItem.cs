using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.DeckBuilder
{
	// Token: 0x0200416D RID: 16749
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DeckBuilderElementTabItem : GridProxyAbstract<ICardTabItemData>
	{
		// Token: 0x0602A654 RID: 173652 RVA: 0x00BF51C4 File Offset: 0x00BF33C4
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(1, typeof(UUITexture)),
				new ValueTuple<int, Type>(2, typeof(UUISprite)),
				new ValueTuple<int, Type>(3, typeof(UUISprite)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleSelectInternal))
			};
		}

		// Token: 0x0602A655 RID: 173653 RVA: 0x00BF5299 File Offset: 0x00BF3499
		private void OnToggleSelectInternal(EToggleState toggleState)
		{
			Action<int> onToggleSelect = this.OnToggleSelect;
			if (onToggleSelect == null)
			{
				return;
			}
			onToggleSelect(base.GridIndex);
		}

		// Token: 0x0602A656 RID: 173654 RVA: 0x00BF52B4 File Offset: 0x00BF34B4
		[NullableContext(1)]
		public override void Refresh(ICardTabItemData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			base.SetTextureShowUntilLoaded(data.TabTexturePath, base.GetTexture(1), null);
			FColor color = FColor.FromHex(data.TabElementColor);
			base.GetSprite(2).SetColor(color);
			base.GetSprite(3).SetColor(color);
			if (isSelected)
			{
				this.OnSelected(false);
			}
			else
			{
				this.OnDeselected(false);
			}
			this.RefreshRedDotState();
			this.RefreshDisableState();
			this.RefreshMaxState();
		}

		// Token: 0x0602A657 RID: 173655 RVA: 0x00BF5327 File Offset: 0x00BF3527
		public override void OnSelected(bool fireEvent)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleState(EToggleState.ETT_Checked, fireEvent, false, false);
		}

		// Token: 0x0602A658 RID: 173656 RVA: 0x00BF533F File Offset: 0x00BF353F
		public override void OnDeselected(bool fireEvent)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleState(EToggleState.ETT_UnChecked, fireEvent, false, false);
		}

		// Token: 0x0602A659 RID: 173657 RVA: 0x00BF5357 File Offset: 0x00BF3557
		public void RefreshRedDotState()
		{
			base.GetItem(4).SetUIActive(this.Data.ShowRedDot);
		}

		// Token: 0x0602A65A RID: 173658 RVA: 0x00BF5370 File Offset: 0x00BF3570
		public void RefreshDisableState()
		{
			base.GetItem(5).SetUIActive(this.Data.IsDisable);
		}

		// Token: 0x0602A65B RID: 173659 RVA: 0x00BF5389 File Offset: 0x00BF3589
		public void RefreshMaxState()
		{
			base.GetItem(6).SetUIActive(this.Data.IsArrivedMax);
		}

		// Token: 0x04017094 RID: 94356
		protected ICardTabItemData Data;

		// Token: 0x04017095 RID: 94357
		public Action<int> OnToggleSelect;

		// Token: 0x02009D45 RID: 40261
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x04030E92 RID: 200338
			public const int ItemToggle = 0;

			// Token: 0x04030E93 RID: 200339
			public const int ElementTexture = 1;

			// Token: 0x04030E94 RID: 200340
			public const int LightSprite1 = 2;

			// Token: 0x04030E95 RID: 200341
			public const int LightSprite2 = 3;

			// Token: 0x04030E96 RID: 200342
			public const int RedDotItem = 4;

			// Token: 0x04030E97 RID: 200343
			public const int DisableItem = 5;

			// Token: 0x04030E98 RID: 200344
			public const int MaxItem = 6;
		}
	}
}
