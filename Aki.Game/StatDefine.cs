using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Typing;
using UnrealEngine;

// Token: 0x02000258 RID: 600
public class StatDefine : IStaticVariableResetter
{
	// Token: 0x060024D9 RID: 9433 RVA: 0x000E2BC3 File Offset: 0x000E0DC3
	static StatDefine()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(StatDefine.CreateStaticDefaultValue), new Action(StatDefine.ResetStaticDefaultValue));
	}

	// Token: 0x060024DA RID: 9434 RVA: 0x000E2BE4 File Offset: 0x000E0DE4
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

	// Token: 0x060024DB RID: 9435 RVA: 0x000E2CBC File Offset: 0x000E0EBC
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

	// Token: 0x060024DC RID: 9436 RVA: 0x000E2D08 File Offset: 0x000E0F08
	public static void InitStatConsoleCommand()
	{
		Action<UObject, string, APlayerController> action;
		if ((action = StatDefine.<>O.<0>__ExecuteConsoleCommand) == null)
		{
			action = (StatDefine.<>O.<0>__ExecuteConsoleCommand = new Action<UObject, string, APlayerController>(UKismetSystemLibrary.ExecuteConsoleCommand));
		}
		StatDefine.orgExecuteConsoleCommand = action;
	}

	// Token: 0x060024DD RID: 9437 RVA: 0x000E2D2A File Offset: 0x000E0F2A
	public static void CreateStaticDefaultValue()
	{
		StatDefine.battleStat = StatDefine.InitializeBattleStat();
	}

	// Token: 0x060024DE RID: 9438 RVA: 0x000E2D36 File Offset: 0x000E0F36
	public static void ResetStaticDefaultValue()
	{
		StatDefine.battleStat = null;
		StatDefine.orgExecuteConsoleCommand = null;
	}

	// Token: 0x04002442 RID: 9282
	public const bool BATTLESTAT_ENABLED = true;

	// Token: 0x04002443 RID: 9283
	[Nullable(1)]
	public const string BATTLESTAT_GROUP = "STATGROUP_KuroBattle";

	// Token: 0x04002444 RID: 9284
	[Nullable(new byte[]
	{
		2,
		1,
		2
	})]
	public static Dictionary<string, Stat> battleStat;

	// Token: 0x04002445 RID: 9285
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		2
	})]
	private static Action<UObject, string, APlayerController> orgExecuteConsoleCommand;

	// Token: 0x020065D2 RID: 26066
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x04021B63 RID: 138083
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
