using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000374 RID: 884
	public class ConfigGaChaShareById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060014BE RID: 5310 RVA: 0x000CED48 File Offset: 0x000CCF48
		static ConfigGaChaShareById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGaChaShareById.CreateStaticDefaultValue), new Action(ConfigGaChaShareById.ResetStaticDefaultValue));
		}

		// Token: 0x060014BF RID: 5311 RVA: 0x000CED68 File Offset: 0x000CCF68
		public static void CreateStaticDefaultValue()
		{
			ConfigGaChaShareById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGaChaShareById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_shareinfo.db"),
				new ValueTuple<string, object>("文件", "f.分享.xlsx"),
				new ValueTuple<string, object>("表名", "GaChaShare"),
				new ValueTuple<string, object>("语句", "select BinData from `GaChaShare` where Id=?")
			});
		}

		// Token: 0x060014C0 RID: 5312 RVA: 0x000CEDE7 File Offset: 0x000CCFE7
		public static void ResetStaticDefaultValue()
		{
			ConfigGaChaShareById.LogPair = null;
			ConfigGaChaShareById.HandleId = 0;
		}

		// Token: 0x060014C1 RID: 5313 RVA: 0x000CEDF5 File Offset: 0x000CCFF5
		public static void Init()
		{
			ConfigGaChaShareById.HandleId = ConfigCommon.InitDataStatement(ConfigGaChaShareById.HandleId, "db_shareinfo.db", "select BinData from `GaChaShare` where Id=?");
		}

		// Token: 0x060014C2 RID: 5314 RVA: 0x000CEE10 File Offset: 0x000CD010
		public static GaChaShare? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGaChaShareById.HandleId, ConfigGaChaShareById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GaChaShareById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new GaChaShare?(GaChaShare.GetRootAsGaChaShare(configBuffer));
				}
			}
			ConfigGaChaShareById.LogPair.Clear();
			ConfigGaChaShareById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigGaChaShareById.HandleId, 1, p0Id, ConfigGaChaShareById.LogPair) || ConfigCommon.Step(ConfigGaChaShareById.HandleId, true, ConfigGaChaShareById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigGaChaShareById.HandleId, ConfigGaChaShareById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGaChaShareById.HandleId, 0, ConfigGaChaShareById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigGaChaShareById.HandleId, ConfigGaChaShareById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			GaChaShare rootAsGaChaShare = GaChaShare.GetRootAsGaChaShare(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GaChaShareById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigGaChaShareById.HandleId, ConfigGaChaShareById.LogPair);
			return new GaChaShare?(rootAsGaChaShare);
		}

		// Token: 0x04001810 RID: 6160
		private const string DB = "db_shareinfo.db";

		// Token: 0x04001811 RID: 6161
		private const string FILE = "f.分享.xlsx";

		// Token: 0x04001812 RID: 6162
		private const string TABLE = "GaChaShare";

		// Token: 0x04001813 RID: 6163
		private const string COMMAND = "select BinData from `GaChaShare` where Id=?";

		// Token: 0x04001814 RID: 6164
		private const string KEY_PREFIX = "GaChaShareById";

		// Token: 0x04001815 RID: 6165
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001816 RID: 6166
		private static int HandleId;
	}
}
