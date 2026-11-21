using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.BattleUi.Views
{
	// Token: 0x02004CC5 RID: 19653
	[NullableContext(2)]
	[Nullable(0)]
	public class BattleSkillExploreItem : BattleSkillItem
	{
		// Token: 0x06031214 RID: 201236 RVA: 0x00DB7FBC File Offset: 0x00DB61BC
		protected override UUIButtonComponent GetPointEventButton()
		{
			return this.CustomPointEventButton;
		}

		// Token: 0x06031215 RID: 201237 RVA: 0x00DB7FC4 File Offset: 0x00DB61C4
		protected override void OnRegisterComponent()
		{
			base.OnRegisterComponent();
			this.ComponentRegisterInfos.Add(new ValueTuple<int, Type>(14, typeof(UUIButtonComponent)));
		}

		// Token: 0x06031216 RID: 201238 RVA: 0x00DB7FE8 File Offset: 0x00DB61E8
		public override void Initialize(object param = null)
		{
			this.CustomPointEventButton = base.GetButton(14);
			EventSystem.Instance.Add(EEventName.GuideTouchIdInject, new Action<int, AActor>(this.OnGuideTouchIdInject));
			base.Initialize(param);
		}

		// Token: 0x06031217 RID: 201239 RVA: 0x00DB801B File Offset: 0x00DB621B
		public override void Reset()
		{
			this.CustomPointEventButton = null;
			EventSystem.Instance.Remove(EEventName.GuideTouchIdInject, new Action<int, AActor>(this.OnGuideTouchIdInject));
			base.Reset();
		}

		// Token: 0x06031218 RID: 201240 RVA: 0x00DB8046 File Offset: 0x00DB6246
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

		// Token: 0x06031219 RID: 201241 RVA: 0x00DB806C File Offset: 0x00DB626C
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

		// Token: 0x0603121A RID: 201242 RVA: 0x00DB80D1 File Offset: 0x00DB62D1
		protected override bool IsNeedLongPress()
		{
			return this.SkillButtonData.IsEnableLongPress();
		}

		// Token: 0x0603121B RID: 201243 RVA: 0x00DB80DE File Offset: 0x00DB62DE
		protected override void OnSkillButtonPressed()
		{
			BattleUiModel.Instance.IsLongPressExploreButton = false;
			base.OnSkillButtonPressed();
		}

		// Token: 0x0603121C RID: 201244 RVA: 0x00DB80F1 File Offset: 0x00DB62F1
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

		// Token: 0x0603121D RID: 201245 RVA: 0x00DB8130 File Offset: 0x00DB6330
		protected virtual void OpenRouletteMainView(int touchId)
		{
			RouletteMainViewProxyBase currentRouletteMainViewProxy = RouletteController.Instance.GetCurrentRouletteMainViewProxy();
			currentRouletteMainViewProxy.TouchId = new int?(touchId);
			RouletteController.Instance.OpenRouletteMainView(currentRouletteMainViewProxy);
		}

		// Token: 0x0401A09F RID: 106655
		private UUIButtonComponent CustomPointEventButton;

		// Token: 0x0401A0A0 RID: 106656
		private int? LongPressTouchId;

		// Token: 0x0200A945 RID: 43333
		[NullableContext(0)]
		private enum EBattleSkillExploreItem
		{
			// Token: 0x040344BA RID: 214202
			PointEventButton = 14
		}
	}
}
