using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005B1 RID: 1457
	public class ConfigMotorFightSubLevelBySubLevelId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002233 RID: 8755 RVA: 0x0011E67C File Offset: 0x0011C87C
		static ConfigMotorFightSubLevelBySubLevelId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorFightSubLevelBySubLevelId.CreateStaticDefaultValue), new Action(ConfigMotorFightSubLevelBySubLevelId.ResetStaticDefaultValue));
		}

		// Token: 0x06002234 RID: 8756 RVA: 0x0011E69C File Offset: 0x0011C89C
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorFightSubLevelBySubLevelId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorFightSubLevelBySubLevelId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motorfight.db"),
				new ValueTuple<string, object>("文件", "m.摩托战斗_局内.xlsx"),
				new ValueTuple<string, object>("表名", "MotorFightSubLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorFightSubLevel` where SubLevelId=?")
			});
		}

		// Token: 0x06002235 RID: 8757 RVA: 0x0011E71B File Offset: 0x0011C91B
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorFightSubLevelBySubLevelId.LogPair = null;
			ConfigMotorFightSubLevelBySubLevelId.HandleId = 0;
		}

		// Token: 0x06002236 RID: 8758 RVA: 0x0011E729 File Offset: 0x0011C929
		public static void Init()
		{
			ConfigMotorFightSubLevelBySubLevelId.HandleId = ConfigCommon.InitDataStatement(ConfigMotorFightSubLevelBySubLevelId.HandleId, "db_motorfight.db", "select BinData from `MotorFightSubLevel` where SubLevelId=?");
		}

		// Token: 0x06002237 RID: 8759 RVA: 0x0011E744 File Offset: 0x0011C944
		public static MotorFightSubLevel? GetConfig(int p0SubLevelId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorFightSubLevelBySubLevelId.HandleId, ConfigMotorFightSubLevelBySubLevelId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorFightSubLevelBySubLevelId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0SubLevelId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MotorFightSubLevel?(MotorFightSubLevel.GetRootAsMotorFightSubLevel(configBuffer));
				}
			}
			ConfigMotorFightSubLevelBySubLevelId.LogPair.Clear();
			ConfigMotorFightSubLevelBySubLevelId.LogPair.Add(new ValueTuple<string, object>("SubLevelId", p0SubLevelId));
			if (!ConfigCommon.BindInt(ConfigMotorFightSubLevelBySubLevelId.HandleId, 1, p0SubLevelId, ConfigMotorFightSubLevelBySubLevelId.LogPair) || ConfigCommon.Step(ConfigMotorFightSubLevelBySubLevelId.HandleId, true, ConfigMotorFightSubLevelBySubLevelId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMotorFightSubLevelBySubLevelId.HandleId, ConfigMotorFightSubLevelBySubLevelId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorFightSubLevelBySubLevelId.HandleId, 0, ConfigMotorFightSubLevelBySubLevelId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMotorFightSubLevelBySubLevelId.HandleId, ConfigMotorFightSubLevelBySubLevelId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MotorFightSubLevel rootAsMotorFightSubLevel = MotorFightSubLevel.GetRootAsMotorFightSubLevel(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorFightSubLevelBySubLevelId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0SubLevelId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMotorFightSubLevelBySubLevelId.HandleId, ConfigMotorFightSubLevelBySubLevelId.LogPair);
			return new MotorFightSubLevel?(rootAsMotorFightSubLevel);
		}

		// Token: 0x040027BB RID: 10171
		private const string DB = "db_motorfight.db";

		// Token: 0x040027BC RID: 10172
		private const string FILE = "m.摩托战斗_局内.xlsx";

		// Token: 0x040027BD RID: 10173
		private const string TABLE = "MotorFightSubLevel";

		// Token: 0x040027BE RID: 10174
		private const string COMMAND = "select BinData from `MotorFightSubLevel` where SubLevelId=?";

		// Token: 0x040027BF RID: 10175
		private const string KEY_PREFIX = "MotorFightSubLevelBySubLevelId";

		// Token: 0x040027C0 RID: 10176
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040027C1 RID: 10177
		private static int HandleId;
	}
}
