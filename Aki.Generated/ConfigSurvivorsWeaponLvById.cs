using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009B5 RID: 2485
	public class ConfigSurvivorsWeaponLvById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003A52 RID: 14930 RVA: 0x001A395C File Offset: 0x001A1B5C
		static ConfigSurvivorsWeaponLvById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSurvivorsWeaponLvById.CreateStaticDefaultValue), new Action(ConfigSurvivorsWeaponLvById.ResetStaticDefaultValue));
		}

		// Token: 0x06003A53 RID: 14931 RVA: 0x001A397C File Offset: 0x001A1B7C
		public static void CreateStaticDefaultValue()
		{
			ConfigSurvivorsWeaponLvById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSurvivorsWeaponLvById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_survivors.db"),
				new ValueTuple<string, object>("文件", "x.幸存者_局内.xlsx"),
				new ValueTuple<string, object>("表名", "SurvivorsWeaponLv"),
				new ValueTuple<string, object>("语句", "select BinData from `SurvivorsWeaponLv` where Id=?")
			});
		}

		// Token: 0x06003A54 RID: 14932 RVA: 0x001A39FB File Offset: 0x001A1BFB
		public static void ResetStaticDefaultValue()
		{
			ConfigSurvivorsWeaponLvById.LogPair = null;
			ConfigSurvivorsWeaponLvById.HandleId = 0;
		}

		// Token: 0x06003A55 RID: 14933 RVA: 0x001A3A09 File Offset: 0x001A1C09
		public static void Init()
		{
			ConfigSurvivorsWeaponLvById.HandleId = ConfigCommon.InitDataStatement(ConfigSurvivorsWeaponLvById.HandleId, "db_survivors.db", "select BinData from `SurvivorsWeaponLv` where Id=?");
		}

		// Token: 0x06003A56 RID: 14934 RVA: 0x001A3A24 File Offset: 0x001A1C24
		public static SurvivorsWeaponLv? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSurvivorsWeaponLvById.HandleId, ConfigSurvivorsWeaponLvById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SurvivorsWeaponLvById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SurvivorsWeaponLv?(SurvivorsWeaponLv.GetRootAsSurvivorsWeaponLv(configBuffer));
				}
			}
			ConfigSurvivorsWeaponLvById.LogPair.Clear();
			ConfigSurvivorsWeaponLvById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSurvivorsWeaponLvById.HandleId, 1, p0Id, ConfigSurvivorsWeaponLvById.LogPair) || ConfigCommon.Step(ConfigSurvivorsWeaponLvById.HandleId, true, ConfigSurvivorsWeaponLvById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSurvivorsWeaponLvById.HandleId, ConfigSurvivorsWeaponLvById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSurvivorsWeaponLvById.HandleId, 0, ConfigSurvivorsWeaponLvById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSurvivorsWeaponLvById.HandleId, ConfigSurvivorsWeaponLvById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SurvivorsWeaponLv rootAsSurvivorsWeaponLv = SurvivorsWeaponLv.GetRootAsSurvivorsWeaponLv(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SurvivorsWeaponLvById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSurvivorsWeaponLvById.HandleId, ConfigSurvivorsWeaponLvById.LogPair);
			return new SurvivorsWeaponLv?(rootAsSurvivorsWeaponLv);
		}

		// Token: 0x040043D9 RID: 17369
		private const string DB = "db_survivors.db";

		// Token: 0x040043DA RID: 17370
		private const string FILE = "x.幸存者_局内.xlsx";

		// Token: 0x040043DB RID: 17371
		private const string TABLE = "SurvivorsWeaponLv";

		// Token: 0x040043DC RID: 17372
		private const string COMMAND = "select BinData from `SurvivorsWeaponLv` where Id=?";

		// Token: 0x040043DD RID: 17373
		private const string KEY_PREFIX = "SurvivorsWeaponLvById";

		// Token: 0x040043DE RID: 17374
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040043DF RID: 17375
		private static int HandleId;
	}
}
