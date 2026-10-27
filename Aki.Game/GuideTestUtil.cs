using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001DBD RID: 7613
[NullableContext(1)]
[Nullable(0)]
public class GuideTestUtil : IStaticVariableResetter
{
	// Token: 0x0600E72B RID: 59179 RVA: 0x00367471 File Offset: 0x00365671
	static GuideTestUtil()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(GuideTestUtil.CreateStaticDefaultValue), new Action(GuideTestUtil.ResetStaticDefaultValue));
	}

	// Token: 0x0600E72C RID: 59180 RVA: 0x00367490 File Offset: 0x00365690
	public static void CreateStaticDefaultValue()
	{
		GuideTestUtil.GuideTestParams = new GuideTestParam();
	}

	// Token: 0x0600E72D RID: 59181 RVA: 0x0036749C File Offset: 0x0036569C
	public static void ResetStaticDefaultValue()
	{
		GuideTestUtil.GuideTestParams = null;
	}

	// Token: 0x0600E72E RID: 59182 RVA: 0x003674A4 File Offset: 0x003656A4
	public static void Debug(string message, [ParamCollection] [ScopedRef] [Nullable(new byte[]
	{
		0,
		0,
		1,
		2
	})] ReadOnlySpan<ValueTuple<string, object>> pairs)
	{
	}

	// Token: 0x0600E72F RID: 59183 RVA: 0x003674A6 File Offset: 0x003656A6
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

	// Token: 0x0600E730 RID: 59184 RVA: 0x003674B8 File Offset: 0x003656B8
	public static bool CheckIsTestGroup(int groupId)
	{
		return false;
	}

	// Token: 0x0600E731 RID: 59185 RVA: 0x003674BB File Offset: 0x003656BB
	public static bool CheckIsTestStep(int stepId)
	{
		return false;
	}

	// Token: 0x0600E732 RID: 59186 RVA: 0x003674BE File Offset: 0x003656BE
	public static string GetGuideFocusTargetViewName(string configViewName, int stepId)
	{
		if (GuideTestUtil.CheckIsTestStep(stepId) && GuideTestUtil.GuideTestParams != null && !string.IsNullOrEmpty(GuideTestUtil.GuideTestParams.ViewName))
		{
			return GuideTestUtil.GuideTestParams.ViewName;
		}
		return configViewName;
	}

	// Token: 0x0600E733 RID: 59187 RVA: 0x003674EC File Offset: 0x003656EC
	public static bool CheckIsGmTest(GuideFocusNew focusConfig)
	{
		return false;
	}

	// Token: 0x0600E734 RID: 59188 RVA: 0x003674FC File Offset: 0x003656FC
	public static bool TestGuideFocus(string[] gmArgs)
	{
		return false;
	}

	// Token: 0x04006AF2 RID: 27378
	private const int TEST_GROUP_ID = 90036;

	// Token: 0x04006AF3 RID: 27379
	private const int TEST_STEP_ID = 1090028005;

	// Token: 0x04006AF4 RID: 27380
	private const string GM_TEST_PARAM = "GuideTestFocus";

	// Token: 0x04006AF5 RID: 27381
	[Nullable(2)]
	public static GuideTestParam GuideTestParams;

	// Token: 0x02008392 RID: 33682
	[NullableContext(0)]
	private enum ETestType
	{
		// Token: 0x0402ADD1 RID: 175569
		GuideHook,
		// Token: 0x0402ADD2 RID: 175570
		GuideMark,
		// Token: 0x0402ADD3 RID: 175571
		ExtraParam,
		// Token: 0x0402ADD4 RID: 175572
		MockStep
	}
}
