using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.VillageInfr
{
	// Token: 0x02004877 RID: 18551
	[NullableContext(1)]
	[Nullable(0)]
	public class VillageInfrBuildPanel : UiPanelBase
	{
		// Token: 0x060308B2 RID: 198834 RVA: 0x00B45F80 File Offset: 0x00B44180
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUISprite)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem))
			};
		}

		// Token: 0x060308B3 RID: 198835 RVA: 0x00B46008 File Offset: 0x00B44208
		private InfrV2TreeBuild GetTreeConfig()
		{
			return VillageInfrConfig.Instance.GetInfrTreeBuild(this.SelectId).Value;
		}

		// Token: 0x060308B4 RID: 198836 RVA: 0x00B46030 File Offset: 0x00B44230
		private string GetName()
		{
			if (this.SelectType == EVillageInfrSelectType.Tree)
			{
				return this.GetTreeConfig().Name;
			}
			if (this.SelectType == EVillageInfrSelectType.Village)
			{
				return "VillageInfr_Name";
			}
			return "";
		}

		// Token: 0x060308B5 RID: 198837 RVA: 0x00B4606C File Offset: 0x00B4426C
		protected override UniTask OnBeforeStartAsync()
		{
			VillageInfrBuildPanel.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<VillageInfrBuildPanel.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060308B6 RID: 198838 RVA: 0x00B460B0 File Offset: 0x00B442B0
		private void SetOpenParam()
		{
			IVillageInfrBuildInfoParam villageInfrBuildInfoParam = this.OpenParam as IVillageInfrBuildInfoParam;
			this.SelectType = villageInfrBuildInfoParam.SelectType;
			this.SelectId = villageInfrBuildInfoParam.SelectId;
		}

		// Token: 0x060308B7 RID: 198839 RVA: 0x00B460E4 File Offset: 0x00B442E4
		private UniTask CreateInfoPanel()
		{
			VillageInfrBuildPanel.<CreateInfoPanel>d__9 <CreateInfoPanel>d__;
			<CreateInfoPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateInfoPanel>d__.<>4__this = this;
			<CreateInfoPanel>d__.<>1__state = -1;
			<CreateInfoPanel>d__.<>t__builder.Start<VillageInfrBuildPanel.<CreateInfoPanel>d__9>(ref <CreateInfoPanel>d__);
			return <CreateInfoPanel>d__.<>t__builder.Task;
		}

		// Token: 0x060308B8 RID: 198840 RVA: 0x00B46128 File Offset: 0x00B44328
		private UniTask CreateBottomPanel()
		{
			VillageInfrBuildPanel.<CreateBottomPanel>d__10 <CreateBottomPanel>d__;
			<CreateBottomPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateBottomPanel>d__.<>4__this = this;
			<CreateBottomPanel>d__.<>1__state = -1;
			<CreateBottomPanel>d__.<>t__builder.Start<VillageInfrBuildPanel.<CreateBottomPanel>d__10>(ref <CreateBottomPanel>d__);
			return <CreateBottomPanel>d__.<>t__builder.Task;
		}

		// Token: 0x060308B9 RID: 198841 RVA: 0x00B4616C File Offset: 0x00B4436C
		protected override void OnStart()
		{
			this.RefreshName();
			this.RefreshTrace();
			base.GetButton(0).RootUIComp.Get().SetUIActive(false);
		}

		// Token: 0x060308BA RID: 198842 RVA: 0x00B4619F File Offset: 0x00B4439F
		[NullableContext(2)]
		public void Refresh(IVillageInfrBuildInfoParam param = null)
		{
			if (param != null)
			{
				this.OpenParam = param;
				this.SetOpenParam();
			}
			this.InfoPanel.Refresh(param);
			this.BottomPanel.Refresh(param);
			this.RefreshTrace();
			this.RefreshName();
		}

		// Token: 0x060308BB RID: 198843 RVA: 0x00B461D5 File Offset: 0x00B443D5
		private void RefreshName()
		{
			base.GetText(1).ShowTextNew(this.GetName());
		}

		// Token: 0x060308BC RID: 198844 RVA: 0x00B461E9 File Offset: 0x00B443E9
		private void RefreshTrace()
		{
			if (this.SelectType == EVillageInfrSelectType.Tree)
			{
				base.GetSprite(2).SetUIActive(VillageInfrModel.Instance.GetTraceTreeId() == this.SelectId);
				return;
			}
			base.GetSprite(2).SetUIActive(false);
		}

		// Token: 0x060308BD RID: 198845 RVA: 0x00B46220 File Offset: 0x00B44420
		public void SetBottomBtnClickCb(Action cb)
		{
			this.BottomPanel.SetBottomBtnClickCb(cb);
		}

		// Token: 0x0401A139 RID: 106809
		private int SelectId;

		// Token: 0x0401A13A RID: 106810
		private EVillageInfrSelectType SelectType;

		// Token: 0x0401A13B RID: 106811
		private readonly VillageInfrBuildInfoPanel InfoPanel = new VillageInfrBuildInfoPanel();

		// Token: 0x0401A13C RID: 106812
		private readonly VillageInfrBuildBottomPanel BottomPanel = new VillageInfrBuildBottomPanel();
	}
}
