using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Module.Util.Layout;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020016D8 RID: 5848
[NullableContext(1)]
[Nullable(0)]
public class AdviceSelectMotionItem : UiPanelBase
{
	// Token: 0x0600A778 RID: 42872 RVA: 0x002593E4 File Offset: 0x002575E4
	public AdviceSelectMotionItem(UUIItem uiItem)
	{
		base.CreateThenShowByActor(uiItem.GetOwner(), null);
	}

	// Token: 0x0600A779 RID: 42873 RVA: 0x002593FC File Offset: 0x002575FC
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

	// Token: 0x0600A77A RID: 42874 RVA: 0x00259479 File Offset: 0x00257679
	private void OnBtnClick()
	{
		Action onClickBtnBtnCall = this.OnClickBtnBtnCall;
		if (onClickBtnBtnCall == null)
		{
			return;
		}
		onClickBtnBtnCall();
	}

	// Token: 0x0600A77B RID: 42875 RVA: 0x0025948B File Offset: 0x0025768B
	public void SetClickChangeRoleCall(Action call)
	{
		this.OnClickBtnBtnCall = call;
	}

	// Token: 0x0600A77C RID: 42876 RVA: 0x00259494 File Offset: 0x00257694
	protected override void OnStart()
	{
		this.Scroller = new GenericScrollView<AdviceSelectMotionContent>(base.GetScrollViewWithScrollbar(2), new CSharpScript.Game.Module.Util.Layout.TLayoutRefresh<AdviceSelectMotionContent>(this.CreateItem), null);
	}

	// Token: 0x0600A77D RID: 42877 RVA: 0x002594B8 File Offset: 0x002576B8
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

	// Token: 0x0600A77E RID: 42878 RVA: 0x002594F0 File Offset: 0x002576F0
	public void RefreshView(AdviceMotionSelectData[] data)
	{
		GenericScrollView<AdviceSelectMotionContent> scroller = this.Scroller;
		if (scroller != null)
		{
			scroller.RefreshByData<AdviceMotionSelectData>(data.ToList<AdviceMotionSelectData>(), null);
		}
		this.RefreshRoleName();
	}

	// Token: 0x0600A77F RID: 42879 RVA: 0x00259524 File Offset: 0x00257724
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

	// Token: 0x0600A780 RID: 42880 RVA: 0x002595AA File Offset: 0x002577AA
	protected override void OnBeforeDestroy()
	{
		GenericScrollView<AdviceSelectMotionContent> scroller = this.Scroller;
		if (scroller == null)
		{
			return;
		}
		scroller.ClearChildren();
	}

	// Token: 0x04004B8C RID: 19340
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollView<AdviceSelectMotionContent> Scroller;

	// Token: 0x04004B8D RID: 19341
	[Nullable(2)]
	protected Action OnClickBtnBtnCall;

	// Token: 0x02007CAC RID: 31916
	[NullableContext(0)]
	private static class EComponents
	{
		// Token: 0x04028E54 RID: 167508
		public const int MoreBtn = 0;

		// Token: 0x04028E55 RID: 167509
		public const int RoleName = 1;

		// Token: 0x04028E56 RID: 167510
		public const int Scroller = 2;
	}
}
