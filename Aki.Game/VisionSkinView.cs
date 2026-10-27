using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020024F5 RID: 9461
[NullableContext(1)]
[Nullable(0)]
public class VisionSkinView : UiViewBase
{
	// Token: 0x06013069 RID: 77929 RVA: 0x004B5EFA File Offset: 0x004B40FA
	public VisionSkinView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0601306A RID: 77930 RVA: 0x004B5F14 File Offset: 0x004B4114
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

	// Token: 0x0601306B RID: 77931 RVA: 0x004B6048 File Offset: 0x004B4248
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

	// Token: 0x0601306C RID: 77932 RVA: 0x004B618C File Offset: 0x004B438C
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

	// Token: 0x0601306D RID: 77933 RVA: 0x004B61FC File Offset: 0x004B43FC
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

	// Token: 0x0601306E RID: 77934 RVA: 0x004B629A File Offset: 0x004B449A
	protected override void OnAddEventListener()
	{
		EventSystem.Instance.Add(EEventName.OnVisionSkinEquip, new Action(this.RefreshItemCurrentEquipment));
	}

	// Token: 0x0601306F RID: 77935 RVA: 0x004B62B8 File Offset: 0x004B44B8
	protected override void OnRemoveEventListener()
	{
		EventSystem.Instance.Remove(EEventName.OnVisionSkinEquip, new Action(this.RefreshItemCurrentEquipment));
	}

	// Token: 0x06013070 RID: 77936 RVA: 0x004B62D6 File Offset: 0x004B44D6
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

