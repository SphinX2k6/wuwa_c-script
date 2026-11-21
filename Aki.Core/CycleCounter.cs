using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Typing;
using UnrealEngine.Utils;

// Token: 0x020000B9 RID: 185
[NullableContext(1)]
[Nullable(0)]
public class CycleCounter : Singleton
{
	// Token: 0x06000608 RID: 1544 RVA: 0x0001F600 File Offset: 0x0001D800
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

	// Token: 0x170000DB RID: 219
	// (get) Token: 0x06000609 RID: 1545 RVA: 0x0001F686 File Offset: 0x0001D886
	public bool IsEnabled
	{
		get
		{
			return this.Enabled;
		}
	}

	// Token: 0x0600060A RID: 1546 RVA: 0x0001F68E File Offset: 0x0001D88E
	public void SetEnable(bool enabled)
	{
		this.EnabledNew = enabled;
	}

	// Token: 0x0600060B RID: 1547 RVA: 0x0001F697 File Offset: 0x0001D897
	public void SetNeedCheck(bool enable)
	{
		this.NeedCheckNew = enable;
	}

	// Token: 0x0600060C RID: 1548 RVA: 0x0001F6A0 File Offset: 0x0001D8A0
	public void Start(string statName)
	{
		if (!this.Enabled)
		{
			return;
		}
		FKuroCycleCounter.StartCycleCounterByName(statName);
		this.CheckStart(statName);
	}

	// Token: 0x0600060D RID: 1549 RVA: 0x0001F6BD File Offset: 0x0001D8BD
	public void CheckStart(string statName)
	{
		if (this.NeedCheck)
		{
			this.NameStack.Push(statName);
		}
	}

	// Token: 0x0600060E RID: 1550 RVA: 0x0001F6D3 File Offset: 0x0001D8D3
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

	// Token: 0x0600060F RID: 1551 RVA: 0x0001F6EC File Offset: 0x0001D8EC
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

	// Token: 0x170000DC RID: 220
	// (get) Token: 0x06000610 RID: 1552 RVA: 0x0001F81C File Offset: 0x0001DA1C
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

	// Token: 0x06000611 RID: 1553 RVA: 0x0001F83F File Offset: 0x0001DA3F
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06000612 RID: 1554 RVA: 0x0001F841 File Offset: 0x0001DA41
	public static void ResetStaticDefaultValue()
	{
		CycleCounter instance = CycleCounter._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		CycleCounter._instance = null;
	}

	// Token: 0x06000613 RID: 1555 RVA: 0x0001F85A File Offset: 0x0001DA5A
	static CycleCounter()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CycleCounter.CreateStaticDefaultValue), new Action(CycleCounter.ResetStaticDefaultValue));
	}

	// Token: 0x040004B8 RID: 1208
	public const int STAT_MAX_NAME_LENGTH = 800;

	// Token: 0x040004B9 RID: 1209
	private bool Enabled = KuroApplication.IsWithStat();

	// Token: 0x040004BA RID: 1210
	private bool EnabledNew = KuroApplication.IsWithStat();

	// Token: 0x040004BB RID: 1211
	private bool NeedCheck = !KuroApplication.IsBuildShipping();

	// Token: 0x040004BC RID: 1212
	private bool NeedCheckNew = !KuroApplication.IsBuildShipping();

	// Token: 0x040004BD RID: 1213
	private bool SwitchChanged;

	// Token: 0x040004BE RID: 1214
	private readonly global::Stack<string> NameStack = new global::Stack<string>();

	// Token: 0x040004BF RID: 1215
	[Nullable(2)]
	private static CycleCounter _instance;
}
