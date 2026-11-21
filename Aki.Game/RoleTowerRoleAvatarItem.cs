using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Skin;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001CFC RID: 7420
[NullableContext(1)]
[Nullable(0)]
public class RoleTowerRoleAvatarItem : UiPanelBase
{
	// Token: 0x060125EF RID: 75247 RVA: 0x0056CBAA File Offset: 0x0056ADAA
	public void SetClickCallback(Action callback)
	{
		this.ClickCallback = callback;
	}

	// Token: 0x060125F0 RID: 75248 RVA: 0x0056CBB4 File Offset: 0x0056ADB4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUISprite)),
			new ValueTuple<int, Type>(10, typeof(UUISprite)),
			new ValueTuple<int, Type>(11, typeof(UUIItem)),
			new ValueTuple<int, Type>(12, typeof(UUISprite))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnClick))
		};
	}

	// Token: 0x060125F1 RID: 75249 RVA: 0x0056CD14 File Offset: 0x0056AF14
	protected override void OnStart()
	{
		UUIItem item = base.GetItem(4);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		UUIItem item2 = base.GetItem(7);
		if (item2 != null)
		{
			item2.SetUIActive(false);
		}
		UUIItem item3 = base.GetItem(8);
		if (item3 != null)
		{
			item3.SetUIActive(false);
		}
		UUISprite sprite = base.GetSprite(9);
		if (sprite != null)
		{
			sprite.SetUIActive(false);
		}
		UUISprite sprite2 = base.GetSprite(10);
		if (sprite2 != null)
		{
			sprite2.SetUIActive(false);
		}
		UUIItem item4 = base.GetItem(11);
		if (item4 != null)
		{
			item4.SetUIActive(false);
		}
		UUISprite sprite3 = base.GetSprite(12);
		this.CostIconDefaultColor = ((sprite3 != null) ? new FColor?(sprite3.GetColor()) : null);
	}

	// Token: 0x060125F2 RID: 75250 RVA: 0x0056CDC0 File Offset: 0x0056AFC0
	public void Refresh(RoleTowerRoleAvatarData data)
	{
		bool flag = data.RoleId > 0;
		UUIItem item = base.GetItem(5);
		if (item != null)
		{
			item.SetUIActive(flag);
		}
		UUIItem item2 = base.GetItem(6);
		if (item2 != null)
		{
			item2.SetUIActive(!flag);
		}
		if (!flag)
		{
			UUITexture texture = base.GetTexture(1);
			if (texture != null)
			{
				texture.SetUIActive(false);
			}
			UUIItem item3 = base.GetItem(2);
			if (item3 != null)
			{
				item3.SetUIActive(false);
			}
			UUISprite sprite = base.GetSprite(10);
			if (sprite != null)
			{
				sprite.SetUIActive(false);
			}
			UUISprite sprite2 = base.GetSprite(9);
			if (sprite2 != null)
			{
				sprite2.SetUIActive(false);
			}
			UUIItem item4 = base.GetItem(7);
			if (item4 == null)
			{
				return;
			}
			item4.SetUIActive(false);
			return;
		}
		else
		{
			this.RefreshRoleIcon(data.RoleId);
			this.RefreshFatigue(data);
			UUISprite sprite3 = base.GetSprite(10);
			if (sprite3 != null)
			{
				sprite3.SetUIActive(RoleUtils.IsTrialRole(data.RoleId));
			}
			this.RefreshSkillBranch(data.RoleId);
			UUIItem item5 = base.GetItem(7);
			if (item5 == null)
			{
				return;
			}
			item5.SetUIActive(data.IsEquipLocked);
			return;
		}
	}

	// Token: 0x060125F3 RID: 75251 RVA: 0x0056CEB8 File Offset: 0x0056B0B8
	private void RefreshSkillBranch(int roleId)
	{
		UUISprite sprite = base.GetSprite(9);
		if (sprite == null)
		{
			return;
		}
		int roleSkillBranchIdInGamePlay = RoleModel.Instance.GetRoleSkillBranchIdInGamePlay(roleId, ESkillBranchCacheType.Mowing);
		int roleBranchIndexById = RoleModel.Instance.GetRoleBranchIndexById(roleId, roleSkillBranchIdInGamePlay);
		bool flag = roleBranchIndexById > -1;
		if (flag && !RoleUtils.IsTrialRole(roleId))
		{
			int roleId2 = (roleId > 10000) ? RoleConfig.Instance.GetTrialRoleConfig(roleId).Value.ParentId : roleId;
			flag = RoleModel.Instance.IsHasRole(roleId2);
		}
		sprite.SetUIActive(flag);
		if (!flag)
		{
			return;
		}
		int num = (roleBranchIndexById == 0) ? 0 : 180;
		UUIItem uuiitem = sprite;
		FVector fvector = new FVector(0f, (float)num, 0f);
		FRotator frotator = FRotator.MakeFromEuler(fvector);
		uuiitem.SetUIRelativeRotation(frotator);
	}

	// Token: 0x060125F4 RID: 75252 RVA: 0x0056CF70 File Offset: 0x0056B170
	private void RefreshRoleIcon(int roleId)
	{
		UUITexture texture = base.GetTexture(1);
		if (texture == null)
		{
			return;
		}
		RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(roleId);
		if (roleConfig == null)
		{
			texture.SetUIActive(false);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Temp;
			ELogAuthor author = ELogAuthor.LJQ;
			string message = "RoleTower.RoleAvatarItem 角色配置缺失(TODO 校准头像数据源)";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("roleId", roleId);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		texture.SetUIActive(true);
		RoleDataBase roleDataById = RoleModel.Instance.GetRoleDataById(roleId, true);
		int num = (roleDataById != null) ? roleDataById.GetRoleSkinId() : 0;
		RoleSkin? roleSkin = (num > 0) ? SkinConfig.Instance.GetRoleSkinConfig(num) : null;
		if (roleSkin != null)
		{
			base.SetRoleIconByRoleIdOrSkinId(roleSkin.Value.RoleHeadIconCircle, texture, roleId, new int?(num), null, null);
			return;
		}
		base.SetRoleIcon(roleConfig.Value.RoleHeadIconCircle, texture, roleId, null, null);
	}

	// Token: 0x060125F5 RID: 75253 RVA: 0x0056D064 File Offset: 0x0056B264
	private void RefreshFatigue(RoleTowerRoleAvatarData data)
	{
		UUIItem item = base.GetItem(2);
		UUIText text = base.GetText(3);
		bool flag = data.Slot == ERoleTowerSlotType.Assist1 || data.Slot == ERoleTowerSlotType.Assist2;
		if (item != null)
		{
			item.SetUIActive(flag);
		}
		if (!flag || text == null)
		{
			return;
		}
		text.SetRichText(true);
		text.SetText(data.Fatigue.ToString(), true);
		bool flag2 = data.Fatigue < data.FatigueCost;
		if (flag2)
		{
			UUIText uuitext = text;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(16, 2);
			defaultInterpolatedStringHandler.AppendLiteral("<color=");
			defaultInterpolatedStringHandler.AppendFormatted("#ff4040");
			defaultInterpolatedStringHandler.AppendLiteral(">");
			defaultInterpolatedStringHandler.AppendFormatted<int>(data.Fatigue);
			defaultInterpolatedStringHandler.AppendLiteral("</color>");
			uuitext.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}
		this.RefreshCostIconColor(flag2);
	}

	// Token: 0x060125F6 RID: 75254 RVA: 0x0056D130 File Offset: 0x0056B330
	private void RefreshCostIconColor(bool lack)
	{
		UUISprite sprite = base.GetSprite(12);
		if (sprite == null)
		{
			return;
		}
		if (lack)
		{
			sprite.SetColor(FColor.FromHex("#ff4040"));
			return;
		}
		if (this.CostIconDefaultColor != null)
		{
			sprite.SetColor(this.CostIconDefaultColor.Value);
		}
	}

	// Token: 0x060125F7 RID: 75255 RVA: 0x0056D17C File Offset: 0x0056B37C
	private void OnClick()
	{
		Action clickCallback = this.ClickCallback;
		if (clickCallback == null)
		{
			return;
		}
		clickCallback();
	}

	// Token: 0x0400A01C RID: 40988
	private const string FatigueLackColorHex = "#ff4040";

	// Token: 0x0400A01D RID: 40989
	private const int TrialRoleMinId = 10000;

	// Token: 0x0400A01E RID: 40990
	private FColor? CostIconDefaultColor;

	// Token: 0x0400A01F RID: 40991
	[Nullable(2)]
	private Action ClickCallback;

	// Token: 0x02008020 RID: 32800
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x04029741 RID: 169793
		public const int Btn = 0;

		// Token: 0x04029742 RID: 169794
		public const int TexRole = 1;

		// Token: 0x04029743 RID: 169795
		public const int PnlCost = 2;

		// Token: 0x04029744 RID: 169796
		public const int TxtNum = 3;

		// Token: 0x04029745 RID: 169797
		public const int PnlUpArrow = 4;

		// Token: 0x04029746 RID: 169798
		public const int PnlAvatar = 5;

		// Token: 0x04029747 RID: 169799
		public const int PnlEmpty = 6;

		// Token: 0x04029748 RID: 169800
		public const int PnlWarning = 7;

		// Token: 0x04029749 RID: 169801
		public const int PnlEmptyRole = 8;

		// Token: 0x0402974A RID: 169802
		public const int SprBuff = 9;

		// Token: 0x0402974B RID: 169803
		public const int SprRoleTrial = 10;

		// Token: 0x0402974C RID: 169804
		public const int PnlRedDot = 11;

		// Token: 0x0402974D RID: 169805
		public const int SprCostIcon = 12;
	}
}
