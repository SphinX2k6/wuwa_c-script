using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Effect;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200196C RID: 6508
[NullableContext(1)]
[Nullable(0)]
public class PhantomInteractSummonView : UiViewBase
{
	// Token: 0x060100F5 RID: 65781 RVA: 0x004AE229 File Offset: 0x004AC429
	public PhantomInteractSummonView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060100F6 RID: 65782 RVA: 0x004AE248 File Offset: 0x004AC448
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIButtonComponent))
		};
		List<ValueTuple<int, Delegate>> list = new List<ValueTuple<int, Delegate>>();
		int item = 2;
		Action item2;
		if ((item2 = PhantomInteractSummonView.<>O.<0>__OnClickEditBtn) == null)
		{
			item2 = (PhantomInteractSummonView.<>O.<0>__OnClickEditBtn = new Action(PhantomInteractSummonView.OnClickEditBtn));
		}
		list.Add(new ValueTuple<int, Delegate>(item, item2));
		list.Add(new ValueTuple<int, Delegate>(7, new Action(this.OnClickBlank)));
		this.BtnBindInfo = list;
	}

	// Token: 0x060100F7 RID: 65783 RVA: 0x004AE35A File Offset: 0x004AC55A
	private void OnClickedCloseButton()
	{
		base.CloseMe(null);
	}

	// Token: 0x060100F8 RID: 65784 RVA: 0x004AE364 File Offset: 0x004AC564
	protected override UniTask OnBeforeStartAsync()
	{
		PhantomInteractSummonView.<OnBeforeStartAsync>d__15 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomInteractSummonView.<OnBeforeStartAsync>d__15>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x060100F9 RID: 65785 RVA: 0x004AE3A8 File Offset: 0x004AC5A8
	private UniTask PreloadSceneEffect(string effectPath)
	{
		PhantomInteractSummonView.<PreloadSceneEffect>d__16 <PreloadSceneEffect>d__;
		<PreloadSceneEffect>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PreloadSceneEffect>d__.<>4__this = this;
		<PreloadSceneEffect>d__.effectPath = effectPath;
		<PreloadSceneEffect>d__.<>1__state = -1;
		<PreloadSceneEffect>d__.<>t__builder.Start<PhantomInteractSummonView.<PreloadSceneEffect>d__16>(ref <PreloadSceneEffect>d__);
		return <PreloadSceneEffect>d__.<>t__builder.Task;
	}

	// Token: 0x060100FA RID: 65786 RVA: 0x004AE3F4 File Offset: 0x004AC5F4
	protected override void OnBeforeDestroy()
	{
		LevelSequencePlayer seqPlayer = this.SeqPlayer;
		if (seqPlayer != null)
		{
			seqPlayer.Clear();
		}
		this.SeqPlayer = null;
		if (this.PostFxHandle != null)
		{
			EffectSystem.Instance.StopEffectById(this.PostFxHandle.Value, "PhantomInteractSummonView_Destroy", true, null);
			this.PostFxHandle = null;
		}
	}

	// Token: 0x060100FB RID: 65787 RVA: 0x004AE458 File Offset: 0x004AC658
	protected override void OnStart()
	{
		bool uiactive = Info.Instance.IsInTouch();
		base.GetItem(3).SetUIActive(uiactive);
		PhantomInteractModel.Instance.DisableAutoExposureOnViewOpen();
	}

	// Token: 0x060100FC RID: 65788 RVA: 0x004AE487 File Offset: 0x004AC687
	protected override void OnAddEventListener()
	{
		if (EventSystem.Instance.HasWithTarget<HitInformation, HitContext>(SceneTeam.Local, EEventName.CharBeHitLocal, new Action<HitInformation, HitContext>(this.OnCharBeHit)))
		{
			return;
		}
		EventSystem.Instance.AddWithTarget(SceneTeam.Local, EEventName.CharBeHitLocal, new Action<HitInformation, HitContext>(this.OnCharBeHit));
	}

	// Token: 0x060100FD RID: 65789 RVA: 0x004AE4C7 File Offset: 0x004AC6C7
	protected override void OnRemoveEventListener()
	{
		this.RemoveCharBeHitListener();
	}

	// Token: 0x060100FE RID: 65790 RVA: 0x004AE4D0 File Offset: 0x004AC6D0
	protected override void OnBeforeShow()
	{
		PhantomInteractModel instance = PhantomInteractModel.Instance;
		this.Refresh(instance.InteractInfoData);
		PhantomInteractDetailPanelGroup detailPanelGroup = this.DetailPanelGroup;
		if (detailPanelGroup != null)
		{
			detailPanelGroup.RefreshDetailPanel(false, null);
		}
		PhantomInteractListPanel visionList = this.VisionList;
		if (visionList != null)
		{
			visionList.SetSelectedItem(-1);
		}
		if (this.RedDotItem != null)
		{
			RedDotController.Instance.BindRedDot(ERedDotName.RedDotPhantomInteractEditEntry, this.RedDotItem, null, 0);
		}
		this.SetOtherTeamEntitiesEnable(false);
	}

	// Token: 0x060100FF RID: 65791 RVA: 0x004AE53C File Offset: 0x004AC73C
	protected override void OnAfterHide()
	{
		PhantomInteractDetailPanelGroup detailPanelGroup = this.DetailPanelGroup;
		if (detailPanelGroup != null)
		{
			detailPanelGroup.RefreshDetailPanel(false, null);
		}
		this.ShowDetail = false;
		if (this.RedDotItem != null)
		{
			RedDotController.Instance.UnBindGivenUi(ERedDotName.RedDotPhantomInteractEditEntry, this.RedDotItem, 0);
		}
		this.SetOtherTeamEntitiesEnable(true);
	}

	// Token: 0x06010100 RID: 65792 RVA: 0x004AE588 File Offset: 0x004AC788
	protected override void OnAfterDestroy()
	{
		PhantomInteractModel instance = PhantomInteractModel.Instance;
		if (instance == null)
		{
			return;
		}
		instance.ReEnableAutoExposureOnViewClose();
	}

	// Token: 0x06010101 RID: 65793 RVA: 0x004AE599 File Offset: 0x004AC799
	public void Refresh(PhantomInteractInfoData viewData)
	{
		this.VisionList.Refresh(new List<IPhantomInteractItemData>(viewData.EquippedVisionData), false, false);
	}

	// Token: 0x06010102 RID: 65794 RVA: 0x004AE5B4 File Offset: 0x004AC7B4
	private void OnListItemClick(IPhantomInteractItemData itemData)
	{
		this.VisionList.SetSelectedItem(itemData.ItemIndex);
		if (itemData.MonsterId > 0)
		{
			PhantomInteractController.Instance.BeginVisionSkill(itemData.MonsterId);
			base.CloseMe(null);
			return;
		}
		PhantomInteractController.Instance.OpenPhantomVisionEditView(itemData.ItemIndex, true);
	}

	// Token: 0x06010103 RID: 65795 RVA: 0x004AE604 File Offset: 0x004AC804
	private void OnListItemLongPress(IPhantomInteractItemData itemData, bool isHover)
	{
		if (!isHover)
		{
			return;
		}
		if (this.ShowDetail && this.LongPressDetailMonsterId == itemData.MonsterId)
		{
			return;
		}
		PhantomInteractEditViewModel editViewModel = PhantomInteractModel.Instance.EditViewModel;
		IPhantomInteractGridViewModel gridViewModel = null;
		PhantomInteractEditGridViewModel phantomInteractEditGridViewModel;
		if (editViewModel.GridViewModelMap.TryGetValue(itemData.MonsterId, out phantomInteractEditGridViewModel))
		{
			gridViewModel = phantomInteractEditGridViewModel;
		}
		PhantomInteractListPanel visionList = this.VisionList;
		if (visionList != null)
		{
			visionList.SetSelectedItem(itemData.ItemIndex);
		}
		this.DetailViewModel.RefreshData(gridViewModel);
		PhantomInteractDetailPanelGroup detailPanelGroup = this.DetailPanelGroup;
		if (detailPanelGroup != null)
		{
			detailPanelGroup.RefreshDetailPanel(true, this.DetailViewModel);
		}
		this.LongPressDetailMonsterId = itemData.MonsterId;
		this.ShowDetail = true;
	}

	// Token: 0x06010104 RID: 65796 RVA: 0x004AE69C File Offset: 0x004AC89C
	private void OnListItemHover(IPhantomInteractItemData itemData, bool isHover)
	{
		bool flag = isHover && ((itemData != null) ? itemData.MonsterId : 0) > 0;
		if (flag && !this.ShowDetail)
		{
			PhantomInteractEditViewModel editViewModel = PhantomInteractModel.Instance.EditViewModel;
			IPhantomInteractGridViewModel gridViewModel = null;
			PhantomInteractEditGridViewModel phantomInteractEditGridViewModel;
			if (editViewModel.GridViewModelMap.TryGetValue(itemData.MonsterId, out phantomInteractEditGridViewModel))
			{
				gridViewModel = phantomInteractEditGridViewModel;
			}
			this.DetailViewModel.RefreshData(gridViewModel);
			PhantomInteractDetailPanelGroup detailPanelGroup = this.DetailPanelGroup;
			if (detailPanelGroup != null)
			{
				detailPanelGroup.RefreshDetailPanel(true, this.DetailViewModel);
			}
		}
		else
		{
			PhantomInteractDetailPanelGroup detailPanelGroup2 = this.DetailPanelGroup;
			if (detailPanelGroup2 != null)
			{
				detailPanelGroup2.RefreshDetailPanel(false, null);
			}
		}
		this.ShowDetail = flag;
	}

	// Token: 0x06010105 RID: 65797 RVA: 0x004AE72C File Offset: 0x004AC92C
	private static void OnClickEditBtn()
	{
		PhantomInteractController.Instance.OpenPhantomVisionEditView(0, true);
	}

	// Token: 0x06010106 RID: 65798 RVA: 0x004AE73A File Offset: 0x004AC93A
	private void OnClickBlank()
	{
		if (!this.ShowDetail)
		{
			base.CloseMe(null);
			return;
		}
		this.ShowDetail = false;
		PhantomInteractDetailPanelGroup detailPanelGroup = this.DetailPanelGroup;
		if (detailPanelGroup != null)
		{
			detailPanelGroup.RefreshDetailPanel(false, null);
		}
		PhantomInteractListPanel visionList = this.VisionList;
		if (visionList == null)
		{
			return;
		}
		visionList.SetSelectedItem(-1);
	}

	// Token: 0x06010107 RID: 65799 RVA: 0x004AE777 File Offset: 0x004AC977
	private void OnCharBeHit(HitInformation hitData, HitContext hitContext)
	{
		this.RemoveCharBeHitListener();
		UiManager.Instance.ResetToBattleView(null);
	}

	// Token: 0x06010108 RID: 65800 RVA: 0x004AE78A File Offset: 0x004AC98A
	private void RemoveCharBeHitListener()
	{
		if (!EventSystem.Instance.HasWithTarget<HitInformation, HitContext>(SceneTeam.Local, EEventName.CharBeHitLocal, new Action<HitInformation, HitContext>(this.OnCharBeHit)))
		{
			return;
		}
		EventSystem.Instance.RemoveWithTarget(SceneTeam.Local, EEventName.CharBeHitLocal, new Action<HitInformation, HitContext>(this.OnCharBeHit));
	}

	// Token: 0x06010109 RID: 65801 RVA: 0x004AE7CC File Offset: 0x004AC9CC
	private void SetOtherTeamEntitiesEnable(bool isEnable)
	{
		foreach (EntityHandle entityHandle in SceneTeamModel.Instance.GetTeamEntities(false))
		{
			Entity entity = entityHandle.Entity;
			if (!(!entity) && !entity.GetComponent<CharacterActorComponent>().IsAutonomousProxy)
			{
				if (isEnable)
				{
					int handle;
					if (this.DisabledEntityHandles.TryGetValue(entity.Id, out handle))
					{
						entity.Enable(handle, "PhantomInteractSummonView_Show");
						this.DisabledEntityHandles.Remove(entity.Id);
					}
				}
				else
				{
					int value = entity.Disable("PhantomInteractSummonView_Show");
					this.DisabledEntityHandles[entity.Id] = value;
				}
			}
		}
		if (isEnable)
		{
			this.DisabledEntityHandles.Clear();
		}
	}

	// Token: 0x04008E9D RID: 36509
	private const string POST_FX_PATH = "/Game/Aki/Effect/EffectGroup/Common/DA_Fx_Group_Post_SimpleLight.DA_Fx_Group_Post_SimpleLight";

	// Token: 0x04008E9E RID: 36510
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x04008E9F RID: 36511
	[Nullable(2)]
	private PhantomInteractListPanel VisionList;

	// Token: 0x04008EA0 RID: 36512
	[Nullable(2)]
	private PhantomInteractDetailPanelGroup DetailPanelGroup;

	// Token: 0x04008EA1 RID: 36513
	private bool ShowDetail;

	// Token: 0x04008EA2 RID: 36514
	private readonly PhantomInteractDetailViewModel DetailViewModel = new PhantomInteractDetailViewModel();

	// Token: 0x04008EA3 RID: 36515
	[Nullable(2)]
	private UUIItem RedDotItem;

	// Token: 0x04008EA4 RID: 36516
	[Nullable(2)]
	private LevelSequencePlayer SeqPlayer;

	// Token: 0x04008EA5 RID: 36517
	private int? PostFxHandle;

	// Token: 0x04008EA6 RID: 36518
	private int LongPressDetailMonsterId;

	// Token: 0x04008EA7 RID: 36519
	private readonly Dictionary<int, int> DisabledEntityHandles = new Dictionary<int, int>();

	// Token: 0x02007B82 RID: 31618
	[NullableContext(0)]
	private enum ENode
	{
		// Token: 0x04028009 RID: 163849
		ItemVisionList,
		// Token: 0x0402800A RID: 163850
		ItemCaption,
		// Token: 0x0402800B RID: 163851
		BtnEdit,
		// Token: 0x0402800C RID: 163852
		ItemLongPressTip,
		// Token: 0x0402800D RID: 163853
		TxtLongPressTip,
		// Token: 0x0402800E RID: 163854
		ItemPanelPhantomTip,
		// Token: 0x0402800F RID: 163855
		ItemRedDot,
		// Token: 0x04028010 RID: 163856
		BtnBlank
	}

	// Token: 0x02007B83 RID: 31619
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x04028011 RID: 163857
		[Nullable(0)]
		public static Action <0>__OnClickEditBtn;
	}
}
