using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200019F RID: 415
	public class ConfigCookLevelById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060009BD RID: 2493 RVA: 0x00090863 File Offset: 0x0008EA63
		static ConfigCookLevelById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCookLevelById.CreateStaticDefaultValue), new Action(ConfigCookLevelById.ResetStaticDefaultValue));
		}

		// Token: 0x060009BE RID: 2494 RVA: 0x00090884 File Offset: 0x0008EA84
		public static void CreateStaticDefaultValue()
		{
			ConfigCookLevelById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCookLevelById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_cook.db"),
				new ValueTuple<string, object>("文件", "p.烹饪.xlsx"),
				new ValueTuple<string, object>("表名", "CookLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `CookLevel` where Id=?")
			});
		}

		// Token: 0x060009BF RID: 2495 RVA: 0x00090903 File Offset: 0x0008EB03
		public static void ResetStaticDefaultValue()
		{
			ConfigCookLevelById.LogPair = null;
			ConfigCookLevelById.HandleId = 0;
		}

		// Token: 0x060009C0 RID: 2496 RVA: 0x00090911 File Offset: 0x0008EB11
		public static void Init()
		{
			ConfigCookLevelById.HandleId = ConfigCommon.InitDataStatement(ConfigCookLevelById.HandleId, "db_cook.db", "select BinData from `CookLevel` where Id=?");
		}

		// Token: 0x060009C1 RID: 2497 RVA: 0x0009092C File Offset: 0x0008EB2C
		public static CookLevel? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCookLevelById.HandleId, ConfigCookLevelById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CookLevelById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new CookLevel?(CookLevel.GetRootAsCookLevel(configBuffer));
				}
			}
			ConfigCookLevelById.LogPair.Clear();
			ConfigCookLevelById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigCookLevelById.HandleId, 1, p0Id, ConfigCookLevelById.LogPair) || ConfigCommon.Step(ConfigCookLevelById.HandleId, true, ConfigCookLevelById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigCookLevelById.HandleId, ConfigCookLevelById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCookLevelById.HandleId, 0, ConfigCookLevelById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigCookLevelById.HandleId, ConfigCookLevelById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			CookLevel rootAsCookLevel = CookLevel.GetRootAsCookLevel(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CookLevelById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigCookLevelById.HandleId, ConfigCookLevelById.LogPair);
			return new CookLevel?(rootAsCookLevel);
		}

		// Token: 0x04000B3D RID: 2877
		private const string DB = "db_cook.db";

		// Token: 0x04000B3E RID: 2878
		private const string FILE = "p.烹饪.xlsx";

		// Token: 0x04000B3F RID: 2879
		private const string TABLE = "CookLevel";

		// Token: 0x04000B40 RID: 2880
		private const string COMMAND = "select BinData from `CookLevel` where Id=?";

		// Token: 0x04000B41 RID: 2881
		private const string KEY_PREFIX = "CookLevelById";

		// Token: 0x04000B42 RID: 2882
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000B43 RID: 2883
		private static int HandleId;
	}
}
