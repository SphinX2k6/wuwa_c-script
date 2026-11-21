using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003BE RID: 958
	public class ConfigGmTypeInfoById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600167B RID: 5755 RVA: 0x000DC1B3 File Offset: 0x000DA3B3
		static ConfigGmTypeInfoById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGmTypeInfoById.CreateStaticDefaultValue), new Action(ConfigGmTypeInfoById.ResetStaticDefaultValue));
		}

		// Token: 0x0600167C RID: 5756 RVA: 0x000DC1D4 File Offset: 0x000DA3D4
		public static void CreateStaticDefaultValue()
		{
			ConfigGmTypeInfoById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGmTypeInfoById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_gm.db"),
				new ValueTuple<string, object>("文件", "g.GM.xlsx"),
				new ValueTuple<string, object>("表名", "GmTypeInfo"),
				new ValueTuple<string, object>("语句", "select BinData from `GmTypeInfo` where Id=?")
			});
		}

		// Token: 0x0600167D RID: 5757 RVA: 0x000DC253 File Offset: 0x000DA453
		public static void ResetStaticDefaultValue()
		{
			ConfigGmTypeInfoById.LogPair = null;
			ConfigGmTypeInfoById.HandleId = 0;
		}

		// Token: 0x0600167E RID: 5758 RVA: 0x000DC261 File Offset: 0x000DA461
		public static void Init()
		{
			ConfigGmTypeInfoById.HandleId = ConfigCommon.InitDataStatement(ConfigGmTypeInfoById.HandleId, "db_gm.db", "select BinData from `GmTypeInfo` where Id=?");
		}

		// Token: 0x0600167F RID: 5759 RVA: 0x000DC27C File Offset: 0x000DA47C
		public static GmTypeInfo? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGmTypeInfoById.HandleId, ConfigGmTypeInfoById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GmTypeInfoById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new GmTypeInfo?(GmTypeInfo.GetRootAsGmTypeInfo(configBuffer));
				}
			}
			ConfigGmTypeInfoById.LogPair.Clear();
			ConfigGmTypeInfoById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigGmTypeInfoById.HandleId, 1, p0Id, ConfigGmTypeInfoById.LogPair) || ConfigCommon.Step(ConfigGmTypeInfoById.HandleId, true, ConfigGmTypeInfoById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigGmTypeInfoById.HandleId, ConfigGmTypeInfoById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGmTypeInfoById.HandleId, 0, ConfigGmTypeInfoById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigGmTypeInfoById.HandleId, ConfigGmTypeInfoById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			GmTypeInfo rootAsGmTypeInfo = GmTypeInfo.GetRootAsGmTypeInfo(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GmTypeInfoById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigGmTypeInfoById.HandleId, ConfigGmTypeInfoById.LogPair);
			return new GmTypeInfo?(rootAsGmTypeInfo);
		}

		// Token: 0x04001A16 RID: 6678
		private const string DB = "db_gm.db";

		// Token: 0x04001A17 RID: 6679
		private const string FILE = "g.GM.xlsx";

		// Token: 0x04001A18 RID: 6680
		private const string TABLE = "GmTypeInfo";

		// Token: 0x04001A19 RID: 6681
		private const string COMMAND = "select BinData from `GmTypeInfo` where Id=?";

		// Token: 0x04001A1A RID: 6682
		private const string KEY_PREFIX = "GmTypeInfoById";

		// Token: 0x04001A1B RID: 6683
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001A1C RID: 6684
		private static int HandleId;
	}
}
