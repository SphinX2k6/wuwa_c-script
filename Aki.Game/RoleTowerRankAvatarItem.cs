using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001CF2 RID: 7410
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class RoleTowerRankAvatarItem : GridProxyAbstract<RoleTowerRankAvatarData>
{
	// Token: 0x06012580 RID: 75136 RVA: 0x00569E23 File Offset: 0x00568023
	public void SetClickCallback(Action<int> callback)
	{
		this.ClickCallback = callback;
	}

	// Token: 0x06012581 RID: 75137 RVA: 0x00569E2C File Offset: 0x0056802C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
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
			new ValueTuple<int, Type>(11, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickTog))
		};
	}

	// Token: 0x06012582 RID: 75138 RVA: 0x00569F74 File Offset: 0x00568174
	protected override void OnStart()
	{
		base.GetExtendToggle(0).bLockStateOnSelect = true;
		UUIItem item = base.GetItem(4);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		UUIItem item2 = base.GetItem(2);
		if (item2 != null)
		{
			item2.SetUIActive(false);
		}
		UUIItem item3 = base.GetItem(6);
		if (item3 != null)
		{
			item3.SetUIActive(false);
		}
		UUIItem item4 = base.GetItem(7);
		if (item4 != null)
		{
			item4.SetUIActive(false);
		}
		UUIItem item5 = base.GetItem(8);
		if (item5 != null)
		{
			item5.SetUIActive(false);
		}
		UUISprite sprite = base.GetSprite(9);
		if (sprite != null)
		{
			sprite.SetUIActive(false);
		}
		UUISprite sprite2 = base.GetSprite(10);
		if (sprite2 == null)
		{
			return;
		}
		sprite2.SetUIActive(false);
	}

	// Token: 0x06012583 RID: 75139 RVA: 0x0056A014 File Offset: 0x00568214
	public override void Refresh(RoleTowerRankAvatarData data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		UUIItem item = base.GetItem(5);
		if (item != null)
		{
			item.SetUIActive(true);
		}
		this.RefreshRoleIcon(data.MainRoleId);
		this.RefreshSelected(data.IsSelected);
		UUIItem item2 = base.GetItem(11);
		if (item2 == null)
		{
			return;
		}
		ActivityRoleTowerData data2 = ActivityRoleTowerController.Instance.Data;
		item2.SetUIActive(data2 != null && data2.HasNewRecordRedDot(data.LevelId));
	}

	// Token: 0x06012584 RID: 75140 RVA: 0x0056A084 File Offset: 0x00568284
	public override UniTask RefreshAsync(RoleTowerRankAvatarData data, bool isSelected, int gridIndex)
	{
		RoleTowerRankAvatarItem.<RefreshAsync>d__7 <RefreshAsync>d__;
		<RefreshAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshAsync>d__.<>4__this = this;
		<RefreshAsync>d__.data = data;
		<RefreshAsync>d__.isSelected = isSelected;
		<RefreshAsync>d__.gridIndex = gridIndex;
		<RefreshAsync>d__.<>1__state = -1;
		<RefreshAsync>d__.<>t__builder.Start<RoleTowerRankAvatarItem.<RefreshAsync>d__7>(ref <RefreshAsync>d__);
		return <RefreshAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06012585 RID: 75141 RVA: 0x0056A0DF File Offset: 0x005682DF
	public void RefreshSelected(bool selected)
	{
		if (this.Data != null)
		{
			this.Data.IsSelected = selected;
		}
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleStateForce(selected ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x06012586 RID: 75142 RVA: 0x0056A110 File Offset: 0x00568310
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
			string message = "RoleTower.RankAvatarItem 角色配置缺失(TODO 校准头像数据源)";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("roleId", roleId);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		texture.SetUIActive(true);
		base.SetRoleIcon(roleConfig.Value.RoleHeadIconCircle, texture, roleId, null, null);
	}

	// Token: 0x06012587 RID: 75143 RVA: 0x0056A199 File Offset: 0x00568399
	private void OnClickTog(EToggleState check)
	{
		if (check != EToggleState.ETT_Checked)
		{
			return;
		}
		if (this.Data != null)
		{
			Action<int> clickCallback = this.ClickCallback;
			if (clickCallback == null)
			{
				return;
			}
			clickCallback(this.Data.LevelId);
		}
	}

	// Token: 0x04009FF4 RID: 40948
	[Nullable(2)]
	private RoleTowerRankAvatarData Data;

	// Token: 0x04009FF5 RID: 40949
	[Nullable(2)]
	private Action<int> ClickCallback;

	// Token: 0x02008006 RID: 32774
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x040296B4 RID: 169652
		public const int TogAvatar = 0;

		// Token: 0x040296B5 RID: 169653
		public const int TexRole = 1;

		// Token: 0x040296B6 RID: 169654
		public const int PnlCost = 2;

		// Token: 0x040296B7 RID: 169655
		public const int TxtNum = 3;

		// Token: 0x040296B8 RID: 169656
		public const int PnlUpArrow = 4;

		// Token: 0x040296B9 RID: 169657
		public const int PnlAvatar = 5;

		// Token: 0x040296BA RID: 169658
		public const int PnlEmpty = 6;

		// Token: 0x040296BB RID: 169659
		public const int PnlWarning = 7;

		// Token: 0x040296BC RID: 169660
		public const int PnlEmptyRole = 8;

		// Token: 0x040296BD RID: 169661
		public const int SprBuff = 9;

		// Token: 0x040296BE RID: 169662
		public const int SprRoleTrial = 10;

		// Token: 0x040296BF RID: 169663
		public const int PnlRedDot = 11;
	}
}
