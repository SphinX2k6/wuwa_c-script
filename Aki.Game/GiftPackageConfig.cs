using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;

// Token: 0x02002397 RID: 9111
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class GiftPackageConfig : ConfigBase
{
	// Token: 0x06012381 RID: 74625 RVA: 0x0047C946 File Offset: 0x0047AB46
	public GiftPackage? GetGiftPackageConfig(int id)
	{
		return ConfigGiftPackageById.GetConfig(id, true);
	}

	// Token: 0x06012382 RID: 74626 RVA: 0x0047C950 File Offset: 0x0047AB50
	public void GetGiftItemList(int id, List<TItem> outList)
	{
		outList.Clear();
		GiftPackage? config = ConfigGiftPackageById.GetConfig(id, true);
		if (config != null)
		{
			outList.Clear();
			using (Dictionary<int, int>.Enumerator enumerator = config.Value.Content().GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					KeyValuePair<int, int> keyValuePair = enumerator.Current;
					int key = keyValuePair.Key;
					int value = keyValuePair.Value;
					TItem item = new TItem(new InventoryDefine.GetItemData(key, 0), value);
					outList.Add(item);
				}
				return;
			}
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Temp;
		ELogAuthor author = ELogAuthor.XXJ;
		string message = "GiftPackage里没有该id";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", id);
		instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x170017A2 RID: 6050
	// (get) Token: 0x06012383 RID: 74627 RVA: 0x0047CA1C File Offset: 0x0047AC1C
	public static GiftPackageConfig Instance
	{
		get
		{
			return GiftPackageConfig._Instance;
		}
	}

	// Token: 0x06012384 RID: 74628 RVA: 0x0047CA23 File Offset: 0x0047AC23
	public static GiftPackageConfig GetOrCreateInstance()
	{
		if (GiftPackageConfig._Instance == null)
		{
			GiftPackageConfig.CreateInstance();
		}
		return GiftPackageConfig._Instance;
	}

	// Token: 0x06012385 RID: 74629 RVA: 0x0047CA37 File Offset: 0x0047AC37
	public static bool CreateInstance()
	{
		if (GiftPackageConfig._Instance != null)
		{
			return true;
		}
		GiftPackageConfig._Instance = new GiftPackageConfig();
		return true;
	}

	// Token: 0x06012386 RID: 74630 RVA: 0x0047CA4D File Offset: 0x0047AC4D
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06012387 RID: 74631 RVA: 0x0047CA4F File Offset: 0x0047AC4F
	public static void ResetStaticDefaultValue()
	{
		GiftPackageConfig._Instance = null;
	}

	// Token: 0x06012388 RID: 74632 RVA: 0x0047CA57 File Offset: 0x0047AC57
	static GiftPackageConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(GiftPackageConfig.CreateStaticDefaultValue), new Action(GiftPackageConfig.ResetStaticDefaultValue));
	}

	// Token: 0x040089AA RID: 35242
	[Nullable(2)]
	private static GiftPackageConfig _Instance;
}
