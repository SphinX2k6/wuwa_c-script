using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200299B RID: 10651
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class ShipTowerAreaItem : GridProxyAbstract<ShipTowerAreaItemData>
{
	// Token: 0x06016146 RID: 90438 RVA: 0x005952EC File Offset: 0x005934EC
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

	// Token: 0x06016147 RID: 90439 RVA: 0x005953AC File Offset: 0x005935AC
	protected override UniTask OnBeforeStartAsync()
	{
		ShipTowerAreaItem.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<ShipTowerAreaItem.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06016148 RID: 90440 RVA: 0x005953EF File Offset: 0x005935EF
	protected override void OnStart()
	{
		this.GetToggleRoot().bLockStateOnSelect = true;
	}

	// Token: 0x06016149 RID: 90441 RVA: 0x00595400 File Offset: 0x00593600
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

	// Token: 0x0601614A RID: 90442 RVA: 0x005954A0 File Offset: 0x005936A0
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

	// Token: 0x0601614B RID: 90443 RVA: 0x005954C3 File Offset: 0x005936C3
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

	// Token: 0x0601614C RID: 90444 RVA: 0x005954EB File Offset: 0x005936EB
	public override void OnDeselected(bool fireEvent)
	{
		this.GetToggleRoot().SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x0601614D RID: 90445 RVA: 0x005954FD File Offset: 0x005936FD
	private UUIExtendToggle GetToggleRoot()
	{
		return base.GetExtendToggle(0);
	}

	// Token: 0x0400A498 RID: 42136
	private ShipTowerAreaItemData ItemData;

	// Token: 0x0400A499 RID: 42137
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<ShipTowerAreaItemData> ClickCallBack;

	// Token: 0x02008F9F RID: 36767
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x0402E84A RID: 190538
		public const int ToggleRoot = 0;

		// Token: 0x0402E84B RID: 190539
		public const int TextName = 1;

		// Token: 0x0402E84C RID: 190540
		public const int TextDesc = 2;

		// Token: 0x0402E84D RID: 190541
		public const int TextTimeContent = 3;

		// Token: 0x0402E84E RID: 190542
		public const int SpriteFinish = 4;

		// Token: 0x0402E84F RID: 190543
		public const int ItemRedPoint = 5;
	}
}
