using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001102 RID: 4354
[NullableContext(1)]
[Nullable(0)]
public class ArtemisQteProgressItem : UiPanelBase
{
	// Token: 0x0600716E RID: 29038 RVA: 0x001728F8 File Offset: 0x00170AF8
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

	// Token: 0x0600716F RID: 29039 RVA: 0x001729D6 File Offset: 0x00170BD6
	protected override void OnStart()
	{
		base.GetItem(3).SetUIActive(false);
	}

	// Token: 0x06007170 RID: 29040 RVA: 0x001729E5 File Offset: 0x00170BE5
	protected override void OnBeforeDestroy()
	{
		this.BgItemList.Clear();
		this.QteAreaTextures.Clear();
		this.PerfectAreaTextures.Clear();
		this.CachedTexture.Clear();
	}

	// Token: 0x06007171 RID: 29041 RVA: 0x00172A14 File Offset: 0x00170C14
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

	// Token: 0x06007172 RID: 29042 RVA: 0x00172A9C File Offset: 0x00170C9C
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

	// Token: 0x06007173 RID: 29043 RVA: 0x00172B00 File Offset: 0x00170D00
	public void OnTick(float delta)
	{
		float currentProgress = this.GetCurrentProgress();
		this.RefreshAnimProgress(currentProgress, delta);
		this.RefreshProgress(currentProgress);
		this.RefreshArrow(delta);
	}

	// Token: 0x06007174 RID: 29044 RVA: 0x00172B2C File Offset: 0x00170D2C
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

	// Token: 0x06007175 RID: 29045 RVA: 0x00172E34 File Offset: 0x00171034
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

	// Token: 0x06007176 RID: 29046 RVA: 0x00172EC8 File Offset: 0x001710C8
	private int GetCurrentArrowStayCellIndex()
	{
		return (int)(Math.Floor((double)(Math.Abs(this.CurrentRotator.Yaw) % 360f / 10f)) + 1.0);
	}

	// Token: 0x06007177 RID: 29047 RVA: 0x00172EF8 File Offset: 0x001710F8
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

	// Token: 0x06007178 RID: 29048 RVA: 0x00172F90 File Offset: 0x00171190
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

	// Token: 0x06007179 RID: 29049 RVA: 0x00173050 File Offset: 0x00171250
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

	// Token: 0x0600717A RID: 29050 RVA: 0x001730F8 File Offset: 0x001712F8
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

	// Token: 0x0600717B RID: 29051 RVA: 0x001731A0 File Offset: 0x001713A0
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

	// Token: 0x0600717C RID: 29052 RVA: 0x001732AC File Offset: 0x001714AC
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

	// Token: 0x0600717D RID: 29053 RVA: 0x001732C4 File Offset: 0x001714C4
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

	// Token: 0x0600717E RID: 29054 RVA: 0x00173334 File Offset: 0x00171534
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

	// Token: 0x0600717F RID: 29055 RVA: 0x001733C4 File Offset: 0x001715C4
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

	// Token: 0x06007180 RID: 29056 RVA: 0x00173454 File Offset: 0x00171654
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

	// Token: 0x06007181 RID: 29057 RVA: 0x00173528 File Offset: 0x00171728
	private float GetCurrentProgress()
	{
		int currentScore = this.GameInfo.CurrentScore;
		int maxScore = ArtemisActivityConfig.Instance.GetArtemisQteConfigById(this.GamePlayId).Value.MaxScore;
		return MathUtils.Instance.Clamp((float)currentScore / (float)maxScore, 0f, 1f);
	}

	// Token: 0x06007182 RID: 29058 RVA: 0x0017357C File Offset: 0x0017177C
	public void StartAnimProgress()
	{
		this.AnimStartProgress = this.GetCurrentProgress();
		this.CurrentAnimTime = 0;
		this.InAnim = true;
	}

	// Token: 0x06007183 RID: 29059 RVA: 0x00173598 File Offset: 0x00171798
	public void EnterNextRound()
	{
		this.AnimStartProgress = 0f;
	}

	// Token: 0x06007184 RID: 29060 RVA: 0x001735A8 File Offset: 0x001717A8
	private int GetAreaRandomSize(int[] rangeConfig)
	{
		int result = 3;
		if (rangeConfig != null && rangeConfig.Length >= 2)
		{
			result = this.RandomRangeInt(rangeConfig[0], rangeConfig[1]);
		}
		return result;
	}

	// Token: 0x06007185 RID: 29061 RVA: 0x001735CE File Offset: 0x001717CE
	private int RandomRangeInt(int start, int end)
	{
		return Math.Min(end, (int)Math.Floor(MathUtils.Instance.GetRandomRange((double)start, (double)(end + 1))));
	}

	// Token: 0x06007186 RID: 29062 RVA: 0x001735EC File Offset: 0x001717EC
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

	// Token: 0x06007187 RID: 29063 RVA: 0x0017367B File Offset: 0x0017187B
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

	// Token: 0x06007188 RID: 29064 RVA: 0x001736B8 File Offset: 0x001718B8
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

	// Token: 0x06007189 RID: 29065 RVA: 0x00173764 File Offset: 0x00171964
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

	// Token: 0x0600718A RID: 29066 RVA: 0x001737C8 File Offset: 0x001719C8
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

	// Token: 0x0600718B RID: 29067 RVA: 0x00173824 File Offset: 0x00171A24
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

	// Token: 0x0600718C RID: 29068 RVA: 0x001738E4 File Offset: 0x00171AE4
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

	// Token: 0x0600718D RID: 29069 RVA: 0x001739E8 File Offset: 0x00171BE8
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

