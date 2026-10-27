using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004D6 RID: 1238
	public class ConfigLifePointGroupByGroupId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001D0F RID: 7439 RVA: 0x000FD670 File Offset: 0x000FB870
		static ConfigLifePointGroupByGroupId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLifePointGroupByGroupId.CreateStaticDefaultValue), new Action(ConfigLifePointGroupByGroupId.ResetStaticDefaultValue));
		}

		// Token: 0x06001D10 RID: 7440 RVA: 0x000FD690 File Offset: 0x000FB890
		public static void CreateStaticDefaultValue()
		{
			ConfigLifePointGroupByGroupId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigLifePointGroupByGroupId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_lifepoint.db"),
				new ValueTuple<string, object>("文件", "y.溢彩画.xlsx"),
				new ValueTuple<string, object>("表名", "LifePointGroup"),
				new ValueTuple<string, object>("语句", "select BinData from `LifePointGroup` where GroupId=?")
			});
		}

		// Token: 0x06001D11 RID: 7441 RVA: 0x000FD70F File Offset: 0x000FB90F
		public static void ResetStaticDefaultValue()
		{
			ConfigLifePointGroupByGroupId.LogPair = null;
			ConfigLifePointGroupByGroupId.HandleId = 0;
		}

		// Token: 0x06001D12 RID: 7442 RVA: 0x000FD71D File Offset: 0x000FB91D
		public static void Init()
		{
			ConfigLifePointGroupByGroupId.HandleId = ConfigCommon.InitDataStatement(ConfigLifePointGroupByGroupId.HandleId, "db_lifepoint.db", "select BinData from `LifePointGroup` where GroupId=?");
		}

		// Token: 0x06001D13 RID: 7443 RVA: 0x000FD738 File Offset: 0x000FB938
		public static LifePointGroup? GetConfig(int p0GroupId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigLifePointGroupByGroupId.HandleId, ConfigLifePointGroupByGroupId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("LifePointGroupByGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new LifePointGroup?(LifePointGroup.GetRootAsLifePointGroup(configBuffer));
				}
			}
			ConfigLifePointGroupByGroupId.LogPair.Clear();
			ConfigLifePointGroupByGroupId.LogPair.Add(new ValueTuple<string, object>("GroupId", p0GroupId));
			if (!ConfigCommon.BindInt(ConfigLifePointGroupByGroupId.HandleId, 1, p0GroupId, ConfigLifePointGroupByGroupId.LogPair) || ConfigCommon.Step(ConfigLifePointGroupByGroupId.HandleId, true, ConfigLifePointGroupByGroupId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigLifePointGroupByGroupId.HandleId, ConfigLifePointGroupByGroupId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigLifePointGroupByGroupId.HandleId, 0, ConfigLifePointGroupByGroupId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigLifePointGroupByGroupId.HandleId, ConfigLifePointGroupByGroupId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			LifePointGroup rootAsLifePointGroup = LifePointGroup.GetRootAsLifePointGroup(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("LifePointGroupByGroupId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0GroupId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigLifePointGroupByGroupId.HandleId, ConfigLifePointGroupByGroupId.LogPair);
			return new LifePointGroup?(rootAsLifePointGroup);
		}

		// Token: 0x040021BE RID: 8638
		private const string DB = "db_lifepoint.db";

		// Token: 0x040021BF RID: 8639
		private const string FILE = "y.溢彩画.xlsx";

		// Token: 0x040021C0 RID: 8640
		private const string TABLE = "LifePointGroup";

		// Token: 0x040021C1 RID: 8641
		private const string COMMAND = "select BinData from `LifePointGroup` where GroupId=?";

		// Token: 0x040021C2 RID: 8642
		private const string KEY_PREFIX = "LifePointGroupByGroupId";

		// Token: 0x040021C3 RID: 8643
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040021C4 RID: 8644
		private static int HandleId;
	}
}
