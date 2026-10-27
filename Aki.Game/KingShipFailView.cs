using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200203B RID: 8251
public class KingShipFailView : UiViewBase
{
	// Token: 0x06010335 RID: 66357 RVA: 0x003F2D08 File Offset: 0x003F0F08
	[NullableContext(1)]
	public KingShipFailView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06010336 RID: 66358 RVA: 0x003F2D14 File Offset: 0x003F0F14
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIButtonComponent))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(2, new Action(this.OnClickCloseBtn))
		};
	}

	// Token: 0x06010337 RID: 66359 RVA: 0x003F2D94 File Offset: 0x003F0F94
	protected override void OnStart()
	{
		int cardId = ((IKingShipFailViewData)this.OpenParam).CardId;
		string configTextByKey = PublicUtil.Instance.GetConfigTextByKey("ReignsCard_" + cardId.ToString() + "_CardDesc");
		base.GetText(1).SetText(configTextByKey, true);
		string configTextByKey2 = PublicUtil.Instance.GetConfigTextByKey("ReignsCard_" + cardId.ToString() + "_CardTitle");
		base.GetText(0).SetText(configTextByKey2, true);
	}

	// Token: 0x06010338 RID: 66360 RVA: 0x003F2E10 File Offset: 0x003F1010
	private void OnClickCloseBtn()
	{
		((IKingShipFailViewData)this.OpenParam).OnCloseCallBack();
		base.CloseMe(null);
	}

	// Token: 0x06010339 RID: 66361 RVA: 0x003F2E2E File Offset: 0x003F102E
	protected override void OnBeforeDestroy()
	{
	}

	// Token: 0x02008634 RID: 34356
	private class EComponentDefine
	{
		// Token: 0x0402BACF RID: 178895
		public const int TitleText = 0;

		// Token: 0x0402BAD0 RID: 178896
		public const int DesText = 1;

		// Token: 0x0402BAD1 RID: 178897
		public const int CloseBtn = 2;
	}
}
