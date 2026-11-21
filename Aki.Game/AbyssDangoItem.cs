using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000EE2 RID: 3810
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class AbyssDangoItem : GridProxyAbstract<AbyssDangoItemData>
{
	// Token: 0x060098F0 RID: 39152 RVA: 0x002D57E4 File Offset: 0x002D39E4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUITexture)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIItem))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(6, new Action<EToggleState>(this.OnSelectToggleClick))
		};
	}

	// Token: 0x060098F1 RID: 39153 RVA: 0x002D58E8 File Offset: 0x002D3AE8
	protected override UniTask OnBeforeStartAsync()
	{
		AbyssDangoItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<AbyssDangoItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060098F2 RID: 39154 RVA: 0x002D5923 File Offset: 0x002D3B23
	private void OnSelectToggleClick(EToggleState toggleState)
	{
		this.CurrentData.OnSelectCallBack(this.CurrentData);
	}

	// Token: 0x060098F3 RID: 39155 RVA: 0x002D593B File Offset: 0x002D3B3B
	protected override void OnBeforeDestroy()
	{
		if (this.RedDotBindState)
		{
			RedDotController.Instance.UnBindGivenUi(ERedDotName.RedDotDangoFormationRole, base.GetItem(8), 0);
		}
	}

	// Token: 0x060098F4 RID: 39156 RVA: 0x002D595C File Offset: 0x002D3B5C
	public override void Refresh(AbyssDangoItemData data, bool isSelected, int gridIndex)
	{
		this.CurrentData = data;
		this.RefreshBelongTexture(data);
		this.RefreshLevelText(data);
		this.RefreshAvatarTexture(data);
		this.RefreshQualitySprite(data);
		this.RefreshToggleState(data);
		this.RefreshLockItem(data);
		this.RefreshLikeItem(data);
		int playerId = data.PlayerId;
		int? id = PlayerInfoModel.Instance.GetId();
		if (playerId == id.GetValueOrDefault() & id != null)
		{
			RedDotController.Instance.BindRedDot(ERedDotName.RedDotDangoFormationRole, base.GetItem(8), null, data.DangoId);
			this.RedDotBindState = true;
		}
	}

	// Token: 0x060098F5 RID: 39157 RVA: 0x002D59EC File Offset: 0x002D3BEC
	private void RefreshLikeItem(AbyssDangoItemData data)
	{
		InstanceDungeon? dungeonConfig = BattleTeamModel.Instance.Context.GetDungeonConfig();
		DangoAbyssActivityData currentOpenAbyssActivityData = DangoAbyssModel.Instance.GetCurrentOpenAbyssActivityData();
		if (dungeonConfig == null || currentOpenAbyssActivityData == null)
		{
			return;
		}
		AbyssChallengeData[] abyssChallengeDataList = currentOpenAbyssActivityData.GetAbyssChallengeDataList();
		int i = 0;
		while (i < abyssChallengeDataList.Length)
		{
			AbyssInst? config = abyssChallengeDataList[i].GetConfig();
			int? num = (config != null) ? new int?(config.GetValueOrDefault().InstId) : null;
			int id = dungeonConfig.Value.Id;
			if (num.GetValueOrDefault() == id & num != null)
			{
				bool uiactive = Array.IndexOf<int>(config.Value.RecommendLittleRole(), data.DangoId) >= 0;
				UUIItem item = base.GetItem(7);
				if (item == null)
				{
					return;
				}
				item.SetUIActive(uiactive);
				return;
			}
			else
			{
				i++;
			}
		}
		UUIItem item2 = base.GetItem(7);
		if (item2 == null)
		{
			return;
		}
		item2.SetUIActive(false);
	}

	// Token: 0x060098F6 RID: 39158 RVA: 0x002D5AE4 File Offset: 0x002D3CE4
	private void RefreshToggleState(AbyssDangoItemData data)
	{
		EToggleState state = data.SelectState ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		UUIExtendToggle extendToggle = base.GetExtendToggle(6);
		if (extendToggle == null)
		{
			return;
		}
		extendToggle.SetToggleState(state, false, false, false);
	}

	// Token: 0x060098F7 RID: 39159 RVA: 0x002D5B14 File Offset: 0x002D3D14
	private void RefreshQualitySprite(AbyssDangoItemData data)
	{
		this.RefreshQualitySpriteAsync(data);
	}

	// Token: 0x060098F8 RID: 39160 RVA: 0x002D5B20 File Offset: 0x002D3D20
	private void RefreshQualitySpriteAsync(AbyssDangoItemData data)
	{
		AbyssDangoItem.<>c__DisplayClass13_0 CS$<>8__locals1 = new AbyssDangoItem.<>c__DisplayClass13_0();
		CS$<>8__locals1.<>4__this = this;
		CS$<>8__locals1.data = data;
		UiAsyncTask task = new UiAsyncTask("RefreshQualitySpriteAsync", delegate()
		{
			AbyssDangoItem.<>c__DisplayClass13_0.<<RefreshQualitySpriteAsync>b__0>d <<RefreshQualitySpriteAsync>b__0>d;
			<<RefreshQualitySpriteAsync>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<<RefreshQualitySpriteAsync>b__0>d.<>4__this = CS$<>8__locals1;
			<<RefreshQualitySpriteAsync>b__0>d.<>1__state = -1;
			<<RefreshQualitySpriteAsync>b__0>d.<>t__builder.Start<AbyssDangoItem.<>c__DisplayClass13_0.<<RefreshQualitySpriteAsync>b__0>d>(ref <<RefreshQualitySpriteAsync>b__0>d);
			return <<RefreshQualitySpriteAsync>b__0>d.<>t__builder.Task;
		}, null);
		base.RunAsyncTask(task);
	}

	// Token: 0x060098F9 RID: 39161 RVA: 0x002D5B64 File Offset: 0x002D3D64
	private void RefreshAvatarTexture(AbyssDangoItemData data)
	{
		string formationIcon = DangoAbyssModel.Instance.GetDangoAbyssRoleData(data.DangoId).GetFormationIcon();
		base.SetTextureByPath(formationIcon, base.GetTexture(1), null, null);
	}

	// Token: 0x060098FA RID: 39162 RVA: 0x002D5BA0 File Offset: 0x002D3DA0
	private void RefreshLevelText(AbyssDangoItemData data)
	{
		AbyssDangoRoleData dangoAbyssRoleData = DangoAbyssModel.Instance.GetDangoAbyssRoleData(data.DangoId);
		int level = dangoAbyssRoleData.GetLevel();
		LguiUtil.Instance.SetLocalTextNew(base.GetText(4), "AbyssDango_LV", new <>z__ReadOnlySingleElementList<object>(level.ToString()));
		UUIItem item = base.GetItem(3);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(!dangoAbyssRoleData.GetIfLock());
	}

	// Token: 0x060098FB RID: 39163 RVA: 0x002D5C04 File Offset: 0x002D3E04
	private void RefreshBelongTexture(AbyssDangoItemData data)
	{
		int playerId = data.PlayerId;
		if ((playerId == 0 || DangoAbyssModel.Instance.CheckIsSelf(playerId)) && data.RoleId != 0)
		{
			UUITexture texture = base.GetTexture(2);
			if (texture != null)
			{
				texture.SetUIActive(true);
			}
			base.SetRoleIcon(RoleConfig.Instance.GetRoleConfig(data.RoleId).Value.RoleHeadIconCircle, base.GetTexture(2), data.RoleId, null, null);
			return;
		}
		UUITexture texture2 = base.GetTexture(2);
		if (texture2 == null)
		{
			return;
		}
		texture2.SetUIActive(false);
	}

	// Token: 0x060098FC RID: 39164 RVA: 0x002D5C94 File Offset: 0x002D3E94
	private void RefreshLockItem(AbyssDangoItemData data)
	{
		bool ifLock = DangoAbyssModel.Instance.GetDangoAbyssRoleData(data.DangoId).GetIfLock();
		UUIItem item = base.GetItem(5);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(ifLock);
	}

	// Token: 0x04005B93 RID: 23443
	private AbyssDangoItemData CurrentData = new AbyssDangoItemData();

	// Token: 0x04005B94 RID: 23444
	[Nullable(2)]
	private AbyssDangoCircleQualityItem DangoCircleQualityItem;

	// Token: 0x04005B95 RID: 23445
	[Nullable(2)]
	private CustomPromise QualityItemPromise;

	// Token: 0x04005B96 RID: 23446
	private bool RedDotBindState;

	// Token: 0x020070F7 RID: 28919
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04024CBE RID: 150718
		QualityItem,
		// Token: 0x04024CBF RID: 150719
		AvatarTexture,
		// Token: 0x04024CC0 RID: 150720
		BelongTexture,
		// Token: 0x04024CC1 RID: 150721
		AddCountItem,
		// Token: 0x04024CC2 RID: 150722
		LevelText,
		// Token: 0x04024CC3 RID: 150723
		LockItem,
		// Token: 0x04024CC4 RID: 150724
		SelectToggle,
		// Token: 0x04024CC5 RID: 150725
		LikeItem,
		// Token: 0x04024CC6 RID: 150726
		RedDot
	}
}
