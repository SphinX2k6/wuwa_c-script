using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000960 RID: 2400
	public class ConfigSheriffCriminalByIdentityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003853 RID: 14419 RVA: 0x0019AF14 File Offset: 0x00199114
		static ConfigSheriffCriminalByIdentityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSheriffCriminalByIdentityId.CreateStaticDefaultValue), new Action(ConfigSheriffCriminalByIdentityId.ResetStaticDefaultValue));
		}

		// Token: 0x06003854 RID: 14420 RVA: 0x0019AF34 File Offset: 0x00199134
		public static void CreateStaticDefaultValue()
		{
			ConfigSheriffCriminalByIdentityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSheriffCriminalByIdentityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_sheriff.db"),
				new ValueTuple<string, object>("文件", "m.明慎台系统.xlsx"),
				new ValueTuple<string, object>("表名", "SheriffCriminal"),
				new ValueTuple<string, object>("语句", "select BinData from `SheriffCriminal` where InitIdentityId=?")
			});
		}

		// Token: 0x06003855 RID: 14421 RVA: 0x0019AFB3 File Offset: 0x001991B3
		public static void ResetStaticDefaultValue()
		{
			ConfigSheriffCriminalByIdentityId.LogPair = null;
			ConfigSheriffCriminalByIdentityId.HandleId = 0;
		}

		// Token: 0x06003856 RID: 14422 RVA: 0x0019AFC1 File Offset: 0x001991C1
		public static void Init()
		{
			ConfigSheriffCriminalByIdentityId.HandleId = ConfigCommon.InitDataStatement(ConfigSheriffCriminalByIdentityId.HandleId, "db_sheriff.db", "select BinData from `SheriffCriminal` where InitIdentityId=?");
		}

		// Token: 0x06003857 RID: 14423 RVA: 0x0019AFDC File Offset: 0x001991DC
		[NullableContext(2)]
		public static IReadOnlyList<SheriffCriminal> GetConfigList(int p0InitIdentityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSheriffCriminalByIdentityId.HandleId, ConfigSheriffCriminalByIdentityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SheriffCriminalByIdentityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0InitIdentityId);
				IReadOnlyList<SheriffCriminal> readOnlyList = (IReadOnlyList<SheriffCriminal>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigSheriffCriminalByIdentityId.LogPair.Clear();
			ConfigSheriffCriminalByIdentityId.LogPair.Add(new ValueTuple<string, object>("InitIdentityId", p0InitIdentityId));
			if (!ConfigCommon.BindInt(ConfigSheriffCriminalByIdentityId.HandleId, 1, p0InitIdentityId, ConfigSheriffCriminalByIdentityId.LogPair))
			{
				ConfigCommon.Reset(ConfigSheriffCriminalByIdentityId.HandleId, ConfigSheriffCriminalByIdentityId.LogPair);
				return null;
			}
			List<SheriffCriminal> list = new List<SheriffCriminal>();
			while (ConfigCommon.Step(ConfigSheriffCriminalByIdentityId.HandleId, false, ConfigSheriffCriminalByIdentityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSheriffCriminalByIdentityId.HandleId, 0, ConfigSheriffCriminalByIdentityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSheriffCriminalByIdentityId.HandleId, ConfigSheriffCriminalByIdentityId.LogPair);
					return null;
				}
				SheriffCriminal rootAsSheriffCriminal = SheriffCriminal.GetRootAsSheriffCriminal(new ByteBuffer(item2));
				list.Add(rootAsSheriffCriminal);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SheriffCriminalByIdentityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0InitIdentityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigSheriffCriminalByIdentityId.HandleId, ConfigSheriffCriminalByIdentityId.LogPair);
			return list;
		}

		// Token: 0x04004186 RID: 16774
		private const string DB = "db_sheriff.db";

		// Token: 0x04004187 RID: 16775
		private const string FILE = "m.明慎台系统.xlsx";

		// Token: 0x04004188 RID: 16776
		private const string TABLE = "SheriffCriminal";

		// Token: 0x04004189 RID: 16777
		private const string COMMAND = "select BinData from `SheriffCriminal` where InitIdentityId=?";

		// Token: 0x0400418A RID: 16778
		private const string KEY_PREFIX = "SheriffCriminalByIdentityId";

		// Token: 0x0400418B RID: 16779
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400418C RID: 16780
		private static int HandleId;
	}
}
