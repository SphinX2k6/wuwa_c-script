using System;
using System.Collections.Generic;
using System.Linq;
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
	// Token: 0x02005734 RID: 22324
	[NullableContext(1)]
	[Nullable(0)]
	public class KurotatoRoleSelectPanel : UiPanelBase
	{
		// Token: 0x06038C06 RID: 232454 RVA: 0x00D78864 File Offset: 0x00D76A64
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

		// Token: 0x06038C07 RID: 232455 RVA: 0x00D78B8C File Offset: 0x00D76D8C
		protected override UniTask OnBeforeStartAsync()
		{
			KurotatoRoleSelectPanel.<OnBeforeStartAsync>d__15 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<KurotatoRoleSelectPanel.<OnBeforeStartAsync>d__15>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038C08 RID: 232456 RVA: 0x00D78BCF File Offset: 0x00D76DCF
		protected override void OnStart()
		{
			this.SeqPlayer = new LevelSequencePlayer(base.GetRootItem());
		}

		// Token: 0x06038C09 RID: 232457 RVA: 0x00D78BE4 File Offset: 0x00D76DE4
		protected override void OnBeforeShow()
		{
			this.SeqPlayer.PlayOrReplaySequenceByName("Start", false, null);
		}

		// Token: 0x06038C0A RID: 232458 RVA: 0x00D78C0B File Offset: 0x00D76E0B
		protected override void OnBeforeHide()
		{
			this.SeqPlayer.StopPlayingSequence(false, false);
		}

		// Token: 0x06038C0B RID: 232459 RVA: 0x00D78C1C File Offset: 0x00D76E1C
		protected override void OnAfterShow()
		{
			bool flag = KurotatoConfig.Instance.GetLevelConfig(this.LevelId).Value.LevelGroup == 3;
			EventSystem.Instance.Emit<string>(EEventName.OnGuideTriggerEvent, flag ? "KurotatoRoleSelectEndless" : "KurotatoRoleSelectTeach");
		}

		// Token: 0x06038C0C RID: 232460 RVA: 0x00D78C6C File Offset: 0x00D76E6C
		private UniTask RefreshView()
		{
			KurotatoRoleSelectPanel.<RefreshView>d__20 <RefreshView>d__;
			<RefreshView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshView>d__.<>4__this = this;
			<RefreshView>d__.<>1__state = -1;
			<RefreshView>d__.<>t__builder.Start<KurotatoRoleSelectPanel.<RefreshView>d__20>(ref <RefreshView>d__);
			return <RefreshView>d__.<>t__builder.Task;
		}

		// Token: 0x06038C0D RID: 232461 RVA: 0x00D78CB0 File Offset: 0x00D76EB0
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
				if (kurotatoWaveLevel.WaveRangeIter().ToList<int>()[0] <= kurotatoRoleData.HistoryWave && kurotatoRoleData.HistoryWave <= kurotatoWaveLevel.WaveRangeIter().ToList<int>()[1])
				{
					base.SetTextureByPath(kurotatoWaveLevel.Icon, base.GetTexture(13), null, null);
					break;
				}
			}
		}

		// Token: 0x06038C0E RID: 232462 RVA: 0x00D78E30 File Offset: 0x00D77030
		private IReadOnlyList<int> GetInitWeaponIds(KurotatoRoleData kurotatoRoleData)
		{
			KurotatoLevelCharacter? levelCharacterByRoleIdAndLevelId = KurotatoConfig.Instance.GetLevelCharacterByRoleIdAndLevelId(this.RoleId, this.LevelId);
			if (levelCharacterByRoleIdAndLevelId == null)
			{
				return kurotatoRoleData.InitWeaponIds;
			}
			return levelCharacterByRoleIdAndLevelId.Value.InitWeaponIdsIter().ToList<int>();
		}

		// Token: 0x06038C0F RID: 232463 RVA: 0x00D78E78 File Offset: 0x00D77078
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

		// Token: 0x06038C10 RID: 232464 RVA: 0x00D78F30 File Offset: 0x00D77130
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

		// Token: 0x06038C11 RID: 232465 RVA: 0x00D78F7C File Offset: 0x00D7717C
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

		// Token: 0x06038C12 RID: 232466 RVA: 0x00D78FF0 File Offset: 0x00D771F0
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

		// Token: 0x06038C13 RID: 232467 RVA: 0x00D7916C File Offset: 0x00D7736C
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

		// Token: 0x06038C14 RID: 232468 RVA: 0x00D791B0 File Offset: 0x00D773B0
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

		// Token: 0x06038C15 RID: 232469 RVA: 0x00D7925A File Offset: 0x00D7745A
		private void OnGotoBtnClick()
		{
			KurotatoController.Instance.RequestEnterInst(this.LevelId, this.RoleId, false);
		}

		// Token: 0x06038C16 RID: 232470 RVA: 0x00D79273 File Offset: 0x00D77473
		private void OnContinueBtnClick()
		{
			KurotatoController.Instance.RequestEnterInst(this.LevelId, this.RoleId, true);
		}

		// Token: 0x06038C17 RID: 232471 RVA: 0x00D7928C File Offset: 0x00D7748C
		private void OnRestartBtnClick()
		{
			KurotatoController.Instance.RequestEnterInst(this.LevelId, this.RoleId, false);
		}

		// Token: 0x06038C18 RID: 232472 RVA: 0x00D792A8 File Offset: 0x00D774A8
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

		// Token: 0x0401DC61 RID: 121953
		private const int INIT_WEAPON_MAX_NUM = 4;

		// Token: 0x0401DC62 RID: 121954
		private CSharpScript.Game.Module.Kurotato.Data.KurotatoActivityData KurotatoActivityData;

		// Token: 0x0401DC63 RID: 121955
		private int RoleId;

		// Token: 0x0401DC64 RID: 121956
		private int LevelId;

		// Token: 0x0401DC65 RID: 121957
		private List<int> RoleIdList = new List<int>();

		// Token: 0x0401DC66 RID: 121958
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private LoopScrollView<KurotatoRoleGridItem, int> RoleLoopScrollView;

		// Token: 0x0401DC67 RID: 121959
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<KurotatoWeaponSmallItemGrid, IKurotatoSmallItemGridData> WeaponLayout;

		// Token: 0x0401DC68 RID: 121960
		[Nullable(2)]
		private ButtonItem GotoBtn;

		// Token: 0x0401DC69 RID: 121961
		[Nullable(2)]
		private ButtonItem ContinueBtn;

		// Token: 0x0401DC6A RID: 121962
		[Nullable(2)]
		private ButtonItem RestartBtn;

		// Token: 0x0401DC6B RID: 121963
		[Nullable(2)]
		private FunctionalPanelConditionLock LockPanel;

		// Token: 0x0401DC6C RID: 121964
		private LevelSequencePlayer SeqPlayer;

		// Token: 0x0401DC6D RID: 121965
		[Nullable(2)]
		public Action OnCloseView;

		// Token: 0x0200B905 RID: 47365
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x04037F58 RID: 229208
			LoopScrollRole,
			// Token: 0x04037F59 RID: 229209
			ItemRole,
			// Token: 0x04037F5A RID: 229210
			SpineRole,
			// Token: 0x04037F5B RID: 229211
			TextRoleName,
			// Token: 0x04037F5C RID: 229212
			TextRoleDesc,
			// Token: 0x04037F5D RID: 229213
			LayoutWeapon,
			// Token: 0x04037F5E RID: 229214
			ItemWeapon,
			// Token: 0x04037F5F RID: 229215
			ItemGotoBtn,
			// Token: 0x04037F60 RID: 229216
			ItemContinueBtn,
			// Token: 0x04037F61 RID: 229217
			ItemLockPanel,
			// Token: 0x04037F62 RID: 229218
			BtnArchive,
			// Token: 0x04037F63 RID: 229219
			ItemRecordPanel,
			// Token: 0x04037F64 RID: 229220
			TextWaveNum,
			// Token: 0x04037F65 RID: 229221
			TextureWaveLevel,
			// Token: 0x04037F66 RID: 229222
			ItemBtnPanel,
			// Token: 0x04037F67 RID: 229223
			TextLevelName,
			// Token: 0x04037F68 RID: 229224
			ItemLimitRolePanel,
			// Token: 0x04037F69 RID: 229225
			ItemRestartBtn,
			// Token: 0x04037F6A RID: 229226
			TextKillNum,
			// Token: 0x04037F6B RID: 229227
			TextWaveTitle,
			// Token: 0x04037F6C RID: 229228
			TextKillTitle
		}
	}
}
