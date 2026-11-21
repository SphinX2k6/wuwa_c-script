using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;

// Token: 0x02001809 RID: 6153
public class BattlePassFirstOpenView : UiViewBase
{
	// Token: 0x0600F151 RID: 61777 RVA: 0x0046DFA6 File Offset: 0x0046C1A6
	[NullableContext(1)]
	public BattlePassFirstOpenView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600F152 RID: 61778 RVA: 0x0046DFAF File Offset: 0x0046C1AF
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
