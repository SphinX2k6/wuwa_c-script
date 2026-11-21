using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.TDConfigMgr.Quest;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001B94 RID: 7060
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class QuestTreeAvailableNodeItem : GridProxyAbstract<QuestTreeNodeData>
{
	// Token: 0x06011946 RID: 72006 RVA: 0x0052E738 File Offset: 0x0052C938
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

	// Token: 0x06011947 RID: 72007 RVA: 0x0052E8C8 File Offset: 0x0052CAC8
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

	// Token: 0x06011948 RID: 72008 RVA: 0x0052E9B4 File Offset: 0x0052CBB4
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

	// Token: 0x040099E2 RID: 39394
	private QuestTreeNodeData Data;

	// Token: 0x02007E73 RID: 32371
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x04028E92 RID: 167570
		public const int SpriteBlueBg = 0;

		// Token: 0x04028E93 RID: 167571
		public const int SpriteGreenBg = 1;

		// Token: 0x04028E94 RID: 167572
		public const int TextName = 2;

		// Token: 0x04028E95 RID: 167573
		public const int BtnGoto = 3;

		// Token: 0x04028E96 RID: 167574
		public const int BtnGoto2 = 4;

		// Token: 0x04028E97 RID: 167575
		public const int SpriteFinish = 5;

		// Token: 0x04028E98 RID: 167576
		public const int TextInProgress = 6;

		// Token: 0x04028E99 RID: 167577
		public const int SpriteTypeIcon = 7;

		// Token: 0x04028E9A RID: 167578
		public const int ItemNew = 8;
	}
}
