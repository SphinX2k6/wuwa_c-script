using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Map.MapDefine;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.WorldMap;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001337 RID: 4919
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class HandbookDisplayGrid : GridProxyAbstract<IHandbookGridData>
{
	// Token: 0x060088F3 RID: 35059 RVA: 0x001D4278 File Offset: 0x001D2478
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

	// Token: 0x060088F4 RID: 35060 RVA: 0x001D4350 File Offset: 0x001D2550
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

	// Token: 0x060088F5 RID: 35061 RVA: 0x001D440C File Offset: 0x001D260C
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

	// Token: 0x060088F6 RID: 35062 RVA: 0x001D44A5 File Offset: 0x001D26A5
	private void SetPanelTitleVisible(bool bVisible)
	{
		base.GetItem(1).SetUIActive(bVisible);
	}

	// Token: 0x060088F7 RID: 35063 RVA: 0x001D44B4 File Offset: 0x001D26B4
	private void SetTitleByTextId(string textId)
	{
		base.GetText(2).ShowTextNew(textId);
	}

	// Token: 0x060088F8 RID: 35064 RVA: 0x001D44C4 File Offset: 0x001D26C4
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

	// Token: 0x04003D0C RID: 15628
	private int MarkId;

	// Token: 0x04003D0D RID: 15629
	private IHandbookGridData HandBookGridData;

	// Token: 0x020079A1 RID: 31137
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x040280CA RID: 164042
		public const int Texture = 0;

		// Token: 0x040280CB RID: 164043
		public const int PanelTitle = 1;

		// Token: 0x040280CC RID: 164044
		public const int TxtTitle = 2;

		// Token: 0x040280CD RID: 164045
		public const int Button = 3;

		// Token: 0x040280CE RID: 164046
		public const int SpriteBg = 4;

		// Token: 0x040280CF RID: 164047
		public const int SpriteLockBg = 5;

		// Token: 0x040280D0 RID: 164048
		public const int TextureLock = 6;
	}
}
