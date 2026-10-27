using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004AAF RID: 19119
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseLevelNamePanel : UiPanelBase
	{
		// Token: 0x060318A0 RID: 202912 RVA: 0x00B7CCD8 File Offset: 0x00B7AED8
		public UniTask Init(UUIItem item)
		{
			TrapDefenseLevelNamePanel.<Init>d__2 <Init>d__;
			<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<Init>d__.<>4__this = this;
			<Init>d__.item = item;
			<Init>d__.<>1__state = -1;
			<Init>d__.<>t__builder.Start<TrapDefenseLevelNamePanel.<Init>d__2>(ref <Init>d__);
			return <Init>d__.<>t__builder.Task;
		}

		// Token: 0x060318A1 RID: 202913 RVA: 0x00B7CD23 File Offset: 0x00B7AF23
		protected override void OnBeforeCreate()
		{
		}

		// Token: 0x060318A2 RID: 202914 RVA: 0x00B7CD28 File Offset: 0x00B7AF28
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIArtText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIArtText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUITexture));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060318A3 RID: 202915 RVA: 0x00B7CE38 File Offset: 0x00B7B038
		protected override UniTask OnBeforeStartAsync()
		{
			TrapDefenseLevelNamePanel.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TrapDefenseLevelNamePanel.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060318A4 RID: 202916 RVA: 0x00B7CE7B File Offset: 0x00B7B07B
		protected override void OnStart()
		{
		}

		// Token: 0x060318A5 RID: 202917 RVA: 0x00B7CE7D File Offset: 0x00B7B07D
		protected override void OnBeforeShow()
		{
		}

		// Token: 0x060318A6 RID: 202918 RVA: 0x00B7CE7F File Offset: 0x00B7B07F
		protected override void OnBeforeDestroy()
		{
		}

		// Token: 0x060318A7 RID: 202919 RVA: 0x00B7CE84 File Offset: 0x00B7B084
		public void UpdateData(TrapDefenseLevelData data)
		{
			this.LevelData = data;
			string positionFormat = data.GetPositionFormat(2);
			UUIArtText artText = base.GetArtText(3);
			if (artText != null)
			{
				artText.SetText(positionFormat);
			}
			UUIArtText artText2 = base.GetArtText(5);
			if (artText2 != null)
			{
				artText2.SetText(positionFormat);
			}
			UUIText text = base.GetText(4);
			if (text != null)
			{
				text.ShowTextNew(data.Config.Name);
			}
			this.UpdateBg();
		}

		// Token: 0x060318A8 RID: 202920 RVA: 0x00B7CEEC File Offset: 0x00B7B0EC
		private void UpdateBg()
		{
			ITrapDefenseDifficultyLevelInfo difficultyUiInfo = this.LevelData.GetDifficultyUiInfo();
			UUITexture texture = base.GetTexture(0);
			UUITexture texture2 = base.GetTexture(1);
			UUISprite sprite = base.GetSprite(2);
			UUIItem artText = base.GetArtText(5);
			UUITexture texture3 = base.GetTexture(6);
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(difficultyUiInfo.BgKey);
			string resourcePath2 = UiResourceConfig.Instance.GetResourcePath(difficultyUiInfo.BgLightKey);
			string resourcePath3 = UiResourceConfig.Instance.GetResourcePath(difficultyUiInfo.BgTitleKey);
			artText.SetColor(FColor.FromHex(difficultyUiInfo.ArtTextShadowColor));
			texture3.SetColor(FColor.FromHex(difficultyUiInfo.BgFlowerColor));
			base.SetTextureByPath(resourcePath, texture, null, null);
			base.SetTextureByPath(resourcePath2, texture2, null, null);
			this.SetSpriteByPath(resourcePath3, sprite, false, null, null);
		}

		// Token: 0x0401A79D RID: 108445
		public TrapDefenseLevelData LevelData;

		// Token: 0x0200AC0A RID: 44042
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x04034473 RID: 214131
			public const int TextureBg = 0;

			// Token: 0x04034474 RID: 214132
			public const int TextureBgLight = 1;

			// Token: 0x04034475 RID: 214133
			public const int SpriteBgTitle = 2;

			// Token: 0x04034476 RID: 214134
			public const int ArtTextPosition = 3;

			// Token: 0x04034477 RID: 214135
			public const int TextTitle = 4;

			// Token: 0x04034478 RID: 214136
			public const int ArtTextPositionShadow = 5;

			// Token: 0x04034479 RID: 214137
			public const int TextureBgFlower = 6;
		}
	}
}
