using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Activity.ActivityContent.WheelTower;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02000A71 RID: 2673
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class WheelTowerBossItem : GridProxyAbstract<IBossItemData>
{
	// Token: 0x060071A7 RID: 29095 RVA: 0x0022E304 File Offset: 0x0022C504
	protected unsafe override void OnRegisterComponent()
	{
		int num = 14;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(9, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(11, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.ButtonClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x060071A8 RID: 29096 RVA: 0x0022E53C File Offset: 0x0022C73C
	protected override UniTask OnBeforeStartAsync()
	{
		WheelTowerBossItem.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<WheelTowerBossItem.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060071A9 RID: 29097 RVA: 0x0022E57F File Offset: 0x0022C77F
	protected override void OnStart()
	{
		UUIItem item = base.GetItem(3);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(false);
	}

	// Token: 0x060071AA RID: 29098 RVA: 0x0022E593 File Offset: 0x0022C793
	protected override void OnBeforeDestroy()
	{
		this.CancelHpBarAnimationTimer();
	}

	// Token: 0x060071AB RID: 29099 RVA: 0x0022E59C File Offset: 0x0022C79C
	public override void Refresh(IBossItemData data, bool isSelected, int gridIndex)
	{
		this.RefreshInfo(data, gridIndex);
		if (data.StartPercent != null)
		{
			UUISprite subBar = base.GetSprite(9);
			if (subBar == null)
			{
				return;
			}
			subBar.SetUIActive(true);
			float start = data.StartPercent.Value / 100f;
			float end = (float)data.BossInfo.HpPercentage / 100f;
			subBar.SetFillAmount(start);
			float alpha = 0f;
			this.CancelHpBarAnimationTimer();
			this.HpBarAnimationTimerHandle = TimerSystem.GameplayTimeInstance.Forever(delegate(float delta)
			{
				alpha = MathUtils.Instance.Clamp(alpha + delta * 1.5f / 1000f, 0f, 1f);
				subBar.SetFillAmount(MathUtils.Instance.Lerp(start, end, alpha));
				if (alpha >= 1f)
				{
					this.CancelHpBarAnimationTimer();
				}
			}, 20f, 1f, null, null, true);
		}
	}

	// Token: 0x060071AC RID: 29100 RVA: 0x0022E671 File Offset: 0x0022C871
	private void CancelHpBarAnimationTimer()
	{
		if (TimerSystem.GameplayTimeInstance.Has(this.HpBarAnimationTimerHandle))
		{
			TimerSystem.GameplayTimeInstance.Remove(this.HpBarAnimationTimerHandle);
		}
	}

	// Token: 0x060071AD RID: 29101 RVA: 0x0022E696 File Offset: 0x0022C896
	public void SetCurrentChallenge(bool isCurrent)
	{
		UUIItem item = base.GetItem(8);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(isCurrent);
	}

	// Token: 0x060071AE RID: 29102 RVA: 0x0022E6AA File Offset: 0x0022C8AA
	public void SetTagVisible(bool isVisible)
	{
		UUIItem item = base.GetItem(13);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(isVisible);
	}

	// Token: 0x060071AF RID: 29103 RVA: 0x0022E6BF File Offset: 0x0022C8BF
	public void SetClickCallback(Action<int, int> callback)
	{
		this.ToggleCallback = callback;
	}

	// Token: 0x060071B0 RID: 29104 RVA: 0x0022E6C8 File Offset: 0x0022C8C8
	private void RefreshInfo(IBossItemData data, int gridIndex)
	{
		IBossInfo bossInfo = data.BossInfo;
		this.BossId = bossInfo.WaveConfigId;
		NewTowerWave? waveConfigById = WheelTowerConfig.Instance.GetWaveConfigById(bossInfo.WaveConfigId);
		if (waveConfigById == null)
		{
			return;
		}
		UUIText text = base.GetText(2);
		if (text != null)
		{
			text.ShowTextNew(waveConfigById.Value.Name);
		}
		UUIText text2 = base.GetText(1);
		if (text2 != null)
		{
			text2.SetText((gridIndex + 1).ToString(), true);
		}
		base.SetTextureByPath(waveConfigById.Value.Icon, base.GetTexture(7), null, null);
		float num = (float)bossInfo.HpPercentage;
		UUIText text3 = base.GetText(5);
		if (text3 != null)
		{
			text3.SetText(num.ToString() + "%", true);
		}
		UUISprite sprite = base.GetSprite(4);
		if (sprite != null)
		{
			sprite.SetFillAmount(num / 100f);
		}
		this.SetFinished(bossInfo.HpPercentage <= 0.0);
		UUIItem item = base.GetItem(8);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		if (waveConfigById.Value.TagIdListLength > 0)
		{
			BossTagItem tagItem = this.TagItem;
			if (tagItem != null)
			{
				tagItem.RefreshByData(waveConfigById.Value.GetTagIdListArray()[0]);
			}
		}
		bool endlessMode = WheelTowerModel.Instance.EndlessMode;
		UUIItem item2 = base.GetItem(10);
		if (item2 != null)
		{
			item2.SetUIActive(endlessMode);
		}
		if (endlessMode)
		{
			UUIText text4 = base.GetText(12);
			if (text4 != null)
			{
				text4.SetText("R" + bossInfo.Round.ToString(), true);
			}
			this.RefreshRoundColor(bossInfo.Round);
		}
	}

	// Token: 0x060071B1 RID: 29105 RVA: 0x0022E870 File Offset: 0x0022CA70
	private void RefreshRoundColor(int round)
	{
		int num = round - 1;
		string text;
		if (num >= WheelTowerBossItem.RoundBgDefine.Length)
		{
			string[] roundBgDefine = WheelTowerBossItem.RoundBgDefine;
			text = roundBgDefine[roundBgDefine.Length - 1];
		}
		else
		{
			text = WheelTowerBossItem.RoundBgDefine[num];
		}
		string path = text;
		this.SetSpriteByPath(path, base.GetSprite(11), false, null, null);
	}

	// Token: 0x060071B2 RID: 29106 RVA: 0x0022E8BC File Offset: 0x0022CABC
	private void SetFinished(bool isFinished)
	{
		UUIItem item = base.GetItem(6);
		if (item != null)
		{
			item.SetUIActive(isFinished);
		}
		UUITexture texture = base.GetTexture(7);
		if (texture != null)
		{
			UUIItem uuiitem = texture;
			FColor? fcolor = new FColor?(texture.changeColor);
			uuiitem.SetChangeColor(isFinished, fcolor);
		}
	}

	// Token: 0x060071B3 RID: 29107 RVA: 0x0022E8FC File Offset: 0x0022CAFC
	private void ButtonClick()
	{
		Action<int, int> toggleCallback = this.ToggleCallback;
		if (toggleCallback == null)
		{
			return;
		}
		toggleCallback(base.GridIndex, this.BossId);
	}

	// Token: 0x04004672 RID: 18034
	private const int MS_PER_SEC = 1000;

	// Token: 0x04004673 RID: 18035
	private const float HP_BAR_ANIMATION_SPEED_MULTIPLE = 1.5f;

	// Token: 0x04004674 RID: 18036
	[StaticVariableRuleIgnore]
	private static readonly string[] RoundBgDefine = new string[]
	{
		"/Game/Aki/UI/UIResources/UiActivity/Atlas/ActivityMowingTower/MowingTower30/SP_RoundNumBg.SP_RoundNumBg",
		"/Game/Aki/UI/UIResources/UiActivity/Atlas/ActivityMowingTower/MowingTower30/SP_RoundNumBgYellow.SP_RoundNumBgYellow",
		"/Game/Aki/UI/UIResources/UiActivity/Atlas/ActivityMowingTower/MowingTower30/SP_RoundNumBgRed.SP_RoundNumBgRed"
	};

	// Token: 0x04004675 RID: 18037
	private int BossId;

	// Token: 0x04004676 RID: 18038
	[Nullable(2)]
	private Action<int, int> ToggleCallback;

	// Token: 0x04004677 RID: 18039
	[Nullable(2)]
	private BossTagItem TagItem;

	// Token: 0x04004678 RID: 18040
	[Nullable(2)]
	private TimerHandle HpBarAnimationTimerHandle;
}
