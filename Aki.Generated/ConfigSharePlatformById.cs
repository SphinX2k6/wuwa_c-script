using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000957 RID: 2391
	public class ConfigSharePlatformById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600381D RID: 14365 RVA: 0x00199B3F File Offset: 0x00197D3F
		static ConfigSharePlatformById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSharePlatformById.CreateStaticDefaultValue), new Action(ConfigSharePlatformById.ResetStaticDefaultValue));
		}

		// Token: 0x0600381E RID: 14366 RVA: 0x00199B60 File Offset: 0x00197D60
		public static void CreateStaticDefaultValue()
		{
			ConfigSharePlatformById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSharePlatformById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_platformchannel.db"),
				new ValueTuple<string, object>("文件", "p.平台渠道.xlsx"),
				new ValueTuple<string, object>("表名", "SharePlatform"),
				new ValueTuple<string, object>("语句", "select BinData from `SharePlatform` where Id=?")
			});
		}

		// Token: 0x0600381F RID: 14367 RVA: 0x00199BDF File Offset: 0x00197DDF
		public static void ResetStaticDefaultValue()
		{
			ConfigSharePlatformById.LogPair = null;
			ConfigSharePlatformById.HandleId = 0;
		}

		// Token: 0x06003820 RID: 14368 RVA: 0x00199BED File Offset: 0x00197DED
		public static void Init()
		{
			ConfigSharePlatformById.HandleId = ConfigCommon.InitDataStatement(ConfigSharePlatformById.HandleId, "db_platformchannel.db", "select BinData from `SharePlatform` where Id=?");
		}

		// Token: 0x06003821 RID: 14369 RVA: 0x00199C08 File Offset: 0x00197E08
		public static SharePlatform? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSharePlatformById.HandleId, ConfigSharePlatformById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SharePlatformById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SharePlatform?(SharePlatform.GetRootAsSharePlatform(configBuffer));
				}
			}
			ConfigSharePlatformById.LogPair.Clear();
			ConfigSharePlatformById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSharePlatformById.HandleId, 1, p0Id, ConfigSharePlatformById.LogPair) || ConfigCommon.Step(ConfigSharePlatformById.HandleId, true, ConfigSharePlatformById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSharePlatformById.HandleId, ConfigSharePlatformById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSharePlatformById.HandleId, 0, ConfigSharePlatformById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSharePlatformById.HandleId, ConfigSharePlatformById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SharePlatform rootAsSharePlatform = SharePlatform.GetRootAsSharePlatform(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SharePlatformById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSharePlatformById.HandleId, ConfigSharePlatformById.LogPair);
			return new SharePlatform?(rootAsSharePlatform);
		}

		// Token: 0x04004147 RID: 16711
		private const string DB = "db_platformchannel.db";

		// Token: 0x04004148 RID: 16712
		private const string FILE = "p.平台渠道.xlsx";

		// Token: 0x04004149 RID: 16713
		private const string TABLE = "SharePlatform";

		// Token: 0x0400414A RID: 16714
		private const string COMMAND = "select BinData from `SharePlatform` where Id=?";

		// Token: 0x0400414B RID: 16715
		private const string KEY_PREFIX = "SharePlatformById";

		// Token: 0x0400414C RID: 16716
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400414D RID: 16717
		private static int HandleId;
	}
}
