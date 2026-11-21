using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Infrastructure
{
	// Token: 0x020048F7 RID: 18679
	[NullableContext(1)]
	[Nullable(0)]
	public class InfrRoadNetworkInfoView : UiViewBase
	{
		// Token: 0x0602EE1D RID: 192029 RVA: 0x00D13E1F File Offset: 0x00D1201F
		public InfrRoadNetworkInfoView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0602EE1E RID: 192030 RVA: 0x00D13E34 File Offset: 0x00D12034
		protected unsafe override void OnRegisterComponent()
		{
			int num = 1;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int index = 0;
			*span[index] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602EE1F RID: 192031 RVA: 0x00D13E7C File Offset: 0x00D1207C
		protected override UniTask OnBeforeStartAsync()
		{
			InfrRoadNetworkInfoView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<InfrRoadNetworkInfoView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602EE20 RID: 192032 RVA: 0x00D13EBF File Offset: 0x00D120BF
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<InfrastructureDefine.IInfrRoadNetworkInfoOpenParam>(EEventName.InfrastructureSelectRoadNetworkMark, new Action<InfrastructureDefine.IInfrRoadNetworkInfoOpenParam>(this.OnSelectMark));
		}

		// Token: 0x0602EE21 RID: 192033 RVA: 0x00D13EDD File Offset: 0x00D120DD
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<InfrastructureDefine.IInfrRoadNetworkInfoOpenParam>(EEventName.InfrastructureSelectRoadNetworkMark, new Action<InfrastructureDefine.IInfrRoadNetworkInfoOpenParam>(this.OnSelectMark));
		}

		// Token: 0x0602EE22 RID: 192034 RVA: 0x00D13EFC File Offset: 0x00D120FC
		private UniTask CreateInfoPanel()
		{
			InfrRoadNetworkInfoView.<CreateInfoPanel>d__8 <CreateInfoPanel>d__;
			<CreateInfoPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateInfoPanel>d__.<>4__this = this;
			<CreateInfoPanel>d__.<>1__state = -1;
			<CreateInfoPanel>d__.<>t__builder.Start<InfrRoadNetworkInfoView.<CreateInfoPanel>d__8>(ref <CreateInfoPanel>d__);
			return <CreateInfoPanel>d__.<>t__builder.Task;
		}

		// Token: 0x0602EE23 RID: 192035 RVA: 0x00D13F3F File Offset: 0x00D1213F
		protected override void OnStart()
		{
			this.SetOpenParam(this.OpenParam as InfrastructureDefine.IInfrRoadNetworkInfoOpenParam);
		}

		// Token: 0x0602EE24 RID: 192036 RVA: 0x00D13F54 File Offset: 0x00D12154
		private void SetOpenParam(InfrastructureDefine.IInfrRoadNetworkInfoOpenParam openParam)
		{
			this.CloseCb = openParam.CloseCb;
			this.InfoPanel.SetClickBtnBuildCb(openParam.BuildCb);
			this.InfoPanel.SetClickCaptionCloseBtnCb(delegate
			{
				this.CloseSelfAsync().Forget();
			});
			this.InfoPanel.Refresh(openParam.InfoParam);
		}

		// Token: 0x0602EE25 RID: 192037 RVA: 0x00D13FA8 File Offset: 0x00D121A8
		private UniTask CloseSelfAsync()
		{
			InfrRoadNetworkInfoView.<CloseSelfAsync>d__11 <CloseSelfAsync>d__;
			<CloseSelfAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CloseSelfAsync>d__.<>4__this = this;
			<CloseSelfAsync>d__.<>1__state = -1;
			<CloseSelfAsync>d__.<>t__builder.Start<InfrRoadNetworkInfoView.<CloseSelfAsync>d__11>(ref <CloseSelfAsync>d__);
			return <CloseSelfAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602EE26 RID: 192038 RVA: 0x00D13FEB File Offset: 0x00D121EB
		private void OnSelectMark(InfrastructureDefine.IInfrRoadNetworkInfoOpenParam param)
		{
			this.SetOpenParam(param);
		}

		// Token: 0x04018DED RID: 101869
		private readonly InfrMaterialsDeliveryInfoPanel InfoPanel = new InfrMaterialsDeliveryInfoPanel();

		// Token: 0x04018DEE RID: 101870
		private Action CloseCb;

		// Token: 0x0200A5BB RID: 42427
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x04033466 RID: 210022
			public const int MarkInfoPanel = 0;
		}
	}
}
