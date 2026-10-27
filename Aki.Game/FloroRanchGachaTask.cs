using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Ui;

// Token: 0x02001B47 RID: 6983
[NullableContext(1)]
[Nullable(0)]
public class FloroRanchGachaTask : FloroRanchDailyTaskBase
{
	// Token: 0x0600CF5D RID: 53085 RVA: 0x002F3EBE File Offset: 0x002F20BE
	public FloroRanchGachaTask(FloroRanchGacha data)
	{
		this.GachaData = data;
	}

	// Token: 0x0600CF5E RID: 53086 RVA: 0x002F3ED0 File Offset: 0x002F20D0
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

	// Token: 0x04005F5E RID: 24414
	private readonly FloroRanchGacha GachaData;
}
