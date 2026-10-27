using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200094F RID: 2383
	public class ConfigSkyboxById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060037ED RID: 14317 RVA: 0x00195B00 File Offset: 0x00193D00
		static ConfigSkyboxById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSkyboxById.CreateStaticDefaultValue), new Action(ConfigSkyboxById.ResetStaticDefaultValue));
		}

		// Token: 0x060037EE RID: 14318 RVA: 0x00195B20 File Offset: 0x00193D20
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

		// Token: 0x060037EF RID: 14319 RVA: 0x00195B9F File Offset: 0x00193D9F
		public static void ResetStaticDefaultValue()
		{
			ConfigSkyboxById.LogPair = null;
			ConfigSkyboxById.HandleId = 0;
		}

		// Token: 0x060037F0 RID: 14320 RVA: 0x00195BAD File Offset: 0x00193DAD
		public static void Init()
		{
			ConfigSkyboxById.HandleId = ConfigCommon.InitDataStatement(ConfigSkyboxById.HandleId, "db_skybox.db", "select BinData from `Skybox` where Id=?");
		}

		// Token: 0x060037F1 RID: 14321 RVA: 0x00195BC8 File Offset: 0x00193DC8
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

		// Token: 0x0400410F RID: 16655
		private const string DB = "db_skybox.db";

		// Token: 0x04004110 RID: 16656
		private const string FILE = "k.可视化编辑/c.Csv/t.天空盒配置/*.csv*";

		// Token: 0x04004111 RID: 16657
		private const string TABLE = "Skybox";

		// Token: 0x04004112 RID: 16658
		private const string COMMAND = "select BinData from `Skybox` where Id=?";

		// Token: 0x04004113 RID: 16659
		private const string KEY_PREFIX = "SkyboxById";

		// Token: 0x04004114 RID: 16660
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004115 RID: 16661
		private static int HandleId;
	}
}
