using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.TimeTrackControl
{
	// Token: 0x02005B44 RID: 23364
	[NullableContext(1)]
	[Nullable(0)]
	public class TimeTrackControlPoint : UiPanelBase
	{
		// Token: 0x06039754 RID: 235348 RVA: 0x0101F943 File Offset: 0x0101DB43
		public TimeTrackControlPoint(UUIItem uiItem, int index, float angle)
		{
			this.Index = index;
			this.Rotator = Rotator.Create(0f, angle, 0f);
			base.CreateThenShowByActor(uiItem.GetOwner(), null);
			this.SequencePlayer = new LevelSequencePlayer(uiItem);
		}

		// Token: 0x06039755 RID: 235349 RVA: 0x0101F984 File Offset: 0x0101DB84
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

		// Token: 0x06039756 RID: 235350 RVA: 0x0101F9F4 File Offset: 0x0101DBF4
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

		// Token: 0x06039757 RID: 235351 RVA: 0x0101FA49 File Offset: 0x0101DC49
		public void HandleDisplay(bool inShow)
		{
		}

		// Token: 0x06039758 RID: 235352 RVA: 0x0101FA4B File Offset: 0x0101DC4B
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

		// Token: 0x06039759 RID: 235353 RVA: 0x0101FA79 File Offset: 0x0101DC79
		public void AddEvent()
		{
		}

		// Token: 0x0603975A RID: 235354 RVA: 0x0101FA7B File Offset: 0x0101DC7B
		public void RemoveEvent()
		{
		}

		// Token: 0x0603975B RID: 235355 RVA: 0x0101FA7D File Offset: 0x0101DC7D
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

		// Token: 0x0603975C RID: 235356 RVA: 0x0101FAB8 File Offset: 0x0101DCB8
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

		// Token: 0x0401E506 RID: 124166
		public const string SHOW = "Show";

		// Token: 0x0401E507 RID: 124167
		public const string HIDE = "Hide";

		// Token: 0x0401E508 RID: 124168
		[Nullable(2)]
		private Rotator Rotator;

		// Token: 0x0401E509 RID: 124169
		public int Index;

		// Token: 0x0401E50A RID: 124170
		[Nullable(2)]
		public LevelSequencePlayer SequencePlayer;

		// Token: 0x0200B72E RID: 46894
		[NullableContext(0)]
		public enum ETimeTrackControlPoint
		{
			// Token: 0x04038A23 RID: 231971
			Point,
			// Token: 0x04038A24 RID: 231972
			Panel,
			// Token: 0x04038A25 RID: 231973
			Normal,
			// Token: 0x04038A26 RID: 231974
			Disable
		}
	}
}
