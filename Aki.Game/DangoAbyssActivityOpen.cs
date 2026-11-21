using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.GenericPrompt.View;
using CSharpScript.Game.Ui;

// Token: 0x02000EE3 RID: 3811
public class DangoAbyssActivityOpen : GenericPromptFloatTipsBase
{
	// Token: 0x060098FE RID: 39166 RVA: 0x002D5CDC File Offset: 0x002D3EDC
	[NullableContext(1)]
	public DangoAbyssActivityOpen(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060098FF RID: 39167 RVA: 0x002D5CE5 File Offset: 0x002D3EE5
	protected override void SetMainText([ParamCollection] [Nullable(new byte[]
	{
		1,
		2
	})] IReadOnlyList<object> param)
	{
	}

	// Token: 0x06009900 RID: 39168 RVA: 0x002D5CE7 File Offset: 0x002D3EE7
	protected override void SetExtraText([ParamCollection] [Nullable(new byte[]
	{
		1,
		2
	})] IReadOnlyList<object> param)
	{
	}
}
