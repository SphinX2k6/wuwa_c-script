using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02003B01 RID: 15105
	[NullableContext(1)]
	[Nullable(0)]
	public class TowerDefensePhantomView : UiViewBase
	{
		// Token: 0x06026CA8 RID: 158888 RVA: 0x00ADAFA2 File Offset: 0x00AD91A2
		public TowerDefensePhantomView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06026CA9 RID: 158889 RVA: 0x00ADAFAC File Offset: 0x00AD91AC
		protected unsafe override void OnRegisterComponent()
		{
			int num = 16;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUILoopScrollViewComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIVerticalLayout));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickClose));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06026CAA RID: 158890 RVA: 0x00ADB228 File Offset: 0x00AD9428
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.TowerDefenseOnClickOnePhantom, new Action<int>(this.HandleClickOnePhantom));
			EventSystem.Instance.Add(EEventName.DissolvePrewar, new Action(this.HandleDissolvePrewar));
			EventSystem.Instance.Add(EEventName.TowerDefensePhantomChanged, new Action(this.HandleTowerDefensePhantomChanged));
		}

		// Token: 0x06026CAB RID: 158891 RVA: 0x00ADB28C File Offset: 0x00AD948C
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.TowerDefenseOnClickOnePhantom, new Action<int>(this.HandleClickOnePhantom));
			EventSystem.Instance.Remove(EEventName.DissolvePrewar, new Action(this.HandleDissolvePrewar));
			EventSystem.Instance.Remove(EEventName.TowerDefensePhantomChanged, new Action(this.HandleTowerDefensePhantomChanged));
		}

		// Token: 0x06026CAC RID: 158892 RVA: 0x00ADB2F0 File Offset: 0x00AD94F0
		private UniTask InitLockItem()
		{
			TowerDefensePhantomView.<InitLockItem>d__8 <InitLockItem>d__;
			<InitLockItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitLockItem>d__.<>4__this = this;
			<InitLockItem>d__.<>1__state = -1;
			<InitLockItem>d__.<>t__builder.Start<TowerDefensePhantomView.<InitLockItem>d__8>(ref <InitLockItem>d__);
			return <InitLockItem>d__.<>t__builder.Task;
		}

		// Token: 0x06026CAD RID: 158893 RVA: 0x00ADB334 File Offset: 0x00AD9534
		private UniTask InitPhantomIconScroll()
		{
			TowerDefensePhantomView.<InitPhantomIconScroll>d__9 <InitPhantomIconScroll>d__;
			<InitPhantomIconScroll>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitPhantomIconScroll>d__.<>4__this = this;
			<InitPhantomIconScroll>d__.<>1__state = -1;
			<InitPhantomIconScroll>d__.<>t__builder.Start<TowerDefensePhantomView.<InitPhantomIconScroll>d__9>(ref <InitPhantomIconScroll>d__);
			return <InitPhantomIconScroll>d__.<>t__builder.Task;
		}

		// Token: 0x06026CAE RID: 158894 RVA: 0x00ADB378 File Offset: 0x00AD9578
		protected override UniTask OnBeforeStartAsync()
		{
			TowerDefensePhantomView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TowerDefensePhantomView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06026CAF RID: 158895 RVA: 0x00ADB3BB File Offset: 0x00AD95BB
		protected override void OnBeforeDestroy()
		{
			this.Args = null;
		}

		// Token: 0x06026CB0 RID: 158896 RVA: 0x00ADB3C4 File Offset: 0x00AD95C4
		private UniTask RefreshIconScroll(bool isFirstTime)
		{
			TowerDefensePhantomView.<RefreshIconScroll>d__12 <RefreshIconScroll>d__;
			<RefreshIconScroll>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<RefreshIconScroll>d__.<>4__this = this;
			<RefreshIconScroll>d__.isFirstTime = isFirstTime;
			<RefreshIconScroll>d__.<>1__state = -1;
			<RefreshIconScroll>d__.<>t__builder.Start<TowerDefensePhantomView.<RefreshIconScroll>d__12>(ref <RefreshIconScroll>d__);
			return <RefreshIconScroll>d__.<>t__builder.Task;
		}

		// Token: 0x06026CB1 RID: 158897 RVA: 0x00ADB410 File Offset: 0x00AD9610
		private void RefreshSkillItems()
		{
			List<ITowerDefensePhantomSkillItemData> list = TowerDefenseController.Instance.BuildPhantomSkillLayoutData();
			ITowerDefensePhantomSkillItemData data = (list.Count > 0) ? list[0] : null;
			ITowerDefensePhantomSkillItemData data2 = (list.Count > 1) ? list[list.Count - 1] : null;
			this.RefreshOneSkillItem(10, 11, 12, data);
			this.RefreshOneSkillItem(13, 14, 15, data2);
		}

		// Token: 0x06026CB2 RID: 158898 RVA: 0x00ADB474 File Offset: 0x00AD9674
		[NullableContext(2)]
		private void RefreshOneSkillItem(int itemComp, int titleComp, int descComp, ITowerDefensePhantomSkillItemData data)
		{
			UUIItem item = base.GetItem(itemComp);
			if (data == null)
			{
				if (item != null)
				{
					item.SetUIActive(false);
				}
				return;
			}
			if (item != null)
			{
				item.SetUIActive(true);
			}
			UUIText text = base.GetText(titleComp);
			if (StringUtils.IsEmpty(data.SkillTextId))
			{
				if (text != null)
				{
					text.SetUIActive(false);
				}
			}
			else
			{
				if (text != null)
				{
					text.SetUIActive(true);
				}
				LguiUtil.Instance.SetLocalTextNew(text, data.SkillTextId, Array.Empty<object>());
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(descComp), data.DescriptionTextId, data.DescriptionArgs);
		}

		// Token: 0x06026CB3 RID: 158899 RVA: 0x00ADB504 File Offset: 0x00AD9704
		private void RefreshConfirmButton(bool isLocked)
		{
			if (isLocked)
			{
				this.ConfirmButtonItem.SetUiActive(false);
				this.ConfirmButtonItem.SetLocalTextNew("TowerDefence_lock", Array.Empty<object>());
				return;
			}
			if (!TowerDefenseController.Instance.CheckCurrentPhantomIsOccupiedInUi())
			{
				this.ConfirmButtonItem.SetUiActive(true);
				this.ConfirmButtonItem.SetEnableClick(true);
				this.ConfirmButtonItem.SetFunction(new Action<int>(this.HandleClickConfirmPhantom));
				this.ConfirmButtonItem.SetLocalTextNew("TowerDefence_confirm", Array.Empty<object>());
				return;
			}
			if (TowerDefenseController.Instance.CheckSelfPhantomCancelAble(this.Args.RoleCfgId))
			{
				this.ConfirmButtonItem.SetUiActive(true);
				this.ConfirmButtonItem.SetEnableClick(true);
				this.ConfirmButtonItem.SetLocalTextNew("Text_GoDownText_Text", Array.Empty<object>());
				this.ConfirmButtonItem.SetFunction(new Action<int>(this.HandleClickCancelPhantom));
				return;
			}
			this.ConfirmButtonItem.SetUiActive(true);
			this.ConfirmButtonItem.SetEnableClick(false);
			this.ConfirmButtonItem.SetLocalTextNew("PrefabTextItem_266690258_Text", Array.Empty<object>());
		}

		// Token: 0x06026CB4 RID: 158900 RVA: 0x00ADB610 File Offset: 0x00AD9810
		private void RefreshOther()
		{
			ITowerDefensePhantomOtherData towerDefensePhantomOtherData = TowerDefenseController.Instance.BuildPhantomOtherData();
			if (towerDefensePhantomOtherData != null)
			{
				bool isLocked = towerDefensePhantomOtherData.IsLocked;
				this.ConfirmButtonItem.SetUiActive(!isLocked);
				this.RefreshConfirmButton(isLocked);
				this.PhantomLockItem.SetUiActive(isLocked);
				this.SetSpriteByPath(towerDefensePhantomOtherData.TypeIconPath, base.GetSprite(4), false, null, null);
				LguiUtil.Instance.SetLocalTextNew(base.GetText(5), towerDefensePhantomOtherData.TypeTextId, Array.Empty<object>());
				LguiUtil.Instance.SetLocalTextNew(base.GetText(3), towerDefensePhantomOtherData.NameTextId, Array.Empty<object>());
			}
		}

		// Token: 0x06026CB5 RID: 158901 RVA: 0x00ADB6AC File Offset: 0x00AD98AC
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
		{
			if (this.PhantomIconScroll == null)
			{
				return null;
			}
			UUIItem grid = this.PhantomIconScroll.GetGrid(0);
			if (grid == null)
			{
				return null;
			}
			return new UUIItem[]
			{
				grid,
				grid
			};
		}

		// Token: 0x06026CB6 RID: 158902 RVA: 0x00ADB6E3 File Offset: 0x00AD98E3
		private void OnClickClose()
		{
			base.CloseMe(null);
		}

		// Token: 0x06026CB7 RID: 158903 RVA: 0x00ADB6EC File Offset: 0x00AD98EC
		private void HandleClickOnePhantom(int id)
		{
			TowerDefenseController.Instance.SetCurrentTowerDefensePhantomIdInUiTemp(id);
			this.RefreshIconScroll(false);
			this.RefreshSkillItems();
			this.RefreshOther();
		}

		// Token: 0x06026CB8 RID: 158904 RVA: 0x00ADB710 File Offset: 0x00AD9910
		private void HandleClickConfirmPhantom(int _)
		{
			int roleCfgId = this.Args.RoleCfgId;
			EventSystem.Instance.Emit<int>(EEventName.TowerDefenseSelfPhantomConfirm, roleCfgId);
			base.CloseMe(null);
		}

		// Token: 0x06026CB9 RID: 158905 RVA: 0x00ADB744 File Offset: 0x00AD9944
		private void HandleClickCancelPhantom(int _)
		{
			int roleCfgId = this.Args.RoleCfgId;
			TowerDefenseController.Instance.SetCurrentTowerDefensePhantomIdInUiTemp(0);
			EventSystem.Instance.Emit<int>(EEventName.TowerDefenseSelfPhantomConfirm, roleCfgId);
			base.CloseMe(null);
		}

		// Token: 0x06026CBA RID: 158906 RVA: 0x00ADB780 File Offset: 0x00AD9980
		private void HandleDissolvePrewar()
		{
			base.CloseMe(null);
		}

		// Token: 0x06026CBB RID: 158907 RVA: 0x00ADB789 File Offset: 0x00AD9989
		private void HandleTowerDefensePhantomChanged()
		{
			this.RefreshIconScroll(false);
			this.RefreshOther();
		}

		// Token: 0x04015377 RID: 86903
		[Nullable(2)]
		private ITowerDefensePhantomViewArgs Args;

		// Token: 0x04015378 RID: 86904
		private ButtonItem ConfirmButtonItem;

		// Token: 0x04015379 RID: 86905
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private LoopScrollView<TowerDefencePhantomIconItem, PhantomSmallItemGrid> PhantomIconScroll;

		// Token: 0x0401537A RID: 86906
		[Nullable(2)]
		private TowerDefensePhantomLockItem PhantomLockItem;

		// Token: 0x020096FD RID: 38653
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x0402F213 RID: 193043
			public const int CloseButton = 0;

			// Token: 0x0402F214 RID: 193044
			public const int PhantomIconScroll = 1;

			// Token: 0x0402F215 RID: 193045
			public const int PhantomIconItem = 2;

			// Token: 0x0402F216 RID: 193046
			public const int NameText = 3;

			// Token: 0x0402F217 RID: 193047
			public const int TypeSprite = 4;

			// Token: 0x0402F218 RID: 193048
			public const int TypeText = 5;

			// Token: 0x0402F219 RID: 193049
			public const int PhantomSkillLayout = 6;

			// Token: 0x0402F21A RID: 193050
			public const int ConfirmButtonItem = 7;

			// Token: 0x0402F21B RID: 193051
			public const int PhantomTipsItem = 8;

			// Token: 0x0402F21C RID: 193052
			public const int PhantomLockItem = 9;

			// Token: 0x0402F21D RID: 193053
			public const int NormalSkillItem = 10;

			// Token: 0x0402F21E RID: 193054
			public const int NormalSkillTitleText = 11;

			// Token: 0x0402F21F RID: 193055
			public const int NormalSkillDescText = 12;

			// Token: 0x0402F220 RID: 193056
			public const int AdvancedSkillItem = 13;

			// Token: 0x0402F221 RID: 193057
			public const int AdvancedSkillTitleText = 14;

			// Token: 0x0402F222 RID: 193058
			public const int AdvancedSkillDescText = 15;
		}
	}
}
