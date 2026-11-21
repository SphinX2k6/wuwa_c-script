using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.KuroSimpleCombat.PB;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Formation
{
	// Token: 0x020052ED RID: 21229
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballFormationView : UiViewBase
	{
		// Token: 0x06034D38 RID: 216376 RVA: 0x00EC42B1 File Offset: 0x00EC24B1
		public PinballFormationView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06034D39 RID: 216377 RVA: 0x00EC42C8 File Offset: 0x00EC24C8
		protected unsafe override void OnRegisterComponent()
		{
			int num = 17;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 4;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickStartBtn));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(6, new Action(this.OnClickLeaderSkillBtn));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(9, new Action(this.OnClickLeaderHeadTipsMaskBtn));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(15, new Action(this.OnClickMonsterBtn));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06034D3A RID: 216378 RVA: 0x00EC45D4 File Offset: 0x00EC27D4
		protected override UniTask OnBeforeStartAsync()
		{
			PinballFormationView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PinballFormationView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06034D3B RID: 216379 RVA: 0x00EC4618 File Offset: 0x00EC2818
		protected override void OnStart()
		{
			IPinballFormationViewData pinballFormationViewData = this.OpenParam as IPinballFormationViewData;
			this.LevelId = pinballFormationViewData.LevelId;
			this.InitRoleInFormation();
			this.InitLevelInfo();
			base.GetItem(8).SetUIActive(false);
			base.GetSprite(13).SetUIActive(false);
		}

		// Token: 0x06034D3C RID: 216380 RVA: 0x00EC4664 File Offset: 0x00EC2864
		protected override void OnBeforeShow()
		{
			this.RefreshFormationList(this.InFormationRoleList);
		}

		// Token: 0x06034D3D RID: 216381 RVA: 0x00EC4674 File Offset: 0x00EC2874
		private void InitRoleInFormation()
		{
			PinballLevelConfig? pinballLevelConfigById = PinballConfig.Instance.GetPinballLevelConfigById(this.LevelId);
			if (pinballLevelConfigById == null || pinballLevelConfigById.Value.TrailRoleLength <= 0)
			{
				this.InFormationRoleList = PinballModel.Instance.GetPinballLevelLastSelectedRoleList((pinballLevelConfigById != null) ? pinballLevelConfigById.GetValueOrDefault().FormationGroup : 0);
				return;
			}
			this.IsTrailLevel = true;
			int trailRoleLength = pinballLevelConfigById.Value.TrailRoleLength;
			this.InFormationRoleList = new List<int>();
			for (int i = 0; i < trailRoleLength; i++)
			{
				this.InFormationRoleList.Add(pinballLevelConfigById.Value.TrailRole(i));
			}
		}

		// Token: 0x06034D3E RID: 216382 RVA: 0x00EC4724 File Offset: 0x00EC2924
		private void InitLevelInfo()
		{
			PinballLevelConfig? pinballLevelConfigById = PinballConfig.Instance.GetPinballLevelConfigById(this.LevelId);
			if (pinballLevelConfigById == null)
			{
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(12), "Pinball_Character_Team_reclevel", new <>z__ReadOnlySingleElementList<object>(pinballLevelConfigById.Value.RecommendLevel));
			PopupCaptionItem captionItem = this.CaptionItem;
			if (captionItem == null)
			{
				return;
			}
			captionItem.SetTitleLocalText(pinballLevelConfigById.Value.Name);
		}

		// Token: 0x06034D3F RID: 216383 RVA: 0x00EC479C File Offset: 0x00EC299C
		private void OnClickStartBtn()
		{
			if ((this.OpenParam as IPinballFormationViewData).IsRestart.GetValueOrDefault())
			{
				(KuroSimpleCombatController.Instance.CurSubController as PinballBattleSubController).Restart(this.InFormationRoleList).Forget();
				return;
			}
			PinballBattleSubController.RequestEnterInst(this.LevelId, this.IsTrailLevel ? new List<int>() : this.InFormationRoleList);
		}

		// Token: 0x06034D40 RID: 216384 RVA: 0x00EC4803 File Offset: 0x00EC2A03
		private void OnClickLeaderSkillBtn()
		{
			base.GetItem(8).SetUIActive(true);
		}

		// Token: 0x06034D41 RID: 216385 RVA: 0x00EC4812 File Offset: 0x00EC2A12
		private void OnClickLeaderHeadTipsMaskBtn()
		{
			base.GetItem(8).SetUIActive(false);
		}

		// Token: 0x06034D42 RID: 216386 RVA: 0x00EC4824 File Offset: 0x00EC2A24
		private void OnClickMonsterBtn()
		{
			int levelId = this.LevelId;
			if (PinballConfig.Instance.GetPinballLevelConfigById(this.LevelId).Value.Type == 4)
			{
				levelId = PinballModel.Instance.ActivityData.GetDailyRandomLevelId();
			}
			PinballController.Instance.OpenMonsterDetailView(levelId).Forget<bool>();
		}

		// Token: 0x06034D43 RID: 216387 RVA: 0x00EC487C File Offset: 0x00EC2A7C
		private void OnClickFormationItemCallBack(int roleId)
		{
			if (this.IsTrailLevel)
			{
				ScrollingTipsController.Instance.ShowTipsByTextId("PinballFilterTrailClickTips", Array.Empty<object>());
				return;
			}
			PinballModel.Instance.SelectRoleHandleList.AddRange(this.InFormationRoleList);
			IPinballFormationSelectRoleViewData openFormationSelectRoleViewData = this.GetOpenFormationSelectRoleViewData(roleId);
			UiManager.Instance.OpenView(EUiViewName.PinballFormationSelectRoleView, openFormationSelectRoleViewData, null);
		}

		// Token: 0x06034D44 RID: 216388 RVA: 0x00EC48D4 File Offset: 0x00EC2AD4
		private IPinballFormationSelectRoleViewData GetOpenFormationSelectRoleViewData(int roleId)
		{
			PinballLevelConfig? pinballLevelConfigById = PinballConfig.Instance.GetPinballLevelConfigById(this.LevelId);
			List<int> list;
			if (pinballLevelConfigById != null)
			{
				int recommendRoleLength = pinballLevelConfigById.Value.RecommendRoleLength;
				list = new List<int>();
				for (int i = 0; i < recommendRoleLength; i++)
				{
					list.Add(pinballLevelConfigById.Value.RecommendRole(i));
				}
			}
			else
			{
				list = new List<int>();
			}
			return new PinballFormationSelectRoleViewData
			{
				RoleList = PinballModel.Instance.GetPinballCanSelectRoleList(),
				RecommendRoleList = list,
				OnConfirm = new Action<List<int>>(this.OnPinballFormationSelectRoleViewConfirm),
				OpenRole = new int?(roleId)
			};
		}

		// Token: 0x06034D45 RID: 216389 RVA: 0x00EC497A File Offset: 0x00EC2B7A
		private void OnPinballFormationSelectRoleViewConfirm(List<int> roleIdList)
		{
			this.RefreshFormationList(roleIdList);
		}

		// Token: 0x06034D46 RID: 216390 RVA: 0x00EC4984 File Offset: 0x00EC2B84
		private void RefreshFormationList(List<int> roleIdList)
		{
			this.InFormationRoleList = roleIdList;
			this.CurrentLeadRole = ((roleIdList.Count > 0) ? roleIdList[0] : 0);
			for (int i = 0; i < this.FormationItemList.Count; i++)
			{
				PinballFormationItem pinballFormationItem = this.FormationItemList[i];
				if (i >= roleIdList.Count)
				{
					pinballFormationItem.RefreshItem(0);
				}
				else
				{
					pinballFormationItem.RefreshItem(roleIdList[i]);
				}
			}
			base.GetButton(3).SetSelfInteractive(this.InFormationRoleList.Count > 0);
			this.RefreshLowLevelTips();
			this.RefreshWarnClassTips();
			this.RefreshLeaderSkill();
		}

		// Token: 0x06034D47 RID: 216391 RVA: 0x00EC4A20 File Offset: 0x00EC2C20
		private void RefreshLowLevelTips()
		{
			int pinballSelectRoleLevelAverage = PinballModel.Instance.GetPinballSelectRoleLevelAverage(this.InFormationRoleList);
			PinballLevelConfig? pinballLevelConfigById = PinballConfig.Instance.GetPinballLevelConfigById(this.LevelId);
			if (pinballLevelConfigById == null || pinballSelectRoleLevelAverage == 0)
			{
				base.GetItem(4).SetUIActive(false);
				return;
			}
			int num = (this.InFormationRoleList.Count > 0) ? PinballModel.Instance.GetRoleLevel(this.InFormationRoleList[0]) : 0;
			base.GetItem(4).SetUIActive(pinballSelectRoleLevelAverage < pinballLevelConfigById.Value.RecommendLevel);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(5), (num > 0 && num >= pinballLevelConfigById.Value.RecommendLevel) ? "Pinball_Character_Team_AvgLevelLow" : "Pinball_Character_Team_LeaderLevelLow", Array.Empty<object>());
		}

		// Token: 0x06034D48 RID: 216392 RVA: 0x00EC4AE8 File Offset: 0x00EC2CE8
		private void RefreshWarnClassTips()
		{
			bool flag = false;
			foreach (int id in this.InFormationRoleList)
			{
				PinballRoleConfig? pinballRoleConfigById = PinballConfig.Instance.GetPinballRoleConfigById(id);
				int pinballClassLength = pinballRoleConfigById.Value.PinballClassLength;
				for (int i = 0; i < pinballClassLength; i++)
				{
					if (pinballRoleConfigById.Value.PinballClass(i) == 3)
					{
						flag = true;
						break;
					}
				}
				if (flag)
				{
					break;
				}
			}
			base.GetItem(16).SetUIActive(!flag);
		}

		// Token: 0x06034D49 RID: 216393 RVA: 0x00EC4B94 File Offset: 0x00EC2D94
		private void RefreshLeaderSkill()
		{
			if (this.CurrentLeadRole == 0)
			{
				base.GetButton(6).RootUIComp.Get().SetUIActive(false);
				return;
			}
			PinballRoleConfig? pinballRoleConfigById = PinballConfig.Instance.GetPinballRoleConfigById(this.CurrentLeadRole);
			if (pinballRoleConfigById == null)
			{
				return;
			}
			PinballSkillDisplayConfig? pinballSkillDisplayConfigById = PinballConfig.Instance.GetPinballSkillDisplayConfigById(pinballRoleConfigById.Value.SkillDisplayList(0));
			if (pinballSkillDisplayConfigById == null)
			{
				return;
			}
			base.GetButton(6).RootUIComp.Get().SetUIActive(true);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(10), pinballSkillDisplayConfigById.Value.Name, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(11), pinballSkillDisplayConfigById.Value.Desc, pinballSkillDisplayConfigById.Value.ValueList());
			base.SetTextureByPath(pinballRoleConfigById.Value.BigIcon, base.GetTexture(7), null, null);
		}

		// Token: 0x06034D4A RID: 216394 RVA: 0x00EC4CA0 File Offset: 0x00EC2EA0
		[NullableContext(0)]
		public override UniTask<bool> CloseMeAsync()
		{
			PinballFormationView.<CloseMeAsync>d__25 <CloseMeAsync>d__;
			<CloseMeAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			<CloseMeAsync>d__.<>4__this = this;
			<CloseMeAsync>d__.<>1__state = -1;
			<CloseMeAsync>d__.<>t__builder.Start<PinballFormationView.<CloseMeAsync>d__25>(ref <CloseMeAsync>d__);
			return <CloseMeAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0401BF23 RID: 114467
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401BF24 RID: 114468
		private readonly List<PinballFormationItem> FormationItemList = new List<PinballFormationItem>();

		// Token: 0x0401BF25 RID: 114469
		private int LevelId;

		// Token: 0x0401BF26 RID: 114470
		private List<int> InFormationRoleList;

		// Token: 0x0401BF27 RID: 114471
		private bool IsTrailLevel;

		// Token: 0x0401BF28 RID: 114472
		private int CurrentLeadRole;

		// Token: 0x0200AF6F RID: 44911
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x04036355 RID: 222037
			FormationItem1,
			// Token: 0x04036356 RID: 222038
			FormationItem2,
			// Token: 0x04036357 RID: 222039
			FormationItem3,
			// Token: 0x04036358 RID: 222040
			StartBtn,
			// Token: 0x04036359 RID: 222041
			LowLevelTipsItem,
			// Token: 0x0403635A RID: 222042
			LowLevelTipsText,
			// Token: 0x0403635B RID: 222043
			LeaderSkillBtn,
			// Token: 0x0403635C RID: 222044
			LeaderHeadTexture,
			// Token: 0x0403635D RID: 222045
			LeaderHeadTipsItem,
			// Token: 0x0403635E RID: 222046
			LeaderHeadTipsMaskBtn,
			// Token: 0x0403635F RID: 222047
			LeaderHeadTipsNameText,
			// Token: 0x04036360 RID: 222048
			LeaderHeadTipsDesText,
			// Token: 0x04036361 RID: 222049
			LevelNameText,
			// Token: 0x04036362 RID: 222050
			LevelIconSprite,
			// Token: 0x04036363 RID: 222051
			CaptionItem,
			// Token: 0x04036364 RID: 222052
			MonsterBtn,
			// Token: 0x04036365 RID: 222053
			WarnClassTipsItem
		}
	}
}
