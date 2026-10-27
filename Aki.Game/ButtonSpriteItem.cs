using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020017EA RID: 6122
public class ButtonSpriteItem : UiPanelBase
{
	// Token: 0x0600B323 RID: 45859 RVA: 0x00287B34 File Offset: 0x00285D34
	protected unsafe override void OnRegisterComponent()
	{
		int num = 3;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.ButtonClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600B324 RID: 45860 RVA: 0x00287BFB File Offset: 0x00285DFB
	protected override void OnBeforeDestroy()
	{
		this.UnBindRedDot();
	}

	// Token: 0x0600B325 RID: 45861 RVA: 0x00287C03 File Offset: 0x00285E03
	private void ButtonClick()
	{
		if (this.ButtonFunction != null)
		{
			this.ButtonFunction();
		}
	}

	// Token: 0x0600B326 RID: 45862 RVA: 0x00287C18 File Offset: 0x00285E18
	[NullableContext(2)]
	public UUIButtonComponent GetBtn()
	{
		return base.GetButton(0);
	}

	// Token: 0x0600B327 RID: 45863 RVA: 0x00287C24 File Offset: 0x00285E24
	public void SetButtonAllowEventBubbleUp(bool value)
	{
		UUIButtonComponent button = base.GetButton(0);
		if (button != null)
		{
			button.AllowEventBubbleUp = value;
		}
	}

	// Token: 0x0600B328 RID: 45864 RVA: 0x00287C44 File Offset: 0x00285E44
	public void SetEnableClick(bool state)
	{
		UUIButtonComponent button = base.GetButton(0);
		if (button != null)
		{
			button.SetSelfInteractive(state);
		}
	}

	// Token: 0x0600B329 RID: 45865 RVA: 0x00287C63 File Offset: 0x00285E63
	[NullableContext(1)]
	public void SetFunction(Action buttonFunction)
	{
		this.ButtonFunction = buttonFunction;
	}

	// Token: 0x0600B32A RID: 45866 RVA: 0x00287C6C File Offset: 0x00285E6C
	public void SetSpriteVisible(bool bVisible)
	{
		base.GetSprite(1).SetUIActive(bVisible);
	}

	// Token: 0x0600B32B RID: 45867 RVA: 0x00287C7C File Offset: 0x00285E7C
	[NullableContext(1)]
	public void SetSprite(string path)
	{
		UUISprite sprite = base.GetSprite(1);
		sprite.SetUIActive(false);
		this.SetSpriteByPath(path, sprite, false, null, delegate(bool success)
		{
			sprite.SetUIActive(success);
		});
	}

	// Token: 0x0600B32C RID: 45868 RVA: 0x00287CCB File Offset: 0x00285ECB
	public void SetRedDotVisible(bool bVisible)
	{
		UUIItem item = base.GetItem(2);
		if (item == null)
		{
			return;
		}
		item.SetUIActive(bVisible);
	}

	// Token: 0x0600B32D RID: 45869 RVA: 0x00287CE0 File Offset: 0x00285EE0
	public void BindRedDot(ERedDotName redDotName, int uId = 0)
	{
		UUIItem item = base.GetItem(2);
		if (item == null)
		{
			return;
		}
		this.UnBindRedDot();
		this.RedDotName = new ERedDotName?(redDotName);
		this.RedDotUid = uId;
		if (this.RedDotName != null)
		{
			RedDotController.Instance.BindRedDot(redDotName, item, null, uId);
		}
	}

	// Token: 0x0600B32E RID: 45870 RVA: 0x00287D30 File Offset: 0x00285F30
	public void UnBindRedDot()
	{
		if (this.RedDotName != null)
		{
			UUIItem item = base.GetItem(2);
			RedDotController.Instance.UnBindGivenUi(this.RedDotName.Value, item, this.RedDotUid);
			this.RedDotName = null;
			this.RedDotUid = 0;
		}
	}

	// Token: 0x0400511A RID: 20762
	private ERedDotName? RedDotName;

	// Token: 0x0400511B RID: 20763
	private int RedDotUid;

	// Token: 0x0400511C RID: 20764
	[Nullable(2)]
	private Action ButtonFunction;

	// Token: 0x02007DD7 RID: 32215
	private class EButtonItemDefine
	{
		// Token: 0x04029313 RID: 168723
		public const int Button = 0;

		// Token: 0x04029314 RID: 168724
		public const int Sprite = 1;

		// Token: 0x04029315 RID: 168725
		public const int RedDot = 2;
	}
}
