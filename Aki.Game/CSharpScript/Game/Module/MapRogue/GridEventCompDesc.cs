using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x020045AD RID: 17837
	[NullableContext(2)]
	[Nullable(0)]
	public class GridEventCompDesc : UiPanelBase, IEventStepItem
	{
		// Token: 0x17005AC5 RID: 23237
		// (get) Token: 0x0602CEEA RID: 184042 RVA: 0x00C91422 File Offset: 0x00C8F622
		public int StepId { get; }

		// Token: 0x17005AC6 RID: 23238
		// (get) Token: 0x0602CEEB RID: 184043 RVA: 0x00C9142A File Offset: 0x00C8F62A
		public EStepType StepType { get; }

		// Token: 0x17005AC7 RID: 23239
		// (get) Token: 0x0602CEEC RID: 184044 RVA: 0x00C91432 File Offset: 0x00C8F632
		// (set) Token: 0x0602CEED RID: 184045 RVA: 0x00C9143A File Offset: 0x00C8F63A
		public Action<int, EStepType> CanInteractCallback { get; set; }

		// Token: 0x17005AC8 RID: 23240
		// (get) Token: 0x0602CEEE RID: 184046 RVA: 0x00C91443 File Offset: 0x00C8F643
		// (set) Token: 0x0602CEEF RID: 184047 RVA: 0x00C9144B File Offset: 0x00C8F64B
		public Action<int, int> ExecuteStep { get; set; }

		// Token: 0x0602CEF0 RID: 184048 RVA: 0x00C91454 File Offset: 0x00C8F654
		public GridEventCompDesc(int stepId, EStepType stepType = EStepType.Desc)
		{
			this.StepId = stepId;
			this.StepType = stepType;
		}

		// Token: 0x0602CEF1 RID: 184049 RVA: 0x00C9146C File Offset: 0x00C8F66C
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

		// Token: 0x0602CEF2 RID: 184050 RVA: 0x00C914DC File Offset: 0x00C8F6DC
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

		// Token: 0x0602CEF3 RID: 184051 RVA: 0x00C915A0 File Offset: 0x00C8F7A0
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

		// Token: 0x0602CEF4 RID: 184052 RVA: 0x00C915FC File Offset: 0x00C8F7FC
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

		// Token: 0x0602CEF5 RID: 184053 RVA: 0x00C91660 File Offset: 0x00C8F860
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

		// Token: 0x0602CEF6 RID: 184054 RVA: 0x00C916F0 File Offset: 0x00C8F8F0
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

		// Token: 0x0602CEF7 RID: 184055 RVA: 0x00C91759 File Offset: 0x00C8F959
		public void MaskClick()
		{
			this.ShowAllText();
		}

		// Token: 0x0602CEF8 RID: 184056 RVA: 0x00C91764 File Offset: 0x00C8F964
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

		// Token: 0x0602CEF9 RID: 184057 RVA: 0x00C917B1 File Offset: 0x00C8F9B1
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

		// Token: 0x0401812E RID: 98606
		private UUIEffectTextAnimation TextAnimDataComp;

		// Token: 0x0401812F RID: 98607
		private ULGUIPlayTweenComponent TextPlayTweenComp;

		// Token: 0x04018130 RID: 98608
		private FLGUIPlayTweenCompleteDynamicDelegate TextPlayTweenEndCb;

		// Token: 0x04018131 RID: 98609
		private FLGUIDelegateHandleWrapper TextPlayTweenEndCbWrapper;

		// Token: 0x04018132 RID: 98610
		private float TextSpeed;

		// Token: 0x04018133 RID: 98611
		private bool IsInPlay;
	}
}
