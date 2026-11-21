using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020005B6 RID: 1462
[NullableContext(1)]
[Nullable(0)]
public class ArtemisQteProgressItem : UiPanelBase
{
	// Token: 0x06004504 RID: 17668 RVA: 0x0017B2B4 File Offset: 0x001794B4
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUITexture)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIItem))
		};
	}

	// Token: 0x06004505 RID: 17669 RVA: 0x0017B392 File Offset: 0x00179592
	protected override void OnStart()
	{
		base.GetItem(3).SetUIActive(false);
	}

	// Token: 0x06004506 RID: 17670 RVA: 0x0017B3A1 File Offset: 0x001795A1
	protected override void OnBeforeDestroy()
	{
		this.BgItemList.Clear();
		this.QteAreaTextures.Clear();
		this.PerfectAreaTextures.Clear();
		this.CachedTexture.Clear();
	}

	// Token: 0x06004507 RID: 17671 RVA: 0x0017B3D0 File Offset: 0x001795D0
	public void Init(int gamePlayId, ArtemisQteGameInfo gameInfo)
	{
		this.GameInfo = gameInfo;
		this.RingInfo = this.GameInfo.GetRingInfo();
		this.GamePlayId = gamePlayId;
		ArtemisQte value = ArtemisActivityConfig.Instance.GetArtemisQteConfigById(this.GamePlayId).Value;
		this.AnimTime = Math.Max(value.HitColdTime, 100);
		float num = value.HiddenInterval(0);
		float num2 = value.HiddenInterval(1);
		float num3 = 2f * num + num2;
		if (num3 > 0f)
		{
			this.PeriodAlphaTotalTime = num3;
		}
	}

	// Token: 0x06004508 RID: 17672 RVA: 0x0017B458 File Offset: 0x00179658
	public void InitRing()
	{
		this.RingInfo.ClearValidAreas();
		this.SpawnBgArea().Forget();
		this.InitAllQteAreas();
		float cursorSpeed = this.GameInfo.CursorSpeed;
		float ringSpeed = this.GameInfo.RingSpeed;
		if (cursorSpeed > 0f && ringSpeed > 0f)
		{
			return;
		}
		this.RotateMode = ((cursorSpeed > 0f) ? EArtemisRotateMode.Arrow : EArtemisRotateMode.Ring);
	}

	// Token: 0x06004509 RID: 17673 RVA: 0x0017B4BC File Offset: 0x001796BC
	public void OnTick(float delta)
	{
		float currentProgress = this.GetCurrentProgress();
		this.RefreshAnimProgress(currentProgress, delta);
		this.RefreshProgress(currentProgress);
		this.RefreshArrow(delta);
	}

	// Token: 0x0600450A RID: 17674 RVA: 0x0017B4E8 File Offset: 0x001796E8
	private void RefreshArrow(float delta)
	{
		if (this.GameInfo.IsGamePause())
		{
			return;
		}
		float cursorSpeed = this.GameInfo.CursorSpeed;
		float ringSpeed = this.GameInfo.RingSpeed;
		float cursorSpeed2 = (this.RotateMode == EArtemisRotateMode.Arrow) ? cursorSpeed : ringSpeed;
		ArtemisQteRingInfo ringInfo = this.RingInfo;
		int direction = (ringInfo != null && ringInfo.ArrowDirection == EArrowDirection.Clockwise) ? -1 : 1;
		float deltaSecond = delta / 1000f;
		this.CurrentRotator.Yaw = this.GetRotatorYaw(direction, cursorSpeed2, deltaSecond);
		UUIItem item = base.GetItem(7);
		EArtemisRotateMode rotateMode = this.RotateMode;
		if (rotateMode != EArtemisRotateMode.Arrow)
		{
			if (rotateMode == EArtemisRotateMode.Ring)
			{
				foreach (ArtemisQteRingBgSingleItem artemisQteRingBgSingleItem in this.BgItemList)
				{
					UUIItem uuiitem = (artemisQteRingBgSingleItem != null) ? artemisQteRingBgSingleItem.GetRootItem() : null;
					if (uuiitem != null && uuiitem.IsUIActiveSelf())
					{
						UUIItem uuiitem2 = uuiitem;
						FRotator frotator = this.CurrentRotator.ToUeRotator();
						uuiitem2.SetUIRelativeRotation(frotator);
					}
				}
				foreach (int continuousIndex in this.RingInfo.GetQteAreas().Keys)
				{
					UUIItem qteAreaTexture = this.GetQteAreaTexture(continuousIndex);
					FRotator frotator = this.CurrentRotator.ToUeRotator();
					qteAreaTexture.SetUIRelativeRotation(frotator);
				}
				foreach (int continuousIndex2 in this.RingInfo.GetPerfectAreas().Keys)
				{
					UUIItem perfectAreaTexture = this.GetPerfectAreaTexture(continuousIndex2);
					FRotator frotator = this.CurrentRotator.ToUeRotator();
					perfectAreaTexture.SetUIRelativeRotation(frotator);
				}
				this.RingInfo.CurrentArrowStayCellIndex = 36 - this.GetCurrentArrowStayCellIndex() + 1;
			}
		}
		else
		{
			if (item != null)
			{
				UUIItem uuiitem3 = item;
				FRotator frotator = this.CurrentRotator.ToUeRotator();
				uuiitem3.SetUIRelativeRotation(frotator);
			}
			this.RingInfo.CurrentArrowStayCellIndex = this.GetCurrentArrowStayCellIndex();
		}
		if (this.PeriodAlphaTotalTime > 0f)
		{
			float alphaInAlphaPeriod = this.GetAlphaInAlphaPeriod(this.PeriodAlphaCurrentTime);
			foreach (int continuousIndex3 in this.RingInfo.GetQteAreas().Keys)
			{
				this.GetQteAreaTexture(continuousIndex3).SetAlpha(alphaInAlphaPeriod);
			}
			foreach (int continuousIndex4 in this.RingInfo.GetPerfectAreas().Keys)
			{
				this.GetPerfectAreaTexture(continuousIndex4).SetAlpha(alphaInAlphaPeriod);
			}
			this.PeriodAlphaCurrentTime += delta;
			if (this.PeriodAlphaCurrentTime >= this.PeriodAlphaTotalTime)
			{
				this.PeriodAlphaCurrentTime = 0f;
			}
		}
	}

	// Token: 0x0600450B RID: 17675 RVA: 0x0017B7F0 File Offset: 0x001799F0
	private float GetAlphaInAlphaPeriod(float currentTime)
	{
		ArtemisQte value = ArtemisActivityConfig.Instance.GetArtemisQteConfigById(this.GamePlayId).Value;
		float num = value.HiddenInterval(0);
		float num2 = value.HiddenInterval(1);
		float num3 = value.HiddenInterval(2);
		float num4 = (num2 - num3) / 2f;
		if (currentTime < num)
		{
			return 1f;
		}
		if (currentTime < num + num4)
		{
			return 1f - (currentTime - num) / num4;
		}
		if (currentTime < num + num4 + num3)
		{
			return 0f;
		}
		if (currentTime < num + num2)
		{
			return (currentTime - num - num4 - num3) / num4;
		}
		return 1f;
	}

	// Token: 0x0600450C RID: 17676 RVA: 0x0017B884 File Offset: 0x00179A84
	private int GetCurrentArrowStayCellIndex()
	{
		return (int)(Math.Floor((double)(Math.Abs(this.CurrentRotator.Yaw) % 360f / 10f)) + 1.0);
	}

	// Token: 0x0600450D RID: 17677 RVA: 0x0017B8B4 File Offset: 0x00179AB4
	private float GetRotatorYaw(int direction, float cursorSpeed, float deltaSecond)
	{
		float num = this.CurrentRotator.Yaw;
		ArtemisQteRingInfo ringInfo = this.RingInfo;
		if (ringInfo != null && ringInfo.IsWholeRing)
		{
			num += (float)direction * (cursorSpeed * deltaSecond);
		}
		else
		{
			num += (float)direction * (cursorSpeed * deltaSecond);
			if (num < this.ArrowActiveEndYawAngle)
			{
				num = this.ArrowActiveEndYawAngle + 1f;
				this.RingInfo.OnArrowDirectionReverse();
			}
			if (num > this.ArrowActiveStartYawAngle)
			{
				num = this.ArrowActiveStartYawAngle;
				this.RingInfo.OnArrowDirectionReverse();
			}
		}
		if (num > 0f)
		{
			num -= 360f;
		}
		return num % (float)ArtemisQteProgressItem.YAW_MAX_ANGLE;
	}

	// Token: 0x0600450E RID: 17678 RVA: 0x0017B94C File Offset: 0x00179B4C
	[NullableContext(2)]
	public void OnAreaClick(EArtemisAreaType areaType, ContinuousRingArea area)
	{
		switch (areaType)
		{
		case EArtemisAreaType.BlankArea:
			this.AllAreaPlayingSequenceName = null;
			this.PlayAnim("Miss");
			return;
		case EArtemisAreaType.QteArea:
			this.PeriodAlphaCurrentTime = 0f;
			this.AllAreaPlayingSequenceName = null;
			this.OncePlayingSequenceName = "Success";
			this.StopTargetPlayingSequence("Perfect");
			this.StopTargetPlayingSequence("Perfect_Light");
			if (area != null)
			{
				this.AnyTargetPlayAnim(areaType, "Success", area.ContinuousIndex, true);
				return;
			}
			break;
		case EArtemisAreaType.PerfectArea:
			this.PeriodAlphaCurrentTime = 0f;
			this.AllAreaPlayingSequenceName = "Perfect";
			this.OncePlayingSequenceName = "Perfect_Light";
			this.PlayAnim("Perfect");
			if (area != null)
			{
				this.AnyTargetPlayAnim(areaType, "Perfect_Light", area.ContinuousIndex, false);
			}
			break;
		default:
			return;
		}
	}

	// Token: 0x0600450F RID: 17679 RVA: 0x0017BA0C File Offset: 0x00179C0C
	public void PlayAnim(string sequenceName)
	{
		foreach (ArtemisQteRingSingleItem artemisQteRingSingleItem in this.QteAreaTextures.Values)
		{
			if (artemisQteRingSingleItem != null)
			{
				artemisQteRingSingleItem.PlayAnim(sequenceName);
			}
		}
		foreach (ArtemisQteRingSingleItem artemisQteRingSingleItem2 in this.PerfectAreaTextures.Values)
		{
			if (artemisQteRingSingleItem2 != null)
			{
				artemisQteRingSingleItem2.PlayAnim(sequenceName);
			}
		}
	}

	// Token: 0x06004510 RID: 17680 RVA: 0x0017BAB4 File Offset: 0x00179CB4
	public void StopTargetPlayingSequence(string sequenceName)
	{
		foreach (ArtemisQteRingSingleItem artemisQteRingSingleItem in this.QteAreaTextures.Values)
		{
			if (artemisQteRingSingleItem != null)
			{
				artemisQteRingSingleItem.StopPlayingSequence(sequenceName);
			}
		}
		foreach (ArtemisQteRingSingleItem artemisQteRingSingleItem2 in this.PerfectAreaTextures.Values)
		{
			if (artemisQteRingSingleItem2 != null)
			{
				artemisQteRingSingleItem2.StopPlayingSequence(sequenceName);
			}
		}
	}

	// Token: 0x06004511 RID: 17681 RVA: 0x0017BB5C File Offset: 0x00179D5C
	public void AnyTargetPlayAnim(EArtemisAreaType areaType, string sequenceName, int continuousIndex, bool needStop)
	{
		if (areaType == EArtemisAreaType.PerfectArea)
		{
			using (Dictionary<int, ArtemisQteRingSingleItem>.Enumerator enumerator = this.PerfectAreaTextures.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					KeyValuePair<int, ArtemisQteRingSingleItem> keyValuePair = enumerator.Current;
					if (this.PerfectAreaTextures.Count <= 1)
					{
						this.RingSingleItemPlayAnim(keyValuePair.Value, sequenceName, needStop);
						break;
					}
					if (keyValuePair.Key != continuousIndex)
					{
						this.RingSingleItemPlayAnim(keyValuePair.Value, sequenceName, needStop);
						break;
					}
				}
				return;
			}
		}
		foreach (KeyValuePair<int, ArtemisQteRingSingleItem> keyValuePair2 in this.QteAreaTextures)
		{
			if (this.QteAreaTextures.Count <= 1)
			{
				this.RingSingleItemPlayAnim(keyValuePair2.Value, sequenceName, needStop);
				break;
			}
			if (keyValuePair2.Key != continuousIndex)
			{
				this.RingSingleItemPlayAnim(keyValuePair2.Value, sequenceName, needStop);
				break;
			}
		}
	}

	// Token: 0x06004512 RID: 17682 RVA: 0x0017BC68 File Offset: 0x00179E68
	private void RingSingleItemPlayAnim(ArtemisQteRingSingleItem item, string sequenceName, bool needStop)
	{
		if (item != null)
		{
			if (needStop)
			{
				item.PlayAnim(sequenceName);
				return;
			}
			item.PlayLevelSequenceByName(sequenceName);
		}
	}

	// Token: 0x06004513 RID: 17683 RVA: 0x0017BC80 File Offset: 0x00179E80
	private void PlayCacheAnim(EArtemisAreaType areaType, int continuousIndex)
	{
		ArtemisQteRingSingleItem artemisQteRingSingleItem2;
		ArtemisQteRingSingleItem artemisQteRingSingleItem3;
		ArtemisQteRingSingleItem artemisQteRingSingleItem = (areaType == EArtemisAreaType.PerfectArea) ? (this.PerfectAreaTextures.TryGetValue(continuousIndex, out artemisQteRingSingleItem2) ? artemisQteRingSingleItem2 : null) : (this.QteAreaTextures.TryGetValue(continuousIndex, out artemisQteRingSingleItem3) ? artemisQteRingSingleItem3 : null);
		if (artemisQteRingSingleItem != null)
		{
			if (this.AllAreaPlayingSequenceName != null)
			{
				artemisQteRingSingleItem.PlayAnim(this.AllAreaPlayingSequenceName);
			}
			if (this.OncePlayingSequenceName != null)
			{
				artemisQteRingSingleItem.PlayLevelSequenceByName(this.OncePlayingSequenceName);
				this.OncePlayingSequenceName = null;
			}
		}
	}

	// Token: 0x06004514 RID: 17684 RVA: 0x0017BCF0 File Offset: 0x00179EF0
	private void RefreshProgress(float progress)
	{
		int value = (int)Math.Ceiling((double)(progress * 100f));
		UUIText text = base.GetText(5);
		DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
		defaultInterpolatedStringHandler.AppendFormatted<int>(value);
		defaultInterpolatedStringHandler.AppendLiteral("%");
		text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		this.CurrentFillAmountRotator.Yaw = MathUtils.Instance.Lerp(-53f, 0f, progress);
		UUIItem item = base.GetItem(6);
		if (item == null)
		{
			return;
		}
		FRotator frotator = this.CurrentFillAmountRotator.ToUeRotator();
		item.SetUIRelativeRotation(frotator);
	}

	// Token: 0x06004515 RID: 17685 RVA: 0x0017BD80 File Offset: 0x00179F80
	private void RefreshAnimProgress(float currentProgress, float delta)
	{
		float alpha = currentProgress;
		if (this.InAnim)
		{
			this.CurrentAnimTime += (int)delta;
			if (0 < this.CurrentAnimTime && this.CurrentAnimTime <= this.AnimTime)
			{
				float alpha2 = (float)this.CurrentAnimTime / (float)this.AnimTime;
				alpha = MathUtils.Instance.Lerp(this.AnimStartProgress, currentProgress, alpha2);
			}
			else
			{
				this.InAnim = false;
				alpha = currentProgress;
			}
		}
		this.AnimRotator.Yaw = MathUtils.Instance.Lerp(-53f, 0f, alpha);
	}

	// Token: 0x06004516 RID: 17686 RVA: 0x0017BE10 File Offset: 0x0017A010
	public void OnArrowStayAreaUpdate(int relativeValidAreaIndex)
	{
		List<RingArea> validAreas = this.GameInfo.GetRingInfo().GetValidAreas();
		if (relativeValidAreaIndex < 0 || relativeValidAreaIndex >= validAreas.Count)
		{
			return;
		}
		RingArea ringArea = validAreas[relativeValidAreaIndex];
		this.ArrowActiveStartYawAngle = (float)(-(float)Math.Max(ringArea.StartCellIndex - 1, 0) * 10);
		this.ArrowActiveEndYawAngle = (float)(-(float)ringArea.EndCellIndex * 10);
		if (this.ArrowActiveEndYawAngle >= this.ArrowActiveStartYawAngle)
		{
			this.ArrowActiveEndYawAngle -= 360f;
		}
		EArrowDirection arrowDirection = ringArea.ArrowDirection;
		if (arrowDirection != EArrowDirection.Clockwise)
		{
			if (arrowDirection == EArrowDirection.Anticlockwise)
			{
				this.CurrentRotator.Yaw = this.ArrowActiveEndYawAngle;
			}
		}
		else
		{
			this.CurrentRotator.Yaw = this.ArrowActiveStartYawAngle;
		}
		UUIItem item = base.GetItem(7);
		if (item == null)
		{
			return;
		}
		FRotator frotator = this.CurrentRotator.ToUeRotator();
		item.SetUIRelativeRotation(frotator);
	}

	// Token: 0x06004517 RID: 17687 RVA: 0x0017BEE4 File Offset: 0x0017A0E4
	private float GetCurrentProgress()
	{
		int currentScore = this.GameInfo.CurrentScore;
		int maxScore = ArtemisActivityConfig.Instance.GetArtemisQteConfigById(this.GamePlayId).Value.MaxScore;
		return MathUtils.Instance.Clamp((float)currentScore / (float)maxScore, 0f, 1f);
	}

	// Token: 0x06004518 RID: 17688 RVA: 0x0017BF38 File Offset: 0x0017A138
	public void StartAnimProgress()
	{
		this.AnimStartProgress = this.GetCurrentProgress();
		this.CurrentAnimTime = 0;
		this.InAnim = true;
	}

	// Token: 0x06004519 RID: 17689 RVA: 0x0017BF54 File Offset: 0x0017A154
	public void EnterNextRound()
	{
		this.AnimStartProgress = 0f;
	}

	// Token: 0x0600451A RID: 17690 RVA: 0x0017BF64 File Offset: 0x0017A164
	private int GetAreaRandomSize(int[] rangeConfig)
	{
		int result = 3;
		if (rangeConfig != null && rangeConfig.Length >= 2)
		{
			result = this.RandomRangeInt(rangeConfig[0], rangeConfig[1]);
		}
		return result;
	}

	// Token: 0x0600451B RID: 17691 RVA: 0x0017BF8A File Offset: 0x0017A18A
	private int RandomRangeInt(int start, int end)
	{
		return Math.Min(end, (int)Math.Floor(MathUtils.Instance.GetRandomRange((double)start, (double)(end + 1))));
	}

	// Token: 0x0600451C RID: 17692 RVA: 0x0017BFA8 File Offset: 0x0017A1A8
	public void ResetArea(int continuousIndex, EArtemisAreaType areaType)
	{
		if (areaType != EArtemisAreaType.QteArea)
		{
			if (areaType != EArtemisAreaType.PerfectArea)
			{
				return;
			}
			this.RingInfo.RemovePerfectArea(continuousIndex);
			ArtemisQteRingSingleItem artemisQteRingSingleItem;
			if (this.PerfectAreaTextures.TryGetValue(continuousIndex, out artemisQteRingSingleItem))
			{
				artemisQteRingSingleItem.SetUiActive(false);
				this.CachedTexture.Add(artemisQteRingSingleItem);
				this.PerfectAreaTextures.Remove(continuousIndex);
			}
		}
		else
		{
			this.RingInfo.RemoveQteArea(continuousIndex);
			ArtemisQteRingSingleItem artemisQteRingSingleItem2;
			if (this.QteAreaTextures.TryGetValue(continuousIndex, out artemisQteRingSingleItem2))
			{
				artemisQteRingSingleItem2.SetUiActive(false);
				this.CachedTexture.Add(artemisQteRingSingleItem2);
				this.QteAreaTextures.Remove(continuousIndex);
				return;
			}
		}
	}

	// Token: 0x0600451D RID: 17693 RVA: 0x0017C037 File Offset: 0x0017A237
	public void ResetAreaInLink(int continuousIndex, EArtemisAreaType areaType)
	{
		if (areaType != EArtemisAreaType.QteArea)
		{
			if (areaType != EArtemisAreaType.PerfectArea)
			{
				return;
			}
			this.ResetArea(continuousIndex, EArtemisAreaType.PerfectArea);
			this.ResetArea(continuousIndex, EArtemisAreaType.QteArea);
		}
		else
		{
			this.ResetArea(continuousIndex, EArtemisAreaType.QteArea);
			if (this.PerfectAreaTextures.ContainsKey(continuousIndex))
			{
				this.ResetArea(continuousIndex, EArtemisAreaType.PerfectArea);
				return;
			}
		}
	}

	// Token: 0x0600451E RID: 17694 RVA: 0x0017C074 File Offset: 0x0017A274
	public void ResetAllArea()
	{
		foreach (int continuousIndex in new List<int>(this.QteAreaTextures.Keys))
		{
			this.ResetArea(continuousIndex, EArtemisAreaType.QteArea);
		}
		foreach (int continuousIndex2 in new List<int>(this.PerfectAreaTextures.Keys))
		{
			this.ResetArea(continuousIndex2, EArtemisAreaType.PerfectArea);
		}
	}

	// Token: 0x0600451F RID: 17695 RVA: 0x0017C120 File Offset: 0x0017A320
	private UniTask GenerateAreaWithTexture(int continuousIndex, EArtemisAreaType areaType, int startIndex, int areaSize)
	{
		ArtemisQteProgressItem.<GenerateAreaWithTexture>d__54 <GenerateAreaWithTexture>d__;
		<GenerateAreaWithTexture>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<GenerateAreaWithTexture>d__.<>4__this = this;
		<GenerateAreaWithTexture>d__.continuousIndex = continuousIndex;
		<GenerateAreaWithTexture>d__.areaType = areaType;
		<GenerateAreaWithTexture>d__.startIndex = startIndex;
		<GenerateAreaWithTexture>d__.areaSize = areaSize;
		<GenerateAreaWithTexture>d__.<>1__state = -1;
		<GenerateAreaWithTexture>d__.<>t__builder.Start<ArtemisQteProgressItem.<GenerateAreaWithTexture>d__54>(ref <GenerateAreaWithTexture>d__);
		return <GenerateAreaWithTexture>d__.<>t__builder.Task;
	}

	// Token: 0x06004520 RID: 17696 RVA: 0x0017C184 File Offset: 0x0017A384
	private UniTask GenerateQteArea(int continuousIndex, int startIndex, int areaSize)
	{
		ArtemisQteProgressItem.<GenerateQteArea>d__55 <GenerateQteArea>d__;
		<GenerateQteArea>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<GenerateQteArea>d__.<>4__this = this;
		<GenerateQteArea>d__.continuousIndex = continuousIndex;
		<GenerateQteArea>d__.startIndex = startIndex;
		<GenerateQteArea>d__.areaSize = areaSize;
		<GenerateQteArea>d__.<>1__state = -1;
		<GenerateQteArea>d__.<>t__builder.Start<ArtemisQteProgressItem.<GenerateQteArea>d__55>(ref <GenerateQteArea>d__);
		return <GenerateQteArea>d__.<>t__builder.Task;
	}

	// Token: 0x06004521 RID: 17697 RVA: 0x0017C1E0 File Offset: 0x0017A3E0
	public void SpawnAreaAtValidArea(int continuousIndex, RingArea validArea)
	{
		int startCellIndex = validArea.StartCellIndex;
		int endCellIndex = validArea.EndCellIndex;
		ArtemisQte value = ArtemisActivityConfig.Instance.GetArtemisQteConfigById(this.GamePlayId).Value;
		int num = ArtemisQteDefine.CalculateCellSize(startCellIndex, endCellIndex);
		int[] randomAreaArray = value.GetRandomAreaArray();
		int areaRandomSize = this.GetAreaRandomSize(randomAreaArray ?? Array.Empty<int>());
		if (num <= areaRandomSize)
		{
			this.GenerateQteArea(continuousIndex, startCellIndex, num).Forget();
			return;
		}
		if (endCellIndex >= startCellIndex)
		{
			int startIndex = this.RandomRangeInt(startCellIndex, endCellIndex - areaRandomSize + 1);
			this.GenerateQteArea(continuousIndex, startIndex, areaRandomSize).Forget();
			return;
		}
		int num2 = startCellIndex + num - 1;
		int startIndex2 = this.RandomRangeInt(startCellIndex, num2 - areaRandomSize + 1) % 36;
		this.GenerateQteArea(continuousIndex, startIndex2, areaRandomSize).Forget();
	}

	// Token: 0x06004522 RID: 17698 RVA: 0x0017C2A0 File Offset: 0x0017A4A0
	private void SpawnWholeRingAllArea()
	{
		ContinuousRingArea continuousRingArea;
		int num = this.RingInfo.GetQteAreas().TryGetValue(0, out continuousRingArea) ? continuousRingArea.StartCellIndex : 0;
		ArtemisQte value = ArtemisActivityConfig.Instance.GetArtemisQteConfigById(this.GamePlayId).Value;
		this.ResetAllArea();
		float num2 = 36f / (float)value.MultiBoxGroup;
		if (num2 != (float)((int)num2))
		{
			return;
		}
		int multiBoxGroup = value.MultiBoxGroup;
		int num3 = this.RandomRangeInt(1, 36);
		if (multiBoxGroup == 1 && num != 0)
		{
			int[] randomAreaArray = value.GetRandomAreaArray();
			int areaRandomSize = this.GetAreaRandomSize(randomAreaArray ?? Array.Empty<int>());
			int startIndex = (num + 18) % 36;
			this.GenerateQteArea(0, startIndex, areaRandomSize).Forget();
			return;
		}
		for (int i = 0; i < multiBoxGroup; i++)
		{
			int[] randomAreaArray2 = value.GetRandomAreaArray();
			int areaRandomSize2 = this.GetAreaRandomSize(randomAreaArray2 ?? Array.Empty<int>());
			int startIndex2 = i * (int)num2 + num3 + 1;
			this.GenerateQteArea(i, startIndex2, areaRandomSize2).Forget();
		}
	}

	// Token: 0x06004523 RID: 17699 RVA: 0x0017C3A4 File Offset: 0x0017A5A4
	private void SpawnIncompleteRingAllArea()
	{
		this.ResetAllArea();
		ArtemisQteRingInfo ringInfo = this.RingInfo;
		List<RingArea> list = (ringInfo != null) ? ringInfo.GetValidAreas() : null;
		if (list != null)
		{
			for (int i = 0; i < list.Count; i++)
			{
				this.SpawnAreaAtValidArea(i, list[i]);
			}
		}
	}

	// Token: 0x06004524 RID: 17700 RVA: 0x0017C3EC File Offset: 0x0017A5EC
	public void InitAllQteAreas()
	{
		ArtemisQteRingInfo ringInfo = this.RingInfo;
		if (ringInfo != null && ringInfo.IsWholeRing)
		{
			this.SpawnWholeRingAllArea();
			return;
		}
		this.SpawnIncompleteRingAllArea();
	}

	// Token: 0x06004525 RID: 17701 RVA: 0x0017C410 File Offset: 0x0017A610
	public void SpawnContinuousArea(int continuousIndex, EArtemisAreaType type = EArtemisAreaType.QteArea)
	{
		ArtemisQteRingInfo ringInfo = this.RingInfo;
		if (ringInfo != null && ringInfo.IsWholeRing)
		{
			switch (ArtemisActivityConfig.Instance.GetArtemisQteConfigById(this.GamePlayId).Value.RefreshType)
			{
			case 0:
				break;
			case 1:
				this.SpawnWholeRingAllArea();
				return;
			case 2:
				this.ResetAreaInLink(continuousIndex, type);
				if (this.RingInfo.GetQteAreas().Count == 0)
				{
					this.SpawnWholeRingAllArea();
					return;
				}
				break;
			default:
				return;
			}
		}
		else
		{
			List<RingArea> validAreas = this.RingInfo.GetValidAreas();
			this.ResetAreaInLink(continuousIndex, type);
			this.SpawnAreaAtValidArea(continuousIndex, validAreas[continuousIndex]);
		}
	}

	// Token: 0x06004526 RID: 17702 RVA: 0x0017C4AF File Offset: 0x0017A6AF
	public UUIItem GetQteAreaTexture(int continuousIndex)
	{
		return this.QteAreaTextures[continuousIndex].GetRootItem();
	}

	// Token: 0x06004527 RID: 17703 RVA: 0x0017C4C2 File Offset: 0x0017A6C2
	public UUIItem GetPerfectAreaTexture(int continuousIndex)
	{
		return this.PerfectAreaTextures[continuousIndex].GetRootItem();
	}

	// Token: 0x06004528 RID: 17704 RVA: 0x0017C4D8 File Offset: 0x0017A6D8
	public UniTask SpawnBgArea()
	{
		ArtemisQteProgressItem.<SpawnBgArea>d__63 <SpawnBgArea>d__;
		<SpawnBgArea>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<SpawnBgArea>d__.<>4__this = this;
		<SpawnBgArea>d__.<>1__state = -1;
		<SpawnBgArea>d__.<>t__builder.Start<ArtemisQteProgressItem.<SpawnBgArea>d__63>(ref <SpawnBgArea>d__);
		return <SpawnBgArea>d__.<>t__builder.Task;
	}

	// Token: 0x06004529 RID: 17705 RVA: 0x0017C51B File Offset: 0x0017A71B
	[NullableContext(2)]
	public void SetCurrentPlayingSequenceName(string sequenceName)
	{
		this.AllAreaPlayingSequenceName = sequenceName;
	}

	// Token: 0x0400353D RID: 13629
	private const int MIN_ANIM_TIME = 100;

	// Token: 0x0400353E RID: 13630
	private const int PROGRESS_START_ANGLE = -53;

	// Token: 0x0400353F RID: 13631
	private const int PROGRESS_END_ANGLE = 0;

	// Token: 0x04003540 RID: 13632
	private const int PAUSE_TIME = 0;

	// Token: 0x04003541 RID: 13633
	private static readonly int YAW_MAX_ANGLE = 720;

	// Token: 0x04003542 RID: 13634
	protected int GamePlayId;

	// Token: 0x04003543 RID: 13635
	protected ArtemisQteGameInfo GameInfo;

	// Token: 0x04003544 RID: 13636
	[Nullable(2)]
	protected ArtemisQteRingInfo RingInfo;

	// Token: 0x04003545 RID: 13637
	private readonly Rotator CurrentRotator = Rotator.Create();

	// Token: 0x04003546 RID: 13638
	private readonly Rotator CurrentFillAmountRotator = Rotator.Create();

	// Token: 0x04003547 RID: 13639
	private readonly Rotator AnimRotator = Rotator.Create();

	// Token: 0x04003548 RID: 13640
	private bool InAnim;

	// Token: 0x04003549 RID: 13641
	private int CurrentAnimTime;

	// Token: 0x0400354A RID: 13642
	private float AnimStartProgress;

	// Token: 0x0400354B RID: 13643
	private int AnimTime;

	// Token: 0x0400354C RID: 13644
	private float ArrowActiveStartYawAngle;

	// Token: 0x0400354D RID: 13645
	private float ArrowActiveEndYawAngle;

	// Token: 0x0400354E RID: 13646
	protected EArtemisRotateMode RotateMode;

	// Token: 0x0400354F RID: 13647
	protected float PeriodAlphaTotalTime;

	// Token: 0x04003550 RID: 13648
	protected float PeriodAlphaCurrentTime;

	// Token: 0x04003551 RID: 13649
	private readonly Dictionary<int, ArtemisQteRingSingleItem> QteAreaTextures = new Dictionary<int, ArtemisQteRingSingleItem>();

	// Token: 0x04003552 RID: 13650
	private readonly Dictionary<int, ArtemisQteRingSingleItem> PerfectAreaTextures = new Dictionary<int, ArtemisQteRingSingleItem>();

	// Token: 0x04003553 RID: 13651
	private readonly List<ArtemisQteRingSingleItem> CachedTexture = new List<ArtemisQteRingSingleItem>();

	// Token: 0x04003554 RID: 13652
	[Nullable(2)]
	private string AllAreaPlayingSequenceName;

	// Token: 0x04003555 RID: 13653
	[Nullable(2)]
	private string OncePlayingSequenceName;

	// Token: 0x04003556 RID: 13654
	private readonly List<ArtemisQteRingBgSingleItem> BgItemList = new List<ArtemisQteRingBgSingleItem>();

	// Token: 0x02006853 RID: 26707
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x04022656 RID: 140886
		public const int Setoff1Texture1 = 0;

		// Token: 0x04022657 RID: 140887
		public const int Setoff1Texture2 = 1;

		// Token: 0x04022658 RID: 140888
		public const int Setoff1Texture3 = 2;

		// Token: 0x04022659 RID: 140889
		public const int ClickPointPnl = 3;

		// Token: 0x0402265A RID: 140890
		public const int ControlBar = 4;

		// Token: 0x0402265B RID: 140891
		public const int ProgressPercebtText = 5;

		// Token: 0x0402265C RID: 140892
		public const int RotationBarPnl = 6;

		// Token: 0x0402265D RID: 140893
		public const int PointRotationPnl = 7;

		// Token: 0x0402265E RID: 140894
		public const int PnlClickPointLayout = 8;
	}
}
