using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000919 RID: 2329
	public class ConfigSheriffMapById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060036A9 RID: 13993 RVA: 0x0018E54F File Offset: 0x0018C74F
		static ConfigSheriffMapById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSheriffMapById.CreateStaticDefaultValue), new Action(ConfigSheriffMapById.ResetStaticDefaultValue));
		}

		// Token: 0x060036AA RID: 13994 RVA: 0x0018E570 File Offset: 0x0018C770
		public static void CreateStaticDefaultValue()
		{
			ConfigSheriffMapById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSheriffMapById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_sheriff.db"),
				new ValueTuple<string, object>("文件", "m.明慎台系统.xlsx"),
				new ValueTuple<string, object>("表名", "SheriffMap"),
				new ValueTuple<string, object>("语句", "select BinData from `SheriffMap` where Id=?")
			});
		}

		// Token: 0x060036AB RID: 13995 RVA: 0x0018E5EF File Offset: 0x0018C7EF
		public static void ResetStaticDefaultValue()
		{
			ConfigSheriffMapById.LogPair = null;
			ConfigSheriffMapById.HandleId = 0;
		}

		// Token: 0x060036AC RID: 13996 RVA: 0x0018E5FD File Offset: 0x0018C7FD
		public static void Init()
		{
			ConfigSheriffMapById.HandleId = ConfigCommon.InitDataStatement(ConfigSheriffMapById.HandleId, "db_sheriff.db", "select BinData from `SheriffMap` where Id=?");
		}

		// Token: 0x060036AD RID: 13997 RVA: 0x0018E618 File Offset: 0x0018C818
		public static SheriffMap? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSheriffMapById.HandleId, ConfigSheriffMapById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SheriffMapById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SheriffMap?(SheriffMap.GetRootAsSheriffMap(configBuffer));
				}
			}
			ConfigSheriffMapById.LogPair.Clear();
			ConfigSheriffMapById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSheriffMapById.HandleId, 1, p0Id, ConfigSheriffMapById.LogPair) || ConfigCommon.Step(ConfigSheriffMapById.HandleId, true, ConfigSheriffMapById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSheriffMapById.HandleId, ConfigSheriffMapById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSheriffMapById.HandleId, 0, ConfigSheriffMapById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSheriffMapById.HandleId, ConfigSheriffMapById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SheriffMap rootAsSheriffMap = SheriffMap.GetRootAsSheriffMap(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SheriffMapById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSheriffMapById.HandleId, ConfigSheriffMapById.LogPair);
			return new SheriffMap?(rootAsSheriffMap);
		}

		// Token: 0x04003F95 RID: 16277
		private const string DB = "db_sheriff.db";

		// Token: 0x04003F96 RID: 16278
		private const string FILE = "m.明慎台系统.xlsx";

		// Token: 0x04003F97 RID: 16279
		private const string TABLE = "SheriffMap";

		// Token: 0x04003F98 RID: 16280
		private const string COMMAND = "select BinData from `SheriffMap` where Id=?";

		// Token: 0x04003F99 RID: 16281
		private const string KEY_PREFIX = "SheriffMapById";

		// Token: 0x04003F9A RID: 16282
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003F9B RID: 16283
		private static int HandleId;
	}
}
