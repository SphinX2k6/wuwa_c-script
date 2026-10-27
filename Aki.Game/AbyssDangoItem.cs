using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001A23 RID: 6691
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class AbyssDangoItem : GridProxyAbstract<AbyssDangoItemData>
{
	// Token: 0x0600C4E0 RID: 50400 RVA: 0x002CA6CC File Offset: 0x002C88CC
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

	// Token: 0x0600C4E1 RID: 50401 RVA: 0x002CA7D0 File Offset: 0x002C89D0
	protected override UniTask OnBeforeStartAsync()
	{
		AbyssDangoItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<AbyssDangoItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600C4E2 RID: 50402 RVA: 0x002CA80B File Offset: 0x002C8A0B
	private void OnSelectToggleClick(EToggleState toggleState)
	{
		this.CurrentData.OnSelectCallBack(this.CurrentData);
	}

	// Token: 0x0600C4E3 RID: 50403 RVA: 0x002CA823 File Offset: 0x002C8A23
	protected override void OnBeforeDestroy()
	{
		if (this.RedDotBindState)
		{
			RedDotController.Instance.UnBindGivenUi(ERedDotName.RedDotDangoFormationRole, base.GetItem(8), 0);
		}
	}

	// Token: 0x0600C4E4 RID: 50404 RVA: 0x002CA844 File Offset: 0x002C8A44
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

	// Token: 0x0600C4E5 RID: 50405 RVA: 0x002CA8D4 File Offset: 0x002C8AD4
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
				bool uiactive = config.Value.RecommendLittleRole().Contains(data.DangoId);
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

	// Token: 0x0600C4E6 RID: 50406 RVA: 0x002CA9C4 File Offset: 0x002C8BC4
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

	// Token: 0x0600C4E7 RID: 50407 RVA: 0x002CA9F4 File Offset: 0x002C8BF4
	private void RefreshQualitySprite(AbyssDangoItemData data)
	{
		this.RefreshQualitySpriteAsync(data);
	}

	// Token: 0x0600C4E8 RID: 50408 RVA: 0x002CAA00 File Offset: 0x002C8C00
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

	// Token: 0x0600C4E9 RID: 50409 RVA: 0x002CAA44 File Offset: 0x002C8C44
	private void RefreshAvatarTexture(AbyssDangoItemData data)
	{
		string formationIcon = DangoAbyssModel.Instance.GetDangoAbyssRoleData(data.DangoId).GetFormationIcon();
		base.SetTextureByPath(formationIcon, base.GetTexture(1), null, null);
	}

	// Token: 0x0600C4EA RID: 50410 RVA: 0x002CAA80 File Offset: 0x002C8C80
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

	// Token: 0x0600C4EB RID: 50411 RVA: 0x002CAAE4 File Offset: 0x002C8CE4
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

	// Token: 0x0600C4EC RID: 50412 RVA: 0x002CAB74 File Offset: 0x002C8D74
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

	// Token: 0x04005AC4 RID: 23236
	private AbyssDangoItemData CurrentData = new AbyssDangoItemData();

	// Token: 0x04005AC5 RID: 23237
	[Nullable(2)]
	private AbyssDangoCircleQualityItem DangoCircleQualityItem;

	// Token: 0x04005AC6 RID: 23238
	[Nullable(2)]
	private CustomPromise QualityItemPromise;

	// Token: 0x04005AC7 RID: 23239
	private bool RedDotBindState;

	// Token: 0x02007F68 RID: 32616
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04029981 RID: 170369
		QualityItem,
		// Token: 0x04029982 RID: 170370
		AvatarTexture,
		// Token: 0x04029983 RID: 170371
		BelongTexture,
		// Token: 0x04029984 RID: 170372
		AddCountItem,
		// Token: 0x04029985 RID: 170373
		LevelText,
		// Token: 0x04029986 RID: 170374
		LockItem,
		// Token: 0x04029987 RID: 170375
		SelectToggle,
		// Token: 0x04029988 RID: 170376
		LikeItem,
		// Token: 0x04029989 RID: 170377
		RedDot
	}
}
