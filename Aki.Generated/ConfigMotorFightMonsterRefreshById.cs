using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005AB RID: 1451
	public class ConfigMotorFightMonsterRefreshById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600220F RID: 8719 RVA: 0x0011D990 File Offset: 0x0011BB90
		static ConfigMotorFightMonsterRefreshById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorFightMonsterRefreshById.CreateStaticDefaultValue), new Action(ConfigMotorFightMonsterRefreshById.ResetStaticDefaultValue));
		}

		// Token: 0x06002210 RID: 8720 RVA: 0x0011D9B0 File Offset: 0x0011BBB0
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorFightMonsterRefreshById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorFightMonsterRefreshById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motorfight.db"),
				new ValueTuple<string, object>("文件", "m.摩托战斗_局内.xlsx"),
				new ValueTuple<string, object>("表名", "MotorFightMonsterRefresh"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorFightMonsterRefresh` where Id=?")
			});
		}

		// Token: 0x06002211 RID: 8721 RVA: 0x0011DA2F File Offset: 0x0011BC2F
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorFightMonsterRefreshById.LogPair = null;
			ConfigMotorFightMonsterRefreshById.HandleId = 0;
		}

		// Token: 0x06002212 RID: 8722 RVA: 0x0011DA3D File Offset: 0x0011BC3D
		public static void Init()
		{
			ConfigMotorFightMonsterRefreshById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorFightMonsterRefreshById.HandleId, "db_motorfight.db", "select BinData from `MotorFightMonsterRefresh` where Id=?");
		}

		// Token: 0x06002213 RID: 8723 RVA: 0x0011DA58 File Offset: 0x0011BC58
		public static MotorFightMonsterRefresh? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorFightMonsterRefreshById.HandleId, ConfigMotorFightMonsterRefreshById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorFightMonsterRefreshById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MotorFightMonsterRefresh?(MotorFightMonsterRefresh.GetRootAsMotorFightMonsterRefresh(configBuffer));
				}
			}
			ConfigMotorFightMonsterRefreshById.LogPair.Clear();
			ConfigMotorFightMonsterRefreshById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMotorFightMonsterRefreshById.HandleId, 1, p0Id, ConfigMotorFightMonsterRefreshById.LogPair) || ConfigCommon.Step(ConfigMotorFightMonsterRefreshById.HandleId, true, ConfigMotorFightMonsterRefreshById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMotorFightMonsterRefreshById.HandleId, ConfigMotorFightMonsterRefreshById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorFightMonsterRefreshById.HandleId, 0, ConfigMotorFightMonsterRefreshById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMotorFightMonsterRefreshById.HandleId, ConfigMotorFightMonsterRefreshById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MotorFightMonsterRefresh rootAsMotorFightMonsterRefresh = MotorFightMonsterRefresh.GetRootAsMotorFightMonsterRefresh(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorFightMonsterRefreshById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMotorFightMonsterRefreshById.HandleId, ConfigMotorFightMonsterRefreshById.LogPair);
			return new MotorFightMonsterRefresh?(rootAsMotorFightMonsterRefresh);
		}

		// Token: 0x04002791 RID: 10129
		private const string DB = "db_motorfight.db";

		// Token: 0x04002792 RID: 10130
		private const string FILE = "m.摩托战斗_局内.xlsx";

		// Token: 0x04002793 RID: 10131
		private const string TABLE = "MotorFightMonsterRefresh";

		// Token: 0x04002794 RID: 10132
		private const string COMMAND = "select BinData from `MotorFightMonsterRefresh` where Id=?";

		// Token: 0x04002795 RID: 10133
		private const string KEY_PREFIX = "MotorFightMonsterRefreshById";

		// Token: 0x04002796 RID: 10134
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002797 RID: 10135
		private static int HandleId;
	}
}
