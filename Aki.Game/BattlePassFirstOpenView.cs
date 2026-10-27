using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;

// Token: 0x02002324 RID: 8996
public class BattlePassFirstOpenView : UiViewBase
{
	// Token: 0x06011CA1 RID: 72865 RVA: 0x00460F02 File Offset: 0x0045F102
	[NullableContext(1)]
	public BattlePassFirstOpenView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06011CA2 RID: 72866 RVA: 0x00460F0B File Offset: 0x0045F10B
	protected override void OnBeforeShow()
	{
		BattlePassController.Instance.SetBattlePassEnter();
		base.PlaySequence("BpStart", delegate
		{
			UiManager.Instance.OpenViewAsync(EUiViewName.BattlePassMainView, null, null).ContinueWith(delegate(int? _)
			{
				base.CloseMe(null);
			}).Forget();
		}, false);
	}
}
