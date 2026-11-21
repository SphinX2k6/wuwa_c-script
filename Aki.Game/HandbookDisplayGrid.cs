using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.WorldMap;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020007EB RID: 2027
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class HandbookDisplayGrid : GridProxyAbstract<IHandbookGridData>
{
	// Token: 0x06005C8E RID: 23694 RVA: 0x001DD0E4 File Offset: 0x001DB2E4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUITexture))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(3, new Action(this.OnButtonClicked))
		};
	}

	// Token: 0x06005C8F RID: 23695 RVA: 0x001DD1BC File Offset: 0x001DB3BC
	public override void Refresh(IHandbookGridData data, bool isSelected, int gridIndex)
	{
		this.HandBookGridData = data;
		Building buildingById = BuildingConfig.Instance.GetBuildingById(data.Id);
		this.RefreshTexture(buildingById.BuildingTexture, data.IsUnlock);
		this.SetPanelTitleVisible(true);
		if (data.IsUnlock)
		{
			this.SetTitleByTextId(buildingById.Name);
		}
		else
		{
			base.GetText(2).SetText("???", true);
		}
		base.GetItem(4).SetUIActive(data.IsUnlock);
		base.GetItem(5).SetUIActive(!data.IsUnlock);
		base.GetButton(3).RootUIComp.Get().SetUIActive(data.IsUnlock);
		this.MarkId = buildingById.MapMarkId;
	}

	// Token: 0x06005C90 RID: 23696 RVA: 0x001DD278 File Offset: 0x001DB478
	private void RefreshTexture(string path, bool isUnlock)
	{
		UUITexture texture = base.GetTexture(0);
		UUITexture textureLock = base.GetTexture(6);
		texture.SetUIActive(false);
		textureLock.SetUIActive(false);
		if (string.IsNullOrEmpty(path))
		{
			return;
		}
		base.SetTextureByPath(path, texture, null, delegate(bool _)
		{
			texture.SetUIActive(true);
		});
		base.SetTextureByPath(path, textureLock, null, delegate(bool _)
		{
			textureLock.SetUIActive(!isUnlock);
		});
	}

	// Token: 0x06005C91 RID: 23697 RVA: 0x001DD311 File Offset: 0x001DB511
	private void SetPanelTitleVisible(bool bVisible)
	{
		base.GetItem(1).SetUIActive(bVisible);
	}

	// Token: 0x06005C92 RID: 23698 RVA: 0x001DD320 File Offset: 0x001DB520
	private void SetTitleByTextId(string textId)
	{
		base.GetText(2).ShowTextNew(textId);
	}

	// Token: 0x06005C93 RID: 23699 RVA: 0x001DD330 File Offset: 0x001DB530
	private void OnButtonClicked()
	{
		if (this.HandBookGridData.IsUnlock)
		{
			if (this.MarkId <= 0)
			{
				Log.Instance.Error(ELogModule.MoonChasing, ELogAuthor.BB, "HandbookDisplayGrid 无效markId", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			WorldMapViewOpenParams data = new WorldMapViewOpenParams
			{
				MarkId = new int?(this.MarkId),
				MarkType = EMarkType.None
			};
			WorldMapController.Instance.OpenView(EOpenMapType.Other, false, data, null);
			return;
		}
		else
		{
			if (UiManager.Instance.IsViewOpen(EUiViewName.MoonChasingMainView))
			{
				MoonChasingController.Instance.OpenBuildingTipsInfoView(this.HandBookGridData.Id);
				return;
			}
			ScrollingTipsController.Instance.ShowTipsByTextId("Moonfiesta_BuildingUnlock", Array.Empty<object>());
			return;
		}
	}

	// Token: 0x04003DA4 RID: 15780
	private int MarkId;

	// Token: 0x04003DA5 RID: 15781
	private IHandbookGridData HandBookGridData;

	// Token: 0x02006B2B RID: 27435
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x040233F7 RID: 144375
		public const int Texture = 0;

		// Token: 0x040233F8 RID: 144376
		public const int PanelTitle = 1;

		// Token: 0x040233F9 RID: 144377
		public const int TxtTitle = 2;

		// Token: 0x040233FA RID: 144378
		public const int Button = 3;

		// Token: 0x040233FB RID: 144379
		public const int SpriteBg = 4;

		// Token: 0x040233FC RID: 144380
		public const int SpriteLockBg = 5;

		// Token: 0x040233FD RID: 144381
		public const int TextureLock = 6;
	}
}
