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
	// Token: 0x0200681B RID: 26651
	[NullableContext(1)]
	[Nullable(0)]
	public class DangoBrawlAdventureLevelBgItem : UiPanelBase
	{
		// Token: 0x17009738 RID: 38712
		// (get) Token: 0x060427E3 RID: 272355 RVA: 0x01027B9C File Offset: 0x01025D9C
		// (set) Token: 0x060427E4 RID: 272356 RVA: 0x01027BA4 File Offset: 0x01025DA4
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

		// Token: 0x060427E5 RID: 272357 RVA: 0x01027BBC File Offset: 0x01025DBC
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

		// Token: 0x060427E6 RID: 272358 RVA: 0x01027C88 File Offset: 0x01025E88
		protected override void OnStart()
		{
			this.SequencePlayer = new LevelSequencePlayer(base.GetRootItem());
		}

		// Token: 0x060427E7 RID: 272359 RVA: 0x01027C9B File Offset: 0x01025E9B
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

		// Token: 0x060427E8 RID: 272360 RVA: 0x01027CD0 File Offset: 0x01025ED0
		public void PlaySequence(string sequenceName)
		{
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.PlayLevelSequenceByName(sequenceName, false, null, false);
		}

		// Token: 0x060427E9 RID: 272361 RVA: 0x01027CFC File Offset: 0x01025EFC
		public void Refresh(DangoBrawlLevelData levelData)
		{
			this.SetSpriteByPath(levelData.BgNumIcon, base.GetSprite(0), false, null, null);
			base.SetTextureByPath(levelData.AdventureLeftIcon, base.GetTexture(1), null, null);
			base.SetTextureByPath(levelData.AdventureRightIcon, base.GetTexture(2), null, null);
			this.RefreshSpine(levelData.FirstSpineAtlasPath, levelData.FirstSpineSkeletonDataPath, levelData.FirstSpineAnim, levelData.FirstSpineLoopAnim, levelData.SecondSpineAtlasPath, levelData.SecondSpineSkeletonDataPath, levelData.SecondSpineAnim, levelData.SecondSpineLoopAnim);
		}

		// Token: 0x060427EA RID: 272362 RVA: 0x01027D98 File Offset: 0x01025F98
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

		// Token: 0x060427EB RID: 272363 RVA: 0x01027E14 File Offset: 0x01026014
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

		// Token: 0x060427EC RID: 272364 RVA: 0x01027E9C File Offset: 0x0102609C
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

		// Token: 0x060427ED RID: 272365 RVA: 0x01027ED6 File Offset: 0x010260D6
		private void DoPlaySequenceThenSpine(string sequenceName)
		{
			this.HoldBothSpineAtAnimFirstFrame();
			if (!string.IsNullOrEmpty(sequenceName))
			{
				this.PlaySequence(sequenceName);
			}
			this.ScheduleSpineAnimPlay();
		}

		// Token: 0x060427EE RID: 272366 RVA: 0x01027EF3 File Offset: 0x010260F3
		private void ScheduleSpineAnimPlay()
		{
			this.CancelSpineAnimPlayTimer();
			this.SpineAnimPlayTimer = TimerSystem.Instance.Delay(delegate(float _)
			{
				this.SpineAnimPlayTimer = null;
				this.ResumeBothHeldSpineAnimThenLoop();
			}, this.SpineAnimDelayTime * 1000f, null, null, true, 1f);
		}

		// Token: 0x060427EF RID: 272367 RVA: 0x01027F2B File Offset: 0x0102612B
		private void CancelSpineAnimPlayTimer()
		{
			TimerHandle spineAnimPlayTimer = this.SpineAnimPlayTimer;
			if (spineAnimPlayTimer != null)
			{
				spineAnimPlayTimer.Remove();
			}
			this.SpineAnimPlayTimer = null;
		}

		// Token: 0x060427F0 RID: 272368 RVA: 0x01027F46 File Offset: 0x01026146
		private void ClearPendingSpinePlay()
		{
			this.PendingSpinePlay = false;
			this.PendingSequenceName = "";
		}

		// Token: 0x060427F1 RID: 272369 RVA: 0x01027F5C File Offset: 0x0102615C
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

		// Token: 0x060427F2 RID: 272370 RVA: 0x01027FC0 File Offset: 0x010261C0
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

		// Token: 0x060427F3 RID: 272371 RVA: 0x0102802D File Offset: 0x0102622D
		private void PlayBothSpineAnimThenLoop()
		{
			if (this.IsLoading)
			{
				return;
			}
			this.PlaySpineAnimThenLoop(base.GetSpine(3), this.LeftSpineAnim, this.LeftSpineLoopAnim, true);
			this.PlaySpineAnimThenLoop(base.GetSpine(4), this.RightSpineAnim, this.RightSpineLoopAnim, false);
		}

		// Token: 0x060427F4 RID: 272372 RVA: 0x0102806C File Offset: 0x0102626C
		private void HoldBothSpineAtAnimFirstFrame()
		{
			this.HoldSpineAtAnimFirstFrame(base.GetSpine(3), this.LeftSpineAnim, this.LeftSpineLoopAnim, true);
			this.HoldSpineAtAnimFirstFrame(base.GetSpine(4), this.RightSpineAnim, this.RightSpineLoopAnim, false);
		}

		// Token: 0x060427F5 RID: 272373 RVA: 0x010280A4 File Offset: 0x010262A4
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

		// Token: 0x060427F6 RID: 272374 RVA: 0x01028134 File Offset: 0x01026334
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

		// Token: 0x060427F7 RID: 272375 RVA: 0x010281B4 File Offset: 0x010263B4
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

		// Token: 0x060427F8 RID: 272376 RVA: 0x01028224 File Offset: 0x01026424
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

		// Token: 0x060427F9 RID: 272377 RVA: 0x010282DC File Offset: 0x010264DC
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

		// Token: 0x060427FA RID: 272378 RVA: 0x0102832C File Offset: 0x0102652C
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

		// Token: 0x060427FB RID: 272379 RVA: 0x0102837A File Offset: 0x0102657A
		private void ClearSpineTracks()
		{
			this.LeftSpineTrackEntry = null;
			this.RightSpineTrackEntry = null;
		}

		// Token: 0x060427FC RID: 272380 RVA: 0x0102838A File Offset: 0x0102658A
		private bool IsInvalidSpinePath(string atlasPath, string skeletonPath)
		{
			return string.IsNullOrEmpty(atlasPath) || string.IsNullOrEmpty(skeletonPath);
		}

		// Token: 0x060427FD RID: 272381 RVA: 0x0102839C File Offset: 0x0102659C
		private bool IsLeftSpineLoaded(string atlasPath, string skeletonPath)
		{
			return atlasPath == this.LoadedLeftAtlasPath && skeletonPath == this.LoadedLeftSkeletonPath;
		}

		// Token: 0x060427FE RID: 272382 RVA: 0x010283BA File Offset: 0x010265BA
		private bool IsRightSpineLoaded(string atlasPath, string skeletonPath)
		{
			return atlasPath == this.LoadedRightAtlasPath && skeletonPath == this.LoadedRightSkeletonPath;
		}

		// Token: 0x060427FF RID: 272383 RVA: 0x010283D8 File Offset: 0x010265D8
		[NullableContext(2)]
		private bool IsSpineReady(USpineAtlasAsset atlas, USpineSkeletonDataAsset skeletonData, USpineSkeletonAnimationComponent spine)
		{
			return atlas != null && skeletonData != null && spine != null && spine.IsValid();
		}

		// Token: 0x04022A5C RID: 141916
		private string LoadedLeftAtlasPath = "";

		// Token: 0x04022A5D RID: 141917
		private string LoadedLeftSkeletonPath = "";

		// Token: 0x04022A5E RID: 141918
		private string LoadedRightAtlasPath = "";

		// Token: 0x04022A5F RID: 141919
		private string LoadedRightSkeletonPath = "";

		// Token: 0x04022A60 RID: 141920
		private string LeftSpineAnim = "";

		// Token: 0x04022A61 RID: 141921
		private string LeftSpineLoopAnim = "";

		// Token: 0x04022A62 RID: 141922
		private string RightSpineAnim = "";

		// Token: 0x04022A63 RID: 141923
		private string RightSpineLoopAnim = "";

		// Token: 0x04022A64 RID: 141924
		private bool IsLoading;

		// Token: 0x04022A65 RID: 141925
		[Nullable(2)]
		private UTrackEntry LeftSpineTrackEntry;

		// Token: 0x04022A66 RID: 141926
		[Nullable(2)]
		private UTrackEntry RightSpineTrackEntry;

		// Token: 0x04022A67 RID: 141927
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private LoadAsyncPromise<USpineAtlasAsset> SpineAtlasLeftPromise;

		// Token: 0x04022A68 RID: 141928
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private LoadAsyncPromise<USpineSkeletonDataAsset> SpineSkeletonLeftPromise;

		// Token: 0x04022A69 RID: 141929
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private LoadAsyncPromise<USpineAtlasAsset> SpineAtlasRightPromise;

		// Token: 0x04022A6A RID: 141930
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private LoadAsyncPromise<USpineSkeletonDataAsset> SpineSkeletonRightPromise;

		// Token: 0x04022A6B RID: 141931
		[Nullable(2)]
		private LevelSequencePlayer SequencePlayer;

		// Token: 0x04022A6C RID: 141932
		private float SpineAnimDelayTime;

		// Token: 0x04022A6D RID: 141933
		[Nullable(2)]
		private TimerHandle SpineAnimPlayTimer;

		// Token: 0x04022A6E RID: 141934
		private bool PendingSpinePlay;

		// Token: 0x04022A6F RID: 141935
		private string PendingSequenceName = "";

		// Token: 0x0200C9AD RID: 51629
		[NullableContext(0)]
		private enum EBgItemComponent
		{
			// Token: 0x0403CEA8 RID: 249512
			SprLevelNum,
			// Token: 0x0403CEA9 RID: 249513
			TexRoleL,
			// Token: 0x0403CEAA RID: 249514
			TexRoleR,
			// Token: 0x0403CEAB RID: 249515
			RoleSpineLeft,
			// Token: 0x0403CEAC RID: 249516
			RoleSpineRight
		}
	}
}
