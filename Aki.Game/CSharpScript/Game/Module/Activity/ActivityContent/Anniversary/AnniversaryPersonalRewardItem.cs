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
	// Token: 0x02005876 RID: 22646
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class AnniversaryPersonalRewardItem : GridProxyAbstract<AnniversaryPersonalRewardItemData>
	{
		// Token: 0x06037D1B RID: 228635 RVA: 0x00F9C684 File Offset: 0x00F9A884
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

		// Token: 0x06037D1C RID: 228636 RVA: 0x00F9C74C File Offset: 0x00F9A94C
		protected override UniTask OnBeforeStartAsync()
		{
			AnniversaryPersonalRewardItem.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<AnniversaryPersonalRewardItem.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06037D1D RID: 228637 RVA: 0x00F9C78F File Offset: 0x00F9A98F
		public void SetClickCallback(Action<int> callback)
		{
			this.ClickCallback = callback;
		}

		// Token: 0x06037D1E RID: 228638 RVA: 0x00F9C798 File Offset: 0x00F9A998
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

		// Token: 0x06037D1F RID: 228639 RVA: 0x00F9C984 File Offset: 0x00F9AB84
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

		// Token: 0x06037D20 RID: 228640 RVA: 0x00F9C9B0 File Offset: 0x00F9ABB0
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

		// Token: 0x0401D753 RID: 120659
		[Nullable(2)]
		private AnniversaryPersonalRewardItemData Data;

		// Token: 0x0401D754 RID: 120660
		[Nullable(2)]
		private SmallItemGrid RewardItem;

		// Token: 0x0401D755 RID: 120661
		[Nullable(2)]
		private Action<int> ClickCallback;

		// Token: 0x0200B494 RID: 46228
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04037D7A RID: 228730
			public const int ItemBase = 0;

			// Token: 0x04037D7B RID: 228731
			public const int SprNor = 1;

			// Token: 0x04037D7C RID: 228732
			public const int SprCanGet = 2;

			// Token: 0x04037D7D RID: 228733
			public const int SprFinished = 3;

			// Token: 0x04037D7E RID: 228734
			public const int TxtValue = 4;

			// Token: 0x04037D7F RID: 228735
			public const int SprProgressFill = 5;

			// Token: 0x04037D80 RID: 228736
			public const int PnlProgress = 6;

			// Token: 0x04037D81 RID: 228737
			public const int FxGlow = 7;
		}
	}
}
