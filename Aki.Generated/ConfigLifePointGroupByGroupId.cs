using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004EC RID: 1260
	public class ConfigLifePointGroupByGroupId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001D93 RID: 7571 RVA: 0x00103DC4 File Offset: 0x00101FC4
		static ConfigLifePointGroupByGroupId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLifePointGroupByGroupId.CreateStaticDefaultValue), new Action(ConfigLifePointGroupByGroupId.ResetStaticDefaultValue));
		}

		// Token: 0x06001D94 RID: 7572 RVA: 0x00103DE4 File Offset: 0x00101FE4
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

		// Token: 0x06001D95 RID: 7573 RVA: 0x00103E63 File Offset: 0x00102063
		public static void ResetStaticDefaultValue()
		{
			ConfigLifePointGroupByGroupId.LogPair = null;
			ConfigLifePointGroupByGroupId.HandleId = 0;
		}

		// Token: 0x06001D96 RID: 7574 RVA: 0x00103E71 File Offset: 0x00102071
		public static void Init()
		{
			ConfigLifePointGroupByGroupId.HandleId = ConfigCommon.InitDataStatement(ConfigLifePointGroupByGroupId.HandleId, "db_lifepoint.db", "select BinData from `LifePointGroup` where GroupId=?");
		}

		// Token: 0x06001D97 RID: 7575 RVA: 0x00103E8C File Offset: 0x0010208C
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

		// Token: 0x04002258 RID: 8792
		private const string DB = "db_lifepoint.db";

		// Token: 0x04002259 RID: 8793
		private const string FILE = "y.溢彩画.xlsx";

		// Token: 0x0400225A RID: 8794
		private const string TABLE = "LifePointGroup";

		// Token: 0x0400225B RID: 8795
		private const string COMMAND = "select BinData from `LifePointGroup` where GroupId=?";

		// Token: 0x0400225C RID: 8796
		private const string KEY_PREFIX = "LifePointGroupByGroupId";

		// Token: 0x0400225D RID: 8797
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400225E RID: 8798
		private static int HandleId;
	}
}
