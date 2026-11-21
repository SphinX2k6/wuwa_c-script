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
	// Token: 0x0200576B RID: 22379
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlAdventureLevelBgItem : UiPanelBase
	{
		// Token: 0x17006A79 RID: 27257
		// (get) Token: 0x06037338 RID: 226104 RVA: 0x00F690E0 File Offset: 0x00F672E0
		// (set) Token: 0x06037339 RID: 226105 RVA: 0x00F690E8 File Offset: 0x00F672E8
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

		// Token: 0x0603733A RID: 226106 RVA: 0x00F69100 File Offset: 0x00F67300
		protected unsafe override void OnRegisterComponent()
		{
			int num = 5;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(USpineSkeletonAnimationComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(USpineSkeletonAnimationComponent));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603733B RID: 226107 RVA: 0x00F691CC File Offset: 0x00F673CC
		protected override void OnStart()
		{
			this.SequencePlayer = new LevelSequencePlayer(base.GetRootItem());
		}

		// Token: 0x0603733C RID: 226108 RVA: 0x00F691DF File Offset: 0x00F673DF
		protected override void OnBeforeDestroy()
		{
			this.ClearPendingSpinePlay();
			this.CancelLoadSpine();
			this.CancelSpineAnimPlayTimer();
			this.ClearSpineTracks();
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.Clear();
			}
			this.SequencePlayer = null;
		}

		// Token: 0x0603733D RID: 226109 RVA: 0x00F69214 File Offset: 0x00F67414
		public void PlaySequence(string sequenceName)
		{
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.PlayLevelSequenceByName(sequenceName, false, null, false);
		}

		// Token: 0x0603733E RID: 226110 RVA: 0x00F69240 File Offset: 0x00F67440
		public void Refresh(DangoBrawlLevelData levelData)
		{
			this.SetSpriteByPath(levelData.BgNumIcon, base.GetSprite(0), false, null, null);
			base.SetTextureByPath(levelData.AdventureLeftIcon, base.GetTexture(1), null, null);
			base.SetTextureByPath(levelData.AdventureRightIcon, base.GetTexture(2), null, null);
			this.RefreshSpine(levelData.FirstSpineAtlasPath, levelData.FirstSpineSkeletonDataPath, levelData.FirstSpineAnim, levelData.FirstSpineLoopAnim, levelData.SecondSpineAtlasPath, levelData.SecondSpineSkeletonDataPath, levelData.SecondSpineAnim, levelData.SecondSpineLoopAnim);
		}

		// Token: 0x0603733F RID: 226111 RVA: 0x00F692DC File Offset: 0x00F674DC
		public void RefreshSpine(string leftAtlasPath, string leftSkeletonPath, string leftAnim, string leftLoopAnim, string rightAtlasPath, string rightSkeletonPath, string rightAnim, string rightLoopAnim)
		{
			DangoBrawlAdventureLevelBgItem.<>c__DisplayClass29_0 CS$<>8__locals1 = new DangoBrawlAdventureLevelBgItem.<>c__DisplayClass29_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.leftAtlasPath = leftAtlasPath;
			CS$<>8__locals1.leftSkeletonPath = leftSkeletonPath;
			CS$<>8__locals1.leftAnim = leftAnim;
			CS$<>8__locals1.leftLoopAnim = leftLoopAnim;
			CS$<>8__locals1.rightAtlasPath = rightAtlasPath;
			CS$<>8__locals1.rightSkeletonPath = rightSkeletonPath;
			CS$<>8__locals1.rightAnim = rightAnim;
			CS$<>8__locals1.rightLoopAnim = rightLoopAnim;
			UiAsyncTask task = new UiAsyncTask("DangoBrawlAdventureLevelBgItem", delegate()
			{
				DangoBrawlAdventureLevelBgItem.<>c__DisplayClass29_0.<<RefreshSpine>b__0>d <<RefreshSpine>b__0>d;
				<<RefreshSpine>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<RefreshSpine>b__0>d.<>4__this = CS$<>8__locals1;
				<<RefreshSpine>b__0>d.<>1__state = -1;
				<<RefreshSpine>b__0>d.<>t__builder.Start<DangoBrawlAdventureLevelBgItem.<>c__DisplayClass29_0.<<RefreshSpine>b__0>d>(ref <<RefreshSpine>b__0>d);
				return <<RefreshSpine>b__0>d.<>t__builder.Task;
			}, null);
			base.RunAsyncTask(task).Forget();
		}

		// Token: 0x06037340 RID: 226112 RVA: 0x00F69358 File Offset: 0x00F67558
		private UniTask RefreshSpineAsync(string leftAtlasPath, string leftSkeletonPath, string leftAnim, string leftLoopAnim, string rightAtlasPath, string rightSkeletonPath, string rightAnim, string rightLoopAnim)
		{
			DangoBrawlAdventureLevelBgItem.<RefreshSpineAsync>d__30 <RefreshSpineAsync>d__;
			<RefreshSpineAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshSpineAsync>d__.<>4__this = this;
			<RefreshSpineAsync>d__.leftAtlasPath = leftAtlasPath;
			<RefreshSpineAsync>d__.leftSkeletonPath = leftSkeletonPath;
			<RefreshSpineAsync>d__.leftAnim = leftAnim;
			<RefreshSpineAsync>d__.leftLoopAnim = leftLoopAnim;
			<RefreshSpineAsync>d__.rightAtlasPath = rightAtlasPath;
			<RefreshSpineAsync>d__.rightSkeletonPath = rightSkeletonPath;
			<RefreshSpineAsync>d__.rightAnim = rightAnim;
			<RefreshSpineAsync>d__.rightLoopAnim = rightLoopAnim;
			<RefreshSpineAsync>d__.<>1__state = -1;
			<RefreshSpineAsync>d__.<>t__builder.Start<DangoBrawlAdventureLevelBgItem.<RefreshSpineAsync>d__30>(ref <RefreshSpineAsync>d__);
			return <RefreshSpineAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06037341 RID: 226113 RVA: 0x00F693E0 File Offset: 0x00F675E0
		public void PlaySequenceThenSpine(string sequenceName, float delayTime = 0f)
		{
			this.SpineAnimPlayDelay = delayTime;
			this.PendingSequenceName = sequenceName;
			if (this.IsLoading || string.IsNullOrEmpty(this.LoadedLeftAtlasPath))
			{
				this.PendingSpinePlay = true;
				return;
			}
			this.ClearPendingSpinePlay();
			this.DoPlaySequenceThenSpine(sequenceName);
		}

		// Token: 0x06037342 RID: 226114 RVA: 0x00F6941A File Offset: 0x00F6761A
		private void DoPlaySequenceThenSpine(string sequenceName)
		{
			this.HoldBothSpineAtAnimFirstFrame();
			if (!string.IsNullOrEmpty(sequenceName))
			{
				this.PlaySequence(sequenceName);
			}
			this.ScheduleSpineAnimPlay();
		}

		// Token: 0x06037343 RID: 226115 RVA: 0x00F69437 File Offset: 0x00F67637
		private void ScheduleSpineAnimPlay()
		{
			this.CancelSpineAnimPlayTimer();
			this.SpineAnimPlayTimer = TimerSystem.Instance.Delay(delegate(float _)
			{
				this.SpineAnimPlayTimer = null;
				this.ResumeBothHeldSpineAnimThenLoop();
			}, this.SpineAnimDelayTime * 1000f, null, null, true, 1f);
		}

		// Token: 0x06037344 RID: 226116 RVA: 0x00F6946F File Offset: 0x00F6766F
		private void CancelSpineAnimPlayTimer()
		{
			TimerHandle spineAnimPlayTimer = this.SpineAnimPlayTimer;
			if (spineAnimPlayTimer != null)
			{
				spineAnimPlayTimer.Remove();
			}
			this.SpineAnimPlayTimer = null;
		}

		// Token: 0x06037345 RID: 226117 RVA: 0x00F6948A File Offset: 0x00F6768A
		private void ClearPendingSpinePlay()
		{
			this.PendingSpinePlay = false;
			this.PendingSequenceName = "";
		}

		// Token: 0x06037346 RID: 226118 RVA: 0x00F694A0 File Offset: 0x00F676A0
		[return: Nullable(0)]
		public UniTask<bool> LoadSpineAsync(string leftAtlasPath, string leftSkeletonPath, string rightAtlasPath, string rightSkeletonPath)
		{
			DangoBrawlAdventureLevelBgItem.<LoadSpineAsync>d__36 <LoadSpineAsync>d__;
			<LoadSpineAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<LoadSpineAsync>d__.<>4__this = this;
			<LoadSpineAsync>d__.leftAtlasPath = leftAtlasPath;
			<LoadSpineAsync>d__.leftSkeletonPath = leftSkeletonPath;
			<LoadSpineAsync>d__.rightAtlasPath = rightAtlasPath;
			<LoadSpineAsync>d__.rightSkeletonPath = rightSkeletonPath;
			<LoadSpineAsync>d__.<>1__state = -1;
			<LoadSpineAsync>d__.<>t__builder.Start<DangoBrawlAdventureLevelBgItem.<LoadSpineAsync>d__36>(ref <LoadSpineAsync>d__);
			return <LoadSpineAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06037347 RID: 226119 RVA: 0x00F69504 File Offset: 0x00F67704
		public void CancelLoadSpine()
		{
			LoadAsyncPromise<USpineAtlasAsset> spineAtlasLeftPromise = this.SpineAtlasLeftPromise;
			if (spineAtlasLeftPromise != null)
			{
				spineAtlasLeftPromise.CancelAsyncLoad();
			}
			LoadAsyncPromise<USpineSkeletonDataAsset> spineSkeletonLeftPromise = this.SpineSkeletonLeftPromise;
			if (spineSkeletonLeftPromise != null)
			{
				spineSkeletonLeftPromise.CancelAsyncLoad();
			}
			LoadAsyncPromise<USpineAtlasAsset> spineAtlasRightPromise = this.SpineAtlasRightPromise;
			if (spineAtlasRightPromise != null)
			{
				spineAtlasRightPromise.CancelAsyncLoad();
			}
			LoadAsyncPromise<USpineSkeletonDataAsset> spineSkeletonRightPromise = this.SpineSkeletonRightPromise;
			if (spineSkeletonRightPromise != null)
			{
				spineSkeletonRightPromise.CancelAsyncLoad();
			}
			this.SpineAtlasLeftPromise = null;
			this.SpineSkeletonLeftPromise = null;
			this.SpineAtlasRightPromise = null;
			this.SpineSkeletonRightPromise = null;
		}

		// Token: 0x06037348 RID: 226120 RVA: 0x00F69571 File Offset: 0x00F67771
		private void PlayBothSpineAnimThenLoop()
		{
			if (this.IsLoading)
			{
				return;
			}
			this.PlaySpineAnimThenLoop(base.GetSpine(3), this.LeftSpineAnim, this.LeftSpineLoopAnim, true);
			this.PlaySpineAnimThenLoop(base.GetSpine(4), this.RightSpineAnim, this.RightSpineLoopAnim, false);
		}

		// Token: 0x06037349 RID: 226121 RVA: 0x00F695B0 File Offset: 0x00F677B0
		private void HoldBothSpineAtAnimFirstFrame()
		{
			this.HoldSpineAtAnimFirstFrame(base.GetSpine(3), this.LeftSpineAnim, this.LeftSpineLoopAnim, true);
			this.HoldSpineAtAnimFirstFrame(base.GetSpine(4), this.RightSpineAnim, this.RightSpineLoopAnim, false);
		}

		// Token: 0x0603734A RID: 226122 RVA: 0x00F695E8 File Offset: 0x00F677E8
		private void HoldSpineAtAnimFirstFrame([Nullable(2)] USpineSkeletonAnimationComponent spine, string anim, string loopAnim, bool isLeft)
		{
			if (isLeft)
			{
				this.LeftSpineTrackEntry = null;
			}
			else
			{
				this.RightSpineTrackEntry = null;
			}
			if (spine == null || !spine.IsValid())
			{
				return;
			}
			spine.AnimationComplete.Clear();
			string text = (!string.IsNullOrEmpty(anim)) ? anim : loopAnim;
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
			if (isLeft)
			{
				this.LeftSpineTrackEntry = utrackEntry;
				return;
			}
			this.RightSpineTrackEntry = utrackEntry;
		}

		// Token: 0x0603734B RID: 226123 RVA: 0x00F69678 File Offset: 0x00F67878
		private void ResumeBothHeldSpineAnimThenLoop()
		{
			if (this.IsLoading)
			{
				return;
			}
			if (!this.ResumeHeldSpineAnimThenLoop(this.LeftSpineTrackEntry, this.LeftSpineAnim, this.LeftSpineLoopAnim, true))
			{
				this.PlaySpineAnimThenLoop(base.GetSpine(3), this.LeftSpineAnim, this.LeftSpineLoopAnim, true);
			}
			if (!this.ResumeHeldSpineAnimThenLoop(this.RightSpineTrackEntry, this.RightSpineAnim, this.RightSpineLoopAnim, false))
			{
				this.PlaySpineAnimThenLoop(base.GetSpine(4), this.RightSpineAnim, this.RightSpineLoopAnim, false);
			}
		}

		// Token: 0x0603734C RID: 226124 RVA: 0x00F696F8 File Offset: 0x00F678F8
		private bool ResumeHeldSpineAnimThenLoop([Nullable(2)] UTrackEntry entry, string anim, string loopAnim, bool isLeft)
		{
			if (entry == null || string.IsNullOrEmpty(anim) || string.IsNullOrEmpty(loopAnim))
			{
				return false;
			}
			entry.SetTimeScale(1f);
			entry.AnimationComplete.Clear();
			if (isLeft)
			{
				entry.AnimationComplete.Add(new Action<UTrackEntry>(this.OnLeftSpineAnimComplete));
			}
			else
			{
				entry.AnimationComplete.Add(new Action<UTrackEntry>(this.OnRightSpineAnimComplete));
			}
			return true;
		}

		// Token: 0x0603734D RID: 226125 RVA: 0x00F69768 File Offset: 0x00F67968
		private void PlaySpineAnimThenLoop([Nullable(2)] USpineSkeletonAnimationComponent spine, string anim, string loopAnim, bool isLeft)
		{
			if (spine == null || !spine.IsValid())
			{
				return;
			}
			if (isLeft)
			{
				this.LeftSpineTrackEntry = null;
			}
			else
			{
				this.RightSpineTrackEntry = null;
			}
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
			if (isLeft)
			{
				this.LeftSpineTrackEntry = utrackEntry;
				if (utrackEntry != null)
				{
					utrackEntry.AnimationComplete.Add(new Action<UTrackEntry>(this.OnLeftSpineAnimComplete));
					return;
				}
			}
			else
			{
				this.RightSpineTrackEntry = utrackEntry;
				if (utrackEntry != null)
				{
					utrackEntry.AnimationComplete.Add(new Action<UTrackEntry>(this.OnRightSpineAnimComplete));
				}
			}
		}

		// Token: 0x0603734E RID: 226126 RVA: 0x00F69820 File Offset: 0x00F67A20
		private void OnLeftSpineAnimComplete(UTrackEntry entry)
		{
			if (entry != this.LeftSpineTrackEntry)
			{
				return;
			}
			this.LeftSpineTrackEntry = null;
			USpineSkeletonAnimationComponent spine = base.GetSpine(3);
			if (spine == null || !spine.IsValid() || string.IsNullOrEmpty(this.LeftSpineLoopAnim))
			{
				return;
			}
			spine.SetAnimation(0, this.LeftSpineLoopAnim, true);
		}

		// Token: 0x0603734F RID: 226127 RVA: 0x00F69870 File Offset: 0x00F67A70
		private void OnRightSpineAnimComplete(UTrackEntry entry)
		{
			if (entry != this.RightSpineTrackEntry)
			{
				return;
			}
			this.RightSpineTrackEntry = null;
			USpineSkeletonAnimationComponent spine = base.GetSpine(4);
			if (spine == null || !spine.IsValid() || string.IsNullOrEmpty(this.RightSpineLoopAnim))
			{
				return;
			}
			spine.SetAnimation(0, this.RightSpineLoopAnim, true);
		}

		// Token: 0x06037350 RID: 226128 RVA: 0x00F698BE File Offset: 0x00F67ABE
		private void ClearSpineTracks()
		{
			this.LeftSpineTrackEntry = null;
			this.RightSpineTrackEntry = null;
		}

		// Token: 0x06037351 RID: 226129 RVA: 0x00F698CE File Offset: 0x00F67ACE
		private bool IsInvalidSpinePath(string atlasPath, string skeletonPath)
		{
			return string.IsNullOrEmpty(atlasPath) || string.IsNullOrEmpty(skeletonPath);
		}

		// Token: 0x06037352 RID: 226130 RVA: 0x00F698E0 File Offset: 0x00F67AE0
		private bool IsLeftSpineLoaded(string atlasPath, string skeletonPath)
		{
			return atlasPath == this.LoadedLeftAtlasPath && skeletonPath == this.LoadedLeftSkeletonPath;
		}

		// Token: 0x06037353 RID: 226131 RVA: 0x00F698FE File Offset: 0x00F67AFE
		private bool IsRightSpineLoaded(string atlasPath, string skeletonPath)
		{
			return atlasPath == this.LoadedRightAtlasPath && skeletonPath == this.LoadedRightSkeletonPath;
		}

		// Token: 0x06037354 RID: 226132 RVA: 0x00F6991C File Offset: 0x00F67B1C
		[NullableContext(2)]
		private bool IsSpineReady(USpineAtlasAsset atlas, USpineSkeletonDataAsset skeletonData, USpineSkeletonAnimationComponent spine)
		{
			return atlas != null && skeletonData != null && spine != null && spine.IsValid();
		}

		// Token: 0x0401D2B9 RID: 119481
		private string LoadedLeftAtlasPath = "";

		// Token: 0x0401D2BA RID: 119482
		private string LoadedLeftSkeletonPath = "";

		// Token: 0x0401D2BB RID: 119483
		private string LoadedRightAtlasPath = "";

		// Token: 0x0401D2BC RID: 119484
		private string LoadedRightSkeletonPath = "";

		// Token: 0x0401D2BD RID: 119485
		private string LeftSpineAnim = "";

		// Token: 0x0401D2BE RID: 119486
		private string LeftSpineLoopAnim = "";

		// Token: 0x0401D2BF RID: 119487
		private string RightSpineAnim = "";

		// Token: 0x0401D2C0 RID: 119488
		private string RightSpineLoopAnim = "";

		// Token: 0x0401D2C1 RID: 119489
		private bool IsLoading;

		// Token: 0x0401D2C2 RID: 119490
		[Nullable(2)]
		private UTrackEntry LeftSpineTrackEntry;

		// Token: 0x0401D2C3 RID: 119491
		[Nullable(2)]
		private UTrackEntry RightSpineTrackEntry;

		// Token: 0x0401D2C4 RID: 119492
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private LoadAsyncPromise<USpineAtlasAsset> SpineAtlasLeftPromise;

		// Token: 0x0401D2C5 RID: 119493
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private LoadAsyncPromise<USpineSkeletonDataAsset> SpineSkeletonLeftPromise;

		// Token: 0x0401D2C6 RID: 119494
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private LoadAsyncPromise<USpineAtlasAsset> SpineAtlasRightPromise;

		// Token: 0x0401D2C7 RID: 119495
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private LoadAsyncPromise<USpineSkeletonDataAsset> SpineSkeletonRightPromise;

		// Token: 0x0401D2C8 RID: 119496
		[Nullable(2)]
		private LevelSequencePlayer SequencePlayer;

		// Token: 0x0401D2C9 RID: 119497
		private float SpineAnimDelayTime;

		// Token: 0x0401D2CA RID: 119498
		[Nullable(2)]
		private TimerHandle SpineAnimPlayTimer;

		// Token: 0x0401D2CB RID: 119499
		private bool PendingSpinePlay;

		// Token: 0x0401D2CC RID: 119500
		private string PendingSequenceName = "";

		// Token: 0x0200B37A RID: 45946
		[NullableContext(0)]
		private enum EBgItemComponent
		{
			// Token: 0x04037795 RID: 227221
			SprLevelNum,
			// Token: 0x04037796 RID: 227222
			TexRoleL,
			// Token: 0x04037797 RID: 227223
			TexRoleR,
			// Token: 0x04037798 RID: 227224
			RoleSpineLeft,
			// Token: 0x04037799 RID: 227225
			RoleSpineRight
		}
	}
}
