using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000892 RID: 2194
public class ActivitySubViewPhantomCollectMonsterItem : UiPanelBase
{
	// Token: 0x0600633A RID: 25402 RVA: 0x001F9478 File Offset: 0x001F7678
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickBtnSelf));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600633B RID: 25403 RVA: 0x001F953F File Offset: 0x001F773F
	private void OnClickBtnSelf()
	{
		if (this.MonsterId != 0)
		{
			CalabashController.Instance.JumpToCalabashCollectTabView(this.MonsterId);
		}
	}

	// Token: 0x0600633C RID: 25404 RVA: 0x001F955C File Offset: 0x001F775C
	public void Refresh(int monsterId)
	{
		this.MonsterId = monsterId;
		ActivityPhantomCollectConfig instance = ActivityPhantomCollectConfig.Instance;
		string text;
		((instance != null) ? instance.GetPhantomCollectConfig(ActivityPhantomCollectController.Instance.ActivityId) : null).Value.PhantomActivityImage().TryGetValue(monsterId, out text);
		bool phantomIsUnlock = PhantomBattleModel.Instance.GetPhantomIsUnlock(monsterId);
		if (!string.IsNullOrEmpty(text) && phantomIsUnlock)
		{
			base.SetTextureByPath(text, base.GetTexture(1), null, null);
		}
		base.GetItem(2).SetUIActive(phantomIsUnlock && !CalabashModel.Instance.CheckMonsterIdInRecord(monsterId));
	}

	// Token: 0x04004014 RID: 16404
	public int MonsterId;

	// Token: 0x02006BE3 RID: 27619
	private class EActivitySubViewPhantomCollectMonsterItem
	{
		// Token: 0x04023773 RID: 145267
		public const int BtnSelf = 0;

		// Token: 0x04023774 RID: 145268
		public const int TextureMonster = 1;

		// Token: 0x04023775 RID: 145269
		public const int RedDotItem = 2;
	}
}
