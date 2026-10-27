using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000453 RID: 1107
	public class ConfigItemAccessedPathById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060019FC RID: 6652 RVA: 0x000EC615 File Offset: 0x000EA815
		static ConfigItemAccessedPathById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigItemAccessedPathById.CreateStaticDefaultValue), new Action(ConfigItemAccessedPathById.ResetStaticDefaultValue));
		}

		// Token: 0x060019FD RID: 6653 RVA: 0x000EC634 File Offset: 0x000EA834
		public static void CreateStaticDefaultValue()
		{
			ConfigItemAccessedPathById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigItemAccessedPathById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_giftpackage.db"),
				new ValueTuple<string, object>("文件", "l.礼包.xlsx"),
				new ValueTuple<string, object>("表名", "ItemAccessedPath"),
				new ValueTuple<string, object>("语句", "select BinData from `ItemAccessedPath` where Id=?")
			});
		}

		// Token: 0x060019FE RID: 6654 RVA: 0x000EC6B3 File Offset: 0x000EA8B3
		public static void ResetStaticDefaultValue()
		{
			ConfigItemAccessedPathById.LogPair = null;
			ConfigItemAccessedPathById.HandleId = 0;
		}

		// Token: 0x060019FF RID: 6655 RVA: 0x000EC6C1 File Offset: 0x000EA8C1
		public static void Init()
		{
			ConfigItemAccessedPathById.HandleId = ConfigCommon.InitDataStatement(ConfigItemAccessedPathById.HandleId, "db_giftpackage.db", "select BinData from `ItemAccessedPath` where Id=?");
		}

		// Token: 0x06001A00 RID: 6656 RVA: 0x000EC6DC File Offset: 0x000EA8DC
		public static ItemAccessedPath? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigItemAccessedPathById.HandleId, ConfigItemAccessedPathById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ItemAccessedPathById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ItemAccessedPath?(ItemAccessedPath.GetRootAsItemAccessedPath(configBuffer));
				}
			}
			ConfigItemAccessedPathById.LogPair.Clear();
			ConfigItemAccessedPathById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigItemAccessedPathById.HandleId, 1, p0Id, ConfigItemAccessedPathById.LogPair) || ConfigCommon.Step(ConfigItemAccessedPathById.HandleId, false, ConfigItemAccessedPathById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigItemAccessedPathById.HandleId, ConfigItemAccessedPathById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigItemAccessedPathById.HandleId, 0, ConfigItemAccessedPathById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigItemAccessedPathById.HandleId, ConfigItemAccessedPathById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ItemAccessedPath rootAsItemAccessedPath = ItemAccessedPath.GetRootAsItemAccessedPath(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ItemAccessedPathById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigItemAccessedPathById.HandleId, ConfigItemAccessedPathById.LogPair);
			return new ItemAccessedPath?(rootAsItemAccessedPath);
		}

		// Token: 0x04001E29 RID: 7721
		private const string DB = "db_giftpackage.db";

		// Token: 0x04001E2A RID: 7722
		private const string FILE = "l.礼包.xlsx";

		// Token: 0x04001E2B RID: 7723
		private const string TABLE = "ItemAccessedPath";

		// Token: 0x04001E2C RID: 7724
		private const string COMMAND = "select BinData from `ItemAccessedPath` where Id=?";

		// Token: 0x04001E2D RID: 7725
		private const string KEY_PREFIX = "ItemAccessedPathById";

		// Token: 0x04001E2E RID: 7726
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001E2F RID: 7727
		private static int HandleId;
	}
}
