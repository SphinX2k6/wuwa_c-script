using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Battle.View.Panel
{
	// Token: 0x02004225 RID: 16933
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaBattleSkillTips : UiPanelBase
	{
		// Token: 0x0602ACCC RID: 175308 RVA: 0x00C0C968 File Offset: 0x00C0AB68
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIText))
			};
		}

		// Token: 0x0602ACCD RID: 175309 RVA: 0x00C0C9A1 File Offset: 0x00C0ABA1
		protected override void OnStart()
		{
			this.Sequence = new UiSequencePlayer(this.RootItem);
			this.Sequence.BindOnEndSequenceEvent(new Action<string>(this.SequenceEnd));
		}

		// Token: 0x0602ACCE RID: 175310 RVA: 0x00C0C9CB File Offset: 0x00C0ABCB
		protected override void OnBeforeDestroy()
		{
			this.Sequence.Clear();
			this.RemoveTimeHandler();
		}

		// Token: 0x0602ACCF RID: 175311 RVA: 0x00C0C9DE File Offset: 0x00C0ABDE
		private void SequenceEnd(string sequenceName)
		{
			if (sequenceName == "Close")
			{
				this.SetActive(false);
			}
		}

		// Token: 0x0602ACD0 RID: 175312 RVA: 0x00C0C9F4 File Offset: 0x00C0ABF4
		private void SetPivotAndResetOffset(float pivotX, float pivotY, UIAnchorHorizontalAlign hAlign)
		{
			UUIItem originalItem = this.GetOriginalItem();
			if (originalItem != null)
			{
				originalItem.SetPivot(new FVector2D(pivotX, pivotY));
			}
			if (originalItem != null)
			{
				originalItem.SetAnchorHAlign(hAlign);
			}
			if (originalItem == null)
			{
				return;
			}
			originalItem.SetAnchorOffset(new FVector2D(0f, 0f));
		}

		// Token: 0x0602ACD1 RID: 175313 RVA: 0x00C0CA40 File Offset: 0x00C0AC40
		private void AddTimeHandler()
		{
			this.RemoveTimeHandler();
			this.TimerHandle = TimerSystem.GameplayTimeInstance.Forever(delegate(float _)
			{
				this.CheckMouseInTip();
			}, 100f, 1f, null, null, true);
		}

		// Token: 0x0602ACD2 RID: 175314 RVA: 0x00C0CA71 File Offset: 0x00C0AC71
		private void RemoveTimeHandler()
		{
			if (this.TimerHandle != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.TimerHandle);
				this.TimerHandle = null;
			}
		}

		// Token: 0x0602ACD3 RID: 175315 RVA: 0x00C0CA94 File Offset: 0x00C0AC94
		private void CheckMouseInTip()
		{
			if (this.RootItem == null)
			{
				this.RemoveTimeHandler();
				return;
			}
			ULGUIPointerEventData pointerEventData = LguiEventSystemManager.Instance.GetPointerEventData(0, true);
			if (pointerEventData == null || !pointerEventData.enterComponentStack.Contains(this.RootItem))
			{
				this.HideTips();
			}
		}

		// Token: 0x0602ACD4 RID: 175316 RVA: 0x00C0CADC File Offset: 0x00C0ACDC
		private void ShowTips()
		{
			this.RemoveTimeHandler();
			this.SetActive(true);
			this.Sequence.StopPrevSequence(false, true);
			this.Sequence.PlaySequence("Start", false, null);
		}

		// Token: 0x0602ACD5 RID: 175317 RVA: 0x00C0CB20 File Offset: 0x00C0AD20
		private void HideTips()
		{
			this.RemoveTimeHandler();
			this.Sequence.StopPrevSequence(false, true);
			this.Sequence.PlaySequence("Close", false, null);
		}

		// Token: 0x0602ACD6 RID: 175318 RVA: 0x00C0CB5A File Offset: 0x00C0AD5A
		public void Refresh(IPhantomArenaSkillData data)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), data.SkillName, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.SkillDesc, data.SkillDescParams);
		}

		// Token: 0x0602ACD7 RID: 175319 RVA: 0x00C0CB95 File Offset: 0x00C0AD95
		public void SetTipsPosition(UUIItem attachItem, bool isOwn)
		{
			UUIItem rootItem = this.RootItem;
			if (rootItem != null)
			{
				rootItem.SetUIParent(attachItem, false);
			}
			if (isOwn)
			{
				this.SetPivotAndResetOffset(1f, 0f, UIAnchorHorizontalAlign.Right);
				return;
			}
			this.SetPivotAndResetOffset(0f, 1f, UIAnchorHorizontalAlign.Left);
		}

		// Token: 0x0602ACD8 RID: 175320 RVA: 0x00C0CBD0 File Offset: 0x00C0ADD0
		public void SetTipsActive(bool isActive)
		{
			if (this.IsInActive == isActive)
			{
				return;
			}
			this.IsInActive = isActive;
			if (isActive)
			{
				this.ShowTips();
				return;
			}
			this.AddTimeHandler();
		}

		// Token: 0x040172EE RID: 94958
		protected UiSequencePlayer Sequence;

		// Token: 0x040172EF RID: 94959
		protected bool IsInActive;

		// Token: 0x040172F0 RID: 94960
		protected TimerHandle TimerHandle;

		// Token: 0x02009E46 RID: 40518
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04031345 RID: 201541
			public const int SkillName = 0;

			// Token: 0x04031346 RID: 201542
			public const int SkillDesc = 1;
		}
	}
}
