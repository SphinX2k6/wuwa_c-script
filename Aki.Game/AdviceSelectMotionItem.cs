using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000B90 RID: 2960
[NullableContext(1)]
[Nullable(0)]
public class AdviceSelectMotionItem : UiPanelBase
{
	// Token: 0x06007B58 RID: 31576 RVA: 0x002637F0 File Offset: 0x002619F0
	public AdviceSelectMotionItem(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x06007B59 RID: 31577 RVA: 0x00263808 File Offset: 0x00261A08
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIScrollViewWithScrollbarComponent))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnBtnClick))
		};
	}

	// Token: 0x06007B5A RID: 31578 RVA: 0x00263885 File Offset: 0x00261A85
	private void OnBtnClick()
	{
		Action onClickBtnBtnCall = this.OnClickBtnBtnCall;
		if (onClickBtnBtnCall == null)
		{
			return;
		}
		onClickBtnBtnCall();
	}

	// Token: 0x06007B5B RID: 31579 RVA: 0x00263897 File Offset: 0x00261A97
	public void SetClickChangeRoleCall(Action call)
	{
		this.OnClickBtnBtnCall = call;
	}

	// Token: 0x06007B5C RID: 31580 RVA: 0x002638A0 File Offset: 0x00261AA0
	protected override void OnStart()
	{
		this.Scroller = new GenericScrollView<AdviceSelectMotionContent>(base.GetScrollViewWithScrollbar(2), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<AdviceSelectMotionContent>(this.CreateItem), null);
	}

	// Token: 0x06007B5D RID: 31581 RVA: 0x002638C4 File Offset: 0x00261AC4
	private ILayoutItem<AdviceSelectMotionContent> CreateItem(object data, UUIItem uiItem, int index)
	{
		AdviceSelectMotionContent adviceSelectMotionContent = new AdviceSelectMotionContent(uiItem);
		adviceSelectMotionContent.RefreshView((AdviceMotionSelectData)data);
		return new LayoutItem<AdviceSelectMotionContent>
		{
			Key = index,
			Value = adviceSelectMotionContent
		};
	}

	// Token: 0x06007B5E RID: 31582 RVA: 0x002638FC File Offset: 0x00261AFC
	public void RefreshView(AdviceMotionSelectData[] data)
	{
		GenericScrollView<AdviceSelectMotionContent> scroller = this.Scroller;
		if (scroller != null)
		{
			scroller.RefreshByData<AdviceMotionSelectData>(data, null);
		}
		this.RefreshRoleName();
	}

	// Token: 0x06007B5F RID: 31583 RVA: 0x0026392C File Offset: 0x00261B2C
	private void RefreshRoleName()
	{
		if (AdviceModel.Instance.PreSelectRoleId > 0)
		{
			RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(AdviceModel.Instance.PreSelectRoleId);
			if (roleConfig != null)
			{
				string roleName = RoleConfig.Instance.GetRoleName(roleConfig.Value.Name);
				UUIText text = base.GetText(1);
				if (text == null)
				{
					return;
				}
				text.SetText(roleName ?? "", true);
				return;
			}
		}
		else
		{
			UUIText text2 = base.GetText(1);
			if (text2 == null)
			{
				return;
			}
			text2.SetText("", true);
		}
	}

	// Token: 0x06007B60 RID: 31584 RVA: 0x002639B2 File Offset: 0x00261BB2
	protected override void OnBeforeDestroy()
	{
		GenericScrollView<AdviceSelectMotionContent> scroller = this.Scroller;
		if (scroller == null)
		{
			return;
		}
		scroller.ClearChildren();
	}

	// Token: 0x04004C33 RID: 19507
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollView<AdviceSelectMotionContent> Scroller;

	// Token: 0x04004C34 RID: 19508
	[Nullable(2)]
	protected Action OnClickBtnBtnCall;

	// Token: 0x02006E31 RID: 28209
	[NullableContext(0)]
	private static class EComponents
	{
		// Token: 0x0402417D RID: 147837
		public const int MoreBtn = 0;

		// Token: 0x0402417E RID: 147838
		public const int RoleName = 1;

		// Token: 0x0402417F RID: 147839
		public const int Scroller = 2;
	}
}
