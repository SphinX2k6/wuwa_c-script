using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006D9 RID: 1753
	public class ConfigPhoneTipShowListByDungeonSubType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002926 RID: 10534 RVA: 0x00145A8B File Offset: 0x00143C8B
		static ConfigPhoneTipShowListByDungeonSubType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhoneTipShowListByDungeonSubType.CreateStaticDefaultValue), new Action(ConfigPhoneTipShowListByDungeonSubType.ResetStaticDefaultValue));
		}

		// Token: 0x06002927 RID: 10535 RVA: 0x00145AAC File Offset: 0x00143CAC
		public static void CreateStaticDefaultValue()
		{
			ConfigPhoneTipShowListByDungeonSubType.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPhoneTipShowListByDungeonSubType.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_phonemsg.db"),
				new ValueTuple<string, object>("文件", "s.手机系统.xlsx"),
				new ValueTuple<string, object>("表名", "PhoneTipShowList"),
				new ValueTuple<string, object>("语句", "select BinData from `PhoneTipShowList` where DungeonSubType=?")
			});
		}

		// Token: 0x06002928 RID: 10536 RVA: 0x00145B2B File Offset: 0x00143D2B
		public static void ResetStaticDefaultValue()
		{
			ConfigPhoneTipShowListByDungeonSubType.LogPair = null;
			ConfigPhoneTipShowListByDungeonSubType.HandleId = 0;
		}

		// Token: 0x06002929 RID: 10537 RVA: 0x00145B39 File Offset: 0x00143D39
		public static void Init()
		{
			ConfigPhoneTipShowListByDungeonSubType.HandleId = ConfigCommon.InitDataStatement(ConfigPhoneTipShowListByDungeonSubType.HandleId, "db_phonemsg.db", "select BinData from `PhoneTipShowList` where DungeonSubType=?");
		}

		// Token: 0x0600292A RID: 10538 RVA: 0x00145B54 File Offset: 0x00143D54
		public static PhoneTipShowList? GetConfig(int p0DungeonSubType, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPhoneTipShowListByDungeonSubType.HandleId, ConfigPhoneTipShowListByDungeonSubType.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhoneTipShowListByDungeonSubType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0DungeonSubType);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PhoneTipShowList?(PhoneTipShowList.GetRootAsPhoneTipShowList(configBuffer));
				}
			}
			ConfigPhoneTipShowListByDungeonSubType.LogPair.Clear();
			ConfigPhoneTipShowListByDungeonSubType.LogPair.Add(new ValueTuple<string, object>("DungeonSubType", p0DungeonSubType));
			if (!ConfigCommon.BindInt(ConfigPhoneTipShowListByDungeonSubType.HandleId, 1, p0DungeonSubType, ConfigPhoneTipShowListByDungeonSubType.LogPair) || ConfigCommon.Step(ConfigPhoneTipShowListByDungeonSubType.HandleId, true, ConfigPhoneTipShowListByDungeonSubType.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPhoneTipShowListByDungeonSubType.HandleId, ConfigPhoneTipShowListByDungeonSubType.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPhoneTipShowListByDungeonSubType.HandleId, 0, ConfigPhoneTipShowListByDungeonSubType.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPhoneTipShowListByDungeonSubType.HandleId, ConfigPhoneTipShowListByDungeonSubType.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PhoneTipShowList rootAsPhoneTipShowList = PhoneTipShowList.GetRootAsPhoneTipShowList(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PhoneTipShowListByDungeonSubType");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0DungeonSubType);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPhoneTipShowListByDungeonSubType.HandleId, ConfigPhoneTipShowListByDungeonSubType.LogPair);
			return new PhoneTipShowList?(rootAsPhoneTipShowList);
		}

		// Token: 0x04002FD5 RID: 12245
		private const string DB = "db_phonemsg.db";

		// Token: 0x04002FD6 RID: 12246
		private const string FILE = "s.手机系统.xlsx";

		// Token: 0x04002FD7 RID: 12247
		private const string TABLE = "PhoneTipShowList";

		// Token: 0x04002FD8 RID: 12248
		private const string COMMAND = "select BinData from `PhoneTipShowList` where DungeonSubType=?";

		// Token: 0x04002FD9 RID: 12249
		private const string KEY_PREFIX = "PhoneTipShowListByDungeonSubType";

		// Token: 0x04002FDA RID: 12250
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002FDB RID: 12251
		private static int HandleId;
	}
}
