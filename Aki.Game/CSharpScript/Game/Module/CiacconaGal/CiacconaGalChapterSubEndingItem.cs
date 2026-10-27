using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02005BEB RID: 23531
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class CiacconaGalChapterSubEndingItem : GridProxyAbstract<CiacconaGalSubEndingData>
	{
		// Token: 0x0603B79E RID: 243614 RVA: 0x00E2EEF0 File Offset: 0x00E2D0F0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 6;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISprite));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0603B79F RID: 243615 RVA: 0x00E2EFE0 File Offset: 0x00E2D1E0
		protected override UniTask OnBeforeStartAsync()
		{
			CiacconaGalChapterSubEndingItem.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<CiacconaGalChapterSubEndingItem.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603B7A0 RID: 243616 RVA: 0x00E2F024 File Offset: 0x00E2D224
		[NullableContext(1)]
		public override void Refresh(CiacconaGalSubEndingData data, bool isSelected, int gridIndex)
		{
			this.Data = data;
			base.GetSprite(1).SetUIActive(this.Data.IsFinished);
			base.GetSprite(5).SetUIActive(this.Data.IsRewarded);
			this.BtnReward.SetActive(this.Data.IsFinished && !this.Data.IsRewarded);
			string resourcePath = UiResourceConfig.Instance.GetResourcePath("T_PlotReasoningLockBg");
			string resourcePath2 = UiResourceConfig.Instance.GetResourcePath("SP_PlotReasoningFinishMain");
			if (!this.Data.IsFinished)
			{
				resourcePath = UiResourceConfig.Instance.GetResourcePath("T_PlotReasoningLockBg");
			}
			else if (this.Data.Type == ECiacconaGalSubEndingType.Main)
			{
				resourcePath = UiResourceConfig.Instance.GetResourcePath("T_PlotReasoningFinishMainBg");
				resourcePath2 = UiResourceConfig.Instance.GetResourcePath("SP_PlotReasoningFinishMain");
			}
			else if (this.Data.Type == ECiacconaGalSubEndingType.Side)
			{
				resourcePath = UiResourceConfig.Instance.GetResourcePath("T_PlotReasoningFinishBranchBg");
				resourcePath2 = UiResourceConfig.Instance.GetResourcePath("SP_PlotReasoningFinishBranch");
			}
			base.SetTextureByPath(resourcePath, base.GetTexture(0), null, null);
			this.SetSpriteByPath(resourcePath2, base.GetSprite(1), false, null, null);
			UUIText text = base.GetText(2);
			if (text != null)
			{
				text.SetUIActive(this.Data.IsFinished);
			}
			UUIText text2 = base.GetText(3);
			if (text2 != null)
			{
				text2.SetUIActive(this.Data.IsFinished);
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), this.Data.Title, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), this.Data.Desc, Array.Empty<object>());
		}

		// Token: 0x0603B7A1 RID: 243617 RVA: 0x00E2F1DC File Offset: 0x00E2D3DC
		private void OnBtnRewardClick()
		{
			CiacconaGalChapterData chapterDataBySubEndingId = CiacconaGalModel.Instance.GetChapterDataBySubEndingId(this.Data.Id);
			if (chapterDataBySubEndingId != null)
			{
				int id = CiacconaGalModel.Instance.ActivityData.Id;
				CiacconaGalController.Instance.RequestGetSubEndingReward(id, chapterDataBySubEndingId.Id, this.Data.Id);
			}
		}

		// Token: 0x0401EFC6 RID: 126918
		private CiacconaGalSubEndingData Data;

		// Token: 0x0401EFC7 RID: 126919
		private ButtonSpriteItem BtnReward;

		// Token: 0x0200BDCF RID: 48591
		[NullableContext(0)]
		private class ESubEndingItemComponentDefine
		{
			// Token: 0x040393B7 RID: 234423
			public const int TextureBg = 0;

			// Token: 0x040393B8 RID: 234424
			public const int SpriteIcon = 1;

			// Token: 0x040393B9 RID: 234425
			public const int TextTitle = 2;

			// Token: 0x040393BA RID: 234426
			public const int TextDesc = 3;

			// Token: 0x040393BB RID: 234427
			public const int ItemBtnReward = 4;

			// Token: 0x040393BC RID: 234428
			public const int SpriteFinished = 5;
		}
	}
}
