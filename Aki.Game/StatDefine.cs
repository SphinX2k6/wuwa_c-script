using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Typing;
using UnrealEngine;

// Token: 0x02000254 RID: 596
public class StatDefine : IStaticVariableResetter
{
	// Token: 0x06002422 RID: 9250 RVA: 0x000DC80F File Offset: 0x000DAA0F
	static StatDefine()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(StatDefine.CreateStaticDefaultValue), new Action(StatDefine.ResetStaticDefaultValue));
	}

	// Token: 0x06002423 RID: 9251 RVA: 0x000DC830 File Offset: 0x000DAA30
	[return: Nullable(new byte[]
	{
		1,
		1,
		2
	})]
	private static Dictionary<string, Stat> InitializeBattleStat()
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		dictionary.Add("BulletTick", "Bullet Tick");
		dictionary.Add("BulletAfterTick", "Bullet AfterTick");
		dictionary.Add("MonsterTick", "Monster Tick");
		dictionary.Add("FightCameraTick", "FightCamera Tick");
		dictionary.Add("BulletCreate", "Bullet Create");
		dictionary.Add("BulletDestroy", "Bullet Destroy");
		Dictionary<string, Stat> dictionary2 = new Dictionary<string, Stat>();
		foreach (KeyValuePair<string, string> keyValuePair in dictionary)
		{
			dictionary2[keyValuePair.Key] = Stat.CreateNoFlameGraph(keyValuePair.Value, "", "STATGROUP_KuroBattle");
		}
		return dictionary2;
	}

	// Token: 0x06002424 RID: 9252 RVA: 0x000DC908 File Offset: 0x000DAB08
	[NullableContext(1)]
	private static void StatConsoleCommand(UObject worldContextObject, string command, [Nullable(2)] APlayerController specificPlayer = null)
	{
		double microseconds = KuroTime.GetMicroseconds64();
		Action<UObject, string, APlayerController> action = StatDefine.orgExecuteConsoleCommand;
		if (action != null)
		{
			action(worldContextObject, command, specificPlayer);
		}
		double num = KuroTime.GetMicroseconds64() - microseconds;
		string key = command.Replace("[ .]+", "_");
		FKuroPerfSightHelper.PostValueFloat1("ExecuteConsoleCommand", key, (float)num);
	}

	// Token: 0x06002425 RID: 9253 RVA: 0x000DC954 File Offset: 0x000DAB54
	public static void InitStatConsoleCommand()
	{
		Action<UObject, string, APlayerController> action;
		if ((action = StatDefine.<>O.<0>__ExecuteConsoleCommand) == null)
		{
			action = (StatDefine.<>O.<0>__ExecuteConsoleCommand = new Action<UObject, string, APlayerController>(UKismetSystemLibrary.ExecuteConsoleCommand));
		}
		StatDefine.orgExecuteConsoleCommand = action;
	}

	// Token: 0x06002426 RID: 9254 RVA: 0x000DC976 File Offset: 0x000DAB76
	public static void CreateStaticDefaultValue()
	{
		StatDefine.battleStat = StatDefine.InitializeBattleStat();
	}

	// Token: 0x06002427 RID: 9255 RVA: 0x000DC982 File Offset: 0x000DAB82
	public static void ResetStaticDefaultValue()
	{
		StatDefine.battleStat = null;
		StatDefine.orgExecuteConsoleCommand = null;
	}

	// Token: 0x040023C4 RID: 9156
	public const bool BATTLESTAT_ENABLED = true;

	// Token: 0x040023C5 RID: 9157
	[Nullable(1)]
	public const string BATTLESTAT_GROUP = "STATGROUP_KuroBattle";

	// Token: 0x040023C6 RID: 9158
	[Nullable(new byte[]
	{
		2,
		1,
		2
	})]
	public static Dictionary<string, Stat> battleStat;

	// Token: 0x040023C7 RID: 9159
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		2
	})]
	private static Action<UObject, string, APlayerController> orgExecuteConsoleCommand;

	// Token: 0x02007441 RID: 29761
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x04026825 RID: 157733
		[Nullable(new byte[]
		{
			0,
			1,
			1,
			2
		})]
		public static Action<UObject, string, APlayerController> <0>__ExecuteConsoleCommand;
	}
}
