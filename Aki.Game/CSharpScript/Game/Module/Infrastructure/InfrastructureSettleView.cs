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
	// Token: 0x0200590C RID: 22796
	public class InfrastructureSettleView : UiViewBase
	{
		// Token: 0x06039E34 RID: 237108 RVA: 0x00DBFC65 File Offset: 0x00DBDE65
		[NullableContext(1)]
		public InfrastructureSettleView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x06039E35 RID: 237109 RVA: 0x00DBFC7C File Offset: 0x00DBDE7C
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

		// Token: 0x06039E36 RID: 237110 RVA: 0x00DBFD90 File Offset: 0x00DBDF90
		protected override UniTask OnBeforeStartAsync()
		{
			InfrastructureSettleView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<InfrastructureSettleView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06039E37 RID: 237111 RVA: 0x00DBFDD4 File Offset: 0x00DBDFD4
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

		// Token: 0x06039E38 RID: 237112 RVA: 0x00DBFF90 File Offset: 0x00DBE190
		protected override void OnAfterPlayStartSequence()
		{
			this.UiViewSequence.PlaySequence("Success", true, null);
		}

		// Token: 0x06039E39 RID: 237113 RVA: 0x00DBFFB8 File Offset: 0x00DBE1B8
		private UniTask InitButtonAsync()
		{
			InfrastructureSettleView.<InitButtonAsync>d__7 <InitButtonAsync>d__;
			<InitButtonAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<InitButtonAsync>d__.<>4__this = this;
			<InitButtonAsync>d__.<>1__state = -1;
			<InitButtonAsync>d__.<>t__builder.Start<InfrastructureSettleView.<InitButtonAsync>d__7>(ref <InitButtonAsync>d__);
			return <InitButtonAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06039E3A RID: 237114 RVA: 0x00DBFFFC File Offset: 0x00DBE1FC
		private void RefreshButton()
		{
			base.GetItem(5).SetUIActive(true);
			this.Button.SetUiActive(true);
			this.Button.SetBtnText("Leave", Array.Empty<string>());
			this.Button.HideFloatText();
			this.Button.SetOnClickEvent(new Action(this.OnClickBtnLeave));
			this.Button.SetOnClickLeftEvent(new Action(this.OnClickBtnLeaveLeft));
		}

		// Token: 0x06039E3B RID: 237115 RVA: 0x00DC0070 File Offset: 0x00DBE270
		private void OnClickBtnLeave()
		{
			UiManager.Instance.ResetToBattleView(null);
		}

		// Token: 0x06039E3C RID: 237116 RVA: 0x00DC007D File Offset: 0x00DBE27D
		private void OnClickBtnLeaveLeft()
		{
			base.CloseMe(null);
		}

		// Token: 0x0401E310 RID: 123664
		[Nullable(1)]
		protected InfrastructureSettleViewButton Button = new InfrastructureSettleViewButton();

		// Token: 0x0200BB77 RID: 47991
		private class EComponents
		{
			// Token: 0x0403895D RID: 231773
			public const int TxtTitle = 1;

			// Token: 0x0403895E RID: 231774
			public const int TextureIcon = 2;

			// Token: 0x0403895F RID: 231775
			public const int ButtonHorizontalItem = 4;

			// Token: 0x04038960 RID: 231776
			public const int PanelButtonItem = 5;

			// Token: 0x04038961 RID: 231777
			public const int TextTime = 10;

			// Token: 0x04038962 RID: 231778
			public const int TextPassTime = 11;

			// Token: 0x04038963 RID: 231779
			public const int PanelPassTime = 13;

			// Token: 0x04038964 RID: 231780
			public const int TextMidText = 14;
		}
	}
}