	// Token: 0x0600718E RID: 29070 RVA: 0x00173A30 File Offset: 0x00171C30
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

	// Token: 0x0600718F RID: 29071 RVA: 0x00173A54 File Offset: 0x00171C54
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

	// Token: 0x06007190 RID: 29072 RVA: 0x00173AF3 File Offset: 0x00171CF3
	public UUIItem GetQteAreaTexture(int continuousIndex)
	{
		return this.QteAreaTextures[continuousIndex].GetRootItem();
	}

	// Token: 0x06007191 RID: 29073 RVA: 0x00173B06 File Offset: 0x00171D06
	public UUIItem GetPerfectAreaTexture(int continuousIndex)
	{
		return this.PerfectAreaTextures[continuousIndex].GetRootItem();
	}

	// Token: 0x06007192 RID: 29074 RVA: 0x00173B1C File Offset: 0x00171D1C
	public UniTask SpawnBgArea()
	{
		ArtemisQteProgressItem.<SpawnBgArea>d__63 <SpawnBgArea>d__;
		<SpawnBgArea>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<SpawnBgArea>d__.<>4__this = this;
		<SpawnBgArea>d__.<>1__state = -1;
		<SpawnBgArea>d__.<>t__builder.Start<ArtemisQteProgressItem.<SpawnBgArea>d__63>(ref <SpawnBgArea>d__);
		return <SpawnBgArea>d__.<>t__builder.Task;
	}

	// Token: 0x06007193 RID: 29075 RVA: 0x00173B5F File Offset: 0x00171D5F
	[NullableContext(2)]
	public void SetCurrentPlayingSequenceName(string sequenceName)
	{
		this.AllAreaPlayingSequenceName = sequenceName;
	}

	// Token: 0x040034A4 RID: 13476
	private const int MIN_ANIM_TIME = 100;

	// Token: 0x040034A5 RID: 13477
	private const int PROGRESS_START_ANGLE = -53;

	// Token: 0x040034A6 RID: 13478
	private const int PROGRESS_END_ANGLE = 0;

	// Token: 0x040034A7 RID: 13479
	private const int PAUSE_TIME = 0;

	// Token: 0x040034A8 RID: 13480
	private static readonly int YAW_MAX_ANGLE = 720;

	// Token: 0x040034A9 RID: 13481
	protected int GamePlayId;

	// Token: 0x040034AA RID: 13482
	protected ArtemisQteGameInfo GameInfo;

	// Token: 0x040034AB RID: 13483
	[Nullable(2)]
	protected ArtemisQteRingInfo RingInfo;

	// Token: 0x040034AC RID: 13484
	private readonly Rotator CurrentRotator = Rotator.Create();

	// Token: 0x040034AD RID: 13485
	private readonly Rotator CurrentFillAmountRotator = Rotator.Create();

	// Token: 0x040034AE RID: 13486
	private readonly Rotator AnimRotator = Rotator.Create();

	// Token: 0x040034AF RID: 13487
	private bool InAnim;

	// Token: 0x040034B0 RID: 13488
	private int CurrentAnimTime;

	// Token: 0x040034B1 RID: 13489
	private float AnimStartProgress;

	// Token: 0x040034B2 RID: 13490
	private int AnimTime;

	// Token: 0x040034B3 RID: 13491
	private float ArrowActiveStartYawAngle;

	// Token: 0x040034B4 RID: 13492
	private float ArrowActiveEndYawAngle;

	// Token: 0x040034B5 RID: 13493
	protected EArtemisRotateMode RotateMode;

	// Token: 0x040034B6 RID: 13494
	protected float PeriodAlphaTotalTime;

	// Token: 0x040034B7 RID: 13495
	protected float PeriodAlphaCurrentTime;

	// Token: 0x040034B8 RID: 13496
	private readonly Dictionary<int, ArtemisQteRingSingleItem> QteAreaTextures = new Dictionary<int, ArtemisQteRingSingleItem>();

	// Token: 0x040034B9 RID: 13497
	private readonly Dictionary<int, ArtemisQteRingSingleItem> PerfectAreaTextures = new Dictionary<int, ArtemisQteRingSingleItem>();

	// Token: 0x040034BA RID: 13498
	private readonly List<ArtemisQteRingSingleItem> CachedTexture = new List<ArtemisQteRingSingleItem>();

	// Token: 0x040034BB RID: 13499
	[Nullable(2)]
	private string AllAreaPlayingSequenceName;

	// Token: 0x040034BC RID: 13500
	[Nullable(2)]
	private string OncePlayingSequenceName;

	// Token: 0x040034BD RID: 13501
	private readonly List<ArtemisQteRingBgSingleItem> BgItemList = new List<ArtemisQteRingBgSingleItem>();

	// Token: 0x020076BF RID: 30399
	[NullableContext(0)]
	private class EComponents
	{
		// Token: 0x0402730D RID: 160525
		public const int Setoff1Texture1 = 0;

		// Token: 0x0402730E RID: 160526
		public const int Setoff1Texture2 = 1;

		// Token: 0x0402730F RID: 160527
		public const int Setoff1Texture3 = 2;

		// Token: 0x04027310 RID: 160528
		public const int ClickPointPnl = 3;

		// Token: 0x04027311 RID: 160529
		public const int ControlBar = 4;

		// Token: 0x04027312 RID: 160530
		public const int ProgressPercebtText = 5;

		// Token: 0x04027313 RID: 160531
		public const int RotationBarPnl = 6;

		// Token: 0x04027314 RID: 160532
		public const int PointRotationPnl = 7;

		// Token: 0x04027315 RID: 160533
		public const int PnlClickPointLayout = 8;
	}
}
