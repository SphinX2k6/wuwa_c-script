using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Effect;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002487 RID: 9351
[NullableContext(1)]
[Nullable(0)]
public class PhantomInteractSummonView : UiViewBase
{
	// Token: 0x06012C3E RID: 76862 RVA: 0x004A0AD1 File Offset: 0x0049ECD1
	public PhantomInteractSummonView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06012C3F RID: 76863 RVA: 0x004A0AF0 File Offset: 0x0049ECF0
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

	// Token: 0x06012C40 RID: 76864 RVA: 0x004A0C02 File Offset: 0x0049EE02
	private void OnClickedCloseButton()
	{
		base.CloseMe(null);
	}

	// Token: 0x06012C41 RID: 76865 RVA: 0x004A0C0C File Offset: 0x0049EE0C
	protected override UniTask OnBeforeStartAsync()
	{
		PhantomInteractSummonView.<OnBeforeStartAsync>d__15 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<PhantomInteractSummonView.<OnBeforeStartAsync>d__15>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06012C42 RID: 76866 RVA: 0x004A0C50 File Offset: 0x0049EE50
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

	// Token: 0x06012C43 RID: 76867 RVA: 0x004A0C9C File Offset: 0x0049EE9C
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

	// Token: 0x06012C44 RID: 76868 RVA: 0x004A0D00 File Offset: 0x0049EF00
	protected override void OnStart()
	{
		bool uiactive = Info.Instance.IsInTouch();
		base.GetItem(3).SetUIActive(uiactive);
		PhantomInteractModel.Instance.DisableAutoExposureOnViewOpen();
	}

	// Token: 0x06012C45 RID: 76869 RVA: 0x004A0D2F File Offset: 0x0049EF2F
	protected override void OnAddEventListener()
	{
		if (EventSystem.Instance.HasWithTarget<HitInformation, HitContext>(SceneTeam.Local, EEventName.CharBeHitLocal, new Action<HitInformation, HitContext>(this.OnCharBeHit)))
		{
			return;
		}
		EventSystem.Instance.AddWithTarget(SceneTeam.Local, EEventName.CharBeHitLocal, new Action<HitInformation, HitContext>(this.OnCharBeHit));
	}

	// Token: 0x06012C46 RID: 76870 RVA: 0x004A0D6F File Offset: 0x0049EF6F
	protected override void OnRemoveEventListener()
	{
		this.RemoveCharBeHitListener();
	}

	// Token: 0x06012C47 RID: 76871 RVA: 0x004A0D78 File Offset: 0x0049EF78
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

	// Token: 0x06012C48 RID: 76872 RVA: 0x004A0DE4 File Offset: 0x0049EFE4
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

	// Token: 0x06012C49 RID: 76873 RVA: 0x004A0E30 File Offset: 0x0049F030
	protected override void OnAfterDestroy()
	{
		PhantomInteractModel instance = PhantomInteractModel.Instance;
		if (instance == null)
		{
			return;
		}
		instance.ReEnableAutoExposureOnViewClose();
	}

	// Token: 0x06012C4A RID: 76874 RVA: 0x004A0E41 File Offset: 0x0049F041
	public void Refresh(PhantomInteractInfoData viewData)
	{
		this.VisionList.Refresh(viewData.EquippedVisionData.Cast<IPhantomInteractItemData>().ToList<IPhantomInteractItemData>(), false, false);
	}

	// Token: 0x06012C4B RID: 76875 RVA: 0x004A0E60 File Offset: 0x0049F060
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

	// Token: 0x06012C4C RID: 76876 RVA: 0x004A0EB0 File Offset: 0x0049F0B0
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

	// Token: 0x06012C4D RID: 76877 RVA: 0x004A0F48 File Offset: 0x0049F148
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

	// Token: 0x06012C4E RID: 76878 RVA: 0x004A0FD8 File Offset: 0x0049F1D8
	private static void OnClickEditBtn()
	{
		PhantomInteractController.Instance.OpenPhantomVisionEditView(0, true);
	}

	// Token: 0x06012C4F RID: 76879 RVA: 0x004A0FE6 File Offset: 0x0049F1E6
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

	// Token: 0x06012C50 RID: 76880 RVA: 0x004A1023 File Offset: 0x0049F223
	private void OnCharBeHit(HitInformation hitData, HitContext hitContext)
	{
		this.RemoveCharBeHitListener();
		UiManager.Instance.ResetToBattleView(null);
	}

	// Token: 0x06012C51 RID: 76881 RVA: 0x004A1036 File Offset: 0x0049F236
	private void RemoveCharBeHitListener()
	{
		if (!EventSystem.Instance.HasWithTarget<HitInformation, HitContext>(SceneTeam.Local, EEventName.CharBeHitLocal, new Action<HitInformation, HitContext>(this.OnCharBeHit)))
		{
			return;
		}
		EventSystem.Instance.RemoveWithTarget(SceneTeam.Local, EEventName.CharBeHitLocal, new Action<HitInformation, HitContext>(this.OnCharBeHit));
	}

	// Token: 0x06012C52 RID: 76882 RVA: 0x004A1078 File Offset: 0x0049F278
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

	// Token: 0x04008D56 RID: 36182
	private const string POST_FX_PATH = "/Game/Aki/Effect/EffectGroup/Common/DA_Fx_Group_Post_SimpleLight.DA_Fx_Group_Post_SimpleLight";

	// Token: 0x04008D57 RID: 36183
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x04008D58 RID: 36184
	[Nullable(2)]
	private PhantomInteractListPanel VisionList;

	// Token: 0x04008D59 RID: 36185
	[Nullable(2)]
	private PhantomInteractDetailPanelGroup DetailPanelGroup;

	// Token: 0x04008D5A RID: 36186
	private bool ShowDetail;

	// Token: 0x04008D5B RID: 36187
	private readonly PhantomInteractDetailViewModel DetailViewModel = new PhantomInteractDetailViewModel();

	// Token: 0x04008D5C RID: 36188
	[Nullable(2)]
	private UUIItem RedDotItem;

	// Token: 0x04008D5D RID: 36189
	[Nullable(2)]
	private LevelSequencePlayer SeqPlayer;

	// Token: 0x04008D5E RID: 36190
	private int? PostFxHandle;

	// Token: 0x04008D5F RID: 36191
	private int LongPressDetailMonsterId;

	// Token: 0x04008D60 RID: 36192
	private readonly Dictionary<int, int> DisabledEntityHandles = new Dictionary<int, int>();

	// Token: 0x020089FB RID: 35323
	[NullableContext(0)]
	private enum ENode
	{
		// Token: 0x0402CCF3 RID: 183539
		ItemVisionList,
		// Token: 0x0402CCF4 RID: 183540
		ItemCaption,
		// Token: 0x0402CCF5 RID: 183541
		BtnEdit,
		// Token: 0x0402CCF6 RID: 183542
		ItemLongPressTip,
		// Token: 0x0402CCF7 RID: 183543
		TxtLongPressTip,
		// Token: 0x0402CCF8 RID: 183544
		ItemPanelPhantomTip,
		// Token: 0x0402CCF9 RID: 183545
		ItemRedDot,
		// Token: 0x0402CCFA RID: 183546
		BtnBlank
	}

	// Token: 0x020089FC RID: 35324
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x0402CCFB RID: 183547
		[Nullable(0)]
		public static Action <0>__OnClickEditBtn;
	}
}
