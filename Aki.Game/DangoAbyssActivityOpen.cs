using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.GenericPrompt.View;
using CSharpScript.Game.Ui;

// Token: 0x02001A24 RID: 6692
public class DangoAbyssActivityOpen : GenericPromptFloatTipsBase
{
	// Token: 0x0600C4EE RID: 50414 RVA: 0x002CABBC File Offset: 0x002C8DBC
	[NullableContext(1)]
	public DangoAbyssActivityOpen(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600C4EF RID: 50415 RVA: 0x002CABC5 File Offset: 0x002C8DC5
	protected override void SetMainText([ParamCollection] [Nullable(new byte[]
	{
		1,
		2
	})] IReadOnlyList<object> param)
	{
	}

	// Token: 0x0600C4F0 RID: 50416 RVA: 0x002CABC7 File Offset: 0x002C8DC7
	protected override void SetExtraText([ParamCollection] [Nullable(new byte[]
	{
		1,
		2
	})] IReadOnlyList<object> param)
	{
	}
}
