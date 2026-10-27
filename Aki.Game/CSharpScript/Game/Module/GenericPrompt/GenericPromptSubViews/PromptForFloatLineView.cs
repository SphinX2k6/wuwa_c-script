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
	// Token: 0x020059B8 RID: 22968
	[NullableContext(2)]
	[Nullable(0)]
	public class PromptForFloatLineView : UiPanelBase
	{
		// Token: 0x0603A3B6 RID: 238518 RVA: 0x00DD6D28 File Offset: 0x00DD4F28
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

		// Token: 0x0603A3B7 RID: 238519 RVA: 0x00DD6D70 File Offset: 0x00DD4F70
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

		// Token: 0x0603A3B8 RID: 238520 RVA: 0x00DD6DF0 File Offset: 0x00DD4FF0
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

		// Token: 0x0603A3B9 RID: 238521 RVA: 0x00DD6F6C File Offset: 0x00DD516C
		protected override UniTask OnShowAsyncImplementImplement()
		{
			PromptForFloatLineView.<OnShowAsyncImplementImplement>d__11 <OnShowAsyncImplementImplement>d__;
			<OnShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnShowAsyncImplementImplement>d__.<>4__this = this;
			<OnShowAsyncImplementImplement>d__.<>1__state = -1;
			<OnShowAsyncImplementImplement>d__.<>t__builder.Start<PromptForFloatLineView.<OnShowAsyncImplementImplement>d__11>(ref <OnShowAsyncImplementImplement>d__);
			return <OnShowAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x0603A3BA RID: 238522 RVA: 0x00DD6FB0 File Offset: 0x00DD51B0
		protected override UniTask OnBeforeHideAsync()
		{
			PromptForFloatLineView.<OnBeforeHideAsync>d__12 <OnBeforeHideAsync>d__;
			<OnBeforeHideAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeHideAsync>d__.<>4__this = this;
			<OnBeforeHideAsync>d__.<>1__state = -1;
			<OnBeforeHideAsync>d__.<>t__builder.Start<PromptForFloatLineView.<OnBeforeHideAsync>d__12>(ref <OnBeforeHideAsync>d__);
			return <OnBeforeHideAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603A3BB RID: 238523 RVA: 0x00DD6FF3 File Offset: 0x00DD51F3
		protected override void OnAfterHide()
		{
			THideDelegate hideCallback = this.HideCallback;
			if (hideCallback == null)
			{
				return;
			}
			hideCallback(this);
		}

		// Token: 0x0603A3BC RID: 238524 RVA: 0x00DD7008 File Offset: 0x00DD5208
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

		// Token: 0x0603A3BD RID: 238525 RVA: 0x00DD7050 File Offset: 0x00DD5250
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

		// Token: 0x0603A3BE RID: 238526 RVA: 0x00DD70AC File Offset: 0x00DD52AC
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

		// Token: 0x0603A3BF RID: 238527 RVA: 0x00DD716C File Offset: 0x00DD536C
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

		// Token: 0x0603A3C0 RID: 238528 RVA: 0x00DD7228 File Offset: 0x00DD5428
		private void ApplyPromptText()
		{
			this.SetMainTextParam();
			this.RootItem.SetAsLastHierarchy();
		}

		// Token: 0x0603A3C1 RID: 238529 RVA: 0x00DD723B File Offset: 0x00DD543B
		public void SetHideCallback(THideDelegate callback)
		{
			this.HideCallback = callback;
		}

		// Token: 0x0603A3C2 RID: 238530 RVA: 0x00DD7244 File Offset: 0x00DD5444
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

		// Token: 0x0603A3C3 RID: 238531 RVA: 0x00DD72AD File Offset: 0x00DD54AD
		public void HideView()
		{
			if (base.IsShowOrShowing)
			{
				this.SetActive(false);
			}
		}

		// Token: 0x0603A3C4 RID: 238532 RVA: 0x00DD72BE File Offset: 0x00DD54BE
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

		// Token: 0x0401E5F8 RID: 124408
		private UUIEffectTextAnimation TextAnimDataComp;

		// Token: 0x0401E5F9 RID: 124409
		private ULGUIPlayTweenComponent TextPlayTweenComp;

		// Token: 0x0401E5FA RID: 124410
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0401E5FB RID: 124411
		public IPromptParamHub ParamHub;

		// Token: 0x0401E5FC RID: 124412
		private double Duration;

		// Token: 0x0401E5FD RID: 124413
		private float TickTime;

		// Token: 0x0401E5FE RID: 124414
		private THideDelegate HideCallback;

		// Token: 0x0200BC1F RID: 48159
		[NullableContext(0)]
		private class ECompDefine
		{
			// Token: 0x04038C67 RID: 232551
			public const int MainTextItem = 0;
		}
	}
}
