using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x0200681C RID: 26652
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlLevelBgItem : UiPanelBase
	{
		// Token: 0x17009739 RID: 38713
		// (get) Token: 0x06042802 RID: 272386 RVA: 0x01028471 File Offset: 0x01026671
		// (set) Token: 0x06042803 RID: 272387 RVA: 0x01028479 File Offset: 0x01026679
		public float SpineAnimPlayDelay
		{
			get
			{
				return this.SpineAnimDelayTime;
			}
			set
			{
				this.SpineAnimDelayTime = ((value < 0f) ? 0f : value);
			}
		}

		// Token: 0x06042804 RID: 272388 RVA: 0x01028494 File Offset: 0x01026694
		protected unsafe override void OnRegisterComponent()
		{
			int num = 2;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(USpineSkeletonAnimationComponent));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06042805 RID: 272389 RVA: 0x010284FD File Offset: 0x010266FD
		protected override void OnStart()
		{
			this.SequencePlayer = new LevelSequencePlayer(base.GetRootItem());
		}

		// Token: 0x06042806 RID: 272390 RVA: 0x01028510 File Offset: 0x01026710
		protected override void OnBeforeDestroy()
		{
			this.ClearPendingSpinePlay();
			this.CancelLoadSpine();
			this.CancelSpineAnimPlayTimer();
			this.ClearSpineTrack();
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.Clear();
			}
			this.SequencePlayer = null;
		}

		// Token: 0x06042807 RID: 272391 RVA: 0x01028544 File Offset: 0x01026744
		public void PlaySequence(string sequenceName)
		{
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.PlayLevelSequenceByName(sequenceName, false, null, false);
		}

		// Token: 0x06042808 RID: 272392 RVA: 0x0102856D File Offset: 0x0102676D
		public void PlayClose()
		{
			this.PlaySequence("Close");
		}

		// Token: 0x06042809 RID: 272393 RVA: 0x0102857C File Offset: 0x0102677C
		public void Refresh(DangoBrawlLevelData levelData)
		{
			this.SetSpriteByPath(levelData.BgNumIcon, base.GetSprite(0), false, null, null);
			this.RefreshSpine(levelData.FirstSpineAtlasPath, levelData.FirstSpineSkeletonDataPath, levelData.FirstSpineAnim, levelData.FirstSpineLoopAnim);
		}

		// Token: 0x0604280A RID: 272394 RVA: 0x010285C8 File Offset: 0x010267C8
		public void RefreshSpine(string atlasPath, string skeletonPath, string spineAnim, string spineLoopAnim)
		{
			DangoBrawlLevelBgItem.<>c__DisplayClass23_0 CS$<>8__locals1 = new DangoBrawlLevelBgItem.<>c__DisplayClass23_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.atlasPath = atlasPath;
			CS$<>8__locals1.skeletonPath = skeletonPath;
			CS$<>8__locals1.spineAnim = spineAnim;
			CS$<>8__locals1.spineLoopAnim = spineLoopAnim;
			UiAsyncTask task = new UiAsyncTask("DangoBrawlLevelBgItem", delegate()
			{
				DangoBrawlLevelBgItem.<>c__DisplayClass23_0.<<RefreshSpine>b__0>d <<RefreshSpine>b__0>d;
				<<RefreshSpine>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<RefreshSpine>b__0>d.<>4__this = CS$<>8__locals1;
				<<RefreshSpine>b__0>d.<>1__state = -1;
				<<RefreshSpine>b__0>d.<>t__builder.Start<DangoBrawlLevelBgItem.<>c__DisplayClass23_0.<<RefreshSpine>b__0>d>(ref <<RefreshSpine>b__0>d);
				return <<RefreshSpine>b__0>d.<>t__builder.Task;
			}, null);
			base.RunAsyncTask(task).Forget();
		}

		// Token: 0x0604280B RID: 272395 RVA: 0x01028624 File Offset: 0x01026824
		private UniTask RefreshSpineAsync(string atlasPath, string skeletonPath, string spineAnim, string spineLoopAnim)
		{
			DangoBrawlLevelBgItem.<RefreshSpineAsync>d__24 <RefreshSpineAsync>d__;
			<RefreshSpineAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshSpineAsync>d__.<>4__this = this;
			<RefreshSpineAsync>d__.atlasPath = atlasPath;
			<RefreshSpineAsync>d__.skeletonPath = skeletonPath;
			<RefreshSpineAsync>d__.spineAnim = spineAnim;
			<RefreshSpineAsync>d__.spineLoopAnim = spineLoopAnim;
			<RefreshSpineAsync>d__.<>1__state = -1;
			<RefreshSpineAsync>d__.<>t__builder.Start<DangoBrawlLevelBgItem.<RefreshSpineAsync>d__24>(ref <RefreshSpineAsync>d__);
			return <RefreshSpineAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0604280C RID: 272396 RVA: 0x01028688 File Offset: 0x01026888
		public void PlaySequenceThenSpine(string sequenceName, float delayTime = 0f)
		{
			this.SpineAnimPlayDelay = delayTime;
			this.PendingSequenceName = sequenceName;
			if (this.IsLoading || string.IsNullOrEmpty(this.LoadedAtlasPath))
			{
				this.PendingSpinePlay = true;
				return;
			}
			this.ClearPendingSpinePlay();
			this.DoPlaySequenceThenSpine(sequenceName);
		}

		// Token: 0x0604280D RID: 272397 RVA: 0x010286C2 File Offset: 0x010268C2
		private void DoPlaySequenceThenSpine(string sequenceName)
		{
			this.HoldSpineAtAnimFirstFrame(this.SpineAnim);
			if (!string.IsNullOrEmpty(sequenceName))
			{
				this.PlaySequence(sequenceName);
			}
			this.PlaySpineAnimDelay();
		}

		// Token: 0x0604280E RID: 272398 RVA: 0x010286E5 File Offset: 0x010268E5
		private void PlaySpineAnimDelay()
		{
			this.CancelSpineAnimPlayTimer();
			this.SpineAnimPlayTimer = TimerSystem.Instance.Delay(delegate(float _)
			{
				this.SpineAnimPlayTimer = null;
				this.ResumeHeldSpineAnimThenLoop();
			}, this.SpineAnimDelayTime * 1000f, null, null, true, 1f);
		}

		// Token: 0x0604280F RID: 272399 RVA: 0x0102871D File Offset: 0x0102691D
		private void CancelSpineAnimPlayTimer()
		{
			TimerHandle spineAnimPlayTimer = this.SpineAnimPlayTimer;
			if (spineAnimPlayTimer != null)
			{
				spineAnimPlayTimer.Remove();
			}
			this.SpineAnimPlayTimer = null;
		}

		// Token: 0x06042810 RID: 272400 RVA: 0x01028738 File Offset: 0x01026938
		private void ClearPendingSpinePlay()
		{
			this.PendingSpinePlay = false;
			this.PendingSequenceName = "";
		}

		// Token: 0x06042811 RID: 272401 RVA: 0x0102874C File Offset: 0x0102694C
		[return: Nullable(0)]
		private UniTask<bool> LoadSpineAsync(string atlasPath, string skeletonPath)
		{
			DangoBrawlLevelBgItem.<LoadSpineAsync>d__30 <LoadSpineAsync>d__;
			<LoadSpineAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<LoadSpineAsync>d__.<>4__this = this;
			<LoadSpineAsync>d__.atlasPath = atlasPath;
			<LoadSpineAsync>d__.skeletonPath = skeletonPath;
			<LoadSpineAsync>d__.<>1__state = -1;
			<LoadSpineAsync>d__.<>t__builder.Start<DangoBrawlLevelBgItem.<LoadSpineAsync>d__30>(ref <LoadSpineAsync>d__);
			return <LoadSpineAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06042812 RID: 272402 RVA: 0x0102879F File Offset: 0x0102699F
		private void CancelLoadSpine()
		{
			LoadAsyncPromise<USpineAtlasAsset> spineAtlasPromise = this.SpineAtlasPromise;
			if (spineAtlasPromise != null)
			{
				spineAtlasPromise.CancelAsyncLoad();
			}
			LoadAsyncPromise<USpineSkeletonDataAsset> spineSkeletonDataPromise = this.SpineSkeletonDataPromise;
			if (spineSkeletonDataPromise != null)
			{
				spineSkeletonDataPromise.CancelAsyncLoad();
			}
			this.SpineAtlasPromise = null;
			this.SpineSkeletonDataPromise = null;
		}

		// Token: 0x06042813 RID: 272403 RVA: 0x010287D4 File Offset: 0x010269D4
		private void HoldSpineAtAnimFirstFrame(string anim)
		{
			this.ClearSpineTrack();
			USpineSkeletonAnimationComponent spine = base.GetSpine(1);
			if (spine == null || !spine.IsValid())
			{
				return;
			}
			spine.AnimationComplete.Clear();
			string text = (!string.IsNullOrEmpty(anim)) ? anim : this.SpineLoopAnim;
			if (string.IsNullOrEmpty(text))
			{
				spine.ClearTracks();
				return;
			}
			UTrackEntry utrackEntry = spine.SetAnimation(0, text, false);
			if (utrackEntry != null)
			{
				utrackEntry.SetTrackTime(0f);
			}
			if (utrackEntry != null)
			{
				utrackEntry.SetTimeScale(0f);
			}
			this.SpineTrackEntry = utrackEntry;
		}

		// Token: 0x06042814 RID: 272404 RVA: 0x01028854 File Offset: 0x01026A54
		private void ResumeHeldSpineAnimThenLoop()
		{
			if (this.IsLoading)
			{
				return;
			}
			if (this.SpineTrackEntry != null && !string.IsNullOrEmpty(this.SpineAnim) && !string.IsNullOrEmpty(this.SpineLoopAnim))
			{
				this.SpineTrackEntry.SetTimeScale(1f);
				this.SpineTrackEntry.AnimationComplete.Clear();
				this.SpineTrackEntry.AnimationComplete.Add(new Action<UTrackEntry>(this.OnSpineAnimComplete));
				return;
			}
			this.PlaySpineAnimThenLoop(this.SpineAnim, this.SpineLoopAnim);
		}

		// Token: 0x06042815 RID: 272405 RVA: 0x010288DC File Offset: 0x01026ADC
		private void PlaySpineAnimThenLoop(string anim, string loopAnim)
		{
			if (this.IsLoading)
			{
				return;
			}
			USpineSkeletonAnimationComponent spine = base.GetSpine(1);
			if (spine == null || !spine.IsValid())
			{
				return;
			}
			this.ClearSpineTrack();
			spine.AnimationComplete.Clear();
			if (string.IsNullOrEmpty(anim))
			{
				if (!string.IsNullOrEmpty(loopAnim))
				{
					spine.SetAnimation(0, loopAnim, true);
				}
				return;
			}
			if (string.IsNullOrEmpty(loopAnim))
			{
				spine.SetAnimation(0, anim, true);
				return;
			}
			UTrackEntry utrackEntry = spine.SetAnimation(0, anim, false);
			this.SpineTrackEntry = utrackEntry;
			if (utrackEntry != null)
			{
				utrackEntry.AnimationComplete.Add(new Action<UTrackEntry>(this.OnSpineAnimComplete));
			}
		}

		// Token: 0x06042816 RID: 272406 RVA: 0x01028970 File Offset: 0x01026B70
		private void OnSpineAnimComplete(UTrackEntry entry)
		{
			if (entry != this.SpineTrackEntry)
			{
				return;
			}
			this.SpineTrackEntry = null;
			USpineSkeletonAnimationComponent spine = base.GetSpine(1);
			if (spine == null || !spine.IsValid() || string.IsNullOrEmpty(this.SpineLoopAnim))
			{
				return;
			}
			spine.SetAnimation(0, this.SpineLoopAnim, true);
		}

		// Token: 0x06042817 RID: 272407 RVA: 0x010289BE File Offset: 0x01026BBE
		private void ClearSpineTrack()
		{
			this.SpineTrackEntry = null;
		}

		// Token: 0x04022A70 RID: 141936
		private string LoadedAtlasPath = "";

		// Token: 0x04022A71 RID: 141937
		private string LoadedSkeletonPath = "";

		// Token: 0x04022A72 RID: 141938
		private string SpineAnim = "";

		// Token: 0x04022A73 RID: 141939
		private string SpineLoopAnim = "";

		// Token: 0x04022A74 RID: 141940
		private bool IsLoading;

		// Token: 0x04022A75 RID: 141941
		[Nullable(2)]
		private UTrackEntry SpineTrackEntry;

		// Token: 0x04022A76 RID: 141942
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private LoadAsyncPromise<USpineAtlasAsset> SpineAtlasPromise;

		// Token: 0x04022A77 RID: 141943
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private LoadAsyncPromise<USpineSkeletonDataAsset> SpineSkeletonDataPromise;

		// Token: 0x04022A78 RID: 141944
		[Nullable(2)]
		private LevelSequencePlayer SequencePlayer;

		// Token: 0x04022A79 RID: 141945
		private float SpineAnimDelayTime;

		// Token: 0x04022A7A RID: 141946
		[Nullable(2)]
		private TimerHandle SpineAnimPlayTimer;

		// Token: 0x04022A7B RID: 141947
		private bool PendingSpinePlay;

		// Token: 0x04022A7C RID: 141948
		private string PendingSequenceName = "";

		// Token: 0x0200C9B1 RID: 51633
		[NullableContext(0)]
		private enum EBgItemComponent
		{
			// Token: 0x0403CECB RID: 249547
			SprLevelNum,
			// Token: 0x0403CECC RID: 249548
			RoleSpine
		}
	}
}
