using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000649 RID: 1609
	public class ConfigOrnamentById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060025C6 RID: 9670 RVA: 0x00132B0F File Offset: 0x00130D0F
		static ConfigOrnamentById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigOrnamentById.CreateStaticDefaultValue), new Action(ConfigOrnamentById.ResetStaticDefaultValue));
		}

		// Token: 0x060025C7 RID: 9671 RVA: 0x00132B30 File Offset: 0x00130D30
		public static void CreateStaticDefaultValue()
		{
			ConfigOrnamentById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigOrnamentById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_ornament.db"),
				new ValueTuple<string, object>("文件", "s.饰品.xlsx"),
				new ValueTuple<string, object>("表名", "Ornament"),
				new ValueTuple<string, object>("语句", "select BinData from `Ornament` where Id=?")
			});
		}

		// Token: 0x060025C8 RID: 9672 RVA: 0x00132BAF File Offset: 0x00130DAF
		public static void ResetStaticDefaultValue()
		{
			ConfigOrnamentById.LogPair = null;
			ConfigOrnamentById.HandleId = 0;
		}

		// Token: 0x060025C9 RID: 9673 RVA: 0x00132BBD File Offset: 0x00130DBD
		public static void Init()
		{
			ConfigOrnamentById.HandleId = ConfigCommon.InitDataStatement(ConfigOrnamentById.HandleId, "db_ornament.db", "select BinData from `Ornament` where Id=?");
		}

		// Token: 0x060025CA RID: 9674 RVA: 0x00132BD8 File Offset: 0x00130DD8
		public static Ornament? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigOrnamentById.HandleId, ConfigOrnamentById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("OrnamentById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new Ornament?(Ornament.GetRootAsOrnament(configBuffer));
				}
			}
			ConfigOrnamentById.LogPair.Clear();
			ConfigOrnamentById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigOrnamentById.HandleId, 1, p0Id, ConfigOrnamentById.LogPair) || ConfigCommon.Step(ConfigOrnamentById.HandleId, true, ConfigOrnamentById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigOrnamentById.HandleId, ConfigOrnamentById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigOrnamentById.HandleId, 0, ConfigOrnamentById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigOrnamentById.HandleId, ConfigOrnamentById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			Ornament rootAsOrnament = Ornament.GetRootAsOrnament(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("OrnamentById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigOrnamentById.HandleId, ConfigOrnamentById.LogPair);
			return new Ornament?(rootAsOrnament);
		}

		// Token: 0x04002BE5 RID: 11237
		private const string DB = "db_ornament.db";

		// Token: 0x04002BE6 RID: 11238
		private const string FILE = "s.饰品.xlsx";

		// Token: 0x04002BE7 RID: 11239
		private const string TABLE = "Ornament";

		// Token: 0x04002BE8 RID: 11240
		private const string COMMAND = "select BinData from `Ornament` where Id=?";

		// Token: 0x04002BE9 RID: 11241
		private const string KEY_PREFIX = "OrnamentById";

		// Token: 0x04002BEA RID: 11242
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002BEB RID: 11243
		private static int HandleId;
	}
}
