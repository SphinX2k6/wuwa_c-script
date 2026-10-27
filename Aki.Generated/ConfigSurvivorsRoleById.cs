using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009A3 RID: 2467
	public class ConfigSurvivorsRoleById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060039E6 RID: 14822 RVA: 0x001A115F File Offset: 0x0019F35F
		static ConfigSurvivorsRoleById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSurvivorsRoleById.CreateStaticDefaultValue), new Action(ConfigSurvivorsRoleById.ResetStaticDefaultValue));
		}

		// Token: 0x060039E7 RID: 14823 RVA: 0x001A1180 File Offset: 0x0019F380
		public static void CreateStaticDefaultValue()
		{
			ConfigSurvivorsRoleById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSurvivorsRoleById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_survivors.db"),
				new ValueTuple<string, object>("文件", "x.幸存者_局内.xlsx"),
				new ValueTuple<string, object>("表名", "SurvivorsRole"),
				new ValueTuple<string, object>("语句", "select BinData from `SurvivorsRole` where Id=?")
			});
		}

		// Token: 0x060039E8 RID: 14824 RVA: 0x001A11FF File Offset: 0x0019F3FF
		public static void ResetStaticDefaultValue()
		{
			ConfigSurvivorsRoleById.LogPair = null;
			ConfigSurvivorsRoleById.HandleId = 0;
		}

		// Token: 0x060039E9 RID: 14825 RVA: 0x001A120D File Offset: 0x0019F40D
		public static void Init()
		{
			ConfigSurvivorsRoleById.HandleId = ConfigCommon.InitDataStatement(ConfigSurvivorsRoleById.HandleId, "db_survivors.db", "select BinData from `SurvivorsRole` where Id=?");
		}

		// Token: 0x060039EA RID: 14826 RVA: 0x001A1228 File Offset: 0x0019F428
		public static SurvivorsRole? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSurvivorsRoleById.HandleId, ConfigSurvivorsRoleById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SurvivorsRoleById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SurvivorsRole?(SurvivorsRole.GetRootAsSurvivorsRole(configBuffer));
				}
			}
			ConfigSurvivorsRoleById.LogPair.Clear();
			ConfigSurvivorsRoleById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSurvivorsRoleById.HandleId, 1, p0Id, ConfigSurvivorsRoleById.LogPair) || ConfigCommon.Step(ConfigSurvivorsRoleById.HandleId, true, ConfigSurvivorsRoleById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSurvivorsRoleById.HandleId, ConfigSurvivorsRoleById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSurvivorsRoleById.HandleId, 0, ConfigSurvivorsRoleById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSurvivorsRoleById.HandleId, ConfigSurvivorsRoleById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SurvivorsRole rootAsSurvivorsRole = SurvivorsRole.GetRootAsSurvivorsRole(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SurvivorsRoleById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSurvivorsRoleById.HandleId, ConfigSurvivorsRoleById.LogPair);
			return new SurvivorsRole?(rootAsSurvivorsRole);
		}

		// Token: 0x0400435B RID: 17243
		private const string DB = "db_survivors.db";

		// Token: 0x0400435C RID: 17244
		private const string FILE = "x.幸存者_局内.xlsx";

		// Token: 0x0400435D RID: 17245
		private const string TABLE = "SurvivorsRole";

		// Token: 0x0400435E RID: 17246
		private const string COMMAND = "select BinData from `SurvivorsRole` where Id=?";

		// Token: 0x0400435F RID: 17247
		private const string KEY_PREFIX = "SurvivorsRoleById";

		// Token: 0x04004360 RID: 17248
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004361 RID: 17249
		private static int HandleId;
	}
}
