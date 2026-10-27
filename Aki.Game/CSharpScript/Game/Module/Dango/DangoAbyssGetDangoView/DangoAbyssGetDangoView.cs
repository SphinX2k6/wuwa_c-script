using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Dango.DangoAbyssGetDangoView
{
	// Token: 0x02005AE8 RID: 23272
	[NullableContext(2)]
	[Nullable(0)]
	public class DangoAbyssGetDangoView : UiViewBase, IUiCameraBehavior
	{
		// Token: 0x17008C33 RID: 35891
		// (get) Token: 0x0603AEB7 RID: 241335 RVA: 0x00E0C198 File Offset: 0x00E0A398
		public new DangoAbyssGetDangoViewParams OpenParam
		{
			get
			{
				return this.OpenParam as DangoAbyssGetDangoViewParams;
			}
		}

		// Token: 0x0603AEB8 RID: 241336 RVA: 0x00E0C1A5 File Offset: 0x00E0A3A5
		[NullableContext(1)]
		public DangoAbyssGetDangoView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603AEB9 RID: 241337 RVA: 0x00E0C1B0 File Offset: 0x00E0A3B0
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem))
			};
		}

		// Token: 0x0603AEBA RID: 241338 RVA: 0x00E0C20A File Offset: 0x00E0A40A
		protected override void OnHandleLoadScene()
		{
			DangoAbyssActorManager.InitIndexDangoSkeletalObserverHandle(99);
		}

		// Token: 0x0603AEBB RID: 241339 RVA: 0x00E0C213 File Offset: 0x00E0A413
		protected override void OnHandleReleaseScene()
		{
			DangoAbyssActorManager.DestroyDangoSkeletalObserverHandle(99);
		}

		// Token: 0x0603AEBC RID: 241340 RVA: 0x00E0C21C File Offset: 0x00E0A41C
		protected override UniTask OnBeforeStartAsync()
		{
			DangoAbyssGetDangoView.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DangoAbyssGetDangoView.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603AEBD RID: 241341 RVA: 0x00E0C260 File Offset: 0x00E0A460
		public void OnClickBtnConfirm()
		{
			this.CurrentShowIndex++;
			DangoAbyssGetDangoViewParams openParam = this.OpenParam;
			int? num;
			if (openParam == null)
			{
				num = null;
			}
			else
			{
				DangoAbyssDefine.IDangoUnlockData[] dataList = openParam.DataList;
				num = ((dataList != null) ? new int?(dataList.Length) : null);
			}
			int? num2 = num;
			int valueOrDefault = num2.GetValueOrDefault();
			if (this.CurrentShowIndex >= valueOrDefault)
			{
				base.CloseMe(null);
				return;
			}
			this.RefreshViewByCurrentShowIndex();
		}

		// Token: 0x0603AEBE RID: 241342 RVA: 0x00E0C2CB File Offset: 0x00E0A4CB
		public void PushCameraHandle(EUiViewName viewName, int viewId, bool isBlend)
		{
			UiCameraAnimationController.Instance.PushCameraHandle((EUiViewName)"DangoGet", new int?(base.GetViewId()), true);
		}

		// Token: 0x0603AEBF RID: 241343 RVA: 0x00E0C2ED File Offset: 0x00E0A4ED
		public void PopCameraHandle(EUiViewName viewName, UiViewInfo stackTopInfo, int closeViewId, bool popOrDelete)
		{
			UiCameraAnimationController.Instance.PopCameraHandle((EUiViewName)"DangoGet", stackTopInfo, closeViewId, popOrDelete);
		}

		// Token: 0x0603AEC0 RID: 241344 RVA: 0x00E0C307 File Offset: 0x00E0A507
		protected override void OnBeforeShow()
		{
			this.DLSSPastValue = UKismetSystemLibrary.GetConsoleVariableIntValue("r.NGX.DLSS.Enable");
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.NGX.DLSS.Enable 0", null);
			this.PushCameraHandle((EUiViewName)"DangoGet", base.GetViewId(), true);
			this.RefreshViewByCurrentShowIndex();
		}

		// Token: 0x0603AEC1 RID: 241345 RVA: 0x00E0C348 File Offset: 0x00E0A548
		private void RefreshViewByCurrentShowIndex()
		{
			DangoAbyssGetDangoViewParams openParam = this.OpenParam;
			DangoAbyssDefine.IDangoUnlockData[] array = (openParam != null) ? openParam.DataList : null;
			if (array == null || this.CurrentShowIndex < 0 || this.CurrentShowIndex >= array.Length)
			{
				base.CloseMe(null);
				return;
			}
			base.PlaySequence("Start01", new Action(this.ShowDango), false);
			DangoAbyssDefine.IDangoUnlockData dangoUnlockData = array[this.CurrentShowIndex];
			this.TitlePanel.RefreshView(dangoUnlockData);
			this.TitlePanel.SetActive(true);
			this.DetailPanel.RefreshView(dangoUnlockData);
			this.DetailPanel.SetActive(false);
			DangoAbyssController.Instance.RefreshAbyssDangoModel(99, dangoUnlockData.DangoId, "MonsterCase", null);
		}

		// Token: 0x0603AEC2 RID: 241346 RVA: 0x00E0C3F0 File Offset: 0x00E0A5F0
		protected override void OnBeforeDestroy()
		{
			UObject world = GlobalData.World;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(18, 1);
			defaultInterpolatedStringHandler.AppendLiteral("r.NGX.DLSS.Enable ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.DLSSPastValue);
			UKismetSystemLibrary.ExecuteConsoleCommand(world, defaultInterpolatedStringHandler.ToStringAndClear(), null);
		}

		// Token: 0x0603AEC3 RID: 241347 RVA: 0x00E0C432 File Offset: 0x00E0A632
		private void ShowDango()
		{
			DangoGetTitlePanel titlePanel = this.TitlePanel;
			if (titlePanel != null)
			{
				titlePanel.SetActive(false);
			}
			DangoGetDetailPanel detailPanel = this.DetailPanel;
			if (detailPanel == null)
			{
				return;
			}
			detailPanel.SetActive(true);
		}

		// Token: 0x0401EBFF RID: 125951
		private const int HANDLEINDEX = 99;

		// Token: 0x0401EC00 RID: 125952
		[Nullable(1)]
		private const string DANGOGET = "DangoGet";

		// Token: 0x0401EC01 RID: 125953
		private DangoGetTitlePanel TitlePanel;

		// Token: 0x0401EC02 RID: 125954
		private DangoGetDetailPanel DetailPanel;

		// Token: 0x0401EC03 RID: 125955
		private int CurrentShowIndex;

		// Token: 0x0401EC04 RID: 125956
		private int DLSSPastValue;

		// Token: 0x0200BD3E RID: 48446
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x04039131 RID: 233777
			ItemPop,
			// Token: 0x04039132 RID: 233778
			ItemGet,
			// Token: 0x04039133 RID: 233779
			ItemShowLayer
		}
	}
}
