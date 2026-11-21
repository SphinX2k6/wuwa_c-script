using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020059A2 RID: 22946
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class SolarSchoolScheduleCellItem : GridProxyAbstract<SolarSchoolScheduleCellData>
	{
		// Token: 0x06038927 RID: 231719 RVA: 0x00FD3ED4 File Offset: 0x00FD20D4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 16;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06038928 RID: 231720 RVA: 0x00FD4113 File Offset: 0x00FD2313
		protected override void OnStart()
		{
			this.SequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.SequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceFinish), false);
			if (this.RootItem != null)
			{
				this.SaveInitialItemStates(this.RootItem);
			}
		}

		// Token: 0x06038929 RID: 231721 RVA: 0x00FD4154 File Offset: 0x00FD2354
		private void SaveInitialItemStates(UUIItem item)
		{
			this.InitialItemStates.Add(new ValueTuple<UUIItem, float, FVector2D, FVector>(item, item.GetAlpha(), item.GetAnchorOffset(), item.RelativeScale3D));
			TArray<UUIItem> attachUIChildren = item.GetAttachUIChildren();
			for (int i = 0; i < attachUIChildren.Num(); i++)
			{
				this.SaveInitialItemStates(attachUIChildren[i]);
			}
		}

		// Token: 0x0603892A RID: 231722 RVA: 0x00FD41AC File Offset: 0x00FD23AC
		public override void Refresh(SolarSchoolScheduleCellData data, bool isSelected, int gridIndex)
		{
			bool flag = this.Data != null && !this.IsTransitioning && !data.PlayRefreshAnimation && !data.PlayCancelAnimation && this.Data.Slot == data.Slot && this.Data.Weekday == data.Weekday && this.Data.BehaviorId == data.BehaviorId && this.Data.State == data.State && this.Data.IsSpecialDay == data.IsSpecialDay;
			this.Data = data;
			if (!flag)
			{
				this.ResetAnimations();
				this.IsTransitioning = (data.PlayCancelAnimation && !data.IsSpecialDay && this.SequencePlayer != null);
				this.PreviewCovered = (!data.IsSpecialDay && ((this.IsTransitioning || !data.PlayRefreshAnimation) ? data.WasPreviewCovered : data.IsPreviewCovered));
				this.RefreshIconState();
			}
			this.RefreshContent();
		}

		// Token: 0x0603892B RID: 231723 RVA: 0x00FD42A8 File Offset: 0x00FD24A8
		private void RefreshContent()
		{
			if (this.Data == null)
			{
				return;
			}
			bool flag = !this.Data.IsSpecialDay && (this.IsTransitioning || this.Data.State == ESolarSchoolCellState.Empty);
			bool flag2 = !this.Data.IsSpecialDay && !this.IsTransitioning && this.Data.State > ESolarSchoolCellState.Empty;
			bool flag3 = this.IsDefaultCourse();
			UUIItem item = base.GetItem(10);
			if (item != null)
			{
				item.SetUIActive(!this.Data.IsSpecialDay);
			}
			UUIItem item2 = base.GetItem(0);
			if (item2 != null)
			{
				item2.SetUIActive(flag);
			}
			UUIItem item3 = base.GetItem(3);
			if (item3 != null)
			{
				item3.SetUIActive(flag2 && flag3);
			}
			UUIItem item4 = base.GetItem(6);
			if (item4 != null)
			{
				item4.SetUIActive(flag2 && !flag3);
			}
			UUIText text = base.GetText(5);
			if (text != null)
			{
				text.SetText(this.Data.Text, true);
			}
			UUIText text2 = base.GetText(8);
			if (text2 != null)
			{
				text2.SetText(this.Data.Text, true);
			}
			string bgPath = (this.IsTransitioning && this.Data.State != ESolarSchoolCellState.Empty) ? this.Data.PreviousBgPath : this.Data.BgPath;
			this.RefreshBg(flag ? 1 : (flag3 ? 4 : 7), bgPath);
			UUIItem item5 = base.GetItem(9);
			if (item5 == null)
			{
				return;
			}
			item5.SetUIActive(flag2 && this.Data.CanDelete);
		}

		// Token: 0x0603892C RID: 231724 RVA: 0x00FD441C File Offset: 0x00FD261C
		private bool IsDefaultCourse()
		{
			SolarSchoolScheduleCellData data = this.Data;
			ESolarSchoolBehaviorType? esolarSchoolBehaviorType = (data != null) ? data.BehaviorType : null;
			if (esolarSchoolBehaviorType != null)
			{
				ESolarSchoolBehaviorType valueOrDefault = esolarSchoolBehaviorType.GetValueOrDefault();
				if (valueOrDefault - ESolarSchoolBehaviorType.Fixed <= 1)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0603892D RID: 231725 RVA: 0x00FD4464 File Offset: 0x00FD2664
		private void RefreshBg(int componentId, string bgPath)
		{
			UUISprite sprite = base.GetSprite(componentId);
			if (sprite != null && !string.IsNullOrEmpty(bgPath))
			{
				this.SetSpriteByPath(bgPath, sprite, false, null, null);
			}
		}

		// Token: 0x0603892E RID: 231726 RVA: 0x00FD4498 File Offset: 0x00FD2698
		public UniTask PlayTransitionAsync()
		{
			SolarSchoolScheduleCellItem.<PlayTransitionAsync>d__17 <PlayTransitionAsync>d__;
			<PlayTransitionAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<PlayTransitionAsync>d__.<>4__this = this;
			<PlayTransitionAsync>d__.<>1__state = -1;
			<PlayTransitionAsync>d__.<>t__builder.Start<SolarSchoolScheduleCellItem.<PlayTransitionAsync>d__17>(ref <PlayTransitionAsync>d__);
			return <PlayTransitionAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603892F RID: 231727 RVA: 0x00FD44DC File Offset: 0x00FD26DC
		public void SetPreviewCovered(bool covered)
		{
			if (this.Data == null)
			{
				return;
			}
			covered &= !this.Data.IsSpecialDay;
			this.Data.IsPreviewCovered = covered;
			if (this.IsTransitioning || this.PreviewCovered == covered)
			{
				return;
			}
			this.StopSequence("IconChange");
			this.StopSequence("IconChangeBack");
			this.PreviewCovered = covered;
			UUIItem normalIcon = this.GetNormalIcon();
			UUIItem coveredIcon = this.GetCoveredIcon();
			if (normalIcon != null)
			{
				normalIcon.SetUIActive(true);
			}
			if (coveredIcon != null)
			{
				coveredIcon.SetUIActive(true);
			}
			if (normalIcon != null)
			{
				normalIcon.SetAlpha(covered ? 1f : 0f);
			}
			if (coveredIcon != null)
			{
				coveredIcon.SetAlpha(covered ? 0f : 1f);
			}
			string sequenceName = covered ? "IconChange" : "IconChangeBack";
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.PlayOrReplaySequenceByName(sequenceName, false, null);
			}
			this.SetIconSequenceBindings(sequenceName, normalIcon, coveredIcon);
			LevelSequencePlayer sequencePlayer2 = this.SequencePlayer;
			if (sequencePlayer2 == null)
			{
				return;
			}
			sequencePlayer2.SequenceJumpToStartWhenPlaying(sequenceName);
		}

		// Token: 0x06038930 RID: 231728 RVA: 0x00FD45D7 File Offset: 0x00FD27D7
		[NullableContext(2)]
		private UUIItem GetNormalIcon()
		{
			return base.GetItem(this.IsDefaultCourse() ? 12 : 14);
		}

		// Token: 0x06038931 RID: 231729 RVA: 0x00FD45ED File Offset: 0x00FD27ED
		[NullableContext(2)]
		private UUIItem GetCoveredIcon()
		{
			int name;
			if (!this.IsTransitioning)
			{
				SolarSchoolScheduleCellData data = this.Data;
				if (data == null || data.State != ESolarSchoolCellState.Empty)
				{
					name = (this.IsDefaultCourse() ? 13 : 15);
					goto IL_32;
				}
			}
			name = 11;
			IL_32:
			return base.GetItem(name);
		}

		// Token: 0x06038932 RID: 231730 RVA: 0x00FD4628 File Offset: 0x00FD2828
		[NullableContext(2)]
		private void SetIconSequenceBindings([Nullable(1)] string sequenceName, UUIItem normal, UUIItem fillIn)
		{
			AUIBaseActor auibaseActor = base.GetRootActor() as AUIBaseActor;
			ALevelSequenceActor alevelSequenceActor = (auibaseActor != null) ? auibaseActor.GetSequencePlayerByKey(sequenceName) : null;
			UMovieScene umovieScene;
			if (alevelSequenceActor == null)
			{
				umovieScene = null;
			}
			else
			{
				ULevelSequence sequence = alevelSequenceActor.GetSequence();
				umovieScene = ((sequence != null) ? sequence.GetMovieScene() : null);
			}
			UMovieScene umovieScene2 = umovieScene;
			if (alevelSequenceActor == null || umovieScene2 == null)
			{
				return;
			}
			alevelSequenceActor.ResetBindings();
			TArray<FMovieScenePossessable> possessables = umovieScene2.Possessables;
			for (int i = 0; i < possessables.Num(); i++)
			{
				FMovieScenePossessable fmovieScenePossessable = possessables[i];
				string name = fmovieScenePossessable.Name;
				UUIItem uuiitem;
				if (!(name == "PnlCourse_Nml"))
				{
					if (!(name == "PnlCourse_FillIn"))
					{
						if (!(name == "SprTypeIcon"))
						{
							if (!(name == "SprIconBg"))
							{
								if (!(name == "SprIcon"))
								{
									uuiitem = null;
								}
								else
								{
									uuiitem = (this.FindIcon(fillIn, "SprIcon") ?? ((fillIn != null) ? fillIn.GetAttachUIChild(0) : null));
								}
							}
							else
							{
								uuiitem = this.FindIcon(normal, "SprIconBg");
							}
						}
						else
						{
							uuiitem = (this.FindIcon(normal, "SprTypeIcon") ?? this.FindIcon(normal, "SprIcon"));
						}
					}
					else
					{
						uuiitem = fillIn;
					}
				}
				else
				{
					uuiitem = normal;
				}
				UUIItem uuiitem2 = uuiitem;
				AActor aactor = (uuiitem2 != null) ? uuiitem2.GetOwner() : null;
				if (aactor != null)
				{
					TArray<AActor> tarray = new TArray<AActor>();
					tarray.Add(aactor);
					alevelSequenceActor.SetBinding(new FMovieSceneObjectBindingID
					{
						SequenceID = 0,
						Guid = fmovieScenePossessable.Guid
					}, tarray, false);
				}
			}
		}

		// Token: 0x06038933 RID: 231731 RVA: 0x00FD4790 File Offset: 0x00FD2990
		[NullableContext(2)]
		private UUIItem FindIcon(UUIItem item, [Nullable(1)] string displayName)
		{
			if (item == null)
			{
				return null;
			}
			if (item.GetDisplayName() == displayName)
			{
				return item;
			}
			TArray<UUIItem> attachUIChildren = item.GetAttachUIChildren();
			for (int i = 0; i < attachUIChildren.Num(); i++)
			{
				UUIItem uuiitem = this.FindIcon(attachUIChildren[i], displayName);
				if (uuiitem != null)
				{
					return uuiitem;
				}
			}
			return null;
		}

		// Token: 0x06038934 RID: 231732 RVA: 0x00FD47E0 File Offset: 0x00FD29E0
		private void RefreshIconState()
		{
			this.SetIconState(11, this.PreviewCovered);
			this.SetIconState(12, !this.PreviewCovered);
			this.SetIconState(13, this.PreviewCovered);
			this.SetIconState(14, !this.PreviewCovered);
			this.SetIconState(15, this.PreviewCovered);
		}

		// Token: 0x06038935 RID: 231733 RVA: 0x00FD4839 File Offset: 0x00FD2A39
		private void SetIconState(int componentId, bool active)
		{
			UUIItem item = base.GetItem(componentId);
			if (item != null)
			{
				item.SetUIActive(active);
			}
			if (item == null)
			{
				return;
			}
			item.SetAlpha(1f);
		}

		// Token: 0x06038936 RID: 231734 RVA: 0x00FD485E File Offset: 0x00FD2A5E
		private void OnSequenceFinish(string sequenceName)
		{
			if (this.Data != null && (sequenceName == "IconChange" || sequenceName == "IconChangeBack"))
			{
				this.RefreshIconState();
			}
		}

		// Token: 0x06038937 RID: 231735 RVA: 0x00FD4888 File Offset: 0x00FD2A88
		public int GetWeekday()
		{
			SolarSchoolScheduleCellData data = this.Data;
			if (data == null)
			{
				return 0;
			}
			return data.Weekday;
		}

		// Token: 0x06038938 RID: 231736 RVA: 0x00FD489C File Offset: 0x00FD2A9C
		public bool ShouldPlayRefreshAnimation()
		{
			SolarSchoolScheduleCellData data = this.Data;
			return data != null && data.PlayRefreshAnimation && !data.IsSpecialDay;
		}

		// Token: 0x06038939 RID: 231737 RVA: 0x00FD48C8 File Offset: 0x00FD2AC8
		public void PlayStartAnimation()
		{
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.PlayOrReplaySequenceByName("Start", false, null);
		}

		// Token: 0x0603893A RID: 231738 RVA: 0x00FD48F4 File Offset: 0x00FD2AF4
		public void RefreshPreviewAnimation()
		{
			if (this.Data != null)
			{
				this.SetPreviewCovered(this.Data.IsPreviewCovered);
			}
		}

		// Token: 0x0603893B RID: 231739 RVA: 0x00FD4910 File Offset: 0x00FD2B10
		private void StopSequence(string sequenceName)
		{
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null && sequencePlayer.IsPlayingSequence(sequenceName))
			{
				this.SequencePlayer.StopSequenceByKey(sequenceName, false, false);
				return;
			}
			LevelSequencePlayer sequencePlayer2 = this.SequencePlayer;
			if (sequencePlayer2 != null && sequencePlayer2.CheckSeqActorIsUnStopped(sequenceName))
			{
				AUIBaseActor auibaseActor = base.GetRootActor() as AUIBaseActor;
				if (auibaseActor == null)
				{
					return;
				}
				auibaseActor.StopSequenceByKey(sequenceName);
			}
		}

		// Token: 0x0603893C RID: 231740 RVA: 0x00FD496C File Offset: 0x00FD2B6C
		public void ResetAnimations()
		{
			this.AnimationVersion++;
			this.IsTransitioning = false;
			this.StopSequence("Start");
			this.StopSequence("Cancel");
			this.StopSequence("IconChange");
			this.StopSequence("IconChangeBack");
			foreach (ValueTuple<UUIItem, float, FVector2D, FVector> valueTuple in this.InitialItemStates)
			{
				valueTuple.Item1.SetAlpha(valueTuple.Item2);
				valueTuple.Item1.SetUIRelativeScale3D(valueTuple.Item4);
				if (valueTuple.Item1 != this.RootItem)
				{
					valueTuple.Item1.SetAnchorOffset(valueTuple.Item3);
				}
			}
		}

		// Token: 0x0603893D RID: 231741 RVA: 0x00FD4A3C File Offset: 0x00FD2C3C
		public override void Clear()
		{
			this.Data = null;
			this.ResetAnimations();
			this.PreviewCovered = false;
		}

		// Token: 0x0603893E RID: 231742 RVA: 0x00FD4A52 File Offset: 0x00FD2C52
		protected override void OnBeforeDestroy()
		{
			this.Clear();
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.Clear();
			}
			this.SequencePlayer = null;
			this.InitialItemStates.Clear();
		}

		// Token: 0x0401DCC7 RID: 122055
		private const string CancelSequence = "Cancel";

		// Token: 0x0401DCC8 RID: 122056
		private const string IconChangeSequence = "IconChange";

		// Token: 0x0401DCC9 RID: 122057
		private const string IconChangeBackSequence = "IconChangeBack";

		// Token: 0x0401DCCA RID: 122058
		[Nullable(2)]
		private SolarSchoolScheduleCellData Data;

		// Token: 0x0401DCCB RID: 122059
		[Nullable(2)]
		private LevelSequencePlayer SequencePlayer;

		// Token: 0x0401DCCC RID: 122060
		private bool PreviewCovered;

		// Token: 0x0401DCCD RID: 122061
		private bool IsTransitioning;

		// Token: 0x0401DCCE RID: 122062
		private int AnimationVersion;

		// Token: 0x0401DCCF RID: 122063
		[TupleElementNames(new string[]
		{
			"Item",
			"Alpha",
			"Offset",
			"Scale"
		})]
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		private readonly List<ValueTuple<UUIItem, float, FVector2D, FVector>> InitialItemStates = new List<ValueTuple<UUIItem, float, FVector2D, FVector>>();

		// Token: 0x0200B54B RID: 46411
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x040380D7 RID: 229591
			public const int PnlNotScheduled = 0;

			// Token: 0x040380D8 RID: 229592
			public const int SprBgNot = 1;

			// Token: 0x040380D9 RID: 229593
			public const int TxtNull = 2;

			// Token: 0x040380DA RID: 229594
			public const int PnlDefaultCourse = 3;

			// Token: 0x040380DB RID: 229595
			public const int SprBgDefaultCourse = 4;

			// Token: 0x040380DC RID: 229596
			public const int TxtDefaultCourse = 5;

			// Token: 0x040380DD RID: 229597
			public const int PnlCourse = 6;

			// Token: 0x040380DE RID: 229598
			public const int SprBgCourse = 7;

			// Token: 0x040380DF RID: 229599
			public const int TxtCourse = 8;

			// Token: 0x040380E0 RID: 229600
			public const int SprCancel = 9;

			// Token: 0x040380E1 RID: 229601
			public const int PnlContent = 10;

			// Token: 0x040380E2 RID: 229602
			public const int PnlEmptyIconCovered = 11;

			// Token: 0x040380E3 RID: 229603
			public const int PnlDefaultIconNormal = 12;

			// Token: 0x040380E4 RID: 229604
			public const int PnlDefaultIconCovered = 13;

			// Token: 0x040380E5 RID: 229605
			public const int PnlCourseIconNormal = 14;

			// Token: 0x040380E6 RID: 229606
			public const int PnlCourseIconCovered = 15;
		}
	}
}
