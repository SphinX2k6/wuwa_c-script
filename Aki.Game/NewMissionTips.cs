using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200265C RID: 9820
[NullableContext(1)]
[Nullable(0)]
public class NewMissionTips : UiTickViewBase
{
	// Token: 0x0601417B RID: 82299 RVA: 0x00510A80 File Offset: 0x0050EC80
	public NewMissionTips(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0601417C RID: 82300 RVA: 0x00510AAC File Offset: 0x0050ECAC
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

	// Token: 0x0601417D RID: 82301 RVA: 0x00510B18 File Offset: 0x0050ED18
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

	// Token: 0x0601417E RID: 82302 RVA: 0x00510BD4 File Offset: 0x0050EDD4
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

	// Token: 0x0601417F RID: 82303 RVA: 0x00510C50 File Offset: 0x0050EE50
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

	// Token: 0x06014180 RID: 82304 RVA: 0x00510C84 File Offset: 0x0050EE84
	protected override void OnTick(float delta)
	{
		this.RemainTime = Math.Max(this.RemainTime - delta / 1000f * Time.Instance.TimeDilation, 0f);
		if (this.RemainTime <= 0f && !this.CloseCalled)
		{
			this.CloseView();
		}
	}

	// Token: 0x06014181 RID: 82305 RVA: 0x00510CD5 File Offset: 0x0050EED5
	private void CloseView()
	{
		this.CloseCalled = true;
		base.CloseMe(null);
	}

	// Token: 0x0400977B RID: 38779
	private string MarkIconPath = "";

	// Token: 0x0400977C RID: 38780
	private string QuestNameTid = "";

	// Token: 0x0400977D RID: 38781
	private float RemainTime = 5f;

	// Token: 0x0400977E RID: 38782
	private bool CloseCalled;

	// Token: 0x02008C97 RID: 35991
	[NullableContext(0)]
	private class EChildComponent
	{
		// Token: 0x0402DA16 RID: 186902
		public const int QuestNameText = 0;

		// Token: 0x0402DA17 RID: 186903
		public const int Icon = 1;
	}
}
