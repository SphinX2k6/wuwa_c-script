using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001B97 RID: 7063
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchPopupRewardItem : UiPanelBase
{
	// Token: 0x0600D249 RID: 53833 RVA: 0x003046F4 File Offset: 0x003028F4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIArtText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600D24A RID: 53834 RVA: 0x00304780 File Offset: 0x00302980
	protected override UniTask OnBeforeStartAsync()
	{
		FloroRanchPopupRewardItem.<OnBeforeStartAsync>d__18 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FloroRanchPopupRewardItem.<OnBeforeStartAsync>d__18>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600D24B RID: 53835 RVA: 0x003047C3 File Offset: 0x003029C3
	public void InitCurve(UCurveFloat lerpCurve)
	{
		this.LerpCurve = lerpCurve;
	}

	// Token: 0x0600D24C RID: 53836 RVA: 0x003047CC File Offset: 0x003029CC
	public void Tick(float delta)
	{
		if (this.IsPlayingPopup)
		{
			this.StartTime += delta;
			float floatValue = this.LerpCurve.GetFloatValue(this.StartTime / this.Duration);
			Vector.Lerp(this.StartPoint, this.EndPoint, (double)floatValue, this.TempVector);
			UUIItem rootItem = base.GetRootItem();
			FVector fvector = this.TempVector.ToUeVectorOld();
			rootItem.SetUIWorldLocation(fvector);
			if (this.StartTime >= this.Duration + this.StayTime || FloroRanchGamePlayModel.Instance.IsSkip)
			{
				UUIItem rootItem2 = base.GetRootItem();
				fvector = this.EndPoint.ToUeVectorOld();
				rootItem2.SetUIWorldLocation(fvector);
				this.ClearPopupCurve();
				Action popUpFinishCallback = this.PopUpFinishCallback;
				if (popUpFinishCallback == null)
				{
					return;
				}
				popUpFinishCallback();
			}
			return;
		}
		if (this.IsPlayingBezier)
		{
			float num = this.StartTime / this.Duration;
			num *= num;
			Vector pos = this.BezierCurve.GetPos((double)((num > 1f) ? 1f : num));
			UUIItem rootItem3 = base.GetRootItem();
			FVector fvector = pos.ToUeVectorOld();
			rootItem3.SetUIWorldLocation(fvector);
			this.StartTime += delta;
			if (this.StartTime >= this.Duration || FloroRanchGamePlayModel.Instance.IsSkip)
			{
				UUIItem rootItem4 = base.GetRootItem();
				fvector = this.EndPoint.ToUeVectorOld();
				rootItem4.SetUIWorldLocation(fvector);
				Action bezierFinishCallback = this.BezierFinishCallback;
				if (bezierFinishCallback != null)
				{
					bezierFinishCallback();
				}
				this.ClearBezierCurve();
			}
		}
	}

	// Token: 0x0600D24D RID: 53837 RVA: 0x00304934 File Offset: 0x00302B34
	public void PopupReward(Vector pointA, Vector pointB, [Nullable(2)] Action finishCallback = null)
	{
		if (FloroRanchGamePlayModel.Instance.IsSkip)
		{
			if (finishCallback != null)
			{
				finishCallback();
			}
			return;
		}
		this.StartPoint = pointA;
		this.EndPoint = pointB;
		this.StartTime = 0f;
		this.Duration = 500f;
		this.StayTime = FloroRanchGamePlayModel.Instance.GetPopupRewardStayTime();
		base.GetArtText(2).SetUIActive(true);
		this.IsPlayingPopup = true;
		UUIItem rootItem = base.GetRootItem();
		FVector fvector = pointA.ToUeVectorOld();
		rootItem.SetUIWorldLocation(fvector);
		this.PopUpFinishCallback = finishCallback;
	}

	// Token: 0x0600D24E RID: 53838 RVA: 0x003049BC File Offset: 0x00302BBC
	public void PlayBezierCurve(Vector pointA, Vector pointB, Action finishCallback)
	{
		if (FloroRanchGamePlayModel.Instance.IsSkip)
		{
			if (finishCallback != null)
			{
				finishCallback();
			}
			return;
		}
		this.StartPoint = pointA;
		this.EndPoint = pointB;
		this.StartTime = 0f;
		this.Duration = FloroRanchGamePlayModel.Instance.GetBezierCurveTime();
		base.GetArtText(2).SetUIActive(false);
		Vector upVetcor = (this.EndPoint.X > this.StartPoint.X) ? FloroRanchDefine.FloroRanchRewardRightDirection : FloroRanchDefine.FloroRanchRewardLeftDirection;
		this.BezierCurve.InitByFactor(this.StartPoint, this.EndPoint, upVetcor, 0.5, 0.5);
		this.IsPlayingBezier = true;
		this.BezierFinishCallback = finishCallback;
	}

	// Token: 0x0600D24F RID: 53839 RVA: 0x00304A74 File Offset: 0x00302C74
	public void Refresh(long count, string icon)
	{
		UUIArtText artText = base.GetArtText(2);
		artText.SetUIActive(true);
		artText.SetText(count.ToString());
		if (count >= 1000L)
		{
			artText.SetArtTextData(this.RedArtTextData);
		}
		else if (count >= 100L)
		{
			artText.SetArtTextData(this.YellowArtTextData);
		}
		else
		{
			artText.SetArtTextData(this.NormalArtTextData);
		}
		base.GetTexture(0).SetUIActive(false);
		base.SetTextureByPath(icon, base.GetTexture(1), null, null);
	}

	// Token: 0x0600D250 RID: 53840 RVA: 0x00304AFC File Offset: 0x00302CFC
	public void PlayShowRewardAnim()
	{
		if (this.LevelSequencePlayer == null)
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(base.GetRootItem());
		}
		base.GetRootItem().SetUIActive(true);
		this.LevelSequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
	}

	// Token: 0x0600D251 RID: 53841 RVA: 0x00304B4C File Offset: 0x00302D4C
	public UniTask PlayHideRewardAnim()
	{
		FloroRanchPopupRewardItem.<PlayHideRewardAnim>d__25 <PlayHideRewardAnim>d__;
		<PlayHideRewardAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayHideRewardAnim>d__.<>4__this = this;
		<PlayHideRewardAnim>d__.<>1__state = -1;
		<PlayHideRewardAnim>d__.<>t__builder.Start<FloroRanchPopupRewardItem.<PlayHideRewardAnim>d__25>(ref <PlayHideRewardAnim>d__);
		return <PlayHideRewardAnim>d__.<>t__builder.Task;
	}

	// Token: 0x0600D252 RID: 53842 RVA: 0x00304B90 File Offset: 0x00302D90
	public UniTask PlayCloseRewardAnim()
	{
		FloroRanchPopupRewardItem.<PlayCloseRewardAnim>d__26 <PlayCloseRewardAnim>d__;
		<PlayCloseRewardAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayCloseRewardAnim>d__.<>4__this = this;
		<PlayCloseRewardAnim>d__.<>1__state = -1;
		<PlayCloseRewardAnim>d__.<>t__builder.Start<FloroRanchPopupRewardItem.<PlayCloseRewardAnim>d__26>(ref <PlayCloseRewardAnim>d__);
		return <PlayCloseRewardAnim>d__.<>t__builder.Task;
	}

	// Token: 0x0600D253 RID: 53843 RVA: 0x00304BD4 File Offset: 0x00302DD4
	public void FollowPosition(Vector position)
	{
		UUIItem rootItem = base.GetRootItem();
		FVector fvector = position.ToUeVectorOld();
		rootItem.SetUIWorldLocation(fvector);
	}

	// Token: 0x0600D254 RID: 53844 RVA: 0x00304BF5 File Offset: 0x00302DF5
	protected override void OnBeforeDestroy()
	{
		this.ClearBezierCurve();
		this.ClearPopupCurve();
	}

	// Token: 0x0600D255 RID: 53845 RVA: 0x00304C03 File Offset: 0x00302E03
	private void ClearBezierCurve()
	{
		this.StartTime = 0f;
		this.Duration = 0f;
		this.BezierFinishCallback = null;
		this.IsPlayingBezier = false;
	}

	// Token: 0x0600D256 RID: 53846 RVA: 0x00304C29 File Offset: 0x00302E29
	private void ClearPopupCurve()
	{
		this.StartTime = 0f;
		this.Duration = 0f;
		this.IsPlayingPopup = false;
	}

	// Token: 0x04006060 RID: 24672
	public bool IsPlayingBezier;

	// Token: 0x04006061 RID: 24673
	private bool IsPlayingPopup;

	// Token: 0x04006062 RID: 24674
	private UCurveFloat LerpCurve;

	// Token: 0x04006063 RID: 24675
	private Vector StartPoint = Vector.Create();

	// Token: 0x04006064 RID: 24676
	private Vector EndPoint = Vector.Create();

	// Token: 0x04006065 RID: 24677
	private readonly Vector TempVector = Vector.Create();

	// Token: 0x04006066 RID: 24678
	private readonly BeizerQuadraticCurve BezierCurve = new BeizerQuadraticCurve();

	// Token: 0x04006067 RID: 24679
	private float StartTime;

	// Token: 0x04006068 RID: 24680
	private float Duration;

	// Token: 0x04006069 RID: 24681
	private float StayTime;

	// Token: 0x0400606A RID: 24682
	[Nullable(2)]
	private Action BezierFinishCallback;

	// Token: 0x0400606B RID: 24683
	[Nullable(2)]
	private Action PopUpFinishCallback;

	// Token: 0x0400606C RID: 24684
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x0400606D RID: 24685
	[Nullable(2)]
	private ULGUIArtTextData NormalArtTextData;

	// Token: 0x0400606E RID: 24686
	[Nullable(2)]
	private ULGUIArtTextData YellowArtTextData;

	// Token: 0x0400606F RID: 24687
	[Nullable(2)]
	private ULGUIArtTextData RedArtTextData;

	// Token: 0x02008125 RID: 33061
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x0402A27A RID: 172666
		public const int MapIcon = 0;

		// Token: 0x0402A27B RID: 172667
		public const int Icon = 1;

		// Token: 0x0402A27C RID: 172668
		public const int Count = 2;
	}
}
