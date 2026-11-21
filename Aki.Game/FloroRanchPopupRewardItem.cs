using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001056 RID: 4182
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchPopupRewardItem : UiPanelBase
{
	// Token: 0x0600A65A RID: 42586 RVA: 0x0030F7CC File Offset: 0x0030D9CC
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

	// Token: 0x0600A65B RID: 42587 RVA: 0x0030F858 File Offset: 0x0030DA58
	protected override UniTask OnBeforeStartAsync()
	{
		FloroRanchPopupRewardItem.<OnBeforeStartAsync>d__18 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FloroRanchPopupRewardItem.<OnBeforeStartAsync>d__18>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600A65C RID: 42588 RVA: 0x0030F89B File Offset: 0x0030DA9B
	public void InitCurve(UCurveFloat lerpCurve)
	{
		this.LerpCurve = lerpCurve;
	}

	// Token: 0x0600A65D RID: 42589 RVA: 0x0030F8A4 File Offset: 0x0030DAA4
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

	// Token: 0x0600A65E RID: 42590 RVA: 0x0030FA0C File Offset: 0x0030DC0C
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

	// Token: 0x0600A65F RID: 42591 RVA: 0x0030FA94 File Offset: 0x0030DC94
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

	// Token: 0x0600A660 RID: 42592 RVA: 0x0030FB4C File Offset: 0x0030DD4C
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

	// Token: 0x0600A661 RID: 42593 RVA: 0x0030FBD4 File Offset: 0x0030DDD4
	public void PlayShowRewardAnim()
	{
		if (this.LevelSequencePlayer == null)
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(base.GetRootItem());
		}
		base.GetRootItem().SetUIActive(true);
		this.LevelSequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
	}

	// Token: 0x0600A662 RID: 42594 RVA: 0x0030FC24 File Offset: 0x0030DE24
	public UniTask PlayHideRewardAnim()
	{
		FloroRanchPopupRewardItem.<PlayHideRewardAnim>d__25 <PlayHideRewardAnim>d__;
		<PlayHideRewardAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayHideRewardAnim>d__.<>4__this = this;
		<PlayHideRewardAnim>d__.<>1__state = -1;
		<PlayHideRewardAnim>d__.<>t__builder.Start<FloroRanchPopupRewardItem.<PlayHideRewardAnim>d__25>(ref <PlayHideRewardAnim>d__);
		return <PlayHideRewardAnim>d__.<>t__builder.Task;
	}

	// Token: 0x0600A663 RID: 42595 RVA: 0x0030FC68 File Offset: 0x0030DE68
	public UniTask PlayCloseRewardAnim()
	{
		FloroRanchPopupRewardItem.<PlayCloseRewardAnim>d__26 <PlayCloseRewardAnim>d__;
		<PlayCloseRewardAnim>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PlayCloseRewardAnim>d__.<>4__this = this;
		<PlayCloseRewardAnim>d__.<>1__state = -1;
		<PlayCloseRewardAnim>d__.<>t__builder.Start<FloroRanchPopupRewardItem.<PlayCloseRewardAnim>d__26>(ref <PlayCloseRewardAnim>d__);
		return <PlayCloseRewardAnim>d__.<>t__builder.Task;
	}

	// Token: 0x0600A664 RID: 42596 RVA: 0x0030FCAC File Offset: 0x0030DEAC
	public void FollowPosition(Vector position)
	{
		UUIItem rootItem = base.GetRootItem();
		FVector fvector = position.ToUeVectorOld();
		rootItem.SetUIWorldLocation(fvector);
	}

	// Token: 0x0600A665 RID: 42597 RVA: 0x0030FCCD File Offset: 0x0030DECD
	protected override void OnBeforeDestroy()
	{
		this.ClearBezierCurve();
		this.ClearPopupCurve();
	}

	// Token: 0x0600A666 RID: 42598 RVA: 0x0030FCDB File Offset: 0x0030DEDB
	private void ClearBezierCurve()
	{
		this.StartTime = 0f;
		this.Duration = 0f;
		this.BezierFinishCallback = null;
		this.IsPlayingBezier = false;
	}

	// Token: 0x0600A667 RID: 42599 RVA: 0x0030FD01 File Offset: 0x0030DF01
	private void ClearPopupCurve()
	{
		this.StartTime = 0f;
		this.Duration = 0f;
		this.IsPlayingPopup = false;
	}

	// Token: 0x0400612F RID: 24879
	public bool IsPlayingBezier;

	// Token: 0x04006130 RID: 24880
	private bool IsPlayingPopup;

	// Token: 0x04006131 RID: 24881
	private UCurveFloat LerpCurve;

	// Token: 0x04006132 RID: 24882
	private Vector StartPoint = Vector.Create();

	// Token: 0x04006133 RID: 24883
	private Vector EndPoint = Vector.Create();

	// Token: 0x04006134 RID: 24884
	private readonly Vector TempVector = Vector.Create();

	// Token: 0x04006135 RID: 24885
	private readonly BeizerQuadraticCurve BezierCurve = new BeizerQuadraticCurve();

	// Token: 0x04006136 RID: 24886
	private float StartTime;

	// Token: 0x04006137 RID: 24887
	private float Duration;

	// Token: 0x04006138 RID: 24888
	private float StayTime;

	// Token: 0x04006139 RID: 24889
	[Nullable(2)]
	private Action BezierFinishCallback;

	// Token: 0x0400613A RID: 24890
	[Nullable(2)]
	private Action PopUpFinishCallback;

	// Token: 0x0400613B RID: 24891
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x0400613C RID: 24892
	[Nullable(2)]
	private ULGUIArtTextData NormalArtTextData;

	// Token: 0x0400613D RID: 24893
	[Nullable(2)]
	private ULGUIArtTextData YellowArtTextData;

	// Token: 0x0400613E RID: 24894
	[Nullable(2)]
	private ULGUIArtTextData RedArtTextData;

	// Token: 0x020072B3 RID: 29363
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x040255AE RID: 153006
		public const int MapIcon = 0;

		// Token: 0x040255AF RID: 153007
		public const int Icon = 1;

		// Token: 0x040255B0 RID: 153008
		public const int Count = 2;
	}
}
