using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using UnrealEngine;

// Token: 0x02000009 RID: 9
[NullableContext(1)]
[Nullable(0)]
public class ActorSystemDebugger : Singleton
{
	// Token: 0x0600002B RID: 43 RVA: 0x0000395D File Offset: 0x00001B5D
	public void RecordGetPut(GetPutRecord record)
	{
		if (this.EnableDebugger)
		{
			this.AllGetRecord.Add(record);
		}
	}

	// Token: 0x0600002C RID: 44 RVA: 0x00003974 File Offset: 0x00001B74
	[NullableContext(2)]
	public void OutPutCsv(string getRecordPath)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine("类名,操作类型,是否命中,时间戳,此类型总数,命中率,池中总量,待销毁数量");
		for (int i = 0; i < this.AllGetRecord.Count; i++)
		{
			GetPutRecord getPutRecord = this.AllGetRecord[i];
			string text = getPutRecord.TimeStamp.ToString();
			if (text.Length > 5)
			{
				text = text.Substring(5);
			}
			stringBuilder.Append(getPutRecord.ClassName).Append(',').Append(getPutRecord.GetOrPut).Append(',').Append(getPutRecord.Hit).Append(',').Append(text).Append(',').Append(getPutRecord.ThisTypeTotal).Append(',').Append(getPutRecord.HitRate).Append(',').Append(getPutRecord.CurrentTotal).Append(',').Append(getPutRecord.PendingKillNum).AppendLine();
		}
		string saveText = stringBuilder.ToString();
		if (!string.IsNullOrEmpty(getRecordPath))
		{
			UKuroStaticLibrary.SaveStringToFile(saveText, getRecordPath, false);
			return;
		}
		UKuroStaticLibrary.SaveStringToFile(saveText, this.GetRecordPath, false);
	}

	// Token: 0x17000005 RID: 5
	// (get) Token: 0x0600002D RID: 45 RVA: 0x00003A90 File Offset: 0x00001C90
	public static ActorSystemDebugger Instance
	{
		get
		{
			if (ActorSystemDebugger._instance == null)
			{
				ActorSystemDebugger._instance = new ActorSystemDebugger();
				ActorSystemDebugger._instance.OnInit();
			}
			return ActorSystemDebugger._instance;
		}
	}

	// Token: 0x0600002E RID: 46 RVA: 0x00003AB3 File Offset: 0x00001CB3
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600002F RID: 47 RVA: 0x00003AB5 File Offset: 0x00001CB5
	public static void ResetStaticDefaultValue()
	{
		ActorSystemDebugger instance = ActorSystemDebugger._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		ActorSystemDebugger._instance = null;
	}

	// Token: 0x06000030 RID: 48 RVA: 0x00003ACE File Offset: 0x00001CCE
	static ActorSystemDebugger()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ActorSystemDebugger.CreateStaticDefaultValue), new Action(ActorSystemDebugger.ResetStaticDefaultValue));
	}

	// Token: 0x04000036 RID: 54
	private readonly string GetRecordPath = "f:/full_get_put_actor.csv";

	// Token: 0x04000037 RID: 55
	private readonly bool EnableDebugger;

	// Token: 0x04000038 RID: 56
	private readonly List<GetPutRecord> AllGetRecord = new List<GetPutRecord>();

	// Token: 0x04000039 RID: 57
	[Nullable(2)]
	private static ActorSystemDebugger _instance;
}
