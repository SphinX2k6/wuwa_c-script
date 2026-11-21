using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020017D3 RID: 6099
[NullableContext(1)]
[Nullable(0)]
public class OnlineHallSettingButton : UiPanelBase
{
	// Token: 0x0600EE82 RID: 61058 RVA: 0x0045F7DC File Offset: 0x0045D9DC
	public OnlineHallSettingButton(AActor uiContainerActor, WorldEnterPermission type)
	{
		this.Type = type;
		base.CreateThenShowByActor(uiContainerActor, null);
	}

	// Token: 0x0600EE83 RID: 61059 RVA: 0x0045F7F4 File Offset: 0x0045D9F4
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0600EE84 RID: 61060 RVA: 0x0045F85D File Offset: 0x0045DA5D
	protected override void OnStart()
	{
		this.InitType(this.Type);
		this.AddEvents();
	}

	// Token: 0x0600EE85 RID: 61061 RVA: 0x0045F871 File Offset: 0x0045DA71
	protected override void OnBeforeDestroy()
	{
		this.RemoveEvents();
	}

	// Token: 0x0600EE86 RID: 61062 RVA: 0x0045F879 File Offset: 0x0045DA79
	private void AddEvents()
	{
		base.GetExtendToggle(0).OnStateChange.Add(new Action<EToggleState>(this.OnSettingButtonClicked));
	}

	// Token: 0x0600EE87 RID: 61063 RVA: 0x0045F898 File Offset: 0x0045DA98
	private void RemoveEvents()
	{
		base.GetExtendToggle(0).OnStateChange.Remove(new Action<EToggleState>(this.OnSettingButtonClicked));
	}

	// Token: 0x0600EE88 RID: 61064 RVA: 0x0045F8B7 File Offset: 0x0045DAB7
	public void BindOnSettingButtonClickedCallback(Action<WorldEnterPermission> onSettingButtonClickedCallback)
	{
		this.OnSettingButtonClickedCallback = onSettingButtonClickedCallback;
	}

	// Token: 0x0600EE89 RID: 61065 RVA: 0x0045F8C0 File Offset: 0x0045DAC0
	public void BindCanToggleExecuteChange(Func<WorldEnterPermission, bool> toggle)
	{
		this.OnCanToggleClicked = toggle;
	}

	// Token: 0x0600EE8A RID: 61066 RVA: 0x0045F8C9 File Offset: 0x0045DAC9
	private bool CanToggleExecuteChange()
	{
		return this.OnCanToggleClicked == null || this.OnCanToggleClicked(this.Type);
	}

	// Token: 0x0600EE8B RID: 61067 RVA: 0x0045F8E8 File Offset: 0x0045DAE8
	public void SetSelected(bool bSelected)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (bSelected)
		{
			extendToggle.SetToggleStateForce(EToggleState.ETT_Checked, false, false, false);
			return;
		}
		extendToggle.SetToggleStateForce(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x0600EE8C RID: 61068 RVA: 0x0045F918 File Offset: 0x0045DB18
	private void InitType(WorldEnterPermission type)
	{
		UUIText text = base.GetText(1);
		string str = "PermissionsSetting_";
		int num = (int)type;
		string textTableId = str + num.ToString();
		LguiUtil.Instance.SetLocalText(text, textTableId, Array.Empty<object>());
		base.GetExtendToggle(0).CanExecuteChange.Bind(new Func<bool>(this.CanToggleExecuteChange));
	}

	// Token: 0x0600EE8D RID: 61069 RVA: 0x0045F96F File Offset: 0x0045DB6F
	private void OnSettingButtonClicked(EToggleState state)
	{
		if (state != EToggleState.ETT_Checked)
		{
			return;
		}
		if (this.OnSettingButtonClickedCallback != null)
		{
			this.OnSettingButtonClickedCallback(this.Type);
		}
	}

	// Token: 0x04008701 RID: 34561
	[Nullable(2)]
	private Action<WorldEnterPermission> OnSettingButtonClickedCallback;

	// Token: 0x04008702 RID: 34562
	private readonly WorldEnterPermission Type;

	// Token: 0x04008703 RID: 34563
	[Nullable(2)]
	private Func<WorldEnterPermission, bool> OnCanToggleClicked;

	// Token: 0x020079EA RID: 31210
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04027835 RID: 161845
		Tog,
		// Token: 0x04027836 RID: 161846
		TogText
	}
}
