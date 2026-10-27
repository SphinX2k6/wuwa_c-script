using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020028CE RID: 10446
public class RoleTagDetailView : UiViewBase
{
	// Token: 0x06015912 RID: 88338 RVA: 0x00572443 File Offset: 0x00570643
	[NullableContext(1)]
	public RoleTagDetailView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06015913 RID: 88339 RVA: 0x0057244C File Offset: 0x0057064C
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

	// Token: 0x06015914 RID: 88340 RVA: 0x005724BC File Offset: 0x005706BC
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

	// Token: 0x06015915 RID: 88341 RVA: 0x005725AC File Offset: 0x005707AC
	[NullableContext(1)]
	private RoleTagDetailItem InitRoleTagItem()
	{
		return new RoleTagDetailItem();
	}

	// Token: 0x06015916 RID: 88342 RVA: 0x005725B3 File Offset: 0x005707B3
	private void OnCloseCallBack()
	{
		base.CloseMe(null);
	}

	// Token: 0x0400A08D RID: 41101
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x0400A08E RID: 41102
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<RoleTagDetailItem, int> RoleTagLayout;

	// Token: 0x0400A08F RID: 41103
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericLayout<RoleTagDetailItem, int> OtherTagLayout;

	// Token: 0x02008EE4 RID: 36580
	private enum EComponent
	{
		// Token: 0x0402E565 RID: 189797
		CaptionItem,
		// Token: 0x0402E566 RID: 189798
		RoleTagRoot,
		// Token: 0x0402E567 RID: 189799
		OtherTagRoot,
		// Token: 0x0402E568 RID: 189800
		TagItem
	}
}
