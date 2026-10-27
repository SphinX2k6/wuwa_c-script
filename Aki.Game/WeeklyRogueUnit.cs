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

// Token: 0x02001F6B RID: 8043
[NullableContext(2)]
[Nullable(0)]
public class WeeklyRogueUnit : HudUnitBase
{
	// Token: 0x0600F97E RID: 63870 RVA: 0x003C74E0 File Offset: 0x003C56E0
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

	// Token: 0x0600F97F RID: 63871 RVA: 0x003C75F4 File Offset: 0x003C57F4
	protected override UniTask OnBeforeStartAsync()
	{
		WeeklyRogueUnit.<OnBeforeStartAsync>d__19 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<WeeklyRogueUnit.<OnBeforeStartAsync>d__19>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600F980 RID: 63872 RVA: 0x003C7638 File Offset: 0x003C5838
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

	// Token: 0x0600F981 RID: 63873 RVA: 0x003C7774 File Offset: 0x003C5974
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

	// Token: 0x0600F982 RID: 63874 RVA: 0x003C782C File Offset: 0x003C5A2C
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

	// Token: 0x0600F983 RID: 63875 RVA: 0x003C79F4 File Offset: 0x003C5BF4
	private void RefreshRoleData()
	{
		BattleUiRoleData curRoleData = BattleUiModel.Instance.GetCurRoleData();
		if (curRoleData != null)
		{
			this.BuffComponent = curRoleData.BuffComponent;
		}
	}

	// Token: 0x0600F984 RID: 63876 RVA: 0x003C7A1B File Offset: 0x003C5C1B
	private void OnBattleUiCurRoleDataChanged(int newEntityId, int oldEntityId)
	{
		this.RefreshRoleData();
	}

	// Token: 0x0600F985 RID: 63877 RVA: 0x003C7A23 File Offset: 0x003C5C23
	protected override void OnBeforeHide()
	{
		EventSystem.Instance.Remove<int, int>(EEventName.BattleUiCurRoleDataChanged, new Action<int, int>(this.OnBattleUiCurRoleDataChanged));
	}

	// Token: 0x0600F986 RID: 63878 RVA: 0x003C7A44 File Offset: 0x003C5C44
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

	// Token: 0x0600F987 RID: 63879 RVA: 0x003C7AA4 File Offset: 0x003C5CA4
	protected override UniTask OnBeforeHideAsync()
	{
		WeeklyRogueUnit.<OnBeforeHideAsync>d__27 <OnBeforeHideAsync>d__;
		<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeHideAsync>d__.<>4__this = this;
		<OnBeforeHideAsync>d__.<>1__state = -1;
		<OnBeforeHideAsync>d__.<>t__builder.Start<WeeklyRogueUnit.<OnBeforeHideAsync>d__27>(ref <OnBeforeHideAsync>d__);
		return <OnBeforeHideAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600F988 RID: 63880 RVA: 0x003C7AE7 File Offset: 0x003C5CE7
	private void DestroyPromise()
	{
		if (this.Promise != null)
		{
			this.Promise.SetResult();
			this.Promise = null;
		}
	}

	// Token: 0x0600F989 RID: 63881 RVA: 0x003C7B03 File Offset: 0x003C5D03
	private void DestroyTimer()
	{
		if (this.Timer != null)
		{
			TimerSystem.Instance.Remove(this.Timer);
			this.Timer = null;
		}
	}

	// Token: 0x0600F98A RID: 63882 RVA: 0x003C7B28 File Offset: 0x003C5D28
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

	// Token: 0x0600F98B RID: 63883 RVA: 0x003C7B70 File Offset: 0x003C5D70
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

	// Token: 0x0600F98C RID: 63884 RVA: 0x003C7C26 File Offset: 0x003C5E26
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

	// Token: 0x0600F98D RID: 63885 RVA: 0x003C7C62 File Offset: 0x003C5E62
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

	// Token: 0x04007445 RID: 29765
	private const float CLOSE_ANIM_TIME = 550f;

	// Token: 0x04007446 RID: 29766
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04007447 RID: 29767
	private CombineKeyItem KeyItemPc;

	// Token: 0x04007448 RID: 29768
	private UUITexture BarTex;

	// Token: 0x04007449 RID: 29769
	private UUIItem PointItem;

	// Token: 0x0400744A RID: 29770
	private FRotator PointRotator;

	// Token: 0x0400744B RID: 29771
	private CharacterBuffComponent BuffComponent;

	// Token: 0x0400744C RID: 29772
	private long BuffId;

	// Token: 0x0400744D RID: 29773
	private IActiveBuff Buff;

	// Token: 0x0400744E RID: 29774
	private int BuffHandle;

	// Token: 0x0400744F RID: 29775
	private int ArtifactId;

	// Token: 0x04007450 RID: 29776
	private RogueWeeklyBuffPool? ArtifactConfig;

	// Token: 0x04007451 RID: 29777
	private RogueWeeklyBuffPool? TriggerConfig;

	// Token: 0x04007452 RID: 29778
	private int LoadIconId = -1;

	// Token: 0x04007453 RID: 29779
	private CustomPromise Promise;

	// Token: 0x04007454 RID: 29780
	private TimerHandle Timer;

	// Token: 0x04007455 RID: 29781
	private bool IsPlayWarnAnim;

	// Token: 0x02008567 RID: 34151
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x0402B6F7 RID: 177911
		BarTex,
		// Token: 0x0402B6F8 RID: 177912
		PointItem,
		// Token: 0x0402B6F9 RID: 177913
		IconTex,
		// Token: 0x0402B6FA RID: 177914
		DescText,
		// Token: 0x0402B6FB RID: 177915
		ContentItem,
		// Token: 0x0402B6FC RID: 177916
		AniWarn,
		// Token: 0x0402B6FD RID: 177917
		KeyItem
	}
}
