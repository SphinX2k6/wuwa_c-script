using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200006F RID: 111
	public class ConfigAdvertisingTabCharacterById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600029A RID: 666 RVA: 0x0006BD3F File Offset: 0x00069F3F
		static ConfigAdvertisingTabCharacterById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAdvertisingTabCharacterById.CreateStaticDefaultValue), new Action(ConfigAdvertisingTabCharacterById.ResetStaticDefaultValue));
		}

		// Token: 0x0600029B RID: 667 RVA: 0x0006BD60 File Offset: 0x00069F60
		public static void CreateStaticDefaultValue()
		{
			ConfigAdvertisingTabCharacterById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAdvertisingTabCharacterById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_advertisingpage.db"),
				new ValueTuple<string, object>("文件", "x.下一版本核心内容展示.xlsx"),
				new ValueTuple<string, object>("表名", "AdvertisingTabCharacter"),
				new ValueTuple<string, object>("语句", "select BinData from `AdvertisingTabCharacter` where Id=?")
			});
		}

		// Token: 0x0600029C RID: 668 RVA: 0x0006BDDF File Offset: 0x00069FDF
		public static void ResetStaticDefaultValue()
		{
			ConfigAdvertisingTabCharacterById.LogPair = null;
			ConfigAdvertisingTabCharacterById.HandleId = 0;
		}

		// Token: 0x0600029D RID: 669 RVA: 0x0006BDED File Offset: 0x00069FED
		public static void Init()
		{
			ConfigAdvertisingTabCharacterById.HandleId = ConfigCommon.InitDataStatement(ConfigAdvertisingTabCharacterById.HandleId, "db_advertisingpage.db", "select BinData from `AdvertisingTabCharacter` where Id=?");
		}

		// Token: 0x0600029E RID: 670 RVA: 0x0006BE08 File Offset: 0x0006A008
		public static AdvertisingTabCharacter? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAdvertisingTabCharacterById.HandleId, ConfigAdvertisingTabCharacterById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AdvertisingTabCharacterById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AdvertisingTabCharacter?(AdvertisingTabCharacter.GetRootAsAdvertisingTabCharacter(configBuffer));
				}
			}
			ConfigAdvertisingTabCharacterById.LogPair.Clear();
			ConfigAdvertisingTabCharacterById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigAdvertisingTabCharacterById.HandleId, 1, p0Id, ConfigAdvertisingTabCharacterById.LogPair) || ConfigCommon.Step(ConfigAdvertisingTabCharacterById.HandleId, true, ConfigAdvertisingTabCharacterById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAdvertisingTabCharacterById.HandleId, ConfigAdvertisingTabCharacterById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAdvertisingTabCharacterById.HandleId, 0, ConfigAdvertisingTabCharacterById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAdvertisingTabCharacterById.HandleId, ConfigAdvertisingTabCharacterById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AdvertisingTabCharacter rootAsAdvertisingTabCharacter = AdvertisingTabCharacter.GetRootAsAdvertisingTabCharacter(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AdvertisingTabCharacterById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAdvertisingTabCharacterById.HandleId, ConfigAdvertisingTabCharacterById.LogPair);
			return new AdvertisingTabCharacter?(rootAsAdvertisingTabCharacter);
		}

		// Token: 0x040002ED RID: 749
		private const string DB = "db_advertisingpage.db";

		// Token: 0x040002EE RID: 750
		private const string FILE = "x.下一版本核心内容展示.xlsx";

		// Token: 0x040002EF RID: 751
		private const string TABLE = "AdvertisingTabCharacter";

		// Token: 0x040002F0 RID: 752
		private const string COMMAND = "select BinData from `AdvertisingTabCharacter` where Id=?";

		// Token: 0x040002F1 RID: 753
		private const string KEY_PREFIX = "AdvertisingTabCharacterById";

		// Token: 0x040002F2 RID: 754
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040002F3 RID: 755
		private static int HandleId;
	}
}
