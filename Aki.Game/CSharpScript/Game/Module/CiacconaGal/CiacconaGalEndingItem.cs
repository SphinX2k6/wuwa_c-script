using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.GenericPrompt;
using CSharpScript.Game.Module.Reward;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.CiacconaGal
{
	// Token: 0x02005BEF RID: 23535
	[NullableContext(1)]
	[Nullable(0)]
	public class CiacconaGalEndingItem : UiPanelBase
	{
		// Token: 0x0603B7B7 RID: 243639 RVA: 0x00E2F886 File Offset: 0x00E2DA86
		public CiacconaGalEndingItem(CiacconaGalEndingData endingData, string labelTextId)
		{
			this.EndingData = endingData;
			this.LabelTextId = labelTextId;
		}

		// Token: 0x0603B7B8 RID: 243640 RVA: 0x00E2F89C File Offset: 0x00E2DA9C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 9;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUINiagara));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnBtnSelfClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603B7B9 RID: 243641 RVA: 0x00E2FA2C File Offset: 0x00E2DC2C
		protected override UniTask OnBeforeStartAsync()
		{
			CiacconaGalEndingItem.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<CiacconaGalEndingItem.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603B7BA RID: 243642 RVA: 0x00E2FA6F File Offset: 0x00E2DC6F
		protected override void OnStart()
		{
			this.RefreshPanel();
			EventSystem.Instance.Add(EEventName.OnCiacconaEndingDataUpdate, new Action(this.OnCiacconaEndingDataUpdate));
		}

		// Token: 0x0603B7BB RID: 243643 RVA: 0x00E2FA93 File Offset: 0x00E2DC93
		protected override void OnBeforeDestroy()
		{
			EventSystem.Instance.Remove(EEventName.OnCiacconaEndingDataUpdate, new Action(this.OnCiacconaEndingDataUpdate));
		}

		// Token: 0x0603B7BC RID: 243644 RVA: 0x00E2FAB4 File Offset: 0x00E2DCB4
		private void RefreshPanel()
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), this.LabelTextId, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), this.EndingData.Title, Array.Empty<object>());
			this.BtnReward.SetActive(!this.EndingData.IsRewarded);
			this.BtnReward.SetRedDotVisible(this.EndingData.IsFinished && !this.EndingData.IsRewarded);
			base.GetSprite(4).SetUIActive(this.EndingData.IsRewarded);
			string resourceId = (this.EndingData.Type == ECiacconaGalEndingType.Main) ? "T_PlotReasoningFinalLockGold" : "T_PlotReasoningFinalLock";
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
			string path = this.EndingData.IsFinished ? this.EndingData.ImagePath : resourcePath;
			base.SetTextureByPath(path, base.GetTexture(1), null, null);
			base.GetTexture(6).SetUIActive(!this.EndingData.IsFinished);
			base.GetTexture(7).SetUIActive(this.EndingData.IsFinished);
			base.GetUiNiagara(8).SetUIActive(!this.EndingData.IsFinished && this.EndingData.Type == ECiacconaGalEndingType.Main);
		}

		// Token: 0x0603B7BD RID: 243645 RVA: 0x00E2FC10 File Offset: 0x00E2DE10
		private void OnBtnRewardClick()
		{
			if (this.EndingData.IsFinished)
			{
				int id = CiacconaGalModel.Instance.ActivityData.Id;
				CiacconaGalController.Instance.RequestGetActivityEndingReward(id, this.EndingData.Id);
				return;
			}
			List<TItem> dropPackagePreviewItemList = RewardConfig.Instance.GetDropPackagePreviewItemList(this.EndingData.RewardId);
			List<DailyActivityDefine.RewardTuple> list = new List<DailyActivityDefine.RewardTuple>();
			foreach (TItem titem in dropPackagePreviewItemList)
			{
				list.Add(new DailyActivityDefine.RewardTuple
				{
					Id = titem.ItemData.ItemId,
					Num = titem.Count,
					Received = false
				});
			}
			RewardPopupData p = new RewardPopupData
			{
				RewardLists = list,
				MountItem = base.GetItem(5),
				PosBias = new FVector?(new FVector(0f, 0f, 0f))
			};
			EventSystem.Instance.Emit<RewardPopupData>(EEventName.RefreshRewardPopUp, p);
		}

		// Token: 0x0603B7BE RID: 243646 RVA: 0x00E2FD24 File Offset: 0x00E2DF24
		private void OnBtnSelfClick()
		{
			if (this.EndingData.IsFinished)
			{
				CiacconaGalController.Instance.OpenEndingDetailView(this.EndingData.Id, this.LabelTextId);
				return;
			}
			GenericPromptController.Instance.ShowPromptByCode("EndingUnfinished", Array.Empty<object>());
		}

		// Token: 0x0603B7BF RID: 243647 RVA: 0x00E2FD63 File Offset: 0x00E2DF63
		private void OnCiacconaEndingDataUpdate()
		{
			this.RefreshPanel();
		}

		// Token: 0x0401EFD4 RID: 126932
		[Nullable(2)]
		private ButtonSpriteItem BtnReward;

		// Token: 0x0401EFD5 RID: 126933
		private readonly CiacconaGalEndingData EndingData;

		// Token: 0x0401EFD6 RID: 126934
		private readonly string LabelTextId;

		// Token: 0x0200BDD6 RID: 48598
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x040393D8 RID: 234456
			public const int BtnSelf = 0;

			// Token: 0x040393D9 RID: 234457
			public const int TextureBg = 1;

			// Token: 0x040393DA RID: 234458
			public const int TextTitle = 2;

			// Token: 0x040393DB RID: 234459
			public const int TextDesc = 3;

			// Token: 0x040393DC RID: 234460
			public const int SpriteRewarded = 4;

			// Token: 0x040393DD RID: 234461
			public const int BtnReward = 5;

			// Token: 0x040393DE RID: 234462
			public const int TextureHoverLock = 6;

			// Token: 0x040393DF RID: 234463
			public const int TextureHoverFinish = 7;

			// Token: 0x040393E0 RID: 234464
			public const int Niagara = 8;
		}
	}
}
