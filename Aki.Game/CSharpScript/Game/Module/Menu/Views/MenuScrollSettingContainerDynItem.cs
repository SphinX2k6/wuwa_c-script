using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Menu.Views
{
	// Token: 0x020043EE RID: 17390
	[NullableContext(1)]
	[Nullable(0)]
	public class MenuScrollSettingContainerDynItem : UiPanelBase, IDynamicScrollBaseItem<MenuScrollItemData>
	{
		// Token: 0x0602BF09 RID: 179977 RVA: 0x00C56470 File Offset: 0x00C54670
		public UniTask Init(UUIItem actor)
		{
			MenuScrollSettingContainerDynItem.<Init>d__1 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.actor = actor;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<MenuScrollSettingContainerDynItem.<Init>d__1>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x0602BF0A RID: 179978 RVA: 0x00C564BC File Offset: 0x00C546BC
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIItem))
			};
		}

		// Token: 0x0602BF0B RID: 179979 RVA: 0x00C56558 File Offset: 0x00C54758
		public FVector2D GetItemSize(MenuScrollItemData itemData)
		{
			if (this.VectorValue == null)
			{
				this.VectorValue = Vector2D.Create();
			}
			UUIItem currentTypeUiItem = this.GetCurrentTypeUiItem(itemData);
			if (currentTypeUiItem != null)
			{
				this.VectorValue.Set((double)currentTypeUiItem.GetWidth(), (double)currentTypeUiItem.GetHeight());
			}
			else
			{
				this.VectorValue.Set(0.0, 0.0);
			}
			return this.VectorValue.ToUeVector2D(false);
		}

		// Token: 0x0602BF0C RID: 179980 RVA: 0x00C565C8 File Offset: 0x00C547C8
		[return: Nullable(2)]
		private UUIItem GetCurrentTypeUiItem(MenuScrollItemData itemData)
		{
			if (itemData.Type == EMenuScrollItemType.TitleItem)
			{
				return base.GetItem(1);
			}
			switch (itemData.Data.SetType)
			{
			case ESetType.SLIDER:
				return base.GetItem(4);
			case ESetType.OPTIONS:
				return base.GetItem(3);
			case ESetType.KEYMAP:
				return base.GetItem(2);
			case ESetType.BUTTON:
				return base.GetItem(2);
			case ESetType.DROPDOWN:
				return base.GetItem(5);
			default:
				return null;
			}
		}

		// Token: 0x0602BF0D RID: 179981 RVA: 0x00C56638 File Offset: 0x00C54838
		public void ClearItem()
		{
		}

		// Token: 0x04017AC4 RID: 96964
		[Nullable(2)]
		private Vector2D VectorValue;
	}
}
