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
	// Token: 0x02003D82 RID: 15746
	[NullableContext(1)]
	[Nullable(0)]
	public class RoguelikeAchieveTotalPanel : UiPanelBase
	{
		// Token: 0x0602844D RID: 164941 RVA: 0x00B47A48 File Offset: 0x00B45C48
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

		// Token: 0x0602844E RID: 164942 RVA: 0x00B47C3C File Offset: 0x00B45E3C
		protected override UniTask OnBeforeStartAsync()
		{
			RoguelikeAchieveTotalPanel.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoguelikeAchieveTotalPanel.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602844F RID: 164943 RVA: 0x00B47C80 File Offset: 0x00B45E80
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

		// Token: 0x06028450 RID: 164944 RVA: 0x00B47D1D File Offset: 0x00B45F1D
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

		// Token: 0x06028451 RID: 164945 RVA: 0x00B47D50 File Offset: 0x00B45F50
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

		// Token: 0x06028452 RID: 164946 RVA: 0x00B47D74 File Offset: 0x00B45F74
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

		// Token: 0x06028453 RID: 164947 RVA: 0x00B47E10 File Offset: 0x00B46010
		private void OnBtnDetailClick()
		{
			RogueArchiveInfoData currentArchiveInfoData = this.CurrentArchiveInfoData;
			if (((currentArchiveInfoData != null) ? currentArchiveInfoData.RoguelikeInfo : null) == null)
			{
				return;
			}
			RoguelikeController.Instance.OpenRogueInfoView(this.CurrentArchiveInfoData.RoguelikeInfo, false, false, ERogueInfoViewPage.Overview);
		}

		// Token: 0x06028454 RID: 164948 RVA: 0x00B47E3F File Offset: 0x00B4603F
		private ElementItem CreateElementItem()
		{
			return new ElementItem();
		}

		// Token: 0x06028455 RID: 164949 RVA: 0x00B47E46 File Offset: 0x00B46046
		private RoguelikePhantomAffixStateItem CreatePhantomAffixStateItem()
		{
			return new RoguelikePhantomAffixStateItem();
		}

		// Token: 0x06028456 RID: 164950 RVA: 0x00B47E50 File Offset: 0x00B46050
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

		// Token: 0x06028457 RID: 164951 RVA: 0x00B47EF0 File Offset: 0x00B460F0
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

		// Token: 0x06028458 RID: 164952 RVA: 0x00B47F70 File Offset: 0x00B46170
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

		// Token: 0x06028459 RID: 164953 RVA: 0x00B47FE4 File Offset: 0x00B461E4
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

		// Token: 0x0602845A RID: 164954 RVA: 0x00B48064 File Offset: 0x00B46264
		private void SetPhantomContentState(bool hasPhantom)
		{
			base.GetItem(10).SetUIActive(hasPhantom);
			base.GetItem(11).SetUIActive(!hasPhantom);
		}

		// Token: 0x04015E4B RID: 89675
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<ElementItem, ElementInfo> ElementLayout;

		// Token: 0x04015E4C RID: 89676
		[Nullable(2)]
		private RoguelikeAchieveBtnMainRoleItem MainRolePanel;

		// Token: 0x04015E4D RID: 89677
		[Nullable(2)]
		private RoguelikeAchieveTeamRoleItem TeamRolePanel1;

		// Token: 0x04015E4E RID: 89678
		[Nullable(2)]
		private RoguelikeAchieveTeamRoleItem TeamRolePanel2;

		// Token: 0x04015E4F RID: 89679
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<RoguelikePhantomAffixStateItem, IRoguelikePhantomAffixStateItemData> PhantomAffixStateItemLayout;

		// Token: 0x04015E50 RID: 89680
		[Nullable(2)]
		private RogueArchiveInfoData CurrentArchiveInfoData;

		// Token: 0x04015E51 RID: 89681
		[Nullable(2)]
		private RoguelikeAchieveViewModel Vm;

		// Token: 0x02009964 RID: 39268
		[NullableContext(0)]
		private class ERoguelikeAchieveTotalPanelComponents
		{
			// Token: 0x0402FD5E RID: 195934
			public const int TotalPanel = 0;

			// Token: 0x0402FD5F RID: 195935
			public const int ElementLayout = 1;

			// Token: 0x0402FD60 RID: 195936
			public const int ElementItem = 2;

			// Token: 0x0402FD61 RID: 195937
			public const int BtnDetail = 3;

			// Token: 0x0402FD62 RID: 195938
			public const int MainRoleItem = 4;

			// Token: 0x0402FD63 RID: 195939
			public const int TeamRoleAItem = 5;

			// Token: 0x0402FD64 RID: 195940
			public const int TeamRoleBItem = 6;

			// Token: 0x0402FD65 RID: 195941
			public const int TexVisionAvatar = 7;

			// Token: 0x0402FD66 RID: 195942
			public const int PhantomAffixStateLayout = 8;

			// Token: 0x0402FD67 RID: 195943
			public const int PhantomAffixStateItem = 9;

			// Token: 0x0402FD68 RID: 195944
			public const int PnlContent = 10;

			// Token: 0x0402FD69 RID: 195945
			public const int PnlEmpty = 11;
		}
	}
}
