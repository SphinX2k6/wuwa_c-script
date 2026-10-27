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
	// Token: 0x0200540B RID: 21515
	[NullableContext(1)]
	[Nullable(0)]
	public class MenuScrollSettingContainerDynItem : UiPanelBase, IDynamicScrollBaseItem<MenuScrollItemData>
	{
		// Token: 0x06036FC0 RID: 225216 RVA: 0x00D07054 File Offset: 0x00D05254
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

		// Token: 0x06036FC1 RID: 225217 RVA: 0x00D070A0 File Offset: 0x00D052A0
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

		// Token: 0x06036FC2 RID: 225218 RVA: 0x00D0713C File Offset: 0x00D0533C
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

		// Token: 0x06036FC3 RID: 225219 RVA: 0x00D071AC File Offset: 0x00D053AC
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

		// Token: 0x06036FC4 RID: 225220 RVA: 0x00D0721C File Offset: 0x00D0541C
		public void ClearItem()
		{
		}

		// Token: 0x0401D02B RID: 118827
		[Nullable(2)]
		private Vector2D VectorValue;
	}
}
