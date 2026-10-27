using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000309 RID: 777
	public class ConfigFloatingSubtitle3DById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600123B RID: 4667 RVA: 0x000C09BF File Offset: 0x000BEBBF
		static ConfigFloatingSubtitle3DById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFloatingSubtitle3DById.CreateStaticDefaultValue), new Action(ConfigFloatingSubtitle3DById.ResetStaticDefaultValue));
		}

		// Token: 0x0600123C RID: 4668 RVA: 0x000C09E0 File Offset: 0x000BEBE0
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

		// Token: 0x0600123D RID: 4669 RVA: 0x000C0A5F File Offset: 0x000BEC5F
		public static void ResetStaticDefaultValue()
		{
			ConfigFloatingSubtitle3DById.LogPair = null;
			ConfigFloatingSubtitle3DById.HandleId = 0;
		}

		// Token: 0x0600123E RID: 4670 RVA: 0x000C0A6D File Offset: 0x000BEC6D
		public static void Init()
		{
			ConfigFloatingSubtitle3DById.HandleId = ConfigCommon.InitDataStatement(ConfigFloatingSubtitle3DById.HandleId, "db_floatingsubtitle.db", "select BinData from `FloatingSubtitle3D` where Id=?");
		}

		// Token: 0x0600123F RID: 4671 RVA: 0x000C0A88 File Offset: 0x000BEC88
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

		// Token: 0x04001523 RID: 5411
		private const string DB = "db_floatingsubtitle.db";

		// Token: 0x04001524 RID: 5412
		private const string FILE = "p.飘浮字幕.xlsx";

		// Token: 0x04001525 RID: 5413
		private const string TABLE = "FloatingSubtitle3D";

		// Token: 0x04001526 RID: 5414
		private const string COMMAND = "select BinData from `FloatingSubtitle3D` where Id=?";

		// Token: 0x04001527 RID: 5415
		private const string KEY_PREFIX = "FloatingSubtitle3DById";

		// Token: 0x04001528 RID: 5416
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001529 RID: 5417
		private static int HandleId;
	}
}
