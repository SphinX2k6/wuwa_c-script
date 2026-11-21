using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200012B RID: 299
	public class ConfigBroadcastImageById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000703 RID: 1795 RVA: 0x00084D48 File Offset: 0x00082F48
		static ConfigBroadcastImageById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBroadcastImageById.CreateStaticDefaultValue), new Action(ConfigBroadcastImageById.ResetStaticDefaultValue));
		}

		// Token: 0x06000704 RID: 1796 RVA: 0x00084D68 File Offset: 0x00082F68
		public static void CreateStaticDefaultValue()
		{
			ConfigBroadcastImageById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBroadcastImageById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_loadingtips.db"),
				new ValueTuple<string, object>("文件", "z.载入提示.xlsx"),
				new ValueTuple<string, object>("表名", "BroadcastImage"),
				new ValueTuple<string, object>("语句", "select BinData from `BroadcastImage` where Id=?")
			});
		}

		// Token: 0x06000705 RID: 1797 RVA: 0x00084DE7 File Offset: 0x00082FE7
		public static void ResetStaticDefaultValue()
		{
			ConfigBroadcastImageById.LogPair = null;
			ConfigBroadcastImageById.HandleId = 0;
		}

		// Token: 0x06000706 RID: 1798 RVA: 0x00084DF5 File Offset: 0x00082FF5
		public static void Init()
		{
			ConfigBroadcastImageById.HandleId = ConfigCommon.InitDataStatement(ConfigBroadcastImageById.HandleId, "db_loadingtips.db", "select BinData from `BroadcastImage` where Id=?");
		}

		// Token: 0x06000707 RID: 1799 RVA: 0x00084E10 File Offset: 0x00083010
		public static BroadcastImage? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBroadcastImageById.HandleId, ConfigBroadcastImageById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BroadcastImageById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new BroadcastImage?(BroadcastImage.GetRootAsBroadcastImage(configBuffer));
				}
			}
			ConfigBroadcastImageById.LogPair.Clear();
			ConfigBroadcastImageById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigBroadcastImageById.HandleId, 1, p0Id, ConfigBroadcastImageById.LogPair) || ConfigCommon.Step(ConfigBroadcastImageById.HandleId, true, ConfigBroadcastImageById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigBroadcastImageById.HandleId, ConfigBroadcastImageById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBroadcastImageById.HandleId, 0, ConfigBroadcastImageById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigBroadcastImageById.HandleId, ConfigBroadcastImageById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			BroadcastImage rootAsBroadcastImage = BroadcastImage.GetRootAsBroadcastImage(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BroadcastImageById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigBroadcastImageById.HandleId, ConfigBroadcastImageById.LogPair);
			return new BroadcastImage?(rootAsBroadcastImage);
		}

		// Token: 0x04000811 RID: 2065
		private const string DB = "db_loadingtips.db";

		// Token: 0x04000812 RID: 2066
		private const string FILE = "z.载入提示.xlsx";

		// Token: 0x04000813 RID: 2067
		private const string TABLE = "BroadcastImage";

		// Token: 0x04000814 RID: 2068
		private const string COMMAND = "select BinData from `BroadcastImage` where Id=?";

		// Token: 0x04000815 RID: 2069
		private const string KEY_PREFIX = "BroadcastImageById";

		// Token: 0x04000816 RID: 2070
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000817 RID: 2071
		private static int HandleId;
	}
}
