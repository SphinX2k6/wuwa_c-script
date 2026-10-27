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

// Token: 0x0200226C RID: 8812
[NullableContext(1)]
[Nullable(0)]
public class MotorcycleLevelUpView : UiViewBase
{
	// Token: 0x06011332 RID: 70450 RVA: 0x004314C4 File Offset: 0x0042F6C4
	public MotorcycleLevelUpView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06011333 RID: 70451 RVA: 0x004314FC File Offset: 0x0042F6FC
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

	// Token: 0x06011334 RID: 70452 RVA: 0x00431584 File Offset: 0x0042F784
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

	// Token: 0x06011335 RID: 70453 RVA: 0x0043173E File Offset: 0x0042F93E
	private void LevelUpTryCloseMe()
	{
		if (this.IsLevelUpAnimeDown && this.ShowingExp >= this.TargetExp)
		{
			this.TryCloseMe();
		}
	}

	// Token: 0x06011336 RID: 70454 RVA: 0x0043175C File Offset: 0x0042F95C
	private void TryCloseMe()
	{
		if (this.IsInClosing)
		{
			return;
		}
		this.IsInClosing = true;
		base.CloseMe(null);
	}

	// Token: 0x06011337 RID: 70455 RVA: 0x00431775 File Offset: 0x0042F975
	protected override void OnBeforeShow()
	{
		if (this.IsLevelUp)
		{
			this.PlayLevelUpEffect();
		}
	}

	// Token: 0x06011338 RID: 70456 RVA: 0x00431785 File Offset: 0x0042F985
	protected override void OnAfterShow()
	{
		if (this.IsExpUp)
		{
			this.AnimePlayer = TimerSystem.GameplayTimeInstance.Forever(new TTimerAction(this.BarExpAnime), 20f, 1f, null, null, true);
		}
	}

	// Token: 0x170015F0 RID: 5616
	// (get) Token: 0x06011339 RID: 70457 RVA: 0x004317B8 File Offset: 0x0042F9B8
	private bool GetIsOverLoop
	{
		get
		{
			return this.IsLevelUp && this.ShowingExp >= this.PreMaxExp;
		}
	}

	// Token: 0x0601133A RID: 70458 RVA: 0x004317D8 File Offset: 0x0042F9D8
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

	// Token: 0x0601133B RID: 70459 RVA: 0x004318E4 File Offset: 0x0042FAE4
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

	// Token: 0x0601133C RID: 70460 RVA: 0x0043193D File Offset: 0x0042FB3D
	protected override void OnBeforeDestroy()
	{
		if (this.AnimePlayer != null && TimerSystem.GameplayTimeInstance.Has(this.AnimePlayer))
		{
			TimerSystem.GameplayTimeInstance.Remove(this.AnimePlayer);
		}
		this.RecycleEffect();
	}

	// Token: 0x0601133D RID: 70461 RVA: 0x00431970 File Offset: 0x0042FB70
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add<PlotInfo>(EEventName.PlotNetworkStart, new Action<PlotInfo>(this.OnSequenceNetworkStart));
	}

	// Token: 0x0601133E RID: 70462 RVA: 0x0043198E File Offset: 0x0042FB8E
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.PlotNetworkStart, new Action<PlotInfo>(this.OnSequenceNetworkStart));
	}

	// Token: 0x0601133F RID: 70463 RVA: 0x004319AC File Offset: 0x0042FBAC
	private void OnSequenceNetworkStart(PlotInfo plotInfo)
	{
		this.TryCloseMe();
	}

	// Token: 0x06011340 RID: 70464 RVA: 0x004319B4 File Offset: 0x0042FBB4
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

	// Token: 0x06011341 RID: 70465 RVA: 0x00431A6C File Offset: 0x0042FC6C
	private void RecycleEffect()
	{
		if (EffectSystem.Instance.IsValid(this.EffectHandle))
		{
			EffectSystem.Instance.StopEffectById(this.EffectHandle, "[MotorcycleLevelUpView.RecycleEffect]", true, null);
			this.EffectHandle = 0;
		}
	}

	// Token: 0x040082E4 RID: 33508
	private int EffectHandle;

	// Token: 0x040082E5 RID: 33509
	private bool IsLevelUp;

	// Token: 0x040082E6 RID: 33510
	private bool IsExpUp;

	// Token: 0x040082E7 RID: 33511
	private bool IsOverLevel;

	// Token: 0x040082E8 RID: 33512
	private bool IsOverLoop;

	// Token: 0x040082E9 RID: 33513
	private float ShowingExp;

	// Token: 0x040082EA RID: 33514
	private float PreMaxExp;

	// Token: 0x040082EB RID: 33515
	private float TargetExp;

	// Token: 0x040082EC RID: 33516
	private float CurMaxExp;

	// Token: 0x040082ED RID: 33517
	private float AddExp;

	// Token: 0x040082EE RID: 33518
	private int CurrentLevel;

	// Token: 0x040082EF RID: 33519
	private bool IsLevelUpAnimeDown;

	// Token: 0x040082F0 RID: 33520
	[Nullable(2)]
	private TimerHandle AnimePlayer;

	// Token: 0x040082F1 RID: 33521
	private bool IsInClosing;

	// Token: 0x040082F2 RID: 33522
	private readonly int AnimeTime = ConfigCommonParamById.GetIntConfig("ExpDisplayTime").Value;

	// Token: 0x040082F3 RID: 33523
	private readonly Rotator CurrentRotator = Rotator.Create();

	// Token: 0x02008798 RID: 34712
	[NullableContext(0)]
	private class EChildType
	{
		// Token: 0x0402C126 RID: 180518
		public const int LevelTxt = 0;

		// Token: 0x0402C127 RID: 180519
		public const int BarExp = 1;

		// Token: 0x0402C128 RID: 180520
		public const int ArrowItem = 2;

		// Token: 0x0402C129 RID: 180521
		public const int ExpUpItem = 3;

		// Token: 0x0402C12A RID: 180522
		public const int LevelUpItem = 4;
	}
}
