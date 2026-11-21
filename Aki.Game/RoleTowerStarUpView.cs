using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using UnrealEngine;

// Token: 0x02001D02 RID: 7426
[NullableContext(2)]
[Nullable(0)]
public class RoleTowerStarUpView : UiViewBase
{
	// Token: 0x06012627 RID: 75303 RVA: 0x0056E272 File Offset: 0x0056C472
	[NullableContext(1)]
	public RoleTowerStarUpView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06012628 RID: 75304 RVA: 0x0056E27C File Offset: 0x0056C47C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIHorizontalLayout)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUITexture)),
			new ValueTuple<int, Type>(7, typeof(UUIText)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIText)),
			new ValueTuple<int, Type>(10, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(11, typeof(UUIItem)),
			new ValueTuple<int, Type>(12, typeof(UUIItem)),
			new ValueTuple<int, Type>(13, typeof(UUIText)),
			new ValueTuple<int, Type>(14, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(15, typeof(UUIItem)),
			new ValueTuple<int, Type>(16, typeof(UUISprite)),
			new ValueTuple<int, Type>(17, typeof(UUISprite)),
			new ValueTuple<int, Type>(18, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(14, new Action(this.OnClickConfirm))
		};
	}

	// Token: 0x06012629 RID: 75305 RVA: 0x0056E464 File Offset: 0x0056C664
	protected override void OnStart()
	{
		UUIItem item = base.GetItem(15);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		this.StarLayout = new GenericLayout<RoleTowerPauseStarItem, bool>(base.GetHorizontalLayout(2), () => new RoleTowerPauseStarItem(), null, false, true);
		this.InfoList = new GenericScrollViewNew<RoleTowerInfoTextItem, RoleTowerPropBuffData>(base.GetScrollViewWithScrollbar(10), () => new RoleTowerInfoTextItem(), null, false, null);
		UUIVerticalLayout verticalLayout = base.GetVerticalLayout(4);
		bool flag;
		if (verticalLayout == null)
		{
			flag = (null != null);
		}
		else
		{
			UUIItem uuiitem = verticalLayout.RootUIComp.Get();
			flag = (((uuiitem != null) ? uuiitem.GetAttachUIChild(0) : null) != null);
		}
		if (flag)
		{
			this.RoleLayout = new GenericLayout<RoleTowerStarUpRoleAvatarItem, RoleTowerPropAvatarData>(verticalLayout, new Func<RoleTowerStarUpRoleAvatarItem>(this.CreateRoleAvatarItem), null, false, true);
		}
		UUIVerticalLayout verticalLayout2 = base.GetVerticalLayout(4);
		object obj;
		if (verticalLayout2 == null)
		{
			obj = null;
		}
		else
		{
			AActor owner = verticalLayout2.GetOwner();
			obj = ((owner != null) ? owner.GetComponentByClass(UUIInturnAnimController.StaticClass()) : null);
		}
		this.RoleListAnim = (obj as UUIInturnAnimController);
		UUIHorizontalLayout horizontalLayout = base.GetHorizontalLayout(2);
		object obj2;
		if (horizontalLayout == null)
		{
			obj2 = null;
		}
		else
		{
			AActor owner2 = horizontalLayout.GetOwner();
			obj2 = ((owner2 != null) ? owner2.GetComponentByClass(UUIInturnAnimController.StaticClass()) : null);
		}
		this.StarListAnim = (obj2 as UUIInturnAnimController);
		UUIScrollViewWithScrollbarComponent scrollViewWithScrollbar = base.GetScrollViewWithScrollbar(10);
		object obj3;
		if (scrollViewWithScrollbar == null)
		{
			obj3 = null;
		}
		else
		{
			AUIBaseActor auibaseActor = scrollViewWithScrollbar.Content.Get();
			obj3 = ((auibaseActor != null) ? auibaseActor.GetComponentByClass(UUIInturnAnimController.StaticClass()) : null);
		}
		this.InfoListAnim = (obj3 as UUIInturnAnimController);
	}

	// Token: 0x0601262A RID: 75306 RVA: 0x0056E5D9 File Offset: 0x0056C7D9
	[NullableContext(1)]
	private RoleTowerStarUpRoleAvatarItem CreateRoleAvatarItem()
	{
		RoleTowerStarUpRoleAvatarItem roleTowerStarUpRoleAvatarItem = new RoleTowerStarUpRoleAvatarItem();
		roleTowerStarUpRoleAvatarItem.SetClickCallback(new Action<int>(this.OnSwitchRole));
		return roleTowerStarUpRoleAvatarItem;
	}

	// Token: 0x0601262B RID: 75307 RVA: 0x0056E5F4 File Offset: 0x0056C7F4
	protected override void OnBeforeShow()
	{
		this.CurSelectRoleId = RoleTowerModel.Instance.GetSlotRoleId(ERoleTowerSlotType.Main);
		this.RefreshRoleList();
		this.RefreshRole();
		this.RefreshStar();
		this.RefreshEffectList();
		this.RefreshNextTarget();
		UUIItem item = base.GetItem(0);
		if (item != null)
		{
			item.SetUIActive(true);
		}
		UUIInturnAnimController roleListAnim = this.RoleListAnim;
		if (roleListAnim != null)
		{
			roleListAnim.Play("", -1, false);
		}
		UUIInturnAnimController starListAnim = this.StarListAnim;
		if (starListAnim == null)
		{
			return;
		}
		starListAnim.Play("", -1, false);
	}

	// Token: 0x0601262C RID: 75308 RVA: 0x0056E674 File Offset: 0x0056C874
	private void RefreshRoleList()
	{
		List<RoleTowerPropAvatarData> list = new List<RoleTowerPropAvatarData>();
		foreach (ERoleTowerSlotType slot in new ERoleTowerSlotType[]
		{
			ERoleTowerSlotType.Main,
			ERoleTowerSlotType.Assist1,
			ERoleTowerSlotType.Assist2
		})
		{
			int slotRoleId = RoleTowerModel.Instance.GetSlotRoleId(slot);
			if (slotRoleId > 0)
			{
				list.Add(new RoleTowerPropAvatarData
				{
					RoleId = slotRoleId,
					Slot = slot,
					IsTrial = RoleTowerModel.Instance.GetSlotIsTrial(slot),
					IsSelected = (slotRoleId == this.CurSelectRoleId)
				});
			}
		}
		GenericLayout<RoleTowerStarUpRoleAvatarItem, RoleTowerPropAvatarData> roleLayout = this.RoleLayout;
		if (roleLayout == null)
		{
			return;
		}
		roleLayout.RefreshByData(list, null, false);
	}

	// Token: 0x0601262D RID: 75309 RVA: 0x0056E708 File Offset: 0x0056C908
	private void OnSwitchRole(int roleId)
	{
		if (roleId <= 0 || roleId == this.CurSelectRoleId)
		{
			return;
		}
		this.CurSelectRoleId = roleId;
		this.RefreshRoleList();
		this.RefreshRole();
		this.RefreshStar();
		this.RefreshEffectList();
	}

	// Token: 0x0601262E RID: 75310 RVA: 0x0056E738 File Offset: 0x0056C938
	private void RefreshRole()
	{
		int curSelectRoleId = this.CurSelectRoleId;
		RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(curSelectRoleId);
		if (roleConfig != null)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(7), roleConfig.Value.Name, Array.Empty<object>());
		}
		bool flag = curSelectRoleId == RoleTowerModel.Instance.GetSlotRoleId(ERoleTowerSlotType.Main);
		UUIText text = base.GetText(9);
		if (text != null)
		{
			text.ShowTextNew(flag ? "RoleTowerToken_MainCharacter" : "RoleTowerToken_ViceCharacter");
		}
		UUISprite sprite = base.GetSprite(16);
		if (sprite != null)
		{
			UUIItem uuiitem = sprite;
			bool bUseChangeColor = flag;
			FColor? fcolor = new FColor?(sprite.changeColor);
			uuiitem.SetChangeColor(bUseChangeColor, fcolor);
		}
		this.RefreshElement(roleConfig);
		this.RefreshRolePix(curSelectRoleId);
	}

	// Token: 0x0601262F RID: 75311 RVA: 0x0056E7E8 File Offset: 0x0056C9E8
	private void RefreshElement(RoleInfo? role)
	{
		UUISprite sprite = base.GetSprite(17);
		UUIText text = base.GetText(18);
		ElementInfo? elementInfo = (role != null) ? ElementInfoConfig.Instance.GetElementInfo(role.Value.ElementId) : null;
		if (elementInfo == null)
		{
			if (sprite != null)
			{
				sprite.SetUIActive(false);
			}
			if (text != null)
			{
				text.SetUIActive(false);
			}
			return;
		}
		if (text != null)
		{
			text.SetUIActive(true);
			text.SetText(ElementInfoConfig.Instance.GetElementInfoLocalName(elementInfo.Value.Name), true);
			text.SetColor(FColor.FromHex(elementInfo.Value.ElementColor));
		}
		if (sprite != null)
		{
			string spriteIcon = elementInfo.Value.SpriteIcon1;
			if (string.IsNullOrEmpty(spriteIcon))
			{
				sprite.SetUIActive(false);
				return;
			}
			sprite.SetUIActive(true);
			this.SetSpriteByPath(spriteIcon, sprite, false, null, null);
			sprite.SetColor(FColor.FromHex(elementInfo.Value.ElementColor));
		}
	}

	// Token: 0x06012630 RID: 75312 RVA: 0x0056E8F8 File Offset: 0x0056CAF8
	private void RefreshRolePix(int roleId)
	{
		UUITexture texture = base.GetTexture(6);
		if (texture == null)
		{
			return;
		}
		RoleTrialRoleConfig? roleTrialRoleConfigByRoleId = ActivityRoleTrialConfig.Instance.GetRoleTrialRoleConfigByRoleId(RoleTowerModel.ToSourceRoleId(roleId));
		string text = (roleTrialRoleConfigByRoleId != null) ? roleTrialRoleConfigByRoleId.GetValueOrDefault().RoleStand : null;
		if (string.IsNullOrEmpty(text))
		{
			texture.SetUIActive(false);
			return;
		}
		texture.SetUIActive(true);
		base.SetTextureByPath(text, texture, null, null);
	}

	// Token: 0x06012631 RID: 75313 RVA: 0x0056E968 File Offset: 0x0056CB68
	private void RefreshStar()
	{
		int curTeamStar = RoleTowerModel.Instance.GetCurTeamStar();
		IReadOnlyList<RoleTowerStar> starCfgListByRole = RoleTowerModel.Instance.GetStarCfgListByRole(this.CurSelectRoleId);
		List<bool> list = new List<bool>();
		for (int i = 0; i < starCfgListByRole.Count; i++)
		{
			list.Add(i < curTeamStar);
		}
		GenericLayout<RoleTowerPauseStarItem, bool> starLayout = this.StarLayout;
		if (starLayout == null)
		{
			return;
		}
		starLayout.RefreshByData(list, null, false);
	}

	// Token: 0x06012632 RID: 75314 RVA: 0x0056E9C8 File Offset: 0x0056CBC8
	private void RefreshEffectList()
	{
		int curTeamStar = RoleTowerModel.Instance.GetCurTeamStar();
		List<RoleTowerPropBuffData> list = new List<RoleTowerPropBuffData>();
		foreach (RoleTowerStar roleTowerStar in RoleTowerModel.Instance.GetStarCfgListByRole(this.CurSelectRoleId))
		{
			if (roleTowerStar.StarIndex > 0)
			{
				list.Add(new RoleTowerPropBuffData
				{
					Title = roleTowerStar.Name,
					Desc = roleTowerStar.Desc,
					DescParams = roleTowerStar.DescParam(),
					IsActive = (roleTowerStar.StarIndex <= curTeamStar)
				});
			}
		}
		GenericScrollViewNew<RoleTowerInfoTextItem, RoleTowerPropBuffData> infoList = this.InfoList;
		if (infoList != null)
		{
			infoList.RefreshByData(list, null, false);
		}
		UUIInturnAnimController infoListAnim = this.InfoListAnim;
		if (infoListAnim == null)
		{
			return;
		}
		infoListAnim.Play("", -1, false);
	}

	// Token: 0x06012633 RID: 75315 RVA: 0x0056EAA4 File Offset: 0x0056CCA4
	private void RefreshNextTarget()
	{
		int nextStarUpFloorIndex = RoleTowerModel.Instance.GetNextStarUpFloorIndex();
		bool flag = nextStarUpFloorIndex > 0;
		UUIItem item = base.GetItem(12);
		if (item != null)
		{
			item.SetUIActive(flag);
		}
		if (!flag)
		{
			return;
		}
		string nextStarUpStageName = RoleTowerModel.Instance.GetNextStarUpStageName();
		LguiUtil.Instance.SetLocalTextNew(base.GetText(13), "RoleTowerNextStarUpLevel", new <>z__ReadOnlySingleElementList<object>(string.IsNullOrEmpty(nextStarUpStageName) ? nextStarUpFloorIndex.ToString() : new TableTextArgNew(nextStarUpStageName, Array.Empty<object>())));
	}

	// Token: 0x06012634 RID: 75316 RVA: 0x0056EB1C File Offset: 0x0056CD1C
	private void OnClickConfirm()
	{
		RoleTowerController.Instance.StepAdvanceTeamUpgrade().Forget<bool>();
		base.CloseMe(null);
	}

	// Token: 0x0400A036 RID: 41014
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<RoleTowerPauseStarItem, bool> StarLayout;

	// Token: 0x0400A037 RID: 41015
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericScrollViewNew<RoleTowerInfoTextItem, RoleTowerPropBuffData> InfoList;

	// Token: 0x0400A038 RID: 41016
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<RoleTowerStarUpRoleAvatarItem, RoleTowerPropAvatarData> RoleLayout;

	// Token: 0x0400A039 RID: 41017
	private UUIInturnAnimController RoleListAnim;

	// Token: 0x0400A03A RID: 41018
	private UUIInturnAnimController StarListAnim;

	// Token: 0x0400A03B RID: 41019
	private UUIInturnAnimController InfoListAnim;

	// Token: 0x0400A03C RID: 41020
	private int CurSelectRoleId;

	// Token: 0x0200802C RID: 32812
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x04029789 RID: 169865
		public const int PnlLevelUp = 0;

		// Token: 0x0402978A RID: 169866
		public const int TxtTitle = 1;

		// Token: 0x0402978B RID: 169867
		public const int PnlLevelStar = 2;

		// Token: 0x0402978C RID: 169868
		public const int UiItemStar = 3;

		// Token: 0x0402978D RID: 169869
		public const int PnlRoleLeft = 4;

		// Token: 0x0402978E RID: 169870
		public const int UiItemRoleAvatarTog = 5;

		// Token: 0x0402978F RID: 169871
		public const int TexRolePix = 6;

		// Token: 0x04029790 RID: 169872
		public const int TxtRoleName = 7;

		// Token: 0x04029791 RID: 169873
		public const int PnlTag = 8;

		// Token: 0x04029792 RID: 169874
		public const int TxtTagTitle = 9;

		// Token: 0x04029793 RID: 169875
		public const int InfoItemScroll = 10;

		// Token: 0x04029794 RID: 169876
		public const int UiItemInfoItem = 11;

		// Token: 0x04029795 RID: 169877
		public const int PnlNextTarget = 12;

		// Token: 0x04029796 RID: 169878
		public const int TxtNextTargetTitle = 13;

		// Token: 0x04029797 RID: 169879
		public const int BtnConfirmB = 14;

		// Token: 0x04029798 RID: 169880
		public const int CaptionItem = 15;

		// Token: 0x04029799 RID: 169881
		public const int BgTag = 16;

		// Token: 0x0402979A RID: 169882
		public const int TagSpr = 17;

		// Token: 0x0402979B RID: 169883
		public const int TagText = 18;
	}
}
