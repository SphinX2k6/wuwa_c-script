using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A82 RID: 2690
	public class ConfigSurvivorsTaskById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003F20 RID: 16160 RVA: 0x001C1B83 File Offset: 0x001BFD83
		static ConfigSurvivorsTaskById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSurvivorsTaskById.CreateStaticDefaultValue), new Action(ConfigSurvivorsTaskById.ResetStaticDefaultValue));
		}

		// Token: 0x06003F21 RID: 16161 RVA: 0x001C1BA4 File Offset: 0x001BFDA4
		public static void CreateStaticDefaultValue()
		{
			ConfigSurvivorsTaskById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSurvivorsTaskById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_survivors.db"),
				new ValueTuple<string, object>("文件", "x.幸存者_活动.xlsx"),
				new ValueTuple<string, object>("表名", "SurvivorsTask"),
				new ValueTuple<string, object>("语句", "select BinData from `SurvivorsTask` where Id=?")
			});
		}

		// Token: 0x06003F22 RID: 16162 RVA: 0x001C1C23 File Offset: 0x001BFE23
		public static void ResetStaticDefaultValue()
		{
			ConfigSurvivorsTaskById.LogPair = null;
			ConfigSurvivorsTaskById.HandleId = 0;
		}

		// Token: 0x06003F23 RID: 16163 RVA: 0x001C1C31 File Offset: 0x001BFE31
		public static void Init()
		{
			ConfigSurvivorsTaskById.HandleId = ConfigCommon.InitDataStatement(ConfigSurvivorsTaskById.HandleId, "db_survivors.db", "select BinData from `SurvivorsTask` where Id=?");
		}

		// Token: 0x06003F24 RID: 16164 RVA: 0x001C1C4C File Offset: 0x001BFE4C
		public static SurvivorsTask? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSurvivorsTaskById.HandleId, ConfigSurvivorsTaskById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SurvivorsTaskById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SurvivorsTask?(SurvivorsTask.GetRootAsSurvivorsTask(configBuffer));
				}
			}
			ConfigSurvivorsTaskById.LogPair.Clear();
			ConfigSurvivorsTaskById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSurvivorsTaskById.HandleId, 1, p0Id, ConfigSurvivorsTaskById.LogPair) || ConfigCommon.Step(ConfigSurvivorsTaskById.HandleId, true, ConfigSurvivorsTaskById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSurvivorsTaskById.HandleId, ConfigSurvivorsTaskById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSurvivorsTaskById.HandleId, 0, ConfigSurvivorsTaskById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSurvivorsTaskById.HandleId, ConfigSurvivorsTaskById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SurvivorsTask rootAsSurvivorsTask = SurvivorsTask.GetRootAsSurvivorsTask(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SurvivorsTaskById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSurvivorsTaskById.HandleId, ConfigSurvivorsTaskById.LogPair);
			return new SurvivorsTask?(rootAsSurvivorsTask);
		}

		// Token: 0x04004974 RID: 18804
		private const string DB = "db_survivors.db";

		// Token: 0x04004975 RID: 18805
		private const string FILE = "x.幸存者_活动.xlsx";

		// Token: 0x04004976 RID: 18806
		private const string TABLE = "SurvivorsTask";

		// Token: 0x04004977 RID: 18807
		private const string COMMAND = "select BinData from `SurvivorsTask` where Id=?";

		// Token: 0x04004978 RID: 18808
		private const string KEY_PREFIX = "SurvivorsTaskById";

		// Token: 0x04004979 RID: 18809
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400497A RID: 18810
		private static int HandleId;
	}
}
