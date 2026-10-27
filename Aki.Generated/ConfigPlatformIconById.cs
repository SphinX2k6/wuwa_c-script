using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200073E RID: 1854
	public class ConfigPlatformIconById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002B84 RID: 11140 RVA: 0x0014F82F File Offset: 0x0014DA2F
		static ConfigPlatformIconById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigPlatformIconById.CreateStaticDefaultValue), new Action(ConfigPlatformIconById.ResetStaticDefaultValue));
		}

		// Token: 0x06002B85 RID: 11141 RVA: 0x0014F850 File Offset: 0x0014DA50
		public static void CreateStaticDefaultValue()
		{
			ConfigPlatformIconById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigPlatformIconById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_platformicon.db"),
				new ValueTuple<string, object>("文件", "d.多端图标.xlsx"),
				new ValueTuple<string, object>("表名", "PlatformIcon"),
				new ValueTuple<string, object>("语句", "select BinData from `PlatformIcon` where Id=?")
			});
		}

		// Token: 0x06002B86 RID: 11142 RVA: 0x0014F8CF File Offset: 0x0014DACF
		public static void ResetStaticDefaultValue()
		{
			ConfigPlatformIconById.LogPair = null;
			ConfigPlatformIconById.HandleId = 0;
		}

		// Token: 0x06002B87 RID: 11143 RVA: 0x0014F8DD File Offset: 0x0014DADD
		public static void Init()
		{
			ConfigPlatformIconById.HandleId = ConfigCommon.InitDataStatement(ConfigPlatformIconById.HandleId, "db_platformicon.db", "select BinData from `PlatformIcon` where Id=?");
		}

		// Token: 0x06002B88 RID: 11144 RVA: 0x0014F8F8 File Offset: 0x0014DAF8
		public static PlatformIcon? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigPlatformIconById.HandleId, ConfigPlatformIconById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PlatformIconById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new PlatformIcon?(PlatformIcon.GetRootAsPlatformIcon(configBuffer));
				}
			}
			ConfigPlatformIconById.LogPair.Clear();
			ConfigPlatformIconById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigPlatformIconById.HandleId, 1, p0Id, ConfigPlatformIconById.LogPair) || ConfigCommon.Step(ConfigPlatformIconById.HandleId, true, ConfigPlatformIconById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigPlatformIconById.HandleId, ConfigPlatformIconById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigPlatformIconById.HandleId, 0, ConfigPlatformIconById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigPlatformIconById.HandleId, ConfigPlatformIconById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			PlatformIcon rootAsPlatformIcon = PlatformIcon.GetRootAsPlatformIcon(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("PlatformIconById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigPlatformIconById.HandleId, ConfigPlatformIconById.LogPair);
			return new PlatformIcon?(rootAsPlatformIcon);
		}

		// Token: 0x04003298 RID: 12952
		private const string DB = "db_platformicon.db";

		// Token: 0x04003299 RID: 12953
		private const string FILE = "d.多端图标.xlsx";

		// Token: 0x0400329A RID: 12954
		private const string TABLE = "PlatformIcon";

		// Token: 0x0400329B RID: 12955
		private const string COMMAND = "select BinData from `PlatformIcon` where Id=?";

		// Token: 0x0400329C RID: 12956
		private const string KEY_PREFIX = "PlatformIconById";

		// Token: 0x0400329D RID: 12957
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400329E RID: 12958
		private static int HandleId;
	}
}
