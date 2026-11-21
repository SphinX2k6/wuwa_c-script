using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003A8 RID: 936
	public class ConfigGiantEntrustById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060015F6 RID: 5622 RVA: 0x000D94BF File Offset: 0x000D76BF
		static ConfigGiantEntrustById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGiantEntrustById.CreateStaticDefaultValue), new Action(ConfigGiantEntrustById.ResetStaticDefaultValue));
		}

		// Token: 0x060015F7 RID: 5623 RVA: 0x000D94E0 File Offset: 0x000D76E0
		public static void CreateStaticDefaultValue()
		{
			ConfigGiantEntrustById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGiantEntrustById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_giant.db"),
				new ValueTuple<string, object>("文件", "j.巨人信物.xlsx"),
				new ValueTuple<string, object>("表名", "GiantEntrust"),
				new ValueTuple<string, object>("语句", "select BinData from `GiantEntrust` where Id=?")
			});
		}

		// Token: 0x060015F8 RID: 5624 RVA: 0x000D955F File Offset: 0x000D775F
		public static void ResetStaticDefaultValue()
		{
			ConfigGiantEntrustById.LogPair = null;
			ConfigGiantEntrustById.HandleId = 0;
		}

		// Token: 0x060015F9 RID: 5625 RVA: 0x000D956D File Offset: 0x000D776D
		public static void Init()
		{
			ConfigGiantEntrustById.HandleId = ConfigCommon.InitDataStatement(ConfigGiantEntrustById.HandleId, "db_giant.db", "select BinData from `GiantEntrust` where Id=?");
		}

		// Token: 0x060015FA RID: 5626 RVA: 0x000D9588 File Offset: 0x000D7788
		public static GiantEntrust? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGiantEntrustById.HandleId, ConfigGiantEntrustById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GiantEntrustById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new GiantEntrust?(GiantEntrust.GetRootAsGiantEntrust(configBuffer));
				}
			}
			ConfigGiantEntrustById.LogPair.Clear();
			ConfigGiantEntrustById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigGiantEntrustById.HandleId, 1, p0Id, ConfigGiantEntrustById.LogPair) || ConfigCommon.Step(ConfigGiantEntrustById.HandleId, true, ConfigGiantEntrustById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigGiantEntrustById.HandleId, ConfigGiantEntrustById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGiantEntrustById.HandleId, 0, ConfigGiantEntrustById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigGiantEntrustById.HandleId, ConfigGiantEntrustById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			GiantEntrust rootAsGiantEntrust = GiantEntrust.GetRootAsGiantEntrust(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GiantEntrustById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigGiantEntrustById.HandleId, ConfigGiantEntrustById.LogPair);
			return new GiantEntrust?(rootAsGiantEntrust);
		}

		// Token: 0x0400197C RID: 6524
		private const string DB = "db_giant.db";

		// Token: 0x0400197D RID: 6525
		private const string FILE = "j.巨人信物.xlsx";

		// Token: 0x0400197E RID: 6526
		private const string TABLE = "GiantEntrust";

		// Token: 0x0400197F RID: 6527
		private const string COMMAND = "select BinData from `GiantEntrust` where Id=?";

		// Token: 0x04001980 RID: 6528
		private const string KEY_PREFIX = "GiantEntrustById";

		// Token: 0x04001981 RID: 6529
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001982 RID: 6530
		private static int HandleId;
	}
}
