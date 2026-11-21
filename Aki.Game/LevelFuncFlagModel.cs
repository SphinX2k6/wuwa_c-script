using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x0200110B RID: 4363
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class LevelFuncFlagModel : ModelBase
{
	// Token: 0x0600AE95 RID: 44693 RVA: 0x00337578 File Offset: 0x00335778
	protected override bool OnInit()
	{
		if (LevelFuncFlagDefine.levelFuncFlagDefaultVal != null)
		{
			foreach (KeyValuePair<ELevelFuncFlagId, bool> keyValuePair in LevelFuncFlagDefine.levelFuncFlagDefaultVal)
			{
				this.FuncFlags.Add(keyValuePair.Key, keyValuePair.Value);
			}
		}
		foreach (KeyValuePair<ELevelFuncFlagId, bool> keyValuePair2 in this.FuncFlags)
		{
			EventSystem.Instance.Emit<ELevelFuncFlagId, bool>(EEventName.OnLevelFuncFlagSet, keyValuePair2.Key, keyValuePair2.Value);
		}
		return true;
	}

	// Token: 0x0600AE96 RID: 44694 RVA: 0x00337640 File Offset: 0x00335840
	protected override bool OnClear()
	{
		this.FuncFlags.Clear();
		return true;
	}

	// Token: 0x0600AE97 RID: 44695 RVA: 0x00337650 File Offset: 0x00335850
	public bool GetFuncFlagEnable(ELevelFuncFlagId funcFlagId)
	{
		bool flag;
		return this.FuncFlags.TryGetValue(funcFlagId, out flag) && flag;
	}

	// Token: 0x0600AE98 RID: 44696 RVA: 0x00337670 File Offset: 0x00335870
	public bool GetFuncFlagDefault(ELevelFuncFlagId funcFlagId)
	{
		bool flag;
		return LevelFuncFlagDefine.levelFuncFlagDefaultVal != null && LevelFuncFlagDefine.levelFuncFlagDefaultVal.TryGetValue(funcFlagId, out flag) && flag;
	}

	// Token: 0x0600AE99 RID: 44697 RVA: 0x00337698 File Offset: 0x00335898
	public unsafe void SetFuncFlagEnable(ELevelFuncFlagId funcFlagId, bool enable)
	{
		bool flag;
		if (!this.FuncFlags.TryGetValue(funcFlagId, out flag) || flag != enable)
		{
			this.FuncFlags[funcFlagId] = enable;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Functional;
			ELogAuthor author = ELogAuthor.ZYL;
			string message = "关卡功能标记更新";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("funcFlagId", funcFlagId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("enable", enable);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			EventSystem.Instance.Emit<ELevelFuncFlagId, bool>(EEventName.OnLevelFuncFlagChanged, funcFlagId, enable);
		}
	}

	// Token: 0x0600AE9A RID: 44698 RVA: 0x00337738 File Offset: 0x00335938
	public void ResetFuncFlagToDefault(ELevelFuncFlagId funcFlagId)
	{
		bool funcFlagDefault = this.GetFuncFlagDefault(funcFlagId);
		this.SetFuncFlagEnable(funcFlagId, funcFlagDefault);
	}

	// Token: 0x17001200 RID: 4608
	// (get) Token: 0x0600AE9B RID: 44699 RVA: 0x00337755 File Offset: 0x00335955
	public static LevelFuncFlagModel Instance
	{
		get
		{
			return LevelFuncFlagModel._Instance;
		}
	}

	// Token: 0x0600AE9C RID: 44700 RVA: 0x0033775C File Offset: 0x0033595C
	public static LevelFuncFlagModel GetOrCreateInstance()
	{
		if (LevelFuncFlagModel._Instance == null)
		{
			LevelFuncFlagModel.CreateInstance();
		}
		return LevelFuncFlagModel._Instance;
	}

	// Token: 0x0600AE9D RID: 44701 RVA: 0x00337770 File Offset: 0x00335970
	public static bool CreateInstance()
	{
		if (LevelFuncFlagModel._Instance != null)
		{
			return true;
		}
		LevelFuncFlagModel._Instance = new LevelFuncFlagModel();
		return true;
	}

	// Token: 0x0600AE9E RID: 44702 RVA: 0x00337786 File Offset: 0x00335986
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600AE9F RID: 44703 RVA: 0x00337788 File Offset: 0x00335988
	public static void ResetStaticDefaultValue()
	{
		LevelFuncFlagModel._Instance = null;
	}

	// Token: 0x0600AEA0 RID: 44704 RVA: 0x00337790 File Offset: 0x00335990
	static LevelFuncFlagModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(LevelFuncFlagModel.CreateStaticDefaultValue), new Action(LevelFuncFlagModel.ResetStaticDefaultValue));
	}

	// Token: 0x040064CE RID: 25806
	private readonly Dictionary<ELevelFuncFlagId, bool> FuncFlags = new Dictionary<ELevelFuncFlagId, bool>();

	// Token: 0x040064CF RID: 25807
	[Nullable(2)]
	private static LevelFuncFlagModel _Instance;
}
