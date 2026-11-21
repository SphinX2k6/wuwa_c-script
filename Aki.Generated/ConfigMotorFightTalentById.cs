using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005B3 RID: 1459
	public class ConfigMotorFightTalentById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600223F RID: 8767 RVA: 0x0011EAFB File Offset: 0x0011CCFB
		static ConfigMotorFightTalentById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorFightTalentById.CreateStaticDefaultValue), new Action(ConfigMotorFightTalentById.ResetStaticDefaultValue));
		}

		// Token: 0x06002240 RID: 8768 RVA: 0x0011EB1C File Offset: 0x0011CD1C
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorFightTalentById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorFightTalentById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motorfight.db"),
				new ValueTuple<string, object>("文件", "m.摩托战斗_局外.xlsx"),
				new ValueTuple<string, object>("表名", "MotorFightTalent"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorFightTalent` where Id=?")
			});
		}

		// Token: 0x06002241 RID: 8769 RVA: 0x0011EB9B File Offset: 0x0011CD9B
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorFightTalentById.LogPair = null;
			ConfigMotorFightTalentById.HandleId = 0;
		}

		// Token: 0x06002242 RID: 8770 RVA: 0x0011EBA9 File Offset: 0x0011CDA9
		public static void Init()
		{
			ConfigMotorFightTalentById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorFightTalentById.HandleId, "db_motorfight.db", "select BinData from `MotorFightTalent` where Id=?");
		}

		// Token: 0x06002243 RID: 8771 RVA: 0x0011EBC4 File Offset: 0x0011CDC4
		public static MotorFightTalent? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorFightTalentById.HandleId, ConfigMotorFightTalentById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorFightTalentById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MotorFightTalent?(MotorFightTalent.GetRootAsMotorFightTalent(configBuffer));
				}
			}
			ConfigMotorFightTalentById.LogPair.Clear();
			ConfigMotorFightTalentById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMotorFightTalentById.HandleId, 1, p0Id, ConfigMotorFightTalentById.LogPair) || ConfigCommon.Step(ConfigMotorFightTalentById.HandleId, true, ConfigMotorFightTalentById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMotorFightTalentById.HandleId, ConfigMotorFightTalentById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorFightTalentById.HandleId, 0, ConfigMotorFightTalentById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMotorFightTalentById.HandleId, ConfigMotorFightTalentById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MotorFightTalent rootAsMotorFightTalent = MotorFightTalent.GetRootAsMotorFightTalent(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorFightTalentById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMotorFightTalentById.HandleId, ConfigMotorFightTalentById.LogPair);
			return new MotorFightTalent?(rootAsMotorFightTalent);
		}

		// Token: 0x040027C9 RID: 10185
		private const string DB = "db_motorfight.db";

		// Token: 0x040027CA RID: 10186
		private const string FILE = "m.摩托战斗_局外.xlsx";

		// Token: 0x040027CB RID: 10187
		private const string TABLE = "MotorFightTalent";

		// Token: 0x040027CC RID: 10188
		private const string COMMAND = "select BinData from `MotorFightTalent` where Id=?";

		// Token: 0x040027CD RID: 10189
		private const string KEY_PREFIX = "MotorFightTalentById";

		// Token: 0x040027CE RID: 10190
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040027CF RID: 10191
		private static int HandleId;
	}
}
