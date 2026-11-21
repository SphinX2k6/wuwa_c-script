using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.Module.Kurotato.Data;
using CSharpScript.Game.Module.Kurotato.View.Components;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.RoleSelect
{
	// Token: 0x0200470B RID: 18187
	[NullableContext(1)]
	[Nullable(0)]
	public class KurotatoRoleSelectPanel : UiPanelBase
	{
		// Token: 0x0602DB16 RID: 187158 RVA: 0x00CC6F10 File Offset: 0x00CC5110
		protected unsafe override void OnRegisterComponent()
		{
			int num = 21;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUILoopScrollViewComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(USpineSkeletonAnimationComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUILayoutBase));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(19, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(20, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(10, new Action(this.OnArchiveBtnClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0602DB17 RID: 187159 RVA: 0x00CC7238 File Offset: 0x00CC5438
		protected override UniTask OnBeforeStartAsync()
		{
			KurotatoRoleSelectPanel.<OnBeforeStartAsync>d__15 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<KurotatoRoleSelectPanel.<OnBeforeStartAsync>d__15>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602DB18 RID: 187160 RVA: 0x00CC727B File Offset: 0x00CC547B
		protected override void OnStart()
		{
			this.SeqPlayer = new LevelSequencePlayer(base.GetRootItem());
		}

		// Token: 0x0602DB19 RID: 187161 RVA: 0x00CC7290 File Offset: 0x00CC5490
		protected override void OnBeforeShow()
		{
			this.SeqPlayer.PlayOrReplaySequenceByName("Start", false, null);
		}

		// Token: 0x0602DB1A RID: 187162 RVA: 0x00CC72B7 File Offset: 0x00CC54B7
		protected override void OnBeforeHide()
		{
			this.SeqPlayer.StopPlayingSequence(false, false);
		}

		// Token: 0x0602DB1B RID: 187163 RVA: 0x00CC72C8 File Offset: 0x00CC54C8
		protected override void OnAfterShow()
		{
			bool flag = KurotatoConfig.Instance.GetLevelConfig(this.LevelId).Value.LevelGroup == 3;
			EventSystem.Instance.Emit<string>(EEventName.OnGuideTriggerEvent, flag ? "KurotatoRoleSelectEndless" : "KurotatoRoleSelectTeach");
		}

		// Token: 0x0602DB1C RID: 187164 RVA: 0x00CC7318 File Offset: 0x00CC5518
		private UniTask RefreshView()
		{
			KurotatoRoleSelectPanel.<RefreshView>d__20 <RefreshView>d__;
			<RefreshView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshView>d__.<>4__this = this;
			<RefreshView>d__.<>1__state = -1;
			<RefreshView>d__.<>t__builder.Start<KurotatoRoleSelectPanel.<RefreshView>d__20>(ref <RefreshView>d__);
			return <RefreshView>d__.<>t__builder.Task;
		}

		// Token: 0x0602DB1D RID: 187165 RVA: 0x00CC735C File Offset: 0x00CC555C
		private void RefreshRecordPanel()
		{
			KurotatoRoleData kurotatoRoleData = this.KurotatoActivityData.GetKurotatoRoleData(this.RoleId);
			bool flag = KurotatoConfig.Instance.GetLevelConfig(this.LevelId).Value.LevelGroup == 3 && kurotatoRoleData.HasHistory;
			UUIItem item = base.GetItem(11);
			if (item != null)
			{
				item.SetUIActive(flag);
			}
			if (!flag)
			{
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(19), "PrefabTextItem_2694577864_Text", Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(20), "Kurotato_Settle_TotalKills", Array.Empty<object>());
			UUIText text = base.GetText(12);
			if (text != null)
			{
				text.SetText(kurotatoRoleData.HistoryWave.ToString(), true);
			}
			UUIText text2 = base.GetText(18);
			if (text2 != null)
			{
				text2.SetText(kurotatoRoleData.HistoryKillNum.ToString(), true);
			}
			foreach (KurotatoWaveLevel kurotatoWaveLevel in KurotatoConfig.Instance.GetWaveLevelConfigList())
			{
				List<int> list = new List<int>(kurotatoWaveLevel.WaveRangeIter());
				if (list.Count >= 2 && list[0] <= kurotatoRoleData.HistoryWave && kurotatoRoleData.HistoryWave <= list[1])
				{
					base.SetTextureByPath(kurotatoWaveLevel.Icon, base.GetTexture(13), null, null);
					break;
				}
			}
		}

		// Token: 0x0602DB1E RID: 187166 RVA: 0x00CC74E0 File Offset: 0x00CC56E0
		private IReadOnlyList<int> GetInitWeaponIds(KurotatoRoleData kurotatoRoleData)
		{
			KurotatoLevelCharacter? levelCharacterByRoleIdAndLevelId = KurotatoConfig.Instance.GetLevelCharacterByRoleIdAndLevelId(this.RoleId, this.LevelId);
			if (levelCharacterByRoleIdAndLevelId == null)
			{
				return kurotatoRoleData.InitWeaponIds;
			}
			return new List<int>(levelCharacterByRoleIdAndLevelId.Value.InitWeaponIdsIter());
		}

		// Token: 0x0602DB1F RID: 187167 RVA: 0x00CC7528 File Offset: 0x00CC5728
		private IReadOnlyList<int> GetInitItemIds(KurotatoRoleData kurotatoRoleData)
		{
			KurotatoLevelCharacter? levelCharacterByRoleIdAndLevelId = KurotatoConfig.Instance.GetLevelCharacterByRoleIdAndLevelId(this.RoleId, this.LevelId);
			if (levelCharacterByRoleIdAndLevelId == null)
			{
				return kurotatoRoleData.InitItemIds;
			}
			List<int> list = new List<int>();
			foreach (int num in levelCharacterByRoleIdAndLevelId.Value.InitItemIdsIter())
			{
				KurotatoItem? itemConfigByItemId = KurotatoConfig.Instance.GetItemConfigByItemId(num);
				if (itemConfigByItemId != null && itemConfigByItemId.GetValueOrDefault().Type == 2)
				{
					list.Add(num);
				}
			}
			return list;
		}

		// Token: 0x0602DB20 RID: 187168 RVA: 0x00CC75E0 File Offset: 0x00CC57E0
		private UniTask OnRoleToggleClickCallback(int roleId)
		{
			KurotatoRoleSelectPanel.<OnRoleToggleClickCallback>d__24 <OnRoleToggleClickCallback>d__;
			<OnRoleToggleClickCallback>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnRoleToggleClickCallback>d__.<>4__this = this;
			<OnRoleToggleClickCallback>d__.roleId = roleId;
			<OnRoleToggleClickCallback>d__.<>1__state = -1;
			<OnRoleToggleClickCallback>d__.<>t__builder.Start<KurotatoRoleSelectPanel.<OnRoleToggleClickCallback>d__24>(ref <OnRoleToggleClickCallback>d__);
			return <OnRoleToggleClickCallback>d__.<>t__builder.Task;
		}

		// Token: 0x0602DB21 RID: 187169 RVA: 0x00CC762C File Offset: 0x00CC582C
		private KurotatoRoleGridItem CreateRoleItem()
		{
			KurotatoRoleGridItem kurotatoRoleGridItem = new KurotatoRoleGridItem();
			KurotatoLevel value = KurotatoConfig.Instance.GetLevelConfig(this.LevelId).Value;
			kurotatoRoleGridItem.LimitRoleList = new List<int>(value.CharactersIter());
			kurotatoRoleGridItem.RecommendRoleList = new List<int>(value.RecommendCharactersIter());
			kurotatoRoleGridItem.IsEndlessLevel = (value.LevelGroup == 3);
			kurotatoRoleGridItem.SetToggleClickCallback(delegate(int roleId)
			{
				this.SeqPlayer.PlayOrReplaySequenceByName("Switch", false, null);
				this.OnRoleToggleClickCallback(roleId).Forget();
			});
			return kurotatoRoleGridItem;
		}

		// Token: 0x0602DB22 RID: 187170 RVA: 0x00CC76A0 File Offset: 0x00CC58A0
		private void OnWeaponToggleClickCallback(IKurotatoSmallItemGridData data)
		{
			KurotatoRoleData kurotatoRoleData = this.KurotatoActivityData.GetKurotatoRoleData(this.RoleId);
			IReadOnlyList<int> initWeaponIds = this.GetInitWeaponIds(kurotatoRoleData);
			IReadOnlyList<int> initItemIds = this.GetInitItemIds(kurotatoRoleData);
			List<KurotatoCardTip> list = new List<KurotatoCardTip>();
			foreach (int selectId in initWeaponIds)
			{
				list.Add(new KurotatoCardTip
				{
					CardType = EKurotatoCardType.Weapon,
					SelectId = selectId,
					IsConfigId = new bool?(true)
				});
			}
			List<KurotatoCardTip> list2 = new List<KurotatoCardTip>();
			foreach (int selectId2 in initItemIds)
			{
				list2.Add(new KurotatoCardTip
				{
					CardType = EKurotatoCardType.Item,
					SelectId = selectId2,
					IsConfigId = new bool?(true)
				});
			}
			List<KurotatoCardTip> list3 = new List<KurotatoCardTip>();
			list3.AddRange(list);
			list3.AddRange(list2);
			List<int> list4 = new List<int>();
			list4.AddRange(initWeaponIds);
			list4.AddRange(initItemIds);
			UiManager.Instance.OpenView(EUiViewName.KurotatoPopupWeaponDetailView, new KurotatoPopupItemDetailOpenParam
			{
				Index = list4.FindIndex((int id) => id == data.Id),
				CardData = list3,
				IsOutSide = new bool?(true)
			}, null);
		}

		// Token: 0x0602DB23 RID: 187171 RVA: 0x00CC781C File Offset: 0x00CC5A1C
		private KurotatoWeaponSmallItemGrid CreateWeapon()
		{
			KurotatoWeaponSmallItemGrid item = new KurotatoWeaponSmallItemGrid(false);
			item.BindCallback(delegate(IKurotatoSmallItemGridData data, EToggleState state, int gridIndex)
			{
				if (state != EToggleState.ETT_Checked)
				{
					return;
				}
				if (data.Id != 0)
				{
					this.OnWeaponToggleClickCallback(data);
				}
				item.GetItemGridExtendToggle().SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			});
			return item;
		}

		// Token: 0x0602DB24 RID: 187172 RVA: 0x00CC7860 File Offset: 0x00CC5A60
		private unsafe void OnArchiveBtnClick()
		{
			KurotatoRoleData kurotatoRoleData = this.KurotatoActivityData.GetKurotatoRoleData(this.RoleId);
			if (kurotatoRoleData.ArchivedData == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Kurotato;
				ELogAuthor author = ELogAuthor.CXJ;
				string message = "点击存档按钮时角色无存档数据";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("roleId", this.RoleId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			KurotatoSaveViewOpenParam kurotatoSaveViewOpenParam = new KurotatoSaveViewOpenParam();
			int num = 1;
			List<KurotatoInstInfo> list = new List<KurotatoInstInfo>(num);
			CollectionsMarshal.SetCount<KurotatoInstInfo>(list, num);
			Span<KurotatoInstInfo> span = CollectionsMarshal.AsSpan<KurotatoInstInfo>(list);
			int index = 0;
			*span[index] = kurotatoRoleData.ArchivedData;
			kurotatoSaveViewOpenParam.InstInfos = list;
			kurotatoSaveViewOpenParam.DefaultIndex = 0;
			KurotatoSaveViewOpenParam param = kurotatoSaveViewOpenParam;
			UiManager.Instance.OpenView(EUiViewName.KurotatoTabMainView, param, null);
		}

		// Token: 0x0602DB25 RID: 187173 RVA: 0x00CC790A File Offset: 0x00CC5B0A
		private void OnGotoBtnClick()
		{
			KurotatoController.Instance.RequestEnterInst(this.LevelId, this.RoleId, false);
		}

		// Token: 0x0602DB26 RID: 187174 RVA: 0x00CC7923 File Offset: 0x00CC5B23
		private void OnContinueBtnClick()
		{
			KurotatoController.Instance.RequestEnterInst(this.LevelId, this.RoleId, true);
		}

		// Token: 0x0602DB27 RID: 187175 RVA: 0x00CC793C File Offset: 0x00CC5B3C
		private void OnRestartBtnClick()
		{
			KurotatoController.Instance.RequestEnterInst(this.LevelId, this.RoleId, false);
		}

		// Token: 0x0602DB28 RID: 187176 RVA: 0x00CC7958 File Offset: 0x00CC5B58
		private void OnLockBtnClick()
		{
			int conditionId = this.KurotatoActivityData.GetKurotatoRoleData(this.RoleId).ConditionId;
			int[] groupConditionIds = ConditionConfig.Instance.GetGroupConditionIds(conditionId);
			List<IActivityConditionData> list = new List<IActivityConditionData>();
			foreach (int conditionId2 in groupConditionIds)
			{
				Condition? conditionConfig = ConditionConfig.Instance.GetConditionConfig(conditionId2);
				int accessType = -1;
				if (conditionConfig.Value.AccessId > 0)
				{
					accessType = GetWayConfig.Instance.GetConfigById(conditionConfig.Value.AccessId).Value.SkipName;
				}
				list.Add(new ActivityConditionData
				{
					ConditionId = conditionId2,
					ConditionTextId = conditionConfig.Value.Description,
					IsFinished = LevelGeneralController.Instance.CheckCondition(conditionId2.ToString(), null, false, Array.Empty<object>()),
					AccessId = conditionConfig.Value.AccessId,
					AccessType = accessType
				});
			}
			UiManager.Instance.OpenView(EUiViewName.CommonConditionView, new ConditionGroupData(conditionId, list, "", false), null);
		}

		// Token: 0x040186F7 RID: 100087
		private const int INIT_WEAPON_MAX_NUM = 4;

		// Token: 0x040186F8 RID: 100088
		private CSharpScript.Game.Module.Kurotato.Data.KurotatoActivityData KurotatoActivityData;

		// Token: 0x040186F9 RID: 100089
		private int RoleId;

		// Token: 0x040186FA RID: 100090
		private int LevelId;

		// Token: 0x040186FB RID: 100091
		private List<int> RoleIdList = new List<int>();

		// Token: 0x040186FC RID: 100092
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private LoopScrollView<KurotatoRoleGridItem, int> RoleLoopScrollView;

		// Token: 0x040186FD RID: 100093
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<KurotatoWeaponSmallItemGrid, IKurotatoSmallItemGridData> WeaponLayout;

		// Token: 0x040186FE RID: 100094
		[Nullable(2)]
		private ButtonItem GotoBtn;

		// Token: 0x040186FF RID: 100095
		[Nullable(2)]
		private ButtonItem ContinueBtn;

		// Token: 0x04018700 RID: 100096
		[Nullable(2)]
		private ButtonItem RestartBtn;

		// Token: 0x04018701 RID: 100097
		[Nullable(2)]
		private FunctionalPanelConditionLock LockPanel;

		// Token: 0x04018702 RID: 100098
		private LevelSequencePlayer SeqPlayer;

		// Token: 0x04018703 RID: 100099
		[Nullable(2)]
		public Action OnCloseView;

		// Token: 0x0200A326 RID: 41766
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x04032968 RID: 207208
			LoopScrollRole,
			// Token: 0x04032969 RID: 207209
			ItemRole,
			// Token: 0x0403296A RID: 207210
			SpineRole,
			// Token: 0x0403296B RID: 207211
			TextRoleName,
			// Token: 0x0403296C RID: 207212
			TextRoleDesc,
			// Token: 0x0403296D RID: 207213
			LayoutWeapon,
			// Token: 0x0403296E RID: 207214
			ItemWeapon,
			// Token: 0x0403296F RID: 207215
			ItemGotoBtn,
			// Token: 0x04032970 RID: 207216
			ItemContinueBtn,
			// Token: 0x04032971 RID: 207217
			ItemLockPanel,
			// Token: 0x04032972 RID: 207218
			BtnArchive,
			// Token: 0x04032973 RID: 207219
			ItemRecordPanel,
			// Token: 0x04032974 RID: 207220
			TextWaveNum,
			// Token: 0x04032975 RID: 207221
			TextureWaveLevel,
			// Token: 0x04032976 RID: 207222
			ItemBtnPanel,
			// Token: 0x04032977 RID: 207223
			TextLevelName,
			// Token: 0x04032978 RID: 207224
			ItemLimitRolePanel,
			// Token: 0x04032979 RID: 207225
			ItemRestartBtn,
			// Token: 0x0403297A RID: 207226
			TextKillNum,
			// Token: 0x0403297B RID: 207227
			TextWaveTitle,
			// Token: 0x0403297C RID: 207228
			TextKillTitle
		}
	}
}
