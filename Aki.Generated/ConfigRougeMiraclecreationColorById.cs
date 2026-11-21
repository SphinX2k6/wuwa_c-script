using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000923 RID: 2339
	public class ConfigRougeMiraclecreationColorById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060036E5 RID: 14053 RVA: 0x00192DC0 File Offset: 0x00190FC0
		static ConfigRougeMiraclecreationColorById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRougeMiraclecreationColorById.CreateStaticDefaultValue), new Action(ConfigRougeMiraclecreationColorById.ResetStaticDefaultValue));
		}

		// Token: 0x060036E6 RID: 14054 RVA: 0x00192DE0 File Offset: 0x00190FE0
		public static void CreateStaticDefaultValue()
		{
			ConfigRougeMiraclecreationColorById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRougeMiraclecreationColorById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_rogue.db"),
				new ValueTuple<string, object>("文件", "r.肉鸽.xlsx"),
				new ValueTuple<string, object>("表名", "RougeMiraclecreationColor"),
				new ValueTuple<string, object>("语句", "select BinData from `RougeMiraclecreationColor` where Id=?")
			});
		}

		// Token: 0x060036E7 RID: 14055 RVA: 0x00192E5F File Offset: 0x0019105F
		public static void ResetStaticDefaultValue()
		{
			ConfigRougeMiraclecreationColorById.LogPair = null;
			ConfigRougeMiraclecreationColorById.HandleId = 0;
		}

		// Token: 0x060036E8 RID: 14056 RVA: 0x00192E6D File Offset: 0x0019106D
		public static void Init()
		{
			ConfigRougeMiraclecreationColorById.HandleId = ConfigCommon.InitDataStatement(ConfigRougeMiraclecreationColorById.HandleId, "db_rogue.db", "select BinData from `RougeMiraclecreationColor` where Id=?");
		}

		// Token: 0x060036E9 RID: 14057 RVA: 0x00192E88 File Offset: 0x00191088
		public static RougeMiraclecreationColor? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRougeMiraclecreationColorById.HandleId, ConfigRougeMiraclecreationColorById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RougeMiraclecreationColorById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RougeMiraclecreationColor?(RougeMiraclecreationColor.GetRootAsRougeMiraclecreationColor(configBuffer));
				}
			}
			ConfigRougeMiraclecreationColorById.LogPair.Clear();
			ConfigRougeMiraclecreationColorById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRougeMiraclecreationColorById.HandleId, 1, p0Id, ConfigRougeMiraclecreationColorById.LogPair) || ConfigCommon.Step(ConfigRougeMiraclecreationColorById.HandleId, true, ConfigRougeMiraclecreationColorById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRougeMiraclecreationColorById.HandleId, ConfigRougeMiraclecreationColorById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRougeMiraclecreationColorById.HandleId, 0, ConfigRougeMiraclecreationColorById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRougeMiraclecreationColorById.HandleId, ConfigRougeMiraclecreationColorById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RougeMiraclecreationColor rootAsRougeMiraclecreationColor = RougeMiraclecreationColor.GetRootAsRougeMiraclecreationColor(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RougeMiraclecreationColorById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRougeMiraclecreationColorById.HandleId, ConfigRougeMiraclecreationColorById.LogPair);
			return new RougeMiraclecreationColor?(rootAsRougeMiraclecreationColor);
		}

		// Token: 0x04003FDB RID: 16347
		private const string DB = "db_rogue.db";

		// Token: 0x04003FDC RID: 16348
		private const string FILE = "r.肉鸽.xlsx";

		// Token: 0x04003FDD RID: 16349
		private const string TABLE = "RougeMiraclecreationColor";

		// Token: 0x04003FDE RID: 16350
		private const string COMMAND = "select BinData from `RougeMiraclecreationColor` where Id=?";

		// Token: 0x04003FDF RID: 16351
		private const string KEY_PREFIX = "RougeMiraclecreationColorById";

		// Token: 0x04003FE0 RID: 16352
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003FE1 RID: 16353
		private static int HandleId;
	}
}
