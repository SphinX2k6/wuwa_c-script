using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200062A RID: 1578
	public class ConfigOnlineMotorLevelById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600250C RID: 9484 RVA: 0x0012B277 File Offset: 0x00129477
		static ConfigOnlineMotorLevelById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigOnlineMotorLevelById.CreateStaticDefaultValue), new Action(ConfigOnlineMotorLevelById.ResetStaticDefaultValue));
		}

		// Token: 0x0600250D RID: 9485 RVA: 0x0012B298 File Offset: 0x00129498
		public static void CreateStaticDefaultValue()
		{
			ConfigOnlineMotorLevelById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigOnlineMotorLevelById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db.onlinemotor.db"),
				new ValueTuple<string, object>("文件", "l.联机摩托跑酷.xlsx"),
				new ValueTuple<string, object>("表名", "OnlineMotorLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `OnlineMotorLevel` where Id=?")
			});
		}

		// Token: 0x0600250E RID: 9486 RVA: 0x0012B317 File Offset: 0x00129517
		public static void ResetStaticDefaultValue()
		{
			ConfigOnlineMotorLevelById.LogPair = null;
			ConfigOnlineMotorLevelById.HandleId = 0;
		}

		// Token: 0x0600250F RID: 9487 RVA: 0x0012B325 File Offset: 0x00129525
		public static void Init()
		{
			ConfigOnlineMotorLevelById.HandleId = ConfigCommon.InitDataStatement(ConfigOnlineMotorLevelById.HandleId, "db.onlinemotor.db", "select BinData from `OnlineMotorLevel` where Id=?");
		}

		// Token: 0x06002510 RID: 9488 RVA: 0x0012B340 File Offset: 0x00129540
		public static OnlineMotorLevel? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigOnlineMotorLevelById.HandleId, ConfigOnlineMotorLevelById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("OnlineMotorLevelById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new OnlineMotorLevel?(OnlineMotorLevel.GetRootAsOnlineMotorLevel(configBuffer));
				}
			}
			ConfigOnlineMotorLevelById.LogPair.Clear();
			ConfigOnlineMotorLevelById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigOnlineMotorLevelById.HandleId, 1, p0Id, ConfigOnlineMotorLevelById.LogPair) || ConfigCommon.Step(ConfigOnlineMotorLevelById.HandleId, true, ConfigOnlineMotorLevelById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigOnlineMotorLevelById.HandleId, ConfigOnlineMotorLevelById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigOnlineMotorLevelById.HandleId, 0, ConfigOnlineMotorLevelById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigOnlineMotorLevelById.HandleId, ConfigOnlineMotorLevelById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			OnlineMotorLevel rootAsOnlineMotorLevel = OnlineMotorLevel.GetRootAsOnlineMotorLevel(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("OnlineMotorLevelById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigOnlineMotorLevelById.HandleId, ConfigOnlineMotorLevelById.LogPair);
			return new OnlineMotorLevel?(rootAsOnlineMotorLevel);
		}

		// Token: 0x04002B0C RID: 11020
		private const string DB = "db.onlinemotor.db";

		// Token: 0x04002B0D RID: 11021
		private const string FILE = "l.联机摩托跑酷.xlsx";

		// Token: 0x04002B0E RID: 11022
		private const string TABLE = "OnlineMotorLevel";

		// Token: 0x04002B0F RID: 11023
		private const string COMMAND = "select BinData from `OnlineMotorLevel` where Id=?";

		// Token: 0x04002B10 RID: 11024
		private const string KEY_PREFIX = "OnlineMotorLevelById";

		// Token: 0x04002B11 RID: 11025
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002B12 RID: 11026
		private static int HandleId;
	}
}
