using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Module.Activity.ActivityContent.SolarisSpeed;
using CSharpScript.Game.Module.Personal;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Google.Protobuf.Collections;
using UnrealEngine;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02003AD2 RID: 15058
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class TowerDefenseRankItemV2 : GridProxyAbstract<TowerDefenseRankItemData>
	{
		// Token: 0x06026AEF RID: 158447 RVA: 0x00AD5D38 File Offset: 0x00AD3F38
		protected unsafe override void OnRegisterComponent()
		{
			int num = 12;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUILayoutBase));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUILayoutBase));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIButtonComponent));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(11, new Action(this.OnReviewClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06026AF0 RID: 158448 RVA: 0x00AD5F30 File Offset: 0x00AD4130
		protected override void OnStart()
		{
			this.OnlineNameLayout = new GenericLayout<TowerDefenseRankOnlineItem, ITowerDefenseRankPlayerName>(base.GetLayoutBase(5), new Func<TowerDefenseRankOnlineItem>(this.InitOnlineItem), base.GetItem(6).GetOwner() as AUIBaseActor, false, true);
			this.FormationLayout = new GenericLayout<TowerDefenseRankFormationItemV2, TowerDefenseRankRoleData>(base.GetLayoutBase(8), new Func<TowerDefenseRankFormationItemV2>(this.InitFormationItem), base.GetItem(9).GetOwner() as AUIBaseActor, false, true);
		}

		// Token: 0x06026AF1 RID: 158449 RVA: 0x00AD5FA0 File Offset: 0x00AD41A0
		private TowerDefenseRankOnlineItem InitOnlineItem()
		{
			return new TowerDefenseRankOnlineItem();
		}

		// Token: 0x06026AF2 RID: 158450 RVA: 0x00AD5FA7 File Offset: 0x00AD41A7
		private TowerDefenseRankFormationItemV2 InitFormationItem()
		{
			return new TowerDefenseRankFormationItemV2();
		}

		// Token: 0x06026AF3 RID: 158451 RVA: 0x00AD5FB0 File Offset: 0x00AD41B0
		private void RefreshEmpty()
		{
			base.GetText(1).SetUIActive(false);
			base.GetText(2).SetUIActive(false);
			base.GetItem(3).SetUIActive(true);
			UUIItem rootUiItem = this.OnlineNameLayout.GetRootUiItem();
			if (rootUiItem != null)
			{
				rootUiItem.SetUIActive(false);
			}
			string newText = PlayerInfoModel.Instance.GetAccountName(true) ?? string.Empty;
			UUIText text = base.GetText(4);
			text.SetText(newText, true);
			text.SetUIActive(true);
			base.GetText(7).SetUIActive(false);
			UUIItem rootUiItem2 = this.FormationLayout.GetRootUiItem();
			if (rootUiItem2 != null)
			{
				rootUiItem2.SetUIActive(false);
			}
			UUIText text2 = base.GetText(10);
			if (text2 != null)
			{
				text2.SetUIActive(true);
			}
			UUIButtonComponent button = base.GetButton(11);
			if (button != null)
			{
				button.RootUIComp.Get().SetUIActive(false);
			}
			this.RefreshRankBg();
		}

		// Token: 0x06026AF4 RID: 158452 RVA: 0x00AD6084 File Offset: 0x00AD4284
		protected virtual void RefreshRankBg()
		{
			UUITexture texture = base.GetTexture(0);
			if (!this.RankItemData.IsTopThree)
			{
				texture.SetUIActive(false);
				return;
			}
			texture.SetUIActive(true);
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(this.RankItemData.RankBg);
			base.SetTextureByPath(resourcePath, texture, null, null);
		}

		// Token: 0x06026AF5 RID: 158453 RVA: 0x00AD60E0 File Offset: 0x00AD42E0
		private void RefreshRankNum()
		{
			bool isTopThree = this.RankItemData.IsTopThree;
			UUIText text = base.GetText(1);
			UUIText text2 = base.GetText(2);
			text.SetUIActive(isTopThree);
			text2.SetUIActive(!isTopThree && this.RankItemData.IsInRank);
			base.GetItem(3).SetUIActive(!this.RankItemData.IsInRank);
			if (isTopThree)
			{
				text.SetText(this.RankItemData.Rank.ToString(), true);
				text.outlineColor = FColor.FromHex(this.RankItemData.TopThreeNumColor);
				return;
			}
			if (this.RankItemData.IsInRank)
			{
				text2.SetText(this.RankItemData.Rank.ToString(), true);
			}
		}

		// Token: 0x06026AF6 RID: 158454 RVA: 0x00AD6198 File Offset: 0x00AD4398
		public UniTask RefreshPlayerName()
		{
			TowerDefenseRankItemV2.<RefreshPlayerName>d__10 <RefreshPlayerName>d__;
			<RefreshPlayerName>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshPlayerName>d__.<>4__this = this;
			<RefreshPlayerName>d__.<>1__state = -1;
			<RefreshPlayerName>d__.<>t__builder.Start<TowerDefenseRankItemV2.<RefreshPlayerName>d__10>(ref <RefreshPlayerName>d__);
			return <RefreshPlayerName>d__.<>t__builder.Task;
		}

		// Token: 0x06026AF7 RID: 158455 RVA: 0x00AD61DC File Offset: 0x00AD43DC
		private void RefreshTimeScore()
		{
			UUIText text = base.GetText(7);
			text.SetUIActive(true);
			string timeDataFormat = TimeUtil.Instance.GetTimeDataFormat((double)this.RankItemData.PassTime);
			text.SetText(timeDataFormat, true);
		}

		// Token: 0x06026AF8 RID: 158456 RVA: 0x00AD6218 File Offset: 0x00AD4418
		private UniTask RefreshFormation()
		{
			TowerDefenseRankItemV2.<RefreshFormation>d__12 <RefreshFormation>d__;
			<RefreshFormation>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshFormation>d__.<>4__this = this;
			<RefreshFormation>d__.<>1__state = -1;
			<RefreshFormation>d__.<>t__builder.Start<TowerDefenseRankItemV2.<RefreshFormation>d__12>(ref <RefreshFormation>d__);
			return <RefreshFormation>d__.<>t__builder.Task;
		}

		// Token: 0x06026AF9 RID: 158457 RVA: 0x00AD625B File Offset: 0x00AD445B
		public override void Refresh(TowerDefenseRankItemData data, bool isSelected, int gridIndex)
		{
			this.RankItemData = data;
			if (data.IsEmpty)
			{
				this.RefreshEmpty();
				return;
			}
			this.RefreshRankBg();
			this.RefreshRankNum();
			this.RefreshPlayerName();
			this.RefreshTimeScore();
			this.RefreshFormation();
			this.RefreshReviewButton();
		}

		// Token: 0x06026AFA RID: 158458 RVA: 0x00AD629C File Offset: 0x00AD449C
		protected virtual void RefreshReviewButton()
		{
			UUIButtonComponent button = base.GetButton(11);
			if (button == null)
			{
				return;
			}
			button.RootUIComp.Get().SetUIActive(this.RankItemData.IsOnline);
		}

		// Token: 0x06026AFB RID: 158459 RVA: 0x00AD62D4 File Offset: 0x00AD44D4
		private void OnReviewClick()
		{
			List<ISolarSpeedRolePanelData> list = new List<ISolarSpeedRolePanelData>();
			int? id = PlayerInfoModel.Instance.GetId();
			RepeatedField<TowerDefencePassPlayerInfo> playerPassInfo = this.RankItemData.ServerData.PlayerPassInfo;
			int i = 0;
			int count = playerPassInfo.Count;
			while (i < count)
			{
				TowerDefencePassPlayerInfo towerDefencePassPlayerInfo = playerPassInfo[i];
				int playerId = towerDefencePassPlayerInfo.PlayerId;
				int num = playerId;
				int? num2 = id;
				bool flag = num == num2.GetValueOrDefault() & num2 != null;
				foreach (TowerDefenceRolePassInfo towerDefenceRolePassInfo in towerDefencePassPlayerInfo.RoleList)
				{
					List<ITowerDefenseRoleDescData> list2 = new List<ITowerDefenseRoleDescData>();
					foreach (TowerDefenceBattleScoreInfo towerDefenceBattleScoreInfo in towerDefenceRolePassInfo.ScoreList)
					{
						list2.Add(new TowerDefenseRoleDescData
						{
							Title = towerDefenceBattleScoreInfo.Id,
							Count = towerDefenceBattleScoreInfo.Score
						});
					}
					TowerDefenseRolePanelData item = new TowerDefenseRolePanelData
					{
						Rank = 0,
						PlayerId = playerId,
						IsAddButtonAvailable = (!flag && !FriendModel.Instance.IsMyFriend(playerId)),
						IsSelf = flag,
						BgPath = SolarSpeedDefine.rankBgPathMap[0],
						MedalColorHex = SolarSpeedDefine.medalColorHex[0],
						FxColorHex = SolarSpeedDefine.fxColorHex[0],
						PlayerIndexIconPath = (flag ? SolarSpeedDefine.playerIndexSelfIconMap[i] : SolarSpeedDefine.playerIndexIconMap[i]),
						NameText = towerDefencePassPlayerInfo.Name,
						IconData = new SolarSpeedRoleIconPanelData
						{
							IconPath = PersonalModel.Instance.GetPlayerHeadData(towerDefencePassPlayerInfo.HeadId, false).GetRoleHeadIconCircle()
						},
						BestTitle = towerDefenceRolePassInfo.Title,
						DescDataList = list2
					};
					list.Add(item);
				}
				i++;
			}
			SolarSpeedResultViewData solarSpeedResultViewData = new SolarSpeedResultViewData();
			solarSpeedResultViewData.TitleId = "TowerDefenceSettlement01";
			solarSpeedResultViewData.RoleDataList = list;
			solarSpeedResultViewData.PanelType = (() => new TowerDefenseRolePanel());
			solarSpeedResultViewData.ConfirmClick = delegate()
			{
				UiManager.Instance.CloseView(EUiViewName.SolarSpeedResultView, null);
			};
			SolarSpeedResultViewData param = solarSpeedResultViewData;
			UiManager.Instance.OpenView(EUiViewName.SolarSpeedResultView, param, null);
		}

		// Token: 0x06026AFC RID: 158460 RVA: 0x00AD656C File Offset: 0x00AD476C
		public bool IsSelfItem()
		{
			return this.RankItemData.IsSelfInData;
		}

		// Token: 0x040152D1 RID: 86737
		private GenericLayout<TowerDefenseRankOnlineItem, ITowerDefenseRankPlayerName> OnlineNameLayout;

		// Token: 0x040152D2 RID: 86738
		private GenericLayout<TowerDefenseRankFormationItemV2, TowerDefenseRankRoleData> FormationLayout;

		// Token: 0x040152D3 RID: 86739
		protected TowerDefenseRankItemData RankItemData;

		// Token: 0x020096DA RID: 38618
		[NullableContext(0)]
		protected class ERankItemComponent
		{
			// Token: 0x0402F153 RID: 192851
			public const int RankBgTex = 0;

			// Token: 0x0402F154 RID: 192852
			public const int TopThreeRankTxt = 1;

			// Token: 0x0402F155 RID: 192853
			public const int OtherRankTxt = 2;

			// Token: 0x0402F156 RID: 192854
			public const int EmptyItem = 3;

			// Token: 0x0402F157 RID: 192855
			public const int NameTxt = 4;

			// Token: 0x0402F158 RID: 192856
			public const int OnlineLayout = 5;

			// Token: 0x0402F159 RID: 192857
			public const int OnlineItem = 6;

			// Token: 0x0402F15A RID: 192858
			public const int TimeTxt = 7;

			// Token: 0x0402F15B RID: 192859
			public const int FormationLayout = 8;

			// Token: 0x0402F15C RID: 192860
			public const int FormationItem = 9;

			// Token: 0x0402F15D RID: 192861
			public const int EmptyTxt = 10;

			// Token: 0x0402F15E RID: 192862
			public const int ReviewButton = 11;
		}
	}
}
