using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02005CE3 RID: 23779
	[NullableContext(2)]
	[Nullable(0)]
	public class BattleSkillExploreItem : BattleSkillItem
	{
		// Token: 0x0603C2BE RID: 246462 RVA: 0x00E67A08 File Offset: 0x00E65C08
		protected override UUIButtonComponent GetPointEventButton()
		{
			return this.CustomPointEventButton;
		}

		// Token: 0x0603C2BF RID: 246463 RVA: 0x00E67A10 File Offset: 0x00E65C10
		protected override void OnRegisterComponent()
		{
			base.OnRegisterComponent();
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(13, typeof(UUIButtonComponent)));
		}

		// Token: 0x0603C2C0 RID: 246464 RVA: 0x00E67A34 File Offset: 0x00E65C34
		public override void Initialize(object param = null)
		{
			this.CustomPointEventButton = base.GetButton(13);
			EventSystem.Instance.Add(EEventName.GuideTouchIdInject, new Action<int, AActor>(this.OnGuideTouchIdInject));
			base.Initialize(param);
		}

		// Token: 0x0603C2C1 RID: 246465 RVA: 0x00E67A67 File Offset: 0x00E65C67
		public override void Reset()
		{
			this.CustomPointEventButton = null;
			EventSystem.Instance.Remove(EEventName.GuideTouchIdInject, new Action<int, AActor>(this.OnGuideTouchIdInject));
			base.Reset();
		}

		// Token: 0x0603C2C2 RID: 246466 RVA: 0x00E67A92 File Offset: 0x00E65C92
		[NullableContext(1)]
		private void OnGuideTouchIdInject(int touchId, AActor actor)
		{
			if (this.IsLongPress)
			{
				return;
			}
			if (this.CustomPointEventButton.GetOwner() == actor)
			{
				this.LongPressTouchId = new int?(touchId);
			}
		}

		// Token: 0x0603C2C3 RID: 246467 RVA: 0x00E67AB8 File Offset: 0x00E65CB8
		[NullableContext(1)]
		protected override void OnTouch(string touchIdName, InputDistributeDefine.ITouchData touchData, InputIdentification inputIdentification)
		{
			if (this.IsLongPress)
			{
				return;
			}
			int num = int.Parse(touchIdName);
			TouchFingerData touchFingerData = TouchFingerManager.Instance.GetTouchFingerData((EFingerIndex)num);
			USceneComponent usceneComponent;
			if (touchFingerData == null)
			{
				usceneComponent = null;
			}
			else
			{
				ULGUIPointerEventData pointerEventData = touchFingerData.GetPointerEventData();
				usceneComponent = ((pointerEventData != null) ? pointerEventData.pressComponent : null);
			}
			USceneComponent usceneComponent2 = usceneComponent;
			if (usceneComponent2 == null)
			{
				return;
			}
			if (usceneComponent2.GetOwner() != this.CustomPointEventButton.GetOwner())
			{
				return;
			}
			this.LongPressTouchId = new int?(num);
		}

		// Token: 0x0603C2C4 RID: 246468 RVA: 0x00E67B1D File Offset: 0x00E65D1D
		protected override bool IsNeedLongPress()
		{
			return this.SkillButtonData.IsEnableLongPress();
		}

		// Token: 0x0603C2C5 RID: 246469 RVA: 0x00E67B2A File Offset: 0x00E65D2A
		protected override void OnSkillButtonPressed()
		{
			BattleUiModel.Instance.IsLongPressExploreButton = false;
			base.OnSkillButtonPressed();
		}

		// Token: 0x0603C2C6 RID: 246470 RVA: 0x00E67B3D File Offset: 0x00E65D3D
		protected override void OnLongPressButton()
		{
			base.OnLongPressButton();
			BattleUiModel.Instance.IsLongPressExploreButton = true;
			if (this.LongPressTouchId != null)
			{
				this.OpenRouletteMainView(this.LongPressTouchId.Value);
				this.LongPressTouchId = null;
			}
		}

		// Token: 0x0603C2C7 RID: 246471 RVA: 0x00E67B7C File Offset: 0x00E65D7C
		protected virtual void OpenRouletteMainView(int touchId)
		{
			RouletteMainViewProxyBase currentRouletteMainViewProxy = RouletteController.Instance.GetCurrentRouletteMainViewProxy();
			currentRouletteMainViewProxy.TouchId = new int?(touchId);
			RouletteController.Instance.OpenRouletteMainView(currentRouletteMainViewProxy);
		}

		// Token: 0x0401F5E6 RID: 128486
		private UUIButtonComponent CustomPointEventButton;

		// Token: 0x0401F5E7 RID: 128487
		private int? LongPressTouchId;

		// Token: 0x0200BF3F RID: 48959
		[NullableContext(0)]
		private enum EBattleSkillExploreItem
		{
			// Token: 0x04039AF8 RID: 236280
			PointEventButton = 13
		}
	}
}
