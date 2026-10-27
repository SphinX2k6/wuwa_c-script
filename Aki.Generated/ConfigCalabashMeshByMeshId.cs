using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000139 RID: 313
	public class ConfigCalabashMeshByMeshId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000757 RID: 1879 RVA: 0x0008327C File Offset: 0x0008147C
		static ConfigCalabashMeshByMeshId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCalabashMeshByMeshId.CreateStaticDefaultValue), new Action(ConfigCalabashMeshByMeshId.ResetStaticDefaultValue));
		}

		// Token: 0x06000758 RID: 1880 RVA: 0x0008329C File Offset: 0x0008149C
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

		// Token: 0x06000759 RID: 1881 RVA: 0x0008331B File Offset: 0x0008151B
		public static void ResetStaticDefaultValue()
		{
			ConfigCalabashMeshByMeshId.LogPair = null;
			ConfigCalabashMeshByMeshId.HandleId = 0;
		}

		// Token: 0x0600075A RID: 1882 RVA: 0x00083329 File Offset: 0x00081529
		public static void Init()
		{
			ConfigCalabashMeshByMeshId.HandleId = ConfigCommon.InitDataStatement(ConfigCalabashMeshByMeshId.HandleId, "db_calabash.db", "select BinData from `CalabashMesh` where MeshId=?");
		}

		// Token: 0x0600075B RID: 1883 RVA: 0x00083344 File Offset: 0x00081544
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

		// Token: 0x04000873 RID: 2163
		private const string DB = "db_calabash.db";

		// Token: 0x04000874 RID: 2164
		private const string FILE = "h.葫芦.xlsx";

		// Token: 0x04000875 RID: 2165
		private const string TABLE = "CalabashMesh";

		// Token: 0x04000876 RID: 2166
		private const string COMMAND = "select BinData from `CalabashMesh` where MeshId=?";

		// Token: 0x04000877 RID: 2167
		private const string KEY_PREFIX = "CalabashMeshByMeshId";

		// Token: 0x04000878 RID: 2168
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000879 RID: 2169
		private static int HandleId;
	}
}
