using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001F16 RID: 7958
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class ShipTowerAreaItem : GridProxyAbstract<ShipTowerAreaItemData>
{
	// Token: 0x06013B4C RID: 80716 RVA: 0x005C02AC File Offset: 0x005BE4AC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUISprite)),
			new ValueTuple<int, Type>(5, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggleRoot))
		};
	}

	// Token: 0x06013B4D RID: 80717 RVA: 0x005C036C File Offset: 0x005BE56C
	protected override UniTask OnBeforeStartAsync()
	{
		ShipTowerAreaItem.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ShipTowerAreaItem.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06013B4E RID: 80718 RVA: 0x005C03AF File Offset: 0x005BE5AF
	protected override void OnStart()
	{
		this.GetToggleRoot().bLockStateOnSelect = true;
	}

	// Token: 0x06013B4F RID: 80719 RVA: 0x005C03C0 File Offset: 0x005BE5C0
	public override void Refresh(ShipTowerAreaItemData data, bool isSelected, int gridIndex)
	{
		this.ItemData = data;
		UUIText text = base.GetText(1);
		if (text != null)
		{
			text.ShowTextNew(data.Name);
		}
		UUIText text2 = base.GetText(2);
		if (text2 != null)
		{
			text2.SetText(data.Desc, true);
		}
		UUIText text3 = base.GetText(3);
		if (text3 != null)
		{
			text3.SetText(data.TimeContent ?? "", true);
		}
		UUISprite sprite = base.GetSprite(4);
		if (sprite != null)
		{
			sprite.SetUIActive(data.IsFinish.GetValueOrDefault());
		}
		UUIItem item = base.GetItem(5);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(data.IsRedPoint.GetValueOrDefault());
	}

	// Token: 0x06013B50 RID: 80720 RVA: 0x005C0460 File Offset: 0x005BE660
	private void OnClickToggleRoot(EToggleState check)
	{
		if (check == EToggleState.ETT_Checked)
		{
			IScrollViewDelegate<IGridProxy<ShipTowerAreaItemData>, ShipTowerAreaItemData> scrollViewDelegate = base.ScrollViewDelegate;
			if (scrollViewDelegate == null)
			{
				return;
			}
			scrollViewDelegate.SelectGridProxy(base.GridIndex, base.DisplayIndex, false);
		}
	}

	// Token: 0x06013B51 RID: 80721 RVA: 0x005C0483 File Offset: 0x005BE683
	public override void OnSelected(bool fireEvent)
	{
		this.GetToggleRoot().SetToggleState(EToggleState.ETT_Checked, false, false, false);
		Action<ShipTowerAreaItemData> clickCallBack = this.ClickCallBack;
		if (clickCallBack == null)
		{
			return;
		}
		clickCallBack(this.ItemData);
	}

	// Token: 0x06013B52 RID: 80722 RVA: 0x005C04AB File Offset: 0x005BE6AB
	public override void OnDeselected(bool fireEvent)
	{
		this.GetToggleRoot().SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x06013B53 RID: 80723 RVA: 0x005C04BD File Offset: 0x005BE6BD
	private UUIExtendToggle GetToggleRoot()
	{
		return base.GetExtendToggle(0);
	}

	// Token: 0x0400A882 RID: 43138
	private ShipTowerAreaItemData ItemData;

	// Token: 0x0400A883 RID: 43139
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<ShipTowerAreaItemData> ClickCallBack;

	// Token: 0x020081E8 RID: 33256
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x04029F49 RID: 171849
		public const int ToggleRoot = 0;

		// Token: 0x04029F4A RID: 171850
		public const int TextName = 1;

		// Token: 0x04029F4B RID: 171851
		public const int TextDesc = 2;

		// Token: 0x04029F4C RID: 171852
		public const int TextTimeContent = 3;

		// Token: 0x04029F4D RID: 171853
		public const int SpriteFinish = 4;

		// Token: 0x04029F4E RID: 171854
		public const int ItemRedPoint = 5;
	}
}
