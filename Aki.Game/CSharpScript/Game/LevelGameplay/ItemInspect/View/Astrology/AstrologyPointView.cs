using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.ItemInspect.View.Astrology
{
	// Token: 0x02006DED RID: 28141
	[NullableContext(2)]
	[Nullable(0)]
	public class AstrologyPointView : UiPanelBase
	{
		// Token: 0x06044A8F RID: 281231 RVA: 0x010F2D70 File Offset: 0x010F0F70
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

		// Token: 0x06044A90 RID: 281232 RVA: 0x010F2E37 File Offset: 0x010F1037
		protected override void OnStart()
		{
			this.SequencePlayer = new UiSequencePlayer(this.RootItem);
			this.SequencePlayer.BindOnEndSequenceEvent(new Action<string>(this.SequenceEnd));
		}

		// Token: 0x06044A91 RID: 281233 RVA: 0x010F2E61 File Offset: 0x010F1061
		protected override void OnBeforeHide()
		{
			this.InteractPoint();
		}

		// Token: 0x06044A92 RID: 281234 RVA: 0x010F2E69 File Offset: 0x010F1069
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

		// Token: 0x06044A93 RID: 281235 RVA: 0x010F2E98 File Offset: 0x010F1098
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

		// Token: 0x06044A94 RID: 281236 RVA: 0x010F2EC2 File Offset: 0x010F10C2
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

		// Token: 0x06044A95 RID: 281237 RVA: 0x010F2EE9 File Offset: 0x010F10E9
		[NullableContext(1)]
		public void Init(Action onPreInteractPoint, Action<int> onInteractPoint, Func<bool> isInteractEnable)
		{
			this.OnPreInteractPoint = onPreInteractPoint;
			this.OnInteractPoint = onInteractPoint;
			this.IsInteractEnable = isInteractEnable;
		}

		// Token: 0x06044A96 RID: 281238 RVA: 0x010F2F00 File Offset: 0x010F1100
		public void BindPoint(int tagId, bool isChecked)
		{
			this.PointTagId = tagId;
			base.GetItem(1).SetUIActive(!isChecked);
			base.GetItem(2).SetUIActive(isChecked);
		}

		// Token: 0x06044A97 RID: 281239 RVA: 0x010F2F28 File Offset: 0x010F1128
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

		// Token: 0x06044A98 RID: 281240 RVA: 0x010F2F94 File Offset: 0x010F1194
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

		// Token: 0x04023B87 RID: 146311
		private UiSequencePlayer SequencePlayer;

		// Token: 0x04023B88 RID: 146312
		private Action OnPreInteractPoint;

		// Token: 0x04023B89 RID: 146313
		private Action<int> OnInteractPoint;

		// Token: 0x04023B8A RID: 146314
		private Func<bool> IsInteractEnable;

		// Token: 0x04023B8B RID: 146315
		private int PointTagId;

		// Token: 0x04023B8C RID: 146316
		private bool IsActive;

		// Token: 0x04023B8D RID: 146317
		private bool IsWaitInteract;

		// Token: 0x0200CCC9 RID: 52425
		[NullableContext(0)]
		private class EComponentType
		{
			// Token: 0x0403DC33 RID: 252979
			public const int InteractButton = 0;

			// Token: 0x0403DC34 RID: 252980
			public const int YellowItem = 1;

			// Token: 0x0403DC35 RID: 252981
			public const int WhiteItem = 2;
		}
	}
}
