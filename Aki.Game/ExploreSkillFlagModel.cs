using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

// Token: 0x02001103 RID: 4355
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class ExploreSkillFlagModel : ModelBase
{
	// Token: 0x0600AE4C RID: 44620 RVA: 0x003365C4 File Offset: 0x003347C4
	protected override bool OnInit()
	{
		foreach (KeyValuePair<EExploreSkillType, bool> keyValuePair in ExploreSkillFlagDefine.levelExploreSkillFlagDefaultVal)
		{
			this.SkillFlags.Add(keyValuePair.Key, keyValuePair.Value);
		}
		return true;
	}

	// Token: 0x0600AE4D RID: 44621 RVA: 0x0033662C File Offset: 0x0033482C
	protected override bool OnClear()
	{
		this.SkillFlags.Clear();
		return true;
	}

	// Token: 0x0600AE4E RID: 44622 RVA: 0x0033663C File Offset: 0x0033483C
	public bool GetExploreSkillFlagEnable(EExploreSkillType skillType)
	{
		bool flag;
		return !this.SkillFlags.TryGetValue(skillType, out flag) || flag;
	}

	// Token: 0x0600AE4F RID: 44623 RVA: 0x0033665C File Offset: 0x0033485C
	public unsafe void SetExploreSkillFlagEnable(EExploreSkillType skillType, bool enable)
	{
		bool flag;
		this.SkillFlags.TryGetValue(skillType, out flag);
		if (flag != enable)
		{
			this.SkillFlags[skillType] = enable;
			global::Log instance = global::Log.Instance;
			ELogModule module = ELogModule.Functional;
			ELogAuthor author = ELogAuthor.CH;
			string message = "探索技能标记更新";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("skillType", skillType);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("enable", enable);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}
	}

	// Token: 0x0600AE50 RID: 44624 RVA: 0x003366E8 File Offset: 0x003348E8
	public void DisableAllExploreSkillFlag()
	{
		foreach (KeyValuePair<EExploreSkillType, bool> keyValuePair in this.SkillFlags)
		{
			this.SetExploreSkillFlagEnable(keyValuePair.Key, false);
		}
	}

	// Token: 0x0600AE51 RID: 44625 RVA: 0x00336744 File Offset: 0x00334944
	public void EnableAllExploreSkillFlag()
	{
		foreach (KeyValuePair<EExploreSkillType, bool> keyValuePair in this.SkillFlags)
		{
			this.SetExploreSkillFlagEnable(keyValuePair.Key, true);
		}
	}

	// Token: 0x170011FC RID: 4604
	// (get) Token: 0x0600AE52 RID: 44626 RVA: 0x003367A0 File Offset: 0x003349A0
	public static ExploreSkillFlagModel Instance
	{
		get
		{
			return ExploreSkillFlagModel._Instance;
		}
	}

	// Token: 0x0600AE53 RID: 44627 RVA: 0x003367A7 File Offset: 0x003349A7
	public static ExploreSkillFlagModel GetOrCreateInstance()
	{
		if (ExploreSkillFlagModel._Instance == null)
		{
			ExploreSkillFlagModel.CreateInstance();
		}
		return ExploreSkillFlagModel._Instance;
	}

	// Token: 0x0600AE54 RID: 44628 RVA: 0x003367BB File Offset: 0x003349BB
	public static bool CreateInstance()
	{
		if (ExploreSkillFlagModel._Instance != null)
		{
			return true;
		}
		ExploreSkillFlagModel._Instance = new ExploreSkillFlagModel();
		return true;
	}

	// Token: 0x0600AE55 RID: 44629 RVA: 0x003367D1 File Offset: 0x003349D1
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600AE56 RID: 44630 RVA: 0x003367D3 File Offset: 0x003349D3
	public static void ResetStaticDefaultValue()
	{
		ExploreSkillFlagModel._Instance = null;
	}

	// Token: 0x0600AE57 RID: 44631 RVA: 0x003367DB File Offset: 0x003349DB
	static ExploreSkillFlagModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ExploreSkillFlagModel.CreateStaticDefaultValue), new Action(ExploreSkillFlagModel.ResetStaticDefaultValue));
	}

	// Token: 0x04006430 RID: 25648
	private readonly Dictionary<EExploreSkillType, bool> SkillFlags = new Dictionary<EExploreSkillType, bool>();

	// Token: 0x04006431 RID: 25649
	[Nullable(2)]
	private static ExploreSkillFlagModel _Instance;
}
