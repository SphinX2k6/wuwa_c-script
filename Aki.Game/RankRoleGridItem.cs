using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Skin;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000F0F RID: 3855
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
internal class RankRoleGridItem : GridProxyAbstract<DangoAbyssRankRoleData>
{
	// Token: 0x06009A5A RID: 39514 RVA: 0x002DC600 File Offset: 0x002DA800
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06009A5B RID: 39515 RVA: 0x002DC6AC File Offset: 0x002DA8AC
	protected override UniTask OnBeforeStartAsync()
	{
		RankRoleGridItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RankRoleGridItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06009A5C RID: 39516 RVA: 0x002DC6F0 File Offset: 0x002DA8F0
	private void RefreshPosTexture()
	{
		UUITexture texture = base.GetTexture(2);
		if (this.Data.IsEmpty)
		{
			texture.SetUIActive(false);
			return;
		}
		if (this.Data != null)
		{
			texture.SetUIActive(this.Data.IsOnline);
			if (this.Data.IsOnline)
			{
				string posTexture = DangoAbyssRankItemHelper.GetPosTexture(this.Data.Pos);
				string resourcePath = UiResourceConfig.Instance.GetResourcePath(posTexture);
				base.SetTextureByPath(resourcePath, texture, null, null);
				return;
			}
		}
		else
		{
			texture.SetUIActive(false);
		}
	}

	// Token: 0x06009A5D RID: 39517 RVA: 0x002DC77C File Offset: 0x002DA97C
	private void RefreshItemGrid()
	{
		if (this.Data.IsEmpty)
		{
			this.ItemGrid.SetActive(false);
			return;
		}
		this.ItemGrid.SetActive(true);
		RoleSkin value = SkinConfig.Instance.GetRoleSkinConfig(this.Data.RoleSkinId).Value;
		RoleInfo value2 = RoleConfig.Instance.GetRoleConfig(value.RoleId).Value;
		if (this.CacheGridData == null)
		{
			this.CacheGridData = new CharacterSmallItemGrid
			{
				Data = null
			};
		}
		this.CacheGridData.ItemConfigId = new int?(value.RoleId);
		this.CacheGridData.SkinId = new int?(this.Data.RoleSkinId);
		this.CacheGridData.BottomTextId = "Text_LevelShow_Text";
		this.CacheGridData.BottomTextParameter = new object[]
		{
			this.Data.RoleLevel
		};
		this.CacheGridData.ElementId = new int?(value2.ElementId);
		this.ItemGrid.Apply<CharacterSmallItemGrid>(this.CacheGridData);
	}

	// Token: 0x06009A5E RID: 39518 RVA: 0x002DC894 File Offset: 0x002DAA94
	private void RefreshDangoIcon()
	{
		if (this.Data.IsEmpty)
		{
			base.GetTexture(1).SetUIActive(false);
			return;
		}
		AbyssDangoRoleData dangoAbyssRoleData = DangoAbyssModel.Instance.GetDangoAbyssRoleData(this.Data.DangoId);
		string text = ((dangoAbyssRoleData != null) ? dangoAbyssRoleData.GetFormationIcon() : null) ?? "";
		if (!string.IsNullOrEmpty(text))
		{
			base.GetTexture(1).SetUIActive(true);
			base.SetTextureByPath(text, base.GetTexture(1), null, null);
			return;
		}
		base.GetTexture(1).SetUIActive(false);
	}

	// Token: 0x06009A5F RID: 39519 RVA: 0x002DC928 File Offset: 0x002DAB28
	private void RefreshQualityItem()
	{
		if (this.Data.IsEmpty)
		{
			this.DangoCircleQualityItem.SetActive(false);
			return;
		}
		Dictionary<int, int> equipPluginMap = this.Data.GetEquipPluginMap();
		DangoCircleQualityData dangoCircleQualityData = new DangoCircleQualityData();
		dangoCircleQualityData.PluginIdMap = equipPluginMap;
		this.DangoCircleQualityItem.RefreshData(dangoCircleQualityData);
		this.DangoCircleQualityItem.SetActive(true);
	}

	// Token: 0x06009A60 RID: 39520 RVA: 0x002DC983 File Offset: 0x002DAB83
	public override void Refresh(DangoAbyssRankRoleData data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		this.RefreshPosTexture();
		this.RefreshItemGrid();
		this.RefreshDangoIcon();
		this.RefreshQualityItem();
	}

	// Token: 0x04005C2B RID: 23595
	private DangoAbyssRankRoleData Data;

	// Token: 0x04005C2C RID: 23596
	private SmallItemGrid ItemGrid;

	// Token: 0x04005C2D RID: 23597
	[Nullable(2)]
	private CharacterSmallItemGrid CacheGridData;

	// Token: 0x04005C2E RID: 23598
	[Nullable(2)]
	private AbyssDangoCircleQualityItem DangoCircleQualityItem;

	// Token: 0x02007127 RID: 28967
	[NullableContext(0)]
	private class ERankRoleComponent
	{
		// Token: 0x04024DD1 RID: 150993
		public const int GridItem = 0;

		// Token: 0x04024DD2 RID: 150994
		public const int DangoTexture = 1;

		// Token: 0x04024DD3 RID: 150995
		public const int PosTexture = 2;

		// Token: 0x04024DD4 RID: 150996
		public const int QualityItem = 3;
	}
}
