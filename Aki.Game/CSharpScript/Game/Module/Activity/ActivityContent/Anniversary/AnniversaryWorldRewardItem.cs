using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Anniversary
{
	// Token: 0x02005878 RID: 22648
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class AnniversaryWorldRewardItem : GridProxyAbstract<AnniversaryWorldRewardItemData>
	{
		// Token: 0x06037D23 RID: 228643 RVA: 0x00F9C9E8 File Offset: 0x00F9ABE8
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(1, typeof(UUITexture)),
				new ValueTuple<int, Type>(2, typeof(UUITexture)),
				new ValueTuple<int, Type>(3, typeof(UUITexture)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIText)),
				new ValueTuple<int, Type>(6, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(0, new Action(this.OnClick))
			};
		}

		// Token: 0x06037D24 RID: 228644 RVA: 0x00F9CABD File Offset: 0x00F9ACBD
		public void SetClickCallback(Action<int> callback)
		{
			this.ClickCallback = callback;
		}

		// Token: 0x06037D25 RID: 228645 RVA: 0x00F9CAC8 File Offset: 0x00F9ACC8
		public override void Refresh(AnniversaryWorldRewardItemData data, bool isSelected, int gridIndex)
		{
			if (data == null)
			{
				return;
			}
			this.Data = data;
			EAnniversaryProgressRewardState valueOrDefault = this.Data.State.GetValueOrDefault();
			bool flag = valueOrDefault == EAnniversaryProgressRewardState.Rewarded;
			UUITexture texture = base.GetTexture(3);
			if (texture != null)
			{
				texture.SetUIActive(flag);
			}
			UUITexture texture2 = base.GetTexture(3);
			if (texture2 != null)
			{
				bool bUseChangeColor = !flag;
				FColor? fcolor = null;
				texture2.SetChangeColor(bUseChangeColor, fcolor);
			}
			UUIItem item = base.GetItem(4);
			if (item != null)
			{
				item.SetUIActive(flag);
			}
			UUIItem item2 = base.GetItem(6);
			if (item2 != null)
			{
				item2.SetUIActive(valueOrDefault == EAnniversaryProgressRewardState.CanReceive);
			}
			this.SetBgTexture(valueOrDefault);
			WorldProgressCurve? worldProgressCurveById = AnniversaryActivityConfig.Instance.GetWorldProgressCurveById(this.Data.CfgId);
			if (worldProgressCurveById == null)
			{
				return;
			}
			UUIText text = base.GetText(5);
			if (text == null)
			{
				return;
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
			defaultInterpolatedStringHandler.AppendFormatted<int>(worldProgressCurveById.Value.Percent / 100);
			defaultInterpolatedStringHandler.AppendLiteral("%");
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}

		// Token: 0x06037D26 RID: 228646 RVA: 0x00F9CBC0 File Offset: 0x00F9ADC0
		private void SetBgTexture(EAnniversaryProgressRewardState state)
		{
			string text = null;
			switch (state)
			{
			case EAnniversaryProgressRewardState.Lock:
				text = UiResourceConfig.Instance.GetResourcePath("T_AnniversaryCelebrationRewardBgNor");
				break;
			case EAnniversaryProgressRewardState.CanReceive:
				text = UiResourceConfig.Instance.GetResourcePath("T_AnniversaryCelebrationRewardGetTips");
				break;
			case EAnniversaryProgressRewardState.Rewarded:
				text = UiResourceConfig.Instance.GetResourcePath("T_AnniversaaryCelebrationRewardBgFinished");
				break;
			}
			if (!string.IsNullOrEmpty(text))
			{
				base.TrySetTextureByPath(text, base.GetTexture(1), null, null);
			}
		}

		// Token: 0x06037D27 RID: 228647 RVA: 0x00F9CC37 File Offset: 0x00F9AE37
		private void OnClick()
		{
			if (this.Data != null)
			{
				Action<int> clickCallback = this.ClickCallback;
				if (clickCallback == null)
				{
					return;
				}
				clickCallback(this.Data.CfgId);
			}
		}

		// Token: 0x0401D759 RID: 120665
		[Nullable(2)]
		private AnniversaryWorldRewardItemData Data;

		// Token: 0x0401D75A RID: 120666
		[Nullable(2)]
		private Action<int> ClickCallback;

		// Token: 0x0200B497 RID: 46231
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04037D88 RID: 228744
			public const int BtnItem = 0;

			// Token: 0x04037D89 RID: 228745
			public const int TexBgFinished = 1;

			// Token: 0x04037D8A RID: 228746
			public const int TexRewardIcon = 2;

			// Token: 0x04037D8B RID: 228747
			public const int TexFinishedIcon = 3;

			// Token: 0x04037D8C RID: 228748
			public const int PnlFinished = 4;

			// Token: 0x04037D8D RID: 228749
			public const int TxtProgress = 5;

			// Token: 0x04037D8E RID: 228750
			public const int FxEffect = 6;
		}
	}
}
