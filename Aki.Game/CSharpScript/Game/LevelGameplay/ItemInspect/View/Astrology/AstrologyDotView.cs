using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.ItemInspect.View.Astrology
{
	// Token: 0x02006DE7 RID: 28135
	public class AstrologyDotView : UiPanelBase
	{
		// Token: 0x06044A2B RID: 281131 RVA: 0x010F0472 File Offset: 0x010EE672
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem))
			};
		}

		// Token: 0x06044A2C RID: 281132 RVA: 0x010F04AB File Offset: 0x010EE6AB
		protected override void OnStart()
		{
			this.SequencePlayer = new UiSequencePlayer(this.RootItem);
			this.SequencePlayer.BindOnEndSequenceEvent(new Action<string>(this.SequenceEnd));
		}

		// Token: 0x06044A2D RID: 281133 RVA: 0x010F04D5 File Offset: 0x010EE6D5
		protected override void OnBeforeDestroy()
		{
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.Clear();
			}
			this.SequencePlayer = null;
		}

		// Token: 0x06044A2E RID: 281134 RVA: 0x010F04EF File Offset: 0x010EE6EF
		[NullableContext(1)]
		private void SequenceEnd(string sequenceName)
		{
			if (sequenceName == "Close")
			{
				this.SetActive(false);
			}
		}

		// Token: 0x06044A2F RID: 281135 RVA: 0x010F0508 File Offset: 0x010EE708
		public void SetDotActive(bool isActive, int? pointTagId = null)
		{
			if (isActive == this.IsActive)
			{
				return;
			}
			this.IsActive = isActive;
			this.PointTagId = pointTagId;
			this.SequencePlayer.StopPrevSequence(false, true);
			if (isActive)
			{
				this.SetActive(true);
				this.SequencePlayer.PlaySequencePurely("Start", false, false);
				this.SequencePlayer.PlaySequencePurely("Loop", false, false);
				return;
			}
			this.SequencePlayer.PlaySequencePurely("Close", false, false);
		}

		// Token: 0x06044A30 RID: 281136 RVA: 0x010F057B File Offset: 0x010EE77B
		public void SetChecked(bool isChecked)
		{
			base.GetItem(0).SetUIActive(!isChecked);
			base.GetItem(1).SetUIActive(isChecked);
		}

		// Token: 0x06044A31 RID: 281137 RVA: 0x010F059A File Offset: 0x010EE79A
		public int? GetPointTagId()
		{
			return this.PointTagId;
		}

		// Token: 0x04023B3F RID: 146239
		[Nullable(2)]
		private UiSequencePlayer SequencePlayer;

		// Token: 0x04023B40 RID: 146240
		private bool IsActive;

		// Token: 0x04023B41 RID: 146241
		private int? PointTagId;

		// Token: 0x0200CCBC RID: 52412
		private class EComponentType
		{
			// Token: 0x0403DBFD RID: 252925
			public const int YellowItem = 0;

			// Token: 0x0403DBFE RID: 252926
			public const int WhiteItem = 1;
		}
	}
}
