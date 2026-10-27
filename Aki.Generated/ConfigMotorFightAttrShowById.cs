using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000586 RID: 1414
	public class ConfigMotorFightAttrShowById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002131 RID: 8497 RVA: 0x0011518B File Offset: 0x0011338B
		static ConfigMotorFightAttrShowById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorFightAttrShowById.CreateStaticDefaultValue), new Action(ConfigMotorFightAttrShowById.ResetStaticDefaultValue));
		}

		// Token: 0x06002132 RID: 8498 RVA: 0x001151AC File Offset: 0x001133AC
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

		// Token: 0x06002133 RID: 8499 RVA: 0x0011522B File Offset: 0x0011342B
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorFightAttrShowById.LogPair = null;
			ConfigMotorFightAttrShowById.HandleId = 0;
		}

		// Token: 0x06002134 RID: 8500 RVA: 0x00115239 File Offset: 0x00113439
		public static void Init()
		{
			ConfigMotorFightAttrShowById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorFightAttrShowById.HandleId, "db_motorfight.db", "select BinData from `MotorFightAttrShow` where Id=?");
		}

		// Token: 0x06002135 RID: 8501 RVA: 0x00115254 File Offset: 0x00113454
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

		// Token: 0x0400268E RID: 9870
		private const string DB = "db_motorfight.db";

		// Token: 0x0400268F RID: 9871
		private const string FILE = "m.摩托战斗_局外.xlsx";

		// Token: 0x04002690 RID: 9872
		private const string TABLE = "MotorFightAttrShow";

		// Token: 0x04002691 RID: 9873
		private const string COMMAND = "select BinData from `MotorFightAttrShow` where Id=?";

		// Token: 0x04002692 RID: 9874
		private const string KEY_PREFIX = "MotorFightAttrShowById";

		// Token: 0x04002693 RID: 9875
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002694 RID: 9876
		private static int HandleId;
	}
}
