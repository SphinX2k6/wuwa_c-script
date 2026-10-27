using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

// Token: 0x02001C44 RID: 7236
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class ExploreSkillFlagModel : ModelBase
{
	// Token: 0x0600DA36 RID: 55862 RVA: 0x0032B1B8 File Offset: 0x003293B8
	protected override bool OnInit()
	{
		foreach (KeyValuePair<EExploreSkillType, bool> keyValuePair in ExploreSkillFlagDefine.levelExploreSkillFlagDefaultVal)
		{
			this.SkillFlags.Add(keyValuePair.Key, keyValuePair.Value);
		}
		return true;
	}

	// Token: 0x0600DA37 RID: 55863 RVA: 0x0032B220 File Offset: 0x00329420
	protected override bool OnClear()
	{
		this.SkillFlags.Clear();
		return true;
	}

	// Token: 0x0600DA38 RID: 55864 RVA: 0x0032B230 File Offset: 0x00329430
	public bool GetExploreSkillFlagEnable(EExploreSkillType skillType)
	{
		bool flag;
		return !this.SkillFlags.TryGetValue(skillType, out flag) || flag;
	}

	// Token: 0x0600DA39 RID: 55865 RVA: 0x0032B250 File Offset: 0x00329450
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

	// Token: 0x0600DA3A RID: 55866 RVA: 0x0032B2DC File Offset: 0x003294DC
	public void DisableAllExploreSkillFlag()
	{
		foreach (KeyValuePair<EExploreSkillType, bool> keyValuePair in this.SkillFlags)
		{
			this.SetExploreSkillFlagEnable(keyValuePair.Key, false);
		}
	}

	// Token: 0x0600DA3B RID: 55867 RVA: 0x0032B338 File Offset: 0x00329538
	public void EnableAllExploreSkillFlag()
	{
		foreach (KeyValuePair<EExploreSkillType, bool> keyValuePair in this.SkillFlags)
		{
			this.SetExploreSkillFlagEnable(keyValuePair.Key, true);
		}
	}

	// Token: 0x170011D6 RID: 4566
	// (get) Token: 0x0600DA3C RID: 55868 RVA: 0x0032B394 File Offset: 0x00329594
	public static ExploreSkillFlagModel Instance
	{
		get
		{
			return ExploreSkillFlagModel._Instance;
		}
	}

	// Token: 0x0600DA3D RID: 55869 RVA: 0x0032B39B File Offset: 0x0032959B
	public static ExploreSkillFlagModel GetOrCreateInstance()
	{
		if (ExploreSkillFlagModel._Instance == null)
		{
			ExploreSkillFlagModel.CreateInstance();
		}
		return ExploreSkillFlagModel._Instance;
	}

	// Token: 0x0600DA3E RID: 55870 RVA: 0x0032B3AF File Offset: 0x003295AF
	public static bool CreateInstance()
	{
		if (ExploreSkillFlagModel._Instance != null)
		{
			return true;
		}
		ExploreSkillFlagModel._Instance = new ExploreSkillFlagModel();
		return true;
	}

	// Token: 0x0600DA3F RID: 55871 RVA: 0x0032B3C5 File Offset: 0x003295C5
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600DA40 RID: 55872 RVA: 0x0032B3C7 File Offset: 0x003295C7
	public static void ResetStaticDefaultValue()
	{
		ExploreSkillFlagModel._Instance = null;
	}

	// Token: 0x0600DA41 RID: 55873 RVA: 0x0032B3CF File Offset: 0x003295CF
	static ExploreSkillFlagModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ExploreSkillFlagModel.CreateStaticDefaultValue), new Action(ExploreSkillFlagModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400635E RID: 25438
	private readonly Dictionary<EExploreSkillType, bool> SkillFlags = new Dictionary<EExploreSkillType, bool>();

	// Token: 0x0400635F RID: 25439
	[Nullable(2)]
	private static ExploreSkillFlagModel _Instance;
}
