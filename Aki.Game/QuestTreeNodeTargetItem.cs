using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020026BC RID: 9916
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class QuestTreeNodeTargetItem : GridProxyAbstract<IQuestTreeNodeTarget>
{
	// Token: 0x0601454A RID: 83274 RVA: 0x00524C44 File Offset: 0x00522E44
	protected unsafe override void OnRegisterComponent()
	{
		int num = 7;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnSelfClick));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0601454B RID: 83275 RVA: 0x00524D8F File Offset: 0x00522F8F
	public void SetNode(QuestTreeNodeData node)
	{
		this.Node = node;
	}

	// Token: 0x0601454C RID: 83276 RVA: 0x00524D98 File Offset: 0x00522F98
	public override void Refresh(IQuestTreeNodeTarget data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		base.GetItem(1).SetUIActive(data.Type == EQuestTreeNodeTargetType.Step);
		base.GetItem(3).SetUIActive(data.IsFinished.GetValueOrDefault());
		UUIItem item = base.GetItem(4);
		bool flag;
		if (data != null)
		{
			int? helpId = data.HelpId;
			if (helpId != null && helpId.GetValueOrDefault() != 0 && !(data.IsFinished ?? false))
			{
				flag = true;
				goto IL_78;
			}
		}
		flag = false;
		IL_78:
		item.SetUIActive(flag);
		UUIItem item2 = base.GetItem(5);
		flag = ((data.GotoId ?? 0) != 0 || data.OnGoto != null);
		if (flag)
		{
			bool flag2 = !(data.IsFinished ?? false);
			flag = flag2;
		}
		item2.SetUIActive(flag);
		UUIItem item3 = base.GetItem(6);
		bool uiactive;
		if (!data.IsFinished.GetValueOrDefault() && data.Type == EQuestTreeNodeTargetType.UnlockCondition)
		{
			if (data.HelpId != null)
			{
				int? helpId = data.HelpId;
				int num = 0;
				if (!(helpId.GetValueOrDefault() == num & helpId != null))
				{
					goto IL_132;
				}
			}
			uiactive = (data.OnGoto == null);
			goto IL_133;
		}
		IL_132:
		uiactive = false;
		IL_133:
		item3.SetUIActive(uiactive);
		if (!string.IsNullOrEmpty(data.Text))
		{
			base.GetText(2).SetText(data.Text, true);
		}
		else if (!string.IsNullOrEmpty(data.TextKey))
		{
			LguiUtil instance = LguiUtil.Instance;
			UUIText text = base.GetText(2);
			string textKey = data.TextKey;
			List<object> textParam = data.TextParam;
			instance.SetLocalTextNew(text, textKey, ((textParam != null) ? textParam.ToArray() : null) ?? Array.Empty<object>());
		}
		UUIExtendToggle extendToggle = base.GetExtendToggle(0);
		if (data.IsFinished.GetValueOrDefault() || data.Type == EQuestTreeNodeTargetType.Step)
		{
			extendToggle.SetToggleStateForce(EToggleState.ETT_UnDetermined, false, true, true);
			return;
		}
		extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x0601454D RID: 83277 RVA: 0x00524F78 File Offset: 0x00523178
	private void OnSelfClick(EToggleState _)
	{
		if (this.Data.OnGoto != null && !this.Data.IsFinished.GetValueOrDefault())
		{
			this.Data.OnGoto();
		}
		if (this.Data.HelpId != null)
		{
			int? helpId = this.Data.HelpId;
			int num = 0;
			if (helpId.GetValueOrDefault() > num & helpId != null)
			{
				HelpController.Instance.OpenHelpById(this.Data.HelpId.Value);
			}
		}
		if (this.Node != null)
		{
			QuestTreeController.Instance.ReportJump(this.Node, EQuestTreeLogReportJumpMotion.PreQuest);
		}
		base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x040098DD RID: 39133
	private IQuestTreeNodeTarget Data;

	// Token: 0x040098DE RID: 39134
	[Nullable(2)]
	private QuestTreeNodeData Node;

	// Token: 0x02008D1A RID: 36122
	[NullableContext(0)]
	private class EComponentDefine
	{
		// Token: 0x0402DCC7 RID: 187591
		public const int ToggleSelf = 0;

		// Token: 0x0402DCC8 RID: 187592
		public const int ItemLeftIcon = 1;

		// Token: 0x0402DCC9 RID: 187593
		public const int TextDesc = 2;

		// Token: 0x0402DCCA RID: 187594
		public const int ItemFinished = 3;

		// Token: 0x0402DCCB RID: 187595
		public const int ItemHelp = 4;

		// Token: 0x0402DCCC RID: 187596
		public const int ItemGoto = 5;

		// Token: 0x0402DCCD RID: 187597
		public const int ItemLock = 6;
	}
}
