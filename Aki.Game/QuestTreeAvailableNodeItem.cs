using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020026A9 RID: 9897
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class QuestTreeAvailableNodeItem : GridProxyAbstract<QuestTreeNodeData>
{
	// Token: 0x06014464 RID: 83044 RVA: 0x0051FA00 File Offset: 0x0051DC00
	protected unsafe override void OnRegisterComponent()
	{
		int num = 9;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(7, typeof(UUISprite));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickGoto));
		this.BtnBindInfo = list2;
	}

	// Token: 0x06014465 RID: 83045 RVA: 0x0051FB90 File Offset: 0x0051DD90
	public override void Refresh(QuestTreeNodeData data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		this.SetSpriteByPath(data.TypeIconPath, base.GetSprite(7), false, null, null);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), data.Config.Name, Array.Empty<object>());
		base.GetSprite(0).SetUIActive(data.Type.GetValueOrDefault() == EQuest.Branch);
		base.GetSprite(1).SetUIActive(data.Type.GetValueOrDefault() == EQuest.POI || data.Type.GetValueOrDefault() == EQuest.POI2);
		base.GetItem(8).SetUIActive(data.HasNewTag());
		base.GetSprite(5).SetUIActive(false);
		base.GetText(6).SetUIActive(false);
		base.GetButton(3).GetRootComponent().SetUIActive(true);
		data.RemoveNewTag();
	}

	// Token: 0x06014466 RID: 83046 RVA: 0x0051FC7C File Offset: 0x0051DE7C
	private void OnClickGoto()
	{
		if (UiManager.Instance.IsViewOpen(EUiViewName.QuestTreeChapterView))
		{
			QuestTreeModel.Instance.ViewModelChapter.SelectData(this.Data);
		}
		else
		{
			QuestTreeController.Instance.OpenChapterView(this.Data.ChapterId, new int?(this.Data.Id));
		}
		QuestTreeController.Instance.OpenNodeDetailView(this.Data);
		UiManager.Instance.CloseView(EUiViewName.QuestTreeAvailableListView, null);
	}

	// Token: 0x0400988A RID: 39050
	private QuestTreeNodeData Data;

	// Token: 0x02008CEA RID: 36074
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x0402DB7B RID: 187259
		public const int SpriteBlueBg = 0;

		// Token: 0x0402DB7C RID: 187260
		public const int SpriteGreenBg = 1;

		// Token: 0x0402DB7D RID: 187261
		public const int TextName = 2;

		// Token: 0x0402DB7E RID: 187262
		public const int BtnGoto = 3;

		// Token: 0x0402DB7F RID: 187263
		public const int BtnGoto2 = 4;

		// Token: 0x0402DB80 RID: 187264
		public const int SpriteFinish = 5;

		// Token: 0x0402DB81 RID: 187265
		public const int TextInProgress = 6;

		// Token: 0x0402DB82 RID: 187266
		public const int SpriteTypeIcon = 7;

		// Token: 0x0402DB83 RID: 187267
		public const int ItemNew = 8;
	}
}