	// Token: 0x06013071 RID: 77937 RVA: 0x004B6314 File Offset: 0x004B4514
	private void ShowByUniqueId(int uniqueId)
	{
		int[] phantomList = PhantomBattleModel.Instance.GetMonsterSkinListByMonsterId(uniqueId);
		if (phantomList == null)
		{
			return;
		}
		int selectIndex = 0;
		selectIndex = ((this.CurrentEquipmentSkin != 0) ? phantomList.ToList<int>().IndexOf(this.CurrentEquipmentSkin) : 0);
		if (selectIndex == -1)
		{
			selectIndex = 0;
		}
		LoopScrollView<VisionSkinItem, int> phantomLoopScrollView = this.PhantomLoopScrollView;
		if (phantomLoopScrollView != null)
		{
			phantomLoopScrollView.RefreshByData(phantomList.ToList<int>(), false, delegate
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

	// Token: 0x06013072 RID: 77938 RVA: 0x004B63C0 File Offset: 0x004B45C0
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
		phantomLoopScrollView.RefreshByData(configList.ToList<int>(), false, delegate
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

	// Token: 0x06013073 RID: 77939 RVA: 0x004B6434 File Offset: 0x004B4634
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

	// Token: 0x06013074 RID: 77940 RVA: 0x004B6494 File Offset: 0x004B4694
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

	// Token: 0x06013075 RID: 77941 RVA: 0x004B64DB File Offset: 0x004B46DB
	private void CheckAndCreateVisionHandle()
	{
		if (!UiSceneManager.Instance.HasVisionSkeletalHandle())
		{
			UiSceneManager.Instance.InitVisionSkeletalHandle();
		}
		this.VisionSkeletalHandle = UiSceneManager.Instance.GetVisionSkeletalHandle();
	}

	// Token: 0x06013076 RID: 77942 RVA: 0x004B6504 File Offset: 0x004B4704
	private void OnClickUseSkinBtn()
	{
		PhantomItem? phantomItemById = PhantomBattleConfig.Instance.GetPhantomItemById(this.CurrentItemId);
		PhantomBattleController.Instance.PhantomSkinChangeRequest(this.CurrentUniqueId, (phantomItemById != null && phantomItemById.GetValueOrDefault().ParentMonsterId > 0) ? this.CurrentItemId : 0, true);
		this.PlayMeshEffect();
	}

	// Token: 0x06013077 RID: 77943 RVA: 0x004B6562 File Offset: 0x004B4762
	private void OnClickBackBtn()
	{
		base.CloseMe(null);
	}

	// Token: 0x06013078 RID: 77944 RVA: 0x004B656B File Offset: 0x004B476B
	private void OnClickGetTipsBtn()
	{
		ItemController.Instance.OpenItemTipsByItemId(this.CurrentItemId, true, null);
	}

	// Token: 0x06013079 RID: 77945 RVA: 0x004B657F File Offset: 0x004B477F
	private VisionSkinItem OnCreateItem()
	{
		VisionSkinItem visionSkinItem = new VisionSkinItem();
		visionSkinItem.SetClickToggleEvent(new Action<int, UUIExtendToggle>(this.OnPhantomItemClick));
		visionSkinItem.BindCanToggleExecuteChange(new Func<int, bool>(this.CanToggleChange));
		return visionSkinItem;
	}

	// Token: 0x0601307A RID: 77946 RVA: 0x004B65AC File Offset: 0x004B47AC
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

	// Token: 0x0601307B RID: 77947 RVA: 0x004B66A0 File Offset: 0x004B48A0
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

	// Token: 0x0601307C RID: 77948 RVA: 0x004B6703 File Offset: 0x004B4903
	private void SetUseSkinBtnEnable(bool able)
	{
		UUIButtonComponent button = base.GetButton(4);
		if (button == null)
		{
			return;
		}
		button.SetSelfInteractive(able);
	}

	// Token: 0x0601307D RID: 77949 RVA: 0x004B6717 File Offset: 0x004B4917
	private bool CanToggleChange(int currentItemId)
	{
		return this.CurrentItemId != currentItemId;
	}

	// Token: 0x0601307E RID: 77950 RVA: 0x004B6728 File Offset: 0x004B4928
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
		int num = (this.CurrentEquipmentSkin != 0) ? monsterSkinListByMonsterId.ToList<int>().IndexOf(this.CurrentEquipmentSkin) : 0;
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

	// Token: 0x0601307F RID: 77951 RVA: 0x004B67DE File Offset: 0x004B49DE
	protected override void OnAfterDestroy()
	{
		if (this.OnlyShow)
		{
			UiSceneManager.Instance.DestroyVisionSkeletalHandle();
			return;
		}
		EventSystem.Instance.Emit<bool>(EEventName.VisionSkinViewClose, this.CurrentItemId != this.OriginalItemId);
	}

	// Token: 0x170018C6 RID: 6342
	// (get) Token: 0x06013080 RID: 77952 RVA: 0x004B6814 File Offset: 0x004B4A14
	private bool OnlyShow
	{
		get
		{
			IVisionSkinViewOpenParam currentParam = this.CurrentParam;
			return ((currentParam != null) ? currentParam.ShowItemIdList : null) != null;
		}
	}

	// Token: 0x04008F2E RID: 36654
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x04008F2F RID: 36655
	[Nullable(2)]
	private IVisionSkinViewOpenParam CurrentParam;

	// Token: 0x04008F30 RID: 36656
	private int CurrentUniqueId = -1;

	// Token: 0x04008F31 RID: 36657
	private int CurrentMonsterId = -1;

	// Token: 0x04008F32 RID: 36658
	private int CurrentItemId;

	// Token: 0x04008F33 RID: 36659
	private int OriginalItemId;

	// Token: 0x04008F34 RID: 36660
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private LoopScrollView<VisionSkinItem, int> PhantomLoopScrollView;

	// Token: 0x04008F35 RID: 36661
	[Nullable(2)]
	private VisionSkinItem CurrentPhantom;

	// Token: 0x04008F36 RID: 36662
	[Nullable(2)]
	private SkeletalObserverHandle VisionSkeletalHandle;

	// Token: 0x04008F37 RID: 36663
	[Nullable(2)]
	private UUIExtendToggle CurrentToggle;

	// Token: 0x04008F38 RID: 36664
	private int CurrentEquipmentSkin;

	// Token: 0x02008A86 RID: 35462
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402CFBB RID: 184251
		CaptionItem,
		// Token: 0x0402CFBC RID: 184252
		DefaultBtn,
		// Token: 0x0402CFBD RID: 184253
		DefaultMarkItem,
		// Token: 0x0402CFBE RID: 184254
		DefaultText,
		// Token: 0x0402CFBF RID: 184255
		UseSkinBtn,
		// Token: 0x0402CFC0 RID: 184256
		MonsterNameText,
		// Token: 0x0402CFC1 RID: 184257
		MonsterLoopScrollView,
		// Token: 0x0402CFC2 RID: 184258
		MonsterItem,
		// Token: 0x0402CFC3 RID: 184259
		LockItem,
		// Token: 0x0402CFC4 RID: 184260
		GetTipsBtn
	}
}
