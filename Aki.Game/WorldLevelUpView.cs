using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Effect;
using CSharpScript.Game.NewWorld.Pawn.Component;
using CSharpScript.Game.Ui;
using CSharpScript.Game.Utils;
using UnrealEngine;

// Token: 0x02002D6D RID: 11629
public class WorldLevelUpView : UiTickViewBase
{
	// Token: 0x06018740 RID: 100160 RVA: 0x00639924 File Offset: 0x00637B24
	[NullableContext(1)]
	public WorldLevelUpView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06018741 RID: 100161 RVA: 0x00639950 File Offset: 0x00637B50
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06018742 RID: 100162 RVA: 0x006399DA File Offset: 0x00637BDA
	protected override void OnStart()
	{
		this.SetLevelText();
		this.PlayWorldLevelUpEffect();
	}

	// Token: 0x06018743 RID: 100163 RVA: 0x006399E8 File Offset: 0x00637BE8
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.WorldLevelUpViewRefresh, new Action(this.OnViewRefresh));
	}

	// Token: 0x06018744 RID: 100164 RVA: 0x00639A06 File Offset: 0x00637C06
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.WorldLevelUpViewRefresh, new Action(this.OnViewRefresh));
	}

	// Token: 0x06018745 RID: 100165 RVA: 0x00639A24 File Offset: 0x00637C24
	private void SetLevelText()
	{
		int originWorldLevel = WorldLevelModel.Instance.OriginWorldLevel;
		base.GetText(0).SetText(originWorldLevel.ToString(), true);
		WorldLevel? worldLevelConfig = WorldLevelConfig.Instance.GetWorldLevelConfig(originWorldLevel - 1);
		int? num = (worldLevelConfig != null) ? new int?(worldLevelConfig.GetValueOrDefault().PlayerLevelMax) : null;
		worldLevelConfig = WorldLevelConfig.Instance.GetWorldLevelConfig(originWorldLevel);
		int? num2 = (worldLevelConfig != null) ? new int?(worldLevelConfig.GetValueOrDefault().PlayerLevelMax) : null;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(1), "WorldLevelTips", new <>z__ReadOnlyArray<object>(new object[]
		{
			num,
			num2
		}));
	}

	// Token: 0x06018746 RID: 100166 RVA: 0x00639AF3 File Offset: 0x00637CF3
	protected override void OnTick(float delta)
	{
		if (this.Time < 0f)
		{
			return;
		}
		this.Time += delta;
		if (this.Time > (float)this.CloseTime)
		{
			this.CloseView();
			this.Time = -1f;
		}
	}

	// Token: 0x06018747 RID: 100167 RVA: 0x00639B31 File Offset: 0x00637D31
	private void OnViewRefresh()
	{
		this.SetLevelText();
	}

	// Token: 0x06018748 RID: 100168 RVA: 0x00639B39 File Offset: 0x00637D39
	private void CloseView()
	{
		base.CloseMe(null);
	}

	// Token: 0x06018749 RID: 100169 RVA: 0x00639B42 File Offset: 0x00637D42
	protected override void OnBeforeDestroy()
	{
		this.RecycleEffect();
	}

	// Token: 0x0601874A RID: 100170 RVA: 0x00639B4C File Offset: 0x00637D4C
	private void PlayWorldLevelUpEffect()
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
		EffectSystem instance = EffectSystem.Instance;
		UObject world = GlobalData.World;
		FTransformDouble? ftransformDouble = new FTransformDouble?(value);
		this.EffectHandle = instance.SpawnUnloopedEffect(world, ftransformDouble, effectPath, "[WorldLevelUpView.PlayWorldLevelUpEffect]", null, EEffectType.Scene, null, null, null, false, false);
		EffectSystem.Instance.SetAdditionTimeScale(ETimeScaleSourceType.SelfCentered, this.EffectHandle, CharacterModel.Instance.InverseSelfCenteredTimeDilation);
	}

	// Token: 0x0601874B RID: 100171 RVA: 0x00639BF8 File Offset: 0x00637DF8
	private void RecycleEffect()
	{
		if (EffectSystem.Instance.IsValid(this.EffectHandle))
		{
			EffectSystem.Instance.StopEffectById(this.EffectHandle, "[WorldLevelUpView.RecycleEffect]", true, null);
			this.EffectHandle = 0;
		}
	}

	// Token: 0x0400B552 RID: 46418
	private int EffectHandle;

	// Token: 0x0400B553 RID: 46419
	private float Time;

	// Token: 0x0400B554 RID: 46420
	private readonly int CloseTime = ConfigCommonParamById.GetIntConfig("WorldLevelDisplayTime").Value;
}
