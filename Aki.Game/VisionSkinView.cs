using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020019DC RID: 6620
[NullableContext(1)]
[Nullable(0)]
public class VisionSkinView : UiViewBase
{
	// Token: 0x06010528 RID: 66856 RVA: 0x004C3BA2 File Offset: 0x004C1DA2
	public VisionSkinView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06010529 RID: 66857 RVA: 0x004C3BBC File Offset: 0x004C1DBC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(5, typeof(UUIText)),
			new ValueTuple<int, Type>(6, typeof(UUILoopScrollViewComponent)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIButtonComponent))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(4, new Action(this.OnClickUseSkinBtn)),
			new ValueTuple<int, Delegate>(9, new Action(this.OnClickGetTipsBtn))
		};
	}

	// Token: 0x0601052A RID: 66858 RVA: 0x004C3CF0 File Offset: 0x004C1EF0
	protected override void OnStart()
	{
		UUIButtonComponent button = base.GetButton(1);
		if (button != null)
		{
			button.RootUIComp.Get().SetUIActive(false);
		}
		base.GetItem(2).SetUIActive(false);
		UUIText text = base.GetText(3);
		if (text != null)
		{
			text.SetUIActive(false);
		}
		this.VisionSkeletalHandle = UiSceneManager.Instance.GetVisionSkeletalHandle();
		this.CaptionItem = new PopupCaptionItem(base.GetItem(0));
		this.CaptionItem.SetCloseCallBack(new Action(this.OnClickBackBtn));
		this.CaptionItem.SetTitleByTextIdAndArgNew("VisionSkinTitleText", Array.Empty<object>());
		this.CaptionItem.SetHelpBtnActive(false);
		this.PhantomLoopScrollView = new LoopScrollView<VisionSkinItem, int>(base.GetLoopScrollViewComponent(6), base.GetItem(7).GetOwner() as AUIBaseActor, new Func<VisionSkinItem>(this.OnCreateItem), false);
		this.CurrentParam = (this.OpenParam as IVisionSkinViewOpenParam);
		IVisionSkinViewOpenParam currentParam = this.CurrentParam;
		if (currentParam != null && currentParam.UniqueId != null)
		{
			this.InitByUniqueId(this.CurrentParam.UniqueId.Value);
			return;
		}
		IVisionSkinViewOpenParam currentParam2 = this.CurrentParam;
		if (((currentParam2 != null) ? currentParam2.ShowItemIdList : null) != null)
		{
			this.InitByItemIdList(this.CurrentParam.ShowItemIdList);
		}
	}

	// Token: 0x0601052B RID: 66859 RVA: 0x004C3E34 File Offset: 0x004C2034
	private void InitByUniqueId(int uniqueId)
	{
		this.CurrentUniqueId = uniqueId;
		PhantomBattleData phantomItemDataByUniqueId = PhantomBattleController.Instance.GetPhantomItemDataByUniqueId(this.CurrentUniqueId);
		if (phantomItemDataByUniqueId == null)
		{
			return;
		}
		this.CurrentMonsterId = phantomItemDataByUniqueId.GetConfig().MonsterId;
		this.CurrentEquipmentSkin = phantomItemDataByUniqueId.SkinId;
		string monsterName = phantomItemDataByUniqueId.GetSkinConfig().MonsterName;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(5), monsterName, Array.Empty<object>());
	}

	// Token: 0x0601052C RID: 66860 RVA: 0x004C3EA4 File Offset: 0x004C20A4
	private void InitByItemIdList(int[] itemIdList)
	{
		PhantomItem? phantomItemById = PhantomBattleConfig.Instance.GetPhantomItemById(itemIdList[0]);
		if (phantomItemById == null)
		{
			return;
		}
		string monsterName = phantomItemById.Value.MonsterName;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(5), monsterName, Array.Empty<object>());
		UUIItem item = base.GetItem(8);
		if (item != null)
		{
			item.SetUIActive(false);
		}
		UUIButtonComponent button = base.GetButton(1);
		if (button != null)
		{
			button.RootUIComp.Get().SetUIActive(false);
		}
		UUIButtonComponent button2 = base.GetButton(4);
		if (button2 == null)
		{
			return;
		}
		button2.RootUIComp.Get().SetUIActive(false);
	}

	// Token: 0x0601052D RID: 66861 RVA: 0x004C3F42 File Offset: 0x004C2142
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnVisionSkinEquip, new Action(this.RefreshItemCurrentEquipment));
	}

	// Token: 0x0601052E RID: 66862 RVA: 0x004C3F60 File Offset: 0x004C2160
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnVisionSkinEquip, new Action(this.RefreshItemCurrentEquipment));
	}

	// Token: 0x0601052F RID: 66863 RVA: 0x004C3F7E File Offset: 0x004C217E
	protected override void OnBeforeShow()
	{
		if (this.CurrentMonsterId > 0)
		{
			this.ShowByUniqueId(this.CurrentMonsterId);
			return;
		}
		IVisionSkinViewOpenParam currentParam = this.CurrentParam;
		if (((currentParam != null) ? currentParam.ShowItemIdList : null) != null)
		{
			this.ShowByItemIdList(this.CurrentParam.ShowItemIdList);
		}
	}

	// Token: 0x06010530 RID: 66864 RVA: 0x004C3FBC File Offset: 0x004C21BC
	private void ShowByUniqueId(int uniqueId)
	{
		int[] phantomList = PhantomBattleModel.Instance.GetMonsterSkinListByMonsterId(uniqueId);
		if (phantomList == null)
		{
			return;
		}
		int selectIndex = 0;
		selectIndex = ((this.CurrentEquipmentSkin != 0) ? Array.IndexOf<int>(phantomList, this.CurrentEquipmentSkin) : 0);
		if (selectIndex == -1)
		{
			selectIndex = 0;
		}
		LoopScrollView<VisionSkinItem, int> phantomLoopScrollView = this.PhantomLoopScrollView;
		if (phantomLoopScrollView != null)
		{
			phantomLoopScrollView.RefreshByData(phantomList, false, delegate
			{
				LoopScrollView<VisionSkinItem, int> phantomLoopScrollView2 = this.PhantomLoopScrollView;
				if (phantomLoopScrollView2 != null)
				{
					phantomLoopScrollView2.SelectGridProxy(selectIndex, false);
				}
				VisionSkinView <>4__this = this;
				LoopScrollView<VisionSkinItem, int> phantomLoopScrollView3 = this.PhantomLoopScrollView;
				<>4__this.CurrentPhantom = ((phantomLoopScrollView3 != null) ? phantomLoopScrollView3.UnsafeGetGridProxy(selectIndex, false) : null);
				VisionSkinView <>4__this2 = this;
				VisionSkinItem currentPhantom = this.CurrentPhantom;
				<>4__this2.CurrentToggle = ((currentPhantom != null) ? currentPhantom.GetItemGridExtendToggle() : null);
				VisionSkinItem currentPhantom2 = this.CurrentPhantom;
				if (currentPhantom2 != null)
				{
					currentPhantom2.SetCurrentEquipmentVisible(true);
				}
				this.CurrentItemId = phantomList[selectIndex];
				this.OriginalItemId = this.CurrentItemId;
			}, false);
		}
		this.SetLockShow(false);
		this.SetUseSkinBtnEnable(false);
	}

	// Token: 0x06010531 RID: 66865 RVA: 0x004C405C File Offset: 0x004C225C
	private void ShowByItemIdList(int[] configList)
	{
		int selectedIndex = Array.IndexOf<int>(configList, this.CurrentItemId);
		if (selectedIndex < 0)
		{
			selectedIndex = 0;
		}
		LoopScrollView<VisionSkinItem, int> phantomLoopScrollView = this.PhantomLoopScrollView;
		if (phantomLoopScrollView == null)
		{
			return;
		}
		phantomLoopScrollView.RefreshByData(configList, false, delegate
		{
			LoopScrollView<VisionSkinItem, int> phantomLoopScrollView2 = this.PhantomLoopScrollView;
			if (phantomLoopScrollView2 != null)
			{
				phantomLoopScrollView2.ScrollToGridIndex(selectedIndex, true);
			}
			LoopScrollView<VisionSkinItem, int> phantomLoopScrollView3 = this.PhantomLoopScrollView;
			if (phantomLoopScrollView3 != null)
			{
				phantomLoopScrollView3.SelectGridProxy(selectedIndex, false);
			}
			LoopScrollView<VisionSkinItem, int> phantomLoopScrollView4 = this.PhantomLoopScrollView;
			UUIExtendToggle uuiextendToggle;
			if (phantomLoopScrollView4 == null)
			{
				uuiextendToggle = null;
			}
			else
			{
				VisionSkinItem visionSkinItem = phantomLoopScrollView4.UnsafeGetGridProxy(selectedIndex, false);
				uuiextendToggle = ((visionSkinItem != null) ? visionSkinItem.GetItemGridExtendToggle() : null);
			}
			UUIExtendToggle toggle = uuiextendToggle;
			this.OnPhantomItemClick(configList[selectedIndex], toggle);
		}, false);
	}

	// Token: 0x06010532 RID: 66866 RVA: 0x004C40C8 File Offset: 0x004C22C8
	private void RefreshMesh(int itemId)
	{
		if (this.CurrentItemId == itemId)
		{
			this.PlayMeshEffect();
			return;
		}
		this.CheckAndCreateVisionHandle();
		IVisionSkinViewOpenParam currentParam = this.CurrentParam;
		bool isChangeLocation = ((currentParam != null) ? currentParam.ShowItemIdList : null) != null;
		PhantomBattleController.Instance.SetMeshShow(itemId, new Action(this.PlayMeshEffect), this.VisionSkeletalHandle, isChangeLocation);
		this.CurrentItemId = itemId;
	}

	// Token: 0x06010533 RID: 66867 RVA: 0x004C4128 File Offset: 0x004C2328
	private void PlayMeshEffect()
	{
		if (this.VisionSkeletalHandle == null)
		{
			return;
		}
		UiModelBase model = this.VisionSkeletalHandle.Model;
		if (model == null)
		{
			return;
		}
		UiModelUtil.Instance.PlayEffectOnRoot(model, "VisionLevelUpEffect");
		UiModelUtil.Instance.SetRenderingMaterial(model, "VisionStepupController");
	}

	// Token: 0x06010534 RID: 66868 RVA: 0x004C416F File Offset: 0x004C236F
	private void CheckAndCreateVisionHandle()
	{
		if (!UiSceneManager.Instance.HasVisionSkeletalHandle())
		{
			UiSceneManager.Instance.InitVisionSkeletalHandle();
		}
		this.VisionSkeletalHandle = UiSceneManager.Instance.GetVisionSkeletalHandle();
	}

	// Token: 0x06010535 RID: 66869 RVA: 0x004C4198 File Offset: 0x004C2398
	private void OnClickUseSkinBtn()
	{
		PhantomItem? phantomItemById = PhantomBattleConfig.Instance.GetPhantomItemById(this.CurrentItemId);
		PhantomBattleController.Instance.PhantomSkinChangeRequest(this.CurrentUniqueId, (phantomItemById != null && phantomItemById.GetValueOrDefault().ParentMonsterId > 0) ? this.CurrentItemId : 0, true);
		this.PlayMeshEffect();
	}

	// Token: 0x06010536 RID: 66870 RVA: 0x004C41F6 File Offset: 0x004C23F6
	private void OnClickBackBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x06010537 RID: 66871 RVA: 0x004C41FF File Offset: 0x004C23FF
	private void OnClickGetTipsBtn()
	{
		ItemController.Instance.OpenItemTipsByItemId(this.CurrentItemId, true, null, false);
	}

	// Token: 0x06010538 RID: 66872 RVA: 0x004C4214 File Offset: 0x004C2414
	private VisionSkinItem OnCreateItem()
	{
		VisionSkinItem visionSkinItem = new VisionSkinItem();
		visionSkinItem.SetClickToggleEvent(new Action<int, UUIExtendToggle>(this.OnPhantomItemClick));
		visionSkinItem.BindCanToggleExecuteChange(new Func<int, bool>(this.CanToggleChange));
		return visionSkinItem;
	}

	// Token: 0x06010539 RID: 66873 RVA: 0x004C4240 File Offset: 0x004C2440
	private void OnPhantomItemClick(int data, UUIExtendToggle toggle)
	{
		UUIExtendToggle currentToggle = this.CurrentToggle;
		if (currentToggle != null)
		{
			currentToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
		}
		this.CurrentToggle = toggle;
		PhantomItem? phantomItemById = PhantomBattleConfig.Instance.GetPhantomItemById(data);
		if (phantomItemById == null)
		{
			return;
		}
		string monsterName = phantomItemById.Value.MonsterName;
		LguiUtil.Instance.SetLocalTextNew(base.GetText(5), monsterName, Array.Empty<object>());
		this.RefreshMesh(data);
		if (this.OnlyShow)
		{
			return;
		}
		int parentMonsterId = phantomItemById.Value.ParentMonsterId;
		this.SetLockShow(phantomItemById.Value.ParentMonsterId > 0 && !PhantomBattleModel.Instance.GetSkinIsUnlock(data));
		if (this.CurrentEquipmentSkin != 0)
		{
			this.SetUseSkinBtnEnable(data != this.CurrentEquipmentSkin);
			return;
		}
		int parentMonsterId2 = phantomItemById.Value.ParentMonsterId;
		this.SetUseSkinBtnEnable(phantomItemById.Value.ParentMonsterId > 0);
	}

	// Token: 0x0601053A RID: 66874 RVA: 0x004C4334 File Offset: 0x004C2534
	private void SetLockShow(bool isLock)
	{
		UUIItem item = base.GetItem(8);
		if (item != null)
		{
			item.SetUIActive(isLock);
		}
		UUIButtonComponent button = base.GetButton(9);
		if (button != null)
		{
			button.RootUIComp.Get().SetUIActive(isLock);
		}
		UUIButtonComponent button2 = base.GetButton(4);
		if (button2 == null)
		{
			return;
		}
		button2.RootUIComp.Get().SetUIActive(!isLock);
	}

	// Token: 0x0601053B RID: 66875 RVA: 0x004C4397 File Offset: 0x004C2597
	private void SetUseSkinBtnEnable(bool able)
	{
		UUIButtonComponent button = base.GetButton(4);
		if (button == null)
		{
			return;
		}
		button.SetSelfInteractive(able);
	}

	// Token: 0x0601053C RID: 66876 RVA: 0x004C43AB File Offset: 0x004C25AB
	private bool CanToggleChange(int currentItemId)
	{
		return this.CurrentItemId != currentItemId;
	}

	// Token: 0x0601053D RID: 66877 RVA: 0x004C43BC File Offset: 0x004C25BC
	private void RefreshItemCurrentEquipment()
	{
		if (this.OnlyShow)
		{
			return;
		}
		int[] monsterSkinListByMonsterId = PhantomBattleModel.Instance.GetMonsterSkinListByMonsterId(this.CurrentMonsterId);
		if (monsterSkinListByMonsterId == null)
		{
			return;
		}
		PhantomBattleData phantomItemDataByUniqueId = PhantomBattleController.Instance.GetPhantomItemDataByUniqueId(this.CurrentUniqueId);
		if (phantomItemDataByUniqueId == null)
		{
			return;
		}
		this.CurrentEquipmentSkin = phantomItemDataByUniqueId.SkinId;
		int num = (this.CurrentEquipmentSkin != 0) ? Array.IndexOf<int>(monsterSkinListByMonsterId, this.CurrentEquipmentSkin) : 0;
		if (num == -1)
		{
			num = 0;
		}
		VisionSkinItem currentPhantom = this.CurrentPhantom;
		if (currentPhantom != null)
		{
			currentPhantom.SetCurrentEquipmentVisible(false);
		}
		LoopScrollView<VisionSkinItem, int> phantomLoopScrollView = this.PhantomLoopScrollView;
		this.CurrentPhantom = ((phantomLoopScrollView != null) ? phantomLoopScrollView.UnsafeGetGridProxy(num, false) : null);
		VisionSkinItem currentPhantom2 = this.CurrentPhantom;
		if (currentPhantom2 != null)
		{
			currentPhantom2.SetCurrentEquipmentVisible(true);
		}
		this.SetUseSkinBtnEnable(false);
	}

	// Token: 0x0601053E RID: 66878 RVA: 0x004C446D File Offset: 0x004C266D
	protected override void OnAfterDestroy()
	{
		if (this.OnlyShow)
		{
			UiSceneManager.Instance.DestroyVisionSkeletalHandle();
			return;
		}
		EventSystem.Instance.Emit<bool>(EEventName.VisionSkinViewClose, this.CurrentItemId != this.OriginalItemId);
	}

	// Token: 0x17001900 RID: 6400
	// (get) Token: 0x0601053F RID: 66879 RVA: 0x004C44A3 File Offset: 0x004C26A3
	private bool OnlyShow
	{
		get
		{
			IVisionSkinViewOpenParam currentParam = this.CurrentParam;
			return ((currentParam != null) ? currentParam.ShowItemIdList : null) != null;
		}
	}

	// Token: 0x04009078 RID: 36984
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x04009079 RID: 36985
	[Nullable(2)]
	private IVisionSkinViewOpenParam CurrentParam;

	// Token: 0x0400907A RID: 36986
	private int CurrentUniqueId = -1;

	// Token: 0x0400907B RID: 36987
	private int CurrentMonsterId = -1;

	// Token: 0x0400907C RID: 36988
	private int CurrentItemId;

	// Token: 0x0400907D RID: 36989
	private int OriginalItemId;

	// Token: 0x0400907E RID: 36990
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private LoopScrollView<VisionSkinItem, int> PhantomLoopScrollView;

	// Token: 0x0400907F RID: 36991
	[Nullable(2)]
	private VisionSkinItem CurrentPhantom;

	// Token: 0x04009080 RID: 36992
	[Nullable(2)]
	private SkeletalObserverHandle VisionSkeletalHandle;

	// Token: 0x04009081 RID: 36993
	[Nullable(2)]
	private UUIExtendToggle CurrentToggle;

	// Token: 0x04009082 RID: 36994
	private int CurrentEquipmentSkin;

	// Token: 0x02007C0E RID: 31758
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x040282D3 RID: 164563
		CaptionItem,
		// Token: 0x040282D4 RID: 164564
		DefaultBtn,
		// Token: 0x040282D5 RID: 164565
		DefaultMarkItem,
		// Token: 0x040282D6 RID: 164566
		DefaultText,
		// Token: 0x040282D7 RID: 164567
		UseSkinBtn,
		// Token: 0x040282D8 RID: 164568
		MonsterNameText,
		// Token: 0x040282D9 RID: 164569
		MonsterLoopScrollView,
		// Token: 0x040282DA RID: 164570
		MonsterItem,
		// Token: 0x040282DB RID: 164571
		LockItem,
		// Token: 0x040282DC RID: 164572
		GetTipsBtn
	}
}
