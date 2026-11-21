using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A78 RID: 2680
	public class ConfigSurvivorsRoleById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003EE4 RID: 16100 RVA: 0x001C04F3 File Offset: 0x001BE6F3
		static ConfigSurvivorsRoleById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSurvivorsRoleById.CreateStaticDefaultValue), new Action(ConfigSurvivorsRoleById.ResetStaticDefaultValue));
		}

		// Token: 0x06003EE5 RID: 16101 RVA: 0x001C0514 File Offset: 0x001BE714
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

		// Token: 0x06003EE6 RID: 16102 RVA: 0x001C0593 File Offset: 0x001BE793
		public static void ResetStaticDefaultValue()
		{
			ConfigSurvivorsRoleById.LogPair = null;
			ConfigSurvivorsRoleById.HandleId = 0;
		}

		// Token: 0x06003EE7 RID: 16103 RVA: 0x001C05A1 File Offset: 0x001BE7A1
		public static void Init()
		{
			ConfigSurvivorsRoleById.HandleId = ConfigCommon.InitDataStatement(ConfigSurvivorsRoleById.HandleId, "db_survivors.db", "select BinData from `SurvivorsRole` where Id=?");
		}

		// Token: 0x06003EE8 RID: 16104 RVA: 0x001C05BC File Offset: 0x001BE7BC
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

		// Token: 0x0400492E RID: 18734
		private const string DB = "db_survivors.db";

		// Token: 0x0400492F RID: 18735
		private const string FILE = "x.幸存者_局内.xlsx";

		// Token: 0x04004930 RID: 18736
		private const string TABLE = "SurvivorsRole";

		// Token: 0x04004931 RID: 18737
		private const string COMMAND = "select BinData from `SurvivorsRole` where Id=?";

		// Token: 0x04004932 RID: 18738
		private const string KEY_PREFIX = "SurvivorsRoleById";

		// Token: 0x04004933 RID: 18739
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004934 RID: 18740
		private static int HandleId;
	}
}
