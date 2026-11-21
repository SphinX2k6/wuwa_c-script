using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;

// Token: 0x02001006 RID: 4102
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchGachaTask : FloroRanchDailyTaskBase
{
	// Token: 0x0600A36E RID: 41838 RVA: 0x002FEF96 File Offset: 0x002FD196
	public FloroRanchGachaTask(FloroRanchGacha data)
	{
		this.GachaData = data;
	}

	// Token: 0x0600A36F RID: 41839 RVA: 0x002FEFA8 File Offset: 0x002FD1A8
	protected override void OnExecute()
	{
		FloroRanchCardSelectViewParam floroRanchCardSelectViewParam = new FloroRanchCardSelectViewParam
		{
			GachaData = this.GachaData,
			CloseCallback = delegate()
			{
				base.Complete(null);
			}
		};
		FloroRanchGamePlayModel.Instance.OpenAndRecordView(EUiViewName.FloroRanchCardSelectView, floroRanchCardSelectViewParam, null);
	}

	// Token: 0x0400602D RID: 24621
	private readonly FloroRanchGacha GachaData;
}
