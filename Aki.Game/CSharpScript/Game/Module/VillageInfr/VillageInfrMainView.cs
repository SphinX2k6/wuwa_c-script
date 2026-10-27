using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.VillageInfr
{
	// Token: 0x0200487D RID: 18557
	[NullableContext(1)]
	[Nullable(0)]
	public class VillageInfrMainView : UiViewBase
	{
		// Token: 0x060308CB RID: 198859 RVA: 0x00B466EC File Offset: 0x00B448EC
		public VillageInfrMainView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x060308CC RID: 198860 RVA: 0x00B46760 File Offset: 0x00B44960
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(8, typeof(UUIText)),
				new ValueTuple<int, Type>(9, typeof(UUIItem)),
				new ValueTuple<int, Type>(10, typeof(UUIItem)),
				new ValueTuple<int, Type>(11, typeof(UUIButtonComponent))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(7, new Action(this.OnClickBtnReward)),
				new ValueTuple<int, Delegate>(11, new Action(this.OnClickBtnCloseMask))
			};
		}

		// Token: 0x060308CD RID: 198861 RVA: 0x00B468BF File Offset: 0x00B44ABF
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.VillageInfrTreeDataUpdate, new Action(this.OnTreeDataUpdate));
			EventSystem.Instance.Add(EEventName.VillageInfrActivityTaskDataUpdate, new Action(this.OnTaskDataUpdate));
		}

		// Token: 0x060308CE RID: 198862 RVA: 0x00B468F9 File Offset: 0x00B44AF9
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.VillageInfrTreeDataUpdate, new Action(this.OnTreeDataUpdate));
			EventSystem.Instance.Remove(EEventName.VillageInfrActivityTaskDataUpdate, new Action(this.OnTaskDataUpdate));
		}

		// Token: 0x060308CF RID: 198863 RVA: 0x00B46934 File Offset: 0x00B44B34
		protected override UniTask OnBeforeStartAsync()
		{
			VillageInfrMainView.<OnBeforeStartAsync>d__19 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<VillageInfrMainView.<OnBeforeStartAsync>d__19>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060308D0 RID: 198864 RVA: 0x00B46978 File Offset: 0x00B44B78
		private void SetOpenParam()
		{
			if (this.OpenParam != null)
			{
				IVillageInfrMainParam villageInfrMainParam = this.OpenParam as IVillageInfrMainParam;
				EVillageInfrSelectType? evillageInfrSelectType;
				if (villageInfrMainParam == null)
				{
					evillageInfrSelectType = null;
				}
				else
				{
					IVillageInfrBuildFinishTipParam buildFinishParam = villageInfrMainParam.BuildFinishParam;
					evillageInfrSelectType = ((buildFinishParam != null) ? new EVillageInfrSelectType?(buildFinishParam.SelectType) : null);
				}
				EVillageInfrSelectType? evillageInfrSelectType2 = evillageInfrSelectType;
				this.FinishType = evillageInfrSelectType2.GetValueOrDefault();
				int? num;
				if (villageInfrMainParam == null)
				{
					num = null;
				}
				else
				{
					IVillageInfrBuildFinishTipParam buildFinishParam2 = villageInfrMainParam.BuildFinishParam;
					num = ((buildFinishParam2 != null) ? new int?(buildFinishParam2.SelectId) : null);
				}
				int? num2 = num;
				this.FinishId = num2.GetValueOrDefault();
			}
		}

		// Token: 0x060308D1 RID: 198865 RVA: 0x00B46A14 File Offset: 0x00B44C14
		private UniTask CreateCaption()
		{
			VillageInfrMainView.<CreateCaption>d__21 <CreateCaption>d__;
			<CreateCaption>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateCaption>d__.<>4__this = this;
			<CreateCaption>d__.<>1__state = -1;
			<CreateCaption>d__.<>t__builder.Start<VillageInfrMainView.<CreateCaption>d__21>(ref <CreateCaption>d__);
			return <CreateCaption>d__.<>t__builder.Task;
		}

		// Token: 0x060308D2 RID: 198866 RVA: 0x00B46A58 File Offset: 0x00B44C58
		private UniTask CreateTreeItems()
		{
			VillageInfrMainView.<CreateTreeItems>d__22 <CreateTreeItems>d__;
			<CreateTreeItems>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateTreeItems>d__.<>4__this = this;
			<CreateTreeItems>d__.<>1__state = -1;
			<CreateTreeItems>d__.<>t__builder.Start<VillageInfrMainView.<CreateTreeItems>d__22>(ref <CreateTreeItems>d__);
			return <CreateTreeItems>d__.<>t__builder.Task;
		}

		// Token: 0x060308D3 RID: 198867 RVA: 0x00B46A9C File Offset: 0x00B44C9C
		private UniTask CreateVillageItem()
		{
			VillageInfrMainView.<CreateVillageItem>d__23 <CreateVillageItem>d__;
			<CreateVillageItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateVillageItem>d__.<>4__this = this;
			<CreateVillageItem>d__.<>1__state = -1;
			<CreateVillageItem>d__.<>t__builder.Start<VillageInfrMainView.<CreateVillageItem>d__23>(ref <CreateVillageItem>d__);
			return <CreateVillageItem>d__.<>t__builder.Task;
		}

		// Token: 0x060308D4 RID: 198868 RVA: 0x00B46ADF File Offset: 0x00B44CDF
		protected override void OnStart()
		{
			this.RefreshBtnVisible();
			this.RefreshSequence();
			this.RefreshPanelEffect();
			this.InitPosTweener();
			RedDotController.Instance.BindRedDot(ERedDotName.VillageInfrTask, base.GetItem(9), null, 0);
		}

		// Token: 0x060308D5 RID: 198869 RVA: 0x00B46B14 File Offset: 0x00B44D14
		protected override void OnBeforeShow()
		{
			this.RefreshTreeItems();
			this.RefreshVillageItem();
			this.RefreshBtnReward();
			if (this.FinishType == EVillageInfrSelectType.Tree)
			{
				VillageInfrTreeItem villageInfrTreeItem = null;
				foreach (VillageInfrTreeItem villageInfrTreeItem2 in this.TreeList)
				{
					if (villageInfrTreeItem2.Id == this.FinishId)
					{
						villageInfrTreeItem = villageInfrTreeItem2;
						break;
					}
				}
				bool flag = Array.IndexOf<int>(VillageInfrDefine.villageInfrNeedMoveTreeId, this.SelectedId) >= 0;
				if (villageInfrTreeItem != null)
				{
					villageInfrTreeItem.PlayLevelSequenceByName(flag ? "GetR" : "GetL");
				}
			}
		}

		// Token: 0x060308D6 RID: 198870 RVA: 0x00B46BC0 File Offset: 0x00B44DC0
		private void RefreshSequence()
		{
			this.SeqPlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x060308D7 RID: 198871 RVA: 0x00B46BD4 File Offset: 0x00B44DD4
		private void RefreshPanelEffect()
		{
			IEnumerable<InfrV2TreeBuild> infrTreeBuildAll = VillageInfrConfig.Instance.GetInfrTreeBuildAll();
			bool uiactive = true;
			foreach (InfrV2TreeBuild infrV2TreeBuild in infrTreeBuildAll)
			{
				IVillageInfrTreeData treeData = VillageInfrModel.Instance.GetTreeData(infrV2TreeBuild.Id);
				if (treeData == null || treeData.Status != InfrV2StatusPb.InfrV2StatusComplete)
				{
					uiactive = false;
					break;
				}
			}
			base.GetItem(10).SetUIActive(uiactive);
		}

		// Token: 0x060308D8 RID: 198872 RVA: 0x00B46C58 File Offset: 0x00B44E58
		protected override void OnBeforeDestroy()
		{
			this.ClearPosTweener();
			RedDotController.Instance.UnBindRedDot(ERedDotName.VillageInfrTask);
		}

		// Token: 0x060308D9 RID: 198873 RVA: 0x00B46C70 File Offset: 0x00B44E70
		private void RefreshTreeItems()
		{
			this.TreeDict.Clear();
			IReadOnlyList<InfrV2TreeBuild> infrTreeBuildAll = VillageInfrConfig.Instance.GetInfrTreeBuildAll();
			for (int i = 0; i < this.TreeList.Count; i++)
			{
				VillageInfrTreeItem villageInfrTreeItem = this.TreeList[i];
				int value = this.TreeCompList[i];
				this.TreeDict[infrTreeBuildAll[i].Id] = value;
				int id = infrTreeBuildAll[i].Id;
				EVillageInfrSelectType type = EVillageInfrSelectType.Tree;
				IVillageInfrMainParam villageInfrMainParam = this.OpenParam as IVillageInfrMainParam;
				villageInfrTreeItem.Refresh(id, type, (villageInfrMainParam != null) ? villageInfrMainParam.BuildFinishParam : null);
				villageInfrTreeItem.SetSelectCb(new Action<int, EVillageInfrSelectType>(this.OnClickTreeItem));
				villageInfrTreeItem.SetOnGetSeqEnd(delegate
				{
					if (this.FinishType != EVillageInfrSelectType.None)
					{
						UiManager.Instance.OpenView(EUiViewName.VillageInfrBuildFinishTipView, (this.OpenParam as IVillageInfrMainParam).BuildFinishParam, null);
						this.FinishType = EVillageInfrSelectType.None;
					}
				});
			}
		}

		// Token: 0x060308DA RID: 198874 RVA: 0x00B46D33 File Offset: 0x00B44F33
		private void RefreshVillageItem()
		{
			this.VillageItem.Refresh(VillageInfrModel.Instance.GetVillageLevel(), EVillageInfrSelectType.Village, null);
			this.VillageItem.SetSelectCb(new Action<int, EVillageInfrSelectType>(this.OnClickVillageItem));
		}

		// Token: 0x060308DB RID: 198875 RVA: 0x00B46D64 File Offset: 0x00B44F64
		private void RefreshBtnReward()
		{
			List<VillageInfrLimitTaskData> activityTaskDataList = VillageInfrModel.Instance.GetActivityTaskDataList();
			int num = 0;
			using (List<VillageInfrLimitTaskData>.Enumerator enumerator = activityTaskDataList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.Status == ConditionTaskState.ConditionTaskTaken)
					{
						num++;
					}
				}
			}
			UUIText text = base.GetText(8);
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
			defaultInterpolatedStringHandler.AppendFormatted<int>(num);
			defaultInterpolatedStringHandler.AppendLiteral("/");
			defaultInterpolatedStringHandler.AppendFormatted<int>(activityTaskDataList.Count);
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}

		// Token: 0x060308DC RID: 198876 RVA: 0x00B46E04 File Offset: 0x00B45004
		private void RefreshBtnVisible()
		{
			this.Caption.SetUiActive(this.SelectType == EVillageInfrSelectType.None);
			UUIButtonComponent button = base.GetButton(7);
			if (button != null)
			{
				button.RootUIComp.Get().SetUIActive(this.SelectType == EVillageInfrSelectType.None);
			}
			if (this.SelectType == EVillageInfrSelectType.None)
			{
				LevelSequencePlayer seqPlayer = this.SeqPlayer;
				if (seqPlayer != null)
				{
					seqPlayer.PlayLevelSequenceByName("Restore", false, null, false);
				}
			}
			else
			{
				LevelSequencePlayer seqPlayer2 = this.SeqPlayer;
				if (seqPlayer2 != null)
				{
					seqPlayer2.PlayLevelSequenceByName("Switch", false, null, false);
				}
			}
			if (this.SelectType == EVillageInfrSelectType.Village || (this.SelectType == EVillageInfrSelectType.Tree && Array.IndexOf<int>(VillageInfrDefine.villageInfrNeedMoveTreeId, this.SelectedId) >= 0))
			{
				int valueOrDefault = ConfigCommonParamById.GetIntConfig("VillageInfrMainMoveOffset").GetValueOrDefault();
				this.MoveToTargetPosWithTween(new Vector2D(this.StartPos.X - (double)valueOrDefault, this.StartPos.Y), LTweenEase.InOutSine);
				return;
			}
			this.MoveToTargetPosWithTween(new Vector2D(this.StartPos.X, this.StartPos.Y), LTweenEase.InOutSine);
		}

		// Token: 0x060308DD RID: 198877 RVA: 0x00B46F28 File Offset: 0x00B45128
		private void InitPosTweener()
		{
			this.Delegate = DelegateUtils.ToManualReleaseDelegate<FLTweenVector2SetterDynamic>(new Action<FVector2D>(this.OnTweenUpdate));
			FVector2D anchorOffset = base.GetItem(1).GetAnchorOffset();
			this.StartPos.Set((double)anchorOffset.X, (double)anchorOffset.Y);
		}

		// Token: 0x060308DE RID: 198878 RVA: 0x00B46F72 File Offset: 0x00B45172
		private void ClearPosTweener()
		{
			this.KillPosTweener();
			DelegateUtils.ReleaseManualReleaseDelegate(new Action<FVector2D>(this.OnTweenUpdate));
		}

		// Token: 0x060308DF RID: 198879 RVA: 0x00B46F8C File Offset: 0x00B4518C
		public void MoveToTargetPosWithTween(Vector2D targetPos, LTweenEase tweenEase = LTweenEase.InOutSine)
		{
			this.IsTween = true;
			this.KillPosTweener();
			float duration = (float)ConfigCommonParamById.GetIntConfig("VillageInfrMainMoveInterval").GetValueOrDefault() / (float)TimeUtil.Instance.InverseMillisecond;
			this.PosTweener = ULTweenBPLibrary.Vector2To(GlobalData.World, this.Delegate, base.GetItem(1).GetAnchorOffset(), targetPos.ToUeVector2D(false), duration, 0f, tweenEase);
			this.PosTweener.OnCompleteCallBack.Bind(delegate()
			{
				this.IsTween = false;
			});
		}

		// Token: 0x060308E0 RID: 198880 RVA: 0x00B47012 File Offset: 0x00B45212
		private void KillPosTweener()
		{
			if (this.PosTweener != null)
			{
				this.PosTweener.Kill(false);
				this.PosTweener = null;
			}
		}

		// Token: 0x060308E1 RID: 198881 RVA: 0x00B4702F File Offset: 0x00B4522F
		private void OnTweenUpdate(FVector2D targetPos)
		{
			base.GetItem(1).SetAnchorOffset(targetPos);
		}

		// Token: 0x060308E2 RID: 198882 RVA: 0x00B4703E File Offset: 0x00B4523E
		private void OnTreeDataUpdate()
		{
			this.RefreshTreeItems();
			this.RefreshVillageItem();
			this.RefreshPanelEffect();
		}

		// Token: 0x060308E3 RID: 198883 RVA: 0x00B47052 File Offset: 0x00B45252
		private void OnTaskDataUpdate()
		{
			this.RefreshBtnReward();
		}

		// Token: 0x060308E4 RID: 198884 RVA: 0x00B4705A File Offset: 0x00B4525A
		private void OnClickBtnReward()
		{
			UiManager.Instance.OpenView(EUiViewName.VillageInfrTaskMainView, null, null);
		}

		// Token: 0x060308E5 RID: 198885 RVA: 0x00B4706D File Offset: 0x00B4526D
		private void OnClickBtnCloseMask()
		{
			EventSystem.Instance.Emit(EEventName.CloseVillageInfrBuildInfoView);
		}

		// Token: 0x060308E6 RID: 198886 RVA: 0x00B47080 File Offset: 0x00B45280
		private void OnClickTreeItem(int id, EVillageInfrSelectType type)
		{
			VillageInfrTreeItem selectedItem = this.SelectedItem;
			if (selectedItem != null)
			{
				selectedItem.SetSelected(false);
			}
			this.SelectedId = id;
			this.SelectType = type;
			VillageInfrTreeItem selectedItem2 = null;
			foreach (VillageInfrTreeItem villageInfrTreeItem in this.TreeList)
			{
				if (villageInfrTreeItem.Id == id)
				{
					selectedItem2 = villageInfrTreeItem;
					break;
				}
			}
			this.SelectedItem = selectedItem2;
			this.ProcessBuildInfoView(new VillageInfrBuildInfoParam
			{
				SelectType = this.SelectType,
				SelectId = this.SelectedId,
				IsDelivery = false,
				CloseCb = new Action(this.SelectCloseCb)
			});
			this.RefreshBtnVisible();
		}

		// Token: 0x060308E7 RID: 198887 RVA: 0x00B47144 File Offset: 0x00B45344
		private void OnClickVillageItem(int id, EVillageInfrSelectType type)
		{
			VillageInfrTreeItem selectedItem = this.SelectedItem;
			if (selectedItem != null)
			{
				selectedItem.SetSelected(false);
			}
			this.SelectedId = id;
			this.SelectType = type;
			this.SelectedItem = this.VillageItem;
			this.ProcessBuildInfoView(new VillageInfrBuildInfoParam
			{
				SelectType = this.SelectType,
				SelectId = VillageInfrModel.Instance.GetVillageLevel(),
				IsDelivery = false,
				CloseCb = new Action(this.SelectCloseCb)
			});
			this.RefreshBtnVisible();
		}

		// Token: 0x060308E8 RID: 198888 RVA: 0x00B471C4 File Offset: 0x00B453C4
		private void ProcessBuildInfoView(IVillageInfrBuildInfoParam param)
		{
			if (UiManager.Instance.IsViewOpen(EUiViewName.VillageInfrBuildInfoView))
			{
				EventSystem.Instance.Emit<IVillageInfrBuildInfoParam>(EEventName.VillageInfrMainViewOnSelect, param);
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.VillageInfrBuildInfoView, param, delegate(bool isSuccess, int viewId)
			{
				if (isSuccess)
				{
					base.AddChildViewById(viewId);
				}
			});
		}

		// Token: 0x060308E9 RID: 198889 RVA: 0x00B47210 File Offset: 0x00B45410
		private void SelectCloseCb()
		{
			VillageInfrTreeItem selectedItem = this.SelectedItem;
			if (selectedItem != null)
			{
				selectedItem.SetSelected(false);
			}
			this.SelectedItem = null;
			this.SelectType = EVillageInfrSelectType.None;
			this.RefreshBtnVisible();
		}

		// Token: 0x0401A157 RID: 106839
		private int SelectedId;

		// Token: 0x0401A158 RID: 106840
		private EVillageInfrSelectType SelectType;

		// Token: 0x0401A159 RID: 106841
		private readonly List<VillageInfrTreeItem> TreeList = new List<VillageInfrTreeItem>();

		// Token: 0x0401A15A RID: 106842
		private readonly List<int> TreeCompList = new List<int>
		{
			2,
			3,
			4,
			5
		};

		// Token: 0x0401A15B RID: 106843
		private readonly Dictionary<int, int> TreeDict = new Dictionary<int, int>();

		// Token: 0x0401A15C RID: 106844
		private readonly VillageInfrTreeItem VillageItem = new VillageInfrTreeItem();

		// Token: 0x0401A15D RID: 106845
		private readonly PopupCaptionItem Caption = new PopupCaptionItem(null);

		// Token: 0x0401A15E RID: 106846
		[Nullable(2)]
		private VillageInfrTreeItem SelectedItem;

		// Token: 0x0401A15F RID: 106847
		[Nullable(2)]
		private LevelSequencePlayer SeqPlayer;

		// Token: 0x0401A160 RID: 106848
		private EVillageInfrSelectType FinishType;

		// Token: 0x0401A161 RID: 106849
		public int FinishId;

		// Token: 0x0401A162 RID: 106850
		[Nullable(2)]
		private ULTweener PosTweener;

		// Token: 0x0401A163 RID: 106851
		[Nullable(2)]
		private FLTweenVector2SetterDynamic Delegate;

		// Token: 0x0401A164 RID: 106852
		public bool IsTween;

		// Token: 0x0401A165 RID: 106853
		private readonly Vector2D StartPos = Vector2D.Create();
	}
}
