using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009E0 RID: 2528
	public class ConfigSolarSchoolForumById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003B54 RID: 15188 RVA: 0x001AC220 File Offset: 0x001AA420
		static ConfigSolarSchoolForumById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolForumById.CreateStaticDefaultValue), new Action(ConfigSolarSchoolForumById.ResetStaticDefaultValue));
		}

		// Token: 0x06003B55 RID: 15189 RVA: 0x001AC240 File Offset: 0x001AA440
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolForumById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolForumById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_剧情.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolForum"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolForum` where Id=?")
			});
		}

		// Token: 0x06003B56 RID: 15190 RVA: 0x001AC2BF File Offset: 0x001AA4BF
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolForumById.LogPair = null;
			ConfigSolarSchoolForumById.HandleId = 0;
		}

		// Token: 0x06003B57 RID: 15191 RVA: 0x001AC2CD File Offset: 0x001AA4CD
		public static void Init()
		{
			ConfigSolarSchoolForumById.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolForumById.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolForum` where Id=?");
		}

		// Token: 0x06003B58 RID: 15192 RVA: 0x001AC2E8 File Offset: 0x001AA4E8
		public static SolarSchoolForum? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolForumById.HandleId, ConfigSolarSchoolForumById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolForumById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SolarSchoolForum?(SolarSchoolForum.GetRootAsSolarSchoolForum(configBuffer));
				}
			}
			ConfigSolarSchoolForumById.LogPair.Clear();
			ConfigSolarSchoolForumById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolForumById.HandleId, 1, p0Id, ConfigSolarSchoolForumById.LogPair) || ConfigCommon.Step(ConfigSolarSchoolForumById.HandleId, true, ConfigSolarSchoolForumById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSolarSchoolForumById.HandleId, ConfigSolarSchoolForumById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolForumById.HandleId, 0, ConfigSolarSchoolForumById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSolarSchoolForumById.HandleId, ConfigSolarSchoolForumById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SolarSchoolForum rootAsSolarSchoolForum = SolarSchoolForum.GetRootAsSolarSchoolForum(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolForumById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSolarSchoolForumById.HandleId, ConfigSolarSchoolForumById.LogPair);
			return new SolarSchoolForum?(rootAsSolarSchoolForum);
		}

		// Token: 0x04004506 RID: 17670
		private const string DB = "db_solarschool.db";

		// Token: 0x04004507 RID: 17671
		private const string FILE = "d.第二索拉_剧情.xlsx";

		// Token: 0x04004508 RID: 17672
		private const string TABLE = "SolarSchoolForum";

		// Token: 0x04004509 RID: 17673
		private const string COMMAND = "select BinData from `SolarSchoolForum` where Id=?";

		// Token: 0x0400450A RID: 17674
		private const string KEY_PREFIX = "SolarSchoolForumById";

		// Token: 0x0400450B RID: 17675
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400450C RID: 17676
		private static int HandleId;
	}
}
