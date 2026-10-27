using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008D8 RID: 2264
	public class ConfigRougeMiraclecreationColorById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003523 RID: 13603 RVA: 0x00185BA0 File Offset: 0x00183DA0
		static ConfigRougeMiraclecreationColorById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRougeMiraclecreationColorById.CreateStaticDefaultValue), new Action(ConfigRougeMiraclecreationColorById.ResetStaticDefaultValue));
		}

		// Token: 0x06003524 RID: 13604 RVA: 0x00185BC0 File Offset: 0x00183DC0
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

		// Token: 0x06003525 RID: 13605 RVA: 0x00185C3F File Offset: 0x00183E3F
		public static void ResetStaticDefaultValue()
		{
			ConfigRougeMiraclecreationColorById.LogPair = null;
			ConfigRougeMiraclecreationColorById.HandleId = 0;
		}

		// Token: 0x06003526 RID: 13606 RVA: 0x00185C4D File Offset: 0x00183E4D
		public static void Init()
		{
			ConfigRougeMiraclecreationColorById.HandleId = ConfigCommon.InitDataStatement(ConfigRougeMiraclecreationColorById.HandleId, "db_rogue.db", "select BinData from `RougeMiraclecreationColor` where Id=?");
		}

		// Token: 0x06003527 RID: 13607 RVA: 0x00185C68 File Offset: 0x00183E68
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

		// Token: 0x04003DCE RID: 15822
		private const string DB = "db_rogue.db";

		// Token: 0x04003DCF RID: 15823
		private const string FILE = "r.肉鸽.xlsx";

		// Token: 0x04003DD0 RID: 15824
		private const string TABLE = "RougeMiraclecreationColor";

		// Token: 0x04003DD1 RID: 15825
		private const string COMMAND = "select BinData from `RougeMiraclecreationColor` where Id=?";

		// Token: 0x04003DD2 RID: 15826
		private const string KEY_PREFIX = "RougeMiraclecreationColorById";

		// Token: 0x04003DD3 RID: 15827
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003DD4 RID: 15828
		private static int HandleId;
	}
}
