using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200031E RID: 798
	public class ConfigFloatingSubtitle3DById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060012B9 RID: 4793 RVA: 0x000C6ECB File Offset: 0x000C50CB
		static ConfigFloatingSubtitle3DById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloatingSubtitle3DById.CreateStaticDefaultValue), new Action(ConfigFloatingSubtitle3DById.ResetStaticDefaultValue));
		}

		// Token: 0x060012BA RID: 4794 RVA: 0x000C6EEC File Offset: 0x000C50EC
		public static void CreateStaticDefaultValue()
		{
			ConfigFloatingSubtitle3DById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFloatingSubtitle3DById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_floatingsubtitle.db"),
				new ValueTuple<string, object>("文件", "p.飘浮字幕.xlsx"),
				new ValueTuple<string, object>("表名", "FloatingSubtitle3D"),
				new ValueTuple<string, object>("语句", "select BinData from `FloatingSubtitle3D` where Id=?")
			});
		}

		// Token: 0x060012BB RID: 4795 RVA: 0x000C6F6B File Offset: 0x000C516B
		public static void ResetStaticDefaultValue()
		{
			ConfigFloatingSubtitle3DById.LogPair = null;
			ConfigFloatingSubtitle3DById.HandleId = 0;
		}

		// Token: 0x060012BC RID: 4796 RVA: 0x000C6F79 File Offset: 0x000C5179
		public static void Init()
		{
			ConfigFloatingSubtitle3DById.HandleId = ConfigCommon.InitDataStatement(ConfigFloatingSubtitle3DById.HandleId, "db_floatingsubtitle.db", "select BinData from `FloatingSubtitle3D` where Id=?");
		}

		// Token: 0x060012BD RID: 4797 RVA: 0x000C6F94 File Offset: 0x000C5194
		public static FloatingSubtitle3D? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFloatingSubtitle3DById.HandleId, ConfigFloatingSubtitle3DById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FloatingSubtitle3DById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FloatingSubtitle3D?(FloatingSubtitle3D.GetRootAsFloatingSubtitle3D(configBuffer));
				}
			}
			ConfigFloatingSubtitle3DById.LogPair.Clear();
			ConfigFloatingSubtitle3DById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFloatingSubtitle3DById.HandleId, 1, p0Id, ConfigFloatingSubtitle3DById.LogPair) || ConfigCommon.Step(ConfigFloatingSubtitle3DById.HandleId, true, ConfigFloatingSubtitle3DById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFloatingSubtitle3DById.HandleId, ConfigFloatingSubtitle3DById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFloatingSubtitle3DById.HandleId, 0, ConfigFloatingSubtitle3DById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFloatingSubtitle3DById.HandleId, ConfigFloatingSubtitle3DById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FloatingSubtitle3D rootAsFloatingSubtitle3D = FloatingSubtitle3D.GetRootAsFloatingSubtitle3D(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FloatingSubtitle3DById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFloatingSubtitle3DById.HandleId, ConfigFloatingSubtitle3DById.LogPair);
			return new FloatingSubtitle3D?(rootAsFloatingSubtitle3D);
		}

		// Token: 0x040015B6 RID: 5558
		private const string DB = "db_floatingsubtitle.db";

		// Token: 0x040015B7 RID: 5559
		private const string FILE = "p.飘浮字幕.xlsx";

		// Token: 0x040015B8 RID: 5560
		private const string TABLE = "FloatingSubtitle3D";

		// Token: 0x040015B9 RID: 5561
		private const string COMMAND = "select BinData from `FloatingSubtitle3D` where Id=?";

		// Token: 0x040015BA RID: 5562
		private const string KEY_PREFIX = "FloatingSubtitle3DById";

		// Token: 0x040015BB RID: 5563
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040015BC RID: 5564
		private static int HandleId;
	}
}
