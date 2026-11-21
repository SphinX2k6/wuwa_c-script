using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace Aki.Game.Module.Activity.ActivityContent.Encircle.View
{
	// Token: 0x02003020 RID: 12320
	[NullableContext(1)]
	[Nullable(0)]
	public class EncirclePlayView : UiViewBase
	{
		// Token: 0x0601D3B5 RID: 119733 RVA: 0x008EC47B File Offset: 0x008EA67B
		public EncirclePlayView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0601D3B6 RID: 119734 RVA: 0x008EC490 File Offset: 0x008EA690
		protected unsafe override void OnRegisterComponent()
		{
			int num = 10;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(USpineSkeletonAnimationComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(USpineSkeletonAnimationComponent));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action(this.OnClickedBtnReset));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0601D3B7 RID: 119735 RVA: 0x008EC640 File Offset: 0x008EA840
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<Dictionary<int, IHexData>>(EEventName.EncircleReset, new Action<Dictionary<int, IHexData>>(this.OnEncircleReset));
			EventSystem.Instance.Add<IReadOnlySet<int>>(EEventName.OnActivityClose, new Action<IReadOnlySet<int>>(this.OnActivityClose));
		}

		// Token: 0x0601D3B8 RID: 119736 RVA: 0x008EC67A File Offset: 0x008EA87A
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.EncircleReset, new Action<Dictionary<int, IHexData>>(this.OnEncircleReset));
			EventSystem.Instance.Remove(EEventName.OnActivityClose, new Action<IReadOnlySet<int>>(this.OnActivityClose));
		}

		// Token: 0x0601D3B9 RID: 119737 RVA: 0x008EC6B4 File Offset: 0x008EA8B4
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

		// Token: 0x0601D3BA RID: 119738 RVA: 0x008EC738 File Offset: 0x008EA938
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

		// Token: 0x0601D3BB RID: 119739 RVA: 0x008EC844 File Offset: 0x008EAA44
		private void InitTween()
		{
			this.Monster1PlayTweenComp = (base.GetItem(1).GetOwner().GetComponentByClass(ULGUIPlayTweenComponent.StaticClass()) as ULGUIPlayTweenComponent);
			this.Monster2PlayTweenComp = (base.GetItem(8).GetOwner().GetComponentByClass(ULGUIPlayTweenComponent.StaticClass()) as ULGUIPlayTweenComponent);
		}

		// Token: 0x0601D3BC RID: 119740 RVA: 0x008EC8A0 File Offset: 0x008EAAA0
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

		// Token: 0x0601D3BD RID: 119741 RVA: 0x008EC9DC File Offset: 0x008EABDC
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

		// Token: 0x0601D3BE RID: 119742 RVA: 0x008ECABC File Offset: 0x008EACBC
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

		// Token: 0x0601D3BF RID: 119743 RVA: 0x008ECB88 File Offset: 0x008EAD88
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

		// Token: 0x0601D3C0 RID: 119744 RVA: 0x008ECBD4 File Offset: 0x008EADD4
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

		// Token: 0x0601D3C1 RID: 119745 RVA: 0x008ECD98 File Offset: 0x008EAF98
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

		// Token: 0x0601D3C2 RID: 119746 RVA: 0x008ED05C File Offset: 0x008EB25C
		private void StopTween(UUIItem monsterItem)
		{
			TArray<UActorComponent> tarray = monsterItem.GetOwner().K2_GetComponentsByClass(ULGUIPlayTweenComponent.StaticClass());
			int num = tarray.Num();
			for (int i = 0; i < num; i++)
			{
				(tarray.Get(i) as ULGUIPlayTweenComponent).Stop();
			}
		}

		// Token: 0x0601D3C3 RID: 119747 RVA: 0x008ED0A4 File Offset: 0x008EB2A4
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

		// Token: 0x0601D3C4 RID: 119748 RVA: 0x008ED100 File Offset: 0x008EB300
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

		// Token: 0x0601D3C5 RID: 119749 RVA: 0x008ED143 File Offset: 0x008EB343
		private void PushNextState()
		{
			EncirclePlayLevelController.Instance.TryPushMoveToNextState();
		}

		// Token: 0x0601D3C6 RID: 119750 RVA: 0x008ED150 File Offset: 0x008EB350
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

		// Token: 0x0601D3C7 RID: 119751 RVA: 0x008ED194 File Offset: 0x008EB394
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

		// Token: 0x0601D3C8 RID: 119752 RVA: 0x008ED27C File Offset: 0x008EB47C
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

		// Token: 0x0601D3C9 RID: 119753 RVA: 0x008ED385 File Offset: 0x008EB585
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

		// Token: 0x0601D3CA RID: 119754 RVA: 0x008ED3A8 File Offset: 0x008EB5A8
		public void ShowItemMoveEffect(int posKey, bool value)
		{
			EncirclePlayMapItemView encirclePlayMapItemView;
			this.ChildItems.TryGetValue(posKey, out encirclePlayMapItemView);
			if (encirclePlayMapItemView != null)
			{
				encirclePlayMapItemView.ShowMonsterMoveEffect(value);
			}
		}

		// Token: 0x0601D3CB RID: 119755 RVA: 0x008ED3D0 File Offset: 0x008EB5D0
		public void RefreshStepText()
		{
			if (this.DifficultyStep > 0)
			{
				base.GetText(5).SetText("<color=#fed966>" + this.DifficultyStep.ToString() + "</color>+" + this.CurrentStep.ToString(), true);
				return;
			}
			base.GetText(5).SetText(this.CurrentStep.ToString(), true);
		}

		// Token: 0x0601D3CC RID: 119756 RVA: 0x008ED431 File Offset: 0x008EB631
		public void SetCurrentStepText(int count)
		{
			this.CurrentStep = count;
			this.RefreshStepText();
		}

		// Token: 0x0601D3CD RID: 119757 RVA: 0x008ED440 File Offset: 0x008EB640
		public void SetDifficultyStepTxt(int count)
		{
			this.DifficultyStep = count;
			this.RefreshStepText();
		}

		// Token: 0x0601D3CE RID: 119758 RVA: 0x008ED450 File Offset: 0x008EB650
		public void SetBestRecordStepTxt(int count)
		{
			string newText = count.ToString();
			if (count == 0)
			{
				newText = "--";
			}
			base.GetText(6).SetText(newText, true);
		}

		// Token: 0x0601D3CF RID: 119759 RVA: 0x008ED47C File Offset: 0x008EB67C
		public void ResetSpineStatus(USpineSkeletonAnimationComponent monsterSpine)
		{
			monsterSpine.SetToSetupPose();
			monsterSpine.ClearTracks();
			monsterSpine.AnimationComplete.Clear();
		}

		// Token: 0x0601D3D0 RID: 119760 RVA: 0x008ED498 File Offset: 0x008EB698
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

		// Token: 0x0601D3D1 RID: 119761 RVA: 0x008ED520 File Offset: 0x008EB720
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

		// Token: 0x0601D3D2 RID: 119762 RVA: 0x008ED5A7 File Offset: 0x008EB7A7
		private void OnClickHelpBtn()
		{
			if (this.CanNotClick)
			{
				return;
			}
			HelpController.Instance.OpenHelpById(504);
		}

		// Token: 0x0601D3D3 RID: 119763 RVA: 0x008ED5C1 File Offset: 0x008EB7C1
		private void OnActivityClose(IReadOnlySet<int> closeActivities)
		{
			if (closeActivities.Contains(ActivityEncircleController.Instance.ActivityId))
			{
				ActivityController.Instance.ShowActivityRefreshAndBackToBattleView();
			}
		}

		// Token: 0x0400F626 RID: 63014
		private const int MONSTER1_ITEM_ID = 2;

		// Token: 0x0400F627 RID: 63015
		private const int MONSTER2_ITEM_ID = 3;

		// Token: 0x0400F628 RID: 63016
		private const int HELP_ID = 504;

		// Token: 0x0400F629 RID: 63017
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0400F62A RID: 63018
		[Nullable(2)]
		private IEncircleArgs Param;

		// Token: 0x0400F62B RID: 63019
		private readonly Dictionary<int, EncirclePlayMapItemView> ChildItems = new Dictionary<int, EncirclePlayMapItemView>();

		// Token: 0x0400F62C RID: 63020
		[Nullable(2)]
		private ULGUIPlayTweenComponent Monster1PlayTweenComp;

		// Token: 0x0400F62D RID: 63021
		[Nullable(2)]
		private ULGUIPlayTweenComponent Monster2PlayTweenComp;

		// Token: 0x0400F62E RID: 63022
		[Nullable(2)]
		private FLGUIDelegateHandleWrapper EncirclePlayTweenEndCbWrapper1;

		// Token: 0x0400F62F RID: 63023
		[Nullable(2)]
		private FLGUIDelegateHandleWrapper EncirclePlayTweenEndCbWrapper2;

		// Token: 0x0400F630 RID: 63024
		[Nullable(2)]
		private LevelSequencePlayer ViewSequencePlayer;

		// Token: 0x0400F631 RID: 63025
		[Nullable(2)]
		private Action OnTweenEnd;

		// Token: 0x0400F632 RID: 63026
		private int CurrentStep;

		// Token: 0x0400F633 RID: 63027
		private int DifficultyStep;

		// Token: 0x0400F634 RID: 63028
		private bool CanNotClick;
	}
}
