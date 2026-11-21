using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000147 RID: 327
	public class ConfigCalabashMeshById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060007AB RID: 1963 RVA: 0x00088998 File Offset: 0x00086B98
		static ConfigCalabashMeshById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCalabashMeshById.CreateStaticDefaultValue), new Action(ConfigCalabashMeshById.ResetStaticDefaultValue));
		}

		// Token: 0x060007AC RID: 1964 RVA: 0x000889B8 File Offset: 0x00086BB8
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

		// Token: 0x060007AD RID: 1965 RVA: 0x00088A37 File Offset: 0x00086C37
		public static void ResetStaticDefaultValue()
		{
			ConfigCalabashMeshById.LogPair = null;
			ConfigCalabashMeshById.HandleId = 0;
		}

		// Token: 0x060007AE RID: 1966 RVA: 0x00088A45 File Offset: 0x00086C45
		public static void Init()
		{
			ConfigCalabashMeshById.HandleId = ConfigCommon.InitDataStatement(ConfigCalabashMeshById.HandleId, "db_calabash.db", "select BinData from `CalabashMesh` where Id=?");
		}

		// Token: 0x060007AF RID: 1967 RVA: 0x00088A60 File Offset: 0x00086C60
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

		// Token: 0x040008D5 RID: 2261
		private const string DB = "db_calabash.db";

		// Token: 0x040008D6 RID: 2262
		private const string FILE = "h.葫芦.xlsx";

		// Token: 0x040008D7 RID: 2263
		private const string TABLE = "CalabashMesh";

		// Token: 0x040008D8 RID: 2264
		private const string COMMAND = "select BinData from `CalabashMesh` where Id=?";

		// Token: 0x040008D9 RID: 2265
		private const string KEY_PREFIX = "CalabashMeshById";

		// Token: 0x040008DA RID: 2266
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040008DB RID: 2267
		private static int HandleId;
	}
}
