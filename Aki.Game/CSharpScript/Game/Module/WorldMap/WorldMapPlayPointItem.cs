using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.WorldMap
{
	// Token: 0x020047AB RID: 18347
	[NullableContext(1)]
	[Nullable(0)]
	public class WorldMapPlayPointItem : UiPanelBase
	{
		// Token: 0x17007833 RID: 30771
		// (get) Token: 0x0602FFD4 RID: 196564 RVA: 0x00B1BEBB File Offset: 0x00B1A0BB
		// (set) Token: 0x0602FFD5 RID: 196565 RVA: 0x00B1BEC3 File Offset: 0x00B1A0C3
		[Nullable(2)]
		public ExploreAreaItemData ExploreData { [NullableContext(2)] get; [NullableContext(2)] private set; }

		// Token: 0x0602FFD6 RID: 196566 RVA: 0x00B1BECC File Offset: 0x00B1A0CC
		public UniTask Init(UUIItem item, ExploreAreaItemData data)
		{
			WorldMapPlayPointItem.<Init>d__8 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.item = item;
			<Init>d__.data = data;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<WorldMapPlayPointItem.<Init>d__8>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x0602FFD7 RID: 196567 RVA: 0x00B1BF1F File Offset: 0x00B1A11F
		protected override void OnBeforeCreate()
		{
			this.Sequence = new LevelSequencePlayer(this.RootItem);
			LevelSequencePlayer sequence = this.Sequence;
			if (sequence == null)
			{
				return;
			}
			sequence.BindSequenceCloseEvent(new TSequenceEndEvent(this.SequenceCloseEvent), false);
		}

		// Token: 0x0602FFD8 RID: 196568 RVA: 0x00B1BF50 File Offset: 0x00B1A150
		protected override UniTask OnBeforeStartAsync()
		{
			WorldMapPlayPointItem.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<WorldMapPlayPointItem.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602FFD9 RID: 196569 RVA: 0x00B1BF94 File Offset: 0x00B1A194
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIHorizontalLayout));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0602FFDA RID: 196570 RVA: 0x00B1C07C File Offset: 0x00B1A27C
		protected override void OnBeforeShow()
		{
			this.UpdateData(this.ExploreData);
		}

		// Token: 0x0602FFDB RID: 196571 RVA: 0x00B1C08A File Offset: 0x00B1A28A
		public void UpdateAreaItemData(ExploreAreaItemData data)
		{
			if (base.IsShow)
			{
				base.SetUiActive(true);
				this.UpdateData(data);
				return;
			}
			this.ExploreData = data;
		}

		// Token: 0x0602FFDC RID: 196572 RVA: 0x00B1C0AA File Offset: 0x00B1A2AA
		private void UpdateData(ExploreAreaItemData data)
		{
			this.OnlyUpdateData(data);
			this.PlayStartToPause();
		}

		// Token: 0x0602FFDD RID: 196573 RVA: 0x00B1C0BC File Offset: 0x00B1A2BC
		private void OnlyUpdateData(ExploreAreaItemData data)
		{
			this.ExploreData = data;
			this.PlayProgressPanel.UpdateData(data.GetPlayProgressDataIgnoreHiddenList(), null);
			string nameId = data.GetNameId();
			base.GetText(1).ShowTextNew(nameId);
			UUISprite sprite = base.GetSprite(2);
			this.SetSpriteByPath(data.Icon, sprite, false, null, null);
			if (this.SequencePromise.IsFulfilled)
			{
				this.SequencePromise = new CustomPromise();
			}
		}

		// Token: 0x0602FFDE RID: 196574 RVA: 0x00B1C12E File Offset: 0x00B1A32E
		private void OnClick()
		{
			if (this.ExploreData == null)
			{
				return;
			}
			this.ExploreData.TrackPoint();
		}

		// Token: 0x0602FFDF RID: 196575 RVA: 0x00B1C144 File Offset: 0x00B1A344
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer sequence = this.Sequence;
			if (sequence != null)
			{
				sequence.Clear();
			}
			this.Sequence = null;
		}

		// Token: 0x0602FFE0 RID: 196576 RVA: 0x00B1C160 File Offset: 0x00B1A360
		public void PlayStartToPause()
		{
			if (this.ExploreData == null || !this.ExploreData.IsNewRecommendPlay)
			{
				return;
			}
			LevelSequencePlayer sequence = this.Sequence;
			if (sequence != null)
			{
				sequence.PlayLevelSequenceByName("Start", false, null, false);
			}
			LevelSequencePlayer sequence2 = this.Sequence;
			if (sequence2 != null)
			{
				sequence2.PauseSequence();
			}
			base.SetUiActive(false);
		}

		// Token: 0x0602FFE1 RID: 196577 RVA: 0x00B1C1BC File Offset: 0x00B1A3BC
		public UniTask ResumeSequence(int addIndex)
		{
			WorldMapPlayPointItem.<ResumeSequence>d__19 <ResumeSequence>d__;
			<ResumeSequence>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ResumeSequence>d__.<>4__this = this;
			<ResumeSequence>d__.addIndex = addIndex;
			<ResumeSequence>d__.<>1__state = -1;
			<ResumeSequence>d__.<>t__builder.Start<WorldMapPlayPointItem.<ResumeSequence>d__19>(ref <ResumeSequence>d__);
			return <ResumeSequence>d__.<>t__builder.Task;
		}

		// Token: 0x0602FFE2 RID: 196578 RVA: 0x00B1C208 File Offset: 0x00B1A408
		public UniTask CheckFinish()
		{
			WorldMapPlayPointItem.<CheckFinish>d__20 <CheckFinish>d__;
			<CheckFinish>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CheckFinish>d__.<>4__this = this;
			<CheckFinish>d__.<>1__state = -1;
			<CheckFinish>d__.<>t__builder.Start<WorldMapPlayPointItem.<CheckFinish>d__20>(ref <CheckFinish>d__);
			return <CheckFinish>d__.<>t__builder.Task;
		}

		// Token: 0x0602FFE3 RID: 196579 RVA: 0x00B1C24B File Offset: 0x00B1A44B
		public void CheckPlayPointStateSequence()
		{
			this.PlayProgressPanel.CheckPlayStateChanged();
		}

		// Token: 0x0602FFE4 RID: 196580 RVA: 0x00B1C258 File Offset: 0x00B1A458
		private void SequenceCloseEvent(string sequenceName)
		{
			if (sequenceName == "Close".ToString())
			{
				ExploreAreaItemData exploreData = this.ExploreData;
				if (((exploreData != null) ? exploreData.SequenceData : null) != null)
				{
					ExploreAreaItemData sequenceData = this.ExploreData.SequenceData;
					this.ExploreData.SetSequenceData(null);
					this.OnlyUpdateData(sequenceData);
				}
				else
				{
					base.SetUiActive(false);
					LevelSequencePlayer sequence = this.Sequence;
					if (sequence != null)
					{
						sequence.PlayLevelSequenceByName("Refresh", false, null, false);
					}
				}
				this.SequencePromise.SetResult();
			}
		}

		// Token: 0x0602FFE5 RID: 196581 RVA: 0x00B1C2DF File Offset: 0x00B1A4DF
		public void HideMe()
		{
			base.SetUiActive(false);
			ExploreAreaItemData exploreData = this.ExploreData;
			if (exploreData != null)
			{
				exploreData.SetSequenceData(null);
			}
			this.ExploreData = null;
			this.SequencePromise.SetResult();
		}

		// Token: 0x04019E54 RID: 106068
		[Nullable(2)]
		private MapExplorePlayProgressPanel PlayProgressPanel;

		// Token: 0x04019E56 RID: 106070
		[Nullable(2)]
		private LevelSequencePlayer Sequence;

		// Token: 0x04019E57 RID: 106071
		private CustomPromise SequencePromise = new CustomPromise();

		// Token: 0x0200AA3D RID: 43581
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x04033CBC RID: 212156
			BtnRoot,
			// Token: 0x04033CBD RID: 212157
			TxtName,
			// Token: 0x04033CBE RID: 212158
			SpriteIcon,
			// Token: 0x04033CBF RID: 212159
			HorizontalLayout
		}
	}
}
