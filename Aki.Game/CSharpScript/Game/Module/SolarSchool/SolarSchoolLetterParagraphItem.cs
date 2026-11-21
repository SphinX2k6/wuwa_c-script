using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Plot.PlotView.PlotComponent;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005916 RID: 22806
	[NullableContext(2)]
	[Nullable(0)]
	public class SolarSchoolLetterParagraphItem : GridProxyAbstract<SolarSchoolLetterParagraphData>
	{
		// Token: 0x0603838E RID: 230286 RVA: 0x00FB7DCA File Offset: 0x00FB5FCA
		public SolarSchoolLetterParagraphItem(Action onFinished)
		{
			this.OnFinishedCallback = onFinished;
		}

		// Token: 0x0603838F RID: 230287 RVA: 0x00FB7DE8 File Offset: 0x00FB5FE8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 3;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIEffectTextAnimation));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(ULGUIPlayTweenComponent));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x06038390 RID: 230288 RVA: 0x00FB7E74 File Offset: 0x00FB6074
		protected override void OnStart()
		{
			UUIText text = base.GetText(0);
			UUIEffectTextAnimation uieffectTextAnimation = base.GetUIEffectTextAnimation(1);
			ULGUIPlayTweenComponent tween = base.GetTween(2);
			this.WriterComp = new PlotTextWriterComponent();
			this.WriterComp.Init(new PlotTextWriterComponentContext
			{
				TextComponent = text,
				TextAnimComp = uieffectTextAnimation,
				TweenComp = tween,
				OnAnimCompleteDelegate = new Action(this.FireFinished)
			});
		}

		// Token: 0x06038391 RID: 230289 RVA: 0x00FB7EDC File Offset: 0x00FB60DC
		public override void Refresh(SolarSchoolLetterParagraphData data, bool isSelected, int gridIndex)
		{
			if (this.BoundPageNumber == data.PageNumber && this.BoundParagraphIndex == data.ParagraphIndex)
			{
				return;
			}
			this.BoundPageNumber = data.PageNumber;
			this.BoundParagraphIndex = data.ParagraphIndex;
			this.HasFiredFinished = false;
			UUIText text = base.GetText(0);
			text.SetText(SolarSchoolUtils.GetTextWithPlaceholder(data.TextId), true);
			int activityId = SolarSchoolGamePlayModel.Instance.ActivityId;
			int paramInt = SolarSchoolConfig.Instance.GetParamInt(activityId, "TextAnimSpeed", 0);
			float num = (paramInt > 0) ? ((float)text.GetDisplayCharLength() / (float)paramInt) : 0f;
			if (num <= 0f)
			{
				PlotTextWriterComponent writerComp = this.WriterComp;
				if (writerComp != null)
				{
					writerComp.JumpToEnd();
				}
				this.FireFinished();
				return;
			}
			PlotTextWriterComponent writerComp2 = this.WriterComp;
			if (writerComp2 != null)
			{
				writerComp2.SetPlayDuration(num);
			}
			PlotTextWriterComponent writerComp3 = this.WriterComp;
			if (writerComp3 == null)
			{
				return;
			}
			UUIEffectTextAnimation textAnimComponent = writerComp3.GetTextAnimComponent();
			if (textAnimComponent == null)
			{
				return;
			}
			textAnimComponent.SetSelectorOffset(1f);
		}

		// Token: 0x06038392 RID: 230290 RVA: 0x00FB7FC3 File Offset: 0x00FB61C3
		public void Play()
		{
			if (this.HasFiredFinished || this.WriterComp == null || this.WriterComp.GetIsPlaying())
			{
				return;
			}
			this.WriterComp.Play();
		}

		// Token: 0x06038393 RID: 230291 RVA: 0x00FB7FEE File Offset: 0x00FB61EE
		public void SkipToEnd()
		{
			if (this.HasFiredFinished)
			{
				return;
			}
			PlotTextWriterComponent writerComp = this.WriterComp;
			if (writerComp != null)
			{
				writerComp.JumpToEnd();
			}
			this.FireFinished();
		}

		// Token: 0x06038394 RID: 230292 RVA: 0x00FB8010 File Offset: 0x00FB6210
		[NullableContext(1)]
		public override object GetKey(SolarSchoolLetterParagraphData data, int displayIndex)
		{
			return displayIndex;
		}

		// Token: 0x06038395 RID: 230293 RVA: 0x00FB8018 File Offset: 0x00FB6218
		protected override void OnBeforeDestroy()
		{
			this.ClearWriter();
		}

		// Token: 0x06038396 RID: 230294 RVA: 0x00FB8020 File Offset: 0x00FB6220
		private void FireFinished()
		{
			if (this.HasFiredFinished)
			{
				return;
			}
			this.HasFiredFinished = true;
			Action onFinishedCallback = this.OnFinishedCallback;
			if (onFinishedCallback == null)
			{
				return;
			}
			onFinishedCallback();
		}

		// Token: 0x06038397 RID: 230295 RVA: 0x00FB8042 File Offset: 0x00FB6242
		private void ClearWriter()
		{
			PlotTextWriterComponent writerComp = this.WriterComp;
			if (writerComp != null)
			{
				writerComp.Clear();
			}
			this.WriterComp = null;
		}

		// Token: 0x0401D987 RID: 121223
		private PlotTextWriterComponent WriterComp;

		// Token: 0x0401D988 RID: 121224
		private readonly Action OnFinishedCallback;

		// Token: 0x0401D989 RID: 121225
		private int BoundPageNumber = -1;

		// Token: 0x0401D98A RID: 121226
		private int BoundParagraphIndex = -1;

		// Token: 0x0401D98B RID: 121227
		private bool HasFiredFinished;

		// Token: 0x0200B4D8 RID: 46296
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04037EA4 RID: 229028
			public const int TxtLetterContent = 0;

			// Token: 0x04037EA5 RID: 229029
			public const int EffectTextAnimation = 1;

			// Token: 0x04037EA6 RID: 229030
			public const int TweenText = 2;
		}
	}
}
