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
	// Token: 0x02003A57 RID: 14935
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseLevelNamePanel : UiPanelBase
	{
		// Token: 0x06026630 RID: 157232 RVA: 0x00AC0C8C File Offset: 0x00ABEE8C
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

		// Token: 0x06026631 RID: 157233 RVA: 0x00AC0CD7 File Offset: 0x00ABEED7
		protected override void OnBeforeCreate()
		{
		}

		// Token: 0x06026632 RID: 157234 RVA: 0x00AC0CDC File Offset: 0x00ABEEDC
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

		// Token: 0x06026633 RID: 157235 RVA: 0x00AC0DEC File Offset: 0x00ABEFEC
		protected override UniTask OnBeforeStartAsync()
		{
			TrapDefenseLevelNamePanel.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TrapDefenseLevelNamePanel.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06026634 RID: 157236 RVA: 0x00AC0E2F File Offset: 0x00ABF02F
		protected override void OnStart()
		{
		}

		// Token: 0x06026635 RID: 157237 RVA: 0x00AC0E31 File Offset: 0x00ABF031
		protected override void OnBeforeShow()
		{
		}

		// Token: 0x06026636 RID: 157238 RVA: 0x00AC0E33 File Offset: 0x00ABF033
		protected override void OnBeforeDestroy()
		{
		}

		// Token: 0x06026637 RID: 157239 RVA: 0x00AC0E38 File Offset: 0x00ABF038
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

		// Token: 0x06026638 RID: 157240 RVA: 0x00AC0EA0 File Offset: 0x00ABF0A0
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

		// Token: 0x040150EF RID: 86255
		public TrapDefenseLevelData LevelData;

		// Token: 0x0200962A RID: 38442
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x0402EE24 RID: 192036
			public const int TextureBg = 0;

			// Token: 0x0402EE25 RID: 192037
			public const int TextureBgLight = 1;

			// Token: 0x0402EE26 RID: 192038
			public const int SpriteBgTitle = 2;

			// Token: 0x0402EE27 RID: 192039
			public const int ArtTextPosition = 3;

			// Token: 0x0402EE28 RID: 192040
			public const int TextTitle = 4;

			// Token: 0x0402EE29 RID: 192041
			public const int ArtTextPositionShadow = 5;

			// Token: 0x0402EE2A RID: 192042
			public const int TextureBgFlower = 6;
		}
	}
}
