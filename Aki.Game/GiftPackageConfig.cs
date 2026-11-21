using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Inventory;

// Token: 0x0200187C RID: 6268
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class GiftPackageConfig : ConfigBase
{
	// Token: 0x0600F833 RID: 63539 RVA: 0x00489D86 File Offset: 0x00487F86
	public GiftPackage? GetGiftPackageConfig(int id)
	{
		return ConfigGiftPackageById.GetConfig(id, true);
	}

	// Token: 0x0600F834 RID: 63540 RVA: 0x00489D90 File Offset: 0x00487F90
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

	// Token: 0x170017DC RID: 6108
	// (get) Token: 0x0600F835 RID: 63541 RVA: 0x00489E5C File Offset: 0x0048805C
	public static GiftPackageConfig Instance
	{
		get
		{
			return GiftPackageConfig._Instance;
		}
	}

	// Token: 0x0600F836 RID: 63542 RVA: 0x00489E63 File Offset: 0x00488063
	public static GiftPackageConfig GetOrCreateInstance()
	{
		if (GiftPackageConfig._Instance == null)
		{
			GiftPackageConfig.CreateInstance();
		}
		return GiftPackageConfig._Instance;
	}

	// Token: 0x0600F837 RID: 63543 RVA: 0x00489E77 File Offset: 0x00488077
	public static bool CreateInstance()
	{
		if (GiftPackageConfig._Instance != null)
		{
			return true;
		}
		GiftPackageConfig._Instance = new GiftPackageConfig();
		return true;
	}

	// Token: 0x0600F838 RID: 63544 RVA: 0x00489E8D File Offset: 0x0048808D
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600F839 RID: 63545 RVA: 0x00489E8F File Offset: 0x0048808F
	public static void ResetStaticDefaultValue()
	{
		GiftPackageConfig._Instance = null;
	}

	// Token: 0x0600F83A RID: 63546 RVA: 0x00489E97 File Offset: 0x00488097
	static GiftPackageConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(GiftPackageConfig.CreateStaticDefaultValue), new Action(GiftPackageConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04008AF1 RID: 35569
	[Nullable(2)]
	private static GiftPackageConfig _Instance;
}
