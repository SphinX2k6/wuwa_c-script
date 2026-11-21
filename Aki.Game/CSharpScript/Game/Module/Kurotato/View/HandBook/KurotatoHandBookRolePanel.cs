using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Kurotato.Data;
using CSharpScript.Game.Module.Kurotato.View.Components;
using CSharpScript.Game.Module.Kurotato.View.KurotatoLevelSelect;
using CSharpScript.Game.Module.Kurotato.View.RoleSelect;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Kurotato.View.HandBook
{
	// Token: 0x0200473B RID: 18235
	[NullableContext(1)]
	[Nullable(0)]
	public class KurotatoHandBookRolePanel : UiPanelBase
	{
		// Token: 0x0602DC6D RID: 187501 RVA: 0x00CCF15C File Offset: 0x00CCD35C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 16;
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
			*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602DC6E RID: 187502 RVA: 0x00CCF39C File Offset: 0x00CCD59C
		protected override UniTask OnBeforeStartAsync()
		{
			KurotatoHandBookRolePanel.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<KurotatoHandBookRolePanel.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602DC6F RID: 187503 RVA: 0x00CCF3DF File Offset: 0x00CCD5DF
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x0602DC70 RID: 187504 RVA: 0x00CCF3F2 File Offset: 0x00CCD5F2
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.Clear();
		}

		// Token: 0x0602DC71 RID: 187505 RVA: 0x00CCF404 File Offset: 0x00CCD604
		private UniTask RefreshView()
		{
			KurotatoHandBookRolePanel.<RefreshView>d__15 <RefreshView>d__;
			<RefreshView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshView>d__.<>4__this = this;
			<RefreshView>d__.<>1__state = -1;
			<RefreshView>d__.<>t__builder.Start<KurotatoHandBookRolePanel.<RefreshView>d__15>(ref <RefreshView>d__);
			return <RefreshView>d__.<>t__builder.Task;
		}

		// Token: 0x0602DC72 RID: 187506 RVA: 0x00CCF448 File Offset: 0x00CCD648
		private void RefreshRecordInfo()
		{
			KurotatoRoleData kurotatoRoleData = this.KurotatoActivityData.GetKurotatoRoleData(this.RoleId);
			UUIItem item = base.GetItem(11);
			if (item != null)
			{
				item.SetUIActive(kurotatoRoleData.HasHistory);
			}
			if (!kurotatoRoleData.HasHistory)
			{
				return;
			}
			UUIText text = base.GetText(18);
			if (text != null)
			{
				text.SetText(kurotatoRoleData.HistoryWave.ToString(), true);
			}
			UUIText text2 = base.GetText(12);
			if (text2 != null)
			{
				text2.SetText(kurotatoRoleData.HistoryKillNum.ToString(), true);
			}
			foreach (KurotatoWaveLevel kurotatoWaveLevel in KurotatoConfig.Instance.GetWaveLevelConfigList())
			{
				List<int> list = new List<int>(kurotatoWaveLevel.WaveRangeIter());
				if (list[0] <= kurotatoRoleData.HistoryWave && kurotatoRoleData.HistoryWave <= list[1])
				{
					base.SetTextureByPath(kurotatoWaveLevel.Icon, base.GetTexture(13), null, null);
					break;
				}
			}
		}

		// Token: 0x0602DC73 RID: 187507 RVA: 0x00CCF55C File Offset: 0x00CCD75C
		private UniTask OnRoleToggleClickCallback(int roleId)
		{
			KurotatoHandBookRolePanel.<OnRoleToggleClickCallback>d__17 <OnRoleToggleClickCallback>d__;
			<OnRoleToggleClickCallback>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnRoleToggleClickCallback>d__.<>4__this = this;
			<OnRoleToggleClickCallback>d__.roleId = roleId;
			<OnRoleToggleClickCallback>d__.<>1__state = -1;
			<OnRoleToggleClickCallback>d__.<>t__builder.Start<KurotatoHandBookRolePanel.<OnRoleToggleClickCallback>d__17>(ref <OnRoleToggleClickCallback>d__);
			return <OnRoleToggleClickCallback>d__.<>t__builder.Task;
		}

		// Token: 0x0602DC74 RID: 187508 RVA: 0x00CCF5A7 File Offset: 0x00CCD7A7
		public void RefreshRoleList()
		{
			LoopScrollView<KurotatoRoleGridItem, int> roleLoopScrollView = this.RoleLoopScrollView;
			if (roleLoopScrollView == null)
			{
				return;
			}
			roleLoopScrollView.RefreshAllGridProxies();
		}

		// Token: 0x0602DC75 RID: 187509 RVA: 0x00CCF5B9 File Offset: 0x00CCD7B9
		private KurotatoRoleGridItem CreateRoleItem()
		{
			KurotatoRoleGridItem kurotatoRoleGridItem = new KurotatoRoleGridItem();
			kurotatoRoleGridItem.IsHandBookContext = true;
			kurotatoRoleGridItem.SetToggleClickCallback(delegate(int roleId)
			{
				this.OnRoleToggleClickCallback(roleId).Forget();
			});
			return kurotatoRoleGridItem;
		}

		// Token: 0x0602DC76 RID: 187510 RVA: 0x00CCF5DC File Offset: 0x00CCD7DC
		private void OnWeaponToggleClickCallback(IKurotatoSmallItemGridData data)
		{
			KurotatoRoleData kurotatoRoleData = this.KurotatoActivityData.GetKurotatoRoleData(this.RoleId);
			List<KurotatoCardTip> list = new List<KurotatoCardTip>();
			List<int> initWeaponIds = kurotatoRoleData.InitWeaponIds;
			for (int i = 0; i < initWeaponIds.Count; i++)
			{
				list.Add(new KurotatoCardTip
				{
					CardType = EKurotatoCardType.Weapon,
					SelectId = initWeaponIds[i],
					IsConfigId = new bool?(true)
				});
			}
			List<int> initItemIds = kurotatoRoleData.InitItemIds;
			for (int j = 0; j < initItemIds.Count; j++)
			{
				list.Add(new KurotatoCardTip
				{
					CardType = EKurotatoCardType.Item,
					SelectId = initItemIds[j],
					IsConfigId = new bool?(true)
				});
			}
			List<int> list2 = new List<int>();
			list2.AddRange(kurotatoRoleData.InitWeaponIds);
			list2.AddRange(kurotatoRoleData.InitItemIds);
			UiManager.Instance.OpenView(EUiViewName.KurotatoPopupWeaponDetailView, new KurotatoPopupItemDetailOpenParam
			{
				Index = list2.FindIndex((int id) => id == data.Id),
				CardData = list,
				IsOutSide = new bool?(true)
			}, null);
		}

		// Token: 0x0602DC77 RID: 187511 RVA: 0x00CCF704 File Offset: 0x00CCD904
		private CSharpScript.Game.Module.Kurotato.View.Components.KurotatoWeaponSmallItemGrid CreateItem()
		{
			CSharpScript.Game.Module.Kurotato.View.Components.KurotatoWeaponSmallItemGrid item = new CSharpScript.Game.Module.Kurotato.View.Components.KurotatoWeaponSmallItemGrid(false);
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

		// Token: 0x0602DC78 RID: 187512 RVA: 0x00CCF747 File Offset: 0x00CCD947
		private void OnLockBtnClick()
		{
			this.OpenConditionViewAsync().Forget();
		}

		// Token: 0x0602DC79 RID: 187513 RVA: 0x00CCF754 File Offset: 0x00CCD954
		private UniTask OpenConditionViewAsync()
		{
			KurotatoHandBookRolePanel.<OpenConditionViewAsync>d__23 <OpenConditionViewAsync>d__;
			<OpenConditionViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OpenConditionViewAsync>d__.<>4__this = this;
			<OpenConditionViewAsync>d__.<>1__state = -1;
			<OpenConditionViewAsync>d__.<>t__builder.Start<KurotatoHandBookRolePanel.<OpenConditionViewAsync>d__23>(ref <OpenConditionViewAsync>d__);
			return <OpenConditionViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x04018791 RID: 100241
		private const int INIT_WEAPON_MAX_NUM = 4;

		// Token: 0x04018792 RID: 100242
		private KurotatoActivityData KurotatoActivityData;

		// Token: 0x04018793 RID: 100243
		[Nullable(2)]
		private KurotatoLevelSelectViewData LevelSelectViewData;

		// Token: 0x04018794 RID: 100244
		private int RoleId;

		// Token: 0x04018795 RID: 100245
		private List<int> RoleIdList = new List<int>();

		// Token: 0x04018796 RID: 100246
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private LoopScrollView<KurotatoRoleGridItem, int> RoleLoopScrollView;

		// Token: 0x04018797 RID: 100247
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<CSharpScript.Game.Module.Kurotato.View.Components.KurotatoWeaponSmallItemGrid, IKurotatoSmallItemGridData> WeaponLayout;

		// Token: 0x04018798 RID: 100248
		[Nullable(2)]
		private FunctionalPanelConditionLock LockPanel;

		// Token: 0x04018799 RID: 100249
		[Nullable(2)]
		public Action OnCloseView;

		// Token: 0x0401879A RID: 100250
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0200A37B RID: 41851
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x04032AE6 RID: 207590
			LoopScrollRole,
			// Token: 0x04032AE7 RID: 207591
			ItemRole,
			// Token: 0x04032AE8 RID: 207592
			SpineRole,
			// Token: 0x04032AE9 RID: 207593
			TextRoleName,
			// Token: 0x04032AEA RID: 207594
			TextRoleDesc,
			// Token: 0x04032AEB RID: 207595
			LayoutWeapon,
			// Token: 0x04032AEC RID: 207596
			ItemWeapon,
			// Token: 0x04032AED RID: 207597
			ItemGotoBtn,
			// Token: 0x04032AEE RID: 207598
			ItemContinueBtn,
			// Token: 0x04032AEF RID: 207599
			ItemLockPanel,
			// Token: 0x04032AF0 RID: 207600
			BtnArchive,
			// Token: 0x04032AF1 RID: 207601
			ItemRecordPanel,
			// Token: 0x04032AF2 RID: 207602
			TextKillNum,
			// Token: 0x04032AF3 RID: 207603
			TextureWaveLevel,
			// Token: 0x04032AF4 RID: 207604
			ItemBtnPanel,
			// Token: 0x04032AF5 RID: 207605
			TextWave = 18
		}
	}
}
