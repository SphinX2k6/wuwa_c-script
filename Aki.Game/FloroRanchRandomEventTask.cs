using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;

// Token: 0x02001008 RID: 4104
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchRandomEventTask : FloroRanchDailyTaskBase
{
	// Token: 0x0600A371 RID: 41841 RVA: 0x002FEFFE File Offset: 0x002FD1FE
	public FloroRanchRandomEventTask(FloroRanchPlayEvent data)
	{
		this.EventData = data;
	}

	// Token: 0x0600A372 RID: 41842 RVA: 0x002FF010 File Offset: 0x002FD210
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

	// Token: 0x04006030 RID: 24624
	private readonly FloroRanchPlayEvent EventData;
}
