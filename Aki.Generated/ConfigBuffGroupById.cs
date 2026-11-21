using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000135 RID: 309
	public class ConfigBuffGroupById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600073F RID: 1855 RVA: 0x00086347 File Offset: 0x00084547
		static ConfigBuffGroupById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigBuffGroupById.CreateStaticDefaultValue), new Action(ConfigBuffGroupById.ResetStaticDefaultValue));
		}

		// Token: 0x06000740 RID: 1856 RVA: 0x00086368 File Offset: 0x00084568
		public static void CreateStaticDefaultValue()
		{
			ConfigBuffGroupById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigBuffGroupById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_buffgroup.db"),
				new ValueTuple<string, object>("文件", "b.Buff分组.xlsx"),
				new ValueTuple<string, object>("表名", "BuffGroup"),
				new ValueTuple<string, object>("语句", "select BinData from `BuffGroup` where Id = ?")
			});
		}

		// Token: 0x06000741 RID: 1857 RVA: 0x000863E7 File Offset: 0x000845E7
		public static void ResetStaticDefaultValue()
		{
			ConfigBuffGroupById.LogPair = null;
			ConfigBuffGroupById.HandleId = 0;
		}

		// Token: 0x06000742 RID: 1858 RVA: 0x000863F5 File Offset: 0x000845F5
		public static void Init()
		{
			ConfigBuffGroupById.HandleId = ConfigCommon.InitDataStatement(ConfigBuffGroupById.HandleId, "db_buffgroup.db", "select BinData from `BuffGroup` where Id = ?");
		}

		// Token: 0x06000743 RID: 1859 RVA: 0x00086410 File Offset: 0x00084610
		public static BuffGroup? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigBuffGroupById.HandleId, ConfigBuffGroupById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BuffGroupById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new BuffGroup?(BuffGroup.GetRootAsBuffGroup(configBuffer));
				}
			}
			ConfigBuffGroupById.LogPair.Clear();
			ConfigBuffGroupById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigBuffGroupById.HandleId, 1, p0Id, ConfigBuffGroupById.LogPair) || ConfigCommon.Step(ConfigBuffGroupById.HandleId, true, ConfigBuffGroupById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigBuffGroupById.HandleId, ConfigBuffGroupById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigBuffGroupById.HandleId, 0, ConfigBuffGroupById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigBuffGroupById.HandleId, ConfigBuffGroupById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			BuffGroup rootAsBuffGroup = BuffGroup.GetRootAsBuffGroup(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("BuffGroupById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigBuffGroupById.HandleId, ConfigBuffGroupById.LogPair);
			return new BuffGroup?(rootAsBuffGroup);
		}

		// Token: 0x04000857 RID: 2135
		private const string DB = "db_buffgroup.db";

		// Token: 0x04000858 RID: 2136
		private const string FILE = "b.Buff分组.xlsx";

		// Token: 0x04000859 RID: 2137
		private const string TABLE = "BuffGroup";

		// Token: 0x0400085A RID: 2138
		private const string COMMAND = "select BinData from `BuffGroup` where Id = ?";

		// Token: 0x0400085B RID: 2139
		private const string KEY_PREFIX = "BuffGroupById";

		// Token: 0x0400085C RID: 2140
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400085D RID: 2141
		private static int HandleId;
	}
}
