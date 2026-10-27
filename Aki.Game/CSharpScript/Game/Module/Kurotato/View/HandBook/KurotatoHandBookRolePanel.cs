using System;
using System.Collections.Generic;
using System.Linq;
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
	// Token: 0x02005764 RID: 22372
	[NullableContext(1)]
	[Nullable(0)]
	public class KurotatoHandBookRolePanel : UiPanelBase
	{
		// Token: 0x06038D5D RID: 232797 RVA: 0x00D806B4 File Offset: 0x00D7E8B4
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

		// Token: 0x06038D5E RID: 232798 RVA: 0x00D808F4 File Offset: 0x00D7EAF4
		protected override UniTask OnBeforeStartAsync()
		{
			KurotatoHandBookRolePanel.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<KurotatoHandBookRolePanel.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06038D5F RID: 232799 RVA: 0x00D80937 File Offset: 0x00D7EB37
		protected override void OnStart()
		{
			this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x06038D60 RID: 232800 RVA: 0x00D8094A File Offset: 0x00D7EB4A
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer levelSequencePlayer = this.LevelSequencePlayer;
			if (levelSequencePlayer == null)
			{
				return;
			}
			levelSequencePlayer.Clear();
		}

		// Token: 0x06038D61 RID: 232801 RVA: 0x00D8095C File Offset: 0x00D7EB5C
		private UniTask RefreshView()
		{
			KurotatoHandBookRolePanel.<RefreshView>d__15 <RefreshView>d__;
			<RefreshView>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshView>d__.<>4__this = this;
			<RefreshView>d__.<>1__state = -1;
			<RefreshView>d__.<>t__builder.Start<KurotatoHandBookRolePanel.<RefreshView>d__15>(ref <RefreshView>d__);
			return <RefreshView>d__.<>t__builder.Task;
		}

		// Token: 0x06038D62 RID: 232802 RVA: 0x00D809A0 File Offset: 0x00D7EBA0
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
				if (kurotatoWaveLevel.WaveRangeIter().ToList<int>()[0] <= kurotatoRoleData.HistoryWave && kurotatoRoleData.HistoryWave <= kurotatoWaveLevel.WaveRangeIter().ToList<int>()[1])
				{
					base.SetTextureByPath(kurotatoWaveLevel.Icon, base.GetTexture(13), null, null);
					break;
				}
			}
		}

		// Token: 0x06038D63 RID: 232803 RVA: 0x00D80AB8 File Offset: 0x00D7ECB8
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

		// Token: 0x06038D64 RID: 232804 RVA: 0x00D80B03 File Offset: 0x00D7ED03
		public void RefreshRoleList()
		{
			LoopScrollView<KurotatoRoleGridItem, int> roleLoopScrollView = this.RoleLoopScrollView;
			if (roleLoopScrollView == null)
			{
				return;
			}
			roleLoopScrollView.RefreshAllGridProxies();
		}

		// Token: 0x06038D65 RID: 232805 RVA: 0x00D80B15 File Offset: 0x00D7ED15
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

		// Token: 0x06038D66 RID: 232806 RVA: 0x00D80B38 File Offset: 0x00D7ED38
		private void OnWeaponToggleClickCallback(IKurotatoSmallItemGridData data)
		{
			KurotatoRoleData kurotatoRoleData = this.KurotatoActivityData.GetKurotatoRoleData(this.RoleId);
			List<KurotatoCardTip> collection = (from id in kurotatoRoleData.InitWeaponIds
			select new KurotatoCardTip
			{
				CardType = EKurotatoCardType.Weapon,
				SelectId = id,
				IsConfigId = new bool?(true)
			}).ToList<KurotatoCardTip>();
			List<KurotatoCardTip> collection2 = (from id in kurotatoRoleData.InitItemIds
			select new KurotatoCardTip
			{
				CardType = EKurotatoCardType.Item,
				SelectId = id,
				IsConfigId = new bool?(true)
			}).ToList<KurotatoCardTip>();
			List<KurotatoCardTip> list = new List<KurotatoCardTip>();
			list.AddRange(collection);
			list.AddRange(collection2);
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

		// Token: 0x06038D67 RID: 232807 RVA: 0x00D80C40 File Offset: 0x00D7EE40
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

		// Token: 0x06038D68 RID: 232808 RVA: 0x00D80C83 File Offset: 0x00D7EE83
		private void OnLockBtnClick()
		{
			this.OpenConditionViewAsync().Forget();
		}

		// Token: 0x06038D69 RID: 232809 RVA: 0x00D80C90 File Offset: 0x00D7EE90
		private UniTask OpenConditionViewAsync()
		{
			KurotatoHandBookRolePanel.<OpenConditionViewAsync>d__23 <OpenConditionViewAsync>d__;
			<OpenConditionViewAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OpenConditionViewAsync>d__.<>4__this = this;
			<OpenConditionViewAsync>d__.<>1__state = -1;
			<OpenConditionViewAsync>d__.<>t__builder.Start<KurotatoHandBookRolePanel.<OpenConditionViewAsync>d__23>(ref <OpenConditionViewAsync>d__);
			return <OpenConditionViewAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0401DCFB RID: 122107
		private const int INIT_WEAPON_MAX_NUM = 4;

		// Token: 0x0401DCFC RID: 122108
		private KurotatoActivityData KurotatoActivityData;

		// Token: 0x0401DCFD RID: 122109
		[Nullable(2)]
		private KurotatoLevelSelectViewData LevelSelectViewData;

		// Token: 0x0401DCFE RID: 122110
		private int RoleId;

		// Token: 0x0401DCFF RID: 122111
		private List<int> RoleIdList = new List<int>();

		// Token: 0x0401DD00 RID: 122112
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private LoopScrollView<KurotatoRoleGridItem, int> RoleLoopScrollView;

		// Token: 0x0401DD01 RID: 122113
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private GenericLayout<CSharpScript.Game.Module.Kurotato.View.Components.KurotatoWeaponSmallItemGrid, IKurotatoSmallItemGridData> WeaponLayout;

		// Token: 0x0401DD02 RID: 122114
		[Nullable(2)]
		private FunctionalPanelConditionLock LockPanel;

		// Token: 0x0401DD03 RID: 122115
		[Nullable(2)]
		public Action OnCloseView;

		// Token: 0x0401DD04 RID: 122116
		[Nullable(2)]
		private LevelSequencePlayer LevelSequencePlayer;

		// Token: 0x0200B95F RID: 47455
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x040380E4 RID: 229604
			LoopScrollRole,
			// Token: 0x040380E5 RID: 229605
			ItemRole,
			// Token: 0x040380E6 RID: 229606
			SpineRole,
			// Token: 0x040380E7 RID: 229607
			TextRoleName,
			// Token: 0x040380E8 RID: 229608
			TextRoleDesc,
			// Token: 0x040380E9 RID: 229609
			LayoutWeapon,
			// Token: 0x040380EA RID: 229610
			ItemWeapon,
			// Token: 0x040380EB RID: 229611
			ItemGotoBtn,
			// Token: 0x040380EC RID: 229612
			ItemContinueBtn,
			// Token: 0x040380ED RID: 229613
			ItemLockPanel,
			// Token: 0x040380EE RID: 229614
			BtnArchive,
			// Token: 0x040380EF RID: 229615
			ItemRecordPanel,
			// Token: 0x040380F0 RID: 229616
			TextKillNum,
			// Token: 0x040380F1 RID: 229617
			TextureWaveLevel,
			// Token: 0x040380F2 RID: 229618
			ItemBtnPanel,
			// Token: 0x040380F3 RID: 229619
			TextWave = 18
		}
	}
}
