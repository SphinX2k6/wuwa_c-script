using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

// Token: 0x02001DBB RID: 7611
public class GuideDefine : IStaticVariableResetter
{
	// Token: 0x0600E724 RID: 59172 RVA: 0x0036734C File Offset: 0x0036554C
	static GuideDefine()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(GuideDefine.CreateStaticDefaultValue), new Action(GuideDefine.ResetStaticDefaultValue));
	}

	// Token: 0x0600E725 RID: 59173 RVA: 0x0036736B File Offset: 0x0036556B
	public static void CreateStaticDefaultValue()
	{
		GuideDefine.guideTipsAllowedViews = new List<EUiViewName>
		{
			EUiViewName.BattleView,
			EUiViewName.CommonGameMainView
		};
	}

	// Token: 0x0600E726 RID: 59174 RVA: 0x0036738D File Offset: 0x0036558D
	public static void ResetStaticDefaultValue()
	{
		GuideDefine.guideTipsAllowedViews = null;
	}

	// Token: 0x0600E727 RID: 59175 RVA: 0x00367398 File Offset: 0x00365598
	[NullableContext(1)]
	public static bool isCustomTabViewForGuide(object viewObj)
	{
		GuideDefine.ICustomTabViewForGuide customTabViewForGuide = viewObj as GuideDefine.ICustomTabViewForGuide;
		return customTabViewForGuide != null && new Func<string>(customTabViewForGuide.GetViewName) != null;
	}

	// Token: 0x04006AEB RID: 27371
	[Nullable(1)]
	public static List<EUiViewName> guideTipsAllowedViews;

	// Token: 0x02008390 RID: 33680
	[NullableContext(1)]
	public interface ICustomTabViewForGuide
	{
		// Token: 0x0604A4A3 RID: 304291
		string GetViewName();
	}

	// Token: 0x02008391 RID: 33681
	public class CustomTabViewForGuide : GuideDefine.ICustomTabViewForGuide
	{
		// Token: 0x0604A4A4 RID: 304292 RVA: 0x013565DA File Offset: 0x013547DA
		[NullableContext(1)]
		public string GetViewName()
		{
			throw new NotImplementedException();
		}
	}
}
