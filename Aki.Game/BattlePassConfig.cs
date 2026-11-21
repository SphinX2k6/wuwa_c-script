using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;

// Token: 0x02001803 RID: 6147
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class BattlePassConfig : ConfigBase
{
	// Token: 0x0600F10B RID: 61707 RVA: 0x0046D05C File Offset: 0x0046B25C
	public IReadOnlyList<BattlePassReward> GetAllRewardData(int battlePassId)
	{
		return ConfigBattlePassRewardByBattlePassId.GetConfigList(battlePassId, true);
	}

	// Token: 0x0600F10C RID: 61708 RVA: 0x0046D068 File Offset: 0x0046B268
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

	// Token: 0x0600F10D RID: 61709 RVA: 0x0046D0C8 File Offset: 0x0046B2C8
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

	// Token: 0x0600F10E RID: 61710 RVA: 0x0046D11C File Offset: 0x0046B31C
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

	// Token: 0x0600F10F RID: 61711 RVA: 0x0046D170 File Offset: 0x0046B370
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

	// Token: 0x170016EE RID: 5870
	// (get) Token: 0x0600F110 RID: 61712 RVA: 0x0046D22C File Offset: 0x0046B42C
	public static BattlePassConfig Instance
	{
		get
		{
			return BattlePassConfig._Instance;
		}
	}

	// Token: 0x0600F111 RID: 61713 RVA: 0x0046D233 File Offset: 0x0046B433
	public static BattlePassConfig GetOrCreateInstance()
	{
		if (BattlePassConfig._Instance == null)
		{
			BattlePassConfig.CreateInstance();
		}
		return BattlePassConfig._Instance;
	}

	// Token: 0x0600F112 RID: 61714 RVA: 0x0046D247 File Offset: 0x0046B447
	public static bool CreateInstance()
	{
		if (BattlePassConfig._Instance != null)
		{
			return true;
		}
		BattlePassConfig._Instance = new BattlePassConfig();
		return true;
	}

	// Token: 0x0600F113 RID: 61715 RVA: 0x0046D25D File Offset: 0x0046B45D
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600F114 RID: 61716 RVA: 0x0046D25F File Offset: 0x0046B45F
	public static void ResetStaticDefaultValue()
	{
		BattlePassConfig._Instance = null;
	}

	// Token: 0x0600F115 RID: 61717 RVA: 0x0046D267 File Offset: 0x0046B467
	static BattlePassConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BattlePassConfig.CreateStaticDefaultValue), new Action(BattlePassConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400881B RID: 34843
	[Nullable(2)]
	private static BattlePassConfig _Instance;
}
