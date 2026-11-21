using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200063A RID: 1594
public class BabelTowerSettlementDeTermItem : GridProxyAbstract<int>
{
	// Token: 0x06004A3B RID: 19003 RVA: 0x00193C20 File Offset: 0x00191E20
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickBtn));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06004A3C RID: 19004 RVA: 0x00193CC8 File Offset: 0x00191EC8
	public override void Refresh(int data, bool isSelected, int gridIndex)
	{
		this.DeTermId = data;
		base.SetTextureByPath(ConfigBabelTowerDeTermById.GetConfig(data, true).Value.Texture, base.GetTexture(0), null, null);
	}

	// Token: 0x06004A3D RID: 19005 RVA: 0x00193D0C File Offset: 0x00191F0C
	private void OnClickBtn()
	{
		BabelTowerItemInfoViewInfo param = new BabelTowerItemInfoViewInfo
		{
			IsDeTerm = true,
			ConfigId = this.DeTermId,
			ShowWays = false
		};
		UiManager.Instance.OpenView(EUiViewName.BabelTowerItemInfoView, param, null);
	}

	// Token: 0x04003708 RID: 14088
	private int DeTermId;

	// Token: 0x020068EF RID: 26863
	private class EComponents
	{
		// Token: 0x0402294F RID: 141647
		public const int IconTexture = 0;

		// Token: 0x04022950 RID: 141648
		public const int BgSprite = 1;

		// Token: 0x04022951 RID: 141649
		public const int NameText = 2;

		// Token: 0x04022952 RID: 141650
		public const int Btn = 3;
	}
}
