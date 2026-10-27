using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Common.MediumItemGrid;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Anniversary
{
	// Token: 0x02006926 RID: 26918
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class AnniversaryPersonalRewardItem : GridProxyAbstract<AnniversaryPersonalRewardItemData>
	{
		// Token: 0x060431C3 RID: 274883 RVA: 0x0105B058 File Offset: 0x01059258
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIText)),
				new ValueTuple<int, Type>(5, typeof(UUISprite)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIItem))
			};
		}

		// Token: 0x060431C4 RID: 274884 RVA: 0x0105B120 File Offset: 0x01059320
		protected override UniTask OnBeforeStartAsync()
		{
			AnniversaryPersonalRewardItem.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<AnniversaryPersonalRewardItem.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060431C5 RID: 274885 RVA: 0x0105B163 File Offset: 0x01059363
		public void SetClickCallback(Action<int> callback)
		{
			this.ClickCallback = callback;
		}

		// Token: 0x060431C6 RID: 274886 RVA: 0x0105B16C File Offset: 0x0105936C
		public override void Refresh(AnniversaryPersonalRewardItemData data, bool isSelected, int gridIndex)
		{
			if (data == null)
			{
				return;
			}
			this.Data = data;
			PersonProgressCurve? personProgressCurveById = AnniversaryActivityConfig.Instance.GetPersonProgressCurveById(data.CfgId);
			if (personProgressCurveById == null)
			{
				return;
			}
			EAnniversaryProgressRewardState valueOrDefault = data.State.GetValueOrDefault();
			UUIText text = base.GetText(4);
			if (text != null)
			{
				text.SetText(personProgressCurveById.Value.Progress.ToString(), true);
			}
			UUIText text2 = base.GetText(4);
			if (text2 != null)
			{
				text2.SetColor(this.GetProgressTextColor(valueOrDefault));
			}
			UUISprite sprite = base.GetSprite(5);
			if (sprite != null)
			{
				sprite.SetFillAmount(data.CurProgress);
			}
			UUIItem item = base.GetItem(1);
			if (item != null)
			{
				item.SetUIActive(valueOrDefault == EAnniversaryProgressRewardState.Lock);
			}
			UUIItem item2 = base.GetItem(2);
			if (item2 != null)
			{
				item2.SetUIActive(valueOrDefault == EAnniversaryProgressRewardState.CanReceive);
			}
			UUIItem item3 = base.GetItem(3);
			if (item3 != null)
			{
				item3.SetUIActive(valueOrDefault == EAnniversaryProgressRewardState.Rewarded);
			}
			UUIItem item4 = base.GetItem(7);
			if (item4 != null)
			{
				item4.SetUIActive(personProgressCurveById.Value.ShowEffect);
			}
			if (this.RewardItem != null && personProgressCurveById.Value.DropId > 0)
			{
				Dictionary<int, int> dropPackagePreview = CSharpScript.Game.Module.Reward.RewardConfig.Instance.GetDropPackagePreview(personProgressCurveById.Value.DropId);
				if (dropPackagePreview != null && dropPackagePreview.Count > 0)
				{
					using (Dictionary<int, int>.Enumerator enumerator = dropPackagePreview.GetEnumerator())
					{
						if (enumerator.MoveNext())
						{
							KeyValuePair<int, int> keyValuePair = enumerator.Current;
							PropSmallItemGrid parameters = new PropSmallItemGrid
							{
								Data = null,
								ItemConfigId = new int?(keyValuePair.Key),
								BottomText = keyValuePair.Value.ToString(),
								IsReceivableVisible = new bool?(valueOrDefault == EAnniversaryProgressRewardState.CanReceive),
								IsReceivedVisible = new bool?(valueOrDefault == EAnniversaryProgressRewardState.Rewarded)
							};
							this.RewardItem.ApplyPropSmallItemGrid(parameters);
						}
					}
				}
			}
		}

		// Token: 0x060431C7 RID: 274887 RVA: 0x0105B358 File Offset: 0x01059558
		private FColor GetProgressTextColor(EAnniversaryProgressRewardState state)
		{
			if (state == EAnniversaryProgressRewardState.CanReceive)
			{
				return FColor.FromHex("#010100FF");
			}
			if (state != EAnniversaryProgressRewardState.Rewarded)
			{
				return FColor.FromHex("#FFFFFFFF");
			}
			return FColor.FromHex("#9EFF2BFF");
		}

		// Token: 0x060431C8 RID: 274888 RVA: 0x0105B384 File Offset: 0x01059584
		private void OnClick(MediumItemGridExtendCallback _)
		{
			if (this.Data == null)
			{
				return;
			}
			Action<int> clickCallback = this.ClickCallback;
			if (clickCallback == null)
			{
				return;
			}
			clickCallback(this.Data.CfgId);
		}

		// Token: 0x04022EF7 RID: 143095
		[Nullable(2)]
		private AnniversaryPersonalRewardItemData Data;

		// Token: 0x04022EF8 RID: 143096
		[Nullable(2)]
		private SmallItemGrid RewardItem;

		// Token: 0x04022EF9 RID: 143097
		[Nullable(2)]
		private Action<int> ClickCallback;

		// Token: 0x0200CACC RID: 51916
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403D4A0 RID: 251040
			public const int ItemBase = 0;

			// Token: 0x0403D4A1 RID: 251041
			public const int SprNor = 1;

			// Token: 0x0403D4A2 RID: 251042
			public const int SprCanGet = 2;

			// Token: 0x0403D4A3 RID: 251043
			public const int SprFinished = 3;

			// Token: 0x0403D4A4 RID: 251044
			public const int TxtValue = 4;

			// Token: 0x0403D4A5 RID: 251045
			public const int SprProgressFill = 5;

			// Token: 0x0403D4A6 RID: 251046
			public const int PnlProgress = 6;

			// Token: 0x0403D4A7 RID: 251047
			public const int FxGlow = 7;
		}
	}
}
