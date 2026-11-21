using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000018 RID: 24
[NullableContext(1)]
[Nullable(0)]
public class AudioFilterController : Singleton
{
	// Token: 0x1700000C RID: 12
	// (get) Token: 0x0600009A RID: 154 RVA: 0x00005AAF File Offset: 0x00003CAF
	// (set) Token: 0x0600009B RID: 155 RVA: 0x00005AB8 File Offset: 0x00003CB8
	private IFilterState CurrentFilterState
	{
		get
		{
			return this.CurrentFilterStateInternal;
		}
		set
		{
			if (this.CurrentFilterStateInternal == value)
			{
				return;
			}
			if (this.CurrentFilterStateInternal.State != value.State)
			{
				if (string.IsNullOrEmpty(value.State))
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Audio;
					ELogAuthor author = ELogAuthor.CWZ;
					string message = "[FilterState] [SetCurrent] 传入异常的State";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("State", value.State);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					return;
				}
				AudioSystem.Instance.SetState("filter", value.State, false);
			}
			this.CurrentFilterStateInternal = value;
		}
	}

	// Token: 0x0600009C RID: 156 RVA: 0x00005B40 File Offset: 0x00003D40
	protected override bool OnInit()
	{
		this.CurrentFilterStateInternal = this.NoneFilterState;
		return true;
	}

	// Token: 0x0600009D RID: 157 RVA: 0x00005B50 File Offset: 0x00003D50
	private void UpdateFilterState()
	{
		if (!this.GameplayFilterStack.Empty)
		{
			this.CurrentFilterState = this.GameplayFilterStack.Top;
			return;
		}
		if (!this.UiFilterStack.Empty && this.UiFilterStack.Top.State != "none")
		{
			this.CurrentFilterState = this.UiFilterStack.Top;
			return;
		}
		if (!this.SceneFilterStack.Empty)
		{
			this.CurrentFilterState = this.SceneFilterStack.Top;
			return;
		}
		this.CurrentFilterState = this.NoneFilterState;
	}

	// Token: 0x0600009E RID: 158 RVA: 0x00005BE4 File Offset: 0x00003DE4
	public int PushFilterState(string state, PriorityQueue<AudioFilterState> stack, string context = "", int priority = 0)
	{
		int num = this.Uid + 1;
		this.Uid = num;
		int num2 = num;
		AudioFilterState audioFilterState = this.CreateFilterState(num2, state, new int?(priority));
		stack.Push(audioFilterState);
		this.FilterMap[num2] = audioFilterState;
		this.UpdateFilterState();
		return num2;
	}

	// Token: 0x0600009F RID: 159 RVA: 0x00005C30 File Offset: 0x00003E30
	public void RemoveFilterState(int uid, PriorityQueue<AudioFilterState> stack, string context)
	{
		if (uid <= 0)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Audio;
			ELogAuthor author = ELogAuthor.CWZ;
			string message = "[FilterState] [Remove] uid不大于零,跳过";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Context", context);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		AudioFilterState audioFilterState = null;
		this.FilterMap.TryGetValue(uid, out audioFilterState);
		if (audioFilterState == null)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Audio;
			ELogAuthor author2 = ELogAuthor.CWZ;
			string message2 = "[FilterState] [Remove] 传入异常的uid";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("uid", uid);
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			return;
		}
		stack.Remove(audioFilterState);
		this.FilterMap.Remove(uid);
		this.UpdateFilterState();
	}

	// Token: 0x060000A0 RID: 160 RVA: 0x00005CC5 File Offset: 0x00003EC5
	public int PushGameplayFilterState(string state, string context)
	{
		return this.PushFilterState(state, this.GameplayFilterStack, "[Gameplay] " + context, 0);
	}

	// Token: 0x060000A1 RID: 161 RVA: 0x00005CE0 File Offset: 0x00003EE0
	public void RemoveGameplayFilterState(int uid, string context)
	{
		this.RemoveFilterState(uid, this.GameplayFilterStack, "[Gameplay] " + context);
	}

	// Token: 0x060000A2 RID: 162 RVA: 0x00005CFA File Offset: 0x00003EFA
	public int PushUiFilterState(string state, string ui)
	{
		return this.PushFilterState(state, this.UiFilterStack, "[UI] " + ui, 0);
	}

	// Token: 0x060000A3 RID: 163 RVA: 0x00005D15 File Offset: 0x00003F15
	public void RemoveUiFilterState(int uid, string ui)
	{
		this.RemoveFilterState(uid, this.UiFilterStack, "[UI] " + ui);
	}

	// Token: 0x060000A4 RID: 164 RVA: 0x00005D2F File Offset: 0x00003F2F
	public int PushSceneFilterState(string state, string context, int priority = 0)
	{
		return this.PushFilterState(state, this.SceneFilterStack, "[Scene]" + context, priority);
	}

	// Token: 0x060000A5 RID: 165 RVA: 0x00005D4A File Offset: 0x00003F4A
	public void RemoveSceneFilterState(int uid, string context)
	{
		this.RemoveFilterState(uid, this.SceneFilterStack, "[Scene] " + context);
	}

	// Token: 0x060000A6 RID: 166 RVA: 0x00005D64 File Offset: 0x00003F64
	public unsafe AudioFilterState CreateFilterState(int uid, string state, int? priority = null)
	{
		if (!string.IsNullOrEmpty(state))
		{
			return new AudioFilterState(uid, state, priority);
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Audio;
		ELogAuthor author = ELogAuthor.CWZ;
		string message = "[FilterState] [Create] 传入异常的State";
		<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("State", state);
		*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("priority", priority);
		instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		return this.NoneFilterState;
	}

	// Token: 0x1700000D RID: 13
	// (get) Token: 0x060000A7 RID: 167 RVA: 0x00005DE0 File Offset: 0x00003FE0
	public static AudioFilterController Instance
	{
		get
		{
			if (AudioFilterController._instance == null)
			{
				AudioFilterController._instance = new AudioFilterController();
				AudioFilterController._instance.OnInit();
			}
			return AudioFilterController._instance;
		}
	}

	// Token: 0x060000A8 RID: 168 RVA: 0x00005E03 File Offset: 0x00004003
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060000A9 RID: 169 RVA: 0x00005E05 File Offset: 0x00004005
	public static void ResetStaticDefaultValue()
	{
		AudioFilterController instance = AudioFilterController._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		AudioFilterController._instance = null;
	}

	// Token: 0x060000AA RID: 170 RVA: 0x00005E1E File Offset: 0x0000401E
	static AudioFilterController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(AudioFilterController.CreateStaticDefaultValue), new Action(AudioFilterController.ResetStaticDefaultValue));
	}

	// Token: 0x060000AB RID: 171 RVA: 0x00005E40 File Offset: 0x00004040
	public AudioFilterController()
	{
		Comparison<AudioFilterState> compare;
		if ((compare = AudioFilterController.<>O.<0>__Compare) == null)
		{
			compare = (AudioFilterController.<>O.<0>__Compare = new Comparison<AudioFilterState>(AudioFilterState.Compare));
		}
		this.GameplayFilterStack = new PriorityQueue<AudioFilterState>(compare);
		Comparison<AudioFilterState> compare2;
		if ((compare2 = AudioFilterController.<>O.<0>__Compare) == null)
		{
			compare2 = (AudioFilterController.<>O.<0>__Compare = new Comparison<AudioFilterState>(AudioFilterState.Compare));
		}
		this.UiFilterStack = new PriorityQueue<AudioFilterState>(compare2);
		Comparison<AudioFilterState> compare3;
		if ((compare3 = AudioFilterController.<>O.<0>__Compare) == null)
		{
			compare3 = (AudioFilterController.<>O.<0>__Compare = new Comparison<AudioFilterState>(AudioFilterState.Compare));
		}
		this.SceneFilterStack = new PriorityQueue<AudioFilterState>(compare3);
		this.NoneFilterState = new AudioFilterState(0, "none", null);
		base..ctor();
	}

	// Token: 0x04000083 RID: 131
	private int Uid;

	// Token: 0x04000084 RID: 132
	private readonly Dictionary<int, AudioFilterState> FilterMap = new Dictionary<int, AudioFilterState>();

	// Token: 0x04000085 RID: 133
	private readonly PriorityQueue<AudioFilterState> GameplayFilterStack;

	// Token: 0x04000086 RID: 134
	private readonly PriorityQueue<AudioFilterState> UiFilterStack;

	// Token: 0x04000087 RID: 135
	private readonly PriorityQueue<AudioFilterState> SceneFilterStack;

	// Token: 0x04000088 RID: 136
	private readonly AudioFilterState NoneFilterState;

	// Token: 0x04000089 RID: 137
	private IFilterState CurrentFilterStateInternal;

	// Token: 0x0400008A RID: 138
	[Nullable(2)]
	private static AudioFilterController _instance;

	// Token: 0x02000183 RID: 387
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x0400077F RID: 1919
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public static Comparison<AudioFilterState> <0>__Compare;
	}
}
