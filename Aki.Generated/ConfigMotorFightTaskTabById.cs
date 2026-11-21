using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020005B7 RID: 1463
	public class ConfigMotorFightTaskTabById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002257 RID: 8791 RVA: 0x0011F3FB File Offset: 0x0011D5FB
		static ConfigMotorFightTaskTabById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMotorFightTaskTabById.CreateStaticDefaultValue), new Action(ConfigMotorFightTaskTabById.ResetStaticDefaultValue));
		}

		// Token: 0x06002258 RID: 8792 RVA: 0x0011F41C File Offset: 0x0011D61C
		public static void CreateStaticDefaultValue()
		{
			ConfigMotorFightTaskTabById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMotorFightTaskTabById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_motorfight.db"),
				new ValueTuple<string, object>("文件", "m.摩托战斗_局外.xlsx"),
				new ValueTuple<string, object>("表名", "MotorFightTaskTab"),
				new ValueTuple<string, object>("语句", "select BinData from `MotorFightTaskTab` where Id=?")
			});
		}

		// Token: 0x06002259 RID: 8793 RVA: 0x0011F49B File Offset: 0x0011D69B
		public static void ResetStaticDefaultValue()
		{
			ConfigMotorFightTaskTabById.LogPair = null;
			ConfigMotorFightTaskTabById.HandleId = 0;
		}

		// Token: 0x0600225A RID: 8794 RVA: 0x0011F4A9 File Offset: 0x0011D6A9
		public static void Init()
		{
			ConfigMotorFightTaskTabById.HandleId = ConfigCommon.InitDataStatement(ConfigMotorFightTaskTabById.HandleId, "db_motorfight.db", "select BinData from `MotorFightTaskTab` where Id=?");
		}

		// Token: 0x0600225B RID: 8795 RVA: 0x0011F4C4 File Offset: 0x0011D6C4
		public static MotorFightTaskTab? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMotorFightTaskTabById.HandleId, ConfigMotorFightTaskTabById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorFightTaskTabById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new MotorFightTaskTab?(MotorFightTaskTab.GetRootAsMotorFightTaskTab(configBuffer));
				}
			}
			ConfigMotorFightTaskTabById.LogPair.Clear();
			ConfigMotorFightTaskTabById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigMotorFightTaskTabById.HandleId, 1, p0Id, ConfigMotorFightTaskTabById.LogPair) || ConfigCommon.Step(ConfigMotorFightTaskTabById.HandleId, true, ConfigMotorFightTaskTabById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigMotorFightTaskTabById.HandleId, ConfigMotorFightTaskTabById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMotorFightTaskTabById.HandleId, 0, ConfigMotorFightTaskTabById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigMotorFightTaskTabById.HandleId, ConfigMotorFightTaskTabById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			MotorFightTaskTab rootAsMotorFightTaskTab = MotorFightTaskTab.GetRootAsMotorFightTaskTab(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("MotorFightTaskTabById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigMotorFightTaskTabById.HandleId, ConfigMotorFightTaskTabById.LogPair);
			return new MotorFightTaskTab?(rootAsMotorFightTaskTab);
		}

		// Token: 0x040027E5 RID: 10213
		private const string DB = "db_motorfight.db";

		// Token: 0x040027E6 RID: 10214
		private const string FILE = "m.摩托战斗_局外.xlsx";

		// Token: 0x040027E7 RID: 10215
		private const string TABLE = "MotorFightTaskTab";

		// Token: 0x040027E8 RID: 10216
		private const string COMMAND = "select BinData from `MotorFightTaskTab` where Id=?";

		// Token: 0x040027E9 RID: 10217
		private const string KEY_PREFIX = "MotorFightTaskTabById";

		// Token: 0x040027EA RID: 10218
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040027EB RID: 10219
		private static int HandleId;
	}
}
