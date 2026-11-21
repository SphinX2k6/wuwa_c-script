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

// Token: 0x020022C7 RID: 8903
public class WorldLevelUpView : UiTickViewBase
{
	// Token: 0x06015FE2 RID: 90082 RVA: 0x0065F93C File Offset: 0x0065DB3C
	[NullableContext(1)]
	public WorldLevelUpView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06015FE3 RID: 90083 RVA: 0x0065F968 File Offset: 0x0065DB68
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

	// Token: 0x06015FE4 RID: 90084 RVA: 0x0065F9F2 File Offset: 0x0065DBF2
	protected override void OnStart()
	{
		this.SetLevelText();
		this.PlayWorldLevelUpEffect();
	}

	// Token: 0x06015FE5 RID: 90085 RVA: 0x0065FA00 File Offset: 0x0065DC00
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.WorldLevelUpViewRefresh, new Action(this.OnViewRefresh));
	}

	// Token: 0x06015FE6 RID: 90086 RVA: 0x0065FA1E File Offset: 0x0065DC1E
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.WorldLevelUpViewRefresh, new Action(this.OnViewRefresh));
	}

	// Token: 0x06015FE7 RID: 90087 RVA: 0x0065FA3C File Offset: 0x0065DC3C
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

	// Token: 0x06015FE8 RID: 90088 RVA: 0x0065FB0B File Offset: 0x0065DD0B
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

	// Token: 0x06015FE9 RID: 90089 RVA: 0x0065FB49 File Offset: 0x0065DD49
	private void OnViewRefresh()
	{
		this.SetLevelText();
	}

	// Token: 0x06015FEA RID: 90090 RVA: 0x0065FB51 File Offset: 0x0065DD51
	private void CloseView()
	{
		base.CloseMe(null);
	}

	// Token: 0x06015FEB RID: 90091 RVA: 0x0065FB5A File Offset: 0x0065DD5A
	protected override void OnBeforeDestroy()
	{
		this.RecycleEffect();
	}

	// Token: 0x06015FEC RID: 90092 RVA: 0x0065FB64 File Offset: 0x0065DD64
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

	// Token: 0x06015FED RID: 90093 RVA: 0x0065FC10 File Offset: 0x0065DE10
	private void RecycleEffect()
	{
		if (EffectSystem.Instance.IsValid(this.EffectHandle))
		{
			EffectSystem.Instance.StopEffectById(this.EffectHandle, "[WorldLevelUpView.RecycleEffect]", true, null);
			this.EffectHandle = 0;
		}
	}

	// Token: 0x0400B8C7 RID: 47303
	private int EffectHandle;

	// Token: 0x0400B8C8 RID: 47304
	private float Time;

	// Token: 0x0400B8C9 RID: 47305
	private readonly int CloseTime = ConfigCommonParamById.GetIntConfig("WorldLevelDisplayTime").Value;
}
