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
	// Token: 0x020037EE RID: 14318
	[NullableContext(1)]
	[Nullable(0)]
	public class VillageInfrBuildPanel : UiPanelBase
	{
		// Token: 0x060253DE RID: 152542 RVA: 0x00A80D1C File Offset: 0x00A7EF1C
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

		// Token: 0x060253DF RID: 152543 RVA: 0x00A80DA4 File Offset: 0x00A7EFA4
		private InfrV2TreeBuild GetTreeConfig()
		{
			return VillageInfrConfig.Instance.GetInfrTreeBuild(this.SelectId).Value;
		}

		// Token: 0x060253E0 RID: 152544 RVA: 0x00A80DCC File Offset: 0x00A7EFCC
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

		// Token: 0x060253E1 RID: 152545 RVA: 0x00A80E08 File Offset: 0x00A7F008
		protected override UniTask OnBeforeStartAsync()
		{
			VillageInfrBuildPanel.<OnBeforeStartAsync>d__7 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<VillageInfrBuildPanel.<OnBeforeStartAsync>d__7>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060253E2 RID: 152546 RVA: 0x00A80E4C File Offset: 0x00A7F04C
		private void SetOpenParam()
		{
			IVillageInfrBuildInfoParam villageInfrBuildInfoParam = this.OpenParam as IVillageInfrBuildInfoParam;
			this.SelectType = villageInfrBuildInfoParam.SelectType;
			this.SelectId = villageInfrBuildInfoParam.SelectId;
		}

		// Token: 0x060253E3 RID: 152547 RVA: 0x00A80E80 File Offset: 0x00A7F080
		private UniTask CreateInfoPanel()
		{
			VillageInfrBuildPanel.<CreateInfoPanel>d__9 <CreateInfoPanel>d__;
			<CreateInfoPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateInfoPanel>d__.<>4__this = this;
			<CreateInfoPanel>d__.<>1__state = -1;
			<CreateInfoPanel>d__.<>t__builder.Start<VillageInfrBuildPanel.<CreateInfoPanel>d__9>(ref <CreateInfoPanel>d__);
			return <CreateInfoPanel>d__.<>t__builder.Task;
		}

		// Token: 0x060253E4 RID: 152548 RVA: 0x00A80EC4 File Offset: 0x00A7F0C4
		private UniTask CreateBottomPanel()
		{
			VillageInfrBuildPanel.<CreateBottomPanel>d__10 <CreateBottomPanel>d__;
			<CreateBottomPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateBottomPanel>d__.<>4__this = this;
			<CreateBottomPanel>d__.<>1__state = -1;
			<CreateBottomPanel>d__.<>t__builder.Start<VillageInfrBuildPanel.<CreateBottomPanel>d__10>(ref <CreateBottomPanel>d__);
			return <CreateBottomPanel>d__.<>t__builder.Task;
		}

		// Token: 0x060253E5 RID: 152549 RVA: 0x00A80F08 File Offset: 0x00A7F108
		protected override void OnStart()
		{
			this.RefreshName();
			this.RefreshTrace();
			base.GetButton(0).RootUIComp.Get().SetUIActive(false);
		}

		// Token: 0x060253E6 RID: 152550 RVA: 0x00A80F3B File Offset: 0x00A7F13B
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

		// Token: 0x060253E7 RID: 152551 RVA: 0x00A80F71 File Offset: 0x00A7F171
		private void RefreshName()
		{
			base.GetText(1).ShowTextNew(this.GetName());
		}

		// Token: 0x060253E8 RID: 152552 RVA: 0x00A80F85 File Offset: 0x00A7F185
		private void RefreshTrace()
		{
			if (this.SelectType == EVillageInfrSelectType.Tree)
			{
				base.GetSprite(2).SetUIActive(VillageInfrModel.Instance.GetTraceTreeId() == this.SelectId);
				return;
			}
			base.GetSprite(2).SetUIActive(false);
		}

		// Token: 0x060253E9 RID: 152553 RVA: 0x00A80FBC File Offset: 0x00A7F1BC
		public void SetBottomBtnClickCb(Action cb)
		{
			this.BottomPanel.SetBottomBtnClickCb(cb);
		}

		// Token: 0x040149AC RID: 84396
		private int SelectId;

		// Token: 0x040149AD RID: 84397
		private EVillageInfrSelectType SelectType;

		// Token: 0x040149AE RID: 84398
		private readonly VillageInfrBuildInfoPanel InfoPanel = new VillageInfrBuildInfoPanel();

		// Token: 0x040149AF RID: 84399
		private readonly VillageInfrBuildBottomPanel BottomPanel = new VillageInfrBuildBottomPanel();
	}
}
