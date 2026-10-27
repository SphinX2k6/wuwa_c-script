using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Typing;
using UnrealEngine.Utils;

// Token: 0x020000B7 RID: 183
[NullableContext(1)]
[Nullable(0)]
public class CycleCounter : Singleton
{
	// Token: 0x060005C7 RID: 1479 RVA: 0x0001F00C File Offset: 0x0001D20C
	public void RefreshState()
	{
		this.SwitchChanged = false;
		if (this.Enabled != this.EnabledNew)
		{
			this.Enabled = this.EnabledNew;
			this.SwitchChanged = true;
			if (!this.Enabled)
			{
				int size = this.NameStack.Size;
				for (int i = 0; i < size; i++)
				{
					FKuroCycleCounter.StopCycleCounter();
				}
				this.NameStack.Clear();
			}
		}
		if (this.NeedCheck != this.NeedCheckNew)
		{
			this.NeedCheck = this.NeedCheckNew;
			this.SwitchChanged = true;
		}
	}

	// Token: 0x170000C9 RID: 201
	// (get) Token: 0x060005C8 RID: 1480 RVA: 0x0001F092 File Offset: 0x0001D292
	public bool IsEnabled
	{
		get
		{
			return this.Enabled;
		}
	}

	// Token: 0x060005C9 RID: 1481 RVA: 0x0001F09A File Offset: 0x0001D29A
	public void SetEnable(bool enabled)
	{
		this.EnabledNew = enabled;
	}

	// Token: 0x060005CA RID: 1482 RVA: 0x0001F0A3 File Offset: 0x0001D2A3
	public void SetNeedCheck(bool enable)
	{
		this.NeedCheckNew = enable;
	}

	// Token: 0x060005CB RID: 1483 RVA: 0x0001F0AC File Offset: 0x0001D2AC
	public void Start(string statName)
	{
		if (!this.Enabled)
		{
			return;
		}
		FKuroCycleCounter.StartCycleCounterByName(statName);
		this.CheckStart(statName);
	}

	// Token: 0x060005CC RID: 1484 RVA: 0x0001F0C9 File Offset: 0x0001D2C9
	public void CheckStart(string statName)
	{
		if (this.NeedCheck)
		{
			this.NameStack.Push(statName);
		}
	}

	// Token: 0x060005CD RID: 1485 RVA: 0x0001F0DF File Offset: 0x0001D2DF
	public void Stop(string statName)
	{
		if (!this.Enabled)
		{
			return;
		}
		if (this.IsPassedStackCheck(statName))
		{
			FKuroCycleCounter.StopCycleCounter();
		}
	}

	// Token: 0x060005CE RID: 1486 RVA: 0x0001F0F8 File Offset: 0x0001D2F8
	public bool IsPassedStackCheck(string statName)
	{
		if (!this.NeedCheck)
		{
			return true;
		}
		if (this.NameStack.Size > 0)
		{
			if (statName == this.NameStack.Peek())
			{
				this.NameStack.Pop();
				return true;
			}
			bool flag = false;
			using (IEnumerator<string> enumerator = this.NameStack.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current == statName)
					{
						flag = true;
						break;
					}
				}
			}
			if (flag)
			{
				List<string> list = new List<string>();
				list.Add(this.NameStack.Pop());
				string a = list[0];
				while (a != statName)
				{
					FKuroCycleCounter.StopCycleCounter();
					list.Add(this.NameStack.Pop());
					a = list[list.Count - 1];
				}
				UnrealLogger.Error("CycleCounter.Stop()匹配失败，已尝试从栈中恢复 current stat name: " + statName + ", none stopped names: " + string.Join(", ", list));
				return true;
			}
		}
		if (this.SwitchChanged)
		{
			UnrealLogger.Info("CycleCounter.Stop()匹配失败，但当前帧切换过开关状态 name: " + statName);
			return true;
		}
		UnrealLogger.Error("CycleCounter.Stop()匹配失败 name: " + statName);
		return false;
	}

	// Token: 0x170000CA RID: 202
	// (get) Token: 0x060005CF RID: 1487 RVA: 0x0001F228 File Offset: 0x0001D428
	public static CycleCounter Instance
	{
		get
		{
			if (CycleCounter._instance == null)
			{
				CycleCounter._instance = new CycleCounter();
				CycleCounter._instance.OnInit();
			}
			return CycleCounter._instance;
		}
	}

	// Token: 0x060005D0 RID: 1488 RVA: 0x0001F24B File Offset: 0x0001D44B
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060005D1 RID: 1489 RVA: 0x0001F24D File Offset: 0x0001D44D
	public static void ResetStaticDefaultValue()
	{
		CycleCounter instance = CycleCounter._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		CycleCounter._instance = null;
	}

	// Token: 0x060005D2 RID: 1490 RVA: 0x0001F266 File Offset: 0x0001D466
	static CycleCounter()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CycleCounter.CreateStaticDefaultValue), new Action(CycleCounter.ResetStaticDefaultValue));
	}

	// Token: 0x040004AA RID: 1194
	public const int STAT_MAX_NAME_LENGTH = 800;

	// Token: 0x040004AB RID: 1195
	private bool Enabled = KuroApplication.IsWithStat();

	// Token: 0x040004AC RID: 1196
	private bool EnabledNew = KuroApplication.IsWithStat();

	// Token: 0x040004AD RID: 1197
	private bool NeedCheck = !KuroApplication.IsBuildShipping();

	// Token: 0x040004AE RID: 1198
	private bool NeedCheckNew = !KuroApplication.IsBuildShipping();

	// Token: 0x040004AF RID: 1199
	private bool SwitchChanged;

	// Token: 0x040004B0 RID: 1200
	private readonly global::Stack<string> NameStack = new global::Stack<string>();

	// Token: 0x040004B1 RID: 1201
	[Nullable(2)]
	private static CycleCounter _instance;
}
