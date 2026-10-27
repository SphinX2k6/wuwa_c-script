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
	// Token: 0x0200591E RID: 22814
	[NullableContext(1)]
	[Nullable(0)]
	public class InfrRoadNetworkInfoView : UiViewBase
	{
		// Token: 0x06039EFA RID: 237306 RVA: 0x00DC4B2B File Offset: 0x00DC2D2B
		public InfrRoadNetworkInfoView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06039EFB RID: 237307 RVA: 0x00DC4B40 File Offset: 0x00DC2D40
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

		// Token: 0x06039EFC RID: 237308 RVA: 0x00DC4B88 File Offset: 0x00DC2D88
		protected override UniTask OnBeforeStartAsync()
		{
			InfrRoadNetworkInfoView.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<InfrRoadNetworkInfoView.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06039EFD RID: 237309 RVA: 0x00DC4BCB File Offset: 0x00DC2DCB
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add<InfrastructureDefine.IInfrRoadNetworkInfoOpenParam>(EEventName.InfrastructureSelectRoadNetworkMark, new Action<InfrastructureDefine.IInfrRoadNetworkInfoOpenParam>(this.OnSelectMark));
		}

		// Token: 0x06039EFE RID: 237310 RVA: 0x00DC4BE9 File Offset: 0x00DC2DE9
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove<InfrastructureDefine.IInfrRoadNetworkInfoOpenParam>(EEventName.InfrastructureSelectRoadNetworkMark, new Action<InfrastructureDefine.IInfrRoadNetworkInfoOpenParam>(this.OnSelectMark));
		}

		// Token: 0x06039EFF RID: 237311 RVA: 0x00DC4C08 File Offset: 0x00DC2E08
		private UniTask CreateInfoPanel()
		{
			InfrRoadNetworkInfoView.<CreateInfoPanel>d__8 <CreateInfoPanel>d__;
			<CreateInfoPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateInfoPanel>d__.<>4__this = this;
			<CreateInfoPanel>d__.<>1__state = -1;
			<CreateInfoPanel>d__.<>t__builder.Start<InfrRoadNetworkInfoView.<CreateInfoPanel>d__8>(ref <CreateInfoPanel>d__);
			return <CreateInfoPanel>d__.<>t__builder.Task;
		}

		// Token: 0x06039F00 RID: 237312 RVA: 0x00DC4C4B File Offset: 0x00DC2E4B
		protected override void OnStart()
		{
			this.SetOpenParam(this.OpenParam as InfrastructureDefine.IInfrRoadNetworkInfoOpenParam);
		}

		// Token: 0x06039F01 RID: 237313 RVA: 0x00DC4C60 File Offset: 0x00DC2E60
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

		// Token: 0x06039F02 RID: 237314 RVA: 0x00DC4CB4 File Offset: 0x00DC2EB4
		private UniTask CloseSelfAsync()
		{
			InfrRoadNetworkInfoView.<CloseSelfAsync>d__11 <CloseSelfAsync>d__;
			<CloseSelfAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CloseSelfAsync>d__.<>4__this = this;
			<CloseSelfAsync>d__.<>1__state = -1;
			<CloseSelfAsync>d__.<>t__builder.Start<InfrRoadNetworkInfoView.<CloseSelfAsync>d__11>(ref <CloseSelfAsync>d__);
			return <CloseSelfAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06039F03 RID: 237315 RVA: 0x00DC4CF7 File Offset: 0x00DC2EF7
		private void OnSelectMark(InfrastructureDefine.IInfrRoadNetworkInfoOpenParam param)
		{
			this.SetOpenParam(param);
		}

		// Token: 0x0401E350 RID: 123728
		private readonly InfrMaterialsDeliveryInfoPanel InfoPanel = new InfrMaterialsDeliveryInfoPanel();

		// Token: 0x0401E351 RID: 123729
		private Action CloseCb;

		// Token: 0x0200BBAB RID: 48043
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x04038A80 RID: 232064
			public const int MarkInfoPanel = 0;
		}
	}
}
