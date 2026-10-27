using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001186 RID: 4486
public class BabelTowerSettlementDeTermItem : GridProxyAbstract<int>
{
	// Token: 0x060076A4 RID: 30372 RVA: 0x0018B070 File Offset: 0x00189270
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

	// Token: 0x060076A5 RID: 30373 RVA: 0x0018B118 File Offset: 0x00189318
	public override void Refresh(int data, bool isSelected, int gridIndex)
	{
		this.DeTermId = data;
		base.SetTextureByPath(ConfigBabelTowerDeTermById.GetConfig(data, true).Value.Texture, base.GetTexture(0), null, null);
	}

	// Token: 0x060076A6 RID: 30374 RVA: 0x0018B15C File Offset: 0x0018935C
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

	// Token: 0x0400366F RID: 13935
	private int DeTermId;

	// Token: 0x02007762 RID: 30562
	private class EComponents
	{
		// Token: 0x04027616 RID: 161302
		public const int IconTexture = 0;

		// Token: 0x04027617 RID: 161303
		public const int BgSprite = 1;

		// Token: 0x04027618 RID: 161304
		public const int NameText = 2;

		// Token: 0x04027619 RID: 161305
		public const int Btn = 3;
	}
}
