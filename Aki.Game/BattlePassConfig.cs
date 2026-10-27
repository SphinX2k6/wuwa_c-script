using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;

// Token: 0x0200231E RID: 8990
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class BattlePassConfig : ConfigBase
{
	// Token: 0x06011C5B RID: 72795 RVA: 0x0045FFB4 File Offset: 0x0045E1B4
	public IReadOnlyList<BattlePassReward> GetAllRewardData(int battlePassId)
	{
		return ConfigBattlePassRewardByBattlePassId.GetConfigList(battlePassId, true);
	}

	// Token: 0x06011C5C RID: 72796 RVA: 0x0045FFC0 File Offset: 0x0045E1C0
	public BattlePass? GetBattlePassData(int battlePassId)
	{
		BattlePass? config = ConfigBattlePassById.GetConfig(battlePassId, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Temp;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "获取战令配置错误，BattlePass表格里没有这个id";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("battlePassId", battlePassId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return new BattlePass?(config.Value);
	}

	// Token: 0x06011C5D RID: 72797 RVA: 0x00460020 File Offset: 0x0045E220
	public BattlePassTask? GetBattlePassTask(int taskId)
	{
		BattlePassTask? config = ConfigBattlePassTaskByTaskId.GetConfig(taskId, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Temp;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "获取战令配置错误，BattlePassTask表格里没有这个id";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("taskId", taskId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return config;
	}

	// Token: 0x06011C5E RID: 72798 RVA: 0x00460074 File Offset: 0x0045E274
	public BattlePassUnlockPop? GetBattlePassUnlock(int typeId)
	{
		BattlePassUnlockPop? config = ConfigBattlePassUnlockPopByBattlePassTypeId.GetConfig(typeId, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Temp;
			ELogAuthor author = ELogAuthor.JT;
			string message = "获取战令配置错误，BattlePassTask表格里没有这个id";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("taskId", typeId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return config;
	}

	// Token: 0x06011C5F RID: 72799 RVA: 0x004600C8 File Offset: 0x0045E2C8
	public void GetBattlePassUnlockReward(EBattlePassUnlockType type, List<TItem> outList)
	{
		outList.Clear();
		BattlePassUnlockPop? config = ConfigBattlePassUnlockPopByBattlePassTypeId.GetConfig((int)type, true);
		if (config != null)
		{
			using (Dictionary<int, int>.Enumerator enumerator = config.Value.UnlockReward().GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					KeyValuePair<int, int> keyValuePair = enumerator.Current;
					TItem item = new TItem(new InventoryDefine.GetItemData(keyValuePair.Key, 0), keyValuePair.Value);
					outList.Add(item);
				}
				return;
			}
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Temp;
		ELogAuthor author = ELogAuthor.JT;
		string message = "BattlePassUnlockPop里没有该type";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("type", type);
		instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x170016B4 RID: 5812
	// (get) Token: 0x06011C60 RID: 72800 RVA: 0x00460184 File Offset: 0x0045E384
	public static BattlePassConfig Instance
	{
		get
		{
			return BattlePassConfig._Instance;
		}
	}

	// Token: 0x06011C61 RID: 72801 RVA: 0x0046018B File Offset: 0x0045E38B
	public static BattlePassConfig GetOrCreateInstance()
	{
		if (BattlePassConfig._Instance == null)
		{
			BattlePassConfig.CreateInstance();
		}
		return BattlePassConfig._Instance;
	}

	// Token: 0x06011C62 RID: 72802 RVA: 0x0046019F File Offset: 0x0045E39F
	public static bool CreateInstance()
	{
		if (BattlePassConfig._Instance != null)
		{
			return true;
		}
		BattlePassConfig._Instance = new BattlePassConfig();
		return true;
	}

	// Token: 0x06011C63 RID: 72803 RVA: 0x004601B5 File Offset: 0x0045E3B5
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06011C64 RID: 72804 RVA: 0x004601B7 File Offset: 0x0045E3B7
	public static void ResetStaticDefaultValue()
	{
		BattlePassConfig._Instance = null;
	}

	// Token: 0x06011C65 RID: 72805 RVA: 0x004601BF File Offset: 0x0045E3BF
	static BattlePassConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BattlePassConfig.CreateStaticDefaultValue), new Action(BattlePassConfig.ResetStaticDefaultValue));
	}

	// Token: 0x040086D8 RID: 34520
	[Nullable(2)]
	private static BattlePassConfig _Instance;
}
