using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000148 RID: 328
	public class ConfigCalabashMeshByMeshId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060007B1 RID: 1969 RVA: 0x00088BE0 File Offset: 0x00086DE0
		static ConfigCalabashMeshByMeshId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCalabashMeshByMeshId.CreateStaticDefaultValue), new Action(ConfigCalabashMeshByMeshId.ResetStaticDefaultValue));
		}

		// Token: 0x060007B2 RID: 1970 RVA: 0x00088C00 File Offset: 0x00086E00
		public static void CreateStaticDefaultValue()
		{
			ConfigCalabashMeshByMeshId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCalabashMeshByMeshId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_calabash.db"),
				new ValueTuple<string, object>("文件", "h.葫芦.xlsx"),
				new ValueTuple<string, object>("表名", "CalabashMesh"),
				new ValueTuple<string, object>("语句", "select BinData from `CalabashMesh` where MeshId=?")
			});
		}

		// Token: 0x060007B3 RID: 1971 RVA: 0x00088C7F File Offset: 0x00086E7F
		public static void ResetStaticDefaultValue()
		{
			ConfigCalabashMeshByMeshId.LogPair = null;
			ConfigCalabashMeshByMeshId.HandleId = 0;
		}

		// Token: 0x060007B4 RID: 1972 RVA: 0x00088C8D File Offset: 0x00086E8D
		public static void Init()
		{
			ConfigCalabashMeshByMeshId.HandleId = ConfigCommon.InitDataStatement(ConfigCalabashMeshByMeshId.HandleId, "db_calabash.db", "select BinData from `CalabashMesh` where MeshId=?");
		}

		// Token: 0x060007B5 RID: 1973 RVA: 0x00088CA8 File Offset: 0x00086EA8
		public static CalabashMesh? GetConfig(int p0MeshId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCalabashMeshByMeshId.HandleId, ConfigCalabashMeshByMeshId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CalabashMeshByMeshId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MeshId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new CalabashMesh?(CalabashMesh.GetRootAsCalabashMesh(configBuffer));
				}
			}
			ConfigCalabashMeshByMeshId.LogPair.Clear();
			ConfigCalabashMeshByMeshId.LogPair.Add(new ValueTuple<string, object>("MeshId", p0MeshId));
			if (!ConfigCommon.BindInt(ConfigCalabashMeshByMeshId.HandleId, 1, p0MeshId, ConfigCalabashMeshByMeshId.LogPair) || ConfigCommon.Step(ConfigCalabashMeshByMeshId.HandleId, true, ConfigCalabashMeshByMeshId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigCalabashMeshByMeshId.HandleId, ConfigCalabashMeshByMeshId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCalabashMeshByMeshId.HandleId, 0, ConfigCalabashMeshByMeshId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigCalabashMeshByMeshId.HandleId, ConfigCalabashMeshByMeshId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			CalabashMesh rootAsCalabashMesh = CalabashMesh.GetRootAsCalabashMesh(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("CalabashMeshByMeshId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MeshId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigCalabashMeshByMeshId.HandleId, ConfigCalabashMeshByMeshId.LogPair);
			return new CalabashMesh?(rootAsCalabashMesh);
		}

		// Token: 0x040008DC RID: 2268
		private const string DB = "db_calabash.db";

		// Token: 0x040008DD RID: 2269
		private const string FILE = "h.葫芦.xlsx";

		// Token: 0x040008DE RID: 2270
		private const string TABLE = "CalabashMesh";

		// Token: 0x040008DF RID: 2271
		private const string COMMAND = "select BinData from `CalabashMesh` where MeshId=?";

		// Token: 0x040008E0 RID: 2272
		private const string KEY_PREFIX = "CalabashMeshByMeshId";

		// Token: 0x040008E1 RID: 2273
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040008E2 RID: 2274
		private static int HandleId;
	}
}
