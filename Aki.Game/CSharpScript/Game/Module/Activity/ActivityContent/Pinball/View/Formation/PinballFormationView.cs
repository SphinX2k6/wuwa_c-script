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
	// Token: 0x0200636F RID: 25455
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballFormationView : UiViewBase
	{
		// Token: 0x06040077 RID: 262263 RVA: 0x00F7D351 File Offset: 0x00F7B551
		public PinballFormationView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06040078 RID: 262264 RVA: 0x00F7D368 File Offset: 0x00F7B568
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

		// Token: 0x06040079 RID: 262265 RVA: 0x00F7D674 File Offset: 0x00F7B874
		protected override UniTask OnBeforeStartAsync()
		{
			PinballFormationView.<OnBeforeStartAsync>d__9 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PinballFormationView.<OnBeforeStartAsync>d__9>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0604007A RID: 262266 RVA: 0x00F7D6B8 File Offset: 0x00F7B8B8
		protected override void OnStart()
		{
			IPinballFormationViewData pinballFormationViewData = this.OpenParam as IPinballFormationViewData;
			this.LevelId = pinballFormationViewData.LevelId;
			this.InitRoleInFormation();
			this.InitLevelInfo();
			base.GetItem(8).SetUIActive(false);
			base.GetSprite(13).SetUIActive(false);
		}

		// Token: 0x0604007B RID: 262267 RVA: 0x00F7D704 File Offset: 0x00F7B904
		protected override void OnBeforeShow()
		{
			this.RefreshFormationList(this.InFormationRoleList);
		}

		// Token: 0x0604007C RID: 262268 RVA: 0x00F7D714 File Offset: 0x00F7B914
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

		// Token: 0x0604007D RID: 262269 RVA: 0x00F7D7C4 File Offset: 0x00F7B9C4
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

		// Token: 0x0604007E RID: 262270 RVA: 0x00F7D83C File Offset: 0x00F7BA3C
		private void OnClickStartBtn()
		{
			if ((this.OpenParam as IPinballFormationViewData).IsRestart.GetValueOrDefault())
			{
				(KuroSimpleCombatController.Instance.CurSubController as PinballBattleSubController).Restart(this.InFormationRoleList).Forget();
				return;
			}
			PinballBattleSubController.RequestEnterInst(this.LevelId, this.IsTrailLevel ? new List<int>() : this.InFormationRoleList);
		}

		// Token: 0x0604007F RID: 262271 RVA: 0x00F7D8A3 File Offset: 0x00F7BAA3
		private void OnClickLeaderSkillBtn()
		{
			base.GetItem(8).SetUIActive(true);
		}

		// Token: 0x06040080 RID: 262272 RVA: 0x00F7D8B2 File Offset: 0x00F7BAB2
		private void OnClickLeaderHeadTipsMaskBtn()
		{
			base.GetItem(8).SetUIActive(false);
		}

		// Token: 0x06040081 RID: 262273 RVA: 0x00F7D8C4 File Offset: 0x00F7BAC4
		private void OnClickMonsterBtn()
		{
			int levelId = this.LevelId;
			if (PinballConfig.Instance.GetPinballLevelConfigById(this.LevelId).Value.Type == 4)
			{
				levelId = PinballModel.Instance.ActivityData.GetDailyRandomLevelId();
			}
			PinballController.Instance.OpenMonsterDetailView(levelId).Forget<bool>();
		}

		// Token: 0x06040082 RID: 262274 RVA: 0x00F7D91C File Offset: 0x00F7BB1C
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

		// Token: 0x06040083 RID: 262275 RVA: 0x00F7D974 File Offset: 0x00F7BB74
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

		// Token: 0x06040084 RID: 262276 RVA: 0x00F7DA1A File Offset: 0x00F7BC1A
		private void OnPinballFormationSelectRoleViewConfirm(List<int> roleIdList)
		{
			this.RefreshFormationList(roleIdList);
		}

		// Token: 0x06040085 RID: 262277 RVA: 0x00F7DA24 File Offset: 0x00F7BC24
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

		// Token: 0x06040086 RID: 262278 RVA: 0x00F7DAC0 File Offset: 0x00F7BCC0
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

		// Token: 0x06040087 RID: 262279 RVA: 0x00F7DB88 File Offset: 0x00F7BD88
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

		// Token: 0x06040088 RID: 262280 RVA: 0x00F7DC34 File Offset: 0x00F7BE34
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

		// Token: 0x06040089 RID: 262281 RVA: 0x00F7DD40 File Offset: 0x00F7BF40
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

		// Token: 0x040215F4 RID: 136692
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x040215F5 RID: 136693
		private readonly List<PinballFormationItem> FormationItemList = new List<PinballFormationItem>();

		// Token: 0x040215F6 RID: 136694
		private int LevelId;

		// Token: 0x040215F7 RID: 136695
		private List<int> InFormationRoleList;

		// Token: 0x040215F8 RID: 136696
		private bool IsTrailLevel;

		// Token: 0x040215F9 RID: 136697
		private int CurrentLeadRole;

		// Token: 0x0200C588 RID: 50568
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x0403B9F3 RID: 244211
			FormationItem1,
			// Token: 0x0403B9F4 RID: 244212
			FormationItem2,
			// Token: 0x0403B9F5 RID: 244213
			FormationItem3,
			// Token: 0x0403B9F6 RID: 244214
			StartBtn,
			// Token: 0x0403B9F7 RID: 244215
			LowLevelTipsItem,
			// Token: 0x0403B9F8 RID: 244216
			LowLevelTipsText,
			// Token: 0x0403B9F9 RID: 244217
			LeaderSkillBtn,
			// Token: 0x0403B9FA RID: 244218
			LeaderHeadTexture,
			// Token: 0x0403B9FB RID: 244219
			LeaderHeadTipsItem,
			// Token: 0x0403B9FC RID: 244220
			LeaderHeadTipsMaskBtn,
			// Token: 0x0403B9FD RID: 244221
			LeaderHeadTipsNameText,
			// Token: 0x0403B9FE RID: 244222
			LeaderHeadTipsDesText,
			// Token: 0x0403B9FF RID: 244223
			LevelNameText,
			// Token: 0x0403BA00 RID: 244224
			LevelIconSprite,
			// Token: 0x0403BA01 RID: 244225
			CaptionItem,
			// Token: 0x0403BA02 RID: 244226
			MonsterBtn,
			// Token: 0x0403BA03 RID: 244227
			WarnClassTipsItem
		}
	}
}
