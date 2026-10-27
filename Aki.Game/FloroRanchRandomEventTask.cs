using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;

// Token: 0x02001B49 RID: 6985
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchRandomEventTask : FloroRanchDailyTaskBase
{
	// Token: 0x0600CF60 RID: 53088 RVA: 0x002F3F26 File Offset: 0x002F2126
	public FloroRanchRandomEventTask(FloroRanchPlayEvent data)
	{
		this.EventData = data;
	}

	// Token: 0x0600CF61 RID: 53089 RVA: 0x002F3F38 File Offset: 0x002F2138
	protected override void OnExecute()
	{
		FloroRanchRandomEventViewParam floroRanchRandomEventViewParam = new FloroRanchRandomEventViewParam
		{
			EventData = this.EventData,
			CloseCallback = delegate()
			{
				base.Complete(null);
			}
		};
		FloroRanchGamePlayModel.Instance.OpenAndRecordView(EUiViewName.FloroRanchRandomEventView, floroRanchRandomEventViewParam, null);
	}

	// Token: 0x04005F61 RID: 24417
	private readonly FloroRanchPlayEvent EventData;
}
