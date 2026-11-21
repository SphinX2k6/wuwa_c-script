using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001CFD RID: 7421
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class RoleTowerRoleCardItem : GridProxyAbstract<RoleTowerRoleCardData>
{
	// Token: 0x060125F9 RID: 75257 RVA: 0x0056D198 File Offset: 0x0056B398
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUITexture)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUITexture)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUISprite)),
			new ValueTuple<int, Type>(9, typeof(UUISprite)),
			new ValueTuple<int, Type>(10, typeof(UUISprite))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickTog))
		};
	}

	// Token: 0x060125FA RID: 75258 RVA: 0x0056D2C7 File Offset: 0x0056B4C7
	protected override void OnStart()
	{
		base.GetExtendToggle(0).bLockStateOnSelect = true;
	}

	// Token: 0x060125FB RID: 75259 RVA: 0x0056D2D8 File Offset: 0x0056B4D8
	public override void Refresh(RoleTowerRoleCardData data, bool isSelected, int gridIndex)
	{
		this.LevelId = data.LevelId;
		RoleTowerLevel? levelCfg = RoleTowerModel.Instance.GetLevelCfg(this.LevelId);
		RoleTowerLevelData levelState = RoleTowerModel.Instance.GetLevelState(this.LevelId);
		bool flag = levelState != null && levelState.IsUnlock;
		bool uiactive = levelState != null && levelState.IsAllPass;
		bool uiactive2 = levelState != null && levelState.HasSave;
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle != null)
		{
			extendToggle.SetToggleState(isSelected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
		}
		this.RefreshAvatar(levelCfg, flag);
		UUIItem item = base.GetItem(3);
		if (item != null)
		{
			item.SetUIActive(uiactive);
		}
		UUIItem item2 = base.GetItem(4);
		if (item2 != null)
		{
			item2.SetUIActive(uiactive2);
		}
		UUIItem item3 = base.GetItem(5);
		if (item3 != null)
		{
			item3.SetUIActive(!flag);
		}
		UUIItem item4 = base.GetItem(7);
		if (item4 != null)
		{
			ActivityRoleTowerData data2 = ActivityRoleTowerController.Instance.Data;
			item4.SetUIActive(data2 != null && data2.HasNewLevelRedDot(this.LevelId));
		}
		this.RefreshLockColor(!flag);
	}

	// Token: 0x060125FC RID: 75260 RVA: 0x0056D3D4 File Offset: 0x0056B5D4
	private void RefreshLockColor(bool isLock)
	{
		UUITexture texture = base.GetTexture(1);
		if (texture != null)
		{
			UUIItem uuiitem = texture;
			FColor? fcolor = new FColor?(texture.changeColor);
			uuiitem.SetChangeColor(isLock, fcolor);
		}
		UUISprite sprite = base.GetSprite(8);
		if (sprite != null)
		{
			UUIItem uuiitem2 = sprite;
			FColor? fcolor = new FColor?(sprite.changeColor);
			uuiitem2.SetChangeColor(isLock, fcolor);
		}
		UUISprite sprite2 = base.GetSprite(9);
		if (sprite2 != null)
		{
			UUIItem uuiitem3 = sprite2;
			FColor? fcolor = new FColor?(sprite2.changeColor);
			uuiitem3.SetChangeColor(isLock, fcolor);
		}
		UUISprite sprite3 = base.GetSprite(10);
		if (sprite3 != null)
		{
			UUIItem uuiitem4 = sprite3;
			FColor? fcolor = new FColor?(sprite3.changeColor);
			uuiitem4.SetChangeColor(isLock, fcolor);
		}
	}

	// Token: 0x060125FD RID: 75261 RVA: 0x0056D468 File Offset: 0x0056B668
	private void RefreshAvatar(RoleTowerLevel? levelCfg, bool isUnlock)
	{
		UUITexture texture = base.GetTexture(1);
		UUITexture texture2 = base.GetTexture(6);
		UUITexture texture3 = base.GetTexture(2);
		if (levelCfg == null || texture == null || texture2 == null)
		{
			return;
		}
		string roleTowerLevelIcon = levelCfg.Value.RoleTowerLevelIcon;
		if (string.IsNullOrEmpty(roleTowerLevelIcon))
		{
			texture.SetUIActive(false);
			texture2.SetUIActive(false);
			if (texture3 != null)
			{
				texture3.SetUIActive(false);
			}
			return;
		}
		texture.SetUIActive(true);
		texture2.SetUIActive(true);
		base.SetTextureByPath(roleTowerLevelIcon, texture, null, null);
		base.SetTextureByPath(roleTowerLevelIcon, texture2, null, null);
		if (texture3 != null)
		{
			texture3.SetUIActive(true);
			base.SetTextureByPath(roleTowerLevelIcon, texture3, null, null);
		}
	}

	// Token: 0x060125FE RID: 75262 RVA: 0x0056D520 File Offset: 0x0056B720
	private void OnClickTog(EToggleState check)
	{
		if (check == EToggleState.ETT_Checked)
		{
			IScrollViewDelegate<IGridProxy<RoleTowerRoleCardData>, RoleTowerRoleCardData> scrollViewDelegate = base.ScrollViewDelegate;
			if (scrollViewDelegate == null)
			{
				return;
			}
			scrollViewDelegate.SelectGridProxy(base.GridIndex, base.DisplayIndex, false);
		}
	}

	// Token: 0x060125FF RID: 75263 RVA: 0x0056D544 File Offset: 0x0056B744
	public override void OnSelected(bool fireEvent)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle != null)
		{
			extendToggle.SetToggleState(EToggleState.ETT_Checked, false, false, false);
		}
		ActivityRoleTowerData data = ActivityRoleTowerController.Instance.Data;
		if (data != null)
		{
			data.MarkNewLevelRead(this.LevelId);
		}
		UUIItem item = base.GetItem(7);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		RoleTowerModel.Instance.SelectLevel(this.LevelId);
	}

	// Token: 0x06012600 RID: 75264 RVA: 0x0056D5A6 File Offset: 0x0056B7A6
	public override void OnDeselected(bool fireEvent)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x06012601 RID: 75265 RVA: 0x0056D5BE File Offset: 0x0056B7BE
	public override object GetKey(RoleTowerRoleCardData data, int displayIndex)
	{
		return data.LevelId;
	}

	// Token: 0x0400A020 RID: 40992
	private int LevelId;

	// Token: 0x02008021 RID: 32801
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x0402974E RID: 169806
		public const int TogItem = 0;

		// Token: 0x0402974F RID: 169807
		public const int TexRoleAvatar = 1;

		// Token: 0x04029750 RID: 169808
		public const int TexRoleAvatarShadow = 2;

		// Token: 0x04029751 RID: 169809
		public const int PnlWinState = 3;

		// Token: 0x04029752 RID: 169810
		public const int PnlRecordState = 4;

		// Token: 0x04029753 RID: 169811
		public const int PnlLockState = 5;

		// Token: 0x04029754 RID: 169812
		public const int TexRoleAvatar2 = 6;

		// Token: 0x04029755 RID: 169813
		public const int PnlRedDot = 7;

		// Token: 0x04029756 RID: 169814
		public const int SprNor = 8;

		// Token: 0x04029757 RID: 169815
		public const int SprHold = 9;

		// Token: 0x04029758 RID: 169816
		public const int SprPress = 10;
	}
}
