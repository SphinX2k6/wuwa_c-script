using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

// Token: 0x02002873 RID: 10355
[NullableContext(2)]
[Nullable(0)]
public class RoleFavorPreciousItemComponent : RoleFavorViewComponentBase
{
	// Token: 0x060154ED RID: 87277 RVA: 0x00561CE4 File Offset: 0x0055FEE4
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

	// Token: 0x060154EE RID: 87278 RVA: 0x00561D6A File Offset: 0x0055FF6A
	protected override void OnBeforeDestroy()
	{
		this.FavorGoods = null;
		this.Icon = null;
		this.LockItem = null;
		this.InActiveBgItem = null;
		this.ActiveBgItem = null;
	}

	// Token: 0x060154EF RID: 87279 RVA: 0x00561D94 File Offset: 0x0055FF94
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

	// Token: 0x060154F0 RID: 87280 RVA: 0x00561DF4 File Offset: 0x0055FFF4
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

	// Token: 0x060154F1 RID: 87281 RVA: 0x00561E6C File Offset: 0x0056006C
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

	// Token: 0x04009F45 RID: 40773
	private FavorGoods? FavorGoods;

	// Token: 0x04009F46 RID: 40774
	private UUITexture Icon;

	// Token: 0x04009F47 RID: 40775
	private UUIItem LockItem;

	// Token: 0x04009F48 RID: 40776
	private UUIItem InActiveBgItem;

	// Token: 0x04009F49 RID: 40777
	private UUIItem ActiveBgItem;
}
