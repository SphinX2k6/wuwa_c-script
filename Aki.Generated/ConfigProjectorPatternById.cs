using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200077D RID: 1917
	public class ConfigProjectorPatternById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002CFF RID: 11519 RVA: 0x0015B198 File Offset: 0x00159398
		static ConfigProjectorPatternById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigProjectorPatternById.CreateStaticDefaultValue), new Action(ConfigProjectorPatternById.ResetStaticDefaultValue));
		}

		// Token: 0x06002D00 RID: 11520 RVA: 0x0015B1B8 File Offset: 0x001593B8
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

		// Token: 0x06002D01 RID: 11521 RVA: 0x0015B237 File Offset: 0x00159437
		public static void ResetStaticDefaultValue()
		{
			ConfigProjectorPatternById.LogPair = null;
			ConfigProjectorPatternById.HandleId = 0;
		}

		// Token: 0x06002D02 RID: 11522 RVA: 0x0015B245 File Offset: 0x00159445
		public static void Init()
		{
			ConfigProjectorPatternById.HandleId = ConfigCommon.InitDataStatement(ConfigProjectorPatternById.HandleId, "db_projectorpattern.db", "select BinData from `ProjectorPattern` where ProjectorPatternId=?");
		}

		// Token: 0x06002D03 RID: 11523 RVA: 0x0015B260 File Offset: 0x00159460
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

		// Token: 0x04003451 RID: 13393
		private const string DB = "db_projectorpattern.db";

		// Token: 0x04003452 RID: 13394
		private const string FILE = "k.可视化编辑/c.Csv/t.投影仪玩法配置/*.csv*";

		// Token: 0x04003453 RID: 13395
		private const string TABLE = "ProjectorPattern";

		// Token: 0x04003454 RID: 13396
		private const string COMMAND = "select BinData from `ProjectorPattern` where ProjectorPatternId=?";

		// Token: 0x04003455 RID: 13397
		private const string KEY_PREFIX = "ProjectorPatternById";

		// Token: 0x04003456 RID: 13398
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003457 RID: 13399
		private static int HandleId;
	}
}
