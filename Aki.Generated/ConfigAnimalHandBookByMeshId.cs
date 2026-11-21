using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000A0 RID: 160
	public class ConfigAnimalHandBookByMeshId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060003C0 RID: 960 RVA: 0x00072438 File Offset: 0x00070638
		static ConfigAnimalHandBookByMeshId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAnimalHandBookByMeshId.CreateStaticDefaultValue), new Action(ConfigAnimalHandBookByMeshId.ResetStaticDefaultValue));
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x00072458 File Offset: 0x00070658
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

		// Token: 0x060003C2 RID: 962 RVA: 0x000724D7 File Offset: 0x000706D7
		public static void ResetStaticDefaultValue()
		{
			ConfigAnimalHandBookByMeshId.LogPair = null;
			ConfigAnimalHandBookByMeshId.HandleId = 0;
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x000724E5 File Offset: 0x000706E5
		public static void Init()
		{
			ConfigAnimalHandBookByMeshId.HandleId = ConfigCommon.InitDataStatement(ConfigAnimalHandBookByMeshId.HandleId, "db_handbook.db", "select BinData from `AnimalHandBook` where MeshId = ?");
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x00072500 File Offset: 0x00070700
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

		// Token: 0x04000444 RID: 1092
		private const string DB = "db_handbook.db";

		// Token: 0x04000445 RID: 1093
		private const string FILE = "t.图鉴系统.xlsx";

		// Token: 0x04000446 RID: 1094
		private const string TABLE = "AnimalHandBook";

		// Token: 0x04000447 RID: 1095
		private const string COMMAND = "select BinData from `AnimalHandBook` where MeshId = ?";

		// Token: 0x04000448 RID: 1096
		private const string KEY_PREFIX = "AnimalHandBookByMeshId";

		// Token: 0x04000449 RID: 1097
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400044A RID: 1098
		private static int HandleId;
	}
}
