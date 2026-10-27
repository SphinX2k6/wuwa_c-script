using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000602 RID: 1538
	public class ConfigNewTowerParamByCycleId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600241C RID: 9244 RVA: 0x00125BDF File Offset: 0x00123DDF
		static ConfigNewTowerParamByCycleId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigNewTowerParamByCycleId.CreateStaticDefaultValue), new Action(ConfigNewTowerParamByCycleId.ResetStaticDefaultValue));
		}

		// Token: 0x0600241D RID: 9245 RVA: 0x00125C00 File Offset: 0x00123E00
		public static void CreateStaticDefaultValue()
		{
			ConfigNewTowerParamByCycleId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigNewTowerParamByCycleId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_newtower.db"),
				new ValueTuple<string, object>("文件", "x.3.0新爬塔.xlsx"),
				new ValueTuple<string, object>("表名", "NewTowerParam"),
				new ValueTuple<string, object>("语句", "select BinData from `NewTowerParam` where CycleId=?")
			});
		}

		// Token: 0x0600241E RID: 9246 RVA: 0x00125C7F File Offset: 0x00123E7F
		public static void ResetStaticDefaultValue()
		{
			ConfigNewTowerParamByCycleId.LogPair = null;
			ConfigNewTowerParamByCycleId.HandleId = 0;
		}

		// Token: 0x0600241F RID: 9247 RVA: 0x00125C8D File Offset: 0x00123E8D
		public static void Init()
		{
			ConfigNewTowerParamByCycleId.HandleId = ConfigCommon.InitDataStatement(ConfigNewTowerParamByCycleId.HandleId, "db_newtower.db", "select BinData from `NewTowerParam` where CycleId=?");
		}

		// Token: 0x06002420 RID: 9248 RVA: 0x00125CA8 File Offset: 0x00123EA8
		public static NewTowerParam? GetConfig(int p0CycleId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigNewTowerParamByCycleId.HandleId, ConfigNewTowerParamByCycleId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewTowerParamByCycleId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0CycleId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new NewTowerParam?(NewTowerParam.GetRootAsNewTowerParam(configBuffer));
				}
			}
			ConfigNewTowerParamByCycleId.LogPair.Clear();
			ConfigNewTowerParamByCycleId.LogPair.Add(new ValueTuple<string, object>("CycleId", p0CycleId));
			if (!ConfigCommon.BindInt(ConfigNewTowerParamByCycleId.HandleId, 1, p0CycleId, ConfigNewTowerParamByCycleId.LogPair) || ConfigCommon.Step(ConfigNewTowerParamByCycleId.HandleId, true, ConfigNewTowerParamByCycleId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigNewTowerParamByCycleId.HandleId, ConfigNewTowerParamByCycleId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigNewTowerParamByCycleId.HandleId, 0, ConfigNewTowerParamByCycleId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigNewTowerParamByCycleId.HandleId, ConfigNewTowerParamByCycleId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			NewTowerParam rootAsNewTowerParam = NewTowerParam.GetRootAsNewTowerParam(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("NewTowerParamByCycleId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0CycleId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigNewTowerParamByCycleId.HandleId, ConfigNewTowerParamByCycleId.LogPair);
			return new NewTowerParam?(rootAsNewTowerParam);
		}

		// Token: 0x040029F4 RID: 10740
		private const string DB = "db_newtower.db";

		// Token: 0x040029F5 RID: 10741
		private const string FILE = "x.3.0新爬塔.xlsx";

		// Token: 0x040029F6 RID: 10742
		private const string TABLE = "NewTowerParam";

		// Token: 0x040029F7 RID: 10743
		private const string COMMAND = "select BinData from `NewTowerParam` where CycleId=?";

		// Token: 0x040029F8 RID: 10744
		private const string KEY_PREFIX = "NewTowerParamByCycleId";

		// Token: 0x040029F9 RID: 10745
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040029FA RID: 10746
		private static int HandleId;
	}
}
