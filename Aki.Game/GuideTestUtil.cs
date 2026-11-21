using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x0200127F RID: 4735
[NullableContext(1)]
[Nullable(0)]
public class GuideTestUtil : IStaticVariableResetter
{
	// Token: 0x0600BB49 RID: 47945 RVA: 0x003730D1 File Offset: 0x003712D1
	static GuideTestUtil()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(GuideTestUtil.CreateStaticDefaultValue), new Action(GuideTestUtil.ResetStaticDefaultValue));
	}

	// Token: 0x0600BB4A RID: 47946 RVA: 0x003730F0 File Offset: 0x003712F0
	public static void CreateStaticDefaultValue()
	{
		GuideTestUtil.GuideTestParams = new GuideTestParam();
	}

	// Token: 0x0600BB4B RID: 47947 RVA: 0x003730FC File Offset: 0x003712FC
	public static void ResetStaticDefaultValue()
	{
		GuideTestUtil.GuideTestParams = null;
	}

	// Token: 0x0600BB4C RID: 47948 RVA: 0x00373104 File Offset: 0x00371304
	public static void Debug(string message, [ParamCollection] [ScopedRef] [Nullable(new byte[]
	{
		0,
		0,
		1,
		2
	})] ReadOnlySpan<ValueTuple<string, object>> pairs)
	{
	}

	// Token: 0x0600BB4D RID: 47949 RVA: 0x00373106 File Offset: 0x00371306
	public static void Error(string message, [ParamCollection] [ScopedRef] [Nullable(new byte[]
	{
		0,
		0,
		1,
		2
	})] ReadOnlySpan<ValueTuple<string, object>> pairs)
	{
		Log.Instance.Error(ELogModule.Guide, ELogAuthor.TZJ, message, pairs);
	}

	// Token: 0x0600BB4E RID: 47950 RVA: 0x00373118 File Offset: 0x00371318
	public static bool CheckIsTestGroup(int groupId)
	{
		return false;
	}

	// Token: 0x0600BB4F RID: 47951 RVA: 0x0037311B File Offset: 0x0037131B
	public static bool CheckIsTestStep(int stepId)
	{
		return false;
	}

	// Token: 0x0600BB50 RID: 47952 RVA: 0x0037311E File Offset: 0x0037131E
	public static string GetGuideFocusTargetViewName(string configViewName, int stepId)
	{
		if (GuideTestUtil.CheckIsTestStep(stepId) && GuideTestUtil.GuideTestParams != null && !string.IsNullOrEmpty(GuideTestUtil.GuideTestParams.ViewName))
		{
			return GuideTestUtil.GuideTestParams.ViewName;
		}
		return configViewName;
	}

	// Token: 0x0600BB51 RID: 47953 RVA: 0x0037314C File Offset: 0x0037134C
	public static bool CheckIsGmTest(GuideFocusNew focusConfig)
	{
		return false;
	}

	// Token: 0x0600BB52 RID: 47954 RVA: 0x0037315C File Offset: 0x0037135C
	public static bool TestGuideFocus(string[] gmArgs)
	{
		return false;
	}

	// Token: 0x04006BD3 RID: 27603
	private const int TEST_GROUP_ID = 90036;

	// Token: 0x04006BD4 RID: 27604
	private const int TEST_STEP_ID = 1090028005;

	// Token: 0x04006BD5 RID: 27605
	private const string GM_TEST_PARAM = "GuideTestFocus";

	// Token: 0x04006BD6 RID: 27606
	[Nullable(2)]
	public static GuideTestParam GuideTestParams;

	// Token: 0x0200751A RID: 29978
	[NullableContext(0)]
	private enum ETestType
	{
		// Token: 0x040260F7 RID: 155895
		GuideHook,
		// Token: 0x040260F8 RID: 155896
		GuideMark,
		// Token: 0x040260F9 RID: 155897
		ExtraParam,
		// Token: 0x040260FA RID: 155898
		MockStep
	}
}
