using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200151D RID: 5405
public class KingShipResultView : UiViewBase
{
	// Token: 0x0600D838 RID: 55352 RVA: 0x00402726 File Offset: 0x00400926
	[NullableContext(1)]
	public KingShipResultView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600D839 RID: 55353 RVA: 0x00402730 File Offset: 0x00400930
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIText)),
			new ValueTuple<int, Type>(5, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(6, typeof(UUIButtonComponent))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(6, new Action(this.OnClickCloseBtn)),
			new ValueTuple<int, Delegate>(5, new Action(this.OnClickMaskBtn))
		};
	}

	// Token: 0x0600D83A RID: 55354 RVA: 0x00402820 File Offset: 0x00400A20
	protected override void OnStart()
	{
		IKingShipResultViewData kingShipResultViewData = (IKingShipResultViewData)this.OpenParam;
		this.IsSuccess = kingShipResultViewData.IsSuccess;
		this.ReignsId = kingShipResultViewData.ReignsId;
		this.NextReignsId = kingShipResultViewData.NextReignsId;
		int cardId = kingShipResultViewData.CardId;
		string configTextByKey = PublicUtil.Instance.GetConfigTextByKey("ReignsCard_" + cardId.ToString() + "_CardDesc");
		base.GetText(3).SetText(configTextByKey, true);
		string configTextByKey2 = PublicUtil.Instance.GetConfigTextByKey("ReignsCard_" + cardId.ToString() + "_CardTitle");
		base.GetText(0).SetText(configTextByKey2, true);
		string configTextByKey3 = PublicUtil.Instance.GetConfigTextByKey("ReignsCard_" + cardId.ToString() + "_CardHeader");
		base.GetText(1).SetText(configTextByKey3, true);
	}

	// Token: 0x0600D83B RID: 55355 RVA: 0x004028F4 File Offset: 0x00400AF4
	private void OnClickMaskBtn()
	{
		if (this.IsSuccess)
		{
			GeneralLogicTreeController.Instance.RequestFinishUiGameplay(UiGamePlayType.Reigns, this.ReignsId.ToString());
		}
		if (this.IsSuccess && this.NextReignsId != 0)
		{
			IKingShipMainViewOpenData kingShipOpenData = KingShipUtil.GetKingShipOpenData(this.NextReignsId);
			UiManager.Instance.OpenView(EUiViewName.KingShipLoadingView, kingShipOpenData, delegate(bool _, int _)
			{
				base.CloseMe(null);
			});
			return;
		}
		base.CloseMe(null);
	}

	// Token: 0x0600D83C RID: 55356 RVA: 0x0040295F File Offset: 0x00400B5F
	private void OnClickCloseBtn()
	{
		if (this.IsSuccess)
		{
			GeneralLogicTreeController.Instance.RequestFinishUiGameplay(UiGamePlayType.Reigns, this.ReignsId.ToString());
		}
		base.CloseMe(null);
	}

	// Token: 0x0400790A RID: 30986
	private bool IsSuccess;

	// Token: 0x0400790B RID: 30987
	private int ReignsId;

	// Token: 0x0400790C RID: 30988
	private int NextReignsId;

	// Token: 0x020077CA RID: 30666
	private class EComponentDefine
	{
		// Token: 0x04026E34 RID: 159284
		public const int TitleText = 0;

		// Token: 0x04026E35 RID: 159285
		public const int MainTitleText = 1;

		// Token: 0x04026E36 RID: 159286
		public const int StaticText = 2;

		// Token: 0x04026E37 RID: 159287
		public const int DesText = 3;

		// Token: 0x04026E38 RID: 159288
		public const int Static2Text = 4;

		// Token: 0x04026E39 RID: 159289
		public const int MaskBtn = 5;

		// Token: 0x04026E3A RID: 159290
		public const int CloseBtn = 6;
	}
}
