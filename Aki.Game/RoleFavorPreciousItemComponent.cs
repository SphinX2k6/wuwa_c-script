using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

// Token: 0x02001DEE RID: 7662
[NullableContext(2)]
[Nullable(0)]
public class RoleFavorPreciousItemComponent : RoleFavorViewComponentBase
{
	// Token: 0x06012EEB RID: 77547 RVA: 0x0058CA40 File Offset: 0x0058AC40
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUINiagara)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem))
		};
	}

	// Token: 0x06012EEC RID: 77548 RVA: 0x0058CAC6 File Offset: 0x0058ACC6
	protected override void OnBeforeDestroy()
	{
		this.FavorGoods = null;
		this.Icon = null;
		this.LockItem = null;
		this.InActiveBgItem = null;
		this.ActiveBgItem = null;
	}

	// Token: 0x06012EED RID: 77549 RVA: 0x0058CAF0 File Offset: 0x0058ACF0
	[NullableContext(1)]
	protected override void OnSetData(RoleFavorContentDataBase contentData)
	{
		if (contentData.FavorContentType != EFavorContentType.PreciousItem)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Role;
			ELogAuthor author = ELogAuthor.LRC;
			string message = "不支持的好感度类型";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("favorTabType", contentData.FavorContentType);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		this.FavorGoods = new FavorGoods?(((RoleFavorPreciousItemContentData)contentData).ConfigData);
	}

	// Token: 0x06012EEE RID: 77550 RVA: 0x0058CB50 File Offset: 0x0058AD50
	protected override void OnRefreshView()
	{
		if (this.FavorGoods == null)
		{
			return;
		}
		this.Icon = base.GetTexture(0);
		this.LockItem = base.GetItem(2);
		this.InActiveBgItem = base.GetItem(3);
		this.ActiveBgItem = base.GetItem(4);
		base.SetTextureByPath(this.FavorGoods.Value.Pic, this.Icon, null, null);
	}

	// Token: 0x06012EEF RID: 77551 RVA: 0x0058CBC8 File Offset: 0x0058ADC8
	public void SetLockState(bool isLock)
	{
		if (this.Icon == null)
		{
			return;
		}
		if (isLock)
		{
			this.Icon.SetColor(FColor.FromHex("8F8F8FFF"));
		}
		else
		{
			this.Icon.SetColor(FColor.FromHex("FFFFFFFF"));
		}
		this.Icon.SetUIActive(!isLock);
		UUIItem lockItem = this.LockItem;
		if (lockItem != null)
		{
			lockItem.SetUIActive(false);
		}
		UUIItem inActiveBgItem = this.InActiveBgItem;
		if (inActiveBgItem != null)
		{
			inActiveBgItem.SetUIActive(false);
		}
		UUIItem activeBgItem = this.ActiveBgItem;
		if (activeBgItem == null)
		{
			return;
		}
		activeBgItem.SetUIActive(false);
	}

	// Token: 0x0400A32E RID: 41774
	private FavorGoods? FavorGoods;

	// Token: 0x0400A32F RID: 41775
	private UUITexture Icon;

	// Token: 0x0400A330 RID: 41776
	private UUIItem LockItem;

	// Token: 0x0400A331 RID: 41777
	private UUIItem InActiveBgItem;

	// Token: 0x0400A332 RID: 41778
	private UUIItem ActiveBgItem;
}
