using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Anniversary
{
	// Token: 0x02006928 RID: 26920
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class AnniversaryWorldRewardItem : GridProxyAbstract<AnniversaryWorldRewardItemData>
	{
		// Token: 0x060431CB RID: 274891 RVA: 0x0105B3BC File Offset: 0x010595BC
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

		// Token: 0x060431CC RID: 274892 RVA: 0x0105B491 File Offset: 0x01059691
		public void SetClickCallback(Action<int> callback)
		{
			this.ClickCallback = callback;
		}

		// Token: 0x060431CD RID: 274893 RVA: 0x0105B49C File Offset: 0x0105969C
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

		// Token: 0x060431CE RID: 274894 RVA: 0x0105B594 File Offset: 0x01059794
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

		// Token: 0x060431CF RID: 274895 RVA: 0x0105B60B File Offset: 0x0105980B
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

		// Token: 0x04022EFD RID: 143101
		[Nullable(2)]
		private AnniversaryWorldRewardItemData Data;

		// Token: 0x04022EFE RID: 143102
		[Nullable(2)]
		private Action<int> ClickCallback;

		// Token: 0x0200CACF RID: 51919
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403D4AE RID: 251054
			public const int BtnItem = 0;

			// Token: 0x0403D4AF RID: 251055
			public const int TexBgFinished = 1;

			// Token: 0x0403D4B0 RID: 251056
			public const int TexRewardIcon = 2;

			// Token: 0x0403D4B1 RID: 251057
			public const int TexFinishedIcon = 3;

			// Token: 0x0403D4B2 RID: 251058
			public const int PnlFinished = 4;

			// Token: 0x0403D4B3 RID: 251059
			public const int TxtProgress = 5;

			// Token: 0x0403D4B4 RID: 251060
			public const int FxEffect = 6;
		}
	}
}
