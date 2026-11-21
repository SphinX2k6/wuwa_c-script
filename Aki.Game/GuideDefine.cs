using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x0200127D RID: 4733
public class GuideDefine : IStaticVariableResetter
{
	// Token: 0x0600BB42 RID: 47938 RVA: 0x00372FAC File Offset: 0x003711AC
	static GuideDefine()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(GuideDefine.CreateStaticDefaultValue), new Action(GuideDefine.ResetStaticDefaultValue));
	}

	// Token: 0x0600BB43 RID: 47939 RVA: 0x00372FCB File Offset: 0x003711CB
	public static void CreateStaticDefaultValue()
	{
		GuideDefine.guideTipsAllowedViews = new List<EUiViewName>
		{
			EUiViewName.BattleView,
			EUiViewName.CommonGameMainView
		};
	}

	// Token: 0x0600BB44 RID: 47940 RVA: 0x00372FED File Offset: 0x003711ED
	public static void ResetStaticDefaultValue()
	{
		GuideDefine.guideTipsAllowedViews = null;
	}

	// Token: 0x0600BB45 RID: 47941 RVA: 0x00372FF8 File Offset: 0x003711F8
	[NullableContext(1)]
	public static bool isCustomTabViewForGuide(object viewObj)
	{
		GuideDefine.ICustomTabViewForGuide customTabViewForGuide = viewObj as GuideDefine.ICustomTabViewForGuide;
		return customTabViewForGuide != null && new Func<string>(customTabViewForGuide.GetViewName) != null;
	}

	// Token: 0x04006BCC RID: 27596
	[Nullable(1)]
	public static List<EUiViewName> guideTipsAllowedViews;

	// Token: 0x02007518 RID: 29976
	[NullableContext(1)]
	public interface ICustomTabViewForGuide
	{
		// Token: 0x060408A6 RID: 264358
		string GetViewName();
	}

	// Token: 0x02007519 RID: 29977
	public class CustomTabViewForGuide : GuideDefine.ICustomTabViewForGuide
	{
		// Token: 0x060408A7 RID: 264359 RVA: 0x012F99FE File Offset: 0x012F7BFE
		[NullableContext(1)]
		public string GetViewName()
		{
			throw new NotImplementedException();
		}
	}
}
