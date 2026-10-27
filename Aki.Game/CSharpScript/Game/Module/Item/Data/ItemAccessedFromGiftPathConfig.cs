using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Item.Data
{
	// Token: 0x0200582E RID: 22574
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class ItemAccessedFromGiftPathConfig : ConfigBase
	{
		// Token: 0x0603959B RID: 234907 RVA: 0x00D9A067 File Offset: 0x00D98267
		public ItemAccessedPath? GetItemAccessedFromGiftPathConfig(int id)
		{
			return ConfigItemAccessedPathById.GetConfig(id, true);
		}

		// Token: 0x0603959C RID: 234908 RVA: 0x00D9A070 File Offset: 0x00D98270
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

		// Token: 0x17008A2C RID: 35372
		// (get) Token: 0x0603959D RID: 234909 RVA: 0x00D9A242 File Offset: 0x00D98442
		public static ItemAccessedFromGiftPathConfig Instance
		{
			get
			{
				return ItemAccessedFromGiftPathConfig._Instance;
			}
		}

		// Token: 0x0603959E RID: 234910 RVA: 0x00D9A249 File Offset: 0x00D98449
		public static ItemAccessedFromGiftPathConfig GetOrCreateInstance()
		{
			if (ItemAccessedFromGiftPathConfig._Instance == null)
			{
				ItemAccessedFromGiftPathConfig.CreateInstance();
			}
			return ItemAccessedFromGiftPathConfig._Instance;
		}

		// Token: 0x0603959F RID: 234911 RVA: 0x00D9A25D File Offset: 0x00D9845D
		public static bool CreateInstance()
		{
			if (ItemAccessedFromGiftPathConfig._Instance != null)
			{
				return true;
			}
			ItemAccessedFromGiftPathConfig._Instance = new ItemAccessedFromGiftPathConfig();
			return true;
		}

		// Token: 0x060395A0 RID: 234912 RVA: 0x00D9A273 File Offset: 0x00D98473
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060395A1 RID: 234913 RVA: 0x00D9A275 File Offset: 0x00D98475
		public static void ResetStaticDefaultValue()
		{
			ItemAccessedFromGiftPathConfig._Instance = null;
		}

		// Token: 0x060395A2 RID: 234914 RVA: 0x00D9A27D File Offset: 0x00D9847D
		static ItemAccessedFromGiftPathConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ItemAccessedFromGiftPathConfig.CreateStaticDefaultValue), new Action(ItemAccessedFromGiftPathConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401DFE3 RID: 122851
		[Nullable(2)]
		private static ItemAccessedFromGiftPathConfig _Instance;
	}
}
