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

// Token: 0x02001A50 RID: 6736
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
internal class RankRoleGridItem : GridProxyAbstract<DangoAbyssRankRoleData>
{
	// Token: 0x0600C64A RID: 50762 RVA: 0x002D14EC File Offset: 0x002CF6EC
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

	// Token: 0x0600C64B RID: 50763 RVA: 0x002D1598 File Offset: 0x002CF798
	protected override UniTask OnBeforeStartAsync()
	{
		RankRoleGridItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RankRoleGridItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600C64C RID: 50764 RVA: 0x002D15DC File Offset: 0x002CF7DC
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

	// Token: 0x0600C64D RID: 50765 RVA: 0x002D1668 File Offset: 0x002CF868
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

	// Token: 0x0600C64E RID: 50766 RVA: 0x002D1780 File Offset: 0x002CF980
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

	// Token: 0x0600C64F RID: 50767 RVA: 0x002D1814 File Offset: 0x002CFA14
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

	// Token: 0x0600C650 RID: 50768 RVA: 0x002D186F File Offset: 0x002CFA6F
	public override void Refresh(DangoAbyssRankRoleData data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		this.RefreshPosTexture();
		this.RefreshItemGrid();
		this.RefreshDangoIcon();
		this.RefreshQualityItem();
	}

	// Token: 0x04005B5C RID: 23388
	private DangoAbyssRankRoleData Data;

	// Token: 0x04005B5D RID: 23389
	private SmallItemGrid ItemGrid;

	// Token: 0x04005B5E RID: 23390
	[Nullable(2)]
	private CharacterSmallItemGrid CacheGridData;

	// Token: 0x04005B5F RID: 23391
	[Nullable(2)]
	private AbyssDangoCircleQualityItem DangoCircleQualityItem;

	// Token: 0x02007F98 RID: 32664
	[NullableContext(0)]
	private class ERankRoleComponent
	{
		// Token: 0x04029A94 RID: 170644
		public const int GridItem = 0;

		// Token: 0x04029A95 RID: 170645
		public const int DangoTexture = 1;

		// Token: 0x04029A96 RID: 170646
		public const int PosTexture = 2;

		// Token: 0x04029A97 RID: 170647
		public const int QualityItem = 3;
	}
}
