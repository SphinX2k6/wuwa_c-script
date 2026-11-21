using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001B47 RID: 6983
[NullableContext(1)]
[Nullable(0)]
public class NewMissionTips : UiTickViewBase
{
	// Token: 0x0601165D RID: 71261 RVA: 0x0051F738 File Offset: 0x0051D938
	public NewMissionTips(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0601165E RID: 71262 RVA: 0x0051F764 File Offset: 0x0051D964
	protected unsafe override void OnRegisterComponent()
	{
		int num = 2;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUISprite));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x0601165F RID: 71263 RVA: 0x0051F7D0 File Offset: 0x0051D9D0
	protected override void OnBeforeCreate()
	{
		base.OnBeforeCreate();
		object openParam = this.OpenParam;
		if (openParam is int)
		{
			int num = (int)openParam;
			Quest quest = QuestNewModel.Instance.GetQuest(num);
			if (quest == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Quest;
				ELogAuthor author = ELogAuthor.YSQ;
				string message = "Quest:NewMissionTips.OnBeforeCreate 找不到任务";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("questId", num);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				base.CloseMe(null);
				return;
			}
			this.MarkIconPath = (QuestNewConfig.Instance.GetQuestTypeMark(quest.QuestMarkId) ?? "");
			this.QuestNameTid = quest.NameKey;
			this.RemainTime = (float)QuestNewConfig.Instance.GetNewTipsShowTime((int)quest.Type).GetValueOrDefault();
		}
	}

	// Token: 0x06011660 RID: 71264 RVA: 0x0051F88C File Offset: 0x0051DA8C
	protected override void OnStart()
	{
		base.OnStart();
		UUISprite sprite = base.GetSprite(1);
		if (sprite != null && !StringUtils.IsBlank(this.MarkIconPath))
		{
			this.SetSpriteByPath(this.MarkIconPath, sprite, false, null, null);
			sprite.SetUIActive(true);
		}
		UUIText text = base.GetText(0);
		if (text != null)
		{
			text.OnSelfLanguageChange.Bind(new Action(this.UpdateQuestNameText));
			this.UpdateQuestNameText();
			text.SetUIActive(true);
		}
	}

	// Token: 0x06011661 RID: 71265 RVA: 0x0051F908 File Offset: 0x0051DB08
	private void UpdateQuestNameText()
	{
		string configTextByKey = PublicUtil.Instance.GetConfigTextByKey(this.QuestNameTid);
		UUIText text = base.GetText(0);
		if (text == null)
		{
			return;
		}
		text.SetText(configTextByKey, true);
	}

	// Token: 0x06011662 RID: 71266 RVA: 0x0051F93C File Offset: 0x0051DB3C
	protected override void OnTick(float delta)
	{
		this.RemainTime = Math.Max(this.RemainTime - delta / 1000f * Time.Instance.TimeDilation, 0f);
		if (this.RemainTime <= 0f && !this.CloseCalled)
		{
			this.CloseView();
		}
	}

	// Token: 0x06011663 RID: 71267 RVA: 0x0051F98D File Offset: 0x0051DB8D
	private void CloseView()
	{
		this.CloseCalled = true;
		base.CloseMe(null);
	}

	// Token: 0x040098D3 RID: 39123
	private string MarkIconPath = "";

	// Token: 0x040098D4 RID: 39124
	private string QuestNameTid = "";

	// Token: 0x040098D5 RID: 39125
	private float RemainTime = 5f;

	// Token: 0x040098D6 RID: 39126
	private bool CloseCalled;

	// Token: 0x02007E20 RID: 32288
	[NullableContext(0)]
	private class EChildComponent
	{
		// Token: 0x04028D2D RID: 167213
		public const int QuestNameText = 0;

		// Token: 0x04028D2E RID: 167214
		public const int Icon = 1;
	}
}
