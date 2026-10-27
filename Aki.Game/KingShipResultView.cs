using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200204A RID: 8266
public class KingShipResultView : UiViewBase
{
	// Token: 0x060103D0 RID: 66512 RVA: 0x003F612E File Offset: 0x003F432E
	[NullableContext(1)]
	public KingShipResultView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060103D1 RID: 66513 RVA: 0x003F6138 File Offset: 0x003F4338
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

	// Token: 0x060103D2 RID: 66514 RVA: 0x003F6228 File Offset: 0x003F4428
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

	// Token: 0x060103D3 RID: 66515 RVA: 0x003F62FC File Offset: 0x003F44FC
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

	// Token: 0x060103D4 RID: 66516 RVA: 0x003F6367 File Offset: 0x003F4567
	private void OnClickCloseBtn()
	{
		if (this.IsSuccess)
		{
			GeneralLogicTreeController.Instance.RequestFinishUiGameplay(UiGamePlayType.Reigns, this.ReignsId.ToString());
		}
		base.CloseMe(null);
	}

	// Token: 0x04007821 RID: 30753
	private bool IsSuccess;

	// Token: 0x04007822 RID: 30754
	private int ReignsId;

	// Token: 0x04007823 RID: 30755
	private int NextReignsId;

	// Token: 0x02008643 RID: 34371
	private class EComponentDefine
	{
		// Token: 0x0402BB25 RID: 178981
		public const int TitleText = 0;

		// Token: 0x0402BB26 RID: 178982
		public const int MainTitleText = 1;

		// Token: 0x0402BB27 RID: 178983
		public const int StaticText = 2;

		// Token: 0x0402BB28 RID: 178984
		public const int DesText = 3;

		// Token: 0x0402BB29 RID: 178985
		public const int Static2Text = 4;

		// Token: 0x0402BB2A RID: 178986
		public const int MaskBtn = 5;

		// Token: 0x0402BB2B RID: 178987
		public const int CloseBtn = 6;
	}
}
