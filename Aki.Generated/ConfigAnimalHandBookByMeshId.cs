using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000098 RID: 152
	public class ConfigAnimalHandBookByMeshId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000390 RID: 912 RVA: 0x0006DB84 File Offset: 0x0006BD84
		static ConfigAnimalHandBookByMeshId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAnimalHandBookByMeshId.CreateStaticDefaultValue), new Action(ConfigAnimalHandBookByMeshId.ResetStaticDefaultValue));
		}

		// Token: 0x06000391 RID: 913 RVA: 0x0006DBA4 File Offset: 0x0006BDA4
		public static void CreateStaticDefaultValue()
		{
			ConfigAnimalHandBookByMeshId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAnimalHandBookByMeshId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_handbook.db"),
				new ValueTuple<string, object>("文件", "t.图鉴系统.xlsx"),
				new ValueTuple<string, object>("表名", "AnimalHandBook"),
				new ValueTuple<string, object>("语句", "select BinData from `AnimalHandBook` where MeshId = ?")
			});
		}

		// Token: 0x06000392 RID: 914 RVA: 0x0006DC23 File Offset: 0x0006BE23
		public static void ResetStaticDefaultValue()
		{
			ConfigAnimalHandBookByMeshId.LogPair = null;
			ConfigAnimalHandBookByMeshId.HandleId = 0;
		}

		// Token: 0x06000393 RID: 915 RVA: 0x0006DC31 File Offset: 0x0006BE31
		public static void Init()
		{
			ConfigAnimalHandBookByMeshId.HandleId = ConfigCommon.InitDataStatement(ConfigAnimalHandBookByMeshId.HandleId, "db_handbook.db", "select BinData from `AnimalHandBook` where MeshId = ?");
		}

		// Token: 0x06000394 RID: 916 RVA: 0x0006DC4C File Offset: 0x0006BE4C
		public static AnimalHandBook? GetConfig(int p0MeshId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAnimalHandBookByMeshId.HandleId, ConfigAnimalHandBookByMeshId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AnimalHandBookByMeshId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MeshId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new AnimalHandBook?(AnimalHandBook.GetRootAsAnimalHandBook(configBuffer));
				}
			}
			ConfigAnimalHandBookByMeshId.LogPair.Clear();
			ConfigAnimalHandBookByMeshId.LogPair.Add(new ValueTuple<string, object>("MeshId", p0MeshId));
			if (!ConfigCommon.BindInt(ConfigAnimalHandBookByMeshId.HandleId, 1, p0MeshId, ConfigAnimalHandBookByMeshId.LogPair) || ConfigCommon.Step(ConfigAnimalHandBookByMeshId.HandleId, true, ConfigAnimalHandBookByMeshId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigAnimalHandBookByMeshId.HandleId, ConfigAnimalHandBookByMeshId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAnimalHandBookByMeshId.HandleId, 0, ConfigAnimalHandBookByMeshId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigAnimalHandBookByMeshId.HandleId, ConfigAnimalHandBookByMeshId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			AnimalHandBook rootAsAnimalHandBook = AnimalHandBook.GetRootAsAnimalHandBook(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("AnimalHandBookByMeshId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MeshId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigAnimalHandBookByMeshId.HandleId, ConfigAnimalHandBookByMeshId.LogPair);
			return new AnimalHandBook?(rootAsAnimalHandBook);
		}

		// Token: 0x0400040C RID: 1036
		private const string DB = "db_handbook.db";

		// Token: 0x0400040D RID: 1037
		private const string FILE = "t.图鉴系统.xlsx";

		// Token: 0x0400040E RID: 1038
		private const string TABLE = "AnimalHandBook";

		// Token: 0x0400040F RID: 1039
		private const string COMMAND = "select BinData from `AnimalHandBook` where MeshId = ?";

		// Token: 0x04000410 RID: 1040
		private const string KEY_PREFIX = "AnimalHandBookByMeshId";

		// Token: 0x04000411 RID: 1041
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000412 RID: 1042
		private static int HandleId;
	}
}
