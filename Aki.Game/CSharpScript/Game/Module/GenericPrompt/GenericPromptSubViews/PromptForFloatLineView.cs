using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.GenericPrompt.GenericPromptSubViews
{
	// Token: 0x02004991 RID: 18833
	[NullableContext(2)]
	[Nullable(0)]
	public class PromptForFloatLineView : UiPanelBase
	{
		// Token: 0x0602F2DD RID: 193245 RVA: 0x00D26200 File Offset: 0x00D24400
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602F2DE RID: 193246 RVA: 0x00D26248 File Offset: 0x00D24448
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
			this.TextAnimDataComp = (base.GetText(0).GetOwner().GetComponentByClass(UUIEffectTextAnimation.StaticClass()) as UUIEffectTextAnimation);
			this.TextPlayTweenComp = (base.GetText(0).GetOwner().GetComponentByClass(ULGUIPlayTweenComponent.StaticClass()) as ULGUIPlayTweenComponent);
			UUIEffectTextAnimation textAnimDataComp = this.TextAnimDataComp;
			if (textAnimDataComp == null)
			{
				return;
			}
			textAnimDataComp.SetSelectorOffset(1f);
		}

		// Token: 0x0602F2DF RID: 193247 RVA: 0x00D262C8 File Offset: 0x00D244C8
		protected override void OnBeforeShow()
		{
			GenericPromptConfig instance = GenericPromptConfig.Instance;
			int typeId = this.ParamHub.TypeId;
			FColor? promptTypeMainTextColor = instance.GetPromptTypeMainTextColor(typeId);
			if (promptTypeMainTextColor != null)
			{
				this.SetMainTextColor(promptTypeMainTextColor.Value);
			}
			UUIEffectTextAnimation textAnimDataComp = this.TextAnimDataComp;
			if (textAnimDataComp != null)
			{
				textAnimDataComp.SetSelectorOffset(1f);
			}
			if (this.TextPlayTweenComp != null)
			{
				GenericPrompt? genericPrompt;
				GenericPromptTypes? genericPromptTypes;
				int? num = (typeId != 0) ? ((GenericPromptConfig.Instance.GetPromptInfo(typeId) != null) ? new int?(genericPrompt.GetValueOrDefault().Duration) : null) : ((GenericPromptConfig.Instance.GetPromptTypeInfo(typeId) != null) ? new int?(genericPromptTypes.GetValueOrDefault().Duration) : null);
				float num2 = 0.5f;
				int? num3 = num;
				float? num4 = num2 * ((num3 != null) ? new float?((float)num3.GetValueOrDefault()) : null);
				ULGUIPlayTween playTween = this.TextPlayTweenComp.GetPlayTween();
				if (playTween != null)
				{
					float duration = playTween.duration;
					float? num5 = num4;
					playTween.duration = ((duration > num5.GetValueOrDefault() & num5 != null) ? num4 : new float?(playTween.duration)).GetValueOrDefault();
				}
				ULGUIPlayTweenComponent textPlayTweenComp = this.TextPlayTweenComp;
				if (textPlayTweenComp == null)
				{
					return;
				}
				textPlayTweenComp.Play();
			}
		}

		// Token: 0x0602F2E0 RID: 193248 RVA: 0x00D26444 File Offset: 0x00D24644
		protected override UniTask OnShowAsyncImplementImplement()
		{
			PromptForFloatLineView.<OnShowAsyncImplementImplement>d__11 <OnShowAsyncImplementImplement>d__;
			<OnShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnShowAsyncImplementImplement>d__.<>4__this = this;
			<OnShowAsyncImplementImplement>d__.<>1__state = -1;
			<OnShowAsyncImplementImplement>d__.<>t__builder.Start<PromptForFloatLineView.<OnShowAsyncImplementImplement>d__11>(ref <OnShowAsyncImplementImplement>d__);
			return <OnShowAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x0602F2E1 RID: 193249 RVA: 0x00D26488 File Offset: 0x00D24688
		protected override UniTask OnBeforeHideAsync()
		{
			PromptForFloatLineView.<OnBeforeHideAsync>d__12 <OnBeforeHideAsync>d__;
			<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeHideAsync>d__.<>4__this = this;
			<OnBeforeHideAsync>d__.<>1__state = -1;
			<OnBeforeHideAsync>d__.<>t__builder.Start<PromptForFloatLineView.<OnBeforeHideAsync>d__12>(ref <OnBeforeHideAsync>d__);
			return <OnBeforeHideAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602F2E2 RID: 193250 RVA: 0x00D264CB File Offset: 0x00D246CB
		protected override void OnAfterHide()
		{
			THideDelegate hideCallback = this.HideCallback;
			if (hideCallback == null)
			{
				return;
			}
			hideCallback(this);
		}

		// Token: 0x0602F2E3 RID: 193251 RVA: 0x00D264E0 File Offset: 0x00D246E0
		private void SetMainTextColor(FColor color)
		{
			UUIEffectOutline uuieffectOutline = base.GetText(0).GetOwner().GetComponentByClass(UUIEffectOutline.StaticClass()) as UUIEffectOutline;
			if (uuieffectOutline != null)
			{
				uuieffectOutline.SetOutlineColor(color);
				return;
			}
			base.GetText(0).SetColor(color);
		}

		// Token: 0x0602F2E4 RID: 193252 RVA: 0x00D26528 File Offset: 0x00D24728
		[NullableContext(1)]
		private void SetMainTextUi(TableTextArgNew mainTextObj, [ParamCollection] IReadOnlyList<object> parameters)
		{
			UUIText text = base.GetText(0);
			int? promptId = this.ParamHub.PromptId;
			int num = 0;
			if (!(promptId.GetValueOrDefault() == num & promptId != null))
			{
				LguiUtil.Instance.SetLocalTextNew(text, mainTextObj.TextKey, parameters);
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(text, mainTextObj.TextKey, parameters);
		}

		// Token: 0x0602F2E5 RID: 193253 RVA: 0x00D26584 File Offset: 0x00D24784
		private void SetMainTextParam()
		{
			GenericPromptConfig instance = GenericPromptConfig.Instance;
			IPromptParamHub paramHub = this.ParamHub;
			IReadOnlyList<object> readOnlyList = paramHub.MainTextParams ?? Array.Empty<object>();
			TableTextArgNew tableTextArgNew = paramHub.MainTextObj;
			int valueOrDefault = paramHub.PromptId.GetValueOrDefault();
			if (valueOrDefault != 0)
			{
				if (tableTextArgNew == null)
				{
					tableTextArgNew = instance.GetPromptMainTextObj(valueOrDefault);
				}
			}
			else if (tableTextArgNew == null)
			{
				tableTextArgNew = instance.GetPromptTypeMainTextObj(paramHub.TypeId);
			}
			if (readOnlyList.Count == 0)
			{
				this.SetMainTextUi(tableTextArgNew, Array.Empty<object>());
			}
			if (tableTextArgNew == null && valueOrDefault == 0 && readOnlyList.Count > 0)
			{
				if (!string.IsNullOrEmpty(readOnlyList[0] as string))
				{
					base.GetText(0).SetText(readOnlyList[0] as string, true);
				}
				return;
			}
			this.SetMainTextUi(tableTextArgNew, readOnlyList);
		}

		// Token: 0x0602F2E6 RID: 193254 RVA: 0x00D26644 File Offset: 0x00D24844
		[NullableContext(1)]
		public void SetPromptHub(IPromptParamHub promptParamHub)
		{
			this.ParamHub = promptParamHub;
			GenericPromptConfig instance = GenericPromptConfig.Instance;
			this.TickTime = 0f;
			if (promptParamHub.Duration != null)
			{
				float? duration = promptParamHub.Duration;
				float num = 0f;
				if (duration.GetValueOrDefault() > num & duration != null)
				{
					this.Duration = TimeUtil.Instance.SetTimeMillisecond((double)promptParamHub.Duration.Value);
					goto IL_A9;
				}
			}
			GenericPromptTypes? genericPromptTypes;
			this.Duration = TimeUtil.Instance.SetTimeMillisecond((double)((instance.GetPromptTypeInfo(this.ParamHub.TypeId) != null) ? genericPromptTypes.GetValueOrDefault().Duration : 0));
			IL_A9:
			this.ApplyPromptText();
		}

		// Token: 0x0602F2E7 RID: 193255 RVA: 0x00D26700 File Offset: 0x00D24900
		private void ApplyPromptText()
		{
			this.SetMainTextParam();
			this.RootItem.SetAsLastHierarchy();
		}

		// Token: 0x0602F2E8 RID: 193256 RVA: 0x00D26713 File Offset: 0x00D24913
		public void SetHideCallback(THideDelegate callback)
		{
			this.HideCallback = callback;
		}

		// Token: 0x0602F2E9 RID: 193257 RVA: 0x00D2671C File Offset: 0x00D2491C
		public void ShowView()
		{
			if (!base.IsShowOrShowing)
			{
				this.SetActive(true);
				return;
			}
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (((levelSequencePlayer != null) ? levelSequencePlayer.GetCurrentSequence() : null) != null)
			{
				this.LevelSequencePlayer.ReplaySequenceByKey("Start".ToString());
				return;
			}
			this.LevelSequencePlayer.PlaySequencePurely("Start".ToString(), false, false, null, null, false);
		}

		// Token: 0x0602F2EA RID: 193258 RVA: 0x00D26785 File Offset: 0x00D24985
		public void HideView()
		{
			if (base.IsShowOrShowing)
			{
				this.SetActive(false);
			}
		}

		// Token: 0x0602F2EB RID: 193259 RVA: 0x00D26796 File Offset: 0x00D24996
		public void Tick(float delta)
		{
			if (this.Duration <= 0.0)
			{
				return;
			}
			this.TickTime += delta;
			if ((double)this.TickTime > this.Duration)
			{
				this.SetActive(false);
			}
		}

		// Token: 0x04019097 RID: 102551
		private UUIEffectTextAnimation TextAnimDataComp;

		// Token: 0x04019098 RID: 102552
		private ULGUIPlayTweenComponent TextPlayTweenComp;

		// Token: 0x04019099 RID: 102553
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401909A RID: 102554
		public IPromptParamHub ParamHub;

		// Token: 0x0401909B RID: 102555
		private double Duration;

		// Token: 0x0401909C RID: 102556
		private float TickTime;

		// Token: 0x0401909D RID: 102557
		private THideDelegate HideCallback;

		// Token: 0x0200A62A RID: 42538
		[NullableContext(0)]
		private class ECompDefine
		{
			// Token: 0x04033636 RID: 210486
			public const int MainTextItem = 0;
		}
	}
}
