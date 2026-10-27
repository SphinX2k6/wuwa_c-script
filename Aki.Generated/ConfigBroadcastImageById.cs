using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200011C RID: 284
	public class ConfigBroadcastImageById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060006A9 RID: 1705 RVA: 0x0007F3E4 File Offset: 0x0007D5E4
		static ConfigBroadcastImageById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBroadcastImageById.CreateStaticDefaultValue), new Action(ConfigBroadcastImageById.ResetStaticDefaultValue));
		}

		// Token: 0x060006AA RID: 1706 RVA: 0x0007F404 File Offset: 0x0007D604
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

		// Token: 0x060006AB RID: 1707 RVA: 0x0007F483 File Offset: 0x0007D683
		public static void ResetStaticDefaultValue()
		{
			ConfigBroadcastImageById.LogPair = null;
			ConfigBroadcastImageById.HandleId = 0;
		}

		// Token: 0x060006AC RID: 1708 RVA: 0x0007F491 File Offset: 0x0007D691
		public static void Init()
		{
			ConfigBroadcastImageById.HandleId = ConfigCommon.InitDataStatement(ConfigBroadcastImageById.HandleId, "db_loadingtips.db", "select BinData from `BroadcastImage` where Id=?");
		}

		// Token: 0x060006AD RID: 1709 RVA: 0x0007F4AC File Offset: 0x0007D6AC
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

		// Token: 0x040007A8 RID: 1960
		private const string DB = "db_loadingtips.db";

		// Token: 0x040007A9 RID: 1961
		private const string FILE = "z.载入提示.xlsx";

		// Token: 0x040007AA RID: 1962
		private const string TABLE = "BroadcastImage";

		// Token: 0x040007AB RID: 1963
		private const string COMMAND = "select BinData from `BroadcastImage` where Id=?";

		// Token: 0x040007AC RID: 1964
		private const string KEY_PREFIX = "BroadcastImageById";

		// Token: 0x040007AD RID: 1965
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040007AE RID: 1966
		private static int HandleId;
	}
}
