using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Infrastructure
{
	// Token: 0x020048E5 RID: 18661
	public class InfrastructureSettleView : UiViewBase
	{
		// Token: 0x0602ED57 RID: 191831 RVA: 0x00D0EF5D File Offset: 0x00D0D15D
		[NullableContext(1)]
		public InfrastructureSettleView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0602ED58 RID: 191832 RVA: 0x00D0EF74 File Offset: 0x00D0D174
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x0602ED59 RID: 191833 RVA: 0x00D0F088 File Offset: 0x00D0D288
		protected override UniTask OnBeforeStartAsync()
		{
			InfrastructureSettleView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<InfrastructureSettleView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602ED5A RID: 191834 RVA: 0x00D0F0CC File Offset: 0x00D0D2CC
		protected override void OnStart()
		{
			base.GetItem(13).SetUIActive(true);
			base.GetText(14).SetUIActive(true);
			base.SetTextureByPath(UiResourceConfig.Instance.GetResourcePath("T_Logo_Activity_1_UI"), base.GetTexture(2), null, null);
			base.GetText(10).SetColor(FColor.FromHex("#F0D33F"));
			base.GetText(11).SetColor(FColor.FromHex("#ECE5D8"));
			base.GetText(14).SetColor(FColor.FromHex("#ECE5D8"));
			base.GetText(1).ShowTextNew("Build_CompleteTitle");
			(base.GetText(1).GetOwner().GetComponentByClass(UUIEffectOutline.StaticClass()) as UUIEffectOutline).SetOutlineColor(FColor.FromHex("#C48B29"));
			InfrastructureDefine.IInfrSettleViewOpenParam infrSettleViewOpenParam = this.OpenParam as InfrastructureDefine.IInfrSettleViewOpenParam;
			if (infrSettleViewOpenParam.DeliveryType == ActionInfrastructureItemDeliveryType.Observatory)
			{
				InfrLevel? levelConfigById = InfrastructureConfig.Instance.GetLevelConfigById(InfrastructureModel.Instance.FireLevel);
				LguiUtil.Instance.SetLocalTextNew(base.GetText(14), levelConfigById.Value.BuildSuccessDes, Array.Empty<object>());
			}
			else
			{
				InfrRoadBuild? roadConfigById = InfrastructureConfig.Instance.GetRoadConfigById(infrSettleViewOpenParam.RoadId);
				LguiUtil.Instance.SetLocalTextNew(base.GetText(14), "Build_CompleteDes", new <>z__ReadOnlySingleElementList<object>(new TableTextArgNew(roadConfigById.Value.Name, Array.Empty<object>())));
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(11), "Build_CompleteTime", Array.Empty<object>());
			base.GetText(10).SetText(TimeUtil.Instance.DateFormatString(Time.Instance.ServerTimeStamp / 1000.0), true);
			this.RefreshButton();
		}

		// Token: 0x0602ED5B RID: 191835 RVA: 0x00D0F288 File Offset: 0x00D0D488
		protected override void OnAfterPlayStartSequence()
		{
			this.UiViewSequence.PlaySequence("Success", true, null);
		}

		// Token: 0x0602ED5C RID: 191836 RVA: 0x00D0F2B0 File Offset: 0x00D0D4B0
		private UniTask InitButtonAsync()
		{
			InfrastructureSettleView.<InitButtonAsync>d__7 <InitButtonAsync>d__;
			<InitButtonAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitButtonAsync>d__.<>4__this = this;
			<InitButtonAsync>d__.<>1__state = -1;
			<InitButtonAsync>d__.<>t__builder.Start<InfrastructureSettleView.<InitButtonAsync>d__7>(ref <InitButtonAsync>d__);
			return <InitButtonAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602ED5D RID: 191837 RVA: 0x00D0F2F4 File Offset: 0x00D0D4F4
		private void RefreshButton()
		{
			base.GetItem(5).SetUIActive(true);
			this.Button.SetUiActive(true);
			this.Button.SetBtnText("Leave", Array.Empty<string>());
			this.Button.HideFloatText();
			this.Button.SetOnClickEvent(new Action(this.OnClickBtnLeave));
			this.Button.SetOnClickLeftEvent(new Action(this.OnClickBtnLeaveLeft));
		}

		// Token: 0x0602ED5E RID: 191838 RVA: 0x00D0F368 File Offset: 0x00D0D568
		private void OnClickBtnLeave()
		{
			UiManager.Instance.ResetToBattleView(null);
		}

		// Token: 0x0602ED5F RID: 191839 RVA: 0x00D0F375 File Offset: 0x00D0D575
		private void OnClickBtnLeaveLeft()
		{
			base.CloseMe(null);
		}

		// Token: 0x04018DAD RID: 101805
		[Nullable(1)]
		protected InfrastructureSettleViewButton Button = new InfrastructureSettleViewButton();

		// Token: 0x0200A587 RID: 42375
		private class EComponents
		{
			// Token: 0x04033345 RID: 209733
			public const int TxtTitle = 1;

			// Token: 0x04033346 RID: 209734
			public const int TextureIcon = 2;

			// Token: 0x04033347 RID: 209735
			public const int ButtonHorizontalItem = 4;

			// Token: 0x04033348 RID: 209736
			public const int PanelButtonItem = 5;

			// Token: 0x04033349 RID: 209737
			public const int TextTime = 10;

			// Token: 0x0403334A RID: 209738
			public const int TextPassTime = 11;

			// Token: 0x0403334B RID: 209739
			public const int PanelPassTime = 13;

			// Token: 0x0403334C RID: 209740
			public const int TextMidText = 14;
		}
	}
}
