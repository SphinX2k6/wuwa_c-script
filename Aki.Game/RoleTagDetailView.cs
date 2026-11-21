using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001E49 RID: 7753
public class RoleTagDetailView : UiViewBase
{
	// Token: 0x06013312 RID: 78610 RVA: 0x0059D2FB File Offset: 0x0059B4FB
	[NullableContext(1)]
	public RoleTagDetailView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06013313 RID: 78611 RVA: 0x0059D304 File Offset: 0x0059B504
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(2, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(3, typeof(UUIItem))
		};
	}

	// Token: 0x06013314 RID: 78612 RVA: 0x0059D374 File Offset: 0x0059B574
	protected override void OnStart()
	{
		int[] array = this.OpenParam as int[];
		if (array == null)
		{
			Log.Instance.Error(ELogModule.Role, ELogAuthor.BB, "RoleTagDetailView无效tagList", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		this.CaptionItem = new PopupCaptionItem(base.GetItem(0));
		this.CaptionItem.SetCloseCallBack(new Action(this.OnCloseCallBack));
		this.RoleTagLayout = new GenericLayout<RoleTagDetailItem, int>(base.GetVerticalLayout(1), new Func<RoleTagDetailItem>(this.InitRoleTagItem), base.GetItem(3).GetOwner() as AUIBaseActor, false, true);
		this.OtherTagLayout = new GenericLayout<RoleTagDetailItem, int>(base.GetVerticalLayout(2), new Func<RoleTagDetailItem>(this.InitRoleTagItem), base.GetItem(3).GetOwner() as AUIBaseActor, false, true);
		this.RoleTagLayout.RefreshByData(new List<int>(array), null, false);
		List<int> allRoleTagList = RoleConfig.Instance.GetAllRoleTagList();
		this.OtherTagLayout.RefreshByData(allRoleTagList, null, false);
	}

	// Token: 0x06013315 RID: 78613 RVA: 0x0059D464 File Offset: 0x0059B664
	[NullableContext(1)]
	private RoleTagDetailItem InitRoleTagItem()
	{
		return new RoleTagDetailItem();
	}

	// Token: 0x06013316 RID: 78614 RVA: 0x0059D46B File Offset: 0x0059B66B
	private void OnCloseCallBack()
	{
		base.CloseMe(null);
	}

	// Token: 0x0400A476 RID: 42102
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x0400A477 RID: 42103
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<RoleTagDetailItem, int> RoleTagLayout;

	// Token: 0x0400A478 RID: 42104
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<RoleTagDetailItem, int> OtherTagLayout;

	// Token: 0x0200812C RID: 33068
	private enum EComponent
	{
		// Token: 0x04029C60 RID: 171104
		CaptionItem,
		// Token: 0x04029C61 RID: 171105
		RoleTagRoot,
		// Token: 0x04029C62 RID: 171106
		OtherTagRoot,
		// Token: 0x04029C63 RID: 171107
		TagItem
	}
}
