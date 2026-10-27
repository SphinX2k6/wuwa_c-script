using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001004 RID: 4100
public class GolemHackingGameTipsPopView : UiViewBase
{
	// Token: 0x06006926 RID: 26918 RVA: 0x0014EDA0 File Offset: 0x0014CFA0
	[NullableContext(1)]
	public GolemHackingGameTipsPopView(UiViewInfo info) : base(info)
	{
	}

	// Token: 0x06006927 RID: 26919 RVA: 0x0014EDB4 File Offset: 0x0014CFB4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnClickedClose));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06006928 RID: 26920 RVA: 0x0014EE9C File Offset: 0x0014D09C
	protected override UniTask OnBeforeStartAsync()
	{
		GolemHackingGameTipsPopView.<OnBeforeStartAsync>d__6 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<GolemHackingGameTipsPopView.<OnBeforeStartAsync>d__6>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06006929 RID: 26921 RVA: 0x0014EEE0 File Offset: 0x0014D0E0
	protected override void OnAfterShow()
	{
		int num = 2000 + this.GridList.Count * 250;
		for (int i = 0; i < this.GridList.Count; i++)
		{
			this.GridList[i].PlayAnim(i);
		}
		this.TimerHandle = TimerSystem.Instance.Forever(delegate(float _)
		{
			for (int j = 0; j < this.GridList.Count; j++)
			{
				this.GridList[j].PlayAnim(j);
			}
		}, (float)num, 1f, null, null, true);
	}

	// Token: 0x0600692A RID: 26922 RVA: 0x0014EF53 File Offset: 0x0014D153
	private void OnClickedClose()
	{
		if (this.TimerHandle != null)
		{
			if (this.TimerHandle.Valid())
			{
				TimerSystem.Instance.Remove(this.TimerHandle);
			}
			this.TimerHandle = null;
		}
		base.CloseMe(null);
	}

	// Token: 0x04003060 RID: 12384
	private const int INTERVAL_TIME = 250;

	// Token: 0x04003061 RID: 12385
	[Nullable(1)]
	protected List<GolemHackingTipsPopGrid> GridList = new List<GolemHackingTipsPopGrid>();

	// Token: 0x04003062 RID: 12386
	[Nullable(2)]
	protected TimerHandle TimerHandle;

	// Token: 0x020075FD RID: 30205
	private enum EDefine
	{
		// Token: 0x04026FB8 RID: 159672
		BtnMask,
		// Token: 0x04026FB9 RID: 159673
		TxtTipsDesc,
		// Token: 0x04026FBA RID: 159674
		PanelCodeTips,
		// Token: 0x04026FBB RID: 159675
		PanelHelpTipsItem
	}
}
