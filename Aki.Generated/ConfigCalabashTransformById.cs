using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200013C RID: 316
	public class ConfigCalabashTransformById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000769 RID: 1897 RVA: 0x000838A0 File Offset: 0x00081AA0
		static ConfigCalabashTransformById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCalabashTransformById.CreateStaticDefaultValue), new Action(ConfigCalabashTransformById.ResetStaticDefaultValue));
		}

		// Token: 0x0600076A RID: 1898 RVA: 0x000838C0 File Offset: 0x00081AC0
		public static void CreateStaticDefaultValue()
		{
			ConfigCalabashTransformById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCalabashTransformById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_calabash.db"),
				new ValueTuple<string, object>("文件", "h.葫芦.xlsx"),
				new ValueTuple<string, object>("表名", "CalabashTransform"),
				new ValueTuple<string, object>("语句", "select BinData from `CalabashTransform` where Id=?")
			});
		}

		// Token: 0x0600076B RID: 1899 RVA: 0x0008393F File Offset: 0x00081B3F
		public static void ResetStaticDefaultValue()
		{
			ConfigCalabashTransformById.LogPair = null;
			ConfigCalabashTransformById.HandleId = 0;
		}

		// Token: 0x0600076C RID: 1900 RVA: 0x0008394D File Offset: 0x00081B4D
		public static void Init()
		{
			ConfigCalabashTransformById.HandleId = ConfigCommon.InitDataStatement(ConfigCalabashTransformById.HandleId, "db_calabash.db", "select BinData from `CalabashTransform` where Id=?");
		}

		// Token: 0x0600076D RID: 1901 RVA: 0x00083968 File Offset: 0x00081B68
		public static CalabashTransform? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCalabashTransformById.HandleId, ConfigCalabashTransformById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CalabashTransformById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new CalabashTransform?(CalabashTransform.GetRootAsCalabashTransform(configBuffer));
				}
			}
			ConfigCalabashTransformById.LogPair.Clear();
			ConfigCalabashTransformById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigCalabashTransformById.HandleId, 1, p0Id, ConfigCalabashTransformById.LogPair) || ConfigCommon.Step(ConfigCalabashTransformById.HandleId, true, ConfigCalabashTransformById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigCalabashTransformById.HandleId, ConfigCalabashTransformById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCalabashTransformById.HandleId, 0, ConfigCalabashTransformById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigCalabashTransformById.HandleId, ConfigCalabashTransformById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			CalabashTransform rootAsCalabashTransform = CalabashTransform.GetRootAsCalabashTransform(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CalabashTransformById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigCalabashTransformById.HandleId, ConfigCalabashTransformById.LogPair);
			return new CalabashTransform?(rootAsCalabashTransform);
		}

		// Token: 0x04000888 RID: 2184
		private const string DB = "db_calabash.db";

		// Token: 0x04000889 RID: 2185
		private const string FILE = "h.葫芦.xlsx";

		// Token: 0x0400088A RID: 2186
		private const string TABLE = "CalabashTransform";

		// Token: 0x0400088B RID: 2187
		private const string COMMAND = "select BinData from `CalabashTransform` where Id=?";

		// Token: 0x0400088C RID: 2188
		private const string KEY_PREFIX = "CalabashTransformById";

		// Token: 0x0400088D RID: 2189
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400088E RID: 2190
		private static int HandleId;
	}
}
