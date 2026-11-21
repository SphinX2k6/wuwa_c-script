using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x0200590E RID: 22798
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSchoolExamView : SolarSchoolHideHudViewBase
	{
		// Token: 0x0603834C RID: 230220 RVA: 0x00FB6DA9 File Offset: 0x00FB4FA9
		public SolarSchoolExamView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603834D RID: 230221 RVA: 0x00FB6DBC File Offset: 0x00FB4FBC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 10;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIRenderableMask));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603834E RID: 230222 RVA: 0x00FB6F30 File Offset: 0x00FB5130
		public void ShowEvent(SolarSchoolExamEvent evt, IReadOnlyList<int> choiceIds)
		{
			this.ChoiceInteractable = true;
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), evt.Desc, Array.Empty<object>());
			base.TrySetTextureByPath(evt.Image, base.GetTexture(3), null, null);
			this.OptionLayout.RefreshByData(choiceIds, null, true);
		}

		// Token: 0x0603834F RID: 230223 RVA: 0x00FB6F90 File Offset: 0x00FB5190
		public void ShowResult(bool success)
		{
			SolarSchoolExamView.<>c__DisplayClass13_0 CS$<>8__locals1 = new SolarSchoolExamView.<>c__DisplayClass13_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.success = success;
			int paramInt = SolarSchoolConfig.Instance.GetParamInt(SolarSchoolGamePlayModel.Instance.GetActivityId(), "ExamResultHoldDuration", 0);
			this.ClearResultTimer();
			base.RunAsyncTask(new UiAsyncTask("SolarSchoolExamResultSpine", delegate()
			{
				SolarSchoolExamView.<>c__DisplayClass13_0.<<ShowResult>b__0>d <<ShowResult>b__0>d;
				<<ShowResult>b__0>d.<>t__builder = AsyncUniTaskMethodBuilder.Create();
				<<ShowResult>b__0>d.<>4__this = CS$<>8__locals1;
				<<ShowResult>b__0>d.<>1__state = -1;
				<<ShowResult>b__0>d.<>t__builder.Start<SolarSchoolExamView.<>c__DisplayClass13_0.<<ShowResult>b__0>d>(ref <<ShowResult>b__0>d);
				return <<ShowResult>b__0>d.<>t__builder.Task;
			}, null)).Forget();
			this.ResultTimer = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
			{
				CS$<>8__locals1.<>4__this.ResultTimer = null;
				ISolarSchoolExamViewHandler handler = CS$<>8__locals1.<>4__this.Handler;
				if (handler == null)
				{
					return;
				}
				handler.OnResultConfirmed();
			}, (float)paramInt, null, null, true, 1f);
		}

		// Token: 0x06038350 RID: 230224 RVA: 0x00FB701A File Offset: 0x00FB521A
		private SolarSchoolExamOptionItem CreateOptionItem()
		{
			return new SolarSchoolExamOptionItem
			{
				OnClickChoiceBack = new Action<int, int>(this.OnChoiceItemClicked),
				CanSelectFunc = (() => this.ChoiceInteractable)
			};
		}

		// Token: 0x06038351 RID: 230225 RVA: 0x00FB7048 File Offset: 0x00FB5248
		private void OnChoiceItemClicked(int gridIndex, int choiceId)
		{
			this.ChoiceInteractable = false;
			GenericLayout<SolarSchoolExamOptionItem, int> optionLayout = this.OptionLayout;
			if (optionLayout != null)
			{
				optionLayout.SelectGridProxy(gridIndex, false);
			}
			GenericLayout<SolarSchoolExamOptionItem, int> optionLayout2 = this.OptionLayout;
			if (optionLayout2 != null)
			{
				SolarSchoolExamOptionItem layoutItemByKey = optionLayout2.GetLayoutItemByKey(choiceId);
				if (layoutItemByKey != null)
				{
					layoutItemByKey.ShowCorrectness();
				}
			}
			ISolarSchoolExamViewHandler handler = this.Handler;
			if (handler == null)
			{
				return;
			}
			handler.OnChoiceSelected(choiceId);
		}

		// Token: 0x06038352 RID: 230226 RVA: 0x00FB70A4 File Offset: 0x00FB52A4
		private void SetRoleShadowTextures()
		{
			bool flag = SolarSchoolGamePlayModel.Instance.GetPlayerGender() == EPlayerGender.Male;
			this.SetRoleShadowLightTexture(flag ? "TexRoleShadowLight_Male" : "TexRoleShadowLight_Female");
			this.SetRoleShadowMaskTexture(flag ? "TexRoleShadowMask_Male" : "TexRoleShadowMask_Female");
		}

		// Token: 0x06038353 RID: 230227 RVA: 0x00FB70EC File Offset: 0x00FB52EC
		private void SetRoleShadowLightTexture(string resourceId)
		{
			UUITexture texture = base.GetTexture(7);
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
			base.SetTextureShowUntilLoaded(resourcePath, texture, null);
		}

		// Token: 0x06038354 RID: 230228 RVA: 0x00FB7118 File Offset: 0x00FB5318
		private void SetRoleShadowMaskTexture(string resourceId)
		{
			UUIRenderableMask renderableMask = base.GetRenderableMask(8);
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
			base.SetRenderableMaskTextureByPath(resourcePath, renderableMask, null);
		}

		// Token: 0x06038355 RID: 230229 RVA: 0x00FB7142 File Offset: 0x00FB5342
		private void ClearResultTimer()
		{
			if (this.ResultTimer == null)
			{
				return;
			}
			this.ResultTimer.Remove();
			this.ResultTimer = null;
		}

		// Token: 0x06038356 RID: 230230 RVA: 0x00FB7160 File Offset: 0x00FB5360
		protected override UniTask OnBeforeStartAsync()
		{
			SolarSchoolExamView.<OnBeforeStartAsync>d__20 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SolarSchoolExamView.<OnBeforeStartAsync>d__20>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038357 RID: 230231 RVA: 0x00FB71A4 File Offset: 0x00FB53A4
		protected override void OnStart()
		{
			this.OptionLayout = new GenericLayout<SolarSchoolExamOptionItem, int>(base.GetVerticalLayout(4), new Func<SolarSchoolExamOptionItem>(this.CreateOptionItem), base.GetItem(5).GetOwner() as AUIBaseActor, false, true);
			this.SetRoleShadowTextures();
			this.Handler = (this.OpenParam as ISolarSchoolExamViewHandler);
			if (this.Handler == null)
			{
				return;
			}
			this.Handler.OnViewReady(this);
		}

		// Token: 0x06038358 RID: 230232 RVA: 0x00FB7210 File Offset: 0x00FB5410
		private UniTask ShowSelfSpineAsync(ESolarSchoolSpineScene scene)
		{
			SolarSchoolExamView.<ShowSelfSpineAsync>d__22 <ShowSelfSpineAsync>d__;
			<ShowSelfSpineAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ShowSelfSpineAsync>d__.<>4__this = this;
			<ShowSelfSpineAsync>d__.scene = scene;
			<ShowSelfSpineAsync>d__.<>1__state = -1;
			<ShowSelfSpineAsync>d__.<>t__builder.Start<SolarSchoolExamView.<ShowSelfSpineAsync>d__22>(ref <ShowSelfSpineAsync>d__);
			return <ShowSelfSpineAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038359 RID: 230233 RVA: 0x00FB725B File Offset: 0x00FB545B
		protected override void OnBeforeDestroy()
		{
			this.ClearResultTimer();
			this.SpineItem = null;
			ISolarSchoolExamViewHandler handler = this.Handler;
			if (handler != null)
			{
				handler.OnViewClosed();
			}
			this.Handler = null;
		}

		// Token: 0x0401D971 RID: 121201
		private const string MaleRoleShadowLightResourceId = "TexRoleShadowLight_Male";

		// Token: 0x0401D972 RID: 121202
		private const string FemaleRoleShadowLightResourceId = "TexRoleShadowLight_Female";

		// Token: 0x0401D973 RID: 121203
		private const string MaleRoleShadowMaskResourceId = "TexRoleShadowMask_Male";

		// Token: 0x0401D974 RID: 121204
		private const string FemaleRoleShadowMaskResourceId = "TexRoleShadowMask_Female";

		// Token: 0x0401D975 RID: 121205
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private GenericLayout<SolarSchoolExamOptionItem, int> OptionLayout;

		// Token: 0x0401D976 RID: 121206
		[Nullable(2)]
		private SolarSchoolCharacterSpineItem SpineItem;

		// Token: 0x0401D977 RID: 121207
		[Nullable(2)]
		private ISolarSchoolExamViewHandler Handler;

		// Token: 0x0401D978 RID: 121208
		private bool ChoiceInteractable = true;

		// Token: 0x0401D979 RID: 121209
		[Nullable(2)]
		private TimerHandle ResultTimer;

		// Token: 0x0200B4D0 RID: 46288
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04037E7F RID: 228991
			public const int SpineItem = 0;

			// Token: 0x04037E80 RID: 228992
			public const int TxtQuestion = 1;

			// Token: 0x04037E81 RID: 228993
			public const int PnlPic = 2;

			// Token: 0x04037E82 RID: 228994
			public const int TexPic = 3;

			// Token: 0x04037E83 RID: 228995
			public const int OptionLayout = 4;

			// Token: 0x04037E84 RID: 228996
			public const int OptionItem = 5;

			// Token: 0x04037E85 RID: 228997
			public const int TexRoleShadow = 6;

			// Token: 0x04037E86 RID: 228998
			public const int TexRoleShadowLight = 7;

			// Token: 0x04037E87 RID: 228999
			public const int PnlBg = 8;

			// Token: 0x04037E88 RID: 229000
			public const int PnlSpineM = 9;

			// Token: 0x04037E89 RID: 229001
			public const int PnlSpineF = 10;
		}
	}
}
