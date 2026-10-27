using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200033C RID: 828
	public class ConfigFlySkinConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600136D RID: 4973 RVA: 0x000C72F1 File Offset: 0x000C54F1
		static ConfigFlySkinConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFlySkinConfigById.CreateStaticDefaultValue), new Action(ConfigFlySkinConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x0600136E RID: 4974 RVA: 0x000C7310 File Offset: 0x000C5510
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

		// Token: 0x0600136F RID: 4975 RVA: 0x000C738F File Offset: 0x000C558F
		public static void ResetStaticDefaultValue()
		{
			ConfigFlySkinConfigById.LogPair = null;
			ConfigFlySkinConfigById.HandleId = 0;
		}

		// Token: 0x06001370 RID: 4976 RVA: 0x000C739D File Offset: 0x000C559D
		public static void Init()
		{
			ConfigFlySkinConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigFlySkinConfigById.HandleId, "db_skin.db", "select BinData from `FlySkinConfig` where Id=?");
		}

		// Token: 0x06001371 RID: 4977 RVA: 0x000C73B8 File Offset: 0x000C55B8
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

		// Token: 0x04001688 RID: 5768
		private const string DB = "db_skin.db";

		// Token: 0x04001689 RID: 5769
		private const string FILE = "p.皮肤外观.xlsx";

		// Token: 0x0400168A RID: 5770
		private const string TABLE = "FlySkinConfig";

		// Token: 0x0400168B RID: 5771
		private const string COMMAND = "select BinData from `FlySkinConfig` where Id=?";

		// Token: 0x0400168C RID: 5772
		private const string KEY_PREFIX = "FlySkinConfigById";

		// Token: 0x0400168D RID: 5773
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400168E RID: 5774
		private static int HandleId;
	}
}
