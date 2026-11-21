using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005B9 RID: 1465
	public class ConfigMotorFightWaveGroupById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002263 RID: 8803 RVA: 0x0011F88C File Offset: 0x0011DA8C
		static ConfigMotorFightWaveGroupById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorFightWaveGroupById.CreateStaticDefaultValue), new Action(ConfigMotorFightWaveGroupById.ResetStaticDefaultValue));
		}

		// Token: 0x06002264 RID: 8804 RVA: 0x0011F8AC File Offset: 0x0011DAAC
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorFightWaveGroupById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorFightWaveGroupById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motorfight.db"),
				new ValueTuple<string, object>("文件", "m.摩托战斗_局内.xlsx"),
				new ValueTuple<string, object>("表名", "MotorFightWaveGroup"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorFightWaveGroup` where GroupId=?")
			});
		}

		// Token: 0x06002265 RID: 8805 RVA: 0x0011F92B File Offset: 0x0011DB2B
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorFightWaveGroupById.LogPair = null;
			ConfigMotorFightWaveGroupById.HandleId = 0;
		}

		// Token: 0x06002266 RID: 8806 RVA: 0x0011F939 File Offset: 0x0011DB39
		public static void Init()
		{
			ConfigMotorFightWaveGroupById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorFightWaveGroupById.HandleId, "db_motorfight.db", "select BinData from `MotorFightWaveGroup` where GroupId=?");
		}

		// Token: 0x06002267 RID: 8807 RVA: 0x0011F954 File Offset: 0x0011DB54
		public static MotorFightWaveGroup? GetConfig(int p0GroupId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorFightWaveGroupById.HandleId, ConfigMotorFightWaveGroupById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorFightWaveGroupById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MotorFightWaveGroup?(MotorFightWaveGroup.GetRootAsMotorFightWaveGroup(configBuffer));
				}
			}
			ConfigMotorFightWaveGroupById.LogPair.Clear();
			ConfigMotorFightWaveGroupById.LogPair.Add(new ValueTuple<string, object>("GroupId", p0GroupId));
			if (!ConfigCommon.BindInt(ConfigMotorFightWaveGroupById.HandleId, 1, p0GroupId, ConfigMotorFightWaveGroupById.LogPair) || ConfigCommon.Step(ConfigMotorFightWaveGroupById.HandleId, true, ConfigMotorFightWaveGroupById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMotorFightWaveGroupById.HandleId, ConfigMotorFightWaveGroupById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorFightWaveGroupById.HandleId, 0, ConfigMotorFightWaveGroupById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMotorFightWaveGroupById.HandleId, ConfigMotorFightWaveGroupById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MotorFightWaveGroup rootAsMotorFightWaveGroup = MotorFightWaveGroup.GetRootAsMotorFightWaveGroup(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorFightWaveGroupById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMotorFightWaveGroupById.HandleId, ConfigMotorFightWaveGroupById.LogPair);
			return new MotorFightWaveGroup?(rootAsMotorFightWaveGroup);
		}

		// Token: 0x040027F3 RID: 10227
		private const string DB = "db_motorfight.db";

		// Token: 0x040027F4 RID: 10228
		private const string FILE = "m.摩托战斗_局内.xlsx";

		// Token: 0x040027F5 RID: 10229
		private const string TABLE = "MotorFightWaveGroup";

		// Token: 0x040027F6 RID: 10230
		private const string COMMAND = "select BinData from `MotorFightWaveGroup` where GroupId=?";

		// Token: 0x040027F7 RID: 10231
		private const string KEY_PREFIX = "MotorFightWaveGroupById";

		// Token: 0x040027F8 RID: 10232
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040027F9 RID: 10233
		private static int HandleId;
	}
}
