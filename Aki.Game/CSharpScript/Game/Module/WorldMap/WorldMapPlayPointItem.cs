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
	// Token: 0x020036DC RID: 14044
	[NullableContext(1)]
	[Nullable(0)]
	public class WorldMapPlayPointItem : UiPanelBase
	{
		// Token: 0x17004AEF RID: 19183
		// (get) Token: 0x060247A1 RID: 149409 RVA: 0x00A4BE57 File Offset: 0x00A4A057
		// (set) Token: 0x060247A2 RID: 149410 RVA: 0x00A4BE5F File Offset: 0x00A4A05F
		[Nullable(2)]
		public ExploreAreaItemData ExploreData { [NullableContext(2)] get; [NullableContext(2)] private set; }

		// Token: 0x060247A3 RID: 149411 RVA: 0x00A4BE68 File Offset: 0x00A4A068
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

		// Token: 0x060247A4 RID: 149412 RVA: 0x00A4BEBB File Offset: 0x00A4A0BB
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

		// Token: 0x060247A5 RID: 149413 RVA: 0x00A4BEEC File Offset: 0x00A4A0EC
		protected override UniTask OnBeforeStartAsync()
		{
			WorldMapPlayPointItem.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<WorldMapPlayPointItem.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060247A6 RID: 149414 RVA: 0x00A4BF30 File Offset: 0x00A4A130
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

		// Token: 0x060247A7 RID: 149415 RVA: 0x00A4C018 File Offset: 0x00A4A218
		protected override void OnBeforeShow()
		{
			this.UpdateData(this.ExploreData);
		}

		// Token: 0x060247A8 RID: 149416 RVA: 0x00A4C026 File Offset: 0x00A4A226
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

		// Token: 0x060247A9 RID: 149417 RVA: 0x00A4C046 File Offset: 0x00A4A246
		private void UpdateData(ExploreAreaItemData data)
		{
			this.OnlyUpdateData(data);
			this.PlayStartToPause();
		}

		// Token: 0x060247AA RID: 149418 RVA: 0x00A4C058 File Offset: 0x00A4A258
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

		// Token: 0x060247AB RID: 149419 RVA: 0x00A4C0CA File Offset: 0x00A4A2CA
		private void OnClick()
		{
			if (this.ExploreData == null)
			{
				return;
			}
			this.ExploreData.TrackPoint();
		}

		// Token: 0x060247AC RID: 149420 RVA: 0x00A4C0E0 File Offset: 0x00A4A2E0
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer sequence = this.Sequence;
			if (sequence != null)
			{
				sequence.Clear();
			}
			this.Sequence = null;
		}

		// Token: 0x060247AD RID: 149421 RVA: 0x00A4C0FC File Offset: 0x00A4A2FC
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

		// Token: 0x060247AE RID: 149422 RVA: 0x00A4C158 File Offset: 0x00A4A358
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

		// Token: 0x060247AF RID: 149423 RVA: 0x00A4C1A4 File Offset: 0x00A4A3A4
		public UniTask CheckFinish()
		{
			WorldMapPlayPointItem.<CheckFinish>d__20 <CheckFinish>d__;
			<CheckFinish>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CheckFinish>d__.<>4__this = this;
			<CheckFinish>d__.<>1__state = -1;
			<CheckFinish>d__.<>t__builder.Start<WorldMapPlayPointItem.<CheckFinish>d__20>(ref <CheckFinish>d__);
			return <CheckFinish>d__.<>t__builder.Task;
		}

		// Token: 0x060247B0 RID: 149424 RVA: 0x00A4C1E7 File Offset: 0x00A4A3E7
		public void CheckPlayPointStateSequence()
		{
			this.PlayProgressPanel.CheckPlayStateChanged();
		}

		// Token: 0x060247B1 RID: 149425 RVA: 0x00A4C1F4 File Offset: 0x00A4A3F4
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

		// Token: 0x060247B2 RID: 149426 RVA: 0x00A4C27B File Offset: 0x00A4A47B
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

		// Token: 0x04014504 RID: 83204
		[Nullable(2)]
		private MapExplorePlayProgressPanel PlayProgressPanel;

		// Token: 0x04014506 RID: 83206
		[Nullable(2)]
		private LevelSequencePlayer Sequence;

		// Token: 0x04014507 RID: 83207
		private CustomPromise SequencePromise = new CustomPromise();

		// Token: 0x020093F0 RID: 37872
		[NullableContext(0)]
		private enum EChildType
		{
			// Token: 0x0402E448 RID: 189512
			BtnRoot,
			// Token: 0x0402E449 RID: 189513
			TxtName,
			// Token: 0x0402E44A RID: 189514
			SpriteIcon,
			// Token: 0x0402E44B RID: 189515
			HorizontalLayout
		}
	}
}
