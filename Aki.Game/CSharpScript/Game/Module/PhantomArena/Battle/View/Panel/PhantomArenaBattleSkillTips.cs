using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.PhantomArena.Battle.View.Panel
{
	// Token: 0x02005255 RID: 21077
	[NullableContext(1)]
	[Nullable(0)]
	public class PhantomArenaBattleSkillTips : UiPanelBase
	{
		// Token: 0x06035DD1 RID: 220625 RVA: 0x00CBF2D8 File Offset: 0x00CBD4D8
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIText))
			};
		}

		// Token: 0x06035DD2 RID: 220626 RVA: 0x00CBF311 File Offset: 0x00CBD511
		protected override void OnStart()
		{
			this.Sequence = new UiSequencePlayer(this.RootItem);
			this.Sequence.BindOnEndSequenceEvent(new Action<string>(this.SequenceEnd));
		}

		// Token: 0x06035DD3 RID: 220627 RVA: 0x00CBF33B File Offset: 0x00CBD53B
		protected override void OnBeforeDestroy()
		{
			this.Sequence.Clear();
			this.RemoveTimeHandler();
		}

		// Token: 0x06035DD4 RID: 220628 RVA: 0x00CBF34E File Offset: 0x00CBD54E
		private void SequenceEnd(string sequenceName)
		{
			if (sequenceName == "Close")
			{
				this.SetActive(false);
			}
		}

		// Token: 0x06035DD5 RID: 220629 RVA: 0x00CBF364 File Offset: 0x00CBD564
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

		// Token: 0x06035DD6 RID: 220630 RVA: 0x00CBF3B0 File Offset: 0x00CBD5B0
		private void AddTimeHandler()
		{
			this.RemoveTimeHandler();
			this.TimerHandle = TimerSystem.GameplayTimeInstance.Forever(delegate(float _)
			{
				this.CheckMouseInTip();
			}, 100f, 1f, null, null, true);
		}

		// Token: 0x06035DD7 RID: 220631 RVA: 0x00CBF3E1 File Offset: 0x00CBD5E1
		private void RemoveTimeHandler()
		{
			if (this.TimerHandle != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.TimerHandle);
				this.TimerHandle = null;
			}
		}

		// Token: 0x06035DD8 RID: 220632 RVA: 0x00CBF404 File Offset: 0x00CBD604
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

		// Token: 0x06035DD9 RID: 220633 RVA: 0x00CBF44C File Offset: 0x00CBD64C
		private void ShowTips()
		{
			this.RemoveTimeHandler();
			this.SetActive(true);
			this.Sequence.StopPrevSequence(false, true);
			this.Sequence.PlaySequence("Start", false, null);
		}

		// Token: 0x06035DDA RID: 220634 RVA: 0x00CBF490 File Offset: 0x00CBD690
		private void HideTips()
		{
			this.RemoveTimeHandler();
			this.Sequence.StopPrevSequence(false, true);
			this.Sequence.PlaySequence("Close", false, null);
		}

		// Token: 0x06035DDB RID: 220635 RVA: 0x00CBF4CA File Offset: 0x00CBD6CA
		public void Refresh(IPhantomArenaSkillData data)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), data.SkillName, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.SkillDesc, data.SkillDescParams);
		}

		// Token: 0x06035DDC RID: 220636 RVA: 0x00CBF505 File Offset: 0x00CBD705
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

		// Token: 0x06035DDD RID: 220637 RVA: 0x00CBF540 File Offset: 0x00CBD740
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

		// Token: 0x0401C8B9 RID: 116921
		protected UiSequencePlayer Sequence;

		// Token: 0x0401C8BA RID: 116922
		protected bool IsInActive;

		// Token: 0x0401C8BB RID: 116923
		protected TimerHandle TimerHandle;

		// Token: 0x0200B40E RID: 46094
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x040368F2 RID: 223474
			public const int SkillName = 0;

			// Token: 0x040368F3 RID: 223475
			public const int SkillDesc = 1;
		}
	}
}
