using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200150E RID: 5390
public class KingShipFailView : UiViewBase
{
	// Token: 0x0600D79D RID: 55197 RVA: 0x003FF300 File Offset: 0x003FD500
	[NullableContext(1)]
	public KingShipFailView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600D79E RID: 55198 RVA: 0x003FF30C File Offset: 0x003FD50C
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

	// Token: 0x0600D79F RID: 55199 RVA: 0x003FF38C File Offset: 0x003FD58C
	protected override void OnStart()
	{
		int cardId = ((IKingShipFailViewData)this.OpenParam).CardId;
		string configTextByKey = PublicUtil.Instance.GetConfigTextByKey("ReignsCard_" + cardId.ToString() + "_CardDesc");
		base.GetText(1).SetText(configTextByKey, true);
		string configTextByKey2 = PublicUtil.Instance.GetConfigTextByKey("ReignsCard_" + cardId.ToString() + "_CardTitle");
		base.GetText(0).SetText(configTextByKey2, true);
	}

	// Token: 0x0600D7A0 RID: 55200 RVA: 0x003FF408 File Offset: 0x003FD608
	private void OnClickCloseBtn()
	{
		((IKingShipFailViewData)this.OpenParam).OnCloseCallBack();
		base.CloseMe(null);
	}

	// Token: 0x0600D7A1 RID: 55201 RVA: 0x003FF426 File Offset: 0x003FD626
	protected override void OnBeforeDestroy()
	{
	}

	// Token: 0x020077BB RID: 30651
	private class EComponentDefine
	{
		// Token: 0x04026DDE RID: 159198
		public const int TitleText = 0;

		// Token: 0x04026DDF RID: 159199
		public const int DesText = 1;

		// Token: 0x04026DE0 RID: 159200
		public const int CloseBtn = 2;
	}
}
