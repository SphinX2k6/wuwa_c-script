using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x02001C4C RID: 7244
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class LevelFuncFlagModel : ModelBase
{
	// Token: 0x0600DA7F RID: 55935 RVA: 0x0032C170 File Offset: 0x0032A370
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

	// Token: 0x0600DA80 RID: 55936 RVA: 0x0032C238 File Offset: 0x0032A438
	protected override bool OnClear()
	{
		this.FuncFlags.Clear();
		return true;
	}

	// Token: 0x0600DA81 RID: 55937 RVA: 0x0032C248 File Offset: 0x0032A448
	public bool GetFuncFlagEnable(ELevelFuncFlagId funcFlagId)
	{
		bool flag;
		return this.FuncFlags.TryGetValue(funcFlagId, out flag) && flag;
	}

	// Token: 0x0600DA82 RID: 55938 RVA: 0x0032C268 File Offset: 0x0032A468
	public bool GetFuncFlagDefault(ELevelFuncFlagId funcFlagId)
	{
		bool flag;
		return LevelFuncFlagDefine.levelFuncFlagDefaultVal != null && LevelFuncFlagDefine.levelFuncFlagDefaultVal.TryGetValue(funcFlagId, out flag) && flag;
	}

	// Token: 0x0600DA83 RID: 55939 RVA: 0x0032C290 File Offset: 0x0032A490
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

	// Token: 0x0600DA84 RID: 55940 RVA: 0x0032C330 File Offset: 0x0032A530
	public void ResetFuncFlagToDefault(ELevelFuncFlagId funcFlagId)
	{
		bool funcFlagDefault = this.GetFuncFlagDefault(funcFlagId);
		this.SetFuncFlagEnable(funcFlagId, funcFlagDefault);
	}

	// Token: 0x170011DA RID: 4570
	// (get) Token: 0x0600DA85 RID: 55941 RVA: 0x0032C34D File Offset: 0x0032A54D
	public static LevelFuncFlagModel Instance
	{
		get
		{
			return LevelFuncFlagModel._Instance;
		}
	}

	// Token: 0x0600DA86 RID: 55942 RVA: 0x0032C354 File Offset: 0x0032A554
	public static LevelFuncFlagModel GetOrCreateInstance()
	{
		if (LevelFuncFlagModel._Instance == null)
		{
			LevelFuncFlagModel.CreateInstance();
		}
		return LevelFuncFlagModel._Instance;
	}

	// Token: 0x0600DA87 RID: 55943 RVA: 0x0032C368 File Offset: 0x0032A568
	public static bool CreateInstance()
	{
		if (LevelFuncFlagModel._Instance != null)
		{
			return true;
		}
		LevelFuncFlagModel._Instance = new LevelFuncFlagModel();
		return true;
	}

	// Token: 0x0600DA88 RID: 55944 RVA: 0x0032C37E File Offset: 0x0032A57E
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600DA89 RID: 55945 RVA: 0x0032C380 File Offset: 0x0032A580
	public static void ResetStaticDefaultValue()
	{
		LevelFuncFlagModel._Instance = null;
	}

	// Token: 0x0600DA8A RID: 55946 RVA: 0x0032C388 File Offset: 0x0032A588
	static LevelFuncFlagModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(LevelFuncFlagModel.CreateStaticDefaultValue), new Action(LevelFuncFlagModel.ResetStaticDefaultValue));
	}

	// Token: 0x040063FC RID: 25596
	private readonly Dictionary<ELevelFuncFlagId, bool> FuncFlags = new Dictionary<ELevelFuncFlagId, bool>();

	// Token: 0x040063FD RID: 25597
	[Nullable(2)]
	private static LevelFuncFlagModel _Instance;
}
