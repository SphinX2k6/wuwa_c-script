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
	// Token: 0x02004B59 RID: 19289
	[NullableContext(1)]
	[Nullable(0)]
	public class TowerDefensePhantomView : UiViewBase
	{
		// Token: 0x06031F19 RID: 204569 RVA: 0x00B96D66 File Offset: 0x00B94F66
		public TowerDefensePhantomView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06031F1A RID: 204570 RVA: 0x00B96D70 File Offset: 0x00B94F70
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

		// Token: 0x06031F1B RID: 204571 RVA: 0x00B96FEC File Offset: 0x00B951EC
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.TowerDefenseOnClickOnePhantom, new Action<int>(this.HandleClickOnePhantom));
			EventSystem.Instance.Add(EEventName.DissolvePrewar, new Action(this.HandleDissolvePrewar));
			EventSystem.Instance.Add(EEventName.TowerDefensePhantomChanged, new Action(this.HandleTowerDefensePhantomChanged));
		}

		// Token: 0x06031F1C RID: 204572 RVA: 0x00B97050 File Offset: 0x00B95250
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.TowerDefenseOnClickOnePhantom, new Action<int>(this.HandleClickOnePhantom));
			EventSystem.Instance.Remove(EEventName.DissolvePrewar, new Action(this.HandleDissolvePrewar));
			EventSystem.Instance.Remove(EEventName.TowerDefensePhantomChanged, new Action(this.HandleTowerDefensePhantomChanged));
		}

		// Token: 0x06031F1D RID: 204573 RVA: 0x00B970B4 File Offset: 0x00B952B4
		private UniTask InitLockItem()
		{
			TowerDefensePhantomView.<InitLockItem>d__8 <InitLockItem>d__;
			<InitLockItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitLockItem>d__.<>4__this = this;
			<InitLockItem>d__.<>1__state = -1;
			<InitLockItem>d__.<>t__builder.Start<TowerDefensePhantomView.<InitLockItem>d__8>(ref <InitLockItem>d__);
			return <InitLockItem>d__.<>t__builder.Task;
		}

		// Token: 0x06031F1E RID: 204574 RVA: 0x00B970F8 File Offset: 0x00B952F8
		private UniTask InitPhantomIconScroll()
		{
			TowerDefensePhantomView.<InitPhantomIconScroll>d__9 <InitPhantomIconScroll>d__;
			<InitPhantomIconScroll>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitPhantomIconScroll>d__.<>4__this = this;
			<InitPhantomIconScroll>d__.<>1__state = -1;
			<InitPhantomIconScroll>d__.<>t__builder.Start<TowerDefensePhantomView.<InitPhantomIconScroll>d__9>(ref <InitPhantomIconScroll>d__);
			return <InitPhantomIconScroll>d__.<>t__builder.Task;
		}

		// Token: 0x06031F1F RID: 204575 RVA: 0x00B9713C File Offset: 0x00B9533C
		protected override UniTask OnBeforeStartAsync()
		{
			TowerDefensePhantomView.<OnBeforeStartAsync>d__10 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<TowerDefensePhantomView.<OnBeforeStartAsync>d__10>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06031F20 RID: 204576 RVA: 0x00B9717F File Offset: 0x00B9537F
		protected override void OnBeforeDestroy()
		{
			this.Args = null;
		}

		// Token: 0x06031F21 RID: 204577 RVA: 0x00B97188 File Offset: 0x00B95388
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

		// Token: 0x06031F22 RID: 204578 RVA: 0x00B971D4 File Offset: 0x00B953D4
		private void RefreshSkillItems()
		{
			List<ITowerDefensePhantomSkillItemData> list = TowerDefenseController.Instance.BuildPhantomSkillLayoutData();
			ITowerDefensePhantomSkillItemData data = (list.Count > 0) ? list[0] : null;
			ITowerDefensePhantomSkillItemData data2 = (list.Count > 1) ? list[list.Count - 1] : null;
			this.RefreshOneSkillItem(10, 11, 12, data);
			this.RefreshOneSkillItem(13, 14, 15, data2);
		}

		// Token: 0x06031F23 RID: 204579 RVA: 0x00B97238 File Offset: 0x00B95438
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

		// Token: 0x06031F24 RID: 204580 RVA: 0x00B972C8 File Offset: 0x00B954C8
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

		// Token: 0x06031F25 RID: 204581 RVA: 0x00B973D4 File Offset: 0x00B955D4
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

		// Token: 0x06031F26 RID: 204582 RVA: 0x00B97470 File Offset: 0x00B95670
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

		// Token: 0x06031F27 RID: 204583 RVA: 0x00B974A7 File Offset: 0x00B956A7
		private void OnClickClose()
		{
			base.CloseMe(null);
		}

		// Token: 0x06031F28 RID: 204584 RVA: 0x00B974B0 File Offset: 0x00B956B0
		private void HandleClickOnePhantom(int id)
		{
			TowerDefenseController.Instance.SetCurrentTowerDefensePhantomIdInUiTemp(id);
			this.RefreshIconScroll(false);
			this.RefreshSkillItems();
			this.RefreshOther();
		}

		// Token: 0x06031F29 RID: 204585 RVA: 0x00B974D4 File Offset: 0x00B956D4
		private void HandleClickConfirmPhantom(int _)
		{
			int roleCfgId = this.Args.RoleCfgId;
			EventSystem.Instance.Emit<int>(EEventName.TowerDefenseSelfPhantomConfirm, roleCfgId);
			base.CloseMe(null);
		}

		// Token: 0x06031F2A RID: 204586 RVA: 0x00B97508 File Offset: 0x00B95708
		private void HandleClickCancelPhantom(int _)
		{
			int roleCfgId = this.Args.RoleCfgId;
			TowerDefenseController.Instance.SetCurrentTowerDefensePhantomIdInUiTemp(0);
			EventSystem.Instance.Emit<int>(EEventName.TowerDefenseSelfPhantomConfirm, roleCfgId);
			base.CloseMe(null);
		}

		// Token: 0x06031F2B RID: 204587 RVA: 0x00B97544 File Offset: 0x00B95744
		private void HandleDissolvePrewar()
		{
			base.CloseMe(null);
		}

		// Token: 0x06031F2C RID: 204588 RVA: 0x00B9754D File Offset: 0x00B9574D
		private void HandleTowerDefensePhantomChanged()
		{
			this.RefreshIconScroll(false);
			this.RefreshOther();
		}

		// Token: 0x0401AA25 RID: 109093
		[Nullable(2)]
		private ITowerDefensePhantomViewArgs Args;

		// Token: 0x0401AA26 RID: 109094
		private ButtonItem ConfirmButtonItem;

		// Token: 0x0401AA27 RID: 109095
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private LoopScrollView<TowerDefencePhantomIconItem, PhantomSmallItemGrid> PhantomIconScroll;

		// Token: 0x0401AA28 RID: 109096
		[Nullable(2)]
		private TowerDefensePhantomLockItem PhantomLockItem;

		// Token: 0x0200ACDE RID: 44254
		[NullableContext(0)]
		private class EComponent
		{
			// Token: 0x0403486A RID: 215146
			public const int CloseButton = 0;

			// Token: 0x0403486B RID: 215147
			public const int PhantomIconScroll = 1;

			// Token: 0x0403486C RID: 215148
			public const int PhantomIconItem = 2;

			// Token: 0x0403486D RID: 215149
			public const int NameText = 3;

			// Token: 0x0403486E RID: 215150
			public const int TypeSprite = 4;

			// Token: 0x0403486F RID: 215151
			public const int TypeText = 5;

			// Token: 0x04034870 RID: 215152
			public const int PhantomSkillLayout = 6;

			// Token: 0x04034871 RID: 215153
			public const int ConfirmButtonItem = 7;

			// Token: 0x04034872 RID: 215154
			public const int PhantomTipsItem = 8;

			// Token: 0x04034873 RID: 215155
			public const int PhantomLockItem = 9;

			// Token: 0x04034874 RID: 215156
			public const int NormalSkillItem = 10;

			// Token: 0x04034875 RID: 215157
			public const int NormalSkillTitleText = 11;

			// Token: 0x04034876 RID: 215158
			public const int NormalSkillDescText = 12;

			// Token: 0x04034877 RID: 215159
			public const int AdvancedSkillItem = 13;

			// Token: 0x04034878 RID: 215160
			public const int AdvancedSkillTitleText = 14;

			// Token: 0x04034879 RID: 215161
			public const int AdvancedSkillDescText = 15;
		}
	}
}
