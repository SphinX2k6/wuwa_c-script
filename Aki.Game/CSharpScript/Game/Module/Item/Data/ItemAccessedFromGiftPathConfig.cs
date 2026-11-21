using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Item.Data
{
	// Token: 0x02004805 RID: 18437
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class ItemAccessedFromGiftPathConfig : ConfigBase
	{
		// Token: 0x0602E4AF RID: 189615 RVA: 0x00CE8EFB File Offset: 0x00CE70FB
		public ItemAccessedPath? GetItemAccessedFromGiftPathConfig(int id)
		{
			return ConfigItemAccessedPathById.GetConfig(id, true);
		}

		// Token: 0x0602E4B0 RID: 189616 RVA: 0x00CE8F04 File Offset: 0x00CE7104
		public unsafe List<int> GetGiftItemGroupById(int itemID, bool ignoreNotExistError = false)
		{
			List<int> list = new List<int>();
			ItemAccessedPath? config = ConfigItemAccessedPathById.GetConfig(itemID, true);
			if (config == null)
			{
				if (!ignoreNotExistError)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.SkipInterface;
					ELogAuthor author = ELogAuthor.WHJ;
					string message = "[SkipInterface]道具ID不存在，找不到ItemAccessedPath配置";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("itemID", itemID);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
				return list;
			}
			foreach (int num in config.Value.GiftItemGroup())
			{
				ItemInfo? config2 = ConfigItemInfoById.GetConfig(num, true);
				if (config2 == null || config2.Value.ItemType != 11 || !config2.Value.Parameters().ContainsKey(2))
				{
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.SkipInterface;
					ELogAuthor author2 = ELogAuthor.WHJ;
					string message2 = "[SkipInterface]道具存在异常";
					ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("giftItemID", num);
					instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				}
				else
				{
					int num2 = config2.Value.Parameters()[2];
					GiftPackage? giftPackageConfig = GiftPackageConfig.Instance.GetGiftPackageConfig(num2);
					if (giftPackageConfig == null || !giftPackageConfig.Value.Content().ContainsKey(itemID))
					{
						Log instance3 = Log.Instance;
						ELogModule module3 = ELogModule.SkipInterface;
						ELogAuthor author3 = ELogAuthor.WHJ;
						string message3 = "[SkipInterface]礼包内不存在对应道具";
						<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("itemID", itemID);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("giftItemID", num);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("giftID", num2);
						instance3.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
					}
					else
					{
						list.Add(num);
					}
				}
			}
			return list;
		}

		// Token: 0x17005DF6 RID: 24054
		// (get) Token: 0x0602E4B1 RID: 189617 RVA: 0x00CE90D6 File Offset: 0x00CE72D6
		public static ItemAccessedFromGiftPathConfig Instance
		{
			get
			{
				return ItemAccessedFromGiftPathConfig._Instance;
			}
		}

		// Token: 0x0602E4B2 RID: 189618 RVA: 0x00CE90DD File Offset: 0x00CE72DD
		public static ItemAccessedFromGiftPathConfig GetOrCreateInstance()
		{
			if (ItemAccessedFromGiftPathConfig._Instance == null)
			{
				ItemAccessedFromGiftPathConfig.CreateInstance();
			}
			return ItemAccessedFromGiftPathConfig._Instance;
		}

		// Token: 0x0602E4B3 RID: 189619 RVA: 0x00CE90F1 File Offset: 0x00CE72F1
		public static bool CreateInstance()
		{
			if (ItemAccessedFromGiftPathConfig._Instance != null)
			{
				return true;
			}
			ItemAccessedFromGiftPathConfig._Instance = new ItemAccessedFromGiftPathConfig();
			return true;
		}

		// Token: 0x0602E4B4 RID: 189620 RVA: 0x00CE9107 File Offset: 0x00CE7307
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602E4B5 RID: 189621 RVA: 0x00CE9109 File Offset: 0x00CE7309
		public static void ResetStaticDefaultValue()
		{
			ItemAccessedFromGiftPathConfig._Instance = null;
		}

		// Token: 0x0602E4B6 RID: 189622 RVA: 0x00CE9111 File Offset: 0x00CE7311
		static ItemAccessedFromGiftPathConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ItemAccessedFromGiftPathConfig.CreateStaticDefaultValue), new Action(ItemAccessedFromGiftPathConfig.ResetStaticDefaultValue));
		}

		// Token: 0x04018A7C RID: 100988
		[Nullable(2)]
		private static ItemAccessedFromGiftPathConfig _Instance;
	}
}
