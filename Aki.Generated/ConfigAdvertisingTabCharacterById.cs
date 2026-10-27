using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000067 RID: 103
	public class ConfigAdvertisingTabCharacterById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600026A RID: 618 RVA: 0x0006748B File Offset: 0x0006568B
		static ConfigAdvertisingTabCharacterById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAdvertisingTabCharacterById.CreateStaticDefaultValue), new Action(ConfigAdvertisingTabCharacterById.ResetStaticDefaultValue));
		}

		// Token: 0x0600026B RID: 619 RVA: 0x000674AC File Offset: 0x000656AC
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

		// Token: 0x0600026C RID: 620 RVA: 0x0006752B File Offset: 0x0006572B
		public static void ResetStaticDefaultValue()
		{
			ConfigAdvertisingTabCharacterById.LogPair = null;
			ConfigAdvertisingTabCharacterById.HandleId = 0;
		}

		// Token: 0x0600026D RID: 621 RVA: 0x00067539 File Offset: 0x00065739
		public static void Init()
		{
			ConfigAdvertisingTabCharacterById.HandleId = ConfigCommon.InitDataStatement(ConfigAdvertisingTabCharacterById.HandleId, "db_advertisingpage.db", "select BinData from `AdvertisingTabCharacter` where Id=?");
		}

		// Token: 0x0600026E RID: 622 RVA: 0x00067554 File Offset: 0x00065754
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

		// Token: 0x040002B5 RID: 693
		private const string DB = "db_advertisingpage.db";

		// Token: 0x040002B6 RID: 694
		private const string FILE = "x.下一版本核心内容展示.xlsx";

		// Token: 0x040002B7 RID: 695
		private const string TABLE = "AdvertisingTabCharacter";

		// Token: 0x040002B8 RID: 696
		private const string COMMAND = "select BinData from `AdvertisingTabCharacter` where Id=?";

		// Token: 0x040002B9 RID: 697
		private const string KEY_PREFIX = "AdvertisingTabCharacterById";

		// Token: 0x040002BA RID: 698
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040002BB RID: 699
		private static int HandleId;
	}
}
