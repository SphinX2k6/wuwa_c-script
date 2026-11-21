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
	// Token: 0x0200576C RID: 22380
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlLevelBgItem : UiPanelBase
	{
		// Token: 0x17006A7A RID: 27258
		// (get) Token: 0x06037357 RID: 226135 RVA: 0x00F699B5 File Offset: 0x00F67BB5
		// (set) Token: 0x06037358 RID: 226136 RVA: 0x00F699BD File Offset: 0x00F67BBD
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

		// Token: 0x06037359 RID: 226137 RVA: 0x00F699D8 File Offset: 0x00F67BD8
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

		// Token: 0x0603735A RID: 226138 RVA: 0x00F69A41 File Offset: 0x00F67C41
		protected override void OnStart()
		{
			this.SequencePlayer = new LevelSequencePlayer(base.GetRootItem());
		}

		// Token: 0x0603735B RID: 226139 RVA: 0x00F69A54 File Offset: 0x00F67C54
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

		// Token: 0x0603735C RID: 226140 RVA: 0x00F69A88 File Offset: 0x00F67C88
		public void PlaySequence(string sequenceName)
		{
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.PlayLevelSequenceByName(sequenceName, false, null, false);
		}

		// Token: 0x0603735D RID: 226141 RVA: 0x00F69AB1 File Offset: 0x00F67CB1
		public void PlayClose()
		{
			this.PlaySequence("Close");
		}

		// Token: 0x0603735E RID: 226142 RVA: 0x00F69AC0 File Offset: 0x00F67CC0
		public void Refresh(DangoBrawlLevelData levelData)
		{
			this.SetSpriteByPath(levelData.BgNumIcon, base.GetSprite(0), false, null, null);
			this.RefreshSpine(levelData.FirstSpineAtlasPath, levelData.FirstSpineSkeletonDataPath, levelData.FirstSpineAnim, levelData.FirstSpineLoopAnim);
		}

		// Token: 0x0603735F RID: 226143 RVA: 0x00F69B0C File Offset: 0x00F67D0C
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

		// Token: 0x06037360 RID: 226144 RVA: 0x00F69B68 File Offset: 0x00F67D68
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

		// Token: 0x06037361 RID: 226145 RVA: 0x00F69BCC File Offset: 0x00F67DCC
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

		// Token: 0x06037362 RID: 226146 RVA: 0x00F69C06 File Offset: 0x00F67E06
		private void DoPlaySequenceThenSpine(string sequenceName)
		{
			this.HoldSpineAtAnimFirstFrame(this.SpineAnim);
			if (!string.IsNullOrEmpty(sequenceName))
			{
				this.PlaySequence(sequenceName);
			}
			this.PlaySpineAnimDelay();
		}

		// Token: 0x06037363 RID: 226147 RVA: 0x00F69C29 File Offset: 0x00F67E29
		private void PlaySpineAnimDelay()
		{
			this.CancelSpineAnimPlayTimer();
			this.SpineAnimPlayTimer = TimerSystem.Instance.Delay(delegate(float _)
			{
				this.SpineAnimPlayTimer = null;
				this.ResumeHeldSpineAnimThenLoop();
			}, this.SpineAnimDelayTime * 1000f, null, null, true, 1f);
		}

		// Token: 0x06037364 RID: 226148 RVA: 0x00F69C61 File Offset: 0x00F67E61
		private void CancelSpineAnimPlayTimer()
		{
			TimerHandle spineAnimPlayTimer = this.SpineAnimPlayTimer;
			if (spineAnimPlayTimer != null)
			{
				spineAnimPlayTimer.Remove();
			}
			this.SpineAnimPlayTimer = null;
		}

		// Token: 0x06037365 RID: 226149 RVA: 0x00F69C7C File Offset: 0x00F67E7C
		private void ClearPendingSpinePlay()
		{
			this.PendingSpinePlay = false;
			this.PendingSequenceName = "";
		}

		// Token: 0x06037366 RID: 226150 RVA: 0x00F69C90 File Offset: 0x00F67E90
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

		// Token: 0x06037367 RID: 226151 RVA: 0x00F69CE3 File Offset: 0x00F67EE3
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

		// Token: 0x06037368 RID: 226152 RVA: 0x00F69D18 File Offset: 0x00F67F18
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

		// Token: 0x06037369 RID: 226153 RVA: 0x00F69D98 File Offset: 0x00F67F98
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

		// Token: 0x0603736A RID: 226154 RVA: 0x00F69E20 File Offset: 0x00F68020
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

		// Token: 0x0603736B RID: 226155 RVA: 0x00F69EB4 File Offset: 0x00F680B4
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

		// Token: 0x0603736C RID: 226156 RVA: 0x00F69F02 File Offset: 0x00F68102
		private void ClearSpineTrack()
		{
			this.SpineTrackEntry = null;
		}

		// Token: 0x0401D2CD RID: 119501
		private string LoadedAtlasPath = "";

		// Token: 0x0401D2CE RID: 119502
		private string LoadedSkeletonPath = "";

		// Token: 0x0401D2CF RID: 119503
		private string SpineAnim = "";

		// Token: 0x0401D2D0 RID: 119504
		private string SpineLoopAnim = "";

		// Token: 0x0401D2D1 RID: 119505
		private bool IsLoading;

		// Token: 0x0401D2D2 RID: 119506
		[Nullable(2)]
		private UTrackEntry SpineTrackEntry;

		// Token: 0x0401D2D3 RID: 119507
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private LoadAsyncPromise<USpineAtlasAsset> SpineAtlasPromise;

		// Token: 0x0401D2D4 RID: 119508
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private LoadAsyncPromise<USpineSkeletonDataAsset> SpineSkeletonDataPromise;

		// Token: 0x0401D2D5 RID: 119509
		[Nullable(2)]
		private LevelSequencePlayer SequencePlayer;

		// Token: 0x0401D2D6 RID: 119510
		private float SpineAnimDelayTime;

		// Token: 0x0401D2D7 RID: 119511
		[Nullable(2)]
		private TimerHandle SpineAnimPlayTimer;

		// Token: 0x0401D2D8 RID: 119512
		private bool PendingSpinePlay;

		// Token: 0x0401D2D9 RID: 119513
		private string PendingSequenceName = "";

		// Token: 0x0200B37E RID: 45950
		[NullableContext(0)]
		private enum EBgItemComponent
		{
			// Token: 0x040377B8 RID: 227256
			SprLevelNum,
			// Token: 0x040377B9 RID: 227257
			RoleSpine
		}
	}
}
