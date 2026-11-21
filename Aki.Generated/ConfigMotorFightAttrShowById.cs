using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200059D RID: 1437
	public class ConfigMotorFightAttrShowById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060021BB RID: 8635 RVA: 0x0011BA73 File Offset: 0x00119C73
		static ConfigMotorFightAttrShowById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorFightAttrShowById.CreateStaticDefaultValue), new Action(ConfigMotorFightAttrShowById.ResetStaticDefaultValue));
		}

		// Token: 0x060021BC RID: 8636 RVA: 0x0011BA94 File Offset: 0x00119C94
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorFightAttrShowById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorFightAttrShowById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motorfight.db"),
				new ValueTuple<string, object>("文件", "m.摩托战斗_局外.xlsx"),
				new ValueTuple<string, object>("表名", "MotorFightAttrShow"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorFightAttrShow` where Id=?")
			});
		}

		// Token: 0x060021BD RID: 8637 RVA: 0x0011BB13 File Offset: 0x00119D13
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorFightAttrShowById.LogPair = null;
			ConfigMotorFightAttrShowById.HandleId = 0;
		}

		// Token: 0x060021BE RID: 8638 RVA: 0x0011BB21 File Offset: 0x00119D21
		public static void Init()
		{
			ConfigMotorFightAttrShowById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorFightAttrShowById.HandleId, "db_motorfight.db", "select BinData from `MotorFightAttrShow` where Id=?");
		}

		// Token: 0x060021BF RID: 8639 RVA: 0x0011BB3C File Offset: 0x00119D3C
		public static MotorFightAttrShow? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorFightAttrShowById.HandleId, ConfigMotorFightAttrShowById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorFightAttrShowById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MotorFightAttrShow?(MotorFightAttrShow.GetRootAsMotorFightAttrShow(configBuffer));
				}
			}
			ConfigMotorFightAttrShowById.LogPair.Clear();
			ConfigMotorFightAttrShowById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMotorFightAttrShowById.HandleId, 1, p0Id, ConfigMotorFightAttrShowById.LogPair) || ConfigCommon.Step(ConfigMotorFightAttrShowById.HandleId, true, ConfigMotorFightAttrShowById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMotorFightAttrShowById.HandleId, ConfigMotorFightAttrShowById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorFightAttrShowById.HandleId, 0, ConfigMotorFightAttrShowById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMotorFightAttrShowById.HandleId, ConfigMotorFightAttrShowById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MotorFightAttrShow rootAsMotorFightAttrShow = MotorFightAttrShow.GetRootAsMotorFightAttrShow(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorFightAttrShowById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMotorFightAttrShowById.HandleId, ConfigMotorFightAttrShowById.LogPair);
			return new MotorFightAttrShow?(rootAsMotorFightAttrShow);
		}

		// Token: 0x0400272F RID: 10031
		private const string DB = "db_motorfight.db";

		// Token: 0x04002730 RID: 10032
		private const string FILE = "m.摩托战斗_局外.xlsx";

		// Token: 0x04002731 RID: 10033
		private const string TABLE = "MotorFightAttrShow";

		// Token: 0x04002732 RID: 10034
		private const string COMMAND = "select BinData from `MotorFightAttrShow` where Id=?";

		// Token: 0x04002733 RID: 10035
		private const string KEY_PREFIX = "MotorFightAttrShowById";

		// Token: 0x04002734 RID: 10036
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002735 RID: 10037
		private static int HandleId;
	}
}
