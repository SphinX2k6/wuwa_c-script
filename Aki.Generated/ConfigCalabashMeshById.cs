using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000138 RID: 312
	public class ConfigCalabashMeshById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000751 RID: 1873 RVA: 0x00083034 File Offset: 0x00081234
		static ConfigCalabashMeshById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCalabashMeshById.CreateStaticDefaultValue), new Action(ConfigCalabashMeshById.ResetStaticDefaultValue));
		}

		// Token: 0x06000752 RID: 1874 RVA: 0x00083054 File Offset: 0x00081254
		public static void CreateStaticDefaultValue()
		{
			ConfigCalabashMeshById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCalabashMeshById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_calabash.db"),
				new ValueTuple<string, object>("文件", "h.葫芦.xlsx"),
				new ValueTuple<string, object>("表名", "CalabashMesh"),
				new ValueTuple<string, object>("语句", "select BinData from `CalabashMesh` where Id=?")
			});
		}

		// Token: 0x06000753 RID: 1875 RVA: 0x000830D3 File Offset: 0x000812D3
		public static void ResetStaticDefaultValue()
		{
			ConfigCalabashMeshById.LogPair = null;
			ConfigCalabashMeshById.HandleId = 0;
		}

		// Token: 0x06000754 RID: 1876 RVA: 0x000830E1 File Offset: 0x000812E1
		public static void Init()
		{
			ConfigCalabashMeshById.HandleId = ConfigCommon.InitDataStatement(ConfigCalabashMeshById.HandleId, "db_calabash.db", "select BinData from `CalabashMesh` where Id=?");
		}

		// Token: 0x06000755 RID: 1877 RVA: 0x000830FC File Offset: 0x000812FC
		public static CalabashMesh? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCalabashMeshById.HandleId, ConfigCalabashMeshById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CalabashMeshById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new CalabashMesh?(CalabashMesh.GetRootAsCalabashMesh(configBuffer));
				}
			}
			ConfigCalabashMeshById.LogPair.Clear();
			ConfigCalabashMeshById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigCalabashMeshById.HandleId, 1, p0Id, ConfigCalabashMeshById.LogPair) || ConfigCommon.Step(ConfigCalabashMeshById.HandleId, true, ConfigCalabashMeshById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigCalabashMeshById.HandleId, ConfigCalabashMeshById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCalabashMeshById.HandleId, 0, ConfigCalabashMeshById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigCalabashMeshById.HandleId, ConfigCalabashMeshById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			CalabashMesh rootAsCalabashMesh = CalabashMesh.GetRootAsCalabashMesh(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CalabashMeshById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigCalabashMeshById.HandleId, ConfigCalabashMeshById.LogPair);
			return new CalabashMesh?(rootAsCalabashMesh);
		}

		// Token: 0x0400086C RID: 2156
		private const string DB = "db_calabash.db";

		// Token: 0x0400086D RID: 2157
		private const string FILE = "h.葫芦.xlsx";

		// Token: 0x0400086E RID: 2158
		private const string TABLE = "CalabashMesh";

		// Token: 0x0400086F RID: 2159
		private const string COMMAND = "select BinData from `CalabashMesh` where Id=?";

		// Token: 0x04000870 RID: 2160
		private const string KEY_PREFIX = "CalabashMeshById";

		// Token: 0x04000871 RID: 2161
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000872 RID: 2162
		private static int HandleId;
	}
}
