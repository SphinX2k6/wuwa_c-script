using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200031C RID: 796
	public class ConfigFloatingSubtitle2DById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060012AD RID: 4781 RVA: 0x000C6AEF File Offset: 0x000C4CEF
		static ConfigFloatingSubtitle2DById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloatingSubtitle2DById.CreateStaticDefaultValue), new Action(ConfigFloatingSubtitle2DById.ResetStaticDefaultValue));
		}

		// Token: 0x060012AE RID: 4782 RVA: 0x000C6B10 File Offset: 0x000C4D10
		public static void CreateStaticDefaultValue()
		{
			ConfigFloatingSubtitle2DById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFloatingSubtitle2DById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_floatingsubtitle.db"),
				new ValueTuple<string, object>("文件", "p.飘浮字幕.xlsx"),
				new ValueTuple<string, object>("表名", "FloatingSubtitle2D"),
				new ValueTuple<string, object>("语句", "select BinData from `FloatingSubtitle2D` where Id=?")
			});
		}

		// Token: 0x060012AF RID: 4783 RVA: 0x000C6B8F File Offset: 0x000C4D8F
		public static void ResetStaticDefaultValue()
		{
			ConfigFloatingSubtitle2DById.LogPair = null;
			ConfigFloatingSubtitle2DById.HandleId = 0;
		}

		// Token: 0x060012B0 RID: 4784 RVA: 0x000C6B9D File Offset: 0x000C4D9D
		public static void Init()
		{
			ConfigFloatingSubtitle2DById.HandleId = ConfigCommon.InitDataStatement(ConfigFloatingSubtitle2DById.HandleId, "db_floatingsubtitle.db", "select BinData from `FloatingSubtitle2D` where Id=?");
		}

		// Token: 0x060012B1 RID: 4785 RVA: 0x000C6BB8 File Offset: 0x000C4DB8
		public static FloatingSubtitle2D? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigFloatingSubtitle2DById.HandleId, ConfigFloatingSubtitle2DById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FloatingSubtitle2DById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new FloatingSubtitle2D?(FloatingSubtitle2D.GetRootAsFloatingSubtitle2D(configBuffer));
				}
			}
			ConfigFloatingSubtitle2DById.LogPair.Clear();
			ConfigFloatingSubtitle2DById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigFloatingSubtitle2DById.HandleId, 1, p0Id, ConfigFloatingSubtitle2DById.LogPair) || ConfigCommon.Step(ConfigFloatingSubtitle2DById.HandleId, true, ConfigFloatingSubtitle2DById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigFloatingSubtitle2DById.HandleId, ConfigFloatingSubtitle2DById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigFloatingSubtitle2DById.HandleId, 0, ConfigFloatingSubtitle2DById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigFloatingSubtitle2DById.HandleId, ConfigFloatingSubtitle2DById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			FloatingSubtitle2D rootAsFloatingSubtitle2D = FloatingSubtitle2D.GetRootAsFloatingSubtitle2D(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("FloatingSubtitle2DById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigFloatingSubtitle2DById.HandleId, ConfigFloatingSubtitle2DById.LogPair);
			return new FloatingSubtitle2D?(rootAsFloatingSubtitle2D);
		}

		// Token: 0x040015A8 RID: 5544
		private const string DB = "db_floatingsubtitle.db";

		// Token: 0x040015A9 RID: 5545
		private const string FILE = "p.飘浮字幕.xlsx";

		// Token: 0x040015AA RID: 5546
		private const string TABLE = "FloatingSubtitle2D";

		// Token: 0x040015AB RID: 5547
		private const string COMMAND = "select BinData from `FloatingSubtitle2D` where Id=?";

		// Token: 0x040015AC RID: 5548
		private const string KEY_PREFIX = "FloatingSubtitle2DById";

		// Token: 0x040015AD RID: 5549
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040015AE RID: 5550
		private static int HandleId;
	}
}
