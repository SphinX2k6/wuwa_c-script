using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000351 RID: 849
	public class ConfigFlySkinConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060013EB RID: 5099 RVA: 0x000CD7FD File Offset: 0x000CB9FD
		static ConfigFlySkinConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFlySkinConfigById.CreateStaticDefaultValue), new Action(ConfigFlySkinConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x060013EC RID: 5100 RVA: 0x000CD81C File Offset: 0x000CBA1C
		public static void CreateStaticDefaultValue()
		{
			ConfigFlySkinConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFlySkinConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_skin.db"),
				new ValueTuple<string, object>("文件", "p.皮肤外观.xlsx"),
				new ValueTuple<string, object>("表名", "FlySkinConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `FlySkinConfig` where Id=?")
			});
		}

		// Token: 0x060013ED RID: 5101 RVA: 0x000CD89B File Offset: 0x000CBA9B
		public static void ResetStaticDefaultValue()
		{
			ConfigFlySkinConfigById.LogPair = null;
			ConfigFlySkinConfigById.HandleId = 0;
		}

		// Token: 0x060013EE RID: 5102 RVA: 0x000CD8A9 File Offset: 0x000CBAA9
		public static void Init()
		{
			ConfigFlySkinConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigFlySkinConfigById.HandleId, "db_skin.db", "select BinData from `FlySkinConfig` where Id=?");
		}

		// Token: 0x060013EF RID: 5103 RVA: 0x000CD8C4 File Offset: 0x000CBAC4
		public static FlySkinConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFlySkinConfigById.HandleId, ConfigFlySkinConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FlySkinConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FlySkinConfig?(FlySkinConfig.GetRootAsFlySkinConfig(configBuffer));
				}
			}
			ConfigFlySkinConfigById.LogPair.Clear();
			ConfigFlySkinConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFlySkinConfigById.HandleId, 1, p0Id, ConfigFlySkinConfigById.LogPair) || ConfigCommon.Step(ConfigFlySkinConfigById.HandleId, true, ConfigFlySkinConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFlySkinConfigById.HandleId, ConfigFlySkinConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFlySkinConfigById.HandleId, 0, ConfigFlySkinConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFlySkinConfigById.HandleId, ConfigFlySkinConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FlySkinConfig rootAsFlySkinConfig = FlySkinConfig.GetRootAsFlySkinConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FlySkinConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFlySkinConfigById.HandleId, ConfigFlySkinConfigById.LogPair);
			return new FlySkinConfig?(rootAsFlySkinConfig);
		}

		// Token: 0x0400171B RID: 5915
		private const string DB = "db_skin.db";

		// Token: 0x0400171C RID: 5916
		private const string FILE = "p.皮肤外观.xlsx";

		// Token: 0x0400171D RID: 5917
		private const string TABLE = "FlySkinConfig";

		// Token: 0x0400171E RID: 5918
		private const string COMMAND = "select BinData from `FlySkinConfig` where Id=?";

		// Token: 0x0400171F RID: 5919
		private const string KEY_PREFIX = "FlySkinConfigById";

		// Token: 0x04001720 RID: 5920
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001721 RID: 5921
		private static int HandleId;
	}
}
