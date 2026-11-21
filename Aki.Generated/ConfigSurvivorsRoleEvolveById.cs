using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A79 RID: 2681
	public class ConfigSurvivorsRoleEvolveById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003EEA RID: 16106 RVA: 0x001C073C File Offset: 0x001BE93C
		static ConfigSurvivorsRoleEvolveById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSurvivorsRoleEvolveById.CreateStaticDefaultValue), new Action(ConfigSurvivorsRoleEvolveById.ResetStaticDefaultValue));
		}

		// Token: 0x06003EEB RID: 16107 RVA: 0x001C075C File Offset: 0x001BE95C
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

		// Token: 0x06003EEC RID: 16108 RVA: 0x001C07DB File Offset: 0x001BE9DB
		public static void ResetStaticDefaultValue()
		{
			ConfigSurvivorsRoleEvolveById.LogPair = null;
			ConfigSurvivorsRoleEvolveById.HandleId = 0;
		}

		// Token: 0x06003EED RID: 16109 RVA: 0x001C07E9 File Offset: 0x001BE9E9
		public static void Init()
		{
			ConfigSurvivorsRoleEvolveById.HandleId = ConfigCommon.InitDataStatement(ConfigSurvivorsRoleEvolveById.HandleId, "db_survivors.db", "select BinData from `SurvivorsRoleEvolve` where Id=?");
		}

		// Token: 0x06003EEE RID: 16110 RVA: 0x001C0804 File Offset: 0x001BEA04
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

		// Token: 0x04004935 RID: 18741
		private const string DB = "db_survivors.db";

		// Token: 0x04004936 RID: 18742
		private const string FILE = "x.幸存者_局内.xlsx";

		// Token: 0x04004937 RID: 18743
		private const string TABLE = "SurvivorsRoleEvolve";

		// Token: 0x04004938 RID: 18744
		private const string COMMAND = "select BinData from `SurvivorsRoleEvolve` where Id=?";

		// Token: 0x04004939 RID: 18745
		private const string KEY_PREFIX = "SurvivorsRoleEvolveById";

		// Token: 0x0400493A RID: 18746
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400493B RID: 18747
		private static int HandleId;
	}
}
