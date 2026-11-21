using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009E1 RID: 2529
	public class ConfigSolarSchoolForumPostById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003B5A RID: 15194 RVA: 0x001AC468 File Offset: 0x001AA668
		static ConfigSolarSchoolForumPostById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolForumPostById.CreateStaticDefaultValue), new Action(ConfigSolarSchoolForumPostById.ResetStaticDefaultValue));
		}

		// Token: 0x06003B5B RID: 15195 RVA: 0x001AC488 File Offset: 0x001AA688
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolForumPostById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolForumPostById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_剧情.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolForumPost"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolForumPost` where Id=?")
			});
		}

		// Token: 0x06003B5C RID: 15196 RVA: 0x001AC507 File Offset: 0x001AA707
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolForumPostById.LogPair = null;
			ConfigSolarSchoolForumPostById.HandleId = 0;
		}

		// Token: 0x06003B5D RID: 15197 RVA: 0x001AC515 File Offset: 0x001AA715
		public static void Init()
		{
			ConfigSolarSchoolForumPostById.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolForumPostById.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolForumPost` where Id=?");
		}

		// Token: 0x06003B5E RID: 15198 RVA: 0x001AC530 File Offset: 0x001AA730
		public static SolarSchoolForumPost? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolForumPostById.HandleId, ConfigSolarSchoolForumPostById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolForumPostById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SolarSchoolForumPost?(SolarSchoolForumPost.GetRootAsSolarSchoolForumPost(configBuffer));
				}
			}
			ConfigSolarSchoolForumPostById.LogPair.Clear();
			ConfigSolarSchoolForumPostById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolForumPostById.HandleId, 1, p0Id, ConfigSolarSchoolForumPostById.LogPair) || ConfigCommon.Step(ConfigSolarSchoolForumPostById.HandleId, true, ConfigSolarSchoolForumPostById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSolarSchoolForumPostById.HandleId, ConfigSolarSchoolForumPostById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolForumPostById.HandleId, 0, ConfigSolarSchoolForumPostById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSolarSchoolForumPostById.HandleId, ConfigSolarSchoolForumPostById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SolarSchoolForumPost rootAsSolarSchoolForumPost = SolarSchoolForumPost.GetRootAsSolarSchoolForumPost(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolForumPostById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSolarSchoolForumPostById.HandleId, ConfigSolarSchoolForumPostById.LogPair);
			return new SolarSchoolForumPost?(rootAsSolarSchoolForumPost);
		}

		// Token: 0x0400450D RID: 17677
		private const string DB = "db_solarschool.db";

		// Token: 0x0400450E RID: 17678
		private const string FILE = "d.第二索拉_剧情.xlsx";

		// Token: 0x0400450F RID: 17679
		private const string TABLE = "SolarSchoolForumPost";

		// Token: 0x04004510 RID: 17680
		private const string COMMAND = "select BinData from `SolarSchoolForumPost` where Id=?";

		// Token: 0x04004511 RID: 17681
		private const string KEY_PREFIX = "SolarSchoolForumPostById";

		// Token: 0x04004512 RID: 17682
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004513 RID: 17683
		private static int HandleId;
	}
}
