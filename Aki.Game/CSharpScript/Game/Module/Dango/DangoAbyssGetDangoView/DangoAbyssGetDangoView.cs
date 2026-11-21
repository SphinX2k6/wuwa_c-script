using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.UiCamera;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Dango.DangoAbyssGetDangoView
{
	// Token: 0x02004AC9 RID: 19145
	[NullableContext(2)]
	[Nullable(0)]
	public class DangoAbyssGetDangoView : UiViewBase, IUiViewCameraBehavior
	{
		// Token: 0x1700600D RID: 24589
		// (get) Token: 0x0602FE29 RID: 196137 RVA: 0x00D5CE7C File Offset: 0x00D5B07C
		public new DangoAbyssGetDangoViewParams OpenParam
		{
			get
			{
				return this.OpenParam as DangoAbyssGetDangoViewParams;
			}
		}

		// Token: 0x0602FE2A RID: 196138 RVA: 0x00D5CE89 File Offset: 0x00D5B089
		[NullableContext(1)]
		public DangoAbyssGetDangoView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602FE2B RID: 196139 RVA: 0x00D5CE94 File Offset: 0x00D5B094
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIItem)),
				new ValueTuple<int, Type>(2, typeof(UUIItem))
			};
		}

		// Token: 0x0602FE2C RID: 196140 RVA: 0x00D5CEEE File Offset: 0x00D5B0EE
		protected override void OnHandleLoadScene()
		{
			DangoAbyssActorManager.InitIndexDangoSkeletalObserverHandle(99);
		}

		// Token: 0x0602FE2D RID: 196141 RVA: 0x00D5CEF7 File Offset: 0x00D5B0F7
		protected override void OnHandleReleaseScene()
		{
			DangoAbyssActorManager.DestroyDangoSkeletalObserverHandle(99);
		}

		// Token: 0x0602FE2E RID: 196142 RVA: 0x00D5CF00 File Offset: 0x00D5B100
		protected override UniTask OnBeforeStartAsync()
		{
			DangoAbyssGetDangoView.<OnBeforeStartAsync>d__13 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<DangoAbyssGetDangoView.<OnBeforeStartAsync>d__13>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602FE2F RID: 196143 RVA: 0x00D5CF44 File Offset: 0x00D5B144
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

		// Token: 0x0602FE30 RID: 196144 RVA: 0x00D5CFAF File Offset: 0x00D5B1AF
		public void PushCameraHandleByOpenView(EUiViewName viewName, int viewId, EUiCameraHandleOperationType operationType)
		{
			UiCameraController.Instance.PushCameraHandleByOpenView((EUiViewName)"DangoGet", viewId, operationType);
		}

		// Token: 0x0602FE31 RID: 196145 RVA: 0x00D5CFC7 File Offset: 0x00D5B1C7
		public void PopCameraHandleByCloseView(EUiViewName viewName, EUiViewName? nextViewName, int closeViewId, EUiCameraHandleOperationType operationType)
		{
			UiCameraController.Instance.PopCameraHandleByCloseView((EUiViewName)"DangoGet", nextViewName, closeViewId, operationType);
		}

		// Token: 0x0602FE32 RID: 196146 RVA: 0x00D5CFE1 File Offset: 0x00D5B1E1
		protected override void OnBeforeShow()
		{
			this.DLSSPastValue = UKismetSystemLibrary.GetConsoleVariableIntValue("r.NGX.DLSS.Enable");
			UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.NGX.DLSS.Enable 0", null);
			this.PushCameraHandleByOpenView((EUiViewName)"DangoGet", base.GetViewId(), EUiCameraHandleOperationType.Blend);
			this.RefreshViewByCurrentShowIndex();
		}

		// Token: 0x0602FE33 RID: 196147 RVA: 0x00D5D020 File Offset: 0x00D5B220
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

		// Token: 0x0602FE34 RID: 196148 RVA: 0x00D5D0C8 File Offset: 0x00D5B2C8
		protected override void OnBeforeDestroy()
		{
			UObject world = GlobalData.World;
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(18, 1);
			defaultInterpolatedStringHandler.AppendLiteral("r.NGX.DLSS.Enable ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.DLSSPastValue);
			UKismetSystemLibrary.ExecuteConsoleCommand(world, defaultInterpolatedStringHandler.ToStringAndClear(), null);
		}

		// Token: 0x0602FE35 RID: 196149 RVA: 0x00D5D10A File Offset: 0x00D5B30A
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

		// Token: 0x040196BB RID: 104123
		private const int HANDLEINDEX = 99;

		// Token: 0x040196BC RID: 104124
		[Nullable(1)]
		private const string DANGOGET = "DangoGet";

		// Token: 0x040196BD RID: 104125
		private DangoGetTitlePanel TitlePanel;

		// Token: 0x040196BE RID: 104126
		private DangoGetDetailPanel DetailPanel;

		// Token: 0x040196BF RID: 104127
		private int CurrentShowIndex;

		// Token: 0x040196C0 RID: 104128
		private int DLSSPastValue;

		// Token: 0x0200A746 RID: 42822
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x04033AFB RID: 211707
			ItemPop,
			// Token: 0x04033AFC RID: 211708
			ItemGet,
			// Token: 0x04033AFD RID: 211709
			ItemShowLayer
		}
	}
}
