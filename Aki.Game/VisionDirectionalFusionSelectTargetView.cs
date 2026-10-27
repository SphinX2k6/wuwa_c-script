using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001756 RID: 5974
[NullableContext(1)]
[Nullable(0)]
public class VisionDirectionalFusionSelectTargetView : UiViewBase
{
	// Token: 0x0600ACD5 RID: 44245 RVA: 0x0026D931 File Offset: 0x0026BB31
	public VisionDirectionalFusionSelectTargetView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600ACD6 RID: 44246 RVA: 0x0026D93C File Offset: 0x0026BB3C
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

	// Token: 0x0600ACD7 RID: 44247 RVA: 0x0026D9A4 File Offset: 0x0026BBA4
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

	// Token: 0x0600ACD8 RID: 44248 RVA: 0x0026DA68 File Offset: 0x0026BC68
	private SelectTargetItem InitGird()
	{
		return new SelectTargetItem
		{
			OnClickToggleCallBack = new Action<int, UUIExtendToggle>(this.OnClickGirdToggle)
		};
	}

	// Token: 0x0600ACD9 RID: 44249 RVA: 0x0026DA81 File Offset: 0x0026BC81
	private void RefreshButton()
	{
		base.GetButton(1).SetSelfInteractive(this.CurrentSelectFetter > 0);
	}

	// Token: 0x0600ACDA RID: 44250 RVA: 0x0026DA98 File Offset: 0x0026BC98
	private void OnClickRightBtn()
	{
		CalabashModel.Instance.SetDirectionalFusionTargetFetter(this.CurrentSelectFetter);
		base.CloseMe(null);
	}

	// Token: 0x0600ACDB RID: 44251 RVA: 0x0026DAB4 File Offset: 0x0026BCB4
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

	// Token: 0x04004EA0 RID: 20128
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<SelectTargetItem, int> GirdLayout;

	// Token: 0x04004EA1 RID: 20129
	private int CurrentSelectFetter;

	// Token: 0x04004EA2 RID: 20130
	[Nullable(2)]
	private UUIExtendToggle CurrentSelectToggle;

	// Token: 0x02007D39 RID: 32057
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04029012 RID: 167954
		LeftBtn,
		// Token: 0x04029013 RID: 167955
		RightBtn,
		// Token: 0x04029014 RID: 167956
		GirdLayout
	}
}
