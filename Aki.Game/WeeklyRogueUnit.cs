using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Module.BattleUi.Views;
using CSharpScript.Game.Module.GenericPrompt;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200142D RID: 5165
[NullableContext(2)]
[Nullable(0)]
public class WeeklyRogueUnit : HudUnitBase
{
	// Token: 0x0600CD9D RID: 52637 RVA: 0x003D2FCC File Offset: 0x003D11CC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 6;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		if (!Info.Instance.IsInTouch())
		{
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(6, typeof(UUIItem)));
		}
	}

	// Token: 0x0600CD9E RID: 52638 RVA: 0x003D30E0 File Offset: 0x003D12E0
	protected override UniTask OnBeforeStartAsync()
	{
		WeeklyRogueUnit.<OnBeforeStartAsync>d__19 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<WeeklyRogueUnit.<OnBeforeStartAsync>d__19>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600CD9F RID: 52639 RVA: 0x003D3124 File Offset: 0x003D1324
	protected override void OnStart()
	{
		base.OnStart();
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		base.InitTweenAnim(5);
		UUIItem item = base.GetItem(4);
		if (item != null)
		{
			item.SetAlpha(1f);
		}
		this.ArtifactId = WeeklyRogueModel.Instance.GetArtifactBuffId();
		if (this.ArtifactId != 0)
		{
			this.ArtifactConfig = WeeklyRogueConfig.Instance.GetRogueWeeklyBuffPool(this.ArtifactId);
		}
		RogueWeeklyCycle? cycleConfig = WeeklyRogueModel.Instance.ActivityData.GetCycleConfig();
		if (cycleConfig != null)
		{
			long? battleBuffIdMap = cycleConfig.Value.GetBattleBuffIdMap(this.ArtifactId);
			long? num = battleBuffIdMap;
			long num2 = 0L;
			if ((num.GetValueOrDefault() == num2 & num != null) || battleBuffIdMap == null)
			{
				battleBuffIdMap = cycleConfig.Value.GetBattleBuffIdMap(0);
			}
			this.BuffId = battleBuffIdMap.GetValueOrDefault();
		}
		this.BarTex = base.GetTexture(0);
		this.PointItem = base.GetItem(1);
		this.PointRotator = new FRotator(0f, 0f, 0f);
		if (!Info.Instance.IsInTouch())
		{
			CombineKeyItem keyItemPc = this.KeyItemPc;
			if (keyItemPc != null)
			{
				keyItemPc.SetUiActive(true);
			}
		}
		this.RefreshIcon();
	}

	// Token: 0x0600CDA0 RID: 52640 RVA: 0x003D3260 File Offset: 0x003D1460
	private void RefreshIcon()
	{
		UUITexture iconTexture = base.GetTexture(2);
		iconTexture.SetUIActive(false);
		string text = (this.ArtifactConfig != null) ? this.ArtifactConfig.GetValueOrDefault().ButtonIcon : null;
		if (!string.IsNullOrEmpty(text))
		{
			this.LoadIconId = ResourceSystem.Instance.LoadAsync<UTexture2D>(text, delegate([Nullable(2)] UTexture2D iconTextureData, string _)
			{
				this.LoadIconId = -1;
				if (iconTextureData == null)
				{
					return;
				}
				iconTexture.SetUIActive(true);
				iconTexture.SetTexture(iconTextureData);
			}, 103, this.MemoryTag);
			return;
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.WeeklyRogue;
		ELogAuthor author = ELogAuthor.CFT;
		string message = "神器图标路径为空";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("神器Id", this.ArtifactId);
		instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x0600CDA1 RID: 52641 RVA: 0x003D3318 File Offset: 0x003D1518
	protected override void OnBeforeShow()
	{
		base.OnBeforeShow();
		EventSystem.Instance.Add<int, int>(EEventName.BattleUiCurRoleDataChanged, new Action<int, int>(this.OnBattleUiCurRoleDataChanged));
		this.RefreshRoleData();
		this.LevelSequencePlayer.PlaySequencePurely("Start", false, false, null, null, false);
		this.RefreshTriggerConfig();
		string text = (this.TriggerConfig != null) ? this.TriggerConfig.GetValueOrDefault().BuffTriggerActionName : null;
		if (!string.IsNullOrEmpty(text))
		{
			CombineKeyItem keyItemPc = this.KeyItemPc;
			if (keyItemPc != null)
			{
				keyItemPc.RefreshAction(text);
			}
			CombineKeyItem keyItemPc2 = this.KeyItemPc;
			if (keyItemPc2 != null)
			{
				keyItemPc2.SetUiActive(true);
			}
		}
		else
		{
			CombineKeyItem keyItemPc3 = this.KeyItemPc;
			if (keyItemPc3 != null)
			{
				keyItemPc3.SetUiActive(false);
			}
		}
		int? num = (this.TriggerConfig != null) ? new int?(this.TriggerConfig.GetValueOrDefault().BuffTriggerTagId) : null;
		if (num == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.WeeklyRogue;
			ELogAuthor author = ELogAuthor.CFT;
			string message = "神器触发tag为空";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("神器Id", this.ArtifactId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		RogueWeekTag? rogueWeekTagConfig = WeeklyRogueConfig.Instance.GetRogueWeekTagConfig(num.Value);
		if (rogueWeekTagConfig == null)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.WeeklyRogue;
			ELogAuthor author2 = ELogAuthor.CFT;
			string message2 = "神器触发tag缺少配置";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("BuffTriggerTagId", num);
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return;
		}
		string name = rogueWeekTagConfig.Value.Name;
		UUIText text2 = base.GetText(3);
		LguiUtil.Instance.SetLocalTextNew(text2, name, Array.Empty<object>());
		string text3 = ConfigMultiTextLang.GetLocalTextNew(name, null) ?? name;
		GenericPromptController.Instance.ShowPromptByCode("WeeklyRogueUseArtifact", new object[]
		{
			text3
		});
	}

	// Token: 0x0600CDA2 RID: 52642 RVA: 0x003D34E0 File Offset: 0x003D16E0
	private void RefreshRoleData()
	{
		BattleUiRoleData curRoleData = BattleUiModel.Instance.GetCurRoleData();
		if (curRoleData != null)
		{
			this.BuffComponent = curRoleData.BuffComponent;
		}
	}

	// Token: 0x0600CDA3 RID: 52643 RVA: 0x003D3507 File Offset: 0x003D1707
	private void OnBattleUiCurRoleDataChanged(int newEntityId, int oldEntityId)
	{
		this.RefreshRoleData();
	}

	// Token: 0x0600CDA4 RID: 52644 RVA: 0x003D350F File Offset: 0x003D170F
	protected override void OnBeforeHide()
	{
		EventSystem.Instance.Remove<int, int>(EEventName.BattleUiCurRoleDataChanged, new Action<int, int>(this.OnBattleUiCurRoleDataChanged));
	}

	// Token: 0x0600CDA5 RID: 52645 RVA: 0x003D3530 File Offset: 0x003D1730
	protected override void OnBeforeDestroy()
	{
		base.StopTweenAnim(5);
		base.OnBeforeDestroy();
		LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
		if (levelSequencePlayer != null)
		{
			levelSequencePlayer.Clear();
		}
		this.LevelSequencePlayer = null;
		if (this.LoadIconId != -1)
		{
			ResourceSystem.Instance.CancelAsyncLoad(this.LoadIconId);
			this.LoadIconId = -1;
		}
		this.DestroyPromise();
		this.DestroyTimer();
	}

	// Token: 0x0600CDA6 RID: 52646 RVA: 0x003D3590 File Offset: 0x003D1790
	protected override UniTask OnBeforeHideAsync()
	{
		WeeklyRogueUnit.<OnBeforeHideAsync>d__27 <OnBeforeHideAsync>d__;
		<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeHideAsync>d__.<>4__this = this;
		<OnBeforeHideAsync>d__.<>1__state = -1;
		<OnBeforeHideAsync>d__.<>t__builder.Start<WeeklyRogueUnit.<OnBeforeHideAsync>d__27>(ref <OnBeforeHideAsync>d__);
		return <OnBeforeHideAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600CDA7 RID: 52647 RVA: 0x003D35D3 File Offset: 0x003D17D3
	private void DestroyPromise()
	{
		if (this.Promise != null)
		{
			this.Promise.SetResult();
			this.Promise = null;
		}
	}

	// Token: 0x0600CDA8 RID: 52648 RVA: 0x003D35EF File Offset: 0x003D17EF
	private void DestroyTimer()
	{
		if (this.Timer != null)
		{
			TimerSystem.Instance.Remove(this.Timer);
			this.Timer = null;
		}
	}

	// Token: 0x0600CDA9 RID: 52649 RVA: 0x003D3614 File Offset: 0x003D1814
	private void RefreshTriggerConfig()
	{
		List<int> buffIdListByType = WeeklyRogueModel.Instance.GetBuffIdListByType(EWeeklyRogueBuffType.Modifier);
		if (buffIdListByType.Count > 0)
		{
			this.TriggerConfig = WeeklyRogueConfig.Instance.GetRogueWeeklyBuffPool(buffIdListByType[0]);
			return;
		}
		this.TriggerConfig = this.ArtifactConfig;
	}

	// Token: 0x0600CDAA RID: 52650 RVA: 0x003D365C File Offset: 0x003D185C
	public override void Tick(float delta)
	{
		base.Tick(delta);
		if (!base.IsShowOrShowing)
		{
			return;
		}
		if (this.Buff != null)
		{
			CharacterBuffComponent buffComponent = this.BuffComponent;
			if (((buffComponent != null) ? buffComponent.GetBuffByHandle(this.BuffHandle) : null) != null)
			{
				goto IL_68;
			}
		}
		CharacterBuffComponent buffComponent2 = this.BuffComponent;
		this.Buff = ((buffComponent2 != null) ? buffComponent2.GetBuffById(this.BuffId) : null);
		IActiveBuff buff = this.Buff;
		this.BuffHandle = ((buff != null) ? buff.Handle : 0);
		IL_68:
		if (this.Buff != null)
		{
			float remainDuration = this.Buff.GetRemainDuration();
			this.SetProgress(remainDuration / this.Buff.Duration);
			this.PlayWarnAnim(remainDuration < 1f);
			return;
		}
		this.SetProgress(0f);
	}

	// Token: 0x0600CDAB RID: 52651 RVA: 0x003D3712 File Offset: 0x003D1912
	private void SetProgress(float progress)
	{
		this.PointRotator.Yaw = progress * -360f;
		UUIItem pointItem = this.PointItem;
		if (pointItem != null)
		{
			pointItem.SetUIRelativeRotation(this.PointRotator);
		}
		UUITexture barTex = this.BarTex;
		if (barTex == null)
		{
			return;
		}
		barTex.SetFillAmount(progress);
	}

	// Token: 0x0600CDAC RID: 52652 RVA: 0x003D374E File Offset: 0x003D194E
	private void PlayWarnAnim(bool bPlay)
	{
		if (this.IsPlayWarnAnim == bPlay)
		{
			return;
		}
		this.IsPlayWarnAnim = bPlay;
		if (bPlay)
		{
			base.PlayTweenAnim(5);
			return;
		}
		base.StopTweenAnim(5);
		UUIItem item = base.GetItem(4);
		if (item == null)
		{
			return;
		}
		item.SetAlpha(1f);
	}

	// Token: 0x04007526 RID: 29990
	private const float CLOSE_ANIM_TIME = 550f;

	// Token: 0x04007527 RID: 29991
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04007528 RID: 29992
	private CombineKeyItem KeyItemPc;

	// Token: 0x04007529 RID: 29993
	private UUITexture BarTex;

	// Token: 0x0400752A RID: 29994
	private UUIItem PointItem;

	// Token: 0x0400752B RID: 29995
	private FRotator PointRotator;

	// Token: 0x0400752C RID: 29996
	private CharacterBuffComponent BuffComponent;

	// Token: 0x0400752D RID: 29997
	private long BuffId;

	// Token: 0x0400752E RID: 29998
	private IActiveBuff Buff;

	// Token: 0x0400752F RID: 29999
	private int BuffHandle;

	// Token: 0x04007530 RID: 30000
	private int ArtifactId;

	// Token: 0x04007531 RID: 30001
	private RogueWeeklyBuffPool? ArtifactConfig;

	// Token: 0x04007532 RID: 30002
	private RogueWeeklyBuffPool? TriggerConfig;

	// Token: 0x04007533 RID: 30003
	private int LoadIconId = -1;

	// Token: 0x04007534 RID: 30004
	private CustomPromise Promise;

	// Token: 0x04007535 RID: 30005
	private TimerHandle Timer;

	// Token: 0x04007536 RID: 30006
	private bool IsPlayWarnAnim;

	// Token: 0x020076EC RID: 30444
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04026A1B RID: 158235
		BarTex,
		// Token: 0x04026A1C RID: 158236
		PointItem,
		// Token: 0x04026A1D RID: 158237
		IconTex,
		// Token: 0x04026A1E RID: 158238
		DescText,
		// Token: 0x04026A1F RID: 158239
		ContentItem,
		// Token: 0x04026A20 RID: 158240
		AniWarn,
		// Token: 0x04026A21 RID: 158241
		KeyItem
	}
}
