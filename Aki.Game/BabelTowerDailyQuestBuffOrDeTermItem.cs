using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001124 RID: 4388
[Nullable(new byte[]
{
	0,
	1
})]
public class BabelTowerDailyQuestBuffOrDeTermItem : GridProxyAbstract<IBabelTowerDailyQuestItem>
{
	// Token: 0x06007311 RID: 29457 RVA: 0x0017A4E4 File Offset: 0x001786E4
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

	// Token: 0x06007312 RID: 29458 RVA: 0x0017A58C File Offset: 0x0017878C
	[NullableContext(1)]
	public override void Refresh(IBabelTowerDailyQuestItem data, bool isSelected, int gridIndex)
	{
		this.ConfigId = data.ConfigId;
		this.IsDeTerm = data.IsDeTerm;
		if (data.IsDeTerm)
		{
			base.SetTextureByPath(ConfigBabelTowerDeTermById.GetConfig(this.ConfigId, true).Value.Texture, base.GetTexture(0), null, null);
			return;
		}
		base.SetTextureByPath(ConfigBabelTowerBuffById.GetConfig(this.ConfigId, true).Value.Texture, base.GetTexture(0), null, null);
	}

	// Token: 0x06007313 RID: 29459 RVA: 0x0017A624 File Offset: 0x00178824
	private void OnClickBtn()
	{
		bool showWays;
		if (this.IsDeTerm)
		{
			showWays = BabelTowerController.Instance.GetBabelTowerData().GetDeTermIsLock(this.ConfigId);
		}
		else
		{
			showWays = BabelTowerController.Instance.GetBabelTowerData().GetBuffIsLock(this.ConfigId);
		}
		BabelTowerItemInfoViewInfo param = new BabelTowerItemInfoViewInfo
		{
			IsDeTerm = this.IsDeTerm,
			ConfigId = this.ConfigId,
			ShowWays = showWays
		};
		UiManager.Instance.OpenView(EUiViewName.BabelTowerItemInfoView, param, null);
	}

	// Token: 0x0400351C RID: 13596
	private int ConfigId;

	// Token: 0x0400351D RID: 13597
	private bool IsDeTerm;

	// Token: 0x020076FB RID: 30459
	private class EComponentDefine
	{
		// Token: 0x04027417 RID: 160791
		public const int Texture = 0;

		// Token: 0x04027418 RID: 160792
		public const int Btn = 3;
	}
}
