using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.TimeTrackControl
{
	// Token: 0x020069E8 RID: 27112
	[NullableContext(1)]
	[Nullable(0)]
	public class TimeTrackControlPoint : UiPanelBase
	{
		// Token: 0x06043718 RID: 276248 RVA: 0x0107B48F File Offset: 0x0107968F
		public TimeTrackControlPoint(UUIItem uiItem, int index, float angle)
		{
			this.Index = index;
			this.Rotator = Rotator.Create(0f, angle, 0f);
			base.CreateThenShowByActor(uiItem.GetOwner(), null);
			this.SequencePlayer = new LevelSequencePlayer(uiItem);
		}

		// Token: 0x06043719 RID: 276249 RVA: 0x0107B4D0 File Offset: 0x010796D0
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem))
			};
		}

		// Token: 0x0604371A RID: 276250 RVA: 0x0107B540 File Offset: 0x01079740
		protected override void OnStart()
		{
			base.GetItem(2).SetUIActive(true);
			base.GetItem(3).SetUIActive(false);
			if (this.Rotator != null)
			{
				UUIItem item = base.GetItem(0);
				if (item != null)
				{
					FRotator frotator = this.Rotator.ToUeRotator();
					item.SetUIRelativeRotation(frotator);
				}
			}
			this.AddEvent();
		}

		// Token: 0x0604371B RID: 276251 RVA: 0x0107B595 File Offset: 0x01079795
		public void HandleDisplay(bool inShow)
		{
		}

		// Token: 0x0604371C RID: 276252 RVA: 0x0107B597 File Offset: 0x01079797
		protected override void OnBeforeDestroy()
		{
			this.Rotator = null;
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.Clear();
			}
			this.SequencePlayer = null;
			this.RemoveEvent();
			base.Destroy(null);
		}

		// Token: 0x0604371D RID: 276253 RVA: 0x0107B5C5 File Offset: 0x010797C5
		public void AddEvent()
		{
		}

		// Token: 0x0604371E RID: 276254 RVA: 0x0107B5C7 File Offset: 0x010797C7
		public void RemoveEvent()
		{
		}

		// Token: 0x0604371F RID: 276255 RVA: 0x0107B5C9 File Offset: 0x010797C9
		public void UpdateState(bool inEnable)
		{
			if (inEnable)
			{
				base.GetItem(2).SetUIActive(true);
				base.GetItem(3).SetUIActive(false);
				return;
			}
			base.GetItem(2).SetUIActive(false);
			base.GetItem(3).SetUIActive(true);
		}

		// Token: 0x06043720 RID: 276256 RVA: 0x0107B604 File Offset: 0x01079804
		public void ToggleSelected(bool isSelected)
		{
			if (this.SequencePlayer == null)
			{
				return;
			}
			this.SequencePlayer.StopCurrentSequence(false, true);
			if (isSelected)
			{
				this.SequencePlayer.PlaySequencePurely("Show", false, false, null, null, false);
				return;
			}
			this.SequencePlayer.PlaySequencePurely("Hide", false, false, null, null, false);
		}

		// Token: 0x04023316 RID: 144150
		public const string SHOW = "Show";

		// Token: 0x04023317 RID: 144151
		public const string HIDE = "Hide";

		// Token: 0x04023318 RID: 144152
		[Nullable(2)]
		private Rotator Rotator;

		// Token: 0x04023319 RID: 144153
		public int Index;

		// Token: 0x0402331A RID: 144154
		[Nullable(2)]
		public LevelSequencePlayer SequencePlayer;

		// Token: 0x0200CB4F RID: 52047
		[NullableContext(0)]
		public enum ETimeTrackControlPoint
		{
			// Token: 0x0403D641 RID: 251457
			Point,
			// Token: 0x0403D642 RID: 251458
			Panel,
			// Token: 0x0403D643 RID: 251459
			Normal,
			// Token: 0x0403D644 RID: 251460
			Disable
		}
	}
}
