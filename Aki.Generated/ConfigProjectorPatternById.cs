using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000763 RID: 1891
	public class ConfigProjectorPatternById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002C63 RID: 11363 RVA: 0x0015428C File Offset: 0x0015248C
		static ConfigProjectorPatternById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigProjectorPatternById.CreateStaticDefaultValue), new Action(ConfigProjectorPatternById.ResetStaticDefaultValue));
		}

		// Token: 0x06002C64 RID: 11364 RVA: 0x001542AC File Offset: 0x001524AC
		public static void CreateStaticDefaultValue()
		{
			ConfigProjectorPatternById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigProjectorPatternById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_projectorpattern.db"),
				new ValueTuple<string, object>("文件", "k.可视化编辑/c.Csv/t.投影仪玩法配置/*.csv*"),
				new ValueTuple<string, object>("表名", "ProjectorPattern"),
				new ValueTuple<string, object>("语句", "select BinData from `ProjectorPattern` where ProjectorPatternId=?")
			});
		}

		// Token: 0x06002C65 RID: 11365 RVA: 0x0015432B File Offset: 0x0015252B
		public static void ResetStaticDefaultValue()
		{
			ConfigProjectorPatternById.LogPair = null;
			ConfigProjectorPatternById.HandleId = 0;
		}

		// Token: 0x06002C66 RID: 11366 RVA: 0x00154339 File Offset: 0x00152539
		public static void Init()
		{
			ConfigProjectorPatternById.HandleId = ConfigCommon.InitDataStatement(ConfigProjectorPatternById.HandleId, "db_projectorpattern.db", "select BinData from `ProjectorPattern` where ProjectorPatternId=?");
		}

		// Token: 0x06002C67 RID: 11367 RVA: 0x00154354 File Offset: 0x00152554
		public static ProjectorPattern? GetConfig(int p0ProjectorPatternId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigProjectorPatternById.HandleId, ConfigProjectorPatternById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ProjectorPatternById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ProjectorPatternId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ProjectorPattern?(ProjectorPattern.GetRootAsProjectorPattern(configBuffer));
				}
			}
			ConfigProjectorPatternById.LogPair.Clear();
			ConfigProjectorPatternById.LogPair.Add(new ValueTuple<string, object>("ProjectorPatternId", p0ProjectorPatternId));
			if (!ConfigCommon.BindInt(ConfigProjectorPatternById.HandleId, 1, p0ProjectorPatternId, ConfigProjectorPatternById.LogPair) || ConfigCommon.Step(ConfigProjectorPatternById.HandleId, true, ConfigProjectorPatternById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigProjectorPatternById.HandleId, ConfigProjectorPatternById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigProjectorPatternById.HandleId, 0, ConfigProjectorPatternById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigProjectorPatternById.HandleId, ConfigProjectorPatternById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ProjectorPattern rootAsProjectorPattern = ProjectorPattern.GetRootAsProjectorPattern(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ProjectorPatternById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ProjectorPatternId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigProjectorPatternById.HandleId, ConfigProjectorPatternById.LogPair);
			return new ProjectorPattern?(rootAsProjectorPattern);
		}

		// Token: 0x0400339B RID: 13211
		private const string DB = "db_projectorpattern.db";

		// Token: 0x0400339C RID: 13212
		private const string FILE = "k.可视化编辑/c.Csv/t.投影仪玩法配置/*.csv*";

		// Token: 0x0400339D RID: 13213
		private const string TABLE = "ProjectorPattern";

		// Token: 0x0400339E RID: 13214
		private const string COMMAND = "select BinData from `ProjectorPattern` where ProjectorPatternId=?";

		// Token: 0x0400339F RID: 13215
		private const string KEY_PREFIX = "ProjectorPatternById";

		// Token: 0x040033A0 RID: 13216
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040033A1 RID: 13217
		private static int HandleId;
	}
}
