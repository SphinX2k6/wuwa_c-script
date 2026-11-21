using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000C0F RID: 3087
[NullableContext(1)]
[Nullable(0)]
public class VisionDirectionalFusionSelectTargetView : UiViewBase
{
	// Token: 0x060080BC RID: 32956 RVA: 0x00277DAD File Offset: 0x00275FAD
	public VisionDirectionalFusionSelectTargetView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060080BD RID: 32957 RVA: 0x00277DB8 File Offset: 0x00275FB8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(2, typeof(UUIGridLayout)),
			new ValueTuple<int, Type>(1, typeof(UUIButtonComponent))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(1, new Action(this.OnClickRightBtn))
		};
	}

	// Token: 0x060080BE RID: 32958 RVA: 0x00277E20 File Offset: 0x00276020
	protected override void OnStart()
	{
		this.GirdLayout = new GenericLayout<SelectTargetItem, int>(base.GetGridLayout(2), new Func<SelectTargetItem>(this.InitGird), null, false, true);
		IReadOnlyList<PhantomDirectRefining> phantomDirectRefiningAll = CalabashConfig.Instance.GetPhantomDirectRefiningAll();
		List<int> list = new List<int>();
		if (phantomDirectRefiningAll != null)
		{
			foreach (PhantomDirectRefining phantomDirectRefining in phantomDirectRefiningAll)
			{
				list.Add(phantomDirectRefining.FetterGroup);
			}
		}
		list.Sort(delegate(int a, int b)
		{
			int[] fetterGroupMonsterIdArray = PhantomBattleModel.Instance.GetFetterGroupMonsterIdArray(a);
			int num = (PhantomBattleModel.Instance.GetMonsterFindCountByMonsterIdArrayWithoutCost4(fetterGroupMonsterIdArray) > 0) ? 1 : 0;
			int[] fetterGroupMonsterIdArray2 = PhantomBattleModel.Instance.GetFetterGroupMonsterIdArray(b);
			int num2 = (PhantomBattleModel.Instance.GetMonsterFindCountByMonsterIdArrayWithoutCost4(fetterGroupMonsterIdArray2) > 0) ? 1 : 0;
			if (num != num2)
			{
				return num2 - num;
			}
			return b - a;
		});
		this.GirdLayout.RefreshByData(list, delegate
		{
			this.RefreshButton();
		}, false);
	}

	// Token: 0x060080BF RID: 32959 RVA: 0x00277EE4 File Offset: 0x002760E4
	private SelectTargetItem InitGird()
	{
		return new SelectTargetItem
		{
			OnClickToggleCallBack = new Action<int, UUIExtendToggle>(this.OnClickGirdToggle)
		};
	}

	// Token: 0x060080C0 RID: 32960 RVA: 0x00277EFD File Offset: 0x002760FD
	private void RefreshButton()
	{
		base.GetButton(1).SetSelfInteractive(this.CurrentSelectFetter > 0);
	}

	// Token: 0x060080C1 RID: 32961 RVA: 0x00277F14 File Offset: 0x00276114
	private void OnClickRightBtn()
	{
		CalabashModel.Instance.SetDirectionalFusionTargetFetter(this.CurrentSelectFetter);
		base.CloseMe(null);
	}

	// Token: 0x060080C2 RID: 32962 RVA: 0x00277F30 File Offset: 0x00276130
	private void OnClickGirdToggle(int fetter, UUIExtendToggle toggle)
	{
		if (fetter <= 0)
		{
			this.CurrentSelectFetter = fetter;
			this.CurrentSelectToggle = null;
			this.RefreshButton();
			return;
		}
		if (this.CurrentSelectFetter == fetter)
		{
			return;
		}
		UUIExtendToggle currentSelectToggle = this.CurrentSelectToggle;
		if (currentSelectToggle != null)
		{
			currentSelectToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
		}
		this.CurrentSelectToggle = toggle;
		this.CurrentSelectFetter = fetter;
		this.RefreshButton();
	}

	// Token: 0x04004F49 RID: 20297
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<SelectTargetItem, int> GirdLayout;

	// Token: 0x04004F4A RID: 20298
	private int CurrentSelectFetter;

	// Token: 0x04004F4B RID: 20299
	[Nullable(2)]
	private UUIExtendToggle CurrentSelectToggle;

	// Token: 0x02006EBF RID: 28351
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402433D RID: 148285
		LeftBtn,
		// Token: 0x0402433E RID: 148286
		RightBtn,
		// Token: 0x0402433F RID: 148287
		GirdLayout
	}
}
