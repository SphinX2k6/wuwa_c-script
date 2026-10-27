using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Encircle
{
	// Token: 0x02006670 RID: 26224
	[NullableContext(1)]
	[Nullable(0)]
	public class EncirclePlayView : UiViewBase
	{
		// Token: 0x06041B8D RID: 269197 RVA: 0x00FF046F File Offset: 0x00FEE66F
		public EncirclePlayView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06041B8E RID: 269198 RVA: 0x00FF0484 File Offset: 0x00FEE684
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(USpineSkeletonAnimationComponent)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(5, typeof(UUIText)),
				new ValueTuple<int, Type>(6, typeof(UUIText)),
				new ValueTuple<int, Type>(7, typeof(UUIItem)),
				new ValueTuple<int, Type>(8, typeof(UUIItem)),
				new ValueTuple<int, Type>(9, typeof(USpineSkeletonAnimationComponent))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(4, new Action(this.OnClickedBtnReset))
			};
		}

		// Token: 0x06041B8F RID: 269199 RVA: 0x00FF059C File Offset: 0x00FEE79C
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<Dictionary<int, IHexData>>(EEventName.EncircleReset, new Action<Dictionary<int, IHexData>>(this.OnEncircleReset));
			EventSystem.Instance.Add<IReadOnlySet<int>>(EEventName.OnActivityClose, new Action<IReadOnlySet<int>>(this.OnActivityClose));
		}

		// Token: 0x06041B90 RID: 269200 RVA: 0x00FF05D6 File Offset: 0x00FEE7D6
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.EncircleReset, new Action<Dictionary<int, IHexData>>(this.OnEncircleReset));
			EventSystem.Instance.Remove(EEventName.OnActivityClose, new Action<IReadOnlySet<int>>(this.OnActivityClose));
		}

		// Token: 0x06041B91 RID: 269201 RVA: 0x00FF0610 File Offset: 0x00FEE810
		protected override void OnStart()
		{
			this.CaptionItem = new PopupCaptionItem(base.GetItem(3));
			this.CaptionItem.SetCloseCallBack(new Action(this.OnClickedCloseButton));
			this.CaptionItem.SetHelpCallBack(new Action(this.OnClickHelpBtn));
			this.Param = (this.OpenParam as IEncircleArgs);
			this.InitMap();
			this.InitTween();
			this.ViewSequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.CanNotClick = false;
		}

		// Token: 0x06041B92 RID: 269202 RVA: 0x00FF0694 File Offset: 0x00FEE894
		protected override void OnBeforeDestroy()
		{
			this.ChildItems.Clear();
			if (this.EncirclePlayTweenEndCbWrapper1 != null)
			{
				ULGUIPlayTweenComponent monster1PlayTweenComp = this.Monster1PlayTweenComp;
				if (monster1PlayTweenComp != null)
				{
					ULGUIPlayTween playTween = monster1PlayTweenComp.GetPlayTween();
					if (playTween != null)
					{
						playTween.UnregisterOnComplete(this.EncirclePlayTweenEndCbWrapper1);
					}
				}
				this.EncirclePlayTweenEndCbWrapper1 = null;
			}
			if (this.EncirclePlayTweenEndCbWrapper2 != null)
			{
				ULGUIPlayTweenComponent monster1PlayTweenComp2 = this.Monster1PlayTweenComp;
				if (monster1PlayTweenComp2 != null)
				{
					ULGUIPlayTween playTween2 = monster1PlayTweenComp2.GetPlayTween();
					if (playTween2 != null)
					{
						playTween2.UnregisterOnComplete(this.EncirclePlayTweenEndCbWrapper2);
					}
				}
				this.EncirclePlayTweenEndCbWrapper2 = null;
			}
			if (this.OnTweenEnd != null)
			{
				DelegateUtils.ReleaseManualReleaseDelegate(this.OnTweenEnd);
			}
			USpineSkeletonAnimationComponent spine = base.GetSpine(2);
			if (spine != null)
			{
				spine.ClearTracks();
			}
			USpineSkeletonAnimationComponent spine2 = base.GetSpine(2);
			if (spine2 != null)
			{
				spine2.AnimationComplete.Clear();
			}
			USpineSkeletonAnimationComponent spine3 = base.GetSpine(9);
			if (spine3 != null)
			{
				spine3.ClearTracks();
			}
			USpineSkeletonAnimationComponent spine4 = base.GetSpine(9);
			if (spine4 != null)
			{
				spine4.AnimationComplete.Clear();
			}
			LevelSequencePlayer viewSequencePlayer = this.ViewSequencePlayer;
			if (viewSequencePlayer != null)
			{
				viewSequencePlayer.Clear();
			}
			this.ViewSequencePlayer = null;
			this.CanNotClick = false;
		}

		// Token: 0x06041B93 RID: 269203 RVA: 0x00FF07A0 File Offset: 0x00FEE9A0
		private void InitTween()
		{
			this.Monster1PlayTweenComp = (base.GetItem(1).GetOwner().GetComponentByClass(ULGUIPlayTweenComponent.StaticClass()) as ULGUIPlayTweenComponent);
			this.Monster2PlayTweenComp = (base.GetItem(8).GetOwner().GetComponentByClass(ULGUIPlayTweenComponent.StaticClass()) as ULGUIPlayTweenComponent);
		}

		// Token: 0x06041B94 RID: 269204 RVA: 0x00FF07FC File Offset: 0x00FEE9FC
		private void InitMap()
		{
			UUIItem item = base.GetItem(7);
			UUIItem item2 = base.GetItem(0);
			using (Dictionary<int, IHexData>.ValueCollection.Enumerator enumerator = this.Param.Hexes.Values.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					IHexData hexData = enumerator.Current;
					ValueTuple<int, int> planePos = EncircleUtils.Instance.HexPosToPlanePos(hexData.HexPos);
					UUIItem uuiitem = LguiUtil.Instance.CopyItem(item, item2);
					uuiitem.SetActive(true, false);
					ValueTuple<float, float> valueTuple = this.CalcItemOffset(planePos);
					uuiitem.SetAnchorOffsetX(valueTuple.Item1);
					uuiitem.SetAnchorOffsetY(valueTuple.Item2);
					EncirclePlayMapItemView newMapItemClass = new EncirclePlayMapItemView();
					this.CreateMapItemTemplate(uuiitem, newMapItemClass).ContinueWith(delegate()
					{
						newMapItemClass.SetPos(planePos.Item1, planePos.Item2);
						int num = EncircleUtils.Instance.PlanePosToKey(planePos.Item1, planePos.Item2);
						this.ChildItems[num] = newMapItemClass;
						newMapItemClass.ChangeNorMap(hexData.MapId, new int?(num));
						if (hexData.Type == EncircleHexType.Monster)
						{
							this.SetMonsterPos(hexData.MapId, newMapItemClass, true, 1, false, false);
						}
					});
				}
			}
			this.SetCurrentStepText(0);
			ActivityEncircleData encircleData = ActivityEncircleController.Instance.GetEncircleData();
			int currentChallengeId = EncirclePlayLevelController.Instance.GetCurrentChallengeId();
			this.SetBestRecordStepTxt(encircleData.GetChallengeRecord(currentChallengeId));
		}

		// Token: 0x06041B95 RID: 269205 RVA: 0x00FF0938 File Offset: 0x00FEEB38
		[NullableContext(0)]
		[return: TupleElementNames(new string[]
		{
			"OffsetX",
			"OffsetY"
		})]
		private ValueTuple<float, float> CalcItemOffset([TupleElementNames(new string[]
		{
			"PosX",
			"PosY"
		})] ValueTuple<int, int> planePos)
		{
			int num = (int)Math.Floor((double)this.Param.Height / 2.0);
			int num2 = (int)Math.Floor((double)this.Param.Width / 2.0);
			UUIItem item = base.GetItem(7);
			float width = item.GetWidth();
			float height = item.GetHeight();
			float num3 = height * ((this.Param.Height % 2 == 0) ? 0.5f : 0f);
			return new ValueTuple<float, float>(width * ((this.Param.Width % 2 == 0) ? 0.5f : 0f) + (float)(planePos.Item1 - num2) * width * 1.1f + (((planePos.Item2 + 1) % 2 == 1) ? (width * 0.55f) : 0f), -num3 + (float)(-(float)planePos.Item2 + num) * height * 0.84f);
		}

		// Token: 0x06041B96 RID: 269206 RVA: 0x00FF0A18 File Offset: 0x00FEEC18
		private void ResetMap(Dictionary<int, IHexData> hexes)
		{
			this.SetCurrentStepText(0);
			foreach (IHexData hexData in hexes.Values)
			{
				ValueTuple<int, int> valueTuple = EncircleUtils.Instance.HexPosToPlanePos(hexData.HexPos);
				EncirclePlayMapItemView encirclePlayMapItemView;
				this.ChildItems.TryGetValue(EncircleUtils.Instance.PlanePosToKey(valueTuple.Item1, valueTuple.Item2), out encirclePlayMapItemView);
				if (encirclePlayMapItemView != null)
				{
					encirclePlayMapItemView.ChangeNorMap(hexData.MapId, new int?(EncircleUtils.Instance.HexPosToKey(hexData.HexPos)));
					if (hexData.Type == EncircleHexType.Monster)
					{
						this.SetMonsterPos(hexData.MapId, encirclePlayMapItemView, true, 1, false, false);
					}
				}
			}
		}

		// Token: 0x06041B97 RID: 269207 RVA: 0x00FF0AE4 File Offset: 0x00FEECE4
		private UniTask CreateMapItemTemplate(UUIItem item, EncirclePlayMapItemView itemView)
		{
			EncirclePlayView.<CreateMapItemTemplate>d__25 <CreateMapItemTemplate>d__;
			<CreateMapItemTemplate>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateMapItemTemplate>d__.item = item;
			<CreateMapItemTemplate>d__.itemView = itemView;
			<CreateMapItemTemplate>d__.<>1__state = -1;
			<CreateMapItemTemplate>d__.<>t__builder.Start<EncirclePlayView.<CreateMapItemTemplate>d__25>(ref <CreateMapItemTemplate>d__);
			return <CreateMapItemTemplate>d__.<>t__builder.Task;
		}

		// Token: 0x06041B98 RID: 269208 RVA: 0x00FF0B30 File Offset: 0x00FEED30
		private void SetMonsterPos(int mapItemId, EncirclePlayMapItemView currentMapItemView, bool init = false, int towardDirection = 1, bool goSleep = false, bool goOutSide = false)
		{
			UUIItem item;
			ULGUIPlayTweenComponent monsterTween;
			USpineSkeletonAnimationComponent spine;
			int monsterIndex;
			if (mapItemId == 2)
			{
				item = base.GetItem(1);
				monsterTween = this.Monster1PlayTweenComp;
				spine = base.GetSpine(2);
				monsterIndex = 1;
			}
			else
			{
				if (mapItemId != 3)
				{
					return;
				}
				item = base.GetItem(8);
				monsterTween = this.Monster2PlayTweenComp;
				spine = base.GetSpine(9);
				monsterIndex = 2;
			}
			item.SetUIActive(true);
			if (towardDirection != 0 && item != null)
			{
				item.SetUIItemScale(new FVector((float)towardDirection, 1f, 1f));
			}
			UUIItem item2 = base.GetItem(0);
			float? num = ((item2 != null) ? new float?(item2.GetAnchorOffsetX()) : null) + ((currentMapItemView != null) ? new float?(currentMapItemView.GetRootItem().GetAnchorOffsetX()) : null);
			float? num2 = ((item2 != null) ? new float?(item2.GetAnchorOffsetY()) : null) + ((currentMapItemView != null) ? new float?(currentMapItemView.GetRootItem().GetAnchorOffsetY()) : null);
			if (init)
			{
				this.ResetSpineStatus(spine);
				this.StopTween(item);
				if (item != null)
				{
					item.SetAnchorOffsetX(num.GetValueOrDefault());
				}
				if (item != null)
				{
					item.SetAnchorOffsetY(num2.GetValueOrDefault());
				}
				if (spine != null)
				{
					spine.SetAnimation(0, ESpineAnimation.Idle.ToEnumString(), true);
					return;
				}
			}
			else
			{
				this.PlayTween(item, monsterTween, spine, num.GetValueOrDefault(), num2.GetValueOrDefault(), goSleep, goOutSide, monsterIndex);
			}
		}

		// Token: 0x06041B99 RID: 269209 RVA: 0x00FF0CF4 File Offset: 0x00FEEEF4
		private void PlayTween(UUIItem monsterItem, ULGUIPlayTweenComponent monsterTween, USpineSkeletonAnimationComponent monsterSpine, float offsetX, float offsetY, bool goSleep, bool goOutSide, int monsterIndex)
		{
			float anchorOffsetX = monsterItem.GetAnchorOffsetX();
			float anchorOffsetY = monsterItem.GetAnchorOffsetY();
			ULGUIPlayTween_Vector2 tween = monsterTween.GetPlayTween() as ULGUIPlayTween_Vector2;
			tween.from = Vector2D.Create((double)anchorOffsetX, (double)anchorOffsetY).ToUeVector2D(false);
			tween.to = Vector2D.Create((double)offsetX, (double)offsetY).ToUeVector2D(false);
			double x = monsterItem.D_K2_GetComponentScale().X;
			string sleepAnimName = "";
			string sleepStartAnimName = "";
			string animationName = "";
			if (x > 0.0)
			{
				sleepAnimName = ESpineAnimation.Sleep.ToEnumString();
				sleepStartAnimName = ESpineAnimation.SleepStart.ToEnumString();
				animationName = ESpineAnimation.WakeUp.ToEnumString();
			}
			else if (x < 0.0)
			{
				sleepAnimName = ESpineAnimation.Sleep2.ToEnumString();
				sleepStartAnimName = ESpineAnimation.SleepStart2.ToEnumString();
				animationName = ESpineAnimation.WakeUp2.ToEnumString();
			}
			if (anchorOffsetX == offsetX && anchorOffsetY == offsetY)
			{
				UTrackEntry current = monsterSpine.GetCurrent(0);
				if (!(((current != null) ? current.getAnimationName() : null) == sleepAnimName))
				{
					UTrackEntry current2 = monsterSpine.GetCurrent(0);
					if (!(((current2 != null) ? current2.getAnimationName() : null) == sleepStartAnimName))
					{
						monsterSpine.SetAnimation(0, sleepAnimName, true);
						goto IL_1C6;
					}
				}
				monsterSpine.SetAnimation(0, animationName, false);
				monsterSpine.AnimationComplete.Add(delegate(UTrackEntry entry)
				{
					monsterSpine.SetAnimation(0, ESpineAnimation.Idle.ToEnumString(), true);
				});
				IL_1C6:
				EncirclePlayLevelController.Instance.TryPushMoveToNextState();
				return;
			}
			Action<UTrackEntry> <>9__2;
			Action<UTrackEntry> <>9__3;
			this.OnTweenEnd = delegate()
			{
				if (goOutSide)
				{
					tween.from = Vector2D.Create((double)offsetX, (double)offsetY).ToUeVector2D(false);
					tween.to = Vector2D.Create((double)(offsetX * 1.3f), (double)(offsetY * 1.3f)).ToUeVector2D(false);
					this.ResetSpineStatus(monsterSpine);
					monsterSpine.SetAnimation(0, ESpineAnimation.WalkAway.ToEnumString(), false);
					if (this.EncirclePlayTweenEndCbWrapper1 != null)
					{
						tween.UnregisterOnComplete(this.EncirclePlayTweenEndCbWrapper1);
					}
					if (this.EncirclePlayTweenEndCbWrapper2 != null)
					{
						tween.UnregisterOnComplete(this.EncirclePlayTweenEndCbWrapper2);
					}
					monsterTween.Stop();
					monsterTween.Play();
					FSpineAnimationCompleteDelegate animationComplete = monsterSpine.AnimationComplete;
					Action<UTrackEntry> callback;
					if ((callback = <>9__2) == null)
					{
						callback = (<>9__2 = delegate(UTrackEntry entry)
						{
							this.PushNextState();
							this.CanNotClick = false;
						});
					}
					animationComplete.Add(callback);
					return;
				}
				if (goSleep)
				{
					monsterSpine.SetAnimation(0, sleepStartAnimName, false);
					FSpineAnimationCompleteDelegate animationComplete2 = monsterSpine.AnimationComplete;
					Action<UTrackEntry> callback2;
					if ((callback2 = <>9__3) == null)
					{
						callback2 = (<>9__3 = delegate(UTrackEntry entry)
						{
							monsterSpine.SetAnimation(0, sleepAnimName, true);
						});
					}
					animationComplete2.Add(callback2);
				}
				else
				{
					monsterSpine.SetAnimation(0, ESpineAnimation.Idle.ToEnumString(), true);
				}
				this.PushNextState();
			};
			if (monsterIndex == 1)
			{
				DelegateUtils.ReleaseManualReleaseDelegate(this.OnTweenEnd);
				if (this.EncirclePlayTweenEndCbWrapper1 != null)
				{
					tween.UnregisterOnComplete(this.EncirclePlayTweenEndCbWrapper1);
				}
				FLGUIPlayTweenCompleteDynamicDelegate flguiplayTweenCompleteDynamicDelegate = DelegateUtils.ToManualReleaseDelegate<FLGUIPlayTweenCompleteDynamicDelegate>(this.OnTweenEnd);
				this.EncirclePlayTweenEndCbWrapper1 = tween.RegisterOnComplete(flguiplayTweenCompleteDynamicDelegate);
			}
			else
			{
				DelegateUtils.ReleaseManualReleaseDelegate(this.OnTweenEnd);
				if (this.EncirclePlayTweenEndCbWrapper2 != null)
				{
					tween.UnregisterOnComplete(this.EncirclePlayTweenEndCbWrapper2);
				}
				FLGUIPlayTweenCompleteDynamicDelegate flguiplayTweenCompleteDynamicDelegate2 = DelegateUtils.ToManualReleaseDelegate<FLGUIPlayTweenCompleteDynamicDelegate>(this.OnTweenEnd);
				this.EncirclePlayTweenEndCbWrapper2 = tween.RegisterOnComplete(flguiplayTweenCompleteDynamicDelegate2);
			}
			if (goOutSide)
			{
				this.CanNotClick = true;
			}
			monsterTween.Stop();
			monsterTween.Play();
			monsterSpine.SetAnimation(0, ESpineAnimation.Walk.ToEnumString(), false);
		}

		// Token: 0x06041B9A RID: 269210 RVA: 0x00FF0FB8 File Offset: 0x00FEF1B8
		private void StopTween(UUIItem monsterItem)
		{
			TArray<UActorComponent> tarray = monsterItem.GetOwner().K2_GetComponentsByClass(ULGUIPlayTweenComponent.StaticClass());
			int num = tarray.Num();
			for (int i = 0; i < num; i++)
			{
				(tarray.Get(i) as ULGUIPlayTweenComponent).Stop();
			}
		}

		// Token: 0x06041B9B RID: 269211 RVA: 0x00FF1000 File Offset: 0x00FEF200
		public void ShowSuccessNiagara()
		{
			foreach (EncirclePlayMapItemView encirclePlayMapItemView in this.ChildItems.Values)
			{
				if (encirclePlayMapItemView != null)
				{
					encirclePlayMapItemView.ShowSuccess();
				}
			}
		}

		// Token: 0x06041B9C RID: 269212 RVA: 0x00FF105C File Offset: 0x00FEF25C
		public void SetMonsterDead(int monsterId)
		{
			USpineSkeletonAnimationComponent uspineSkeletonAnimationComponent = null;
			if (monsterId == 2)
			{
				uspineSkeletonAnimationComponent = base.GetSpine(2);
			}
			else if (monsterId == 3)
			{
				uspineSkeletonAnimationComponent = base.GetSpine(9);
			}
			this.ResetSpineStatus(uspineSkeletonAnimationComponent);
			if (uspineSkeletonAnimationComponent != null)
			{
				uspineSkeletonAnimationComponent.SetAnimation(0, ESpineAnimation.Die.ToEnumString(), false);
			}
		}

		// Token: 0x06041B9D RID: 269213 RVA: 0x00FF109F File Offset: 0x00FEF29F
		private void PushNextState()
		{
			EncirclePlayLevelController.Instance.TryPushMoveToNextState();
		}

		// Token: 0x06041B9E RID: 269214 RVA: 0x00FF10AC File Offset: 0x00FEF2AC
		private void OnEncircleReset(Dictionary<int, IHexData> hexes)
		{
			LevelSequencePlayer viewSequencePlayer = this.ViewSequencePlayer;
			if (viewSequencePlayer != null)
			{
				viewSequencePlayer.StopCurrentSequence(false, true);
			}
			this.ViewSequencePlayer.PlayLevelSequenceByName("Refresh", false, null, false);
			this.ResetMap(hexes);
		}

		// Token: 0x06041B9F RID: 269215 RVA: 0x00FF10F0 File Offset: 0x00FEF2F0
		public void SetAllMonsterDead(List<int> monsterIds)
		{
			USpineSkeletonAnimationComponent monsterSpine = null;
			foreach (int num in monsterIds)
			{
				if (num == 2)
				{
					monsterSpine = base.GetSpine(2);
				}
				else if (num == 3)
				{
					monsterSpine = base.GetSpine(9);
				}
				this.ResetSpineStatus(monsterSpine);
				USpineSkeletonAnimationComponent monsterSpine4 = monsterSpine;
				if (monsterSpine4 != null)
				{
					monsterSpine4.SetAnimation(0, ESpineAnimation.Die.ToEnumString(), false);
				}
				this.ShowSuccessNiagara();
			}
			this.CanNotClick = true;
			Action<UTrackEntry> executeWin = null;
			executeWin = delegate(UTrackEntry trackEntry)
			{
				USpineSkeletonAnimationComponent monsterSpine3 = monsterSpine;
				if (monsterSpine3 != null)
				{
					monsterSpine3.AnimationComplete.Remove(executeWin);
				}
				EncirclePlayLevelController.Instance.ExecuteWin();
				this.CanNotClick = false;
			};
			USpineSkeletonAnimationComponent monsterSpine2 = monsterSpine;
			if (monsterSpine2 == null)
			{
				return;
			}
			monsterSpine2.AnimationComplete.Add(executeWin);
		}

		// Token: 0x06041BA0 RID: 269216 RVA: 0x00FF11D8 File Offset: 0x00FEF3D8
		public void ChangeEncircleMap(int mapItemId, IHexPos currentPos, [Nullable(2)] IHexPos oldPos)
		{
			EncircleHexType? mapItemType = ActivityEncircleConfig.Instance.GetMapItemType(mapItemId);
			int num = EncircleUtils.Instance.HexPosToKey(currentPos);
			EncircleHexType? encircleHexType = mapItemType;
			EncircleHexType encircleHexType2 = EncircleHexType.Monster;
			if (encircleHexType.GetValueOrDefault() == encircleHexType2 & encircleHexType != null)
			{
				if (oldPos != null)
				{
					EncirclePlayMapItemView encirclePlayMapItemView;
					this.ChildItems.TryGetValue(EncircleUtils.Instance.HexPosToKey(oldPos), out encirclePlayMapItemView);
					if (encirclePlayMapItemView != null)
					{
						encirclePlayMapItemView.ChangeNorMap(0, null);
					}
				}
				EncirclePlayMapItemView encirclePlayMapItemView2;
				this.ChildItems.TryGetValue(num, out encirclePlayMapItemView2);
				EncircleHexType? type = encirclePlayMapItemView2.GetType2();
				bool goSleep = false;
				if (type != null)
				{
					encircleHexType = type;
					encircleHexType2 = EncircleHexType.Trap;
					if (encircleHexType.GetValueOrDefault() == encircleHexType2 & encircleHexType != null)
					{
						goSleep = true;
					}
				}
				bool goOutSide = false;
				if (EncirclePlayLevelController.Instance.CheckIsBoundary(currentPos))
				{
					goOutSide = true;
				}
				if (encirclePlayMapItemView2 != null)
				{
					encirclePlayMapItemView2.ChangeNorMap(mapItemId, new int?(num));
				}
				this.SetMonsterPos(mapItemId, encirclePlayMapItemView2, false, this.GetTowardDirection(oldPos, currentPos), goSleep, goOutSide);
				return;
			}
			EncirclePlayMapItemView encirclePlayMapItemView3;
			this.ChildItems.TryGetValue(num, out encirclePlayMapItemView3);
			if (encirclePlayMapItemView3 != null)
			{
				encirclePlayMapItemView3.ChangeNorMap(mapItemId, new int?(num));
			}
		}

		// Token: 0x06041BA1 RID: 269217 RVA: 0x00FF12E1 File Offset: 0x00FEF4E1
		private int GetTowardDirection([Nullable(2)] IHexPos oldPos, IHexPos currentPos)
		{
			if (oldPos == null)
			{
				return 1;
			}
			if (oldPos == currentPos)
			{
				return 0;
			}
			if (currentPos.PosX - oldPos.PosX < 0)
			{
				return -1;
			}
			return 1;
		}

		// Token: 0x06041BA2 RID: 269218 RVA: 0x00FF1304 File Offset: 0x00FEF504
		public void ShowItemMoveEffect(int posKey, bool value)
		{
			EncirclePlayMapItemView encirclePlayMapItemView;
			this.ChildItems.TryGetValue(posKey, out encirclePlayMapItemView);
			if (encirclePlayMapItemView != null)
			{
				encirclePlayMapItemView.ShowMonsterMoveEffect(value);
			}
		}

		// Token: 0x06041BA3 RID: 269219 RVA: 0x00FF132C File Offset: 0x00FEF52C
		public void RefreshStepText()
		{
			if (this.DifficultyStep > 0)
			{
				base.GetText(5).SetText("<color=#fed966>" + this.DifficultyStep.ToString() + "</color>+" + this.CurrentStep.ToString(), true);
				return;
			}
			base.GetText(5).SetText(this.CurrentStep.ToString(), true);
		}

		// Token: 0x06041BA4 RID: 269220 RVA: 0x00FF138D File Offset: 0x00FEF58D
		public void SetCurrentStepText(int count)
		{
			this.CurrentStep = count;
			this.RefreshStepText();
		}

		// Token: 0x06041BA5 RID: 269221 RVA: 0x00FF139C File Offset: 0x00FEF59C
		public void SetDifficultyStepTxt(int count)
		{
			this.DifficultyStep = count;
			this.RefreshStepText();
		}

		// Token: 0x06041BA6 RID: 269222 RVA: 0x00FF13AC File Offset: 0x00FEF5AC
		public void SetBestRecordStepTxt(int count)
		{
			string newText = count.ToString();
			if (count == 0)
			{
				newText = "--";
			}
			base.GetText(6).SetText(newText, true);
		}

		// Token: 0x06041BA7 RID: 269223 RVA: 0x00FF13D8 File Offset: 0x00FEF5D8
		public void ResetSpineStatus(USpineSkeletonAnimationComponent monsterSpine)
		{
			monsterSpine.SetToSetupPose();
			monsterSpine.ClearTracks();
			monsterSpine.AnimationComplete.Clear();
		}

		// Token: 0x06041BA8 RID: 269224 RVA: 0x00FF13F4 File Offset: 0x00FEF5F4
		private void OnClickedBtnReset()
		{
			if (this.CanNotClick)
			{
				return;
			}
			Action value = delegate()
			{
			};
			Action value2 = delegate()
			{
				EncirclePlayLevelController.Instance.ResetEncircle();
			};
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.EncircleResetConfirm);
			confirmBoxDataNew.FunctionMap.Add(1, value);
			confirmBoxDataNew.FunctionMap.Add(2, value2);
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x06041BA9 RID: 269225 RVA: 0x00FF147C File Offset: 0x00FEF67C
		private void OnClickedCloseButton()
		{
			if (this.CanNotClick)
			{
				return;
			}
			Action value = delegate()
			{
			};
			Action value2 = delegate()
			{
				EncirclePlayLevelController.Instance.CloseEncircle();
			};
			ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.EncircleExitConfirm);
			confirmBoxDataNew.FunctionMap.Add(1, value);
			confirmBoxDataNew.FunctionMap.Add(2, value2);
			ConfirmBoxController.Instance.ShowConfirmBoxNew(confirmBoxDataNew);
		}

		// Token: 0x06041BAA RID: 269226 RVA: 0x00FF1503 File Offset: 0x00FEF703
		private void OnClickHelpBtn()
		{
			if (this.CanNotClick)
			{
				return;
			}
			HelpController.Instance.OpenHelpById(504);
		}

		// Token: 0x06041BAB RID: 269227 RVA: 0x00FF151D File Offset: 0x00FEF71D
		private void OnActivityClose(IReadOnlySet<int> closeActivities)
		{
			if (closeActivities.Contains(ActivityEncircleController.Instance.ActivityId))
			{
				ActivityController.Instance.ShowActivityRefreshAndBackToBattleView();
			}
		}

		// Token: 0x0402231C RID: 140060
		private const int MONSTER1_ITEM_ID = 2;

		// Token: 0x0402231D RID: 140061
		private const int MONSTER2_ITEM_ID = 3;

		// Token: 0x0402231E RID: 140062
		private const int HELP_ID = 504;

		// Token: 0x0402231F RID: 140063
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x04022320 RID: 140064
		[Nullable(2)]
		private IEncircleArgs Param;

		// Token: 0x04022321 RID: 140065
		private readonly Dictionary<int, EncirclePlayMapItemView> ChildItems = new Dictionary<int, EncirclePlayMapItemView>();

		// Token: 0x04022322 RID: 140066
		[Nullable(2)]
		private ULGUIPlayTweenComponent Monster1PlayTweenComp;

		// Token: 0x04022323 RID: 140067
		[Nullable(2)]
		private ULGUIPlayTweenComponent Monster2PlayTweenComp;

		// Token: 0x04022324 RID: 140068
		[Nullable(2)]
		private FLGUIDelegateHandleWrapper EncirclePlayTweenEndCbWrapper1;

		// Token: 0x04022325 RID: 140069
		[Nullable(2)]
		private FLGUIDelegateHandleWrapper EncirclePlayTweenEndCbWrapper2;

		// Token: 0x04022326 RID: 140070
		[Nullable(2)]
		private LevelSequencePlayer ViewSequencePlayer;

		// Token: 0x04022327 RID: 140071
		[Nullable(2)]
		private Action OnTweenEnd;

		// Token: 0x04022328 RID: 140072
		private int CurrentStep;

		// Token: 0x04022329 RID: 140073
		private int DifficultyStep;

		// Token: 0x0402232A RID: 140074
		private bool CanNotClick;
	}
}
