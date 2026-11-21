using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Effect;
using CSharpScript.Game.Module.Plot;
using CSharpScript.Game.Ui;
using CSharpScript.Game.Utils;
using UnrealEngine;

// Token: 0x02001750 RID: 5968
[NullableContext(1)]
[Nullable(0)]
public class MotorcycleLevelUpView : UiViewBase
{
	// Token: 0x0600E7C8 RID: 59336 RVA: 0x0043E0D0 File Offset: 0x0043C2D0
	public MotorcycleLevelUpView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600E7C9 RID: 59337 RVA: 0x0043E108 File Offset: 0x0043C308
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem))
		};
	}

	// Token: 0x0600E7CA RID: 59338 RVA: 0x0043E190 File Offset: 0x0043C390
	protected override void OnStart()
	{
		ILevelUpViewViedData cacheData = MotorcycleDevelopModel.Instance.GetCacheData();
		MotorcycleDevelopModel.Instance.ClearCacheData();
		this.IsLevelUp = (cacheData.CurLevel > cacheData.PreLevel);
		this.IsExpUp = cacheData.AddExp;
		this.IsOverLevel = false;
		this.IsOverLoop = false;
		this.CurrentLevel = cacheData.CurLevel;
		this.IsLevelUpAnimeDown = !this.IsLevelUp;
		base.GetText(0).SetText(this.IsExpUp ? cacheData.PreLevel.ToString() : cacheData.CurLevel.ToString(), true);
		this.ShowingExp = (float)(this.IsExpUp ? cacheData.PreExp : cacheData.CurExp);
		this.CurMaxExp = (float)MotorConfig.Instance.GetMotorLevelConfig(cacheData.CurLevel).Value.Exp;
		float num;
		if (cacheData.PreLevel == 1)
		{
			num = this.CurMaxExp;
		}
		else
		{
			num = (float)MotorConfig.Instance.GetMotorLevelConfig(cacheData.PreLevel).Value.Exp;
		}
		this.PreMaxExp = (this.IsExpUp ? num : this.CurMaxExp);
		this.TargetExp = (this.IsLevelUp ? ((float)cacheData.CurExp + this.PreMaxExp) : ((float)cacheData.CurExp));
		this.AddExp = (this.TargetExp - this.ShowingExp) / (float)this.AnimeTime;
		base.GetItem(3).SetUIActive(true);
		base.GetItem(4).SetUIActive(false);
		this.RefreshExp();
		if (this.IsLevelUp)
		{
			this.UiViewSequence.AddSequenceFinishEvent("LevelUp", delegate(string _)
			{
				this.IsLevelUpAnimeDown = true;
				this.LevelUpTryCloseMe();
			}, false);
		}
	}

	// Token: 0x0600E7CB RID: 59339 RVA: 0x0043E34A File Offset: 0x0043C54A
	private void LevelUpTryCloseMe()
	{
		if (this.IsLevelUpAnimeDown && this.ShowingExp >= this.TargetExp)
		{
			this.TryCloseMe();
		}
	}

	// Token: 0x0600E7CC RID: 59340 RVA: 0x0043E368 File Offset: 0x0043C568
	private void TryCloseMe()
	{
		if (this.IsInClosing)
		{
			return;
		}
		this.IsInClosing = true;
		base.CloseMe(null);
	}

	// Token: 0x0600E7CD RID: 59341 RVA: 0x0043E381 File Offset: 0x0043C581
	protected override void OnBeforeShow()
	{
		if (this.IsLevelUp)
		{
			this.PlayLevelUpEffect();
		}
	}

	// Token: 0x0600E7CE RID: 59342 RVA: 0x0043E391 File Offset: 0x0043C591
	protected override void OnAfterShow()
	{
		if (this.IsExpUp)
		{
			this.AnimePlayer = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.BarExpAnime), 20f, 1f, null, null, true);
		}
	}

	// Token: 0x17001627 RID: 5671
	// (get) Token: 0x0600E7CF RID: 59343 RVA: 0x0043E3C4 File Offset: 0x0043C5C4
	private bool GetIsOverLoop
	{
		get
		{
			return this.IsLevelUp && this.ShowingExp >= this.PreMaxExp;
		}
	}

	// Token: 0x0600E7D0 RID: 59344 RVA: 0x0043E3E4 File Offset: 0x0043C5E4
	private void RefreshExp()
	{
		if (this.AnimePlayer != null && !this.IsOverLoop && this.GetIsOverLoop)
		{
			this.IsOverLoop = true;
			base.GetText(0).SetText(this.CurrentLevel.ToString(), true);
			base.GetItem(3).SetUIActive(false);
			base.GetItem(4).SetUIActive(true);
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence != null)
			{
				uiViewSequence.PlaySequence("LevelUp", false, null);
			}
		}
		float num = this.IsOverLoop ? (this.ShowingExp - this.PreMaxExp) : this.ShowingExp;
		float num2 = this.IsOverLoop ? this.CurMaxExp : this.PreMaxExp;
		base.GetTexture(1).SetFillAmount(num / num2);
		this.CurrentRotator.Yaw = -360f * (num / num2);
		UUIItem item = base.GetItem(2);
		FRotator frotator = this.CurrentRotator.ToUeRotator();
		item.SetUIRelativeRotation(frotator);
		if (this.AnimePlayer != null && num > num2 && !this.IsOverLevel)
		{
			this.IsOverLevel = true;
		}
	}

	// Token: 0x0600E7D1 RID: 59345 RVA: 0x0043E4F0 File Offset: 0x0043C6F0
	private void BarExpAnime(float delta)
	{
		this.ShowingExp += this.AddExp * delta;
		if (this.ShowingExp >= this.TargetExp)
		{
			this.ShowingExp = this.TargetExp;
			TimerSystem.GameplayTimeInstance.Remove(this.AnimePlayer);
			this.LevelUpTryCloseMe();
		}
		this.RefreshExp();
	}

	// Token: 0x0600E7D2 RID: 59346 RVA: 0x0043E549 File Offset: 0x0043C749
	protected override void OnBeforeDestroy()
	{
		if (this.AnimePlayer != null && TimerSystem.GameplayTimeInstance.Has(this.AnimePlayer))
		{
			TimerSystem.GameplayTimeInstance.Remove(this.AnimePlayer);
		}
		this.RecycleEffect();
	}

	// Token: 0x0600E7D3 RID: 59347 RVA: 0x0043E57C File Offset: 0x0043C77C
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<PlotInfo>(EEventName.PlotNetworkStart, new Action<PlotInfo>(this.OnSequenceNetworkStart));
	}

	// Token: 0x0600E7D4 RID: 59348 RVA: 0x0043E59A File Offset: 0x0043C79A
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.PlotNetworkStart, new Action<PlotInfo>(this.OnSequenceNetworkStart));
	}

	// Token: 0x0600E7D5 RID: 59349 RVA: 0x0043E5B8 File Offset: 0x0043C7B8
	private void OnSequenceNetworkStart(PlotInfo plotInfo)
	{
		this.TryCloseMe();
	}

	// Token: 0x0600E7D6 RID: 59350 RVA: 0x0043E5C0 File Offset: 0x0043C7C0
	private void PlayLevelUpEffect()
	{
		if (Global.BaseCharacter == null)
		{
			return;
		}
		string effectPath = EffectUtil.GetEffectPath("WorldLevelUpEffect");
		if (effectPath == null || effectPath.Length == 0)
		{
			return;
		}
		TsBaseCharacter baseCharacter = Global.BaseCharacter;
		FTransformDouble value = baseCharacter.D_GetTransform();
		float capsuleHalfHeight = baseCharacter.CapsuleComponent.CapsuleHalfHeight;
		FVectorDouble location = value.GetLocation();
		location.Z -= (double)capsuleHalfHeight;
		value.SetLocation(location);
		if (!EffectSystem.Instance.IsValid(this.EffectHandle))
		{
			EffectSystem instance = EffectSystem.Instance;
			UObject world = GlobalData.World;
			FTransformDouble? ftransformDouble = new FTransformDouble?(value);
			this.EffectHandle = instance.SpawnUnloopedEffect(world, ftransformDouble, effectPath, "[MotorcycleLevelUpView.PlayLevelUpEffect]", null, EEffectType.Scene, null, null, null, false, false);
			if (!EffectSystem.Instance.IsValid(this.EffectHandle))
			{
				this.EffectHandle = 0;
			}
		}
	}

	// Token: 0x0600E7D7 RID: 59351 RVA: 0x0043E678 File Offset: 0x0043C878
	private void RecycleEffect()
	{
		if (EffectSystem.Instance.IsValid(this.EffectHandle))
		{
			EffectSystem.Instance.StopEffectById(this.EffectHandle, "[MotorcycleLevelUpView.RecycleEffect]", true, null);
			this.EffectHandle = 0;
		}
	}

	// Token: 0x04008422 RID: 33826
	private int EffectHandle;

	// Token: 0x04008423 RID: 33827
	private bool IsLevelUp;

	// Token: 0x04008424 RID: 33828
	private bool IsExpUp;

	// Token: 0x04008425 RID: 33829
	private bool IsOverLevel;

	// Token: 0x04008426 RID: 33830
	private bool IsOverLoop;

	// Token: 0x04008427 RID: 33831
	private float ShowingExp;

	// Token: 0x04008428 RID: 33832
	private float PreMaxExp;

	// Token: 0x04008429 RID: 33833
	private float TargetExp;

	// Token: 0x0400842A RID: 33834
	private float CurMaxExp;

	// Token: 0x0400842B RID: 33835
	private float AddExp;

	// Token: 0x0400842C RID: 33836
	private int CurrentLevel;

	// Token: 0x0400842D RID: 33837
	private bool IsLevelUpAnimeDown;

	// Token: 0x0400842E RID: 33838
	[Nullable(2)]
	private TimerHandle AnimePlayer;

	// Token: 0x0400842F RID: 33839
	private bool IsInClosing;

	// Token: 0x04008430 RID: 33840
	private readonly int AnimeTime = ConfigCommonParamById.GetIntConfig("ExpDisplayTime").Value;

	// Token: 0x04008431 RID: 33841
	private readonly Rotator CurrentRotator = Rotator.Create();

	// Token: 0x02007921 RID: 31009
	[NullableContext(0)]
	private class EChildType
	{
		// Token: 0x0402743E RID: 160830
		public const int LevelTxt = 0;

		// Token: 0x0402743F RID: 160831
		public const int BarExp = 1;

		// Token: 0x04027440 RID: 160832
		public const int ArrowItem = 2;

		// Token: 0x04027441 RID: 160833
		public const int ExpUpItem = 3;

		// Token: 0x04027442 RID: 160834
		public const int LevelUpItem = 4;
	}
}
