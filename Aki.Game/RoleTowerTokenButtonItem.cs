using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi.Views;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001D09 RID: 7433
[NullableContext(1)]
[Nullable(0)]
public class RoleTowerTokenButtonItem : UiPanelBase
{
	// Token: 0x06012656 RID: 75350 RVA: 0x0056F7E4 File Offset: 0x0056D9E4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUISprite)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem))
		};
		if (!Info.Instance.IsInTouch())
		{
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(8, typeof(UUIItem)));
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(9, typeof(UUIItem)));
		}
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnClickToken))
		};
	}

	// Token: 0x06012657 RID: 75351 RVA: 0x0056F914 File Offset: 0x0056DB14
	protected override UniTask OnBeforeStartAsync()
	{
		RoleTowerTokenButtonItem.<OnBeforeStartAsync>d__14 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RoleTowerTokenButtonItem.<OnBeforeStartAsync>d__14>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06012658 RID: 75352 RVA: 0x0056F958 File Offset: 0x0056DB58
	protected override void OnStart()
	{
		UUIItem rootItem = base.GetRootItem();
		if (rootItem != null)
		{
			this.SequencePlayer = new UiSequencePlayer(rootItem);
		}
		this.Refresh();
		if (this.CdTickHandle == null)
		{
			this.CdTickHandle = TimerSystem.RealTimeInstance.Forever(delegate(float _)
			{
				this.RefreshCdDisplay();
			}, 100f, 1f, null, null, true);
		}
		EventSystem.Instance.Add<int>(EEventName.RoleTowerLevelUpdate, new Action<int>(this.OnEquipTokenMaybeChanged));
		EventSystem.Instance.Add(EEventName.RoleTowerItemUpdate, new Action(this.OnItemCountUpdated));
	}

	// Token: 0x06012659 RID: 75353 RVA: 0x0056F9EA File Offset: 0x0056DBEA
	protected override void OnBeforeShow()
	{
		this.Refresh();
	}

	// Token: 0x0601265A RID: 75354 RVA: 0x0056F9F2 File Offset: 0x0056DBF2
	protected override void OnAfterShow()
	{
		this.Refresh();
	}

	// Token: 0x0601265B RID: 75355 RVA: 0x0056F9FC File Offset: 0x0056DBFC
	protected override void OnBeforeDestroy()
	{
		if (this.CdTickHandle != null)
		{
			TimerSystem.RealTimeInstance.Remove(this.CdTickHandle);
			this.CdTickHandle = null;
		}
		UiSequencePlayer sequencePlayer = this.SequencePlayer;
		if (sequencePlayer != null)
		{
			sequencePlayer.Clear();
		}
		this.SequencePlayer = null;
		CombineKeyItem keyItemLeft = this.KeyItemLeft;
		if (keyItemLeft != null)
		{
			keyItemLeft.Destroy(null);
		}
		this.KeyItemLeft = null;
		CombineKeyItem keyItemRight = this.KeyItemRight;
		if (keyItemRight != null)
		{
			keyItemRight.Destroy(null);
		}
		this.KeyItemRight = null;
		EventSystem.Instance.Remove(EEventName.RoleTowerLevelUpdate, new Action<int>(this.OnEquipTokenMaybeChanged));
		EventSystem.Instance.Remove(EEventName.RoleTowerItemUpdate, new Action(this.OnItemCountUpdated));
	}

	// Token: 0x0601265C RID: 75356 RVA: 0x0056FAAB File Offset: 0x0056DCAB
	private void OnEquipTokenMaybeChanged(int stageId)
	{
		this.Refresh();
	}

	// Token: 0x0601265D RID: 75357 RVA: 0x0056FAB3 File Offset: 0x0056DCB3
	private void OnItemCountUpdated()
	{
		this.Refresh();
	}

	// Token: 0x0601265E RID: 75358 RVA: 0x0056FABC File Offset: 0x0056DCBC
	public void Refresh()
	{
		int equipTokenId = RoleTowerModel.Instance.GetEquipTokenId();
		RoleTowerToken? roleTowerToken = (equipTokenId > 0) ? RoleTowerModel.Instance.GetTokenCfg(equipTokenId) : null;
		int num = (roleTowerToken != null) ? RoleTowerModel.Instance.GetItemCount(roleTowerToken.Value.ItemId) : 0;
		bool flag = equipTokenId > 0 && roleTowerToken != null;
		UUIItem rootItem = base.GetRootItem();
		if (rootItem != null)
		{
			rootItem.SetUIActive(flag);
		}
		if (!flag)
		{
			return;
		}
		UUITexture texture = base.GetTexture(1);
		ItemConfig itemConfigData = InventoryConfig.Instance.GetItemConfigData(roleTowerToken.Value.ItemId);
		if (texture != null && itemConfigData != null)
		{
			base.SetTextureByPath(itemConfigData.IconMiddle ?? string.Empty, texture, null, null);
		}
		UUIText text = base.GetText(2);
		if (text != null)
		{
			text.SetText(num.ToString(), true);
		}
		this.RefreshKeyItem();
		this.RefreshCdDisplay();
	}

	// Token: 0x0601265F RID: 75359 RVA: 0x0056FBB4 File Offset: 0x0056DDB4
	private void RefreshKeyItem()
	{
		if (this.KeyItemLeft == null && this.KeyItemRight == null)
		{
			return;
		}
		bool flag = Info.Instance.IsInGamepad();
		CombineKeyItem keyItemLeft = this.KeyItemLeft;
		if (keyItemLeft != null)
		{
			keyItemLeft.SetActive(!flag);
		}
		CombineKeyItem keyItemRight = this.KeyItemRight;
		if (keyItemRight != null)
		{
			keyItemRight.SetActive(flag);
		}
		if (flag)
		{
			CombineKeyItem keyItemRight2 = this.KeyItemRight;
			if (keyItemRight2 == null)
			{
				return;
			}
			keyItemRight2.RefreshAction("切换角色4");
			return;
		}
		else
		{
			CombineKeyItem keyItemLeft2 = this.KeyItemLeft;
			if (keyItemLeft2 == null)
			{
				return;
			}
			keyItemLeft2.RefreshAction("切换角色4");
			return;
		}
	}

	// Token: 0x06012660 RID: 75360 RVA: 0x0056FC34 File Offset: 0x0056DE34
	private double GetCurTokenCdMs()
	{
		int equipTokenId = RoleTowerModel.Instance.GetEquipTokenId();
		RoleTowerToken? roleTowerToken = (equipTokenId > 0) ? RoleTowerModel.Instance.GetTokenCfg(equipTokenId) : null;
		if (roleTowerToken == null)
		{
			return 0.0;
		}
		return (double)roleTowerToken.Value.UseCd * 1000.0;
	}

	// Token: 0x06012661 RID: 75361 RVA: 0x0056FC94 File Offset: 0x0056DE94
	private void RefreshCdDisplay()
	{
		double serverCombatStopTime = Time.Instance.ServerCombatStopTime;
		bool flag = RoleTowerModel.Instance.GetTokenCdEndTime() > serverCombatStopTime;
		UUIItem item = base.GetItem(3);
		if (item != null)
		{
			item.SetUIActive(flag);
		}
		UUISprite sprite = base.GetSprite(4);
		if (sprite != null)
		{
			sprite.SetUIActive(flag);
		}
		int equipTokenId = RoleTowerModel.Instance.GetEquipTokenId();
		RoleTowerToken? roleTowerToken = (equipTokenId > 0) ? RoleTowerModel.Instance.GetTokenCfg(equipTokenId) : null;
		bool flag2 = roleTowerToken == null || RoleTowerModel.Instance.GetItemCount(roleTowerToken.Value.ItemId) <= 0;
		UUITexture texture = base.GetTexture(1);
		if (texture != null)
		{
			texture.SetAlpha((flag || flag2) ? 0.3f : 1f);
		}
		if (this.WasInCd && !flag && !flag2)
		{
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.PlayOrReplaySequenceByName("Get", false, null);
			}
		}
		this.WasInCd = flag;
		if (!flag)
		{
			return;
		}
		double num = RoleTowerModel.Instance.GetTokenCdEndTime() - serverCombatStopTime;
		UUIText text = base.GetText(5);
		if (text != null)
		{
			text.SetText(((int)Math.Ceiling(num / 1000.0)).ToString(), true);
		}
		double curTokenCdMs = this.GetCurTokenCdMs();
		float value = (curTokenCdMs > 0.0) ? ((float)(num / curTokenCdMs)) : 0f;
		if (sprite != null)
		{
			sprite.SetFillAmount(Math.Clamp(value, 0f, 1f));
		}
	}

	// Token: 0x06012662 RID: 75362 RVA: 0x0056FE10 File Offset: 0x0056E010
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		UUIButtonComponent button = base.GetButton(0);
		UUIItem uuiitem = (button != null) ? button.GetRootComponent() : null;
		if (uuiitem == null)
		{
			return null;
		}
		return new UUIItem[]
		{
			uuiitem,
			uuiitem
		};
	}

	// Token: 0x06012663 RID: 75363 RVA: 0x0056FE44 File Offset: 0x0056E044
	public void TriggerByKey()
	{
		this.OnClickToken();
	}

	// Token: 0x06012664 RID: 75364 RVA: 0x0056FE4C File Offset: 0x0056E04C
	private unsafe void OnClickToken()
	{
		int equipTokenId = RoleTowerModel.Instance.GetEquipTokenId();
		if (equipTokenId <= 0)
		{
			return;
		}
		EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
		WorldEntity worldEntity = (getCurrentEntity != null) ? getCurrentEntity.Entity : null;
		bool flag;
		if (worldEntity == null)
		{
			flag = false;
		}
		else
		{
			BaseTagComponent component = worldEntity.GetComponent<BaseTagComponent>();
			flag = ((component != null) ? new bool?(component.HasTag(GameplayTagDefine.EGameplayTagId["系统.功能.角色爬塔.输入限制.禁用遗物"])) : null).GetValueOrDefault();
		}
		if (flag)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("RoleTowerToken_Disabled", Array.Empty<object>());
			return;
		}
		RoleTowerToken? tokenCfg = RoleTowerModel.Instance.GetTokenCfg(equipTokenId);
		if (tokenCfg == null)
		{
			return;
		}
		if (RoleTowerModel.Instance.GetItemCount(tokenCfg.Value.ItemId) <= 0)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("RoleTowerToken_UseCountEmpty", Array.Empty<object>());
			return;
		}
		if (RoleTowerModel.Instance.GetTokenCdEndTime() > Time.Instance.ServerCombatStopTime)
		{
			return;
		}
		RoleTowerModel.Instance.SetTokenCdEndTime(Time.Instance.ServerCombatStopTime + this.GetCurTokenCdMs());
		this.RefreshCdDisplay();
		RoleTowerController.Instance.ConsumeItemRequest(tokenCfg.Value.ItemId).Forget();
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Temp;
		ELogAuthor author = ELogAuthor.LJQ;
		string message = "RoleTower.TokenButton 释放信物(四号位)";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("tokenId", equipTokenId);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("itemId", tokenCfg.Value.ItemId);
		instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
	}

	// Token: 0x0400A046 RID: 41030
	public const int TokenSlotPosition = 3;

	// Token: 0x0400A047 RID: 41031
	public const string TokenButtonResourceId = "BtnToken";

	// Token: 0x0400A048 RID: 41032
	private const string TokenActionName = "切换角色4";

	// Token: 0x0400A049 RID: 41033
	private const float CdTickIntervalMs = 100f;

	// Token: 0x0400A04A RID: 41034
	[Nullable(2)]
	private TimerHandle CdTickHandle;

	// Token: 0x0400A04B RID: 41035
	private const float CdIconAlpha = 0.3f;

	// Token: 0x0400A04C RID: 41036
	private const string CdFinishSequenceName = "Get";

	// Token: 0x0400A04D RID: 41037
	private bool WasInCd;

	// Token: 0x0400A04E RID: 41038
	[Nullable(2)]
	private UiSequencePlayer SequencePlayer;

	// Token: 0x0400A04F RID: 41039
	[Nullable(2)]
	private CombineKeyItem KeyItemLeft;

	// Token: 0x0400A050 RID: 41040
	[Nullable(2)]
	private CombineKeyItem KeyItemRight;

	// Token: 0x0400A051 RID: 41041
	private const string DisableTokenTagName = "系统.功能.角色爬塔.输入限制.禁用遗物";

	// Token: 0x02008037 RID: 32823
	[NullableContext(0)]
	private static class EChildType
	{
		// Token: 0x040297CC RID: 169932
		public const int Btn = 0;

		// Token: 0x040297CD RID: 169933
		public const int TexIcon = 1;

		// Token: 0x040297CE RID: 169934
		public const int TxtCount = 2;

		// Token: 0x040297CF RID: 169935
		public const int PnlCdMask = 3;

		// Token: 0x040297D0 RID: 169936
		public const int SprBgFill = 4;

		// Token: 0x040297D1 RID: 169937
		public const int TxtCd = 5;

		// Token: 0x040297D2 RID: 169938
		public const int PnlCount = 6;

		// Token: 0x040297D3 RID: 169939
		public const int PnlEmpty = 7;

		// Token: 0x040297D4 RID: 169940
		public const int TouchMax = 8;
	}

	// Token: 0x02008038 RID: 32824
	[NullableContext(0)]
	private static class EDesktopChildType
	{
		// Token: 0x040297D5 RID: 169941
		public const int KeyItemLeft = 8;

		// Token: 0x040297D6 RID: 169942
		public const int KeyItemRight = 9;
	}
}
