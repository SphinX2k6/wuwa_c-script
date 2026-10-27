using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009A4 RID: 2468
	public class ConfigSurvivorsRoleEvolveById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060039EC RID: 14828 RVA: 0x001A13A8 File Offset: 0x0019F5A8
		static ConfigSurvivorsRoleEvolveById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSurvivorsRoleEvolveById.CreateStaticDefaultValue), new Action(ConfigSurvivorsRoleEvolveById.ResetStaticDefaultValue));
		}

		// Token: 0x060039ED RID: 14829 RVA: 0x001A13C8 File Offset: 0x0019F5C8
		public static void CreateStaticDefaultValue()
		{
			ConfigSurvivorsRoleEvolveById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSurvivorsRoleEvolveById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_survivors.db"),
				new ValueTuple<string, object>("文件", "x.幸存者_局内.xlsx"),
				new ValueTuple<string, object>("表名", "SurvivorsRoleEvolve"),
				new ValueTuple<string, object>("语句", "select BinData from `SurvivorsRoleEvolve` where Id=?")
			});
		}

		// Token: 0x060039EE RID: 14830 RVA: 0x001A1447 File Offset: 0x0019F647
		public static void ResetStaticDefaultValue()
		{
			ConfigSurvivorsRoleEvolveById.LogPair = null;
			ConfigSurvivorsRoleEvolveById.HandleId = 0;
		}

		// Token: 0x060039EF RID: 14831 RVA: 0x001A1455 File Offset: 0x0019F655
		public static void Init()
		{
			ConfigSurvivorsRoleEvolveById.HandleId = ConfigCommon.InitDataStatement(ConfigSurvivorsRoleEvolveById.HandleId, "db_survivors.db", "select BinData from `SurvivorsRoleEvolve` where Id=?");
		}

		// Token: 0x060039F0 RID: 14832 RVA: 0x001A1470 File Offset: 0x0019F670
		public static SurvivorsRoleEvolve? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSurvivorsRoleEvolveById.HandleId, ConfigSurvivorsRoleEvolveById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SurvivorsRoleEvolveById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SurvivorsRoleEvolve?(SurvivorsRoleEvolve.GetRootAsSurvivorsRoleEvolve(configBuffer));
				}
			}
			ConfigSurvivorsRoleEvolveById.LogPair.Clear();
			ConfigSurvivorsRoleEvolveById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSurvivorsRoleEvolveById.HandleId, 1, p0Id, ConfigSurvivorsRoleEvolveById.LogPair) || ConfigCommon.Step(ConfigSurvivorsRoleEvolveById.HandleId, true, ConfigSurvivorsRoleEvolveById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSurvivorsRoleEvolveById.HandleId, ConfigSurvivorsRoleEvolveById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSurvivorsRoleEvolveById.HandleId, 0, ConfigSurvivorsRoleEvolveById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSurvivorsRoleEvolveById.HandleId, ConfigSurvivorsRoleEvolveById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SurvivorsRoleEvolve rootAsSurvivorsRoleEvolve = SurvivorsRoleEvolve.GetRootAsSurvivorsRoleEvolve(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SurvivorsRoleEvolveById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSurvivorsRoleEvolveById.HandleId, ConfigSurvivorsRoleEvolveById.LogPair);
			return new SurvivorsRoleEvolve?(rootAsSurvivorsRoleEvolve);
		}

		// Token: 0x04004362 RID: 17250
		private const string DB = "db_survivors.db";

		// Token: 0x04004363 RID: 17251
		private const string FILE = "x.幸存者_局内.xlsx";

		// Token: 0x04004364 RID: 17252
		private const string TABLE = "SurvivorsRoleEvolve";

		// Token: 0x04004365 RID: 17253
		private const string COMMAND = "select BinData from `SurvivorsRoleEvolve` where Id=?";

		// Token: 0x04004366 RID: 17254
		private const string KEY_PREFIX = "SurvivorsRoleEvolveById";

		// Token: 0x04004367 RID: 17255
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004368 RID: 17256
		private static int HandleId;
	}
}
