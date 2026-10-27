using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020006C1 RID: 1729
	public class ConfigPhoneTipShowListByDungeonSubType : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002896 RID: 10390 RVA: 0x0013F00F File Offset: 0x0013D20F
		static ConfigPhoneTipShowListByDungeonSubType()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPhoneTipShowListByDungeonSubType.CreateStaticDefaultValue), new Action(ConfigPhoneTipShowListByDungeonSubType.ResetStaticDefaultValue));
		}

		// Token: 0x06002897 RID: 10391 RVA: 0x0013F030 File Offset: 0x0013D230
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

		// Token: 0x06002898 RID: 10392 RVA: 0x0013F0AF File Offset: 0x0013D2AF
		public static void ResetStaticDefaultValue()
		{
			ConfigPhoneTipShowListByDungeonSubType.LogPair = null;
			ConfigPhoneTipShowListByDungeonSubType.HandleId = 0;
		}

		// Token: 0x06002899 RID: 10393 RVA: 0x0013F0BD File Offset: 0x0013D2BD
		public static void Init()
		{
			ConfigPhoneTipShowListByDungeonSubType.HandleId = ConfigCommon.InitDataStatement(ConfigPhoneTipShowListByDungeonSubType.HandleId, "db_phonemsg.db", "select BinData from `PhoneTipShowList` where DungeonSubType=?");
		}

		// Token: 0x0600289A RID: 10394 RVA: 0x0013F0D8 File Offset: 0x0013D2D8
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

		// Token: 0x04002F2D RID: 12077
		private const string DB = "db_phonemsg.db";

		// Token: 0x04002F2E RID: 12078
		private const string FILE = "s.手机系统.xlsx";

		// Token: 0x04002F2F RID: 12079
		private const string TABLE = "PhoneTipShowList";

		// Token: 0x04002F30 RID: 12080
		private const string COMMAND = "select BinData from `PhoneTipShowList` where DungeonSubType=?";

		// Token: 0x04002F31 RID: 12081
		private const string KEY_PREFIX = "PhoneTipShowListByDungeonSubType";

		// Token: 0x04002F32 RID: 12082
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002F33 RID: 12083
		private static int HandleId;
	}
}
