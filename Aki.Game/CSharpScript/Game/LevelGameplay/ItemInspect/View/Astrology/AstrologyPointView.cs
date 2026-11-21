using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.ItemInspect.View.Astrology
{
	// Token: 0x02005F6C RID: 24428
	[NullableContext(2)]
	[Nullable(0)]
	public class AstrologyPointView : UiPanelBase
	{
		// Token: 0x0603ABF3 RID: 240627 RVA: 0x0109CFBC File Offset: 0x0109B1BC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnInteractClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603ABF4 RID: 240628 RVA: 0x0109D083 File Offset: 0x0109B283
		protected override void OnStart()
		{
			this.SequencePlayer = new UiSequencePlayer(this.RootItem);
			this.SequencePlayer.BindOnEndSequenceEvent(new Action<string>(this.SequenceEnd));
		}

		// Token: 0x0603ABF5 RID: 240629 RVA: 0x0109D0AD File Offset: 0x0109B2AD
		protected override void OnBeforeHide()
		{
			this.InteractPoint();
		}

		// Token: 0x0603ABF6 RID: 240630 RVA: 0x0109D0B5 File Offset: 0x0109B2B5
		protected override void OnBeforeDestroy()
		{
			this.OnPreInteractPoint = null;
			this.OnInteractPoint = null;
			this.PointTagId = 0;
			UiSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.Clear();
			}
			this.SequencePlayer = null;
		}

		// Token: 0x0603ABF7 RID: 240631 RVA: 0x0109D0E4 File Offset: 0x0109B2E4
		[NullableContext(1)]
		private void SequenceEnd(string sequenceName)
		{
			if (sequenceName == "Close")
			{
				this.SetActive(false);
				return;
			}
			if (sequenceName == "Start2")
			{
				this.InteractPoint();
			}
		}

		// Token: 0x0603ABF8 RID: 240632 RVA: 0x0109D10E File Offset: 0x0109B30E
		private void InteractPoint()
		{
			if (this.IsWaitInteract)
			{
				this.IsWaitInteract = false;
				Action<int> onInteractPoint = this.OnInteractPoint;
				if (onInteractPoint == null)
				{
					return;
				}
				onInteractPoint(this.PointTagId);
			}
		}

		// Token: 0x0603ABF9 RID: 240633 RVA: 0x0109D135 File Offset: 0x0109B335
		[NullableContext(1)]
		public void Init(Action onPreInteractPoint, Action<int> onInteractPoint, Func<bool> isInteractEnable)
		{
			this.OnPreInteractPoint = onPreInteractPoint;
			this.OnInteractPoint = onInteractPoint;
			this.IsInteractEnable = isInteractEnable;
		}

		// Token: 0x0603ABFA RID: 240634 RVA: 0x0109D14C File Offset: 0x0109B34C
		public void BindPoint(int tagId, bool isChecked)
		{
			this.PointTagId = tagId;
			base.GetItem(1).SetUIActive(!isChecked);
			base.GetItem(2).SetUIActive(isChecked);
		}

		// Token: 0x0603ABFB RID: 240635 RVA: 0x0109D174 File Offset: 0x0109B374
		public void SetPointActive(bool isActive)
		{
			if (isActive == this.IsActive)
			{
				return;
			}
			this.IsActive = isActive;
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

		// Token: 0x0603ABFC RID: 240636 RVA: 0x0109D1E0 File Offset: 0x0109B3E0
		private void OnInteractClick()
		{
			if (this.IsInteractEnable == null || !this.IsInteractEnable())
			{
				return;
			}
			Action onPreInteractPoint = this.OnPreInteractPoint;
			if (onPreInteractPoint != null)
			{
				onPreInteractPoint();
			}
			this.IsWaitInteract = true;
			this.SequencePlayer.PlaySequencePurely("Start2", false, false);
		}

		// Token: 0x0401EE29 RID: 126505
		private UiSequencePlayer SequencePlayer;

		// Token: 0x0401EE2A RID: 126506
		private Action OnPreInteractPoint;

		// Token: 0x0401EE2B RID: 126507
		private Action<int> OnInteractPoint;

		// Token: 0x0401EE2C RID: 126508
		private Func<bool> IsInteractEnable;

		// Token: 0x0401EE2D RID: 126509
		private int PointTagId;

		// Token: 0x0401EE2E RID: 126510
		private bool IsActive;

		// Token: 0x0401EE2F RID: 126511
		private bool IsWaitInteract;

		// Token: 0x0200B8B9 RID: 47289
		[NullableContext(0)]
		private class EComponentType
		{
			// Token: 0x04039055 RID: 233557
			public const int InteractButton = 0;

			// Token: 0x04039056 RID: 233558
			public const int YellowItem = 1;

			// Token: 0x04039057 RID: 233559
			public const int WhiteItem = 2;
		}
	}
}
