using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.VisualNovel;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A6C RID: 23148
	[NullableContext(1)]
	[Nullable(0)]
	public sealed class SolarSchoolVisualNovelChoiceView : SolarSchoolHideHudViewBase
	{
		// Token: 0x1400000D RID: 13
		// (add) Token: 0x0603905B RID: 233563 RVA: 0x00FF8EFC File Offset: 0x00FF70FC
		// (remove) Token: 0x0603905C RID: 233564 RVA: 0x00FF8F34 File Offset: 0x00FF7134
		[Nullable(2)]
		[method: NullableContext(2)]
		[Nullable(2)]
		public event Action<int> ChoiceSelected;

		// Token: 0x0603905D RID: 233565 RVA: 0x00FF8F69 File Offset: 0x00FF7169
		public SolarSchoolVisualNovelChoiceView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603905E RID: 233566 RVA: 0x00FF8F80 File Offset: 0x00FF7180
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
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUILayoutBase));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIRenderableMask));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(7, new Action(this.OnReviewButtonClicked));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(8, new Action(this.OnMenuButtonClicked));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603905F RID: 233567 RVA: 0x00FF9154 File Offset: 0x00FF7354
		protected override UniTask OnBeforeStartAsync()
		{
			SolarSchoolVisualNovelChoiceView.<OnBeforeStartAsync>d__16 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<SolarSchoolVisualNovelChoiceView.<OnBeforeStartAsync>d__16>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06039060 RID: 233568 RVA: 0x00FF9197 File Offset: 0x00FF7397
		protected override void OnBeforeDestroy()
		{
			this.Context = null;
			this.ChoiceSelected = null;
			this.ChoiceLayout = null;
			this.CharacterSpineItem = null;
			this.CanSelect = null;
			this.PlaybackRate = 1f;
			this.IsPaused = false;
		}

		// Token: 0x06039061 RID: 233569 RVA: 0x00FF91CE File Offset: 0x00FF73CE
		public void SetPaused(bool paused)
		{
			this.IsPaused = paused;
			SolarSchoolCharacterSpineItem characterSpineItem = this.CharacterSpineItem;
			if (characterSpineItem == null)
			{
				return;
			}
			VisualNovelSpineCharacter character = characterSpineItem.Character;
			if (character == null)
			{
				return;
			}
			character.SetPaused(paused);
		}

		// Token: 0x06039062 RID: 233570 RVA: 0x00FF91F2 File Offset: 0x00FF73F2
		public void SetPlaybackRate(float playbackRate)
		{
			this.PlaybackRate = Math.Max(playbackRate, 0.01f);
			SolarSchoolCharacterSpineItem characterSpineItem = this.CharacterSpineItem;
			if (characterSpineItem == null)
			{
				return;
			}
			VisualNovelSpineCharacter character = characterSpineItem.Character;
			if (character == null)
			{
				return;
			}
			character.SetPlaybackRate(this.PlaybackRate);
		}

		// Token: 0x06039063 RID: 233571 RVA: 0x00FF9225 File Offset: 0x00FF7425
		private SolarSchoolVisualNovelChoiceItem CreateChoiceItem()
		{
			return new SolarSchoolVisualNovelChoiceItem
			{
				ChoiceSelected = new Action<int>(this.OnChoiceSelected),
				CanSelect = new Func<bool>(this.CanSelectChoice)
			};
		}

		// Token: 0x06039064 RID: 233572 RVA: 0x00FF9250 File Offset: 0x00FF7450
		private void SetRoleShadowTextures()
		{
			bool flag = SolarSchoolGamePlayModel.Instance.GetPlayerGender() == EPlayerGender.Male;
			this.SetRoleShadowLightTexture(flag ? "TexRoleShadowLight_Male" : "TexRoleShadowLight_Female");
			this.SetRoleShadowMaskTexture(flag ? "TexRoleShadowMask_Male" : "TexRoleShadowMask_Female");
		}

		// Token: 0x06039065 RID: 233573 RVA: 0x00FF9298 File Offset: 0x00FF7498
		private void SetRoleShadowLightTexture(string resourceId)
		{
			UUITexture texture = base.GetTexture(5);
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
			base.SetTextureShowUntilLoaded(resourcePath, texture, null);
		}

		// Token: 0x06039066 RID: 233574 RVA: 0x00FF92C4 File Offset: 0x00FF74C4
		private void SetRoleShadowMaskTexture(string resourceId)
		{
			UUIRenderableMask renderableMask = base.GetRenderableMask(6);
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
			base.SetRenderableMaskTextureByPath(resourcePath, renderableMask, null);
		}

		// Token: 0x06039067 RID: 233575 RVA: 0x00FF92EE File Offset: 0x00FF74EE
		private void OnChoiceSelected(int optionIndex)
		{
			if (!this.CanSelectChoice())
			{
				return;
			}
			Action<int> choiceSelected = this.ChoiceSelected;
			if (choiceSelected == null)
			{
				return;
			}
			choiceSelected(optionIndex);
		}

		// Token: 0x06039068 RID: 233576 RVA: 0x00FF930A File Offset: 0x00FF750A
		private bool CanSelectChoice()
		{
			if (!this.IsPaused)
			{
				Func<bool> canSelect = this.CanSelect;
				return canSelect != null && canSelect();
			}
			return false;
		}

		// Token: 0x06039069 RID: 233577 RVA: 0x00FF9327 File Offset: 0x00FF7527
		private void OnReviewButtonClicked()
		{
			if (this.Context == null || !this.CanSelectChoice())
			{
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.SolarSchoolVisualNovelReviewView, this.Context, null);
		}

		// Token: 0x0603906A RID: 233578 RVA: 0x00FF9350 File Offset: 0x00FF7550
		private void OnMenuButtonClicked()
		{
			if (this.Context == null || !this.CanSelectChoice())
			{
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.SolarSchoolSettingView, new SolarSchoolSettingViewParam
			{
				HideLimitTimeRewardButton = true,
				HideNormalRewardButton = true,
				HideGalleryButton = true
			}, null);
		}

		// Token: 0x0401E022 RID: 122914
		private const string MALE_ROLE_SHADOW_LIGHT_RESOURCE_ID = "TexRoleShadowLight_Male";

		// Token: 0x0401E023 RID: 122915
		private const string FEMALE_ROLE_SHADOW_LIGHT_RESOURCE_ID = "TexRoleShadowLight_Female";

		// Token: 0x0401E024 RID: 122916
		private const string MALE_ROLE_SHADOW_MASK_RESOURCE_ID = "TexRoleShadowMask_Male";

		// Token: 0x0401E025 RID: 122917
		private const string FEMALE_ROLE_SHADOW_MASK_RESOURCE_ID = "TexRoleShadowMask_Female";

		// Token: 0x0401E026 RID: 122918
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<SolarSchoolVisualNovelChoiceItem, VisualNovelChoiceOption> ChoiceLayout;

		// Token: 0x0401E027 RID: 122919
		[Nullable(2)]
		private SolarSchoolCharacterSpineItem CharacterSpineItem;

		// Token: 0x0401E028 RID: 122920
		[Nullable(2)]
		private VisualNovelContext Context;

		// Token: 0x0401E029 RID: 122921
		[Nullable(2)]
		private Func<bool> CanSelect;

		// Token: 0x0401E02A RID: 122922
		private float PlaybackRate = 1f;

		// Token: 0x0401E02B RID: 122923
		private bool IsPaused;

		// Token: 0x0200B661 RID: 46689
		[NullableContext(0)]
		private static class EComponents
		{
			// Token: 0x040386BB RID: 231099
			public const int CharacterSpineItem = 0;

			// Token: 0x040386BC RID: 231100
			public const int QuestionText = 1;

			// Token: 0x040386BD RID: 231101
			public const int ChoiceLayout = 2;

			// Token: 0x040386BE RID: 231102
			public const int ChoiceTemplateItem = 3;

			// Token: 0x040386BF RID: 231103
			public const int RoleShadowTexture = 4;

			// Token: 0x040386C0 RID: 231104
			public const int TexRoleShadowLight = 5;

			// Token: 0x040386C1 RID: 231105
			public const int PnlBg = 6;

			// Token: 0x040386C2 RID: 231106
			public const int ReviewButton = 7;

			// Token: 0x040386C3 RID: 231107
			public const int MenuButton = 8;

			// Token: 0x040386C4 RID: 231108
			public const int PnlSpineM = 9;

			// Token: 0x040386C5 RID: 231109
			public const int PnlSpineF = 10;
		}
	}
}
