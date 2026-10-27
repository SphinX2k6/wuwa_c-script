using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Prepare.DeckBuilder
{
	// Token: 0x0200519D RID: 20893
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class DeckBuilderElementTabItem : GridProxyAbstract<ICardTabItemData>
	{
		// Token: 0x06035759 RID: 218969 RVA: 0x00CA7BF0 File Offset: 0x00CA5DF0
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

		// Token: 0x0603575A RID: 218970 RVA: 0x00CA7CC5 File Offset: 0x00CA5EC5
		private void OnToggleSelectInternal(EToggleState toggleState)
		{
			Action<int> onToggleSelect = this.OnToggleSelect;
			if (onToggleSelect == null)
			{
				return;
			}
			onToggleSelect(base.GridIndex);
		}

		// Token: 0x0603575B RID: 218971 RVA: 0x00CA7CE0 File Offset: 0x00CA5EE0
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

		// Token: 0x0603575C RID: 218972 RVA: 0x00CA7D53 File Offset: 0x00CA5F53
		public override void OnSelected(bool fireEvent)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleState(EToggleState.ETT_Checked, fireEvent, false, false);
		}

		// Token: 0x0603575D RID: 218973 RVA: 0x00CA7D6B File Offset: 0x00CA5F6B
		public override void OnDeselected(bool fireEvent)
		{
			UUIExtendToggle extendToggle = base.GetExtendToggle(0);
			if (extendToggle == null)
			{
				return;
			}
			extendToggle.SetToggleState(EToggleState.ETT_UnChecked, fireEvent, false, false);
		}

		// Token: 0x0603575E RID: 218974 RVA: 0x00CA7D83 File Offset: 0x00CA5F83
		public void RefreshRedDotState()
		{
			base.GetItem(4).SetUIActive(this.Data.ShowRedDot);
		}

		// Token: 0x0603575F RID: 218975 RVA: 0x00CA7D9C File Offset: 0x00CA5F9C
		public void RefreshDisableState()
		{
			base.GetItem(5).SetUIActive(this.Data.IsDisable);
		}

		// Token: 0x06035760 RID: 218976 RVA: 0x00CA7DB5 File Offset: 0x00CA5FB5
		public void RefreshMaxState()
		{
			base.GetItem(6).SetUIActive(this.Data.IsArrivedMax);
		}

		// Token: 0x0401C65F RID: 116319
		protected ICardTabItemData Data;

		// Token: 0x0401C660 RID: 116320
		public Action<int> OnToggleSelect;

		// Token: 0x0200B30C RID: 45836
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x0403643D RID: 222269
			public const int ItemToggle = 0;

			// Token: 0x0403643E RID: 222270
			public const int ElementTexture = 1;

			// Token: 0x0403643F RID: 222271
			public const int LightSprite1 = 2;

			// Token: 0x04036440 RID: 222272
			public const int LightSprite2 = 3;

			// Token: 0x04036441 RID: 222273
			public const int RedDotItem = 4;

			// Token: 0x04036442 RID: 222274
			public const int DisableItem = 5;

			// Token: 0x04036443 RID: 222275
			public const int MaxItem = 6;
		}
	}
}
