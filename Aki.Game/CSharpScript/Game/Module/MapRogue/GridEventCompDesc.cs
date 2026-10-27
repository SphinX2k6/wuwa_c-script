using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x020055D7 RID: 21975
	[NullableContext(2)]
	[Nullable(0)]
	public class GridEventCompDesc : UiPanelBase, IEventStepItem
	{
		// Token: 0x170086FE RID: 34558
		// (get) Token: 0x06037FEC RID: 229356 RVA: 0x00D436DA File Offset: 0x00D418DA
		public int StepId { get; }

		// Token: 0x170086FF RID: 34559
		// (get) Token: 0x06037FED RID: 229357 RVA: 0x00D436E2 File Offset: 0x00D418E2
		public EStepType StepType { get; }

		// Token: 0x17008700 RID: 34560
		// (get) Token: 0x06037FEE RID: 229358 RVA: 0x00D436EA File Offset: 0x00D418EA
		// (set) Token: 0x06037FEF RID: 229359 RVA: 0x00D436F2 File Offset: 0x00D418F2
		public Action<int, EStepType> CanInteractCallback { get; set; }

		// Token: 0x17008701 RID: 34561
		// (get) Token: 0x06037FF0 RID: 229360 RVA: 0x00D436FB File Offset: 0x00D418FB
		// (set) Token: 0x06037FF1 RID: 229361 RVA: 0x00D43703 File Offset: 0x00D41903
		public Action<int, int> ExecuteStep { get; set; }

		// Token: 0x06037FF2 RID: 229362 RVA: 0x00D4370C File Offset: 0x00D4190C
		public GridEventCompDesc(int stepId, EStepType stepType = EStepType.Desc)
		{
			this.StepId = stepId;
			this.StepType = stepType;
		}

		// Token: 0x06037FF3 RID: 229363 RVA: 0x00D43724 File Offset: 0x00D41924
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIText)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUISprite)),
				new ValueTuple<int, Type>(3, typeof(UUIText))
			};
		}

		// Token: 0x06037FF4 RID: 229364 RVA: 0x00D43794 File Offset: 0x00D41994
		protected override void OnStart()
		{
			UUIText text = base.GetText(0);
			text.SetUIActive(false);
			this.TextAnimDataComp = (text.GetOwner().GetComponentByClass(UUIEffectTextAnimation.StaticClass()) as UUIEffectTextAnimation);
			this.TextPlayTweenComp = (text.GetOwner().GetComponentByClass(ULGUIPlayTweenComponent.StaticClass()) as ULGUIPlayTweenComponent);
			UUIEffectTextAnimation textAnimDataComp = this.TextAnimDataComp;
			if (textAnimDataComp != null)
			{
				textAnimDataComp.SetSelectorOffset(1f);
			}
			this.TextPlayTweenEndCb = DelegateUtils.ToManualReleaseDelegate<FLGUIPlayTweenCompleteDynamicDelegate>(new Action(this.OnTweenEnd));
			this.TextPlayTweenEndCbWrapper = this.TextPlayTweenComp.GetPlayTween().RegisterOnComplete(this.TextPlayTweenEndCb);
			this.TextSpeed = ConfigCommonParamById.GetFloatConfig("MapRogueRandomEventTextSpeed").GetValueOrDefault(10f);
		}

		// Token: 0x06037FF5 RID: 229365 RVA: 0x00D43858 File Offset: 0x00D41A58
		protected override void OnBeforeDestroy()
		{
			if (this.TextPlayTweenEndCbWrapper != null)
			{
				ULGUIPlayTweenComponent textPlayTweenComp = this.TextPlayTweenComp;
				if (textPlayTweenComp != null)
				{
					ULGUIPlayTween playTween = textPlayTweenComp.GetPlayTween();
					if (playTween != null)
					{
						playTween.UnregisterOnComplete(this.TextPlayTweenEndCbWrapper);
					}
				}
				this.TextPlayTweenEndCbWrapper = null;
			}
			DelegateUtils.ReleaseManualReleaseDelegate(new Action(this.OnTweenEnd));
			this.TextPlayTweenEndCb = null;
		}

		// Token: 0x06037FF6 RID: 229366 RVA: 0x00D438B4 File Offset: 0x00D41AB4
		[NullableContext(1)]
		private void SetTag(string tagId, [Nullable(2)] string tagColor = null)
		{
			UUIText text = base.GetText(3);
			UUISprite sprite = base.GetSprite(2);
			UUIItem item = base.GetItem(1);
			if (StringUtils.IsEmpty(tagId))
			{
				item.SetUIActive(false);
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(text, tagId, Array.Empty<object>());
			if (!StringUtils.IsEmpty(tagColor))
			{
				FColor color = FColor.FromHex(tagColor);
				sprite.SetColor(color);
			}
			item.SetUIActive(true);
		}

		// Token: 0x06037FF7 RID: 229367 RVA: 0x00D43918 File Offset: 0x00D41B18
		[NullableContext(1)]
		private void ShowText(string textId, bool playEnd)
		{
			UUIText text = base.GetText(0);
			LguiUtil.Instance.SetLocalTextNew(text, textId, Array.Empty<object>());
			text.SetUIActive(true);
			int displayCharLength = text.GetDisplayCharLength();
			if (this.TextPlayTweenComp != null)
			{
				if (playEnd)
				{
					this.TextAnimDataComp.SetSelectorOffset(0f);
					return;
				}
				float duration = (float)displayCharLength / this.TextSpeed;
				this.TextAnimDataComp.SetSelectorOffset(1f);
				this.TextPlayTweenComp.GetPlayTween().duration = duration;
				this.TextPlayTweenComp.Play();
				this.IsInPlay = true;
			}
		}

		// Token: 0x06037FF8 RID: 229368 RVA: 0x00D439A8 File Offset: 0x00D41BA8
		public void Refresh(bool end)
		{
			RogueResEventStep? rogueEventStepById = MapRogueConfig.Instance.GetRogueEventStepById(this.StepId);
			if (rogueEventStepById == null)
			{
				return;
			}
			this.SetTag(rogueEventStepById.Value.TitleKey, rogueEventStepById.Value.TagColor);
			this.ShowText(rogueEventStepById.Value.TextKey, end);
			this.SetActive(true);
		}

		// Token: 0x06037FF9 RID: 229369 RVA: 0x00D43A11 File Offset: 0x00D41C11
		public void MaskClick()
		{
			this.ShowAllText();
		}

		// Token: 0x06037FFA RID: 229370 RVA: 0x00D43A1C File Offset: 0x00D41C1C
		public void ShowAllText()
		{
			if (!this.IsInPlay)
			{
				return;
			}
			this.TextPlayTweenComp.Stop();
			this.TextAnimDataComp.SetSelectorOffset(0f);
			Action<int, EStepType> canInteractCallback = this.CanInteractCallback;
			if (canInteractCallback == null)
			{
				return;
			}
			canInteractCallback(this.StepId, this.StepType);
		}

		// Token: 0x06037FFB RID: 229371 RVA: 0x00D43A69 File Offset: 0x00D41C69
		private void OnTweenEnd()
		{
			this.IsInPlay = false;
			Action<int, EStepType> canInteractCallback = this.CanInteractCallback;
			if (canInteractCallback == null)
			{
				return;
			}
			canInteractCallback(this.StepId, this.StepType);
		}

		// Token: 0x0401D6A3 RID: 120483
		private UUIEffectTextAnimation TextAnimDataComp;

		// Token: 0x0401D6A4 RID: 120484
		private ULGUIPlayTweenComponent TextPlayTweenComp;

		// Token: 0x0401D6A5 RID: 120485
		private FLGUIPlayTweenCompleteDynamicDelegate TextPlayTweenEndCb;

		// Token: 0x0401D6A6 RID: 120486
		private FLGUIDelegateHandleWrapper TextPlayTweenEndCbWrapper;

		// Token: 0x0401D6A7 RID: 120487
		private float TextSpeed;

		// Token: 0x0401D6A8 RID: 120488
		private bool IsInPlay;
	}
}
