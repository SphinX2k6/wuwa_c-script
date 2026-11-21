using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200099A RID: 2458
	public class ConfigSkyboxById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060039AF RID: 14767 RVA: 0x001A2D20 File Offset: 0x001A0F20
		static ConfigSkyboxById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSkyboxById.CreateStaticDefaultValue), new Action(ConfigSkyboxById.ResetStaticDefaultValue));
		}

		// Token: 0x060039B0 RID: 14768 RVA: 0x001A2D40 File Offset: 0x001A0F40
		public static void CreateStaticDefaultValue()
		{
			ConfigSkyboxById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSkyboxById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_skybox.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/t.天空盒配置/*.csv*"),
				new ValueTuple<string, object>("表名", "Skybox"),
				new ValueTuple<string, object>("语句", "select BinData from `Skybox` where Id=?")
			});
		}

		// Token: 0x060039B1 RID: 14769 RVA: 0x001A2DBF File Offset: 0x001A0FBF
		public static void ResetStaticDefaultValue()
		{
			ConfigSkyboxById.LogPair = null;
			ConfigSkyboxById.HandleId = 0;
		}

		// Token: 0x060039B2 RID: 14770 RVA: 0x001A2DCD File Offset: 0x001A0FCD
		public static void Init()
		{
			ConfigSkyboxById.HandleId = ConfigCommon.InitDataStatement(ConfigSkyboxById.HandleId, "db_skybox.db", "select BinData from `Skybox` where Id=?");
		}

		// Token: 0x060039B3 RID: 14771 RVA: 0x001A2DE8 File Offset: 0x001A0FE8
		public static Skybox? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSkyboxById.HandleId, ConfigSkyboxById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SkyboxById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new Skybox?(Skybox.GetRootAsSkybox(configBuffer));
				}
			}
			ConfigSkyboxById.LogPair.Clear();
			ConfigSkyboxById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSkyboxById.HandleId, 1, p0Id, ConfigSkyboxById.LogPair) || ConfigCommon.Step(ConfigSkyboxById.HandleId, true, ConfigSkyboxById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSkyboxById.HandleId, ConfigSkyboxById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSkyboxById.HandleId, 0, ConfigSkyboxById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSkyboxById.HandleId, ConfigSkyboxById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			Skybox rootAsSkybox = Skybox.GetRootAsSkybox(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SkyboxById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSkyboxById.HandleId, ConfigSkyboxById.LogPair);
			return new Skybox?(rootAsSkybox);
		}

		// Token: 0x0400431C RID: 17180
		private const string DB = "db_skybox.db";

		// Token: 0x0400431D RID: 17181
		private const string FILE = "k.可视化编辑/c.Csv/t.天空盒配置/*.csv*";

		// Token: 0x0400431E RID: 17182
		private const string TABLE = "Skybox";

		// Token: 0x0400431F RID: 17183
		private const string COMMAND = "select BinData from `Skybox` where Id=?";

		// Token: 0x04004320 RID: 17184
		private const string KEY_PREFIX = "SkyboxById";

		// Token: 0x04004321 RID: 17185
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004322 RID: 17186
		private static int HandleId;
	}
}
