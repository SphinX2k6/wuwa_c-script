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

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004DB9 RID: 19897
	[NullableContext(1)]
	[Nullable(0)]
	public class RoguelikeAchieveTotalPanel : UiPanelBase
	{
		// Token: 0x060335E0 RID: 210400 RVA: 0x00BFE508 File Offset: 0x00BFC708
		protected unsafe override void OnRegisterComponent()
		{
			int num = 12;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIHorizontalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnBtnDetailClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060335E1 RID: 210401 RVA: 0x00BFE6FC File Offset: 0x00BFC8FC
		protected override UniTask OnBeforeStartAsync()
		{
			RoguelikeAchieveTotalPanel.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoguelikeAchieveTotalPanel.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060335E2 RID: 210402 RVA: 0x00BFE740 File Offset: 0x00BFC940
		protected override void OnStart()
		{
			this.ElementLayout = new GenericLayout<ElementItem, ElementInfo>(base.GetHorizontalLayout(1), new Func<ElementItem>(this.CreateElementItem), base.GetItem(2).GetOwner() as AUIBaseActor, false, true);
			this.PhantomAffixStateItemLayout = new GenericLayout<RoguelikePhantomAffixStateItem, IRoguelikePhantomAffixStateItemData>(base.GetHorizontalLayout(8), new Func<RoguelikePhantomAffixStateItem>(this.CreatePhantomAffixStateItem), base.GetItem(9).GetOwner() as AUIBaseActor, false, true);
			base.SetUiActive(false);
			this.SetPhantomContentState(false);
			base.GetTexture(7).SetUIActive(false);
			UUIButtonComponent button = base.GetButton(0);
			if (button == null)
			{
				return;
			}
			button.SetSelfInteractive(false);
		}

		// Token: 0x060335E3 RID: 210403 RVA: 0x00BFE7DD File Offset: 0x00BFC9DD
		protected override void OnBeforeDestroy()
		{
			this.CurrentArchiveInfoData = null;
			this.ElementLayout = null;
			this.MainRolePanel = null;
			this.TeamRolePanel1 = null;
			this.TeamRolePanel2 = null;
			this.PhantomAffixStateItemLayout = null;
			this.Vm = null;
		}

		// Token: 0x060335E4 RID: 210404 RVA: 0x00BFE810 File Offset: 0x00BFCA10
		public void SetViewModel(RoguelikeAchieveViewModel vm)
		{
			this.Vm = vm;
			UUIButtonComponent button = base.GetButton(0);
			if (button == null)
			{
				return;
			}
			button.SetSelfInteractive(this.CurrentArchiveInfoData != null);
		}

		// Token: 0x060335E5 RID: 210405 RVA: 0x00BFE834 File Offset: 0x00BFCA34
		[NullableContext(2)]
		public void Refresh(RogueArchiveInfoData archiveInfoData)
		{
			this.CurrentArchiveInfoData = archiveInfoData;
			if (archiveInfoData == null || !archiveInfoData.HasData)
			{
				base.SetUiActive(false);
				return;
			}
			RoguelikeInfo roguelikeInfo = archiveInfoData.RoguelikeInfo;
			base.SetUiActive(true);
			UUIButtonComponent button = base.GetButton(0);
			if (button != null)
			{
				button.SetSelfInteractive(this.Vm != null);
			}
			RoguelikeAchieveBtnMainRoleItem mainRolePanel = this.MainRolePanel;
			if (mainRolePanel != null)
			{
				mainRolePanel.Refresh(archiveInfoData);
			}
			RoguelikeAchieveTeamRoleItem teamRolePanel = this.TeamRolePanel1;
			if (teamRolePanel != null)
			{
				teamRolePanel.Refresh(archiveInfoData, 1);
			}
			RoguelikeAchieveTeamRoleItem teamRolePanel2 = this.TeamRolePanel2;
			if (teamRolePanel2 != null)
			{
				teamRolePanel2.Refresh(archiveInfoData, 2);
			}
			this.RefreshElementLayout(roguelikeInfo);
			this.RefreshPhantomSection(roguelikeInfo);
		}

		// Token: 0x060335E6 RID: 210406 RVA: 0x00BFE8D0 File Offset: 0x00BFCAD0
		private void OnBtnDetailClick()
		{
			RogueArchiveInfoData currentArchiveInfoData = this.CurrentArchiveInfoData;
			if (((currentArchiveInfoData != null) ? currentArchiveInfoData.RoguelikeInfo : null) == null)
			{
				return;
			}
			RoguelikeController.Instance.OpenRogueInfoView(this.CurrentArchiveInfoData.RoguelikeInfo, false, false, ERogueInfoViewPage.Overview);
		}

		// Token: 0x060335E7 RID: 210407 RVA: 0x00BFE8FF File Offset: 0x00BFCAFF
		private ElementItem CreateElementItem()
		{
			return new ElementItem();
		}

		// Token: 0x060335E8 RID: 210408 RVA: 0x00BFE906 File Offset: 0x00BFCB06
		private RoguelikePhantomAffixStateItem CreatePhantomAffixStateItem()
		{
			return new RoguelikePhantomAffixStateItem();
		}

		// Token: 0x060335E9 RID: 210409 RVA: 0x00BFE910 File Offset: 0x00BFCB10
		private void RefreshElementLayout(RoguelikeInfo roguelikeInfo)
		{
			List<ElementInfo> list = new List<ElementInfo>();
			RoguelikeModel instance = RoguelikeModel.Instance;
			RogueParam? rogueParam;
			foreach (int num in ((instance != null) ? ((instance.GetParamConfigBySeasonId(null) != null) ? rogueParam.GetValueOrDefault().ElementList() : null) : null) ?? Array.Empty<int>())
			{
				list.Add(new ElementInfo(num, roguelikeInfo.ElementDict.GetValueOrDefault(num, 0), null));
			}
			GenericLayout<ElementItem, ElementInfo> elementLayout = this.ElementLayout;
			if (elementLayout == null)
			{
				return;
			}
			elementLayout.RefreshByData(list, null, false);
		}

		// Token: 0x060335EA RID: 210410 RVA: 0x00BFE9B0 File Offset: 0x00BFCBB0
		private void RefreshPhantomAffixStateItemLayout(RoguelikeInfo roguelikeInfo, List<AffixEntry> affixEntryList)
		{
			List<IRoguelikePhantomAffixStateItemData> list = new List<IRoguelikePhantomAffixStateItemData>();
			foreach (AffixEntry affixEntry in affixEntryList)
			{
				list.Add(new RoguelikePhantomAffixStateItemData
				{
					AffixEntry = affixEntry,
					IsUnlock = roguelikeInfo.GetIsUnlock(affixEntry)
				});
			}
			GenericLayout<RoguelikePhantomAffixStateItem, IRoguelikePhantomAffixStateItemData> phantomAffixStateItemLayout = this.PhantomAffixStateItemLayout;
			if (phantomAffixStateItemLayout == null)
			{
				return;
			}
			phantomAffixStateItemLayout.RefreshByData(list, null, false);
		}

		// Token: 0x060335EB RID: 210411 RVA: 0x00BFEA30 File Offset: 0x00BFCC30
		private void RefreshPhantomSection(RoguelikeInfo roguelikeInfo)
		{
			RogueGainEntry phantomEntry = roguelikeInfo.PhantomEntry;
			if (phantomEntry != null && phantomEntry.ConfigId != 0)
			{
				this.SetPhantomContentState(true);
				this.RefreshPhantomAvatar(phantomEntry.ConfigId);
				this.RefreshPhantomAffixStateItemLayout(roguelikeInfo, phantomEntry.AffixEntryList ?? new List<AffixEntry>());
				return;
			}
			this.SetPhantomContentState(false);
			base.GetTexture(7).SetUIActive(false);
			GenericLayout<RoguelikePhantomAffixStateItem, IRoguelikePhantomAffixStateItemData> phantomAffixStateItemLayout = this.PhantomAffixStateItemLayout;
			if (phantomAffixStateItemLayout == null)
			{
				return;
			}
			phantomAffixStateItemLayout.RefreshByData(new List<IRoguelikePhantomAffixStateItemData>(), null, false);
		}

		// Token: 0x060335EC RID: 210412 RVA: 0x00BFEAA4 File Offset: 0x00BFCCA4
		private void RefreshPhantomAvatar(int phantomConfigId)
		{
			UUITexture texture = base.GetTexture(7);
			RoguelikeConfig instance = RoguelikeConfig.Instance;
			RoguePokemon? roguePokemon = (instance != null) ? instance.GetRoguePhantomConfig(phantomConfigId) : null;
			string text = (roguePokemon != null) ? roguePokemon.GetValueOrDefault().PokemonIcon : null;
			if (roguePokemon == null || string.IsNullOrEmpty(text))
			{
				texture.SetUIActive(false);
				return;
			}
			texture.SetUIActive(true);
			base.SetTextureByPath(text, texture, null, null);
		}

		// Token: 0x060335ED RID: 210413 RVA: 0x00BFEB24 File Offset: 0x00BFCD24
		private void SetPhantomContentState(bool hasPhantom)
		{
			base.GetItem(10).SetUIActive(hasPhantom);
			base.GetItem(11).SetUIActive(!hasPhantom);
		}

		// Token: 0x0401B478 RID: 111736
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<ElementItem, ElementInfo> ElementLayout;

		// Token: 0x0401B479 RID: 111737
		[Nullable(2)]
		private RoguelikeAchieveBtnMainRoleItem MainRolePanel;

		// Token: 0x0401B47A RID: 111738
		[Nullable(2)]
		private RoguelikeAchieveTeamRoleItem TeamRolePanel1;

		// Token: 0x0401B47B RID: 111739
		[Nullable(2)]
		private RoguelikeAchieveTeamRoleItem TeamRolePanel2;

		// Token: 0x0401B47C RID: 111740
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RoguelikePhantomAffixStateItem, IRoguelikePhantomAffixStateItemData> PhantomAffixStateItemLayout;

		// Token: 0x0401B47D RID: 111741
		[Nullable(2)]
		private RogueArchiveInfoData CurrentArchiveInfoData;

		// Token: 0x0401B47E RID: 111742
		[Nullable(2)]
		private RoguelikeAchieveViewModel Vm;

		// Token: 0x0200AF2F RID: 44847
		[NullableContext(0)]
		private class ERoguelikeAchieveTotalPanelComponents
		{
			// Token: 0x04035329 RID: 217897
			public const int TotalPanel = 0;

			// Token: 0x0403532A RID: 217898
			public const int ElementLayout = 1;

			// Token: 0x0403532B RID: 217899
			public const int ElementItem = 2;

			// Token: 0x0403532C RID: 217900
			public const int BtnDetail = 3;

			// Token: 0x0403532D RID: 217901
			public const int MainRoleItem = 4;

			// Token: 0x0403532E RID: 217902
			public const int TeamRoleAItem = 5;

			// Token: 0x0403532F RID: 217903
			public const int TeamRoleBItem = 6;

			// Token: 0x04035330 RID: 217904
			public const int TexVisionAvatar = 7;

			// Token: 0x04035331 RID: 217905
			public const int PhantomAffixStateLayout = 8;

			// Token: 0x04035332 RID: 217906
			public const int PhantomAffixStateItem = 9;

			// Token: 0x04035333 RID: 217907
			public const int PnlContent = 10;

			// Token: 0x04035334 RID: 217908
			public const int PnlEmpty = 11;
		}
	}
}
